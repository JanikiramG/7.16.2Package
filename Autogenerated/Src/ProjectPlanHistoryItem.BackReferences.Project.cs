namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectPlanHistoryItem

	/// <exclude/>
	public class ProjectPlanHistoryItem : Terrasoft.Configuration.ProjectPlanHistoryItem
	{

		#region Constructors: Public

		public ProjectPlanHistoryItem(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectPlanHistoryItem(Terrasoft.Configuration.ProjectPlanHistoryItem source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

