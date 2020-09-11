namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactTag

	/// <exclude/>
	public class ContactTag : Terrasoft.Configuration.ContactTag
	{

		#region Constructors: Public

		public ContactTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactTag(Terrasoft.Configuration.ContactTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContactInTag> ContactInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

