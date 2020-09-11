namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysOperationResult

	/// <exclude/>
	public class SysOperationResult : Terrasoft.Configuration.SysOperationResult
	{

		#region Constructors: Public

		public SysOperationResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysOperationResult(Terrasoft.Configuration.SysOperationResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysOperationAudit> SysOperationAuditCollectionByResult {
			get;
			set;
		}

		public IEnumerable<SysOperationAuditArch> SysOperationAuditArchCollectionByResult {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

