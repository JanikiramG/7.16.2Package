namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleFolder

	/// <exclude/>
	public class SysModuleFolder : Terrasoft.Configuration.SysModuleFolder
	{

		#region Constructors: Public

		public SysModuleFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleFolder(Terrasoft.Configuration.SysModuleFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleFolderLczOld> SysModuleFolderLczOldCollectionByRecord {
			get;
			set;
		}

		public IEnumerable<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderCollectionBySubSysModuleFolder {
			get;
			set;
		}

		public IEnumerable<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderCollectionBySysModuleFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

