namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModule

	/// <exclude/>
	public class SysModule : Terrasoft.Configuration.SysModule
	{

		#region Constructors: Public

		public SysModule(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModule(Terrasoft.Configuration.SysModule source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MessageNotifierBySection> MessageNotifierBySectionCollectionBySection {
			get;
			set;
		}

		public IEnumerable<MessagePublisherBySection> MessagePublisherBySectionCollectionBySection {
			get;
			set;
		}

		public IEnumerable<ProcessInModules> ProcessInModulesCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByHomePage {
			get;
			set;
		}

		public IEnumerable<SysDashboard> SysDashboardCollectionBySection {
			get;
			set;
		}

		public IEnumerable<SysModuleAction> SysModuleActionCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysModuleAnalyticsReport> SysModuleAnalyticsReportCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysModuleDetail> SysModuleDetailCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysModuleInWorkplace> SysModuleInWorkplaceCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysModuleLczOld> SysModuleLczOldCollectionByRecord {
			get;
			set;
		}

		public IEnumerable<SysModulePrimaryGrid> SysModulePrimaryGridCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysModuleReport> SysModuleReportCollectionBySysModule {
			get;
			set;
		}

		public IEnumerable<SysWidgetDashboard> SysWidgetDashboardCollectionBySection {
			get;
			set;
		}

		public IEnumerable<VwSSPSysAdminUnit> VwSSPSysAdminUnitCollectionByHomePage {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByHomePage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

