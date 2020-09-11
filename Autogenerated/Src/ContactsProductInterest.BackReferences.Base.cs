namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactsProductInterest

	/// <exclude/>
	public class ContactsProductInterest : Terrasoft.Configuration.ContactsProductInterest
	{

		#region Constructors: Public

		public ContactsProductInterest(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactsProductInterest(Terrasoft.Configuration.ContactsProductInterest source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

