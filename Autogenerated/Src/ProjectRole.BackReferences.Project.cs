namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectRole

	/// <exclude/>
	public class ProjectRole : Terrasoft.Configuration.ProjectRole
	{

		#region Constructors: Public

		public ProjectRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectRole(Terrasoft.Configuration.ProjectRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProjectPlanHistoryItem> ProjectPlanHistoryItemCollectionByRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

