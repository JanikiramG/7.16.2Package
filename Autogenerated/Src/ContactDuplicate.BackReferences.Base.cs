namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactDuplicate

	/// <exclude/>
	public class ContactDuplicate : Terrasoft.Configuration.ContactDuplicate
	{

		#region Constructors: Public

		public ContactDuplicate(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactDuplicate(Terrasoft.Configuration.ContactDuplicate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

