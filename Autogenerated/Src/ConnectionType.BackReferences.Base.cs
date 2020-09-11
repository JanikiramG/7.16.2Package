namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ConnectionType

	/// <exclude/>
	public class ConnectionType : Terrasoft.Configuration.ConnectionType
	{

		#region Constructors: Public

		public ConnectionType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ConnectionType(Terrasoft.Configuration.ConnectionType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByUserConnectionType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

