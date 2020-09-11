namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleReportPackage

	/// <exclude/>
	public class SysModuleReportPackage : Terrasoft.Configuration.SysModuleReportPackage
	{

		#region Constructors: Public

		public SysModuleReportPackage(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleReportPackage(Terrasoft.Configuration.SysModuleReportPackage source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleReportInPackage> SysModuleReportInPackageCollectionBySysModuleReportPackage {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

