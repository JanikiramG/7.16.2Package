namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CertificatesActualizationJobSchema

	/// <exclude/>
	public class CertificatesActualizationJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CertificatesActualizationJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CertificatesActualizationJobSchema(CertificatesActualizationJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb1f524d-141f-4a2f-b908-d3aa1a3dcdde");
			Name = "CertificatesActualizationJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,219,110,219,48,12,125,78,129,254,3,145,189,180,64,97,191,103,89,128,44,105,139,20,205,208,173,203,7,200,10,227,168,144,37,79,162,178,181,69,255,125,180,156,198,151,38,125,146,72,30,30,30,82,148,17,5,250,82,72,132,223,232,156,240,118,67,201,204,154,141,202,131,19,164,172,57,63,123,61,63,27,4,175,76,14,143,207,158,176,248,218,179,25,175,53,202,10,236,147,91,52,232,148,252,128,153,11,18,31,156,247,202,252,105,156,185,182,153,208,163,209,204,22,133,53,201,189,205,115,118,55,241,31,248,151,184,68,165,240,206,91,211,4,126,6,225,232,165,111,39,139,162,212,201,82,144,220,162,243,77,180,221,103,85,232,120,196,225,41,127,119,60,39,81,243,239,39,67,215,134,20,41,60,161,137,1,55,66,146,117,159,33,30,185,169,117,208,232,142,33,150,232,189,168,102,215,116,200,168,47,14,115,22,12,51,45,188,135,17,204,208,145,218,40,41,8,253,84,82,16,90,189,196,150,238,108,22,19,210,52,133,177,15,69,33,220,243,100,111,79,65,198,116,218,10,2,135,165,67,143,134,60,200,22,25,136,54,27,60,217,44,121,103,75,91,116,101,200,180,146,123,190,207,196,176,214,5,31,215,255,80,6,30,11,167,190,70,125,135,142,150,72,91,187,174,122,122,136,156,117,180,47,63,58,126,5,211,215,183,177,14,132,214,221,22,148,169,80,106,135,80,242,46,241,74,251,173,42,125,114,224,77,251,196,99,198,137,2,12,127,167,111,195,224,209,241,150,152,250,83,12,39,43,182,65,30,28,201,56,141,232,227,201,241,142,196,37,135,147,135,195,189,147,179,31,221,78,185,170,17,216,89,181,134,122,60,120,177,234,212,134,174,148,43,88,204,85,188,177,246,177,39,199,75,114,5,54,123,226,240,4,154,202,151,80,125,250,193,160,245,44,43,82,218,39,239,111,131,83,173,47,186,220,151,213,42,14,222,246,79,131,102,93,191,78,180,107,111,215,249,246,31,9,115,115,158,123,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb1f524d-141f-4a2f-b908-d3aa1a3dcdde"));
		}

		#endregion

	}

	#endregion

}

