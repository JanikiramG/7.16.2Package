namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysOperationAudit

	/// <exclude/>
	public class SysOperationAudit : Terrasoft.Configuration.SysOperationAudit
	{

		#region Constructors: Public

		public SysOperationAudit(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysOperationAudit(Terrasoft.Configuration.SysOperationAudit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

