namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysAdminUnit

	/// <exclude/>
	public class VwSysAdminUnit : Terrasoft.Configuration.VwSysAdminUnit
	{

		#region Constructors: Public

		public VwSysAdminUnit(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysAdminUnit(Terrasoft.Configuration.VwSysAdminUnit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysAdminUnitGrantedRight> SysAdminUnitGrantedRightCollectionByGranteeSysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysAdminUnitGrantedRight> SysAdminUnitGrantedRightCollectionByGrantorSysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysEntitySchemaOperationRight> SysEntitySchemaOperationRightCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<SysExtServiceOperationRight> SysExtServiceOperationRightCollectionBySysAdminUnit {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByParentRole {
			get;
			set;
		}

		public IEnumerable<VwSysEntitySchemaColumnRight> VwSysEntitySchemaColumnRightCollectionBySysAdminUnit {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

