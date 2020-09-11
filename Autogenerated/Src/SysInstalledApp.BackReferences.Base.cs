namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysInstalledApp

	/// <exclude/>
	public class SysInstalledApp : Terrasoft.Configuration.SysInstalledApp
	{

		#region Constructors: Public

		public SysInstalledApp(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysInstalledApp(Terrasoft.Configuration.SysInstalledApp source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPackageInInstalledApp> SysPackageInInstalledAppCollectionBySysInstalledApp {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

