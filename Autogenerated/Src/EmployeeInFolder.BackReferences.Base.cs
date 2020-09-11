namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmployeeInFolder

	/// <exclude/>
	public class EmployeeInFolder : Terrasoft.Configuration.EmployeeInFolder
	{

		#region Constructors: Public

		public EmployeeInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmployeeInFolder(Terrasoft.Configuration.EmployeeInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

