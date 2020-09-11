namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackage

	/// <exclude/>
	public class SysPackage : Terrasoft.Configuration.SysPackage
	{

		#region Constructors: Public

		public SysPackage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackage(Terrasoft.Configuration.SysPackage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysInstalledPackageData> SysInstalledPackageDataCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysLocalizableValue> SysLocalizableValueCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageDependency> SysPackageDependencyCollectionByDependOnPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageDependency> SysPackageDependencyCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageHierarchy> SysPackageHierarchyCollectionByBaseSysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageHierarchy> SysPackageHierarchyCollectionByDependOnPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageHierarchy> SysPackageHierarchyCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageInInstalledApp> SysPackageInInstalledAppCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageReferenceAssembly> SysPackageReferenceAssemblyCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageResourceChecksum> SysPackageResourceChecksumCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageSchemaData> SysPackageSchemaDataCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysPackageSqlScript> SysPackageSqlScriptCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<SysSchema> SysSchemaCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwProcessLib> VwProcessLibCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysClientUnitSchema> VwSysClientUnitSchemaCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysClientUnitSchemaInPackage> VwSysClientUnitSchemaInPackageCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysDcmLib> VwSysDcmLibCollectionByPackage {
			get;
			set;
		}

		public IEnumerable<VwSysEntitySchemaInPackage> VwSysEntitySchemaInPackageCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysEntitySchemaInWorkspace> VwSysEntitySchemaInWorkspaceCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysPageSchemaInWorkspace> VwSysPageSchemaInWorkspaceCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysProcess> VwSysProcessCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInfo> VwSysSchemaInfoCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInPackage> VwSysSchemaInPackageCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInWorkspace> VwSysSchemaInWorkspaceCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwSysSqlScriptInPackage> VwSysSqlScriptInPackageCollectionBySysPackage {
			get;
			set;
		}

		public IEnumerable<VwWebServiceV2> VwWebServiceV2CollectionBySysPackage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

