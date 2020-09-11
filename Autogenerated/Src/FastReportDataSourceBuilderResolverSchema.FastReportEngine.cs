namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FastReportDataSourceBuilderResolverSchema

	/// <exclude/>
	public class FastReportDataSourceBuilderResolverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FastReportDataSourceBuilderResolverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FastReportDataSourceBuilderResolverSchema(FastReportDataSourceBuilderResolverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e92979a3-208b-459e-b5ac-12cfe09c40e1");
			Name = "FastReportDataSourceBuilderResolver";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("907f2de3-5104-49b3-a54a-bb8730240b72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,219,78,227,48,16,125,14,18,255,48,98,95,130,84,229,3,40,84,42,229,162,74,160,93,149,238,51,50,201,16,44,57,118,118,236,116,27,161,253,247,157,92,74,72,156,70,240,150,25,207,229,92,38,90,100,104,115,17,35,108,145,72,88,243,234,162,149,209,175,50,45,72,56,105,116,180,193,220,144,147,58,141,238,132,117,77,116,171,83,169,241,244,228,253,244,36,40,44,191,193,83,105,29,102,243,65,204,163,148,194,184,154,99,163,123,212,72,50,246,106,30,164,254,211,37,191,3,99,188,139,240,88,158,91,99,103,72,162,29,171,232,54,220,8,39,158,76,65,49,70,203,23,235,72,52,12,166,155,58,88,195,38,110,251,65,152,114,4,43,37,172,189,128,174,182,91,117,93,72,149,32,109,208,26,181,67,170,219,242,226,69,201,24,226,170,235,43,77,112,1,235,137,137,193,123,61,245,3,205,157,68,149,48,156,95,36,119,194,97,243,152,55,1,16,138,196,104,85,194,111,139,196,94,232,198,71,120,46,122,241,124,180,103,12,235,163,208,34,101,140,207,201,48,53,111,97,161,78,26,100,125,152,188,140,245,44,42,235,42,176,181,38,45,214,70,159,47,40,19,14,88,244,73,156,67,117,201,65,48,224,6,87,48,66,54,240,9,112,161,198,191,83,172,195,193,194,122,210,191,105,222,143,232,222,204,81,127,124,163,97,197,250,59,244,242,161,135,9,157,168,56,64,214,126,28,248,19,186,130,218,43,109,254,149,146,127,91,119,233,239,90,132,135,222,104,91,230,56,171,249,127,50,106,73,105,145,161,118,225,89,159,248,217,108,120,64,231,223,212,194,183,127,189,225,179,251,201,103,119,35,235,137,130,202,203,251,66,38,179,17,141,22,208,94,196,82,169,176,42,2,153,28,216,239,4,65,226,137,244,32,173,99,127,125,211,43,101,124,77,171,242,235,114,139,89,174,216,139,117,18,242,252,249,103,113,199,55,68,91,211,161,15,247,112,181,128,125,180,102,10,245,231,49,99,247,147,226,53,217,126,146,115,255,1,40,166,234,98,243,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e92979a3-208b-459e-b5ac-12cfe09c40e1"));
		}

		#endregion

	}

	#endregion

}

