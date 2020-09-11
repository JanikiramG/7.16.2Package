namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MLModelFolder

	/// <exclude/>
	public class MLModelFolder : Terrasoft.Configuration.MLModelFolder
	{

		#region Constructors: Public

		public MLModelFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public MLModelFolder(Terrasoft.Configuration.MLModelFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MLModelFolder> MLModelFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<MLModelInFolder> MLModelInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

