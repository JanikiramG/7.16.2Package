namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GeneratedWebFormServiceSchema

	/// <exclude/>
	public class GeneratedWebFormServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GeneratedWebFormServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GeneratedWebFormServiceSchema(GeneratedWebFormServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("177ef661-e736-4802-9520-b1d553edb13c");
			Name = "GeneratedWebFormService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,89,221,115,218,56,16,127,166,51,253,31,84,247,30,204,29,113,218,123,186,41,77,58,228,163,45,189,38,100,2,185,62,228,50,25,131,5,209,197,216,62,73,78,74,51,249,223,111,87,31,32,25,67,72,210,123,1,44,239,183,118,127,187,18,89,60,165,162,136,71,148,12,40,231,177,200,199,50,218,207,179,49,155,148,60,150,44,207,162,79,52,163,240,147,38,223,232,240,99,206,167,125,202,111,216,136,190,124,113,247,242,69,163,20,44,155,144,254,76,72,58,109,87,158,163,79,105,62,140,83,246,67,201,89,122,219,237,45,45,29,83,185,180,54,160,223,151,23,141,13,71,121,66,211,181,47,35,48,122,61,65,103,36,217,77,197,66,55,20,211,41,196,224,139,88,245,154,211,85,235,209,97,38,153,100,84,212,17,128,89,209,103,41,139,168,51,20,146,199,35,212,143,132,64,122,110,204,131,93,80,111,46,112,173,35,10,8,14,88,83,128,169,67,150,50,57,59,165,255,150,140,211,41,205,164,8,221,7,244,139,236,144,7,88,144,42,50,11,73,19,149,20,229,48,101,35,50,74,99,33,200,202,93,111,224,182,55,94,115,58,1,147,9,24,9,246,151,35,153,115,241,142,156,40,9,202,11,43,109,133,156,176,73,148,156,6,112,99,100,56,29,67,108,40,7,187,179,50,85,123,218,104,176,49,9,49,72,24,9,200,130,104,191,4,146,76,42,171,169,144,209,25,79,79,45,223,43,205,104,197,54,28,129,27,138,192,173,200,211,82,210,51,206,180,254,123,245,121,19,115,114,3,105,156,196,224,36,218,71,111,151,188,250,203,190,15,173,222,22,57,19,148,131,218,140,170,205,109,182,231,194,18,58,142,203,84,2,79,73,143,226,44,158,80,43,246,43,141,147,131,229,183,161,97,62,138,139,98,78,139,106,15,98,25,15,114,149,103,51,253,50,156,91,218,170,211,83,111,149,242,115,131,61,235,214,235,36,83,245,101,67,63,183,82,47,91,13,42,107,104,150,232,196,49,207,38,139,78,120,14,148,88,43,239,240,183,4,227,104,98,210,136,99,117,82,119,19,201,229,213,226,161,173,137,12,15,185,97,92,150,113,234,145,155,61,119,151,180,165,19,42,201,206,174,39,142,124,248,64,66,111,161,54,127,204,134,136,26,1,59,152,44,37,117,221,182,62,248,177,39,151,165,247,92,241,164,66,92,121,92,56,96,242,29,107,165,34,112,169,38,160,40,100,201,235,21,219,108,111,84,133,236,212,196,15,16,84,8,120,121,30,248,102,5,23,36,22,21,83,219,63,217,62,172,32,72,44,207,194,176,227,46,52,107,12,6,2,200,108,5,243,231,129,71,29,92,180,87,57,238,169,137,116,243,168,117,110,157,221,247,143,205,127,7,67,183,183,183,201,123,81,78,167,49,159,237,218,133,46,32,110,156,65,195,206,199,100,69,69,70,115,230,109,151,219,148,247,170,50,54,95,119,4,210,170,77,4,126,60,96,247,17,149,87,121,162,138,86,101,184,159,238,22,61,226,27,64,248,83,42,0,139,0,90,100,191,28,141,32,125,220,229,121,55,48,129,68,124,171,227,158,99,59,62,29,129,16,192,52,216,167,42,94,125,29,253,56,147,216,240,32,160,38,179,96,138,145,176,220,87,221,70,33,98,24,96,8,186,104,7,77,140,77,99,200,198,153,145,27,180,72,176,2,8,131,37,24,109,185,134,237,235,254,251,70,111,127,29,16,172,136,204,33,231,57,247,226,98,186,227,84,155,244,188,40,25,33,117,166,110,189,93,109,235,77,206,18,152,37,4,155,100,32,191,128,126,175,38,19,168,47,107,221,72,63,14,102,5,109,145,52,135,21,120,65,227,233,87,154,77,228,85,139,248,100,7,12,132,8,166,194,134,166,190,6,100,120,117,124,56,232,15,58,199,7,157,211,131,223,47,117,224,192,179,94,65,245,12,90,237,222,189,82,78,114,237,176,50,40,218,95,152,0,238,56,6,181,159,44,75,91,15,210,92,103,158,32,238,51,244,116,202,69,212,73,146,48,48,178,183,156,32,64,50,213,68,6,20,189,166,169,160,74,159,219,185,252,86,179,140,116,218,66,135,42,218,52,72,181,60,198,250,243,185,229,58,14,0,244,126,96,162,65,174,107,43,220,135,180,42,57,237,102,227,60,234,102,128,214,44,206,164,89,108,174,209,4,241,209,202,30,27,165,44,97,227,13,48,118,129,85,14,192,158,123,251,104,167,237,198,57,236,48,216,158,95,211,80,179,129,183,193,73,175,63,0,51,204,228,136,85,23,227,22,0,169,169,49,189,164,206,10,72,166,253,90,79,167,230,110,139,203,166,78,250,224,192,2,161,17,158,108,161,193,92,23,91,12,192,126,90,153,9,118,150,70,96,5,19,154,57,58,156,22,114,230,206,181,70,232,53,157,129,117,191,4,11,117,127,210,217,229,221,167,146,37,112,30,187,197,239,176,121,31,104,78,95,163,29,3,144,245,28,228,96,82,160,141,109,23,165,96,221,133,149,53,17,7,4,12,97,246,30,208,105,145,34,242,64,204,209,156,69,44,62,178,148,110,223,141,225,243,24,78,173,247,219,119,168,204,36,18,24,125,31,120,225,236,171,244,36,203,34,108,56,173,160,57,66,249,226,30,31,233,197,201,197,139,176,35,22,124,90,19,66,95,255,197,162,166,156,195,3,205,70,121,130,82,245,41,224,108,240,241,143,67,179,228,146,233,218,52,68,71,116,154,243,153,142,135,37,26,206,36,61,191,208,226,40,106,7,90,43,27,155,229,30,188,23,161,99,145,29,121,149,148,232,27,103,146,134,11,238,22,121,211,114,132,69,26,21,124,158,62,165,215,33,144,225,119,143,179,9,203,162,61,168,205,108,65,85,233,38,152,1,168,122,27,242,129,101,65,29,153,131,6,170,171,35,75,44,101,60,186,194,67,110,91,237,113,6,123,188,243,119,16,144,223,230,91,14,63,3,88,209,18,235,155,155,215,213,140,7,182,163,173,80,222,244,18,95,243,108,152,251,75,104,211,59,25,116,123,199,125,28,53,150,75,194,206,57,120,92,132,104,251,121,175,26,54,236,96,133,200,224,86,175,80,87,13,225,218,222,139,25,148,87,26,153,233,4,26,201,30,221,254,116,100,86,200,212,189,177,163,70,176,45,21,154,60,221,234,164,105,126,187,165,243,4,103,177,95,131,230,83,133,24,232,71,41,10,196,159,44,200,80,160,32,109,88,139,216,94,165,243,4,185,10,25,252,47,237,219,105,144,155,134,234,73,114,86,68,235,73,178,30,23,176,74,39,175,61,253,236,67,81,1,50,145,20,36,147,97,172,174,213,0,145,211,56,83,168,88,224,172,139,168,181,226,8,164,86,138,152,3,54,42,88,8,198,166,53,4,187,189,225,63,128,201,228,150,193,212,183,44,238,253,182,226,90,8,209,85,46,118,201,151,126,239,216,54,89,50,55,19,188,4,204,18,112,140,130,1,40,101,63,224,68,159,59,10,198,140,166,48,140,88,114,103,26,223,130,209,129,151,2,88,223,16,38,8,20,45,159,17,250,157,142,74,188,21,16,206,65,165,69,114,121,69,249,45,19,192,245,54,242,101,217,185,127,139,216,95,74,175,126,105,228,97,43,83,251,9,65,178,238,60,113,42,218,0,164,244,193,99,47,79,160,19,205,82,234,141,68,243,85,104,44,120,10,77,54,157,179,148,204,103,204,90,203,118,134,118,88,32,54,53,30,123,76,33,183,53,107,107,97,211,235,108,12,186,232,84,193,146,6,108,85,55,192,95,35,21,6,108,143,118,49,174,27,48,48,119,27,117,172,235,15,42,235,17,166,214,196,231,130,222,3,238,251,248,179,214,221,231,193,231,26,231,44,64,253,132,233,27,91,236,173,206,188,207,0,54,233,252,94,247,155,183,24,214,222,34,251,140,145,254,198,149,112,158,179,139,27,244,87,21,106,115,215,81,53,20,75,4,255,25,209,104,21,214,94,71,84,36,41,2,83,104,205,166,235,221,74,153,181,151,63,77,119,72,90,117,126,219,199,191,37,222,213,93,120,120,255,55,232,127,47,106,169,26,250,175,139,7,111,221,42,24,225,227,169,9,218,132,154,172,197,59,224,185,231,46,55,203,164,11,235,15,243,185,142,215,70,195,172,85,2,130,184,117,146,11,9,222,96,100,21,73,181,115,226,115,133,14,108,3,180,30,65,75,81,17,139,44,151,219,45,189,144,46,233,193,104,62,120,192,174,237,225,40,6,102,232,252,154,81,34,115,130,29,230,26,35,45,244,245,218,166,173,27,71,0,125,129,25,236,162,117,112,254,192,7,175,85,219,153,216,252,45,160,102,99,84,191,87,76,205,201,171,155,84,43,217,191,197,109,17,173,131,44,212,153,210,169,79,88,179,73,222,34,172,253,7,18,152,98,147,104,29,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNotAllowedURLMessageLocalizableString());
			LocalizableStrings.Add(CreateDataIsSavedSuccessfullyMessageLocalizableString());
			LocalizableStrings.Add(CreateUnknownWebFormIdentifierMessageLocalizableString());
			LocalizableStrings.Add(CreateLandingDisabledMessageLocalizableString());
			LocalizableStrings.Add(CreateConversionExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateOverflowExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateFormatExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNotAllowedURLMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab59051e-66d5-4ef8-885c-4a1307f76006"),
				Name = "NotAllowedURLMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDataIsSavedSuccessfullyMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fe873f3-73c3-4911-ada1-b77028b1ac25"),
				Name = "DataIsSavedSuccessfullyMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnknownWebFormIdentifierMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("29eb0044-749f-44a7-be3e-f5ca1d725a82"),
				Name = "UnknownWebFormIdentifierMessage",
				CreatedInPackageId = new Guid("a350b119-a1d4-416a-b96f-a65dc67beca4"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLandingDisabledMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ec21278c-9228-4888-ad81-2753b2f4bfc7"),
				Name = "LandingDisabledMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateConversionExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4fdb8564-ea35-4b21-8dc4-c5f118c7a7e0"),
				Name = "ConversionExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOverflowExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54e9d086-fbb8-4bea-a8f1-7611beb3aee1"),
				Name = "OverflowExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFormatExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e82e92af-f617-41f4-b061-1fe472ab96dd"),
				Name = "FormatExceptionMessage",
				CreatedInPackageId = new Guid("2cebfd9b-fa03-4242-8ecd-21cd2ca5b8ba"),
				CreatedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c"),
				ModifiedInSchemaUId = new Guid("177ef661-e736-4802-9520-b1d553edb13c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("177ef661-e736-4802-9520-b1d553edb13c"));
		}

		#endregion

	}

	#endregion

}

