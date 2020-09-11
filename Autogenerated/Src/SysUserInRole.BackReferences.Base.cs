namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysUserInRole

	/// <exclude/>
	public class SysUserInRole : Terrasoft.Configuration.SysUserInRole
	{

		#region Constructors: Public

		public SysUserInRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysUserInRole(Terrasoft.Configuration.SysUserInRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

