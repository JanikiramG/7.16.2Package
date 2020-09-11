namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageSqlScript

	/// <exclude/>
	public class SysPackageSqlScript : Terrasoft.Configuration.SysPackageSqlScript
	{

		#region Constructors: Public

		public SysPackageSqlScript(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageSqlScript(Terrasoft.Configuration.SysPackageSqlScript source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysSqlScriptDependency> SysSqlScriptDependencyCollectionByDependOnSqlScript {
			get;
			set;
		}

		public IEnumerable<SysSqlScriptDependency> SysSqlScriptDependencyCollectionBySysSqlScript {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

