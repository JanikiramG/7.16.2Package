namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageModule

	/// <exclude/>
	public class SysPackageModule : Terrasoft.Configuration.SysPackageModule
	{

		#region Constructors: Public

		public SysPackageModule(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageModule(Terrasoft.Configuration.SysPackageModule source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

