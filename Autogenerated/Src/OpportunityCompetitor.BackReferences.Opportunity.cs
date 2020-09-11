namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityCompetitor

	/// <exclude/>
	public class OpportunityCompetitor : Terrasoft.Configuration.OpportunityCompetitor
	{

		#region Constructors: Public

		public OpportunityCompetitor(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityCompetitor(Terrasoft.Configuration.OpportunityCompetitor source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

