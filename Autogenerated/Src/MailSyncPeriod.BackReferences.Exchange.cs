namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailSyncPeriod

	/// <exclude/>
	public class MailSyncPeriod : Terrasoft.Configuration.MailSyncPeriod
	{

		#region Constructors: Public

		public MailSyncPeriod(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailSyncPeriod(Terrasoft.Configuration.MailSyncPeriod source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ActivitySyncSettings> ActivitySyncSettingsCollectionByActivitySyncPeriod {
			get;
			set;
		}

		public IEnumerable<MailboxSyncSettings> MailboxSyncSettingsCollectionByMailSyncPeriod {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

