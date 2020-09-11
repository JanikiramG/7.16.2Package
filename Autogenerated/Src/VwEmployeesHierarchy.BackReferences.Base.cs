namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwEmployeesHierarchy

	/// <exclude/>
	public class VwEmployeesHierarchy : Terrasoft.Configuration.VwEmployeesHierarchy
	{

		#region Constructors: Public

		public VwEmployeesHierarchy(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwEmployeesHierarchy(Terrasoft.Configuration.VwEmployeesHierarchy source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

