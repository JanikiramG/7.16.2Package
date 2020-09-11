namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmployeeCareer

	/// <exclude/>
	public class EmployeeCareer : Terrasoft.Configuration.EmployeeCareer
	{

		#region Constructors: Public

		public EmployeeCareer(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmployeeCareer(Terrasoft.Configuration.EmployeeCareer source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

