namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailTemplateActivity

	/// <exclude/>
	public class EmailTemplateActivity : Terrasoft.Configuration.EmailTemplateActivity
	{

		#region Constructors: Public

		public EmailTemplateActivity(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailTemplateActivity(Terrasoft.Configuration.EmailTemplateActivity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

