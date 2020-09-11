namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminUnitInFolder

	/// <exclude/>
	public class SysAdminUnitInFolder : Terrasoft.Configuration.SysAdminUnitInFolder
	{

		#region Constructors: Public

		public SysAdminUnitInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminUnitInFolder(Terrasoft.Configuration.SysAdminUnitInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

