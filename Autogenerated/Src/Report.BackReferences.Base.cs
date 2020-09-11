namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Report

	/// <exclude/>
	public class Report : Terrasoft.Configuration.Report
	{

		#region Constructors: Public

		public Report(UserConnection userConnection)
			: base(userConnection) {
		}

		public Report(Terrasoft.Configuration.Report source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ReportInFolder> ReportInFolderCollectionByReport {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

