namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysUserSession

	/// <exclude/>
	public class SysUserSession : Terrasoft.Configuration.SysUserSession
	{

		#region Constructors: Public

		public SysUserSession(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysUserSession(Terrasoft.Configuration.SysUserSession source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

