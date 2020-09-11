namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageReferenceAssembly

	/// <exclude/>
	public class SysPackageReferenceAssembly : Terrasoft.Configuration.SysPackageReferenceAssembly
	{

		#region Constructors: Public

		public SysPackageReferenceAssembly(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageReferenceAssembly(Terrasoft.Configuration.SysPackageReferenceAssembly source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

