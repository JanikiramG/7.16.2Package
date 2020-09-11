namespace Terrasoft.Configuration.CES
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.CESResponses;

	#region Class: CESApi

	/// <summary>
	/// Introduces API for Cloud Email Service.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.CES.ICESApi"/>
	public class CESApi : ICESApi
	{

		#region Constants: Private

		private const string AccountInfoApiPath = "/account/info.json";
		private const string AddSenderDomainsInfoApiPath = "/account/mailing/sender-domains/add.json";
		private const string AddTemplateApiPath = "/templates/add.json";
		private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
		private const string GetCheckedEmailsApiPath = "/account/mailing/checked-email.json";
		private const string PingApiPath = "/users/ping.json";
		private const string SenderDomainsInfoApiPath = "/account/mailing/sender-domains.json";
		private const string SendMessageApiPath = "/messages/send.json";
		private const string SendTemplateApiPath = "/messages/send-template.json";
		private const string UpdateUserSettingsApiPath = "/account/update-user-settings.json";
		private const string ValidateSenderApiPath = "/users/validate";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="CESApi"/> class.
		/// </summary>
		/// <param name="apiKey">
		/// The API Key received from CESApp
		/// </param>
		/// <param name="baseUrl">
		/// The base url.
		/// </param>
		public CESApi(string apiKey, string baseUrl) {
			ApiKey = apiKey;
			ServiceClient = new WebServiceClient(baseUrl) {
				ContentType = RequestContentType.Json
			};
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// The main rest client for use throughout the whole app.
		/// </summary>
		public IWebServiceClient ServiceClient { get; set; }

		/// <summary>
		/// The Api Key for the project received from the CESApp website.
		/// </summary>
		public string ApiKey { get; }

		/// <summary>
		/// Service base url.
		/// </summary>
		public string BaseUrl { get; set; }

		/// <summary>
		/// Service base secure url.
		/// </summary>
		public string BaseSecureUrl { get; set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns the mailing account info.
		/// </summary>
		/// <param name="authKey"></param>
		/// <returns>The <see cref="AccountInfo"/>.</returns>
		public AccountInfo AccountInfo(string authKey) {
			var request = new AccountInfoRequest {
				AuthKey = authKey,
				ApiKey = ApiKey
			};
			return ServiceClient.Post<AccountInfo>(request, AccountInfoApiPath);
		}

		/// <summary>
		/// Adds the sender domain.
		/// </summary>
		/// <param name="domain">The domain.</param>
		/// <returns>Information about added domain from provider. <see cref="CloudSenderDomainsInfo"/></returns>
		public CloudSenderDomainsInfo AddSenderDomainsInfo(string domain) {
			var request = new AddSenderDomainsInfoRequest {
				ApiKey = ApiKey,
				Domain = domain
			};
			return ServiceClient.Post<CloudSenderDomainsInfo>(request, AddSenderDomainsInfoApiPath);
		}

		/// <summary>
		/// Add a new template.
		/// </summary>
		/// <param name="name">The name for the new template - must be unique.</param>
		/// <param name="fromEmail">A default sending address for emails sent using this template.</param>
		/// <param name="fromName">A default from name to be used.</param>
		/// <param name="subject">A default subject line to be used.</param>
		/// <param name="code">
		/// The HTML code for the template with <c>mc:edit</c> attributes for
		/// the editable elements.
		/// </param>
		/// <param name="text">A default text part to be used when sending with this template.</param>
		/// <param name="emailId">Unique id of email.</param>
		/// <param name="images">List of inline attachments.</param>
		/// <param name="checksum">Current template checksum.</param>
		/// <param name="replicaId">The replica identifier.</param>
		/// <returns>
		/// A <see cref="BaseCloudResponse"/> object.
		/// </returns>
		public BaseCloudResponse AddTemplate(string name, string fromEmail, string fromName, string subject, string code,
			string text, Guid emailId, IEnumerable<image> images = null, string checksum = null,
			string replicaId = null) {
			var request = new AddTemplateRequest {
				ApiKey = ApiKey,
				Name = name,
				FromEmail = fromEmail,
				FromName = fromName,
				Subject = subject,
				Code = code,
				Text = text,
				EmailId = emailId,
				Images = images,
				ReplicaChecksum = checksum,
				ReplicaId = replicaId
			};
			return ServiceClient.Post<BaseCloudResponse>(request, AddTemplateApiPath);
		}

		/// <summary>
		/// Gets the checked emails by api key.
		/// </summary>
		/// <param name="emails">Enumerable of emails.</param>
		/// <returns></returns>
		public CheckedEmailResponse GetCheckedEmails(IEnumerable<string> emails) {
			var request = new CheckedEmailRequest {
				ApiKey = ApiKey,
				Emails = emails
			};
			return ServiceClient.Post<CheckedEmailResponse>(request, GetCheckedEmailsApiPath);
		}

		/// <summary>
		/// Validate an API key and respond to a ping
		/// </summary>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		public string Ping() {
			ServiceClient.ContentType = RequestContentType.Json;
			var request = new BaseServiceRequest {
				ApiKey = ApiKey
			};
			return ServiceClient.Post<string>(request, PingApiPath);
		}

		/// <summary>
		/// Gets the list of sender's domains from provider.
		/// </summary>
		/// <returns>
		/// The <see cref="CloudSenderDomainsInfo"/>.
		/// </returns>
		public CloudSenderDomainsInfo SenderDomainsInfo() {
			var request = new BaseServiceRequest {
				ApiKey = ApiKey
			};
			return ServiceClient.Post<CloudSenderDomainsInfo>(request, SenderDomainsInfoApiPath);
		}

		/// <summary>
		/// Sends a new transactional message through CES.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="emailId"></param>
		/// <param name="sendAt">The send_at.</param>
		/// <returns>
		/// <see cref="BaseCloudResponse"/>
		/// </returns>
		public BaseCloudResponse SendMessage(EmailMessage message, Guid emailId, DateTime sendAt = new DateTime()) {
			sendAt = sendAt.ToUniversalTime();
			var request = new SendMessageRequest {
				ApiKey = ApiKey,
				Message = message
			};
			if (emailId != Guid.Empty) {
				request.EmailId = emailId;
			}
			request.SendAt = sendAt == DateTime.MinValue ? string.Empty : sendAt.ToString(DateTimeFormat);
			return ServiceClient.Post<BaseCloudResponse>(request, SendMessageApiPath);
		}

		/// <summary>
		/// Send a new transactional message through CES using a template
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="templateName"></param>
		/// <param name="templateContents"></param>
		/// <param name="emailId">Identifier of email.</param>
		/// <param name="sendAt">The send_at.</param>
		/// <returns>
		/// <see cref="BaseCloudResponse"/>
		/// </returns>
		public BaseCloudResponse SendTemplate(EmailMessage message, string templateName,
			IEnumerable<TemplateContent> templateContents, Guid emailId, DateTime sendAt = new DateTime()) {
			sendAt = sendAt.ToUniversalTime();
			var request = new SendTemplateRequest {
				ApiKey = ApiKey,
				Message = message,
				TemplateName = templateName,
				EmailId = emailId,
				SendAt = sendAt == DateTime.MinValue ? string.Empty : sendAt.ToString(DateTimeFormat)
			};
			return ServiceClient.Post<BaseCloudResponse>(request, SendTemplateApiPath);
		}

		/// <summary>
		/// Updates the user settings.
		/// </summary>
		/// <param name="webHookAppDomain"></param>
		/// <param name="authKey"></param>
		/// <returns>
		/// The <see cref="AccountInfo"/>.
		/// </returns>
		public AccountInfo UpdateUserSettings(string webHookAppDomain, string authKey) {
			var request = new UpdateUserSettingsRequest {
				ApiKey = ApiKey,
				AuthKey = authKey,
				WebHookAppDomain = webHookAppDomain
			};
			return ServiceClient.Post<AccountInfo>(request, UpdateUserSettingsApiPath);
		}

		/// <summary>
		/// Validates sender's emails and send validation emails if needed.
		/// </summary>
		/// <param name="emails">List of sender's emails for validation</param>
		/// <returns>
		/// Lists of incorrect and validated emails
		/// </returns>
		public SenderValidationInfo ValidateSender(IEnumerable<string> emails) {
			var request = new ValidateSenderRequest {
				EmailList = emails,
				ApiKey = ApiKey
			};
			return ServiceClient.Post<SenderValidationInfo>(request, ValidateSenderApiPath);
		}

		#endregion

	}

	#endregion

}

