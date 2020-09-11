namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleInSysModuleFolder

	/// <exclude/>
	public class SysModuleInSysModuleFolder : Terrasoft.Configuration.SysModuleInSysModuleFolder
	{

		#region Constructors: Public

		public SysModuleInSysModuleFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleInSysModuleFolder(Terrasoft.Configuration.SysModuleInSysModuleFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

