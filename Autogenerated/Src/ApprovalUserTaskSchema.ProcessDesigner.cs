namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ApprovalUserTaskSchema

	/// <exclude/>
	public class ApprovalUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ApprovalUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ApprovalUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("51179e03-650d-4492-862d-9943005c26b4");
			RealUId = new Guid("51179e03-650d-4492-862d-9943005c26b4");
			Name = "ApprovalUserTask";
			CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = new Guid("575d8d4c-0b7c-48ca-8bb5-cb380e26294b");
			DcmParametersEditPageSchemaV2UId = new Guid("f54fb188-5d79-4395-b2d9-80283cbede52");
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,146,107,107,194,48,20,134,63,175,191,34,248,41,138,164,63,64,4,231,133,33,76,38,243,242,61,75,79,109,180,77,36,73,43,101,236,191,239,180,41,154,186,21,90,146,115,121,222,247,28,58,27,68,241,40,34,22,114,16,142,28,165,229,59,145,65,193,15,235,132,164,70,23,100,87,219,141,78,202,28,154,92,36,149,2,67,206,90,170,71,130,232,224,194,122,245,8,153,246,9,108,157,252,11,89,41,39,93,221,67,249,16,235,51,216,83,26,113,183,12,12,252,105,195,187,63,61,230,153,146,25,244,67,17,25,197,81,20,214,145,234,190,2,172,63,88,48,11,141,118,133,147,90,177,176,112,195,21,63,129,97,111,224,214,202,58,174,4,204,107,68,210,39,213,225,164,227,19,5,183,238,52,13,84,216,194,0,119,157,107,218,23,196,222,123,19,219,129,91,66,186,208,121,89,168,35,207,75,176,180,151,199,214,215,164,144,234,83,158,50,103,81,35,229,185,133,73,84,113,67,68,219,133,177,0,231,213,209,190,63,121,240,188,222,128,227,91,238,50,58,192,7,5,226,88,127,157,155,127,163,106,52,17,33,30,14,88,251,109,106,100,74,232,214,104,1,214,54,35,236,185,189,28,156,204,165,147,96,219,21,217,85,113,117,245,187,214,151,242,250,97,150,56,241,94,22,208,246,211,150,60,238,192,12,115,188,141,239,235,43,12,135,228,27,241,47,66,163,107,229,181,126,240,133,251,78,130,133,80,79,24,123,171,232,29,11,131,129,121,5,180,221,73,147,49,224,74,163,186,29,13,126,1,137,162,255,126,6,3,0,0 };
			SerializeToDB = true;
			IsUserTask = true;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreatePurposeParameter());
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateResultParameterParameter());
			Parameters.Add(CreateApproverTypeParameter());
			Parameters.Add(CreateEmployeeIdParameter());
			Parameters.Add(CreateRoleIdParameter());
			Parameters.Add(CreateIsAllowedToDelegateParameter());
			Parameters.Add(CreateApprovalSchemaUIdParameter());
			Parameters.Add(CreateCurrentApprovalIdParameter());
			Parameters.Add(CreateMasterColumnUIdParameter());
			Parameters.Add(CreateIsSendEmailToApproversParameter());
			Parameters.Add(CreateIsSendEmailToAuthorParameter());
			Parameters.Add(CreateApproverEmailTemplateParameter());
			Parameters.Add(CreateAuthorEmailTemplateParameter());
			Parameters.Add(CreateIgnoreEmailErrorsParameter());
			Parameters.Add(CreateIsRequiredDigitalSignatureParameter());
			Parameters.Add(CreateSectionIdParameter());
		}

		protected virtual ProcessSchemaParameter CreatePurposeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6c2dc734-4e20-4730-9d5d-ad395a9d1cee"),
				Name = "Purpose",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
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
				UId = new Guid("8504dab0-c752-42bb-a717-106c04fb4564"),
				Name = "EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
				UId = new Guid("4884bbe2-c746-4039-8ce0-886be810b6f2"),
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

		protected virtual ProcessSchemaParameter CreateResultParameterParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e8f2fad0-2415-48e7-8d8d-9fb757184b9b"),
				Name = "ResultParameter",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = true,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateApproverTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a87e8c83-f7fd-44a8-9f6f-6d35fcbde22b"),
				Name = "ApproverType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEmployeeIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1f5ec9bf-a784-4895-8e50-314432fc54f6"),
				Name = "EmployeeId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("9c16d882-1168-4064-8e37-145afb9369ea"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRoleIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("518a93b6-a3c3-47b0-ba27-3c93451198f6"),
				Name = "RoleId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("1f424900-3d1a-4ffe-badd-a76e62ed952b"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsAllowedToDelegateParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("07055d0f-f246-4ecc-84b0-33518c37dbc6"),
				Name = "IsAllowedToDelegate",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateApprovalSchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("11bb1436-16eb-4ee2-b1f3-3f306ea9861e"),
				Name = "ApprovalSchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentApprovalIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("eecc2584-b274-420e-8c37-3981d528606a"),
				Name = "CurrentApprovalId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMasterColumnUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cfaa27ea-5096-467e-8fe7-062614255205"),
				Name = "MasterColumnUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSendEmailToApproversParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("14e341cb-f5d9-49bd-9aa4-2c3b9fee7a64"),
				Name = "IsSendEmailToApprovers",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSendEmailToAuthorParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("87ed6d1c-5ef4-407b-9b01-5ce4e43d99c4"),
				Name = "IsSendEmailToAuthor",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateApproverEmailTemplateParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("674d6e46-e9df-486c-a9ed-c284ab67d35c"),
				Name = "ApproverEmailTemplate",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAuthorEmailTemplateParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("96974b08-0eeb-4c00-b465-1194194658c3"),
				Name = "AuthorEmailTemplate",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIgnoreEmailErrorsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1e2ccc81-f6aa-4602-a369-1e385c7d5ddd"),
				Name = "IgnoreEmailErrors",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsRequiredDigitalSignatureParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d6393389-c7ad-4b37-bef1-26210eef3a55"),
				Name = "IsRequiredDigitalSignature",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSectionIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("04e0b696-3117-4e10-90d4-c57f40d0297c"),
				Name = "SectionId",
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
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ad64f267-0555-4c38-a0c9-03d263c97f05"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("dce8bec2-6e2f-4ee6-9a95-98b71b1b3746")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d303dbe3-50e3-4c06-9b4d-6eaa983a0d8a"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1566927-8489-43bc-8365-ad289d5cfed0"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				ModifiedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2889174c-ef8e-4de5-af20-80ebb0ffb003"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				ModifiedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,77,106,195,48,16,133,215,214,41,6,175,100,48,186,128,235,64,19,59,193,155,46,26,72,215,170,53,52,162,178,76,245,147,52,148,220,189,178,165,214,13,165,5,129,196,60,189,111,52,51,58,113,3,6,173,87,14,106,208,120,134,70,246,78,142,154,155,203,221,206,75,81,130,117,70,234,151,21,45,42,178,71,133,189,3,27,183,120,63,198,168,183,104,54,163,214,56,187,11,146,177,205,168,252,160,105,126,144,150,239,29,119,222,230,37,228,157,200,255,22,31,248,128,179,188,53,227,112,35,78,193,167,35,26,252,197,179,91,169,185,202,11,214,217,246,205,115,69,35,58,100,208,214,81,103,60,22,5,112,155,222,89,17,111,67,53,64,155,117,251,142,189,119,163,1,241,252,125,172,225,182,14,214,106,235,13,54,235,37,68,3,238,131,100,9,211,53,220,241,71,228,2,3,103,57,214,169,71,44,146,49,134,233,146,41,66,178,243,81,42,4,186,56,217,180,165,20,89,54,13,0,94,241,18,120,63,174,236,208,197,26,15,92,121,156,167,180,162,115,99,171,201,20,231,5,167,73,252,215,248,53,216,212,246,217,28,191,2,187,23,130,134,188,101,164,204,210,149,132,117,37,6,157,55,58,125,153,234,19,24,63,37,99,62,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("eb30184a-7ae4-4ff8-b4d3-9353c6bd0a9f"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7e881892-d4cc-4ff1-a82c-3366fb790340"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				ModifiedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ad76035-8781-439b-84a1-07d07c700c77"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e133a2ba-b6a7-4e37-aaff-b5f0d8dcf9ca"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				ModifiedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("dba86575-ea01-4de6-911e-415c7ef2239d"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c275146d-c804-45f9-9924-917db1834451"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a39cf7e5-14a7-4eae-85ce-5cb937e9ef4a"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bd8fb2c7-7001-4613-a3f2-2277255d5217"),
				Name = "target",
				CreatedInSchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("124051ab-5f04-43b7-be54-10b03ec96fbb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ApprovalUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51179e03-650d-4492-862d-9943005c26b4"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ApprovalUserTask(userConnection) {
				SchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ApprovalUserTaskSchemaExtension

	/// <exclude/>
	public class ApprovalUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var result = new Dictionary<Guid, string>();
			Select select = new Select(userConnection)
				.Column("VisaStatus", "Id")
				.Column("VisaStatus", "Name")
				.From("VisaStatus")
				.Where("VisaStatus", "IsFinal").IsEqual(Column.Const(true)) as Select;
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						Guid key = dataReader.GetColumnValue<Guid>("Id");
						string value = dataReader.GetColumnValue<string>("Name");
						result.Add(key, value);
					}
				}
			}
			return result;
		}

		#endregion

	}

	#endregion

	#region Class: ApprovalUserTask

	[DesignModeProperty(Name = "Purpose", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.Purpose.Caption", DescriptionResourceItem = "Parameters.Purpose.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntitySchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.EntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultParameter", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.ResultParameter.Caption", DescriptionResourceItem = "Parameters.ResultParameter.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ApproverType", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.ApproverType.Caption", DescriptionResourceItem = "Parameters.ApproverType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EmployeeId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.EmployeeId.Caption", DescriptionResourceItem = "Parameters.EmployeeId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RoleId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.RoleId.Caption", DescriptionResourceItem = "Parameters.RoleId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsAllowedToDelegate", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.IsAllowedToDelegate.Caption", DescriptionResourceItem = "Parameters.IsAllowedToDelegate.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ApprovalSchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.ApprovalSchemaUId.Caption", DescriptionResourceItem = "Parameters.ApprovalSchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentApprovalId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.CurrentApprovalId.Caption", DescriptionResourceItem = "Parameters.CurrentApprovalId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MasterColumnUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.MasterColumnUId.Caption", DescriptionResourceItem = "Parameters.MasterColumnUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSendEmailToApprovers", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.IsSendEmailToApprovers.Caption", DescriptionResourceItem = "Parameters.IsSendEmailToApprovers.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSendEmailToAuthor", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.IsSendEmailToAuthor.Caption", DescriptionResourceItem = "Parameters.IsSendEmailToAuthor.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ApproverEmailTemplate", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.ApproverEmailTemplate.Caption", DescriptionResourceItem = "Parameters.ApproverEmailTemplate.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "AuthorEmailTemplate", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.AuthorEmailTemplate.Caption", DescriptionResourceItem = "Parameters.AuthorEmailTemplate.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IgnoreEmailErrors", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.IgnoreEmailErrors.Caption", DescriptionResourceItem = "Parameters.IgnoreEmailErrors.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsRequiredDigitalSignature", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.IsRequiredDigitalSignature.Caption", DescriptionResourceItem = "Parameters.IsRequiredDigitalSignature.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SectionId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "51179e03650d4492862d9943005c26b4", CaptionResourceItem = "Parameters.SectionId.Caption", DescriptionResourceItem = "Parameters.SectionId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class ApprovalUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ApprovalUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("51179e03-650d-4492-862d-9943005c26b4");
		}

		#endregion

		#region Properties: Public

		private LocalizableString _purpose;
		public virtual LocalizableString Purpose {
			get {
				return _purpose ?? (_purpose = new LocalizableString());
			}
			set {
				_purpose = value;
			}
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual Guid ResultParameter {
			get;
			set;
		}

		public virtual int ApproverType {
			get;
			set;
		}

		public virtual Guid EmployeeId {
			get;
			set;
		}

		public virtual Guid RoleId {
			get;
			set;
		}

		public virtual bool IsAllowedToDelegate {
			get;
			set;
		}

		public virtual Guid ApprovalSchemaUId {
			get;
			set;
		}

		public virtual Guid CurrentApprovalId {
			get;
			set;
		}

		public virtual Guid MasterColumnUId {
			get;
			set;
		}

		public virtual bool IsSendEmailToApprovers {
			get;
			set;
		}

		public virtual bool IsSendEmailToAuthor {
			get;
			set;
		}

		public virtual Guid ApproverEmailTemplate {
			get;
			set;
		}

		public virtual Guid AuthorEmailTemplate {
			get;
			set;
		}

		private bool _ignoreEmailErrors = true;
		public virtual bool IgnoreEmailErrors {
			get {
				return _ignoreEmailErrors;
			}
			set {
				_ignoreEmailErrors = value;
			}
		}

		public virtual bool IsRequiredDigitalSignature {
			get;
			set;
		}

		public virtual Guid SectionId {
			get;
			set;
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
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("ResultParameter")) {
				writer.WriteValue("ResultParameter", ResultParameter, Guid.Empty);
			}
			if (!HasMapping("ApproverType")) {
				writer.WriteValue("ApproverType", ApproverType, 0);
			}
			if (!HasMapping("EmployeeId")) {
				writer.WriteValue("EmployeeId", EmployeeId, Guid.Empty);
			}
			if (!HasMapping("RoleId")) {
				writer.WriteValue("RoleId", RoleId, Guid.Empty);
			}
			if (!HasMapping("IsAllowedToDelegate")) {
				writer.WriteValue("IsAllowedToDelegate", IsAllowedToDelegate, false);
			}
			if (!HasMapping("ApprovalSchemaUId")) {
				writer.WriteValue("ApprovalSchemaUId", ApprovalSchemaUId, Guid.Empty);
			}
			if (!HasMapping("CurrentApprovalId")) {
				writer.WriteValue("CurrentApprovalId", CurrentApprovalId, Guid.Empty);
			}
			if (!HasMapping("MasterColumnUId")) {
				writer.WriteValue("MasterColumnUId", MasterColumnUId, Guid.Empty);
			}
			if (!HasMapping("IsSendEmailToApprovers")) {
				writer.WriteValue("IsSendEmailToApprovers", IsSendEmailToApprovers, false);
			}
			if (!HasMapping("IsSendEmailToAuthor")) {
				writer.WriteValue("IsSendEmailToAuthor", IsSendEmailToAuthor, false);
			}
			if (!HasMapping("ApproverEmailTemplate")) {
				writer.WriteValue("ApproverEmailTemplate", ApproverEmailTemplate, Guid.Empty);
			}
			if (!HasMapping("AuthorEmailTemplate")) {
				writer.WriteValue("AuthorEmailTemplate", AuthorEmailTemplate, Guid.Empty);
			}
			if (!HasMapping("IgnoreEmailErrors")) {
				writer.WriteValue("IgnoreEmailErrors", IgnoreEmailErrors, false);
			}
			if (!HasMapping("IsRequiredDigitalSignature")) {
				writer.WriteValue("IsRequiredDigitalSignature", IsRequiredDigitalSignature, false);
			}
			if (!HasMapping("SectionId")) {
				writer.WriteValue("SectionId", SectionId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Purpose":
					Purpose = reader.GetLocalizableStringValue();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetGuidValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "ResultParameter":
					ResultParameter = reader.GetGuidValue();
				break;
				case "ApproverType":
					ApproverType = reader.GetIntValue();
				break;
				case "EmployeeId":
					EmployeeId = reader.GetGuidValue();
				break;
				case "RoleId":
					RoleId = reader.GetGuidValue();
				break;
				case "IsAllowedToDelegate":
					IsAllowedToDelegate = reader.GetBoolValue();
				break;
				case "ApprovalSchemaUId":
					ApprovalSchemaUId = reader.GetGuidValue();
				break;
				case "CurrentApprovalId":
					CurrentApprovalId = reader.GetGuidValue();
				break;
				case "MasterColumnUId":
					MasterColumnUId = reader.GetGuidValue();
				break;
				case "IsSendEmailToApprovers":
					IsSendEmailToApprovers = reader.GetBoolValue();
				break;
				case "IsSendEmailToAuthor":
					IsSendEmailToAuthor = reader.GetBoolValue();
				break;
				case "ApproverEmailTemplate":
					ApproverEmailTemplate = reader.GetGuidValue();
				break;
				case "AuthorEmailTemplate":
					AuthorEmailTemplate = reader.GetGuidValue();
				break;
				case "IgnoreEmailErrors":
					IgnoreEmailErrors = reader.GetBoolValue();
				break;
				case "IsRequiredDigitalSignature":
					IsRequiredDigitalSignature = reader.GetBoolValue();
				break;
				case "SectionId":
					SectionId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

