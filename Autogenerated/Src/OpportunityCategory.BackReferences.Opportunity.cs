namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityCategory

	/// <exclude/>
	public class OpportunityCategory : Terrasoft.Configuration.OpportunityCategory
	{

		#region Constructors: Public

		public OpportunityCategory(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityCategory(Terrasoft.Configuration.OpportunityCategory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Opportunity> OpportunityCollectionByCategory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

