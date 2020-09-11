namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailServer

	/// <exclude/>
	public class MailServer : Terrasoft.Configuration.MailServer
	{

		#region Constructors: Public

		public MailServer(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailServer(Terrasoft.Configuration.MailServer source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MailboxSyncSettings> MailboxSyncSettingsCollectionByMailServer {
			get;
			set;
		}

		public IEnumerable<MailServerDomain> MailServerDomainCollectionByMailServer {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

