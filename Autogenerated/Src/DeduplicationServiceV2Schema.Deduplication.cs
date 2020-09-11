﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationServiceV2Schema

	/// <exclude/>
	public class DeduplicationServiceV2Schema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationServiceV2Schema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationServiceV2Schema(DeduplicationServiceV2Schema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92db89de-9c23-42a4-871c-4987414f2c40");
			Name = "DeduplicationServiceV2";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,88,235,111,19,71,16,255,108,36,254,135,109,144,144,221,134,51,9,80,137,56,9,162,33,161,169,18,130,114,17,124,64,21,90,223,141,237,43,247,98,119,207,96,66,254,247,206,62,238,233,61,251,234,148,138,182,95,156,236,222,204,111,102,118,158,187,49,141,128,167,212,3,114,5,140,81,158,76,132,115,148,196,147,96,154,49,42,130,36,118,94,128,159,165,97,224,169,213,221,59,215,119,239,244,50,30,196,83,226,46,184,128,104,212,88,35,119,24,130,39,137,185,243,18,98,96,129,183,68,115,153,197,34,136,192,113,241,43,13,131,47,10,123,137,10,191,206,3,15,206,19,31,194,149,31,157,231,40,111,190,30,196,121,11,227,37,2,220,67,34,206,145,217,21,84,64,73,48,13,147,49,13,247,246,142,146,40,194,131,56,75,166,83,220,46,191,191,130,79,2,173,148,71,246,27,175,138,174,30,37,3,231,132,122,34,97,1,112,164,64,154,123,12,166,40,140,28,133,148,243,61,114,18,196,254,11,115,194,192,47,98,151,206,225,18,62,102,192,133,34,31,14,135,100,159,103,81,68,217,226,208,172,37,15,241,11,38,130,104,28,217,8,211,124,196,167,130,58,57,239,176,194,252,238,5,126,65,255,10,134,58,253,142,27,105,54,70,16,226,73,93,26,170,20,74,244,174,149,34,133,226,175,89,146,2,19,104,208,30,121,173,248,245,119,5,126,14,209,24,88,255,21,198,21,57,32,91,220,155,65,68,229,106,107,155,156,42,204,128,129,143,159,38,52,228,48,144,58,228,74,112,193,148,95,10,22,114,77,166,32,70,132,203,159,155,118,33,19,150,68,235,225,131,88,60,35,39,72,218,21,150,7,95,58,104,173,96,93,36,237,10,27,201,80,92,143,123,22,112,177,95,122,3,211,42,139,98,9,119,72,84,48,119,21,151,178,64,122,95,243,191,161,97,214,193,166,151,89,224,63,67,63,55,57,187,202,244,20,11,239,104,164,246,251,33,209,130,184,77,200,61,136,125,29,125,245,80,60,7,49,75,252,70,28,26,236,100,142,105,24,248,64,198,73,18,146,227,143,25,74,239,39,227,63,176,56,17,252,51,32,178,148,245,122,193,132,200,93,114,112,64,226,44,12,243,237,30,3,145,177,88,235,60,82,91,55,234,119,78,25,153,216,18,101,23,45,236,91,83,104,128,248,163,66,152,246,158,17,71,190,126,109,65,115,106,116,107,213,146,200,249,1,174,199,110,80,118,50,218,135,9,205,66,225,42,111,97,77,76,41,3,134,54,171,147,13,196,34,223,202,253,137,157,67,49,140,10,4,6,28,215,200,98,133,114,140,139,202,252,223,110,83,191,36,25,148,232,42,175,92,144,248,49,124,34,191,82,62,195,149,61,133,180,19,44,204,187,157,184,87,121,204,128,22,182,154,127,238,223,47,100,96,187,17,198,214,66,108,59,151,37,11,209,107,45,26,44,19,151,38,234,164,92,62,32,227,174,60,122,6,22,142,230,169,228,44,171,163,171,176,73,197,84,105,81,1,91,57,136,82,148,230,186,177,167,50,22,91,242,18,132,212,227,8,143,174,159,7,174,212,118,102,54,81,215,157,157,199,63,63,124,130,191,15,181,10,149,79,197,191,63,146,7,59,79,118,119,118,30,61,222,125,250,132,252,180,54,140,157,170,220,165,0,220,72,130,108,29,118,124,217,166,190,13,178,236,84,183,65,110,111,75,118,121,213,156,216,72,160,234,69,118,236,229,104,191,181,101,198,233,118,121,214,184,206,5,84,195,182,209,174,244,110,99,179,49,6,218,142,180,117,254,211,36,106,204,35,147,132,85,71,65,14,148,121,179,13,134,63,187,2,189,235,239,122,242,211,101,227,47,9,57,42,88,186,10,17,139,180,59,252,21,18,119,5,158,119,155,198,106,67,82,235,28,118,171,17,169,173,174,102,49,186,196,251,128,138,153,1,161,81,104,31,233,84,80,211,71,197,123,63,52,198,138,150,132,220,121,138,121,88,178,213,114,205,36,153,153,63,148,0,109,250,18,54,38,0,80,111,70,250,82,183,0,175,116,104,141,62,166,146,102,149,2,146,197,42,58,151,93,81,65,121,183,57,52,173,2,47,163,205,110,29,1,244,118,23,32,41,121,213,1,217,170,145,254,214,210,74,87,79,197,6,78,204,2,94,151,42,173,71,58,139,42,155,215,62,57,52,187,65,20,132,148,93,130,151,48,159,203,254,231,226,165,25,252,78,87,97,174,153,113,198,80,220,249,61,120,195,43,240,90,85,172,23,226,142,85,49,201,152,7,167,126,183,59,24,113,13,121,231,43,171,162,119,55,40,189,13,198,206,2,255,238,42,191,73,235,172,190,80,153,247,158,55,187,173,17,115,9,41,206,162,128,21,79,187,92,53,208,42,4,234,163,48,236,225,99,4,84,35,232,221,115,158,190,2,161,38,9,17,140,3,57,86,152,147,136,80,14,239,87,23,231,58,191,215,176,72,42,39,63,205,193,114,179,182,154,76,246,200,233,37,80,255,34,14,23,213,39,173,229,136,61,9,32,84,61,129,201,119,51,48,21,66,47,208,79,8,235,97,18,81,63,65,36,114,122,150,76,201,251,16,127,14,8,254,123,78,99,58,197,235,26,86,0,249,36,134,193,176,85,83,103,107,48,90,221,145,106,83,4,75,4,150,30,240,235,42,156,214,16,141,68,242,222,183,236,142,52,159,129,105,225,180,110,234,74,135,17,152,215,95,89,225,173,50,150,75,126,11,153,14,73,253,224,183,144,39,180,111,213,231,176,165,122,183,27,88,43,229,235,91,189,221,173,42,253,234,47,20,46,157,128,88,216,159,45,26,151,204,218,211,100,245,226,85,92,90,181,4,231,56,74,197,66,107,45,216,162,58,57,84,230,212,3,171,79,156,186,34,253,85,26,140,242,163,51,210,229,27,44,102,37,246,55,81,60,44,195,133,234,108,253,82,176,97,187,33,184,146,67,195,241,103,15,82,149,245,240,185,112,175,12,118,231,152,177,4,99,251,106,6,12,7,36,78,64,174,209,4,117,138,122,204,150,255,149,208,88,1,17,163,250,108,82,187,250,174,104,146,171,135,181,102,17,83,27,111,97,252,32,82,212,4,131,127,46,59,186,57,137,100,178,84,206,164,174,249,35,177,83,64,14,155,152,251,120,17,162,17,137,177,52,31,108,153,30,186,117,152,71,131,122,84,222,31,42,154,146,69,155,200,15,229,144,42,69,79,146,172,246,54,189,63,204,41,84,11,185,192,204,87,90,85,235,103,239,29,90,115,26,207,147,15,120,95,212,54,97,107,121,125,225,94,225,145,254,146,248,11,87,44,66,89,52,145,236,28,235,26,70,74,177,235,188,101,52,77,101,115,230,105,18,115,216,86,7,111,116,62,73,88,68,69,141,81,111,169,7,251,109,146,51,173,166,179,53,49,219,171,253,230,89,100,226,196,154,154,107,83,224,102,211,40,49,113,145,15,79,33,214,123,254,143,68,71,93,226,127,56,66,204,36,121,38,237,252,119,70,135,170,117,141,233,122,188,64,27,229,64,76,244,184,217,53,102,38,235,103,235,219,197,147,81,240,127,16,81,75,231,215,215,141,171,195,245,133,116,112,195,183,236,238,107,44,232,117,81,239,59,105,253,141,184,219,188,255,219,110,57,55,127,2,184,175,66,83,155,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92db89de-9c23-42a4-871c-4987414f2c40"));
		}

		#endregion

	}

	#endregion

}

