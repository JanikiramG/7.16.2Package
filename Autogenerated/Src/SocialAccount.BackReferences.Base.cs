namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SocialAccount

	/// <exclude/>
	public class SocialAccount : Terrasoft.Configuration.SocialAccount
	{

		#region Constructors: Public

		public SocialAccount(UserConnection userConnection)
			: base(userConnection) {
		}

		public SocialAccount(Terrasoft.Configuration.SocialAccount source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivityCorrespondence> ActivityCorrespondenceCollectionBySourceAccount {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByFacebookAFDA {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByLinkedInAFDA {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByTwitterAFDA {
			get;
			set;
		}

		public IEnumerable<ContactCorrespondence> ContactCorrespondenceCollectionBySourceAccount {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

