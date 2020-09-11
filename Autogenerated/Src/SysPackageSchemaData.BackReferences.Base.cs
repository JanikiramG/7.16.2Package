namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPackageSchemaData

	/// <exclude/>
	public class SysPackageSchemaData : Terrasoft.Configuration.SysPackageSchemaData
	{

		#region Constructors: Public

		public SysPackageSchemaData(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPackageSchemaData(Terrasoft.Configuration.SysPackageSchemaData source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPackageDataLcz> SysPackageDataLczCollectionBySysPackageSchemaData {
			get;
			set;
		}

		public IEnumerable<SysPackageSchemaDataColumn> SysPackageSchemaDataColumnCollectionBySysPackageSchemaData {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

