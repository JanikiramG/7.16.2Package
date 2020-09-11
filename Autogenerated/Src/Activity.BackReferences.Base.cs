namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Activity

	/// <exclude/>
	public class Activity : Terrasoft.Configuration.Activity
	{

		#region Constructors: Public

		public Activity(UserConnection userConnection)
			: base(userConnection) {
		}

		public Activity(Terrasoft.Configuration.Activity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByActivityConnection {
			get;
			set;
		}

		public IEnumerable<ActivityCorrespondence> ActivityCorrespondenceCollectionByActivity {
			get;
			set;
		}

		public IEnumerable<ActivityFile> ActivityFileCollectionByActivity {
			get;
			set;
		}

		public IEnumerable<ActivityInFolder> ActivityInFolderCollectionByActivity {
			get;
			set;
		}

		public IEnumerable<ActivityInTag> ActivityInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ActivityParticipant> ActivityParticipantCollectionByActivity {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByActivity {
			get;
			set;
		}

		public IEnumerable<EmailMessageData> EmailMessageDataCollectionByActivity {
			get;
			set;
		}

		public IEnumerable<EmailRelation> EmailRelationCollectionByEmail {
			get;
			set;
		}

		public IEnumerable<EmailTemplateActivity> EmailTemplateActivityCollectionByActivity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

