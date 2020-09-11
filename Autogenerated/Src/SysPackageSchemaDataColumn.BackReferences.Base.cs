namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageSchemaDataColumn

	/// <exclude/>
	public class SysPackageSchemaDataColumn : Terrasoft.Configuration.SysPackageSchemaDataColumn
	{

		#region Constructors: Public

		public SysPackageSchemaDataColumn(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageSchemaDataColumn(Terrasoft.Configuration.SysPackageSchemaDataColumn source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

