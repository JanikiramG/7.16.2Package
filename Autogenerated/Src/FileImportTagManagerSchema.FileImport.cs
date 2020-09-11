﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportTagManagerSchema

	/// <exclude/>
	public class FileImportTagManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportTagManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportTagManagerSchema(FileImportTagManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a80d7d9c-0ac6-4f09-988d-4b6fb7eff66b");
			Name = "FileImportTagManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,91,111,219,54,20,126,118,129,254,7,78,125,152,12,24,114,177,199,218,49,144,52,23,24,189,32,200,165,123,40,138,130,177,104,135,155,44,122,36,229,192,43,242,223,119,120,145,76,81,148,44,183,216,208,189,36,54,121,238,231,59,23,58,199,107,34,54,120,65,208,29,225,28,11,182,148,201,91,150,47,233,170,224,88,82,150,39,151,52,35,243,245,134,113,249,242,197,183,151,47,6,133,160,249,10,221,238,132,36,235,137,247,29,88,179,140,44,20,159,72,174,72,78,56,93,52,104,206,177,196,251,67,87,237,122,205,242,240,13,39,109,231,201,249,89,235,213,69,46,169,164,68,180,18,92,226,133,100,220,80,0,205,120,60,70,83,81,172,215,152,239,102,246,251,105,142,104,46,36,206,33,68,108,137,228,35,21,104,145,97,33,208,19,227,127,194,95,42,31,17,213,241,65,18,175,68,82,202,25,59,130,62,159,147,37,46,50,121,70,243,20,204,136,229,110,67,216,50,158,239,99,123,135,87,31,112,142,87,132,15,71,232,35,36,5,157,160,28,254,1,85,144,104,248,5,196,110,138,135,140,46,172,57,33,178,55,40,168,2,88,85,38,7,175,56,89,65,170,16,36,92,72,94,168,88,136,55,232,90,75,213,1,105,68,68,31,188,229,4,75,34,234,113,1,143,128,146,16,180,224,100,121,18,133,212,70,227,89,82,9,29,251,82,167,27,204,241,90,59,125,18,21,130,112,176,42,55,88,138,102,247,240,29,45,170,131,100,58,214,212,154,217,70,33,164,49,190,175,201,65,117,177,67,164,163,48,248,90,63,134,200,215,15,38,134,138,40,52,237,110,23,143,100,141,65,133,80,25,34,79,232,156,106,34,112,101,10,65,132,236,142,144,249,63,139,135,1,206,121,126,20,239,60,167,242,194,83,172,224,33,218,8,140,124,151,228,217,164,242,21,201,83,147,111,251,221,38,255,146,146,44,85,105,231,116,11,105,237,200,187,81,131,132,214,163,193,174,179,37,80,90,185,209,146,223,141,145,221,225,47,106,132,119,210,219,18,106,66,250,47,217,98,2,58,233,14,226,53,103,27,194,85,175,81,129,100,18,128,67,210,14,7,124,60,163,110,91,61,24,127,13,224,115,83,106,245,137,189,175,6,242,43,34,237,167,1,39,178,224,97,153,10,58,21,126,130,126,204,235,141,175,195,133,247,84,200,169,201,27,4,152,150,133,42,60,227,107,100,85,57,139,118,179,61,73,198,228,129,216,19,58,20,80,117,91,156,21,164,233,92,91,94,63,16,249,200,250,85,199,141,54,72,32,206,152,68,196,5,104,223,166,167,56,13,230,238,231,105,52,187,81,130,44,196,139,156,254,85,16,68,83,37,120,73,9,175,117,64,45,201,4,68,24,182,186,254,233,184,188,116,51,226,118,13,116,69,164,98,116,207,226,171,130,166,168,102,84,217,49,109,240,235,208,74,92,102,219,128,97,9,144,115,59,38,206,118,32,33,174,203,155,28,2,88,57,107,0,97,125,195,8,164,174,37,170,21,70,129,168,104,234,102,24,61,73,134,27,192,211,66,94,6,86,81,24,241,157,209,182,254,0,117,108,154,13,10,88,91,54,34,100,245,151,81,175,37,204,109,81,128,235,30,169,184,132,229,99,159,11,37,56,14,40,183,99,133,46,81,92,87,1,19,171,200,178,161,87,127,234,204,45,60,235,38,8,6,163,92,1,137,241,220,220,123,115,217,234,84,57,190,37,18,118,37,88,35,139,117,254,73,213,106,53,232,236,173,115,21,71,58,59,163,42,78,237,132,119,176,158,64,77,141,16,68,94,111,59,34,177,21,13,7,234,178,2,99,233,24,72,57,8,206,91,188,5,104,66,134,213,41,180,115,165,208,116,24,132,243,84,7,65,239,69,146,161,170,9,245,69,113,197,16,205,14,97,180,78,81,2,110,203,160,122,149,133,32,67,173,220,113,213,77,247,198,140,208,62,95,101,102,247,150,234,216,65,26,85,64,175,141,147,78,80,39,30,181,138,162,93,107,42,77,250,204,2,230,156,138,77,134,119,165,80,69,247,158,45,112,70,255,198,15,25,185,213,136,247,112,145,252,174,86,108,245,58,73,110,136,96,5,95,0,29,227,128,230,17,10,111,152,35,163,107,16,53,68,187,9,119,77,49,94,70,67,203,89,154,215,129,19,131,246,62,171,149,51,61,14,175,4,106,145,163,202,102,128,20,249,129,77,171,156,164,91,202,101,129,51,131,131,142,53,178,92,130,253,253,43,57,77,211,56,122,151,179,167,140,164,43,114,134,133,42,181,250,1,208,125,250,45,58,220,197,219,125,59,118,119,235,229,93,109,7,14,249,103,8,250,120,168,41,123,249,8,147,46,144,184,218,176,233,89,250,164,49,189,46,122,12,174,114,232,248,227,199,143,152,157,45,96,174,7,136,189,194,114,54,249,134,148,177,12,92,215,248,161,126,12,73,114,201,248,26,203,56,250,246,250,89,181,178,81,83,228,126,220,52,17,8,21,40,49,188,50,223,145,93,220,96,172,38,81,151,25,13,153,159,125,57,95,220,233,101,123,127,171,196,239,1,129,70,248,255,5,6,26,238,63,4,4,79,66,16,10,154,230,8,48,216,114,61,30,14,77,99,2,114,143,134,132,39,245,184,73,208,247,199,149,142,39,85,3,41,2,180,194,240,155,93,108,193,76,100,190,33,246,240,7,100,188,123,193,197,124,37,74,54,248,92,172,225,131,8,253,184,162,219,108,181,187,138,216,8,183,170,70,232,140,44,25,183,211,184,252,209,77,173,30,90,242,41,40,81,210,69,112,143,229,222,171,3,114,20,122,139,40,254,228,166,249,118,24,204,221,215,157,94,42,156,23,100,185,59,42,235,240,226,17,133,118,32,40,80,109,93,178,151,84,97,169,182,205,238,87,247,206,222,233,59,148,104,120,142,156,13,208,93,63,172,129,26,243,74,205,47,222,154,237,248,167,199,149,90,212,44,139,89,116,33,202,113,117,226,174,123,206,146,231,48,61,247,123,215,155,205,22,103,153,89,62,32,126,72,7,208,8,133,54,98,223,58,63,23,64,53,228,180,97,33,144,58,240,220,41,202,244,63,64,103,199,147,205,228,227,251,222,109,7,186,118,24,130,126,45,56,224,134,18,104,71,191,29,103,71,63,231,108,39,238,120,210,57,20,245,215,26,94,233,199,154,2,248,149,119,7,23,195,3,236,198,40,45,65,39,198,190,93,204,113,47,129,78,81,29,44,149,115,146,145,178,97,35,40,99,98,251,31,74,25,17,249,175,210,214,204,79,86,42,198,234,143,76,66,234,210,80,181,156,46,37,225,125,59,186,234,94,78,15,37,233,13,123,18,111,89,1,166,156,156,160,215,21,162,250,99,79,55,55,99,100,220,222,187,220,113,171,206,158,255,1,231,212,54,220,207,26,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTagTemplateLocalizableString());
			LocalizableStrings.Add(CreatePrivateTagDisplayValueLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTagTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("05e40be4-2586-4c89-a046-bf572255e7c3"),
				Name = "TagTemplate",
				CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c"),
				CreatedInSchemaUId = new Guid("a80d7d9c-0ac6-4f09-988d-4b6fb7eff66b"),
				ModifiedInSchemaUId = new Guid("a80d7d9c-0ac6-4f09-988d-4b6fb7eff66b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePrivateTagDisplayValueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fedb2d33-4074-4fef-9048-9225b0700703"),
				Name = "PrivateTagDisplayValue",
				CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c"),
				CreatedInSchemaUId = new Guid("a80d7d9c-0ac6-4f09-988d-4b6fb7eff66b"),
				ModifiedInSchemaUId = new Guid("a80d7d9c-0ac6-4f09-988d-4b6fb7eff66b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a80d7d9c-0ac6-4f09-988d-4b6fb7eff66b"));
		}

		#endregion

	}

	#endregion

}

