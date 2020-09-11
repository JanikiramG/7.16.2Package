namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageHierarchy

	/// <exclude/>
	public class SysPackageHierarchy : Terrasoft.Configuration.SysPackageHierarchy
	{

		#region Constructors: Public

		public SysPackageHierarchy(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageHierarchy(Terrasoft.Configuration.SysPackageHierarchy source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

