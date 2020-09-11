﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHierarchyRowDataRepositorySchema

	/// <exclude/>
	public class ForecastHierarchyRowDataRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHierarchyRowDataRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHierarchyRowDataRepositorySchema(ForecastHierarchyRowDataRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f");
			Name = "ForecastHierarchyRowDataRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,27,219,114,219,54,246,89,157,233,63,32,108,218,82,19,45,157,221,199,216,114,199,23,57,213,214,141,189,182,147,125,200,228,129,33,33,155,27,138,84,9,210,137,226,234,223,247,0,56,32,46,4,41,217,155,233,108,31,146,8,196,185,95,112,112,112,90,196,75,202,86,113,66,201,13,173,170,152,149,139,58,58,41,139,69,118,219,84,113,157,149,69,116,86,86,52,137,89,253,238,31,223,127,247,240,253,119,163,134,101,197,45,185,94,179,154,46,247,157,223,0,154,231,52,225,112,44,122,77,11,90,101,73,103,207,105,92,199,157,197,243,172,248,67,47,154,188,84,212,191,190,92,150,69,31,68,52,43,234,172,206,40,235,221,112,22,39,117,89,13,237,56,61,134,79,240,241,135,138,222,130,60,100,94,212,180,90,128,166,94,145,185,210,201,175,25,173,226,42,185,91,95,149,159,185,88,87,116,85,178,12,16,175,5,232,222,222,30,57,96,205,114,25,87,235,67,252,125,89,149,247,89,74,25,89,210,250,174,76,25,169,75,82,209,26,88,185,167,164,190,163,36,5,60,228,78,33,38,229,66,172,2,189,178,130,221,89,33,126,46,144,129,72,81,217,51,200,172,154,143,121,150,192,86,100,120,55,126,71,15,130,231,14,211,98,225,53,173,153,32,172,25,171,202,207,44,106,1,246,92,136,131,85,92,197,75,82,128,127,77,3,197,174,48,203,250,237,60,13,14,111,12,41,8,21,235,4,244,2,255,88,0,137,232,96,79,192,251,209,181,76,72,52,237,207,97,40,84,225,60,101,18,172,85,105,202,186,128,96,146,166,42,216,161,118,104,110,137,3,70,41,73,42,186,152,6,166,42,131,189,195,131,61,5,193,81,204,103,69,179,132,239,31,115,122,96,110,60,228,138,52,23,88,120,125,71,105,77,24,255,115,194,65,253,176,215,180,174,193,71,231,16,42,135,90,222,9,185,140,111,41,223,41,67,150,172,172,159,99,233,192,155,94,95,188,113,13,58,228,78,73,30,51,70,76,230,181,207,168,24,1,231,94,209,138,7,222,43,114,41,192,182,249,84,89,17,166,124,75,26,196,244,130,1,247,186,143,243,134,182,63,111,182,128,235,221,40,205,235,38,75,201,149,128,152,167,228,129,220,210,122,159,115,178,79,54,143,97,89,224,125,28,155,46,72,135,53,6,201,0,210,209,59,190,238,227,236,7,90,164,82,223,134,121,157,69,101,144,19,110,180,87,228,255,59,95,73,178,148,198,57,43,49,186,118,200,88,1,217,227,192,239,79,233,34,110,242,250,56,43,82,80,91,88,175,87,180,92,132,59,32,24,143,63,184,222,189,29,136,236,152,253,221,200,128,136,100,117,92,212,76,46,175,170,236,62,174,33,151,240,101,101,241,51,43,75,30,229,89,204,200,148,4,103,179,96,127,43,12,176,160,1,174,6,0,206,147,175,243,20,178,90,179,44,222,64,90,228,251,85,24,12,64,185,32,131,155,13,158,174,147,59,186,140,21,148,241,33,216,247,58,179,173,175,170,225,135,180,147,75,208,96,219,141,16,190,101,180,2,60,5,230,239,198,250,57,38,15,34,221,218,171,209,201,29,77,62,29,85,183,144,130,139,250,77,147,231,33,63,60,192,161,28,232,177,16,127,228,144,152,58,68,196,38,127,216,122,114,166,114,141,178,6,104,154,18,7,185,243,19,51,67,7,123,7,161,34,244,187,12,96,208,166,52,154,237,137,215,148,159,115,60,195,217,110,40,215,67,52,173,125,144,115,187,78,136,113,130,41,165,34,168,48,62,30,238,243,226,132,230,57,46,77,29,97,34,19,224,247,184,128,99,172,130,250,177,158,139,160,73,232,49,175,25,66,65,34,178,217,147,104,225,43,26,4,249,236,210,68,31,236,126,136,248,23,9,124,31,87,142,132,210,235,69,42,70,4,146,9,224,77,110,184,162,11,90,81,96,81,238,116,124,110,252,75,228,96,144,132,80,217,76,254,53,37,5,253,140,6,112,17,136,237,163,232,172,42,151,97,87,249,227,232,136,133,158,180,161,192,254,89,102,69,200,255,184,129,172,24,205,1,107,53,233,209,13,130,140,162,139,194,135,113,34,98,126,28,205,217,236,143,38,206,67,63,146,201,176,250,90,26,71,69,218,139,33,16,254,100,17,147,104,34,145,19,208,11,192,224,99,2,233,78,106,77,106,85,86,96,168,85,51,244,148,143,255,171,161,21,240,4,7,133,136,32,48,226,85,118,123,87,179,118,41,180,12,51,33,150,31,219,162,201,69,229,240,220,115,24,77,154,10,190,204,138,219,172,160,93,31,63,61,190,182,118,104,159,171,108,46,184,151,89,59,185,187,201,36,205,142,215,130,101,205,49,119,29,251,219,197,74,220,191,144,51,43,22,209,135,125,146,136,48,152,116,65,174,203,166,74,168,58,91,164,98,34,185,56,251,178,170,40,99,92,54,233,35,18,90,48,225,161,218,39,147,180,129,222,26,246,178,55,70,10,23,144,223,98,212,148,184,171,217,55,86,19,206,32,209,66,69,87,52,78,17,21,228,66,94,134,88,167,155,151,62,176,219,217,27,42,134,184,165,161,140,236,152,252,164,169,32,57,212,124,21,60,86,111,62,165,197,218,20,190,143,168,103,171,192,177,25,91,30,239,248,143,207,245,239,75,168,119,143,210,180,221,196,110,74,204,56,142,207,155,247,143,223,232,90,4,239,101,156,85,7,112,159,156,224,17,127,120,8,39,62,215,2,179,247,243,170,218,184,159,240,11,14,4,42,122,34,66,240,4,62,139,147,187,48,33,211,67,229,164,217,130,132,73,4,228,72,7,28,140,219,20,117,56,38,127,35,127,87,168,148,228,82,11,92,214,17,134,146,168,166,65,157,46,146,89,78,249,137,126,84,75,50,168,63,25,183,62,15,63,65,102,193,236,199,50,3,134,207,245,189,83,126,125,16,168,54,60,85,253,18,25,113,178,175,101,50,112,67,54,123,83,138,146,226,162,154,45,87,245,58,28,107,113,240,216,74,188,69,22,242,153,88,249,65,112,105,26,212,164,53,49,48,77,200,121,121,155,37,113,174,253,31,210,175,82,128,224,82,94,73,32,219,186,108,141,90,154,156,123,94,13,181,112,27,66,115,70,253,59,61,89,91,144,24,107,104,211,112,232,205,189,30,43,44,209,231,174,158,82,67,254,120,172,39,187,110,122,81,165,180,58,94,159,82,150,80,121,181,16,14,43,221,199,235,196,220,72,171,184,18,225,156,68,130,92,116,189,202,179,58,252,57,250,217,244,56,72,155,247,86,106,244,28,184,206,118,75,204,169,37,168,177,19,238,64,244,11,124,126,105,172,193,197,6,234,40,185,46,184,51,3,202,161,162,130,192,102,16,55,73,96,37,248,202,16,92,192,59,193,129,146,245,5,141,229,217,25,59,7,38,47,1,63,64,160,12,83,205,184,185,149,26,117,5,50,234,166,105,249,47,185,229,120,125,25,215,192,236,216,196,193,108,45,162,159,182,149,156,165,85,140,60,67,34,11,200,80,143,216,201,47,11,39,189,187,79,51,182,202,99,183,42,2,202,176,154,208,208,140,217,32,24,59,26,162,241,162,21,219,52,127,132,199,146,133,92,48,22,137,56,100,6,94,43,234,45,156,127,254,217,170,5,202,81,136,116,35,9,116,132,210,8,21,62,168,104,107,141,45,84,193,105,199,163,141,103,226,243,24,55,65,140,236,36,35,138,37,219,78,62,61,59,166,180,172,36,112,164,166,174,182,65,235,147,223,82,177,78,133,163,143,101,153,115,19,149,144,101,179,175,60,223,240,3,29,84,175,169,114,133,219,84,159,117,244,60,114,81,88,0,144,87,141,175,45,226,141,163,27,185,121,158,162,94,86,228,133,117,121,183,212,16,99,184,63,15,102,15,34,236,54,179,7,59,244,55,15,14,74,29,184,234,204,202,147,175,109,231,33,176,228,181,196,49,229,52,64,36,11,47,72,0,107,65,87,40,68,131,217,193,210,213,16,129,145,117,138,135,103,77,145,192,191,227,156,231,242,80,239,26,241,226,25,47,5,124,163,46,104,67,197,162,235,181,170,226,219,2,30,123,97,199,226,190,54,228,246,221,115,213,149,197,143,121,7,188,94,221,90,142,207,29,172,252,212,172,248,101,209,212,38,26,58,75,251,51,219,35,83,218,144,97,253,242,154,196,133,180,207,131,7,143,192,155,7,211,217,55,129,79,1,130,246,51,164,194,47,199,44,154,125,201,88,205,36,173,177,197,12,15,147,255,192,158,147,110,241,101,95,174,207,233,162,190,104,106,126,193,246,100,40,193,114,108,92,205,197,127,252,174,221,30,187,19,55,122,245,253,23,117,96,138,102,8,182,37,20,70,80,67,169,111,92,0,193,182,157,160,123,18,159,9,101,222,208,145,29,21,34,38,43,155,1,127,51,11,140,216,40,113,228,23,43,155,139,100,20,65,201,39,60,207,200,180,158,82,136,89,199,181,162,38,48,188,120,161,46,8,136,65,253,141,22,132,124,94,103,5,212,148,253,5,168,125,174,237,94,123,118,10,122,204,27,184,238,139,85,52,154,14,203,161,243,125,238,181,183,168,247,116,114,245,53,148,237,84,59,148,39,119,73,142,73,55,49,246,131,121,219,74,201,35,210,227,118,79,222,226,185,94,14,28,63,182,19,176,163,160,45,18,12,243,191,49,125,111,8,163,108,181,245,39,57,254,121,232,202,212,81,146,227,183,250,228,54,149,131,171,24,221,206,233,110,122,167,55,119,90,200,116,14,221,150,43,109,48,46,115,75,17,123,152,23,133,55,255,169,86,162,202,145,218,39,157,23,14,133,135,247,28,245,166,224,122,205,78,154,188,110,42,202,181,233,98,195,40,187,228,143,194,20,24,13,7,26,59,38,166,177,105,234,77,95,135,93,189,218,250,111,180,195,111,186,70,195,177,189,114,183,117,172,221,188,120,255,242,131,238,49,166,89,213,62,82,216,244,79,213,151,232,44,171,88,189,223,197,255,14,155,42,210,39,34,209,38,192,247,27,225,16,54,139,17,63,213,223,97,75,161,183,229,177,11,63,111,232,23,100,103,212,225,165,143,166,25,106,92,136,18,187,161,178,201,110,83,194,78,105,200,235,240,137,139,241,170,252,44,46,202,19,173,58,52,46,162,180,187,47,142,49,38,164,205,131,218,137,2,153,42,90,94,131,137,163,99,229,62,232,17,43,139,91,109,223,155,82,201,17,34,47,118,63,208,134,131,237,43,215,68,74,56,111,26,25,156,94,56,203,242,156,166,206,12,131,237,192,89,81,147,156,222,211,188,205,34,148,27,95,74,104,248,47,156,11,16,55,104,153,115,200,34,54,181,208,62,172,103,95,104,2,57,131,247,110,65,149,149,248,203,232,65,136,7,253,140,247,96,229,39,126,109,51,170,82,217,154,244,244,240,4,163,58,163,182,39,180,106,36,250,177,97,243,168,23,95,139,77,212,102,169,175,183,166,8,104,221,116,187,153,102,23,19,245,100,170,40,212,216,218,81,6,40,158,84,163,121,164,98,69,144,66,228,72,68,234,158,187,112,104,18,113,234,36,213,95,22,155,125,174,130,202,226,207,97,92,140,150,57,65,57,236,22,65,253,37,147,18,5,97,150,80,51,128,203,42,231,208,181,14,150,132,78,62,190,162,178,251,121,93,151,21,128,161,2,240,233,118,135,81,0,56,16,58,52,88,228,145,73,182,245,148,121,61,29,41,186,189,27,213,233,199,168,135,43,153,94,129,221,101,92,135,168,1,167,70,63,137,87,58,19,185,113,123,154,9,109,64,177,104,181,56,173,161,35,60,27,194,254,218,85,234,238,17,99,72,246,153,36,208,163,221,122,24,82,145,45,138,9,61,189,37,91,204,221,163,130,63,141,196,201,29,9,125,124,240,209,152,246,223,89,97,12,131,97,3,55,140,121,150,128,154,144,7,166,17,127,200,233,123,213,239,253,141,174,177,53,250,65,100,218,22,43,30,167,220,116,86,132,234,51,102,229,169,208,173,91,242,112,39,73,62,37,237,155,221,231,30,174,250,8,89,110,132,160,67,5,162,49,136,209,121,1,53,230,209,136,149,216,191,229,227,62,214,100,79,122,226,127,250,91,171,247,57,183,157,82,121,194,84,130,176,156,119,220,197,224,213,32,244,215,61,241,122,153,218,250,188,235,78,19,125,171,23,93,191,138,254,154,215,92,243,46,240,237,159,107,91,137,182,190,213,242,100,231,117,5,183,17,140,245,142,152,214,16,247,38,191,246,204,209,15,101,175,177,57,189,209,26,209,189,56,17,227,63,227,206,211,51,26,3,71,35,96,50,11,36,207,219,163,79,176,193,135,71,223,5,73,101,39,39,37,177,129,156,180,67,65,225,31,176,240,204,126,248,58,9,134,237,92,28,61,102,179,212,226,192,108,215,136,160,228,120,37,207,56,236,140,198,252,134,57,43,248,129,156,134,65,39,131,7,250,104,27,78,240,168,70,204,233,93,107,244,205,169,233,241,177,157,6,123,159,62,44,46,24,116,6,196,197,154,57,126,45,92,130,143,128,62,109,82,220,59,201,109,84,21,219,49,219,23,42,137,94,173,241,91,157,206,96,38,45,251,110,239,167,162,6,201,201,110,179,231,196,29,62,199,1,201,255,101,6,253,91,14,161,171,186,94,156,236,189,227,149,114,124,16,221,209,185,172,246,2,57,148,198,158,83,222,12,230,111,56,118,104,87,35,226,206,215,237,73,180,138,19,165,167,217,87,81,53,178,175,48,183,251,200,186,200,142,254,125,71,43,106,12,33,144,131,169,164,108,55,13,218,161,194,190,81,78,171,36,197,214,159,208,190,68,227,25,185,240,63,231,170,185,137,22,172,147,183,173,84,211,155,88,165,246,14,201,75,51,129,121,230,148,20,26,85,26,119,245,129,234,232,180,114,44,111,159,119,19,238,51,188,121,217,23,16,7,9,214,22,103,89,94,211,10,187,53,190,2,204,59,201,245,212,218,178,99,171,161,67,88,180,239,223,174,224,108,241,183,149,189,35,102,189,211,3,250,165,211,123,104,233,142,233,121,246,137,118,27,166,207,131,31,31,182,106,48,186,41,37,191,227,205,143,193,184,99,151,158,166,21,247,21,242,211,79,158,134,29,187,88,44,224,230,70,14,167,134,55,153,1,225,116,94,149,75,117,255,191,25,199,63,164,182,127,141,25,94,42,121,14,100,238,209,143,223,142,88,18,58,83,100,162,177,26,218,2,170,217,28,39,1,180,227,21,10,202,112,240,169,29,240,162,251,208,118,143,164,128,190,54,140,135,138,108,99,120,67,210,234,204,245,52,252,148,222,176,203,103,180,247,182,244,141,118,248,127,87,96,237,191,178,40,253,9,149,56,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmptyHierarchyValueLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmptyHierarchyValueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a416b392-9149-46c8-b2a6-121bc2cb969e"),
				Name = "EmptyHierarchyValue",
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f"),
				ModifiedInSchemaUId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f"));
		}

		#endregion

	}

	#endregion

}
