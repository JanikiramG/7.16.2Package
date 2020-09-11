namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityRating

	/// <exclude/>
	public class OpportunityRating : Terrasoft.Configuration.OpportunityRating
	{

		#region Constructors: Public

		public OpportunityRating(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityRating(Terrasoft.Configuration.OpportunityRating source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

