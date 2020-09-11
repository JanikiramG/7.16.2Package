namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLDAPSynchGroup

	/// <exclude/>
	public class SysLDAPSynchGroup : Terrasoft.Configuration.SysLDAPSynchGroup
	{

		#region Constructors: Public

		public SysLDAPSynchGroup(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLDAPSynchGroup(Terrasoft.Configuration.SysLDAPSynchGroup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

