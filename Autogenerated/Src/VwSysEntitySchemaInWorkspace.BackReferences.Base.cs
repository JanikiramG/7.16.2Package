namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysEntitySchemaInWorkspace

	/// <exclude/>
	public class VwSysEntitySchemaInWorkspace : Terrasoft.Configuration.VwSysEntitySchemaInWorkspace
	{

		#region Constructors: Public

		public VwSysEntitySchemaInWorkspace(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysEntitySchemaInWorkspace(Terrasoft.Configuration.VwSysEntitySchemaInWorkspace source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

