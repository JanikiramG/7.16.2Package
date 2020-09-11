namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysSchemaInWorkspace

	/// <exclude/>
	public class VwSysSchemaInWorkspace : Terrasoft.Configuration.VwSysSchemaInWorkspace
	{

		#region Constructors: Public

		public VwSysSchemaInWorkspace(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysSchemaInWorkspace(Terrasoft.Configuration.VwSysSchemaInWorkspace source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysProcessEntity> VwSysProcessEntityCollectionBySysSchema {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

