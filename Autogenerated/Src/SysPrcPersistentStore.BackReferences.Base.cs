namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcPersistentStore

	/// <exclude/>
	public class SysPrcPersistentStore : Terrasoft.Configuration.SysPrcPersistentStore
	{

		#region Constructors: Public

		public SysPrcPersistentStore(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcPersistentStore(Terrasoft.Configuration.SysPrcPersistentStore source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

