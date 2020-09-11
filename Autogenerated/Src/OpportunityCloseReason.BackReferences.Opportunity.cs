namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityCloseReason

	/// <exclude/>
	public class OpportunityCloseReason : Terrasoft.Configuration.OpportunityCloseReason
	{

		#region Constructors: Public

		public OpportunityCloseReason(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityCloseReason(Terrasoft.Configuration.OpportunityCloseReason source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Opportunity> OpportunityCollectionByCloseReason {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

