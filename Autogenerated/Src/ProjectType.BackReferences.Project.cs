namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectType

	/// <exclude/>
	public class ProjectType : Terrasoft.Configuration.ProjectType
	{

		#region Constructors: Public

		public ProjectType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectType(Terrasoft.Configuration.ProjectType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Project> ProjectCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

