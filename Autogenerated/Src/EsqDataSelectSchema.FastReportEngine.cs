namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsqDataSelectSchema

	/// <exclude/>
	public class EsqDataSelectSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsqDataSelectSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsqDataSelectSchema(EsqDataSelectSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5bd55bed-b9af-4b85-843e-a772a217d3c2");
			Name = "EsqDataSelect";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("907f2de3-5104-49b3-a54a-bb8730240b72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,193,78,2,49,16,61,47,9,255,48,137,23,77,200,126,0,168,137,1,52,28,140,8,254,192,80,134,181,201,110,187,76,219,195,134,240,239,78,187,8,86,57,120,106,250,230,189,55,239,141,193,134,92,139,138,224,131,152,209,217,157,47,167,214,236,116,21,24,189,182,166,92,81,107,217,107,83,149,207,232,124,255,155,155,74,27,42,231,110,63,28,28,134,131,34,56,153,195,186,115,158,26,145,215,53,169,168,117,229,11,25,98,173,38,103,206,207,45,44,14,198,107,175,201,93,35,92,22,207,208,227,218,6,86,84,62,109,156,103,60,185,71,92,148,162,189,97,170,4,130,105,141,206,141,65,130,37,13,197,32,137,208,134,77,173,21,168,56,207,199,48,134,197,79,114,113,72,130,139,165,108,242,28,148,183,44,206,203,228,211,51,78,158,153,219,109,106,212,173,213,39,53,248,30,136,59,32,183,31,193,98,69,184,125,51,117,55,211,41,60,114,119,47,182,210,110,4,253,251,24,137,114,187,208,152,87,108,239,32,222,181,40,196,28,30,226,100,242,253,61,83,122,252,252,77,132,227,41,59,153,109,31,63,239,178,100,219,18,199,131,95,111,242,39,123,92,127,128,138,252,4,142,25,245,63,125,178,176,185,203,175,128,61,154,131,130,125,1,166,204,89,132,157,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5bd55bed-b9af-4b85-843e-a772a217d3c2"));
		}

		#endregion

	}

	#endregion

}

