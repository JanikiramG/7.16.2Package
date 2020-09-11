namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PortalSchemaAccessList

	/// <exclude/>
	public class PortalSchemaAccessList : Terrasoft.Configuration.PortalSchemaAccessList
	{

		#region Constructors: Public

		public PortalSchemaAccessList(UserConnection userConnection)
			: base(userConnection) {
		}

		public PortalSchemaAccessList(Terrasoft.Configuration.PortalSchemaAccessList source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PortalColumnAccessList> PortalColumnAccessListCollectionByPortalSchemaList {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

