namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityResult

	/// <exclude/>
	public class ActivityResult : Terrasoft.Configuration.ActivityResult
	{

		#region Constructors: Public

		public ActivityResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityResult(Terrasoft.Configuration.ActivityResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByResult {
			get;
			set;
		}

		public IEnumerable<ActivityCategoryResultEntry> ActivityCategoryResultEntryCollectionByActivityResult {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByResult {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

