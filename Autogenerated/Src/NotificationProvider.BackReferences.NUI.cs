namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: NotificationProvider

	/// <exclude/>
	public class NotificationProvider : Terrasoft.Configuration.NotificationProvider
	{

		#region Constructors: Public

		public NotificationProvider(UserConnection userConnection)
			: base(userConnection) {
		}

		public NotificationProvider(Terrasoft.Configuration.NotificationProvider source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

