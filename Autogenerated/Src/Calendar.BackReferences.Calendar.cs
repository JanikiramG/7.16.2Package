namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Calendar

	/// <exclude/>
	public class Calendar : Terrasoft.Configuration.Calendar
	{

		#region Constructors: Public

		public Calendar(UserConnection userConnection)
			: base(userConnection) {
		}

		public Calendar(Terrasoft.Configuration.Calendar source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Calendar> CalendarCollectionByParent {
			get;
			set;
		}

		public IEnumerable<DayInCalendar> DayInCalendarCollectionByCalendar {
			get;
			set;
		}

		public IEnumerable<DayOff> DayOffCollectionByCalendar {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

