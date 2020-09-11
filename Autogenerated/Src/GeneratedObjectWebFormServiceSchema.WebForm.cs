﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GeneratedObjectWebFormServiceSchema

	/// <exclude/>
	public class GeneratedObjectWebFormServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GeneratedObjectWebFormServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GeneratedObjectWebFormServiceSchema(GeneratedObjectWebFormServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95");
			Name = "GeneratedObjectWebFormService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,81,111,219,54,16,126,118,129,254,7,214,125,177,135,68,217,94,235,166,129,155,165,77,134,181,14,106,183,121,8,130,64,145,206,14,55,89,210,72,202,169,187,246,191,239,142,164,100,138,146,28,167,77,129,61,4,49,201,187,227,221,119,199,143,71,165,225,18,100,30,70,192,102,32,68,40,179,185,10,142,179,116,206,23,133,8,21,207,210,224,45,164,128,63,33,190,128,155,55,153,88,78,65,172,120,4,79,159,252,251,244,73,175,144,60,93,176,233,90,42,88,6,239,65,141,252,57,43,253,46,139,33,217,186,24,160,249,237,2,227,72,241,149,246,105,35,231,58,189,92,110,91,9,254,144,93,203,2,218,230,209,159,45,70,105,245,84,169,60,24,223,72,37,194,136,220,146,190,255,56,198,153,231,2,22,184,202,142,147,80,202,23,172,194,115,114,243,23,68,202,71,21,21,46,237,0,243,160,77,95,209,220,88,230,136,47,58,148,35,4,55,60,225,106,253,1,254,41,184,128,37,164,74,14,220,1,225,197,14,217,61,42,36,21,216,137,120,72,155,228,197,77,194,35,22,145,163,219,253,100,47,216,235,80,66,229,117,143,138,161,71,127,85,180,136,135,18,69,164,50,33,117,84,165,245,173,118,7,67,166,45,125,123,128,202,153,29,159,134,105,156,128,96,119,181,225,30,163,52,17,148,240,89,177,219,205,239,61,218,160,215,251,40,65,224,76,10,58,133,172,168,13,173,55,61,111,135,67,111,143,145,22,186,118,140,163,136,51,178,235,117,219,40,82,159,24,57,129,63,135,52,54,64,218,177,69,245,92,100,57,8,197,1,11,9,127,43,212,132,216,136,28,28,28,176,151,178,88,46,67,177,126,85,78,188,5,37,153,186,5,22,21,66,96,210,217,233,108,118,206,34,227,86,80,169,29,248,122,47,87,97,82,64,53,156,221,111,97,163,144,11,58,166,80,195,253,218,71,35,47,157,103,43,46,84,17,38,53,241,99,179,151,59,117,248,170,9,242,209,17,27,120,168,59,42,227,40,2,41,51,129,12,166,206,176,24,195,148,234,107,56,178,165,101,189,244,242,127,221,146,147,141,175,217,10,9,128,199,13,45,111,104,138,102,1,202,254,234,241,57,58,234,165,255,217,33,75,139,36,41,75,172,215,19,160,10,209,238,129,174,139,94,107,13,53,161,66,214,148,18,23,143,46,251,117,191,250,87,44,148,158,175,163,71,118,112,21,10,22,230,121,205,197,193,216,157,24,182,120,140,2,120,206,53,183,95,246,107,210,253,171,81,87,228,181,109,2,195,184,173,193,109,243,251,155,203,54,182,36,124,66,185,110,57,237,155,154,240,165,189,97,163,22,74,111,234,70,77,45,223,249,60,147,194,157,103,112,80,15,81,215,115,5,191,164,109,26,166,15,153,62,156,35,230,6,219,197,48,239,64,221,102,177,166,23,141,70,29,154,85,198,99,54,5,53,201,245,133,119,60,249,48,45,41,187,215,146,215,15,216,91,160,24,4,227,56,62,133,48,70,247,251,230,88,238,235,203,45,75,246,199,73,146,221,237,79,4,95,240,180,191,199,250,191,244,109,68,63,98,206,6,65,246,206,39,211,217,99,152,52,139,218,164,214,77,213,254,108,157,195,30,35,233,92,217,45,190,181,195,101,148,127,34,90,222,190,229,13,25,174,176,25,65,179,69,162,232,42,48,89,131,216,157,111,92,159,183,229,189,73,147,191,135,42,100,115,251,163,116,157,206,184,48,70,77,133,150,118,91,182,29,88,232,137,96,74,59,65,102,170,39,192,160,177,10,203,176,47,184,186,61,249,76,96,226,34,97,59,220,28,25,50,133,226,206,34,241,138,117,149,88,173,30,196,240,40,168,44,29,17,255,147,198,96,24,188,199,110,151,78,26,118,38,232,97,112,178,204,213,218,61,63,246,108,154,253,30,0,236,137,16,153,248,65,84,219,76,75,103,208,141,99,131,169,93,53,196,169,43,243,149,79,149,43,22,11,6,137,132,14,99,14,35,181,229,217,242,144,179,18,24,52,223,97,25,135,11,74,155,221,54,208,160,217,233,81,151,218,177,105,101,247,127,27,185,9,106,224,178,91,154,166,133,62,77,117,191,27,69,109,154,204,251,67,117,165,27,65,250,175,166,63,163,47,31,21,181,224,216,186,25,92,169,44,113,118,170,75,241,19,17,244,160,79,73,56,35,255,48,83,198,215,57,230,117,109,205,210,129,223,218,10,163,128,119,59,116,122,106,113,253,117,212,172,123,35,183,75,55,186,185,43,116,159,110,22,47,39,57,152,167,163,251,126,233,93,162,171,103,233,42,251,27,6,70,13,119,239,79,206,103,103,147,247,83,242,91,240,25,44,243,132,178,135,11,4,129,141,205,184,67,200,244,245,35,165,124,20,104,110,69,12,27,98,244,164,1,89,94,81,85,130,253,91,203,13,240,33,62,235,11,101,71,135,205,27,227,117,22,175,167,106,157,144,32,202,216,108,86,179,193,133,192,86,6,226,61,102,61,39,35,161,170,9,155,41,253,134,53,54,75,210,220,46,91,3,204,144,30,107,245,116,208,73,75,222,237,181,97,33,175,231,61,52,28,196,190,126,53,229,93,218,233,92,8,232,199,27,14,73,44,93,185,161,215,39,117,81,181,109,114,79,33,193,212,5,211,28,34,62,95,99,92,85,38,207,98,188,94,241,201,59,104,222,180,254,49,9,172,8,205,218,8,205,57,75,16,230,172,16,17,76,241,25,139,208,98,107,173,80,22,69,143,241,160,224,143,65,183,161,192,138,88,131,245,251,32,48,255,105,102,224,177,47,97,251,204,147,182,100,224,99,67,41,166,111,36,60,76,248,23,24,180,94,68,23,222,107,184,218,109,216,114,241,53,13,182,82,230,112,11,57,152,217,250,100,243,35,72,11,173,106,177,218,23,136,86,33,243,165,161,245,61,236,144,80,189,228,235,228,92,117,228,163,178,103,174,93,33,70,147,227,75,215,97,202,237,58,110,180,173,0,248,225,159,232,198,7,226,170,73,233,194,195,127,212,211,216,40,75,156,7,124,149,11,152,31,246,91,212,251,7,175,216,29,118,84,44,140,99,78,91,224,19,219,244,11,248,35,175,96,11,202,77,220,79,0,181,44,108,105,238,88,71,34,41,71,187,100,169,245,147,5,157,209,144,99,87,83,181,123,76,81,191,151,98,239,214,241,197,162,158,237,122,155,184,123,230,118,204,157,102,74,152,135,24,169,190,181,53,123,53,139,183,67,236,123,202,55,202,146,98,153,234,222,117,167,218,181,106,250,209,247,200,149,235,68,245,182,224,177,142,108,107,236,142,212,247,132,190,75,12,117,141,152,75,188,148,215,159,126,66,240,58,174,205,141,213,30,183,187,254,61,17,167,255,135,52,87,175,20,219,49,117,114,81,117,88,137,101,98,151,101,36,221,52,237,205,198,189,148,211,216,253,135,8,229,77,18,46,144,207,99,250,192,4,244,53,20,251,165,20,0,25,148,167,81,82,32,187,123,76,195,117,39,172,219,43,118,119,11,41,227,10,181,68,118,39,89,92,104,204,205,251,131,153,6,99,59,41,221,100,89,194,238,121,232,254,36,146,234,230,37,234,183,118,132,180,94,108,212,61,156,197,187,213,103,253,52,92,94,49,175,225,219,217,136,83,10,85,113,61,114,189,35,93,240,88,183,141,93,205,72,83,226,65,167,91,151,129,105,166,30,116,186,119,107,90,238,141,23,231,254,3,32,19,2,217,234,27,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDataIsSavedSuccessfullyMessageLocalizableString());
			LocalizableStrings.Add(CreateLandingDisabledMessageLocalizableString());
			LocalizableStrings.Add(CreateNotAllowedURLMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDataIsSavedSuccessfullyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6db1d3e6-c846-44e1-a09c-1a50c702b21d"),
				Name = "DataIsSavedSuccessfullyMessage",
				CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c"),
				CreatedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"),
				ModifiedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLandingDisabledMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d67f55cf-49e0-4c7b-b5b9-ae2c35802592"),
				Name = "LandingDisabledMessage",
				CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c"),
				CreatedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"),
				ModifiedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotAllowedURLMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("94f80c05-fb1c-490f-b4c8-39286962e741"),
				Name = "NotAllowedURLMessage",
				CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c"),
				CreatedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"),
				ModifiedInSchemaUId = new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("526433f8-1cc4-4bf1-954a-ebc25a9c9c95"));
		}

		#endregion

	}

	#endregion

}
