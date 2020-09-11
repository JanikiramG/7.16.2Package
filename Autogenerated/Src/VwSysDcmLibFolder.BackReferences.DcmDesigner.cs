namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysDcmLibFolder

	/// <exclude/>
	public class VwSysDcmLibFolder : Terrasoft.Configuration.VwSysDcmLibFolder
	{

		#region Constructors: Public

		public VwSysDcmLibFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysDcmLibFolder(Terrasoft.Configuration.VwSysDcmLibFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysDcmLibFolder> VwSysDcmLibFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysDcmLibInFolder> VwSysDcmLibInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

