namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CustomReportDataSourceConfigurationDataSchema

	/// <exclude/>
	public class CustomReportDataSourceConfigurationDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CustomReportDataSourceConfigurationDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CustomReportDataSourceConfigurationDataSchema(CustomReportDataSourceConfigurationDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ad081cc-e1d0-4024-aa7a-4cc3d8fe2ee0");
			Name = "CustomReportDataSourceConfigurationData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,77,111,218,64,16,61,59,82,254,195,40,189,24,9,249,7,132,132,67,113,27,181,82,105,20,162,94,162,30,150,245,24,182,178,119,173,253,128,82,196,127,239,172,119,9,193,5,197,141,122,232,197,98,102,223,204,123,243,102,23,201,106,52,13,227,8,143,168,53,51,170,180,217,68,201,82,44,156,102,86,40,153,61,96,163,180,21,114,145,125,100,198,134,232,242,98,123,121,145,56,67,89,152,109,140,197,122,212,137,169,73,85,33,247,29,76,118,135,18,181,224,7,204,20,215,150,14,60,217,103,163,228,225,224,165,8,141,196,200,173,210,2,205,41,196,212,137,108,134,122,37,56,126,81,5,86,89,206,44,35,237,86,83,21,21,80,201,59,141,11,82,0,147,138,25,115,13,19,103,172,170,195,8,30,60,83,78,115,60,26,215,167,219,210,167,28,75,230,42,251,94,200,130,120,83,187,105,80,149,233,167,87,171,7,67,152,146,169,112,11,87,129,239,106,240,157,250,53,110,94,9,14,220,43,233,43,4,174,161,135,216,100,219,10,62,12,75,206,90,237,188,115,52,243,125,203,27,16,81,67,79,246,244,206,137,2,68,49,4,106,231,173,151,52,214,115,96,104,163,172,18,191,176,104,135,38,169,115,102,48,245,112,143,27,128,191,33,73,98,245,38,254,74,86,76,67,225,167,186,5,191,116,226,91,161,182,89,142,207,173,190,206,127,208,149,185,233,169,47,183,106,156,118,100,140,2,213,189,86,43,81,160,142,139,240,172,217,203,92,132,205,248,18,107,102,246,136,24,134,195,29,112,102,249,114,47,222,46,181,90,131,196,53,124,248,201,177,241,26,210,200,182,243,223,93,220,1,202,34,172,225,120,39,68,222,208,176,116,147,79,110,36,122,122,36,123,11,11,180,35,242,153,62,187,35,116,46,218,119,197,244,230,38,20,14,79,165,130,139,173,127,237,92,244,32,93,45,199,99,216,79,29,9,78,43,15,217,78,242,109,207,137,246,212,86,191,229,5,180,181,221,11,254,31,155,105,254,133,163,93,154,115,238,253,137,251,75,167,124,131,111,172,114,248,72,127,110,157,232,188,99,209,223,7,44,81,163,228,24,36,188,98,115,183,40,40,62,87,212,195,58,202,253,6,126,22,220,195,188,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ad081cc-e1d0-4024-aa7a-4cc3d8fe2ee0"));
		}

		#endregion

	}

	#endregion

}

