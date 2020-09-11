﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FullPipelineProviderSchema

	/// <exclude/>
	public class FullPipelineProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FullPipelineProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FullPipelineProviderSchema(FullPipelineProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9c364ef-0938-41c8-b1b7-1356928fe099");
			Name = "FullPipelineProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,75,115,219,184,249,172,157,217,255,128,170,23,170,81,105,167,199,88,86,38,241,35,235,118,157,164,177,219,30,60,158,12,45,66,54,54,20,169,5,72,59,106,86,255,189,31,222,0,9,80,84,30,183,94,108,17,196,247,126,226,3,203,108,133,217,58,91,96,116,141,41,205,88,181,172,211,147,170,92,146,251,134,102,53,169,202,159,127,250,242,243,79,163,134,145,242,30,93,109,88,141,87,71,173,103,216,95,20,120,193,55,179,244,13,46,49,37,139,206,158,95,73,249,123,103,241,67,83,214,100,133,211,43,0,201,10,242,95,65,208,238,122,139,159,106,192,201,89,250,59,115,95,184,172,82,28,91,79,207,179,69,93,81,130,89,120,199,106,21,198,249,182,33,156,163,71,178,192,151,85,142,139,244,52,171,51,208,73,77,1,31,0,0,200,159,41,190,7,86,209,69,89,99,186,4,237,189,64,23,231,77,81,188,39,107,92,144,18,191,167,213,35,201,49,69,98,247,193,193,1,154,177,102,181,202,232,102,174,158,213,14,134,86,184,126,168,114,134,150,21,69,107,13,86,45,209,18,208,161,181,194,135,114,96,33,213,168,14,28,92,235,230,174,32,11,68,52,35,97,62,96,35,183,98,135,19,177,240,1,215,13,45,25,202,128,32,3,100,192,20,39,215,101,226,110,3,192,24,163,5,197,203,227,177,75,231,12,236,88,111,164,223,140,15,230,169,161,117,208,38,54,91,103,52,91,161,18,220,238,120,140,57,24,216,71,1,206,207,212,51,90,184,30,152,206,14,4,144,197,65,37,199,243,211,24,155,74,140,8,183,87,252,45,103,115,118,160,49,113,212,238,150,139,114,89,161,55,184,126,85,20,98,55,227,164,146,139,95,9,171,103,49,193,231,200,151,103,34,125,101,43,61,6,151,185,116,26,207,129,78,138,140,177,23,40,108,179,126,215,217,199,75,110,78,241,50,107,138,250,53,41,115,112,246,164,222,172,113,181,76,130,190,50,153,220,90,191,90,112,254,130,236,69,60,94,122,26,87,167,17,17,66,184,206,202,26,196,124,79,201,99,86,99,249,126,45,31,184,173,89,141,114,188,32,171,172,64,31,239,50,134,175,234,236,30,3,220,35,166,140,163,56,70,207,15,15,87,71,10,175,175,73,67,231,156,224,34,143,17,161,56,203,171,178,216,160,127,49,76,1,115,41,243,21,250,216,120,207,71,46,140,39,31,183,63,4,10,100,19,96,10,125,204,221,71,31,10,188,230,3,94,87,140,64,238,217,200,20,180,153,201,108,35,228,226,152,230,232,35,227,191,59,27,125,84,144,38,33,3,53,133,84,200,47,224,124,176,197,194,40,36,157,245,163,160,228,167,68,136,8,30,49,235,4,195,53,248,195,20,49,144,167,4,55,254,136,11,188,2,95,254,119,86,52,248,45,68,234,101,182,6,27,112,172,163,18,63,237,129,73,36,157,209,232,11,10,238,131,28,12,5,96,138,198,226,255,133,84,207,24,109,167,187,160,180,99,92,87,2,68,96,104,173,237,135,230,156,80,86,135,112,217,23,6,225,118,135,31,10,127,167,13,55,39,247,70,17,71,202,25,101,76,133,194,38,105,249,165,239,150,19,165,72,127,53,61,121,192,139,79,175,232,125,195,141,245,22,176,38,60,173,66,92,183,160,39,194,33,70,45,95,7,139,6,156,127,219,47,28,240,187,198,148,231,184,160,104,61,33,227,63,73,121,238,113,173,93,68,38,226,86,96,161,151,47,81,210,90,58,230,105,217,67,150,104,1,183,226,47,179,72,201,178,3,254,167,99,84,2,143,90,163,163,81,253,64,171,39,196,221,250,2,90,146,87,5,143,151,205,217,103,136,169,179,207,11,188,230,138,209,106,245,168,106,162,138,234,232,145,7,75,220,36,97,216,142,108,2,139,35,205,214,87,239,176,220,114,21,76,45,113,157,135,83,145,84,126,228,157,176,66,152,206,14,115,68,16,126,139,93,194,124,236,105,160,29,72,226,138,216,97,178,93,57,60,178,220,111,172,238,126,107,172,238,59,107,172,43,92,215,144,152,153,125,57,196,90,93,140,223,108,173,14,202,175,177,86,28,73,92,19,17,107,197,242,221,165,236,206,35,93,69,79,186,235,38,41,165,43,15,230,159,13,166,155,215,13,41,120,59,119,167,254,11,115,169,197,68,73,164,172,47,218,69,229,122,112,212,170,103,113,14,230,137,84,5,183,137,83,146,180,50,147,177,159,252,199,211,118,47,52,153,238,64,160,248,5,72,245,75,169,127,219,163,36,79,96,87,76,173,157,97,25,46,26,140,225,40,150,58,220,25,138,44,28,34,26,109,184,207,26,102,26,87,238,31,111,153,176,122,198,211,136,222,134,225,235,42,70,35,236,190,137,120,194,46,3,244,165,41,116,60,151,29,104,87,209,59,208,126,187,190,213,73,110,223,30,191,167,68,130,52,17,97,6,161,254,254,34,201,142,157,179,124,214,106,254,95,111,76,207,156,4,59,105,121,218,230,191,116,20,235,90,21,56,71,220,152,205,183,65,23,57,43,65,2,154,221,21,120,38,196,101,252,36,110,85,201,159,88,226,238,26,124,26,87,188,61,102,20,206,68,12,14,195,16,215,92,127,226,76,239,208,210,41,119,89,65,17,91,60,160,132,67,96,7,51,34,101,4,247,136,148,53,90,101,159,223,54,171,59,145,200,37,33,121,206,81,165,73,144,11,39,52,38,83,191,148,66,114,148,184,132,211,171,197,3,94,101,92,147,19,85,119,211,119,20,50,202,235,77,178,194,146,228,28,201,95,169,228,97,146,94,87,156,162,22,138,75,133,18,206,38,1,98,135,71,240,111,166,136,43,46,17,121,246,204,214,117,46,187,120,13,187,229,182,27,114,171,80,141,148,116,175,242,60,225,138,180,58,52,224,163,139,92,3,166,23,249,84,175,26,253,16,244,204,234,203,188,62,37,108,93,100,27,225,54,6,220,93,52,59,173,66,96,95,68,85,106,239,214,111,48,182,174,163,74,65,118,249,99,40,190,61,91,169,24,98,214,74,142,207,185,29,137,206,111,209,202,194,83,65,226,224,57,50,104,136,24,166,44,112,180,214,165,94,2,73,66,100,253,158,66,99,76,229,184,43,9,166,238,199,138,228,8,12,125,146,21,139,166,128,149,220,158,4,147,206,84,204,232,72,229,18,136,69,249,131,77,189,211,239,7,232,25,249,9,72,235,137,183,156,98,244,120,220,234,47,37,171,110,163,42,70,93,33,110,210,243,138,158,65,220,38,159,176,246,32,75,222,248,106,31,183,154,168,114,43,141,39,253,7,222,40,199,211,158,105,94,137,191,146,187,112,233,211,227,45,208,177,29,47,36,109,93,44,26,74,129,1,53,136,104,191,53,147,49,87,93,46,72,68,109,72,140,206,140,230,56,148,65,165,65,208,31,127,88,252,233,59,96,48,43,10,145,16,248,142,195,54,70,151,106,119,247,10,189,228,127,94,4,135,121,71,221,240,75,226,232,14,34,92,77,208,95,248,76,112,87,200,118,234,149,172,36,98,162,251,122,195,171,80,188,152,152,250,54,87,227,100,177,221,11,105,57,101,118,202,72,151,94,176,154,16,56,35,241,42,18,192,59,146,107,97,71,229,175,76,110,21,165,247,88,224,210,249,80,204,195,99,236,152,188,149,168,226,177,157,4,108,33,201,135,244,234,34,123,67,171,102,141,115,113,224,168,158,110,110,185,86,223,83,188,206,40,206,175,43,29,150,252,66,72,206,205,35,42,6,216,185,72,0,82,128,88,241,103,154,117,87,249,191,85,128,32,87,18,47,105,181,146,219,68,249,225,170,213,48,186,84,140,4,132,42,102,240,67,94,113,148,22,10,10,20,194,191,55,89,193,84,197,145,13,71,206,239,86,42,1,236,163,19,52,245,178,78,29,128,88,47,165,106,230,126,177,60,91,173,235,141,214,58,7,101,152,223,151,161,182,125,125,173,218,34,10,16,198,122,186,30,114,142,167,206,6,245,174,197,143,37,185,245,114,190,85,158,105,32,100,158,76,13,33,167,129,120,69,105,182,9,215,133,161,193,54,212,5,118,251,192,180,159,230,176,128,237,36,1,23,64,106,10,113,128,181,242,105,165,221,126,47,23,82,56,206,106,139,246,210,76,145,1,137,139,243,230,240,214,164,135,78,91,230,110,148,205,25,216,192,107,207,56,110,191,0,248,216,77,171,214,222,168,228,113,151,94,138,107,78,219,37,218,108,37,116,99,211,149,109,14,117,81,19,235,186,38,234,98,3,153,76,182,67,170,246,10,1,204,73,64,117,186,61,71,13,129,52,149,167,138,103,234,138,96,108,80,63,145,154,179,231,110,50,225,178,128,138,209,119,225,240,194,68,133,199,120,91,63,47,83,247,90,130,15,216,172,104,163,209,29,40,232,211,209,32,146,173,155,9,75,94,121,216,35,169,26,22,180,223,101,86,63,164,151,217,231,228,112,10,30,241,87,244,124,114,123,20,102,222,239,43,218,162,76,125,50,210,212,19,139,138,55,118,6,90,122,90,23,69,208,142,147,111,212,136,189,95,137,88,101,151,96,54,180,126,188,80,106,52,57,218,163,223,221,89,141,13,132,113,223,161,237,233,200,116,168,195,35,201,86,12,115,184,50,202,214,175,180,148,91,45,118,172,237,183,61,125,91,175,70,129,146,180,72,96,189,157,183,149,73,23,93,63,30,157,178,228,28,35,207,172,146,53,47,3,14,123,241,14,199,28,114,90,110,211,215,166,159,170,164,47,82,93,86,195,255,187,166,198,238,225,175,221,165,11,121,219,3,244,246,134,224,209,230,198,195,127,27,200,89,94,143,252,53,83,110,231,74,239,255,223,138,244,124,43,18,184,202,253,46,159,140,196,134,84,109,66,250,88,177,179,173,2,120,239,90,32,117,159,146,238,7,43,35,103,90,33,36,178,151,71,114,246,22,4,81,147,160,171,78,127,229,54,69,162,101,21,210,192,129,65,249,125,223,119,1,253,59,218,223,0,12,221,109,43,142,58,175,251,18,216,25,150,211,104,123,189,115,119,88,212,10,171,125,63,248,225,20,196,158,27,247,67,179,222,143,112,36,136,252,166,75,64,93,138,161,95,162,10,194,88,250,244,88,124,201,99,110,34,251,91,117,101,59,115,239,120,4,167,20,79,202,32,29,163,174,56,45,183,139,239,140,8,3,132,134,168,207,226,25,160,56,119,115,92,101,36,247,69,120,211,64,49,128,66,180,159,66,114,103,74,233,227,83,37,194,155,109,238,135,187,20,7,50,31,43,63,50,168,105,234,158,150,51,195,197,32,155,206,96,213,226,149,229,140,127,105,88,242,174,223,18,217,219,229,133,179,237,233,243,10,38,110,65,254,81,155,47,76,248,186,66,252,249,130,140,166,80,159,61,97,201,199,217,51,88,145,135,240,22,230,253,117,99,39,23,251,233,199,153,120,196,19,131,108,175,2,174,174,27,175,129,138,209,13,215,80,229,152,62,215,52,109,223,77,79,102,214,241,117,234,178,163,146,168,214,202,88,152,200,0,25,166,177,199,110,78,208,7,104,149,13,190,81,33,110,99,177,167,50,124,208,30,247,25,158,53,134,41,101,33,111,36,113,254,31,82,63,196,131,215,240,103,55,171,187,56,111,109,48,85,211,92,191,131,214,90,142,112,226,5,236,164,187,123,142,2,139,29,151,238,9,66,202,191,14,137,40,81,191,29,156,163,26,28,69,118,42,223,13,69,181,36,5,100,119,22,68,117,46,223,133,80,105,139,169,29,208,253,169,159,73,235,70,152,127,198,47,155,177,58,61,197,76,125,246,143,223,221,253,6,54,156,41,160,121,162,126,76,246,170,47,1,139,12,136,130,32,84,60,0,42,189,41,168,34,131,98,168,190,193,212,247,124,192,81,52,171,50,26,85,215,173,77,223,47,81,180,163,233,107,179,70,23,207,87,87,105,145,65,236,119,10,123,23,236,31,149,161,128,151,171,126,212,39,129,141,67,137,240,145,31,28,227,149,240,189,222,240,62,184,117,176,52,15,164,200,7,209,57,9,237,28,230,122,81,135,241,47,56,180,151,4,220,128,79,89,130,205,148,222,236,28,36,156,33,82,152,57,21,8,60,163,191,216,233,108,174,0,24,32,6,0,72,41,78,9,229,119,58,199,232,80,28,69,63,240,195,54,227,58,127,46,158,47,179,114,115,93,241,191,176,244,183,93,65,27,224,85,183,175,253,12,218,93,146,43,117,41,171,152,10,159,131,13,143,157,67,117,15,171,176,246,63,115,74,228,21,59,54,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9c364ef-0938-41c8-b1b7-1356928fe099"));
		}

		#endregion

	}

	#endregion

}

