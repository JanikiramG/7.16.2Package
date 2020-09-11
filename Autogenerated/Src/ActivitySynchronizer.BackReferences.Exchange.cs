namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivitySynchronizer

	/// <exclude/>
	public class ActivitySynchronizer : Terrasoft.Configuration.ActivitySynchronizer
	{

		#region Constructors: Public

		public ActivitySynchronizer(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivitySynchronizer(Terrasoft.Configuration.ActivitySynchronizer source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

