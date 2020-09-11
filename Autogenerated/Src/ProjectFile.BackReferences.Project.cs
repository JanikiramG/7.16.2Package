namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectFile

	/// <exclude/>
	public class ProjectFile : Terrasoft.Configuration.ProjectFile
	{

		#region Constructors: Public

		public ProjectFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectFile(Terrasoft.Configuration.ProjectFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

