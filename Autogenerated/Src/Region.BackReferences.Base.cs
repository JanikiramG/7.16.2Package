namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Region

	/// <exclude/>
	public class Region : Terrasoft.Configuration.Region
	{

		#region Constructors: Public

		public Region(UserConnection userConnection)
			: base(userConnection) {
		}

		public Region(Terrasoft.Configuration.Region source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByRegion {
			get;
			set;
		}

		public IEnumerable<AccountAddress> AccountAddressCollectionByRegion {
			get;
			set;
		}

		public IEnumerable<City> CityCollectionByRegion {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByRegion {
			get;
			set;
		}

		public IEnumerable<ContactAddress> ContactAddressCollectionByRegion {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByRegion {
			get;
			set;
		}

		public IEnumerable<LeadAddress> LeadAddressCollectionByRegion {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadAccountRegion {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadContactRegion {
			get;
			set;
		}

		public IEnumerable<VwClientAddress> VwClientAddressCollectionByRegion {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

