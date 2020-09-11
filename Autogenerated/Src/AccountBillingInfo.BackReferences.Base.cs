namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountBillingInfo

	/// <exclude/>
	public class AccountBillingInfo : Terrasoft.Configuration.AccountBillingInfo
	{

		#region Constructors: Public

		public AccountBillingInfo(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountBillingInfo(Terrasoft.Configuration.AccountBillingInfo source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contract> ContractCollectionByCustomerBillingInfo {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionBySupplierBillingInfo {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByCustomerBillingInfo {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionBySupplierBillingInfo {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

