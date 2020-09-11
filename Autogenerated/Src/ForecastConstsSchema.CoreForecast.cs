namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastConstsSchema

	/// <exclude/>
	public class ForecastConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastConstsSchema(ForecastConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ddba69f-54ab-463d-85d0-bc0e3119f357");
			Name = "ForecastConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0db428d0-fc38-40d1-af3f-5cbb75ee95a9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,77,111,156,48,20,60,47,210,254,7,196,169,61,184,194,6,47,70,85,15,224,143,106,47,109,213,77,122,247,130,147,80,25,179,194,70,213,170,202,127,175,33,161,205,102,179,9,234,1,25,222,123,51,99,207,224,193,54,230,54,220,29,173,83,237,199,117,176,14,140,108,149,61,200,74,133,87,170,239,165,237,110,220,7,218,153,155,230,118,232,165,107,58,179,14,126,175,131,213,97,216,235,166,10,173,243,181,42,172,180,180,54,20,93,175,42,105,157,31,183,206,250,161,113,240,217,100,175,100,221,25,125,12,63,15,77,253,23,193,141,107,220,113,87,221,169,86,94,111,235,240,83,104,212,175,105,228,93,84,22,73,158,199,57,1,5,70,49,72,11,88,130,188,40,17,64,156,102,188,32,44,207,104,30,189,159,246,126,81,204,186,126,60,230,44,183,187,83,202,121,145,232,164,16,45,226,248,226,253,25,161,227,186,12,241,77,245,77,87,95,29,15,19,238,223,215,182,94,134,63,53,233,233,182,31,42,255,199,179,53,84,105,253,2,219,84,191,94,74,186,83,206,141,171,231,121,124,125,3,55,229,254,117,255,83,85,238,135,212,131,162,157,30,90,243,224,199,73,238,41,98,98,147,38,28,20,52,37,32,229,155,12,16,145,17,128,17,131,164,228,156,10,24,191,149,251,36,198,235,198,201,189,190,172,68,112,17,115,198,40,136,55,137,87,162,12,131,18,178,20,100,2,9,130,4,199,48,21,139,148,188,147,237,160,229,69,33,88,166,49,132,25,2,12,82,238,133,50,12,8,78,98,64,49,202,80,153,151,9,34,236,185,80,53,94,166,217,237,23,125,155,255,200,39,205,232,21,142,115,59,102,130,185,243,26,250,236,136,51,248,177,177,36,125,209,24,105,42,245,189,211,103,73,48,198,9,142,75,144,100,57,243,153,227,24,228,57,167,160,220,80,154,194,66,8,196,146,201,160,213,202,63,247,235,224,254,15,61,150,60,182,192,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ddba69f-54ab-463d-85d0-bc0e3119f357"));
		}

		#endregion

	}

	#endregion

}

