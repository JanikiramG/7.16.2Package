namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmployeeInTag

	/// <exclude/>
	public class EmployeeInTag : Terrasoft.Configuration.EmployeeInTag
	{

		#region Constructors: Public

		public EmployeeInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmployeeInTag(Terrasoft.Configuration.EmployeeInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

