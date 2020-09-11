namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysOperationAuditArch

	/// <exclude/>
	public class SysOperationAuditArch : Terrasoft.Configuration.SysOperationAuditArch
	{

		#region Constructors: Public

		public SysOperationAuditArch(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysOperationAuditArch(Terrasoft.Configuration.SysOperationAuditArch source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

