namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysUser

	/// <exclude/>
	public class VwSysUser : Terrasoft.Configuration.VwSysUser
	{

		#region Constructors: Public

		public VwSysUser(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysUser(Terrasoft.Configuration.VwSysUser source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

