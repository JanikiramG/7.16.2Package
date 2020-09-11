﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PeriodicitySettingsUtilitiesSchema

	/// <exclude/>
	public class PeriodicitySettingsUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PeriodicitySettingsUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PeriodicitySettingsUtilitiesSchema(PeriodicitySettingsUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("17643e9b-e4a0-4fef-b99d-89248119d832");
			Name = "PeriodicitySettingsUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,25,219,110,219,54,244,217,5,250,15,172,159,148,85,83,218,109,125,137,155,26,89,46,109,134,38,233,106,119,195,250,82,40,50,157,112,149,69,129,162,146,120,69,254,125,135,119,82,148,18,47,45,246,176,5,112,18,30,30,158,251,141,116,149,175,112,83,231,5,70,115,204,88,222,208,37,207,246,105,181,36,23,45,203,57,161,213,227,71,95,30,63,26,181,13,169,46,208,108,221,112,188,154,216,181,127,132,225,33,120,54,43,46,241,162,45,49,115,24,191,182,57,227,127,117,215,217,241,170,46,179,57,35,23,23,152,53,253,187,251,121,137,171,69,238,209,82,82,1,171,178,196,133,16,185,201,94,227,10,51,82,0,14,96,213,237,121,73,10,84,148,121,211,160,119,0,167,11,82,16,190,158,97,206,225,124,243,129,147,146,112,130,27,192,21,186,142,106,70,174,114,142,209,135,6,51,176,69,165,168,162,79,109,176,158,248,168,61,100,209,167,218,1,149,36,70,148,187,132,72,58,92,67,166,41,122,221,146,5,170,99,2,239,113,65,217,226,195,241,98,11,73,37,70,29,113,209,46,234,145,127,228,11,9,40,21,190,238,147,46,9,143,110,169,179,100,137,146,39,62,129,236,8,243,226,242,136,209,213,193,207,201,157,50,26,33,71,252,146,209,107,201,118,32,254,178,99,112,238,41,229,71,180,173,22,135,55,5,174,5,52,249,212,181,139,34,55,186,139,107,54,167,51,206,0,148,108,165,104,220,163,230,88,43,118,43,126,223,6,46,187,162,96,246,125,134,193,217,58,62,147,70,210,66,127,210,243,83,72,162,20,185,245,107,70,219,218,2,106,70,11,220,52,1,82,67,203,86,200,45,129,146,167,222,16,106,9,160,49,80,200,210,242,114,76,66,234,62,89,75,43,69,85,91,150,74,183,127,79,43,237,145,142,94,14,215,20,5,95,219,171,156,185,13,8,199,189,186,182,197,3,146,154,219,197,25,59,192,203,188,45,121,18,210,81,254,11,142,189,199,43,122,133,127,161,231,125,214,179,167,245,201,99,192,59,192,60,39,165,64,234,74,160,44,245,78,105,62,64,113,3,127,24,41,207,193,20,121,193,181,229,17,215,127,119,165,187,38,126,84,232,45,113,24,182,53,87,244,20,141,245,217,113,31,182,20,72,161,203,127,21,206,156,172,240,172,206,43,180,0,37,215,34,87,1,37,72,226,253,182,225,116,37,118,50,129,124,182,60,200,215,125,103,231,164,44,251,207,138,157,238,217,3,17,99,0,114,38,159,113,168,234,93,2,179,96,183,195,54,60,42,169,237,118,128,67,108,167,14,239,136,84,164,185,12,204,124,78,105,137,72,99,153,31,86,139,18,156,216,21,238,56,194,240,10,97,124,220,22,185,152,117,191,206,106,123,50,114,69,104,212,225,127,32,12,15,231,57,107,241,4,109,111,163,100,142,87,53,101,57,91,163,37,101,232,28,98,247,251,43,104,158,162,74,35,228,43,119,86,21,24,106,30,88,38,86,75,236,77,2,236,147,188,90,11,187,53,67,71,148,167,117,95,27,21,208,117,185,73,237,130,209,106,79,198,198,248,59,29,153,209,254,219,188,225,176,255,118,104,255,148,206,106,92,144,37,20,41,64,155,142,13,35,23,11,235,170,208,17,16,72,38,84,217,139,194,192,30,99,184,134,28,62,174,56,102,87,185,16,209,236,100,31,49,163,206,157,190,189,192,143,186,152,137,157,158,32,124,101,165,177,46,31,138,247,83,124,195,149,61,59,113,187,183,88,0,188,73,158,235,234,224,69,141,73,20,209,37,13,217,164,151,108,246,7,206,89,218,207,50,59,161,21,191,28,218,132,79,170,249,142,140,50,217,27,218,178,38,181,202,101,39,164,106,57,246,33,51,232,173,213,162,49,50,171,152,189,69,184,108,48,82,102,236,4,146,53,208,160,41,109,93,250,79,216,210,106,99,140,233,0,214,154,14,20,155,83,253,35,250,98,33,19,78,77,45,243,117,45,2,63,145,52,207,152,166,180,213,83,138,29,190,166,73,42,174,199,199,125,152,168,162,250,235,159,154,56,79,197,204,119,81,200,92,233,231,124,22,37,154,156,241,116,178,37,207,82,95,136,20,193,250,153,213,218,133,207,6,108,141,238,155,51,142,120,119,24,27,66,110,52,221,99,23,237,10,87,220,141,159,99,101,39,68,12,27,46,164,35,13,0,96,69,22,227,78,70,104,71,10,227,43,249,230,20,154,132,40,80,28,123,162,194,126,118,146,223,252,150,151,45,54,253,11,98,195,220,121,84,164,216,149,223,193,194,2,170,49,244,188,48,22,177,37,122,178,55,242,6,116,199,126,221,27,74,88,217,24,12,229,189,18,70,161,197,250,240,134,52,92,180,201,101,14,150,211,42,67,31,194,121,113,137,18,17,181,149,16,129,120,173,91,140,113,251,158,124,77,226,46,3,82,2,121,2,252,236,43,225,48,70,67,18,200,142,104,144,206,97,239,179,89,221,250,158,80,189,186,151,136,99,178,189,29,25,90,150,11,15,150,184,164,181,183,138,113,49,222,74,221,108,20,110,216,82,116,63,233,123,167,177,46,203,123,71,176,77,68,145,216,31,105,37,59,106,120,187,2,154,140,65,252,139,171,169,69,139,74,171,40,187,86,7,223,123,105,24,183,169,138,22,253,103,32,81,192,75,125,163,15,248,104,228,234,216,2,138,188,169,98,207,229,56,52,60,13,101,232,4,12,3,160,29,192,235,30,14,88,73,70,81,5,236,12,4,166,70,184,153,29,220,56,35,171,186,52,55,41,241,90,145,120,131,123,26,204,229,246,194,218,105,77,105,119,78,77,135,11,70,26,150,54,171,144,42,167,162,176,245,148,212,225,4,151,106,122,86,1,155,122,121,247,112,77,13,133,175,83,53,44,235,54,132,141,92,217,126,88,243,252,248,179,133,32,172,239,178,171,174,224,14,73,230,129,110,111,161,24,188,140,20,124,149,56,158,118,30,41,32,47,196,34,26,65,98,84,72,202,90,163,246,92,52,166,150,148,200,34,49,121,52,201,139,45,180,211,53,81,230,181,6,248,185,190,36,37,22,109,82,139,241,114,215,242,241,92,167,199,7,133,3,28,187,227,143,101,173,38,30,187,212,67,142,93,251,115,141,46,30,178,204,248,147,141,4,132,147,141,4,117,38,27,59,86,56,161,94,245,138,62,10,229,54,40,142,204,109,160,165,239,206,119,110,210,123,88,184,26,214,169,111,188,7,5,233,168,43,215,38,225,26,158,18,113,145,116,201,12,152,83,228,110,24,143,226,10,3,229,17,6,148,37,97,13,159,58,37,1,58,195,220,86,17,180,20,47,2,182,185,237,196,214,248,54,209,243,117,131,113,224,119,63,115,228,216,111,107,152,67,183,216,193,112,18,69,11,12,42,62,204,15,196,200,131,39,164,1,91,130,243,97,232,106,205,19,107,12,204,130,216,203,142,96,247,148,94,59,61,92,251,52,69,65,63,44,217,176,140,181,8,38,26,175,182,119,58,230,239,24,127,46,195,27,87,127,23,243,238,221,0,63,91,138,131,226,122,209,105,139,102,231,41,52,6,239,45,117,18,83,57,188,169,25,148,53,101,19,49,240,5,176,196,92,31,211,206,85,63,53,79,7,105,40,139,101,17,54,33,65,117,195,102,27,63,212,109,220,126,67,125,254,89,71,133,228,146,113,163,133,153,78,167,155,121,78,230,78,199,117,253,40,106,218,11,123,120,191,147,31,228,159,56,2,36,223,224,37,61,240,153,115,102,212,162,191,165,215,30,234,182,13,253,54,232,56,155,122,247,185,78,188,111,69,195,213,55,116,140,121,67,251,159,154,95,231,143,119,91,48,90,62,81,183,98,247,5,147,46,188,95,87,174,229,221,226,236,224,108,39,28,37,166,86,178,141,203,120,240,221,146,254,246,80,7,64,236,111,219,149,57,241,190,58,177,181,209,188,66,57,112,12,113,69,212,190,70,187,77,213,86,197,237,217,123,204,139,75,187,207,64,246,102,115,194,60,194,220,117,66,180,119,131,47,91,189,143,45,112,163,19,65,18,40,120,118,68,217,42,231,201,248,203,179,91,244,229,57,124,126,128,207,143,240,249,9,62,47,110,199,246,62,229,212,74,61,129,83,43,74,26,153,207,179,91,111,215,97,152,183,172,234,72,102,190,76,83,174,132,95,127,3,209,37,225,187,73,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("17643e9b-e4a0-4fef-b99d-89248119d832"));
		}

		#endregion

	}

	#endregion

}
