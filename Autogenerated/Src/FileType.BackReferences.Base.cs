namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FileType

	/// <exclude/>
	public class FileType : Terrasoft.Configuration.FileType
	{

		#region Constructors: Public

		public FileType(UserConnection userConnection)
			: base(userConnection) {
		}

		public FileType(Terrasoft.Configuration.FileType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountFile> AccountFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<ActivityFile> ActivityFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<CallFile> CallFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<ContactFile> ContactFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<ContentBlockFile> ContentBlockFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<ContractFile> ContractFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<DocumentFile> DocumentFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<EmailTemplateFile> EmailTemplateFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<EmployeeFile> EmployeeFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<ExternalAccessFile> ExternalAccessFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<File> FileCollectionByType {
			get;
			set;
		}

		public IEnumerable<FileLead> FileLeadCollectionByType {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormFile> GeneratedWebFormFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<InvoiceFile> InvoiceFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseFile> KnowledgeBaseFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<MailboxSettingsFile> MailboxSettingsFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<MLModelFile> MLModelFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<OAuth20AppFile> OAuth20AppFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<OpportunityFile> OpportunityFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<OrderFile> OrderFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<PartnershipFile> PartnershipFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<ProductFile> ProductFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<ProjectFile> ProjectFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprogramsFile> UsrTreatmentprogramsFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<VwProcessLibFile> VwProcessLibFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<VwSysProcessFile> VwSysProcessFileCollectionByType {
			get;
			set;
		}

		public IEnumerable<WebServiceV2File> WebServiceV2FileCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

