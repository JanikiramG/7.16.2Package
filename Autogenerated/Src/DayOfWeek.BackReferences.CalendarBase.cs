namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DayOfWeek

	/// <exclude/>
	public class DayOfWeek : Terrasoft.Configuration.DayOfWeek
	{

		#region Constructors: Public

		public DayOfWeek(UserConnection userConnection)
			: base(userConnection) {
		}

		public DayOfWeek(Terrasoft.Configuration.DayOfWeek source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DayInCalendar> DayInCalendarCollectionByDayOfWeek {
			get;
			set;
		}

		public IEnumerable<MaintenanceWindow> MaintenanceWindowCollectionByDayOfWeek {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

