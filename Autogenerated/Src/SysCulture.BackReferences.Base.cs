namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysCulture

	/// <exclude/>
	public class SysCulture : Terrasoft.Configuration.SysCulture
	{

		#region Constructors: Public

		public SysCulture(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysCulture(Terrasoft.Configuration.SysCulture source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MainParamLczOld> MainParamLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysClientUnitSchemaSource> SysClientUnitSchemaSourceCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysLocalizableValue> SysLocalizableValueCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysModuleActionLczOld> SysModuleActionLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysModuleAnalyticsReportLczOld> SysModuleAnalyticsReportLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysModuleDetailLczOld> SysModuleDetailLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysModuleEditLczOld> SysModuleEditLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysModuleFolderLczOld> SysModuleFolderLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysModuleLczOld> SysModuleLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysModuleReportLczOld> SysModuleReportLczOldCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysPackageDataLcz> SysPackageDataLczCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysPackageResourceChecksum> SysPackageResourceChecksumCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<SysProfileData> SysProfileDataCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<VwSspAdminUnit> VwSspAdminUnitCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<VwSSPSysAdminUnit> VwSSPSysAdminUnitCollectionBySysCulture {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionBySysCulture {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

