namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FastReportDataSourceDataProviderResolverSchema

	/// <exclude/>
	public class FastReportDataSourceDataProviderResolverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FastReportDataSourceDataProviderResolverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FastReportDataSourceDataProviderResolverSchema(FastReportDataSourceDataProviderResolverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75f557f5-7498-4287-b71f-94807d66eb36");
			Name = "FastReportDataSourceDataProviderResolver";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,203,106,195,48,16,60,59,144,127,216,210,139,13,197,31,144,148,94,210,7,61,180,132,36,63,160,202,107,71,224,104,205,106,229,212,132,252,123,101,217,117,211,83,114,17,187,179,59,51,203,200,170,3,186,70,105,132,29,50,43,71,165,228,43,178,165,169,60,43,49,100,243,13,54,196,98,108,149,191,42,39,67,55,159,157,230,179,196,187,128,194,182,115,130,135,229,212,95,234,48,6,146,22,98,131,46,108,132,157,123,198,42,168,194,170,86,206,45,224,79,242,89,137,218,146,103,141,125,181,102,106,77,129,188,65,71,117,139,28,185,141,255,170,141,6,221,83,111,102,194,2,222,111,119,73,78,209,105,58,243,3,101,79,69,56,116,29,189,135,225,120,199,85,89,24,117,83,39,220,39,211,140,248,103,200,60,131,62,193,36,49,37,164,119,49,140,33,168,46,223,113,247,134,242,120,85,253,41,189,212,123,0,242,2,173,226,201,37,251,181,72,100,207,116,4,139,71,120,249,214,216,244,191,154,102,203,56,59,199,151,81,60,219,137,25,71,231,49,8,180,197,144,69,236,7,244,63,24,176,31,77,203,19,136,70,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75f557f5-7498-4287-b71f-94807d66eb36"));
		}

		#endregion

	}

	#endregion

}

