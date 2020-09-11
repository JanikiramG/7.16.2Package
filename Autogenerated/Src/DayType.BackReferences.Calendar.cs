namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DayType

	/// <exclude/>
	public class DayType : Terrasoft.Configuration.DayType
	{

		#region Constructors: Public

		public DayType(UserConnection userConnection)
			: base(userConnection) {
		}

		public DayType(Terrasoft.Configuration.DayType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DayInCalendar> DayInCalendarCollectionByDayType {
			get;
			set;
		}

		public IEnumerable<DayOff> DayOffCollectionByDayType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

