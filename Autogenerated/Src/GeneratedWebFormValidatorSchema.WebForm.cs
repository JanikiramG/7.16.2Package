﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GeneratedWebFormValidatorSchema

	/// <exclude/>
	public class GeneratedWebFormValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GeneratedWebFormValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GeneratedWebFormValidatorSchema(GeneratedWebFormValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("07193271-ef32-4b21-a43b-0bfbd62252bb");
			Name = "GeneratedWebFormValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,91,79,219,72,20,126,78,165,254,135,105,250,128,179,10,78,139,16,91,40,137,54,245,134,46,18,208,150,144,229,161,244,97,176,79,18,171,206,216,157,25,19,178,136,255,190,103,46,78,38,182,3,121,64,171,125,177,236,241,185,205,249,190,115,97,116,6,34,163,33,144,43,224,156,138,116,44,253,32,101,227,120,146,115,42,227,148,249,159,129,1,190,66,116,13,183,39,41,159,13,129,223,197,33,188,126,245,240,250,85,35,23,49,155,144,225,66,72,152,125,44,125,251,103,49,251,85,57,188,130,123,233,95,194,36,79,40,31,220,103,28,132,64,47,98,37,231,198,193,97,211,185,63,96,50,150,49,212,42,98,164,254,95,82,102,126,255,86,72,78,67,105,61,160,232,91,14,19,252,34,65,66,133,56,34,229,203,253,77,147,56,162,50,229,90,56,203,111,147,56,36,161,146,221,44,74,142,200,233,19,118,26,42,79,141,78,167,67,142,69,62,155,81,190,232,21,7,103,64,35,34,36,157,0,217,37,42,204,59,240,151,194,29,87,58,227,241,29,154,87,194,18,35,226,168,152,178,100,65,62,231,113,68,6,140,222,38,16,157,81,22,97,30,134,40,2,65,26,1,233,18,6,115,45,226,53,79,62,13,246,14,15,222,239,239,6,239,246,130,221,253,253,131,193,110,63,248,16,236,14,126,63,57,216,11,246,63,28,30,14,130,102,75,37,179,241,148,63,4,14,238,201,87,158,202,52,76,19,243,101,220,232,119,239,143,230,20,243,254,93,252,120,120,215,126,255,120,116,211,185,233,104,171,207,219,188,158,207,235,204,205,231,243,27,127,105,98,137,30,226,41,121,30,98,130,17,196,175,26,38,235,196,64,182,17,15,111,36,128,163,58,3,205,10,146,175,125,182,136,6,171,81,18,234,150,196,116,154,26,241,152,120,138,101,120,46,21,169,131,156,115,96,138,220,191,114,16,210,31,113,76,208,24,73,9,156,188,193,91,229,73,82,216,111,20,63,70,60,70,235,91,90,81,116,78,147,92,2,106,153,16,30,213,243,113,203,155,99,198,84,153,240,149,235,54,121,185,108,172,223,200,113,242,209,137,241,45,176,200,64,184,142,39,18,42,3,174,202,121,133,166,33,98,109,221,156,34,250,148,97,207,74,199,58,22,18,46,131,217,84,63,38,57,165,155,148,62,205,109,39,32,205,141,132,125,177,177,215,70,130,217,205,117,24,138,246,230,214,24,206,20,169,141,112,61,25,138,69,195,77,219,211,254,221,220,153,220,20,217,59,7,57,77,35,149,58,83,97,229,34,190,77,211,132,4,83,8,127,14,238,37,112,70,147,209,229,153,226,27,141,153,176,60,43,216,1,43,9,81,224,175,136,110,126,251,167,226,2,105,252,133,15,102,153,92,120,78,240,173,37,181,57,200,156,51,50,166,137,0,135,165,141,59,202,49,65,218,25,114,26,57,178,214,69,144,239,89,130,99,200,181,217,182,73,242,181,55,211,156,26,107,38,138,166,177,212,94,253,173,85,118,111,183,49,2,87,104,27,43,149,32,158,53,96,83,228,202,153,220,249,195,44,137,165,167,26,96,56,165,252,251,15,242,64,118,62,238,180,201,206,111,234,65,212,163,173,30,55,76,63,185,126,202,29,242,216,38,67,237,71,27,248,146,233,137,135,1,205,210,59,208,158,113,92,114,44,175,150,245,211,103,11,47,35,221,158,131,136,143,131,131,75,113,29,203,169,151,181,90,46,245,10,34,233,153,187,24,134,83,152,209,111,57,112,156,63,32,205,225,96,248,205,115,127,159,83,134,99,141,19,168,158,21,76,81,132,24,99,135,66,85,219,244,43,246,189,26,245,54,105,150,123,156,29,92,13,107,205,199,58,80,229,166,77,4,216,49,103,12,137,219,79,230,116,33,134,144,96,181,163,63,28,31,176,174,213,143,34,35,236,53,245,12,45,91,117,254,59,117,212,92,199,212,10,111,211,244,86,101,235,204,175,77,93,70,245,112,16,36,49,51,222,166,117,67,135,209,39,25,229,116,70,24,174,119,221,230,220,164,233,52,106,246,78,35,165,58,142,17,26,236,90,214,156,127,220,209,226,43,109,115,27,209,115,59,173,141,2,67,191,4,145,39,242,184,83,72,57,109,173,44,180,140,221,211,171,202,50,18,151,4,220,72,26,14,148,13,120,203,198,50,204,195,16,132,133,206,52,22,147,250,45,121,135,154,235,13,223,175,81,172,90,52,68,95,17,117,141,242,117,244,118,77,96,28,234,217,45,244,253,165,118,105,17,105,59,169,89,173,23,86,187,180,60,152,124,249,231,184,58,171,213,177,91,153,249,103,225,63,35,25,39,122,63,54,42,13,229,24,143,77,147,208,83,203,107,142,216,79,150,206,217,117,225,184,96,134,53,220,172,169,52,187,252,55,203,155,131,141,185,8,109,9,149,51,5,138,10,49,34,238,100,112,179,109,42,172,32,166,221,101,245,81,215,228,210,55,114,190,57,21,234,94,159,22,23,72,243,82,213,106,186,85,205,152,129,93,216,66,229,171,69,6,145,243,239,88,41,246,188,170,166,239,8,41,127,14,76,155,220,224,214,183,97,55,127,113,44,173,131,63,99,161,253,253,15,32,4,119,215,216,18,193,154,190,90,221,75,182,5,210,104,246,188,138,234,19,72,190,121,110,77,170,143,163,245,226,120,94,164,178,159,36,233,28,34,244,244,95,163,89,253,81,183,131,154,51,247,8,79,254,5,92,124,74,144,80,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07193271-ef32-4b21-a43b-0bfbd62252bb"));
		}

		#endregion

	}

	#endregion

}
