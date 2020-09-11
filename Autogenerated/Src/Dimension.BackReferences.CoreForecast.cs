namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Dimension

	/// <exclude/>
	public class Dimension : Terrasoft.Configuration.Dimension
	{

		#region Constructors: Public

		public Dimension(UserConnection userConnection)
			: base(userConnection) {
		}

		public Dimension(Terrasoft.Configuration.Dimension source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ForecastDimension> ForecastDimensionCollectionByDimension {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

