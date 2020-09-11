namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysClientUnitSchemaDependency

	/// <exclude/>
	public class SysClientUnitSchemaDependency : Terrasoft.Configuration.SysClientUnitSchemaDependency
	{

		#region Constructors: Public

		public SysClientUnitSchemaDependency(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysClientUnitSchemaDependency(Terrasoft.Configuration.SysClientUnitSchemaDependency source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

