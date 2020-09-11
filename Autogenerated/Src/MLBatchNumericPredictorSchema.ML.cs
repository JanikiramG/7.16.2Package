namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBatchNumericPredictorSchema

	/// <exclude/>
	public class MLBatchNumericPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBatchNumericPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBatchNumericPredictorSchema(MLBatchNumericPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0aff8371-c82b-4302-bc26-bde1d1357452");
			Name = "MLBatchNumericPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,203,106,235,48,16,93,187,208,127,24,124,55,41,20,123,223,166,89,52,133,82,104,75,184,109,63,64,145,198,177,192,150,140,30,41,185,161,255,126,71,242,35,181,131,33,160,205,140,116,206,153,57,51,82,172,70,219,48,142,240,137,198,48,171,11,151,173,181,42,228,206,27,230,164,86,217,219,235,245,213,241,250,42,241,86,170,29,124,28,172,195,250,126,136,215,218,32,69,20,231,121,14,75,235,235,154,153,195,170,139,215,21,179,22,10,109,96,203,28,47,161,49,40,36,119,218,88,112,37,115,80,178,61,246,73,210,2,131,214,87,14,116,65,76,136,192,13,22,15,169,208,126,91,97,154,175,192,29,26,204,122,169,124,162,21,16,172,178,186,67,205,183,67,231,49,84,179,233,139,57,182,77,101,79,81,232,39,133,60,112,54,20,72,14,60,182,208,65,222,125,141,70,242,1,9,119,48,37,91,182,229,6,134,99,244,37,249,99,112,23,154,163,58,172,51,62,182,127,7,27,163,29,114,135,162,125,52,117,47,38,94,148,116,146,85,242,31,90,96,160,240,27,36,81,48,69,211,34,139,92,137,191,109,154,41,49,248,22,123,200,6,153,124,170,179,108,152,97,53,40,218,133,135,212,91,52,84,170,194,56,146,116,245,73,50,33,7,124,72,102,203,60,34,34,65,211,55,50,103,210,226,107,196,8,99,129,27,242,112,203,44,46,166,233,176,115,201,79,103,33,42,209,186,56,182,244,13,93,169,197,133,110,126,208,178,217,232,218,217,198,93,234,77,173,5,86,47,162,53,37,6,32,5,42,39,11,137,102,228,202,12,180,27,223,215,132,163,159,234,165,100,225,149,59,244,36,109,116,49,120,207,42,143,233,106,115,246,237,226,197,204,108,245,158,254,19,41,192,94,75,17,173,60,225,255,70,248,226,217,211,77,231,208,45,252,138,78,77,119,233,190,252,219,160,145,36,237,143,105,229,187,185,39,39,246,160,101,178,177,226,98,144,57,87,24,200,59,194,251,249,61,162,44,157,255,100,250,192,147,3,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0aff8371-c82b-4302-bc26-bde1d1357452"));
		}

		#endregion

	}

	#endregion

}

