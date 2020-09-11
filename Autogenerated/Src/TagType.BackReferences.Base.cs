namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: TagType

	/// <exclude/>
	public class TagType : Terrasoft.Configuration.TagType
	{

		#region Constructors: Public

		public TagType(UserConnection userConnection)
			: base(userConnection) {
		}

		public TagType(Terrasoft.Configuration.TagType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountTag> AccountTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<ActivityTag> ActivityTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<CallTag> CallTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<ContactTag> ContactTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<ContentBlockTag> ContentBlockTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<ContractTag> ContractTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<DocumentTag> DocumentTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<DuplicatesRuleTag> DuplicatesRuleTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<EmployeeTag> EmployeeTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<ExternalAccessTag> ExternalAccessTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormTag> GeneratedWebFormTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<InvoiceTag> InvoiceTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseTagV2> KnowledgeBaseTagV2CollectionByType {
			get;
			set;
		}

		public IEnumerable<LeadTag> LeadTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<LookupTag> LookupTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<MLModelTag> MLModelTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<OAuth20AppTag> OAuth20AppTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<OpportunityTag> OpportunityTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<OrderTag> OrderTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<PartnershipTag> PartnershipTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<ProductTag> ProductTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<ProjectTag> ProjectTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<SocialChannelTag> SocialChannelTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<SysTranslationTag> SysTranslationTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprogramsTag> UsrTreatmentprogramsTagCollectionByType {
			get;
			set;
		}

		public IEnumerable<WebServiceV2Tag> WebServiceV2TagCollectionByType {
			get;
			set;
		}

		public IEnumerable<WSysAccountTag> WSysAccountTagCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

