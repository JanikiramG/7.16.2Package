namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountOwnership

	/// <exclude/>
	public class AccountOwnership : Terrasoft.Configuration.AccountOwnership
	{

		#region Constructors: Public

		public AccountOwnership(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountOwnership(Terrasoft.Configuration.AccountOwnership source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByOwnership {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByAccountOwnership {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByOwnership {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

