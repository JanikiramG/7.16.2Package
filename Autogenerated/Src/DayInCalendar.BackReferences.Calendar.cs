namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DayInCalendar

	/// <exclude/>
	public class DayInCalendar : Terrasoft.Configuration.DayInCalendar
	{

		#region Constructors: Public

		public DayInCalendar(UserConnection userConnection)
			: base(userConnection) {
		}

		public DayInCalendar(Terrasoft.Configuration.DayInCalendar source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WorkingTimeInterval> WorkingTimeIntervalCollectionByDayInCalendar {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

