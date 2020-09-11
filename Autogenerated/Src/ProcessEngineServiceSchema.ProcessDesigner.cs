﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessEngineServiceSchema

	/// <exclude/>
	public class ProcessEngineServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessEngineServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessEngineServiceSchema(ProcessEngineServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7f14723-039c-438b-b43a-9b369264a887");
			Name = "ProcessEngineService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("96d1b784-3b9b-4dbf-9322-c475322e3eef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,91,111,219,54,20,126,118,129,254,7,206,27,90,25,240,148,237,53,137,3,196,137,51,120,104,210,32,151,229,33,8,6,90,58,182,181,232,86,146,114,234,5,249,239,59,188,136,18,105,217,105,183,1,197,246,146,88,228,185,126,135,231,66,230,52,3,94,210,8,200,13,48,70,121,49,23,225,73,145,207,147,69,197,168,72,138,252,237,155,231,183,111,122,21,79,242,5,185,94,115,1,217,129,247,141,244,105,10,145,36,230,225,47,144,3,75,162,13,154,83,42,232,198,226,85,149,139,36,131,240,26,89,104,154,252,169,20,110,80,225,238,42,137,224,188,136,33,221,185,25,222,193,108,55,193,49,90,185,242,180,44,210,98,70,211,253,253,147,34,203,138,60,252,80,44,22,184,220,236,183,113,145,20,221,59,12,182,173,135,167,227,173,91,151,172,136,128,243,174,253,139,42,113,109,151,8,98,100,4,163,145,232,98,64,231,27,11,113,255,123,6,11,116,148,156,164,148,243,125,98,84,77,114,244,14,140,96,69,183,183,183,71,14,121,149,101,148,173,143,204,247,205,18,200,19,204,8,215,116,68,44,169,32,37,43,86,73,12,156,208,72,74,34,162,192,117,64,94,0,18,49,152,143,250,142,142,62,217,59,34,25,136,101,17,243,176,214,179,215,82,116,111,172,168,157,122,144,107,199,188,188,0,129,126,148,24,166,89,146,38,98,125,5,159,170,132,65,6,185,224,65,251,67,226,66,70,228,21,22,73,21,154,133,120,32,149,148,213,44,77,34,18,73,96,58,113,33,251,100,76,121,131,82,239,89,33,101,33,61,215,94,73,80,229,113,210,56,246,74,253,65,184,64,59,34,194,128,198,69,158,174,201,20,143,20,249,61,197,63,35,130,63,207,105,78,23,192,48,83,132,60,107,192,130,26,183,254,224,160,83,210,105,162,146,11,97,59,228,130,97,212,135,164,152,253,129,25,119,68,80,200,117,180,132,140,94,82,134,153,44,128,253,70,211,10,120,112,139,161,67,96,115,157,151,164,114,62,135,82,73,175,39,125,52,170,181,144,73,170,32,35,51,233,124,123,101,72,166,147,188,202,128,209,89,10,135,18,234,20,117,89,157,71,36,242,151,248,128,60,43,45,43,202,8,239,50,17,209,200,225,105,135,115,129,132,195,145,80,219,55,34,193,212,24,222,40,196,160,208,105,62,47,6,27,214,107,49,142,167,150,173,169,93,174,142,70,46,106,115,118,194,179,130,69,128,192,55,36,181,165,115,204,105,26,45,73,176,129,16,41,237,175,36,223,129,214,22,43,85,252,110,40,127,108,86,70,219,236,13,207,146,60,30,175,47,240,51,176,90,195,71,88,27,35,123,201,156,4,29,242,48,28,85,154,90,67,122,17,166,101,146,87,96,184,94,244,63,25,140,24,43,81,219,16,25,198,230,187,230,87,81,198,221,198,134,149,92,49,210,140,84,191,84,162,100,197,119,179,46,65,233,105,190,70,155,32,184,244,45,247,92,206,132,19,36,132,27,108,53,174,130,119,239,92,95,66,99,179,15,69,39,17,233,75,162,190,11,143,62,186,141,207,53,173,43,1,15,143,218,8,188,180,124,205,195,58,130,157,249,116,191,201,44,207,192,67,59,4,138,82,11,209,6,51,16,21,203,187,19,84,209,189,152,202,7,121,172,139,223,182,74,168,106,170,222,244,59,138,90,184,82,154,56,30,127,204,146,76,245,96,221,86,24,148,12,184,172,212,132,98,195,17,164,152,171,190,82,234,76,32,184,195,214,164,44,18,164,8,173,248,61,95,254,161,114,146,228,232,193,168,143,60,216,5,116,18,221,78,227,254,209,109,158,124,194,64,96,251,194,157,121,130,199,212,104,209,148,6,128,240,112,79,73,217,37,84,74,155,110,17,227,240,223,127,44,65,143,80,237,6,215,187,199,62,61,205,87,197,35,4,26,60,121,146,46,63,94,223,244,135,100,92,196,235,107,177,78,229,137,65,178,115,116,31,91,133,93,13,239,24,45,75,136,135,68,182,51,224,226,76,33,233,16,235,165,240,87,94,87,249,43,28,239,112,48,131,221,180,170,47,214,141,241,67,194,197,161,230,139,96,34,225,191,84,232,171,118,99,251,165,93,150,71,52,208,181,155,120,192,15,137,179,62,141,235,156,242,232,194,147,37,68,143,199,108,81,201,90,118,129,121,245,145,77,178,82,172,131,141,80,154,28,168,5,190,202,217,176,236,108,137,8,140,187,223,244,30,102,16,52,149,110,43,58,237,126,5,118,253,26,100,127,33,35,157,185,129,254,28,72,65,250,167,87,3,6,166,228,200,161,186,202,242,160,143,99,108,13,185,174,244,18,110,233,148,38,12,207,88,145,5,253,198,14,187,113,183,4,6,106,199,197,47,156,242,201,167,138,166,129,214,16,218,172,15,164,81,191,84,73,28,120,152,15,6,181,204,227,60,174,37,126,149,168,13,25,83,174,70,113,216,37,67,176,10,6,6,211,169,51,166,213,181,193,124,141,188,88,134,46,181,150,160,199,229,224,116,60,249,12,81,37,10,108,99,51,251,115,67,194,36,231,21,131,211,113,179,20,12,108,63,48,162,166,50,18,87,56,229,1,83,195,158,234,133,126,224,67,173,3,52,93,208,232,108,196,245,78,199,178,184,163,170,21,48,217,65,227,153,251,189,97,157,199,96,186,66,239,105,153,96,233,8,180,45,161,212,216,50,186,215,147,241,32,160,15,209,84,150,29,79,15,138,213,157,166,80,145,211,98,238,127,122,168,187,142,153,196,186,206,163,73,141,206,179,234,31,112,43,77,54,234,239,58,197,133,103,32,162,165,60,217,167,227,192,90,220,246,197,159,78,108,3,54,110,54,98,149,167,221,90,174,91,68,86,142,89,177,237,103,228,30,54,53,93,25,154,241,26,147,35,104,171,10,111,138,107,85,240,130,193,144,168,243,235,120,107,101,250,3,198,46,127,36,232,134,81,229,140,108,87,56,0,95,186,75,3,67,162,236,59,75,139,39,227,168,182,177,193,208,202,223,58,252,251,163,182,167,59,180,87,14,67,18,52,50,235,74,25,30,199,177,42,1,29,101,178,113,57,145,145,177,150,181,161,107,80,161,165,41,206,238,8,126,162,215,45,86,214,132,151,246,52,230,140,56,181,109,237,169,166,115,80,169,103,119,156,60,84,170,74,253,254,72,98,204,248,194,105,68,178,77,210,221,115,136,47,122,231,36,98,231,57,222,63,106,13,254,255,143,233,3,15,137,141,193,164,142,64,160,178,218,2,57,212,93,184,227,34,218,64,83,103,215,223,105,251,95,215,110,58,186,141,28,89,159,95,185,101,111,73,52,83,103,54,210,204,58,95,31,246,29,207,2,242,152,216,91,246,214,55,2,255,246,193,221,43,127,11,202,3,231,114,122,10,60,98,73,169,122,104,243,211,119,192,139,33,38,118,43,124,141,129,181,108,147,166,141,192,240,142,38,146,237,214,92,107,248,73,81,213,119,249,23,18,81,236,16,129,255,54,23,78,5,100,23,5,30,205,42,143,39,159,35,80,101,194,214,89,249,8,131,98,89,30,252,208,63,22,72,90,10,249,138,85,95,199,187,18,145,60,37,98,73,176,137,188,127,182,230,191,188,31,146,89,37,244,245,197,210,81,78,242,66,144,185,84,29,246,61,183,126,252,185,117,235,218,85,125,204,184,192,191,101,189,249,239,214,142,85,129,85,194,64,232,54,124,175,128,124,211,226,224,230,73,167,185,186,109,123,41,255,202,93,188,253,64,236,238,152,39,224,142,110,172,233,238,219,172,109,60,245,19,105,7,31,49,47,162,86,5,154,143,135,70,36,224,189,5,104,217,231,144,205,128,61,104,239,181,104,115,49,196,160,60,147,5,136,3,121,245,63,32,47,95,198,85,207,5,93,172,62,60,175,160,102,176,217,104,37,95,132,204,230,59,223,191,133,203,35,172,191,10,24,243,240,164,158,216,254,17,44,238,183,166,114,23,113,237,47,4,125,59,66,54,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7f14723-039c-438b-b43a-9b369264a887"));
		}

		#endregion

	}

	#endregion

}

