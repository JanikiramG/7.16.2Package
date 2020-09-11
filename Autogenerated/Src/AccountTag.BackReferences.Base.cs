namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountTag

	/// <exclude/>
	public class AccountTag : Terrasoft.Configuration.AccountTag
	{

		#region Constructors: Public

		public AccountTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountTag(Terrasoft.Configuration.AccountTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountInTag> AccountInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

