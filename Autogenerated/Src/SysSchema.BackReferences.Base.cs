namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSchema

	/// <exclude/>
	public class SysSchema : Terrasoft.Configuration.SysSchema
	{

		#region Constructors: Public

		public SysSchema(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSchema(Terrasoft.Configuration.SysSchema source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Attribute> AttributeCollectionByOwnerSchema {
			get;
			set;
		}

		public IEnumerable<Attribute> AttributeCollectionByReferenceSchema {
			get;
			set;
		}

		public IEnumerable<AttributeReferenceSchema> AttributeReferenceSchemaCollectionByReferenceSchema {
			get;
			set;
		}

		public IEnumerable<SysClientUnitSchemaDependency> SysClientUnitSchemaDependencyCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysClientUnitSchemaSource> SysClientUnitSchemaSourceCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysEditPage> SysEditPageCollectionBySysEntitySchema {
			get;
			set;
		}

		public IEnumerable<SysEditPage> SysEditPageCollectionBySysPageSchema {
			get;
			set;
		}

		public IEnumerable<SysEntityPrcStartEvent> SysEntityPrcStartEventCollectionByProcessSchema {
			get;
			set;
		}

		public IEnumerable<SysEntitySchemaReference> SysEntitySchemaReferenceCollectionByReferenceSchema {
			get;
			set;
		}

		public IEnumerable<SysEntitySchemaReference> SysEntitySchemaReferenceCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysGridPage> SysGridPageCollectionBySysEntitySchema {
			get;
			set;
		}

		public IEnumerable<SysGridPage> SysGridPageCollectionBySysPageSchema {
			get;
			set;
		}

		public IEnumerable<SysInstalledPackageData> SysInstalledPackageDataCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysLocalizableValue> SysLocalizableValueCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysModuleGridEditPage> SysModuleGridEditPageCollectionBySysEditPageSchema {
			get;
			set;
		}

		public IEnumerable<SysModuleGridEditPage> SysModuleGridEditPageCollectionBySysModuleGridPage {
			get;
			set;
		}

		public IEnumerable<SysPackageResourceChecksum> SysPackageResourceChecksumCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysPackageSchemaData> SysPackageSchemaDataCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysPrcActualVersion> SysPrcActualVersionCollectionByActualVersionSchema {
			get;
			set;
		}

		public IEnumerable<SysPrcActualVersion> SysPrcActualVersionCollectionByRootVersionSchema {
			get;
			set;
		}

		public IEnumerable<SysPrcHistoryLog> SysPrcHistoryLogCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysProcessData> SysProcessDataCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysProcessDisabled> SysProcessDisabledCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysProcessLog> SysProcessLogCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysSchema> SysSchemaCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysSchemaContent> SysSchemaContentCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysSchemaProperty> SysSchemaPropertyCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<SysSSPCustomerSchema> SysSSPCustomerSchemaCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<VwProcessLib> VwProcessLibCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysDcmLib> VwSysDcmLibCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysEntitySchemaInWorkspace> VwSysEntitySchemaInWorkspaceCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysPageSchemaInWorkspace> VwSysPageSchemaInWorkspaceCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysProcess> VwSysProcessCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysProcessLog> VwSysProcessLogCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<VwSysProcessMILog> VwSysProcessMILogCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaDataInPackage> VwSysSchemaDataInPackageCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInfo> VwSysSchemaInfoCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInWorkspace> VwSysSchemaInWorkspaceCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysSSPEntitySchemaAccessList> VwSysSSPEntitySchemaAccessListCollectionBySysSchema {
			get;
			set;
		}

		public IEnumerable<VwWebServiceV2> VwWebServiceV2CollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

