namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityTypeStatusEntry

	/// <exclude/>
	public class ActivityTypeStatusEntry : Terrasoft.Configuration.ActivityTypeStatusEntry
	{

		#region Constructors: Public

		public ActivityTypeStatusEntry(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityTypeStatusEntry(Terrasoft.Configuration.ActivityTypeStatusEntry source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

