namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysRole

	/// <exclude/>
	public class VwSysRole : Terrasoft.Configuration.VwSysRole
	{

		#region Constructors: Public

		public VwSysRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysRole(Terrasoft.Configuration.VwSysRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

