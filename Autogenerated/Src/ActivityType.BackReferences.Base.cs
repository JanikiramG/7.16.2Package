namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityType

	/// <exclude/>
	public class ActivityType : Terrasoft.Configuration.ActivityType
	{

		#region Constructors: Public

		public ActivityType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityType(Terrasoft.Configuration.ActivityType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByType {
			get;
			set;
		}

		public IEnumerable<ActivityCategory> ActivityCategoryCollectionByActivityType {
			get;
			set;
		}

		public IEnumerable<ActivityTypeStatusEntry> ActivityTypeStatusEntryCollectionByActivityType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

