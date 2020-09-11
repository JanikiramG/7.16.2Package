namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleGrid

	/// <exclude/>
	public class SysModuleGrid : Terrasoft.Configuration.SysModuleGrid
	{

		#region Constructors: Public

		public SysModuleGrid(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleGrid(Terrasoft.Configuration.SysModuleGrid source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleDetail> SysModuleDetailCollectionBySysModuleGrid {
			get;
			set;
		}

		public IEnumerable<SysModuleEditDetail> SysModuleEditDetailCollectionBySysModuleGrid {
			get;
			set;
		}

		public IEnumerable<SysModuleGridView> SysModuleGridViewCollectionBySysModuleGrid {
			get;
			set;
		}

		public IEnumerable<SysModulePrimaryGrid> SysModulePrimaryGridCollectionBySysModuleGrid {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

