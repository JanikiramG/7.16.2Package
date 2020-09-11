namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityInTag

	/// <exclude/>
	public class ActivityInTag : Terrasoft.Configuration.ActivityInTag
	{

		#region Constructors: Public

		public ActivityInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityInTag(Terrasoft.Configuration.ActivityInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

