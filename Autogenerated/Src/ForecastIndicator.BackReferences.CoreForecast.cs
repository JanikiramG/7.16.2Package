namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastIndicator

	/// <exclude/>
	public class ForecastIndicator : Terrasoft.Configuration.ForecastIndicator
	{

		#region Constructors: Public

		public ForecastIndicator(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastIndicator(Terrasoft.Configuration.ForecastIndicator source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionByIndicator {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByIndicator {
			get;
			set;
		}

		public IEnumerable<ForecastColumn> ForecastColumnCollectionByIndicator {
			get;
			set;
		}

		public IEnumerable<ForecastItemValue> ForecastItemValueCollectionByForecastIndicator {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionByIndicator {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionByIndicator {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionByIndicator {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

