namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLicPackageNames

	/// <exclude/>
	public class SysLicPackageNames : Terrasoft.Configuration.SysLicPackageNames
	{

		#region Constructors: Public

		public SysLicPackageNames(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLicPackageNames(Terrasoft.Configuration.SysLicPackageNames source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

