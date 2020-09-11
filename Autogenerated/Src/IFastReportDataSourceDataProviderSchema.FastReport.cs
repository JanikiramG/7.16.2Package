namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFastReportDataSourceDataProviderSchema

	/// <exclude/>
	public class IFastReportDataSourceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFastReportDataSourceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFastReportDataSourceDataProviderSchema(IFastReportDataSourceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("871baf4c-f2ae-497e-a62e-ab72c52c22b2");
			Name = "IFastReportDataSourceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,65,110,194,64,12,60,131,196,31,44,245,210,74,40,15,0,196,165,8,148,67,85,4,233,3,76,226,132,109,195,110,100,239,86,138,80,255,94,103,183,109,74,79,189,173,199,158,241,120,214,226,133,164,195,146,160,32,102,20,87,251,236,209,217,218,52,129,209,27,103,179,3,117,142,189,177,77,182,69,241,169,154,77,175,179,233,36,136,162,112,236,197,211,69,73,109,75,229,192,144,108,71,150,216,148,203,191,51,197,153,9,171,65,170,64,121,147,177,255,123,55,147,226,218,185,99,106,84,13,114,235,137,107,117,184,128,124,116,176,65,143,71,23,184,164,225,181,103,247,110,42,226,72,236,194,169,53,37,152,111,222,127,104,147,107,164,254,44,125,34,127,118,149,44,96,31,197,82,115,48,189,26,117,54,38,158,139,220,175,97,71,17,186,127,17,98,141,207,166,36,32,220,148,115,200,15,122,255,179,109,251,145,187,18,207,26,193,28,220,233,85,199,214,208,33,235,159,168,119,121,88,126,153,34,91,37,95,177,254,72,241,220,128,138,125,2,209,189,168,43,202,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("871baf4c-f2ae-497e-a62e-ab72c52c22b2"));
		}

		#endregion

	}

	#endregion

}

