namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AddressType

	/// <exclude/>
	public class AddressType : Terrasoft.Configuration.AddressType
	{

		#region Constructors: Public

		public AddressType(UserConnection userConnection)
			: base(userConnection) {
		}

		public AddressType(Terrasoft.Configuration.AddressType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByAddressType {
			get;
			set;
		}

		public IEnumerable<AccountAddress> AccountAddressCollectionByAddressType {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByAddressType {
			get;
			set;
		}

		public IEnumerable<ContactAddress> ContactAddressCollectionByAddressType {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByAddressType {
			get;
			set;
		}

		public IEnumerable<LeadAddress> LeadAddressCollectionByAddressType {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadAccountAddressType {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadContactAddressType {
			get;
			set;
		}

		public IEnumerable<VwClientAddress> VwClientAddressCollectionByAddressType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

