﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContractVisaNotificationProviderSchema

	/// <exclude/>
	public class ContractVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContractVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContractVisaNotificationProviderSchema(ContractVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54");
			Name = "ContractVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("26258d2f-5eb6-4391-98b9-20659e44f505");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,219,110,219,54,244,57,5,250,15,130,247,34,3,134,178,189,214,105,0,231,10,15,205,101,177,211,61,20,65,161,72,116,194,65,23,151,164,210,121,65,254,125,135,55,137,164,69,73,238,178,117,3,246,100,137,60,247,27,15,143,92,196,57,162,235,56,65,193,18,17,18,211,114,197,162,227,178,88,225,135,138,196,12,151,197,219,55,207,111,223,236,85,20,23,15,22,8,65,209,201,209,180,222,90,108,40,67,57,172,103,25,74,56,30,141,206,81,129,8,78,166,30,116,23,23,222,97,229,7,130,30,0,59,56,206,98,74,223,5,32,10,35,113,194,62,98,26,95,150,12,175,112,34,164,186,38,229,19,78,17,17,56,235,234,62,195,73,144,112,148,94,140,224,93,112,20,83,212,182,53,9,230,230,50,80,126,22,244,27,161,64,45,22,23,12,4,187,38,248,41,102,72,238,175,229,75,144,240,253,128,50,194,181,58,191,185,186,189,254,124,57,187,56,13,222,7,35,46,206,104,234,5,214,96,90,250,14,80,83,193,69,242,136,242,248,18,124,104,34,247,240,210,96,237,200,163,169,210,25,21,169,84,219,182,193,25,70,89,234,51,0,65,113,90,22,217,38,56,175,112,26,124,166,27,58,75,115,92,220,22,152,205,211,30,194,194,184,164,74,88,73,56,121,225,83,69,93,250,183,207,179,225,9,22,145,23,147,205,129,84,117,18,148,247,191,65,56,30,6,235,152,128,158,12,17,58,134,0,184,135,0,8,205,37,30,226,123,123,142,188,96,149,144,235,49,102,143,152,70,13,248,167,145,13,55,186,19,182,126,217,77,216,91,138,8,0,21,50,91,130,202,122,29,11,121,148,160,206,150,20,246,165,219,152,192,102,141,8,195,200,49,229,254,254,126,112,64,171,60,7,35,29,234,133,115,82,86,235,160,0,245,162,26,102,223,4,82,58,233,192,22,224,210,100,15,136,169,167,61,130,88,69,10,35,236,133,85,184,160,181,180,173,220,235,196,28,44,128,8,89,31,255,118,206,62,59,93,32,246,88,122,195,121,129,120,49,11,206,17,91,152,30,47,110,202,12,201,189,80,199,206,83,76,2,42,193,223,7,5,250,170,112,29,55,75,191,238,241,50,89,229,69,56,90,216,129,212,181,205,121,26,32,103,164,204,29,124,33,86,13,240,235,35,34,104,155,67,52,167,167,95,170,56,11,37,143,232,90,135,117,232,68,255,120,28,196,84,105,33,237,169,12,76,155,165,23,219,92,191,84,136,108,142,33,100,185,197,234,23,203,68,95,106,16,105,37,3,106,90,3,65,181,74,49,55,215,25,38,148,89,144,122,39,180,95,151,155,53,2,205,46,171,44,211,220,246,62,160,21,59,253,125,77,16,165,220,211,22,21,174,122,179,39,172,196,29,165,76,56,9,234,5,109,240,23,41,93,45,126,52,75,83,176,112,49,135,131,43,180,229,157,116,48,106,175,221,19,121,60,92,125,45,36,199,177,203,236,52,163,232,53,84,177,252,88,147,111,115,165,78,117,196,78,224,53,84,175,41,60,51,156,35,109,99,188,10,194,133,216,82,198,191,34,167,249,154,109,194,26,112,236,100,167,36,20,9,40,35,75,133,219,57,210,69,156,144,146,130,134,118,222,64,47,193,62,148,73,156,225,63,226,123,200,61,65,37,28,245,21,217,81,48,25,157,212,84,71,70,136,129,185,170,140,135,22,144,120,130,66,25,45,75,14,184,4,153,27,225,45,115,73,12,128,83,204,27,105,199,221,6,60,42,211,77,219,209,36,127,15,131,180,222,146,206,252,24,103,21,162,102,210,220,3,133,87,51,9,68,4,151,104,137,242,117,6,130,154,70,41,170,252,30,234,240,123,143,72,159,70,75,204,32,166,238,166,150,203,184,205,58,112,184,89,77,148,56,73,202,170,96,29,24,51,9,97,34,65,134,177,56,233,66,58,150,16,174,112,128,161,99,88,203,58,222,146,69,225,74,19,2,134,10,210,179,146,228,49,11,71,207,63,190,76,130,231,159,94,192,116,10,97,162,5,82,180,188,121,160,224,155,52,240,112,84,228,204,140,240,210,212,172,251,104,170,101,147,166,10,36,91,63,190,56,81,190,159,8,163,77,90,13,99,167,3,199,50,227,126,192,1,91,50,136,92,148,234,60,81,175,65,9,249,71,32,52,141,211,150,55,232,206,249,170,216,246,158,172,226,92,108,47,179,78,158,110,241,127,42,161,103,133,186,46,3,139,134,74,30,121,222,105,57,68,99,11,39,229,60,143,31,84,116,153,105,38,150,189,101,190,224,231,147,52,163,164,106,159,247,222,211,65,28,220,51,26,142,182,123,4,47,206,149,232,124,241,19,82,168,198,251,64,10,11,22,179,138,214,188,155,215,161,82,211,227,184,72,64,207,90,122,99,97,32,13,235,92,148,98,116,182,76,91,93,205,246,101,103,44,233,216,172,124,2,89,194,92,138,28,81,114,200,90,56,4,173,22,93,40,35,220,224,183,162,235,1,34,138,151,34,32,31,157,38,81,151,75,46,160,208,68,128,234,85,23,90,215,73,27,90,175,126,179,53,187,44,233,208,208,201,163,48,197,115,221,156,244,100,231,207,37,46,150,252,184,243,100,167,149,85,115,168,13,132,99,180,137,29,93,117,121,171,105,146,61,113,169,55,12,71,242,126,243,170,98,138,101,227,0,206,201,116,82,43,3,139,184,2,246,211,174,221,37,104,27,46,237,167,173,128,135,26,92,148,67,213,221,118,84,196,79,119,193,10,23,113,150,109,100,149,64,188,133,51,235,226,45,195,25,230,215,81,222,182,156,73,80,97,84,5,238,86,115,179,72,170,171,204,144,58,5,44,67,48,192,118,212,209,208,145,111,172,77,59,43,210,129,37,204,123,115,90,197,208,159,143,135,218,115,38,170,48,215,247,12,103,28,189,205,170,126,50,214,136,106,94,172,74,126,4,221,160,164,36,169,187,243,215,186,78,198,11,220,107,182,157,162,98,186,125,167,56,79,177,172,1,205,74,180,36,27,176,47,92,11,125,253,158,46,27,119,147,160,172,152,166,96,247,40,188,89,216,178,150,106,154,150,74,59,161,229,68,174,29,201,246,72,247,236,30,19,41,96,37,0,192,43,222,106,253,180,0,146,27,177,193,249,115,109,188,74,88,7,194,221,216,162,96,77,231,186,8,24,165,247,78,81,184,128,203,160,150,174,87,8,147,181,121,184,14,193,117,14,227,154,142,24,17,41,217,197,179,113,137,30,220,48,246,141,173,110,132,151,105,80,24,46,246,204,143,196,138,140,10,122,104,134,68,116,176,175,151,141,57,211,252,20,218,97,68,120,128,31,108,229,219,161,219,243,81,183,73,117,247,57,22,13,237,250,32,25,213,89,221,92,23,101,42,223,136,219,230,171,92,27,123,194,121,250,15,39,188,184,104,154,38,77,59,226,187,30,174,10,52,212,164,214,176,140,106,80,233,144,108,50,51,169,65,197,117,162,247,214,162,6,105,93,174,171,181,202,160,107,254,12,173,91,92,199,73,87,245,17,215,177,193,37,70,155,196,95,58,26,205,205,65,150,28,87,18,204,221,138,174,149,176,66,232,104,161,151,67,187,154,218,183,70,166,220,58,113,156,57,113,200,118,70,189,56,18,23,136,233,27,215,7,76,217,129,14,240,68,46,106,155,169,87,62,120,147,247,160,233,246,178,234,201,91,118,78,140,8,180,54,234,54,173,101,175,110,179,90,246,236,94,190,5,192,236,136,91,182,219,219,94,199,62,205,141,88,56,22,218,39,231,86,172,91,7,207,116,90,102,191,127,118,109,15,88,120,58,155,1,180,93,10,204,221,139,184,0,13,72,4,205,92,202,167,160,71,27,174,107,91,171,173,122,57,89,225,52,163,227,120,205,228,44,179,141,117,164,182,141,30,225,21,238,220,127,99,167,218,140,190,205,9,183,61,6,119,10,89,237,205,29,62,24,116,78,8,6,130,30,19,4,201,144,94,21,187,98,28,109,118,224,114,81,166,96,210,157,216,104,148,157,248,192,121,147,64,183,195,43,7,255,220,76,191,101,62,98,99,212,14,52,46,237,122,2,49,120,242,49,203,178,242,43,74,151,229,9,120,245,161,229,218,238,197,213,8,41,159,100,237,192,115,231,241,12,212,221,157,44,189,64,172,109,254,48,232,238,52,52,208,202,60,71,219,67,139,255,135,58,175,59,212,105,17,138,127,64,179,84,146,187,122,185,133,31,39,193,183,29,166,28,151,47,15,26,5,57,135,193,150,19,213,250,119,29,75,41,180,19,40,48,184,224,135,230,128,65,243,247,25,64,53,236,124,253,192,246,4,213,252,100,188,103,138,212,51,137,213,242,109,19,147,95,28,125,159,173,157,65,150,253,177,210,148,163,245,59,166,38,54,156,125,171,121,236,248,109,134,104,102,72,247,79,210,156,220,248,207,141,255,20,237,158,225,154,227,246,34,84,62,242,119,44,157,255,94,232,253,223,194,171,252,115,97,208,108,239,223,50,54,244,252,205,194,238,17,59,38,39,114,213,92,132,149,63,1,134,238,21,237,215,39,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2e5be659-37d8-4f91-a21c-c576c5bc1faa"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("e41d942b-483e-4e7e-a5b7-2e909b02075f"),
				CreatedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"),
				ModifiedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f7a73bbe-3b62-451c-851b-7295900f0ef2"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("e41d942b-483e-4e7e-a5b7-2e909b02075f"),
				CreatedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"),
				ModifiedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("43f62c11-f604-4b44-8370-b662b18d69af"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("bbde7dd6-3050-4dbf-a52a-de1e7d1f8df9"),
				CreatedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"),
				ModifiedInSchemaUId = new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("817a7ad5-b3e2-43e0-9db3-0b8376b57e54"));
		}

		#endregion

	}

	#endregion

}
