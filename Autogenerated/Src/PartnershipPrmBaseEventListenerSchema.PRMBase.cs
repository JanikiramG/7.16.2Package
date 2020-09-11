namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PartnershipPrmBaseEventListenerSchema

	/// <exclude/>
	public class PartnershipPrmBaseEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PartnershipPrmBaseEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PartnershipPrmBaseEventListenerSchema(PartnershipPrmBaseEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ec40417-7c1e-4576-891b-39fe06427885");
			Name = "PartnershipPrmBaseEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6efc2b6b-5901-4b9d-a21e-e587e5c1977b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,142,218,48,16,61,179,210,254,195,40,189,4,9,37,119,22,144,88,186,162,43,181,93,4,180,151,170,135,33,30,18,87,201,56,178,29,42,186,234,191,215,113,8,155,32,232,30,237,121,111,222,155,231,73,24,11,50,37,38,4,91,210,26,141,218,219,104,161,120,47,211,74,163,149,138,239,239,94,239,239,6,149,145,156,194,230,104,44,21,15,231,115,151,82,20,138,175,87,52,245,59,222,68,125,124,188,89,122,98,43,173,36,243,46,32,122,58,16,219,26,231,144,31,52,165,78,16,22,57,26,51,134,21,106,203,164,77,38,203,149,46,30,209,144,7,127,150,110,42,119,239,41,113,28,195,196,84,69,129,250,56,59,157,91,0,236,149,238,54,1,170,69,143,64,94,50,106,217,241,5,125,98,136,48,55,10,18,77,251,105,240,127,227,145,183,229,251,246,204,5,16,215,253,126,92,41,133,155,36,163,2,191,186,151,132,41,4,29,131,193,240,167,227,148,213,46,151,9,36,117,8,239,101,0,99,184,97,192,53,122,245,9,157,83,253,66,54,83,162,206,213,11,52,197,203,252,252,197,39,100,145,147,105,243,122,102,67,218,146,104,130,139,206,180,248,146,55,41,81,99,1,236,38,155,6,134,88,184,28,102,222,21,52,167,104,18,123,200,117,6,5,179,109,70,62,255,54,251,241,205,244,189,181,249,222,146,246,2,115,157,154,58,115,144,108,44,178,251,62,18,197,22,37,215,187,103,51,106,5,253,8,32,208,98,207,203,41,115,117,112,114,82,16,28,148,20,240,194,237,228,161,218,253,162,164,157,98,4,215,212,129,134,80,127,122,131,193,206,189,72,212,33,183,44,26,62,248,250,1,53,56,105,231,170,89,203,41,132,77,195,97,131,124,67,105,153,102,214,172,41,173,114,180,110,153,167,192,244,27,54,166,108,240,235,126,57,236,52,141,190,57,113,247,25,179,179,237,30,127,212,21,140,222,22,240,228,232,66,39,90,106,100,251,162,83,100,249,199,255,3,214,132,162,81,235,137,172,180,172,23,96,161,242,170,224,239,152,87,52,242,253,92,160,29,212,146,236,246,88,146,232,192,38,203,74,138,89,24,204,147,68,85,108,159,69,48,108,172,252,61,237,172,11,162,89,91,127,110,110,251,151,238,238,31,125,33,82,163,13,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ec40417-7c1e-4576-891b-39fe06427885"));
		}

		#endregion

	}

	#endregion

}

