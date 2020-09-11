namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwWorkspaceObjects

	/// <exclude/>
	public class VwWorkspaceObjects : Terrasoft.Configuration.VwWorkspaceObjects
	{

		#region Constructors: Public

		public VwWorkspaceObjects(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwWorkspaceObjects(Terrasoft.Configuration.VwWorkspaceObjects source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

