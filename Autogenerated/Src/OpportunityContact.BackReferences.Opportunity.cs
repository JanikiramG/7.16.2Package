namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityContact

	/// <exclude/>
	public class OpportunityContact : Terrasoft.Configuration.OpportunityContact
	{

		#region Constructors: Public

		public OpportunityContact(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityContact(Terrasoft.Configuration.OpportunityContact source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OppContactMotivator> OppContactMotivatorCollectionByOpportunityContact {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

