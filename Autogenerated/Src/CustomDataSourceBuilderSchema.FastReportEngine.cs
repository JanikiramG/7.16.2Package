namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CustomDataSourceBuilderSchema

	/// <exclude/>
	public class CustomDataSourceBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CustomDataSourceBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CustomDataSourceBuilderSchema(CustomDataSourceBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5fcfcb8d-bcb1-4131-9c48-d001a22ad833");
			Name = "CustomDataSourceBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b2e55c4-93df-4e50-a678-d373851bda85");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,79,195,48,12,61,15,137,255,96,193,165,149,166,254,128,13,38,177,13,36,14,32,196,199,9,113,200,58,111,139,212,37,147,147,12,16,226,191,227,52,131,174,93,219,1,130,99,220,247,108,191,103,187,74,44,209,172,68,138,112,143,68,194,232,153,77,70,90,205,228,220,145,176,82,171,228,22,87,154,172,84,243,228,66,24,27,94,231,106,46,21,38,35,103,172,94,30,30,188,29,30,116,156,97,200,143,146,244,107,89,132,77,113,166,166,86,147,68,83,135,40,42,140,133,21,119,218,81,138,201,217,196,88,98,22,183,224,73,76,59,38,156,243,11,70,153,48,166,7,65,65,193,24,58,153,77,145,114,232,227,24,103,194,101,118,40,213,148,243,70,246,117,133,122,22,93,238,160,227,46,92,179,141,112,10,71,33,223,81,252,196,252,149,155,100,50,133,212,87,106,42,4,61,216,137,157,4,41,69,188,100,229,73,200,212,138,241,225,65,119,187,38,102,152,218,1,55,245,150,75,43,108,96,99,44,57,239,43,187,113,147,119,28,16,155,238,27,250,142,30,12,18,147,21,230,230,130,43,61,99,159,160,211,131,137,48,24,141,8,133,45,247,119,67,122,45,125,150,10,141,91,206,193,190,220,119,48,65,214,249,75,62,99,77,81,249,99,186,192,165,40,62,86,242,196,224,183,182,243,190,241,3,213,52,88,82,246,231,10,237,66,79,189,53,36,215,156,120,227,77,120,128,177,44,39,133,203,134,49,124,74,248,163,129,14,160,205,202,246,129,4,177,29,66,235,72,129,194,103,104,173,247,213,249,119,123,171,186,219,223,242,182,206,173,74,129,173,29,173,91,129,159,106,43,146,54,108,81,55,135,21,191,162,66,218,54,233,22,141,206,214,76,142,247,234,169,108,226,255,157,112,219,246,183,25,177,3,222,171,168,124,62,127,188,195,117,7,250,251,41,239,57,245,126,243,161,135,104,57,200,177,15,140,25,154,133,22,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5fcfcb8d-bcb1-4131-9c48-d001a22ad833"));
		}

		#endregion

	}

	#endregion

}

