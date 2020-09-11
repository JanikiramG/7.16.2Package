namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityResultCategory

	/// <exclude/>
	public class ActivityResultCategory : Terrasoft.Configuration.ActivityResultCategory
	{

		#region Constructors: Public

		public ActivityResultCategory(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityResultCategory(Terrasoft.Configuration.ActivityResultCategory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivityResult> ActivityResultCollectionByCategory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

