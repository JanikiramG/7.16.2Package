﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PreconfiguredPageUserTaskPartialSchema

	/// <exclude/>
	public class PreconfiguredPageUserTaskPartialSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PreconfiguredPageUserTaskPartialSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PreconfiguredPageUserTaskPartialSchema(PreconfiguredPageUserTaskPartialSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62421f2a-f6ca-4cd5-9719-201b6d69a467");
			Name = "PreconfiguredPageUserTaskPartial";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,26,219,110,219,56,246,57,3,204,63,176,90,96,32,99,61,202,98,31,155,38,70,155,164,29,207,164,73,54,118,90,96,131,60,48,18,227,112,42,83,170,72,165,241,22,249,247,61,188,137,23,73,142,59,15,139,29,96,26,155,60,55,158,251,33,205,240,154,240,26,231,4,45,73,211,96,94,221,139,236,184,106,72,118,217,84,57,225,28,190,176,123,186,106,27,44,104,197,126,254,233,251,207,63,237,181,156,178,21,90,108,184,32,235,131,232,59,192,151,37,201,37,48,207,62,16,70,26,154,111,133,185,184,251,19,62,126,172,10,82,246,224,78,54,12,175,7,240,207,40,251,218,91,92,146,39,225,22,207,201,55,1,228,229,113,126,231,21,115,27,254,49,215,235,177,157,134,140,173,103,167,76,80,65,9,31,5,48,154,27,221,95,136,17,242,167,79,130,48,174,180,242,9,151,180,80,42,31,2,60,111,105,182,32,205,35,205,137,82,92,118,130,5,6,67,137,6,231,98,39,4,199,202,129,75,225,212,225,54,139,252,129,172,129,96,217,174,25,58,28,83,64,214,7,118,196,244,158,51,244,139,100,28,104,76,68,51,216,81,14,135,124,45,104,169,246,35,76,207,157,173,169,174,57,105,150,152,127,233,80,128,10,208,249,91,67,86,82,244,227,18,115,254,26,93,54,36,55,216,164,184,196,43,98,209,20,112,221,222,149,52,71,53,110,4,197,37,202,37,206,54,148,189,239,10,205,49,1,91,8,204,132,98,68,31,177,32,122,191,214,95,80,46,247,17,23,141,60,219,91,171,211,4,23,69,114,48,10,119,66,238,175,155,114,73,214,117,41,247,0,254,6,236,223,150,228,118,255,70,138,115,187,159,160,191,27,106,7,70,30,194,10,45,82,40,31,168,170,38,141,84,206,136,128,199,37,37,76,92,51,42,180,37,62,98,6,28,154,209,245,195,35,36,181,1,231,102,218,238,217,8,228,65,200,199,183,182,165,53,180,214,167,63,0,245,194,161,63,18,241,80,21,99,39,54,74,254,64,132,79,249,28,50,106,250,161,165,5,130,255,39,72,38,204,189,189,134,136,182,97,114,37,155,243,211,117,45,54,233,4,205,12,133,76,45,160,215,67,199,128,28,42,230,144,222,222,109,174,231,69,42,41,102,146,129,50,249,243,152,56,210,230,213,23,194,82,179,84,3,37,137,101,165,121,196,13,90,43,63,0,151,24,209,122,246,158,178,194,113,214,110,51,81,124,247,12,89,77,66,18,6,50,250,203,76,73,135,102,51,148,152,216,58,198,77,161,145,63,253,51,9,208,133,115,75,16,24,244,114,222,150,229,69,227,180,19,121,239,107,9,118,224,171,211,82,200,174,8,252,205,73,218,185,119,50,245,164,155,120,251,202,235,97,183,83,201,144,38,43,85,147,164,38,47,113,3,64,130,52,103,85,245,165,173,33,45,183,36,53,39,211,234,234,32,100,232,235,79,83,37,227,222,252,138,224,226,130,149,155,19,170,252,15,55,155,55,210,47,166,72,254,123,132,248,134,107,105,181,217,165,100,203,77,221,25,201,8,241,40,89,130,138,124,97,180,24,29,63,99,21,105,85,56,193,26,248,232,108,252,201,160,42,111,156,77,20,37,13,74,239,81,218,7,157,121,190,249,234,16,221,227,146,119,210,88,149,51,176,145,166,241,236,40,89,65,50,144,16,124,9,162,6,219,164,125,168,48,58,42,219,64,209,197,55,104,23,50,151,199,225,191,179,106,149,125,198,13,147,150,27,203,165,183,25,114,70,128,127,49,20,78,44,205,79,239,41,41,16,22,168,105,65,195,107,146,37,19,95,244,160,186,52,228,158,128,64,57,233,164,113,162,94,133,123,78,133,17,18,148,19,165,210,19,202,193,221,54,182,126,70,42,176,138,36,223,236,202,158,181,113,223,36,153,254,119,89,45,84,204,164,19,141,241,220,63,7,34,250,207,97,124,148,236,184,33,224,212,26,42,13,83,162,209,135,70,205,96,239,109,177,166,236,138,174,30,132,44,155,202,3,156,115,229,74,46,190,172,222,19,145,63,192,190,60,131,171,219,111,134,27,136,163,212,59,250,160,190,52,220,116,43,76,160,83,13,250,236,36,123,192,220,134,79,215,181,140,132,151,236,0,4,166,140,255,65,54,61,3,66,166,51,42,25,105,134,234,152,139,139,7,233,16,61,57,186,163,171,130,32,186,117,96,52,46,226,205,128,88,183,7,54,128,34,1,122,214,214,70,82,233,91,167,238,128,171,57,158,137,219,128,214,171,200,81,247,66,123,103,111,139,34,66,177,196,158,61,111,52,190,164,80,222,55,213,250,228,221,88,152,24,91,142,122,253,52,114,184,169,201,72,154,233,233,83,141,89,81,233,241,1,149,46,61,235,92,169,171,154,206,218,48,46,124,209,41,83,11,55,69,131,199,48,129,233,145,26,174,178,208,58,230,40,100,63,202,48,136,205,233,88,139,93,15,250,140,116,108,155,25,100,164,5,44,33,168,48,71,115,175,180,232,170,58,53,197,235,200,6,135,84,167,180,92,162,62,66,229,51,6,186,236,107,221,101,153,73,15,187,208,241,247,105,144,72,16,156,10,100,226,213,153,237,94,230,120,132,128,170,145,152,14,166,73,195,28,148,46,193,11,143,173,170,175,71,49,37,15,64,149,124,227,180,65,49,48,198,79,3,37,123,37,51,242,130,184,164,235,138,14,18,45,134,67,154,167,190,85,27,194,219,82,24,179,14,146,74,189,154,78,248,87,235,1,158,235,252,171,37,205,38,29,232,24,167,40,137,132,72,58,101,207,87,12,60,240,196,179,165,76,243,162,129,96,211,0,195,37,192,109,158,85,57,76,166,255,193,102,252,80,187,126,50,6,89,165,45,181,198,83,41,136,47,33,228,31,91,130,35,192,165,159,163,44,76,111,134,36,253,161,82,210,233,26,112,183,179,173,206,57,168,236,125,213,156,226,252,33,37,114,90,232,28,178,145,137,57,146,91,178,218,226,113,91,78,170,8,198,153,127,43,173,65,101,236,105,167,185,233,139,118,43,77,232,163,24,191,14,211,154,70,223,177,219,61,129,245,37,116,76,187,245,187,127,185,99,149,233,193,64,143,52,73,81,183,41,85,89,24,217,100,99,107,229,140,123,91,7,115,136,44,76,246,145,154,220,180,67,75,107,9,100,127,64,25,245,169,200,239,153,138,130,48,131,33,143,209,162,38,57,189,223,72,208,142,208,52,164,112,205,184,2,130,6,117,50,112,64,172,4,149,126,224,159,242,196,223,152,184,254,52,88,15,140,238,101,207,30,85,202,196,36,88,132,252,127,202,218,117,58,153,14,159,43,96,35,175,147,168,76,5,68,91,112,138,36,200,191,43,70,230,236,190,202,174,69,62,241,242,130,241,184,253,253,125,244,134,183,107,89,51,142,236,194,149,18,149,171,34,232,124,138,103,29,194,126,140,241,70,65,33,6,144,135,73,237,59,103,114,164,199,10,100,86,17,215,29,199,155,125,133,50,76,161,149,105,173,171,249,60,57,58,171,112,97,218,0,100,234,158,113,234,10,166,57,116,95,53,74,177,82,96,39,230,69,89,232,21,4,18,32,125,5,213,157,198,160,67,197,230,20,70,86,130,86,178,29,52,138,99,149,176,49,104,117,233,87,219,73,79,120,109,92,126,212,69,23,7,132,174,136,236,219,237,145,122,21,245,9,58,76,87,196,17,11,227,29,5,10,158,162,187,170,42,81,164,50,191,182,181,102,42,147,46,22,16,178,227,218,36,32,40,243,224,59,204,201,105,73,214,96,56,221,177,234,45,179,228,154,86,147,153,135,234,235,72,45,69,189,98,58,86,122,35,173,248,40,133,190,133,246,180,125,216,157,50,115,171,217,231,7,232,114,211,90,150,146,218,12,93,197,156,121,21,228,48,212,165,154,54,32,232,206,40,23,1,63,19,111,1,195,158,16,33,187,48,54,231,188,75,140,3,244,181,103,239,78,61,50,54,250,229,151,1,134,26,98,136,29,6,255,6,98,47,240,59,125,202,73,45,210,254,217,39,118,43,22,59,230,37,211,118,12,3,173,31,140,254,232,8,253,163,203,214,227,14,180,181,123,243,147,116,95,200,174,145,80,10,211,62,166,123,90,211,198,142,23,215,122,98,187,237,158,240,63,66,212,191,159,170,167,163,119,75,150,87,207,40,63,196,44,150,252,197,22,99,123,250,121,43,96,237,174,21,59,118,201,91,66,149,170,59,244,124,219,181,166,188,79,53,80,58,217,196,128,97,190,169,125,183,181,228,189,168,215,144,245,136,30,189,150,210,159,228,186,1,27,215,166,141,133,132,161,63,207,204,236,107,32,6,171,118,28,125,81,221,222,163,38,26,21,221,225,64,181,160,209,104,110,238,114,135,110,180,235,248,26,76,234,201,113,188,34,95,91,218,144,66,241,156,119,95,131,235,170,189,1,183,122,244,166,197,157,59,86,239,166,91,183,249,130,60,137,211,39,146,183,82,133,242,196,246,230,251,79,174,191,91,191,50,203,173,67,147,187,32,180,41,85,103,152,145,89,22,18,86,244,188,36,19,33,199,23,215,113,123,105,69,136,219,60,126,103,188,65,15,221,239,90,90,22,164,73,59,137,205,93,249,93,118,70,216,74,60,252,250,107,183,240,182,174,9,180,150,201,52,153,216,207,145,76,221,122,242,156,132,74,5,116,55,230,15,233,86,190,150,118,189,93,179,32,66,0,40,87,201,209,174,106,16,189,145,70,47,28,242,64,35,36,140,90,164,31,74,219,255,6,115,118,41,141,113,136,226,165,236,28,250,200,105,8,254,150,115,178,190,43,55,16,95,107,44,6,144,135,1,178,133,106,184,12,49,105,40,21,12,30,126,111,45,155,179,188,108,11,127,174,125,222,249,153,168,18,144,147,164,223,119,221,26,101,144,104,169,40,170,124,223,180,100,6,6,85,143,164,105,104,65,116,79,53,7,235,53,12,151,218,143,187,169,203,184,53,91,25,243,202,7,62,249,215,234,93,122,36,4,107,179,185,172,32,55,204,189,247,165,206,17,253,109,249,216,98,95,57,101,32,90,46,29,72,52,57,79,81,52,109,218,5,249,201,165,74,237,214,234,8,56,23,159,169,120,144,100,82,35,235,20,65,70,104,25,83,105,123,241,80,125,235,98,85,22,38,67,162,3,49,55,18,129,219,186,155,232,157,77,161,222,99,183,217,65,63,216,134,70,56,174,164,183,8,210,105,93,207,172,220,20,155,155,91,175,32,88,253,58,125,158,16,56,188,10,163,157,212,218,25,101,139,146,141,114,212,47,41,128,238,130,174,192,69,210,48,166,239,160,127,206,70,36,215,146,246,134,176,151,148,241,88,193,124,114,44,107,93,249,255,166,10,125,218,33,209,254,226,89,189,103,220,160,132,248,189,136,26,78,183,55,21,221,83,233,11,13,69,48,92,197,67,210,164,255,6,166,252,146,242,185,62,5,41,228,165,186,247,162,63,38,210,60,196,24,146,10,102,118,67,39,124,215,149,15,109,107,24,189,10,123,205,103,111,253,238,74,162,75,71,84,243,174,2,4,115,191,58,27,104,25,147,16,50,153,204,188,106,36,95,141,253,7,113,77,230,53,10,113,50,119,51,111,229,165,236,94,229,124,216,189,96,11,65,234,29,68,158,199,56,219,164,238,1,239,38,120,15,205,151,93,221,236,250,254,22,246,134,210,77,78,75,125,89,40,77,165,87,153,238,207,84,235,228,224,192,123,162,196,174,207,0,246,190,180,219,169,114,44,219,176,81,30,84,23,82,188,219,232,204,18,83,153,143,1,134,244,140,20,166,125,212,62,236,9,249,64,112,33,127,145,129,150,84,148,36,232,112,67,95,179,226,197,138,179,108,192,179,143,93,207,12,223,108,219,236,89,195,170,10,234,206,165,167,196,36,88,48,239,24,26,180,53,63,151,208,157,111,247,227,9,69,95,61,24,120,178,54,133,162,214,213,64,43,152,55,37,244,47,84,162,43,148,145,96,182,108,112,55,14,201,145,99,36,240,103,189,193,233,181,186,200,236,12,18,61,150,135,215,252,216,94,159,235,159,254,120,157,206,94,212,56,3,140,108,231,32,93,67,186,20,238,214,207,188,66,5,30,60,69,186,247,18,93,11,183,165,109,52,41,199,227,179,173,157,143,186,226,161,214,250,71,82,190,117,106,125,195,116,94,9,122,79,115,157,237,64,10,255,123,80,9,182,160,49,255,203,161,46,201,131,164,220,28,17,230,53,251,48,38,175,87,162,140,247,27,230,250,101,19,182,94,13,101,195,209,17,196,151,42,83,193,7,178,133,20,6,30,193,124,172,96,68,208,90,124,164,141,104,33,85,168,30,33,110,76,188,174,148,15,229,221,75,152,234,56,164,145,86,8,233,85,5,137,231,165,120,76,250,225,122,249,63,184,132,188,83,210,115,247,20,50,124,33,168,159,224,213,244,156,232,3,243,164,79,69,122,75,68,111,150,45,170,182,201,245,13,81,230,149,50,247,116,21,85,146,218,87,171,163,56,83,50,164,119,102,249,200,172,223,36,75,188,74,110,179,79,246,237,165,111,21,77,218,99,29,214,68,180,10,236,110,31,222,221,83,74,32,16,20,203,102,3,58,54,229,52,244,153,100,138,170,86,12,17,244,116,21,238,2,167,1,240,153,95,94,71,29,48,68,124,201,251,204,0,99,106,243,200,72,22,63,54,162,239,22,210,22,67,100,146,107,244,131,196,121,215,27,175,40,35,217,242,161,169,190,153,64,234,38,167,72,222,45,51,144,94,13,23,97,237,191,90,148,172,60,226,45,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62421f2a-f6ca-4cd5-9719-201b6d69a467"));
		}

		#endregion

	}

	#endregion

}

