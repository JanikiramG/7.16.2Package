namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysWorkplace

	/// <exclude/>
	public class SysWorkplace : Terrasoft.Configuration.SysWorkplace
	{

		#region Constructors: Public

		public SysWorkplace(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysWorkplace(Terrasoft.Configuration.SysWorkplace source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysAdminUnitInWorkplace> SysAdminUnitInWorkplaceCollectionBySysWorkplace {
			get;
			set;
		}

		public IEnumerable<SysModuleInWorkplace> SysModuleInWorkplaceCollectionBySysWorkplace {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

