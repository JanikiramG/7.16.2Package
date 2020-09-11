namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialMessage

	/// <exclude/>
	public class SocialMessage : Terrasoft.Configuration.SocialMessage
	{

		#region Constructors: Public

		public SocialMessage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialMessage(Terrasoft.Configuration.SocialMessage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ESNNotification> ESNNotificationCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<SocialLike> SocialLikeCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<SocialMention> SocialMentionCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<SocialMessage> SocialMessageCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SocialMessageEntity> SocialMessageEntityCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<VwSocialSubscription> VwSocialSubscriptionCollectionBySocialMessage {
			get;
			set;
		}

		public IEnumerable<VwSocialUnsubscription> VwSocialUnsubscriptionCollectionBySocialMessage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

