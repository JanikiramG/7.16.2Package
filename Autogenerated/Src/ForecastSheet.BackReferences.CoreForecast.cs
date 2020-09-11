namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastSheet

	/// <exclude/>
	public class ForecastSheet : Terrasoft.Configuration.ForecastSheet
	{

		#region Constructors: Public

		public ForecastSheet(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastSheet(Terrasoft.Configuration.ForecastSheet source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ForecastColumn> ForecastColumnCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionBySheet {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

