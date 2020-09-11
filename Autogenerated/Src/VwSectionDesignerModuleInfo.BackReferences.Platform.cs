namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSectionDesignerModuleInfo

	/// <exclude/>
	public class VwSectionDesignerModuleInfo : Terrasoft.Configuration.VwSectionDesignerModuleInfo
	{

		#region Constructors: Public

		public VwSectionDesignerModuleInfo(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSectionDesignerModuleInfo(Terrasoft.Configuration.VwSectionDesignerModuleInfo source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

