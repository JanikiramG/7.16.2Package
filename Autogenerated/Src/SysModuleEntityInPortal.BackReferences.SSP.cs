namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleEntityInPortal

	/// <exclude/>
	public class SysModuleEntityInPortal : Terrasoft.Configuration.SysModuleEntityInPortal
	{

		#region Constructors: Public

		public SysModuleEntityInPortal(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleEntityInPortal(Terrasoft.Configuration.SysModuleEntityInPortal source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

