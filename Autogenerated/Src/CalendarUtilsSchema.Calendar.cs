﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilsSchema

	/// <exclude/>
	public class CalendarUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilsSchema(CalendarUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87e4846c-42e3-4483-baaf-bea01429675a");
			Name = "CalendarUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,219,110,219,70,246,89,1,242,15,83,27,40,40,148,160,155,167,2,182,229,34,107,167,129,128,36,206,174,221,205,67,81,20,180,56,182,185,165,72,123,72,38,81,3,253,251,158,185,95,73,145,178,229,77,23,241,131,197,153,57,183,153,57,119,178,173,243,242,6,93,172,234,6,47,143,158,63,107,141,97,114,90,21,5,94,52,121,85,214,201,107,92,98,146,47,92,144,55,121,121,175,230,46,49,33,105,93,93,55,128,185,92,86,101,112,129,224,142,233,228,85,217,228,77,142,107,88,127,254,172,76,151,184,190,75,23,216,130,42,175,243,155,150,164,84,164,231,207,190,80,184,201,62,193,55,48,68,243,178,193,228,26,16,14,209,156,81,90,157,95,253,7,164,103,64,7,7,7,232,184,110,151,203,148,172,78,196,120,95,254,233,39,107,132,232,99,226,2,11,8,111,34,244,16,100,129,140,145,164,126,124,96,200,118,215,94,21,249,2,229,114,63,238,118,38,176,239,137,218,246,123,82,221,97,66,143,237,16,189,103,152,108,195,222,142,189,93,72,41,212,54,125,73,38,175,219,60,67,243,12,125,65,55,184,57,66,53,253,183,230,244,247,113,153,113,17,196,88,200,243,22,55,183,85,54,88,152,216,150,201,61,41,67,68,125,98,1,65,217,204,93,74,210,37,162,138,51,219,195,236,200,246,78,66,55,115,124,192,32,53,34,193,77,75,202,250,36,192,207,149,233,248,64,2,83,108,126,49,232,151,188,40,248,99,36,102,56,251,233,145,127,86,19,126,126,206,241,201,211,59,45,210,26,206,238,44,93,205,203,211,180,0,160,148,60,88,141,237,13,5,117,238,183,11,48,238,180,200,255,74,175,10,252,187,86,194,5,149,39,36,14,2,43,59,45,170,18,83,132,56,164,162,166,82,128,225,214,13,105,23,77,69,28,205,16,124,2,28,162,41,168,221,122,35,148,53,135,50,115,196,101,2,50,148,196,4,212,120,22,90,79,230,217,17,3,144,211,157,128,26,128,35,156,165,13,238,0,165,75,18,104,117,185,186,195,157,68,213,186,2,63,191,254,128,241,159,125,8,18,130,163,204,107,65,131,78,2,100,7,222,107,220,80,160,12,156,122,187,44,255,157,22,45,62,190,170,170,226,36,218,19,248,127,204,107,65,98,111,234,72,243,174,93,94,97,50,130,50,120,47,78,152,227,255,193,9,8,186,35,111,245,213,231,6,126,113,230,48,23,179,83,38,233,33,106,110,243,58,10,66,36,22,53,165,15,181,156,129,101,38,180,183,61,137,175,65,25,156,185,135,46,55,184,165,91,182,109,184,195,217,137,115,235,113,206,131,157,255,48,38,134,101,140,97,214,79,153,154,200,101,190,196,236,225,1,155,64,195,246,160,237,112,107,86,202,139,14,99,167,236,120,36,195,216,116,221,106,139,236,175,151,47,53,102,228,57,131,81,204,71,236,18,12,28,185,238,97,235,141,170,189,198,72,73,17,214,86,241,220,47,155,56,9,207,190,119,151,198,132,100,212,143,125,73,139,149,123,216,193,220,206,53,196,222,42,30,126,89,236,141,164,47,227,112,168,196,159,130,177,154,3,241,8,56,207,98,62,178,194,157,30,136,85,17,219,232,143,154,209,129,76,61,235,53,35,106,25,35,177,30,8,81,238,148,75,73,69,28,103,70,81,12,120,111,127,146,1,175,77,135,61,212,1,187,105,83,232,158,31,148,140,154,196,55,102,164,6,219,160,86,108,74,68,133,10,228,215,40,162,87,202,242,19,244,221,76,57,225,228,109,206,3,55,91,145,224,19,142,157,92,224,198,136,237,52,172,55,120,47,70,138,146,200,22,214,8,23,53,30,134,91,182,69,33,209,216,255,78,112,161,105,140,159,120,22,136,221,40,82,253,56,146,28,245,163,105,19,0,44,61,232,71,98,192,10,72,152,33,135,237,202,18,6,21,0,31,42,242,39,84,200,244,106,88,93,251,49,45,30,161,12,232,152,218,162,34,232,148,15,121,213,247,232,90,160,147,118,160,34,232,134,13,172,160,79,254,92,160,70,232,132,74,140,36,93,251,216,13,56,14,44,39,240,11,169,150,189,88,20,128,131,94,86,189,128,151,149,40,2,32,81,253,220,47,60,133,248,27,167,174,110,13,187,57,1,179,238,104,92,110,18,222,215,192,132,150,221,238,232,188,107,107,118,160,33,227,83,218,237,249,210,196,143,107,219,78,211,169,112,196,245,230,30,61,44,239,91,161,246,105,194,242,160,224,210,29,237,76,61,231,17,207,156,233,71,167,186,10,56,244,167,31,240,178,2,176,203,106,67,56,164,122,65,133,166,191,99,130,226,192,176,24,108,11,108,14,137,161,2,194,55,244,125,195,199,196,200,89,68,222,127,187,78,49,88,30,34,107,17,121,138,229,17,15,10,24,10,202,221,93,57,125,24,118,123,120,92,231,77,82,217,212,123,83,112,61,221,183,152,151,97,185,221,59,241,187,47,50,121,207,3,77,22,59,210,186,253,153,93,5,179,167,170,75,59,139,210,254,192,52,50,26,218,71,104,143,54,120,240,65,54,41,137,253,218,228,69,61,52,61,213,70,97,247,218,55,107,189,195,110,164,182,91,216,209,175,53,38,128,82,242,119,92,168,181,134,82,83,29,160,153,3,54,90,9,73,213,0,166,112,91,147,59,57,68,14,31,103,184,85,172,37,249,71,72,18,36,35,54,16,33,233,98,113,139,151,233,63,91,76,86,232,101,150,189,44,10,75,49,184,83,175,35,31,24,215,247,42,106,213,247,9,199,229,0,18,73,134,8,190,204,103,141,170,44,177,90,193,1,48,90,227,37,94,43,90,134,145,250,222,106,33,139,93,177,148,239,53,110,222,167,4,2,141,14,126,17,91,88,232,96,40,100,255,8,202,15,164,224,54,105,207,196,219,166,163,25,137,9,240,54,45,211,27,12,238,77,85,140,29,91,225,178,200,69,43,240,3,95,10,12,2,139,180,192,230,23,155,18,7,162,40,173,220,105,1,205,11,237,159,197,108,176,15,79,247,127,34,101,129,244,128,119,203,39,135,236,196,146,87,203,59,59,38,203,243,180,221,4,16,54,26,43,115,16,147,68,80,229,181,75,76,104,117,200,153,24,50,215,177,206,78,51,213,65,242,49,242,155,178,34,56,3,4,121,47,188,187,245,219,239,138,88,61,207,120,65,87,195,153,25,28,32,245,160,175,166,35,184,221,217,9,138,56,222,52,207,166,80,17,189,36,36,93,73,53,124,148,155,182,142,195,184,110,160,218,99,61,212,86,180,102,252,171,250,116,90,181,144,60,207,208,139,160,190,72,244,228,12,223,53,183,123,211,228,156,100,152,252,99,117,134,235,69,244,99,151,185,52,216,129,124,97,64,66,226,9,53,96,77,49,168,52,201,41,193,128,192,103,63,228,205,237,123,154,222,98,10,18,241,201,211,106,9,41,111,94,87,37,179,194,87,247,109,90,152,154,30,7,46,102,186,3,134,158,183,16,109,63,208,68,167,31,24,81,5,155,78,141,219,206,20,71,253,253,66,215,245,187,112,84,232,24,189,169,110,114,216,231,57,56,109,246,169,193,69,67,242,69,3,167,44,184,132,56,108,189,229,121,253,14,76,153,237,153,222,229,46,88,232,83,101,189,183,76,245,237,58,110,46,196,92,128,210,14,162,54,91,233,136,208,247,223,27,198,156,188,44,193,252,116,19,241,17,244,226,93,213,200,77,208,26,135,19,158,24,44,165,59,176,188,129,82,139,181,233,67,237,164,117,106,57,98,67,19,108,199,48,77,46,242,242,166,192,231,228,12,95,167,109,209,68,211,33,145,127,251,186,215,234,63,163,254,244,210,171,108,233,5,242,186,182,191,132,181,152,4,43,216,186,1,11,224,69,127,192,246,44,47,111,198,214,204,107,227,71,64,98,170,52,79,191,197,182,194,155,135,54,67,63,162,159,209,79,232,208,93,218,162,165,31,124,83,179,77,223,224,42,173,177,81,113,251,223,152,108,108,28,116,73,16,188,2,63,110,26,241,24,116,255,244,54,205,75,158,232,216,146,57,111,135,66,88,54,66,28,76,161,28,162,211,157,30,189,7,101,218,64,103,59,27,89,43,104,167,87,105,162,223,57,103,181,103,116,134,2,50,118,145,252,159,104,71,204,147,102,119,11,166,21,203,88,207,104,136,16,250,38,175,27,193,232,139,77,112,173,35,132,75,148,198,9,157,112,170,200,96,209,103,177,193,147,230,72,196,125,42,106,137,63,123,218,9,82,133,116,182,139,206,167,219,188,192,40,10,82,10,203,24,16,50,132,45,25,76,70,8,217,71,103,237,199,45,75,144,177,70,104,150,217,238,55,119,200,4,99,127,67,205,199,72,200,109,213,239,238,222,202,97,175,93,57,206,126,239,196,69,239,197,214,105,65,80,40,181,125,100,109,93,195,116,138,104,218,105,95,208,244,170,39,186,21,152,220,84,52,209,40,155,133,94,119,247,149,78,136,167,96,223,42,168,13,21,212,255,103,89,228,234,203,99,114,13,87,38,223,42,128,96,5,48,226,237,232,168,84,126,119,46,86,150,8,131,81,158,196,175,154,20,135,57,87,163,53,245,200,93,41,199,181,122,47,59,120,92,247,90,99,22,75,198,201,236,116,105,43,2,10,252,67,156,89,224,67,28,101,60,26,10,153,229,147,252,190,216,82,108,128,125,136,78,126,211,207,113,250,57,78,87,213,103,204,182,206,168,119,105,127,27,221,165,9,65,94,131,162,234,15,224,187,245,216,8,26,18,165,87,181,3,90,237,125,214,168,142,12,8,196,232,59,77,120,164,242,35,239,113,155,118,192,174,44,224,41,212,185,47,139,53,181,203,58,254,19,35,165,173,55,168,237,88,61,189,174,8,107,21,161,156,101,121,240,115,60,67,63,193,239,15,63,40,181,89,229,184,200,144,238,106,200,236,218,206,165,3,138,187,30,237,27,61,51,239,208,21,228,222,240,87,162,67,215,164,90,158,41,79,58,184,175,209,84,6,210,64,156,167,246,190,91,232,172,225,237,54,233,173,118,183,242,8,99,225,71,197,52,63,162,56,208,127,233,212,109,209,124,144,4,185,235,3,245,230,164,236,47,111,93,29,55,147,28,75,78,37,158,175,238,19,185,6,114,40,166,144,127,179,237,191,120,60,155,48,159,191,217,199,215,98,31,230,243,56,91,145,225,213,179,153,129,169,138,109,40,90,65,191,2,219,81,59,248,122,108,200,211,95,187,89,204,159,135,191,248,177,191,6,28,240,14,40,100,174,27,245,37,240,117,53,207,10,252,249,154,55,159,29,201,30,245,67,140,0,87,231,155,140,190,143,84,204,206,132,238,87,60,160,69,99,52,186,98,111,223,222,231,44,195,90,15,188,185,193,91,117,129,237,78,179,206,215,145,193,143,184,214,255,5,215,223,10,95,247,63,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87e4846c-42e3-4483-baaf-bea01429675a"));
		}

		#endregion

	}

	#endregion

}
