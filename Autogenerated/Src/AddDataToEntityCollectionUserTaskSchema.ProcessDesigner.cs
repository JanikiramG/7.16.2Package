namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: AddDataToEntityCollectionUserTaskSchema

	/// <exclude/>
	public class AddDataToEntityCollectionUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public AddDataToEntityCollectionUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public AddDataToEntityCollectionUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab");
			RealUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab");
			Name = "AddDataToEntityCollectionUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("b9acdc6c-82c9-4733-b580-e08a0c83a5c0");
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,203,110,219,48,16,60,203,128,255,129,205,73,6,4,229,3,28,27,109,157,164,8,138,0,105,133,230,206,72,235,88,129,76,5,36,213,66,104,244,239,37,181,180,76,82,143,218,45,144,139,101,105,119,135,203,153,89,242,227,69,190,37,225,13,147,185,172,55,101,81,64,42,243,146,145,213,138,176,170,40,200,219,27,241,99,113,146,238,96,79,15,41,11,242,123,62,11,56,200,138,51,34,121,5,203,249,172,153,207,176,202,164,130,253,178,26,67,92,122,85,130,238,95,139,156,61,219,31,85,206,79,202,137,0,93,10,217,166,100,66,42,160,106,207,30,105,81,129,80,232,12,126,145,235,188,5,166,188,190,178,171,49,51,34,229,211,139,42,95,135,11,15,238,182,98,233,249,104,186,202,4,58,232,62,118,98,118,115,62,126,255,27,162,107,225,18,135,35,75,192,15,182,58,67,76,170,181,199,138,143,122,52,4,10,1,83,24,122,17,84,92,183,115,39,18,111,187,159,178,236,190,204,0,251,208,41,195,56,118,183,158,153,2,171,137,96,91,114,160,233,142,132,95,161,110,57,124,160,57,191,18,146,43,196,136,224,115,109,217,163,227,154,228,140,124,135,180,228,217,53,108,145,253,248,22,100,186,187,7,73,31,168,220,129,48,171,7,125,190,29,3,155,79,43,231,99,252,5,164,29,254,92,31,112,195,129,102,98,213,189,86,112,120,177,33,134,186,69,135,130,45,80,112,102,11,237,175,105,98,202,163,177,82,48,236,239,63,154,104,19,81,27,45,93,235,140,105,209,204,196,156,42,26,62,80,171,119,84,74,143,242,86,13,186,150,96,140,77,66,197,224,97,176,52,214,111,235,157,193,12,198,78,158,81,214,53,198,194,159,138,209,227,112,92,188,73,71,52,167,14,244,221,183,10,120,77,159,10,48,123,94,123,182,104,227,138,179,141,114,128,132,246,173,61,187,142,131,140,121,94,153,22,126,0,200,144,102,114,212,209,105,254,121,10,227,98,24,11,127,8,224,138,23,134,71,27,90,243,242,178,171,141,19,144,202,92,54,105,216,96,128,137,155,242,181,118,130,110,91,209,177,11,172,82,112,78,122,23,142,198,47,173,174,242,192,177,239,6,7,197,91,127,204,65,61,208,115,1,135,234,16,180,119,95,104,151,185,60,52,206,221,241,191,130,157,162,215,63,19,255,247,221,168,205,216,87,210,197,31,178,180,183,242,52,9,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntityCollectionParameter());
			Parameters.Add(CreateSamplingEntityCollectionParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateRecordDefValuesParameter());
			Parameters.Add(CreateIsSelectedSamplingAddModeParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("233fbe97-72a2-4565-b5b9-dff344c467e5"),
				Name = "EntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSamplingEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("568d5e39-407d-4c0d-8870-a528ed9605ca"),
				Name = "SamplingEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2c6d8535-b413-462e-82b5-3857f8393587"),
				Name = "DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordDefValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b3b3d042-dcff-4ae0-84b9-dc6043c146eb"),
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

		protected virtual ProcessSchemaParameter CreateIsSelectedSamplingAddModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9b0bfcf7-fd43-48c1-95f0-259da2751fca"),
				Name = "IsSelectedSamplingAddMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateCreateQueryMethod());
			Methods.Add(CreateSetColumnValuesMethod());
			Methods.Add(CreateSetSamplingColumnValuesMethod());
			Methods.Add(CreateShouldSetColumnValueMethod());
			Methods.Add(CreateSetSamplingFuncColumnValuesMethod());
			Methods.Add(CreateCopyColumnValuesMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f6dae533-1597-44c8-8e19-2824f9f71807"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1b2a8a2e-f641-4ab3-ab74-d8e31363e834"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("db9167e8-269e-49ab-a8e7-a753aa9234f0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("56990565-165e-400e-9e5f-cb7ce0082fcd"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4da18a8a-6b87-4079-bdb0-4bc069ac7aec"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b0a2d08c-9dc5-402c-8023-b7779fbcfaef"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f8215a95-244f-454b-b31f-c689a99cb261")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("612e3c26-cf79-47c9-a3a5-d22a847e9c83"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d81bc9e1-0b30-47d3-b8ff-286e6358f977"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("75a8cd88-7f42-490f-9f97-dddb08478355"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f20a8948-315f-454f-9b4b-6ec5be44e261"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e41c3c8c-b378-49d8-bc44-966d457cc15b"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d6e54e19-f10d-41fd-97a9-26612522e9da"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4cdaf2bc-2c88-471c-aac9-8133661c65f5"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateQueryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4812e1f6-0c85-47f9-8ee7-cf804a36cdcb"),
				Name = "CreateQuery",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "IQueryable<Entity>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,221,106,194,64,16,133,175,179,79,177,222,109,32,228,5,66,111,170,22,10,197,31,162,15,176,196,177,14,110,118,117,102,214,18,74,223,189,43,10,193,68,111,15,231,124,124,51,51,43,182,14,145,26,248,64,39,64,211,224,28,52,130,193,235,253,48,120,211,62,58,87,41,220,107,51,97,33,244,223,229,39,47,82,182,164,121,123,146,206,204,6,52,206,115,253,171,178,39,164,21,133,6,152,183,12,180,177,124,220,10,58,20,4,46,167,193,95,128,100,19,238,141,33,178,167,24,149,101,215,125,90,248,91,82,232,218,182,39,151,188,230,94,80,186,190,91,214,205,1,90,91,104,57,32,23,122,236,89,169,63,117,177,164,211,248,124,87,8,116,189,24,126,70,237,175,190,3,100,30,21,18,136,64,34,249,71,82,249,30,209,237,214,17,168,51,175,28,139,209,199,243,234,31,80,70,200,179,159,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e875f6a8-31da-4519-b0fe-bdbc633699b4"),
				Name = "SetColumnValues",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9b7ea3a5-b441-4c2a-a2ee-44b46f303c5b"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc70e283-4cee-4099-8d67-714c6f0e2fcd"),
				Name = "selectedConstColumnValues",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<EntitySchemaColumn, object>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,143,63,11,195,32,16,197,231,248,41,110,52,16,66,247,52,93,66,167,46,1,161,187,53,23,98,49,10,254,25,66,241,187,87,204,82,16,167,46,55,220,123,247,123,239,228,10,212,161,66,225,113,153,140,118,126,50,42,236,250,201,85,64,215,79,38,104,15,227,8,151,22,62,164,177,232,131,213,3,137,100,53,22,185,216,128,62,240,200,222,153,75,123,189,107,47,253,193,196,134,59,63,57,29,152,215,59,193,111,80,11,1,169,171,154,203,169,37,21,176,92,141,85,74,159,58,14,164,145,233,83,182,153,160,22,134,191,50,45,97,93,157,149,103,155,123,53,231,97,255,63,46,181,139,36,126,1,12,142,4,115,139,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetSamplingColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("267797dd-2c26-4f16-b9d4-ddd22ce9035b"),
				Name = "SetSamplingColumnValues",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d54cd3dc-740b-45b5-a867-445419639ddb"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9478d965-0271-4ffd-80b3-d115c8b5c5a4"),
				Name = "samplingEntity",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("095a4011-72b9-4835-a4a9-5cf1868c8f2b"),
				Name = "selectedSamplingColumnValues",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<EntitySchemaColumn, EntitySchemaColumn>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,189,14,130,48,20,133,103,250,20,119,132,132,16,119,172,11,49,14,46,38,36,238,21,46,82,83,90,211,159,129,24,222,221,166,24,131,130,12,46,29,238,57,253,206,185,45,111,32,54,40,176,178,88,151,172,187,11,46,175,133,18,174,147,103,38,28,154,172,80,78,90,160,20,54,9,60,72,164,209,58,45,115,50,144,70,105,100,85,11,241,17,251,224,61,49,174,183,123,105,185,237,203,170,197,142,141,156,20,230,179,29,172,100,2,151,107,178,9,61,230,76,192,249,136,174,129,50,95,60,95,36,153,151,121,65,90,39,134,211,51,213,229,230,61,111,206,116,57,250,69,207,14,104,39,122,252,59,59,241,96,238,191,171,108,149,19,117,249,121,109,190,124,186,20,159,132,199,139,70,119,246,39,195,247,24,200,240,4,188,141,6,250,58,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateShouldSetColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("35fb2ea7-5705-442a-ba48-ffefe76c56b8"),
				Name = "ShouldSetColumnValue",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6f20eb60-581e-4c3d-a112-0dcbf6b15635"),
				Name = "entitySchemaColumn",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaColumn",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6bd15e9b-f335-4f74-b0aa-1c2f885b148b"),
				Name = "value",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,59,11,194,64,16,132,235,4,242,31,182,10,119,77,254,64,72,163,145,16,240,81,248,232,15,221,224,146,203,131,187,93,33,24,255,187,158,8,54,218,204,48,195,192,55,212,168,210,176,57,76,35,30,153,44,49,161,207,42,228,218,111,197,218,157,43,23,193,79,198,10,170,91,80,173,225,158,196,145,67,22,215,67,99,172,199,60,137,31,73,76,13,40,133,61,19,79,251,243,21,59,179,28,172,116,125,86,251,245,48,180,50,6,4,204,51,252,156,108,196,50,125,119,250,69,136,210,20,84,37,116,209,111,46,20,5,132,148,173,186,145,167,127,39,62,13,59,193,252,9,96,137,117,42,219,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetSamplingFuncColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ebcb6ee7-7cc3-4b9f-9d13-c716bdd1e36e"),
				Name = "SetSamplingFuncColumnValues",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("87490cd4-f04a-4109-8373-e49bfa7c48cb"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("66af9b46-6ff6-4e88-8347-c0ce88261439"),
				Name = "samplingEntity",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b9c0077a-a0b2-4def-baec-c5a68de67d63"),
				Name = "selectedFuncColumnValues",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<EntitySchemaColumn, Func<Entity, object>>",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,177,14,130,48,20,69,103,250,21,111,44,9,33,238,8,11,209,196,184,152,144,184,87,120,72,181,180,6,90,19,98,248,119,43,213,4,173,46,46,29,218,119,207,185,175,188,6,218,163,192,82,99,181,54,178,204,149,48,173,220,51,97,176,143,115,101,164,134,52,133,69,8,55,18,116,168,77,39,19,50,146,90,117,200,202,6,232,22,135,105,118,199,120,183,92,73,205,245,80,148,13,182,204,113,34,120,48,159,15,17,168,195,201,138,178,12,234,119,19,112,9,191,74,76,102,159,12,232,95,165,159,220,216,214,75,72,224,180,208,179,246,34,184,60,206,197,126,196,157,27,121,85,103,164,175,136,243,135,150,197,237,127,21,141,50,162,42,80,207,114,212,239,19,125,51,134,211,62,129,155,142,255,100,216,30,35,25,239,34,114,141,200,187,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("14213706-bcd2-4469-80ce-78c6fb63fbb4"),
				Name = "CopyColumnValues",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bf45a6ad-1c49-4be4-a73f-d1df19a847a3"),
				Name = "sourceEntity",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aa6b25ce-cdae-4770-98b2-ca7d973228a6"),
				Name = "targetEntity",
				CreatedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				ModifiedInSchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,189,14,130,48,20,133,103,251,20,117,67,98,224,1,136,19,58,144,160,11,234,222,148,2,141,133,146,254,12,196,248,238,34,109,76,65,197,176,116,184,247,220,243,157,147,134,62,56,52,138,170,46,195,21,169,81,204,153,174,155,254,101,4,43,202,27,40,157,177,132,59,40,185,22,152,152,147,192,220,4,118,27,129,130,11,130,112,5,189,79,203,145,17,164,19,227,13,188,131,149,84,130,54,37,196,195,232,138,152,38,39,84,147,23,211,145,90,216,123,29,129,149,66,162,36,202,70,74,57,202,29,137,231,230,221,78,189,55,209,155,154,83,217,50,212,197,243,240,253,87,85,239,66,11,232,77,131,175,119,63,92,135,182,75,98,255,176,233,185,15,131,30,133,76,228,81,51,69,83,206,111,186,61,119,173,229,217,162,246,7,205,223,92,146,252,79,227,108,86,29,45,235,49,143,54,125,30,192,15,159,105,233,46,95,149,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AddDataToEntityCollectionUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new AddDataToEntityCollectionUserTask(userConnection) {
				SchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab")
			};
		}

		#endregion

	}

	#endregion

	#region Class: AddDataToEntityCollectionUserTask

	[DesignModeProperty(Name = "EntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d86f08f2b04f4b1080d0731c55b045ab", CaptionResourceItem = "Parameters.EntityCollection.Caption", DescriptionResourceItem = "Parameters.EntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SamplingEntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d86f08f2b04f4b1080d0731c55b045ab", CaptionResourceItem = "Parameters.SamplingEntityCollection.Caption", DescriptionResourceItem = "Parameters.SamplingEntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d86f08f2b04f4b1080d0731c55b045ab", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordDefValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d86f08f2b04f4b1080d0731c55b045ab", CaptionResourceItem = "Parameters.RecordDefValues.Caption", DescriptionResourceItem = "Parameters.RecordDefValues.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSelectedSamplingAddMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d86f08f2b04f4b1080d0731c55b045ab", CaptionResourceItem = "Parameters.IsSelectedSamplingAddMode.Caption", DescriptionResourceItem = "Parameters.IsSelectedSamplingAddMode.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class AddDataToEntityCollectionUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public AddDataToEntityCollectionUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("d86f08f2-b04f-4b10-80d0-731c55b045ab");
		}

		#endregion

		#region Properties: Public

		public virtual EntityCollection EntityCollection {
			get;
			set;
		}

		public virtual EntityCollection SamplingEntityCollection {
			get;
			set;
		}

		public virtual string DataSourceFilters {
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

		public virtual bool IsSelectedSamplingAddMode {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntityCollection == null || EntityCollection.Schema == null) {
				return true;
			}
			EntitySchema entitySchema = EntityCollection.Schema;
			EntitySchema samplingEntitySchema;
			var selectedConstColumnValues = new Dictionary<EntitySchemaColumn, object>();
			var selectedFuncColumnValues = new Dictionary<EntitySchemaColumn, Func<Entity, object>>();
			var selectedSamplingColumnValues = new Dictionary<EntitySchemaColumn, EntitySchemaColumn>();
			if (SamplingEntityCollection != null) {
				samplingEntitySchema = SamplingEntityCollection.Schema;
			} else {
				samplingEntitySchema = null;
			}
			if (IsSelectedSamplingAddMode) {
				if (samplingEntitySchema == null) {
					return true;
				} else {
					foreach (KeyValuePair<string, string> selectedColumnValue in RecordDefValues.FetchMetaPathes) {
						EntitySchemaColumn entitySchemaColumn = entitySchema.GetSchemaColumnByMetaPath(selectedColumnValue.Key);
						EntitySchemaColumn samplingEntitySchemaColumn = samplingEntitySchema
							.GetSchemaColumnByMetaPath(selectedColumnValue.Value);
						selectedSamplingColumnValues.Add(entitySchemaColumn, samplingEntitySchemaColumn);
					}
				}
			}
			foreach (KeyValuePair<string, object> selectedColumnValue in RecordDefValues.Values) {
				EntitySchemaColumn entitySchemaColumn = entitySchema.GetSchemaColumnByMetaPath(selectedColumnValue.Key);
				var func = selectedColumnValue.Value as Func<Entity, object>;
				if (func != null) {
					selectedFuncColumnValues.Add(entitySchemaColumn, func);
				} else {
					selectedConstColumnValues.Add(entitySchemaColumn, selectedColumnValue.Value);
				}
			}
			if (IsSelectedSamplingAddMode) {
				IQueryable<Entity> samplingEntityQuery = CreateQuery();
				foreach (Entity samplingEntity in samplingEntityQuery) {
					Entity newEntity = entitySchema.CreateEntity(UserConnection);
					//newEntity.SetDefColumnValues();
					
					//CopyColumnValues(samplingEntity, newEntity);
					SetColumnValues(newEntity, selectedConstColumnValues);
					SetSamplingFuncColumnValues(newEntity, samplingEntity, selectedFuncColumnValues);
					SetSamplingColumnValues(newEntity, samplingEntity, selectedSamplingColumnValues);
					EntityCollection.Add(newEntity);
				}
			} else {
				Entity newEntity = entitySchema.CreateEntity(UserConnection);
				//newEntity.SetDefColumnValues();
				SetColumnValues(newEntity, selectedConstColumnValues);
				EntityCollection.Add(newEntity);
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public virtual IQueryable<Entity> CreateQuery() {
			DataSourceFilterCollection filterCollection = null;
			if (!string.IsNullOrEmpty(DataSourceFilters)) {
				filterCollection = ProcessUserTaskUtilities.ConvertToProcessDataSourceFilterCollection(
					UserConnection, SamplingEntityCollection.Schema, this, DataSourceFilters);
			}
			var linqConvertor = new DataSourceFilterLinqConverter(UserConnection);
			return linqConvertor.BuildQuery(SamplingEntityCollection, filterCollection);
		}

		public virtual void SetColumnValues(Entity entity, Dictionary<EntitySchemaColumn, object> selectedConstColumnValues) {
			if (selectedConstColumnValues.Count == 0) {
				return;
			}
			foreach (KeyValuePair<EntitySchemaColumn, object> selectedConstColumnValue in selectedConstColumnValues) {
				EntitySchemaColumn entitySchemaColumn = selectedConstColumnValue.Key;
				if (ShouldSetColumnValue(entitySchemaColumn, selectedConstColumnValue.Value)) {
					entity.SetColumnValue(entitySchemaColumn, selectedConstColumnValue.Value);
				}
			}
		}

		public virtual void SetSamplingColumnValues(Entity entity, Entity samplingEntity, Dictionary<EntitySchemaColumn, EntitySchemaColumn> selectedSamplingColumnValues) {
			if (selectedSamplingColumnValues.Count == 0) {
				return;
			}
			foreach (KeyValuePair<EntitySchemaColumn, EntitySchemaColumn> selectedSamplingColumnValue in selectedSamplingColumnValues) {
				EntitySchemaColumn entitySchemaColumn = selectedSamplingColumnValue.Key;
				EntitySchemaColumn samplingEntitySchemaColumn = selectedSamplingColumnValue.Value;
				object samplingColumnValue = samplingEntity.GetColumnValue(samplingEntitySchemaColumn);
				if (ShouldSetColumnValue(entitySchemaColumn, samplingColumnValue)) {
					entity.SetColumnValue(entitySchemaColumn, samplingColumnValue);
				}
			}
		}

		public virtual bool ShouldSetColumnValue(EntitySchemaColumn entitySchemaColumn, object value) {
			if(DataTypeUtilities.GetIsNullOrDBNullValue(value)) {
				return false;
			}
			if ((entitySchemaColumn.IsLookupType || entitySchemaColumn.IsMultiLookupType)
					&& (Guid)value == Guid.Empty) {
				return false;
			}
			return true;
		}

		public virtual void SetSamplingFuncColumnValues(Entity entity, Entity samplingEntity, Dictionary<EntitySchemaColumn, Func<Entity, object>> selectedFuncColumnValues) {
			if (selectedFuncColumnValues.Count == 0) {
				return;
			}
			foreach (KeyValuePair<EntitySchemaColumn, Func<Entity, object>> funcColumnValue in selectedFuncColumnValues) {
				EntitySchemaColumn entitySchemaColumn = funcColumnValue.Key;
				object samplingColumnValue = funcColumnValue.Value.Invoke(samplingEntity);
				if (ShouldSetColumnValue(entitySchemaColumn, samplingColumnValue)) {
					entity.SetColumnValue(entitySchemaColumn, samplingColumnValue);
				}
			}
		}

		public virtual void CopyColumnValues(Entity sourceEntity, Entity targetEntity) {
			/*
			EntitySchemaColumnCollection schemaColumns = sourceEntity.Schema.Columns;
			foreach (EntitySchemaColumn schemaColumn in schemaColumns) {
				string columnValueName = schemaColumn.ColumnValueName;
				targetEntity.LoadColumnValue(sourceEntity, columnValueName);
				string displayColumnValueName = schemaColumn.DisplayColumnValueName;
				if (columnValueName != displayColumnValueName) {
					targetEntity.LoadColumnValue(sourceEntity, displayColumnValueName);
				}
				if (schemaColumn.IsMultiLookupType) {
					string  sourceSchemaUIdColumnValueName = schemaColumn.SourceSchemaUIdColumnValueName;
					targetEntity.LoadColumnValue(sourceEntity, sourceSchemaUIdColumnValueName);
				}
			}
			*/
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			if (!HasMapping("IsSelectedSamplingAddMode")) {
				writer.WriteValue("IsSelectedSamplingAddMode", IsSelectedSamplingAddMode, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "RecordDefValues":
					if (UseFlowEngineMode) {
						RecordDefValues = reader.GetValue<EntityColumnMappingValues>();
					}
				break;
				case "IsSelectedSamplingAddMode":
					IsSelectedSamplingAddMode = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

