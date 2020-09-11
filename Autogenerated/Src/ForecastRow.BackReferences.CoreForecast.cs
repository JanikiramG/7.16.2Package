namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastRow

	/// <exclude/>
	public class ForecastRow : Terrasoft.Configuration.ForecastRow
	{

		#region Constructors: Public

		public ForecastRow(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastRow(Terrasoft.Configuration.ForecastRow source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionByRow {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByRow {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionByRow {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionByRow {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionByRow {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

