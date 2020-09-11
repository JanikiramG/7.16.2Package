namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactAnniversary

	/// <exclude/>
	public class ContactAnniversary : Terrasoft.Configuration.ContactAnniversary
	{

		#region Constructors: Public

		public ContactAnniversary(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactAnniversary(Terrasoft.Configuration.ContactAnniversary source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

