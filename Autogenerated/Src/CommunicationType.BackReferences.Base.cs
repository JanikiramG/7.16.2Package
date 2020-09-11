namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CommunicationType

	/// <exclude/>
	public class CommunicationType : Terrasoft.Configuration.CommunicationType
	{

		#region Constructors: Public

		public CommunicationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public CommunicationType(Terrasoft.Configuration.CommunicationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountCommunication> AccountCommunicationCollectionByCommunicationType {
			get;
			set;
		}

		public IEnumerable<ComTypebyCommunication> ComTypebyCommunicationCollectionByCommunicationType {
			get;
			set;
		}

		public IEnumerable<ContactCommunication> ContactCommunicationCollectionByCommunicationType {
			get;
			set;
		}

		public IEnumerable<ContactCorrespondence> ContactCorrespondenceCollectionBySource {
			get;
			set;
		}

		public IEnumerable<CTISearchResult> CTISearchResultCollectionByCommunicationType {
			get;
			set;
		}

		public IEnumerable<EmailTemplateMacros> EmailTemplateMacrosCollectionByAccountCommunicationType {
			get;
			set;
		}

		public IEnumerable<EnrchTypeMapping> EnrchTypeMappingCollectionByCommunicationType {
			get;
			set;
		}

		public IEnumerable<SocialAccount> SocialAccountCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

