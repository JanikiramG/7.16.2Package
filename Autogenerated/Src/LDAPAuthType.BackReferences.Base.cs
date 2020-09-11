namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LDAPAuthType

	/// <exclude/>
	public class LDAPAuthType : Terrasoft.Configuration.LDAPAuthType
	{

		#region Constructors: Public

		public LDAPAuthType(UserConnection userConnection)
			: base(userConnection) {
		}

		public LDAPAuthType(Terrasoft.Configuration.LDAPAuthType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

