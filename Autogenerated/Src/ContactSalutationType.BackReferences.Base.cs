namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactSalutationType

	/// <exclude/>
	public class ContactSalutationType : Terrasoft.Configuration.ContactSalutationType
	{

		#region Constructors: Public

		public ContactSalutationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactSalutationType(Terrasoft.Configuration.ContactSalutationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contact> ContactCollectionBySalutationType {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByTitle {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionBySalutation {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

