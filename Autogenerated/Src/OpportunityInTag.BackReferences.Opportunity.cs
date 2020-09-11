namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityInTag

	/// <exclude/>
	public class OpportunityInTag : Terrasoft.Configuration.OpportunityInTag
	{

		#region Constructors: Public

		public OpportunityInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityInTag(Terrasoft.Configuration.OpportunityInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

