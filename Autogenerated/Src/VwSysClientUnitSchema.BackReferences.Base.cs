namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysClientUnitSchema

	/// <exclude/>
	public class VwSysClientUnitSchema : Terrasoft.Configuration.VwSysClientUnitSchema
	{

		#region Constructors: Public

		public VwSysClientUnitSchema(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysClientUnitSchema(Terrasoft.Configuration.VwSysClientUnitSchema source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

