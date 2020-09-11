namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLDAPSynchUser

	/// <exclude/>
	public class SysLDAPSynchUser : Terrasoft.Configuration.SysLDAPSynchUser
	{

		#region Constructors: Public

		public SysLDAPSynchUser(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLDAPSynchUser(Terrasoft.Configuration.SysLDAPSynchUser source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

