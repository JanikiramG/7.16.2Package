namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityCorrespondence

	/// <exclude/>
	public class ActivityCorrespondence : Terrasoft.Configuration.ActivityCorrespondence
	{

		#region Constructors: Public

		public ActivityCorrespondence(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityCorrespondence(Terrasoft.Configuration.ActivityCorrespondence source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

