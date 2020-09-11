namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Currency

	/// <exclude/>
	public class Currency : Terrasoft.Configuration.Currency
	{

		#region Constructors: Public

		public Currency(UserConnection userConnection)
			: base(userConnection) {
		}

		public Currency(Terrasoft.Configuration.Currency source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Cashflow> CashflowCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<CurrencyRate> CurrencyRateCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<OrderProduct> OrderProductCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionByCurrency {
			get;
			set;
		}

		public IEnumerable<ProductPrice> ProductPriceCollectionByCurrency {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

