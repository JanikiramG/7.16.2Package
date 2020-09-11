namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleEntity

	/// <exclude/>
	public class SysModuleEntity : Terrasoft.Configuration.SysModuleEntity
	{

		#region Constructors: Public

		public SysModuleEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleEntity(Terrasoft.Configuration.SysModuleEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Portal_SysModule> Portal_SysModuleCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<SysDcmSettings> SysDcmSettingsCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<SysModule> SysModuleCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<SysModuleDcmSettings> SysModuleDcmSettingsCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<SysModuleEdit> SysModuleEditCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<SysModuleEntityInPortal> SysModuleEntityInPortalCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<SysModuleGrid> SysModuleGridCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<VwSysModuleEdit> VwSysModuleEditCollectionBySysModuleEntity {
			get;
			set;
		}

		public IEnumerable<VwSysModuleSchemaEdit> VwSysModuleSchemaEditCollectionBySysModuleEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

