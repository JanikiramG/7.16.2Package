namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysOperationType

	/// <exclude/>
	public class SysOperationType : Terrasoft.Configuration.SysOperationType
	{

		#region Constructors: Public

		public SysOperationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysOperationType(Terrasoft.Configuration.SysOperationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysOperationAudit> SysOperationAuditCollectionByType {
			get;
			set;
		}

		public IEnumerable<SysOperationAuditArch> SysOperationAuditArchCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

