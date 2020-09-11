namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PushNotificationHistory

	/// <exclude/>
	public class PushNotificationHistory : Terrasoft.Configuration.PushNotificationHistory
	{

		#region Constructors: Public

		public PushNotificationHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public PushNotificationHistory(Terrasoft.Configuration.PushNotificationHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

