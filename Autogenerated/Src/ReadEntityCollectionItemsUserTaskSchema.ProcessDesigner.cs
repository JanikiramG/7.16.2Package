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

	#region Class: ReadEntityCollectionItemsUserTaskSchema

	/// <exclude/>
	public class ReadEntityCollectionItemsUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ReadEntityCollectionItemsUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ReadEntityCollectionItemsUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533");
			RealUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533");
			Name = "ReadEntityCollectionItemsUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("d48e6f5b-9107-4513-8158-6d8588391f12");
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,109,111,226,70,16,254,108,126,197,134,15,119,182,226,88,164,253,82,65,160,37,33,84,145,174,73,26,184,86,42,226,131,99,6,216,158,189,155,219,93,39,65,61,254,123,247,213,216,198,132,156,90,233,36,200,236,204,51,111,207,48,115,191,180,175,137,192,98,51,73,214,144,197,8,202,127,244,145,121,187,162,105,10,137,192,148,68,230,165,215,194,75,228,87,117,251,136,228,105,26,160,127,90,30,3,145,51,130,4,203,161,215,218,182,70,177,136,39,52,103,9,140,113,42,128,237,224,208,82,11,56,50,198,6,246,132,11,134,201,42,186,225,183,82,118,199,174,179,39,177,241,235,32,60,208,174,118,0,247,140,38,192,249,103,14,108,26,243,47,159,5,78,177,192,192,163,43,74,158,129,137,41,181,26,135,195,241,91,158,167,236,165,5,49,146,176,82,144,16,137,53,230,33,218,143,69,165,249,28,51,68,217,2,216,229,230,134,44,169,202,9,94,208,8,107,160,152,109,46,76,94,33,186,83,74,35,204,140,139,137,148,38,98,224,255,20,152,244,245,171,6,56,49,85,65,31,62,200,184,124,27,253,3,196,11,229,255,1,120,158,138,233,230,9,130,221,87,213,133,131,122,145,105,166,132,67,133,143,232,19,144,149,88,163,1,234,232,114,154,16,103,115,147,136,42,235,78,117,242,36,11,234,127,12,63,202,64,189,226,221,124,137,238,76,226,62,22,144,161,254,64,97,121,170,32,234,111,165,166,62,29,66,87,35,120,42,89,253,236,130,144,193,255,168,163,240,28,131,244,243,236,135,185,82,223,182,10,177,225,138,183,13,162,41,29,50,22,111,124,5,104,99,15,109,240,42,230,63,177,88,255,5,140,222,83,142,53,223,76,79,172,166,13,221,120,15,145,118,131,137,64,152,44,224,85,170,158,157,75,193,146,50,25,166,146,74,73,167,39,63,46,80,197,80,138,78,79,77,216,213,234,21,197,153,225,121,67,234,250,205,165,126,178,75,61,161,178,77,68,77,142,201,185,60,158,146,170,121,70,80,98,62,250,21,114,70,230,145,71,99,25,255,229,230,54,206,192,248,152,117,230,133,83,103,89,26,214,125,143,5,145,11,142,74,87,126,149,181,193,53,201,179,232,62,102,28,124,33,201,69,151,117,133,208,96,204,206,231,213,148,75,160,253,218,40,68,183,148,192,129,160,154,134,166,22,165,21,246,247,130,223,243,51,2,158,0,89,200,102,161,159,149,179,38,240,178,82,183,113,102,163,161,83,168,36,40,249,26,77,25,206,252,64,181,181,221,238,180,219,54,167,210,175,67,52,92,44,138,246,132,141,137,232,178,109,17,164,28,140,185,230,229,233,105,175,128,106,162,248,76,107,133,168,51,119,133,144,14,222,103,114,190,51,57,119,35,39,255,189,172,113,10,106,6,212,84,12,228,84,4,197,116,255,15,44,121,103,100,186,24,239,230,192,119,17,14,125,251,118,156,49,69,171,203,173,220,103,222,113,154,148,27,250,61,32,59,54,186,137,104,100,211,219,148,120,131,104,90,231,236,76,253,172,218,93,150,98,242,213,238,78,253,99,166,183,89,109,243,125,42,235,248,213,221,41,97,249,11,22,201,26,249,239,90,94,186,178,73,44,139,115,108,133,117,101,188,55,191,231,192,54,241,99,10,23,70,56,64,76,235,105,185,12,87,89,79,104,6,83,250,244,0,137,204,155,155,89,175,164,21,93,230,56,93,104,19,191,126,235,132,238,58,9,203,107,61,68,183,121,246,8,236,110,105,81,3,5,218,173,57,255,143,78,116,71,84,15,12,106,221,200,54,163,46,246,235,183,203,129,235,77,163,203,189,6,177,234,141,189,10,204,42,145,187,175,156,73,177,141,155,162,208,164,51,102,129,227,164,105,213,3,125,225,87,52,39,138,204,7,108,245,115,175,176,104,200,176,217,208,77,246,91,176,197,53,83,69,63,28,204,24,51,46,162,63,226,116,183,110,30,101,117,190,244,142,242,113,156,19,13,209,181,253,138,87,43,6,171,88,137,204,61,134,252,97,85,100,71,206,25,42,145,242,73,31,255,150,193,216,0,247,8,116,253,10,73,46,224,40,133,74,190,204,53,160,174,128,176,30,85,208,107,236,148,186,118,60,55,177,117,19,187,148,85,53,26,19,50,149,87,101,112,208,14,86,29,79,129,201,75,175,161,162,180,111,194,13,159,87,221,35,42,147,60,59,166,242,91,252,122,84,5,19,19,181,238,151,185,143,52,19,108,255,14,204,80,113,109,253,10,194,30,91,141,197,15,34,197,152,2,48,42,190,153,90,236,110,178,146,207,62,178,187,82,154,194,20,75,16,91,126,87,90,39,119,36,82,85,46,116,203,165,46,47,27,103,60,78,105,44,74,150,150,101,242,148,30,65,130,179,56,181,179,21,88,136,106,207,74,179,177,109,149,255,159,215,254,23,18,54,108,104,73,14,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateResultTypeParameter());
			Parameters.Add(CreateFunctionTypeParameter());
			Parameters.Add(CreateAggregationColumnNameParameter());
			Parameters.Add(CreateOrderInfoParameter());
			Parameters.Add(CreateResultEntityCollectionParameter());
			Parameters.Add(CreateResultCountParameter());
			Parameters.Add(CreateEntityCollectionParameter());
			Parameters.Add(CreateResultIntegerFunctionParameter());
			Parameters.Add(CreateResultFloatFunctionParameter());
			Parameters.Add(CreateResultDateTimeFunctionParameter());
			Parameters.Add(CreateResultRowsCountParameter());
			Parameters.Add(CreateReadSomeTopRecordsParameter());
			Parameters.Add(CreateNumberOfRecordsParameter());
			Parameters.Add(CreateResultEntityParameter());
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e47d0d27-5da7-43e9-aa7d-802085d27e75"),
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

		protected virtual ProcessSchemaParameter CreateResultTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("fdcab7d3-0422-450b-a11c-dfebb3f78670"),
				Name = "ResultType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFunctionTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("dd8451fb-64e8-4e28-9053-28688ecb057a"),
				Name = "FunctionType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAggregationColumnNameParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("803fdfa6-e548-4a1c-96f4-0b6da12c4337"),
				Name = "AggregationColumnName",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOrderInfoParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("69a135cf-a663-4125-b0ac-6c81e13443ab"),
				Name = "OrderInfo",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8b25ceb7-322e-4621-b788-e94d6a976451"),
				Name = "ResultEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultCountParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b9460067-56d5-4865-8ba0-01168ab7788e"),
				Name = "ResultCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityCollectionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("87254bde-b7a9-4112-a567-fbae7817fcd0"),
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

		protected virtual ProcessSchemaParameter CreateResultIntegerFunctionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e6785913-b61b-4319-bc30-775f3dd950d9"),
				Name = "ResultIntegerFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultFloatFunctionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8a5ac730-b847-4202-ac31-ce779d17d282"),
				Name = "ResultFloatFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultDateTimeFunctionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e88a80be-4cff-4e8c-b5e9-2414debbb746"),
				Name = "ResultDateTimeFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultRowsCountParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3a6dde9d-7abc-4a8e-a3c8-c8d3acccb242"),
				Name = "ResultRowsCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateReadSomeTopRecordsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("71bf9fc6-aaf3-41b2-a077-644b76541511"),
				Name = "ReadSomeTopRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateNumberOfRecordsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("738d7ba1-d063-4c12-9f8e-6e9cf285278b"),
				Name = "NumberOfRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultEntityParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4689d8e5-b05e-41aa-8b22-90d1fc78626b"),
				Name = "ResultEntity",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType"),
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
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3cb4b168-bccf-4303-b71d-c3abbb297465"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("726867c6-0462-4752-ab04-ea1c52567552"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cf2ff618-8cf1-4345-9f32-291b4a76b97c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("42fe18ff-9657-4d13-9922-350ab5ecc66e"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("32c87b7f-8a3e-448c-a591-c5de41de0e0f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("25e049f3-3cc2-40da-afdf-96b8178ec42b"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f8215a95-244f-454b-b31f-c689a99cb261")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("22e1dda3-4e0f-4f47-8552-115a6eee79fe"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f965b1fb-2fac-4acb-adc9-71a7a8c3cbab"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				ModifiedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f3650066-1a87-40fb-8ef3-58cfb5f8d688"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				ModifiedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("06d4f3a0-a390-4a82-a374-7329afcf22db"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1acb2d62-e1cc-4959-84b3-a5009f360618"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				ModifiedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
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
				UId = new Guid("c7e0204d-10b7-4849-86b4-e59fa2d092d4"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cd7ee051-3fcc-476d-8869-3228424e9f6d"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				ModifiedInSchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReadEntityCollectionItemsUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ReadEntityCollectionItemsUserTask(userConnection) {
				SchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ReadEntityCollectionItemsUserTask

	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultType", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultType.Caption", DescriptionResourceItem = "Parameters.ResultType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FunctionType", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.FunctionType.Caption", DescriptionResourceItem = "Parameters.FunctionType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "AggregationColumnName", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.AggregationColumnName.Caption", DescriptionResourceItem = "Parameters.AggregationColumnName.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OrderInfo", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.OrderInfo.Caption", DescriptionResourceItem = "Parameters.OrderInfo.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultEntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultEntityCollection.Caption", DescriptionResourceItem = "Parameters.ResultEntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultCount", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultCount.Caption", DescriptionResourceItem = "Parameters.ResultCount.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntityCollection", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.EntityCollection.Caption", DescriptionResourceItem = "Parameters.EntityCollection.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultIntegerFunction", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultIntegerFunction.Caption", DescriptionResourceItem = "Parameters.ResultIntegerFunction.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultFloatFunction", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultFloatFunction.Caption", DescriptionResourceItem = "Parameters.ResultFloatFunction.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultDateTimeFunction", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultDateTimeFunction.Caption", DescriptionResourceItem = "Parameters.ResultDateTimeFunction.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultRowsCount", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultRowsCount.Caption", DescriptionResourceItem = "Parameters.ResultRowsCount.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ReadSomeTopRecords", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ReadSomeTopRecords.Caption", DescriptionResourceItem = "Parameters.ReadSomeTopRecords.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NumberOfRecords", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.NumberOfRecords.Caption", DescriptionResourceItem = "Parameters.NumberOfRecords.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultEntity", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d83279bffb3f4b199cbe23c4742e0533", CaptionResourceItem = "Parameters.ResultEntity.Caption", DescriptionResourceItem = "Parameters.ResultEntity.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ReadEntityCollectionItemsUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ReadEntityCollectionItemsUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("d83279bf-fb3f-4b19-9cbe-23c4742e0533");
		}

		#endregion

		#region Properties: Public

		public virtual string DataSourceFilters {
			get;
			set;
		}

		public virtual int ResultType {
			get;
			set;
		}

		public virtual int FunctionType {
			get;
			set;
		}

		public virtual string AggregationColumnName {
			get;
			set;
		}

		public virtual string OrderInfo {
			get;
			set;
		}

		public virtual EntityCollection ResultEntityCollection {
			get;
			set;
		}

		public virtual int ResultCount {
			get;
			set;
		}

		public virtual EntityCollection EntityCollection {
			get;
			set;
		}

		public virtual int ResultIntegerFunction {
			get;
			set;
		}

		public virtual Decimal ResultFloatFunction {
			get;
			set;
		}

		public virtual DateTime ResultDateTimeFunction {
			get;
			set;
		}

		public virtual int ResultRowsCount {
			get;
			set;
		}

		public virtual bool ReadSomeTopRecords {
			get;
			set;
		}

		public virtual int NumberOfRecords {
			get;
			set;
		}

		private Entity _resultEntity;
		public virtual Entity ResultEntity {
			get {
				return _resultEntity ?? (_resultEntity = new Entity(UserConnection));
			}
			set {
				_resultEntity = value;
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			EntitySchema entitySchema = EntityCollection.Schema;
			if (entitySchema == null) {
				return true;
			}
			DataSourceFilterCollection filters = null;
			if (!string.IsNullOrEmpty(DataSourceFilters)) {
				filters = ProcessUserTaskUtilities.ConvertToProcessDataSourceFilterCollection(
					UserConnection, entitySchema, this, DataSourceFilters);
			}
			var orderByInfo = new Dictionary<string, OrderDirectionStrict>(8);
			if (OrderInfo != null &&
					(ProcessReadDataResultType)ResultType == ProcessReadDataResultType.Entity && OrderInfo.Length > 0) {
				string[] orders = OrderInfo.Split(',');
				orders = orders.OrderBy(item => {
					var items = item.Split(':');
					if (items.Length == 3) {
						return items[2];
					}
					return null;
				}).ToArray();
				string[,] orderInfoWithZeroPosition = new string[orders.Length, 2];
				int index = -1;
				for (int i = 0; i < orders.Length; i++) {
					string[] order = orders[i].Split(':');
					if (order.Length != 3) {
						continue;
					}
					EntitySchemaColumn column = entitySchema.Columns.FindByName(order[0]);
					if (column == null) {
						continue;
					}
					var orderDirection = (OrderDirection)Enum.Parse(typeof(OrderDirection), order[1]);
					if (orderDirection == OrderDirection.None) {
						continue;
					}
					OrderDirectionStrict orderDirectionStrict = orderDirection == OrderDirection.Descending ?
						OrderDirectionStrict.Descending : OrderDirectionStrict.Ascending;
					if (order[2].Trim() != "0") {
						orderByInfo.Add(order[0], orderDirectionStrict);
					} else {
						index++;
						orderInfoWithZeroPosition[index, 0] = order[0];
						orderInfoWithZeroPosition[index, 1] = order[1];
					}
				}
				while (index > -1) {
					var orderDirection = (OrderDirection)Enum.Parse(typeof(OrderDirection),
						orderInfoWithZeroPosition[index, 1]);
					OrderDirectionStrict orderDirectionStrict;
					if (orderDirection == OrderDirection.None || orderDirection == OrderDirection.Ascending) {
						orderDirectionStrict = OrderDirectionStrict.Ascending;
					} else {
						orderDirectionStrict = OrderDirectionStrict.Descending;
					}
					orderByInfo.Add(orderInfoWithZeroPosition[index, 0], orderDirectionStrict);
					index--;
				}
			}
			var linqConverter = new DataSourceFilterLinqConverter(UserConnection);
			switch ((ProcessReadDataResultType)ResultType) {
				case ProcessReadDataResultType.Entity:
					IQueryable<Entity> resultQuery = ReadSomeTopRecords ?
						linqConverter.BuildQuery(EntityCollection, filters, orderByInfo, NumberOfRecords)
						: resultQuery = linqConverter.BuildQuery(EntityCollection, filters, orderByInfo);
					var resultEntityCollection = new EntityCollection(UserConnection, EntityCollection.Schema);
					foreach (Entity entity in resultQuery) {
						resultEntityCollection.Add(entity);
					}
					ResultRowsCount = resultEntityCollection.Count;
					ResultEntityCollection = resultEntityCollection;
					if (resultEntityCollection.Count > 0) {
						ResultEntity = resultEntityCollection.First.Value;
					}
					break;
				case ProcessReadDataResultType.Function:
					var aggregationType = (AggregationTypeStrict)FunctionType;
					object result = linqConverter.ExecuteQuery(EntityCollection, filters, AggregationColumnName, aggregationType);
					ResultRowsCount = 1;
					switch (aggregationType) {
						case AggregationTypeStrict.Count:
							ResultCount = (int)result;
							break;
						case AggregationTypeStrict.Avg:
						case AggregationTypeStrict.Sum:
						case AggregationTypeStrict.Max:
						case AggregationTypeStrict.Min:
							Type columnValueType = EntityCollection.Schema.Columns.GetByName(AggregationColumnName).DataValueType.ValueType;
							if (columnValueType == typeof(DateTime)) {
								ResultDateTimeFunction = (DateTime)result;
							} else {
								ResultFloatFunction = Convert.ToDecimal(result);
							}
							break;
					}
					break;
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
			if (!HasMapping("ResultType")) {
				writer.WriteValue("ResultType", ResultType, 0);
			}
			if (!HasMapping("FunctionType")) {
				writer.WriteValue("FunctionType", FunctionType, 0);
			}
			if (!HasMapping("AggregationColumnName")) {
				writer.WriteValue("AggregationColumnName", AggregationColumnName, null);
			}
			if (!HasMapping("OrderInfo")) {
				writer.WriteValue("OrderInfo", OrderInfo, null);
			}
			if (!HasMapping("ResultCount")) {
				writer.WriteValue("ResultCount", ResultCount, 0);
			}
			if (!HasMapping("ResultIntegerFunction")) {
				writer.WriteValue("ResultIntegerFunction", ResultIntegerFunction, 0);
			}
			if (!HasMapping("ResultFloatFunction")) {
				writer.WriteValue("ResultFloatFunction", ResultFloatFunction, 0m);
			}
			if (!HasMapping("ResultDateTimeFunction")) {
				writer.WriteValue("ResultDateTimeFunction", ResultDateTimeFunction, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("ResultRowsCount")) {
				writer.WriteValue("ResultRowsCount", ResultRowsCount, 0);
			}
			if (!HasMapping("ReadSomeTopRecords")) {
				writer.WriteValue("ReadSomeTopRecords", ReadSomeTopRecords, false);
			}
			if (!HasMapping("NumberOfRecords")) {
				writer.WriteValue("NumberOfRecords", NumberOfRecords, 0);
			}
			if (ResultEntity != null && ResultEntity.Schema != null) {
				if (UseFlowEngineMode) {
					ResultEntity.Write(writer, "ResultEntity");
				} else {
					string serializedEntity = Entity.SerializeToJson(ResultEntity);
					writer.WriteValue("ResultEntity", serializedEntity, null);
				}
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
				case "ResultType":
					ResultType = reader.GetIntValue();
				break;
				case "FunctionType":
					FunctionType = reader.GetIntValue();
				break;
				case "AggregationColumnName":
					AggregationColumnName = reader.GetStringValue();
				break;
				case "OrderInfo":
					OrderInfo = reader.GetStringValue();
				break;
				case "ResultCount":
					ResultCount = reader.GetIntValue();
				break;
				case "ResultIntegerFunction":
					ResultIntegerFunction = reader.GetIntValue();
				break;
				case "ResultFloatFunction":
					ResultFloatFunction = reader.GetValue<System.Decimal>();
				break;
				case "ResultDateTimeFunction":
					ResultDateTimeFunction = reader.GetDateTimeValue();
				break;
				case "ResultRowsCount":
					ResultRowsCount = reader.GetIntValue();
				break;
				case "ReadSomeTopRecords":
					ReadSomeTopRecords = reader.GetBoolValue();
				break;
				case "NumberOfRecords":
					NumberOfRecords = reader.GetIntValue();
				break;
				case "ResultEntity":
					if (UseFlowEngineMode) {
						ResultEntity = reader.GetValue<Entity>();
					} else {
						ResultEntity = Entity.DeserializeFromJson(UserConnection, reader.GetValue<System.String>());
					}
				break;
			}
		}

		#endregion

	}

	#endregion

}

