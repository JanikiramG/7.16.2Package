namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Contact

	/// <exclude/>
	public class Contact : Terrasoft.Configuration.Contact
	{

		#region Constructors: Public

		public Contact(UserConnection userConnection)
			: base(userConnection) {
		}

		public Contact(Terrasoft.Configuration.Contact source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Account> AccountCollectionByPrimaryContact {
			get;
			set;
		}

		public IEnumerable<AccountBillingInfo> AccountBillingInfoCollectionByAccountManager {
			get;
			set;
		}

		public IEnumerable<AccountBillingInfo> AccountBillingInfoCollectionByChiefAccountant {
			get;
			set;
		}

		public IEnumerable<AccountFile> AccountFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<AccountOrganizationChart> AccountOrganizationChartCollectionByManager {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByAuthor {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByOrganizer {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionBySenderContact {
			get;
			set;
		}

		public IEnumerable<ActivityFile> ActivityFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ActivityParticipant> ActivityParticipantCollectionByParticipant {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByContact {
			get;
			set;
		}

		public IEnumerable<CallFile> CallFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Certificate> CertificateCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Comment> CommentCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ContactAddress> ContactAddressCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactAnniversary> ContactAnniversaryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactCareer> ContactCareerCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactCommunication> ContactCommunicationCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactCorrespondence> ContactCorrespondenceCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactDuplicate> ContactDuplicateCollectionByEntity1 {
			get;
			set;
		}

		public IEnumerable<ContactDuplicate> ContactDuplicateCollectionByEntity2 {
			get;
			set;
		}

		public IEnumerable<ContactExternalRate> ContactExternalRateCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactFile> ContactFileCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactFile> ContactFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactInFolder> ContactInFolderCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactInTag> ContactInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ContactInternalRate> ContactInternalRateCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactsProductInterest> ContactsProductInterestCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContentBlockFile> ContentBlockFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ContractFile> ContractFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ContractVisa> ContractVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<CTISearchResult> CTISearchResultCollectionByContact {
			get;
			set;
		}

		public IEnumerable<DayOff> DayOffCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<DocumentFile> DocumentFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<EducationActivity> EducationActivityCollectionByContact {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByContact {
			get;
			set;
		}

		public IEnumerable<EmailMessageData> EmailMessageDataCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<EmailTemplateFile> EmailTemplateFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Employee> EmployeeCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Employee> EmployeeCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<EmployeeFile> EmployeeFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<EnrchFoundContact> EnrchFoundContactCollectionByContact {
			get;
			set;
		}

		public IEnumerable<EnrchProcessedData> EnrchProcessedDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<EnrchRejectedData> EnrchRejectedDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ESNNotification> ESNNotificationCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ExternalAccess> ExternalAccessCollectionByGrantor {
			get;
			set;
		}

		public IEnumerable<ExternalAccessFile> ExternalAccessFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ExternalAccessRequestLog> ExternalAccessRequestLogCollectionByRequestedBy {
			get;
			set;
		}

		public IEnumerable<Favorites> FavoritesCollectionByContact {
			get;
			set;
		}

		public IEnumerable<File> FileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<FileLead> FileLeadCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<GeneratedWebForm> GeneratedWebFormCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormFile> GeneratedWebFormFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<InvoiceFile> InvoiceFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<InvoiceVisa> InvoiceVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseFile> KnowledgeBaseFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByPartnerOwner {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByQualifiedContact {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionBySalesOwner {
			get;
			set;
		}

		public IEnumerable<LeadInQualifyStatus> LeadInQualifyStatusCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Like> LikeCollectionByContact {
			get;
			set;
		}

		public IEnumerable<LocationHistory> LocationHistoryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<MailboxSettingsFile> MailboxSettingsFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<MLModelFile> MLModelFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<OAuth20AppFile> OAuth20AppFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<OpportunityContact> OpportunityContactCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OpportunityDepartment> OpportunityDepartmentCollectionBySalesDirector {
			get;
			set;
		}

		public IEnumerable<OpportunityFile> OpportunityFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<OpportunityInStage> OpportunityInStageCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<OpportunityParticipant> OpportunityParticipantCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OpportunityVisa> OpportunityVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<OrderFile> OrderFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<OrderVisa> OrderVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<PartnershipFile> PartnershipFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ProductFile> ProductFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ProjectFile> ProjectFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ProjectResourceElement> ProjectResourceElementCollectionByContact {
			get;
			set;
		}

		public IEnumerable<QuickDialUserSettings> QuickDialUserSettingsCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Relationship> RelationshipCollectionByContactA {
			get;
			set;
		}

		public IEnumerable<Relationship> RelationshipCollectionByContactB {
			get;
			set;
		}

		public IEnumerable<Reminding> RemindingCollectionByAuthor {
			get;
			set;
		}

		public IEnumerable<Reminding> RemindingCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SocialMention> SocialMentionCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysGridPageView> SysGridPageViewCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysOperationAudit> SysOperationAuditCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysOperationAuditArch> SysOperationAuditArchCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysPrcElHistoryLog> SysPrcElHistoryLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysPrcHistoryLog> SysPrcHistoryLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysProcessData> SysProcessDataCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysProcessElementData> SysProcessElementDataCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysProcessElementLog> SysProcessElementLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysProcessLog> SysProcessLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysProfileData> SysProfileDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysRegistrationData> SysRegistrationDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprograms> UsrTreatmentprogramsCollectionByUsrOwner {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprogramsFile> UsrTreatmentprogramsFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwAccountRelationship> VwAccountRelationshipCollectionByRelatedContact {
			get;
			set;
		}

		public IEnumerable<VwAnniversary> VwAnniversaryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwContactDuplicate> VwContactDuplicateCollectionByEntity1 {
			get;
			set;
		}

		public IEnumerable<VwContactDuplicate> VwContactDuplicateCollectionByEntity2 {
			get;
			set;
		}

		public IEnumerable<VwContactModuleHistory> VwContactModuleHistoryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwContactRelationship> VwContactRelationshipCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwContactRelationship> VwContactRelationshipCollectionByRelatedContact {
			get;
			set;
		}

		public IEnumerable<VwModuleHistory> VwModuleHistoryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwOpportunityInStage> VwOpportunityInStageCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByElementOwner {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByProcessOwner {
			get;
			set;
		}

		public IEnumerable<VwProcessLibFile> VwProcessLibFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwRelationship> VwRelationshipCollectionByContactA {
			get;
			set;
		}

		public IEnumerable<VwRelationship> VwRelationshipCollectionByContactB {
			get;
			set;
		}

		public IEnumerable<VwRemindings> VwRemindingsCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwRemindingsCount> VwRemindingsCountCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwSspAdminUnit> VwSspAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwSSPSysAdminUnit> VwSSPSysAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwSysProcessElementLog> VwSysProcessElementLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwSysProcessFile> VwSysProcessFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwSysProcessLog> VwSysProcessLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwSysProcessMILog> VwSysProcessMILogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwSystemUsers> VwSystemUsersCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwVisa> VwVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<WebServiceV2File> WebServiceV2FileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<WSysAccount> WSysAccountCollectionByContact {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

