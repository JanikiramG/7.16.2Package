namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PortalColumnAccessList

	/// <exclude/>
	public class PortalColumnAccessList : Terrasoft.Configuration.PortalColumnAccessList
	{

		#region Constructors: Public

		public PortalColumnAccessList(UserConnection userConnection)
			: base(userConnection) {
		}

		public PortalColumnAccessList(Terrasoft.Configuration.PortalColumnAccessList source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

