namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Order

	/// <exclude/>
	public class Order : Terrasoft.Configuration.Order
	{

		#region Constructors: Public

		public Order(UserConnection userConnection)
			: base(userConnection) {
		}

		public Order(Terrasoft.Configuration.Order source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderFile> OrderFileCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderInFolder> OrderInFolderCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderInTag> OrderInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<OrderVisa> OrderVisaCollectionByOrder {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByOrder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

