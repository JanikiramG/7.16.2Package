namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminUnitType

	/// <exclude/>
	public class SysAdminUnitType : Terrasoft.Configuration.SysAdminUnitType
	{

		#region Constructors: Public

		public SysAdminUnitType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminUnitType(Terrasoft.Configuration.SysAdminUnitType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSspAdminUnit> VwSspAdminUnitCollectionBySysAdminUnitType {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionBySysAdminUnitType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

