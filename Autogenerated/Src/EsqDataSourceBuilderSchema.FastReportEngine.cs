namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsqDataSourceBuilderSchema

	/// <exclude/>
	public class EsqDataSourceBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsqDataSourceBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsqDataSourceBuilderSchema(EsqDataSourceBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("788f8d96-84a9-4c96-b0f8-5fd9201be0a6");
			Name = "EsqDataSourceBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("907f2de3-5104-49b3-a54a-bb8730240b72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,77,79,2,49,16,61,99,194,127,152,224,5,18,178,63,0,144,68,17,19,14,26,21,61,25,15,101,25,176,201,218,226,180,69,13,241,191,59,221,34,176,184,187,124,68,143,157,190,153,121,239,205,140,18,175,104,102,34,70,120,64,34,97,244,196,70,61,173,38,114,234,72,88,169,85,116,143,51,77,86,170,105,116,37,140,13,175,190,154,74,133,81,223,188,85,79,22,213,147,138,51,252,127,80,133,118,110,22,97,81,156,83,99,171,73,162,201,67,172,59,92,10,43,134,218,81,140,209,249,200,88,226,44,166,224,147,56,237,148,112,202,47,232,37,194,152,22,48,253,53,252,194,201,100,140,148,226,158,46,113,34,92,98,47,164,26,115,209,186,253,156,161,158,212,7,191,208,141,38,220,176,129,112,6,181,254,240,174,214,120,230,228,153,27,37,50,134,216,247,200,109,1,45,248,21,235,4,5,235,120,198,193,14,151,41,5,248,112,183,185,234,134,9,198,182,203,92,22,169,156,181,110,118,194,146,243,70,178,252,219,148,104,64,44,73,231,209,173,63,26,36,206,84,152,90,9,46,243,108,248,236,74,11,70,194,96,189,71,40,108,150,217,45,233,185,244,85,182,210,154,16,192,190,221,62,152,160,169,255,145,78,84,151,67,227,23,124,21,133,208,6,248,141,173,124,45,173,65,53,14,238,100,173,186,70,251,162,199,222,37,146,115,46,188,180,41,60,192,88,22,23,195,160,96,28,63,130,254,98,170,93,40,115,181,124,54,65,105,133,208,58,82,160,240,29,74,251,173,104,239,69,108,219,215,246,134,171,121,62,109,86,223,216,210,188,61,56,84,213,178,98,209,30,237,98,182,181,91,255,113,139,37,155,124,164,216,29,7,177,83,115,246,72,254,114,83,243,110,240,88,145,229,167,220,46,62,228,16,205,6,57,246,13,226,123,78,127,239,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("788f8d96-84a9-4c96-b0f8-5fd9201be0a6"));
		}

		#endregion

	}

	#endregion

}

