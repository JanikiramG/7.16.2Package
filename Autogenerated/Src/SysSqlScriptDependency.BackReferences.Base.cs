namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSqlScriptDependency

	/// <exclude/>
	public class SysSqlScriptDependency : Terrasoft.Configuration.SysSqlScriptDependency
	{

		#region Constructors: Public

		public SysSqlScriptDependency(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSqlScriptDependency(Terrasoft.Configuration.SysSqlScriptDependency source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

