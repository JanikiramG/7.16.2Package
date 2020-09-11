namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityProductInterest

	/// <exclude/>
	public class OpportunityProductInterest : Terrasoft.Configuration.OpportunityProductInterest
	{

		#region Constructors: Public

		public OpportunityProductInterest(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityProductInterest(Terrasoft.Configuration.OpportunityProductInterest source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

