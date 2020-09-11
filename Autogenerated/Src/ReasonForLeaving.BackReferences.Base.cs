namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ReasonForLeaving

	/// <exclude/>
	public class ReasonForLeaving : Terrasoft.Configuration.ReasonForLeaving
	{

		#region Constructors: Public

		public ReasonForLeaving(UserConnection userConnection)
			: base(userConnection) {
		}

		public ReasonForLeaving(Terrasoft.Configuration.ReasonForLeaving source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Employee> EmployeeCollectionByReasonForDismissal {
			get;
			set;
		}

		public IEnumerable<EmployeeCareer> EmployeeCareerCollectionByReasonForDismissal {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

