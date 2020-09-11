namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityParticipantRole

	/// <exclude/>
	public class OpportunityParticipantRole : Terrasoft.Configuration.OpportunityParticipantRole
	{

		#region Constructors: Public

		public OpportunityParticipantRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityParticipantRole(Terrasoft.Configuration.OpportunityParticipantRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<OpportunityParticipant> OpportunityParticipantCollectionByRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

