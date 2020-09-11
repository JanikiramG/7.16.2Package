namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuthTokenStorage

	/// <exclude/>
	public class OAuthTokenStorage : Terrasoft.Configuration.OAuthTokenStorage
	{

		#region Constructors: Public

		public OAuthTokenStorage(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuthTokenStorage(Terrasoft.Configuration.OAuthTokenStorage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MailboxSyncSettings> MailboxSyncSettingsCollectionByOAuthTokenStorage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

