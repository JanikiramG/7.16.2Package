namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LDAPElement

	/// <exclude/>
	public class LDAPElement : Terrasoft.Configuration.LDAPElement
	{

		#region Constructors: Public

		public LDAPElement(UserConnection userConnection)
			: base(userConnection) {
		}

		public LDAPElement(Terrasoft.Configuration.LDAPElement source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LDAPUserInLDAPGroup> LDAPUserInLDAPGroupCollectionByLDAPGroup {
			get;
			set;
		}

		public IEnumerable<LDAPUserInLDAPGroup> LDAPUserInLDAPGroupCollectionByLDAPUser {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByLDAPElement {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByLDAPElement {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

