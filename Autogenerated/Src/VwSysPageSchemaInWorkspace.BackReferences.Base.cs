namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysPageSchemaInWorkspace

	/// <exclude/>
	public class VwSysPageSchemaInWorkspace : Terrasoft.Configuration.VwSysPageSchemaInWorkspace
	{

		#region Constructors: Public

		public VwSysPageSchemaInWorkspace(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysPageSchemaInWorkspace(Terrasoft.Configuration.VwSysPageSchemaInWorkspace source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

