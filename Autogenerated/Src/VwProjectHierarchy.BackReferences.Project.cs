namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProjectHierarchy

	/// <exclude/>
	public class VwProjectHierarchy : Terrasoft.Configuration.VwProjectHierarchy
	{

		#region Constructors: Public

		public VwProjectHierarchy(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProjectHierarchy(Terrasoft.Configuration.VwProjectHierarchy source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

