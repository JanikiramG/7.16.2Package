namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: AddDataUserTaskSchema

	/// <exclude/>
	public class AddDataUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public AddDataUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public AddDataUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71");
			RealUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71");
			Name = "AddDataUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("d84286d0-3e64-4e9f-9d71-7e80c73b191d");
			ParametersEditPageSchemaV2UId = new Guid("ed565d7e-5e4b-41ef-a04d-531890719306");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,221,78,131,48,20,190,110,159,162,238,170,36,100,47,128,26,163,99,102,23,26,195,18,189,110,224,32,77,74,153,229,116,11,49,188,187,165,56,129,133,225,5,41,77,191,223,246,60,172,18,72,43,147,237,50,118,199,158,173,204,214,113,121,192,38,162,50,103,60,214,40,177,217,167,5,148,98,231,78,190,172,80,53,31,80,65,192,190,41,49,128,214,104,134,198,66,68,91,226,153,91,169,16,204,148,207,110,198,14,158,186,145,41,202,74,11,211,220,214,104,164,254,12,89,191,222,51,240,220,167,74,217,82,191,136,131,75,167,173,82,17,37,71,97,88,238,229,19,168,173,194,248,12,84,224,197,186,30,128,219,5,4,175,44,94,234,7,78,57,175,12,136,180,96,124,222,130,73,189,104,236,27,249,120,26,78,191,20,159,229,245,188,229,157,11,233,238,103,132,232,139,245,228,233,93,18,210,186,207,53,81,73,117,250,144,88,108,4,138,199,166,175,54,72,132,51,169,194,185,126,228,143,178,222,139,35,240,220,189,38,116,7,45,109,25,184,255,46,195,191,249,23,226,79,211,187,81,184,12,63,16,59,165,107,113,70,19,57,64,222,140,44,221,156,244,133,222,133,242,195,70,39,142,171,31,154,167,245,236,205,2,0,0 };
			SerializeToDB = true;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntitySchemaIdParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateRecordAddModeParameter());
			Parameters.Add(CreateFilterEntitySchemaIdParameter());
			Parameters.Add(CreateRecordDefValuesParameter());
			Parameters.Add(CreateRecordIdParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInvalidRightExpressionParameterValueExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInvalidRightExpressionParameterValueExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4aa0b1af-a85d-46af-b49c-98873dc8b554"),
				Name = "InvalidRightExpressionParameterValueException",
				CreatedInPackageId = new Guid("415f292c-4eb5-4c80-8e80-df146f3cd0dc"),
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4573b9c8-b4d4-442e-a499-682e7b31ab10"),
				Name = "EntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("24151caf-0cf3-48bb-862c-ba9a0ddc4b29"),
				Name = "DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordAddModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("06ad8e3f-90fc-4aa2-922d-3fa9c386f7fc"),
				Name = "RecordAddMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFilterEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cb4a4921-dd8e-4b41-b4f9-539408697296"),
				Name = "FilterEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordDefValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f1b0cf15-8edd-4df1-948f-7dd046622d22"),
				Name = "RecordDefValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("01b58ce0-aa7f-40c5-a5c6-b4ddffb5d0c7"),
				Name = "RecordId",
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
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateGetFilterResultEntityCollectionMethod());
			Methods.Add(CreateGetEntitySchemaMethod());
			Methods.Add(CreateGetNewEntityMethod());
			Methods.Add(CreateFillRowWithDataByFilterMethod());
			Methods.Add(CreateFillRowWithDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8e5fbb15-b808-4701-be64-2cb18d734e4e"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2b63aec8-7df8-4218-a8e9-614d076a60c0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("021bedf8-949b-4ad3-addf-f62d520deebe"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a80ccad5-1326-4384-af88-7fd2763e51dc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("415f292c-4eb5-4c80-8e80-df146f3cd0dc")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2968733f-7b64-4fe7-a71e-5f7879edc4a9"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ab2be97a-9ed2-4961-b94e-7a2771e0470d"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bcb1ffe1-b116-40b8-9855-e5f75b5a41e6"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a6cdc3d1-f190-4b6c-b727-ac9d45fbdc87"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1564da9e-b172-474f-9e4e-e90bb3a8847b"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFilterResultEntityCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cb574a44-80d8-47b3-8113-7f7168e146c7"),
				Name = "GetFilterResultEntityCollection",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntityCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("75cb83e9-6fb9-49a4-9516-6951f674f34b"),
				Name = "entityColumnMap",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Output,
				ValueTypeName = "out Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,61,111,219,48,16,157,229,95,193,46,129,4,8,66,119,183,5,92,219,9,50,196,117,162,166,75,209,129,160,78,17,81,138,116,200,99,3,161,241,127,239,145,116,98,217,42,144,44,18,37,222,251,184,119,36,104,148,56,44,141,242,189,190,225,59,246,153,105,175,212,124,38,91,150,95,74,133,96,215,177,162,22,29,244,252,186,169,214,143,158,43,151,95,121,73,235,126,135,67,81,176,191,179,204,2,122,171,15,224,253,236,15,183,12,70,64,226,189,2,28,83,253,151,189,152,179,168,124,10,77,158,222,35,115,235,193,14,161,7,120,98,235,243,255,39,172,197,124,54,1,86,247,14,22,77,47,245,157,124,232,208,17,79,75,173,66,10,227,14,132,177,205,10,218,31,92,121,112,213,37,160,232,110,0,249,150,99,7,238,197,37,123,126,102,111,148,86,75,227,53,6,192,199,216,211,212,199,214,202,158,219,33,126,164,209,84,215,110,161,158,248,224,106,80,32,8,204,208,122,114,182,103,64,14,143,44,39,131,164,16,86,82,160,52,154,200,62,57,180,82,63,148,44,189,191,228,148,64,214,26,11,92,116,44,15,65,138,136,141,158,153,212,111,117,81,176,160,154,37,182,3,54,236,144,240,184,161,138,198,158,86,203,215,146,175,195,11,77,62,210,172,226,51,184,202,130,155,199,99,243,103,148,41,163,69,211,164,221,252,168,29,193,103,65,252,156,72,252,34,190,17,123,181,225,61,37,153,237,233,60,133,65,127,120,231,177,103,23,23,108,197,145,215,198,91,1,9,228,104,78,27,131,27,58,8,223,108,44,203,211,245,216,90,35,192,57,58,96,246,59,119,191,239,81,42,137,146,82,173,119,32,100,59,172,235,219,3,67,30,106,150,70,107,136,147,43,25,118,210,149,39,1,148,211,56,74,106,124,98,166,8,87,228,112,99,166,1,190,222,71,138,65,37,177,51,237,98,254,15,193,227,107,183,30,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEntitySchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e143d053-ddeb-4b10-85c4-5bccdc7e8e87"),
				Name = "GetEntitySchema",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "EntitySchema"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("92b1209c-ffc4-423a-b3f4-69d8d9acdc0d"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,205,43,201,44,169,12,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,241,204,43,46,73,204,75,78,117,170,12,245,76,209,72,69,82,228,153,162,105,173,0,0,229,242,29,53,76,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNewEntityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d2eabdae-090d-4141-b7c9-5e7ee00ed4be"),
				Name = "GetNewEntity",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Entity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,205,65,10,194,48,20,4,208,125,79,145,101,220,244,2,193,133,68,17,183,150,186,15,237,212,6,146,31,72,126,42,222,222,15,5,141,203,153,225,49,155,203,10,196,158,223,195,180,34,58,117,84,87,240,165,105,116,27,110,243,193,116,155,24,194,107,239,5,180,190,183,25,142,177,111,122,44,200,54,17,97,98,159,72,232,151,245,3,248,140,197,166,80,35,61,92,168,40,250,111,23,122,154,163,167,187,127,174,92,228,101,113,161,192,116,25,92,51,253,254,205,7,239,164,182,86,194,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillRowWithDataByFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1b3b2e9d-4c7f-4199-b1e8-ae9fe4a79305"),
				Name = "FillRowWithDataByFilter",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4140ac93-fef8-4e38-826a-4846d031a63e"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e2a0912f-219f-4f5f-a94d-8b7a8b27c441"),
				Name = "filterEntity",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e58eeb74-4d7e-4855-9bcc-50d309b4ce67"),
				Name = "entityColumnMap",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,205,78,195,48,12,62,183,79,225,221,90,105,234,11,76,187,208,117,8,193,196,52,58,56,32,14,81,112,213,104,105,83,37,46,168,66,125,119,242,67,181,192,129,67,34,199,206,247,99,123,47,164,60,169,207,23,65,237,142,17,203,176,39,65,83,190,73,27,165,145,241,22,178,15,166,129,43,57,118,253,51,147,35,130,232,225,132,92,233,247,29,54,62,99,138,61,18,111,15,72,236,200,168,69,147,195,23,164,201,21,7,91,8,180,197,19,111,177,99,197,45,82,136,74,95,191,153,22,108,22,9,21,247,232,124,36,149,135,198,255,161,17,146,80,151,11,121,120,86,255,75,120,250,96,35,164,14,108,120,141,229,252,253,230,20,157,243,192,25,58,254,163,96,169,203,43,46,139,205,56,180,104,32,139,209,171,45,244,163,148,118,40,105,226,139,71,173,56,26,115,54,168,107,102,46,103,18,82,144,176,99,180,196,119,166,234,6,154,30,148,186,140,195,163,182,43,193,90,116,24,43,249,120,253,51,218,194,45,205,103,234,105,192,60,136,36,92,89,167,253,136,214,77,50,219,179,76,255,183,241,192,176,142,91,117,254,231,116,254,6,211,3,73,18,21,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFillRowWithDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d4cba07d-d41a-4818-ab36-a7fcceedaa94"),
				Name = "FillRowWithData",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("90c9ef8f-2ed9-4524-9072-9cb70e32c1a5"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,143,221,10,194,48,12,133,175,183,167,232,229,6,163,47,32,187,241,7,17,21,135,78,239,99,205,88,221,79,71,155,13,138,248,238,150,110,178,93,37,228,36,231,124,41,148,70,16,101,52,128,102,66,213,125,211,62,160,238,145,201,150,93,81,40,253,218,98,225,39,134,143,37,102,159,48,152,183,89,202,176,37,73,150,223,68,137,13,240,61,210,216,109,188,190,182,103,36,200,128,202,104,97,207,143,104,227,85,24,168,231,27,5,177,193,71,166,75,128,49,205,173,200,130,69,153,86,2,141,185,27,212,57,152,234,78,178,150,36,29,146,11,59,152,93,211,145,61,41,85,245,221,69,111,129,48,151,13,250,243,200,27,39,147,47,119,26,248,121,110,59,140,253,35,129,80,142,190,245,73,223,48,248,191,130,180,153,81,38,240,100,196,116,216,223,31,91,161,48,164,53,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AddDataUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new AddDataUserTask(userConnection) {
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
		}

		#endregion

	}

	#endregion

	#region Class: AddDataUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "db6abed10c5f455b80532665378cdb71", CaptionResourceItem = "Parameters.EntitySchemaId.Group", DescriptionResourceItem = "Parameters.EntitySchemaId.Group")]
	[DesignModeProperty(Name = "EntitySchemaId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "db6abed10c5f455b80532665378cdb71", CaptionResourceItem = "Parameters.EntitySchemaId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "db6abed10c5f455b80532665378cdb71", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordAddMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "db6abed10c5f455b80532665378cdb71", CaptionResourceItem = "Parameters.RecordAddMode.Caption", DescriptionResourceItem = "Parameters.RecordAddMode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FilterEntitySchemaId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "db6abed10c5f455b80532665378cdb71", CaptionResourceItem = "Parameters.FilterEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.FilterEntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordDefValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "db6abed10c5f455b80532665378cdb71", CaptionResourceItem = "Parameters.RecordDefValues.Caption", DescriptionResourceItem = "Parameters.RecordDefValues.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "db6abed10c5f455b80532665378cdb71", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class AddDataUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public AddDataUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71");
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntitySchemaId {
			get;
			set;
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		public virtual string RecordAddMode {
			get;
			set;
		}

		public virtual Guid FilterEntitySchemaId {
			get;
			set;
		}

		private EntityColumnMappingValues _recordDefValues;
		public virtual EntityColumnMappingValues RecordDefValues {
			get {
				return _recordDefValues ?? ( _recordDefValues = new EntityColumnMappingValues (
					new Dictionary<string, object>(),
					new Dictionary<string, string>()));
			}
			set {
				_recordDefValues = value;
			}
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		private LocalizableString _invalidRightExpressionParameterValueException;
		public LocalizableString InvalidRightExpressionParameterValueException {
			get {
				return _invalidRightExpressionParameterValueException ?? (_invalidRightExpressionParameterValueException = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.InvalidRightExpressionParameterValueException.Value"));
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			RecordId = Guid.Empty;
			if (EntitySchemaId.Equals(Guid.Empty)) {
				return true;
			}	
			if (FilterEntitySchemaId != Guid.Empty) {
				Dictionary<string, string> entityColumnMap = null;
				var filterResultEntityCollection = GetFilterResultEntityCollection(out entityColumnMap);
				foreach (var filterResultEntity in filterResultEntityCollection) {
					var newEntity = GetNewEntity();
					if (newEntity == null) {
						return true;
					}
					FillRowWithDataByFilter(newEntity, filterResultEntity, entityColumnMap);
					newEntity.Save(false);
				}
			} else {
				var newEntity = GetNewEntity();
				if (newEntity == null) {
					return true;
				}	
				FillRowWithData(newEntity);
				newEntity.Save(false);
				RecordId = newEntity.PrimaryColumnValue;
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public virtual EntityCollection GetFilterResultEntityCollection(out Dictionary<string, string> entityColumnMap) {
			entityColumnMap = null;
			if (FilterEntitySchemaId.Equals(Guid.Empty)) {
				return null;
			}
			var entitySchema = GetEntitySchema(FilterEntitySchemaId); 
			if (entitySchema == null) {
				return null;
			}
			var entitySchemaQuery = new EntitySchemaQuery(entitySchema);
			entitySchemaQuery.UseAdminRights = false;
			if (RecordDefValues.FetchMetaPathes == null || RecordDefValues.FetchMetaPathes.Count == 0) {
				entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			} else {
				entityColumnMap = new Dictionary<string, string>();
				foreach (var columnValue in RecordDefValues.FetchMetaPathes)  {
					string columnPath = entitySchema.GetSchemaColumnPathByMetaPath(columnValue.Value);
					var queryColumn = entitySchemaQuery.AddColumn(columnPath);
					entityColumnMap[columnValue.Value] = queryColumn.Name;
				}
			}
			if (!FilterEntitySchemaId.Equals(Guid.Empty) && DataSourceFilters.IsNotNullOrEmpty()) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, entitySchemaQuery,
					DataSourceFilters);
			}
			return entitySchemaQuery.GetEntityCollection(UserConnection);
		}

		public virtual EntitySchema GetEntitySchema(Guid entitySchemaId) {
			return UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaId); 
		}

		public virtual Entity GetNewEntity() {
			var entitySchema = GetEntitySchema(EntitySchemaId);
			var newEntity = entitySchema.CreateEntity(UserConnection);
			newEntity.SetDefColumnValues();
			newEntity.UseAdminRights = false;
			return newEntity;
		}

		public virtual void FillRowWithDataByFilter(Entity entity, Entity filterEntity, Dictionary<string, string> entityColumnMap) {
			FillRowWithData(entity);
			foreach (var columnValue in RecordDefValues.FetchMetaPathes) { 
				var column = entity.Schema.GetSchemaColumnByMetaPath(columnValue.Key);
				EntitySchemaColumn filterColumn = filterEntity.Schema.GetSchemaColumnByPath(entityColumnMap[columnValue.Value]);
				var filterValue = filterEntity.GetColumnValue(filterColumn);
				if (filterValue != null) {
					if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(filterValue, column.DataValueType)) {
						continue;
					}
					entity.SetColumnValue(column, filterValue);
				}
			}
		}

		public virtual void FillRowWithData(Entity entity) {
			foreach(var columnValue in RecordDefValues.Values) {
				var column = entity.Schema.GetSchemaColumnByMetaPath(columnValue.Key);
				object value = columnValue.Value;
				if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(value, column.DataValueType)) {
					continue;
				}
				entity.SetColumnValue(column, value);
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("EntitySchemaId")) {
				writer.WriteValue("EntitySchemaId", EntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			if (!HasMapping("RecordAddMode")) {
				writer.WriteValue("RecordAddMode", RecordAddMode, null);
			}
			if (!HasMapping("FilterEntitySchemaId")) {
				writer.WriteValue("FilterEntitySchemaId", FilterEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntitySchemaId":
					EntitySchemaId = reader.GetGuidValue();
				break;
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "RecordAddMode":
					RecordAddMode = reader.GetStringValue();
				break;
				case "FilterEntitySchemaId":
					FilterEntitySchemaId = reader.GetGuidValue();
				break;
				case "RecordDefValues":
					if (UseFlowEngineMode) {
						RecordDefValues = reader.GetValue<EntityColumnMappingValues>();
					}
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

