namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFastReportDataSourceDataProviderResolverSchema

	/// <exclude/>
	public class IFastReportDataSourceDataProviderResolverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFastReportDataSourceDataProviderResolverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFastReportDataSourceDataProviderResolverSchema(IFastReportDataSourceDataProviderResolverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63e653b8-2ae5-4d31-aae6-1228169299ce");
			Name = "IFastReportDataSourceDataProviderResolver";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,177,14,130,64,12,134,103,72,120,135,38,46,186,220,3,224,168,49,97,208,16,244,5,78,40,120,9,94,47,189,194,98,124,119,79,14,53,78,198,173,253,219,126,127,91,171,175,232,157,174,17,78,200,172,61,181,162,54,100,91,211,13,172,197,144,85,21,58,98,49,182,83,59,237,37,102,89,122,203,210,44,77,22,140,93,232,129,194,10,114,27,40,57,20,159,174,173,22,125,164,129,107,124,70,37,211,104,26,228,10,61,245,35,242,4,112,195,185,55,53,152,215,252,63,227,73,220,225,189,196,30,229,66,141,207,161,156,160,177,248,147,7,51,112,233,133,195,145,224,102,253,16,30,179,90,207,14,104,155,104,50,229,247,120,251,151,24,180,7,237,191,152,107,75,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63e653b8-2ae5-4d31-aae6-1228169299ce"));
		}

		#endregion

	}

	#endregion

}

