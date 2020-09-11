namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ESNNotificationType

	/// <exclude/>
	public class ESNNotificationType : Terrasoft.Configuration.ESNNotificationType
	{

		#region Constructors: Public

		public ESNNotificationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ESNNotificationType(Terrasoft.Configuration.ESNNotificationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ESNNotification> ESNNotificationCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

