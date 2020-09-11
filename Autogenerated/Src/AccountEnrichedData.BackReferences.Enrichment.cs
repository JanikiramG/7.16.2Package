namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountEnrichedData

	/// <exclude/>
	public class AccountEnrichedData : Terrasoft.Configuration.AccountEnrichedData
	{

		#region Constructors: Public

		public AccountEnrichedData(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountEnrichedData(Terrasoft.Configuration.AccountEnrichedData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

