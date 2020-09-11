﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnServiceSchema

	/// <exclude/>
	public class EsnServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnServiceSchema(EsnServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0efab49d-c4be-440d-91a9-a715a5813ec3");
			Name = "EsnService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,91,79,227,58,16,126,238,74,251,31,172,238,75,43,85,233,251,66,43,177,229,162,30,45,11,162,32,30,16,58,10,201,148,70,228,210,99,59,112,122,16,255,125,199,142,157,56,105,210,75,160,208,229,244,101,55,177,61,51,159,61,223,231,113,92,66,59,0,54,181,29,32,151,64,169,205,162,49,183,6,81,56,246,238,99,106,115,47,10,173,163,209,175,175,95,158,191,126,105,196,204,11,239,201,104,198,56,4,123,133,119,180,241,125,112,132,1,179,78,32,4,234,57,115,99,46,226,144,123,1,88,35,236,181,125,239,63,233,127,110,20,246,62,122,14,156,70,46,248,11,59,173,3,140,247,184,220,137,117,13,119,115,3,176,13,7,49,134,198,35,110,115,200,6,12,34,10,214,177,237,240,136,122,192,178,246,108,125,132,237,32,10,2,92,28,21,231,34,138,57,142,201,6,103,67,176,13,91,191,81,184,199,80,132,12,124,155,177,239,228,136,133,63,189,7,96,218,30,115,128,43,7,114,236,205,161,205,109,204,1,167,8,226,22,27,166,241,157,239,57,196,17,166,85,150,228,59,201,165,109,206,113,67,164,48,197,129,99,25,167,177,152,36,162,57,151,1,100,112,29,172,34,76,171,77,158,201,203,74,35,143,254,117,96,42,160,16,208,79,109,68,121,103,99,159,209,146,186,251,6,161,155,160,83,239,10,234,57,141,166,64,57,230,34,15,84,46,211,41,4,119,64,91,191,144,197,164,71,154,190,0,210,108,223,26,240,134,71,97,28,0,181,239,124,216,87,80,15,47,207,250,41,108,4,112,15,124,143,48,241,79,9,148,70,210,86,64,87,146,207,243,136,241,83,100,148,125,191,102,58,75,12,55,144,205,146,40,229,201,44,27,248,17,185,28,186,249,68,158,196,158,75,134,238,155,229,75,205,177,158,4,43,140,87,204,91,182,216,21,126,202,51,83,53,120,221,236,148,173,182,225,126,161,126,46,192,118,213,64,45,35,109,87,146,153,85,115,161,102,36,187,187,221,46,217,103,113,16,216,116,214,87,239,200,155,71,207,197,16,7,231,67,50,142,40,121,138,232,3,121,242,248,132,64,200,129,78,169,135,139,207,34,7,235,10,9,129,139,110,75,251,234,26,206,110,14,97,108,199,62,55,246,109,16,179,189,25,177,233,124,91,210,96,242,224,230,128,77,127,1,199,173,125,138,9,190,243,124,143,207,46,224,159,216,163,16,32,18,214,50,95,68,245,193,181,93,98,34,70,89,170,193,109,151,145,77,225,192,148,254,192,148,170,183,14,25,138,92,156,133,254,204,172,99,197,173,129,28,123,224,187,66,110,84,212,74,80,156,74,94,48,185,44,28,200,21,36,127,131,126,220,91,67,195,101,78,165,80,79,112,198,49,165,232,240,138,1,69,217,246,250,68,60,225,98,134,201,57,193,50,250,173,161,187,87,137,44,123,146,51,107,32,201,212,83,195,27,147,86,6,156,244,122,36,140,125,191,173,187,27,143,54,37,142,236,75,10,250,12,211,33,89,167,94,241,168,194,247,179,80,170,181,223,106,239,41,7,166,243,188,39,107,64,1,129,166,182,173,252,236,180,135,151,228,63,10,60,166,97,126,145,117,239,146,61,243,20,248,36,114,11,27,102,81,36,178,1,39,67,98,68,65,100,25,148,58,9,148,54,173,212,168,91,180,218,159,218,212,14,72,136,27,65,175,169,198,15,93,214,236,43,93,19,204,166,147,158,238,172,253,174,28,159,153,39,83,99,253,33,214,32,59,68,154,70,99,132,6,64,28,10,227,94,179,226,120,208,36,221,62,250,210,198,114,91,58,67,94,201,109,211,84,92,227,6,207,82,195,240,49,122,128,86,178,20,98,187,58,63,27,93,54,59,228,71,228,206,70,124,230,11,153,225,48,133,56,109,181,174,169,61,157,130,43,212,5,140,119,146,92,168,183,227,136,6,54,207,25,38,77,214,95,44,10,59,68,35,93,60,46,183,87,86,157,205,48,49,202,82,118,163,185,32,75,235,167,199,248,190,80,75,159,100,235,174,201,91,229,139,2,195,253,43,161,15,71,66,43,170,11,166,39,105,239,101,130,177,42,2,23,197,217,49,227,239,105,198,138,56,232,45,132,167,202,137,105,157,165,104,113,188,68,161,200,175,88,78,28,155,59,19,98,22,170,84,163,171,196,105,65,219,208,139,22,147,177,18,47,75,84,145,241,87,176,83,104,132,145,167,73,36,177,186,122,242,107,107,196,148,200,78,23,245,116,113,61,137,68,151,62,83,180,100,241,72,87,248,173,197,80,140,150,5,250,108,172,23,14,63,134,216,139,14,192,159,146,221,139,38,44,243,176,152,219,130,172,57,58,44,242,167,79,38,6,217,51,130,231,98,85,111,241,237,117,249,185,16,208,107,72,122,1,65,244,8,217,153,101,71,212,143,35,234,85,248,158,84,45,68,251,19,200,154,156,35,2,241,205,102,158,39,140,83,246,170,244,101,206,4,2,251,74,208,119,36,31,181,3,130,109,243,52,54,77,49,56,126,62,10,203,35,249,148,90,150,241,127,35,135,150,138,75,136,79,41,152,5,23,61,226,219,123,144,176,129,37,106,73,179,218,73,190,128,117,170,212,235,114,49,45,186,14,154,147,82,98,105,153,215,47,230,89,39,7,207,64,150,129,170,175,176,5,56,95,171,175,157,144,254,151,66,202,85,157,45,208,145,240,114,115,75,158,11,130,210,48,151,232,137,212,249,0,216,148,162,156,73,28,62,164,215,64,178,90,37,152,183,89,99,84,92,108,202,21,99,205,190,88,121,241,147,90,148,52,20,84,100,228,69,91,36,2,218,233,177,190,30,147,116,173,166,202,244,100,55,159,9,98,228,241,221,170,94,30,123,169,84,77,88,219,45,85,249,101,52,6,112,87,85,235,78,57,31,171,156,99,204,85,107,123,196,32,224,104,41,108,33,235,197,79,205,210,127,189,139,170,236,4,230,242,168,192,201,107,234,113,253,125,121,120,121,86,151,218,37,63,134,127,86,90,151,253,25,130,209,214,154,95,84,157,182,69,116,46,253,179,131,42,42,139,159,9,13,6,155,209,117,168,26,204,45,131,240,38,172,85,183,1,111,124,107,101,154,168,8,59,162,191,7,209,213,247,114,225,238,171,67,74,136,175,242,178,73,226,107,52,6,16,29,117,11,52,112,228,122,107,127,173,215,224,255,59,109,244,187,155,96,243,28,35,114,91,126,15,92,170,133,101,69,160,246,29,177,137,195,128,80,183,18,108,236,98,88,106,97,205,90,160,134,11,45,40,161,111,75,45,216,105,161,168,133,92,93,72,19,87,171,46,188,74,11,26,135,1,161,110,69,216,152,22,14,193,7,190,246,15,207,127,238,61,238,78,45,166,90,146,236,191,237,109,110,109,201,228,193,188,241,111,32,155,22,208,154,229,228,35,4,180,98,9,219,9,104,109,1,229,10,206,18,1,165,89,216,148,128,52,152,82,1,101,209,63,66,64,75,254,236,31,91,126,3,55,241,46,89,222,52,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0efab49d-c4be-440d-91a9-a715a5813ec3"));
		}

		#endregion

	}

	#endregion

}

