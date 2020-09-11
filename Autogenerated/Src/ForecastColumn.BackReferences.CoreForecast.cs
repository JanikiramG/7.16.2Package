namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastColumn

	/// <exclude/>
	public class ForecastColumn : Terrasoft.Configuration.ForecastColumn
	{

		#region Constructors: Public

		public ForecastColumn(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastColumn(Terrasoft.Configuration.ForecastColumn source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionByForecastColumn {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByForecastColumn {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionByForecastColumn {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionByForecastColumn {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionByForecastColumn {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

