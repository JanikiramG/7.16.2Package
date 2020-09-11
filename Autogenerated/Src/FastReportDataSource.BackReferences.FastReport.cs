namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FastReportDataSource

	/// <exclude/>
	public class FastReportDataSource : Terrasoft.Configuration.FastReportDataSource
	{

		#region Constructors: Public

		public FastReportDataSource(UserConnection userConnection)
			: base(userConnection) {
		}

		public FastReportDataSource(Terrasoft.Configuration.FastReportDataSource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

