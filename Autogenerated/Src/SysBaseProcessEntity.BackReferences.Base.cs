namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysBaseProcessEntity

	/// <exclude/>
	public class SysBaseProcessEntity : Terrasoft.Configuration.SysBaseProcessEntity
	{

		#region Constructors: Public

		public SysBaseProcessEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysBaseProcessEntity(Terrasoft.Configuration.SysBaseProcessEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

