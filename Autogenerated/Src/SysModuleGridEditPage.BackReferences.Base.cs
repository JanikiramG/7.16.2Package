namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleGridEditPage

	/// <exclude/>
	public class SysModuleGridEditPage : Terrasoft.Configuration.SysModuleGridEditPage
	{

		#region Constructors: Public

		public SysModuleGridEditPage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleGridEditPage(Terrasoft.Configuration.SysModuleGridEditPage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

