namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: TimelineTileSetting

	/// <exclude/>
	public class TimelineTileSetting : Terrasoft.Configuration.TimelineTileSetting
	{

		#region Constructors: Public

		public TimelineTileSetting(UserConnection userConnection)
			: base(userConnection) {
		}

		public TimelineTileSetting(Terrasoft.Configuration.TimelineTileSetting source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

