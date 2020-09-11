namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountFolder

	/// <exclude/>
	public class AccountFolder : Terrasoft.Configuration.AccountFolder
	{

		#region Constructors: Public

		public AccountFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountFolder(Terrasoft.Configuration.AccountFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountFolder> AccountFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<AccountInFolder> AccountInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

