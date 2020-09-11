﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoEmailRelationSchema

	/// <exclude/>
	public class AutoEmailRelationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoEmailRelationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoEmailRelationSchema(AutoEmailRelationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("678b6b87-59e3-448c-be04-0c7ab1f1df91");
			Name = "AutoEmailRelation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa5a4ea1-d5a6-4cdb-bf8a-922751325e62");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,219,110,219,70,246,89,5,250,15,99,21,8,36,64,160,251,156,68,90,56,174,18,8,104,18,215,118,183,15,69,17,208,212,216,34,74,145,206,12,233,68,72,252,239,59,103,110,156,43,73,201,106,178,11,108,17,36,22,117,110,115,238,231,112,220,50,221,98,122,159,102,24,93,99,66,82,90,221,214,201,121,85,222,230,119,13,73,235,188,42,147,179,166,174,150,219,52,47,46,113,193,159,252,248,195,151,31,127,24,53,52,47,239,208,213,142,214,120,251,194,249,204,40,20,5,206,0,152,38,111,112,137,73,158,121,48,191,230,229,71,239,225,53,254,92,39,151,248,174,41,82,178,252,124,79,48,165,64,164,133,51,165,36,56,246,220,62,66,20,106,89,214,121,157,99,32,207,64,126,34,248,142,65,163,243,34,165,20,5,142,205,96,78,79,79,209,75,218,108,183,41,217,45,228,231,235,77,78,81,198,145,238,73,245,144,175,49,69,91,92,111,170,53,69,117,133,50,130,211,26,35,44,121,33,34,233,209,68,226,43,6,84,130,174,145,16,150,52,5,166,51,196,200,101,36,191,97,143,111,118,140,55,198,0,118,59,31,175,46,217,247,10,247,109,181,198,197,248,116,129,242,237,125,129,183,140,153,205,227,229,169,33,244,125,115,83,228,153,20,57,112,206,17,216,87,171,227,117,142,139,53,125,142,46,72,254,192,164,227,106,240,244,32,31,104,225,126,167,152,48,27,148,194,9,184,96,37,173,211,50,195,137,134,54,69,26,221,11,234,200,70,68,31,26,235,243,139,14,238,194,152,181,161,97,161,65,148,105,103,236,225,189,90,150,205,22,147,244,166,192,47,125,237,46,208,7,98,60,107,93,188,75,168,22,10,85,183,32,73,179,101,118,190,201,203,53,179,48,51,46,59,222,26,156,228,54,47,10,148,174,215,57,128,166,5,42,114,90,3,134,229,44,1,209,249,19,130,217,231,191,105,200,14,112,10,174,152,29,40,241,149,224,171,156,165,37,105,82,8,105,35,78,134,105,5,187,95,120,170,249,9,151,107,225,77,242,179,116,173,11,82,221,99,2,81,193,220,139,59,229,96,85,130,41,90,67,99,101,251,152,133,133,199,247,25,248,50,104,95,196,195,97,116,135,107,249,211,136,224,186,33,101,135,63,48,152,71,248,251,177,251,252,76,103,180,38,77,86,87,100,144,6,120,122,160,168,196,159,252,176,237,11,48,254,228,62,37,233,22,149,44,231,207,199,118,100,141,23,78,228,105,114,47,79,57,150,233,110,112,122,186,232,16,1,60,74,0,25,218,247,224,39,14,75,91,162,169,212,182,147,2,208,28,121,57,1,160,58,188,144,161,188,193,181,231,191,45,192,100,42,137,132,13,42,240,195,206,33,81,31,255,251,205,102,18,225,137,113,188,48,18,133,39,88,18,81,6,228,242,135,180,104,122,56,40,115,240,132,39,21,222,203,177,195,134,29,108,191,145,63,206,122,211,135,44,216,34,71,12,77,159,65,69,237,233,251,81,183,229,18,13,10,144,160,24,47,6,228,176,183,162,211,25,210,31,168,64,192,7,87,106,203,222,135,21,126,23,219,171,158,151,28,151,178,156,204,74,115,94,90,69,1,213,96,79,139,90,119,225,12,185,73,71,46,145,102,255,149,85,255,176,135,97,218,20,53,51,23,228,146,24,148,202,102,15,41,65,152,126,148,208,194,255,174,178,13,147,248,183,6,147,221,196,113,174,196,132,120,155,150,233,29,38,51,52,54,233,143,77,202,6,244,239,171,181,240,156,119,44,246,193,153,232,199,228,108,45,159,77,198,75,27,116,60,77,0,46,76,74,224,236,65,80,35,116,146,189,194,41,201,54,123,144,213,8,3,200,238,45,179,131,230,177,0,247,237,162,5,54,177,144,156,239,47,42,154,11,123,37,239,201,26,147,87,187,51,154,77,60,227,217,9,128,145,48,170,164,246,73,199,75,36,145,91,22,29,105,182,153,0,49,22,122,91,8,20,151,168,242,230,209,155,38,95,135,173,193,248,2,54,48,190,222,221,99,121,128,127,67,158,127,9,88,139,73,143,17,165,56,62,139,189,137,7,201,194,241,82,86,38,206,43,24,171,106,44,114,195,188,179,231,77,254,216,96,130,39,178,199,71,243,133,32,53,26,201,39,201,117,74,238,148,162,13,97,231,158,252,207,158,185,168,87,85,67,50,220,131,170,213,164,78,225,231,8,209,62,207,101,70,134,175,195,138,158,249,167,87,68,129,66,226,73,226,158,33,6,172,125,127,63,35,5,34,45,42,143,233,100,193,195,117,35,30,40,97,52,35,88,114,94,10,245,71,233,178,169,128,153,123,49,177,19,129,38,193,171,0,4,60,7,152,26,3,135,26,77,4,200,224,214,116,207,181,2,186,73,97,110,101,63,136,158,143,33,90,109,159,155,66,79,23,67,187,219,48,254,66,152,7,81,254,28,177,71,241,46,48,48,4,15,57,82,164,67,208,53,221,15,33,35,118,226,9,110,54,120,140,246,3,77,166,79,211,53,81,202,82,204,67,251,113,238,46,72,66,69,28,60,108,37,59,225,87,59,112,164,201,248,76,210,81,21,61,191,69,225,12,0,201,197,107,148,249,220,10,59,182,154,201,195,132,222,54,101,158,241,111,116,224,235,228,111,125,237,107,49,19,68,94,231,69,33,131,2,154,149,110,164,201,88,178,30,207,84,130,236,22,81,75,197,250,153,63,67,98,63,151,15,159,175,214,127,37,214,55,16,154,45,155,1,216,239,154,237,13,38,227,89,76,107,75,102,226,106,135,49,23,70,157,67,69,54,111,233,186,188,68,170,235,44,80,147,116,75,216,129,175,122,0,219,169,50,83,75,135,251,148,123,152,152,172,60,113,129,180,113,65,117,39,204,254,139,148,75,39,20,18,176,110,28,197,204,230,14,162,156,121,146,215,140,127,27,30,89,213,148,236,40,22,217,72,245,181,245,215,131,97,10,98,227,245,202,33,136,62,58,234,85,145,147,132,124,34,102,2,93,72,120,177,112,40,201,114,130,112,65,49,58,36,49,72,169,159,150,24,82,65,100,207,196,160,20,214,151,24,36,156,149,24,66,98,63,151,15,251,19,67,47,118,95,98,120,223,16,176,81,90,238,128,52,23,73,155,127,104,122,144,74,123,114,122,112,148,31,244,173,24,47,219,183,28,74,150,111,217,219,84,149,17,108,139,198,250,79,115,189,170,138,116,123,42,145,184,132,35,89,171,63,57,212,240,130,157,175,237,18,235,34,90,195,118,16,228,184,147,182,203,66,153,29,38,179,11,146,67,211,196,201,137,68,145,172,232,89,241,41,221,209,43,12,131,7,227,93,147,198,152,33,233,142,58,153,74,224,249,211,228,149,7,105,206,249,153,221,202,250,232,198,24,219,202,203,236,93,99,34,82,61,124,22,205,146,120,250,71,94,111,46,160,121,195,0,50,17,78,32,190,226,1,64,114,42,194,43,89,126,108,210,66,198,88,68,11,144,39,37,68,46,50,228,244,152,115,110,155,254,140,1,239,28,60,26,45,208,207,211,214,133,121,71,238,107,210,220,172,73,244,63,127,254,171,99,150,136,153,45,225,64,252,228,103,69,158,82,103,22,48,203,202,126,12,29,251,198,249,184,115,69,36,138,155,162,136,71,232,208,102,184,111,93,111,238,201,186,232,248,251,178,1,217,239,216,209,44,153,60,45,156,89,88,48,187,198,163,208,77,30,23,18,222,10,229,77,94,172,135,147,56,23,224,254,210,239,91,237,141,194,105,185,54,154,59,107,53,30,74,244,61,147,187,173,85,207,247,237,110,217,21,132,26,205,221,83,5,177,76,19,149,3,178,81,228,248,39,115,30,122,232,217,179,152,92,18,162,237,172,227,161,128,182,252,239,57,234,235,210,165,92,35,14,31,91,108,69,44,22,200,150,125,228,204,44,23,33,170,65,108,90,177,214,61,172,171,94,209,186,251,250,8,81,79,52,99,143,195,201,42,117,62,30,188,207,185,20,171,11,227,205,7,188,43,239,93,133,176,168,244,54,57,84,55,3,195,183,55,45,142,179,177,97,62,30,223,216,156,239,37,172,251,46,111,191,151,46,244,117,69,132,104,162,7,164,238,88,114,156,87,47,16,168,180,117,51,150,18,64,3,108,244,175,119,83,167,96,90,21,53,154,35,35,175,248,52,49,96,200,83,76,96,55,236,157,209,242,60,192,218,203,241,148,198,31,42,166,63,70,193,126,133,42,86,97,240,8,38,152,208,90,94,62,37,56,171,200,186,21,170,69,84,180,120,44,113,197,189,195,159,224,95,165,93,107,121,97,161,60,117,133,97,157,101,108,177,179,25,65,225,243,25,203,54,87,58,88,184,2,90,104,201,21,174,127,193,183,70,61,160,147,24,156,1,52,25,179,16,155,185,218,26,132,184,20,166,81,216,67,177,156,249,96,230,26,117,16,149,75,105,114,134,174,173,31,196,75,31,240,228,54,101,205,229,52,228,120,55,85,85,160,21,93,126,102,65,72,87,229,47,175,66,78,231,186,215,145,154,186,144,127,236,223,208,237,57,33,117,204,70,82,36,195,156,135,13,97,157,44,66,118,179,39,196,67,219,65,189,128,242,103,43,244,47,174,48,244,28,113,79,8,57,2,55,52,36,246,118,143,2,123,44,225,14,114,241,176,90,135,246,232,220,78,71,240,7,103,65,179,191,39,120,140,101,115,126,47,168,200,19,249,189,250,133,245,61,231,255,93,103,111,173,237,118,4,255,14,67,56,119,166,253,198,95,91,209,145,233,215,170,136,109,41,31,226,147,210,67,132,79,202,69,235,63,235,147,206,26,254,120,62,41,109,236,59,163,25,5,223,213,11,181,126,255,215,188,80,170,246,112,247,235,191,157,53,244,114,105,202,134,200,251,138,210,252,198,184,96,75,131,35,130,56,227,222,111,119,245,112,160,174,231,205,208,167,77,158,109,208,39,184,4,125,131,81,145,151,127,139,107,209,105,89,213,27,76,244,229,249,208,16,97,223,222,90,74,72,46,48,132,17,16,163,154,52,229,175,47,244,21,251,222,201,40,114,133,204,184,244,37,238,18,242,102,248,130,84,25,198,235,137,106,24,249,63,202,49,6,93,30,212,211,73,123,229,212,152,88,4,193,164,125,207,100,47,85,208,68,221,29,130,137,193,166,103,223,197,201,140,97,53,126,53,67,14,5,226,46,130,196,81,247,145,44,73,212,155,43,38,241,171,29,67,108,119,138,230,29,37,155,16,247,244,150,82,215,37,136,150,179,154,83,222,166,53,191,99,161,66,121,11,159,249,75,9,126,26,70,236,173,120,50,49,152,153,75,20,137,16,8,95,203,78,60,56,181,243,25,189,191,98,35,244,166,135,31,73,118,230,142,31,122,79,98,142,118,226,228,171,181,94,129,25,44,140,215,159,32,238,137,213,237,118,168,204,188,143,162,172,163,91,5,157,45,167,51,205,124,106,112,26,121,195,156,254,102,116,4,158,45,49,113,5,70,50,113,70,139,153,203,83,189,247,132,132,174,212,40,51,162,254,215,152,91,135,220,118,177,82,92,90,174,205,95,188,248,127,198,243,51,222,89,72,61,138,190,253,59,75,67,127,245,228,160,196,170,253,242,91,39,88,62,113,230,84,221,38,225,26,189,106,178,12,83,122,11,75,215,185,49,163,40,224,247,96,70,35,101,24,16,58,95,199,46,230,197,211,55,100,3,38,247,121,90,94,54,252,253,55,191,1,54,235,16,206,136,240,253,115,255,241,146,255,17,179,255,211,210,127,95,254,247,46,238,43,251,92,164,57,97,197,224,115,205,90,173,214,23,169,87,13,150,46,68,127,89,96,50,77,60,194,66,184,201,212,17,79,215,16,87,54,29,155,66,185,80,85,92,146,38,25,113,209,184,221,40,202,87,66,221,182,229,99,204,212,98,212,174,181,219,227,72,87,179,169,15,176,185,40,37,54,154,73,21,76,23,36,26,92,176,154,133,203,89,69,217,68,102,40,116,46,102,71,146,94,154,143,76,81,70,215,172,71,55,238,38,200,240,123,79,212,192,39,24,207,208,17,88,241,99,119,92,111,125,226,13,61,201,164,43,189,181,195,161,93,127,7,72,119,114,216,53,33,227,242,115,219,51,236,203,97,191,243,187,25,187,227,208,237,143,237,79,202,211,156,229,165,9,228,183,43,163,43,149,54,120,141,163,148,141,15,202,115,28,137,36,57,115,231,32,75,100,78,106,54,37,139,189,168,93,28,34,5,102,134,122,42,154,210,141,156,57,255,9,251,126,253,42,149,114,210,33,198,139,248,105,121,99,208,23,132,86,163,48,67,126,169,243,194,211,74,92,34,20,165,46,252,228,147,136,130,56,55,118,46,214,152,165,151,98,178,217,112,86,66,36,20,240,192,165,197,59,49,19,27,188,219,237,77,158,106,25,3,239,237,99,121,49,156,19,13,204,153,177,61,245,95,13,117,216,35,224,205,142,9,66,221,145,146,76,126,247,142,181,122,18,191,187,92,0,60,59,241,202,196,48,47,52,159,88,180,156,13,141,185,90,225,140,89,93,205,48,59,128,205,254,10,86,100,117,13,191,13,7,50,152,140,63,184,191,31,56,126,237,147,96,186,52,147,129,189,6,28,82,13,149,111,181,23,49,60,223,218,203,41,66,29,173,252,218,200,125,147,86,70,219,7,191,126,69,17,247,52,20,31,37,204,60,216,205,179,236,209,73,64,245,218,90,17,103,181,141,110,43,57,154,138,237,27,75,3,41,67,25,232,37,28,89,197,201,103,206,118,206,254,31,77,4,47,151,48,40,246,39,47,107,76,96,236,202,58,33,191,24,225,200,157,35,112,15,237,11,186,195,245,11,54,13,178,191,30,93,248,246,242,130,11,230,203,255,248,31,204,153,5,27,50,68,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("678b6b87-59e3-448c-be04-0c7ab1f1df91"));
		}

		#endregion

	}

	#endregion

}

