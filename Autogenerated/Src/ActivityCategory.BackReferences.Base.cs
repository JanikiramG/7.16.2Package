namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityCategory

	/// <exclude/>
	public class ActivityCategory : Terrasoft.Configuration.ActivityCategory
	{

		#region Constructors: Public

		public ActivityCategory(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityCategory(Terrasoft.Configuration.ActivityCategory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByActivityCategory {
			get;
			set;
		}

		public IEnumerable<ActivityCategoryResultEntry> ActivityCategoryResultEntryCollectionByActivityCategory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

