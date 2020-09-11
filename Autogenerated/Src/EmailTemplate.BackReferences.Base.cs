namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailTemplate

	/// <exclude/>
	public class EmailTemplate : Terrasoft.Configuration.EmailTemplate
	{

		#region Constructors: Public

		public EmailTemplate(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailTemplate(Terrasoft.Configuration.EmailTemplate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EmailTemplateActivity> EmailTemplateActivityCollectionByEmailTemplate {
			get;
			set;
		}

		public IEnumerable<EmailTemplateFile> EmailTemplateFileCollectionByEmailTemplate {
			get;
			set;
		}

		public IEnumerable<EmailTemplateLang> EmailTemplateLangCollectionByEmailTemplate {
			get;
			set;
		}

		public IEnumerable<SocialFeedFavoriteTpl> SocialFeedFavoriteTplCollectionByEmailTemplate {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

