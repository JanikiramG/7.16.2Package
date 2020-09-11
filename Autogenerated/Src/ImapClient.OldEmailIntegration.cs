namespace Terrasoft.Mail
{
	using System;
	using System.IO;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading;
	using global::Common.Logging;
	using MailBee;
	using MailBee.ImapMail;
	using MailBee.Mime;
	using MailBee.Security;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.Imap;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
#if !NETSTANDARD2_0 // TODO #CRM-42481
	using Terrasoft.Social.OAuth;
#endif

	#region Class: ImapClient
	[DefaultBinding(typeof(IImapClient), Name = "OldEmailIntegration")]
	public class ImapClient: IImapClient
	{
		#region LocalizableStrings

		public LocalizableString LocFileNotLoaded {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocFileNotLoaded.Value").ToString();
			}
		}
		public LocalizableString LocLoginOrPwdWrong {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocLoginOrPwdWrong.Value").ToString();
			}
		}

		/// <summary>
		/// Invalid OAuth credentials localizable string.
		/// </summary>
		public LocalizableString LocInvalidOAuthCredentials {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocInvalidOAuthCredentials.Value").ToString();
			}
		}

		public LocalizableString LocCanNotConnect {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCanNotConnect.Value").ToString();
			}
		}
		public LocalizableString LocCustomFlagsNotSupported {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCustomFlagsNotSupported.Value").ToString();
			}
		}
		public LocalizableString LocServerNotSupportSslConnection {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocServerNotSupportSslConnection.Value").ToString();
			}
		}
		public LocalizableString LocSyncError {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocSyncError.Value").ToString();
			}
		}

		/// <summary>
		/// Cannot read folder localizable string.
		/// </summary>
		public LocalizableString LocCanNotReadFolder {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCanNotReadFolder.Value").ToString();
			}
		}

		public LocalizableString LocCanNotCreateFolder {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCanNotCreateFolder.Value").ToString();
			}
		}
		public LocalizableString LocNoName {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocNoName.Value").ToString();
			}
		}

		#endregion

		#region Fields: Private

		private Imap _client;
		private string _currentMailboxName;
		private string _bpmOnlineFolderFullName = "INBOX";
		private string _syncMemoryLimitToDeallocateSysSetting = "SyncMemoryLimitToDeallocate";
		private readonly string _imapEventsLogging = "ImapEventsLogging";
		/// <summary>
		/// Default memory size limit for deallocation (size specified in MegaBytes)
		/// </summary>
		private decimal _defMaxMemorySize = 100m;
		private decimal _kbSize = 1024m;
		private UserConnection _userConnection;
		private static readonly ILog _log = LogManager.GetLogger("Imap");
		private MailboxFoldersCorrespondence _currentFolder;
		/// <summary>
		/// Default credentials timeout (used when mail server SMTP server timeout equals 0).
		/// </summary>
		private int _defaultCredentialsTimeout = 40000;



		#endregion

		#region Fields: Public

		public string BPMonlineFolderName => "INBOX";

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Sets or gets current mailbox settings unique identifier.
		/// </summary>
		private Guid _currentMailboxSettingsId = Guid.Empty;
		protected Guid CurrentMailboxSettingsId {
			get {
				if (_currentMailboxSettingsId.IsEmpty()) {
					Select settingsSelect = new Select(_userConnection)
						.Column("Id")
					.From("MailboxSyncSettings")
					.Where("SenderEmailAddress").IsEqual(Column.Parameter(_currentMailboxName)) as Select;
					_currentMailboxSettingsId = settingsSelect.ExecuteScalar<Guid>();
				}
				return _currentMailboxSettingsId;
			}
			set {
				_currentMailboxSettingsId = value;
			}
		}

		/// <summary>
		/// Current mailbox root <see cref="ActivityFolder"/> instance id.
		/// </summary>
		private Guid _rootActivityFolderId;
		protected Guid RootActivityFolderId {
			get {
				if (_rootActivityFolderId.IsEmpty()) {
					var activityFolderSelect =
						new Select(_userConnection).Top(1)
							.Column("Id")
						.From("ActivityFolder")
						.Where("FolderTypeId").IsEqual(Column.Parameter(FolderConsts.MailboxFolderTypeId))
						.And("CreatedById").IsEqual(Column.Parameter(_userConnection.CurrentUser.ContactId))
						.And("Name").IsEqual(Column.Parameter(_currentMailboxName)) as Select;
					_rootActivityFolderId = activityFolderSelect.ExecuteScalar<Guid>();
				}
				return _rootActivityFolderId;
			}
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// <see cref="ISyncStrategy"/> implementation.
		/// </summary>
		public ISyncStrategy Strategy {
			get;
			set;
		}

		private int _synchronizedMessages = 0;
		public int SynchronizedMessages {
			get {
				return _synchronizedMessages;
			}
		}

		private int _remoteChangesCount = 0;
		public int RemoteChangesCount {
			get {
				return _remoteChangesCount;
			}
		}

		public int LocalChangesCount {
			get;
			private set;
		}

		private decimal _maxMemorySize = -1;
		public decimal MaxMemorySize {
			get {
				if (_maxMemorySize < 0) {
					_maxMemorySize = Terrasoft.Core.Configuration.SysSettings.GetValue<decimal>(_userConnection,
							_syncMemoryLimitToDeallocateSysSetting, _defMaxMemorySize);
				}
				return _maxMemorySize;
			}
		}

		#endregion

		#region Constructors: Internal

		static ImapClient() {
			MailBee.Global.LicenseKey = "MN110-6DA58BC4A5FCA54AA5BA8059BC03-5DA1";
		}

		/// <summary>
		/// Creates <see cref="ImapClient"/> instance.
		/// </summary>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="errorMessages"><see cref="ImapErrorMessages"/> instance.</param>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="mailboxSettingsId">Mailbox synchronization settings unique identifier.</param>
		/// <param name="login">Flag indicates if need to login to imap server.</param>
		public ImapClient(MailCredentials credentials, ImapErrorMessages errorMessages, UserConnection userConnection, Guid mailboxSettingsId,
			bool login = true)
			: this(credentials, errorMessages, userConnection, login) {
			CurrentMailboxSettingsId = mailboxSettingsId;
		}

		/// <summary>
		/// Creates <see cref="ImapClient"/> instance.
		/// </summary>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="errorMessages"><see cref="ImapErrorMessages"/> instance.</param>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="login">Flag indicates if need to login to imap server.</param>
		public ImapClient(MailCredentials credentials, ImapErrorMessages errorMessages, UserConnection userConnection, bool login = true) {
			_userConnection = userConnection;
			_client = CreateImapClient(credentials);
			_remoteChangesCount = 0;
			LocalChangesCount = 0;
			string errorMessage = string.Empty;
			try {
				_currentMailboxName = credentials.SenderEmailAddress;
				if (login) {
					string oauthClassName = GetOAuthClientClassNameBySender(_currentMailboxName);
					if (oauthClassName.IsNotNullOrEmpty()) {
						errorMessage = LocInvalidOAuthCredentials.ToString();
#if !NETSTANDARD2_0 // TODO #CRM-42481
						OAuthClient oauthClient = (OAuthClient)Activator.CreateInstance(Type.GetType("Terrasoft.Configuration." + oauthClassName), credentials.SenderEmailAddress, userConnection);
						string token = oauthClient.GetAccessToken();
#else
						string token = string.Empty;
#endif
						string xoAuthKey = OAuth2.GetXOAuthKeyStatic(credentials.SenderEmailAddress, token);
						_client.Login(credentials.UserName, xoAuthKey, AuthenticationMethods.SaslOAuth2, MailBee.AuthenticationOptions.None, null);
					} else {
						errorMessage = LocLoginOrPwdWrong.ToString();
						_client.Login(credentials.UserName, credentials.UserPassword);
					}
				}
			} catch (Exception ex) {
				throw new ImapException(errorMessage, ex);
			}
		}

		#endregion

		#region Methods: Private

		private IResourceStorage GetResourceStorage() {
			return _userConnection.ResourceStorage;
		}

		private Imap CreateImapClient(MailCredentials credentials) {
			Imap client = new Imap();
			SetImapLogging(client, credentials.SenderEmailAddress);
			if (credentials.StartTls) {
				client.SslMode = SslStartupMode.UseStartTlsIfSupported;
			}
			client.SslProtocol = SecurityProtocol.Auto;
			client.Timeout = credentials.Timeout > 0 ? credentials.Timeout : _defaultCredentialsTimeout;
			try {
				if (credentials.Port > 0) {
					client.Connect(credentials.Host, credentials.Port);
				} else {
					client.Connect(credentials.Host);
				}
			} catch (Exception ex) {
				throw new ImapException(LocCanNotConnect.ToString(), ex);
			}
			if (credentials.UseSsl && !client.IsSslConnection) {
				throw new ImapException(LocServerNotSupportSslConnection);
			}
			return client;
		}

		private void SetImapLogging(Imap client, string email) {
			if (_userConnection.GetIsFeatureEnabled(_imapEventsLogging)) {
				var filenamePath = GetImapEventsLoggingFileName(email);
				if (filenamePath.IsNotNullOrEmpty()) {
					client.Log.Enabled = true;
					client.Log.Filename = filenamePath;
					_log.Info($"[{_currentMailboxName}] | ImapEventsLogging is enabled, path = '{filenamePath}'");
				}
			}
		}

		private string GetImapEventsLoggingFileName(string email) {
			try {
				var tempFolderPath = Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine);
				var directoryInfo = Directory.CreateDirectory(Path.Combine(tempFolderPath, _imapEventsLogging));
				var defImapEventsLoggingFileName = Path.Combine(directoryInfo.FullName, email + ".log");
				return Core.Configuration.SysSettings.GetValue<string>(_userConnection,
					_imapEventsLogging, defImapEventsLoggingFileName);
			} catch (Exception exp) {
				_log.Info($"[{_currentMailboxName}] | Error when get events logging file name. Message '{exp.Message}'");
				return string.Empty;
			}
		}

		private decimal SyncEnvelope(Envelope envelope, Func<MailMessage, Envelope, bool, string, bool> syncAction,
				string crmFolder, decimal totalSize) {
			try {
				decimal fileSize = (decimal)envelope.Size / _kbSize / _kbSize;
				_log.Info(string.Format("[{0}] - [{1}] | Downloaded message size: {2:0.00} mb", _currentMailboxName,
						crmFolder, fileSize));
				totalSize += fileSize;
				bool leaveMessageUnread = !envelope.Flags.SystemFlags.HasFlag(SystemMessageFlags.Seen);
				using (MailMessage message = _client.DownloadEntireMessage((long)envelope.Uid, true)) {
					var messageInfo = string.Format("[{0}] - [{1}] | FROM: {2} SUBJECT: {3}", _currentMailboxName, crmFolder,
							message.From, message.Subject);
					try {
						_log.Info(messageInfo);
						syncAction(message, envelope, !leaveMessageUnread, crmFolder);
						Strategy.SetMessageSynchronized(_client, message);
					} catch (Exception e) {
						_log.Error(string.Format("{0} - Error on sync action: {1}", messageInfo, e.ToString()));
					}
				}
				totalSize = TryClearMemory(totalSize, crmFolder);
				if (leaveMessageUnread) {
					_client.SetMessageFlags(envelope.Uid.ToString(), true, SystemMessageFlags.Seen, MessageFlagAction.Remove);
				}
				Interlocked.Increment(ref _synchronizedMessages);
			} catch (Exception ex) {
				var messageInfo = string.Format("[{0}] - [{1}] | FROM: {2} SUBJECT: {3}", _currentMailboxName, crmFolder,
					envelope.From, envelope.Subject);
				_log.Error(string.Format("{0} - Error on sync action: {1}", messageInfo, ex.ToString()));
			}
			return totalSize;
		}

		private decimal TryClearMemory(decimal totalSize, string crmFolder) {
			if (totalSize >= MaxMemorySize) {
				_log.Info(string.Format("[{0}] - [{1}] | Messages total size reached {2:0.00}mb. Starting memory deallocation",
							_currentMailboxName, crmFolder, totalSize));
				GC.Collect();
				totalSize = 0;
			}
			return totalSize;
		}

		/// <summary>
		/// Gets current folder mailbox correspondence.
		/// </summary>
		/// <param name="folderPath">Folder path.</param>
		/// <param name="mailBoxId">Unique mailbox identifier in bpm.</param>
		/// <param name="getCurrentMailboxFolderResult">True if obtain successful folder <c>false</c> otherwise.</param>
		/// <returns><see cref="MailboxFoldersCorrespondence"/> instance</returns>
		private MailboxFoldersCorrespondence GetsCurrentMailboxFoldersCorrespondence(string folderPath, string mailBoxId,
				out bool getCurrentMailboxFolderResult) {
			EntitySchema mailboxFoldersCorrespondenceSchema = _userConnection.EntitySchemaManager.GetInstanceByName("MailboxFoldersCorrespondence");
			MailboxFoldersCorrespondence mailboxFoldersCorrespondence =
				mailboxFoldersCorrespondenceSchema.CreateEntity(_userConnection) as MailboxFoldersCorrespondence;
			Select mfcSelect = new Select(_userConnection).Top(1)
				.Column("Id")
				.From("MailboxFoldersCorrespondence")
				.Where("FolderPath").IsEqual(Column.Parameter(folderPath))
					.And("MailboxId").IsEqual(Column.Parameter(new Guid(mailBoxId))) as Select;
			Guid mailboxFolderId = mfcSelect.ExecuteScalar<Guid>();
			if (mailboxFolderId.IsEmpty()) {
				getCurrentMailboxFolderResult = false;
				return null;
			}
			getCurrentMailboxFolderResult = mailboxFoldersCorrespondence.FetchFromDB(mailboxFolderId, false);
			return mailboxFoldersCorrespondence;
		}

		private void SyncMailMessagesInFolder(string crmFolder, string rawName, Func<MailMessage, Envelope, bool, string, bool> syncAction) {
			_log.Info(string.Format("------ [{0}] | Mail synchronization in folder {1} STARTED. ------", _currentMailboxName, rawName));
			bool getCurrentMailboxFoldersResult;
			_currentFolder = GetsCurrentMailboxFoldersCorrespondence(rawName, CurrentMailboxSettingsId.ToString(),
					out getCurrentMailboxFoldersResult);
			if (!getCurrentMailboxFoldersResult) {
				throw new ImapException(LocCanNotReadFolder.ToString());
			}
			MessageIndexCollection msgIndexes = Strategy.GetUnsyncedMsgIndexes(_client, rawName);
			_log.Info(string.Format("[{0}] - [{1}] Sync query {2} - found {3} unsynchronized messages headers for ActivityFolderId {4}",
				_currentMailboxName, rawName, Strategy.GetUnsyncMsgSearchQuery(), msgIndexes.Count, _currentFolder.ActivityFolderId));
			if (msgIndexes.Count > 0) {
				try {
					var remoteChangesCount = 0;
					decimal totalSize = 0m;
					var msgEnvelopes = _client.DownloadEnvelopes(msgIndexes.ToString(), true);
					_log.Info(string.Format("[{0}] - [{1}] | Load {2} unsynchronized messages", _currentMailboxName, rawName, msgEnvelopes.Count));
					foreach (Envelope envelope in msgEnvelopes) {
						totalSize = SyncEnvelope(envelope, syncAction, crmFolder, totalSize);
						remoteChangesCount++;
					}
					_log.Info(string.Format("[{0}] - [{1}] | Processed {2} messages", _currentMailboxName, rawName, msgEnvelopes.Count));
					_remoteChangesCount = remoteChangesCount;
				} catch (Exception ex) {
					_log.Error(string.Format("[{0}] - [{1}] | Error on folder sync: {2}", _currentMailboxName, rawName, ex.ToString()));
				}
			}
			List<long> messageIndexList = GetMsgIndexesList(msgIndexes);
			messageIndexList.Sort();
			if (_currentFolder != null && messageIndexList.Count > 0) {
				_currentFolder.UId = messageIndexList.Last().ToString();
				_log.Error($"[{_currentMailboxName}] - [{_currentFolder}] | Update folder UId '{_currentFolder.UId}' start." +
					$"ActivityFolderId = '{_currentFolder.ActivityFolderId}'");
				SaveCurrentFolder(_currentFolder);
				_log.Error($"[{_currentMailboxName}] - [{_currentFolder}] | Update folder UId '{_currentFolder.UId}' end." +
					$"ActivityFolderId = '{_currentFolder.ActivityFolderId}'");
			}
			_log.Info(string.Format("------ [{0}] | Mail synchronization in folder {1} COMPLETED. ------", _currentMailboxName, rawName));
		}

		private int GetIndexDraftsFolder(FolderCollection folders) {
			for (int index = 0; index < folders.Count; index++) {
				Folder folder = folders[index];
				if (folder.Flags == FolderFlags.Drafts) {
					return index;
				}
			}
			return -1;
		}

		/// <summary>
		/// Returns true if <paramref name"folder"/> allowed for synchronization.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder" instance.</param>
		/// <returns>Returns is <paramref name"folder"/> allowed for synchronization.</returns>
		private bool IsFolderAlowedForSync(ImapFolder folder) {
			_log.DebugFormat("[{0}] - [{1}] | folder flags are {2}", _currentMailboxName, folder.Name, folder.Flags);
			return ((folder.Flags & (FolderFlags.AllMail | FolderFlags.Trash | FolderFlags.Spam | FolderFlags.Drafts |
					FolderFlags.Noselect)) == 0);
		}

		/// <summary>
		/// Sync all folders in imap client, which allowed for synchronization.
		/// </summary>
		/// <param name="syncAction">Sync action for <see cref="Envelope"/> instance.</param>
		/// <param name="crmFolders">Crm folders list.</param>
		/// <remarks>
		/// <see cref="ImapClient.IsFolderAlowedForSync"/> method is used to determine folders for synchronization.
		/// </remarks>
		private void SyncAllFolders(Func<MailMessage, Envelope, bool, string, bool> syncAction,
				Dictionary<string, List<Guid>> crmFolders) {
			var mailboxFolders = TryGetImapFoldersCollection();
			foreach (var mailboxFolder in mailboxFolders) {
				try {
					_log.Info(string.Format("[{0}] - [{1}] [2]| Check if folder is allowed for sync",
						_currentMailboxName, mailboxFolder.Name, mailboxFolder.RawName));
					if (IsFolderAlowedForSync(mailboxFolder)) {
						SelectFolderForSyncronization(mailboxFolder.RawName);
						ActualizeMailboxFoldersCorrespondence(mailboxFolder);
						SyncMailMessagesInFolder(mailboxFolder.ShortName, mailboxFolder.RawName, syncAction);
					}
				} catch (Exception e) {
					_log.Error(string.Format("[{0}] - [{1}] | Folder synchronization error: {2}",
						_currentMailboxName, mailboxFolder.RawName, e.ToString()));
				}
			}
		}

		/// <summary>
		/// Synchronize selected folders in IMAP client.
		/// </summary>
		/// <param name="syncAction">Sync action for <see cref="Envelope"/> instance.</param>
		/// <param name="crmFolders">Crm folders list.</param>
		private void SyncSelectedFolders(Func<MailMessage, Envelope, bool, string, bool> syncAction,
				Dictionary<string, List<Guid>> crmFolders) {
			var realFoldersFromMailbox = TryGetImapFoldersCollection();
			foreach (var crmFolder in crmFolders) {
				foreach (Guid activityFoderId in crmFolder.Value) {
					_log.InfoFormat("[{0}] - try ActivityFolderId = \"{1}\" synchronization",
						_currentMailboxName, activityFoderId);
					var rawName = GetRawNameByFolderId(activityFoderId);
					if (rawName.IsNotNullOrEmpty() && realFoldersFromMailbox.Any(f => f.RawName == rawName)) {
						_log.InfoFormat("[{0}] - ActivityFolderId \"{1}\" raw name is {2}",
							_currentMailboxName, activityFoderId, rawName);
						try {
							SelectFolderForSyncronization(rawName);
							SyncMailMessagesInFolder(crmFolder.Key, rawName, syncAction);
						} catch (Exception e) {
							_log.Error(string.Format("[{0}] - [{1}] | Folder synchronization error: {2}",
									_currentMailboxName, rawName, e.ToString()));
						}
					}
				}
			}
		}

		/// <summary>
		/// Returns id of the <paramref name="folder"/>.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder"/> instance.</param>
		/// <returns>id of the <paramref name="folder"/>.</returns>
		private Guid GetFolderId(ImapFolder folder) {
			var select = SelectFolderFromDB(folder.RawName) as Select;
			return select.ExecuteScalar<Guid>();
		}

		/// <summary>
		/// Returns <see cref="Query"/> for selecting folder by provided name.
		/// </summary>
		/// <param name="rawName"> folder's name.</param>
		/// <returns><see cref="Query"/> for selecting folder by provided name.</returns>
		private Query SelectFolderFromDB(string rawName) {
			var select =
				new Select(_userConnection).Top(1)
					.Column("Id")
				.From("MailboxFoldersCorrespondence")
				.Where("FolderPath").IsEqual(Column.Parameter(rawName))
				.And("MailboxId").IsEqual(Column.Parameter(CurrentMailboxSettingsId));
			return select;
		}

		/// <summary>
		/// Creates <see cref="ActivityFolder"/> instance for <paramref name="folder"/>.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder"/> instance.</param>
		/// <returns><see cref="ActivityFolder"/> instance unique identifier.</returns>
		private Guid CreateActivityFolder(ImapFolder folder) {
			EntitySchema schema = _userConnection.EntitySchemaManager.GetInstanceByName("ActivityFolder");
			Entity activityFolder = schema.CreateEntity(_userConnection);
			activityFolder.SetDefColumnValues();
			activityFolder.SetColumnValue("Name", folder.ShortName);
			activityFolder.SetColumnValue("FolderTypeId", FolderConsts.EmailFolderTypeId);
			activityFolder.SetColumnValue("ParentId", RootActivityFolderId);
			activityFolder.Save();
			return activityFolder.PrimaryColumnValue;
		}

		/// <summary>
		/// Creates <see cref="MailboxFoldersCorrespondence"/> instance for <paramref name="folder"/> if needed.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder"/> instance.</param>
		private void ActualizeMailboxFoldersCorrespondence(ImapFolder folder) {
			Guid folderId = GetFolderId(folder);
			if (folderId.IsEmpty()) {
				Guid activityFolderId = CreateActivityFolder(folder);
				EntitySchema schema = _userConnection.EntitySchemaManager
					.GetInstanceByName("MailboxFoldersCorrespondence");
				Entity correspondence = schema.CreateEntity(_userConnection);
				correspondence.SetDefColumnValues();
				correspondence.SetColumnValue("FolderPath", folder.RawName);
				correspondence.SetColumnValue("UId", "0");
				correspondence.SetColumnValue("MailboxId", CurrentMailboxSettingsId);
				correspondence.SetColumnValue("ActivityFolderId", activityFolderId);
				SaveEntity(correspondence);
			}
		}

		private string GetOAuthClientClassNameBySender(string emailSender) {
			EntitySchemaQuery esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "MailboxSyncSettings");
			EntitySchemaQueryColumn column = esq.AddColumn("MailServer.OAuthApplication.ClientClassName");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SenderEmailAddress", emailSender));
			esq.Filters.Add(esq.CreateIsNotNullFilter("OAuthTokenStorage"));
			Entity mailbox = esq.GetEntityCollection(_userConnection).FirstOrDefault();
			if (mailbox != null) {
				return mailbox.GetTypedColumnValue<string>(column.Name);
			} else {
				return null;
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Saves entity.
		/// </summary>
		/// <param name="entity"><see cref="Entity"/>instance.</param>
		protected virtual void SaveEntity(Entity entity) {
			entity.Save();
		}

		/// <summary>
		/// Gets list mailbox indexes from <paramref name="msgIndexes"/>.
		/// </summary>
		/// <param name="msgIndexes"><see cref="MessageIndexCollection"/> instance.</param>
		/// <returns>List mailbox indexes.</returns>
		protected virtual List<long> GetMsgIndexesList(MessageIndexCollection msgIndexes) {
			return msgIndexes.Cast<long>().ToList();
		}

		/// <summary>
		/// Returns imap folder unique identifier.
		/// </summary>
		/// <returns>Imap folder unique identifier.</returns>
		protected virtual long GetFolderUid() {
			return _client.UidValidity;
		}

		/// <summary>
		/// Gets folder name by <paramref name="activityFolderId"/>.
		/// </summary>
		/// <param name="activityFolderId">Activity folder unique identifier.</param>
		/// <returns>Folder name.</returns>
		protected virtual string GetRawNameByFolderId(Guid activityFolderId) {
			var sel = new Select(_userConnection)
				.Column("FolderPath")
				.From("MailboxFoldersCorrespondence")
				.Where("ActivityFolderId").IsEqual(Column.Parameter(activityFolderId)) as Select;
			List<string> names = new List<string>();
			using (var dbExecutor = _userConnection.EnsureDBConnection()) {
				using (var reader = sel.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						int columnOrdinal = reader.GetOrdinal("FolderPath");
						return reader.GetString(columnOrdinal);
					}
				}
			}
			return string.Empty;
		}

		/// <summary>
		/// Saves folder entity.
		/// </summary>
		/// <param name="currentFolder"><see cref="MailboxFoldersCorrespondence"/> instance.</param>
		protected virtual void SaveCurrentFolder(MailboxFoldersCorrespondence currentFolder) {
			currentFolder.Save();
		}

		/// <summary>
		/// Selects the specified folder for read-write access.
		/// </summary>
		/// <param name="rawName">Folder raw name.</param>
		protected virtual void SelectFolderForSyncronization(string rawName) {
			_log.Info(string.Format("[{0}] - [{1}] | Selecting folder for sync in client.", _currentMailboxName, rawName));
			_client.Utf7EncodeFolderNames = false;
			_client.SelectFolder(rawName);
			_client.Utf7EncodeFolderNames = true;
			_log.Info(string.Format("[{0}] - [{1}] | Folder selected for sync in client.", _currentMailboxName, rawName));
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns folders of mailbox.
		/// </summary>
		/// <remarks>
		/// Draft folders will be filtered.
		/// </remarks>
		public List<IImapFolder> GetFolders() {
			var resultFolders = new List<IImapFolder>();
			foreach (Folder mailbeeFolder in TryGetFoldersCollection()) {
				resultFolders.Add(new ImapFolder(mailbeeFolder));
			}
			return resultFolders.OrderBy(f => f.NestingLevel).ToList();
		}

		/// <summary>
		/// Returns <see cref="FolderCollection"/> instance.
		/// </summary>
		/// <remarks>
		/// Draft folders will be filtered.
		/// </remarks>
		public FolderCollection TryGetFoldersCollection() {
			FolderCollection folders = null;
			try {
				folders = _client.DownloadFolders(false);
			} catch (MailBeeException e) {
				throw new ImapException(LocSyncError.ToString(), e);
			}
			int draftsIndex = GetIndexDraftsFolder(folders);
			if (draftsIndex > 0) {
				folders.RemoveAt(draftsIndex);
			}
			return folders;
		}

		/// <summary>
		/// Returns <see cref="ImapFolderCollection"/> instance.
		/// </summary>
		/// <remarks>
		/// Draft folders will be filtered.
		/// </remarks>
		public virtual ImapFolderCollection TryGetImapFoldersCollection() {
			FolderCollection folders = TryGetFoldersCollection();
			var imapfolders = new ImapFolderCollection(folders);
			if (imapfolders != null) {
				_log.Info($"[{_currentMailboxName}] | Folders from mailbox count {imapfolders.Count()}.");
				foreach (ImapFolder folder in imapfolders) {
					_log.Info($"[{_currentMailboxName}] - [{folder.Name}] | RawName = '{folder.RawName}'");
				}
			}
			return imapfolders;
		}

		public bool TryDeleteFolder(string folderName) {
			bool result = true;
			try {
				result = _client.DeleteFolder(folderName);
			} catch (MailBeeImapNegativeResponseException) {
				result = false;
			}
			return result;
		}

		public bool EnsureFolderExists(string folderName) {
			bool result = false;
			try {
				result = _client.ExamineFolder(folderName);
			} catch (MailBeeImapNegativeResponseException) {
				result = false;//_client.CreateFolder(folderName);
			}
			return result;
		}

		public bool CreateFolder(string newFolderPath) {
			bool result = false;
			try {
				result = _client.CreateFolder(newFolderPath);
			} catch (MailBeeImapNegativeResponseException e) {
				return e.OptionalResponse != null && e.OptionalResponse.Equals("ALREADYEXISTS",
						StringComparison.InvariantCultureIgnoreCase) ||
					e.HumanReadable.Equals("Mailbox already exists.", StringComparison.InvariantCultureIgnoreCase);
			}
			return result;
		}

		public void MoveMessageToFolder(string folderName, string messageTitle, string destenationFolder) {
			_client.SelectFolder(folderName);
			MessageIndexCollection uids = _client.Search(true, string.Format("SUBJECT {0}", messageTitle), null);
			if (uids.Count > 0) {
				_client.MoveMessages(uids.ToString(), true, destenationFolder);
			}
		}

		public bool RenameOrCreateFolder(string oldFolderName, string newFolderName) {
			bool result = false;
			try {
				result = _client.RenameFolder(oldFolderName, newFolderName);
			} catch (MailBeeImapNegativeResponseException) {
				result = _client.CreateFolder(newFolderName);
			}
			return result;
		}

		public void EnforceFoldersStructure(IEnumerable<string> folderNames) {
		}

		public bool ValidateCustomFlagsSupport() {
			try {
				_client.SelectFolder(_bpmOnlineFolderFullName);
				var strategy = new FlagBasedSyncStrategy(_userConnection);
				return strategy.ValidateCustomFlagsSuport(_client);
			} catch (MailBeeException e) {
				throw new ImapException(LocSyncError.ToString(), e);
			}
		}

		/// <summary>
		/// Synchronizes email messages.
		/// </summary>
		/// <param name="syncAction">Sync action for <see cref="Envelope"/> instance.</param>
		/// <param name="crmFolders">Specific directories to synchronize.</param>
		/// <param name="loadAll">Defines the need to download all messages.</param>
		public void SyncMailMessages(Func<MailMessage, Envelope, bool, string, bool> syncAction, Dictionary<string, List<Guid>> crmFolders, bool loadAll = true) {
			SynchronizationErrorHelper helper = SynchronizationErrorHelper.GetInstance(_userConnection);
			try {
				if (loadAll) {
					_log.Info(string.Format("[{0}] | Loading emails from all folders", _currentMailboxName));
					SyncAllFolders(syncAction, crmFolders);
				} else {
					_log.Info(string.Format("[{0}] | Loading emails from selected folders", _currentMailboxName));
					SyncSelectedFolders(syncAction, crmFolders);
				}
				helper.CleanUpSynchronizationError(_currentMailboxName);
			} catch (Exception ex) {
				helper.ProcessSynchronizationError(_currentMailboxName, ex);
				if (ex is MailBeeException) {
					throw new ImapException(LocSyncError.ToString(), ex);
				}
				throw ex;
			}
		}

		public void Dispose() {
			if (_client != null) {
				try {
					_client.Disconnect();
				} finally {
					_client = null;
				}
			}
		}

		#endregion

	}

	#endregion

}
