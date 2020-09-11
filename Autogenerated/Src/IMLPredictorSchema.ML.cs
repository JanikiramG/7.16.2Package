namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLPredictorSchema

	/// <exclude/>
	public class IMLPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLPredictorSchema(IMLPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aeb1fe7c-c682-4da4-9982-b4e533fa8b82");
			Name = "IMLPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,148,219,106,220,48,16,134,175,179,176,239,48,236,77,27,88,236,7,168,235,155,6,130,193,166,129,238,11,104,229,241,86,169,37,153,145,84,48,161,239,94,201,178,220,173,115,104,146,134,192,94,120,214,255,28,254,111,100,41,38,209,12,140,35,28,144,136,25,221,217,236,139,86,157,56,57,98,86,104,149,53,245,118,115,183,221,92,56,35,212,9,190,141,198,162,252,180,138,125,74,223,35,15,122,147,93,163,66,18,220,107,188,42,207,115,40,140,147,146,209,88,206,113,165,44,82,23,122,118,154,64,200,161,71,137,202,78,237,12,232,14,6,194,86,112,171,201,76,138,166,6,203,204,15,147,165,122,249,170,96,97,199,1,7,70,76,130,242,126,62,239,14,95,157,221,149,135,239,8,225,77,40,105,253,179,118,54,43,242,69,27,178,7,119,236,5,7,177,76,84,53,245,77,234,94,132,50,65,21,236,223,115,50,253,113,32,129,6,172,78,35,103,139,50,95,75,139,243,1,165,110,177,143,156,119,165,247,55,197,192,255,2,95,228,203,152,247,11,180,204,178,232,80,168,193,89,8,241,211,25,132,198,245,51,149,248,124,134,250,193,126,132,214,145,50,101,213,1,103,234,131,77,98,152,95,64,193,203,142,245,6,139,156,151,62,61,233,67,129,163,214,189,167,51,206,48,63,54,117,243,199,50,156,217,223,195,85,236,239,89,21,198,146,63,84,123,208,199,91,127,154,202,201,213,62,236,13,194,42,230,177,47,227,201,122,120,33,115,63,147,44,30,71,56,137,159,168,206,49,253,215,142,68,235,143,170,232,4,210,91,44,40,33,187,89,214,48,15,190,194,57,217,79,44,175,157,104,227,52,85,251,79,124,47,165,21,114,160,35,45,103,110,193,173,29,223,135,89,236,85,181,145,91,140,158,76,126,3,124,83,148,26,191,4,86,188,155,194,189,18,65,245,194,76,95,20,33,215,212,154,119,189,9,106,223,123,87,214,171,9,94,141,43,20,138,151,31,60,227,251,173,38,249,227,199,48,158,195,32,10,120,47,126,109,55,254,247,27,241,149,3,150,120,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aeb1fe7c-c682-4da4-9982-b4e533fa8b82"));
		}

		#endregion

	}

	#endregion

}

