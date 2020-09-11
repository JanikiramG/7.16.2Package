namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwOpportunityInStage

	/// <exclude/>
	public class VwOpportunityInStage : Terrasoft.Configuration.VwOpportunityInStage
	{

		#region Constructors: Public

		public VwOpportunityInStage(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwOpportunityInStage(Terrasoft.Configuration.VwOpportunityInStage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

