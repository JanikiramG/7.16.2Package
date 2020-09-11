namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmployeeJob

	/// <exclude/>
	public class EmployeeJob : Terrasoft.Configuration.EmployeeJob
	{

		#region Constructors: Public

		public EmployeeJob(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmployeeJob(Terrasoft.Configuration.EmployeeJob source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Employee> EmployeeCollectionByJob {
			get;
			set;
		}

		public IEnumerable<EmployeeCareer> EmployeeCareerCollectionByEmployeeJob {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

