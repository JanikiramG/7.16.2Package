namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailTemplateSendFlag

	/// <exclude/>
	public class EmailTemplateSendFlag : Terrasoft.Configuration.EmailTemplateSendFlag
	{

		#region Constructors: Public

		public EmailTemplateSendFlag(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailTemplateSendFlag(Terrasoft.Configuration.EmailTemplateSendFlag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EmailTemplate> EmailTemplateCollectionBySendIndividualEmail {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

