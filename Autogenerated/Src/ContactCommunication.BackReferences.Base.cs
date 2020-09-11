namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactCommunication

	/// <exclude/>
	public class ContactCommunication : Terrasoft.Configuration.ContactCommunication
	{

		#region Constructors: Public

		public ContactCommunication(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactCommunication(Terrasoft.Configuration.ContactCommunication source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

