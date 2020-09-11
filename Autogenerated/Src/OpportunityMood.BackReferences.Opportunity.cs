namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityMood

	/// <exclude/>
	public class OpportunityMood : Terrasoft.Configuration.OpportunityMood
	{

		#region Constructors: Public

		public OpportunityMood(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityMood(Terrasoft.Configuration.OpportunityMood source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Opportunity> OpportunityCollectionByMood {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

