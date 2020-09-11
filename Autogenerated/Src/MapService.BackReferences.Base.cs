namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MapService

	/// <exclude/>
	public class MapService : Terrasoft.Configuration.MapService
	{

		#region Constructors: Public

		public MapService(UserConnection userConnection)
			: base(userConnection) {
		}

		public MapService(Terrasoft.Configuration.MapService source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

