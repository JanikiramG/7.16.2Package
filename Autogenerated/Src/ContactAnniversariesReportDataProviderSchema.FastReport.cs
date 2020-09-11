namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactAnniversariesReportDataProviderSchema

	/// <exclude/>
	public class ContactAnniversariesReportDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactAnniversariesReportDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactAnniversariesReportDataProviderSchema(ContactAnniversariesReportDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6");
			Name = "ContactAnniversariesReportDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,88,91,111,26,57,20,126,175,212,255,96,209,125,24,36,24,53,55,54,109,82,170,16,134,20,41,105,179,129,238,75,84,69,102,48,193,219,97,76,108,79,2,27,241,223,215,151,129,241,204,120,46,145,82,237,67,231,33,1,207,241,57,159,207,237,51,39,132,11,196,150,208,71,96,140,40,133,140,204,184,123,78,194,25,190,143,40,228,152,132,111,223,60,191,125,3,196,19,49,28,222,131,209,154,113,180,56,201,47,137,93,65,128,124,185,133,185,23,40,68,20,251,54,177,75,28,62,216,214,199,115,138,224,84,44,184,99,200,126,178,148,136,9,109,177,32,97,225,75,3,183,123,131,150,132,114,169,112,0,25,215,223,10,55,82,84,242,202,245,66,142,57,70,197,160,132,204,0,250,156,80,45,164,197,222,81,116,47,128,128,243,0,50,246,17,8,116,92,200,156,133,33,126,68,148,65,41,171,81,245,33,135,215,148,60,226,41,162,219,205,183,125,52,131,81,192,123,56,148,78,113,248,122,137,200,204,25,38,103,145,187,70,36,162,62,50,247,55,91,224,171,8,41,248,4,26,245,12,54,154,63,180,197,101,52,9,176,15,124,137,182,38,88,240,17,84,2,210,202,159,183,231,50,29,51,192,40,152,10,207,92,83,252,8,57,50,69,150,122,9,200,156,32,97,176,6,23,17,158,130,59,95,195,82,241,88,143,252,57,90,192,239,195,169,56,108,136,158,148,136,211,216,235,244,188,131,206,209,94,251,120,224,237,183,15,247,142,62,180,143,251,253,247,237,179,227,247,7,253,195,206,241,65,191,127,208,104,158,212,53,149,120,96,93,102,117,112,118,208,241,62,156,29,181,207,247,7,231,237,195,63,123,251,237,222,209,121,175,189,223,59,58,246,6,157,189,254,161,215,41,183,202,56,149,89,117,71,17,83,62,188,130,33,188,71,244,133,193,60,41,117,162,182,113,251,3,220,5,196,135,1,254,23,78,2,52,82,139,210,14,211,71,18,239,159,19,37,242,217,90,31,99,30,160,70,203,254,82,106,184,132,19,20,20,9,124,123,18,77,193,46,241,149,112,244,36,206,50,95,123,143,40,228,172,212,208,23,178,64,215,115,18,150,91,187,34,19,28,148,201,101,109,10,63,150,107,236,201,186,71,140,189,64,231,88,84,173,150,76,4,55,169,24,189,67,225,84,151,131,173,66,174,16,159,147,138,18,25,122,97,180,64,84,134,242,116,120,35,66,253,77,132,186,143,85,39,22,89,123,170,131,222,2,100,242,143,104,207,221,46,184,64,60,62,145,76,29,231,59,67,84,124,15,117,239,22,205,205,252,154,57,160,42,13,148,174,131,150,68,144,172,252,21,33,186,30,224,128,35,58,20,125,29,204,212,199,102,54,165,30,33,77,41,18,169,151,182,236,154,74,227,98,16,188,194,135,33,227,48,244,81,111,45,108,59,25,44,102,133,201,39,7,12,60,168,191,186,116,115,111,83,234,178,186,36,98,60,21,44,23,45,66,161,64,41,114,207,166,241,138,211,24,78,27,217,45,57,25,89,35,213,82,42,193,170,197,118,117,80,45,106,20,67,78,88,158,139,200,210,44,62,154,170,220,2,43,58,212,76,138,59,113,172,173,65,72,174,7,192,79,62,110,141,137,192,102,197,156,116,62,216,96,139,94,41,40,50,142,230,37,102,188,86,1,56,89,85,51,193,223,208,159,3,39,73,74,128,77,152,185,236,221,2,8,8,249,25,45,119,142,211,123,93,157,63,174,94,150,151,33,222,91,203,200,59,134,155,93,185,144,5,34,31,125,38,229,78,121,170,226,115,216,48,201,231,86,103,217,143,4,143,42,120,105,244,111,24,68,104,155,133,238,152,232,214,239,52,91,69,154,116,198,148,168,138,83,170,142,174,36,93,75,244,25,57,93,71,167,153,215,37,90,83,233,95,71,175,168,229,180,58,217,200,167,134,206,83,217,9,187,206,182,31,232,104,22,170,83,245,99,137,74,78,171,14,113,215,49,243,202,237,99,182,12,224,218,144,83,214,242,198,54,217,124,218,164,191,82,196,35,26,198,25,102,136,110,94,153,86,140,59,147,98,152,52,138,114,190,249,237,41,102,42,156,95,220,137,229,37,197,218,193,227,235,106,241,206,56,54,214,205,242,199,69,241,78,35,156,50,97,173,26,88,52,81,199,243,86,75,145,94,204,108,237,231,162,185,114,52,138,38,166,47,18,185,29,50,215,66,160,121,181,238,40,94,170,65,60,49,48,45,88,20,16,253,214,209,255,196,207,203,165,184,90,51,18,202,147,186,222,74,112,10,179,128,210,210,238,13,190,159,243,4,155,198,146,199,92,77,156,59,149,191,33,119,166,243,182,138,66,83,121,94,72,162,137,254,177,153,218,85,202,147,58,248,149,244,172,106,184,130,8,164,204,24,47,80,215,73,250,65,5,201,196,158,204,81,151,201,132,22,159,187,89,94,41,52,32,65,190,156,196,146,0,252,127,68,86,76,29,222,138,83,225,10,189,50,160,100,113,13,169,192,36,11,243,53,126,24,85,87,20,88,238,12,90,9,108,161,105,73,129,173,205,95,66,184,22,119,197,126,76,32,184,177,63,60,246,144,184,68,143,25,12,199,100,41,219,192,168,115,20,124,254,156,15,42,159,83,242,164,123,240,202,71,75,213,166,178,128,126,197,165,228,50,59,234,168,136,172,53,12,185,121,137,156,149,20,76,81,196,5,51,129,228,172,192,167,46,88,89,138,74,189,112,52,210,166,106,38,57,164,25,79,187,55,241,108,104,196,9,21,30,111,89,167,69,5,245,251,71,35,239,8,247,121,181,113,85,33,54,154,77,253,161,32,69,226,177,144,205,15,155,162,160,213,29,109,168,185,99,42,218,122,18,41,231,192,167,201,140,43,241,169,10,235,139,103,23,175,80,140,49,249,236,46,20,101,221,35,91,36,5,179,203,150,105,179,138,166,109,206,176,241,204,142,12,84,171,206,204,123,106,3,75,157,214,70,11,183,249,169,228,58,99,49,251,83,160,200,120,241,152,181,32,157,107,128,203,231,251,22,156,165,37,100,122,64,134,126,236,69,33,19,212,213,29,82,6,201,209,177,106,214,175,135,221,235,244,43,177,252,31,150,244,54,60,151,25,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateContactTitleLocalizableString());
			LocalizableStrings.Add(CreateContactNameLabelLocalizableString());
			LocalizableStrings.Add(CreateContactOwnerLabelLocalizableString());
			LocalizableStrings.Add(CreateContactBusinessPhoneLabelLocalizableString());
			LocalizableStrings.Add(CreateContactMobilePhoneLabelLocalizableString());
			LocalizableStrings.Add(CreateContactHomePhoneLabelLocalizableString());
			LocalizableStrings.Add(CreateNoteworthyEventsTitleLocalizableString());
			LocalizableStrings.Add(CreateNoteworthyEventsDateLabelLocalizableString());
			LocalizableStrings.Add(CreateNoteworthyEventsTypeLabelLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateContactTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a3ea6fe3-858f-4289-953e-eff32e7d5359"),
				Name = "ContactTitle",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactNameLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f3763488-b1f1-4f2c-9200-e950a8061f92"),
				Name = "ContactNameLabel",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactOwnerLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("446e0ff8-9068-4443-95ea-8430144c9fda"),
				Name = "ContactOwnerLabel",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactBusinessPhoneLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1c2e18e8-dd88-4275-ae0e-4bb35daaf024"),
				Name = "ContactBusinessPhoneLabel",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactMobilePhoneLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1480f944-970e-43bc-b7b7-f95d7bdc3b1d"),
				Name = "ContactMobilePhoneLabel",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateContactHomePhoneLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9de7d939-e5e0-4e9b-a1cf-2bcbfe1eb742"),
				Name = "ContactHomePhoneLabel",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoteworthyEventsTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ffcde0e7-1ba1-43dc-96b9-60a1edd7edb9"),
				Name = "NoteworthyEventsTitle",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoteworthyEventsDateLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5eb620ec-396b-44ca-ad94-05029cc294f4"),
				Name = "NoteworthyEventsDateLabel",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoteworthyEventsTypeLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("989f9d5d-ca67-49d0-aaad-e69040b20d8d"),
				Name = "NoteworthyEventsTypeLabel",
				CreatedInPackageId = new Guid("906acf31-b33e-421e-b4ec-d7d51ef64e74"),
				CreatedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"),
				ModifiedInSchemaUId = new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dca41caf-58be-4af8-bb7d-ece6f8535de6"));
		}

		#endregion

	}

	#endregion

}

