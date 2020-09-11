namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Country

	/// <exclude/>
	public class Country : Terrasoft.Configuration.Country
	{

		#region Constructors: Public

		public Country(UserConnection userConnection)
			: base(userConnection) {
		}

		public Country(Terrasoft.Configuration.Country source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<AccountAddress> AccountAddressCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<AccountBillingInfo> AccountBillingInfoCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<AccountOwnership> AccountOwnershipCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<City> CityCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<ContactAddress> ContactAddressCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<DialingCode> DialingCodeCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<LeadAddress> LeadAddressCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadAccountCountry {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadContactCountry {
			get;
			set;
		}

		public IEnumerable<Region> RegionCollectionByCountry {
			get;
			set;
		}

		public IEnumerable<VwClientAddress> VwClientAddressCollectionByCountry {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

