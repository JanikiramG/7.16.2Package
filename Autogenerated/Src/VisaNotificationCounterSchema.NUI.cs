﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: VisaNotificationCounterSchema

	/// <exclude/>
	public class VisaNotificationCounterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public VisaNotificationCounterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public VisaNotificationCounterSchema(VisaNotificationCounterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d27c816a-0341-4314-bda7-c25742c08a6b");
			Name = "VisaNotificationCounter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,77,111,219,56,16,61,171,64,255,3,215,189,208,128,33,223,91,219,133,215,113,2,47,182,73,16,111,118,15,139,69,193,72,99,155,8,69,186,36,229,84,40,242,223,119,72,74,214,135,165,32,185,196,26,146,111,102,222,188,25,82,178,12,204,145,37,64,254,2,173,153,81,59,27,175,148,220,241,125,174,153,229,74,126,252,240,235,227,135,40,55,92,238,201,182,48,22,178,47,157,111,220,47,4,36,110,179,137,111,64,130,230,201,197,158,63,185,252,81,27,87,74,67,124,205,18,171,52,7,83,219,155,49,100,153,146,253,43,26,134,236,241,213,239,184,132,139,159,52,236,49,30,178,18,204,152,207,228,111,110,216,173,178,124,199,19,159,212,74,229,210,130,246,91,167,211,41,153,153,60,203,152,46,22,229,247,189,86,39,158,130,33,140,100,96,15,42,37,86,145,61,88,98,15,64,100,158,61,129,38,106,71,78,8,75,100,3,55,174,240,166,13,192,99,254,36,120,66,18,23,202,80,36,228,51,217,244,6,24,57,246,207,233,92,115,16,41,230,115,175,249,137,89,240,241,71,199,240,65,52,176,84,73,81,144,71,3,26,107,40,67,77,200,247,188,245,253,165,121,102,179,150,150,219,226,1,142,202,112,172,70,49,195,122,125,83,105,46,192,69,122,197,44,91,144,239,166,105,171,247,6,170,163,79,32,211,16,95,249,93,113,143,122,176,58,119,69,118,33,123,22,202,136,3,35,3,92,208,78,252,237,240,199,196,51,18,181,173,241,234,0,201,243,82,239,243,12,164,189,205,133,160,18,149,173,118,180,115,122,236,211,143,58,156,144,57,233,33,233,245,237,252,80,36,71,208,182,232,205,237,93,196,110,251,121,45,51,116,122,155,15,179,79,190,126,37,116,112,113,30,164,31,122,172,240,120,17,9,127,216,163,118,182,98,201,1,210,129,0,22,52,28,168,78,72,120,105,86,179,162,153,142,218,164,141,38,93,173,141,43,190,13,230,18,178,138,248,238,141,176,127,155,99,123,9,81,21,57,138,236,65,171,23,31,192,70,158,152,224,233,29,114,238,213,178,254,153,192,209,253,160,165,15,87,47,247,239,13,78,16,33,7,71,92,13,219,212,76,13,57,26,96,102,84,250,122,125,135,62,190,249,201,49,212,173,40,16,244,171,217,147,128,25,18,139,179,108,65,176,48,206,221,22,75,147,49,115,235,70,51,173,168,104,238,239,145,146,233,154,12,166,59,144,132,19,192,18,59,164,204,69,131,205,181,236,65,136,183,224,230,58,189,88,113,178,188,48,198,117,232,46,242,113,179,133,170,164,185,180,85,146,190,217,105,200,188,13,230,78,79,200,77,206,83,146,40,105,81,193,155,180,98,193,89,255,253,143,236,184,100,66,20,91,203,44,10,206,165,218,156,35,143,150,11,110,241,98,113,137,94,135,173,62,184,114,59,237,170,52,240,112,98,218,79,244,144,53,98,210,240,107,236,117,82,114,209,61,26,36,231,174,192,60,147,244,58,151,73,28,50,11,150,120,137,183,159,230,230,153,98,43,224,7,29,249,213,81,117,238,90,171,140,94,100,95,173,110,208,141,254,67,241,160,199,101,154,113,249,40,185,221,200,7,37,160,194,136,226,187,254,245,9,105,89,157,109,147,142,198,241,198,172,127,228,76,92,186,197,3,238,231,221,11,122,117,59,223,142,98,216,191,243,220,242,244,142,232,26,254,254,57,128,134,222,232,66,1,61,52,214,155,162,3,89,241,124,207,52,238,65,174,13,237,136,99,92,225,46,101,218,139,186,49,43,38,19,44,111,51,228,18,214,79,61,186,99,194,64,11,231,34,223,85,165,212,75,140,115,104,180,150,115,67,114,137,19,132,155,77,103,233,197,235,159,144,228,22,182,9,19,76,207,176,105,22,157,94,245,103,222,115,71,213,51,168,113,69,117,95,60,222,240,224,145,205,229,155,38,56,67,98,201,83,81,53,100,124,134,153,118,113,102,71,151,46,113,183,239,124,116,78,120,180,40,9,34,248,172,146,14,28,116,60,155,250,189,245,209,144,157,89,92,113,223,92,8,59,33,47,78,13,228,25,10,194,13,217,107,149,31,221,203,43,144,198,100,90,142,116,92,243,38,196,172,64,154,151,113,13,88,206,218,137,27,69,126,224,94,60,64,104,255,228,57,27,218,79,141,117,118,180,69,245,214,232,173,239,169,53,22,221,172,234,29,243,3,130,168,15,198,219,60,163,109,155,155,195,173,113,218,94,158,144,139,128,74,253,184,129,54,196,73,121,243,254,106,18,115,227,120,247,189,224,167,252,36,196,24,238,219,215,33,29,150,182,166,233,245,127,135,225,11,226,111,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d27c816a-0341-4314-bda7-c25742c08a6b"));
		}

		#endregion

	}

	#endregion

}
