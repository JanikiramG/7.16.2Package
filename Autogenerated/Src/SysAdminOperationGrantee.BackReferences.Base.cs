namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminOperationGrantee

	/// <exclude/>
	public class SysAdminOperationGrantee : Terrasoft.Configuration.SysAdminOperationGrantee
	{

		#region Constructors: Public

		public SysAdminOperationGrantee(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminOperationGrantee(Terrasoft.Configuration.SysAdminOperationGrantee source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

