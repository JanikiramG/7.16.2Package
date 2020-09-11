namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityCreateReason

	/// <exclude/>
	public class OpportunityCreateReason : Terrasoft.Configuration.OpportunityCreateReason
	{

		#region Constructors: Public

		public OpportunityCreateReason(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityCreateReason(Terrasoft.Configuration.OpportunityCreateReason source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

