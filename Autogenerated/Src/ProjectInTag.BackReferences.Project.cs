namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectInTag

	/// <exclude/>
	public class ProjectInTag : Terrasoft.Configuration.ProjectInTag
	{

		#region Constructors: Public

		public ProjectInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectInTag(Terrasoft.Configuration.ProjectInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

