namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiDeleteWorkerSchema

	/// <exclude/>
	public class MultiDeleteWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiDeleteWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiDeleteWorkerSchema(MultiDeleteWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fec963bc-4f40-4b98-bb72-921691cdead0");
			Name = "MultiDeleteWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,193,78,220,48,16,61,7,137,127,24,129,132,178,18,218,15,216,237,246,208,5,33,132,16,43,104,197,1,245,224,117,222,46,110,131,29,141,157,150,21,226,223,59,118,18,54,33,162,106,47,78,102,230,249,189,153,55,182,234,9,190,82,26,244,21,204,202,187,77,152,46,157,221,152,109,205,42,24,103,233,229,240,32,171,189,177,91,186,219,249,128,167,249,187,88,224,101,9,29,177,126,122,1,11,54,122,143,233,179,50,62,202,79,207,109,48,193,192,11,64,32,199,140,109,148,94,150,202,251,25,93,215,101,48,103,40,17,112,239,248,39,56,129,170,122,93,26,77,58,98,198,16,154,209,23,229,113,11,237,184,240,55,21,154,105,218,98,156,41,203,226,241,38,37,221,7,174,117,112,44,138,171,196,157,100,58,157,145,66,254,205,131,229,154,109,102,167,122,16,158,210,229,153,73,127,138,119,159,132,90,134,62,37,183,254,33,229,207,84,41,22,223,3,216,79,82,39,217,140,214,210,109,254,158,163,135,107,123,54,27,202,247,217,184,170,160,140,245,87,216,229,71,151,126,169,188,86,5,142,38,116,114,66,249,218,185,114,178,7,63,244,0,223,105,177,32,153,23,29,111,246,102,209,249,51,116,45,54,208,130,44,126,83,227,96,51,56,223,155,240,120,23,92,181,98,167,225,253,223,250,157,39,218,87,66,233,241,95,26,255,64,26,207,215,102,59,199,176,69,179,194,24,245,55,122,141,240,232,138,184,76,118,65,184,80,116,136,170,75,144,251,37,207,208,20,160,244,254,118,116,129,176,98,136,32,138,38,147,183,5,164,79,103,22,35,212,108,219,228,188,237,230,99,238,103,141,42,61,17,161,239,89,208,102,243,142,117,224,2,241,32,90,80,62,40,79,70,86,206,251,157,13,46,79,199,154,195,158,71,30,54,222,14,210,135,7,146,252,3,209,204,248,244,45,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fec963bc-4f40-4b98-bb72-921691cdead0"));
		}

		#endregion

	}

	#endregion

}

