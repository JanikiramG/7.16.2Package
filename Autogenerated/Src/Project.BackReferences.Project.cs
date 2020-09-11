namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Project

	/// <exclude/>
	public class Project : Terrasoft.Configuration.Project
	{

		#region Constructors: Public

		public Project(UserConnection userConnection)
			: base(userConnection) {
		}

		public Project(Terrasoft.Configuration.Project source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Cashflow> CashflowCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByProject {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByParentProject {
			get;
			set;
		}

		public IEnumerable<ProjectFile> ProjectFileCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectInFolder> ProjectInFolderCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectInTag> ProjectInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ProjectPlanHistoryItem> ProjectPlanHistoryItemCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectProduct> ProjectProductCollectionByProject {
			get;
			set;
		}

		public IEnumerable<ProjectResourceElement> ProjectResourceElementCollectionByProject {
			get;
			set;
		}

		public IEnumerable<VwProjectHierarchy> VwProjectHierarchyCollectionByBaseProject {
			get;
			set;
		}

		public IEnumerable<VwProjectHierarchy> VwProjectHierarchyCollectionByProject {
			get;
			set;
		}

		public IEnumerable<VwProjectProduct> VwProjectProductCollectionByProject {
			get;
			set;
		}

		public IEnumerable<WorkResourceElement> WorkResourceElementCollectionByProject {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

