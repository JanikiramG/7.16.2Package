namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivitySyncSettings

	/// <exclude/>
	public class ActivitySyncSettings : Terrasoft.Configuration.ActivitySyncSettings
	{

		#region Constructors: Public

		public ActivitySyncSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivitySyncSettings(Terrasoft.Configuration.ActivitySyncSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

