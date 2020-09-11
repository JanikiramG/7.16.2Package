namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSyncMetaData

	/// <exclude/>
	public class SysSyncMetaData : Terrasoft.Configuration.SysSyncMetaData
	{

		#region Constructors: Public

		public SysSyncMetaData(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSyncMetaData(Terrasoft.Configuration.SysSyncMetaData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

