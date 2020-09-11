namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectInFolder

	/// <exclude/>
	public class ProjectInFolder : Terrasoft.Configuration.ProjectInFolder
	{

		#region Constructors: Public

		public ProjectInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectInFolder(Terrasoft.Configuration.ProjectInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

