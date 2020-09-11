namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: NotificationType

	/// <exclude/>
	public class NotificationType : Terrasoft.Configuration.NotificationType
	{

		#region Constructors: Public

		public NotificationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public NotificationType(Terrasoft.Configuration.NotificationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<NotificationsSettings> NotificationsSettingsCollectionByNotificationType {
			get;
			set;
		}

		public IEnumerable<Reminding> RemindingCollectionByNotificationType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

