namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrgStructureUnit

	/// <exclude/>
	public class OrgStructureUnit : Terrasoft.Configuration.OrgStructureUnit
	{

		#region Constructors: Public

		public OrgStructureUnit(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrgStructureUnit(Terrasoft.Configuration.OrgStructureUnit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Employee> EmployeeCollectionByOrgStructureUnit {
			get;
			set;
		}

		public IEnumerable<EmployeeCareer> EmployeeCareerCollectionByOrgStructureUnit {
			get;
			set;
		}

		public IEnumerable<OrgStructureUnit> OrgStructureUnitCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

