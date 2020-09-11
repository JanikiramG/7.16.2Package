namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LandingLeadDefaults

	/// <exclude/>
	public class LandingLeadDefaults : Terrasoft.Configuration.LandingLeadDefaults
	{

		#region Constructors: Public

		public LandingLeadDefaults(UserConnection userConnection)
			: base(userConnection) {
		}

		public LandingLeadDefaults(Terrasoft.Configuration.LandingLeadDefaults source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

