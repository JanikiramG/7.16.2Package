namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PushNotificationToken

	/// <exclude/>
	public class PushNotificationToken : Terrasoft.Configuration.PushNotificationToken
	{

		#region Constructors: Public

		public PushNotificationToken(UserConnection userConnection)
			: base(userConnection) {
		}

		public PushNotificationToken(Terrasoft.Configuration.PushNotificationToken source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

