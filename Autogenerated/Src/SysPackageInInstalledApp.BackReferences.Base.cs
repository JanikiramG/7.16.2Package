namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageInInstalledApp

	/// <exclude/>
	public class SysPackageInInstalledApp : Terrasoft.Configuration.SysPackageInInstalledApp
	{

		#region Constructors: Public

		public SysPackageInInstalledApp(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageInInstalledApp(Terrasoft.Configuration.SysPackageInInstalledApp source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

