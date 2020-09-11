namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmployeeFile

	/// <exclude/>
	public class EmployeeFile : Terrasoft.Configuration.EmployeeFile
	{

		#region Constructors: Public

		public EmployeeFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmployeeFile(Terrasoft.Configuration.EmployeeFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

