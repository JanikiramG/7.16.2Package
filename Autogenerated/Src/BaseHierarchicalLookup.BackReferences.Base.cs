namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BaseHierarchicalLookup

	/// <exclude/>
	public class BaseHierarchicalLookup : Terrasoft.Configuration.BaseHierarchicalLookup
	{

		#region Constructors: Public

		public BaseHierarchicalLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public BaseHierarchicalLookup(Terrasoft.Configuration.BaseHierarchicalLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

