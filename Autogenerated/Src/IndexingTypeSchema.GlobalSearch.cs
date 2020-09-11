namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingTypeSchema

	/// <exclude/>
	public class IndexingTypeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingTypeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingTypeSchema(IndexingTypeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ad4db37-38f8-4550-9801-018f4f9abf1e");
			Name = "IndexingType";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,75,106,195,64,12,134,215,49,248,14,58,128,177,47,80,186,73,161,100,221,228,0,178,71,147,12,204,139,121,208,152,144,187,87,51,73,131,161,56,164,187,25,233,211,167,95,22,13,69,143,19,193,158,66,192,232,100,234,183,206,74,117,204,1,147,114,182,255,212,110,68,253,69,24,166,83,219,92,218,102,51,12,3,188,197,108,12,134,249,253,254,223,207,158,34,56,9,202,10,58,43,123,236,127,193,97,65,250,60,106,53,1,217,108,96,119,7,203,36,183,138,248,143,185,22,42,200,114,4,225,166,108,200,166,254,193,46,229,155,10,118,109,3,255,80,117,32,81,233,8,74,46,138,48,206,144,78,152,64,9,64,29,8,197,12,156,53,38,230,44,119,232,118,229,74,140,45,15,36,234,56,197,106,142,131,23,140,188,112,210,13,124,234,218,217,72,33,45,93,229,24,235,210,35,186,15,20,75,217,113,242,240,173,34,65,174,218,213,157,69,248,116,167,32,77,47,229,255,168,32,191,174,109,115,253,1,172,224,100,210,108,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ad4db37-38f8-4550-9801-018f4f9abf1e"));
		}

		#endregion

	}

	#endregion

}

