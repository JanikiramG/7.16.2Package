namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactFolder

	/// <exclude/>
	public class ContactFolder : Terrasoft.Configuration.ContactFolder
	{

		#region Constructors: Public

		public ContactFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactFolder(Terrasoft.Configuration.ContactFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContactFolder> ContactFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ContactInFolder> ContactInFolderCollectionByFolder {
			get;
			set;
		}

		public IEnumerable<MailboxContactFolder> MailboxContactFolderCollectionByContactFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

