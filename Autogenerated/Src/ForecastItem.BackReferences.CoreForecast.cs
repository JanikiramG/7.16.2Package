namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastItem

	/// <exclude/>
	public class ForecastItem : Terrasoft.Configuration.ForecastItem
	{

		#region Constructors: Public

		public ForecastItem(UserConnection userConnection)
			: base(userConnection) {
		}

		public ForecastItem(Terrasoft.Configuration.ForecastItem source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ForecastItem> ForecastItemCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ForecastItemValue> ForecastItemValueCollectionByForecastItem {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

