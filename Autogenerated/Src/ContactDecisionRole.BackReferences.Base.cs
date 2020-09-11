namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContactDecisionRole

	/// <exclude/>
	public class ContactDecisionRole : Terrasoft.Configuration.ContactDecisionRole
	{

		#region Constructors: Public

		public ContactDecisionRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContactDecisionRole(Terrasoft.Configuration.ContactDecisionRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Contact> ContactCollectionByDecisionRole {
			get;
			set;
		}

		public IEnumerable<ContactCareer> ContactCareerCollectionByDecisionRole {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByDecisionRole {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByDecisionRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

