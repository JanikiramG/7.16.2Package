namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FileInFolder

	/// <exclude/>
	public class FileInFolder : Terrasoft.Configuration.FileInFolder
	{

		#region Constructors: Public

		public FileInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public FileInFolder(Terrasoft.Configuration.FileInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

