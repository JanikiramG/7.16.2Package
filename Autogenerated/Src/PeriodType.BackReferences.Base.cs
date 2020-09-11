namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PeriodType

	/// <exclude/>
	public class PeriodType : Terrasoft.Configuration.PeriodType
	{

		#region Constructors: Public

		public PeriodType(UserConnection userConnection)
			: base(userConnection) {
		}

		public PeriodType(Terrasoft.Configuration.PeriodType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Forecast> ForecastCollectionByPeriodType {
			get;
			set;
		}

		public IEnumerable<ForecastSheet> ForecastSheetCollectionByPeriodType {
			get;
			set;
		}

		public IEnumerable<Period> PeriodCollectionByPeriodType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

