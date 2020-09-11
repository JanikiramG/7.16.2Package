namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityInFolder

	/// <exclude/>
	public class ActivityInFolder : Terrasoft.Configuration.ActivityInFolder
	{

		#region Constructors: Public

		public ActivityInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityInFolder(Terrasoft.Configuration.ActivityInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

