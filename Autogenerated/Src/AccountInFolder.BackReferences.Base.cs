namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountInFolder

	/// <exclude/>
	public class AccountInFolder : Terrasoft.Configuration.AccountInFolder
	{

		#region Constructors: Public

		public AccountInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountInFolder(Terrasoft.Configuration.AccountInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

