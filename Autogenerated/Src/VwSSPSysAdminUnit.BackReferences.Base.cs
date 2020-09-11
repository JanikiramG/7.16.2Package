namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSSPSysAdminUnit

	/// <exclude/>
	public class VwSSPSysAdminUnit : Terrasoft.Configuration.VwSSPSysAdminUnit
	{

		#region Constructors: Public

		public VwSSPSysAdminUnit(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSSPSysAdminUnit(Terrasoft.Configuration.VwSSPSysAdminUnit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSSPSysAdminUnit> VwSSPSysAdminUnitCollectionByParentRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

