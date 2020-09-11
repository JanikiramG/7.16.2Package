namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountAnniversary

	/// <exclude/>
	public class AccountAnniversary : Terrasoft.Configuration.AccountAnniversary
	{

		#region Constructors: Public

		public AccountAnniversary(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountAnniversary(Terrasoft.Configuration.AccountAnniversary source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

