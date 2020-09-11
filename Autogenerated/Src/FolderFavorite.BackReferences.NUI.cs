namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FolderFavorite

	/// <exclude/>
	public class FolderFavorite : Terrasoft.Configuration.FolderFavorite
	{

		#region Constructors: Public

		public FolderFavorite(UserConnection userConnection)
			: base(userConnection) {
		}

		public FolderFavorite(Terrasoft.Configuration.FolderFavorite source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

