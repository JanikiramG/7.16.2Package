namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using RecordEditMode = Terrasoft.Configuration.RecordEditMode;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Globalization;
	using System.Runtime.Serialization.Formatters;
	using System.Text;
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
	using UserTaskExecutedMode = Terrasoft.Configuration.UserTaskExecutedMode;

	#region Class: UserQuestionUserTaskSchema

	/// <exclude/>
	public class UserQuestionUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public UserQuestionUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public UserQuestionUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603");
			RealUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603");
			Name = "UserQuestionUserTask";
			CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("17736af0-dba3-4c76-b544-20278e3358c5");
			ParametersEditPageSchemaV2UId = new Guid("f0405edc-6d61-4d72-9880-c3e2dd6d4b29");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,65,107,194,64,16,133,207,230,87,140,30,36,1,201,31,16,161,34,34,185,20,105,148,158,183,201,36,25,26,119,101,118,214,42,37,255,189,187,73,35,69,40,20,122,91,222,188,247,134,111,246,105,70,21,196,185,40,113,22,86,43,216,179,41,208,218,65,72,183,204,134,19,248,140,38,193,181,113,204,168,101,93,8,93,72,110,89,25,2,59,71,101,186,61,157,229,6,243,57,76,191,243,71,139,124,80,246,253,40,212,146,16,218,116,135,146,217,49,186,97,84,130,101,28,108,27,163,53,122,221,232,5,28,179,50,233,215,77,14,200,172,172,169,36,245,243,138,106,199,42,88,210,177,1,212,248,88,193,208,54,78,226,100,233,243,235,74,144,71,41,87,23,204,11,166,179,108,175,88,56,193,120,76,7,111,23,117,209,155,49,45,144,125,113,90,147,174,67,231,35,107,154,217,103,35,61,104,156,244,168,63,112,204,233,220,162,7,90,70,225,78,211,123,81,207,242,79,148,191,147,116,209,175,215,207,180,47,241,214,87,146,38,76,99,105,200,46,160,48,94,191,138,63,252,195,71,220,9,22,144,55,230,99,88,230,39,123,85,163,223,196,40,142,53,84,170,181,184,156,125,1,3,227,40,104,68,2,0,0 };
			SerializeToDB = true;
			IsUserTask = true;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateBranchingDecisionsParameter());
			Parameters.Add(CreateResultDecisionsParameter());
			Parameters.Add(CreateDecisionModeParameter());
			Parameters.Add(CreateIsDecisionRequiredParameter());
			Parameters.Add(CreateQuestionParameter());
			Parameters.Add(CreateWindowCaptionParameter());
			Parameters.Add(CreateRecommendationParameter());
			Parameters.Add(CreateActivityCategoryParameter());
			Parameters.Add(CreateOwnerIdParameter());
			Parameters.Add(CreateDurationParameter());
			Parameters.Add(CreateDurationPeriodParameter());
			Parameters.Add(CreateStartInParameter());
			Parameters.Add(CreateStartInPeriodParameter());
			Parameters.Add(CreateRemindBeforeParameter());
			Parameters.Add(CreateRemindBeforePeriodParameter());
			Parameters.Add(CreateShowInSchedulerParameter());
			Parameters.Add(CreateShowExecutionPageParameter());
			Parameters.Add(CreateLeadParameter());
			Parameters.Add(CreateAccountParameter());
			Parameters.Add(CreateContactParameter());
			Parameters.Add(CreateOpportunityParameter());
			Parameters.Add(CreateInvoiceParameter());
			Parameters.Add(CreateDocumentParameter());
			Parameters.Add(CreateIncidentParameter());
			Parameters.Add(CreateCaseParameter());
			Parameters.Add(CreateActivityResultParameter());
			Parameters.Add(CreateCurrentActivityIdParameter());
			Parameters.Add(CreateIsActivityCompletedParameter());
			Parameters.Add(CreateExecutionContextParameter());
			Parameters.Add(CreateInformationOnStepParameter());
			Parameters.Add(CreateOrderParameter());
			Parameters.Add(CreateRequestsParameter());
			Parameters.Add(CreateListingParameter());
			Parameters.Add(CreatePropertyParameter());
			Parameters.Add(CreateContractParameter());
			Parameters.Add(CreateProjectParameter());
			Parameters.Add(CreateProblemParameter());
			Parameters.Add(CreateChangeParameter());
			Parameters.Add(CreateReleaseParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoCaptionLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoCaptionLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("78466bea-26bb-4dea-aa9f-2a48c3d14efc"),
				Name = "NoCaptionLocalizableString",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreateBranchingDecisionsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a7fe00c9-60ac-40f6-83d0-6fc87cfa235a"),
				Name = "BranchingDecisions",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableParameterValuesListDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultDecisionsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("65bb805a-39a3-41ed-a090-172d6bfc4aaa"),
				Name = "ResultDecisions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = true,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDecisionModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("42acf581-41a8-4216-a5a3-4456051999dd"),
				Name = "DecisionMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsDecisionRequiredParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1cd31021-c5d3-4a69-a147-a0fa2c94bfa4"),
				Name = "IsDecisionRequired",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateQuestionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("42c3caf7-5813-45fe-a658-69ad350484e5"),
				Name = "Question",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateWindowCaptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4c7f82ce-bcd4-45f8-9605-29a99d1c54c1"),
				Name = "WindowCaption",
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
				UId = new Guid("f91b852b-fcbf-4a8a-98aa-04de8b6e9579"),
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

		protected virtual ProcessSchemaParameter CreateActivityCategoryParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6dd2b519-520b-49e3-8e70-0870db852cb2"),
				Name = "ActivityCategory",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				},
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOwnerIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("32169238-b71a-420d-8127-c08ff94951ef"),
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

		protected virtual ProcessSchemaParameter CreateDurationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("eda36e75-f706-44bb-af93-eac82a6eaadf"),
				Name = "Duration",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"5",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDurationPeriodParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e9ba348e-8343-4208-b75b-8e88bf95699f"),
				Name = "DurationPeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStartInParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9a3dc23a-5208-404e-b142-62f95b1883ee"),
				Name = "StartIn",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateStartInPeriodParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e16b72d5-b9c3-40ae-8643-c967e360553f"),
				Name = "StartInPeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRemindBeforeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("87141981-5c1c-4f1f-b6aa-caa84ceb1dae"),
				Name = "RemindBefore",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRemindBeforePeriodParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4da1f181-7242-48bc-9ce6-5b9647b766c9"),
				Name = "RemindBeforePeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateShowInSchedulerParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5f348eeb-6151-44d1-b4ac-0af0c3674179"),
				Name = "ShowInScheduler",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateShowExecutionPageParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("eb1cfd00-9e56-4de9-9112-8d1adbbca8d9"),
				Name = "ShowExecutionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b1777a9e-9e59-4a4f-bca5-5f36acaafca0"),
				Name = "Lead",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("049a01bc-ae13-4e74-acf4-28603c2cc7f7"),
				Name = "Account",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateContactParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ab8c496c-876b-4b70-bda2-c119989d0cce"),
				Name = "Contact",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOpportunityParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e746a82f-c271-4122-8d94-d0dd7df54fee"),
				Name = "Opportunity",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInvoiceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("91be76ac-a66e-4ae4-ae1a-cf103ae7427b"),
				Name = "Invoice",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDocumentParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("540c71b7-06d5-4dda-8a94-2697d9d9208b"),
				Name = "Document",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIncidentParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9dafd57e-8f4d-4767-a1db-70ab01e85cf8"),
				Name = "Incident",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Incident",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("98fb964d-12fd-4f01-95a8-b39281e855f6"),
				Name = "Case",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Case",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateActivityResultParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2cb54bfb-0075-49f9-99b4-4310f47fe21b"),
				Name = "ActivityResult",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentActivityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5ffe50e9-22a2-4cea-8d3d-7d5fa70a7278"),
				Name = "CurrentActivityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsActivityCompletedParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f658039f-cd5d-4184-a5b3-5e92e1455b34"),
				Name = "IsActivityCompleted",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateExecutionContextParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("636df2e5-445b-4dde-9441-489820d3d31c"),
				Name = "ExecutionContext",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = false,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateInformationOnStepParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("babfc1c6-c902-4248-994e-237e43c80a96"),
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

		protected virtual ProcessSchemaParameter CreateOrderParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3911a1da-d517-491b-890c-149347d3868d"),
				Name = "Order",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRequestsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f63af18b-b6ad-48fd-9c79-eb30ce13bc59"),
				Name = "Requests",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Requests",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateListingParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("24d8a5fa-61e9-40ee-bd62-9e3d4ec84632"),
				Name = "Listing",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Listing",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePropertyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2dec1472-cb37-4c44-ab16-82d2130e239e"),
				Name = "Property",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Property",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateContractParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5610469b-a171-4922-b7e8-e8543d46c29d"),
				Name = "Contract",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateProjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("43a53b52-a761-4f8e-8f6f-1f02ed392fcc"),
				Name = "Project",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateProblemParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f1c4cbbd-857f-485b-9bac-830202416742"),
				Name = "Problem",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Problem",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateChangeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4162f7d2-4bb0-4fe8-87b0-786024df5546"),
				Name = "Change",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Change",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateReleaseParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("e12a2247-a122-44ed-9c28-da6204baab37"),
				Name = "Release",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Release",
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
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6af6c254-bc17-4811-abe8-1addebedc123"),
				Name = "Terrasoft.Configuration.RecordEditMode",
				Alias = "RecordEditMode",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d3e04ca4-117b-47d3-af66-59d645b02386"),
				Name = "Terrasoft.Configuration.UserTaskExecutedMode",
				Alias = "UserTaskExecutedMode",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a17a8293-79d9-4402-9570-fe7f8ed0e9fd"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7f7de994-9503-4cf9-991e-aa4ffc9e39a0"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5bd8a167-d710-4bb0-8c0b-94be05e85988"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0568088c-61fe-498e-8cc6-0b51fb0caa7c"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cc28411d-a932-4193-b599-d2c04eab5d06"),
				Name = "System.Runtime.Serialization.Formatters",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9b8b1e7a-6774-4218-ae3d-19b95dc5228a"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("68a4fb24-6dd4-4112-b83b-a6350ca13133"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d5191cc1-1342-45de-81d8-26c6d451a3d0"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4c734fad-3e93-4cfd-90aa-5ac439620f0c"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dcef1195-bd46-43f5-9902-4152583d5404"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("5f1bdcb0-8c10-43bc-aead-341648534099")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,193,110,194,48,12,134,207,244,41,172,156,82,9,245,5,58,118,128,74,104,18,66,72,108,187,32,14,94,112,215,104,33,65,113,202,196,166,189,251,146,22,58,134,166,221,226,56,191,255,207,118,142,232,65,57,187,211,65,59,251,140,166,37,134,9,88,122,135,74,171,116,135,254,116,55,111,245,110,12,28,188,182,175,247,50,47,179,149,119,138,152,215,170,161,61,174,208,227,158,2,249,78,14,236,90,175,168,63,79,64,202,191,223,230,220,197,79,76,254,17,249,173,24,18,156,141,138,57,133,233,105,25,99,41,166,30,173,106,162,111,69,74,115,228,97,145,231,197,250,199,163,204,22,78,161,209,31,248,98,232,55,10,47,52,7,208,129,246,169,167,43,174,226,74,50,115,198,144,26,186,47,51,93,131,60,107,226,32,90,99,114,248,204,70,151,42,105,50,255,27,166,249,124,1,25,166,65,87,172,41,180,135,138,106,108,77,184,82,247,34,41,102,120,72,0,98,12,98,233,64,157,163,84,39,171,157,39,84,13,200,99,92,84,42,6,218,246,45,117,88,55,171,219,36,188,180,173,174,131,141,120,216,137,109,209,165,242,109,132,239,47,47,110,231,76,114,241,145,207,219,219,143,80,126,3,29,225,18,248,29,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("73f6c8c6-fdc1-4dae-b86c-2c582ed8bb43"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ac0a52f7-8504-48f9-8479-6c603eb93368"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("69f9d496-16b0-4854-81dc-2400a5c1e47e"),
				Name = "target",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,230,10,40,202,79,78,45,46,14,5,202,135,36,22,103,135,150,100,230,100,150,100,166,22,35,27,231,8,212,84,150,89,82,137,48,128,8,147,1,137,124,156,89,148,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new UserQuestionUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new UserQuestionUserTask(userConnection) {
				SchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
		}

		#endregion

	}

	#endregion

	#region Class: UserQuestionUserTaskSchemaExtension

	/// <exclude/>
	public class UserQuestionUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var conditionValues = new Dictionary<Guid, string>();
			ProcessSchemaParameterValue sourceValue = ((ProcessSchemaParameter)schemaUserTask.Parameters
				.GetByName("BranchingDecisions")).SourceValue;
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

		public override void SynchronizeDynamicParameters(UserConnection userConnection, ProcessUserTaskSchema target) {
			base.SynchronizeDynamicParameters(userConnection, target);
			ProcessUserTaskUtilities.SynchronizeActivityConnectionParameters(userConnection, target);
		}

		#endregion

	}

	#endregion

	#region Class: UserQuestionUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Recommendation.Group", DescriptionResourceItem = "Parameters.Recommendation.Group")]
	[DesignModeGroup(Name = "Connected to", Position = 2, UseSolutionStorage = true, ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Lead.Group", DescriptionResourceItem = "Parameters.Lead.Group")]
	[DesignModeProperty(Name = "BranchingDecisions", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.BranchingDecisions.Caption", DescriptionResourceItem = "Parameters.BranchingDecisions.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultDecisions", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.ResultDecisions.Caption", DescriptionResourceItem = "Parameters.ResultDecisions.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DecisionMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.DecisionMode.Caption", DescriptionResourceItem = "Parameters.DecisionMode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsDecisionRequired", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.IsDecisionRequired.Caption", DescriptionResourceItem = "Parameters.IsDecisionRequired.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Question", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Question.Caption", DescriptionResourceItem = "Parameters.Question.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "WindowCaption", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.WindowCaption.Caption", DescriptionResourceItem = "Parameters.WindowCaption.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityCategory", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.ActivityCategory.Caption", DescriptionResourceItem = "Parameters.ActivityCategory.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duration", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Duration.Caption", DescriptionResourceItem = "Parameters.Duration.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DurationPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.DurationPeriod.Caption", DescriptionResourceItem = "Parameters.DurationPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartIn", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.StartIn.Caption", DescriptionResourceItem = "Parameters.StartIn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartInPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.StartInPeriod.Caption", DescriptionResourceItem = "Parameters.StartInPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBefore", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.RemindBefore.Caption", DescriptionResourceItem = "Parameters.RemindBefore.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBeforePeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.RemindBeforePeriod.Caption", DescriptionResourceItem = "Parameters.RemindBeforePeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowInScheduler", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.ShowInScheduler.Caption", DescriptionResourceItem = "Parameters.ShowInScheduler.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Lead", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Lead.Caption", DescriptionResourceItem = "Parameters.Lead.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Account", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Account.Caption", DescriptionResourceItem = "Parameters.Account.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Opportunity", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Opportunity.Caption", DescriptionResourceItem = "Parameters.Opportunity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Invoice", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Invoice.Caption", DescriptionResourceItem = "Parameters.Invoice.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Document", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Document.Caption", DescriptionResourceItem = "Parameters.Document.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Incident", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Incident.Caption", DescriptionResourceItem = "Parameters.Incident.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Case", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Case.Caption", DescriptionResourceItem = "Parameters.Case.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityResult", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.ActivityResult.Caption", DescriptionResourceItem = "Parameters.ActivityResult.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentActivityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.CurrentActivityId.Caption", DescriptionResourceItem = "Parameters.CurrentActivityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActivityCompleted", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.IsActivityCompleted.Caption", DescriptionResourceItem = "Parameters.IsActivityCompleted.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExecutionContext", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.ExecutionContext.Caption", DescriptionResourceItem = "Parameters.ExecutionContext.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Order", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Order.Caption", DescriptionResourceItem = "Parameters.Order.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Requests", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Requests.Caption", DescriptionResourceItem = "Parameters.Requests.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Listing", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Listing.Caption", DescriptionResourceItem = "Parameters.Listing.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Property", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Property.Caption", DescriptionResourceItem = "Parameters.Property.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contract", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Contract.Caption", DescriptionResourceItem = "Parameters.Contract.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Project", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Project.Caption", DescriptionResourceItem = "Parameters.Project.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Problem", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Problem.Caption", DescriptionResourceItem = "Parameters.Problem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Change", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Change.Caption", DescriptionResourceItem = "Parameters.Change.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Release", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "fe10dd952d614aa181119fb23b032603", CaptionResourceItem = "Parameters.Release.Caption", DescriptionResourceItem = "Parameters.Release.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class UserQuestionUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public UserQuestionUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603");
			_decisionMode = () => { return 0; };
			_isDecisionRequired = () => { return true; };
		}

		#endregion

		#region Properties: Public

		private LocalizableString _branchingDecisions;
		public virtual LocalizableString BranchingDecisions {
			get {
				return _branchingDecisions ?? (_branchingDecisions = new LocalizableString());
			}
			set {
				_branchingDecisions = value;
			}
		}

		public virtual string ResultDecisions {
			get;
			set;
		}

		private Func<int> _decisionMode;
		public virtual int DecisionMode {
			get {
				return (_decisionMode ?? (_decisionMode = () => 0)).Invoke();
			}
			set {
				_decisionMode = () => { return value; };
			}
		}

		private Func<bool> _isDecisionRequired;
		public virtual bool IsDecisionRequired {
			get {
				return (_isDecisionRequired ?? (_isDecisionRequired = () => false)).Invoke();
			}
			set {
				_isDecisionRequired = () => { return value; };
			}
		}

		private LocalizableString _question;
		public virtual LocalizableString Question {
			get {
				return _question ?? (_question = new LocalizableString());
			}
			set {
				_question = value;
			}
		}

		private LocalizableString _windowCaption;
		public virtual LocalizableString WindowCaption {
			get {
				return _windowCaption ?? (_windowCaption = new LocalizableString());
			}
			set {
				_windowCaption = value;
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

		private Guid _activityCategory = new Guid("f51c4643-58e6-df11-971b-001d60e938c6");
		public virtual Guid ActivityCategory {
			get {
				return _activityCategory;
			}
			set {
				_activityCategory = value;
			}
		}

		public virtual Guid OwnerId {
			get;
			set;
		}

		private int _duration = 5;
		public virtual int Duration {
			get {
				return _duration;
			}
			set {
				_duration = value;
			}
		}

		private int _durationPeriod = 0;
		public virtual int DurationPeriod {
			get {
				return _durationPeriod;
			}
			set {
				_durationPeriod = value;
			}
		}

		public virtual int StartIn {
			get;
			set;
		}

		public virtual int StartInPeriod {
			get;
			set;
		}

		public virtual int RemindBefore {
			get;
			set;
		}

		public virtual int RemindBeforePeriod {
			get;
			set;
		}

		private bool _showInScheduler = false;
		public virtual bool ShowInScheduler {
			get {
				return _showInScheduler;
			}
			set {
				_showInScheduler = value;
			}
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

		public virtual Guid Lead {
			get;
			set;
		}

		public virtual Guid Account {
			get;
			set;
		}

		public virtual Guid Contact {
			get;
			set;
		}

		public virtual Guid Opportunity {
			get;
			set;
		}

		public virtual Guid Invoice {
			get;
			set;
		}

		public virtual Guid Document {
			get;
			set;
		}

		public virtual Guid Incident {
			get;
			set;
		}

		public virtual Guid Case {
			get;
			set;
		}

		public virtual Guid ActivityResult {
			get;
			set;
		}

		public virtual Guid CurrentActivityId {
			get;
			set;
		}

		public virtual bool IsActivityCompleted {
			get;
			set;
		}

		public virtual string ExecutionContext {
			get;
			set;
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

		public virtual Guid Order {
			get;
			set;
		}

		public virtual Guid Requests {
			get;
			set;
		}

		public virtual Guid Listing {
			get;
			set;
		}

		public virtual Guid Property {
			get;
			set;
		}

		public virtual Guid Contract {
			get;
			set;
		}

		public virtual Guid Project {
			get;
			set;
		}

		public virtual Guid Problem {
			get;
			set;
		}

		public virtual Guid Change {
			get;
			set;
		}

		public virtual Guid Release {
			get;
			set;
		}

		private LocalizableString _noCaptionLocalizableString;
		public LocalizableString NoCaptionLocalizableString {
			get {
				return _noCaptionLocalizableString ?? (_noCaptionLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.NoCaptionLocalizableString.Value"));
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
			if (!HasMapping("ResultDecisions")) {
				writer.WriteValue("ResultDecisions", ResultDecisions, null);
			}
			if (!HasMapping("DecisionMode")) {
				writer.WriteValue("DecisionMode", DecisionMode, 0);
			}
			if (!HasMapping("IsDecisionRequired")) {
				writer.WriteValue("IsDecisionRequired", IsDecisionRequired, false);
			}
			if (!HasMapping("ActivityCategory")) {
				writer.WriteValue("ActivityCategory", ActivityCategory, Guid.Empty);
			}
			if (!HasMapping("OwnerId")) {
				writer.WriteValue("OwnerId", OwnerId, Guid.Empty);
			}
			if (!HasMapping("Duration")) {
				writer.WriteValue("Duration", Duration, 0);
			}
			if (!HasMapping("DurationPeriod")) {
				writer.WriteValue("DurationPeriod", DurationPeriod, 0);
			}
			if (!HasMapping("StartIn")) {
				writer.WriteValue("StartIn", StartIn, 0);
			}
			if (!HasMapping("StartInPeriod")) {
				writer.WriteValue("StartInPeriod", StartInPeriod, 0);
			}
			if (!HasMapping("RemindBefore")) {
				writer.WriteValue("RemindBefore", RemindBefore, 0);
			}
			if (!HasMapping("RemindBeforePeriod")) {
				writer.WriteValue("RemindBeforePeriod", RemindBeforePeriod, 0);
			}
			if (!HasMapping("ShowInScheduler")) {
				writer.WriteValue("ShowInScheduler", ShowInScheduler, false);
			}
			if (!HasMapping("ShowExecutionPage")) {
				writer.WriteValue("ShowExecutionPage", ShowExecutionPage, false);
			}
			if (!HasMapping("Lead")) {
				writer.WriteValue("Lead", Lead, Guid.Empty);
			}
			if (!HasMapping("Account")) {
				writer.WriteValue("Account", Account, Guid.Empty);
			}
			if (!HasMapping("Contact")) {
				writer.WriteValue("Contact", Contact, Guid.Empty);
			}
			if (!HasMapping("Opportunity")) {
				writer.WriteValue("Opportunity", Opportunity, Guid.Empty);
			}
			if (!HasMapping("Invoice")) {
				writer.WriteValue("Invoice", Invoice, Guid.Empty);
			}
			if (!HasMapping("Document")) {
				writer.WriteValue("Document", Document, Guid.Empty);
			}
			if (!HasMapping("Incident")) {
				writer.WriteValue("Incident", Incident, Guid.Empty);
			}
			if (!HasMapping("Case")) {
				writer.WriteValue("Case", Case, Guid.Empty);
			}
			if (!HasMapping("ActivityResult")) {
				writer.WriteValue("ActivityResult", ActivityResult, Guid.Empty);
			}
			if (!HasMapping("CurrentActivityId")) {
				writer.WriteValue("CurrentActivityId", CurrentActivityId, Guid.Empty);
			}
			if (!HasMapping("IsActivityCompleted")) {
				writer.WriteValue("IsActivityCompleted", IsActivityCompleted, false);
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("ExecutionContext")) {
					writer.WriteValue("ExecutionContext", ExecutionContext, null);
				}
			}
			if (!HasMapping("Order")) {
				writer.WriteValue("Order", Order, Guid.Empty);
			}
			if (!HasMapping("Requests")) {
				writer.WriteValue("Requests", Requests, Guid.Empty);
			}
			if (!HasMapping("Listing")) {
				writer.WriteValue("Listing", Listing, Guid.Empty);
			}
			if (!HasMapping("Property")) {
				writer.WriteValue("Property", Property, Guid.Empty);
			}
			if (!HasMapping("Contract")) {
				writer.WriteValue("Contract", Contract, Guid.Empty);
			}
			if (!HasMapping("Project")) {
				writer.WriteValue("Project", Project, Guid.Empty);
			}
			if (!HasMapping("Problem")) {
				writer.WriteValue("Problem", Problem, Guid.Empty);
			}
			if (!HasMapping("Change")) {
				writer.WriteValue("Change", Change, Guid.Empty);
			}
			if (!HasMapping("Release")) {
				writer.WriteValue("Release", Release, Guid.Empty);
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
				case "BranchingDecisions":
					BranchingDecisions = reader.GetLocalizableStringValue();
				break;
				case "ResultDecisions":
					ResultDecisions = reader.GetStringValue();
				break;
				case "DecisionMode":
					DecisionMode = reader.GetIntValue();
				break;
				case "IsDecisionRequired":
					IsDecisionRequired = reader.GetBoolValue();
				break;
				case "Question":
					Question = reader.GetLocalizableStringValue();
				break;
				case "WindowCaption":
					WindowCaption = reader.GetLocalizableStringValue();
				break;
				case "Recommendation":
					Recommendation = reader.GetLocalizableStringValue();
				break;
				case "ActivityCategory":
					ActivityCategory = reader.GetGuidValue();
				break;
				case "OwnerId":
					OwnerId = reader.GetGuidValue();
				break;
				case "Duration":
					Duration = reader.GetIntValue();
				break;
				case "DurationPeriod":
					DurationPeriod = reader.GetIntValue();
				break;
				case "StartIn":
					StartIn = reader.GetIntValue();
				break;
				case "StartInPeriod":
					StartInPeriod = reader.GetIntValue();
				break;
				case "RemindBefore":
					RemindBefore = reader.GetIntValue();
				break;
				case "RemindBeforePeriod":
					RemindBeforePeriod = reader.GetIntValue();
				break;
				case "ShowInScheduler":
					ShowInScheduler = reader.GetBoolValue();
				break;
				case "ShowExecutionPage":
					ShowExecutionPage = reader.GetBoolValue();
				break;
				case "Lead":
					Lead = reader.GetGuidValue();
				break;
				case "Account":
					Account = reader.GetGuidValue();
				break;
				case "Contact":
					Contact = reader.GetGuidValue();
				break;
				case "Opportunity":
					Opportunity = reader.GetGuidValue();
				break;
				case "Invoice":
					Invoice = reader.GetGuidValue();
				break;
				case "Document":
					Document = reader.GetGuidValue();
				break;
				case "Incident":
					Incident = reader.GetGuidValue();
				break;
				case "Case":
					Case = reader.GetGuidValue();
				break;
				case "ActivityResult":
					ActivityResult = reader.GetGuidValue();
				break;
				case "CurrentActivityId":
					CurrentActivityId = reader.GetGuidValue();
				break;
				case "IsActivityCompleted":
					IsActivityCompleted = reader.GetBoolValue();
				break;
				case "ExecutionContext":
					if (!UseFlowEngineMode) {
						break;
					}
					ExecutionContext = reader.GetStringValue();
				break;
				case "InformationOnStep":
					InformationOnStep = reader.GetLocalizableStringValue();
				break;
				case "Order":
					Order = reader.GetGuidValue();
				break;
				case "Requests":
					Requests = reader.GetGuidValue();
				break;
				case "Listing":
					Listing = reader.GetGuidValue();
				break;
				case "Property":
					Property = reader.GetGuidValue();
				break;
				case "Contract":
					Contract = reader.GetGuidValue();
				break;
				case "Project":
					Project = reader.GetGuidValue();
				break;
				case "Problem":
					Problem = reader.GetGuidValue();
				break;
				case "Change":
					Change = reader.GetGuidValue();
				break;
				case "Release":
					Release = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

