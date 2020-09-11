namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Opportunity

	/// <exclude/>
	public class Opportunity : Terrasoft.Configuration.Opportunity
	{

		#region Constructors: Public

		public Opportunity(UserConnection userConnection)
			: base(userConnection) {
		}

		public Opportunity(Terrasoft.Configuration.Opportunity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityCompetitor> OpportunityCompetitorCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityContact> OpportunityContactCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityFile> OpportunityFileCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityInFolder> OpportunityInFolderCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityInStage> OpportunityInStageCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityInTag> OpportunityInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<OpportunityParticipant> OpportunityParticipantCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityProductInterest> OpportunityProductInterestCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityTacticHist> OpportunityTacticHistCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<OpportunityVisa> OpportunityVisaCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<VwOpportFunnelData> VwOpportFunnelDataCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisCollectionByOpportunity {
			get;
			set;
		}

		public IEnumerable<VwOpportunityInStage> VwOpportunityInStageCollectionByOpportunity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

