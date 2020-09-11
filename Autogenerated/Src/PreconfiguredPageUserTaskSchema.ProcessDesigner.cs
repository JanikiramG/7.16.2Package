namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Runtime.Serialization.Formatters;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: PreconfiguredPageUserTaskSchema

	/// <exclude/>
	public class PreconfiguredPageUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public PreconfiguredPageUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public PreconfiguredPageUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48");
			RealUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48");
			Name = "PreconfiguredPageUserTask";
			CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("3a010dca-6314-4fd3-b54d-86f130ba97c8");
			ParametersEditPageSchemaV2UId = new Guid("2352c272-080e-4cc9-828c-f6689a45e95a");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,207,10,194,48,12,135,207,238,41,138,167,13,134,47,48,4,69,118,232,109,168,195,115,233,178,45,232,82,105,82,116,136,239,110,7,254,67,240,150,252,190,36,31,89,205,177,85,105,73,226,199,202,33,137,110,22,154,203,225,44,99,154,101,234,150,204,190,145,90,170,202,59,11,204,53,131,223,27,62,214,130,39,20,4,94,172,155,230,201,62,27,233,52,182,113,68,96,5,29,229,42,34,148,113,103,123,24,76,173,155,87,48,85,177,205,138,228,158,252,21,104,18,240,198,202,1,165,159,104,42,61,114,174,172,139,249,85,226,129,31,151,230,109,32,66,234,114,181,235,221,165,188,130,13,19,169,76,7,209,244,198,241,41,241,1,138,196,131,4,79,170,53,39,134,98,254,0,70,238,153,90,25,1,0,0 };
			SerializeToDB = true;
			IsUserTask = true;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateTitleParameter());
			Parameters.Add(CreateRecommendationParameter());
			Parameters.Add(CreateClientUnitSchemaUIdParameter());
			Parameters.Add(CreateEntityIdParameter());
			Parameters.Add(CreateEntryPointIdParameter());
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateUseCardProcessModuleParameter());
			Parameters.Add(CreateOwnerIdParameter());
			Parameters.Add(CreateShowExecutionPageParameter());
			Parameters.Add(CreateInformationOnStepParameter());
			Parameters.Add(CreateIsRunningParameter());
			Parameters.Add(CreateTemplateParameter());
			Parameters.Add(CreateModuleParameter());
			Parameters.Add(CreatePressedButtonCodeParameter());
			Parameters.Add(CreateUrlParameter());
		}

		protected virtual ProcessSchemaParameter CreateTitleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d2729057-12b6-4edd-8556-2f495c589534"),
				Name = "Title",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecommendationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b52611bd-6983-4060-86f7-2873a0f41d81"),
				Name = "Recommendation",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateClientUnitSchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ecadbaba-3f52-4d98-b713-f6d983b5a65f"),
				Name = "ClientUnitSchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b5ae3982-d220-423c-9d73-5bcb919352af"),
				Name = "EntityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntryPointIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("322dab8e-6a42-4e23-8037-79e0b521e70a"),
				Name = "EntryPointId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d90c3077-d7e3-4219-b89e-f187a0bcdf1a"),
				Name = "EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateUseCardProcessModuleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("883cd593-009e-40bf-9469-1e719103e861"),
				Name = "UseCardProcessModule",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOwnerIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("db05a62e-5413-4738-acff-3dfe3c1aa871"),
				Name = "OwnerId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsResult = false,
				IsPerformer = true,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateShowExecutionPageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("baf1468d-4c68-446a-be28-5868cfb9a04b"),
				Name = "ShowExecutionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInformationOnStepParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8c3110b2-35c7-4203-8a4d-56adb6527c29"),
				Name = "InformationOnStep",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsRunningParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0ca91c6f-659b-4913-88ad-672449dc1b06"),
				Name = "IsRunning",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateTemplateParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0d0462d2-49cf-4c24-ad1c-71c67327c0e5"),
				Name = "Template",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.21620f25-166f-42f1-8b4d-224a959040a3#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				},
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("dd32ea3f-c0c6-44e5-8e85-b21a97dc82e9"),
				Name = "Module",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.eb89c336-08b9-4951-bffd-3f5abc433174#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				},
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePressedButtonCodeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0808fb80-7df5-4393-a857-d2034d2c3f36"),
				Name = "PressedButtonCode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = true,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateUrlParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1f98cc3d-1c4a-428c-b00d-1e42b772f00e"),
				Name = "Url",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				},
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
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateGetNotificationDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5f1dd810-69d3-4227-b4fb-b94daf6a2e8f"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d99a2dd4-ea93-486a-8178-cb31c946148b"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "",
				CreatedInPackageId = new Guid("726732c0-931c-4e11-9479-6aff326ae941")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c6161e1e-6de2-4ac5-b7c0-949aa9ae9c3c"),
				Name = "Terrasoft.Nui.ServiceModel.Extensions",
				Alias = "",
				CreatedInPackageId = new Guid("726732c0-931c-4e11-9479-6aff326ae941")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e62a9c65-7777-4e48-a80d-4246812e29f1"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("726732c0-931c-4e11-9479-6aff326ae941")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1403508-bcbf-4fb5-b4e3-f777ac6f61f4"),
				Name = "System.Runtime.Serialization.Formatters",
				Alias = "",
				CreatedInPackageId = new Guid("0face2ca-1563-453f-9ade-4b0125a92797")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("99534887-9cad-477c-b0a1-edeae935162c"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2ea6d938-e895-445a-863c-2906e23b8589"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bf157c2b-aff1-427c-bd3a-28af7e32a54a"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,79,107,194,48,20,63,119,159,226,145,83,11,146,47,224,220,65,5,25,136,8,221,118,17,15,89,250,58,195,210,68,242,18,135,27,251,238,107,210,86,59,15,94,66,242,94,126,255,242,114,18,14,164,53,149,242,202,154,55,161,3,18,204,192,224,23,44,149,140,53,225,206,143,171,160,170,9,144,119,202,124,60,229,197,244,33,203,178,173,179,18,137,74,121,192,70,108,133,19,13,122,116,137,1,200,6,39,177,219,207,128,210,149,87,66,247,34,232,147,95,238,18,95,161,159,159,55,237,41,103,243,224,189,53,196,10,94,94,193,73,104,109,165,208,234,91,188,107,252,47,67,107,69,30,148,199,38,90,30,105,242,17,100,97,181,70,121,9,151,24,85,13,121,15,107,163,6,173,11,248,137,245,108,224,138,241,239,203,246,143,240,11,168,9,199,104,94,162,15,199,37,214,34,104,63,226,232,160,57,91,136,99,52,195,38,192,54,22,100,127,234,217,226,82,91,135,66,30,32,63,181,147,137,148,160,76,23,114,112,121,51,174,93,116,27,39,148,50,237,216,115,197,246,60,181,138,125,155,165,43,14,178,125,231,42,231,90,187,206,220,126,129,233,31,250,142,51,21,23,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("57008551-fc79-4a7c-a706-a9fda8ab1113"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d9224666-17e9-43c9-92ee-c84e5932ecd7"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,202,49,14,130,64,16,133,225,222,83,80,66,98,184,0,37,82,208,109,162,28,96,92,94,116,34,59,75,102,6,34,183,23,181,160,124,255,251,130,230,8,179,193,160,55,178,215,224,60,177,51,172,190,128,162,243,74,142,240,39,157,184,110,33,179,120,249,213,109,22,193,46,178,156,139,227,234,199,223,98,223,174,241,137,68,195,17,250,177,106,78,10,95,84,138,59,25,234,54,167,121,130,163,123,35,46,206,242,40,103,82,74,123,81,171,154,15,112,184,200,26,153,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a477470a-46aa-4a36-81f7-14165d402ad6"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("36b14633-79db-4962-96e6-8b9c952ce952"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,202,59,14,194,64,12,132,225,158,83,80,38,18,202,5,82,134,20,233,86,130,61,128,113,70,96,145,120,145,237,32,114,123,94,69,202,249,231,75,86,24,238,217,97,103,242,123,14,153,36,4,222,28,65,28,242,164,64,250,147,94,195,214,84,68,163,250,234,174,168,226,35,138,30,246,219,53,140,191,37,177,158,248,134,153,242,22,134,177,110,119,23,114,52,29,41,99,234,95,224,37,68,175,213,131,140,102,4,204,235,246,13,159,3,96,26,144,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a47104ae-f3fa-4279-90d4-59019ec561f1"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				CreatedInPackageId = new Guid("2eb2739e-09fc-468f-bc49-96baa1a33d59"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,75,115,219,54,16,62,75,191,130,214,137,156,42,204,76,143,86,156,140,45,171,45,91,191,166,148,114,200,13,34,86,50,26,16,228,0,160,18,166,227,255,222,197,131,20,65,51,83,223,200,125,125,187,223,62,200,19,145,81,193,25,8,189,19,76,231,197,51,148,228,158,8,114,4,25,93,69,59,5,114,93,9,1,133,102,149,72,215,211,134,171,121,22,188,103,26,202,15,91,144,146,168,234,160,211,117,37,225,149,235,199,1,42,2,253,36,133,244,119,208,38,218,77,187,203,104,60,142,129,178,100,53,63,97,5,13,230,185,37,234,43,70,138,159,100,85,128,82,222,196,43,146,56,148,39,143,223,4,134,247,47,6,230,134,40,216,112,40,17,193,161,57,157,23,57,40,165,37,19,199,168,145,124,91,125,5,129,104,11,31,117,77,36,189,175,104,195,225,243,175,239,23,209,47,131,130,210,7,82,2,74,22,239,9,165,11,151,111,141,197,61,17,137,10,13,82,97,28,1,223,162,91,102,89,38,178,253,224,128,150,81,181,255,7,169,255,24,35,182,7,234,189,62,19,222,0,10,79,140,98,171,78,193,27,198,107,56,95,205,15,200,60,41,158,71,156,244,33,48,141,238,137,137,158,195,244,156,88,18,253,59,159,177,67,20,247,134,233,26,35,106,160,153,232,91,16,93,92,69,67,54,83,195,149,113,156,21,149,208,76,52,176,154,207,94,230,51,83,55,69,223,45,43,225,150,104,98,11,216,182,53,96,186,231,248,161,134,168,232,118,202,5,35,58,106,162,90,86,53,72,221,90,21,70,194,78,134,20,157,115,71,18,109,49,211,73,92,56,210,92,230,182,230,48,242,80,61,11,251,151,94,83,58,160,200,244,123,25,185,22,166,155,178,214,173,65,14,232,48,124,4,132,152,193,237,42,77,2,228,149,79,231,108,121,213,115,146,222,51,97,141,222,158,150,45,98,50,157,33,72,250,23,19,116,136,100,222,211,187,170,32,61,3,35,222,251,148,242,26,10,118,104,141,67,31,110,25,198,217,9,101,141,24,208,164,67,127,75,234,184,35,22,155,142,166,39,102,66,39,211,109,77,183,213,70,52,101,156,36,75,227,121,26,101,27,218,230,32,25,225,236,7,132,189,95,78,143,173,229,200,70,157,25,221,151,74,64,38,14,85,186,211,69,98,138,50,165,189,68,192,21,216,172,223,80,224,228,196,69,159,130,81,138,46,67,51,139,50,127,233,78,19,124,135,162,49,87,196,164,138,133,254,169,42,129,7,252,132,246,231,242,30,237,234,196,29,159,24,175,216,112,179,201,120,240,51,91,146,32,118,36,109,90,222,2,207,135,181,240,167,164,59,172,59,205,56,211,12,84,234,54,15,143,222,83,103,29,219,179,96,153,103,202,75,55,54,65,160,55,109,206,142,130,240,255,137,152,253,204,111,16,219,103,247,224,114,118,167,168,203,252,25,136,59,136,91,166,57,164,174,159,40,151,80,84,37,30,118,236,44,146,133,250,191,3,193,217,144,97,75,101,105,133,143,34,215,80,163,173,221,3,246,131,236,57,228,174,53,153,122,192,86,61,74,219,162,56,27,251,36,216,68,219,203,203,232,149,238,12,101,38,100,77,106,159,208,224,3,226,133,56,203,14,46,182,101,11,248,110,169,238,90,183,8,4,54,234,194,216,13,190,86,221,99,199,128,164,214,115,131,135,64,183,174,243,96,159,207,199,189,211,246,146,177,145,167,125,51,246,195,83,220,48,234,134,214,44,73,56,198,70,114,57,254,189,24,198,152,252,1,24,129,36,125,155,235,225,183,52,220,52,55,33,88,172,56,176,99,35,129,62,161,26,173,180,108,0,87,7,213,191,217,134,104,147,219,3,46,49,74,204,102,152,205,233,55,70,230,96,13,148,93,24,179,253,6,249,15,34,40,55,91,135,227,53,18,117,145,122,219,107,165,160,220,243,214,129,161,135,71,5,217,105,114,221,226,132,230,172,172,185,245,52,19,101,187,56,128,121,37,75,51,81,240,134,154,74,240,18,152,19,238,247,229,142,136,240,155,214,253,187,56,202,53,206,138,63,17,3,7,195,246,46,52,136,187,175,230,133,154,26,245,81,184,196,125,29,204,151,77,237,253,111,141,155,217,155,134,113,220,196,56,56,80,246,250,171,125,122,7,226,168,159,223,189,243,175,215,117,141,139,24,47,150,139,36,148,140,209,70,246,47,206,126,124,3,209,226,188,57,254,92,74,208,141,20,225,185,92,253,7,17,5,215,47,12,11,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d129b3db-2612-4976-a8ae-f3cd49730049"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "ProcessElementNotification",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,118,205,73,205,77,205,43,241,203,47,201,76,203,76,78,44,201,204,207,83,200,67,230,216,42,36,37,22,167,234,185,167,162,168,113,73,44,73,212,208,180,230,202,76,83,208,8,74,77,206,207,5,26,146,2,209,160,104,171,144,87,154,147,163,160,166,166,128,42,163,231,145,88,28,150,152,83,154,170,169,80,205,197,137,108,137,94,72,102,73,78,42,208,42,84,13,214,92,181,92,69,169,37,165,69,168,78,178,6,0,8,28,93,54,187,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PreconfiguredPageUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new PreconfiguredPageUserTask(userConnection) {
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
		}

		#endregion

	}

	#endregion

	#region Class: PreconfiguredPageUserTaskSchemaExtension

	/// <exclude/>
	public class PreconfiguredPageUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var conditionValues = new Dictionary<Guid, string>();
						ProcessSchemaParameterValue sourceValue = schemaUserTask.Parameters.GetByName("Buttons").SourceValue;
						LocalizableParameterValuesList items = sourceValue.LocalizableCollectionValue;
						if (items == null) {
							items = new LocalizableParameterValuesList();
						} else {
							items.SetupDefaultLocalizableValues("Caption", "No caption");
						}
						foreach (var item in items) {
							conditionValues[new Guid(item["Id"].Value)] = item["Caption"].Value;
						}
						return conditionValues;
		}

		#endregion

	}

	#endregion

	#region Class: PreconfiguredPageUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.Recommendation.Group", DescriptionResourceItem = "Parameters.Recommendation.Group")]
	[DesignModeProperty(Name = "Title", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.Title.Caption", DescriptionResourceItem = "Parameters.Title.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ClientUnitSchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.ClientUnitSchemaUId.Caption", DescriptionResourceItem = "Parameters.ClientUnitSchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntityId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.EntityId.Caption", DescriptionResourceItem = "Parameters.EntityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntryPointId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.EntryPointId.Caption", DescriptionResourceItem = "Parameters.EntryPointId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntitySchemaUId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.EntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "UseCardProcessModule", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.UseCardProcessModule.Caption", DescriptionResourceItem = "Parameters.UseCardProcessModule.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsRunning", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.IsRunning.Caption", DescriptionResourceItem = "Parameters.IsRunning.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Template", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.Template.Caption", DescriptionResourceItem = "Parameters.Template.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Module", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.Module.Caption", DescriptionResourceItem = "Parameters.Module.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PressedButtonCode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.PressedButtonCode.Caption", DescriptionResourceItem = "Parameters.PressedButtonCode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Url", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "ac2ef13c30dd40239c0458f580743b48", CaptionResourceItem = "Parameters.Url.Caption", DescriptionResourceItem = "Parameters.Url.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class PreconfiguredPageUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public PreconfiguredPageUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48");
			_template = () => { return new Guid("21620f25-166f-42f1-8b4d-224a959040a3"); };
			_module = () => { return new Guid("eb89c336-08b9-4951-bffd-3f5abc433174"); };
			_url = () => { return "[Module]/[Page]/add"; };
		}

		#endregion

		#region Properties: Public

		private LocalizableString _title;
		public virtual LocalizableString Title {
			get {
				return _title ?? (_title = new LocalizableString());
			}
			set {
				_title = value;
			}
		}

		private LocalizableString _recommendation;
		public virtual LocalizableString Recommendation {
			get {
				return _recommendation ?? (_recommendation = new LocalizableString());
			}
			set {
				_recommendation = value;
			}
		}

		public virtual Guid ClientUnitSchemaUId {
			get;
			set;
		}

		public virtual Guid EntityId {
			get;
			set;
		}

		public virtual Guid EntryPointId {
			get;
			set;
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		private bool _useCardProcessModule = false;
		public virtual bool UseCardProcessModule {
			get {
				return _useCardProcessModule;
			}
			set {
				_useCardProcessModule = value;
			}
		}

		public virtual Guid OwnerId {
			get;
			set;
		}

		private bool _showExecutionPage = true;
		public virtual bool ShowExecutionPage {
			get {
				return _showExecutionPage;
			}
			set {
				_showExecutionPage = value;
			}
		}

		private LocalizableString _informationOnStep;
		public virtual LocalizableString InformationOnStep {
			get {
				return _informationOnStep ?? (_informationOnStep = new LocalizableString());
			}
			set {
				_informationOnStep = value;
			}
		}

		public virtual bool IsRunning {
			get;
			set;
		}

		private Func<Guid> _template;
		public virtual Guid Template {
			get {
				return (_template ?? (_template = () => Guid.Empty)).Invoke();
			}
			set {
				_template = () => { return value; };
			}
		}

		private Func<Guid> _module;
		public virtual Guid Module {
			get {
				return (_module ?? (_module = () => Guid.Empty)).Invoke();
			}
			set {
				_module = () => { return value; };
			}
		}

		public virtual string PressedButtonCode {
			get;
			set;
		}

		private Func<string> _url;
		public virtual string Url {
			get {
				return (_url ?? (_url = () => null)).Invoke();
			}
			set {
				_url = () => { return value; };
			}
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ClientUnitSchemaUId")) {
				writer.WriteValue("ClientUnitSchemaUId", ClientUnitSchemaUId, Guid.Empty);
			}
			if (!HasMapping("EntityId")) {
				writer.WriteValue("EntityId", EntityId, Guid.Empty);
			}
			if (!HasMapping("EntryPointId")) {
				writer.WriteValue("EntryPointId", EntryPointId, Guid.Empty);
			}
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("UseCardProcessModule")) {
				writer.WriteValue("UseCardProcessModule", UseCardProcessModule, false);
			}
			if (!HasMapping("OwnerId")) {
				writer.WriteValue("OwnerId", OwnerId, Guid.Empty);
			}
			if (!HasMapping("ShowExecutionPage")) {
				writer.WriteValue("ShowExecutionPage", ShowExecutionPage, false);
			}
			if (!HasMapping("IsRunning")) {
				writer.WriteValue("IsRunning", IsRunning, false);
			}
			if (!HasMapping("Template")) {
				writer.WriteValue("Template", Template, Guid.Empty);
			}
			if (!HasMapping("Module")) {
				writer.WriteValue("Module", Module, Guid.Empty);
			}
			if (!HasMapping("PressedButtonCode")) {
				writer.WriteValue("PressedButtonCode", PressedButtonCode, null);
			}
			if (!HasMapping("Url")) {
				writer.WriteValue("Url", Url, null);
			}
			writer.WriteFinishObject();
		}

		public override bool TryGetPerformer(out Guid performerUId) {
			performerUId = OwnerId;
			return true;
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Title":
					Title = reader.GetLocalizableStringValue();
				break;
				case "Recommendation":
					Recommendation = reader.GetLocalizableStringValue();
				break;
				case "ClientUnitSchemaUId":
					ClientUnitSchemaUId = reader.GetGuidValue();
				break;
				case "EntityId":
					EntityId = reader.GetGuidValue();
				break;
				case "EntryPointId":
					EntryPointId = reader.GetGuidValue();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetGuidValue();
				break;
				case "UseCardProcessModule":
					UseCardProcessModule = reader.GetBoolValue();
				break;
				case "OwnerId":
					OwnerId = reader.GetGuidValue();
				break;
				case "ShowExecutionPage":
					ShowExecutionPage = reader.GetBoolValue();
				break;
				case "InformationOnStep":
					InformationOnStep = reader.GetLocalizableStringValue();
				break;
				case "IsRunning":
					IsRunning = reader.GetBoolValue();
				break;
				case "Template":
					Template = reader.GetGuidValue();
				break;
				case "Module":
					Module = reader.GetGuidValue();
				break;
				case "PressedButtonCode":
					PressedButtonCode = reader.GetStringValue();
				break;
				case "Url":
					Url = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

