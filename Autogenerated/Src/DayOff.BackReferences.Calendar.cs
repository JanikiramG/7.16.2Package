namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DayOff

	/// <exclude/>
	public class DayOff : Terrasoft.Configuration.DayOff
	{

		#region Constructors: Public

		public DayOff(UserConnection userConnection)
			: base(userConnection) {
		}

		public DayOff(Terrasoft.Configuration.DayOff source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WorkingTimeInterval> WorkingTimeIntervalCollectionByDayOff {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

