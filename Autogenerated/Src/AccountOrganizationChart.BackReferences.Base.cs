namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountOrganizationChart

	/// <exclude/>
	public class AccountOrganizationChart : Terrasoft.Configuration.AccountOrganizationChart
	{

		#region Constructors: Public

		public AccountOrganizationChart(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountOrganizationChart(Terrasoft.Configuration.AccountOrganizationChart source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountOrganizationChart> AccountOrganizationChartCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

