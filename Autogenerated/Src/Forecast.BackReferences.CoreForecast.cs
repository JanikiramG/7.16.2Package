namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Forecast

	/// <exclude/>
	public class Forecast : Terrasoft.Configuration.Forecast
	{

		#region Constructors: Public

		public Forecast(UserConnection userConnection)
			: base(userConnection) {
		}

		public Forecast(Terrasoft.Configuration.Forecast source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ForecastDimension> ForecastDimensionCollectionByForecast {
			get;
			set;
		}

		public IEnumerable<ForecastItem> ForecastItemCollectionByForecast {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

