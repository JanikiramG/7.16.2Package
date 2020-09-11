namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FolderType

	/// <exclude/>
	public class FolderType : Terrasoft.Configuration.FolderType
	{

		#region Constructors: Public

		public FolderType(UserConnection userConnection)
			: base(userConnection) {
		}

		public FolderType(Terrasoft.Configuration.FolderType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountFolder> AccountFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<ActivityFolder> ActivityFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<CallFolder> CallFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<ContactFolder> ContactFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<ContractFolder> ContractFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<DocumentFolder> DocumentFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<DuplicatesRuleFolder> DuplicatesRuleFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<EmployeeFolder> EmployeeFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<ExternalAccessFolder> ExternalAccessFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<FileFolder> FileFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormFolder> GeneratedWebFormFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<InvoiceFolder> InvoiceFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseFolder> KnowledgeBaseFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<LeadFolder> LeadFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<LookupFolder> LookupFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<MLModelFolder> MLModelFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<OAuth20AppFolder> OAuth20AppFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<OpportunityFolder> OpportunityFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<OrderFolder> OrderFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<PartnershipFolder> PartnershipFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<ProductFolder> ProductFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<ProjectFolder> ProjectFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<ReportFolder> ReportFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SocialChannelFolder> SocialChannelFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SysAdminOperationFolder> SysAdminOperationFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SysAdminUnitFolder> SysAdminUnitFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SysLookupFolder> SysLookupFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SysProcessLogFolder> SysProcessLogFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SysProcessUserTaskFolder> SysProcessUserTaskFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SysSettingsFolder> SysSettingsFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<SysTranslationFolder> SysTranslationFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprogramsFolder> UsrTreatmentprogramsFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<VwProcessLibFolder> VwProcessLibFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<VwSysDcmLibFolder> VwSysDcmLibFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<VwSysProcessFolder> VwSysProcessFolderCollectionByFolderType {
			get;
			set;
		}

		public IEnumerable<WebServiceV2Folder> WebServiceV2FolderCollectionByFolderType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

