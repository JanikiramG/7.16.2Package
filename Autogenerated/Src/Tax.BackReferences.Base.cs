namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Tax

	/// <exclude/>
	public class Tax : Terrasoft.Configuration.Tax
	{

		#region Constructors: Public

		public Tax(UserConnection userConnection)
			: base(userConnection) {
		}

		public Tax(Terrasoft.Configuration.Tax source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DocumentProduct> DocumentProductCollectionByTax {
			get;
			set;
		}

		public IEnumerable<InvoiceProduct> InvoiceProductCollectionByTax {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByTax {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByTax {
			get;
			set;
		}

		public IEnumerable<ProductPrice> ProductPriceCollectionByTax {
			get;
			set;
		}

		public IEnumerable<ProjectProduct> ProjectProductCollectionByTax {
			get;
			set;
		}

		public IEnumerable<VwDocumentProduct> VwDocumentProductCollectionByTax {
			get;
			set;
		}

		public IEnumerable<VwInvoiceProduct> VwInvoiceProductCollectionByTax {
			get;
			set;
		}

		public IEnumerable<VwProjectProduct> VwProjectProductCollectionByTax {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

