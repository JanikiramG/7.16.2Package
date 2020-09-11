namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CompetitorProduct

	/// <exclude/>
	public class CompetitorProduct : Terrasoft.Configuration.CompetitorProduct
	{

		#region Constructors: Public

		public CompetitorProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public CompetitorProduct(Terrasoft.Configuration.CompetitorProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OpportunityCompetitor> OpportunityCompetitorCollectionByCompetitorProduct {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

