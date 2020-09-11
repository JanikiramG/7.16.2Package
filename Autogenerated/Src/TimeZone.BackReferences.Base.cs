namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: TimeZone

	/// <exclude/>
	public class TimeZone : Terrasoft.Configuration.TimeZone
	{

		#region Constructors: Public

		public TimeZone(UserConnection userConnection)
			: base(userConnection) {
		}

		public TimeZone(Terrasoft.Configuration.TimeZone source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByTimeZone {
			get;
			set;
		}

		public IEnumerable<Calendar> CalendarCollectionByTimeZone {
			get;
			set;
		}

		public IEnumerable<City> CityCollectionByTimeZone {
			get;
			set;
		}

		public IEnumerable<Country> CountryCollectionByTimeZone {
			get;
			set;
		}

		public IEnumerable<Region> RegionCollectionByTimeZone {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByTimeZone {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

