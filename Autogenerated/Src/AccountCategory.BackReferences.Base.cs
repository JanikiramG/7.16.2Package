namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountCategory

	/// <exclude/>
	public class AccountCategory : Terrasoft.Configuration.AccountCategory
	{

		#region Constructors: Public

		public AccountCategory(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountCategory(Terrasoft.Configuration.AccountCategory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByAccountCategory {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByAccountCategory {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByAccountCategory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

