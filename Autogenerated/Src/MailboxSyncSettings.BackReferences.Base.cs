namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailboxSyncSettings

	/// <exclude/>
	public class MailboxSyncSettings : Terrasoft.Configuration.MailboxSyncSettings
	{

		#region Constructors: Public

		public MailboxSyncSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailboxSyncSettings(Terrasoft.Configuration.MailboxSyncSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivitySyncSettings> ActivitySyncSettingsCollectionByMailboxSyncSettings {
			get;
			set;
		}

		public IEnumerable<ContactSyncSettings> ContactSyncSettingsCollectionByMailboxSyncSettings {
			get;
			set;
		}

		public IEnumerable<EmailDefRights> EmailDefRightsCollectionByRecord {
			get;
			set;
		}

		public IEnumerable<MailboxContactFolder> MailboxContactFolderCollectionByMailboxSyncSettings {
			get;
			set;
		}

		public IEnumerable<MailboxFoldersCorrespondence> MailboxFoldersCorrespondenceCollectionByMailbox {
			get;
			set;
		}

		public IEnumerable<MailboxSettingsFile> MailboxSettingsFileCollectionByMailboxSyncSettings {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

