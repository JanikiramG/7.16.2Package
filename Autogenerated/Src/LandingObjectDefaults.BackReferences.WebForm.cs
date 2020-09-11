namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LandingObjectDefaults

	/// <exclude/>
	public class LandingObjectDefaults : Terrasoft.Configuration.LandingObjectDefaults
	{

		#region Constructors: Public

		public LandingObjectDefaults(UserConnection userConnection)
			: base(userConnection) {
		}

		public LandingObjectDefaults(Terrasoft.Configuration.LandingObjectDefaults source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

