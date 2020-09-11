namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Department

	/// <exclude/>
	public class Department : Terrasoft.Configuration.Department
	{

		#region Constructors: Public

		public Department(UserConnection userConnection)
			: base(userConnection) {
		}

		public Department(Terrasoft.Configuration.Department source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountOrganizationChart> AccountOrganizationChartCollectionByDepartment {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByDepartment {
			get;
			set;
		}

		public IEnumerable<ContactCareer> ContactCareerCollectionByDepartment {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByDepartment {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByDepartment {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

