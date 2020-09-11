namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DeduplicateExecLog

	/// <exclude/>
	public class DeduplicateExecLog : Terrasoft.Configuration.DeduplicateExecLog
	{

		#region Constructors: Public

		public DeduplicateExecLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public DeduplicateExecLog(Terrasoft.Configuration.DeduplicateExecLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DeduplicateExecLocker> DeduplicateExecLockerCollectionByConversation {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

