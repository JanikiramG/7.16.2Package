namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportDataSourceConfigurationProviderSchema

	/// <exclude/>
	public class ReportDataSourceConfigurationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportDataSourceConfigurationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportDataSourceConfigurationProviderSchema(ReportDataSourceConfigurationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9a3794e-b34a-4c43-b274-cc907214da97");
			Name = "ReportDataSourceConfigurationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b2e55c4-93df-4e50-a678-d373851bda85");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,193,110,194,48,12,61,23,105,255,96,105,151,34,77,253,0,216,144,38,54,16,7,36,4,221,121,10,141,41,209,74,82,57,9,8,161,253,251,146,150,173,20,80,233,180,29,253,156,231,231,103,59,146,109,80,231,44,65,136,145,136,105,181,50,209,80,201,149,72,45,49,35,148,140,230,152,43,50,66,166,209,136,105,83,70,175,50,21,18,239,58,135,187,78,96,181,203,193,98,175,13,110,250,103,113,20,175,9,25,247,228,152,233,15,93,229,127,163,118,157,69,120,13,175,248,47,204,176,133,178,148,96,244,188,212,134,88,226,5,124,11,142,118,79,152,186,8,134,25,211,186,7,37,171,98,212,122,154,145,218,10,142,84,16,115,187,204,68,2,137,231,181,163,61,198,141,207,60,60,128,30,76,110,149,105,172,210,70,100,224,218,15,118,107,36,183,235,155,175,93,71,133,199,7,152,220,124,235,234,30,138,225,252,140,117,36,48,227,110,174,51,18,91,102,176,76,230,101,0,254,34,148,204,246,80,109,184,42,62,101,146,165,72,240,206,207,161,254,81,2,37,47,85,234,146,174,43,183,100,155,24,69,94,184,88,211,81,183,92,89,171,101,133,111,26,201,101,36,22,215,2,182,22,118,193,31,124,16,92,54,7,79,32,113,215,228,40,60,43,229,143,55,248,108,246,52,69,179,86,252,186,29,255,159,254,225,38,96,140,166,6,135,99,43,56,84,6,39,252,219,245,150,209,9,238,28,95,142,33,114,213,42,185,54,13,132,53,165,98,40,1,161,177,36,11,135,209,136,212,102,142,218,102,38,244,3,254,179,225,19,189,110,211,14,74,180,14,58,236,11,188,158,84,85,47,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9a3794e-b34a-4c43-b274-cc907214da97"));
		}

		#endregion

	}

	#endregion

}

