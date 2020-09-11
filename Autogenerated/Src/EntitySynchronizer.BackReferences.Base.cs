namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EntitySynchronizer

	/// <exclude/>
	public class EntitySynchronizer : Terrasoft.Configuration.EntitySynchronizer
	{

		#region Constructors: Public

		public EntitySynchronizer(UserConnection userConnection)
			: base(userConnection) {
		}

		public EntitySynchronizer(Terrasoft.Configuration.EntitySynchronizer source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

