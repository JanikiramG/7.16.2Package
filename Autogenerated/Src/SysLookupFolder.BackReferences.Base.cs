namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLookupFolder

	/// <exclude/>
	public class SysLookupFolder : Terrasoft.Configuration.SysLookupFolder
	{

		#region Constructors: Public

		public SysLookupFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLookupFolder(Terrasoft.Configuration.SysLookupFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysLookup> SysLookupCollectionBySysFolder {
			get;
			set;
		}

		public IEnumerable<SysLookupFolder> SysLookupFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysLookup> VwSysLookupCollectionBySysFolder {
			get;
			set;
		}

		public IEnumerable<VwSysLookupInFolder> VwSysLookupInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

