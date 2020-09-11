namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingEntitySchema

	/// <exclude/>
	public class IndexingEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingEntitySchema(IndexingEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63239894-55a3-454b-b98c-866936068d3b");
			Name = "IndexingEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,148,203,78,194,64,20,134,215,144,240,14,39,176,129,132,148,189,168,27,188,196,24,13,1,118,198,197,116,122,10,19,102,166,117,102,154,80,141,239,238,233,180,85,16,44,169,155,54,231,242,159,255,235,92,170,153,66,155,50,142,176,66,99,152,77,98,23,204,18,29,139,117,102,152,19,137,14,238,101,18,50,185,68,102,248,166,215,253,232,117,59,153,21,122,13,203,220,58,84,193,34,211,78,40,12,150,104,4,147,226,221,139,166,189,46,245,13,12,174,41,128,153,100,214,94,192,131,142,112,71,202,91,18,184,220,119,76,38,19,184,180,153,82,204,228,215,85,188,192,212,160,69,237,44,136,74,1,232,37,65,173,152,236,73,94,110,152,99,68,236,12,227,238,149,18,105,22,74,193,129,23,166,71,158,157,130,255,27,236,78,160,140,136,108,238,37,158,232,8,201,39,74,57,108,209,51,28,67,148,20,79,168,66,52,195,103,90,82,184,130,254,35,230,253,81,65,84,35,89,103,138,143,161,252,244,188,151,229,27,84,12,52,13,107,225,89,138,139,232,164,245,79,185,137,96,206,12,45,120,181,232,255,4,41,103,156,193,249,221,212,4,181,124,147,224,112,231,90,48,144,100,69,138,147,214,85,173,201,177,62,59,224,242,20,97,232,15,227,24,184,65,230,112,12,89,106,209,184,226,29,249,56,66,137,14,71,45,240,234,249,43,26,127,200,184,95,57,8,154,112,87,116,1,182,5,174,74,34,17,11,140,128,39,50,83,186,237,206,213,115,102,94,253,231,222,29,183,53,238,30,117,74,132,88,20,15,201,214,109,150,201,150,226,67,138,48,73,36,212,165,202,121,128,58,42,111,54,69,159,229,47,104,47,229,51,95,177,134,236,188,240,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63239894-55a3-454b-b98c-866936068d3b"));
		}

		#endregion

	}

	#endregion

}

