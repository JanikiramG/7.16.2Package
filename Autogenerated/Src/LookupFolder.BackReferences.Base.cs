namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LookupFolder

	/// <exclude/>
	public class LookupFolder : Terrasoft.Configuration.LookupFolder
	{

		#region Constructors: Public

		public LookupFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public LookupFolder(Terrasoft.Configuration.LookupFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LookupFolder> LookupFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<LookupInFolder> LookupInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

