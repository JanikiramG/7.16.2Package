namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactAddress

	/// <exclude/>
	public class ContactAddress : Terrasoft.Configuration.ContactAddress
	{

		#region Constructors: Public

		public ContactAddress(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactAddress(Terrasoft.Configuration.ContactAddress source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

