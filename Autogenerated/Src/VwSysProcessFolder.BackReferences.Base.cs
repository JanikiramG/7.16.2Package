namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysProcessFolder

	/// <exclude/>
	public class VwSysProcessFolder : Terrasoft.Configuration.VwSysProcessFolder
	{

		#region Constructors: Public

		public VwSysProcessFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysProcessFolder(Terrasoft.Configuration.VwSysProcessFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysProcessFolder> VwSysProcessFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysProcessInFolder> VwSysProcessInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

