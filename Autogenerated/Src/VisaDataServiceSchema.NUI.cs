﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: VisaDataServiceSchema

	/// <exclude/>
	public class VisaDataServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public VisaDataServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public VisaDataServiceSchema(VisaDataServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3ea38e5-fdc7-4c29-af2d-ef8695eef420");
			Name = "VisaDataService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5226f1bd-12e1-45ab-8b98-b5181a9b030e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,26,203,110,219,72,242,172,1,230,31,184,218,11,5,8,196,156,227,56,3,89,146,179,30,196,150,19,57,153,131,17,4,20,217,82,122,135,34,57,108,82,137,54,240,191,111,85,63,216,15,54,41,217,131,193,2,123,73,196,238,122,87,117,61,186,157,199,123,194,202,56,33,193,3,169,170,152,21,219,58,154,23,249,150,238,154,42,174,105,145,255,252,211,143,159,127,26,53,140,230,187,96,125,100,53,217,95,56,223,0,159,101,36,65,96,22,189,37,57,169,104,210,129,89,196,117,220,89,252,208,228,53,221,147,104,13,40,113,70,255,195,25,118,160,96,247,64,19,114,91,164,36,27,220,140,102,32,196,225,52,145,232,119,178,209,0,166,222,251,189,137,106,238,84,164,111,61,90,92,245,110,45,65,191,154,18,214,11,112,29,39,117,81,245,64,220,53,212,150,27,141,8,206,169,43,192,58,11,97,249,189,38,57,67,199,248,192,193,12,29,157,81,42,46,245,113,157,124,37,251,56,184,236,211,41,50,193,52,1,177,170,67,226,36,1,13,10,68,128,204,63,43,178,67,188,121,22,51,246,42,248,68,89,140,122,75,189,56,200,163,252,80,182,248,140,107,51,86,222,145,26,244,41,33,2,54,52,3,210,31,200,159,13,173,200,158,228,53,11,205,15,180,14,8,118,2,5,161,34,185,144,78,144,73,217,108,50,154,4,9,138,230,74,22,188,10,174,98,70,90,57,71,63,184,172,173,62,183,164,254,90,164,160,209,125,133,65,42,52,25,149,226,131,19,251,23,201,74,82,5,111,73,173,191,194,183,13,77,3,118,100,179,116,79,243,143,57,173,111,210,73,128,71,114,52,170,72,221,84,210,80,34,144,142,112,254,234,215,26,251,77,152,147,111,224,211,156,213,85,131,0,179,106,215,160,110,225,216,38,57,158,186,60,166,156,197,168,23,191,97,164,130,141,92,184,14,240,63,90,11,147,9,134,196,232,73,218,128,228,169,48,67,159,77,184,97,197,230,227,10,36,231,167,216,244,239,232,17,194,245,38,63,20,127,144,80,160,129,3,199,247,171,245,3,240,70,39,17,86,95,23,213,62,174,97,29,64,111,9,99,241,142,136,165,232,55,86,228,92,163,171,34,61,174,235,99,70,44,168,118,53,250,189,138,203,146,164,72,146,149,160,55,25,166,201,163,66,133,5,24,9,79,128,244,159,10,115,159,7,91,137,87,37,79,155,65,101,125,42,7,31,226,42,248,42,130,226,210,9,11,199,91,220,216,163,53,193,147,244,190,33,213,81,137,15,148,89,147,161,252,130,16,6,72,43,153,195,245,194,140,42,25,199,235,58,78,254,120,32,223,107,193,183,77,213,36,20,132,45,55,255,63,121,238,232,247,27,95,60,0,144,62,134,127,167,151,142,161,228,245,151,125,99,30,65,92,27,97,170,181,143,165,39,243,10,202,2,186,147,252,100,190,114,242,220,53,37,89,111,154,179,147,68,240,197,206,34,23,54,48,183,245,23,219,134,14,72,167,92,125,217,64,14,70,225,218,186,100,130,155,160,220,1,26,126,185,126,127,49,156,172,140,52,152,218,25,75,90,102,56,107,187,25,50,176,117,87,209,228,232,11,33,209,49,0,66,217,200,0,213,177,36,66,217,198,16,225,201,123,130,148,164,87,74,113,195,38,225,196,65,4,171,244,96,173,223,135,14,249,103,102,124,95,120,136,163,17,224,81,22,63,67,185,194,138,166,130,128,231,31,202,82,166,224,208,68,52,251,220,232,58,240,216,136,69,6,10,56,146,70,114,71,40,43,15,63,156,156,24,97,199,55,121,77,170,60,206,4,183,177,121,104,3,38,254,187,12,116,117,148,130,58,30,153,8,128,145,100,21,114,234,83,32,158,142,251,182,230,21,1,27,164,171,252,20,196,213,113,128,10,52,45,116,75,7,201,40,144,65,58,247,85,145,64,210,124,71,161,125,134,150,158,245,2,174,54,255,70,149,15,164,23,2,13,191,250,6,68,6,216,221,176,89,150,21,223,72,250,80,44,192,160,59,208,179,23,86,1,164,215,85,177,31,160,9,249,177,110,216,16,0,169,7,109,0,251,139,33,65,110,216,60,206,19,144,102,192,169,208,95,67,191,52,104,27,17,148,119,48,137,245,130,61,208,58,59,97,96,238,134,1,101,52,167,135,99,73,78,0,34,200,160,64,154,218,60,230,237,67,191,17,79,107,183,22,167,187,31,80,71,62,180,12,99,1,18,205,88,104,156,242,232,154,230,176,143,123,38,248,36,90,80,86,102,241,81,128,125,138,179,134,43,214,225,192,21,226,1,115,30,11,9,123,130,126,132,33,26,90,217,11,137,114,197,21,200,59,178,173,87,13,228,156,223,10,138,170,66,235,4,157,147,224,110,105,178,114,13,129,78,140,110,216,242,207,38,206,134,146,132,203,194,208,85,80,181,149,247,146,117,15,83,180,170,82,82,93,29,67,254,255,2,70,36,158,247,214,144,76,147,58,90,16,150,64,5,128,188,58,13,124,153,41,128,84,43,236,97,53,54,76,47,61,217,149,225,80,64,65,157,149,101,118,148,221,42,244,56,219,192,202,202,103,54,213,116,27,56,141,47,232,122,15,205,97,188,201,136,2,26,9,146,209,67,81,186,192,31,138,111,243,162,201,101,119,197,91,41,87,216,5,229,182,136,171,227,107,81,92,166,178,195,124,131,165,84,68,10,6,201,109,92,134,150,10,102,75,185,143,75,168,51,88,97,250,201,169,122,189,133,54,40,78,190,134,136,151,112,242,1,85,214,84,197,78,171,38,234,93,210,138,1,108,196,71,52,67,87,9,146,220,78,2,20,236,115,215,100,217,170,90,238,75,232,72,53,226,164,165,57,242,81,19,199,90,176,55,41,63,137,255,64,193,71,141,246,185,197,195,47,195,182,28,206,136,123,4,52,62,47,52,140,140,96,14,32,127,91,209,5,64,190,208,234,244,144,39,155,36,195,75,196,216,184,141,115,8,35,156,2,156,102,0,219,121,11,36,28,47,187,120,226,84,120,54,46,90,110,27,143,56,192,206,35,4,178,188,129,126,21,235,147,74,89,74,153,177,140,154,142,226,157,118,81,76,255,54,84,232,19,98,26,108,227,140,17,73,216,233,182,102,105,170,178,236,187,34,223,225,196,50,214,53,237,57,40,110,181,60,133,139,109,248,184,83,32,159,131,101,87,204,231,202,170,203,232,203,180,108,107,235,115,208,159,99,32,11,175,83,133,173,211,211,25,172,58,7,169,59,93,245,12,14,157,192,99,98,128,240,52,246,130,14,233,172,136,216,236,64,134,204,24,69,70,29,52,72,222,133,60,137,144,212,62,209,170,134,18,7,180,120,240,246,225,128,185,160,55,53,231,12,22,218,166,233,224,248,172,227,27,251,229,109,1,222,34,170,66,64,228,229,140,61,235,12,84,20,200,52,7,82,61,20,243,140,2,174,85,92,196,232,102,215,27,135,190,206,45,137,121,101,171,141,171,103,42,119,196,153,186,99,149,36,38,238,129,195,197,213,242,59,73,26,152,150,131,116,211,254,236,230,198,101,206,154,138,44,174,244,82,168,235,138,164,117,131,22,250,64,98,232,52,130,84,255,188,116,172,21,9,54,68,108,135,154,173,93,168,164,62,209,187,34,78,67,77,110,98,149,167,39,195,48,57,24,24,170,141,186,55,3,190,220,141,237,237,186,190,174,49,172,165,25,77,135,124,36,185,122,28,92,240,132,245,6,249,111,233,206,203,84,141,189,8,16,154,67,251,57,44,123,238,161,196,15,17,2,62,16,105,72,104,131,24,47,217,142,113,166,122,123,182,221,2,54,73,125,96,17,239,161,52,240,92,41,41,180,21,46,176,14,153,18,205,119,182,160,206,213,52,233,59,98,188,109,81,11,161,115,123,126,158,154,57,244,63,126,205,126,241,232,128,208,134,6,231,95,137,20,53,39,171,148,147,159,193,65,38,42,28,198,95,11,97,121,39,41,126,50,156,49,0,247,64,33,136,89,56,144,50,84,68,149,113,5,145,0,227,0,235,239,48,21,172,180,195,143,160,251,98,224,94,85,61,77,91,216,206,235,128,123,97,245,100,122,248,174,168,97,50,72,248,205,241,199,26,223,97,240,148,229,222,85,33,176,23,67,101,101,110,38,149,30,249,117,37,6,62,71,245,161,201,121,6,236,105,82,85,6,157,183,248,161,111,27,43,124,132,135,174,163,162,41,140,242,25,243,56,76,106,100,194,41,69,176,5,215,242,139,35,19,188,9,126,105,179,153,112,210,227,103,233,173,123,244,43,18,252,97,186,88,26,89,13,9,170,171,215,150,193,89,65,179,209,169,146,39,63,92,87,141,100,159,5,121,42,50,1,181,212,83,75,52,149,98,213,117,90,41,141,176,86,215,106,97,120,227,179,242,196,18,99,98,62,98,200,235,183,150,50,218,204,33,251,15,113,34,181,98,35,159,31,176,206,59,152,45,81,57,177,60,225,63,70,117,176,166,86,155,154,157,165,220,131,44,5,3,53,110,99,154,75,21,176,237,252,213,121,91,144,128,251,22,74,102,151,243,99,171,55,77,88,147,99,16,250,61,66,253,218,185,179,36,115,90,71,224,107,19,146,179,224,242,123,9,105,156,87,47,13,108,204,155,66,249,174,195,28,98,179,60,13,93,150,238,189,133,168,120,209,189,58,7,234,33,197,174,242,35,158,244,5,172,22,46,32,250,231,101,208,161,228,178,86,36,53,150,24,164,249,28,234,54,213,18,214,209,72,246,227,154,130,162,105,121,222,252,48,170,204,104,244,171,99,110,185,252,202,192,136,32,73,23,48,134,103,110,140,187,87,49,86,104,107,252,23,63,231,202,199,145,190,218,172,222,34,207,186,187,241,29,7,251,16,241,184,209,217,179,107,177,54,168,164,134,221,254,192,52,131,183,41,199,39,69,253,66,161,89,72,204,206,45,149,141,61,117,117,179,186,28,115,34,240,181,234,79,103,27,85,62,96,158,206,39,182,1,173,247,198,255,149,9,159,103,140,83,79,155,252,219,126,219,180,163,77,128,60,154,127,94,51,13,218,63,74,218,100,164,243,183,31,78,180,58,79,160,144,39,75,232,118,65,90,231,47,27,144,195,45,217,111,32,137,200,52,57,166,237,221,227,216,122,146,222,20,69,22,232,139,73,105,242,29,169,47,32,35,91,167,209,71,181,146,151,148,54,77,10,237,131,186,190,28,32,248,2,123,130,217,82,202,91,200,140,95,129,191,192,164,29,18,66,194,151,218,85,223,37,142,125,79,253,122,32,122,166,101,15,40,155,77,82,116,56,1,151,250,37,212,176,135,236,58,234,147,218,234,33,41,77,115,242,89,31,22,255,11,201,208,227,42,229,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3ea38e5-fdc7-4c29-af2d-ef8695eef420"));
		}

		#endregion

	}

	#endregion

}
