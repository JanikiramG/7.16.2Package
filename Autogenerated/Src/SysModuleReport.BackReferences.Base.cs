namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleReport

	/// <exclude/>
	public class SysModuleReport : Terrasoft.Configuration.SysModuleReport
	{

		#region Constructors: Public

		public SysModuleReport(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleReport(Terrasoft.Configuration.SysModuleReport source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleReportInPackage> SysModuleReportInPackageCollectionBySysModuleReport {
			get;
			set;
		}

		public IEnumerable<SysModuleReportLczOld> SysModuleReportLczOldCollectionByRecord {
			get;
			set;
		}

		public IEnumerable<SysModuleReportTable> SysModuleReportTableCollectionBySysModuleReport {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

