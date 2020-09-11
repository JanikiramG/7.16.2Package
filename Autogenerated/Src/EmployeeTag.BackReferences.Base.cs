namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmployeeTag

	/// <exclude/>
	public class EmployeeTag : Terrasoft.Configuration.EmployeeTag
	{

		#region Constructors: Public

		public EmployeeTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmployeeTag(Terrasoft.Configuration.EmployeeTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<EmployeeInTag> EmployeeInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

