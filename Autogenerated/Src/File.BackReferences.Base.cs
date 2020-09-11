namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: File

	/// <exclude/>
	public class File : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public File(UserConnection userConnection)
			: base(userConnection) {
		}

		public File(Terrasoft.Configuration.File source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<FileInFolder> FileInFolderCollectionByFile {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

