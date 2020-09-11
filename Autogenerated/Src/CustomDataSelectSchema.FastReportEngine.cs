namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CustomDataSelectSchema

	/// <exclude/>
	public class CustomDataSelectSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CustomDataSelectSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CustomDataSelectSchema(CustomDataSelectSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8e6aa3a-8514-4021-adab-1ac712c5737b");
			Name = "CustomDataSelect";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b2e55c4-93df-4e50-a678-d373851bda85");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,221,74,3,49,16,133,175,183,224,59,12,120,163,80,246,1,90,21,164,85,233,141,150,214,23,152,166,211,53,178,155,44,147,172,80,74,223,221,73,178,236,79,237,133,151,153,124,231,156,156,137,193,138,92,141,138,224,147,152,209,217,131,207,23,214,28,116,209,48,122,109,77,190,161,218,178,215,166,200,95,209,249,116,122,49,133,54,148,47,26,231,109,117,51,57,221,76,178,198,9,2,219,163,243,84,137,67,89,146,10,114,151,191,145,33,214,106,222,49,125,80,111,189,68,143,91,219,176,162,252,121,231,60,99,43,14,115,81,138,246,150,169,144,17,44,74,116,110,6,41,58,202,40,68,69,166,110,118,165,86,160,2,242,135,128,25,172,134,124,118,138,154,222,88,242,60,55,202,91,22,255,117,180,74,68,107,123,105,120,39,120,232,83,179,253,209,123,226,119,89,229,20,218,161,83,95,84,97,26,173,54,132,251,15,83,30,151,58,214,66,62,62,36,108,10,118,247,45,86,79,80,35,11,235,137,221,61,132,117,102,217,122,96,11,143,163,148,121,4,182,93,132,92,247,121,233,114,221,249,5,109,119,136,151,231,182,56,153,125,234,62,94,132,4,215,36,223,66,215,215,208,22,28,61,239,4,5,249,57,156,175,129,131,103,94,197,254,179,157,65,155,177,199,69,135,52,29,15,101,246,11,244,154,91,239,229,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8e6aa3a-8514-4021-adab-1ac712c5737b"));
		}

		#endregion

	}

	#endregion

}

