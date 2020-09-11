namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Mail.Sender;
	using global::Common.Logging;
	using Terrasoft.Configuration.ProcessDesigner;
	using SysSettings = Core.Configuration.SysSettings;

	#region Class: AutoEmailUserTaskSender

	public class AutoEmailUserTaskSender : IEmailUserTaskSender
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("Process");

		#endregion

		#region Properties: Public

		public UserConnection UserConnection {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public virtual void SendEmailWithDefaultSender(EmailMessage emailMessage, bool ignoreErrors) {
			var userConnectionArg = new ConstructorArgument("userConnection", UserConnection);
			var emailClientFactory = ClassFactory.Get<EmailClientFactory>(userConnectionArg);
			if (UserConnection.GetIsFeatureEnabled("EmailIntegrationV2")) {
				var sender = new ActivityEmailSender(emailClientFactory, UserConnection);
				sender.Send(emailMessage, true);
			} else {
				var credentials = new Terrasoft.Mail.MailCredentials {
					Host = (string)SysSettings.GetValue(UserConnection, "SmtpHost"),
					Port = int.Parse(SysSettings.GetValue(UserConnection, "SmtpPort").ToString()),
					UseSsl = (bool)SysSettings.GetValue(UserConnection, "SmtpEnableSsl"),
					UserName = (string)SysSettings.GetValue(UserConnection, "SmtpUserName"),
					UserPassword = (string)SysSettings.GetValue(UserConnection, "SmtpUserPassword")
				};
				try {
					var emailClientFactoryArg = new ConstructorArgument("emailClientFactory", emailClientFactory);
					var emailSener = ClassFactory.Get<IEmailSender>(emailClientFactoryArg, userConnectionArg);
					emailSener.Send(emailMessage, credentials);
				} catch (Exception e) {
					_log.Error(e);
					if (!ignoreErrors) {
						throw;
					}
				}
			}
		}
		public bool Execute(IEmailUserTaskMessageProvider messageProvider, ProcessExecutingContext context) {
			EmailTemplateUserTask userTask = messageProvider.EmailUserTask;
			EmailMessage message = messageProvider.GetEmailMessage();
			if (message.To.IsNullOrEmpty()) {
				return true;
			}
			if (message.From.IsEmpty()) {
				SendEmailWithDefaultSender(message, userTask.IgnoreErrors);
				return true;
			}
			var constructorArguments = new ConstructorArgument("userConnection", UserConnection);
			var emailClientFactory = ClassFactory.Get<EmailClientFactory>(constructorArguments);
			var emailSender = new HtmlEmailMessageSender(emailClientFactory, UserConnection);
			try {
				bool ignoreRights = (SendEmailType)userTask.SendEmailType == SendEmailType.Auto;
				emailSender.Send(message, ignoreRights);
			} catch (Exception e) {
				_log.Error(e);
				if (!userTask.IgnoreErrors) {
					throw;
				}
			}
			return true;
		}

		public bool CompleteExecuting(EmailTemplateUserTask userTask,
				Func<object[], bool> callBase, params object[] parameters) {
			return callBase(parameters);
		}

		public void CancelExecuting(EmailTemplateUserTask userTask,
				Action<object[]> callBase, params object[] parameters) {
			callBase(parameters);
		}

		public string GetExecutionData(EmailTemplateUserTask userTask) {
			return string.Empty;
		}

		/// <summary>
		/// Returns instance that implements the <see cref="IProcessNotifier"/> interface.
		/// </summary>
		/// <param name="baseProcessNotifier">Delegate to get base process notifier.</param>
		/// <returns></returns>
		public IProcessNotifier GetProcessNotifier(Func<IProcessNotifier> baseProcessNotifier) {
			return new EmptyProcessNotifier();
		}

		#endregion

	}

	#endregion

}
