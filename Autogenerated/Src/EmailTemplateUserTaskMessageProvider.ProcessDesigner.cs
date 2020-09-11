namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Text.RegularExpressions;
	using Terrasoft.Configuration;
	using Terrasoft.Core.Entities;
	using System.Linq;
	using Terrasoft.Configuration.ProcessDesigner;

	public class EmailTemplateUserTaskMessageProvider : BaseProcessEmailMessageProvider
	{

		#region Constants: Private

		/// <summary>
		/// Email template entity schema name.
		/// </summary>
		private const string _emailTemplateSchemaName = "EmailTemplate";

		/// <summary>
		/// Tag for getting email template user task language iterator.
		/// </summary>
		private const string _emailTemplateUserTaskLanguageIteratorTag = "EmailTemplateUserTask";

		/// <summary>
		/// Contact schema name.
		/// </summary>
		private const string _contactSchemaName = "Contact";

		#endregion

		#region Constructors: Public

		public EmailTemplateUserTaskMessageProvider(EmailTemplateUserTask userTask)
			: base(userTask) {
		}

		#endregion

		#region Properties: Public

		private MLangContentFactory _contentFactory;
		/// <summary>
		/// Multilanguage content factory.
		/// </summary>
		public MLangContentFactory MLangContentFactory
		{
			get => _contentFactory ?? (_contentFactory = new MLangContentFactory(UserConnection));
			set => _contentFactory = value;
		}

		#endregion

		#region Methods: Private

		private EntitySchemaQuery GetEmailTemplateContentEsq(Guid templateId) {
			var manager = UserConnection.EntitySchemaManager;
			var esq = new EntitySchemaQuery(manager, "EmailTemplate");
			esq.AddColumn("Body");
			esq.AddColumn("Subject");
			var primariFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", templateId);
			esq.Filters.Add(primariFilter);
			if (EmailUserTask.SendEmailType == (int)SendEmailType.Auto) {
				esq.UseAdminRights = false;
			}
			return esq;
		}

		#endregion

		#region Methods: Protected

		protected override (string Body, string Subject) GetEmailContent() {
			Entity entity = null;
			if (UserConnection.GetIsFeatureEnabled("EmailTemplateUserTaskMultiLanguageV2")) { 
				entity = GetMultiLanguageTemplate(EmailUserTask.EmailTemplateId, GetTemplateRecipientId(),
					_emailTemplateUserTaskLanguageIteratorTag);
				if (UserConnection.GetIsFeatureEnabled("UseMacrosAdditionalParameters")) {
					EmailUserTask.MacrosExtendedProperties.LanguageId = entity.GetTypedColumnValue<Guid>("LanguageId");
				}
			} else {
				var templateEsq = GetEmailTemplateContentEsq(EmailUserTask.EmailTemplateId);
				entity = templateEsq.GetEntityCollection(UserConnection).SingleOrDefault();
			}
			var tempalteSubject = string.Empty;
			var body = string.Empty;
			if (entity != null) {
				body = entity.GetTypedColumnValue<string>("Body");
				tempalteSubject = entity.GetTypedColumnValue<string>("Subject");
			}
			string userTaskSubject = GetEmailSubject();
			var subject = string.IsNullOrEmpty(userTaskSubject) ? tempalteSubject : userTaskSubject;
			return (body, subject);
		}

		/// <summary>
		/// Returns recipient identifier from email template user task.
		/// </summary>
		/// <returns>Recipient identifier from email template user task.</returns>
		protected virtual Guid GetTemplateRecipientId() {
			var regex = new Regex(@"^Recipient\d+$");
			BaseProcessSchemaElement userTaskSchema = EmailUserTask.GetSchemaElement();
			var processParametersMetaInfo = userTaskSchema as IProcessParametersMetaInfo;
			if (processParametersMetaInfo == null) {
				return Guid.Empty;
			}
			ProcessSchemaParameterCollection parameters = processParametersMetaInfo.ForceGetParameters();
			if (parameters == null || parameters.Count == 0) {
				return Guid.Empty;
			}
			foreach (ProcessSchemaParameter parameter in parameters) {
				if (regex.IsMatch(parameter.Name) && parameter.DataValueType.IsLookup &&
					parameter.ReferenceSchema != null && parameter.ReferenceSchema.Name == _contactSchemaName) {
					object propertyValue = EmailUserTask.GetParameterValue(parameter);
					return (Guid)propertyValue;
				}
			}
			return Guid.Empty;
		}

		/// <summary>
		/// Gets multi language template entity.
		/// </summary>
		/// <param name="templateId">Template record identifier.</param>
		/// <param name="recordId">Entity record identifier.</param>
		/// <param name="schemaName">Tag name to get an iterator.</param>
		/// <returns>Multi language template entity.</returns>
		protected Entity GetMultiLanguageTemplate(Guid templateId, Guid recordId, string schemaName) {
			var contentKit = MLangContentFactory.GetContentKit(schemaName, _emailTemplateSchemaName);
			if (EmailUserTask.SendEmailType == (int)SendEmailType.Auto) {
				contentKit.ContentStore.UseAdminRights = false;
			}
			Entity template = contentKit.GetContent(templateId, recordId);
			return template;
		}

		protected override string GetEmailBody() {
			var content = GetEmailContent();
			return content.Body;
		}

		#endregion

	}

}

