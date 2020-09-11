namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: NotificationsSettings

	/// <exclude/>
	public class NotificationsSettings : Terrasoft.Configuration.NotificationsSettings
	{

		#region Constructors: Public

		public NotificationsSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public NotificationsSettings(Terrasoft.Configuration.NotificationsSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

