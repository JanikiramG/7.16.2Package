namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountIndustry

	/// <exclude/>
	public class AccountIndustry : Terrasoft.Configuration.AccountIndustry
	{

		#region Constructors: Public

		public AccountIndustry(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountIndustry(Terrasoft.Configuration.AccountIndustry source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByIndustry {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByIndustry {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByIndustry {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

