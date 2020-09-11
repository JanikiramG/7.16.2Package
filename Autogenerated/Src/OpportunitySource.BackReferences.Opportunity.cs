namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunitySource

	/// <exclude/>
	public class OpportunitySource : Terrasoft.Configuration.OpportunitySource
	{

		#region Constructors: Public

		public OpportunitySource(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunitySource(Terrasoft.Configuration.OpportunitySource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Opportunity> OpportunityCollectionBySource {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

