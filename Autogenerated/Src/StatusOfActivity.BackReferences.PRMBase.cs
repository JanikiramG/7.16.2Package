namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: StatusOfActivity

	/// <exclude/>
	public class StatusOfActivity : Terrasoft.Configuration.StatusOfActivity
	{

		#region Constructors: Public

		public StatusOfActivity(UserConnection userConnection)
			: base(userConnection) {
		}

		public StatusOfActivity(Terrasoft.Configuration.StatusOfActivity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

