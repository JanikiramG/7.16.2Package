namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModulePrimaryGrid

	/// <exclude/>
	public class SysModulePrimaryGrid : Terrasoft.Configuration.SysModulePrimaryGrid
	{

		#region Constructors: Public

		public SysModulePrimaryGrid(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModulePrimaryGrid(Terrasoft.Configuration.SysModulePrimaryGrid source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

