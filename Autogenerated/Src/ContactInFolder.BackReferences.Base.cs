namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactInFolder

	/// <exclude/>
	public class ContactInFolder : Terrasoft.Configuration.ContactInFolder
	{

		#region Constructors: Public

		public ContactInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactInFolder(Terrasoft.Configuration.ContactInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

