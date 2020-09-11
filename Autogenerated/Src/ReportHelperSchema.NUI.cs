﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportHelperSchema

	/// <exclude/>
	public class ReportHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportHelperSchema(ReportHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd8aa451-b26b-4be4-acbc-ba08ada173c4");
			Name = "ReportHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,87,91,111,219,54,20,126,118,129,254,7,86,121,168,188,185,74,80,20,235,218,212,41,18,219,73,189,54,78,22,59,237,67,22,4,178,116,108,171,149,41,149,164,220,120,69,255,251,14,69,202,34,37,217,217,134,97,47,78,68,158,251,249,206,133,212,95,2,79,253,0,200,4,24,243,121,50,19,94,47,161,179,104,158,49,95,68,9,245,174,32,77,152,24,3,91,69,1,60,126,244,253,241,163,86,198,35,58,39,227,53,23,176,60,172,124,123,103,113,50,245,227,232,207,156,187,118,59,188,168,29,125,136,232,215,218,161,214,119,158,132,16,123,159,96,90,35,152,192,189,40,15,77,227,25,108,59,183,61,219,74,53,160,34,18,17,240,102,130,229,18,131,242,27,111,230,31,101,145,109,250,224,94,0,229,168,173,81,218,245,80,250,134,86,9,150,196,220,187,22,81,188,85,51,18,122,239,132,72,189,227,41,23,204,15,132,45,84,94,41,254,53,233,22,65,42,120,244,133,17,68,136,33,16,191,103,192,36,245,14,251,251,190,240,115,251,80,161,103,112,109,13,222,41,18,38,76,249,128,52,105,54,141,163,128,4,177,207,57,81,80,122,7,113,10,12,239,190,231,20,173,61,6,115,244,133,156,70,16,135,252,53,185,100,209,202,23,160,46,83,245,65,24,248,97,66,227,53,25,74,127,164,69,152,255,227,32,0,206,19,70,238,22,245,195,67,91,0,134,226,10,145,142,49,131,75,150,104,190,198,195,238,17,233,73,115,149,39,107,239,12,196,155,38,194,35,183,173,117,236,1,13,149,19,182,71,104,17,166,42,147,98,164,95,121,40,180,85,42,44,102,64,220,182,188,104,189,38,98,17,113,215,240,210,107,240,184,77,100,29,182,126,108,151,214,24,167,134,48,105,73,173,166,16,34,52,154,3,187,209,188,205,115,12,18,26,33,161,188,37,159,215,28,24,202,165,144,227,152,220,101,214,119,174,98,127,127,159,188,225,217,114,233,179,245,81,113,32,249,72,176,33,244,54,132,251,38,165,14,72,69,73,229,83,249,61,7,161,255,107,25,17,51,253,198,40,52,5,71,226,98,136,249,245,105,0,57,18,164,8,6,34,99,53,119,200,219,183,196,173,158,117,137,107,27,212,54,148,96,169,113,217,53,110,28,155,198,185,213,154,126,228,191,28,141,71,184,214,69,175,252,56,131,191,147,168,30,22,150,0,133,28,11,76,171,136,137,204,143,9,2,88,86,185,73,231,234,51,144,125,114,61,14,22,176,244,175,135,97,167,160,101,106,98,212,206,177,35,165,49,74,193,35,21,173,13,125,144,176,176,38,224,210,103,56,156,4,48,222,33,211,36,137,101,218,87,8,170,33,189,236,159,22,176,213,28,95,64,246,49,245,225,157,38,108,233,11,215,81,214,246,124,52,228,61,172,239,190,31,252,112,58,228,44,139,66,111,4,223,228,95,183,173,163,169,40,101,175,35,161,252,233,18,154,197,177,186,203,85,71,188,15,171,193,125,202,48,45,165,162,33,31,33,217,5,27,44,83,177,118,75,247,180,212,149,207,138,88,168,150,42,229,194,55,98,77,212,6,240,25,229,215,4,60,149,127,165,34,154,17,215,180,45,15,203,30,158,62,25,13,38,227,201,241,168,127,124,213,127,126,119,64,176,68,38,23,253,11,210,187,58,127,246,226,151,151,175,158,43,173,218,91,203,74,4,54,5,28,145,80,138,213,121,175,37,188,154,105,37,180,85,38,180,154,73,25,153,61,136,57,40,74,177,96,201,183,60,38,163,68,140,179,84,18,67,56,184,15,32,149,64,118,29,35,234,74,20,39,62,3,66,19,65,120,65,238,57,74,42,13,163,153,138,13,145,26,138,192,238,116,241,124,252,9,45,213,238,25,248,52,48,105,161,206,44,62,187,50,139,138,149,32,186,65,56,222,162,78,169,90,113,232,190,128,231,102,81,86,74,109,44,176,200,150,4,251,138,50,232,52,138,193,45,1,94,64,62,153,126,70,149,218,161,139,233,103,84,244,128,41,135,15,216,139,59,222,50,89,129,43,149,84,161,43,251,84,89,30,237,141,214,67,179,252,152,174,180,84,183,31,99,231,240,174,89,124,233,139,197,128,6,184,80,184,138,210,211,164,109,242,51,113,60,7,127,245,185,42,93,75,118,32,209,79,197,100,157,194,38,141,154,142,116,187,196,73,195,153,163,50,253,150,56,126,154,98,68,243,245,110,31,47,14,73,176,240,25,118,201,238,245,228,244,217,175,154,238,181,77,151,4,2,196,51,158,7,191,202,208,100,73,63,194,69,128,71,218,85,199,23,2,59,204,18,47,14,201,12,51,70,17,234,63,41,246,167,79,75,215,138,224,160,195,78,173,61,168,196,171,238,112,142,185,96,107,117,84,132,43,15,189,226,106,218,68,188,99,76,229,156,74,188,20,119,61,101,171,251,240,228,234,152,17,238,88,22,121,31,128,206,197,162,211,224,121,219,194,181,201,180,125,234,52,247,165,188,35,61,127,241,242,149,61,152,176,236,53,230,118,141,37,244,164,199,87,133,179,250,80,150,93,81,44,21,208,247,79,198,16,100,12,113,57,160,243,136,226,139,96,1,193,151,158,79,7,247,120,46,224,34,5,245,56,112,157,252,80,218,112,198,162,208,49,234,130,91,187,179,124,9,120,125,64,53,145,124,245,192,27,99,73,62,114,195,50,113,3,163,121,42,102,168,157,116,77,225,222,73,22,197,225,128,127,173,238,9,166,188,94,18,199,122,234,67,245,160,91,215,32,83,95,101,108,22,47,235,128,4,124,213,135,56,90,70,216,187,213,171,98,12,66,96,140,185,20,244,81,46,25,21,238,14,113,122,227,143,27,38,167,237,77,146,113,158,22,183,125,115,112,91,70,49,200,211,38,59,107,46,90,34,191,103,28,185,166,234,182,197,134,239,69,144,67,216,148,224,217,64,168,249,221,169,69,199,76,104,110,95,30,237,141,45,99,243,172,88,239,102,248,192,193,90,39,5,208,180,49,36,162,27,187,10,220,181,44,161,222,113,154,98,41,184,154,170,216,22,155,104,228,189,107,205,25,93,99,54,113,25,213,29,3,101,83,36,106,216,41,56,99,151,192,128,225,66,228,22,182,90,10,54,219,83,133,122,199,250,180,83,249,24,125,50,69,241,166,42,181,182,184,173,230,62,52,198,138,177,107,99,193,40,193,127,56,133,77,3,32,148,26,154,54,223,17,246,251,205,230,58,83,62,234,134,251,190,28,218,255,113,31,210,234,54,93,39,44,87,172,221,235,64,205,192,219,42,148,90,230,0,34,112,111,13,168,32,127,6,96,116,245,124,170,22,127,67,96,26,76,108,255,203,177,218,253,195,145,3,181,170,36,95,34,176,180,254,112,26,231,181,222,28,28,233,240,62,146,57,255,207,32,53,35,247,240,32,181,168,199,0,95,220,131,14,145,127,47,88,132,0,241,78,112,42,86,134,174,201,178,3,207,86,58,119,231,143,100,149,116,110,131,187,245,124,107,204,176,134,189,218,113,120,22,139,166,237,166,130,3,89,179,33,92,250,115,216,54,107,170,246,201,89,83,240,88,163,166,24,145,184,115,226,247,144,206,146,155,91,116,67,125,202,18,41,174,212,64,212,231,5,95,254,228,155,37,25,13,243,25,170,111,189,99,186,118,193,16,41,159,222,230,183,151,131,177,219,53,61,105,151,239,180,39,185,196,205,128,40,223,62,170,227,26,175,30,131,223,177,70,65,97,169,82,11,91,252,112,235,250,167,107,1,24,1,212,22,203,129,165,189,146,239,32,113,130,87,220,29,80,196,75,66,101,189,201,246,110,76,41,205,154,202,140,77,99,155,247,82,31,186,54,237,52,155,53,168,216,209,9,20,68,188,79,216,16,193,45,52,117,8,150,64,241,161,43,168,137,30,181,229,164,248,119,7,149,118,61,167,212,255,87,169,245,42,43,153,118,44,177,250,157,137,55,249,61,254,252,5,176,189,61,115,68,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd8aa451-b26b-4be4-acbc-ba08ada173c4"));
		}

		#endregion

	}

	#endregion

}
