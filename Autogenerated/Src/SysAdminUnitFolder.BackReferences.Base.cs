namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminUnitFolder

	/// <exclude/>
	public class SysAdminUnitFolder : Terrasoft.Configuration.SysAdminUnitFolder
	{

		#region Constructors: Public

		public SysAdminUnitFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminUnitFolder(Terrasoft.Configuration.SysAdminUnitFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysAdminUnitFolder> SysAdminUnitFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysAdminUnitInFolder> SysAdminUnitInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

