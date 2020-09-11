namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysSchemaDataInPackage

	/// <exclude/>
	public class VwSysSchemaDataInPackage : Terrasoft.Configuration.VwSysSchemaDataInPackage
	{

		#region Constructors: Public

		public VwSysSchemaDataInPackage(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysSchemaDataInPackage(Terrasoft.Configuration.VwSysSchemaDataInPackage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

