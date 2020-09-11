namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPersistentStore

	/// <exclude/>
	public class SysPersistentStore : Terrasoft.Configuration.SysPersistentStore
	{

		#region Constructors: Public

		public SysPersistentStore(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPersistentStore(Terrasoft.Configuration.SysPersistentStore source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

