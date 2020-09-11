namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactType

	/// <exclude/>
	public class ContactType : Terrasoft.Configuration.ContactType
	{

		#region Constructors: Public

		public ContactType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactType(Terrasoft.Configuration.ContactType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contact> ContactCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

