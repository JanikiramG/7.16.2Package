namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectFolder

	/// <exclude/>
	public class ProjectFolder : Terrasoft.Configuration.ProjectFolder
	{

		#region Constructors: Public

		public ProjectFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectFolder(Terrasoft.Configuration.ProjectFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProjectFolder> ProjectFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ProjectInFolder> ProjectInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

