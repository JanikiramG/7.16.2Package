namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountEmployeesNumber

	/// <exclude/>
	public class AccountEmployeesNumber : Terrasoft.Configuration.AccountEmployeesNumber
	{

		#region Constructors: Public

		public AccountEmployeesNumber(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountEmployeesNumber(Terrasoft.Configuration.AccountEmployeesNumber source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByEmployeesNumber {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByEmployeesNumber {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByEmployeesNumber {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

