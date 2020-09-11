namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysAdminOperation

	/// <exclude/>
	public class SysAdminOperation : Terrasoft.Configuration.SysAdminOperation
	{

		#region Constructors: Public

		public SysAdminOperation(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysAdminOperation(Terrasoft.Configuration.SysAdminOperation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysAdminOperationGrantee> SysAdminOperationGranteeCollectionBySysAdminOperation {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

