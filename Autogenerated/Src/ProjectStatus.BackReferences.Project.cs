namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectStatus

	/// <exclude/>
	public class ProjectStatus : Terrasoft.Configuration.ProjectStatus
	{

		#region Constructors: Public

		public ProjectStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectStatus(Terrasoft.Configuration.ProjectStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Project> ProjectCollectionByStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

