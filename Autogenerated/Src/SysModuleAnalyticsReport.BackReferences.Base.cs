namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleAnalyticsReport

	/// <exclude/>
	public class SysModuleAnalyticsReport : Terrasoft.Configuration.SysModuleAnalyticsReport
	{

		#region Constructors: Public

		public SysModuleAnalyticsReport(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleAnalyticsReport(Terrasoft.Configuration.SysModuleAnalyticsReport source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleAnalyticsReportLczOld> SysModuleAnalyticsReportLczOldCollectionByRecord {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

