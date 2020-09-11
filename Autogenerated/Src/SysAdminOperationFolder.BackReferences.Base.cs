namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminOperationFolder

	/// <exclude/>
	public class SysAdminOperationFolder : Terrasoft.Configuration.SysAdminOperationFolder
	{

		#region Constructors: Public

		public SysAdminOperationFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminOperationFolder(Terrasoft.Configuration.SysAdminOperationFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysAdminOperation> SysAdminOperationCollectionBySysFolder {
			get;
			set;
		}

		public IEnumerable<SysAdminOperationFolder> SysAdminOperationFolderCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

