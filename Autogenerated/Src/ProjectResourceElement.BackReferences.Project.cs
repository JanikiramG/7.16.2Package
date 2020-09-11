namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProjectResourceElement

	/// <exclude/>
	public class ProjectResourceElement : Terrasoft.Configuration.ProjectResourceElement
	{

		#region Constructors: Public

		public ProjectResourceElement(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProjectResourceElement(Terrasoft.Configuration.ProjectResourceElement source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WorkResourceElement> WorkResourceElementCollectionByProjectResourceElement {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

