namespace Terrasoft.Mail 
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using MailBee;
	using MailBee.Mime;
	using MailBee.Security;
	using MailBee.SmtpMail;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Mail.Sender;
#if !NETSTANDARD2_0 // TODO #CRM-42481
	using Terrasoft.Social.OAuth;
#endif

	#region Class: SmtpClient

	[DefaultBinding(typeof(ISmtpClient))]
	public class SmtpClient : ISmtpClient {
		
		#region Enum

		enum AttachmentType { FileAttachment, ListImageAttachment, WebLinkImage }

		#endregion

		#region LocalizableStrings

		public LocalizableString NotEmailTypeError {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.NotEmailTypeError.Value").ToString();
			}
		}
		public LocalizableString EmailSenderNotSetError {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.EmailSenderNotSetError.Value").ToString();
			}
		}
		public LocalizableString NoRecepientError {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.NoRecepientError.Value").ToString();
			}
		}
		public LocalizableString ActivityTypeEmailIsNotDifinedError {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
											 "LocalizableStrings.ActivityTypeEmailIsNotDifinedError.Value").ToString();
			}
		}
		public LocalizableString NoAcceptedRecipientsError {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.NoAcceptedRecipientsError.Value").ToString();
			}
		}
		public LocalizableString TestMessageSubject {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.TestMessageSubject.Value").ToString();
			}
		}
		public LocalizableString TestMessageBody {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.TestMessageBody.Value").ToString();
			}
		}

		public LocalizableString NotAllowedSendingFromThisMailbox {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.NotAllowedSendingFromThisMailbox.Value").ToString();
			}
		}

		public LocalizableString MailBeeSmtpLoginBadCredentials {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.MailBeeSmtpLoginBadCredentials.Value").ToString();
			}
		}

		public LocalizableString MailBeeSocketTimeout {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.MailBeeSocketTimeout.Value").ToString();
			}
		}

		public LocalizableString MailBeeLoginNoCredentials {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.MailBeeLoginNoCredentials.Value").ToString();
			}
		}

		#region LocalizableStrings: New

		/// <summary>
		/// Localizable string with "Mailbox is not exists" error message.
		/// </summary>
		public LocalizableString MailboxDoesNotExist {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.MailboxDoesNotExist.Value").ToString();
			}
		}

		/// <summary>
		/// Localizable string with "Mail server is not exists" error message.
		/// </summary>
		public LocalizableString MailServerDoesNotExist {
			get {
				return new LocalizableString(GetResourceStorage(), "SmtpClient",
					"LocalizableStrings.MailServerDoesNotExist.Value").ToString();
			}
		}

		#endregion

		#endregion

		#region Constructors: Public

		static SmtpClient() {
			MailBee.Global.LicenseKey = "MN110-6DA58BC4A5FCA54AA5BA8059BC03-5DA1";
		}

		public SmtpClient(UserConnection userConnection, MailCredentials mailCredentials)
			:this (userConnection) {
			_credentials = mailCredentials;
		}
		public SmtpClient(UserConnection userConnection) {
			_userConnection = userConnection;
			_listImgId = new Dictionary<Guid, Tuple<AttachmentType, string>>();
		}

		#region Constructors: New

		/// <summary>Initializes <see cref="SmtpClient"/> instance.</summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials">Connection credentials.</param>
		public SmtpClient(UserConnection userConnection, Credentials credentials)
			:this (userConnection) {
			_credentials = CreateMailCredentials(credentials);
		}

		#endregion

		#endregion

		#region Properties: Private

		private MailCredentials _credentials;
		private Dictionary<Guid, Tuple<AttachmentType, string>> _listImgId;
		private UserConnection _userConnection;
		private UserConnection UserConnection {
			get {
				return _userConnection;
			}
		}

		#endregion

		#region Methods: Private

		private IResourceStorage GetResourceStorage() {
			return _userConnection.Workspace.ResourceStorage;
		}

		private Activity LoadActivity(Guid activityId) {
			var activitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("Activity");
			var activity = (Activity)activitySchema.CreateEntity(UserConnection);
			if (!activity.FetchFromDB(activityId)) {
				return null;
			}
			Guid emailTypeId = GetEmailTypeId();
			var activityTypeId = activity.TypeId;
			if (activityTypeId != emailTypeId) {
				throw new SmtpException("NotEmailType", NotEmailTypeError);
			}
			if (string.IsNullOrEmpty(activity.Sender)) {
				throw new SmtpException("EmailSenderNotSet", EmailSenderNotSetError);
			}
#if !NETSTANDARD2_0 // TODO #CRM-44355
			var sender = Terrasoft.UI.WebControls.Utilities.ControlUtilities.HtmlDecode(activity.Sender);
			var splitSender= sender.Split(new Char[] { '<', '>' });
			_credentials = CreateMailCredential(splitSender[1]);
#endif
			return activity;
		}

		private MailMessage CreateMailMessage(Activity activity) {
			var separators = new char[] { ';', ',' };
			string body = SafeGetColumnValue<string>(activity, "Body");
			string title = SafeGetColumnValue<string>(activity, "Title");
#if !NETSTANDARD2_0 // TODO #CRM-44355
			string from = (Terrasoft.UI.WebControls.Utilities.ControlUtilities.HtmlDecode(SafeGetColumnValue<string>(activity, "Sender")).Split(';'))[0];
#else
			string from = string.Empty;
#endif
			MailPriority mailPriority = MailPriority.None;
			var toEmails = new List<string>();
			var ccEmails = new List<string>();
			var bccEmails = new List<string>();

			string toValues = SafeGetColumnValue<string>(activity, "Recepient");
			Guid priority = SafeGetColumnValue<Guid>(activity, "PriorityId");
			if (priority != Guid.Empty) {
				mailPriority = MailPriorityConverter.ConvertPriorityToImportance(priority);
			}
			if (!String.IsNullOrEmpty(toValues)) {
				toEmails.AddRange(toValues.Split(separators));
			}
			string ccValues = SafeGetColumnValue<string>(activity, "CopyRecepient");
			if (!String.IsNullOrEmpty(ccValues)) {
				ccEmails.AddRange(ccValues.Split(separators));
			}
			string bccValue = SafeGetColumnValue<string>(activity, "BlindCopyRecepient");
			if (!String.IsNullOrEmpty(bccValue)) {
				bccEmails.AddRange(bccValue.Split(separators));
			}
			if (toEmails.Count == 0 && ccEmails.Count == 0 && bccEmails.Count == 0) {
				throw new SmtpException("ErrorOnSend", NoRecepientError);
			}
			try {
				var message = new MailMessage {
					Subject = title,
					Charset="utf-8",
					Priority = mailPriority,
					From = new EmailAddress {
						AsString = from
					}
				};
				if (activity.IsHtmlBody) {
					message.BodyHtmlText = ReplaceImgSrc(body, _listImgId);
					message.MailTransferEncodingHtml = MailTransferEncoding.QuotedPrintable;
				} else {
					message.BodyPlainText = body;
					message.MailTransferEncodingPlain  = MailTransferEncoding.QuotedPrintable;
				}
				FillAttachmentsForActivity(activity.PrimaryColumnValue, message.Attachments, _listImgId);
				foreach (var item in toEmails) {
					if (!String.IsNullOrEmpty(item.Trim())) {
						message.To.Add(new EmailAddress {
							AsString = item.Trim()
						});
					}
				}
				foreach (var item in ccEmails) {
					if (!String.IsNullOrEmpty(item.Trim())) {
						message.Cc.Add(new EmailAddress {
							AsString = item.Trim()
						});
					}
				}
				foreach (var item in bccEmails) {
					if (!String.IsNullOrEmpty(item.Trim())) {
						message.Bcc.Add(new EmailAddress {
							AsString = item.Trim()
						});
					}
				}
				return message;
			} catch (FormatException e) {
				throw new SmtpException("ErrorOnSend", e.Message, e);
			}
		}

		private void FillAttachmentsForActivity(Guid activityId, AttachmentCollection mesAttachments, Dictionary<Guid, Tuple<AttachmentType, string>> listImgId) {
			var activitySchema = _userConnection.EntitySchemaManager.GetInstanceByName("ActivityFile");	
			var activityFileSchemaQuery = new EntitySchemaQuery(activitySchema);
			var idQueryColumn = activityFileSchemaQuery.AddColumn("Id");
			activityFileSchemaQuery.Filters.Add(
				activityFileSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Activity", activityId));
			activityFileSchemaQuery.Filters.Add(
				activityFileSchemaQuery.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Type.Code", "Link"));
			var entityCollection = activityFileSchemaQuery.GetEntityCollection(_userConnection);
			var attachments = new Dictionary<Guid, Tuple<byte[], string>>();
			var fileRepository = ClassFactory.Get<FileRepository>(
						new ConstructorArgument("userConnection", _userConnection));
			foreach (var attach in entityCollection) {
				Guid id = attach.GetTypedColumnValue<Guid>(idQueryColumn.Name);		
				using (var memoryStream = new MemoryStream()) {
					var bwriter = new BinaryWriter(memoryStream);
					var fileInfo = fileRepository.LoadFile(activitySchema.UId, id, bwriter);
					attachments.Add(id, Tuple.Create(memoryStream.ToArray(), Path.GetFileName(fileInfo.FileName)));
				}  
			}
			FillFileAttachments(attachments, mesAttachments, listImgId);
			FillAttachmentsFromImageList(mesAttachments, listImgId);
		}

		private void FillFileAttachments(Dictionary<Guid, Tuple<byte[], string>> attachments, AttachmentCollection mesAttachments, Dictionary<Guid, Tuple<AttachmentType, string>> listImgId) {
			foreach (var attach in attachments) {
				byte[] data = attach.Value.Item1;
				string name = attach.Value.Item2;
				Guid id = attach.Key;
				string img = null;
				if (_listImgId.ContainsKey(id))
					img = id.ToString();
				name = Path.GetFileName(name);
				mesAttachments.Add(data, name, img, null, null, NewAttachmentOptions.None, MailTransferEncoding.None);
			}
		}

		private void FillAttachmentsFromImageList(AttachmentCollection attachments, Dictionary<Guid, Tuple<AttachmentType, string>> listImgId) {
			var listImgs = listImgId.Where(item => item.Value.Item1 == AttachmentType.ListImageAttachment);
			foreach (var listImg in listImgs) {
				var strArrayGuid = listImg.Value.Item2.Split('|');
				var imageList = UserConnection.ImageListSchemaManager.GetInstanceByUId(Guid.Parse(strArrayGuid[0]));
				var image = imageList.Items.Where(item => item.UId == Guid.Parse(strArrayGuid[1]));
				foreach (var imgItem in image) {
					byte[] data = null;
					using (MemoryStream ms = new MemoryStream()) {
#if !NETSTANDARD2_0 // TODO #CRM-41873
						imgItem.Image.Value.Save(ms, imgItem.Image.Value.RawFormat);
#endif
						data = ms.ToArray();
					}
					string name = imgItem.Caption;
					string img = listImg.Key.ToString();
					name = Path.GetFileName(name);
					attachments.Add(data, name, img, null, null, NewAttachmentOptions.None, MailTransferEncoding.None);
				}
			}
		}

		private string ReplaceImgSrc(string htmlBody, Dictionary<Guid, Tuple<AttachmentType, string>> listId) {
#if !NETSTANDARD2_0 // TODO #CRM-44355
			htmlBody = Terrasoft.UI.WebControls.Utilities.ControlUtilities.HtmlDecode(htmlBody);
#endif
			string regexStr = @"(s=db&sn=)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})(&id=)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})(&t=)(.*?)(&sc=)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})";
			Regex regex = new Regex(regexStr, RegexOptions.IgnoreCase);
			MatchCollection matchCollection = regex.Matches(htmlBody);
			if (matchCollection != null && matchCollection.Count > 0) {
				foreach (Match match in matchCollection) {
					if (match.Groups.Count > 5) {
						listId[Guid.Parse(match.Groups[4].ToString())] = Tuple.Create(AttachmentType.FileAttachment, string.Empty);
						htmlBody = htmlBody.Replace(string.Format("./terrasoft.axd?{0}", match.Groups[0].ToString()), string.Format("cid:{0}", match.Groups[4].ToString()));
					}
				}
			}
			regexStr = @"(s=shm&sid=)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})(&r=)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})(&t=)(.*?)";
			regex = new Regex(regexStr, RegexOptions.IgnoreCase);
			matchCollection = regex.Matches(htmlBody);
			if (matchCollection != null && matchCollection.Count > 0) {
				foreach (Match match in matchCollection) {
					if (match.Groups.Count > 5) {
						listId[Guid.Parse(match.Groups[4].ToString())] = Tuple.Create(AttachmentType.ListImageAttachment, match.Groups[2].ToString()+"|"+match.Groups[4].ToString());
						htmlBody = htmlBody.Replace(string.Format("./terrasoft.axd?{0}undefined", match.Groups[0].ToString()), string.Format("cid:{0}", match.Groups[4].ToString()));
					}
				}
			}
			regexStr = @"(../rest/FileService/GetFile/)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})(/)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})";
			regex = new Regex(regexStr, RegexOptions.IgnoreCase);
			matchCollection = regex.Matches(htmlBody);
			if (matchCollection != null && matchCollection.Count > 0) {
				foreach (Match match in matchCollection) {
					if (match.Groups.Count > 4) {
						listId[Guid.Parse(match.Groups[4].ToString())] = Tuple.Create(AttachmentType.FileAttachment, match.Groups[2].ToString()+"|"+match.Groups[4].ToString());
						htmlBody = htmlBody.Replace("../rest/FileService/GetFile/080C9917-7EC9-42E5-86FF-75A683D4F124/", "cid:");
					}
				}
			}
			//htmlBody = htmlBody.Replace("(../rest/FileService/GetFile/)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})(/)([A-Z0-9]{8}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{12})", "cid:");
			return htmlBody;
		}

		private MailCredentials CreateMailCredential(string emailAddress) {
			var mailboxESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MailboxSyncSettings");
			EntitySchemaQueryColumn isAnonymousAuthenticationColumn = mailboxESQ.AddColumn("IsAnonymousAuthentication");
			EntitySchemaQueryColumn userNameColumn = mailboxESQ.AddColumn("UserName");
			EntitySchemaQueryColumn userPasswordColumn = mailboxESQ.AddColumn("UserPassword");
			EntitySchemaQueryColumn sendEmailsViaThisAccountColumn = mailboxESQ.AddColumn("SendEmailsViaThisAccount");
			EntitySchemaQueryColumn smtpHostColumn = mailboxESQ.AddColumn("MailServer.SMTPServerAddress");
			EntitySchemaQueryColumn smtpPortColumn = mailboxESQ.AddColumn("MailServer.SMTPPort");
			EntitySchemaQueryColumn smtpSSLColumn = mailboxESQ.AddColumn("MailServer.UseSSLforSending");
			EntitySchemaQueryColumn smtpTimeoutColumn = mailboxESQ.AddColumn("MailServer.SMTPServerTimeout");

			IEntitySchemaQueryFilterItem sysAdminUnitFilter = mailboxESQ
				.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnit", UserConnection.CurrentUser.Id);
			IEntitySchemaQueryFilterItem senderEmailAddressFilter = mailboxESQ
				.CreateFilterWithParameters(FilterComparisonType.Equal, "SenderEmailAddress", emailAddress);
			mailboxESQ.Filters.Add(sysAdminUnitFilter);
			mailboxESQ.Filters.Add(senderEmailAddressFilter);
			var mailboxEntities = mailboxESQ.GetEntityCollection(UserConnection);
			MailCredentials mr = new MailCredentials();
			if (mailboxEntities.Count > 0) {
				Entity mailBox = mailboxEntities[0];
				if (!mailBox.GetTypedColumnValue<bool>(sendEmailsViaThisAccountColumn.Name)) {
					throw new SmtpException("ErrorOnSend", NotAllowedSendingFromThisMailbox);
				}
				mr.Host = mailBox.GetTypedColumnValue<string>(smtpHostColumn.Name);
				mr.Port = mailBox.GetTypedColumnValue<int>(smtpPortColumn.Name);
				if (mailBox.GetTypedColumnValue<bool>(isAnonymousAuthenticationColumn.Name)) {
					mr.IsAnonymousAuthentication = true;
				} else {
					mr.UserName = mailBox.GetTypedColumnValue<string>(userNameColumn.Name);
					mr.UserPassword = mailBox.GetTypedColumnValue<string>(userPasswordColumn.Name);
				}
				mr.UseSsl = mailBox.GetTypedColumnValue<bool>(smtpSSLColumn.Name);
				mr.Timeout = mailBox.GetTypedColumnValue<int>(smtpTimeoutColumn.Name) * 1000;
			}
			return mr;
		}

		private void SendMessage(MailMessage message) {
			try {
				using (var client = CreateSmtpClient()) {
					client.Message = message;
					client.Send();
				}
			} catch (MailBeeLoginNoCredentialsException) {
				throw new SmtpException("ErrorOnSend", MailBeeLoginNoCredentials);
			} catch (MailBeeSmtpNoAcceptedRecipientsException e) {
				throw new SmtpException("ErrorOnSend", NoAcceptedRecipientsError, e);
			} catch (MailBeeSmtpLoginBadCredentialsException e) {
				throw new SmtpException("ErrorOnSend", MailBeeSmtpLoginBadCredentials, e);
			} catch (MailBeeSocketTimeoutException e) {
				throw new SmtpException("ErrorOnSend", MailBeeSocketTimeout, e);
			} catch (Exception e) {
				throw new SmtpException("ErrorOnSend", e.Message, e);
			}
		}

		private Smtp CreateSmtpClient(bool ignoreRights = false) {
			var client = new Smtp();
			SmtpServer server = new SmtpServer() {
				Name = _credentials.Host,
				AccountName = _credentials.UserName,
				Port = _credentials.Port,
				Password = _credentials.UserPassword,
				SslMode = _credentials.UseSsl ? SslStartupMode.OnConnect : SslStartupMode.Manual,
				Timeout = _credentials.Timeout,
				SmtpOptions = ExtendedSmtpOptions.NoChunking,
			};

			if (_credentials.UseOAuth) {
				string oauthClassName = GetOAuthClientClassNameBySender(_credentials.SenderEmailAddress, ignoreRights);
#if !NETSTANDARD2_0 // TODO #CRM-42481
				OAuthClient oauthClient = (OAuthClient)Activator.CreateInstance(Type.GetType("Terrasoft.Configuration." + oauthClassName), _credentials.SenderEmailAddress, _userConnection);
				string token = oauthClient.GetAccessToken();
				string xOAuthKey = OAuth2.GetXOAuthKeyStatic(_credentials.SenderEmailAddress, token);
				server.Password = xOAuthKey;
#endif
				server.AuthMethods |= AuthenticationMethods.SaslOAuth2;
				client.SmtpServers.Add(server);
			} else {
				client.SmtpServers.Add(server);
				server.AuthMethods = GetAuthenticationMethods(client);
			}
			return client;
		}

		/// <summary>
		/// Returns OAuth client class name by the specific sender email address.
		/// </summary>
		/// <param name="emailSender">User sender email address.</param>
		/// <returns>OAuth client class name.</returns>
		private string GetOAuthClientClassNameBySender(string emailSender, bool ignoreRights = false) {
			EntitySchemaQuery esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "MailboxSyncSettings");
			EntitySchemaQueryColumn column = esq.AddColumn("MailServer.OAuthApplication.ClientClassName");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SenderEmailAddress", emailSender));
			if (ignoreRights) {
				esq.UseAdminRights = false;
			} else {
				esq.AddRightsFilters(_userConnection.CurrentUser.Id);
			}
			Entity mailbox = esq.GetEntityCollection(_userConnection).FirstOrDefault();
			if (mailbox != null) {
				return mailbox.GetTypedColumnValue<string>(column.Name);
			} else {
				return null;
			}
		}

		private AuthenticationMethods GetAuthenticationMethods(Smtp client) {
			if (client == null) {
				string errMessage = string.Format("Smtp client should be initialized.");
				throw new NullReferenceException(errMessage);
			}
			if (_credentials.IsAnonymousAuthentication) {
				return AuthenticationMethods.None;
			}
			client.Connect();
			client.Hello();
			AuthenticationMethods methods = client.GetSupportedAuthMethods();
			client.Disconnect();
			return methods;
		}

		private Guid GetActivityStatusByCode(string code) {
			var activityStatusSchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ActivityStatus");
			var idQueryColumn = activityStatusSchemaQuery.AddColumn("Id");
			activityStatusSchemaQuery.AddColumn("Code");
			activityStatusSchemaQuery.Filters.Add(activityStatusSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", code));
			var entityCollection = activityStatusSchemaQuery.GetEntityCollection(UserConnection);
			if (entityCollection.Count > 0) {
				return entityCollection[0].GetTypedColumnValue<Guid>(idQueryColumn.Name);
			}
			return Guid.Empty;
		}

		private void UpdateActivityStatus(Guid activityId, string emailSendStatus, string errorOnSendMessage) {
			Guid emailSendStatusId;
			Guid activityStatusId = Guid.Empty;
			bool isEmailSended = false;
			switch (emailSendStatus) {
				case "Sended":
					isEmailSended = true;
					emailSendStatusId = FindEmailSendStatus("Sended");
					activityStatusId = GetActivityStatusByCode("Finished");
					break;
				case "NotSend":
				case "InProgress":
				case "ErrorOnSend":
					emailSendStatusId = FindEmailSendStatus(emailSendStatus);
					break;
				default:
					emailSendStatusId = FindEmailSendStatus("ErrorOnSend");
					errorOnSendMessage = emailSendStatus + ": " + errorOnSendMessage;
					break;
			}
			var update = new Update(UserConnection, "Activity")
				.Set("EmailSendStatusId", Column.Parameter(emailSendStatusId))
				.Set("ErrorOnSend", Column.Parameter(errorOnSendMessage))
				.Where("Id").IsEqual(Column.Parameter(activityId)) as Update;
			if (isEmailSended) {
				update.Set("StatusId", Column.Parameter(activityStatusId));
			}
			update.Execute();
		}

		private Guid FindEmailSendStatus(string code) {
			return ((Select)new Select(UserConnection).Top(1)
				.Column("Id")
				.From("EmailSendStatus")
			.Where("Code").IsEqual(Column.Parameter(code))).ExecuteScalar<Guid>();
		}

		private void SetCurrentUserAsSenderIfEmpty(Activity activity) {
			string sender = SafeGetColumnValue<string>(activity, "Sender");
			if (String.IsNullOrEmpty(sender)) {
				sender = ((Select)new Select(UserConnection)
					.Column("Email")
					.From("Contact")
					.Where("Id").IsEqual(Column.Parameter(UserConnection.CurrentUser.ContactId)))
					.ExecuteScalar<string>();
				if (String.IsNullOrEmpty(sender)) {
					throw new SmtpException("ErrorOnSend", EmailSenderNotSetError);
				}
				activity.Sender = sender;
			}
		}

		private void CompleteSending(Activity activity) {
			activity.SetColumnValue("StatusId", "4BDBB88F-58E6-DF11-971B-001D60E938C6"); // Finished
			activity.SendDate = UserConnection.CurrentUser.GetCurrentDateTime();
			activity.Save();
			Update update = new Update(UserConnection, "ActivityParticipant")
				.Set("ReadMark", Column.Parameter(true))
				.Where("ActivityId").IsEqual(Column.Parameter(activity.PrimaryColumnValue))
				.And("ParticipantId").IsEqual(Column.Parameter(UserConnection.CurrentUser.ContactId)) as Update;
			update.Execute();
		}

		private Guid GetEmailTypeId() {
			var select = new Select(UserConnection).Top(1)
				.Column("Id")
				.From("ActivityType")
				.Where("Code").IsEqual(Column.Parameter("Email")) as Select;
			Guid emailTypeId = select.ExecuteScalar<Guid>();
			if (emailTypeId == Guid.Empty) {
				throw new SmtpException("ErrorOnSend", ActivityTypeEmailIsNotDifinedError);
			}
			return emailTypeId;
		}

		private T SafeGetColumnValue<T>(Entity entity, string columnName) {
			if (entity.IsColumnValueLoaded(columnName)) {
				return entity.GetTypedColumnValue<T>(columnName);
			}
			return default(T);
		}

		#region Methods: Private: New

		private static MailBee.Mime.EmailAddressCollection GetEmailAddressCollection(IEnumerable<string> emailAddresses) {
			var emailAddressCollection = new MailBee.Mime.EmailAddressCollection();
			foreach (var emailAddress in emailAddresses) {
				emailAddressCollection.Add(emailAddress.ExtractEmailAddress());
			}
			return emailAddressCollection;
		}

		private MailMessage SetAttachments(MailMessage mailMessage, IEnumerable<Sender.EmailAttachment> emailAttachments) {
			var mailTransferEncoding = MailTransferEncoding.Base64;
			foreach (Sender.EmailAttachment emailAttachment in emailAttachments) {
				string contenId = emailAttachment.IsContent ? emailAttachment.Id.ToString() : string.Empty;
				mailMessage.Attachments.Add(emailAttachment.Data, emailAttachment.Name, contenId, null, null,
					NewAttachmentOptions.None, mailTransferEncoding);
				var file = mailMessage.Attachments[mailMessage.Attachments.Count - 1];
				file.Headers.Add("Content-Disposition", emailAttachment.IsContent ? "inline" : "attachment", true);
				if (mailMessage.BodyHtmlText.Contains("cid:" + emailAttachment.Id)) {
					ActivityUtils.SetInlineFlagAtActivityFile(_userConnection, emailAttachment.Id);
				}
			}
			return mailMessage;
		}

		private static MailPriority GetMailBeePriority(Sender.EmailPriority emailPriority) {
			switch (emailPriority) {
				case Sender.EmailPriority.None:
					return MailPriority.None;
				case Sender.EmailPriority.Normal:
					return MailPriority.Normal;
				case Sender.EmailPriority.High:
					return MailPriority.High;
				case Sender.EmailPriority.Low:
					return MailPriority.Low;
				default:
					return MailPriority.None;
			}
		}

		private MailMessage CreateMaillBeeMessage(Sender.EmailMessage emailMessage) {
			MailBee.Mime.EmailAddressCollection to = GetEmailAddressCollection(emailMessage.To);
			MailBee.Mime.EmailAddressCollection cc = GetEmailAddressCollection(emailMessage.Cc);
			MailBee.Mime.EmailAddressCollection bcc = GetEmailAddressCollection(emailMessage.Bcc);
			MailPriority mailPriority = GetMailBeePriority(emailMessage.Priority);
			string senderEmailAddress = emailMessage.From.ExtractEmailAddress();
			string displayName = FindContactNameForMailbox(senderEmailAddress, _userConnection);
			var mailMessage = new MailMessage {
				Subject = emailMessage.Subject,
				Charset = "utf-8",
				Priority = mailPriority,
				From = new MailBee.Mime.EmailAddress {
					AsString = senderEmailAddress,
					DisplayName = displayName
				},
				To = to,
				Cc = cc,
				Bcc = bcc,
				MailTransferEncodingHtml = MailTransferEncoding.QuotedPrintable
			};
			mailMessage = SetHeaderProperties(mailMessage, emailMessage);
			if (emailMessage.IsHtmlBody) {
				mailMessage.BodyHtmlText = emailMessage.Body;
			} else {
				mailMessage.BodyPlainText = emailMessage.Body;
			}
			mailMessage = SetAttachments(mailMessage, emailMessage.Attachments);
			bool hasFileAttachment = emailMessage.Attachments.Any(att => att.IsContent == false);
			if (hasFileAttachment) {
				//todo #CRM-26964 Content-Type multipart/related to multipart/mixed via methods
				mailMessage = fixContentTypeHeader(mailMessage);
			}
			return mailMessage;
		}

		/// <summary>
		/// Sets message header properties from <paramref name="bpmMessage"/> to <paramref name="mailMessage"/>.
		/// </summary>
		/// <param name="mailMessage"><see cref="MailMessage"/> instance.</param>
		/// <param name="bpmMessage"><see cref="Sender.EmailMessage"/> instance.</param>
		/// <returns><see cref="MailMessage"/> instance.</returns>
		private MailMessage SetHeaderProperties(MailMessage mailMessage, Sender.EmailMessage bpmMessage) {
			List<Sender.EmailMessageHeader> emailMessageHeader = bpmMessage.HeaderProperties;
			if (emailMessageHeader != null) {
				foreach (var property in emailMessageHeader) {
					mailMessage.Headers[property.Name] = property.Value;
				}
			}
			mailMessage.MessageID = bpmMessage.GetMessageId();
			return mailMessage;
		}

		private MailMessage fixContentTypeHeader(MailMessage message) {
			//Serialize 
			MemoryStream stream = new MemoryStream();
			message.SaveMessage(stream);
			stream.Position = 0;
			using (StreamReader reader = new StreamReader(stream, Encoding.UTF8)) {
				string value = reader.ReadToEnd();
				//fix headers
				value = value.Replace("multipart/related", "multipart/mixed");
				//Deserialize
				byte[] byteArray = Encoding.UTF8.GetBytes(value);
				stream = new MemoryStream(byteArray);
				message.LoadMessage(stream);
			}
			return message;
		}

		private MailCredentials CreateMailCredentials(Credentials credentials) {
			var mailServerESQ = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "MailServer");
			EntitySchemaQueryColumn hostColumn = mailServerESQ.AddColumn("SMTPServerAddress");
			EntitySchemaQueryColumn portColumn = mailServerESQ.AddColumn("SMTPPort");
			EntitySchemaQueryColumn SSLColumn = mailServerESQ.AddColumn("UseSSLforSending");
			EntitySchemaQueryColumn timeoutColumn = mailServerESQ.AddColumn("SMTPServerTimeout");
			IEntitySchemaQueryFilterItem idFilter = mailServerESQ
				.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", credentials.ServerId);
			mailServerESQ.Filters.Add(idFilter);
			EntityCollection mailServerEntities = mailServerESQ.GetEntityCollection(_userConnection);
			Entity mailServer = mailServerEntities[0];
			var mailCredentials = new MailCredentials();
			mailCredentials.Host = mailServer.GetTypedColumnValue<string>(hostColumn.Name);
			mailCredentials.Port = mailServer.GetTypedColumnValue<int>(portColumn.Name);
			mailCredentials.UseSsl = mailServer.GetTypedColumnValue<bool>(SSLColumn.Name);
			mailCredentials.Timeout = mailServer.GetTypedColumnValue<int>(timeoutColumn.Name) * 1000;
			mailCredentials.UserName = credentials.UserName;
			mailCredentials.UserPassword = credentials.UserPassword;
			mailCredentials.IsAnonymousAuthentication = false;
			return mailCredentials;
		}

		private MailCredentials CreateMailCredentialByAddress(string address, bool ignoreRights = false) {
			var mailboxESQ = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "MailboxSyncSettings");
			EntitySchemaQueryColumn userNameColumn = mailboxESQ.AddColumn("UserName");
			EntitySchemaQueryColumn userPasswordColumn = mailboxESQ.AddColumn("UserPassword");
			EntitySchemaQueryColumn isAnonymousAuthentication = mailboxESQ.AddColumn("IsAnonymousAuthentication");
			EntitySchemaQueryColumn sendEmailsViaThisAccountColumn = mailboxESQ.AddColumn("SendEmailsViaThisAccount");
			EntitySchemaQueryColumn smtpHostColumn = mailboxESQ.AddColumn("MailServer.SMTPServerAddress");
			EntitySchemaQueryColumn smtpPortColumn = mailboxESQ.AddColumn("MailServer.SMTPPort");
			EntitySchemaQueryColumn smtpSslColumn = mailboxESQ.AddColumn("MailServer.UseSSLforSending");
			EntitySchemaQueryColumn smtpTimeoutColumn = mailboxESQ.AddColumn("MailServer.SMTPServerTimeout");
			EntitySchemaQueryColumn useOAuth = mailboxESQ.AddColumn("MailServer.OAuthApplication.ClientClassName");
			EntitySchemaQueryColumn tokenColumn = mailboxESQ.AddColumn("OAuthTokenStorage");
			IEntitySchemaQueryFilterItem senderEmailAddressFilter = mailboxESQ
				.CreateFilterWithParameters(FilterComparisonType.Equal, "SenderEmailAddress", address);
			mailboxESQ.Filters.Add(senderEmailAddressFilter);
			if (ignoreRights) {
				mailboxESQ.UseAdminRights = false;
			} else {
				mailboxESQ.AddRightsFilters(_userConnection.CurrentUser.Id);
			}
			EntityCollection mailboxEntities = mailboxESQ.GetEntityCollection(_userConnection);
			var mailCredentials = new MailCredentials();
			if (mailboxEntities.Count == 0) {
				throw new EmailException("ErrorOnSend", MailboxDoesNotExist);
			}
			Entity mailbox = mailboxEntities[0];
			if (!mailbox.GetTypedColumnValue<bool>(sendEmailsViaThisAccountColumn.Name)) {
				throw new EmailException("ErrorOnSend", NotAllowedSendingFromThisMailbox);
			}
			mailCredentials.SenderEmailAddress = address;
			mailCredentials.Host = mailbox.GetTypedColumnValue<string>(smtpHostColumn.Name);
			mailCredentials.Port = mailbox.GetTypedColumnValue<int>(smtpPortColumn.Name);
			mailCredentials.UserName = mailbox.GetTypedColumnValue<string>(userNameColumn.Name);
			mailCredentials.UserPassword = mailbox.GetTypedColumnValue<string>(userPasswordColumn.Name);
			mailCredentials.UseSsl = mailbox.GetTypedColumnValue<bool>(smtpSslColumn.Name);
			mailCredentials.Timeout = mailbox.GetTypedColumnValue<int>(smtpTimeoutColumn.Name) * 1000;
			mailCredentials.IsAnonymousAuthentication = mailbox.GetTypedColumnValue<bool>(isAnonymousAuthentication.Name);
			mailCredentials.UseOAuth = mailbox.GetTypedColumnValue<string>(useOAuth.Name).IsNotNullOrEmpty() && 
				mailbox.GetTypedColumnValue<Guid>(tokenColumn.ValueQueryAlias).IsNotEmpty();
			return mailCredentials;
		}

		/// <summary>Returns <see cref="Contact"/> name for mailbox.</summary>
		/// <param name="emailAddress">Email address.</param>
		/// <param name="userConnection">User connection instance.</param>
		/// <returns>Mail settings contact password.</returns>
		private string FindContactNameForMailbox(String emailAddress, UserConnection userConnection) {
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "MailboxSyncSettings");
			var nameColumn = esq.AddColumn("SysAdminUnit.Contact.Name");
			var senderDisplayValueColumn = esq.AddColumn("SenderDisplayValue");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, false, "SenderEmailAddress",
				emailAddress));
			var mailboxEntities = esq.GetEntityCollection(UserConnection);
			if (mailboxEntities.Count > 0) {
				Entity mailBox = mailboxEntities[0];
				string senderDisplayValue = mailBox.GetTypedColumnValue<string>(senderDisplayValueColumn.Name);
				return senderDisplayValue.IsNotNullOrEmpty() ? senderDisplayValue : mailBox.GetTypedColumnValue<string>(nameColumn.Name);
			}
			return string.Empty;
		}

		#endregion

		#endregion

		#region Methods: Protected

		/// <summary> Creates <see cref="MailBee.SmtpMail.Smtp"/> instance.</summary>
		/// <returns>Smtp instance.</returns>
		protected virtual Smtp CreateSmtp(string address, bool ignoreRights = false) {
			if (_credentials == null) {
				_credentials = CreateMailCredentialByAddress(address, ignoreRights);
			}
			return CreateSmtpClient(ignoreRights);
		}

		#endregion

		#region Methods: Public

		public MailCredentials CreateMailCredentials(string senderEmailAddress) {
			var mailboxESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MailboxSyncSettings");
			EntitySchemaQueryColumn senderEmailAddressColumn = mailboxESQ.AddColumn("SenderEmailAddress");
			IEntitySchemaQueryFilterItem sysAdminUnitFilter = mailboxESQ
				.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnit", UserConnection.CurrentUser.Id);
			IEntitySchemaQueryFilterItem userEmailFilter = mailboxESQ
				.CreateFilterWithParameters(FilterComparisonType.Equal, "SenderEmailAddress", senderEmailAddress);
			mailboxESQ.Filters.Add(sysAdminUnitFilter);
			mailboxESQ.Filters.Add(userEmailFilter);
			var mailboxEntities = mailboxESQ.GetEntityCollection(UserConnection);
			if (mailboxEntities.Count > 0) {
				Entity mailBox = mailboxEntities[0];
				string emailAddress = mailBox.GetTypedColumnValue<string>(senderEmailAddressColumn.Name);
				return CreateMailCredential(emailAddress);
			}
			return new MailCredentials();
		}

		public void SendMessage(MailMessage message, MailCredentials credentials) {
			try {
				_credentials = credentials;
				SendMessage(message);
			} catch (SmtpException) {
				throw;
			}
		}

		public Activity SendMessage(Guid activityId) {
			Activity activity = null;
			try {
				activity = LoadActivity(activityId);
				UpdateActivityStatus(activityId, "InProgress", string.Empty);
				SetCurrentUserAsSenderIfEmpty(activity);
				MailMessage message = CreateMailMessage(activity);
				SendMessage(message);
				CompleteSending(activity);
				UpdateActivityStatus(activityId, "Sended", string.Empty);
			} catch (SmtpException e) {
				UpdateActivityStatus(activityId, e.EmailSendStatus, e.Message);
				throw;
			}
			return activity;
		}

		public MailMessage CreateMessage(string htmlBody, string subject, string[] to, string from, bool isHtmlBody, Dictionary<Guid, Tuple<byte[], string>> attachments,
				string activityPriorityId = "ab96fa02-7fe6-df11-971b-001d60e938c6", string charset = "utf-8") {
#if !NETSTANDARD2_0 // TODO #CRM-44355
			from = (Terrasoft.UI.WebControls.Utilities.ControlUtilities.HtmlDecode(from));
#endif
			MailPriority mailPriority = MailPriorityConverter.ConvertPriorityToImportance(new Guid(activityPriorityId));
			var toEmails = new List<string>();

			if (to == null) {
				throw new SmtpException("ErrorOnSend", NoRecepientError);
			}
			if (to.Length != 0) {
				foreach (string r in to) {
					if (r.Trim() != String.Empty) {
						toEmails.Add(r);
					}
				}
			}
			if (toEmails.Count == 0) {
				throw new SmtpException("ErrorOnSend", NoRecepientError);
			}
			try {
				var message = new MailMessage {
					Subject = subject,
					Charset=charset,
					Priority = mailPriority,
					From = new EmailAddress {
						AsString = from
					}
				};
				if (isHtmlBody) {
					message.BodyHtmlText = ReplaceImgSrc(htmlBody, _listImgId);
					message.MailTransferEncodingHtml = MailTransferEncoding.QuotedPrintable;
				} else {
					message.BodyPlainText = htmlBody;
					message.MailTransferEncodingPlain  = MailTransferEncoding.QuotedPrintable;
				}

				FillFileAttachments(attachments, message.Attachments, _listImgId);
				FillAttachmentsFromImageList(message.Attachments, _listImgId);

				foreach (var item in toEmails) {
					if (!String.IsNullOrEmpty(item.Trim())) {
						message.To.Add(new EmailAddress {
							AsString = item.Trim()
						});
					}
				}
				return message;
			} catch (FormatException e) {
				throw new SmtpException("ErrorOnSend", e.Message, e);
			}
		}

		public void SendTestMessage() {
			var testMessage = new MailMessage {
				Subject = TestMessageSubject.Value,
				BodyHtmlText = TestMessageBody.Value,
				Charset = "utf-8",
				From = new EmailAddress {
					AsString = _credentials.SenderEmailAddress
				}
			};
			testMessage.To.Add(new EmailAddress { AsString = string.Format("BPMonline<{0}>", _credentials.SenderEmailAddress) });
			SendMessage(testMessage);
		}

		#region Methods: Public: New

		/// <summary>
		/// Sends <paramref name="emailMessage"/>.</summary>
		/// <param name="emailMessage">email message.</param>
		/// <param name="ignoreRights">Flag that indicates whether to ignore rights.</param>
		public void Send(Sender.EmailMessage emailMessage, bool ignoreRights = false) {
			MailMessage mailMessage = CreateMaillBeeMessage(emailMessage);
			try {
				using (Smtp smtp = CreateSmtp(emailMessage.From.ExtractEmailAddress(), ignoreRights)) {
					smtp.Message = mailMessage;
					smtp.Send();
					DateTime sendDate = mailMessage.Date;
					if (sendDate.Kind == DateTimeKind.Utc) {
						sendDate = TimeZoneInfo.ConvertTimeFromUtc(sendDate, _userConnection.CurrentUser.TimeZone);
					} else {
						sendDate = TimeZoneInfo.ConvertTimeFromUtc(sendDate.ToUniversalTime(), _userConnection.CurrentUser.TimeZone);
					}
					emailMessage.SendDate = sendDate;
				}
			} catch (MailBeeLoginNoCredentialsException) {
				throw new EmailException("ErrorOnSend", MailBeeLoginNoCredentials);
			} catch (MailBeeSmtpNoAcceptedRecipientsException e) {
				throw new EmailException("ErrorOnSend", NoAcceptedRecipientsError, e);
			} catch (MailBeeSmtpLoginBadCredentialsException e) {
				throw new EmailException("ErrorOnSend", MailBeeSmtpLoginBadCredentials, e);
			} catch (MailBeeSocketTimeoutException e) {
				throw new EmailException("ErrorOnSend", MailBeeSocketTimeout, e);
			} catch (Exception e) {
				throw new EmailException("ErrorOnSend", e.Message, e);
			}
		}

		#endregion

		#endregion


	}

	#endregion

	#region Class: MailPriorityConverter

	public static class MailPriorityConverter {

		private static Dictionary<MailPriority, Guid> GetPriorityMapping() {
			var highPriorityId = new Guid("d625a9fc-7ee6-df11-971b-001d60e938c6");
			var normalPriorityId = new Guid("ab96fa02-7fe6-df11-971b-001d60e938c6");
			var lowPriorityId = new Guid("ac96fa02-7fe6-df11-971b-001d60e938c6");
			var PriorityMapping = new Dictionary<MailPriority, Guid>() {
						{MailPriority.None, normalPriorityId},
						{MailPriority.Normal, normalPriorityId},
						{MailPriority.High, highPriorityId},
						{MailPriority.Highest, highPriorityId},
						{MailPriority.Low, lowPriorityId},
						{MailPriority.Lowest, lowPriorityId}
					};
			return PriorityMapping;
		}
		public static MailPriority ConvertPriorityToImportance(Guid priority) {
			var priorityMapping = GetPriorityMapping();
			foreach (var pair in priorityMapping) {
				if (pair.Value == priority) {
					return pair.Key;
				}
			}
			return MailPriority.None;
		}
	}

	#endregion

	#region Class: SmtpClientCredentialsUtility

	internal static class SmtpClientCredentialsUtility
	{

		/// <summary>
		/// Adds <see cref="EntitySchemaQuery"/> filters to select users with mailbox rights granted.
		/// </summary>
		/// <param name="esq"><see cref="EntitySchemaQuery"/> instance.</param>
		/// <param name="currentUserId">Current user identifier.</param>
		internal static void AddRightsFilters(this EntitySchemaQuery esq, Guid currentUserId) {
			var helper = ClassFactory.Get<EmailMessageHelper>(
				new ConstructorArgument("userConnection", null));
			helper.AddMailboxRightsFilters(esq, currentUserId);
		}
	}

	#endregion

}
