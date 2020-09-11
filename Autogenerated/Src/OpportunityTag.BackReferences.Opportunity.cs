namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityTag

	/// <exclude/>
	public class OpportunityTag : Terrasoft.Configuration.OpportunityTag
	{

		#region Constructors: Public

		public OpportunityTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityTag(Terrasoft.Configuration.OpportunityTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OpportunityInTag> OpportunityInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

