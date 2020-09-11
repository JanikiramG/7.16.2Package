namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactSyncSettings

	/// <exclude/>
	public class ContactSyncSettings : Terrasoft.Configuration.ContactSyncSettings
	{

		#region Constructors: Public

		public ContactSyncSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactSyncSettings(Terrasoft.Configuration.ContactSyncSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

