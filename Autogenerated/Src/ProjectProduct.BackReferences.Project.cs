namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectProduct

	/// <exclude/>
	public class ProjectProduct : Terrasoft.Configuration.ProjectProduct
	{

		#region Constructors: Public

		public ProjectProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectProduct(Terrasoft.Configuration.ProjectProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

