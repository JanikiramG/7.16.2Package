namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Product

	/// <exclude/>
	public class Product : Terrasoft.Configuration.Product
	{

		#region Constructors: Public

		public Product(UserConnection userConnection)
			: base(userConnection) {
		}

		public Product(Terrasoft.Configuration.Product source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContactsProductInterest> ContactsProductInterestCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<DocumentProduct> DocumentProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<InvoiceProduct> InvoiceProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<LeadProduct> LeadProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<OpportunityProductInterest> OpportunityProductInterestCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductEntry> ProductEntryCollectionByCrossSalesOferring {
			get;
			set;
		}

		public IEnumerable<ProductEntry> ProductEntryCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductFile> ProductFileCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductInFolder> ProductInFolderCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductInLeadType> ProductInLeadTypeCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductInTag> ProductInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ProductPrice> ProductPriceCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductStockBalance> ProductStockBalanceCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProductUnit> ProductUnitCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<ProjectProduct> ProjectProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<SpecificationInProduct> SpecificationInProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<VwDocumentProduct> VwDocumentProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<VwInvoiceProduct> VwInvoiceProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<VwProductInLeadType> VwProductInLeadTypeCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<VwProjectProduct> VwProjectProductCollectionByProduct {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

