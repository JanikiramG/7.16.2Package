﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WordReportingDesignServiceSchema

	/// <exclude/>
	public class WordReportingDesignServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WordReportingDesignServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WordReportingDesignServiceSchema(WordReportingDesignServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("778cb9df-4e29-46a4-8914-8863c3d25dbc");
			Name = "WordReportingDesignService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ce5f9868-588b-431e-9bee-93d7e8c140a5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,25,219,114,219,54,246,89,157,233,63,96,149,78,75,109,101,56,77,51,219,93,187,142,87,241,37,213,78,20,103,37,185,121,240,122,50,20,9,201,156,144,4,11,128,178,181,174,255,125,15,110,36,64,81,151,109,51,125,232,75,34,2,231,126,63,112,30,102,132,23,97,68,208,148,48,22,114,58,23,248,140,230,243,100,81,178,80,36,52,199,99,82,80,38,146,124,129,63,80,22,227,9,97,203,36,34,252,203,47,30,191,252,162,83,114,184,64,147,21,23,36,59,110,124,227,225,213,218,209,219,36,255,101,237,240,29,17,107,103,134,205,136,198,36,221,122,137,7,145,72,150,74,212,237,112,31,200,108,13,96,74,30,4,40,184,40,211,144,93,60,20,140,112,14,116,248,26,156,135,187,72,233,44,76,143,142,206,104,150,129,125,222,210,197,2,142,235,251,77,134,188,76,82,114,93,164,52,140,119,195,54,140,14,255,124,34,108,95,52,163,118,59,56,219,120,142,47,195,72,80,150,16,190,17,194,53,40,112,22,12,48,218,128,193,94,88,155,167,190,253,73,136,66,226,128,201,209,73,3,86,222,225,193,140,43,130,210,3,216,129,6,18,207,146,57,122,119,49,157,76,7,239,206,7,227,243,23,31,159,163,195,67,52,189,58,191,66,103,227,209,193,203,191,189,252,199,15,181,24,147,221,244,37,77,146,114,82,33,141,36,146,231,237,103,36,143,147,185,67,213,51,181,199,66,217,198,187,6,124,192,124,198,200,66,194,158,165,33,231,71,72,186,178,114,236,57,225,201,34,55,6,85,208,55,230,195,26,246,86,158,13,120,1,233,1,182,44,128,238,44,73,19,177,26,147,95,202,132,145,140,228,130,7,238,135,116,11,200,181,3,69,66,97,115,16,247,36,147,162,156,165,73,132,34,41,229,22,33,209,17,122,29,114,82,137,220,121,84,98,215,90,130,93,69,8,28,142,208,123,38,83,82,171,213,41,244,7,138,228,61,2,31,72,115,74,54,163,36,35,211,85,33,101,238,134,69,1,50,40,219,29,46,243,24,211,130,228,15,89,58,167,44,11,5,63,160,243,57,240,140,105,84,74,29,240,61,96,23,140,70,50,95,243,69,150,98,123,211,61,54,50,129,243,180,88,190,140,151,9,73,227,77,2,214,9,74,24,250,56,119,190,142,125,192,97,109,36,109,33,157,159,232,35,83,103,85,182,186,56,16,84,99,168,180,96,3,242,94,75,78,1,225,190,229,116,135,10,202,204,172,148,169,42,21,81,190,51,172,180,31,55,123,48,232,161,71,244,180,47,240,53,39,12,152,229,68,165,12,42,189,207,62,26,214,230,26,230,115,138,230,222,103,79,242,232,28,161,25,68,76,224,163,58,66,108,210,17,108,81,16,16,137,108,114,213,38,15,140,29,7,160,147,87,74,8,207,43,232,244,20,5,254,201,137,206,79,93,253,86,248,13,17,63,110,32,255,42,232,245,246,113,107,235,161,149,166,205,229,90,170,214,155,22,233,218,200,183,136,230,133,179,247,97,69,113,67,92,139,224,157,156,40,168,206,26,127,151,214,171,32,39,247,110,76,14,216,66,101,98,208,245,189,222,237,35,63,160,122,149,192,155,162,96,68,196,29,221,152,173,205,248,3,201,252,147,96,34,24,9,51,21,152,170,149,228,2,66,79,233,196,136,40,89,190,110,89,159,192,22,221,28,154,160,152,203,161,223,214,173,180,33,55,82,99,80,141,9,151,148,166,19,183,243,225,179,146,49,89,239,198,26,64,17,55,109,107,63,122,18,100,164,105,26,26,31,24,148,90,194,130,209,118,78,154,149,233,128,219,120,113,248,10,23,100,205,189,106,102,81,147,37,208,228,180,100,17,153,104,80,229,247,78,231,201,119,167,233,11,64,96,9,153,255,122,37,8,159,210,209,44,136,73,148,100,97,138,102,242,196,250,111,25,50,148,205,32,55,2,117,140,14,209,119,207,95,188,236,153,255,143,93,31,103,51,60,165,19,69,60,168,24,119,58,46,107,217,213,108,66,201,48,178,191,131,25,165,41,74,248,164,140,100,146,245,81,146,139,83,4,93,159,130,158,49,233,91,153,97,130,230,160,151,108,99,93,87,66,102,105,158,40,63,120,108,52,84,199,144,6,136,138,141,186,120,210,58,64,32,5,127,169,110,208,215,95,215,220,241,79,33,255,57,76,75,98,57,118,44,59,124,33,97,84,78,104,198,245,183,129,236,140,42,137,141,236,125,115,113,97,201,195,85,205,170,54,160,6,51,210,61,185,118,182,220,219,124,187,164,73,140,38,181,97,101,224,77,68,40,74,30,212,63,21,87,94,253,84,106,237,154,251,126,120,241,189,206,45,119,184,140,170,33,179,37,192,143,221,12,130,66,122,5,185,160,166,142,117,236,150,91,143,74,149,28,210,75,21,26,152,188,76,83,199,41,210,58,149,189,246,86,168,17,63,134,60,30,187,86,174,61,238,88,16,114,2,194,180,87,27,210,211,248,170,20,11,10,158,116,90,136,85,156,154,171,241,58,215,171,198,149,230,222,68,240,165,104,8,96,141,213,136,12,155,221,144,117,163,240,65,150,223,73,242,95,114,201,104,6,179,56,68,140,156,74,120,96,173,9,138,161,165,140,121,57,125,251,243,56,118,224,101,41,87,169,209,24,97,250,168,43,57,12,51,217,215,29,118,80,187,158,247,188,162,97,111,76,53,34,12,143,102,83,170,138,82,160,4,104,45,97,170,92,12,249,219,144,139,179,187,50,255,20,152,250,32,107,212,56,204,23,196,47,14,11,242,96,18,116,44,127,7,255,236,254,39,254,246,32,56,253,177,212,189,53,86,252,94,221,28,220,158,194,69,239,16,110,4,21,97,170,143,229,209,87,93,35,182,36,232,97,201,177,65,203,14,201,59,204,197,247,47,2,197,16,143,66,17,221,5,181,68,248,13,163,101,193,111,186,30,122,247,22,255,92,171,169,200,215,172,255,127,218,53,110,131,240,225,161,12,253,35,101,239,65,145,32,14,113,210,80,228,62,129,33,160,132,240,204,137,50,164,193,131,125,77,206,104,168,72,75,216,190,53,98,68,33,57,35,209,32,160,252,229,58,183,97,168,19,87,181,95,127,109,92,127,139,190,243,65,92,199,239,30,92,156,233,252,198,43,38,118,193,235,220,64,42,14,243,37,253,68,2,141,38,219,200,251,171,201,20,162,210,52,227,75,181,4,233,138,100,42,183,62,194,255,226,50,170,109,2,238,128,83,54,120,77,227,213,68,172,82,226,129,85,167,88,143,7,177,29,3,110,91,87,133,81,152,228,178,159,156,11,122,115,43,115,119,253,234,140,166,169,206,186,160,49,116,185,35,58,86,221,86,126,115,23,1,226,106,0,187,245,42,240,210,236,79,100,64,91,169,192,128,190,249,170,146,247,166,132,150,169,215,148,97,188,151,5,43,212,10,107,79,227,1,133,224,154,37,83,146,21,169,44,99,96,190,115,122,159,203,44,208,148,237,205,225,163,37,253,212,245,20,51,131,118,59,150,173,130,77,101,116,17,148,103,74,87,93,9,229,207,134,2,29,193,86,182,155,186,35,125,53,126,69,97,161,215,202,19,223,50,86,156,74,144,154,155,161,220,177,20,244,236,126,158,64,24,240,196,60,239,124,213,13,133,8,163,59,57,230,30,43,142,121,152,145,191,158,92,79,47,15,254,254,205,55,143,114,184,184,22,234,121,5,95,179,244,125,40,238,46,242,8,250,93,96,5,122,146,207,18,15,93,195,171,109,107,195,3,46,183,75,89,254,188,118,12,131,181,51,187,12,34,3,13,158,26,170,55,22,185,202,247,189,55,20,59,192,73,57,79,241,91,146,47,196,157,92,233,158,247,91,180,179,234,155,120,146,56,102,66,1,99,66,13,71,193,80,144,236,29,133,196,41,243,248,226,33,34,74,33,68,30,170,185,70,220,49,122,175,92,6,122,93,134,101,42,42,176,198,76,135,45,157,94,131,199,239,165,171,179,29,168,15,210,148,222,147,138,254,239,43,25,141,76,208,219,160,31,209,221,125,43,134,151,36,222,248,223,70,118,203,190,234,142,183,119,222,59,234,206,48,209,70,105,228,32,32,58,100,236,210,135,255,93,18,182,210,163,254,77,215,194,118,111,53,9,167,34,109,73,214,237,175,66,128,184,190,166,187,250,106,34,118,42,204,234,25,77,99,110,155,17,155,147,144,189,49,194,214,76,245,220,24,52,222,171,170,141,140,136,179,18,150,218,12,26,82,153,229,92,242,209,24,64,104,30,194,32,109,82,109,228,9,231,136,234,46,112,78,237,114,95,77,176,254,33,143,2,95,90,155,154,114,167,112,71,73,31,10,191,174,134,172,74,240,142,9,31,81,71,175,87,14,97,238,74,98,56,175,194,173,65,82,141,198,85,101,236,120,184,147,112,89,227,89,6,125,19,13,21,202,62,27,30,62,3,33,69,149,172,102,135,172,106,130,125,87,104,173,13,123,209,135,129,148,176,60,76,229,43,38,97,106,159,109,148,59,119,195,215,14,213,43,211,122,217,146,25,85,136,112,150,146,102,237,218,89,31,255,112,89,91,75,172,19,163,82,74,2,99,237,111,151,86,55,149,234,47,7,191,73,80,159,70,127,253,185,167,17,148,142,2,189,189,250,199,31,107,247,109,45,168,141,148,96,37,80,82,15,4,127,170,201,214,235,109,99,146,209,37,105,244,182,214,121,214,169,142,94,185,209,20,26,115,219,112,45,186,119,38,225,231,73,162,207,64,250,51,197,73,99,223,212,167,254,33,156,253,15,4,103,37,49,211,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("778cb9df-4e29-46a4-8914-8863c3d25dbc"));
		}

		#endregion

	}

	#endregion

}

