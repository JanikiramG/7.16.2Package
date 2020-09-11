namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ParticipantResponse

	/// <exclude/>
	public class ParticipantResponse : Terrasoft.Configuration.ParticipantResponse
	{

		#region Constructors: Public

		public ParticipantResponse(UserConnection userConnection)
			: base(userConnection) {
		}

		public ParticipantResponse(Terrasoft.Configuration.ParticipantResponse source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivityParticipant> ActivityParticipantCollectionByInviteResponse {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

