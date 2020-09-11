namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Process;
	using Terrasoft.Mail.Sender;
	using Terrasoft.Common;
	using Terrasoft.Core.Entities;


	#region Interface: IMacrosProvider

	public interface IEmailUserTaskMacrosProvider
	{

		#region Properties: Public

		UserConnection UserConnection {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		void ReplaceMacroses(EmailMessage message);

		#endregion

	}

	#endregion

	#region Interface: IEmailUserTaskMessageProvider

	public interface IEmailUserTaskMessageProvider
	{

		#region Properties: Public

		EmailTemplateUserTask EmailUserTask {
			get;
		}

		IEmailUserTaskMacrosProvider MacrosProvider {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		EmailMessage GetEmailMessage();

		#endregion
	}

	#endregion

	#region Interface: IEmailUserTaskSender

	public interface IEmailUserTaskSender
	{
		#region Properties: Public

		UserConnection UserConnection {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		bool Execute(IEmailUserTaskMessageProvider messageProvider, ProcessExecutingContext context);

		bool CompleteExecuting(EmailTemplateUserTask userTask, Func<object[], bool> callBase,
				params object[] parameters);

		void CancelExecuting(EmailTemplateUserTask userTask, Action<object[]> callBase, params object[] parameters);

		string GetExecutionData(EmailTemplateUserTask userTask);

		/// <summary>
		/// Returns instance that implements the <see cref="IProcessNotifier"/> interface.
		/// </summary>
		/// <param name="baseProcessNotifier">Delegate to get base process notifier.</param>
		/// <returns></returns>
		IProcessNotifier GetProcessNotifier(Func<IProcessNotifier> baseProcessNotifier);

		#endregion

	}

	#endregion

	#region Class: BaseProcessEmailMessageProvider

	public abstract class BaseProcessEmailMessageProvider : IEmailUserTaskMessageProvider
	{

		#region Constructors: Protected

		protected BaseProcessEmailMessageProvider(EmailTemplateUserTask userTask) {
			EmailUserTask = userTask;
		}

		#endregion

		#region Properties: Public

		public EmailTemplateUserTask EmailUserTask {
			get;
			private set;
		}

		public IEmailUserTaskMacrosProvider MacrosProvider {
			get;
			set;
		}

		#endregion

		#region Properties: Protected

		protected UserConnection UserConnection {
			get {
				return EmailUserTask.UserConnection;
			}
		}

		#endregion

		#region Methods: Private

		protected virtual EntitySchemaQuery GetSenderEsq() {
			EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MailboxSyncSettings");
			esq.AddColumn("SenderEmailAddress");
			var primariFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", EmailUserTask.Sender);
			esq.Filters.Add(primariFilter);
			esq.UseAdminRights = false;
			return esq;
		}

		private string GetSenderName() {
			var result = string.Empty;
			var mailboxTableEsq = GetSenderEsq();
			Entity entity = mailboxTableEsq.GetEntityCollection(UserConnection).SingleOrDefault();
			if (entity != null) {
				result = entity.GetTypedColumnValue<string>("SenderEmailAddress");
			}
			return result;
		}

		private string GetDefaultEmailSubject() {
			string subject = String.Empty;
			var processSchema = EmailUserTask.Owner.Schema as ProcessSchema;
			if (processSchema != null) {
				var schemaElementCaption = processSchema.GetBaseElementByUId(EmailUserTask.SchemaElementUId).Caption;
				if (!LocalizableString.IsNullOrEmpty(schemaElementCaption)) {
					subject = schemaElementCaption;
				}
			}
			if (string.IsNullOrEmpty(subject)) {
				string resourceItemName = "LocalizableStrings.DefaultEmailSubject.Value";
				subject = new LocalizableString(UserConnection.ResourceStorage,
					"EmailTemplateUserTaskMessageProvider", resourceItemName);
			}
			return subject;
		}

		#endregion

		#region Methods: Protected

		protected abstract string GetEmailBody();

		protected string GetEmailSubject() {
			var subject = string.Empty;
			if (!LocalizableString.IsNullOrEmpty(EmailUserTask.Subject)) {
				subject = EmailUserTask.Subject;
			}
			return subject;
		}

		protected virtual (string Body, string Subject) GetEmailContent() {
			return (GetEmailBody(), GetEmailSubject());
		}

		protected EmailMessage CreateEmailMessage() {
			var emailContnent = GetEmailContent();
			string sender = GetSenderName();
			string subject = string.IsNullOrEmpty(emailContnent.Subject) ? GetDefaultEmailSubject() : emailContnent.Subject;
			string body = emailContnent.Body;
			var emailPriority = (EmailPriority)EmailUserTask.Importance;
			List<string> recepients = EmailUserTask.GetRecipientList();
			List<string> ccRecipients = EmailUserTask.GetCopyRecipientList();
			List<string> bccRecipients = EmailUserTask.GetBlindCopyRecipientList();
			var message = new EmailMessage {
				From = sender,
				To = recepients,
				Priority = emailPriority,
				Cc = ccRecipients,
				Bcc = bccRecipients,
				Subject = subject,
				Body = body,
				IsHtmlBody = true
			};
			return message;
		}

		#endregion

		#region Methods: Public

		public EmailMessage GetEmailMessage() {
			EmailMessage message = CreateEmailMessage();
			if (MacrosProvider != null) {
				MacrosProvider.ReplaceMacroses(message);
			}
			return message;
		}

		#endregion

	}

	#endregion

}

