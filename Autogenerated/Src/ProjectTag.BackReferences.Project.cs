namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectTag

	/// <exclude/>
	public class ProjectTag : Terrasoft.Configuration.ProjectTag
	{

		#region Constructors: Public

		public ProjectTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectTag(Terrasoft.Configuration.ProjectTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProjectInTag> ProjectInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

