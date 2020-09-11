namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastDimension

	/// <exclude/>
	public class ForecastDimension : Terrasoft.Configuration.ForecastDimension
	{

		#region Constructors: Public

		public ForecastDimension(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastDimension(Terrasoft.Configuration.ForecastDimension source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ForecastItem> ForecastItemCollectionByForecastDimension {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

