namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentFolder

	/// <exclude/>
	public class DocumentFolder : Terrasoft.Configuration.DocumentFolder
	{

		#region Constructors: Public

		public DocumentFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentFolder(Terrasoft.Configuration.DocumentFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DocumentFolder> DocumentFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<DocumentInFolder> DocumentInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

