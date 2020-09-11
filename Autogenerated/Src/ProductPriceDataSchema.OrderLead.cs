namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProductPriceDataSchema

	/// <exclude/>
	public class ProductPriceDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProductPriceDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProductPriceDataSchema(ProductPriceDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("525ed2a1-425c-433b-81f6-b5e01bce93f9");
			Name = "ProductPriceData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c797525-d05e-4bd8-84e9-5dcb79ad7c60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,193,106,195,48,12,134,207,13,228,29,4,187,39,247,101,236,146,193,24,236,80,88,95,64,179,149,32,72,236,32,219,208,80,250,238,115,156,164,180,27,203,214,163,101,125,159,126,71,49,216,147,27,80,17,28,72,4,157,109,124,81,91,211,112,27,4,61,91,147,103,167,60,219,5,199,166,133,143,209,121,234,171,60,139,149,7,161,54,94,67,221,161,115,143,176,23,171,131,242,123,97,69,47,232,49,245,148,101,9,79,46,244,61,202,248,188,156,83,63,40,107,60,178,33,129,198,202,13,92,172,92,121,5,14,225,179,99,5,42,177,63,71,237,78,105,220,37,83,236,24,72,60,211,20,44,161,243,253,247,60,169,112,192,35,176,38,227,185,97,146,226,210,119,61,127,13,240,26,88,79,192,155,174,126,245,213,65,132,140,26,239,147,174,212,150,57,189,24,222,217,249,251,220,137,155,176,77,57,137,138,78,176,13,120,60,110,91,53,41,238,177,155,190,196,130,253,21,58,90,135,121,109,255,51,39,170,90,182,74,70,207,139,77,231,243,252,251,221,20,207,95,106,200,84,61,199,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("525ed2a1-425c-433b-81f6-b5e01bce93f9"));
		}

		#endregion

	}

	#endregion

}

