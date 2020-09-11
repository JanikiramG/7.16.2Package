namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactExternalRate

	/// <exclude/>
	public class ContactExternalRate : Terrasoft.Configuration.ContactExternalRate
	{

		#region Constructors: Public

		public ContactExternalRate(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactExternalRate(Terrasoft.Configuration.ContactExternalRate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

