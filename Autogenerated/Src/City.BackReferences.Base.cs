namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: City

	/// <exclude/>
	public class City : Terrasoft.Configuration.City
	{

		#region Constructors: Public

		public City(UserConnection userConnection)
			: base(userConnection) {
		}

		public City(Terrasoft.Configuration.City source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Account> AccountCollectionByCity {
			get;
			set;
		}

		public IEnumerable<AccountAddress> AccountAddressCollectionByCity {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByCity {
			get;
			set;
		}

		public IEnumerable<ContactAddress> ContactAddressCollectionByCity {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByCity {
			get;
			set;
		}

		public IEnumerable<LeadAddress> LeadAddressCollectionByCity {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadAccountCity {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadContactCity {
			get;
			set;
		}

		public IEnumerable<SysModuleFolder> SysModuleFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwClientAddress> VwClientAddressCollectionByCity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

