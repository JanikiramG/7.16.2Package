namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysEntitySchemaInPackage

	/// <exclude/>
	public class VwSysEntitySchemaInPackage : Terrasoft.Configuration.VwSysEntitySchemaInPackage
	{

		#region Constructors: Public

		public VwSysEntitySchemaInPackage(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysEntitySchemaInPackage(Terrasoft.Configuration.VwSysEntitySchemaInPackage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

