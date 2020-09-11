namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: StoredReport

	/// <exclude/>
	public class StoredReport : Terrasoft.Configuration.StoredReport
	{

		#region Constructors: Public

		public StoredReport(UserConnection userConnection)
			: base(userConnection) {
		}

		public StoredReport(Terrasoft.Configuration.StoredReport source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<StoredReportResources> StoredReportResourcesCollectionByDevExpressReport {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

