﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProductPriceHelperSchema

	/// <exclude/>
	public class ProductPriceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProductPriceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProductPriceHelperSchema(ProductPriceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70b4bee4-c8f3-41d2-b561-a02a76828ee7");
			Name = "ProductPriceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,221,111,219,54,16,127,118,129,254,15,140,7,116,14,160,41,123,110,28,23,107,210,116,6,154,46,88,178,61,236,165,160,37,58,214,38,75,46,73,57,241,218,252,239,59,242,72,137,164,36,91,105,135,125,188,196,145,116,119,188,143,223,125,177,160,107,38,54,52,97,228,150,113,78,69,185,148,241,121,89,44,179,187,138,83,153,149,5,121,254,236,211,243,103,163,74,100,197,29,185,217,9,201,214,167,193,51,48,228,57,75,20,181,136,223,178,130,241,44,105,104,92,185,156,245,189,247,15,237,165,122,83,200,76,102,76,0,1,144,124,195,217,157,82,241,60,167,66,188,36,215,188,76,171,68,94,195,241,236,71,150,111,24,215,84,155,106,145,103,9,73,20,81,7,13,24,56,82,22,214,210,46,51,150,167,90,92,182,165,146,105,25,163,13,62,144,95,4,227,160,106,129,230,146,15,149,247,124,234,146,106,93,119,55,201,138,173,41,249,176,113,14,198,119,135,137,107,58,173,30,43,82,212,208,60,91,227,193,235,146,3,117,201,133,209,21,13,110,155,58,9,180,247,149,63,38,218,13,163,192,38,114,70,58,140,28,117,24,4,148,1,111,236,154,117,69,11,122,199,56,32,68,206,65,101,90,36,236,245,238,61,224,111,50,118,85,29,31,251,7,252,77,178,141,216,199,253,206,188,98,114,85,246,6,63,43,36,129,19,180,154,128,249,106,93,92,115,150,100,2,56,39,168,13,97,250,199,186,210,85,17,25,200,166,97,6,155,144,60,70,138,24,95,139,248,50,43,210,70,125,199,39,217,146,76,28,1,241,5,149,244,87,154,87,236,118,183,1,245,4,185,204,75,42,189,183,86,149,209,150,114,146,46,26,234,51,50,233,160,238,149,142,10,140,56,147,21,47,92,65,113,237,3,36,121,212,127,13,221,247,174,211,173,27,183,101,150,146,247,37,95,211,60,251,147,105,3,125,247,69,218,211,235,172,113,175,181,34,133,103,96,67,47,54,254,131,160,40,85,82,84,92,171,54,189,64,210,89,224,66,43,161,176,231,167,215,70,214,21,149,171,248,231,178,42,82,244,113,228,105,16,145,171,44,221,148,160,152,38,129,218,20,255,112,79,119,151,188,92,255,198,120,25,6,136,28,157,133,71,212,145,176,65,103,210,209,215,170,25,181,216,28,183,30,118,164,176,158,20,60,137,76,85,33,41,19,210,158,174,96,0,223,52,113,109,28,88,223,135,107,160,53,26,104,0,129,164,193,172,250,88,227,151,32,158,192,213,86,98,218,33,30,61,246,170,77,141,31,94,118,176,224,137,1,190,180,59,60,68,117,146,41,105,93,116,195,203,70,41,161,60,177,20,191,159,156,156,144,169,168,214,107,202,119,51,251,2,138,112,74,100,73,32,69,120,198,182,140,200,21,35,175,169,64,21,222,101,66,146,173,66,68,92,75,56,9,69,76,49,189,196,204,103,155,167,241,244,196,126,66,160,24,117,200,54,227,178,2,216,191,173,0,50,16,48,143,113,158,78,44,60,202,197,239,192,64,22,238,103,141,207,6,223,71,237,126,29,195,32,0,112,150,144,21,34,190,229,59,56,0,65,29,212,236,136,140,189,131,199,17,134,177,172,186,142,60,174,51,198,84,19,165,124,252,102,189,145,59,183,212,40,92,46,124,115,84,113,83,196,199,125,118,24,129,1,155,27,234,225,161,51,13,198,212,34,178,216,169,56,236,137,221,134,114,186,38,5,84,247,179,177,233,113,243,116,60,179,98,116,16,53,77,59,220,193,81,16,141,12,30,30,64,121,113,48,242,166,22,232,100,213,82,240,133,246,19,169,245,240,59,151,125,175,186,175,215,142,227,115,206,160,2,25,17,65,148,77,106,45,202,50,135,158,116,201,36,176,168,144,24,9,177,126,163,10,231,197,235,73,115,176,23,152,134,237,85,173,195,75,82,84,121,62,56,70,137,214,16,66,149,83,137,111,26,15,19,90,164,196,205,27,111,88,178,93,101,96,12,3,16,169,72,122,9,25,196,242,235,195,239,41,57,60,236,239,217,61,38,95,35,196,133,64,96,70,68,246,2,99,17,72,114,16,226,76,132,131,96,18,72,82,125,241,130,45,157,214,40,38,123,72,189,22,10,142,68,189,99,48,86,253,78,142,135,178,186,17,140,66,103,12,23,98,227,25,145,30,100,135,50,190,170,230,184,72,80,133,103,15,194,255,23,104,254,210,138,246,95,196,181,106,75,73,9,147,162,222,139,65,78,193,238,201,69,166,73,192,251,83,88,218,160,93,70,4,59,238,204,182,186,79,245,194,226,64,232,49,106,62,214,173,51,180,12,187,225,99,79,241,109,97,215,173,194,141,158,253,101,184,229,153,118,61,110,135,72,171,49,23,232,40,76,149,243,21,45,238,88,58,189,157,245,141,170,17,65,223,128,251,20,131,218,131,108,148,110,21,113,189,61,193,255,157,163,63,136,118,88,79,13,167,18,93,179,170,135,193,188,198,27,71,245,217,241,155,143,96,157,152,52,34,143,135,247,165,21,75,254,32,236,99,5,51,124,206,96,81,37,229,146,156,87,156,195,255,59,133,207,91,250,160,126,208,201,122,18,20,67,147,23,20,28,207,110,202,138,187,253,97,79,198,42,253,199,179,11,248,155,21,120,219,211,199,229,102,162,122,113,9,230,51,149,174,174,230,215,184,54,169,210,163,141,32,148,51,101,41,208,42,203,83,231,28,180,75,147,74,94,129,15,160,170,241,251,76,184,83,239,254,236,239,128,150,48,216,58,180,3,153,228,192,165,5,89,0,18,221,48,173,215,72,45,12,225,233,111,148,70,154,117,196,33,129,170,252,248,210,26,23,6,34,193,137,79,151,166,61,63,14,243,56,212,238,243,231,208,1,250,77,115,226,96,60,139,93,145,172,120,89,64,236,250,97,156,152,155,141,127,19,199,109,8,233,253,249,6,244,183,215,138,135,128,19,238,218,181,223,3,40,120,104,108,197,174,134,105,200,174,183,171,22,251,139,23,88,173,110,100,169,170,226,141,84,99,237,209,25,49,207,63,233,254,161,223,170,169,39,216,153,194,69,41,49,17,218,83,61,17,82,29,168,84,252,246,226,165,143,185,231,214,69,247,92,73,31,14,31,235,193,215,108,163,192,168,105,84,19,181,45,71,59,75,73,4,79,52,123,97,109,189,195,2,255,186,94,64,95,6,131,155,99,108,84,251,168,190,49,234,96,176,151,53,27,231,138,166,147,16,237,137,106,27,60,90,186,101,147,165,170,164,79,188,101,208,23,188,251,114,115,147,2,28,132,137,214,178,228,245,26,228,95,24,120,253,156,179,164,228,205,156,56,95,118,125,6,116,23,223,218,9,77,151,111,60,195,188,86,49,32,223,153,221,75,168,81,117,253,196,85,120,28,44,185,126,10,227,205,54,230,173,185,117,154,23,158,77,19,127,115,181,128,192,139,57,179,204,34,140,246,100,138,63,34,58,171,235,30,224,54,168,237,26,59,241,154,172,117,235,210,64,185,69,223,9,235,182,170,253,115,107,255,92,220,26,137,195,93,165,81,200,149,24,184,173,251,200,254,45,243,224,169,104,144,87,143,13,73,212,178,111,192,188,213,155,3,22,96,22,209,75,103,81,194,70,229,12,45,126,194,56,247,92,135,47,233,58,208,141,101,163,103,145,63,132,115,195,21,32,220,187,91,118,96,222,29,180,30,172,255,83,104,117,19,203,220,218,186,135,186,95,246,229,154,187,160,186,189,179,71,178,29,215,195,173,254,11,42,192,0,213,236,18,108,20,107,221,164,181,110,224,186,178,111,120,173,234,202,23,51,136,219,26,216,215,92,204,59,247,213,227,95,58,152,80,190,17,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70b4bee4-c8f3-41d2-b561-a02a76828ee7"));
		}

		#endregion

	}

	#endregion

}
