namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PropositionResult

	/// <exclude/>
	public class PropositionResult : Terrasoft.Configuration.PropositionResult
	{

		#region Constructors: Public

		public PropositionResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public PropositionResult(Terrasoft.Configuration.PropositionResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContactsProductInterest> ContactsProductInterestCollectionByResultOfProposal {
			get;
			set;
		}

		public IEnumerable<OpportunityProductInterest> OpportunityProductInterestCollectionByOfferResult {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

