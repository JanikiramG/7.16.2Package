namespace Terrasoft.Core.Process.Configuration
{
	using System.Collections.Generic;
	using System.Text.RegularExpressions;
	using Core.Process;
	using Terrasoft.Configuration;

	#region Class: EmailTemplateUserTask

	/// <summary>
	/// Partial class of EmailTemplateUserTask, that implement user task runtime behaviour.
	/// </summary>
	public partial class EmailTemplateUserTask
	{

		#region Constants: Private

		private const string dynamicParameterNamePrefixRegexTempalte = @"^{0}\d+$";

		#endregion

		#region Fields: Private

		private IEmailUserTaskMessageProvider _messageProvider;

		#endregion

		#region Properties: Private

		private IEmailUserTaskSender _emailSender;
		private IEmailUserTaskSender EmailSender {
			get {
				if (_emailSender == null) {
					_emailSender = EmailUserTaskSenderFactory.GetEmailSender(this);
				}
				return _emailSender;
			}
		}

		#endregion

		#region Properties: Protected

		protected override IProcessNotifier ProcessNotifier {
			get {
				return EmailSender.GetProcessNotifier(() => base.ProcessNotifier);
			}
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Returns true if process is interpretable.
		/// </summary>
		public bool CanUseFlowEngine {
			get {
				return UseFlowEngineMode;
			}
		}

		private MacrosExtendedProperties _macrosExtendedProperties;
		public MacrosExtendedProperties MacrosExtendedProperties {
			get => _macrosExtendedProperties ?? (_macrosExtendedProperties = new MacrosExtendedProperties());
			set => _macrosExtendedProperties = value;
		}

		#endregion

		#region Methods: Protected

		protected virtual List<ProcessSchemaParameter> GetFilteredParametersList(string parameterNamePrefix) {
			string pattern = string.Format(dynamicParameterNamePrefixRegexTempalte, parameterNamePrefix);
			var regex = new Regex(pattern);
			BaseProcessSchemaElement userTaskSchema = GetSchemaElement();
			var processParametersMetaInfo = userTaskSchema as IProcessParametersMetaInfo;
			var result = new List<ProcessSchemaParameter>();
			if (processParametersMetaInfo == null) {
				return result;
			}
			ProcessSchemaParameterCollection parameters = processParametersMetaInfo.ForceGetParameters();
			if (parameters == null || parameters.Count == 0) {
				return result;
			}
			Schema schema = Owner.Schema;
			foreach (ProcessSchemaParameter parameter in parameters) {
				if (parameter.CreatedInSchemaUId == schema.UId && regex.IsMatch(parameter.Name)) {
					result.Add(parameter);
				}
			}
			return result;
		}

		protected virtual List<string> GetEmailAddresses(string parameterNamePrefix) {
			var emailAddresses = new List<string>();
			var parameters = GetFilteredParametersList(parameterNamePrefix);
			foreach (ProcessSchemaParameter parameter in parameters) {
				object propertyValue = GetParameterValue(parameter);
				List<string> parameterAddresses = EmailTemplateUserTaskUtilities
					.GetParameterEmailAddresses(UserConnection, propertyValue, parameter);
				emailAddresses.AddRange(parameterAddresses);
			}
			return emailAddresses;
		}

		protected override bool InternalExecute(ProcessExecutingContext context) {
			IEmailUserTaskMessageProvider messageProvider = GetMessageProvider();
			return EmailSender.Execute(messageProvider, context);
		}

		protected IEmailUserTaskMessageProvider GetMessageProvider() {
			if (_messageProvider == null) {
				_messageProvider = EmailUserTaskMessageProviderFactory.GetEmailMessageProvider(this);
				_messageProvider.MacrosProvider = CreateMacrosProvider();
			}
			return _messageProvider;
		}

		protected virtual IEmailUserTaskMacrosProvider CreateMacrosProvider() {
			return EmailUserTaskMacrosHelperFactory.GetMacrosHelper(this, UserConnection);
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return EmailSender.CompleteExecuting(this, base.CompleteExecuting, parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			EmailSender.CancelExecuting(this, base.CancelExecuting, parameters);
		}

		public override string GetExecutionData() {
			return EmailSender.GetExecutionData(this);
		}

		/// <summary>
		/// Returns data of the process element notification event.
		/// </summary>
		/// <returns>Instance of the <see cref="ProcessElementNotification"/> type.</returns>
		public override ProcessElementNotification GetNotificationData() {
			ProcessElementNotification notification = base.GetNotificationData();
			ProcessUserTaskUtilities.AssignNotificationData(notification, Subject, StartIn, StartInPeriod);
			return notification;
		}

		public virtual List<string> GetRecipientList() {
			return GetEmailAddresses("Recipient");
		}

		public virtual List<string> GetCopyRecipientList() {
			return GetEmailAddresses("CopyRecipient");
		}

		public virtual List<string> GetBlindCopyRecipientList() {
			return GetEmailAddresses("BlindCopyRecipient");
		}

		public void ExecuteAfterActivitySaveScript(Activity activity) {
			this.AfterActivitySaveScriptExecute(activity);
		}

		#endregion

	}

	#endregion
}

