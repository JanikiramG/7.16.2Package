namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Period

	/// <exclude/>
	public class Period : Terrasoft.Configuration.Period
	{

		#region Constructors: Public

		public Period(UserConnection userConnection)
			: base(userConnection) {
		}

		public Period(Terrasoft.Configuration.Period source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionByPeriod {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByPeriod {
			get;
			set;
		}

		public IEnumerable<ForecastItemValue> ForecastItemValueCollectionByPeriod {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionByPeriod {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionByPeriod {
			get;
			set;
		}

		public IEnumerable<Period> PeriodCollectionByParent {
			get;
			set;
		}

		public IEnumerable<Period> PeriodCollectionByQuarter {
			get;
			set;
		}

		public IEnumerable<Period> PeriodCollectionByYear {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionByPeriod {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

