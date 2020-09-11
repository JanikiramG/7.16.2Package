namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysModuleEntityForEdit

	/// <exclude/>
	public class VwSysModuleEntityForEdit : Terrasoft.Configuration.VwSysModuleEntityForEdit
	{

		#region Constructors: Public

		public VwSysModuleEntityForEdit(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysModuleEntityForEdit(Terrasoft.Configuration.VwSysModuleEntityForEdit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

