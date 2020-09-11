namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityInStage

	/// <exclude/>
	public class OpportunityInStage : Terrasoft.Configuration.OpportunityInStage
	{

		#region Constructors: Public

		public OpportunityInStage(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityInStage(Terrasoft.Configuration.OpportunityInStage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

