namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityFile

	/// <exclude/>
	public class ActivityFile : Terrasoft.Configuration.ActivityFile
	{

		#region Constructors: Public

		public ActivityFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityFile(Terrasoft.Configuration.ActivityFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

