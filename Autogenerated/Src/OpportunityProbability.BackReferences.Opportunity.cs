namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityProbability

	/// <exclude/>
	public class OpportunityProbability : Terrasoft.Configuration.OpportunityProbability
	{

		#region Constructors: Public

		public OpportunityProbability(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityProbability(Terrasoft.Configuration.OpportunityProbability source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

