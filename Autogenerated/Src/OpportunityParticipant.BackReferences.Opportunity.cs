namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityParticipant

	/// <exclude/>
	public class OpportunityParticipant : Terrasoft.Configuration.OpportunityParticipant
	{

		#region Constructors: Public

		public OpportunityParticipant(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityParticipant(Terrasoft.Configuration.OpportunityParticipant source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

