namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LocationHistory

	/// <exclude/>
	public class LocationHistory : Terrasoft.Configuration.LocationHistory
	{

		#region Constructors: Public

		public LocationHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public LocationHistory(Terrasoft.Configuration.LocationHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

