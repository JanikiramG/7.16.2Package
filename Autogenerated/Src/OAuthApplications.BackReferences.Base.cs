namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuthApplications

	/// <exclude/>
	public class OAuthApplications : Terrasoft.Configuration.OAuthApplications
	{

		#region Constructors: Public

		public OAuthApplications(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuthApplications(Terrasoft.Configuration.OAuthApplications source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MailServer> MailServerCollectionByOAuthApplication {
			get;
			set;
		}

		public IEnumerable<OAuth20AppFile> OAuth20AppFileCollectionByOAuth20App {
			get;
			set;
		}

		public IEnumerable<OAuth20AppInFolder> OAuth20AppInFolderCollectionByOAuth20App {
			get;
			set;
		}

		public IEnumerable<OAuth20AppInTag> OAuth20AppInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<OAuthAppScope> OAuthAppScopeCollectionByOAuth20App {
			get;
			set;
		}

		public IEnumerable<OAuthTokenStorage> OAuthTokenStorageCollectionByOAuthApp {
			get;
			set;
		}

		public IEnumerable<VwOAuthAppUser> VwOAuthAppUserCollectionByOAuthApp {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

