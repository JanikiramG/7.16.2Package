namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Employee

	/// <exclude/>
	public class Employee : Terrasoft.Configuration.Employee
	{

		#region Constructors: Public

		public Employee(UserConnection userConnection)
			: base(userConnection) {
		}

		public Employee(Terrasoft.Configuration.Employee source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Employee> EmployeeCollectionByManager {
			get;
			set;
		}

		public IEnumerable<EmployeeCareer> EmployeeCareerCollectionByEmployee {
			get;
			set;
		}

		public IEnumerable<EmployeeFile> EmployeeFileCollectionByEmployee {
			get;
			set;
		}

		public IEnumerable<EmployeeInFolder> EmployeeInFolderCollectionByEmployee {
			get;
			set;
		}

		public IEnumerable<EmployeeInTag> EmployeeInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<OrgStructureUnit> OrgStructureUnitCollectionByHead {
			get;
			set;
		}

		public IEnumerable<Salary> SalaryCollectionByEmployee {
			get;
			set;
		}

		public IEnumerable<VwEmployeesHierarchy> VwEmployeesHierarchyCollectionByEmployee {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

