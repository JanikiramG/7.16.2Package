﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnMessageReaderSchema

	/// <exclude/>
	public class EsnMessageReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnMessageReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnMessageReaderSchema(EsnMessageReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("018d54e3-873e-4c77-80ce-ce9f24c6e1fe");
			Name = "EsnMessageReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,89,91,79,227,56,20,126,238,72,243,31,188,153,151,84,66,97,247,21,104,87,80,10,170,196,109,40,104,31,70,60,132,196,5,107,82,167,99,59,176,213,106,254,251,30,223,18,59,113,105,97,184,204,19,196,61,151,239,92,124,142,125,76,211,57,230,139,52,195,232,10,51,150,242,114,38,146,81,73,103,228,174,98,169,32,37,77,198,211,179,207,159,254,251,252,169,87,113,66,239,208,116,201,5,158,239,182,190,129,167,40,112,38,25,120,114,140,41,102,36,107,104,70,229,124,94,82,247,155,97,255,43,25,83,65,4,193,188,181,124,148,102,162,100,222,186,162,92,78,179,123,60,79,209,192,231,78,220,31,27,150,198,180,179,138,36,83,204,30,72,134,79,203,28,23,201,248,95,129,41,151,176,129,28,24,190,48,124,7,95,8,141,138,148,243,29,52,230,244,20,115,158,222,225,75,156,230,152,41,162,237,237,109,180,71,232,61,88,41,242,50,67,219,67,88,252,118,136,103,105,85,136,3,66,115,80,26,139,229,2,151,179,120,210,150,208,239,223,0,245,162,186,45,72,134,50,169,165,163,4,237,160,14,27,240,200,32,212,0,33,72,92,164,84,0,198,11,86,10,240,61,206,21,184,222,194,126,162,76,210,32,46,152,242,91,45,208,117,210,25,196,31,188,24,77,203,140,164,133,33,136,118,125,57,12,16,148,180,88,162,107,142,25,40,166,58,210,173,79,237,192,222,23,76,115,141,209,124,187,128,89,37,227,41,49,43,251,13,96,237,139,182,197,113,75,91,229,125,246,145,114,71,207,95,77,70,247,56,251,190,207,238,170,57,166,226,172,42,138,152,130,133,16,135,22,119,95,153,216,107,169,24,180,148,40,162,159,79,219,117,138,197,125,153,171,48,144,135,84,96,27,4,245,225,103,235,49,22,141,145,122,45,238,163,193,80,65,105,97,241,82,249,52,165,192,193,96,103,137,137,10,123,134,15,150,50,116,241,234,168,246,119,125,36,38,13,64,196,180,100,16,85,216,177,213,156,42,33,122,193,200,209,235,136,119,215,36,212,208,122,114,85,78,149,240,184,173,243,161,36,57,154,98,113,206,100,60,93,132,95,43,204,150,104,174,197,168,143,45,180,33,140,45,237,46,37,243,144,48,19,186,220,254,103,19,227,33,101,134,219,136,26,120,234,18,189,42,171,149,48,190,12,185,38,228,6,147,59,174,240,164,133,102,208,224,89,69,124,81,114,98,104,255,114,243,44,148,57,218,91,50,125,166,95,99,215,64,220,74,39,16,22,76,178,221,154,195,245,1,80,83,252,216,213,20,183,197,26,126,207,127,144,174,251,249,156,208,75,114,119,47,184,84,92,148,183,105,177,191,88,64,192,5,100,3,79,142,112,42,42,134,125,202,9,29,207,111,113,158,227,252,164,188,211,93,162,215,99,24,8,169,7,238,153,123,207,43,129,170,64,243,106,62,79,217,114,104,23,246,243,28,205,72,33,160,190,222,214,169,135,72,158,212,28,219,109,150,189,69,202,210,57,146,37,100,16,185,224,162,161,221,135,160,7,99,148,49,60,27,68,29,71,70,208,26,246,182,149,144,39,101,78,242,104,120,218,0,114,89,154,42,252,64,152,168,210,66,111,42,48,70,118,85,40,114,92,105,58,82,134,173,221,98,199,21,240,214,74,109,38,121,113,213,146,120,2,26,98,189,211,252,109,3,205,64,96,77,244,15,17,247,23,18,41,150,28,177,94,4,88,128,158,240,146,94,65,7,76,198,63,0,243,22,138,128,14,192,70,91,142,246,190,27,226,13,66,134,149,113,224,32,148,210,28,149,11,125,218,248,192,232,105,64,50,120,154,215,77,170,39,25,101,67,61,215,248,163,161,236,118,178,50,27,131,60,72,156,202,95,77,106,88,14,128,181,97,138,104,88,134,253,57,41,98,45,51,181,54,136,3,57,86,172,205,164,64,14,77,184,236,207,6,149,205,143,126,168,212,116,83,242,117,114,114,108,227,183,85,27,108,245,147,25,138,29,251,146,243,217,140,99,113,40,11,243,31,80,220,245,81,47,150,223,87,4,122,173,181,95,149,216,89,64,39,130,2,233,201,107,245,139,1,242,87,146,67,204,51,172,78,146,198,226,191,81,208,150,19,112,132,161,216,9,83,28,43,239,176,221,192,102,254,5,199,26,242,94,200,216,45,251,99,168,163,186,94,208,63,30,44,251,53,71,216,231,230,87,27,156,159,193,16,25,99,100,124,40,36,86,29,146,73,39,227,53,229,4,238,45,208,64,127,24,62,163,195,15,147,117,208,65,69,138,124,108,105,253,108,190,44,75,161,133,39,215,176,99,90,167,226,254,58,191,55,8,92,235,54,175,138,242,196,138,120,117,203,51,70,20,106,52,195,248,67,155,218,123,85,183,35,176,115,195,162,246,254,5,236,165,5,228,181,247,231,202,162,241,62,155,84,213,195,58,78,171,14,156,22,164,157,33,120,222,118,14,175,110,154,255,186,196,174,180,68,29,73,211,226,124,129,245,244,3,196,183,151,228,85,39,19,80,192,27,88,114,11,78,114,160,109,93,225,70,21,147,57,33,87,147,73,190,82,233,47,68,55,28,94,221,223,106,154,232,155,190,221,79,29,213,59,182,247,213,255,220,36,223,166,75,46,177,78,232,101,89,224,29,248,178,127,213,241,253,154,18,113,147,24,154,168,17,175,173,111,69,255,55,54,211,181,103,157,25,77,234,42,248,93,171,156,228,172,232,235,166,103,72,94,2,53,167,20,32,85,176,10,63,65,246,94,190,190,246,148,191,178,183,67,150,173,59,30,54,34,54,187,93,100,122,54,32,74,219,48,56,250,161,132,190,109,255,220,176,195,157,58,210,205,188,98,77,171,11,246,177,11,70,164,5,142,24,200,163,253,226,49,93,242,41,150,25,232,37,148,199,170,238,153,146,35,142,204,125,115,84,86,178,205,173,161,85,121,6,77,99,67,194,115,186,142,240,36,229,98,95,237,149,245,180,245,185,126,35,58,237,202,235,134,92,13,86,186,51,210,85,82,100,217,212,132,59,215,117,234,215,66,111,18,201,14,162,65,176,146,222,150,156,216,17,108,123,128,23,133,209,140,210,133,233,76,47,5,100,36,88,115,3,194,131,152,44,91,115,190,105,181,59,56,72,152,137,207,84,64,80,33,102,132,126,191,96,248,129,224,199,168,47,239,56,127,122,247,164,162,249,25,206,15,105,120,76,231,218,117,226,51,52,229,70,90,37,87,172,73,189,160,232,218,170,150,156,200,61,176,172,204,63,242,29,111,148,250,118,134,190,134,204,30,23,155,32,67,41,42,217,122,39,232,194,59,186,79,193,239,197,142,87,107,71,82,130,21,233,136,171,13,215,4,107,11,35,4,82,87,65,52,43,25,156,146,225,196,3,206,130,67,188,173,145,79,85,71,61,202,227,207,170,133,150,39,92,13,131,147,80,183,52,122,35,209,214,128,211,14,77,181,83,86,212,212,64,247,93,51,145,124,153,223,208,35,244,92,148,22,133,233,59,220,236,236,223,199,159,251,69,161,157,242,76,199,182,211,21,228,152,170,97,92,252,150,110,221,180,89,115,115,147,137,134,250,78,211,196,5,238,209,142,91,3,15,17,157,166,221,17,94,15,252,107,233,245,74,151,241,35,54,201,234,231,149,3,184,33,175,122,78,65,3,93,81,87,142,167,158,78,17,127,155,234,28,168,31,132,252,59,122,131,165,121,203,249,13,146,230,117,167,25,31,22,253,141,39,32,27,196,49,52,29,216,122,98,188,25,170,17,151,229,163,106,167,173,185,168,131,81,253,252,236,231,33,117,200,234,190,15,57,207,205,193,215,123,251,8,61,25,211,106,14,55,253,219,2,239,105,167,14,145,196,100,31,91,226,240,11,202,6,78,11,108,191,164,62,253,182,247,95,178,95,111,175,186,113,133,222,123,252,29,212,192,90,233,54,121,72,211,118,57,151,207,208,196,242,231,6,206,50,175,30,78,204,94,238,158,77,32,183,128,118,12,126,25,230,186,229,113,163,229,5,54,180,219,230,59,25,179,42,91,189,119,159,216,127,209,89,59,11,125,81,33,104,210,52,244,230,228,167,105,3,165,195,255,214,25,187,202,97,114,148,108,221,245,198,254,113,166,214,190,91,222,194,25,94,101,212,107,238,18,172,252,15,130,96,248,195,1,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("018d54e3-873e-4c77-80ce-ce9f24c6e1fe"));
		}

		#endregion

	}

	#endregion

}

