namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LDAPUserInLDAPGroup

	/// <exclude/>
	public class LDAPUserInLDAPGroup : Terrasoft.Configuration.LDAPUserInLDAPGroup
	{

		#region Constructors: Public

		public LDAPUserInLDAPGroup(UserConnection userConnection)
			: base(userConnection) {
		}

		public LDAPUserInLDAPGroup(Terrasoft.Configuration.LDAPUserInLDAPGroup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

