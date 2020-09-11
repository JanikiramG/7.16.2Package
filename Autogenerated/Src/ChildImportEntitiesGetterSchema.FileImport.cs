﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChildImportEntitiesGetterSchema

	/// <exclude/>
	public class ChildImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChildImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChildImportEntitiesGetterSchema(ChildImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6eb9e4aa-52ba-4b23-94c6-bb6fb8b15ae0");
			Name = "ChildImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,89,91,111,219,54,20,126,118,129,254,7,214,123,145,1,67,126,79,98,23,169,219,20,65,219,33,75,122,121,24,134,129,145,105,155,155,44,57,36,149,213,40,242,223,119,120,147,72,138,244,165,237,246,146,88,212,225,185,124,231,194,115,168,10,111,8,223,226,130,160,143,132,49,204,235,165,200,231,117,181,164,171,134,97,65,235,42,191,162,37,185,222,108,107,38,158,63,251,246,252,217,160,225,180,90,161,187,29,23,100,115,30,60,195,214,178,36,133,220,199,243,183,164,34,140,22,61,154,247,180,122,232,22,93,177,140,164,214,243,55,149,160,130,18,158,36,184,194,133,168,153,166,0,154,95,24,89,129,22,104,94,98,206,207,208,124,77,203,133,182,194,114,122,75,132,32,76,17,79,38,19,116,193,155,205,6,179,221,204,60,95,86,136,86,92,224,10,160,169,151,72,172,41,71,133,100,134,224,7,3,204,192,68,122,95,18,180,172,25,90,1,47,169,83,33,197,32,170,228,32,98,4,229,86,194,196,17,241,251,107,178,196,77,41,94,209,106,1,59,51,177,219,146,122,153,93,39,21,29,141,209,175,224,43,52,69,21,252,3,210,52,229,232,15,16,176,109,238,75,90,24,149,147,180,232,12,197,150,199,40,173,8,240,254,166,80,235,48,6,40,4,107,36,254,0,245,141,18,172,41,66,96,213,194,156,17,44,8,247,225,5,243,129,146,16,84,48,178,156,14,111,24,149,123,98,242,135,147,89,222,242,158,132,204,47,182,152,225,141,194,104,58,108,56,97,160,92,165,35,114,56,251,4,207,168,104,23,242,139,137,162,142,111,46,234,178,217,84,252,134,213,5,225,188,102,195,217,92,175,160,173,93,242,24,24,192,147,184,101,159,60,109,144,175,156,68,92,179,191,92,173,0,87,12,96,94,46,240,86,40,141,125,77,70,82,220,224,12,221,99,78,178,144,77,143,24,201,164,29,60,25,151,145,106,161,189,230,187,16,200,183,132,73,101,207,228,111,1,220,200,66,147,108,25,125,4,127,161,215,84,73,0,176,47,148,97,187,187,98,77,54,120,140,220,167,223,26,2,206,64,127,170,68,176,246,203,197,54,49,19,49,161,18,199,102,12,226,4,179,98,141,30,244,198,132,187,183,86,207,147,84,155,71,52,211,16,13,32,139,205,175,1,35,162,97,85,220,14,244,242,37,210,84,131,44,78,0,57,74,254,57,69,171,108,52,58,87,44,159,142,240,213,7,34,214,245,66,57,74,121,102,15,172,16,121,28,45,8,135,226,164,138,57,194,66,48,122,223,128,59,117,156,168,88,63,54,157,28,70,195,153,14,113,203,198,121,181,63,171,184,178,122,56,115,49,232,239,208,240,243,217,235,131,170,95,76,44,173,27,171,80,142,100,57,6,243,29,14,151,150,129,78,52,89,77,51,109,133,94,112,133,57,246,248,254,66,218,0,147,85,3,35,8,251,172,63,227,178,33,166,90,187,200,92,65,177,191,76,144,102,38,2,76,228,105,49,185,169,9,58,220,242,47,107,194,72,102,204,159,206,12,16,121,192,41,127,243,208,224,146,103,41,165,70,35,195,238,142,200,179,186,207,79,17,25,154,43,202,184,48,186,61,29,81,212,139,46,145,119,104,73,75,168,95,169,252,237,197,6,225,15,54,48,140,253,170,2,236,246,71,20,237,106,237,174,13,75,173,192,254,141,63,35,156,31,37,168,87,53,187,195,143,100,56,83,16,171,134,128,195,115,58,172,231,49,144,226,145,220,171,21,87,138,188,235,179,12,242,93,89,51,20,60,235,109,69,0,240,88,251,213,57,160,118,200,69,112,236,150,45,29,221,99,84,223,255,5,194,102,232,111,178,51,1,169,44,229,54,11,14,43,105,140,52,149,241,32,125,6,154,154,124,0,52,9,134,179,32,123,71,118,74,234,13,166,44,173,153,118,1,173,146,186,14,174,19,210,175,161,55,53,122,170,159,83,9,87,174,209,213,20,95,168,88,223,72,143,18,133,175,85,122,3,94,166,188,174,62,66,15,163,115,207,128,60,240,181,202,193,130,113,160,105,174,254,26,83,7,54,20,46,23,139,172,211,196,61,26,108,121,48,148,7,211,82,29,0,58,151,184,20,109,219,3,164,2,247,232,204,220,182,86,183,153,210,45,253,196,244,180,25,112,151,214,56,158,38,102,195,187,192,233,210,254,196,171,204,77,132,206,171,142,93,99,148,204,18,27,76,143,152,89,116,123,162,117,168,167,164,135,209,237,30,68,182,10,65,20,59,40,155,253,93,28,59,59,116,212,23,206,239,169,167,175,58,121,28,82,83,243,109,220,209,37,202,188,205,160,123,83,150,173,168,1,244,204,80,15,27,98,232,159,76,184,198,148,79,156,162,210,24,115,188,56,20,157,53,131,183,13,93,24,44,63,93,47,130,131,243,206,174,27,5,148,198,45,177,61,240,28,176,110,235,90,180,155,70,157,148,208,18,107,202,64,23,18,228,214,115,208,97,30,52,211,10,199,207,14,77,230,53,10,14,134,35,87,83,159,107,8,110,82,167,72,223,1,58,249,99,68,238,18,125,192,21,94,17,6,147,183,184,54,195,213,171,29,0,208,65,213,170,101,91,214,94,216,146,196,11,215,158,23,137,152,207,63,178,29,200,214,33,198,77,183,91,55,34,201,212,245,76,138,198,61,51,34,175,179,214,164,65,74,43,89,78,173,54,73,77,66,240,105,37,220,16,188,174,22,228,107,16,149,10,102,88,238,84,48,81,20,235,188,142,108,5,59,94,166,181,116,54,129,206,192,69,175,203,75,154,2,139,44,84,113,28,21,222,50,237,129,27,30,147,158,155,83,96,121,126,246,21,212,254,238,29,190,142,159,195,119,198,191,123,252,154,84,67,58,54,20,223,19,29,58,54,36,8,185,228,221,120,48,246,234,65,232,25,220,159,39,192,150,195,51,135,87,50,204,56,225,193,222,211,16,124,45,48,173,36,0,97,87,175,27,250,52,186,202,186,200,158,3,113,18,43,65,237,225,100,107,143,89,8,142,26,0,224,150,44,97,80,129,234,163,41,178,192,72,131,95,200,200,0,24,46,171,113,228,120,124,98,92,93,128,212,57,179,213,215,75,126,122,122,86,152,11,40,255,201,161,63,223,11,120,76,137,113,68,106,136,247,83,191,211,75,20,181,131,157,31,168,225,77,99,242,94,66,77,83,167,78,101,255,87,239,215,191,37,232,25,61,220,223,24,58,119,113,166,45,124,172,193,217,128,68,239,210,167,29,146,190,175,255,51,13,126,170,235,76,168,111,163,176,237,155,186,246,177,199,130,38,61,223,198,114,188,61,136,243,147,179,199,121,127,91,59,22,58,141,224,139,216,13,89,250,100,135,65,173,203,46,120,146,93,147,154,153,44,135,59,117,151,167,36,133,133,32,42,201,59,173,219,49,176,215,115,74,236,146,45,67,139,94,15,7,157,118,173,194,39,12,187,114,32,76,29,68,94,73,56,101,26,78,14,239,114,84,143,133,92,191,224,180,104,202,113,245,170,55,65,114,31,192,211,46,24,195,171,124,90,173,193,73,98,81,23,230,158,62,253,153,96,56,113,111,197,31,41,19,208,163,35,24,190,155,13,97,248,190,36,230,82,116,38,79,204,125,105,104,157,245,158,114,209,238,105,75,154,110,30,220,119,137,209,42,146,197,193,128,101,245,111,163,67,102,67,250,80,56,118,74,58,177,72,160,169,29,136,210,163,171,91,163,188,177,212,72,222,91,241,82,155,199,201,130,115,30,164,94,180,130,72,48,163,249,28,84,45,133,170,27,170,243,186,129,86,123,54,69,221,135,70,53,224,200,249,69,240,252,3,254,170,100,40,222,102,143,218,226,156,233,90,33,39,193,72,184,160,47,115,0,210,144,52,248,42,211,111,58,101,42,221,226,106,69,178,144,169,67,11,188,111,9,7,135,169,27,85,93,235,252,215,173,181,37,148,195,108,223,185,255,115,96,14,81,190,172,64,163,14,178,255,0,177,227,1,139,116,57,118,243,249,17,229,201,124,210,13,195,116,95,47,148,252,150,203,200,150,129,227,32,208,142,191,29,179,205,133,230,208,203,223,179,61,55,168,114,251,49,159,227,140,137,169,153,247,71,77,109,171,231,119,218,156,188,60,136,218,30,82,157,138,66,162,10,254,40,8,39,223,138,250,24,164,202,250,217,129,239,126,17,216,14,1,162,87,253,197,167,127,1,10,16,110,170,185,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6eb9e4aa-52ba-4b23-94c6-bb6fb8b15ae0"));
		}

		#endregion

	}

	#endregion

}
