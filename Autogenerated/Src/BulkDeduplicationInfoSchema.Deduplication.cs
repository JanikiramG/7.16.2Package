namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationInfoSchema

	/// <exclude/>
	public class BulkDeduplicationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationInfoSchema(BulkDeduplicationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2");
			Name = "BulkDeduplicationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,77,111,194,48,12,134,207,171,212,255,96,193,101,187,180,247,177,237,48,208,36,14,76,8,184,77,59,164,169,91,69,180,73,101,39,210,24,226,191,47,253,128,49,232,129,106,151,72,142,95,191,126,98,183,90,148,200,149,144,8,27,36,18,108,50,27,77,141,206,84,238,72,88,101,116,52,195,212,85,133,146,77,20,6,251,48,8,131,59,199,74,231,176,222,177,197,50,90,57,109,85,137,209,26,73,137,66,125,55,202,73,163,27,19,230,62,128,105,33,152,31,225,213,21,219,63,126,115,157,153,70,24,199,49,60,177,43,75,65,187,151,46,174,213,144,158,203,65,53,250,86,29,159,201,63,102,194,10,207,109,73,72,251,233,47,42,151,248,34,144,117,223,254,182,208,190,228,170,115,115,177,33,135,160,178,139,238,218,88,96,43,200,98,10,9,102,134,48,58,57,156,211,180,56,11,44,19,164,251,119,63,97,120,134,145,226,55,69,108,253,176,70,15,53,225,17,49,49,166,128,249,41,9,123,200,209,78,128,235,227,48,24,81,49,144,211,218,111,103,16,218,170,173,233,37,235,114,55,131,45,201,72,100,246,51,170,144,36,106,11,230,146,210,10,222,14,224,171,142,142,203,214,240,47,166,242,29,150,23,138,155,97,103,29,21,50,72,227,191,99,72,118,192,198,121,19,32,148,134,210,1,152,165,248,250,181,243,32,171,198,224,26,118,209,171,251,231,226,235,145,2,59,89,143,97,208,234,215,109,77,239,234,187,92,15,90,123,142,81,167,237,31,238,131,48,56,252,0,207,101,116,155,78,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2"));
		}

		#endregion

	}

	#endregion

}

