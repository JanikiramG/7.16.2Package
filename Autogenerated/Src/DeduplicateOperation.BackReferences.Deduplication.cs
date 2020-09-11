namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DeduplicateOperation

	/// <exclude/>
	public class DeduplicateOperation : Terrasoft.Configuration.DeduplicateOperation
	{

		#region Constructors: Public

		public DeduplicateOperation(UserConnection userConnection)
			: base(userConnection) {
		}

		public DeduplicateOperation(Terrasoft.Configuration.DeduplicateOperation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DeduplicateExecLocker> DeduplicateExecLockerCollectionByOperation {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

