namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SyncErrorMessage

	/// <exclude/>
	public class SyncErrorMessage : Terrasoft.Configuration.SyncErrorMessage
	{

		#region Constructors: Public

		public SyncErrorMessage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SyncErrorMessage(Terrasoft.Configuration.SyncErrorMessage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<MailboxSyncSettings> MailboxSyncSettingsCollectionByErrorCode {
			get;
			set;
		}

		public IEnumerable<SyncErrorHandler> SyncErrorHandlerCollectionByErrorCode {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

