namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuth20AppFolder

	/// <exclude/>
	public class OAuth20AppFolder : Terrasoft.Configuration.OAuth20AppFolder
	{

		#region Constructors: Public

		public OAuth20AppFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuth20AppFolder(Terrasoft.Configuration.OAuth20AppFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OAuth20AppFolder> OAuth20AppFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<OAuth20AppInFolder> OAuth20AppInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

