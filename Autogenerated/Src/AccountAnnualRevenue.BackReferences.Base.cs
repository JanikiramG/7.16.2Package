namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountAnnualRevenue

	/// <exclude/>
	public class AccountAnnualRevenue : Terrasoft.Configuration.AccountAnnualRevenue
	{

		#region Constructors: Public

		public AccountAnnualRevenue(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountAnnualRevenue(Terrasoft.Configuration.AccountAnnualRevenue source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByAnnualRevenue {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByAnnualRevenue {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByAnnualRevenue {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

