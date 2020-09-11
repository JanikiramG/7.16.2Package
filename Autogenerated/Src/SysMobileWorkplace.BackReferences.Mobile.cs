namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysMobileWorkplace

	/// <exclude/>
	public class SysMobileWorkplace : Terrasoft.Configuration.SysMobileWorkplace
	{

		#region Constructors: Public

		public SysMobileWorkplace(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysMobileWorkplace(Terrasoft.Configuration.SysMobileWorkplace source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysRoleInMobWorkplace> SysRoleInMobWorkplaceCollectionBySysMobileWorkplace {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

