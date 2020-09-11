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

	#region Class: InitializePrimaryGridsSchema

	/// <exclude/>
	public class InitializePrimaryGridsSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public InitializePrimaryGridsSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public InitializePrimaryGridsSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e");
			RealUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e");
			Name = "InitializePrimaryGrids";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,80,42,75,44,82,40,40,202,204,77,44,170,116,47,202,76,41,86,176,85,112,79,45,9,64,18,209,8,174,44,246,205,79,41,205,73,245,76,209,180,230,74,203,47,74,77,76,206,80,208,0,233,204,44,73,205,85,200,204,67,49,65,83,161,154,139,19,36,153,14,228,133,36,38,1,77,116,6,106,41,73,69,50,20,40,172,1,210,171,231,9,36,12,117,20,224,108,99,36,182,9,208,54,78,183,204,156,28,144,142,176,204,212,114,132,22,35,29,152,233,58,32,231,66,156,87,140,69,157,38,208,140,90,174,162,212,146,210,162,60,133,146,162,210,84,107,37,0,238,215,123,64,244,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePrimaryGridTabPanelParameter());
			Parameters.Add(CreateSysModuleIdParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAllViewMenuItemCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAllViewMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4a15e29f-6b1b-4f7e-86f9-3a27065c9be7"),
				Name = "AllViewMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreatePrimaryGridTabPanelParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("118d75c7-c4ce-49c7-a8c6-6539d35f4de6"),
				Name = "PrimaryGridTabPanel",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4a51da3f-cda2-4843-ab83-32c0a68c7911"),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetPrimaryGridsMethod());
			Methods.Add(CreateCreatePrimaryGridTabMethod());
			Methods.Add(CreateFillGridViewMethod());
			Methods.Add(CreateCreateViewMenuItemMethod());
			Methods.Add(CreateCreateMenuSeparatorMethod());
			Methods.Add(CreateGetModulesGridViewMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dd63d05f-387c-44c0-a440-71f1560a3610"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1463024f-817e-4e17-80af-acb47bb70398"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca5463c1-ea45-4994-9c16-4658fabb55f6"),
				Name = "System.Drawing",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b00d4773-252f-4643-971f-efa92024623f"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7cadc7a8-f9c2-49fd-bcb3-de8b38231049"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateGetPrimaryGridsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7ddcdb66-d1bc-469e-9c1d-2268ba07bebd"),
				Name = "GetPrimaryGrids",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, Guid, Guid, string, bool>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("18654d3a-afa7-437b-b230-c95a15770bcb"),
				Name = "moduleId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,65,110,219,48,16,60,199,175,32,124,162,0,65,232,61,169,1,87,113,92,3,73,235,194,118,122,44,88,105,99,47,64,145,42,73,37,16,130,252,189,75,81,72,36,75,73,237,94,108,144,218,25,206,14,103,249,40,12,51,96,43,233,216,103,166,224,137,221,162,117,87,219,170,148,112,181,172,48,143,89,247,215,58,131,106,31,179,223,90,203,217,140,71,151,147,71,194,131,114,232,234,77,118,128,66,220,9,37,246,96,136,108,103,193,164,90,41,200,28,106,149,44,134,69,67,244,143,10,76,221,10,89,28,239,243,145,115,98,54,221,212,246,78,231,149,132,181,193,66,152,122,105,48,159,146,178,1,111,146,10,90,12,149,109,192,90,250,111,190,38,63,209,29,110,117,38,164,95,82,175,60,180,156,220,104,83,8,199,183,27,2,62,224,190,50,162,193,54,160,157,67,137,14,193,38,215,224,4,74,219,236,198,172,104,100,173,242,168,245,9,243,84,203,170,80,223,68,225,101,12,5,206,243,182,130,79,87,212,67,226,11,3,52,19,165,63,239,116,124,26,0,61,146,61,57,179,58,67,195,171,179,222,210,228,72,209,65,216,185,148,43,7,133,189,71,120,58,159,239,107,159,96,160,116,77,247,27,136,254,95,51,173,222,104,118,71,29,148,218,226,121,166,174,91,4,209,124,55,57,152,47,245,220,102,124,52,107,55,40,29,24,235,209,124,36,137,6,132,131,80,227,19,183,22,134,142,247,0,30,54,83,93,148,194,160,213,106,91,151,144,44,254,84,66,118,179,62,237,167,235,157,172,123,115,219,190,250,49,30,29,26,251,235,249,211,75,151,184,51,159,20,238,81,115,150,224,194,156,146,69,50,204,19,239,143,23,177,60,104,106,55,59,48,222,12,1,105,98,168,94,105,35,246,60,185,8,47,80,99,150,31,253,147,158,31,238,153,188,0,239,80,123,69,247,66,86,1,72,159,59,169,137,98,246,143,234,227,217,136,226,201,197,9,144,241,144,70,241,251,216,208,195,140,15,38,250,195,19,67,199,35,51,23,249,235,127,153,24,112,149,81,237,75,126,249,23,23,94,97,160,213,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreatePrimaryGridTabMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1033f647-c020-488e-b208-d61fba7b4dff"),
				Name = "CreatePrimaryGridTab",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Tab"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8193f92d-dd68-4b55-970d-7c2d4a297dd8"),
				Name = "primaryGridId",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f70261f3-7cc6-45d9-9d49-d2f225da567a"),
				Name = "primaryGridPageSchemaId",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("200cfcfa-a5cf-4228-878e-ea4ecf1a25b2"),
				Name = "primaryGridCaption",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,193,110,131,48,12,61,143,175,64,156,64,235,162,238,140,118,152,54,169,67,234,42,52,218,245,236,18,143,70,10,9,10,161,85,255,126,78,75,11,84,76,155,186,19,142,253,252,108,63,91,236,192,248,10,247,75,216,248,79,206,240,151,104,12,212,250,203,178,85,194,214,184,121,209,202,26,45,107,118,49,8,27,70,177,119,202,34,20,167,204,89,35,56,91,224,222,125,123,193,5,148,72,209,224,21,45,8,73,158,192,191,247,43,35,74,48,135,153,17,60,225,108,169,51,107,132,42,194,136,125,96,37,33,199,48,120,8,38,126,16,68,20,155,235,61,154,30,225,11,84,86,104,69,156,61,150,214,25,123,59,26,166,231,167,132,20,20,74,66,167,35,94,168,253,179,29,123,35,105,236,153,243,240,84,151,26,248,93,151,20,10,116,15,16,10,143,162,118,15,146,182,145,242,56,197,192,249,39,189,7,188,173,22,151,247,207,250,119,144,243,22,122,34,92,130,255,89,72,87,193,181,152,229,91,44,225,212,78,143,177,11,37,252,42,235,13,69,177,181,4,207,14,181,197,210,77,127,45,194,74,9,203,82,52,57,82,82,129,225,227,116,122,93,123,45,184,221,222,70,226,46,42,81,53,26,155,80,106,56,157,12,182,54,54,36,161,45,168,28,89,106,116,142,117,205,50,180,100,86,68,113,248,4,217,144,86,115,65,125,16,222,193,91,20,137,66,2,122,119,225,216,149,209,118,72,237,238,44,232,44,7,27,143,198,11,159,29,196,125,99,163,36,216,187,230,141,196,99,119,189,23,241,25,180,141,81,237,159,33,254,6,94,109,182,2,37,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillGridViewMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7281b710-88af-4137-a3e9-11245373bd13"),
				Name = "FillGridView",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("28ce3b53-c9a4-4bc6-8066-7e0d00e510be"),
				Name = "moduleGridId",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8aadc8d3-77fa-493b-838f-f0038f177f0b"),
				Name = "gridTab",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Tab",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c91e0abb-746f-4626-a30c-18aac7cbfc02"),
				Name = "entities",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Tuple<Guid, string, string, bool>>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,49,79,195,48,16,133,231,84,234,127,56,58,84,142,26,172,20,152,40,1,161,8,170,12,176,20,177,32,6,183,185,52,22,105,28,217,14,21,66,253,239,156,75,146,33,4,169,147,173,231,231,231,239,157,215,74,21,144,11,115,95,20,137,197,157,121,149,184,135,8,176,180,210,74,52,60,86,117,105,225,22,66,184,235,196,183,240,157,59,243,21,92,67,38,10,131,139,241,104,171,101,250,34,214,124,149,171,253,19,150,181,59,143,69,101,165,42,7,227,232,202,167,208,176,201,113,243,241,40,181,177,228,106,179,50,165,129,73,242,73,18,195,5,45,55,189,4,210,102,51,31,190,199,35,207,165,236,154,7,201,30,107,20,22,93,139,150,130,117,216,242,23,251,34,128,190,116,25,80,146,215,87,231,62,193,120,109,56,143,29,43,166,244,200,89,127,96,211,41,1,67,20,1,235,53,61,135,185,127,76,105,231,227,168,120,82,26,212,150,133,65,71,238,60,135,241,72,102,192,6,178,255,142,239,212,238,19,138,114,130,153,4,208,108,123,191,67,12,42,173,11,92,18,96,146,254,215,216,234,26,79,172,49,232,153,7,13,157,19,87,88,9,45,172,210,204,88,45,203,45,127,216,85,246,43,128,101,45,83,254,140,123,183,50,255,56,183,195,15,58,39,28,242,160,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateViewMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8af9dc57-05da-4b19-8571-bfb2265b73d8"),
				Name = "CreateViewMenuItem",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "CheckMenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9d8b0513-2956-4751-975c-6588704bcd33"),
				Name = "viewCode",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7aa4693f-cbf3-4652-9263-6404494a6721"),
				Name = "viewCaption",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0475c347-984e-4650-9297-32f66b6ea8c0"),
				Name = "viewId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,139,219,48,16,61,59,191,66,235,195,98,179,197,236,221,248,144,186,155,18,104,151,208,164,221,67,41,101,98,79,28,111,21,105,145,101,167,165,228,191,119,244,101,59,176,208,210,28,66,242,102,244,230,205,155,145,6,80,172,213,120,98,5,19,120,102,229,17,171,31,31,81,244,107,194,146,52,95,152,88,102,81,172,41,231,0,188,67,143,190,87,178,127,33,44,254,210,226,121,213,114,141,42,246,161,207,107,147,204,6,10,172,107,143,237,160,33,204,64,165,172,3,199,35,156,208,80,24,56,148,253,30,179,59,127,52,219,201,173,86,173,104,146,248,49,78,9,14,76,65,24,188,232,86,138,192,235,254,249,216,242,25,126,62,12,40,116,231,244,151,71,16,13,102,22,98,119,5,171,145,99,3,26,19,185,127,198,74,179,14,69,141,234,13,219,161,82,208,201,131,166,46,178,39,220,151,82,104,37,57,177,132,31,35,243,82,53,29,195,244,247,34,26,200,198,147,215,79,106,28,23,131,238,31,216,174,44,207,23,81,123,96,201,77,224,10,214,167,140,138,68,10,117,175,168,191,232,226,42,106,216,251,130,99,254,6,148,233,207,84,134,125,206,28,157,207,203,204,151,169,220,83,70,81,176,251,215,89,15,118,148,102,72,68,156,252,119,43,169,155,83,148,36,164,100,3,2,121,26,116,56,145,105,182,69,189,172,116,59,32,101,4,145,180,115,86,69,69,164,208,10,42,93,176,43,253,95,239,191,25,53,27,104,176,12,57,222,182,233,204,13,173,115,207,57,187,189,157,136,50,115,100,45,58,13,162,194,144,225,44,48,5,107,208,176,149,189,170,76,219,211,161,85,43,234,80,139,154,124,251,203,172,108,18,191,27,179,227,148,8,236,135,84,77,48,73,178,154,230,180,243,146,147,237,198,247,232,239,230,78,212,43,63,32,206,105,111,205,250,187,137,117,204,241,231,190,161,97,188,150,38,50,233,176,45,249,128,189,195,161,167,233,30,119,113,26,244,207,89,174,60,139,14,82,33,84,71,74,25,151,198,110,99,43,230,165,125,114,52,37,100,235,238,65,192,158,187,7,101,130,221,91,80,204,246,207,104,176,238,68,175,15,49,219,29,149,60,219,171,152,196,37,71,80,198,36,167,61,154,53,252,65,66,253,73,158,187,36,245,118,95,22,151,124,225,6,96,159,148,252,15,7,110,145,47,7,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateMenuSeparatorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("839eb3e7-0ae0-4d80-b075-b2076f1d8d8a"),
				Name = "CreateMenuSeparator",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuSeparator"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ccad7446-ac31-4495-be42-cdc21f80205e"),
				Name = "menuSeparatorCaption",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				ModifiedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a5b771b3-f592-4276-b4ca-d6c31a468e00"),
				Name = "separatorId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,65,11,130,64,16,133,207,250,43,182,155,130,44,21,148,7,241,16,82,228,161,58,84,116,94,217,81,22,214,93,153,93,139,136,254,123,139,88,164,117,154,25,222,124,239,205,92,25,146,26,84,123,132,134,33,179,26,73,74,20,220,200,9,16,153,209,165,165,231,156,94,160,200,180,178,168,165,161,159,102,247,77,5,97,226,123,3,31,199,113,231,101,222,115,206,221,134,40,73,48,49,22,133,170,104,110,246,173,148,7,92,215,141,189,7,3,54,99,141,21,90,133,33,121,248,222,200,182,215,82,242,143,112,17,207,241,29,189,148,105,217,61,215,85,186,65,93,175,176,42,130,105,52,143,226,56,154,45,150,191,31,108,5,231,160,28,83,50,105,32,241,17,108,139,106,24,156,188,0,101,148,173,155,65,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetModulesGridViewMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85644868-b4c4-4dc0-bb23-9d71336d21ab"),
				Name = "GetModulesGridView",
				CreatedInSchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, string, string, bool>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fadd58cf-5b64-4d03-aa29-711d2a25b787"),
				Name = "sysModuleGridId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,203,110,194,48,16,69,215,201,87,88,89,25,41,202,15,240,144,40,149,16,18,237,38,161,44,170,46,220,100,0,171,142,29,249,1,106,43,254,189,126,64,33,129,22,86,132,209,157,59,103,238,120,75,36,34,77,51,33,229,6,208,16,45,20,200,137,224,28,74,77,5,207,198,77,195,104,73,220,183,87,100,75,170,55,115,81,18,230,254,82,190,198,69,110,229,43,186,54,210,171,50,47,91,104,202,168,166,160,178,165,144,31,170,33,37,248,250,84,10,211,244,250,241,214,14,93,75,90,189,80,216,169,137,96,44,140,179,243,47,236,68,93,11,126,242,155,130,206,193,201,31,137,38,56,142,218,188,233,61,253,79,162,50,204,162,28,198,7,187,244,55,132,43,30,237,149,142,157,190,108,151,81,90,218,32,80,73,26,31,147,96,166,230,207,164,118,105,22,32,37,81,98,165,179,155,84,243,242,235,212,138,187,107,37,249,167,106,115,39,182,56,9,35,19,11,49,167,74,15,10,211,48,24,76,13,173,82,20,168,78,191,239,66,176,209,8,73,80,134,105,139,198,97,135,238,108,194,214,127,37,36,216,125,17,62,63,29,162,252,218,25,123,232,59,142,34,231,136,74,35,37,112,221,162,159,85,135,241,78,129,143,253,175,137,106,139,146,183,172,16,185,7,193,61,75,16,69,116,133,176,234,58,13,255,152,17,32,2,133,234,134,119,23,66,16,94,98,68,237,131,91,167,95,131,139,55,112,222,236,123,93,162,104,67,212,152,177,153,134,90,249,24,135,200,222,122,11,82,91,245,131,21,0,225,103,80,29,245,63,64,162,130,115,154,196,21,146,11,132,240,4,178,113,85,97,23,193,205,251,227,43,169,164,126,88,122,204,32,237,174,20,192,246,241,62,150,160,141,228,135,119,215,255,1,96,201,29,144,110,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InitializePrimaryGridsSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new InitializePrimaryGrids(userConnection) {
				SchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e")
			};
		}

		#endregion

	}

	#endregion

	#region Class: InitializePrimaryGrids

	[DesignModeProperty(Name = "PrimaryGridTabPanel", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "bc29c02b046c4813bcc5346bd851ba4e", CaptionResourceItem = "Parameters.PrimaryGridTabPanel.Caption", DescriptionResourceItem = "Parameters.PrimaryGridTabPanel.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SysModuleId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "bc29c02b046c4813bcc5346bd851ba4e", CaptionResourceItem = "Parameters.SysModuleId.Caption", DescriptionResourceItem = "Parameters.SysModuleId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class InitializePrimaryGrids : ProcessUserTask
	{

		#region Constructors: Public

		public InitializePrimaryGrids(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("bc29c02b-046c-4813-bcc5-346bd851ba4e");
		}

		#endregion

		#region Properties: Public

		public virtual Object PrimaryGridTabPanel {
			get;
			set;
		}

		public virtual Guid SysModuleId {
			get;
			set;
		}

		private LocalizableString _allViewMenuItemCaption;
		public LocalizableString AllViewMenuItemCaption {
			get {
				return _allViewMenuItemCaption ?? (_allViewMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.AllViewMenuItemCaption.Value"));
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var primaryGrids = GetPrimaryGrids(SysModuleId);
			foreach (var item in primaryGrids) {
				var gridTab = CreatePrimaryGridTab(item.Item1, item.Item3, item.Item4);
				FillGridView(item.Item2, gridTab, GetModulesGridView(item.Item2));
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual List<Tuple<Guid, Guid, Guid, string, bool>> GetPrimaryGrids(Guid moduleId) {
			var result = new List<Tuple<Guid, Guid, Guid, string, bool>>();
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModulePrimaryGrid");
			entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(string.Format(TSConfiguration.CacheUtilities.DetailsCache, moduleId));
			var idColumnName = entitySchemaQuery.AddColumn("Id").Name;
			var captionColumnName = entitySchemaQuery.AddColumn("Caption").Name;
			var gridIdColumnName = entitySchemaQuery.AddColumn("SysModuleGrid.Id").Name;
			var hasAllItemsViewName = entitySchemaQuery.AddColumn("SysModuleGrid.HasAllItemsView").Name;
			var gridPageSchemaIdColumnName = entitySchemaQuery.AddColumn("SysModuleGrid.SysPageSchemaUId").Name;
			var positionColumnName = entitySchemaQuery.AddColumn("Position").OrderByAsc();
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "SysModule", moduleId));
			entitySchemaQuery.CacheItemName = string.Format("SysModulePrimaryGrids_{0}", moduleId);
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			foreach (var item in entities) {
				result.Add(new Tuple<Guid, Guid, Guid, string, bool>(item.GetTypedColumnValue<Guid>(idColumnName), item.GetTypedColumnValue<Guid>(gridIdColumnName),
				item.GetTypedColumnValue<Guid>(gridPageSchemaIdColumnName),	item.GetTypedColumnValue<string>(captionColumnName),
				item.GetTypedColumnValue<bool>(hasAllItemsViewName)));
			}
			return result;
		}

		public virtual Tab CreatePrimaryGridTab(Guid primaryGridId, Guid primaryGridPageSchemaId, string primaryGridCaption) {
			var newTab = new Terrasoft.UI.WebControls.Controls.Tab();
			newTab.UId = Guid.NewGuid();
			newTab.Name = "DetailTab" + primaryGridId.ToString().Replace("-", "").ToLower();
			newTab.Caption = primaryGridCaption;
			var primaryGridTabPanel = PrimaryGridTabPanel as TabPanel;
			primaryGridTabPanel.Add(newTab);
			Terrasoft.UI.WebControls.Controls.PageContainer newContainer = null;
			newContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			newContainer.UId = Guid.NewGuid();
			newContainer.Name = "PrimaryGridContainer" + primaryGridId.ToString().Replace("-", "").ToLower();
			newContainer.PageSchemaUId = primaryGridPageSchemaId;
			newContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			newContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			newTab.InsertItem(0, newContainer);
			newContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", 
				(primaryGridTabPanel.NamingContainer as PageContainer).PageInstance.Process.InstanceUId);
			newContainer.PageInstance.Process.SetPropertyValue("SysModuleId", SysModuleId);
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
					var dataSource = container.FindPageControlByName("DataSource")
										as DataSource;
					if (dataSource == null) {
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

		public virtual List<Tuple<Guid, string, string, bool>> GetModulesGridView(Guid sysModuleGridId) {
			var appCache = UserConnection.ApplicationCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var gridViewsCollection = TSConfiguration.CommonUtilities.GetSelectData(
				UserConnection, TSConfiguration.CommonUtilities.GetModuleGridViewsSelect, appCache, TSConfiguration.CacheUtilities.GridViewCache);
			string captionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleGridView", "Caption");
			List<Tuple<Guid, string, string, bool>> result = new List<Tuple<Guid, string, string, bool>>();
			foreach (var gridView in gridViewsCollection) {
					Guid currentSysModuleGridId = new Guid(gridView["sysModuleGridId"].ToString());
					if (sysModuleGridId == currentSysModuleGridId) {
						Guid sysModuleGridViewId = new Guid(gridView["sysModuleGridViewId"].ToString());
						string caption = gridView[captionColumnName].ToString();
						bool hasAllItemsView = Convert.ToBoolean(gridView["hasAllItemsView"].ToString());
						string code = gridView["code"].ToString();
						result.Add(new Tuple<Guid, string, string, bool>(sysModuleGridViewId, code, caption, hasAllItemsView));
					}
			}
			return result;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (PrimaryGridTabPanel != null) {
				if (PrimaryGridTabPanel.GetType().IsSerializable || PrimaryGridTabPanel.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("PrimaryGridTabPanel", PrimaryGridTabPanel, null);
				}
			}
			if (!HasMapping("SysModuleId")) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "PrimaryGridTabPanel":
					PrimaryGridTabPanel = reader.GetSerializableObjectValue();
				break;
				case "SysModuleId":
					SysModuleId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

