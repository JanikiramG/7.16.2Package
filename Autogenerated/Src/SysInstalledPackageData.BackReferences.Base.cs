namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysInstalledPackageData

	/// <exclude/>
	public class SysInstalledPackageData : Terrasoft.Configuration.SysInstalledPackageData
	{

		#region Constructors: Public

		public SysInstalledPackageData(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysInstalledPackageData(Terrasoft.Configuration.SysInstalledPackageData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

