﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChunkLookupValueHandlerSchema

	/// <exclude/>
	public class ChunkLookupValueHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChunkLookupValueHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChunkLookupValueHandlerSchema(ChunkLookupValueHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b286e0a-684a-4d22-a2be-ff6633bab9da");
			Name = "ChunkLookupValueHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,91,143,226,54,20,126,102,165,253,15,22,251,18,84,20,222,59,16,180,165,204,22,105,169,70,115,105,31,87,158,228,192,184,147,216,172,29,211,97,171,249,239,61,190,36,228,226,64,203,11,241,241,185,126,231,226,195,105,1,234,64,83,32,143,32,37,85,98,87,198,43,193,119,108,175,37,45,153,224,241,45,203,97,83,28,132,44,63,126,248,231,227,135,145,86,140,239,201,195,73,149,80,220,212,231,149,144,208,62,197,183,52,45,133,100,160,206,244,166,141,162,16,28,111,240,238,147,132,61,90,34,100,149,83,165,126,38,171,23,205,95,191,10,241,170,15,127,208,92,131,250,141,242,44,7,105,153,15,250,57,103,41,73,13,235,5,206,145,113,181,214,188,62,2,47,81,243,157,21,182,122,42,69,96,174,200,231,212,196,58,87,165,68,55,167,196,253,39,228,78,138,20,148,90,75,41,164,243,117,244,9,120,230,180,250,179,55,113,203,32,207,140,9,201,142,180,4,111,195,29,136,4,154,9,158,159,200,147,2,137,240,114,176,246,58,199,155,166,200,198,97,238,130,179,113,170,95,105,73,209,163,35,203,64,146,111,204,222,55,105,45,249,38,42,62,12,129,82,121,136,60,40,248,40,60,79,91,176,38,183,4,29,104,228,27,24,180,182,120,75,247,240,8,197,33,199,203,43,224,161,186,3,200,18,107,101,0,192,107,104,108,122,96,24,105,91,3,163,61,148,100,145,132,0,35,203,37,137,66,244,133,43,69,87,193,167,248,11,148,243,43,30,36,17,135,191,177,238,57,162,160,141,212,103,185,215,5,150,86,52,214,173,36,143,167,214,41,252,181,147,63,153,76,44,154,239,237,192,195,105,12,82,219,17,187,175,17,219,69,225,156,147,197,130,112,157,231,147,138,115,52,196,215,199,34,104,62,137,170,192,200,127,134,162,211,0,147,233,117,21,71,154,179,12,145,185,135,239,154,73,200,86,34,215,5,87,168,11,89,193,131,56,24,77,220,236,104,242,211,34,140,100,213,239,70,207,187,251,147,80,106,201,47,245,143,227,236,164,207,247,196,58,208,18,131,233,10,245,79,63,91,155,123,80,66,203,20,30,16,30,228,68,83,238,127,209,1,53,254,83,200,87,59,226,227,142,72,13,85,216,162,205,193,87,145,34,224,63,232,115,142,82,38,150,200,219,153,146,177,239,5,155,128,26,139,115,125,143,123,178,42,14,1,17,91,52,199,147,48,224,3,211,164,131,247,208,96,105,148,80,120,252,15,189,32,81,103,82,183,43,119,98,6,74,135,99,209,225,185,50,242,182,80,190,136,193,7,35,60,132,177,247,130,23,81,144,186,5,211,49,130,52,75,182,170,159,35,149,36,56,209,175,181,123,205,248,63,6,94,183,203,125,166,131,246,77,141,162,50,44,24,132,33,106,185,238,164,124,93,12,63,71,190,34,102,179,25,153,43,93,20,84,158,146,138,176,194,135,184,4,69,24,223,9,89,216,253,134,208,103,161,75,114,112,26,76,179,218,138,139,107,29,179,174,146,249,129,74,90,16,142,155,211,98,156,66,158,223,195,110,7,18,120,10,227,100,211,211,12,111,200,67,12,95,60,159,89,209,176,38,132,142,149,167,135,244,5,10,250,180,201,198,201,218,18,136,178,20,162,57,251,174,129,224,91,131,228,29,3,121,89,91,193,108,48,174,181,146,53,250,112,176,62,21,174,147,250,194,14,87,149,204,103,213,87,96,142,57,252,90,29,223,236,232,232,139,102,25,233,4,82,109,83,164,233,82,179,14,125,128,189,185,181,110,232,217,82,142,250,165,41,199,13,238,157,191,156,80,113,212,49,212,46,16,103,52,190,181,217,136,66,115,103,234,45,199,43,106,177,153,182,61,12,189,198,71,129,241,13,63,25,145,120,254,11,157,39,98,122,129,201,238,162,216,44,202,173,158,230,171,66,35,4,31,226,82,243,181,32,193,187,155,26,67,83,94,106,195,51,120,3,211,194,225,109,109,105,224,91,53,56,253,139,221,75,216,217,160,75,245,239,88,82,77,234,182,135,211,168,233,192,210,160,190,166,233,75,100,168,150,136,243,210,217,106,86,205,50,222,240,163,120,133,51,91,245,118,92,171,179,11,30,215,165,30,123,230,201,196,42,109,229,243,250,80,238,191,20,54,247,235,55,72,53,14,166,243,190,105,31,144,121,99,45,52,196,132,164,230,179,202,107,56,29,152,167,193,129,110,197,99,163,42,238,92,217,193,232,65,47,229,169,218,7,76,17,248,25,6,153,19,33,3,219,77,181,3,57,114,20,118,174,234,52,21,213,43,85,195,167,187,182,37,235,19,154,235,56,16,63,208,163,31,228,109,29,21,191,67,209,162,102,73,103,189,158,189,191,214,199,79,7,179,253,57,128,188,214,119,178,99,156,230,121,13,198,32,222,102,133,186,188,60,120,90,147,244,254,47,187,127,55,145,36,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b286e0a-684a-4d22-a2be-ff6633bab9da"));
		}

		#endregion

	}

	#endregion

}

