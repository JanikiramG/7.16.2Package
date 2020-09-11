namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityChannel

	/// <exclude/>
	public class OpportunityChannel : Terrasoft.Configuration.OpportunityChannel
	{

		#region Constructors: Public

		public OpportunityChannel(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityChannel(Terrasoft.Configuration.OpportunityChannel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

