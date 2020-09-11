namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityParticipantRole

	/// <exclude/>
	public class ActivityParticipantRole : Terrasoft.Configuration.ActivityParticipantRole
	{

		#region Constructors: Public

		public ActivityParticipantRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityParticipantRole(Terrasoft.Configuration.ActivityParticipantRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivityParticipant> ActivityParticipantCollectionByRole {
			get;
			set;
		}

		public IEnumerable<EmailMessageData> EmailMessageDataCollectionByRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

