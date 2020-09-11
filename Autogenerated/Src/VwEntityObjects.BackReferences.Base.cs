namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwEntityObjects

	/// <exclude/>
	public class VwEntityObjects : Terrasoft.Configuration.VwEntityObjects
	{

		#region Constructors: Public

		public VwEntityObjects(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwEntityObjects(Terrasoft.Configuration.VwEntityObjects source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ForecastSheet> ForecastSheetCollectionByForecastEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

