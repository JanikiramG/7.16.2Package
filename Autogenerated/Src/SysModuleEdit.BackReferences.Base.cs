namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleEdit

	/// <exclude/>
	public class SysModuleEdit : Terrasoft.Configuration.SysModuleEdit
	{

		#region Constructors: Public

		public SysModuleEdit(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleEdit(Terrasoft.Configuration.SysModuleEdit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<QuickAddMenuItem> QuickAddMenuItemCollectionBySysModuleEdit {
			get;
			set;
		}

		public IEnumerable<SysModuleEditDetail> SysModuleEditDetailCollectionBySysModuleEdit {
			get;
			set;
		}

		public IEnumerable<SysModuleEditLczOld> SysModuleEditLczOldCollectionByRecord {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

