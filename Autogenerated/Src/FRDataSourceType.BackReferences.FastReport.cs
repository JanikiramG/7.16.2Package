namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FRDataSourceType

	/// <exclude/>
	public class FRDataSourceType : Terrasoft.Configuration.FRDataSourceType
	{

		#region Constructors: Public

		public FRDataSourceType(UserConnection userConnection)
			: base(userConnection) {
		}

		public FRDataSourceType(Terrasoft.Configuration.FRDataSourceType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<FastReportDataSource> FastReportDataSourceCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

