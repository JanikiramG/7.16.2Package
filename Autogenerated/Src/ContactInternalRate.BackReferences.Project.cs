namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactInternalRate

	/// <exclude/>
	public class ContactInternalRate : Terrasoft.Configuration.ContactInternalRate
	{

		#region Constructors: Public

		public ContactInternalRate(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactInternalRate(Terrasoft.Configuration.ContactInternalRate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

