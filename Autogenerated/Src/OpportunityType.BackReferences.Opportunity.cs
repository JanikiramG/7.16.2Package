namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityType

	/// <exclude/>
	public class OpportunityType : Terrasoft.Configuration.OpportunityType
	{

		#region Constructors: Public

		public OpportunityType(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityType(Terrasoft.Configuration.OpportunityType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionBySalesChannel {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByType {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

