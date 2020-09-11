namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FileFolder

	/// <exclude/>
	public class FileFolder : Terrasoft.Configuration.FileFolder
	{

		#region Constructors: Public

		public FileFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public FileFolder(Terrasoft.Configuration.FileFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<FileFolder> FileFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<FileInFolder> FileInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

