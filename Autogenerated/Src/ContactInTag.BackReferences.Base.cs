namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactInTag

	/// <exclude/>
	public class ContactInTag : Terrasoft.Configuration.ContactInTag
	{

		#region Constructors: Public

		public ContactInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactInTag(Terrasoft.Configuration.ContactInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

