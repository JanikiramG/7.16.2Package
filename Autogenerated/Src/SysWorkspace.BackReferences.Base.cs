namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysWorkspace

	/// <exclude/>
	public class SysWorkspace : Terrasoft.Configuration.SysWorkspace
	{

		#region Constructors: Public

		public SysWorkspace(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysWorkspace(Terrasoft.Configuration.SysWorkspace source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPackage> SysPackageCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<SysPackageHierarchy> SysPackageHierarchyCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<SysPackageModule> SysPackageModuleCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<SysPrcHistoryLog> SysPrcHistoryLogCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<SysProcessLog> SysProcessLogCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwAdministrativeObjects> VwAdministrativeObjectsCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwLogObjects> VwLogObjectsCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwProcessLib> VwProcessLibCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysClientUnitSchema> VwSysClientUnitSchemaCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysClientUnitSchemaInPackage> VwSysClientUnitSchemaInPackageCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysDcmLib> VwSysDcmLibCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysEntitySchemaInPackage> VwSysEntitySchemaInPackageCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysEntitySchemaInWorkspace> VwSysEntitySchemaInWorkspaceCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysLookup> VwSysLookupCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysModuleEdit> VwSysModuleEditCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysModuleEntity> VwSysModuleEntityCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysModuleEntityForEdit> VwSysModuleEntityForEditCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysPageSchemaInWorkspace> VwSysPageSchemaInWorkspaceCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysProcess> VwSysProcessCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysProcessEntity> VwSysProcessEntityCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysProcessLog> VwSysProcessLogCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysProcessMILog> VwSysProcessMILogCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInfo> VwSysSchemaInfoCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInPackage> VwSysSchemaInPackageCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInWorkspace> VwSysSchemaInWorkspaceCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwSysSqlScriptInPackage> VwSysSqlScriptInPackageCollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwWebServiceV2> VwWebServiceV2CollectionBySysWorkspace {
			get;
			set;
		}

		public IEnumerable<VwWorkspaceObjects> VwWorkspaceObjectsCollectionBySysWorkspace {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

