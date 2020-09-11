namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Pricelist

	/// <exclude/>
	public class Pricelist : Terrasoft.Configuration.Pricelist
	{

		#region Constructors: Public

		public Pricelist(UserConnection userConnection)
			: base(userConnection) {
		}

		public Pricelist(Terrasoft.Configuration.Pricelist source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByPriceList {
			get;
			set;
		}

		public IEnumerable<InvoiceProduct> InvoiceProductCollectionByPriceList {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByPriceList {
			get;
			set;
		}

		public IEnumerable<ProductPrice> ProductPriceCollectionByPriceList {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

