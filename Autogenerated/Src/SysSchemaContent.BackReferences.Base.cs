namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSchemaContent

	/// <exclude/>
	public class SysSchemaContent : Terrasoft.Configuration.SysSchemaContent
	{

		#region Constructors: Public

		public SysSchemaContent(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSchemaContent(Terrasoft.Configuration.SysSchemaContent source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

