namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountInTag

	/// <exclude/>
	public class AccountInTag : Terrasoft.Configuration.AccountInTag
	{

		#region Constructors: Public

		public AccountInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountInTag(Terrasoft.Configuration.AccountInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

