namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminUnitInRole

	/// <exclude/>
	public class SysAdminUnitInRole : Terrasoft.Configuration.SysAdminUnitInRole
	{

		#region Constructors: Public

		public SysAdminUnitInRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminUnitInRole(Terrasoft.Configuration.SysAdminUnitInRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

