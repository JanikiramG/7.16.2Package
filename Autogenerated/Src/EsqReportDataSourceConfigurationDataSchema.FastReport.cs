namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsqReportDataSourceConfigurationDataSchema

	/// <exclude/>
	public class EsqReportDataSourceConfigurationDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsqReportDataSourceConfigurationDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsqReportDataSourceConfigurationDataSchema(EsqReportDataSourceConfigurationDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b8fabd5-6170-498c-b58a-d959035f2847");
			Name = "EsqReportDataSourceConfigurationData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,221,110,218,48,20,190,78,165,190,195,81,119,19,36,148,7,40,29,23,43,172,218,164,49,214,84,189,153,118,97,156,19,240,20,236,204,63,101,12,245,221,119,108,135,66,51,218,68,221,77,136,237,115,190,63,159,32,217,26,77,205,56,194,29,106,205,140,42,109,118,173,100,41,150,78,51,43,148,204,110,177,86,218,10,185,204,62,50,99,227,234,252,108,119,126,150,56,67,187,144,111,141,197,245,168,181,38,144,170,66,238,17,76,118,131,18,181,224,135,154,25,110,44,29,120,178,207,70,201,195,193,177,8,141,196,200,173,210,2,205,169,138,153,19,89,142,250,65,112,252,162,10,172,178,9,179,140,180,91,77,93,212,64,45,239,52,46,73,1,92,87,204,152,75,152,154,95,81,191,175,204,149,211,28,159,121,245,219,161,239,251,4,75,230,42,251,65,200,130,72,83,187,173,81,149,233,167,206,238,193,16,102,148,40,188,135,139,105,254,237,98,240,131,192,106,183,168,4,7,238,53,244,146,0,151,208,67,102,178,11,82,15,30,41,80,171,157,15,140,172,206,3,105,172,104,4,244,161,78,111,156,40,64,20,67,32,44,31,183,36,55,79,11,67,183,200,42,241,7,139,224,149,116,46,152,193,212,151,251,186,1,248,169,72,18,171,183,205,91,146,243,21,174,153,161,60,252,61,19,221,3,106,155,77,240,9,233,235,226,39,77,201,213,68,132,81,97,122,123,21,185,134,94,110,16,26,16,198,227,180,69,62,10,4,143,192,153,229,171,61,157,93,105,181,1,137,27,152,254,230,88,123,200,116,95,233,159,143,77,100,40,139,152,218,243,8,231,90,213,164,143,230,237,100,128,157,34,97,111,119,7,75,180,35,56,77,23,119,91,155,255,78,234,1,55,20,180,167,232,248,184,61,10,29,62,154,219,12,131,218,40,53,71,114,123,186,165,15,220,173,229,24,226,175,57,133,244,191,198,35,116,135,253,125,209,219,66,152,51,187,122,45,4,162,185,103,149,195,59,250,7,104,173,94,238,106,176,111,177,68,141,146,99,20,218,145,119,187,41,250,122,169,169,71,180,180,247,23,178,113,4,240,222,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b8fabd5-6170-498c-b58a-d959035f2847"));
		}

		#endregion

	}

	#endregion

}

