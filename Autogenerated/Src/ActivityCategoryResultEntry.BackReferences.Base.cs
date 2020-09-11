namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityCategoryResultEntry

	/// <exclude/>
	public class ActivityCategoryResultEntry : Terrasoft.Configuration.ActivityCategoryResultEntry
	{

		#region Constructors: Public

		public ActivityCategoryResultEntry(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityCategoryResultEntry(Terrasoft.Configuration.ActivityCategoryResultEntry source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

