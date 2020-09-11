namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportDataSourceConfigurationDataSchema

	/// <exclude/>
	public class ReportDataSourceConfigurationDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportDataSourceConfigurationDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportDataSourceConfigurationDataSchema(ReportDataSourceConfigurationDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("daa9a74a-aaec-4721-8d24-877607029c28");
			Name = "ReportDataSourceConfigurationData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,65,106,3,49,12,69,215,51,48,119,16,116,211,66,153,3,100,232,42,165,37,155,82,146,94,64,177,149,193,144,216,198,150,23,97,200,221,43,219,83,138,187,73,151,250,210,215,127,124,139,23,138,30,21,193,23,133,128,209,157,120,220,58,123,50,115,10,200,198,217,113,79,222,5,54,118,30,223,48,114,157,134,126,25,250,46,69,81,225,112,141,76,151,105,232,69,121,8,52,139,7,182,103,140,113,3,245,248,21,25,15,46,5,69,205,227,44,23,147,79,199,179,81,128,199,200,1,21,131,202,230,251,94,216,192,238,31,1,221,82,66,126,209,156,149,156,164,216,5,33,252,12,142,73,49,233,122,228,127,198,251,241,143,239,201,104,48,250,25,228,93,238,193,74,147,79,144,123,233,186,157,134,23,217,77,101,248,144,133,140,121,95,132,219,10,68,86,87,166,22,80,144,60,73,225,148,241,74,53,43,91,173,169,196,202,255,5,102,226,9,110,205,114,69,41,137,237,193,159,180,170,182,162,104,223,181,175,93,218,14,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("daa9a74a-aaec-4721-8d24-877607029c28"));
		}

		#endregion

	}

	#endregion

}

