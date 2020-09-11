namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntitySchemaColRightLevel

	/// <exclude/>
	public class SysEntitySchemaColRightLevel : Terrasoft.Configuration.SysEntitySchemaColRightLevel
	{

		#region Constructors: Public

		public SysEntitySchemaColRightLevel(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntitySchemaColRightLevel(Terrasoft.Configuration.SysEntitySchemaColRightLevel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysEntitySchemaColumnRight> VwSysEntitySchemaColumnRightCollectionByRightLevel {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

