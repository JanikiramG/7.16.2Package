namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ChartAggregationType

	/// <exclude/>
	public class ChartAggregationType : Terrasoft.Configuration.ChartAggregationType
	{

		#region Constructors: Public

		public ChartAggregationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ChartAggregationType(Terrasoft.Configuration.ChartAggregationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ChartProperty> ChartPropertyCollectionByChartAggregationType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

