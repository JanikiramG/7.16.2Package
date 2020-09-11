namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityStatus

	/// <exclude/>
	public class ActivityStatus : Terrasoft.Configuration.ActivityStatus
	{

		#region Constructors: Public

		public ActivityStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityStatus(Terrasoft.Configuration.ActivityStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<ActivityTypeStatusEntry> ActivityTypeStatusEntryCollectionByActivityStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

