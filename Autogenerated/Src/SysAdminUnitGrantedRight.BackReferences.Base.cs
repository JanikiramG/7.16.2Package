namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminUnitGrantedRight

	/// <exclude/>
	public class SysAdminUnitGrantedRight : Terrasoft.Configuration.SysAdminUnitGrantedRight
	{

		#region Constructors: Public

		public SysAdminUnitGrantedRight(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminUnitGrantedRight(Terrasoft.Configuration.SysAdminUnitGrantedRight source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

