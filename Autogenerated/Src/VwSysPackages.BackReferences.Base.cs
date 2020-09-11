namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysPackages

	/// <exclude/>
	public class VwSysPackages : Terrasoft.Configuration.VwSysPackages
	{

		#region Constructors: Public

		public VwSysPackages(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysPackages(Terrasoft.Configuration.VwSysPackages source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

