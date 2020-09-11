namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactCareer

	/// <exclude/>
	public class ContactCareer : Terrasoft.Configuration.ContactCareer
	{

		#region Constructors: Public

		public ContactCareer(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactCareer(Terrasoft.Configuration.ContactCareer source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

