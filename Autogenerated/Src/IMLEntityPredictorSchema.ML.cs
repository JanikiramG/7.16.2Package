namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLEntityPredictorSchema

	/// <exclude/>
	public class IMLEntityPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLEntityPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLEntityPredictorSchema(IMLEntityPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f591c48-2aae-4f89-af89-1090bb3a3146");
			Name = "IMLEntityPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,209,106,195,48,12,69,159,27,200,63,136,62,109,48,226,15,88,23,24,99,140,64,11,133,246,7,220,88,105,61,98,57,200,246,32,140,253,251,236,36,134,178,142,49,240,203,149,174,142,175,108,146,6,221,32,91,132,35,50,75,103,59,95,189,88,234,244,57,176,244,218,82,181,219,150,197,103,89,172,130,211,116,134,195,232,60,154,199,178,136,21,33,4,108,92,48,70,242,88,47,186,33,143,220,37,94,103,25,6,70,165,219,132,1,73,10,156,252,72,12,127,193,235,14,163,11,189,7,77,128,228,181,31,171,140,22,87,236,33,156,122,221,70,83,198,55,187,237,235,100,223,207,36,203,209,149,114,222,196,154,10,139,203,229,28,232,254,19,227,54,199,92,25,36,75,3,20,223,238,105,109,172,194,190,81,235,250,24,121,147,0,173,18,162,211,200,213,70,76,222,223,71,231,139,242,236,172,254,28,102,244,129,201,213,251,159,177,163,53,247,146,217,158,222,177,245,121,233,103,82,135,184,241,221,91,208,10,150,184,15,48,169,156,224,62,254,232,234,171,44,226,249,6,242,211,88,214,18,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f591c48-2aae-4f89-af89-1090bb3a3146"));
		}

		#endregion

	}

	#endregion

}

