namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectEntryType

	/// <exclude/>
	public class ProjectEntryType : Terrasoft.Configuration.ProjectEntryType
	{

		#region Constructors: Public

		public ProjectEntryType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectEntryType(Terrasoft.Configuration.ProjectEntryType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Project> ProjectCollectionByProjectEntryType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

