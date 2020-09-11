namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleReportType

	/// <exclude/>
	public class SysModuleReportType : Terrasoft.Configuration.SysModuleReportType
	{

		#region Constructors: Public

		public SysModuleReportType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleReportType(Terrasoft.Configuration.SysModuleReportType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysModuleAnalyticsReport> SysModuleAnalyticsReportCollectionByType {
			get;
			set;
		}

		public IEnumerable<SysModuleReport> SysModuleReportCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

