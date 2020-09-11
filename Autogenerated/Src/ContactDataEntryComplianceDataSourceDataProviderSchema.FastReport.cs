namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactDataEntryComplianceDataSourceDataProviderSchema

	/// <exclude/>
	public class ContactDataEntryComplianceDataSourceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactDataEntryComplianceDataSourceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactDataEntryComplianceDataSourceDataProviderSchema(ContactDataEntryComplianceDataSourceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e");
			Name = "ContactDataEntryComplianceDataSourceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("efa487c3-72d9-47e0-913f-57efbff16893");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,89,111,27,55,16,126,86,128,252,7,86,237,195,170,144,183,62,18,195,141,47,88,135,3,1,177,227,88,74,243,16,4,1,189,26,89,219,236,146,50,201,117,164,38,254,239,29,30,43,113,87,43,89,113,11,180,47,113,118,200,225,204,124,223,28,164,24,77,65,78,104,4,100,0,66,80,201,71,42,108,115,54,138,111,51,65,85,204,217,243,103,223,158,63,171,101,50,102,183,164,63,147,10,210,195,210,55,238,79,18,136,244,102,25,190,6,6,34,142,150,246,188,137,217,221,146,112,48,22,64,135,40,8,7,84,126,145,139,117,223,151,52,229,172,122,197,243,50,188,134,9,23,74,31,117,78,165,178,95,213,90,2,86,201,195,46,83,177,138,97,133,35,184,225,156,70,138,139,21,59,46,179,56,236,131,184,143,35,184,224,67,72,194,238,84,1,147,26,150,197,118,99,98,214,143,198,144,82,114,188,202,129,208,223,86,173,140,160,103,41,219,240,8,187,25,15,194,163,126,22,112,139,62,145,118,66,165,124,69,218,153,84,60,237,80,69,175,4,191,143,135,32,204,174,143,29,24,209,44,81,173,152,105,130,2,53,155,0,31,5,189,5,186,90,165,207,51,17,129,175,220,104,146,75,76,41,244,171,142,4,41,196,75,175,162,47,98,134,84,78,146,152,50,171,176,172,90,111,124,66,195,147,236,38,137,35,18,105,239,200,143,30,65,94,145,71,61,68,27,223,76,136,115,36,206,99,72,134,8,197,149,136,239,169,2,187,56,177,31,68,103,40,103,201,140,188,206,226,33,249,12,30,170,239,123,67,140,147,193,87,179,22,212,119,246,91,221,189,253,151,59,91,7,231,221,221,173,23,59,47,127,223,58,232,116,182,183,206,14,182,247,58,47,246,15,246,58,157,189,122,227,176,242,116,169,132,102,248,179,0,105,60,190,160,140,222,130,120,50,150,235,172,124,252,68,62,39,60,162,73,252,23,189,73,160,111,132,218,146,180,225,224,186,174,249,90,173,110,113,28,196,42,129,122,211,138,222,101,212,64,240,118,116,13,17,23,67,249,134,222,64,146,175,218,68,43,136,206,99,236,14,195,30,187,2,244,17,163,184,133,202,229,130,240,146,171,162,92,139,31,14,29,109,192,134,150,185,34,141,23,160,198,124,37,143,61,191,30,222,101,32,102,104,65,129,232,97,35,34,109,68,72,65,55,157,168,153,141,224,15,154,100,96,55,4,75,138,228,78,255,219,172,42,199,200,252,105,56,252,4,168,76,228,194,80,243,99,206,29,96,45,145,88,98,229,78,85,65,104,148,106,167,246,252,208,58,101,157,248,16,171,241,21,21,200,17,126,200,192,10,117,18,80,17,75,206,180,114,136,160,117,239,50,154,52,115,131,154,210,166,227,60,52,193,53,172,133,87,5,11,61,137,154,151,89,146,184,120,61,109,155,172,15,69,36,99,166,200,107,112,4,217,184,175,249,215,54,207,152,10,222,75,237,22,99,118,28,144,172,240,105,201,173,21,90,160,95,79,107,16,109,174,231,111,100,254,155,195,190,130,48,87,171,75,171,129,239,131,141,184,102,241,57,27,186,248,2,251,125,205,185,178,219,112,206,41,76,179,148,10,151,48,26,173,160,209,8,251,89,170,133,134,226,99,114,118,123,139,201,105,38,148,161,200,128,228,91,176,49,72,109,41,88,155,132,46,229,92,126,53,86,157,225,128,56,244,211,207,238,66,135,157,111,125,208,211,218,134,94,36,168,129,35,11,162,76,65,31,155,3,21,71,200,244,73,176,46,7,108,11,216,132,122,219,62,75,221,243,135,88,189,167,162,160,143,240,22,109,20,38,158,235,159,58,236,30,147,74,119,202,214,12,77,6,37,23,138,80,173,74,235,114,48,197,172,245,191,180,193,78,171,144,26,1,206,68,159,151,18,148,55,156,39,164,77,89,255,75,60,113,10,27,54,22,91,78,174,92,223,75,140,215,166,221,113,69,29,205,151,177,77,48,32,223,191,63,77,249,108,120,175,161,28,206,15,8,86,53,183,22,134,5,148,21,228,141,178,93,59,222,112,190,93,141,185,226,59,251,245,245,27,118,119,31,217,176,183,91,175,130,24,179,44,75,65,232,97,119,212,187,198,97,248,22,135,97,39,54,100,34,77,71,182,69,54,9,191,249,19,25,62,57,209,121,96,38,44,40,6,82,234,24,2,107,117,147,254,86,153,233,118,233,255,146,238,250,112,177,168,93,60,187,84,204,235,18,222,20,110,85,163,41,212,129,205,28,105,227,14,63,140,65,128,203,21,114,124,66,126,42,38,124,222,214,220,110,219,161,10,190,183,231,170,22,30,27,195,168,162,88,109,48,255,176,140,219,110,234,20,194,156,7,170,199,200,234,244,153,123,88,251,88,95,12,135,250,39,116,108,217,68,216,166,19,195,230,128,219,123,24,118,139,133,250,226,206,148,95,135,244,49,249,122,45,192,54,220,184,160,106,140,147,41,99,195,32,24,114,188,61,67,163,18,150,223,72,80,160,252,152,108,147,83,178,131,87,102,79,220,32,191,146,157,237,237,38,217,246,221,240,141,87,98,238,237,245,174,110,102,187,111,115,171,82,217,233,62,56,144,31,242,44,120,43,240,34,219,154,117,64,34,6,230,17,50,213,252,79,171,97,201,181,6,99,96,173,217,124,171,79,64,101,251,125,74,111,184,204,210,27,16,243,27,240,127,210,31,22,169,56,191,174,215,54,204,75,141,10,226,110,232,121,98,221,59,170,204,159,135,127,11,214,55,229,55,137,92,127,169,240,91,229,210,123,70,191,101,86,188,114,176,214,22,158,56,226,108,190,52,189,143,192,186,214,8,52,170,75,174,149,144,10,175,221,187,173,175,184,192,188,108,86,190,228,154,228,151,250,114,144,225,183,233,67,104,102,100,29,47,144,230,63,197,190,234,56,174,138,113,21,246,171,179,168,59,85,2,95,146,86,114,46,120,234,61,43,158,114,133,115,137,251,56,197,100,50,55,228,19,151,90,120,140,111,27,143,56,220,188,193,109,110,97,48,116,81,119,229,221,34,112,251,184,245,194,47,199,235,185,102,95,67,228,244,148,168,177,224,95,237,67,98,26,129,233,221,197,43,242,227,207,83,243,11,135,163,204,254,218,161,127,254,58,90,252,104,177,0,209,212,133,233,47,143,112,243,116,2,108,69,35,246,235,50,163,108,174,252,59,72,211,63,220,191,99,200,44,81,238,225,85,21,95,222,147,116,75,42,220,183,242,230,84,190,134,61,238,136,235,80,205,252,224,138,102,157,31,94,213,199,127,220,192,114,69,231,231,87,52,180,82,7,243,26,104,158,181,58,23,66,155,159,26,188,192,98,184,46,197,172,180,40,68,217,223,133,255,176,61,219,21,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateReportTitleLocalizableString());
			LocalizableStrings.Add(CreateQuantityOfRecordsLabelLocalizableString());
			LocalizableStrings.Add(CreateColumnLabelLocalizableString());
			LocalizableStrings.Add(CreateFilledInPercentageLabelLocalizableString());
			LocalizableStrings.Add(CreateFilledInLabelLocalizableString());
			LocalizableStrings.Add(CreateNotFilledInLabelLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateReportTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("63943904-f284-4c2b-8c09-40ebd2f68beb"),
				Name = "ReportTitle",
				CreatedInPackageId = new Guid("efa487c3-72d9-47e0-913f-57efbff16893"),
				CreatedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e"),
				ModifiedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateQuantityOfRecordsLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("00170f6c-9158-4943-830a-0fbe7a4beef7"),
				Name = "QuantityOfRecordsLabel",
				CreatedInPackageId = new Guid("efa487c3-72d9-47e0-913f-57efbff16893"),
				CreatedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e"),
				ModifiedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateColumnLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cdc9f530-a9ec-4566-b8c8-0445bfb15ba8"),
				Name = "ColumnLabel",
				CreatedInPackageId = new Guid("efa487c3-72d9-47e0-913f-57efbff16893"),
				CreatedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e"),
				ModifiedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFilledInPercentageLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d1a5b31d-a21d-4eda-af7c-08971fd8efd1"),
				Name = "FilledInPercentageLabel",
				CreatedInPackageId = new Guid("efa487c3-72d9-47e0-913f-57efbff16893"),
				CreatedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e"),
				ModifiedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFilledInLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4cbb0ef3-8cd3-487e-b927-c14c08c0f2eb"),
				Name = "FilledInLabel",
				CreatedInPackageId = new Guid("efa487c3-72d9-47e0-913f-57efbff16893"),
				CreatedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e"),
				ModifiedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotFilledInLabelLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d5ad4a57-06bf-4feb-9cda-0401d4240773"),
				Name = "NotFilledInLabel",
				CreatedInPackageId = new Guid("efa487c3-72d9-47e0-913f-57efbff16893"),
				CreatedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e"),
				ModifiedInSchemaUId = new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7168866e-bf9a-4c7d-a71f-006687219c1e"));
		}

		#endregion

	}

	#endregion

}

