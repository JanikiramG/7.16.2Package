namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailTemplateRecipientType

	/// <exclude/>
	public class EmailTemplateRecipientType : Terrasoft.Configuration.EmailTemplateRecipientType
	{

		#region Constructors: Public

		public EmailTemplateRecipientType(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailTemplateRecipientType(Terrasoft.Configuration.EmailTemplateRecipientType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

