namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountAddress

	/// <exclude/>
	public class AccountAddress : Terrasoft.Configuration.AccountAddress
	{

		#region Constructors: Public

		public AccountAddress(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountAddress(Terrasoft.Configuration.AccountAddress source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

