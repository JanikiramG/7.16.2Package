namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleFolderMode

	/// <exclude/>
	public class SysModuleFolderMode : Terrasoft.Configuration.SysModuleFolderMode
	{

		#region Constructors: Public

		public SysModuleFolderMode(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleFolderMode(Terrasoft.Configuration.SysModuleFolderMode source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Portal_SysModule> Portal_SysModuleCollectionByFolderMode {
			get;
			set;
		}

		public IEnumerable<SysModule> SysModuleCollectionByFolderMode {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

