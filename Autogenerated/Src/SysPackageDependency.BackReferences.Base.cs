namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageDependency

	/// <exclude/>
	public class SysPackageDependency : Terrasoft.Configuration.SysPackageDependency
	{

		#region Constructors: Public

		public SysPackageDependency(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageDependency(Terrasoft.Configuration.SysPackageDependency source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

