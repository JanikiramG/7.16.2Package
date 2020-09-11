namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ActivityFolder

	/// <exclude/>
	public class ActivityFolder : Terrasoft.Configuration.ActivityFolder
	{

		#region Constructors: Public

		public ActivityFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ActivityFolder(Terrasoft.Configuration.ActivityFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivityFolder> ActivityFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ActivityInFolder> ActivityInFolderCollectionByFolder {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByEmailFolder {
			get;
			set;
		}

		public IEnumerable<MailboxFoldersCorrespondence> MailboxFoldersCorrespondenceCollectionByActivityFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

