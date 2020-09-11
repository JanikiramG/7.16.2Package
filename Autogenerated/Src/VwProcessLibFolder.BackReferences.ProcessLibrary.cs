namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProcessLibFolder

	/// <exclude/>
	public class VwProcessLibFolder : Terrasoft.Configuration.VwProcessLibFolder
	{

		#region Constructors: Public

		public VwProcessLibFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProcessLibFolder(Terrasoft.Configuration.VwProcessLibFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwProcessLibFolder> VwProcessLibFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwProcessLibInFolder> VwProcessLibInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

