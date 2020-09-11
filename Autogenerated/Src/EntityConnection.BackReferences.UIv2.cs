namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EntityConnection

	/// <exclude/>
	public class EntityConnection : Terrasoft.Configuration.EntityConnection
	{

		#region Constructors: Public

		public EntityConnection(UserConnection userConnection)
			: base(userConnection) {
		}

		public EntityConnection(Terrasoft.Configuration.EntityConnection source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

