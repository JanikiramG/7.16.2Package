namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysRecentEntity

	/// <exclude/>
	public class SysRecentEntity : Terrasoft.Configuration.SysRecentEntity
	{

		#region Constructors: Public

		public SysRecentEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysRecentEntity(Terrasoft.Configuration.SysRecentEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

