namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls.Controls;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: InitializeDetailsSchema

	/// <exclude/>
	public class InitializeDetailsSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public InitializeDetailsSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public InitializeDetailsSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb");
			RealUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb");
			Name = "InitializeDetails";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,219,114,219,54,16,125,38,191,130,226,67,70,156,74,28,249,18,199,174,226,180,142,44,187,106,227,68,83,217,233,131,39,211,129,72,200,70,2,145,10,1,198,86,27,253,123,119,1,94,32,146,150,109,165,47,137,12,96,239,7,103,23,252,213,253,70,18,39,164,146,48,46,46,201,116,76,34,202,157,99,231,84,173,20,11,68,88,249,239,190,205,102,78,187,38,113,236,68,41,231,158,243,175,109,37,84,166,73,228,200,36,165,125,123,101,163,129,5,185,161,160,181,34,229,143,113,153,8,231,146,38,9,17,241,76,250,87,35,255,47,58,29,196,145,76,98,46,212,129,190,45,100,194,162,27,71,210,249,226,148,72,242,7,93,130,46,215,205,255,118,221,226,8,9,36,251,70,65,255,25,163,60,252,72,120,138,102,245,166,63,156,47,228,178,56,26,196,156,147,133,160,225,134,163,24,233,131,190,13,239,165,63,18,39,159,201,253,159,244,107,74,133,116,94,188,80,129,250,131,84,200,120,142,174,249,120,154,176,72,128,207,109,195,127,15,18,101,217,214,239,31,166,159,105,32,139,200,192,129,138,130,107,67,232,19,166,42,19,233,131,116,115,4,74,65,230,145,127,22,39,243,235,106,214,7,156,209,72,142,78,157,159,32,137,127,15,114,45,174,251,169,111,91,24,114,150,132,145,120,15,37,253,144,168,100,180,27,172,121,170,220,15,248,81,132,251,12,251,78,75,195,8,50,105,169,56,174,4,29,39,241,140,113,234,57,191,128,41,107,11,165,190,242,232,181,14,234,77,219,115,126,94,175,178,5,169,92,217,86,51,116,158,155,205,147,92,11,102,211,218,144,206,6,115,89,58,155,29,121,106,58,77,7,140,116,58,245,116,58,91,104,108,200,165,235,246,240,2,66,10,87,182,61,141,99,94,189,229,69,45,32,138,25,225,130,234,123,245,60,144,109,208,121,74,103,36,229,178,88,2,206,113,40,152,121,68,12,93,5,126,73,4,109,180,138,204,197,34,89,13,166,72,198,40,10,233,61,168,233,245,117,208,11,212,20,214,182,65,133,127,153,44,181,157,134,202,118,156,56,125,196,136,167,243,213,106,178,208,148,155,38,23,87,218,73,178,88,240,101,134,128,245,106,84,224,129,136,105,61,157,249,148,27,138,231,181,184,201,101,227,114,169,191,118,104,4,248,195,67,229,254,131,64,204,137,201,148,108,25,29,167,186,169,97,42,214,216,215,117,131,146,20,60,21,96,213,220,232,38,138,147,60,5,240,223,130,38,146,25,106,42,58,180,233,39,98,172,238,221,245,154,182,79,254,101,60,81,87,162,237,65,197,45,107,133,188,244,180,192,52,174,36,153,50,172,248,15,68,87,83,212,28,98,35,202,55,132,89,85,91,143,85,211,135,49,138,188,99,208,79,143,157,115,42,245,36,34,218,222,218,224,129,251,224,121,10,55,244,141,211,195,120,171,35,73,197,201,215,112,234,251,247,71,174,243,155,99,167,166,191,145,127,154,239,88,109,117,163,84,223,158,65,61,72,112,219,198,184,25,98,154,69,166,253,226,86,65,230,64,217,0,14,75,90,12,102,109,148,240,49,209,59,29,167,248,189,107,252,222,239,60,72,197,181,157,26,229,88,103,140,243,243,132,133,31,25,189,43,109,189,236,160,55,29,44,204,69,28,166,156,138,134,51,170,168,88,44,56,170,86,68,86,42,152,18,123,249,204,16,73,22,225,128,136,197,207,71,196,12,138,52,129,112,11,217,235,158,26,124,198,230,62,136,173,157,87,131,226,40,18,146,68,129,162,156,128,10,225,79,168,204,112,190,84,88,4,132,3,197,105,191,51,88,185,110,199,169,174,33,78,90,163,72,175,13,67,38,189,173,205,77,150,98,8,129,202,229,36,184,165,115,50,10,209,30,220,20,96,181,218,214,246,86,70,66,123,142,165,64,3,56,121,111,175,237,36,12,47,227,11,26,165,152,253,139,24,80,17,255,184,210,119,113,0,224,13,71,17,230,19,133,80,229,255,147,99,188,42,20,4,240,124,118,236,74,39,26,112,86,101,5,255,61,153,3,239,148,64,171,34,203,107,182,155,47,92,233,58,149,76,133,125,107,18,167,73,144,79,139,101,0,103,64,119,185,110,232,155,111,151,96,27,29,46,69,144,170,55,61,127,202,142,171,144,82,10,230,163,101,205,135,74,87,172,29,240,53,218,32,12,127,248,53,133,254,223,62,79,89,168,39,97,175,36,200,77,2,17,189,115,80,8,251,197,238,238,116,135,190,58,234,190,154,5,59,221,253,25,125,217,37,83,210,235,190,220,59,164,71,225,236,232,96,182,243,10,187,136,231,152,125,164,73,57,54,145,156,63,246,84,75,40,102,56,171,49,82,67,180,101,202,102,29,235,57,166,44,235,193,2,92,73,198,153,234,146,213,10,148,59,147,101,20,220,38,113,196,254,161,208,212,210,0,30,191,180,230,174,167,13,101,140,239,40,202,135,238,159,206,163,146,244,13,103,7,105,162,56,34,215,7,72,192,179,34,143,78,165,164,165,21,192,40,246,145,9,54,197,161,62,219,181,138,157,19,126,71,150,98,66,57,62,51,143,179,55,185,58,178,178,139,127,87,186,5,43,84,19,33,226,128,17,201,226,200,236,191,154,179,78,202,205,181,246,99,94,228,14,188,8,160,119,72,154,224,21,52,10,131,118,183,187,225,90,221,59,58,147,195,251,69,2,135,192,62,42,55,124,245,243,169,125,91,27,64,199,102,19,208,4,82,198,248,3,154,117,234,116,1,47,64,249,152,200,219,170,247,248,73,64,183,66,85,216,198,183,81,225,204,65,54,150,149,168,5,167,102,236,38,77,178,84,176,144,198,191,81,190,48,48,74,101,9,107,220,42,231,191,246,90,84,70,204,7,170,51,38,176,21,1,120,64,177,225,97,57,111,168,47,63,37,35,244,14,201,238,97,111,183,215,61,216,237,133,221,253,253,29,218,157,6,123,180,75,142,166,71,193,97,120,68,15,232,65,49,87,110,151,207,12,106,70,239,188,170,84,107,207,203,222,163,232,170,249,230,105,26,229,252,19,206,227,187,1,225,124,74,130,47,147,32,97,11,24,109,34,38,99,245,153,168,120,37,213,229,158,57,237,213,20,152,47,133,135,6,181,38,187,143,248,155,127,119,83,72,106,250,226,6,184,26,199,66,190,5,241,230,132,192,195,110,248,13,48,43,124,88,27,220,146,8,100,38,183,241,221,135,5,129,231,222,5,17,95,74,42,169,10,23,18,167,148,19,252,78,183,215,83,179,113,229,131,162,110,83,125,219,252,86,232,254,7,117,171,175,144,141,20,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSysModuleIdParameter());
			Parameters.Add(CreateDetailTabPanelParameter());
			Parameters.Add(CreateSysModuleEditIdParameter());
			Parameters.Add(CreateInModuleEditParameter());
			Parameters.Add(CreateParentSysEntitySchemaIdParameter());
			Parameters.Add(CreateUseModuleDetailsParameter());
			Parameters.Add(CreateDefaultCollapsedParameter());
			Parameters.Add(CreateDetailFilterParameter());
			Parameters.Add(CreateActiveTabIndexParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAllViewMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateNotesDetailCaptionLocalizableString());
			LocalizableStrings.Add(CreateRightsDetailCaptionLocalizableString());
			LocalizableStrings.Add(CreateLogDetailCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAllViewMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9f5cb9f4-4ec2-4add-bcfe-07d894ad55b3"),
				Name = "AllViewMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotesDetailCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dad5de2b-8fdb-486e-a135-75af1f12fd1b"),
				Name = "NotesDetailCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRightsDetailCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("09cec632-6f4b-42ea-9a3a-bdd025d09ebe"),
				Name = "RightsDetailCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLogDetailCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5f4e3b8e-3408-46b4-87f3-ec73902c017b"),
				Name = "LogDetailCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e4993c65-00e0-4e5c-a8c2-95b830004a3b"),
				Name = "SysModuleId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailTabPanelParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("12e8025f-d146-4b85-ac5d-921ec1cfa586"),
				Name = "DetailTabPanel",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleEditIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("33a54a96-838f-4c6c-9eed-82f7e7fa3f04"),
				Name = "SysModuleEditId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInModuleEditParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4d18737c-2ea7-4a70-8615-7f0104d84ea6"),
				Name = "InModuleEdit",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateParentSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("46fc17d0-52dd-4cf8-857e-65b5c2915598"),
				Name = "ParentSysEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateUseModuleDetailsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c6702671-c421-49f2-868f-117fe972ff6a"),
				Name = "UseModuleDetails",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDefaultCollapsedParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("03e8800e-f706-4211-b3be-2db5374aa124"),
				Name = "DefaultCollapsed",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDetailFilterParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4a85cb43-fe4a-41a2-bcc7-402ed1749e95"),
				Name = "DetailFilter",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTabIndexParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d0b40731-e8d7-4d89-961f-3720bce42af2"),
				Name = "ActiveTabIndex",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetDetailsMethod());
			Methods.Add(CreateGetModuleDetailsMethod());
			Methods.Add(CreateGetModuleEditDetailsMethod());
			Methods.Add(CreateCreateDetailTabMethod());
			Methods.Add(CreateFillGridViewMethod());
			Methods.Add(CreateCreateViewMenuItemMethod());
			Methods.Add(CreateGetDetailParentAssociationMethod());
			Methods.Add(CreateCreateMenuSeparatorMethod());
			Methods.Add(CreateGetAutoDetailMethod());
			Methods.Add(CreateGetModulesGridViewMethod());
			Methods.Add(CreateUpdateFiltersRightExprMetaDataByParameterValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8d11482a-2b90-4ebc-a399-95f404f10842"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("69198542-6699-45e2-bba7-d9dcdf72a3e7"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("29886dc1-d1bf-46a9-b9a5-aa4c9fe5cfe7"),
				Name = "System.Drawing",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("93658f49-d97d-46b6-a4dd-e407034cd253"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c2bd63bf-4ccc-4fe8-bf8f-e26a31e96326"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetDetailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c85adc63-5007-4060-9e9f-e6c2706c033e"),
				Name = "GetDetails",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, Guid, Guid, string, Guid, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,204,243,205,79,41,205,73,117,77,201,44,209,84,168,230,226,44,74,45,41,45,202,83,112,79,45,65,72,184,164,150,36,102,230,20,107,104,90,115,213,42,164,230,20,167,98,83,136,172,8,0,82,242,85,18,90,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleDetailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fe5d28cc-b680-4986-ad90-d0cd3c0e0e55"),
				Name = "GetModuleDetails",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, Guid, Guid, string, Guid, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,75,139,219,48,16,62,111,126,133,240,73,161,70,208,210,83,211,109,73,147,37,4,182,75,193,217,238,161,44,69,216,147,68,84,182,132,44,109,155,150,253,239,29,73,241,250,21,104,147,139,176,103,230,123,204,232,241,196,13,49,80,59,105,201,53,89,129,157,59,171,150,96,185,144,116,58,155,60,97,150,107,189,224,249,30,48,127,95,131,89,168,170,130,220,10,85,177,185,214,82,228,220,127,135,10,246,32,236,254,86,229,92,250,95,81,237,232,38,195,242,173,216,57,19,170,88,40,187,183,66,10,43,160,102,15,202,252,168,53,207,33,196,87,70,57,141,162,181,53,136,37,69,112,81,135,212,29,47,189,254,63,232,150,29,4,121,69,146,239,9,174,3,207,11,103,12,84,214,71,89,118,168,23,216,184,51,129,63,118,219,168,42,41,35,194,203,130,49,188,86,91,203,6,242,170,44,85,213,234,227,248,50,240,176,37,183,156,246,133,211,115,88,62,171,194,73,56,182,19,41,211,151,125,72,71,147,105,103,150,115,29,118,67,73,87,86,205,208,254,95,247,54,255,221,66,71,13,36,56,175,174,179,4,67,139,40,152,160,133,173,50,128,142,8,109,199,72,68,53,30,232,148,252,153,92,173,156,40,142,169,72,185,46,208,106,5,63,137,207,208,152,249,150,212,141,226,186,72,30,217,70,101,161,77,58,69,185,43,177,37,116,200,112,77,178,22,17,132,186,74,65,163,161,110,66,201,163,135,45,63,221,57,41,217,87,46,29,144,143,193,4,187,41,181,61,144,119,99,87,45,116,96,41,138,105,190,131,12,183,166,228,61,65,236,229,75,39,115,129,238,136,225,164,252,203,204,86,70,20,67,7,221,204,101,14,250,12,39,29,224,253,18,246,112,122,4,55,189,220,101,22,134,28,67,19,253,203,208,234,143,110,71,23,217,1,238,65,106,60,248,22,126,217,158,253,94,60,25,130,227,43,202,230,69,65,189,233,141,211,18,222,123,235,41,233,174,81,163,255,247,129,54,71,42,237,157,158,116,48,202,180,233,41,29,238,114,218,55,29,230,240,60,121,158,28,77,101,202,88,212,144,176,227,22,232,89,214,136,176,80,190,78,207,235,39,128,222,132,11,104,0,31,216,42,178,176,53,174,111,253,203,163,185,129,141,162,161,44,70,167,179,103,52,125,172,142,182,103,127,1,238,86,62,1,157,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModuleEditDetailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f8a999cb-aad4-49e1-b22b-5379e2a04912"),
				Name = "GetModuleEditDetails",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, Guid, Guid, string, Guid, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,149,81,107,219,48,16,199,159,147,79,33,252,164,48,99,216,216,211,210,118,100,73,8,129,180,140,57,93,31,70,25,194,190,36,98,178,101,100,169,91,55,250,221,119,146,156,218,178,3,91,18,18,17,75,119,247,255,221,73,39,63,49,69,20,212,70,104,114,77,74,248,73,54,188,214,87,91,83,9,184,90,25,158,199,164,59,214,90,241,114,31,62,221,220,208,201,116,252,132,113,160,212,92,63,167,217,1,10,118,203,74,182,7,133,65,239,107,80,115,89,150,144,105,46,203,100,57,52,154,142,249,142,80,180,187,149,185,17,176,0,205,184,168,39,228,207,120,228,209,146,89,158,127,97,229,30,232,10,116,96,68,39,168,253,66,64,212,208,154,163,40,218,205,140,150,222,202,242,141,44,32,171,170,57,67,229,33,213,172,170,4,207,152,253,239,44,146,7,174,15,27,153,49,97,31,49,75,186,77,209,124,199,247,70,57,171,196,153,221,107,46,184,230,80,39,15,82,253,168,43,150,129,155,95,41,105,42,84,37,205,199,87,138,64,206,117,3,238,204,238,88,97,89,254,17,122,217,243,34,111,72,244,61,194,177,151,195,220,40,133,91,96,103,147,244,185,158,99,37,140,114,26,77,250,121,19,68,10,225,93,172,54,40,197,106,185,211,73,143,65,22,133,44,91,8,44,104,10,214,109,193,52,163,161,114,124,78,20,191,125,157,156,124,216,248,117,115,226,147,101,178,91,216,84,49,99,149,219,39,41,76,81,30,75,248,255,0,155,236,119,235,58,200,36,194,202,245,17,35,156,158,123,209,200,114,236,164,2,228,34,180,45,42,225,229,176,188,238,4,143,108,175,52,107,62,240,58,111,90,205,174,80,191,242,45,170,187,186,235,60,122,76,182,50,117,9,187,51,62,26,217,30,233,135,185,38,105,232,230,37,187,154,78,237,40,114,156,138,30,173,239,226,211,157,17,34,249,202,132,1,242,209,225,36,203,162,210,207,228,195,144,175,117,237,131,121,181,10,59,217,119,117,160,136,105,125,238,172,92,32,60,136,112,90,255,181,126,43,197,243,62,66,119,229,50,132,48,194,105,132,238,253,215,39,88,6,107,151,49,244,99,12,40,194,6,105,1,6,29,211,117,237,122,30,64,84,216,13,26,126,233,32,129,96,62,26,120,183,183,52,181,220,103,189,61,232,241,96,197,193,17,138,123,213,140,143,89,197,253,157,142,67,106,95,138,151,49,126,95,198,13,88,42,149,70,29,1,123,166,129,158,133,71,184,134,226,109,124,94,78,206,233,93,243,2,195,75,184,244,81,146,53,142,239,237,157,84,49,5,91,73,157,153,159,181,175,49,252,53,230,158,123,250,23,214,140,156,252,157,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateDetailTabMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dfcde058-afe0-4ae1-8557-8e72ac2f48dd"),
				Name = "CreateDetailTab",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Tab"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("986cba17-b044-4275-bb6b-655f318d9257"),
				Name = "detailId",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5ca483de-e45f-4446-b121-e78d4b72b799"),
				Name = "pageSchemaId",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d211bfe4-8608-4076-afde-c563a0cf31a4"),
				Name = "detailCaption",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("672c31a3-c624-4375-955a-25835d37ec63"),
				Name = "detailsTabPanelCollapsed",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0eb4d31e-ac59-48e9-b368-612b1672bdd6"),
				Name = "detailsTabPanelActiveTabIndex",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,223,111,218,48,16,126,38,127,133,201,67,23,52,26,209,245,49,234,164,140,118,29,26,170,80,161,235,67,133,38,147,28,224,42,216,169,237,64,209,202,255,190,115,98,104,126,140,117,43,18,138,99,127,247,221,221,231,187,131,53,149,132,195,102,66,103,228,194,44,200,4,164,164,74,204,181,127,55,240,239,97,214,23,92,75,145,40,255,176,64,172,215,9,156,194,10,81,49,90,94,103,44,246,111,96,99,158,165,195,27,186,2,60,117,47,65,83,150,224,142,75,62,146,56,127,25,196,254,68,140,181,100,124,225,117,252,91,72,19,26,129,231,158,186,93,226,186,29,60,27,138,13,200,18,87,159,166,154,9,142,116,5,129,125,15,156,53,166,80,108,41,196,141,40,135,4,65,7,151,197,6,85,100,191,14,156,26,218,15,227,216,43,188,160,59,149,199,68,180,61,236,39,12,184,206,147,172,155,217,163,203,34,132,185,144,171,145,80,250,146,106,250,7,240,136,46,0,211,124,202,64,105,255,43,98,3,103,38,68,130,154,67,220,151,64,53,24,132,17,153,50,14,18,25,230,52,81,80,66,13,5,141,127,48,216,140,53,130,205,121,201,225,195,94,36,27,18,202,236,254,196,141,48,210,108,141,240,216,157,146,11,188,8,45,51,112,3,135,205,137,87,54,247,195,36,249,14,91,229,15,129,47,244,146,124,38,231,29,242,203,105,89,45,30,166,244,145,62,219,224,71,84,210,85,221,253,249,180,124,155,227,52,97,218,251,240,242,1,229,108,25,95,117,243,135,94,30,78,67,227,147,19,210,128,126,154,250,87,79,25,106,225,185,152,80,127,73,249,2,220,78,30,222,62,62,106,178,4,60,29,240,24,158,235,177,53,188,24,109,194,189,137,59,13,94,137,82,9,107,38,50,245,127,92,163,189,85,141,212,100,222,174,198,182,79,165,240,231,95,173,82,189,181,185,180,24,215,132,89,167,184,198,138,145,10,188,170,189,17,180,32,182,200,102,161,225,194,52,107,198,245,233,153,101,110,29,47,50,83,16,57,231,206,201,191,59,103,215,202,203,163,93,227,237,139,36,161,169,130,252,146,106,103,97,77,255,191,5,69,78,73,17,214,91,49,237,242,48,142,161,94,94,154,61,145,211,190,61,191,170,68,216,56,101,223,60,75,112,64,180,234,187,255,52,24,43,196,102,114,85,104,142,76,202,42,166,72,53,254,178,13,177,13,16,221,110,36,25,56,4,63,21,163,1,103,154,209,100,91,55,182,119,91,193,86,39,242,181,100,241,225,236,61,179,185,74,110,4,24,71,75,88,209,34,215,244,240,62,136,235,216,111,192,22,75,141,160,241,86,105,88,25,69,235,194,222,97,94,254,8,100,132,173,134,76,222,89,175,215,112,121,207,98,156,87,239,99,49,3,115,192,21,72,61,64,91,175,215,173,200,106,64,216,251,64,163,37,241,170,244,150,155,68,246,201,120,245,66,246,190,243,130,36,199,43,231,78,51,28,148,12,14,53,212,216,80,19,9,112,11,81,38,21,118,216,80,136,212,179,78,187,120,87,9,44,240,194,61,49,123,132,72,19,5,216,125,178,75,174,214,152,105,40,23,138,128,13,128,16,243,3,181,57,120,70,189,10,112,254,179,120,44,186,215,117,80,144,152,126,44,145,180,139,110,57,248,32,37,15,111,213,164,65,239,204,99,103,100,198,161,227,72,208,153,228,246,191,72,240,27,244,166,68,232,151,8,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillGridViewMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("67b57e3f-779c-44dd-aac9-639fe7f0607a"),
				Name = "FillGridView",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("caf510a9-2d7e-465d-acf0-35ee32ab12e4"),
				Name = "moduleGridId",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8f7c97f7-00c9-424b-8156-1ecf142042b4"),
				Name = "gridTab",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Tab",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8fd8ceba-9b39-45f1-807e-c4fcb572ab19"),
				Name = "entities",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Tuple<Guid, string, string, bool>>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,193,79,131,48,24,197,207,240,87,124,238,176,148,12,27,80,79,34,26,67,116,217,65,47,51,94,140,135,110,124,140,70,104,73,91,36,198,236,127,183,141,192,1,49,217,169,205,235,235,235,239,125,221,73,89,65,201,244,125,85,109,12,214,250,149,99,7,41,160,48,220,112,212,52,147,173,48,112,11,17,220,141,226,91,244,78,157,249,10,174,161,96,149,198,196,63,40,158,191,176,29,221,150,178,123,66,209,186,227,140,53,134,75,49,155,150,248,159,76,193,190,196,253,199,35,87,218,88,83,159,84,72,5,132,91,23,183,90,148,216,229,102,114,223,106,171,85,0,223,190,231,50,234,254,53,235,206,20,50,131,174,193,128,64,70,100,254,139,124,17,194,84,186,12,125,207,155,138,113,144,248,222,16,77,51,199,137,185,125,226,108,58,170,229,210,210,66,154,2,153,148,60,135,56,112,33,195,100,28,18,221,8,141,202,144,40,28,177,173,229,232,243,2,200,76,240,223,177,157,216,122,97,147,156,160,23,33,244,219,201,167,88,0,153,183,21,174,45,221,38,255,167,172,81,45,158,212,96,214,18,135,61,154,19,183,216,48,197,140,84,68,27,197,197,129,62,212,141,249,10,97,221,242,156,62,99,231,86,18,184,129,29,127,0,59,197,192,249,146,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateViewMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("63720684-f4c7-4243-885a-1d1da5ee019a"),
				Name = "CreateViewMenuItem",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "CheckMenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e2091484-8fad-4a11-9708-8af48031517e"),
				Name = "viewCode",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6b95ed57-24b8-4dac-afe5-b229b6915fa5"),
				Name = "viewCaption",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("529005e3-a467-4823-bf46-aa1c0ee1e5de"),
				Name = "viewId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,107,219,64,16,61,203,191,98,163,67,144,72,17,185,11,29,82,53,14,134,54,152,216,109,15,165,148,177,52,146,149,202,187,97,119,37,183,20,255,247,206,126,89,50,4,26,234,131,177,103,222,190,121,243,102,118,71,144,172,211,120,96,5,227,120,100,229,30,171,159,159,144,15,43,138,37,105,190,48,185,204,70,177,38,76,3,189,66,31,125,144,98,120,161,88,252,165,195,227,178,235,53,202,216,167,62,175,12,152,141,148,88,213,62,182,133,150,98,38,84,138,58,112,60,194,1,13,133,9,135,178,63,98,118,227,143,102,91,177,209,178,227,109,18,63,198,41,133,3,83,16,6,47,186,19,60,240,186,127,62,119,247,12,191,238,71,228,90,57,253,229,30,120,139,153,13,177,155,130,213,216,99,11,26,19,177,123,198,74,51,133,188,70,249,142,109,81,74,80,162,209,212,69,246,21,119,165,224,90,138,158,88,194,143,51,243,157,108,21,195,244,207,34,26,201,198,131,215,79,106,28,23,3,245,6,182,11,203,243,69,212,53,44,185,10,92,193,250,148,81,145,72,162,30,36,245,23,157,92,69,13,59,95,240,140,95,131,52,253,153,202,176,203,153,163,243,184,204,124,153,202,3,33,138,130,221,190,206,218,216,81,154,33,17,113,242,223,173,164,110,78,81,146,144,146,53,112,236,211,160,195,137,76,179,13,234,187,74,119,35,18,34,136,164,157,179,42,42,34,133,142,83,233,130,93,232,255,118,251,221,168,89,67,139,101,192,120,219,166,51,87,180,206,67,223,179,235,235,137,40,51,71,86,92,105,224,21,6,132,179,192,20,172,65,195,70,12,178,50,109,79,135,150,29,175,125,131,73,252,225,140,137,83,58,102,63,164,101,10,147,16,171,100,78,54,47,20,189,174,38,219,238,165,56,218,157,74,226,7,217,213,38,249,132,141,68,181,127,18,199,216,152,50,27,148,153,84,244,239,113,76,178,150,126,164,125,79,155,110,46,140,155,177,98,78,91,238,45,24,207,23,217,100,166,30,172,9,62,97,111,253,251,223,230,226,38,179,155,175,156,70,211,251,156,229,194,229,168,17,18,161,218,19,228,188,102,118,127,59,62,47,237,193,209,4,200,86,234,158,195,174,119,79,208,20,118,175,71,49,219,88,235,211,233,141,70,151,61,130,52,38,121,127,103,13,127,20,80,147,241,42,73,189,221,167,197,41,95,184,1,216,71,40,255,11,206,231,50,78,57,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDetailParentAssociationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("db9f86dd-9011-46c9-b10b-46732e3bdf8a"),
				Name = "GetDetailParentAssociation",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "KeyValuePair<string, string[]>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("285a1eed-e620-42cd-b0d6-dec1f8a24b0f"),
				Name = "detailId",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1328a9ad-0aa2-43c0-8761-32d483bb5c41"),
				Name = "isModuleEditDetail",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("816804f5-751a-40b5-99f5-32713c62dfb0"),
				Name = "asscTypeCode",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ed6fa3b6-cfff-4287-ad23-d6ef631b5358"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,81,111,155,48,16,126,134,95,225,240,80,129,138,208,158,71,59,169,237,210,42,218,218,101,74,186,61,68,209,100,5,183,181,4,166,179,205,38,52,245,191,239,108,227,96,2,164,105,180,73,137,82,31,119,223,221,125,254,238,168,144,156,178,71,148,17,137,105,62,199,156,48,121,33,196,102,177,121,34,5,190,195,5,65,231,40,88,212,226,182,204,170,156,124,220,113,11,82,95,12,3,92,211,92,18,126,85,230,85,193,70,96,218,224,103,29,102,156,167,76,82,89,155,252,115,44,159,6,2,147,213,142,225,253,44,91,39,91,91,251,151,193,82,103,23,245,126,150,65,106,250,128,66,106,253,50,42,13,18,58,57,65,147,123,65,92,116,17,161,63,190,247,166,6,91,64,200,212,11,29,33,183,13,234,16,236,29,204,78,11,224,48,212,26,187,44,41,251,97,76,189,248,191,48,71,196,177,223,98,134,31,9,135,228,64,21,112,192,24,217,72,90,178,100,218,119,74,117,52,134,94,220,135,95,43,194,107,136,103,228,55,234,217,195,129,92,241,30,137,70,169,63,136,159,92,97,56,244,171,92,16,33,224,87,63,77,190,83,249,244,185,220,224,92,29,65,140,161,209,100,114,93,242,2,203,112,185,128,192,7,250,88,113,172,99,117,208,189,164,57,149,148,136,164,81,136,182,198,104,75,231,44,139,162,182,113,115,117,183,224,170,174,172,35,153,225,186,47,178,204,120,133,65,55,54,136,18,21,216,66,207,29,109,28,151,96,8,161,147,102,76,126,111,74,179,79,195,54,217,48,134,153,51,161,176,194,145,91,230,4,75,98,252,212,109,66,71,128,167,130,66,59,164,5,228,167,162,100,203,250,153,36,211,159,21,206,99,61,55,91,53,149,27,170,239,87,59,92,149,25,9,98,223,83,233,148,65,157,163,81,145,253,183,2,95,219,56,177,221,44,70,109,123,70,96,38,73,97,215,77,139,215,104,247,71,128,78,145,219,42,28,3,109,180,232,91,185,89,150,160,134,220,204,210,232,213,223,16,105,140,173,111,216,29,195,200,174,255,213,218,197,22,205,86,104,158,13,102,133,27,170,152,92,167,222,208,11,196,138,24,112,22,102,148,167,197,179,172,83,255,161,228,33,101,18,81,120,242,46,133,159,179,225,158,12,58,56,156,158,234,205,223,14,129,105,112,150,153,174,251,145,43,186,86,141,43,34,27,225,127,195,121,69,206,110,42,154,125,24,157,129,246,70,129,18,157,77,152,60,76,72,204,54,234,214,6,22,162,74,100,61,46,107,216,212,157,173,9,146,104,176,156,66,27,86,246,149,238,84,61,176,123,150,165,97,52,84,224,234,5,58,105,150,229,76,220,85,121,254,133,107,166,195,157,148,145,102,81,251,119,27,131,209,97,153,203,193,101,173,252,123,241,232,28,36,1,248,6,199,235,119,180,3,11,125,184,168,202,233,178,182,109,132,255,162,125,213,191,247,226,171,143,43,93,64,233,242,171,2,193,245,184,251,236,106,206,82,126,104,249,251,94,60,17,154,184,140,246,100,162,242,190,81,44,175,191,140,118,228,115,168,126,108,45,141,138,142,149,209,22,102,71,76,222,88,227,199,106,202,73,165,186,84,18,209,223,145,21,53,24,153,42,101,153,127,187,56,17,85,46,155,157,248,137,212,154,237,57,166,252,204,80,23,219,69,185,238,46,24,155,34,238,236,86,40,137,19,89,113,214,224,166,127,1,176,156,72,89,255,11,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateMenuSeparatorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("38326836-8700-41c7-b8b4-4f32f5363262"),
				Name = "CreateMenuSeparator",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuSeparator"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fd82c0ec-4016-4f80-a013-1a438a924177"),
				Name = "menuSeparatorCaption",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("512b4c04-2da4-41fd-94e0-5a8c7aef7899"),
				Name = "separatorId",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,49,11,194,48,16,133,103,5,255,67,220,90,40,65,5,117,40,29,164,40,118,80,7,21,231,148,92,75,32,77,202,37,85,68,252,239,166,165,138,213,78,119,199,187,239,189,187,43,67,82,128,170,142,80,50,100,86,35,137,136,130,27,57,1,34,51,58,179,244,156,208,11,164,177,86,22,181,52,244,211,236,190,41,207,15,71,195,65,199,200,129,220,153,153,247,156,240,122,69,100,196,27,27,139,66,229,52,49,251,74,202,3,174,139,210,222,189,14,28,179,210,10,173,124,159,60,28,244,99,220,138,17,233,67,234,144,231,223,45,173,24,107,217,124,216,84,186,65,93,172,48,79,189,73,48,11,150,203,96,58,95,244,188,177,21,156,131,114,80,198,164,1,167,35,216,10,85,55,60,124,1,60,193,221,253,72,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAutoDetailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8a06a2c6-467b-4569-a5bd-4fe8346658d9"),
				Name = "GetAutoDetail",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "new List<Tuple<Guid, Guid, Guid, string, Guid, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,149,93,111,155,48,20,134,175,83,105,255,129,113,81,17,13,16,73,104,66,212,15,137,16,168,144,218,170,107,210,237,98,154,38,23,220,196,26,216,153,109,186,178,169,255,125,54,38,9,9,233,164,74,149,34,34,27,159,215,239,121,206,177,121,2,84,163,144,21,25,215,206,53,12,127,107,87,136,241,179,121,177,202,224,217,101,129,82,83,107,62,25,167,8,47,118,71,23,23,70,247,244,195,209,147,16,130,152,35,94,206,146,37,204,193,53,192,96,1,169,80,189,103,144,6,4,99,152,112,68,176,29,182,23,29,8,255,92,64,90,214,150,194,253,121,227,192,70,166,166,207,74,118,77,210,34,131,186,52,212,82,179,3,32,6,109,67,51,200,152,248,175,222,218,95,17,95,94,145,4,100,114,40,178,51,84,146,118,68,104,14,184,49,159,137,192,71,180,40,40,168,98,171,160,123,142,50,196,17,100,246,20,114,128,50,86,205,154,218,198,79,156,118,215,136,88,201,154,233,196,105,64,178,34,199,55,32,151,206,218,158,253,180,94,97,108,211,83,2,246,108,87,234,62,78,245,174,45,133,14,38,31,161,140,67,202,164,160,113,0,13,133,128,67,181,70,34,184,5,84,8,201,0,67,77,6,36,95,1,138,24,193,243,114,5,237,240,87,1,50,243,195,81,167,45,117,71,8,87,99,251,18,242,91,138,114,64,203,109,150,70,183,13,230,149,82,197,28,230,53,24,221,47,56,81,49,138,241,15,93,251,212,212,177,231,100,86,85,202,208,111,244,53,236,132,100,153,42,242,65,182,194,158,2,24,108,214,25,187,189,33,133,208,163,102,108,133,236,128,20,88,156,149,115,173,215,213,254,10,0,85,81,215,5,16,219,108,151,126,115,190,203,45,36,175,186,134,95,64,86,168,99,117,97,252,167,17,228,174,157,253,3,177,151,65,221,245,114,131,24,51,14,112,2,39,165,112,96,108,188,84,42,210,124,140,235,182,73,17,87,158,43,113,76,56,100,106,211,61,109,91,205,50,209,51,56,157,148,85,213,244,27,185,188,34,219,169,84,155,225,31,197,57,45,178,76,59,62,110,170,218,83,192,65,149,178,68,160,33,166,93,131,231,25,250,3,231,240,153,239,188,171,93,109,109,221,138,220,214,92,234,75,64,82,51,244,208,115,194,200,15,135,150,215,143,28,203,245,166,61,107,18,140,6,214,192,11,198,145,59,246,122,190,239,214,38,59,234,90,171,26,94,10,188,233,78,171,4,58,70,203,140,217,246,103,118,54,200,205,78,69,73,117,104,0,86,178,11,148,176,29,230,43,94,174,229,213,168,171,124,190,136,199,75,93,170,157,42,248,105,142,176,184,141,197,85,3,69,25,238,96,66,104,202,26,21,164,104,177,228,175,179,114,60,208,247,156,190,99,13,251,78,106,185,110,15,90,15,201,0,90,96,252,48,78,188,116,12,135,112,88,179,122,7,84,109,51,230,1,131,166,214,128,117,87,189,222,163,117,48,166,69,237,32,176,152,205,41,72,126,6,75,128,23,144,197,120,58,105,192,202,200,226,117,82,3,47,58,57,241,167,214,52,24,140,45,119,26,250,214,100,60,117,173,201,104,52,138,70,142,23,133,110,239,253,72,237,57,49,247,173,237,118,204,21,89,188,169,159,4,25,241,163,144,23,20,215,95,246,211,127,50,206,240,149,229,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModulesGridViewMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7ab5f668-640a-433b-ba5a-8cfeca392d0f"),
				Name = "GetModulesGridView",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, string, string, bool>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e4da28bc-1f4a-46cd-979a-1f6c222bed0c"),
				Name = "sysModuleGridId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,221,78,194,48,20,190,222,158,162,217,85,73,150,189,128,66,162,152,16,19,244,102,19,46,140,23,117,59,64,99,215,46,253,129,168,225,221,61,107,65,216,134,145,171,166,103,231,251,57,223,233,182,76,19,214,52,83,86,110,128,140,201,139,1,61,85,82,66,105,185,146,89,14,198,224,233,191,102,75,110,55,115,85,50,209,94,185,92,211,34,199,214,21,95,59,205,124,183,111,123,177,92,112,203,193,100,75,165,63,76,195,74,240,245,153,86,174,25,221,196,91,20,92,107,94,45,56,236,204,84,9,17,164,80,123,64,167,234,90,201,19,223,12,108,14,109,251,3,179,140,198,81,215,107,122,13,254,73,85,78,160,149,131,124,160,75,127,3,184,192,209,29,233,136,244,101,28,198,88,141,65,144,146,53,109,55,78,227,106,249,204,106,184,110,154,121,249,117,130,208,254,56,73,254,105,186,126,19,44,78,131,84,130,226,115,110,236,109,225,26,1,183,51,199,171,148,4,55,167,243,93,41,49,153,16,13,198,9,139,150,36,236,200,149,32,138,252,43,165,1,231,36,244,124,101,132,203,75,235,27,145,239,56,138,90,70,82,58,173,65,218,142,251,199,234,32,223,118,208,35,254,53,49,221,166,228,45,43,84,238,141,208,17,58,136,34,190,34,212,244,153,198,127,104,4,19,193,133,233,135,119,149,133,208,56,180,17,117,23,141,76,191,4,131,221,159,131,61,182,77,148,108,152,185,19,226,209,66,109,124,140,131,95,237,225,190,248,108,0,11,91,208,22,52,222,23,76,56,40,212,61,194,207,252,246,136,146,183,174,65,85,193,185,187,164,45,36,3,75,225,73,100,119,85,69,219,72,254,125,15,244,66,74,169,23,75,143,153,164,253,17,67,114,251,120,31,107,176,78,203,195,59,188,249,1,33,105,167,92,114,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateFiltersRightExprMetaDataByParameterValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1f936b02-eb5f-45ee-a530-3923b739441e"),
				Name = "UpdateFiltersRightExprMetaDataByParameterValue",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d3be461e-2308-4aa1-b192-ee24abfd97f5"),
				Name = "process",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Process",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ea2b84df-b723-46c2-a74f-96ef58c50355"),
				Name = "filters",
				CreatedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				ModifiedInSchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DataSourceFilterCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,93,75,195,48,20,134,175,39,248,31,142,55,35,5,9,211,219,81,193,205,143,43,97,108,234,141,120,17,235,233,26,104,155,146,143,97,145,253,119,147,54,38,179,142,57,115,147,112,206,123,158,188,121,147,11,137,44,43,128,108,152,132,156,151,26,37,240,218,159,84,2,159,167,39,35,187,92,247,157,105,182,18,70,102,232,117,41,144,155,80,187,235,106,73,223,154,246,83,60,7,50,156,162,75,190,46,244,237,71,35,81,41,46,106,250,216,54,8,105,10,67,84,148,56,5,157,27,165,69,21,12,141,142,228,254,133,93,48,201,42,140,150,143,243,28,166,20,157,11,83,107,231,255,50,122,235,226,106,130,198,186,248,7,113,186,11,177,37,182,96,186,176,136,200,123,185,120,165,207,172,52,24,164,123,122,110,66,138,204,226,233,61,234,128,239,122,179,246,193,115,9,81,90,242,122,157,124,95,148,236,97,210,37,86,98,131,215,154,76,66,123,123,40,174,149,121,235,195,86,112,150,66,109,202,18,198,227,223,25,68,153,79,241,10,38,59,33,62,53,118,194,255,154,10,121,57,231,238,79,103,237,207,55,17,255,218,243,67,247,12,237,247,219,246,11,156,60,60,111,5,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InitializeDetailsSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new InitializeDetails(userConnection) {
				SchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb")
			};
		}

		#endregion

	}

	#endregion

	#region Class: InitializeDetails

	[DesignModeProperty(Name = "SysModuleId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.SysModuleId.Caption", DescriptionResourceItem = "Parameters.SysModuleId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DetailTabPanel", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.DetailTabPanel.Caption", DescriptionResourceItem = "Parameters.DetailTabPanel.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SysModuleEditId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.SysModuleEditId.Caption", DescriptionResourceItem = "Parameters.SysModuleEditId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InModuleEdit", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.InModuleEdit.Caption", DescriptionResourceItem = "Parameters.InModuleEdit.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ParentSysEntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.ParentSysEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.ParentSysEntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "UseModuleDetails", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.UseModuleDetails.Caption", DescriptionResourceItem = "Parameters.UseModuleDetails.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DefaultCollapsed", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.DefaultCollapsed.Caption", DescriptionResourceItem = "Parameters.DefaultCollapsed.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DetailFilter", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.DetailFilter.Caption", DescriptionResourceItem = "Parameters.DetailFilter.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActiveTabIndex", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "338c91dd8878440ab0cb78711b91d9bb", CaptionResourceItem = "Parameters.ActiveTabIndex.Caption", DescriptionResourceItem = "Parameters.ActiveTabIndex.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class InitializeDetails : ProcessUserTask
	{

		#region Constructors: Public

		public InitializeDetails(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("338c91dd-8878-440a-b0cb-78711b91d9bb");
		}

		#endregion

		#region Properties: Public

		public virtual Guid SysModuleId {
			get;
			set;
		}

		public virtual Object DetailTabPanel {
			get;
			set;
		}

		public virtual Guid SysModuleEditId {
			get;
			set;
		}

		public virtual bool InModuleEdit {
			get;
			set;
		}

		public virtual Guid ParentSysEntitySchemaId {
			get;
			set;
		}

		public virtual bool UseModuleDetails {
			get;
			set;
		}

		public virtual bool DefaultCollapsed {
			get;
			set;
		}

		public virtual Object DetailFilter {
			get;
			set;
		}

		public virtual int ActiveTabIndex {
			get;
			set;
		}

		private LocalizableString _allViewMenuItemCaption;
		public LocalizableString AllViewMenuItemCaption {
			get {
				return _allViewMenuItemCaption ?? (_allViewMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.AllViewMenuItemCaption.Value"));
			}
		}

		private LocalizableString _notesDetailCaption;
		public LocalizableString NotesDetailCaption {
			get {
				return _notesDetailCaption ?? (_notesDetailCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.NotesDetailCaption.Value"));
			}
		}

		private LocalizableString _rightsDetailCaption;
		public LocalizableString RightsDetailCaption {
			get {
				return _rightsDetailCaption ?? (_rightsDetailCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.RightsDetailCaption.Value"));
			}
		}

		private LocalizableString _logDetailCaption;
		public LocalizableString LogDetailCaption {
			get {
				return _logDetailCaption ?? (_logDetailCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.LogDetailCaption.Value"));
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var detailsTabPanel = DetailTabPanel as	TabPanel;
			if (detailsTabPanel == null) {
				return true;
			}
			var page = detailsTabPanel.Page as Terrasoft.UI.WebControls.Page;
			string tempDataKey = "tempData";
			string activeTabFieldValue = string.Empty;
			string collapsedFieldValue = string.Empty;
			if (Terrasoft.UI.WebControls.Ext.IsAjaxRequest && page.CustomData.ContainsKey(tempDataKey)) {	
				JObject tempData = page.CustomData[tempDataKey] as JObject;	
				collapsedFieldValue = page.Request.Form[detailsTabPanel.ClientID + "_Collapsed"];
				if (string.IsNullOrEmpty(collapsedFieldValue)) {
					collapsedFieldValue = (tempData[detailsTabPanel.ClientID + "_Collapsed"] != null &&	page.UseProfile) ?
						tempData[detailsTabPanel.ClientID + "_Collapsed"].Value<string>() : string.Empty;		
				}
				activeTabFieldValue = page.Request.Form[detailsTabPanel.ClientID + "_ActiveTab"];	
				if (string.IsNullOrEmpty(activeTabFieldValue)) {
					activeTabFieldValue = (tempData[detailsTabPanel.ClientID + "_ActiveTab"] != null && page.UseProfile) ? tempData[detailsTabPanel.ClientID + "_ActiveTab"].Value<string>() : "0";
				}
			}
			
			bool detailsTabPanelCollapsed = false;
			if (string.IsNullOrEmpty(collapsedFieldValue)) {
				detailsTabPanelCollapsed = DefaultCollapsed;
			} else {
				detailsTabPanelCollapsed = bool.Parse(collapsedFieldValue);
			}
			int detailsTabPanelActiveTabIndex = 0;
			bool parsedActiveTabIndex = int.TryParse(activeTabFieldValue, out detailsTabPanelActiveTabIndex);
			if (!parsedActiveTabIndex) {
				detailsTabPanelActiveTabIndex = 0;
			}
			bool applyProfile = false;
			if (page.UseProfile && !Terrasoft.UI.WebControls.Ext.IsAjaxRequest) {
				var profileData = page.ProfileData;
				var profileItem = profileData[detailsTabPanel.ClientID];
				if (profileItem != null) {
					if (profileItem.Values.ContainsKey("collapsed") && !detailsTabPanel.IgnoreProfileProperties.Contains("collapsed")) {
						detailsTabPanelCollapsed = bool.Parse(profileItem.Values["collapsed"].ToString());
					}		
					if (profileItem.Values.ContainsKey("activetabindex") && !detailsTabPanel.IgnoreProfileProperties.Contains("activetabindex")) {
						detailsTabPanelActiveTabIndex = int.Parse(profileItem.Values["activetabindex"].ToString());
					}
				}
			}
			var detailsList = GetDetails();
			if (detailsList.Count > 0 && (detailsTabPanelActiveTabIndex < 0 || detailsTabPanelActiveTabIndex >= detailsList.Count)) {
				detailsTabPanelActiveTabIndex = 0;
			}
			ActiveTabIndex = detailsTabPanelActiveTabIndex;
			foreach(var item in detailsList) {
				var tab = CreateDetailTab(item.Item1, item.Item2, item.Item4, detailsTabPanelCollapsed, detailsTabPanelActiveTabIndex);
				FillGridView(item.Item5, tab, GetModulesGridView(item.Item5));
				if (tab.Items.Count == 0) {
					continue;
				}
				var pageContainer = tab.Items[0] as PageContainer;
				pageContainer.PageInstance.Process.SetPropertyValue("UseModuleDetails", UseModuleDetails || !InModuleEdit);
				pageContainer.PageInstance.Process.SetPropertyValue("SysEntitySchemaId", ParentSysEntitySchemaId);
				pageContainer.PageInstance.Process.SetPropertyValue("IsDetailGrid", true);
				pageContainer.PageInstance.Process.SetPropertyValue("AddToMenuItemMoveTo", true);
				pageContainer.PageInstance.Process.SetPropertyValue("LocatedInEditPage", InModuleEdit);
				pageContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", 
					(detailsTabPanel.NamingContainer as PageContainer).PageInstance.Process.InstanceUId);
				var detailDataSource = pageContainer.FindPageControlByName("DataSource") as Terrasoft.UI.WebControls.Controls.EntityDataSource;	
				if (detailDataSource != null) {
					if(detailDataSource.SchemaUId.Equals(Guid.Empty) || detailDataSource.SchemaUId.Equals(new Guid("a22b1e79-7fc1-4fe5-aba0-538e9df96f17")))  {
						detailDataSource.SchemaUId = item.Item3;
					} else {
						if (detailDataSource.SchemaUId != item.Item3) {
							detailDataSource.SchemaUId = item.Item3;
							Terrasoft.UI.WebControls.Utilities.EntityDataSourceUtilities.SynchronizeStructure(detailDataSource);
							foreach (var column in detailDataSource.CurrentStructure.Columns) {
								if (!column.IsVisible) {
									column.IsAlwaysSelect = true;
								}
							}
						}
					}
					var association = GetDetailParentAssociation(item.Item1, InModuleEdit, "Filter", item.Item3);
					pageContainer.PageInstance.Process.SetPropertyValue("FilterLeftExpression", association.Value);
					pageContainer.PageInstance.Process.SetPropertyValue("SysModuleDetailId", item.Item1);
					pageContainer.PageInstance.Process.SetPropertyValue("ParentColumnMetaPath", association.Key);
				}
				if (!string.IsNullOrEmpty(item.Item6)) {
					Terrasoft.Configuration.VideoHelpUtilities.SetWebControlHelpProperties(pageContainer, item.Item6, UserConnection);
				}
				if (item.Item2 == new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6")) {
					pageContainer.PageInstance.Process.SetPropertyValue("ModuleEntitySchemaUId", item.Item3);
				}
			}
			if (applyProfile) {
				detailsTabPanel.AllowCallbackScriptMonitoring = false;
				detailsTabPanel.ActiveTabIndex = detailsTabPanelActiveTabIndex;
				detailsTabPanel.Collapsed = detailsTabPanelCollapsed;
				detailsTabPanel.AllowCallbackScriptMonitoring = true;
			}
			if (!detailsTabPanel.Page.IsPostBack) {
				detailsTabPanel.AjaxEvents.TabChange.ShowOpaqueMask = true;
				detailsTabPanel.TabChangeDelay = 300;
			}
			DetailTabPanel = null;
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual List<Tuple<Guid, Guid, Guid, string, Guid, string>> GetDetails() {
			if (InModuleEdit) {
				return GetModuleEditDetails();
			} else {
				return GetModuleDetails();
			}
		}

		public virtual List<Tuple<Guid, Guid, Guid, string, Guid, string>> GetModuleDetails() {
			var result = GetAutoDetail();
			var appCache = UserConnection.ApplicationCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			string detailsCacheName = TSConfiguration.CacheUtilities.DetailsCache + "_" + UserConnection.CurrentUser.SysCultureName;
			var detailsCollection = Terrasoft.Configuration.CommonUtilities.GetSelectData(UserConnection, Terrasoft.Configuration.CommonUtilities.GetModuleDetailsSelect, appCache, detailsCacheName);
			string captionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleDetail", "Caption");
			foreach (var detail in detailsCollection) {
				Guid detailModuleId = new Guid(detail["sysModuleId"].ToString());
				if (detailModuleId == SysModuleId) {
					Guid detailId = detail["detailId"] == DBNull.Value ? Guid.Empty : new Guid(detail["detailId"].ToString());
					Guid pageSchemaId = detail["sysPageSchemaId"] == DBNull.Value ? Guid.Empty : new Guid(detail["sysPageSchemaId"].ToString());
					Guid sysModuleGridId = detail["sysModuleGridId"] == DBNull.Value ? Guid.Empty : new Guid(detail["sysModuleGridId"].ToString());
					Guid entitySchemaId = detail["sysEntitySchemaId"] == DBNull.Value ? Guid.Empty : new Guid(detail["sysEntitySchemaId"].ToString());
					string caption = detail[captionColumnName].ToString();
					string helpContextId = detail["helpContextId"].ToString();
					result.Add(new Tuple<Guid, Guid, Guid, string, Guid, string>(detailId, pageSchemaId, entitySchemaId, caption, sysModuleGridId, helpContextId));
				}
			}
			result.Sort(delegate(Tuple<Guid, Guid, Guid, string, Guid, string> item1, Tuple<Guid, Guid, Guid, string, Guid, string> item2) {
				return item1.Item4.CompareTo(item2.Item4);});
			return result;
		}

		public virtual List<Tuple<Guid, Guid, Guid, string, Guid, string>> GetModuleEditDetails() {
			var result = new List<Tuple<Guid, Guid, Guid, string, Guid, string>>();
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			if (UseModuleDetails) {
				result.AddRange(GetModuleDetails());
			} else {
				result = GetAutoDetail();
				var appCache = UserConnection.ApplicationCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			        string editDetailsCacheName = TSConfiguration.CacheUtilities.EditDetailsCache + "_" + UserConnection.CurrentUser.SysCultureName;
				var detailsCollection = Terrasoft.Configuration.CommonUtilities.GetSelectData(UserConnection, Terrasoft.Configuration.CommonUtilities.GetModuleEditDetailsSelect, appCache, editDetailsCacheName);
				string captionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleEditDetail", "Caption");
				foreach (var detail in detailsCollection) {
					Guid detailModuleId = new Guid(detail["sysModuleEditId"].ToString());
					if (detailModuleId == SysModuleEditId) {
						Guid detailId = detail["detailId"] == DBNull.Value ? Guid.Empty : new Guid(detail["detailId"].ToString());
						Guid pageSchemaId = detail["sysPageSchemaId"] == DBNull.Value ? Guid.Empty : new Guid(detail["sysPageSchemaId"].ToString());
						Guid sysModuleGridId = detail["sysModuleGridId"] == DBNull.Value ? Guid.Empty : new Guid(detail["sysModuleGridId"].ToString());
						Guid entitySchemaId = detail["sysEntitySchemaId"] == DBNull.Value ? Guid.Empty : new Guid(detail["sysEntitySchemaId"].ToString());
						string caption = detail[captionColumnName].ToString();
						string helpContextId = detail["helpContextId"].ToString();
						result.Add(new Tuple<Guid, Guid, Guid, string, Guid, string>(detailId, pageSchemaId, entitySchemaId, caption, sysModuleGridId, helpContextId));
					}
				}
			}
			result.Sort(delegate(Tuple<Guid, Guid, Guid, string, Guid, string> item1, Tuple<Guid, Guid, Guid, string, Guid, string> item2) {
				return item1.Item4.CompareTo(item2.Item4);
			});
			return result;
		}

		public virtual Tab CreateDetailTab(Guid detailId, Guid pageSchemaId, string detailCaption, bool detailsTabPanelCollapsed, int detailsTabPanelActiveTabIndex) {
			var newTab = new Terrasoft.UI.WebControls.Controls.Tab();
			newTab.UId = Guid.NewGuid();
			newTab.Name = "DetailTab" + detailId.ToString().Replace("-", "").ToLower();
			newTab.Caption = detailCaption;
			var detailsTabPanel = DetailTabPanel as TabPanel;
			detailsTabPanel.Add(newTab);
			string tabPanelClientId = detailsTabPanel.ClientID;
			var formPostData = detailsTabPanel.Page.Request.Form;
			bool needCreatePageContainer = false;
			bool needLoadViewState = formPostData[newTab.ClientID + "_TabActivated"] == "true";
			if (formPostData.AllKeys.Length > 3) {
				string []ajaxRequestParam = formPostData[3].ToString().Split('|');
				if (ajaxRequestParam[0] == tabPanelClientId && ajaxRequestParam[2].Equals("TabChange")) {
					string activeTabIndex = formPostData[tabPanelClientId + "_ActiveTab"];
					string previouseTabIndex = formPostData[tabPanelClientId + "_PreviouseActiveTab"];
					if (!activeTabIndex.Equals(string.Empty)) {
						int index = int.Parse(activeTabIndex);
						if (index == detailsTabPanel.Tabs.Count-1) {
							needCreatePageContainer = true;
						}
					}
				}
			}	
			if (!detailsTabPanelCollapsed && detailsTabPanelActiveTabIndex == detailsTabPanel.Tabs.Count - 1) {
				needCreatePageContainer = true;
			}
			if (needCreatePageContainer || needLoadViewState) {
				Terrasoft.UI.WebControls.Controls.PageContainer newContainer = null;
				newContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
				newContainer.UId = Guid.NewGuid();
				newContainer.CreatedByAjax = !needLoadViewState;
			    newContainer.InitialyCreatedByAjax = true;
				newContainer.Name = "DetailGridContainer" + detailId.ToString().Replace("-", "").ToLower();
				newContainer.PageSchemaUId = pageSchemaId;
				newContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
				newContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
				newTab.InsertItem(0, newContainer);
				foreach (System.Web.UI.Control control in newContainer.Controls) {
				  Terrasoft.UI.WebControls.Utilities.ControlUtilities.ControlsTreeRecursiveLoop(control, delegate(object sender, EventArgs e) {
				    var webControl = sender as Terrasoft.UI.WebControls.WebControl;
				    if (webControl != null) {
				      webControl.InitialyCreatedByAjax = true;
				    }
				  });
				}
			}
			return newTab;
		}

		public virtual void FillGridView(Guid moduleGridId, Tab gridTab, List<Tuple<Guid, string, string, bool>> entities) {
			bool hasAllItemsView = entities.Count > 0 ? entities[0].Item4 : false;
			gridTab.ShowMenuItemCaption = entities.Count > 0;
			var checkFirst = false;
			for (int i = 0; i < entities.Count; i++) {
				var menuItem = CreateViewMenuItem(entities[i].Item2, entities[i].Item3,
					entities[i].Item1);
				menuItem.Checked = !hasAllItemsView && (i == (entities.Count - 1));
				gridTab.Menu.Insert(0, menuItem);
			}
			if (hasAllItemsView && entities.Count > 0) {
				var menuItem = CreateViewMenuItem("AllViews", AllViewMenuItemCaption, moduleGridId);
				menuItem.Checked = true;
				gridTab.Menu.Insert(0, menuItem);
				gridTab.Menu.Insert(1, CreateMenuSeparator(string.Empty, Guid.NewGuid()));
			}
		}

		public virtual CheckMenuItem CreateViewMenuItem(string viewCode, string viewCaption, Guid viewId) {
			var item = new CheckMenuItem();
			item.Checked = false;
			item.Group = "ViewFilter";
			item.UId =  viewId;
			item.Tag = viewCode;
			item.Name = "viewMenuItem_" + viewId.ToString("N") + item.Tag;
			item.Caption = viewCaption;
			item.AjaxEvents.CheckChange.Event += delegate(object sender, Terrasoft.UI.WebControls.Controls.AjaxEventArgs e){
				var menuItem = sender as Terrasoft.UI.WebControls.Controls.CheckMenuItem;
				if (!menuItem.Checked) {
					return;
				}
				var tabItem = menuItem.Parent as Tab; 
				if (tabItem.Items.Count == 0) {
					return;
				}
				var filterCode = (sender as Terrasoft.UI.WebControls.Controls.CheckMenuItem).Tag;
				((TabPanel)tabItem.Parent).SetActiveTab(tabItem);
				var container = tabItem.Items[0] as PageContainer;
				if (container != null && container.PageInstance != null) {
					var dataSource = container.FindControl("DataSource")
										as DataSource;
					if (dataSource == null) {
						container.PageInstance.ThrowEvent("GridPageRefreshRow");
						return;
					}
					Terrasoft.UI.WebControls.Controls.DataSourceFilterCollection filters = null;
					var viewFilters = dataSource.FindFiltersGroupByName("ViewFilters");
					if (viewFilters != null) {
						foreach (var filterItem in viewFilters) {
							filterItem.IsEnabled = filterItem.Name == filterCode;
						}
						container.PageInstance.ThrowEvent("ClearData");
						dataSource.LoadRows();
					}
				}
			};
			return item;
		}

		public virtual KeyValuePair<string, string[]> GetDetailParentAssociation(Guid detailId, bool isModuleEditDetail, string asscTypeCode, Guid entitySchemaId) {
			string detailParentAsscSchemaName = "SysModuleDetailParentAssc";
			string detailParentAsscFilterColumnName = "SysModuleDetail";
			string parentColumnEntitySchemaPath = "SysModuleDetail.[SysModuleDetail:Id].SysModule.SysModuleEntity.SysEntitySchemaUId";
			if (isModuleEditDetail && !UseModuleDetails) {
				detailParentAsscFilterColumnName = "SysModuleEditDetail";
				detailParentAsscSchemaName = "SysModuleEditDetailParentAssc";
				parentColumnEntitySchemaPath = "SysModuleEditDetail.[SysModuleEditDetail:Id].SysModuleEdit.SysModuleEntity.SysEntitySchemaUId";
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var asscEntitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, detailParentAsscSchemaName);
			asscEntitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.DetailsCache, SysModuleId));
			var asscColumnMetaPathColumnName = asscEntitySchemaQuery.AddColumn("ColumnMetaPath").Name;
			var asscParentColumnMetaPathColumnName = asscEntitySchemaQuery.AddColumn("ParentColumnMetaPath").Name;
			var parentColumnEntitySchemaColumnName = asscEntitySchemaQuery.AddColumn(parentColumnEntitySchemaPath).Name;
			asscEntitySchemaQuery.Filters.Add(asscEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysParentAssociationType.Code",
				asscTypeCode));
			asscEntitySchemaQuery.Filters.Add(asscEntitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, detailParentAsscFilterColumnName,
				detailId));
			asscEntitySchemaQuery.CacheItemName = "ParentAsscDetails_" + asscTypeCode + "_" + detailId;
			var associationCollection = asscEntitySchemaQuery.GetEntityCollection(UserConnection);
			string[] associations = new string[associationCollection.Count];	
			string parentColumnMetaPath = String.Empty;
			for(int i = 0; i < associationCollection.Count; i++) {
				var parentSchemaId = associationCollection[i].GetTypedColumnValue<Guid>(parentColumnEntitySchemaColumnName);
				var schemaInstance = entitySchemaManager.GetInstanceByUId(entitySchemaId);
				var associationPath = associationCollection[i].GetColumnValue("ColumnMetaPath").ToString();
				if (!string.IsNullOrEmpty(associationPath)) {
					if (schemaInstance.FindSchemaColumnByPath(associationPath) == null) {
						associationPath = schemaInstance.GetSchemaColumnPathByMetaPath(associationCollection[i].GetColumnValue("ColumnMetaPath").ToString());
					}
				}
				associations[i] = associationPath;
				schemaInstance = entitySchemaManager.GetInstanceByUId(parentSchemaId);
				if (associationCollection[i].GetColumnValue(asscColumnMetaPathColumnName) != null) {
					var associationParentPath = associationCollection[i].GetColumnValue(asscParentColumnMetaPathColumnName).ToString();
					if (!string.IsNullOrEmpty(associationParentPath)) {
						if (schemaInstance.FindSchemaColumnByPath(associationParentPath) == null) {
							associationParentPath = schemaInstance.GetSchemaColumnPathByMetaPath(associationParentPath);
						}
					}
					parentColumnMetaPath = associationParentPath;
				}
			}
			var result = new KeyValuePair<string, string[]>(parentColumnMetaPath, associations);
			return result;
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparator(string menuSeparatorCaption, Guid separatorId) {
			var menuSeparator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
				menuSeparator.UId = separatorId;
				if (!string.IsNullOrEmpty(menuSeparatorCaption)) {
					menuSeparator.Caption= menuSeparatorCaption;
				}
				menuSeparator.CaptionColor = Color.FromArgb(0,2,77,156);
				menuSeparator.Hidden = false;
			return menuSeparator;
		}

		public virtual new List<Tuple<Guid, Guid, Guid, string, Guid, string>> GetAutoDetail() {
			var result = new List<Tuple<Guid, Guid, Guid, string, Guid, string>>();
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModule");
			entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.DetailsCache, SysModuleId));
			var sysEntitySchemaIdColumnName = entitySchemaQuery.AddColumn("SysModuleEntity.SysEntitySchemaUId").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				entitySchemaQuery.RootSchema.GetPrimaryColumnName(), SysModuleId));
			entitySchemaQuery.CacheItemName = "AutoModuleDetail_" + SysModuleId.ToString("N");
			var collection = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (collection.Count == 1) {
				var schemaUId = collection[0].GetTypedColumnValue<Guid>(sysEntitySchemaIdColumnName);
				var entitySchema = entitySchemaManager.GetInstanceByUId(schemaUId);
				if (InModuleEdit) {
					var notesColumn = entitySchema.Columns.FindByName("Notes");
					if (notesColumn != null && notesColumn.DataValueType is MaxSizeTextDataValueType) {
						var notesPageSchemaId = new Guid("E80EFAE6-82F0-48D1-BC73-38C9F4981AA4");
						result.Add(new Tuple<Guid, Guid, Guid, string, Guid, string>
							(notesPageSchemaId, notesPageSchemaId,	schemaUId,	NotesDetailCaption, Guid.Empty, string.Empty));
					}
				}
				if (entitySchema.AdministratedByRecords) {
					var rightsPageSchemaId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
					result.Add(new Tuple<Guid, Guid, Guid, string, Guid, string>
							(rightsPageSchemaId, rightsPageSchemaId, schemaUId,	RightsDetailCaption, rightsPageSchemaId, string.Empty));
				}
				if (entitySchema.IsTrackChangesInDB) {
					var logPageSchemaId = new Guid("038F55AD-DC39-4DEA-B9D4-B777F708FE41");
					result.Add(new Tuple<Guid, Guid, Guid, string, Guid, string>
							(logPageSchemaId, logPageSchemaId, Guid.Empty, LogDetailCaption, Guid.Empty, string.Empty));
				}
			}
			return result;
		}

		public virtual List<Tuple<Guid, string, string, bool>> GetModulesGridView(Guid sysModuleGridId) {
			var appCache = UserConnection.SessionCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var gridViewsCollection = TSConfiguration.CommonUtilities.GetSelectData(
				UserConnection, TSConfiguration.CommonUtilities.GetModuleGridViewsSelect, appCache, TSConfiguration.CacheUtilities.GridViewCache);
			string captionColumnName = TSConfiguration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleGridView", "Caption");
			List<Tuple<Guid, string, string, bool>> result = new List<Tuple<Guid, string, string, bool>>();
			foreach (var gridView in gridViewsCollection) {
					Guid currentSysModuleGridId = new Guid(gridView["sysModuleGridId"].ToString());
					if (sysModuleGridId == currentSysModuleGridId) {
						Guid sysModuleGridViewId = new Guid(gridView["sysModuleGridViewId"].ToString());
						string caption = gridView[captionColumnName].ToString();
						bool hasAllItemsView = UserConnection.DBTypeConverter.DBValueToBool(gridView["hasAllItemsView"]);
						string code = gridView["code"].ToString();
						result.Add(new Tuple<Guid, string, string, bool>(sysModuleGridViewId, code, caption, hasAllItemsView));
					}
			}
			return result;
		}

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process, DataSourceFilterCollection filters) {
			foreach (var filter in filters) {
							var dataSourcefilter = (DataSourceFilter)filter;
							if (dataSourcefilter.RightExpression.Type == DataSourceFilterExpressionType.Custom) {
								dataSourcefilter.RightExpression.Type = DataSourceFilterExpressionType.Parameter;
								if (dataSourcefilter.RightExpression.Parameters.Count == 2) {
									var parameters = dataSourcefilter.RightExpression.Parameters;
									var metaPath = parameters[1].Value;
									parameters[1].Value = process.GetParameterValueByMetaPath((string)metaPath);
									parameters.RemoveAt(0);
								}
								if (dataSourcefilter.SubFilters != null && dataSourcefilter.SubFilters.Count > 0) {
									UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourcefilter.SubFilters);
								}
							}
						}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("SysModuleId")) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
			if (DetailTabPanel != null) {
				if (DetailTabPanel.GetType().IsSerializable || DetailTabPanel.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DetailTabPanel", DetailTabPanel, null);
				}
			}
			if (!HasMapping("SysModuleEditId")) {
				writer.WriteValue("SysModuleEditId", SysModuleEditId, Guid.Empty);
			}
			if (!HasMapping("InModuleEdit")) {
				writer.WriteValue("InModuleEdit", InModuleEdit, false);
			}
			if (!HasMapping("ParentSysEntitySchemaId")) {
				writer.WriteValue("ParentSysEntitySchemaId", ParentSysEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("UseModuleDetails")) {
				writer.WriteValue("UseModuleDetails", UseModuleDetails, false);
			}
			if (!HasMapping("DefaultCollapsed")) {
				writer.WriteValue("DefaultCollapsed", DefaultCollapsed, false);
			}
			if (DetailFilter != null) {
				if (DetailFilter.GetType().IsSerializable || DetailFilter.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("DetailFilter", DetailFilter, null);
				}
			}
			if (!HasMapping("ActiveTabIndex")) {
				writer.WriteValue("ActiveTabIndex", ActiveTabIndex, 0);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "SysModuleId":
					SysModuleId = reader.GetGuidValue();
				break;
				case "DetailTabPanel":
					DetailTabPanel = reader.GetSerializableObjectValue();
				break;
				case "SysModuleEditId":
					SysModuleEditId = reader.GetGuidValue();
				break;
				case "InModuleEdit":
					InModuleEdit = reader.GetBoolValue();
				break;
				case "ParentSysEntitySchemaId":
					ParentSysEntitySchemaId = reader.GetGuidValue();
				break;
				case "UseModuleDetails":
					UseModuleDetails = reader.GetBoolValue();
				break;
				case "DefaultCollapsed":
					DefaultCollapsed = reader.GetBoolValue();
				break;
				case "DetailFilter":
					DetailFilter = reader.GetSerializableObjectValue();
				break;
				case "ActiveTabIndex":
					ActiveTabIndex = reader.GetIntValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

