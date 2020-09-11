namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportDataSourceConfigurationSchema

	/// <exclude/>
	public class ReportDataSourceConfigurationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportDataSourceConfigurationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportDataSourceConfigurationSchema(ReportDataSourceConfigurationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46cfbe19-cf35-44dc-b6c8-28814e8be6f8");
			Name = "ReportDataSourceConfiguration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b2e55c4-93df-4e50-a678-d373851bda85");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,219,106,194,64,16,125,142,208,127,24,232,139,5,201,7,120,3,209,86,242,208,86,170,63,176,38,99,220,18,119,195,236,198,34,226,191,119,118,163,198,20,141,246,101,97,206,158,57,115,230,162,196,6,77,46,98,132,5,18,9,163,87,54,28,107,181,146,105,65,194,74,173,194,47,204,53,89,169,210,240,77,24,91,70,175,42,149,10,159,90,251,167,86,80,24,254,131,249,206,88,220,244,254,196,44,149,101,24,59,29,19,78,81,33,201,184,226,252,167,226,181,172,138,55,17,86,204,117,65,49,134,163,165,177,36,142,37,29,206,153,156,251,76,152,50,4,227,76,24,211,133,50,181,74,171,25,240,9,121,177,204,100,12,177,227,55,211,251,139,198,111,7,15,161,11,209,205,106,65,240,179,70,226,13,220,213,97,25,111,168,3,209,93,46,235,238,125,39,85,239,60,18,75,69,108,53,241,8,102,190,193,146,113,108,182,81,179,253,128,189,132,159,23,112,87,17,4,30,24,120,200,45,47,56,28,205,160,74,74,63,117,115,51,210,57,242,54,241,186,181,105,33,19,168,74,71,9,12,134,62,14,163,164,87,99,114,139,238,76,42,238,7,159,248,153,237,130,58,255,129,182,252,179,135,20,109,15,14,181,100,94,131,72,62,85,182,155,72,127,114,130,118,253,210,64,7,244,242,155,79,127,8,51,65,92,212,34,153,147,70,78,114,43,44,130,185,16,188,53,151,119,180,107,157,92,31,202,86,243,80,70,121,158,237,170,26,237,71,44,229,103,250,105,91,23,38,7,23,223,13,155,43,209,58,200,216,47,249,125,237,107,81,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46cfbe19-cf35-44dc-b6c8-28814e8be6f8"));
		}

		#endregion

	}

	#endregion

}

