namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageResourceChecksum

	/// <exclude/>
	public class SysPackageResourceChecksum : Terrasoft.Configuration.SysPackageResourceChecksum
	{

		#region Constructors: Public

		public SysPackageResourceChecksum(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageResourceChecksum(Terrasoft.Configuration.SysPackageResourceChecksum source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

