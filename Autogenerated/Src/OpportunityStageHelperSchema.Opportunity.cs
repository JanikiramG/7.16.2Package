﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityStageHelperSchema

	/// <exclude/>
	public class OpportunityStageHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityStageHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityStageHelperSchema(OpportunityStageHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da7fb9b8-ebdd-4dbd-86e9-f1075b5f04bc");
			Name = "OpportunityStageHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,90,91,111,219,184,18,126,118,129,254,7,86,7,88,200,128,161,224,188,110,18,47,90,231,82,3,109,157,133,179,187,15,139,197,66,145,152,152,56,178,164,146,84,122,124,186,249,239,59,188,73,36,69,201,118,18,236,1,122,177,104,206,112,46,223,12,103,70,110,24,41,31,208,122,199,56,222,158,190,125,211,88,143,201,162,42,10,156,113,82,149,44,185,198,37,166,36,243,183,124,34,229,215,118,237,22,83,154,178,234,158,3,229,118,91,149,193,47,40,30,88,78,46,75,78,56,193,108,232,251,139,15,67,223,172,121,152,237,151,134,36,107,76,31,73,134,63,87,57,46,146,203,255,114,92,50,161,16,236,126,251,166,76,183,152,213,105,134,29,134,229,61,121,104,104,42,244,126,251,230,251,219,55,19,248,243,47,138,31,224,25,45,138,148,177,31,209,170,174,43,202,155,146,240,221,154,167,15,248,35,46,106,76,5,203,201,239,171,59,86,21,152,227,56,146,155,17,97,40,199,53,197,89,202,113,62,67,117,129,83,134,81,3,127,125,46,159,211,18,254,165,73,52,253,3,24,213,205,93,65,50,148,73,38,67,7,78,190,203,67,247,201,119,145,242,84,109,172,105,197,193,167,56,31,96,172,118,78,4,223,201,196,200,112,221,144,28,201,175,151,57,250,142,228,87,147,7,204,79,213,39,102,62,61,217,68,164,228,232,75,179,189,195,244,96,146,187,170,42,208,101,9,103,140,239,151,255,72,181,113,153,43,205,219,149,65,67,44,203,195,77,225,236,13,25,227,8,59,200,253,54,111,151,20,237,167,253,6,161,55,76,133,250,100,33,167,162,238,211,158,227,109,78,176,31,223,146,45,254,73,126,178,253,210,35,156,104,207,248,126,177,189,114,69,112,145,131,91,110,40,121,4,126,198,15,242,1,81,156,230,85,89,236,208,47,12,83,8,195,82,229,30,244,103,227,60,159,218,52,50,103,236,214,217,6,111,83,244,103,85,215,218,115,106,229,244,64,105,164,174,90,24,29,117,144,34,56,98,156,138,132,178,106,217,46,82,224,123,77,171,166,254,2,169,3,157,163,200,55,53,139,78,143,97,179,132,36,42,216,40,218,245,174,204,54,180,42,201,255,96,127,180,71,250,27,90,65,10,16,9,83,216,83,67,217,71,182,103,74,239,81,185,19,188,9,144,160,152,55,180,111,108,244,100,185,181,227,235,216,125,229,153,221,225,171,96,98,184,7,60,36,176,163,118,49,139,160,183,19,172,244,152,22,13,118,211,192,152,129,22,194,248,180,201,224,114,8,59,57,156,84,99,207,72,174,65,102,174,234,190,148,83,173,187,103,70,16,62,0,226,160,146,65,11,61,189,88,238,151,11,230,178,79,108,51,152,139,235,26,243,37,216,60,45,51,252,97,39,34,36,142,250,73,53,154,158,30,224,188,207,152,111,170,64,170,48,0,252,68,24,63,11,229,185,57,2,41,84,56,117,245,75,108,212,127,76,41,32,157,53,5,7,141,74,252,109,132,79,172,228,148,36,76,172,94,178,175,154,200,214,253,231,6,211,93,188,223,56,179,126,174,208,150,152,24,238,137,204,11,125,83,191,175,107,112,187,44,72,228,142,228,55,194,55,159,170,44,45,196,35,164,138,120,40,67,5,15,16,57,71,167,175,161,148,212,105,78,114,176,98,179,21,64,105,185,188,207,245,98,28,45,243,200,50,83,41,175,251,81,2,85,17,68,211,100,69,115,76,63,236,222,179,204,54,52,160,97,148,28,138,131,200,247,11,179,247,130,243,149,241,45,231,187,230,180,109,194,146,171,138,94,130,234,177,124,68,231,115,141,14,113,102,44,92,29,188,74,245,53,104,42,34,125,188,56,251,118,87,99,45,236,175,34,91,157,137,27,124,30,27,43,38,210,41,51,69,174,139,163,49,106,168,161,230,177,109,85,135,129,168,148,198,168,69,57,53,143,91,147,42,90,149,62,167,218,10,58,47,43,165,157,84,163,47,88,89,129,0,243,79,41,227,253,88,94,230,177,220,80,217,229,205,76,17,49,181,193,68,222,26,11,119,32,166,254,83,113,164,214,124,255,36,183,85,29,255,91,9,58,153,36,54,212,212,90,114,69,171,109,56,181,232,13,191,109,48,245,146,15,80,39,75,118,249,181,73,139,88,219,227,38,165,96,17,14,169,211,145,127,106,184,188,47,243,56,210,122,142,81,27,77,13,157,134,246,5,6,108,71,11,40,107,32,97,173,202,104,138,82,166,85,118,140,175,76,2,189,9,206,26,14,249,54,45,82,170,113,51,117,93,114,88,242,91,150,32,212,22,231,4,206,85,137,48,30,33,80,113,48,11,3,189,42,114,249,160,0,23,220,2,126,148,15,211,174,80,150,121,67,10,177,54,241,121,88,170,37,247,40,54,71,162,115,160,106,138,194,224,103,226,113,84,114,27,144,40,135,183,65,172,98,66,7,216,89,43,163,94,105,161,117,91,9,153,204,233,79,8,23,12,143,30,231,159,19,59,7,205,91,123,153,131,208,15,63,60,83,22,27,32,182,40,14,192,91,57,222,169,67,32,33,120,24,12,155,196,108,178,206,60,238,74,118,170,205,147,147,19,116,198,154,237,54,165,187,185,89,80,176,103,118,102,0,61,180,20,45,213,137,79,118,86,139,168,66,162,49,63,143,128,86,192,35,154,175,2,76,80,14,95,157,157,200,253,97,114,194,122,145,16,205,151,76,147,223,87,20,101,66,72,161,26,244,232,196,218,171,182,216,204,187,216,123,36,32,73,90,160,199,10,114,156,86,179,159,137,226,112,51,137,180,74,51,213,234,6,36,4,168,221,167,0,67,187,96,201,26,74,113,201,101,7,118,110,88,36,226,49,249,152,50,153,235,127,114,151,229,26,250,209,47,36,22,138,145,88,21,23,198,162,227,43,122,60,131,61,117,127,10,160,234,79,231,189,10,63,81,122,171,239,195,247,107,75,158,172,225,164,238,86,146,137,92,93,17,201,23,252,77,252,31,79,247,210,184,153,124,214,106,235,172,239,231,162,58,105,155,94,173,236,165,52,183,64,71,217,250,52,209,223,29,194,131,74,99,3,23,203,165,118,238,235,241,22,87,252,95,127,133,128,210,230,197,225,3,47,26,60,120,220,147,47,108,250,136,221,235,38,24,214,191,212,121,47,172,85,60,85,194,146,71,68,118,91,65,184,225,173,152,145,28,164,37,247,4,211,209,8,175,180,63,231,0,36,37,192,0,229,64,248,42,109,250,161,42,81,209,86,54,173,164,186,176,209,167,26,7,232,32,233,54,190,36,106,4,10,222,249,172,146,43,204,179,141,40,122,46,62,196,174,64,42,87,180,88,232,81,2,36,46,240,189,133,10,230,222,48,33,130,161,144,113,66,165,79,40,0,164,196,217,139,162,143,105,153,23,128,162,108,147,150,15,98,52,82,221,27,136,190,2,178,12,121,52,95,132,121,242,67,82,251,66,200,134,53,7,11,21,157,187,13,75,99,253,126,37,172,178,181,121,78,160,149,21,130,91,246,245,58,153,30,197,112,71,209,213,165,167,221,225,133,42,210,91,124,0,183,177,210,221,171,218,153,147,199,132,80,218,229,135,11,101,208,162,121,140,199,151,47,173,7,177,49,0,117,131,50,204,76,19,40,46,116,91,204,67,1,163,75,54,145,70,132,165,2,0,60,52,27,189,22,244,44,237,84,49,161,144,213,10,106,102,80,33,16,238,173,244,21,38,250,3,18,203,235,224,147,35,124,238,141,0,116,121,251,2,40,219,108,86,47,68,224,104,203,34,31,218,210,254,138,80,192,35,133,116,153,66,47,28,51,89,52,39,173,50,231,150,106,99,204,141,155,142,100,222,121,215,186,9,92,65,189,126,72,53,7,118,50,183,219,39,73,242,206,35,81,241,168,203,130,171,138,10,188,43,132,217,224,146,254,119,110,9,93,172,202,29,55,20,63,146,170,17,56,10,157,37,58,30,91,236,174,241,177,119,235,213,78,83,143,185,39,113,160,163,13,156,225,73,238,116,115,129,150,52,220,41,155,118,216,150,118,230,104,164,249,79,212,101,30,96,33,165,152,249,16,158,57,231,59,230,237,215,248,207,170,219,199,91,14,221,132,15,108,210,102,90,141,220,94,123,82,192,204,154,137,117,231,117,54,212,7,180,241,236,155,71,125,175,245,183,172,33,38,113,107,156,85,101,30,116,186,158,103,41,11,12,118,99,218,6,251,47,22,211,182,246,187,193,222,5,131,190,109,72,182,65,41,133,13,255,33,53,88,230,25,53,138,95,254,30,120,213,120,198,3,30,35,197,111,143,154,137,70,68,210,235,105,236,92,182,38,250,182,83,227,198,81,6,184,204,29,114,209,165,12,17,15,149,87,67,209,51,56,79,12,2,102,228,186,115,194,205,29,78,105,56,8,226,129,217,148,21,27,206,139,128,87,8,83,91,174,222,248,89,238,232,138,121,35,101,104,28,237,189,163,110,201,156,16,100,221,244,110,52,186,219,0,220,27,161,123,66,52,48,102,122,50,201,174,107,29,90,189,140,254,93,59,33,110,198,177,56,214,31,103,136,211,6,79,15,40,21,49,103,232,35,156,85,81,146,1,250,82,206,41,185,107,64,7,94,161,178,226,40,205,36,42,245,69,125,96,8,27,219,152,8,184,169,24,145,147,36,232,100,132,159,122,69,228,190,202,241,176,68,48,218,199,6,130,73,252,6,195,21,213,244,176,242,166,116,163,2,140,1,89,157,168,208,94,155,57,125,172,62,77,71,6,246,102,132,121,200,164,94,141,225,188,57,189,121,41,164,87,151,236,90,2,128,174,232,192,196,221,213,105,106,5,104,83,231,93,79,97,38,207,202,62,158,216,238,11,57,239,13,194,68,52,194,113,212,225,6,26,224,158,20,10,129,174,42,199,188,114,24,121,213,80,198,1,111,104,53,93,21,205,123,131,35,134,55,186,0,148,23,90,17,108,121,254,47,205,211,43,132,64,168,180,237,53,79,193,0,120,213,41,78,111,114,180,191,17,151,133,119,168,7,248,39,167,65,175,116,195,237,29,42,141,13,38,15,29,44,237,127,75,97,253,224,99,116,10,213,195,44,67,172,237,192,229,251,129,231,132,67,219,39,29,121,21,20,121,91,212,5,89,200,25,201,107,207,33,212,239,74,142,28,66,152,133,182,193,25,158,74,232,6,82,238,92,108,128,62,87,237,163,41,54,222,61,183,191,239,58,83,142,213,196,46,71,118,51,125,4,103,111,10,209,118,165,45,227,54,174,122,166,241,186,231,86,251,211,177,78,221,49,71,203,123,104,236,216,103,59,244,19,40,249,59,72,181,238,198,8,172,253,13,185,37,122,148,238,43,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da7fb9b8-ebdd-4dbd-86e9-f1075b5f04bc"));
		}

		#endregion

	}

	#endregion

}
