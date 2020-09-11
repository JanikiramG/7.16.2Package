namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysClientUnitSchemaSource

	/// <exclude/>
	public class SysClientUnitSchemaSource : Terrasoft.Configuration.SysClientUnitSchemaSource
	{

		#region Constructors: Public

		public SysClientUnitSchemaSource(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysClientUnitSchemaSource(Terrasoft.Configuration.SysClientUnitSchemaSource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

