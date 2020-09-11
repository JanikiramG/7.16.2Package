﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvoiceVisaNotificationProviderSchema

	/// <exclude/>
	public class InvoiceVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvoiceVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvoiceVisaNotificationProviderSchema(InvoiceVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b");
			Name = "InvoiceVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("239e4f82-9e39-4c8d-98a1-02dd073d1a06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,89,111,227,54,16,126,118,129,254,7,194,125,145,1,67,105,95,55,7,224,156,112,177,57,26,59,219,135,69,176,80,36,58,203,66,135,151,164,178,117,131,252,247,14,47,137,148,68,89,217,38,219,110,177,79,137,200,57,63,14,103,70,35,231,81,134,217,58,138,49,90,98,74,35,86,172,120,120,84,228,43,114,95,210,136,147,34,71,143,63,254,48,42,25,201,239,209,98,195,56,206,118,27,207,64,158,166,56,22,180,44,60,195,57,166,36,174,105,108,169,20,251,214,195,227,67,239,214,73,206,9,39,152,1,1,144,252,68,241,189,176,234,40,141,24,123,131,230,249,67,65,98,252,142,176,232,162,224,100,69,98,105,244,21,45,30,72,130,169,100,89,151,119,41,137,81,44,56,182,49,160,55,232,48,98,184,107,107,138,230,246,50,2,201,143,82,126,109,19,32,192,163,156,131,93,87,148,60,68,28,171,253,181,122,64,177,216,71,140,83,225,229,217,245,229,205,213,135,139,217,249,9,218,71,99,97,207,120,215,75,108,200,180,245,61,148,150,127,139,248,35,206,162,11,56,96,139,117,139,34,77,213,201,58,222,213,238,226,60,81,30,187,238,159,18,156,38,62,223,41,142,146,34,79,55,232,172,36,9,250,192,54,108,150,100,36,191,201,9,223,34,86,162,74,203,152,23,84,8,151,135,169,101,171,131,221,114,164,193,49,145,193,25,209,205,158,242,114,138,138,187,63,32,98,15,208,58,162,224,35,199,148,77,132,192,209,27,116,7,167,31,88,203,50,252,71,35,199,96,192,36,16,110,76,248,71,194,194,154,248,253,216,166,154,39,227,91,9,244,211,179,172,189,97,152,130,203,185,186,81,168,116,30,29,43,27,91,202,210,167,126,48,65,205,26,83,113,157,92,40,119,118,118,208,30,43,179,12,80,58,48,11,103,180,40,215,40,7,239,194,138,102,199,38,210,46,153,136,150,228,10,175,123,204,245,127,35,138,121,73,115,43,222,37,40,194,208,202,218,78,237,213,149,28,108,128,140,87,159,254,110,205,62,156,206,49,255,88,120,131,121,129,69,194,67,103,152,47,236,3,207,175,139,20,171,189,192,4,206,67,68,17,83,228,251,40,199,159,53,111,227,152,213,185,142,68,42,45,179,60,24,47,220,56,234,219,22,58,45,146,83,90,100,13,126,105,86,69,240,251,71,76,113,91,67,56,103,39,159,202,40,13,148,142,240,202,68,117,224,132,254,100,130,34,166,125,80,104,106,120,89,189,244,228,130,245,91,137,233,230,8,2,86,224,85,61,56,0,125,170,72,20,70,22,213,110,69,4,121,42,33,2,172,83,66,25,119,40,205,78,224,62,46,55,107,12,126,93,148,105,106,180,141,222,226,21,63,249,115,77,49,99,226,156,29,41,194,241,122,79,98,36,142,73,3,56,69,213,130,129,251,73,89,87,153,31,206,146,4,240,205,231,80,22,3,215,222,105,143,162,206,156,61,85,69,225,242,115,174,20,78,154,186,78,82,134,95,194,19,231,24,43,241,93,39,105,238,57,230,199,240,24,232,199,4,254,231,36,195,246,129,138,181,243,40,166,5,3,187,220,80,135,22,129,191,45,226,40,37,127,69,119,112,93,164,144,96,188,37,45,10,155,143,43,161,99,43,44,192,199,50,21,225,0,42,30,32,181,133,203,66,16,46,193,162,160,50,205,241,81,113,0,157,214,93,27,59,233,247,250,176,72,54,93,213,68,253,61,64,73,181,165,78,224,93,148,150,152,217,184,220,129,132,37,206,214,169,16,252,114,200,28,90,98,109,108,242,50,187,131,4,186,239,177,236,253,120,73,56,196,195,237,174,115,112,2,186,30,30,129,174,205,18,197,113,81,230,188,135,99,166,40,108,38,184,28,60,138,251,152,142,20,133,97,178,130,13,152,76,8,26,115,39,45,115,52,187,2,17,56,20,127,120,90,208,44,226,193,248,241,231,167,41,122,252,229,9,208,211,12,83,99,147,150,69,86,40,80,220,58,133,92,210,147,108,205,55,129,166,159,84,41,197,163,81,139,179,106,142,95,166,81,189,77,166,94,182,101,154,176,106,249,104,199,218,84,135,194,84,2,56,237,4,201,189,36,130,219,190,13,3,10,101,193,33,142,113,98,110,143,126,68,5,220,74,10,145,106,85,77,209,98,55,234,164,86,187,181,66,202,250,214,153,48,27,151,183,165,30,88,18,4,9,90,133,25,11,180,57,170,112,25,51,100,119,10,5,111,158,69,247,58,208,236,75,39,151,125,249,250,26,67,145,76,0,73,217,177,178,208,102,20,165,168,218,159,39,26,107,165,219,45,238,190,98,32,139,244,140,5,227,118,63,224,99,185,148,93,46,121,192,154,211,122,30,38,96,193,35,94,178,74,115,253,56,208,100,118,20,229,49,248,88,153,110,45,12,19,225,148,64,101,68,111,107,212,234,94,90,47,52,19,37,198,213,228,49,199,49,229,66,222,32,109,133,74,156,3,184,42,187,165,39,242,0,188,0,54,177,167,50,201,105,126,245,111,163,17,52,153,85,152,39,221,144,164,102,181,73,109,82,170,75,109,86,191,20,73,63,138,45,17,230,98,105,78,249,127,213,130,108,185,185,191,22,36,95,138,186,232,185,185,206,93,154,67,218,160,130,163,195,234,240,178,231,164,76,23,236,13,105,181,110,29,161,104,40,47,75,174,213,213,216,11,53,246,249,116,137,119,68,107,90,191,232,234,160,164,104,235,48,183,138,214,180,67,161,150,73,82,55,175,61,121,242,253,45,90,145,60,74,211,141,74,12,88,52,123,118,210,187,225,36,149,163,27,209,217,156,42,82,137,168,38,111,166,120,59,41,234,247,148,1,153,9,52,6,224,126,59,220,88,208,48,111,98,128,157,229,201,176,164,229,125,41,90,69,208,125,79,134,162,57,147,89,87,120,123,74,82,193,222,133,169,95,140,51,119,154,231,171,66,148,165,107,28,23,52,105,238,252,179,246,148,139,172,246,130,125,169,204,146,205,198,84,150,88,162,174,126,189,18,46,233,6,224,133,87,62,95,67,104,178,197,237,20,21,37,55,18,220,174,69,180,15,45,176,116,75,181,212,206,73,39,167,106,237,80,53,78,166,183,247,32,164,137,181,1,64,175,117,235,117,57,160,220,200,13,161,95,120,227,117,194,169,2,183,19,71,130,51,116,235,19,96,101,220,91,45,225,28,222,244,140,117,91,141,176,85,47,220,185,214,86,222,70,249,173,228,200,225,143,182,93,254,111,189,32,15,110,33,183,13,164,174,229,41,51,148,91,71,236,153,12,201,21,21,21,236,192,14,137,112,111,199,44,219,83,185,19,104,144,49,21,241,189,215,186,110,7,205,54,144,53,219,214,230,190,224,98,129,155,30,148,34,55,55,44,48,55,237,232,91,194,248,158,185,170,177,90,52,90,244,163,24,47,168,254,111,183,189,172,59,146,142,157,99,235,242,57,27,85,173,234,216,171,138,77,199,158,219,202,116,16,216,45,65,199,118,119,221,111,224,83,191,118,171,76,119,45,223,218,191,169,215,111,110,167,191,215,78,171,242,125,223,14,220,164,39,139,84,179,233,255,219,152,64,48,225,58,31,15,75,195,53,43,27,146,130,237,244,91,179,146,170,58,108,45,96,46,142,223,199,25,175,57,206,16,242,214,197,186,92,235,226,118,37,254,7,176,163,42,133,187,141,65,165,194,105,16,132,242,225,93,128,9,64,127,117,175,227,204,158,35,171,111,5,148,136,148,128,175,180,209,210,248,112,97,150,3,183,225,113,49,226,53,62,78,38,152,54,196,246,38,222,122,76,99,190,188,54,70,53,166,121,245,124,250,80,241,236,255,48,162,236,159,43,60,206,163,28,64,164,98,96,190,103,227,116,128,136,202,131,246,34,218,87,128,54,242,168,77,162,229,133,240,182,145,8,161,135,27,1,114,199,91,160,213,139,126,181,113,207,107,190,52,169,43,165,65,59,138,214,92,125,19,232,64,49,212,187,138,177,254,58,99,127,132,113,191,212,52,82,107,21,17,207,248,162,213,55,213,26,70,121,68,49,68,118,114,153,63,147,225,112,51,92,199,121,145,192,57,60,71,137,225,120,142,22,40,229,49,180,235,162,225,19,191,150,96,95,48,206,115,25,170,147,179,38,77,102,102,54,116,82,55,75,211,226,51,78,150,197,49,156,230,125,199,172,201,199,106,232,19,49,153,29,174,241,185,179,68,232,148,159,131,241,2,243,174,129,217,144,151,254,129,209,85,100,25,110,207,216,190,207,31,95,109,254,40,167,4,178,191,104,65,40,210,237,128,89,176,46,150,77,25,130,123,208,248,210,205,174,45,43,244,250,191,57,72,213,108,199,144,90,72,46,138,173,94,232,249,106,242,245,39,166,181,42,95,11,209,158,244,219,63,97,24,89,246,108,249,96,96,140,107,203,82,223,192,125,191,162,104,76,94,221,207,231,182,25,157,95,214,141,176,225,234,191,221,121,178,22,221,63,173,109,28,74,30,104,4,253,221,67,239,79,93,182,254,200,229,5,126,230,50,100,84,252,31,25,66,123,126,145,227,246,106,61,131,56,181,106,47,62,253,13,47,242,173,91,22,42,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("08ed08f7-7782-4735-814d-1cd099187246"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("b7b94813-de23-4fcc-94bb-87dcdb99f623"),
				CreatedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"),
				ModifiedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eb7c8736-95d7-455e-94d0-683e480c79c8"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("b7b94813-de23-4fcc-94bb-87dcdb99f623"),
				CreatedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"),
				ModifiedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("31227caa-7aab-487b-bebf-5313afcf3030"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("f66fcce8-7173-41d7-8de1-d6e019c595fc"),
				CreatedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"),
				ModifiedInSchemaUId = new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3aee4e03-bc67-435d-83ce-363d27a55f3b"));
		}

		#endregion

	}

	#endregion

}
