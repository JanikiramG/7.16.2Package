namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LinkContactToAccount

	/// <exclude/>
	public class LinkContactToAccount : Terrasoft.Configuration.LinkContactToAccount
	{

		#region Constructors: Public

		public LinkContactToAccount(UserConnection userConnection)
			: base(userConnection) {
		}

		public LinkContactToAccount(Terrasoft.Configuration.LinkContactToAccount source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContactSyncSettings> ContactSyncSettingsCollectionByLinkContactToAccount {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

