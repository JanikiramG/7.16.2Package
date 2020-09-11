namespace Terrasoft.Mail
{
	using System;
	using System.IO;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using global::Common.Logging;
	using MailBee.ImapMail;
	using MailBee.Mime;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Configuration.FileUpload;
	using Terrasoft.EmailDomain.Interfaces;

	#region Struct: MailMessageParticipants

	public struct MailMessageParticipants
	{

		#region Fields: Public

		public Guid SenderContactId;
		public List<Guid> ToContactIds;
		public List<Guid> CcContactIds;
		public List<Guid> BccContactIds;
		public List<Guid> AllParticipantContactIds;

		#endregion

	}

	#endregion

	#region Class: MailSynchronizer

	[DefaultBinding(typeof(IImapSyncSession))]
	public class MailSynchronizer : IImapSyncSession
	{

		#region Constants: Private

		private const string JobName = "SyncImap";
		private const string SyncJobGroupName = "IMAP";
		private const string SyncProcessName = "SyncImapMail";
		private const string ActivitySchemaName = "Activity";
		private const string ActivityFolderSchemaName = "ActivityFolder";
		private const string ActivityInFolderSchemaName = "ActivityInFolder";
		private const string ActivityStatusSchemaName = "ActivityStatus";
		private const string EmailSendStatusSchemaName = "EmailSendStatus";
		private const string EmailSubfolderTypeCode = "SubEmail";
		private const string MailBoxFolderTypeCode = "MailBox";
		private const string FileTypeCode = "File";
		private const string EmailActivityTypeCode = "Email";

		/// <summary>
		/// <see cref="FlagBasedSinceDateSyncStrategy"/> class factory binding key.
		/// </summary>
		private const string FlagBasedSinceDateSyncStrategyName = "FlagBasedSinceDateSyncStrategy";

		/// <summary>
		/// <see cref="DateBasedSyncStrategy"/> class factory binding key.
		/// </summary>
		private const string DateBasedSyncStrategyName = "DateBasedSyncStrategy";

		/// <summary>
		/// <see cref="UidBasedSyncStrategy"/> class factory binding key.
		/// </summary>
		private const string UidBasedSyncStrategyName = "UidBasedSyncStrategy";

		#endregion

		#region Fields: Private

		private static readonly Guid IncomingMessageTypeId = new Guid("7f9d1f86-f36b-1410-068c-20cf30b39373");
		private static readonly Guid OutcomingMessageTypeId = new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373");
		private static readonly Guid ActivityCategoryId = new Guid("8038a396-7825-e011-8165-00155d043204");
		private Guid EmailSubfolderTypeId;
		private Guid MailBoxFolderTypeId;
		private Dictionary<MailPriority, Guid> PriorityMapping = new Dictionary<MailPriority, Guid>() {
				{MailPriority.None, new Guid("ab96fa02-7fe6-df11-971b-001d60e938c6")},
				{MailPriority.Normal, new Guid("ab96fa02-7fe6-df11-971b-001d60e938c6")},
				{MailPriority.High, new Guid("d625a9fc-7ee6-df11-971b-001d60e938c6")},
				{MailPriority.Highest, new Guid("d625a9fc-7ee6-df11-971b-001d60e938c6")},
				{MailPriority.Low, new Guid("ac96fa02-7fe6-df11-971b-001d60e938c6")},
				{MailPriority.Lowest, new Guid("ac96fa02-7fe6-df11-971b-001d60e938c6")}
			};
		private Guid FinishedActvityStatusId;
		private Guid SendedEmailStatusId;
		private Guid FileTypeId;
		private Dictionary<string, Guid> ActivityParticipantRoles;
		private Guid EmailActivityTypeId;
		private Guid _currentEmailActivityId;
		private MailCredentials _credentials;
		private MailboxSyncSettings _mailboxSyncSettings;
		private static readonly ILog _log = LogManager.GetLogger("Imap");

		/// <summary>
		/// Current synchronization class factory binding key. 
		/// </summary>
		private string _settingsStrategy;

		#endregion

		#region Fields: Protected

		/// <summary>
		/// Activity folders in bpm.
		/// </summary>
		protected Dictionary<string, List<Guid>> _activityFolders;

		/// <summary>
		/// <see cref="UserConnection"/>
		/// </summary>
		protected UserConnection _userConnection;

		/// <summary>
		/// Flag indicates, if used date base strategy.
		/// </summary>
		protected bool _isDateBasedStrategy;

		/// <summary>
		/// Last synchronization date.
		/// </summary>
		protected DateTime _lastSyncDate;

		/// <summary>
		/// Current synchronization start date.
		/// </summary>
		protected DateTime _startSyncDate;

		/// <summary>
		/// <see cref="ImapClient"/> instance.
		/// </summary>
		protected ImapClient _imapClient;

		#endregion

		#region Constructors: Public

		public MailSynchronizer() {
			LocalChangesCount = 0;
			RemoteChangesCount = 0;
			InitSyncSessionId();
		}

		/// <summary>
		/// Initializes a new instance of the class <see cref="TestMailSynchronizer"/>
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="login">Flag indicates the need to log in to the mail server.</param>
		public MailSynchronizer(UserConnection userConnection, MailCredentials credentials, bool login = true) {
			_userConnection = userConnection;
			_credentials = credentials;
			LocalChangesCount = 0;
			RemoteChangesCount = 0;
			if (login) {
				_mailboxSyncSettings = GetMailboxSyncSettings();
			}
			InitMailSynchronizer(userConnection, credentials, login);
			InitSyncSessionId();
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User name not set error message tpl.
		/// </summary>
		protected virtual string LocNoName {
			get {
				return new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
					"LocalizableStrings.LocNoName.Value").ToString();
			}
		}

		/// <summary>
		/// File not loaded error message tpl.
		/// </summary>
		protected virtual string LocFileNotLoaded {
			get {
				return new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
					"LocalizableStrings.LocFileNotLoaded.Value").ToString();
			}
		}

		/// <summary>
		/// <see cref="EmailMessageHelper"/> instance.
		/// </summary>
		private EmailMessageHelper _messageHelper;
		protected virtual EmailMessageHelper MessageHelper {
			get {
				if (_messageHelper == null) {
					var userConnection = new ConstructorArgument("userConnection", _userConnection);
					_messageHelper = ClassFactory.Get<EmailMessageHelper>(userConnection);
				}
				return _messageHelper;
			}
		}

		#endregion

		#region Properties: Public

		public int RemoteChangesCount {
			get;
			private set;
		}

		public int LocalChangesCount {
			get;
			private set;
		}

		/// <summary>
		/// Synchronization session unique identifier.
		/// </summary>
		private string _synsSessionId;
		public string SynsSessionId {
			get {
				return _synsSessionId;
			}
		}

		#endregion

		#region Methods: Private

		#region Custom: Helpers

		/// <summary>
		/// Gets synchronization job name.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="parameters">Synchronization parameters.</param>
		/// <returns>Synchronization job name.</returns>
		private static string GetSyncJobName(UserConnection userConnection,
				IDictionary<string, object> parameters = null) {
			List<string> syncJobNameParts = new List<string>();
			syncJobNameParts.Add(JobName);
			if (parameters != null) {
				object senderEmailAddress;
				if (parameters.TryGetValue("SenderEmailAddress", out senderEmailAddress)) {
					syncJobNameParts.Add(senderEmailAddress.ToString());
				}
			}
			syncJobNameParts.Add(userConnection.CurrentUser.Id.ToString());
			return string.Join("_", syncJobNameParts);
		}

		private IEnumerable<Guid> GetUsersByContacts(IEnumerable<Guid> contactIds) {
			var result = new List<Guid>();
			object[] contactsArray = contactIds.Select<Guid, object>(id => id).ToArray();
			var entitySchemaManager = _userConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var sysAdminUnitSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnit");
			var idQueryColumnName = sysAdminUnitSchemaQuery.AddColumn("Id").Name;
			var filter = sysAdminUnitSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", contactsArray);
			sysAdminUnitSchemaQuery.Filters.Add(filter);
			var sysAdminUnits = sysAdminUnitSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var sysAdminUnit in sysAdminUnits) {
				var id = sysAdminUnit.GetTypedColumnValue<Guid>(idQueryColumnName);
				if (!result.Contains(id)) {
					result.Add(id);
				}
			}
			return result;
		}

		private Guid GetUserByContact(Guid contactId) {
			var sysAdminUnit = new Terrasoft.Configuration.SysAdminUnit(_userConnection);
			if (sysAdminUnit.FetchFromDB("Contact", contactId, false)) {
				return sysAdminUnit.Id;
			}
			return Guid.Empty;
		}

		private Guid GetMailboxActivityFolderIdByName(string folderName) {
			Select afSelect = new Select(_userConnection).Top(1)
				.Column("Id")
				.From("ActivityFolder")
				.Where("Name").IsEqual(Column.Parameter(folderName))
					.And("FolderTypeId").IsEqual(Column.Parameter(FolderConsts.MailboxFolderTypeId)) as Select;
			Guid activityFolderId = afSelect.ExecuteScalar<Guid>();
			return activityFolderId;
		}

		/// <summary>
		/// <see cref="ContactUtilities.GetContactEmailDisplayValue"/>
		/// </summary>
		private string GetContactDisplayNameByEmail(string email, out Guid contactId) {
			return ContactUtilities.GetContactEmailDisplayValue(_userConnection, email, out contactId);
		}

		private Guid GetAccountId(string email) {
			var result = Guid.Empty;
			var accountCommunicationSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "AccountCommunication");
			var accountIdQueryColumnName = accountCommunicationSchemaQuery.AddColumn("Account").Name;
			var filter = accountCommunicationSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Number", email);
			accountCommunicationSchemaQuery.Filters.Add(filter);
			var accountCommunications = accountCommunicationSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var accountCommunication in accountCommunications) {
				result = accountCommunication.GetTypedColumnValue<Guid>("AccountId");
			}
			return result;
		}

		private void EnsureEmailRightsGranted(Guid userId) {
			EntitySchema activitySchema = _userConnection.EntitySchemaManager.GetInstanceByName(ActivitySchemaName);
			DBSecurityEngine dbSecurityEngine = _userConnection.DBSecurityEngine;
			SchemaRecordRightLevels messageRights =
				dbSecurityEngine.GetEntitySchemaRecordRightLevel(userId, activitySchema, _currentEmailActivityId);
			if ((messageRights & SchemaRecordRightLevels.CanRead) != SchemaRecordRightLevels.CanRead) {
				messageRights |= SchemaRecordRightLevels.CanRead;
				dbSecurityEngine.SetEntitySchemaRecordRightLevel(userId, activitySchema, _currentEmailActivityId, messageRights);
			}
		}

		private void EnsureActivityInFolder(Guid emailFolderId) {
			EntitySchema activityInFolderSchema = _userConnection.EntitySchemaManager.GetInstanceByName(ActivityInFolderSchemaName);
			Entity activityInFolder = activityInFolderSchema.CreateEntity(_userConnection);
			var conditions = new Dictionary<string, object>() {
				{"Folder", emailFolderId},
				{"Activity", _currentEmailActivityId}
			};
			if (!activityInFolder.FetchFromDB(conditions, false)) {
				activityInFolder.SetDefColumnValues();
				activityInFolder.SetColumnValue("FolderId", emailFolderId);
				activityInFolder.SetColumnValue("ActivityId", _currentEmailActivityId);
				activityInFolder.Save();
			}
		}

		#endregion

		#region Custom: Activity

		/// <summary>
		/// Adds attachments to activity.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="message">Email message.</param>
		/// <param name="htmlBody">Email body.</param>
		/// <param name="activityFiles">Dictionary of activity files and their content provider methods.</param>
		private void AddAttachmentsToActivity(UserConnection userConnection, MailMessage message, ref string htmlBody,
				Dictionary<Entity, Func<byte[]>> activityFiles) {
			var schema = userConnection.EntitySchemaManager.GetInstanceByName("ActivityFile");
			foreach (Attachment attachment in message.Attachments) {
				Entity file = CreateActivityFile(schema, userConnection);
				file.SetDefColumnValues();
				file.SetColumnValue("ActivityId", _currentEmailActivityId);
				var attName = string.IsNullOrEmpty(attachment.Name) ? attachment.Filename : attachment.Name;
				file.SetColumnValue("Name", string.IsNullOrEmpty(attName) ? LocNoName : ActivityUtils.GetAttachmentName(userConnection, attName));
				file.SetColumnValue("TypeId", FileTypeId);
				file.SetColumnValue("Inline", attachment.IsInline);
				activityFiles.Add(file, attachment.GetData);
				if (attachment.IsInline || (attachment.AsMimePart.PartType == MailBee.Mime.MimePartType.Image && attachment.IsFile)) {
					var url = string.Format("../rest/FileService/GetFile/{0}/{1}", schema.UId, file.PrimaryColumnValue);
					if (!string.IsNullOrEmpty(htmlBody) && !string.IsNullOrEmpty(attachment.ContentID)) {
						htmlBody = htmlBody.Replace("cid:" + attachment.ContentID, url);
					}
				}
			}
		}

		/// <summary>
		/// Saves error text to <paramref name="file"/> ErrorOnUpload column.
		/// </summary>
		/// <param name="file"><see cref="ActivityFile"/> instance.</param>
		/// <param name="errorText">Error text.</param>
		/// <param name="e">The exception that was thrown.</param>
		private void SaveAttachmentUploadError(Entity file, string errorText, Exception e = null) {
			if (e != null) {
				_log.ErrorFormat("[{0}] Attachment {1} ({2}) load error.", e, _mailboxSyncSettings.SenderEmailAddress,
					file.PrimaryColumnValue, file.GetTypedColumnValue<string>("Name"));
			}
			file.SetColumnValue("Uploaded", false);
			file.SetColumnValue("ErrorOnUpload", errorText);
			file.Save();

		}

		/// <summary>
		/// Uploads activity files data.
		/// </summary>
		/// <param name="userConnection">UserConnection instance.</param>
		/// <param name="activityFiles">Dictionary of activity files and their content provider methods.</param>
		private void UploadActivityFilesData(UserConnection userConnection,
				Dictionary<Entity, Func<byte[]>> activityFiles) {
			var fileRepository = ClassFactory.Get<FileRepository>(new ConstructorArgument("userConnection", userConnection));
			foreach (var activityFile in activityFiles) {
				var file = activityFile.Key;
				var getDataMethod = activityFile.Value;
				try {
					var data = getDataMethod();
					if (data != null && data.Length > 0) {
						var fileEntityInfo = new FileEntityUploadInfo("ActivityFile", file.PrimaryColumnValue,
								file.GetTypedColumnValue<string>("Name")) {
							Content = new MemoryStream(data),
							TotalFileLength = data.Length,
						};
						fileRepository.UploadFile(fileEntityInfo, false);
					} else {
						SaveAttachmentUploadError(file, LocFileNotLoaded);
					}
				} catch (Exception e) {
					SaveAttachmentUploadError(file, LocFileNotLoaded, e);
				}
			}
		}

		private void UpdateActivityReadStatusForCurrentUser(Guid activityId) {
			var update = new Update(_userConnection, "ActivityParticipant")
						.Set("ReadMark", Column.Parameter(true)).Where("ActivityId")
				.IsEqual(Column.Parameter(activityId)).And("ParticipantId")
				.IsEqual(Column.Parameter(_userConnection.CurrentUser.ContactId));
			update.Execute();
		}

		#endregion

		#region Custom: Query

		private void QueryCrmFolders(Guid mailBoxFolderId) {
			_activityFolders = new Dictionary<string, List<Guid>>();
			var activityFolderSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, ActivityFolderSchemaName);
			var idQueryColumnName = activityFolderSchemaQuery.AddColumn("Id").Name;
			var nameQueryColumnName = activityFolderSchemaQuery.AddColumn("Name").Name;
			activityFolderSchemaQuery.Filters.Add(
				activityFolderSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "FolderType", EmailSubfolderTypeId));
			activityFolderSchemaQuery.Filters.Add(
				activityFolderSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Parent", mailBoxFolderId));
			var activityFolders = activityFolderSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityFolder in activityFolders) {
				var id = activityFolder.GetTypedColumnValue<Guid>(idQueryColumnName);
				var name = activityFolder.GetTypedColumnValue<string>(nameQueryColumnName);
				_log.InfoFormat("[{0}] - Folder \"{1}\", ActivityFolderId = \"{2}\" selected from DB for synchronization",
					_mailboxSyncSettings.SenderEmailAddress, name, id);
				if (_activityFolders.ContainsKey(name)) {
					var idList = _activityFolders[name];
					if (!idList.Contains(id)) {
						idList.Add(id);
					}
				} else {
					var idList = new List<Guid>();
					idList.Add(id);
					_activityFolders.Add(name, idList);
				}
				if (!_activityFolders[name].Contains(mailBoxFolderId)) {
					_activityFolders[name].Add(mailBoxFolderId);
				}
			}
			_log.InfoFormat("[{0}] - Total folders for synchronization count \"{1}\"",
				_mailboxSyncSettings.SenderEmailAddress, _activityFolders.Count);
		}

		#endregion

		/// <summary>
		/// Flag indicates if activity is new.
		/// </summary>
		/// <param name="activity">Activity instance.</param>
		/// <param name="isMessageRead">Message read state.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <param name="messageId">Email Message-ID.</param>
		/// <returns>True if activity is new.</returns>
		private bool IsNewActivity(Entity activity, bool isMessageRead, string folderName, string messageId) {
			return !IsUpdateActivity(isMessageRead, activity, folderName, messageId);
		}

		/// <summary>
		/// Returns true if activity updated.
		/// </summary>
		/// <param name="isMessageRead">Message read state.</param>
		/// <param name="activity">Activity instance.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <param name="messageId">Email Message-ID.</param>
		/// <returns>True, if activity updated.</returns>
		private bool IsUpdateActivity(bool isMessageRead, Entity activity, string folderName, string messageId) {
			if (_userConnection.GetIsFeatureEnabled("MailboxRightsForEmail")) {
				return IsActivityExist(activity, folderName, messageId);
			}
			if (IsActivityExist(activity, folderName, messageId)) {
				if (isMessageRead) {
					UpdateActivityReadStatusForCurrentUser(activity.PrimaryColumnValue);
				}
				ActualizeActivityRelations(activity);
				return true;
			}
			return false;
		}

		private void SetCurrentLastSyncDate(string senderEmailAddress) {
			new Update(_userConnection, "MailboxSyncSettings")
				.Set("LastSyncDate", Column.Parameter(_startSyncDate))
				.Set("IsCustomFlagsNotSuported", Column.Parameter(true))
				.Where("SysAdminUnitId").IsEqual(Column.Parameter(_userConnection.CurrentUser.Id))
				.And("SenderEmailAddress").IsEqual(Column.Parameter(senderEmailAddress)).Execute();
			_log.Info(string.Format("[{0}] | Updating LastSyncDate. New value: {1}",
					senderEmailAddress, DateTime.UtcNow.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture)));
		}

		private void UpdateRightsForOutcomingEmail(Activity activity, MailMessageParticipants participants) {
			var senderId = GetUserByContact(participants.SenderContactId);
			var delete = new Delete(_userConnection)
				.From("SysActivityRight")
				.Where("RecordId")
					.IsEqual(Column.Parameter(activity.Id))
					.And("SysAdminUnitId")
					.IsNotEqual(Column.Parameter(senderId)) as Delete;
			delete.Execute();
		}

		/// <summary>
		/// Returns class factory binding key for <paramref name="mailboxSyncSettings"/>.
		/// </summary>
		/// <param name="mailboxSyncSettings"><see cref="MailboxSyncSettings"/> instance.</param>
		/// <returns>Sync strategy class factory binding key.</returns>
		private string GetStrategyName(MailboxSyncSettings mailboxSyncSettings) {
			string strategyName = string.Empty;
			strategyName = _settingsStrategy.IsNullOrEmpty() ? UidBasedSyncStrategyName : _settingsStrategy;
			_log.Info(string.Format("[{0}] | {1} selected.", mailboxSyncSettings.SenderEmailAddress, strategyName));
			return strategyName;
		}

		/// <summary>
		/// Select custom strategy bind key for current <see cref="MailServer"/>.
		/// </summary>
		/// <param name="mailServerId"><see cref="MailServer"/> unique identifier.</param>
		private void QueryStrategyName(Guid mailServerId) {
			var select = new Select(_userConnection).Top(1)
				.Column("Strategy")
				.From("MailServer")
				.Where("Id").IsEqual(Column.Parameter(mailServerId)) as Select;
			_settingsStrategy = select.ExecuteScalar<string>();
		}

		/// <summary>
		/// Sets <see cref="SyncSessionId"/> property value.
		/// </summary>
		private void InitSyncSessionId() {
			_synsSessionId = string.Format("ImapSyncSession_{0}", Guid.NewGuid());
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Sets email activity type uniqueidentifier.
		/// </summary>
		protected virtual void QueryEmailActivityType() {
			var activityTypeSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "ActivityType");
			var idQueryColumnName = activityTypeSchemaQuery.AddColumn("Id").Name;
			var filter = activityTypeSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", EmailActivityTypeCode);
			activityTypeSchemaQuery.Filters.Add(filter);
			var activityTypes = activityTypeSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityType in activityTypes) {
				EmailActivityTypeId = activityType.GetTypedColumnValue<Guid>(idQueryColumnName);
			}
		}

		/// <summary>
		/// Adds roles in activity participant collection.
		/// </summary>
		protected virtual void QueryActivityParticipantRoles() {
			ActivityParticipantRoles = new Dictionary<string, Guid>();
			var activityParticipantRoleSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "ActivityParticipantRole");
			var idQueryColumnName = activityParticipantRoleSchemaQuery.AddColumn("Id").Name;
			var codeQueryColumnName = activityParticipantRoleSchemaQuery.AddColumn("Code").Name;
			var activityParticipantRoles = activityParticipantRoleSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityParticipantRole in activityParticipantRoles) {
				var id = activityParticipantRole.GetTypedColumnValue<Guid>(idQueryColumnName);
				var code = activityParticipantRole.GetTypedColumnValue<string>(codeQueryColumnName);
				ActivityParticipantRoles.Add(code, id);
			}
		}

		/// <summary>
		/// Sets file type unique identifier.
		/// </summary>
		protected virtual void QueryFileTypes() {
			FileTypeId = Terrasoft.WebApp.FileConsts.FileTypeUId;
		}

		/// <summary>
		/// Sets sender email status unique identifier.
		/// </summary>
		protected virtual void QueryActivityStatuses() {
			var activityStatusSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, ActivityStatusSchemaName);
			var idQueryColumnName = activityStatusSchemaQuery.AddColumn("Id").Name;
			var filter = activityStatusSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", "Finished");
			activityStatusSchemaQuery.Filters.Add(filter);
			var activityStatuses = activityStatusSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityStatus in activityStatuses) {
				FinishedActvityStatusId = activityStatus.GetTypedColumnValue<Guid>(idQueryColumnName);
				break;
			}
			var emailSendStatusSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, EmailSendStatusSchemaName);
			idQueryColumnName = emailSendStatusSchemaQuery.AddColumn("Id").Name;
			filter = emailSendStatusSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", "Sended");
			emailSendStatusSchemaQuery.Filters.Add(filter);
			var emailSendStatuses = emailSendStatusSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var emailSendStatus in emailSendStatuses) {
				SendedEmailStatusId = emailSendStatus.GetTypedColumnValue<Guid>(idQueryColumnName);
				break;
			}
		}

		/// <summary>
		/// Sets email folders type unique edentifier.
		/// </summary>
		protected virtual void QueryEmailFolderTypeIds() {
			EmailSubfolderTypeId = FolderConsts.EmailFolderTypeId;
			MailBoxFolderTypeId = FolderConsts.MailboxFolderTypeId;
		}

		/// <summary>
		/// Gets flag indicates if email message is outcoming.
		/// </summary>
		/// <param name="message"><see cref="MailMessage"/> instance.</param>
		/// <returns>True,if email message is outcoming.</returns>
		protected virtual bool GetIsMessageOutcoming(MailMessage message) {
			int lastPointIndex = _credentials.Host.LastIndexOf(".");
			if (lastPointIndex == -1) {
				return false;
			}
			int lastButOnePointIndex = _credentials.Host.Substring(0, lastPointIndex).LastIndexOf(".");
			if (lastButOnePointIndex == -1) {
				return false;
			}
			string hostName = _credentials.Host.Substring(lastButOnePointIndex + 1);
			return message.From.Email == (_credentials.SenderEmailAddress.Contains('@') ?
				_credentials.SenderEmailAddress : string.Concat(_credentials.UserName, "@", hostName));
		}

		/// <summary>
		/// Gets <see cref="MailboxSyncSettings"/> instance by sender email address.
		/// </summary>
		/// <returns><see cref="MailboxSyncSettings"/> instance.</returns>
		protected virtual MailboxSyncSettings GetMailboxSyncSettings() {
			EntitySchema mailboxSynSettingsSchema = _userConnection.EntitySchemaManager.GetInstanceByName("MailboxSyncSettings");
			MailboxSyncSettings syncSettings = (MailboxSyncSettings)mailboxSynSettingsSchema.CreateEntity(_userConnection);
			syncSettings.FetchFromDB("SenderEmailAddress", _credentials.SenderEmailAddress, false);
			if (syncSettings.LastSyncDate != null) {
				syncSettings.LastSyncDate =
					(DateTime)_userConnection.DataValueTypeManager.GetInstanceByName("DateTime").GetValueForLoad(_userConnection,
						syncSettings.LastSyncDate.ToUniversalTime());
			} else {
				syncSettings.LastSyncDate = _userConnection.CurrentUser.GetCurrentDateTime().AddYears(-10);
			}
			QueryStrategyName(syncSettings.GetTypedColumnValue<Guid>("MailServerId"));
			return syncSettings;
		}

		/// <summary>
		/// Sets contacts fields in participants from message.
		/// </summary>
		/// <param name="message"><see cref="MailMessage"/> instance.</param>
		/// <param name="activity"><see cref="Activity"/> instance.</param>
		/// <param name="participants"><see cref="MailMessageParticipants"/> instance.</param>
		protected virtual void SetContactFields(MailMessage message, Activity activity, out MailMessageParticipants participants) {
			participants = new MailMessageParticipants {
				ToContactIds = new List<Guid>(),
				CcContactIds = new List<Guid>(),
				BccContactIds = new List<Guid>(),
				AllParticipantContactIds = new List<Guid>()
			};
			Guid contactId;
			activity.Sender = GetContactDisplayNameByEmail(message.From.Email, out contactId);
			if (contactId != Guid.Empty) {
				participants.AllParticipantContactIds.Add(contactId);
			}
			participants.SenderContactId = contactId;
			var sb = new StringBuilder();
			foreach (EmailAddress mailAddress in message.To) {
				sb.Append(GetContactDisplayNameByEmail(mailAddress.Email, out contactId));
				sb.Append("; ");
				if (!participants.ToContactIds.Contains(contactId)) {
					participants.ToContactIds.Add(contactId);
				}
				if (!participants.AllParticipantContactIds.Contains(contactId)) {
					participants.AllParticipantContactIds.Add(contactId);
				}
			}
			if (sb.Length > 1) {
				sb.Remove(sb.Length - 2, 2);
			}
			activity.Recepient = sb.ToString();
			sb.Clear();
			foreach (EmailAddress mailAddress in message.Cc) {
				sb.Append(GetContactDisplayNameByEmail(mailAddress.Email, out contactId));
				sb.Append("; ");
				if (!participants.CcContactIds.Contains(contactId)) {
					participants.CcContactIds.Add(contactId);
				}
				if (!participants.AllParticipantContactIds.Contains(contactId)) {
					participants.AllParticipantContactIds.Add(contactId);
				}
			}
			if (sb.Length > 1) {
				sb.Remove(sb.Length - 2, 2);
			}
			activity.CopyRecepient = sb.ToString();
			sb.Clear();
			foreach (EmailAddress mailAddress in message.Bcc) {
				sb.Append(GetContactDisplayNameByEmail(mailAddress.Email, out contactId));
				sb.Append("; ");
				if (!participants.BccContactIds.Contains(contactId)) {
					participants.BccContactIds.Add(contactId);
				}
				if (!participants.AllParticipantContactIds.Contains(contactId)) {
					participants.AllParticipantContactIds.Add(contactId);
				}
			}
			if (sb.Length > 1) {
				sb.Remove(sb.Length - 2, 2);
			}
			activity.BlindCopyRecepient = sb.ToString();
		}

		/// <summary>
		/// Sets <see cref="ImapClient"/> instance;
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="mailboxSettingsId">Mailbox settings unique identifier.</param>
		/// <param name="login">Try login when imap client created flag.</param>
		protected virtual void SetImapClient(UserConnection userConnection, MailCredentials credentials, Guid mailboxSettingsId, bool login) {
			SynchronizationErrorHelper helper = SynchronizationErrorHelper.GetInstance(userConnection);
			try {

				_imapClient = new ImapClient(credentials, GetImapErrorMessages(userConnection), userConnection, mailboxSettingsId, login);
				if (login) {
					helper.CleanUpSynchronizationError(_mailboxSyncSettings.SenderEmailAddress);
				}
			} catch (Exception ex) {
				helper.ProcessSynchronizationError(_mailboxSyncSettings.SenderEmailAddress, ex);
				_log.ErrorFormat("Error on imapClient creation for {0}", ex, _mailboxSyncSettings.SenderEmailAddress);
			}
		}

		/// <summary>
		/// Initializes synchronizer properties.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="login">Try login when imap client created flag.</param>
		protected virtual void InitMailSynchronizer(UserConnection userConnection, MailCredentials credentials, bool login) {
			Guid mailboxSettingsId = Guid.Empty;
			if (login) {
				mailboxSettingsId = _mailboxSyncSettings.Id;
			}
			SetImapClient(userConnection, credentials, mailboxSettingsId, login);
			QueryEmailFolderTypeIds();
			QueryActivityStatuses();
			QueryFileTypes();
			QueryActivityParticipantRoles();
			QueryEmailActivityType();
		}

		/// <summary>
		/// Ensure provision of rights to e-mail.
		/// </summary>
		protected virtual void EnsureEmailRightsGranted() {
			EnsureEmailRightsGranted(_userConnection.CurrentUser.Id);
		}

		[Obsolete]
		protected virtual bool IsActivityExist(Activity activity, string folderName, string messageId = "") {
			return IsActivityExist((Entity)activity, folderName, messageId);
		}

		/// <summary>
		/// Checks if activity exists.
		/// </summary>
		/// <param name="activity">Activity instance.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <param name="messageId">Email Message-ID.</param>
		/// <returns>Flag indicates if activity exists.</returns>
		protected virtual bool IsActivityExist(Entity activity, string folderName, string messageId = "") {
			var emailService = ClassFactory.Get<IEmailService>(new ConstructorArgument("uc", _userConnection));
			var emailIds = emailService.GetActivityIds(messageId);
			if (emailIds == null || !emailIds.Any()) {
				emailIds = ActivityUtils.GetExistingEmaisIds(_userConnection,
					activity.GetTypedColumnValue<DateTime>("SendDate"), activity.GetTypedColumnValue<string>("Title"),
					activity.GetTypedColumnValue<string>("Body"), _userConnection.CurrentUser.TimeZone);
			}
			if (_userConnection.GetIsFeatureEnabled("MailboxRightsForEmail")) {
				bool result = emailIds.Any();
				if (result) {
					activity.PrimaryColumnValue = emailIds.FirstOrDefault();
				}
				return result;
			}
			Guid idWithRights = emailIds.FirstOrDefault(id => activity.FetchFromDB(id, false));
			if (!emailIds.IsEmpty() && idWithRights.IsNotEmpty()) {
				_currentEmailActivityId = idWithRights;
				EnsureEmailRightsGranted();
				if (_activityFolders.ContainsKey(folderName)) {
					foreach (var emailFolderId in _activityFolders[folderName]) {
						EnsureActivityInFolder(emailFolderId);
					}
				}
				activity.StoringState = StoringObjectState.Changed;
				return true;
			}
			return false;
		}

		[Obsolete]
		protected virtual void ActualizeActivityRelations(Activity activity) {
			ActualizeActivityRelations((Entity)activity);
		}

		/// <summary>
		/// Calls <see cref="ActivityUtils.SetEmailRelations(UserConnection, Entity)"/> method
		/// for <paramref name="activity"/>.
		/// </summary>
		/// <param name="activity">Activity instance.</param>
		/// <remarks>External dependency relocation.</remarks>
		protected virtual void ActualizeActivityRelations(Entity activity) {
			ActivityUtils.SetEmailRelations(_userConnection, activity);
		}

		/// <summary>
		/// Synchronizes single e-mail message.
		/// </summary>
		/// <param name="message"><see cref="MailBee.ImapMail.MailMessage"/> header instance.</param>
		/// <param name="envelope"><see cref="MailBee.ImapMail.Envelope"/> instance.</param>
		/// <param name="isMessageRead">Message read state.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <returns>
		/// True if new Activity was created, false if new Activity wasn't created because the message is duplicated.
		/// </returns>
		public virtual bool SyncAction(MailMessage message, Envelope envelope, bool isMessageRead, string folderName) {
			var folderIds = new List<Guid>();
			if (_activityFolders.ContainsKey(folderName)) {
				folderIds = _activityFolders[folderName];
			}
			_currentEmailActivityId = Guid.NewGuid();
			MailMessageParticipants participants;
			var emailFolderId = folderIds.Count == 0 ? Guid.Empty : folderIds[0];
			Entity activity = CreateActivityByMessage(message, envelope, emailFolderId, out participants);
			string messageId = message.Headers["Message-Id"];
			if (!IsNewActivity(activity, isMessageRead, folderName, messageId)) {
				CreateEmailMessageData(activity, message);
				_log.InfoFormat("Message {0} already exists.", activity.GetTypedColumnValue<string>("Title"));
				return false;
			}
			var activityFiles = new Dictionary<Entity, Func<byte[]>>();
			if (message.HasAttachments) {
				string htmlBodyWithCorrectInlineImgUrls = activity.GetTypedColumnValue<string>("Body");
				AddAttachmentsToActivity(_userConnection, message, ref htmlBodyWithCorrectInlineImgUrls, activityFiles);
				activity.SetColumnValue("Body", htmlBodyWithCorrectInlineImgUrls);
			}
			SaveActivity(activity);
			SaveActivityFiles(activityFiles.Keys.ToList());
			UploadActivityFilesData(_userConnection, activityFiles);
			CreateEmailMessageData(activity, message);
			if (isMessageRead) {
				UpdateActivityReadStatusForCurrentUser(activity.PrimaryColumnValue);
			}

			foreach (var folderId in folderIds) {
				EnsureActivityInFolder(folderId);
			}
			if (participants.AllParticipantContactIds.Count > 0) {
				var userIds = GetUsersByContacts(participants.AllParticipantContactIds);
				foreach (var userId in userIds) {
					EnsureEmailRightsGranted(userId);
				}
			}
			return true;
		}

		[Obsolete]
		protected virtual void SaveActivity(Activity activity) {
			SaveActivity((Entity)activity);
		}

		/// <summary>
		/// Saves activity.
		/// </summary>
		/// <param name="activity"><see cref="Activity"/>instance.</param>
		protected virtual void SaveActivity(Entity activity) {
			activity.Save();
			_log.Info(string.Format("Message {0} saved. Activity Id: {1}.",
				activity.GetTypedColumnValue<string>("Title"), activity.PrimaryColumnValue));
		}

		[Obsolete]
		protected virtual void CreateEmailMessageData(Activity activity, MailMessage message) {
			CreateEmailMessageData((Entity)activity, message);
		}

		/// <summary>
		/// Creates <see cref="EmailMessageData"/> instance for <paramref name="activity"/> in current mailbox.
		/// </summary>
		/// <param name="activity"><see cref="Activity"/> instance.</param>
		/// <param name="message"><see cref="MailMessage"/> instance.</param>
		protected virtual void CreateEmailMessageData(Entity activity, MailMessage message) {
			var ticks = ActivityUtils.GetSendDateTicks(_userConnection, activity);
			Dictionary<string, string> headers = new Dictionary<string, string> {
				{ "MessageId", message.Headers["Message-Id"] },
				{ "InReplyTo", message.Headers["In-Reply-To"] },
				{ "References", message.Headers["References"] },
				{ "SyncSessionId", SynsSessionId },
				{ "ThreadIndex", message.Headers["Thread-Index"] },
				{ "SendDateTicks", ticks.ToString() }
			};
			MessageHelper.CreateEmailMessage(activity, _mailboxSyncSettings.PrimaryColumnValue, headers);
		}

		/// <summary>
		/// Saves activity files.
		/// </summary>
		/// <param name="activityFiles">List activity files.</param>
		protected virtual void SaveActivityFiles(List<Entity> activityFiles) {
			activityFiles.ForEach(file => file.Save());
		}

		/// <summary>
		/// Obsolete. Use <see cref="AutoEmailRelation"/> features.
		/// </summary>
		protected virtual void SetDefValuesFromFolderSettings(Activity activity, Guid emailFolderId) {
		}

		/// <summary>
		/// Creates <see cref="ActivityFile"/> instance.
		/// </summary>
		/// <param name="schema">Entity schema.</param>
		/// <param name="userConnection">User connection.</param>
		/// <returns><see cref="ActivityFile"/> instance.</returns>
		protected virtual ActivityFile CreateActivityFile(EntitySchema schema, UserConnection userConnection) {
			return schema.CreateEntity(userConnection) as ActivityFile;
		}

		/// <summary>
		/// Gets date received property from <paramref name="envelope"/>
		/// </summary>
		/// <param name="envelope"><see cref="Envelope"/> instance.</param>
		/// <returns>Date received property.</returns>
		protected virtual DateTime GetEnvelopeDataReceived(Envelope envelope) {
			return (envelope == null) ? DateTime.MinValue : envelope.DateReceived;
		}

		/// <summary>
		/// Gets date property from <paramref name="envelope"/>
		/// </summary>
		/// <param name="envelope"><see cref="Envelope"/> instance.</param>
		/// <returns>Date received property.</returns>
		protected virtual DateTime GetEnvelopeData(Envelope envelope) {
			return (envelope == null) ? DateTime.MinValue : envelope.Date;
		}

		protected virtual Activity CreateActivityByMessage(MailMessage message, Envelope envelope, Guid emailFolderId, out MailMessageParticipants participants) {
			EntitySchema activitySchema = _userConnection.EntitySchemaManager.GetInstanceByName(ActivitySchemaName);
			Activity activity = activitySchema.CreateEntity(_userConnection) as Activity;
			activity.SetDefColumnValues();
			activity.Id = _currentEmailActivityId;
			SetContactFields(message, activity, out participants);
			activity.Title = ActivityUtils.FixActivityTitle(message.Subject, _userConnection);
			activity.PriorityId = PriorityMapping[message.Priority];
			activity.ActivityCategoryId = ActivityCategoryId;
			activity.HeaderProperties = HeaderPropertiesToString(message.Headers);
			if (message.Priority == MailPriority.None && message.Importance != MailPriority.None) {
				activity.PriorityId = PriorityMapping[message.Importance];
			}
			activity.IsHtmlBody = !string.IsNullOrEmpty(message.BodyHtmlText);
			activity.Body = activity.IsHtmlBody ? message.BodyHtmlText : message.BodyPlainText;
			activity.TypeId = EmailActivityTypeId;
			if (GetIsMessageOutcoming(message)) {
				activity.MessageTypeId = OutcomingMessageTypeId;
				activity.OwnerId = participants.SenderContactId == Guid.Empty ?
					_userConnection.CurrentUser.ContactId : participants.SenderContactId;
			} else {
				activity.MessageTypeId = IncomingMessageTypeId;
				activity.OwnerId = _userConnection.CurrentUser.ContactId;
			}
			activity.AuthorId = _userConnection.CurrentUser.ContactId;
			DateTime sendDate = GetEnvelopeData(envelope);
			if (sendDate.Kind == DateTimeKind.Utc) {
				sendDate = TimeZoneInfo.ConvertTimeFromUtc(sendDate, _userConnection.CurrentUser.TimeZone);
			} else {
				sendDate = TimeZoneInfo.ConvertTimeFromUtc(sendDate.ToUniversalTime(), _userConnection.CurrentUser.TimeZone);
			}
			activity.SendDate = sendDate;
			DateTime dateReceived = GetEnvelopeDataReceived(envelope);
			if (dateReceived.Kind == DateTimeKind.Utc) {
				dateReceived = TimeZoneInfo.ConvertTimeFromUtc(dateReceived, _userConnection.CurrentUser.TimeZone);
			} else {
				dateReceived = TimeZoneInfo.ConvertTimeFromUtc(dateReceived.ToUniversalTime(), _userConnection.CurrentUser.TimeZone);
			}
			activity.StartDate = dateReceived;
			activity.DueDate = dateReceived;
			activity.StatusId = FinishedActvityStatusId;
			activity.EmailSendStatusId = SendedEmailStatusId;
			activity.MailHash = ActivityUtils.GetEmailHash(_userConnection, activity.SendDate, activity.Title, activity.Body,
				_userConnection.CurrentUser.TimeZone);
			return activity;
		}

		/// <summary>
		/// Combines <paramref name="HeaderCollection"/> items into one string.
		/// </summary>
		/// <remarks>Item format is <c>Name <PropertyName> = <c>Value <Value>;</c></remarks>
		/// <param name="EmailMessage"><see cref="xchange.EmailMessage"/> instance.</param>
		/// <returns>Formated HeaderProperties string.</returns>
		protected virtual string HeaderPropertiesToString(HeaderCollection messageHeaders) {
			var headerProperties = new StringBuilder();
			foreach (Header property in messageHeaders) {
				headerProperties.Append(property.Name + "=" + property.Value + "\n");
			}
			return headerProperties.ToString();
		}

		/// <summary>
		/// Sets <see cref="MailSynchronizer._startSyncDate"/> field value.
		/// </summary>
		/// <remarks>
		/// External dependency realocation.
		/// </remarks>
		protected virtual void SetStartSyncDate() {
			_startSyncDate = DateTime.UtcNow;
		}

		/// <summary>
		/// Sets <see cref="_isDateBasedStrategy"/> field value.
		/// </summary>
		/// <remarks><c>True</c> if strategy <see cref="DateBasedSentSinceSyncStrategy"/> 
		/// or <see cref="DateBasedSyncStrategy"/> class instance, <c>false</c> otherwise.</remarks>
		protected virtual void SetIsDateBasedStrategy() {
			ISyncStrategy strategy = _imapClient.Strategy;
			bool isDateBasedSentSinceSyncStrategy = strategy is DateBasedSentSinceSyncStrategy;
			bool isDateBasedSyncStrategy = strategy is DateBasedSyncStrategy;
			_isDateBasedStrategy = isDateBasedSentSinceSyncStrategy || isDateBasedSyncStrategy;
		}

		/// <summary>
		/// Sends synchronization session finish message.
		/// </summary>
		protected virtual void SendSyncSessionFinished() {
			MessageHelper.SendSyncSessionFinished(SynsSessionId);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Creates synchronization job.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="periodInMinutes">Synchronization interval.</param>
		/// <param name="parameters">Synchronization parameters.</param>
		public static void CreateSyncJob(UserConnection userConnection, int periodInMinutes,
				IDictionary<string, object> parameters = null) {
			if (periodInMinutes <= 0) {
				throw new ArgumentOutOfRangeException("periodInMinutes");
			}
			RemoveSyncJob(userConnection, parameters);
			string syncJobName = GetSyncJobName(userConnection, parameters);
			_log.ErrorFormat("ScheduleMinutelyJob called: CurrentUser {0}, SyncJobName {1}",
				userConnection.CurrentUser.Name, syncJobName);
			AppScheduler.ScheduleMinutelyJob(syncJobName, SyncJobGroupName, SyncProcessName,
				userConnection.Workspace.Name, userConnection.CurrentUser.Name, periodInMinutes, parameters);
		}

		/// <summary>
		/// Removes synchronization job.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="parameters">Synchronization parameters.</param>
		public static void RemoveSyncJob(UserConnection userConnection,
				IDictionary<string, object> parameters = null) {
			string[] syncJobNames = new string[] {
				GetSyncJobName(userConnection),
				GetSyncJobName(userConnection, parameters)
			};
			string trace = string.Empty;
			try {
				var stackTrace = new System.Diagnostics.StackTrace(false);
				trace = stackTrace.ToString();
			} catch {
			}
			foreach (string syncJobName in syncJobNames) {
				_log.ErrorFormat("RemoveJob called: CurrentUser {0}, SyncJobName {1}. Trace: {2}",
					userConnection.CurrentUser.Name, syncJobName, trace);
				AppScheduler.RemoveJob(syncJobName, SyncJobGroupName);
			}
		}

		/// <summary>
		/// Check if sync job exists.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="parameters">Job parameters collection.</param>
		/// <returns><c>True</c> if job exists. Otherwise returns <c>false</c>.</returns>
		public static bool DoesSyncJobExist(UserConnection userConnection, IDictionary<string, object> parameters = null) {
			string syncJobName = GetSyncJobName(userConnection, parameters);
			return AppScheduler.DoesJobExist(syncJobName, SyncJobGroupName);
		}

		/// <summary>
		/// Starts imap mail synchronization session.
		/// </summary>
		public void SyncImapMail() {
			if (_imapClient == null) {
				_log.ErrorFormat(string.Concat("ImapClient SyncImapMail _imapClient is null for {0}. ",
					"Probably was timeout error when trying create connection to IMAP server"),
					_mailboxSyncSettings.SenderEmailAddress);
				return;
			}
			SetStartSyncDate();
			_log.Info(string.Format("-------------------------------------- Sync session for {0} started --------------------------------------",
				_mailboxSyncSettings.SenderEmailAddress));
			var mailBoxActivityFolderId = GetMailboxActivityFolderIdByName(_mailboxSyncSettings.MailboxName);
			_log.InfoFormat("[{0}] - Mailbox name \"{1}\", ActivityFolderId = \"{2}\"",
				_mailboxSyncSettings.SenderEmailAddress, _mailboxSyncSettings.MailboxName, mailBoxActivityFolderId);
			QueryCrmFolders(mailBoxActivityFolderId);
			_imapClient.EnforceFoldersStructure(_activityFolders.Keys);
			if (_mailboxSyncSettings.LoadAllEmailsFromMailBox) {
				_activityFolders = new Dictionary<string, List<Guid>> {
					{
						_imapClient.BPMonlineFolderName, new List<Guid> {
							mailBoxActivityFolderId
						}
					}
				};
			}
			string strategyName = GetStrategyName(_mailboxSyncSettings);
			_imapClient.Strategy = ClassFactory.Get<ISyncStrategy>(strategyName, new ConstructorArgument("userConnection", _userConnection),
				new ConstructorArgument("syncSettings", _mailboxSyncSettings));
			SetIsDateBasedStrategy();
			_imapClient.SyncMailMessages(SyncAction, _activityFolders, _mailboxSyncSettings.LoadAllEmailsFromMailBox);
			if (_isDateBasedStrategy) {
				SetCurrentLastSyncDate(_mailboxSyncSettings.SenderEmailAddress);
			}
			_log.Info(string.Format("-------------------------------------- Sync session for {0} ended --------------------------------------",
					_mailboxSyncSettings.SenderEmailAddress));
			RemoteChangesCount = _imapClient.RemoteChangesCount;
			SendSyncSessionFinished();
		}

		public void ValidateImapServer() {
		}

		public void ValidateImapClient() {
			ValidateImapServer();
		}

		public static ImapErrorMessages GetImapErrorMessages(UserConnection _userConnection) {
			var result = new ImapErrorMessages();
			result.LocCanNotConnect = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocCanNotConnect.Value").ToString();
			result.LocServerNotSupportSslConnection = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocServerNotSupportSslConnection.Value").ToString();
			result.LocLoginOrPwdWrong = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocLoginOrPwdWrong.Value").ToString();
			result.LocSyncError = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocSyncError.Value").ToString();
			return result;
		}

		public void StartIdle() {
		}

		public void Dispose() {
			_imapClient?.Dispose();
		}

		public void Init(UserConnection userConnection, MailCredentials credentials, bool login = true) {
			_userConnection = userConnection;
			_credentials = credentials;
			_imapClient = new ImapClient(credentials, GetImapErrorMessages(userConnection), userConnection, _mailboxSyncSettings.Id, login);
			QueryEmailFolderTypeIds();
			QueryActivityStatuses();
			QueryFileTypes();
			QueryActivityParticipantRoles();
			QueryEmailActivityType();
		}

		#endregion

	}

	#endregion

}
