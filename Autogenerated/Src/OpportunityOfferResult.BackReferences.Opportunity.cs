namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityOfferResult

	/// <exclude/>
	public class OpportunityOfferResult : Terrasoft.Configuration.OpportunityOfferResult
	{

		#region Constructors: Public

		public OpportunityOfferResult(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityOfferResult(Terrasoft.Configuration.OpportunityOfferResult source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

