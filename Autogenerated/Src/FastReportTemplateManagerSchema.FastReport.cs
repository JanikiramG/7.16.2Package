namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FastReportTemplateManagerSchema

	/// <exclude/>
	public class FastReportTemplateManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FastReportTemplateManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FastReportTemplateManagerSchema(FastReportTemplateManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f4089a7-7a40-49e7-97e4-e0cfff18a6ec");
			Name = "FastReportTemplateManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a4b49bea-882f-4e7d-ae8d-44e3ec2194f3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,205,110,219,48,12,62,187,64,223,65,203,46,14,80,232,1,150,173,135,166,113,145,67,179,161,201,122,45,52,153,73,4,216,146,65,81,237,140,162,239,94,58,114,92,219,77,115,36,249,233,251,33,101,85,9,190,82,26,196,6,16,149,119,91,146,115,103,183,102,23,80,145,113,86,62,64,229,144,140,221,201,76,121,138,213,229,197,235,229,69,18,60,119,197,186,246,4,229,172,171,191,224,57,13,64,224,62,79,190,35,236,24,36,230,133,242,254,135,248,80,218,64,89,21,138,224,94,89,181,3,60,128,171,240,175,48,90,232,6,123,14,154,188,30,224,29,121,102,160,200,153,253,15,154,103,198,197,97,21,11,129,160,114,103,139,90,252,245,128,236,220,130,110,108,139,167,48,168,103,45,37,216,60,178,14,37,24,232,9,131,38,135,141,208,193,104,171,19,77,127,105,55,29,233,14,101,167,162,89,120,146,140,220,136,95,226,147,189,36,121,59,239,241,30,104,239,242,211,246,216,124,115,162,59,232,236,165,119,193,228,130,218,106,153,31,157,60,43,20,96,201,80,189,214,123,40,21,91,25,153,147,139,222,184,77,41,153,121,201,43,82,86,195,77,189,226,207,151,78,62,175,100,50,157,141,52,152,189,47,38,231,124,46,130,40,144,142,116,219,199,102,43,210,111,241,145,204,128,244,62,67,87,222,222,164,189,40,199,44,9,237,209,189,8,11,47,98,201,227,149,163,204,5,155,47,254,107,168,26,198,177,194,85,111,31,114,227,214,135,165,165,211,43,113,38,203,91,151,232,248,182,203,212,44,101,83,87,144,207,93,17,74,251,168,138,0,63,227,37,174,211,201,173,34,53,233,101,138,3,185,244,171,80,20,191,113,81,86,188,130,35,231,169,72,31,49,6,86,16,40,160,237,220,156,249,57,177,59,108,114,239,29,143,199,192,197,59,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f4089a7-7a40-49e7-97e4-e0cfff18a6ec"));
		}

		#endregion

	}

	#endregion

}

