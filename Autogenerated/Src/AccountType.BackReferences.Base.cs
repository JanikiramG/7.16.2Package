namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountType

	/// <exclude/>
	public class AccountType : Terrasoft.Configuration.AccountType
	{

		#region Constructors: Public

		public AccountType(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountType(Terrasoft.Configuration.AccountType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

