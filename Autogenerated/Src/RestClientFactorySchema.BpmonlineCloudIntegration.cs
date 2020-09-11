namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RestClientFactorySchema

	/// <exclude/>
	public class RestClientFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RestClientFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RestClientFactorySchema(RestClientFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d31eb8c4-6fa9-4307-aac7-0b01e4d010f5");
			Name = "RestClientFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,203,78,3,49,12,69,215,83,169,255,96,149,77,145,208,204,30,104,145,40,32,144,120,169,133,15,8,83,183,19,41,147,4,219,81,85,16,255,78,154,73,105,121,237,146,235,107,231,216,142,85,45,178,87,53,194,19,18,41,118,11,41,39,206,46,244,50,144,18,237,108,191,247,222,239,21,129,181,93,194,20,89,102,141,34,127,210,239,69,241,128,112,25,29,48,49,138,249,56,69,39,70,163,149,43,85,139,163,117,50,85,85,5,167,28,218,86,209,122,156,239,57,126,4,171,70,215,13,212,132,74,144,97,122,57,123,130,58,85,128,149,150,24,112,68,88,11,204,113,161,130,17,96,20,137,28,92,110,235,86,123,133,125,120,49,186,6,150,136,93,199,50,145,233,47,164,226,61,97,125,193,223,161,52,110,30,241,31,83,126,23,252,9,157,132,201,127,152,202,123,114,158,116,140,66,163,236,220,32,37,196,223,140,157,226,21,169,22,108,156,252,104,240,162,24,159,201,12,198,231,241,0,207,211,91,16,7,33,30,23,142,64,25,3,132,175,33,118,193,229,105,149,242,118,101,8,37,144,229,113,226,201,182,232,218,202,27,223,247,153,220,236,198,145,155,217,9,67,22,218,172,56,243,192,8,6,131,67,216,172,190,40,246,210,114,219,35,232,236,229,13,223,7,99,30,232,178,245,178,30,230,228,195,148,85,156,129,197,213,222,10,134,89,63,254,169,111,211,78,82,188,123,162,156,197,54,252,5,50,198,185,26,253,150,254,226,117,30,238,48,91,187,86,51,84,146,62,242,114,209,206,187,253,166,123,167,126,23,63,62,1,35,60,65,243,250,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d31eb8c4-6fa9-4307-aac7-0b01e4d010f5"));
		}

		#endregion

	}

	#endregion

}

