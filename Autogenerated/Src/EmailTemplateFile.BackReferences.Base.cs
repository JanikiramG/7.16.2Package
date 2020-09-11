namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailTemplateFile

	/// <exclude/>
	public class EmailTemplateFile : Terrasoft.Configuration.EmailTemplateFile
	{

		#region Constructors: Public

		public EmailTemplateFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailTemplateFile(Terrasoft.Configuration.EmailTemplateFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

