namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountDuplicate

	/// <exclude/>
	public class AccountDuplicate : Terrasoft.Configuration.AccountDuplicate
	{

		#region Constructors: Public

		public AccountDuplicate(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountDuplicate(Terrasoft.Configuration.AccountDuplicate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

