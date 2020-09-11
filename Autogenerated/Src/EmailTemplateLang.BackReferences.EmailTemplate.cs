namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailTemplateLang

	/// <exclude/>
	public class EmailTemplateLang : Terrasoft.Configuration.EmailTemplateLang
	{

		#region Constructors: Public

		public EmailTemplateLang(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailTemplateLang(Terrasoft.Configuration.EmailTemplateLang source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

