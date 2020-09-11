namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Contract

	/// <exclude/>
	public class Contract : Terrasoft.Configuration.Contract
	{

		#region Constructors: Public

		public Contract(UserConnection userConnection)
			: base(userConnection) {
		}

		public Contract(Terrasoft.Configuration.Contract source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByContract {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ContractFile> ContractFileCollectionByContract {
			get;
			set;
		}

		public IEnumerable<ContractInFolder> ContractInFolderCollectionByContract {
			get;
			set;
		}

		public IEnumerable<ContractInTag> ContractInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ContractVisa> ContractVisaCollectionByContract {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByContract {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByContract {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByContract {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByContract {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

