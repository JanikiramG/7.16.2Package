namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactFile

	/// <exclude/>
	public class ContactFile : Terrasoft.Configuration.ContactFile
	{

		#region Constructors: Public

		public ContactFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactFile(Terrasoft.Configuration.ContactFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

