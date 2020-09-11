namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountForecast

	/// <exclude/>
	public class AccountForecast : Terrasoft.Configuration.AccountForecast
	{

		#region Constructors: Public

		public AccountForecast(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountForecast(Terrasoft.Configuration.AccountForecast source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

