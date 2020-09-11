﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SchemaDataBindingControllerSchema

	/// <exclude/>
	public class SchemaDataBindingControllerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SchemaDataBindingControllerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SchemaDataBindingControllerSchema(SchemaDataBindingControllerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0afa307d-9af3-4f01-be55-3496175fc7ae");
			Name = "SchemaDataBindingController";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,27,93,111,227,184,241,217,7,220,127,224,185,197,65,70,93,165,207,151,216,139,205,215,213,232,102,55,77,178,237,195,225,16,40,18,237,168,149,37,135,148,178,49,130,252,247,14,191,36,146,34,105,57,201,2,45,250,146,181,200,225,112,190,103,56,228,150,201,26,211,77,146,98,116,131,9,73,104,181,172,227,147,170,92,230,171,134,36,117,94,149,63,254,240,252,227,15,163,134,230,229,10,93,111,105,141,215,135,214,55,192,23,5,78,25,48,141,127,197,37,38,121,26,132,249,114,247,47,248,121,81,101,184,232,193,125,202,203,135,110,80,167,105,189,174,74,247,12,193,190,241,248,172,172,243,58,199,212,11,112,158,164,117,69,66,16,151,73,250,239,100,197,1,0,228,15,4,175,128,9,116,82,36,148,254,130,78,147,58,57,206,203,12,214,129,212,106,194,184,36,87,152,54,69,205,193,15,14,14,208,17,109,214,235,132,108,231,242,91,76,163,101,69,208,194,185,94,173,59,208,22,110,154,187,34,79,81,202,182,13,239,58,122,230,59,183,148,94,146,106,131,9,19,194,47,232,146,99,17,243,54,105,124,96,65,209,157,64,140,104,147,166,152,210,101,83,196,45,184,78,145,34,233,174,170,10,116,45,128,209,51,90,225,250,16,81,246,231,37,176,207,167,156,214,168,90,194,4,198,40,37,120,57,27,47,64,253,255,72,138,60,227,102,119,1,216,64,234,227,131,121,120,247,211,156,27,21,140,30,253,218,228,217,20,117,134,118,228,196,56,159,75,5,200,111,7,205,92,122,184,204,132,0,249,183,224,197,26,180,108,193,167,204,78,123,121,89,99,178,100,206,230,85,60,115,182,81,64,191,136,59,88,82,99,57,79,35,90,19,174,174,244,30,175,147,207,224,206,83,196,36,241,219,239,136,224,180,34,217,34,163,98,4,209,45,149,198,252,117,145,77,14,7,178,117,205,17,251,121,251,237,20,47,19,160,76,206,70,245,118,131,171,101,228,230,112,50,69,140,68,52,67,227,0,222,241,228,119,219,228,3,208,200,47,122,219,23,206,115,92,100,204,15,72,254,8,50,20,147,27,241,1,226,74,178,170,44,182,72,74,244,54,51,24,187,4,43,205,159,24,229,201,234,110,124,168,175,236,17,119,93,147,38,173,27,130,191,220,213,73,14,10,99,68,225,167,26,221,82,207,140,129,79,103,231,34,41,27,48,25,182,132,160,219,181,246,117,232,36,158,121,214,145,224,96,142,110,153,51,227,236,184,41,179,2,44,125,134,74,252,205,128,136,38,135,78,123,119,71,15,82,213,224,90,56,11,56,246,87,10,100,166,85,89,10,31,244,57,175,194,196,225,79,90,112,251,115,104,56,105,229,141,42,41,86,70,3,147,235,78,2,134,235,206,59,49,227,40,71,94,221,162,15,31,80,228,159,157,241,213,35,238,110,34,29,109,33,141,214,71,131,41,155,71,2,195,136,105,23,198,196,78,21,249,72,86,205,26,151,117,52,110,12,177,142,167,150,156,39,19,101,6,78,233,202,237,145,110,124,59,229,234,181,97,227,67,137,78,71,45,196,101,140,204,80,79,58,62,252,74,24,111,151,133,207,37,52,172,3,50,170,6,237,22,25,31,217,36,36,89,163,18,66,227,204,38,112,110,187,212,209,1,135,214,179,96,32,58,70,150,75,153,216,39,136,39,156,145,5,52,179,192,120,168,121,9,139,229,2,215,247,85,47,184,58,101,2,250,67,105,67,8,232,3,109,68,70,66,77,153,63,52,24,229,25,12,230,203,220,107,97,124,132,96,208,117,73,231,151,222,197,71,7,10,70,143,146,60,13,194,238,39,98,243,46,27,70,74,16,143,9,81,164,117,179,204,254,88,41,104,20,198,49,84,172,215,184,174,89,18,102,22,9,149,70,131,165,241,153,226,156,162,177,185,225,34,27,139,148,28,159,173,55,245,150,167,226,209,40,95,162,168,183,117,188,160,159,171,154,131,69,19,69,228,72,240,214,39,84,32,122,225,127,37,204,155,9,167,117,181,238,118,112,16,254,98,166,209,199,10,100,252,49,203,204,42,43,226,162,87,21,201,128,50,13,65,21,94,17,181,124,10,75,151,161,186,87,149,173,226,75,9,138,137,212,152,136,77,170,226,27,178,109,37,208,17,87,53,53,98,134,176,150,96,29,177,157,10,250,115,49,99,58,41,65,189,75,166,178,39,72,179,52,50,184,136,111,42,150,124,163,137,212,248,11,194,5,197,10,99,144,80,192,173,17,104,96,157,104,90,127,149,46,66,98,205,193,22,228,239,55,232,64,195,98,49,246,33,254,88,130,101,163,217,12,65,148,196,173,120,153,248,137,89,167,207,144,31,77,124,158,19,38,88,33,138,81,159,229,142,91,19,107,204,117,47,88,51,201,223,45,213,179,167,20,111,152,230,111,170,176,128,91,64,132,213,175,87,10,115,79,183,145,21,223,206,85,74,112,167,152,166,36,223,64,174,66,89,247,83,32,145,49,160,75,53,29,176,90,46,11,231,150,73,137,30,16,180,67,177,26,251,147,54,118,93,3,238,27,2,7,35,129,199,144,166,169,48,73,140,1,17,201,127,111,224,228,17,159,49,254,167,61,26,36,133,78,246,13,153,201,13,156,128,81,39,20,203,142,36,122,211,219,153,207,234,35,18,40,100,156,142,160,231,176,202,80,41,172,206,135,188,152,224,77,6,96,33,81,88,66,73,85,175,65,238,172,138,115,60,87,69,96,91,198,26,117,72,15,129,98,105,60,135,114,128,237,35,221,193,204,209,22,2,149,178,63,43,210,85,47,162,174,208,29,239,19,36,172,180,132,137,102,147,177,159,158,52,47,237,16,34,123,175,48,98,168,35,127,101,141,108,198,229,209,89,177,227,72,44,45,40,164,106,113,208,178,211,244,31,199,207,206,179,228,203,237,115,15,7,111,88,109,175,219,195,252,203,88,207,233,44,42,118,2,4,83,85,116,65,102,185,230,76,71,19,136,140,155,2,92,41,26,255,25,146,245,120,44,173,238,61,104,185,125,238,54,151,132,121,66,227,177,118,238,148,73,111,15,161,239,39,101,243,144,203,189,110,39,43,42,186,187,120,224,13,173,5,229,9,124,81,234,156,188,150,15,41,123,47,43,232,231,159,173,163,58,171,216,216,25,143,14,101,197,165,135,147,2,39,68,167,159,138,234,67,82,101,239,200,160,35,39,182,80,154,58,225,78,201,203,65,217,4,12,64,71,150,68,88,164,13,33,151,26,86,221,69,81,35,76,197,224,149,93,29,112,100,251,183,3,163,201,180,111,11,3,14,57,187,123,33,199,77,94,100,122,139,83,87,221,223,27,76,182,227,131,57,143,115,50,54,190,57,72,107,123,249,205,148,245,84,191,95,236,222,193,110,47,98,171,126,65,15,184,205,100,103,244,225,29,34,54,11,157,152,62,72,59,233,237,102,29,147,13,47,187,72,74,176,20,72,249,67,195,10,236,19,75,209,113,228,96,132,205,186,4,119,255,88,124,75,216,225,139,153,164,180,102,177,2,140,0,39,233,61,138,248,249,147,131,67,181,219,223,80,96,162,109,236,99,59,65,192,19,195,145,88,24,235,1,174,141,163,63,237,14,164,45,17,50,127,10,116,151,73,125,239,164,229,60,47,106,38,51,5,132,59,178,56,93,98,94,150,65,240,45,34,133,24,253,103,94,223,95,50,3,194,12,36,82,168,214,96,84,57,133,130,154,87,114,15,77,82,72,103,31,141,58,98,166,157,110,85,189,255,210,73,67,237,250,169,90,229,105,82,124,217,96,113,234,5,113,219,67,44,99,166,117,252,133,56,142,205,128,202,140,132,166,157,118,97,133,85,25,234,150,233,93,205,84,55,255,254,226,118,221,161,69,117,172,232,209,104,180,140,123,72,17,201,26,51,74,61,60,68,133,66,139,222,127,243,223,216,252,119,199,47,29,129,113,81,50,110,187,76,172,29,227,143,123,158,184,230,17,83,103,252,76,216,238,153,55,152,147,243,198,39,152,123,61,196,73,135,150,151,54,222,138,58,96,160,210,131,141,110,154,65,151,4,176,99,41,128,237,140,183,114,169,140,138,174,21,114,42,22,49,87,70,72,52,155,135,216,23,107,218,88,38,137,209,130,171,10,74,11,122,94,145,20,127,229,135,145,14,196,24,238,96,255,134,183,58,12,124,202,224,53,233,215,31,222,62,188,232,129,180,5,195,182,59,143,129,195,82,10,71,162,129,206,199,241,252,111,187,158,190,110,67,240,99,94,53,84,84,133,6,59,129,2,147,215,95,164,90,179,96,199,154,209,170,0,27,82,221,236,64,155,86,107,192,6,1,64,162,78,90,221,81,219,137,101,43,193,91,26,13,185,14,94,24,234,84,119,177,129,0,98,234,127,64,248,16,134,28,162,197,212,1,171,180,154,162,208,19,155,214,191,211,18,220,95,193,40,18,146,222,111,21,213,54,105,29,85,38,65,214,134,90,27,93,223,232,39,147,142,145,185,40,238,206,22,158,9,56,155,233,125,71,57,60,160,209,216,107,157,58,201,53,170,14,19,194,93,128,236,111,13,93,33,160,36,44,136,231,23,193,126,19,153,91,54,210,161,25,108,45,175,55,151,86,139,142,237,123,42,53,170,103,115,21,171,92,125,120,186,114,181,71,74,216,173,222,102,160,82,229,3,21,239,190,84,228,165,180,209,217,163,250,65,242,91,206,106,246,154,218,17,231,255,170,50,11,165,135,83,77,114,252,169,128,124,74,34,34,241,91,138,60,175,79,246,194,220,27,170,59,110,58,14,167,11,18,178,211,223,108,128,96,224,100,119,162,251,181,126,236,19,169,191,197,214,235,163,217,29,85,135,187,104,29,82,44,143,99,162,96,109,15,103,59,15,81,140,40,181,22,10,199,166,228,50,248,203,126,155,175,221,117,244,44,80,230,251,9,155,58,222,108,13,142,86,253,176,223,171,142,79,241,6,151,25,109,7,232,190,177,140,113,108,92,80,0,53,58,151,177,245,92,173,149,239,212,35,40,39,139,131,146,180,121,125,106,164,233,93,215,192,190,75,200,80,118,15,225,219,153,238,251,222,166,8,214,247,118,52,209,123,158,113,200,96,61,254,249,106,179,48,23,236,109,20,239,144,217,140,164,150,20,133,164,128,238,121,200,249,222,121,140,6,18,25,69,5,104,236,93,210,217,219,18,205,43,250,8,59,31,143,106,69,189,237,254,175,202,10,70,5,167,182,102,181,91,75,70,235,24,226,145,54,7,204,238,206,158,112,218,136,59,234,94,3,151,2,59,167,199,221,144,246,126,38,88,151,18,61,63,202,146,109,212,109,197,110,171,73,125,67,146,146,38,18,175,2,170,193,14,212,14,35,98,187,97,175,0,216,55,238,179,7,35,105,82,51,49,105,47,10,58,166,116,34,175,128,163,59,113,171,222,167,115,228,187,25,106,1,156,193,20,120,89,38,5,197,45,84,240,13,132,118,169,237,127,94,209,182,110,121,72,36,238,194,131,53,127,193,169,202,6,251,23,245,226,167,33,13,246,191,7,114,183,206,204,55,56,239,40,67,69,163,79,148,238,113,72,100,196,145,193,134,60,105,9,72,89,63,113,132,233,54,175,42,251,65,123,247,197,216,174,7,145,87,77,105,29,92,86,194,65,252,207,133,251,113,179,237,0,142,197,99,129,138,165,91,17,136,197,220,208,240,125,245,61,195,182,120,156,249,152,147,186,73,138,65,177,187,13,217,175,125,213,223,15,204,93,172,159,121,159,48,199,226,187,59,232,110,225,39,144,179,218,70,212,190,220,146,22,226,207,54,254,176,70,157,113,205,109,89,174,255,154,0,99,255,1,176,98,109,94,176,52,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0afa307d-9af3-4f01-be55-3496175fc7ae"));
		}

		#endregion

	}

	#endregion

}
