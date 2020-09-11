namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportParametersExtensionsSchema

	/// <exclude/>
	public class ReportParametersExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportParametersExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportParametersExtensionsSchema(ReportParametersExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb807f21-ad89-4edf-8b4c-a6a175aae41f");
			Name = "ReportParametersExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0005402e-c4df-422a-beab-65ef1e6175ad");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,209,110,90,49,12,125,166,82,255,193,107,165,10,36,148,15,24,107,165,173,133,10,105,237,58,104,247,30,238,53,144,41,36,204,113,170,93,161,254,251,76,114,185,64,97,107,247,2,216,177,143,143,207,49,78,47,48,44,117,129,240,136,68,58,248,41,171,107,239,166,102,22,73,179,241,78,141,112,233,137,141,155,169,129,14,156,163,211,147,213,233,73,43,6,201,194,184,10,140,11,105,178,22,139,117,71,80,183,232,144,76,209,107,106,118,177,9,255,150,87,125,199,134,13,134,99,5,247,209,168,49,210,179,41,240,206,151,104,213,141,102,45,76,153,116,193,239,106,232,255,102,116,97,77,80,202,165,225,156,112,38,17,92,127,213,33,124,132,188,217,131,38,81,132,145,194,182,60,85,47,227,196,154,2,2,139,42,5,20,86,122,254,217,210,90,165,182,102,202,29,242,220,151,50,231,33,1,229,199,125,208,97,218,191,26,23,115,92,232,239,17,169,26,24,43,184,67,209,23,4,123,189,105,63,252,202,201,1,249,197,235,249,109,158,155,0,195,17,234,242,155,179,213,141,73,126,104,170,62,5,38,81,167,11,126,242,83,76,186,130,224,35,21,216,93,115,104,181,158,2,146,40,233,178,125,16,247,194,46,228,94,192,29,114,247,50,176,3,171,212,110,166,208,206,112,234,145,170,91,228,31,218,70,108,159,53,76,195,153,204,141,12,207,154,96,185,225,218,129,139,139,109,4,111,208,174,129,174,64,91,91,255,222,140,79,243,183,233,61,14,175,41,111,121,236,190,108,0,27,196,22,33,71,114,199,138,212,151,104,108,217,172,118,100,194,190,122,157,94,134,124,73,95,249,179,70,119,209,218,244,250,114,236,22,38,222,91,144,93,62,151,229,91,126,31,92,205,127,185,251,158,107,105,124,106,84,95,107,56,77,188,224,114,231,89,189,235,74,15,14,44,95,207,200,123,206,91,168,116,95,189,230,188,234,73,31,46,147,104,141,79,117,223,198,26,145,170,174,220,168,94,43,205,20,177,119,104,192,84,219,128,187,14,156,163,43,243,191,53,197,57,187,159,148,220,31,251,107,220,219,50,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb807f21-ad89-4edf-8b4c-a6a175aae41f"));
		}

		#endregion

	}

	#endregion

}

