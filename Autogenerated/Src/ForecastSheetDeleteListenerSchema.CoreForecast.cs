namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastSheetDeleteListenerSchema

	/// <exclude/>
	public class ForecastSheetDeleteListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastSheetDeleteListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastSheetDeleteListenerSchema(ForecastSheetDeleteListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bf4ad992-435a-4079-bea5-e2728964b9c8");
			Name = "ForecastSheetDeleteListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,111,219,48,12,61,187,64,255,3,225,93,108,160,80,238,109,83,32,73,147,194,192,186,21,75,179,29,134,29,20,139,118,52,56,114,38,201,233,130,34,255,189,180,232,124,117,237,122,137,35,242,241,241,241,137,50,114,137,110,37,115,132,71,180,86,186,186,240,98,84,155,66,151,141,149,94,215,230,252,236,249,252,44,106,156,54,37,76,55,206,227,242,106,127,62,46,177,40,110,135,239,166,198,198,107,175,209,125,8,16,227,53,26,223,226,8,249,201,98,73,18,96,84,73,231,46,97,66,192,92,58,63,93,32,250,91,172,208,227,103,77,138,12,218,0,255,25,72,54,129,97,151,72,166,249,2,151,242,11,141,9,125,136,79,40,226,244,23,85,173,154,121,165,115,200,219,30,255,107,1,151,48,148,14,223,232,65,36,207,65,192,94,240,61,250,69,173,72,242,67,32,231,100,175,215,187,214,102,129,86,123,85,231,189,155,54,214,53,175,215,228,134,86,8,235,90,43,248,106,66,103,114,41,169,231,191,49,247,224,208,40,180,23,192,205,135,88,144,204,32,97,96,75,7,152,66,123,71,81,52,39,125,226,168,122,87,134,233,85,200,115,57,32,127,250,144,112,32,101,28,99,214,210,66,113,236,66,166,8,201,37,226,14,253,227,102,133,106,84,87,205,210,124,151,85,131,215,119,141,86,55,73,156,169,56,61,48,88,44,208,162,201,145,237,63,48,204,28,90,218,47,67,83,145,81,124,237,27,6,221,75,35,75,180,98,162,141,202,140,243,146,202,135,155,89,166,146,64,27,125,172,97,119,123,204,154,153,17,86,213,172,21,214,41,211,5,36,255,40,235,131,105,170,106,103,97,100,209,55,214,48,126,27,126,121,13,64,241,135,224,248,4,28,75,222,28,42,21,19,91,47,15,106,190,213,79,113,202,228,226,7,93,63,38,187,211,248,47,109,144,235,198,139,90,222,41,241,230,254,29,222,14,23,9,30,157,61,23,3,199,127,246,217,208,253,213,152,162,125,0,7,8,203,136,73,89,160,200,220,248,79,35,171,83,201,23,112,74,59,48,42,137,187,141,56,170,97,45,226,65,90,234,224,233,193,189,90,158,52,77,65,186,206,48,182,149,157,164,233,49,111,200,68,190,156,109,247,130,104,21,249,17,133,51,71,79,131,219,23,28,14,33,152,180,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf4ad992-435a-4079-bea5-e2728964b9c8"));
		}

		#endregion

	}

	#endregion

}

