namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PushNotificationService

	/// <exclude/>
	public class PushNotificationService : Terrasoft.Configuration.PushNotificationService
	{

		#region Constructors: Public

		public PushNotificationService(UserConnection userConnection)
			: base(userConnection) {
		}

		public PushNotificationService(Terrasoft.Configuration.PushNotificationService source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PushNotificationToken> PushNotificationTokenCollectionByService {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

