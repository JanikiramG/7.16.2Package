namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Salary

	/// <exclude/>
	public class Salary : Terrasoft.Configuration.Salary
	{

		#region Constructors: Public

		public Salary(UserConnection userConnection)
			: base(userConnection) {
		}

		public Salary(Terrasoft.Configuration.Salary source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

