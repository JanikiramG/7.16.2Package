namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityStage

	/// <exclude/>
	public class OpportunityStage : Terrasoft.Configuration.OpportunityStage
	{

		#region Constructors: Public

		public OpportunityStage(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityStage(Terrasoft.Configuration.OpportunityStage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Opportunity> OpportunityCollectionByStage {
			get;
			set;
		}

		public IEnumerable<OpportunityInStage> OpportunityInStageCollectionByStage {
			get;
			set;
		}

		public IEnumerable<OppStageDecoupling> OppStageDecouplingCollectionByAvailableStage {
			get;
			set;
		}

		public IEnumerable<OppStageDecoupling> OppStageDecouplingCollectionByCurrentStage {
			get;
			set;
		}

		public IEnumerable<VwOpportFunnelData> VwOpportFunnelDataCollectionByfStage {
			get;
			set;
		}

		public IEnumerable<VwOpportFunnelData> VwOpportFunnelDataCollectionBylStage {
			get;
			set;
		}

		public IEnumerable<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisCollectionByStage {
			get;
			set;
		}

		public IEnumerable<VwOpportunityInStage> VwOpportunityInStageCollectionByStage {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByStage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

