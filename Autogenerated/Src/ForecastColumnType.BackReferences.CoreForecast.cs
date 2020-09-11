namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastColumnType

	/// <exclude/>
	public class ForecastColumnType : Terrasoft.Configuration.ForecastColumnType
	{

		#region Constructors: Public

		public ForecastColumnType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastColumnType(Terrasoft.Configuration.ForecastColumnType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ForecastColumn> ForecastColumnCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

