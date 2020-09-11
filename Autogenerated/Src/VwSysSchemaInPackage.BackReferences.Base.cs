namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysSchemaInPackage

	/// <exclude/>
	public class VwSysSchemaInPackage : Terrasoft.Configuration.VwSysSchemaInPackage
	{

		#region Constructors: Public

		public VwSysSchemaInPackage(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysSchemaInPackage(Terrasoft.Configuration.VwSysSchemaInPackage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysClientUnitSchemaInPackage> VwSysClientUnitSchemaInPackageCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysEntitySchemaInPackage> VwSysEntitySchemaInPackageCollectionByParent {
			get;
			set;
		}

		public IEnumerable<VwSysSchemaInPackage> VwSysSchemaInPackageCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

