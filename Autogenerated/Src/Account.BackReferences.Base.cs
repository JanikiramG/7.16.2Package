namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Account

	/// <exclude/>
	public class Account : Terrasoft.Configuration.Account
	{

		#region Constructors: Public

		public Account(UserConnection userConnection)
			: base(userConnection) {
		}

		public Account(Terrasoft.Configuration.Account source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByParent {
			get;
			set;
		}

		public IEnumerable<AccountAddress> AccountAddressCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountAlternativeName> AccountAlternativeNameCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountAnniversary> AccountAnniversaryCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountBillingInfo> AccountBillingInfoCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountCommunication> AccountCommunicationCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountDuplicate> AccountDuplicateCollectionByEntity1 {
			get;
			set;
		}

		public IEnumerable<AccountDuplicate> AccountDuplicateCollectionByEntity2 {
			get;
			set;
		}

		public IEnumerable<AccountEnrichedData> AccountEnrichedDataCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountFile> AccountFileCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountForecast> AccountForecastCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountInFolder> AccountInFolderCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<AccountInTag> AccountInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<AccountOrganizationChart> AccountOrganizationChartCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<CompetitorProduct> CompetitorProductCollectionByCompetitor {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<ContactCareer> ContactCareerCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByOurCompany {
			get;
			set;
		}

		public IEnumerable<CTISearchResult> CTISearchResultCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Employee> EmployeeCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<EmployeeCareer> EmployeeCareerCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<EnrchFoundAccount> EnrchFoundAccountCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionBySupplier {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByPartner {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByQualifiedAccount {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByPartner {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByWinner {
			get;
			set;
		}

		public IEnumerable<OpportunityCompetitor> OpportunityCompetitorCollectionByCompetitor {
			get;
			set;
		}

		public IEnumerable<OpportunityCompetitor> OpportunityCompetitorCollectionBySupplier {
			get;
			set;
		}

		public IEnumerable<OpportunityParticipant> OpportunityParticipantCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Partnership> PartnershipCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionBySupplier {
			get;
			set;
		}

		public IEnumerable<QuickDialUserSettings> QuickDialUserSettingsCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<Relationship> RelationshipCollectionByAccountA {
			get;
			set;
		}

		public IEnumerable<Relationship> RelationshipCollectionByAccountB {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByPortalAccount {
			get;
			set;
		}

		public IEnumerable<VwAccountDuplicate> VwAccountDuplicateCollectionByEntity1 {
			get;
			set;
		}

		public IEnumerable<VwAccountDuplicate> VwAccountDuplicateCollectionByEntity2 {
			get;
			set;
		}

		public IEnumerable<VwAccountModuleHistory> VwAccountModuleHistoryCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwAccountRelationship> VwAccountRelationshipCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwAccountRelationship> VwAccountRelationshipCollectionByRelatedAccount {
			get;
			set;
		}

		public IEnumerable<VwAnniversary> VwAnniversaryCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwContactRelationship> VwContactRelationshipCollectionByRelatedAccount {
			get;
			set;
		}

		public IEnumerable<VwModuleHistory> VwModuleHistoryCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByPartner {
			get;
			set;
		}

		public IEnumerable<VwProjectHierarchy> VwProjectHierarchyCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwRelationship> VwRelationshipCollectionByAccountA {
			get;
			set;
		}

		public IEnumerable<VwRelationship> VwRelationshipCollectionByAccountB {
			get;
			set;
		}

		public IEnumerable<VwSspAdminUnit> VwSspAdminUnitCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwSspAdminUnit> VwSspAdminUnitCollectionByPortalAccount {
			get;
			set;
		}

		public IEnumerable<VwSSPSysAdminUnit> VwSSPSysAdminUnitCollectionByAccount {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByAccount {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

