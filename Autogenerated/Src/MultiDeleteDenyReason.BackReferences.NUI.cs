namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MultiDeleteDenyReason

	/// <exclude/>
	public class MultiDeleteDenyReason : Terrasoft.Configuration.MultiDeleteDenyReason
	{

		#region Constructors: Public

		public MultiDeleteDenyReason(UserConnection userConnection)
			: base(userConnection) {
		}

		public MultiDeleteDenyReason(Terrasoft.Configuration.MultiDeleteDenyReason source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MultiDeleteQueue> MultiDeleteQueueCollectionByDenyReason {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

