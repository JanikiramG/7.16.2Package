namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleGridView

	/// <exclude/>
	public class SysModuleGridView : Terrasoft.Configuration.SysModuleGridView
	{

		#region Constructors: Public

		public SysModuleGridView(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleGridView(Terrasoft.Configuration.SysModuleGridView source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

