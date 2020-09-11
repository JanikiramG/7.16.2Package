namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CustomDataSelectExtractorSchema

	/// <exclude/>
	public class CustomDataSelectExtractorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CustomDataSelectExtractorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CustomDataSelectExtractorSchema(CustomDataSelectExtractorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d22a5d4a-7982-4321-bd97-6c4681d2eb43");
			Name = "CustomDataSelectExtractor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b2e55c4-93df-4e50-a678-d373851bda85");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,237,106,194,64,16,252,29,193,119,184,210,63,17,66,30,64,69,40,214,66,41,45,82,251,2,231,185,38,7,201,93,216,221,212,138,248,238,189,15,171,166,218,66,161,127,66,118,110,102,119,230,246,140,172,129,26,169,64,188,1,162,36,187,230,124,106,205,90,23,45,74,214,214,228,175,208,88,100,109,138,252,65,18,199,106,102,10,109,32,159,182,196,182,238,247,118,253,94,210,146,163,136,197,150,24,234,209,177,254,75,211,107,170,19,239,94,178,92,216,22,21,228,119,75,98,148,202,55,34,39,114,178,91,132,194,85,98,90,73,162,161,136,190,130,2,42,80,60,251,8,124,139,129,172,13,3,26,89,9,229,217,63,147,197,80,60,94,129,199,209,211,201,79,39,217,56,182,251,149,227,225,73,118,49,120,226,188,237,130,195,99,158,103,224,210,174,92,162,121,187,172,180,138,135,77,248,191,144,139,131,195,244,127,252,9,117,14,101,194,93,185,95,13,169,18,106,249,226,94,205,64,248,181,39,137,94,139,244,166,67,14,187,202,23,129,73,126,241,44,181,161,39,216,166,103,234,47,121,194,37,218,141,48,176,113,1,20,52,190,65,58,24,133,179,125,248,34,112,139,38,48,190,103,78,175,204,157,163,125,215,43,64,63,37,59,243,155,117,19,229,115,137,14,117,79,129,226,180,253,225,234,193,172,226,237,135,58,162,93,208,97,159,87,160,22,102,55,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d22a5d4a-7982-4321-bd97-6c4681d2eb43"));
		}

		#endregion

	}

	#endregion

}

