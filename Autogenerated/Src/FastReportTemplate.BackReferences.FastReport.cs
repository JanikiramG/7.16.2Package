namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FastReportTemplate

	/// <exclude/>
	public class FastReportTemplate : Terrasoft.Configuration.FastReportTemplate
	{

		#region Constructors: Public

		public FastReportTemplate(UserConnection userConnection)
			: base(userConnection) {
		}

		public FastReportTemplate(Terrasoft.Configuration.FastReportTemplate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<FastReportDataSource> FastReportDataSourceCollectionByTemplate {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

