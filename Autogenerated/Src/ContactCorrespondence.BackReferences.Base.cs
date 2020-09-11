namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactCorrespondence

	/// <exclude/>
	public class ContactCorrespondence : Terrasoft.Configuration.ContactCorrespondence
	{

		#region Constructors: Public

		public ContactCorrespondence(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactCorrespondence(Terrasoft.Configuration.ContactCorrespondence source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

