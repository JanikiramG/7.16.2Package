namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ESNNotification

	/// <exclude/>
	public class ESNNotification : Terrasoft.Configuration.ESNNotification
	{

		#region Constructors: Public

		public ESNNotification(UserConnection userConnection)
			: base(userConnection) {
		}

		public ESNNotification(Terrasoft.Configuration.ESNNotification source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

