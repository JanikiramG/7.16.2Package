namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityTag

	/// <exclude/>
	public class ActivityTag : Terrasoft.Configuration.ActivityTag
	{

		#region Constructors: Public

		public ActivityTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityTag(Terrasoft.Configuration.ActivityTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivityInTag> ActivityInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

