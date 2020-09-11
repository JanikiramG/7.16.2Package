﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiDeleteExecutorSchema

	/// <exclude/>
	public class MultiDeleteExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiDeleteExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiDeleteExecutorSchema(MultiDeleteExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24e9be4e-2a57-4fb2-89e5-ab20757823bc");
			Name = "MultiDeleteExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,90,91,111,235,54,18,126,78,129,254,7,214,11,20,50,106,8,251,28,199,41,188,57,73,235,221,147,211,32,73,187,15,217,32,160,37,198,225,86,166,92,74,114,98,20,249,239,59,188,136,34,41,82,114,246,44,246,37,142,196,185,113,102,56,243,113,108,134,183,164,218,225,140,160,123,194,57,174,202,231,58,189,40,217,51,221,52,28,215,180,100,223,126,243,231,183,223,156,52,21,101,27,116,119,168,106,178,157,123,207,64,95,20,36,19,196,85,250,19,97,132,211,172,71,243,153,178,63,186,151,182,46,78,98,239,211,43,156,213,37,167,164,138,82,220,101,47,36,111,10,194,195,20,219,109,201,186,149,77,81,174,113,113,122,170,222,167,159,203,205,6,94,195,58,80,252,133,147,13,108,0,93,20,184,170,78,209,117,83,212,244,19,41,72,77,46,223,72,214,128,25,146,108,215,172,11,154,161,76,80,133,136,208,41,90,253,189,92,119,60,39,127,74,62,35,255,138,146,34,7,5,55,156,238,113,77,212,226,78,61,160,170,6,151,103,136,19,156,151,172,56,160,21,152,136,158,10,248,179,64,240,239,53,102,120,67,56,248,184,22,182,19,158,76,44,19,38,211,185,86,69,88,174,180,197,84,151,53,132,139,228,173,114,253,136,126,173,8,135,216,51,21,75,239,113,238,210,174,62,81,249,26,243,195,89,85,115,240,227,12,149,235,127,195,226,57,186,193,28,178,170,38,188,242,153,110,73,86,242,252,150,84,96,246,207,152,229,16,56,228,60,29,161,101,245,203,142,168,212,92,110,8,3,117,238,115,79,103,72,132,178,163,50,156,255,44,249,239,132,91,162,212,139,158,172,46,211,207,62,145,29,248,25,20,174,216,115,121,142,156,199,10,226,197,200,43,250,76,171,218,35,76,198,162,4,209,1,35,106,72,250,72,146,172,203,178,248,17,61,209,234,2,87,25,206,201,220,95,68,171,118,9,137,163,123,114,178,33,181,254,239,132,62,163,164,99,69,11,176,179,41,138,105,187,44,215,187,240,137,74,80,99,202,170,127,144,67,50,49,98,39,211,142,225,196,150,134,128,126,15,198,167,247,229,223,192,16,130,153,37,236,193,18,240,56,157,107,254,119,245,169,63,56,169,27,206,172,205,161,239,148,133,232,251,239,81,34,54,55,245,54,174,56,223,93,23,173,46,89,179,133,72,174,11,114,246,83,67,243,115,244,196,101,196,87,121,53,31,38,188,109,233,34,190,51,114,62,230,59,35,214,245,157,37,13,37,61,99,166,182,243,58,9,143,195,190,115,119,26,244,143,58,7,232,169,130,234,185,197,95,64,135,242,138,42,110,122,245,206,44,70,92,209,113,127,204,23,157,96,215,25,182,60,148,40,43,28,23,88,140,35,62,240,54,230,56,33,118,240,174,73,253,82,70,75,243,190,164,57,172,144,29,230,36,239,140,74,134,234,224,206,144,181,219,220,99,142,156,152,43,150,135,199,233,110,40,212,253,52,53,228,183,150,52,35,57,189,35,162,76,37,96,242,226,92,86,34,193,5,143,83,125,238,6,173,238,109,18,45,148,119,161,239,220,146,93,1,96,193,172,217,153,61,11,88,53,179,157,160,116,219,114,3,202,230,129,124,189,71,160,122,197,160,61,178,140,156,221,159,39,144,79,96,118,35,208,193,146,111,192,55,172,126,120,68,88,255,43,203,175,72,71,101,246,235,11,225,66,198,169,110,219,42,20,34,67,45,6,47,129,29,81,224,191,144,194,191,62,90,201,213,166,158,196,15,10,183,28,68,163,22,214,26,97,211,208,230,194,123,1,86,189,80,89,11,199,230,27,114,183,163,210,78,180,89,187,49,5,20,67,123,106,61,16,217,117,50,105,28,88,0,81,119,113,130,114,250,251,220,56,217,178,234,59,207,203,202,166,116,153,231,73,84,93,199,62,113,146,105,26,112,190,150,119,95,46,1,2,30,146,160,187,135,28,24,74,112,93,13,25,60,182,132,104,143,139,6,158,190,62,22,54,149,34,83,142,249,81,70,41,46,222,170,173,58,201,79,199,56,122,231,80,196,70,59,204,46,207,98,163,83,47,66,15,226,229,35,216,43,55,174,29,143,72,81,145,80,36,165,167,36,101,60,70,161,200,104,236,242,43,43,40,251,253,131,133,85,242,26,183,62,99,48,109,40,3,5,156,216,69,97,142,178,96,226,123,33,136,111,118,14,190,209,156,143,31,219,120,104,171,247,231,118,205,211,5,69,20,147,171,134,101,103,3,206,145,172,80,86,115,154,129,236,104,5,8,170,76,172,212,112,1,109,186,100,112,158,140,67,132,184,80,159,24,75,194,22,246,61,195,221,13,103,47,158,22,148,59,79,148,121,168,186,3,11,71,159,188,96,203,178,112,196,204,213,153,94,178,154,214,135,142,192,224,212,113,169,237,221,230,25,186,13,132,76,117,196,161,70,120,188,80,37,203,181,244,107,37,195,85,166,217,178,190,92,253,254,139,60,197,33,201,189,176,203,83,63,236,198,144,164,119,47,21,224,240,253,38,138,198,13,166,124,28,148,136,236,232,155,210,101,200,61,16,168,179,163,80,134,58,14,201,80,89,153,246,229,61,244,94,165,96,102,119,123,177,202,94,144,114,102,172,112,119,253,62,142,194,140,13,234,118,31,11,163,169,57,51,85,245,180,158,227,217,111,203,178,6,102,232,187,78,148,20,155,150,118,143,214,184,34,171,144,67,35,28,150,99,172,123,196,15,104,242,196,149,62,91,160,225,25,169,147,14,6,55,249,159,216,53,142,214,100,235,220,190,37,92,110,235,142,15,191,195,84,195,119,96,181,205,101,81,88,253,225,127,19,72,39,18,55,189,243,226,205,61,16,150,127,165,52,119,165,117,107,44,54,39,121,105,142,73,119,101,128,80,221,98,182,33,137,116,161,201,240,214,161,73,231,167,169,212,44,192,237,23,242,86,175,4,129,41,236,239,232,245,133,22,4,41,41,6,240,233,213,200,125,214,190,186,244,40,161,208,109,203,61,73,38,16,248,61,45,155,110,104,3,1,153,216,141,54,148,45,87,37,135,238,73,25,46,174,73,85,129,225,38,91,244,12,232,134,151,25,172,144,188,29,71,189,232,207,133,59,152,66,184,66,17,150,46,107,90,94,31,231,234,247,169,98,240,164,36,130,116,38,115,209,91,185,220,131,159,1,9,131,123,199,246,121,77,248,134,56,221,178,27,85,57,131,5,111,108,149,25,170,214,216,99,91,115,159,83,30,175,172,225,188,97,181,203,188,104,239,248,30,168,184,162,188,170,127,225,159,200,51,6,79,39,84,210,158,35,26,106,33,2,32,31,215,171,69,36,130,102,248,97,57,9,81,165,246,141,122,152,64,148,6,40,130,73,164,49,79,1,38,138,83,99,14,199,144,190,234,162,108,228,113,30,85,9,139,214,113,179,65,184,239,222,94,95,14,52,161,227,135,34,145,161,241,158,242,186,193,69,120,182,43,43,93,239,181,41,80,118,229,182,111,220,177,203,111,175,40,234,150,97,79,7,2,250,226,55,240,222,38,142,153,55,71,11,110,215,138,250,118,105,4,159,68,153,199,44,243,170,127,188,234,127,124,34,117,140,235,123,248,45,224,122,235,203,8,207,103,193,0,124,32,4,177,121,189,201,47,127,233,131,33,25,22,50,22,154,48,247,184,113,255,175,80,201,203,49,213,64,17,24,205,29,59,22,212,164,37,158,182,227,136,94,152,213,186,142,131,21,222,118,26,17,201,139,62,131,213,88,125,63,13,187,93,149,255,182,228,101,148,84,63,147,98,167,252,30,91,27,173,60,208,133,31,30,191,122,4,54,27,231,95,230,91,202,110,233,230,165,174,12,116,183,39,103,129,227,21,219,212,241,229,77,66,133,207,37,206,77,163,208,142,23,205,193,248,36,234,216,23,245,177,56,206,195,115,23,78,8,232,104,96,158,0,16,93,159,52,48,250,24,156,2,234,149,29,2,128,26,42,105,14,24,161,193,186,222,150,117,247,152,181,16,164,53,65,1,237,182,35,14,226,39,11,234,216,115,29,10,101,56,247,28,217,118,113,175,19,223,53,91,23,221,216,228,71,92,59,252,120,73,62,235,2,98,3,235,48,173,0,217,65,99,67,211,60,239,110,31,17,57,11,11,12,66,213,96,38,94,64,106,212,164,95,170,93,12,177,24,69,17,74,161,247,53,240,208,205,168,234,241,232,239,123,109,101,3,45,229,136,83,118,215,172,171,140,211,53,145,32,222,169,55,255,237,13,99,120,82,18,237,145,60,220,157,224,4,250,187,119,128,252,171,34,91,68,248,211,223,186,81,176,170,162,250,58,234,133,225,33,194,46,198,40,163,59,86,95,210,72,193,61,236,174,236,75,61,118,244,195,66,89,18,190,107,185,163,167,161,43,219,128,252,193,219,92,20,97,71,242,228,146,253,209,144,198,186,150,122,56,175,157,31,29,57,152,253,218,193,170,53,52,243,3,57,124,249,50,95,200,182,18,210,118,103,177,219,81,96,32,54,160,61,52,69,210,58,123,26,61,29,195,1,176,192,73,210,187,3,135,79,154,127,33,40,253,144,249,214,119,29,46,50,195,113,37,56,103,75,207,83,84,82,95,131,97,203,61,46,168,232,145,214,56,60,130,64,205,25,246,79,250,131,167,80,156,198,54,128,253,47,155,219,25,208,192,220,71,102,166,59,243,233,190,217,215,71,105,185,219,21,7,99,73,229,13,154,222,99,7,103,252,106,42,127,182,160,131,172,126,194,224,30,49,249,99,44,146,120,63,111,114,65,220,177,223,230,181,219,242,132,45,60,113,250,171,238,254,239,5,122,144,187,230,135,214,83,226,151,94,169,132,98,147,187,26,243,58,157,152,193,89,127,232,105,85,72,243,187,154,206,231,113,144,231,150,192,94,11,214,203,126,251,210,175,77,181,106,97,147,125,120,244,187,192,200,109,222,219,223,37,203,211,127,49,51,190,67,25,174,197,121,187,124,203,200,78,58,148,188,77,29,183,92,114,94,242,132,188,165,90,232,76,80,104,185,245,11,47,95,251,168,195,75,28,245,214,125,41,223,253,7,2,80,188,131,3,41,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24e9be4e-2a57-4fb2-89e5-ab20757823bc"));
		}

		#endregion

	}

	#endregion

}
