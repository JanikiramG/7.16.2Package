namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CallUserTaskSchema

	/// <exclude/>
	public class CallUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public CallUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public CallUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09");
			RealUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09");
			Name = "CallUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.None;
			ParametersEditPageSchemaUId = new Guid("188192d7-b219-4b23-b9ad-f4ef53e54f82");
			ParametersEditPageSchemaV2UId = new Guid("886b457b-80ec-4df0-9d0a-60747a925335");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,193,110,131,48,16,68,207,248,43,76,14,145,145,16,63,128,144,26,33,20,113,139,74,81,207,46,44,137,21,98,211,245,58,77,84,241,239,53,80,154,74,61,245,58,59,51,251,118,159,54,170,227,162,34,73,206,242,44,227,7,52,13,88,187,8,73,129,104,48,226,159,44,152,92,185,67,4,77,187,134,212,85,209,189,108,167,192,222,169,54,41,46,3,221,249,118,203,195,239,124,109,1,95,164,61,215,164,122,69,10,108,178,7,42,237,26,205,17,36,65,43,38,91,110,180,6,175,27,29,243,186,108,163,121,93,176,235,8,112,181,87,242,10,85,131,106,160,226,6,141,35,16,75,193,58,23,81,148,178,96,100,35,123,51,166,231,202,62,59,173,149,62,242,140,135,127,160,147,226,221,201,222,138,7,120,52,147,255,162,51,151,161,7,207,151,178,233,236,240,167,111,70,251,63,217,200,74,237,51,178,161,87,69,167,233,102,209,24,175,220,40,126,176,198,188,58,153,143,165,197,255,226,32,143,224,163,8,228,80,243,206,3,67,186,249,2,102,185,188,14,173,1,0,0 };
			SerializeToDB = true;
			IsUserTask = true;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
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
			Parameters.Add(CreateContractParameter());
			Parameters.Add(CreateRequestsParameter());
			Parameters.Add(CreateListingParameter());
			Parameters.Add(CreatePropertyParameter());
			Parameters.Add(CreateProjectParameter());
			Parameters.Add(CreateProblemParameter());
			Parameters.Add(CreateReleaseParameter());
			Parameters.Add(CreateChangeParameter());
			Parameters.Add(CreateQueueItemParameter());
		}

		protected virtual ProcessSchemaParameter CreateRecommendationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ea556634-d640-4462-9f9c-9da998c973d0"),
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
				UId = new Guid("dba2c595-cf3a-4e5f-be62-e4f0b3ccf037"),
				Name = "ActivityCategory",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.961e2086-a12b-4d27-b095-40b1e64d6cc0.e52bd583-7825-e011-8165-00155d043204#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
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
				UId = new Guid("a9e99cdd-cb76-4a4b-823e-d1313722f2e0"),
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
				UId = new Guid("d20354ab-9c8e-455b-8fd5-06659b6d2b76"),
				Name = "Duration",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"5",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
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
				UId = new Guid("e1f8f9fd-7772-4e6c-889f-9f96a2558ed2"),
				Name = "DurationPeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
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
				UId = new Guid("e753845b-17b2-4af9-b99a-8b937d556cdb"),
				Name = "StartIn",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				},
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
				UId = new Guid("a87ab342-80fc-4965-952d-f408651f4c23"),
				Name = "StartInPeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				},
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
				UId = new Guid("b278c813-c317-4a1d-bf3a-1addbcb8a14c"),
				Name = "RemindBefore",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				},
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
				UId = new Guid("118aa7b1-c508-4a99-bb60-54b6469d92fe"),
				Name = "RemindBeforePeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				},
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
				UId = new Guid("95c4592a-d21e-4850-8840-0d7171780e18"),
				Name = "ShowInScheduler",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
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
				UId = new Guid("919de484-bbd4-4419-9b38-12e4069a66da"),
				Name = "ShowExecutionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
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
				UId = new Guid("44bda5c9-3341-4695-839c-854e5ecec0c2"),
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
				UId = new Guid("b8e302ca-fc15-4851-9647-7c995203c328"),
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
				UId = new Guid("e7187dca-c0c4-436f-beb4-b14929b7c483"),
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
				UId = new Guid("ab0fc793-23f8-4145-8465-3c8c36f057bd"),
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
				UId = new Guid("ecf1edb8-cd09-4fff-b9c7-daf9c4faf0d7"),
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
				UId = new Guid("122905c2-a137-4e3b-b099-2e5eab65e809"),
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
				UId = new Guid("393e6062-17a1-417a-9a15-dd2cdc9bb57b"),
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
				UId = new Guid("bd382068-37a4-40b5-a679-d28717a6ba89"),
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
				UId = new Guid("585e28c6-fe87-4ebc-8555-7b841d613101"),
				Name = "ActivityResult",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = true,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentActivityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("69566a2b-2ba0-4280-89be-172e44128234"),
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
				UId = new Guid("a8926541-c304-4ee3-901d-7d417a82c368"),
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
				UId = new Guid("32777408-2aff-44e0-9dfa-8c0b33fd7dd8"),
				Name = "ExecutionContext",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
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
				UId = new Guid("8688e9df-1996-4188-b0b8-b6b5cbc67085"),
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
				UId = new Guid("785a86c1-c5b9-40f9-8405-e46d8f1dc37e"),
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

		protected virtual ProcessSchemaParameter CreateContractParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("76a3351b-c620-4b35-b694-ec1269912fc1"),
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

		protected virtual ProcessSchemaParameter CreateRequestsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("9a2ce7bd-4b17-4219-a366-8f85fb6815b5"),
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
				UId = new Guid("a50285a0-8fad-4a3c-bc9d-2ed70c912908"),
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
				UId = new Guid("8f4e97b0-13c2-40de-a448-2efa64515f1a"),
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

		protected virtual ProcessSchemaParameter CreateProjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("7b9651ee-d2cb-4552-a0e3-d028ebedc12e"),
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
				UId = new Guid("620a10c2-c573-4aed-8aac-d7c9b555a83b"),
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

		protected virtual ProcessSchemaParameter CreateReleaseParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2023a75a-0924-4250-a7ff-d3713953c2e3"),
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

		protected virtual ProcessSchemaParameter CreateChangeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("506d2d36-0e03-467f-bc52-04ae9e8a8e2e"),
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

		protected virtual ProcessSchemaParameter CreateQueueItemParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6d159a34-9d6d-44f7-912e-6b7fa0943dba"),
				Name = "QueueItem",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"VwQueueItem",
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
			Methods.Add(CreateGetActivityTypeMethod());
			Methods.Add(CreateNewDateMethod());
			Methods.Add(CreateGetActivityCategoryMethod());
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateGetConditionDataMethod());
			Methods.Add(CreateGetActivityTitleMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateGetActivityEntitySchemaUIdMethod());
			Methods.Add(CreateCreateActivityMethod());
			Methods.Add(CreateGetParentProcessIdMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f2850d0c-a5d7-4ff4-aae9-89d42f02c3f3"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("add5ec74-2174-4de0-8076-9be63cd036d4"),
				Name = "System.Globalization",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("494d565c-0c70-4c58-a5ca-3ee89f17f41e"),
				Name = "System.Runtime.Serialization.Formatters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b79939b1-4a9b-473d-9f77-3cd0a9c5838a"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f4abbe6-57ce-4bc2-8c7f-32c422c0409a"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c68afa46-ebbd-4ad1-aa8e-6268c9d3887e"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a192356e-3320-4b2c-947e-93349330ca70"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8493e2ef-120e-4431-89fd-e8e0d26a2bb9"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6d2e8156-8b72-4d22-8211-b1d3f9df0ea2"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4f6b87a8-82a9-41d3-970c-d1002ee3e2ea"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8")
			});
		}

		protected virtual SchemaMethod CreateGetActivityTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ffd6b283-f645-4423-a432-351c970169ad"),
				Name = "GetActivityType",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,79,177,78,195,48,16,157,237,175,176,50,217,139,197,30,49,208,36,160,108,136,22,24,16,131,169,175,16,201,177,203,217,14,68,168,255,206,165,142,84,129,100,233,252,222,187,247,238,110,11,14,246,73,196,82,174,5,103,30,190,196,246,12,229,99,4,108,130,247,244,31,130,87,154,51,214,4,151,71,47,171,222,86,103,204,110,49,140,178,186,161,142,105,72,243,110,62,194,42,176,231,15,64,144,85,19,236,66,245,177,251,204,198,201,18,160,239,13,154,17,18,32,53,24,231,42,165,56,51,113,29,92,243,28,7,255,46,228,100,80,216,183,238,27,246,57,5,164,245,254,110,164,59,31,51,66,187,185,80,82,41,241,195,217,234,239,91,147,204,3,24,11,148,179,248,203,157,186,36,66,81,228,101,66,49,179,225,32,164,69,189,200,107,30,99,8,41,163,255,191,64,187,89,46,38,98,2,164,99,8,63,25,151,97,23,238,242,96,41,227,229,234,85,213,100,63,113,122,39,190,134,44,162,238,198,99,154,235,95,163,154,22,122,128,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNewDateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5013ad1f-a250-4a30-8194-2455d8730194"),
				Name = "NewDate",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DateTime"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("da42dbdb-c00e-449b-8ce0-04fb7b2c0f60"),
				Name = "oldDate",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1d89073-c6b5-45ed-a34a-64478b333aa9"),
				Name = "offset",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0fdc8547-0a82-489a-aefb-05d0bc59bbcb"),
				Name = "offsetPeriod",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessDurationPeriod",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,208,49,11,194,48,16,134,225,57,253,21,25,173,67,215,130,78,66,6,151,66,55,231,144,92,104,176,228,224,238,66,17,241,191,87,107,193,41,182,243,251,241,112,28,79,81,220,112,192,16,24,164,7,138,232,107,253,172,148,135,96,243,40,167,74,57,203,160,123,66,7,204,38,147,149,136,233,59,108,186,152,178,0,191,71,138,64,50,37,141,163,55,86,160,185,120,191,198,149,174,207,127,165,43,102,42,56,75,218,167,24,251,40,32,159,178,207,184,1,220,183,145,99,187,193,116,152,100,40,125,102,105,191,115,94,51,179,171,30,60,133,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityCategoryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("10936cf7-ddaa-4231-8e74-de40834f9437"),
				Name = "GetActivityCategory",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("56c040ca-0e1f-43ea-949e-cd55f32621a7"),
				Name = "activityType",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,49,79,195,48,16,133,103,251,87,88,153,236,197,98,143,24,104,18,80,182,170,45,48,32,134,163,185,150,72,137,93,206,118,32,66,253,239,56,113,164,0,146,37,251,238,221,251,252,110,143,29,30,189,112,233,186,21,156,25,252,20,251,185,148,143,14,169,176,198,196,119,107,141,210,156,177,194,118,161,55,50,171,155,108,174,217,61,217,94,102,119,113,98,104,253,88,128,199,179,165,113,17,217,243,59,18,174,242,97,188,224,236,172,93,245,17,160,147,9,167,183,64,208,163,71,146,240,107,82,41,206,192,45,97,114,30,92,107,206,66,14,64,162,121,171,190,240,24,188,165,24,249,111,74,93,25,23,8,203,205,218,146,74,137,111,206,22,127,93,130,135,29,66,131,145,51,249,211,238,58,17,49,41,114,253,33,153,89,123,18,178,33,61,201,11,143,49,66,31,200,252,15,80,110,166,240,177,49,32,197,149,98,253,4,93,192,131,125,8,109,19,25,47,55,175,42,143,246,43,143,231,202,23,200,36,234,170,191,248,49,255,1,122,44,50,32,148,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("230606fd-4856-4d73-84ab-79f1c17e11ab"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("904a77ac-217a-46e1-98ec-4e907d19ad27"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b6a26a9d-a587-4155-8aae-11ce64b27c66"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,81,79,194,48,16,126,238,126,69,179,167,46,33,141,62,35,38,176,33,153,15,106,128,232,131,241,161,178,11,52,25,173,94,91,144,24,254,187,221,58,2,2,14,147,101,75,239,238,251,238,187,245,187,149,64,138,96,92,105,13,237,81,5,107,154,201,153,149,90,9,220,220,140,156,44,58,212,88,148,106,126,203,146,110,52,129,18,102,150,154,240,233,209,136,84,136,16,101,206,0,166,90,41,168,241,9,207,164,177,82,249,68,18,17,194,83,93,186,165,98,113,223,103,87,210,110,198,117,211,184,67,227,188,136,47,84,60,136,37,132,154,59,212,203,147,138,58,115,175,165,98,213,107,186,249,0,158,123,25,232,145,187,202,84,88,152,107,108,16,67,101,113,83,195,8,127,252,83,19,207,205,240,211,137,146,181,178,28,52,9,225,221,56,255,19,116,70,197,133,46,187,116,187,196,195,31,219,174,164,10,182,168,136,143,74,207,183,173,73,246,45,9,127,89,0,194,105,62,213,5,28,224,195,149,243,39,129,254,134,45,32,139,83,81,150,113,82,113,8,211,24,171,27,57,227,13,72,217,202,123,181,120,31,126,193,204,89,141,222,126,191,29,199,135,202,56,132,108,176,15,177,36,161,223,17,105,240,121,38,172,24,131,40,192,243,84,248,224,99,30,24,33,100,216,190,67,0,147,245,66,150,64,89,129,188,170,104,40,9,105,182,134,247,139,226,200,250,60,27,84,243,250,192,10,208,79,229,207,207,162,116,48,213,213,66,121,162,215,171,183,164,227,37,240,17,216,73,189,93,236,58,241,235,69,200,54,242,207,54,66,176,14,213,110,49,187,63,94,5,160,140,165,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3a3f999b-6f6c-416e-86fb-7e1589bb39df"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a1f660e0-d13e-44e9-95f3-68c276b73956"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,150,75,143,219,32,20,133,215,228,87,184,89,101,164,42,234,62,154,69,58,157,142,34,141,154,42,125,108,170,46,8,38,9,149,13,46,143,180,163,106,254,123,193,128,141,205,141,196,18,124,248,184,135,43,31,184,98,89,97,162,217,149,233,151,234,190,234,176,196,45,213,84,170,31,239,126,86,88,85,95,169,148,88,137,147,94,63,8,126,98,103,35,177,102,130,175,183,97,205,102,193,78,213,106,36,220,87,220,52,205,93,245,111,129,36,213,70,242,234,132,27,69,55,139,215,197,254,15,167,114,87,219,93,162,124,29,166,54,139,171,45,131,136,198,180,252,153,226,137,228,11,185,208,22,219,221,221,71,181,254,200,120,253,254,229,147,45,114,181,116,210,229,157,175,32,89,252,38,169,65,28,127,81,162,171,102,6,125,162,218,3,191,227,198,208,100,177,165,33,135,107,230,32,20,234,90,61,25,86,223,185,207,86,249,106,93,109,9,17,134,235,148,30,166,156,47,123,104,218,206,167,95,195,212,212,245,190,235,132,212,134,251,46,148,152,79,86,76,207,32,69,1,71,33,224,157,192,19,73,80,241,96,196,13,58,154,58,240,199,148,136,195,105,141,142,119,252,42,24,161,133,110,131,122,234,52,34,0,151,44,167,131,14,3,34,186,99,0,17,141,149,122,87,65,148,57,218,203,154,202,210,238,57,237,172,111,253,114,168,99,115,46,220,43,167,26,186,148,177,80,172,46,116,198,141,50,7,159,165,232,119,44,243,16,212,83,23,17,1,248,232,114,58,232,36,32,162,151,14,32,162,177,82,239,39,136,50,71,238,103,147,184,216,82,148,79,61,13,16,192,20,1,54,0,93,69,72,180,69,32,40,74,234,245,198,162,44,115,246,65,16,211,82,94,234,44,202,167,206,6,8,224,172,6,54,0,157,69,72,116,86,67,80,148,212,235,157,69,89,230,236,64,127,27,170,180,42,116,22,229,83,103,3,4,112,38,129,13,64,103,17,18,157,73,8,138,146,122,189,179,40,203,156,61,51,165,25,63,151,94,111,94,61,187,225,2,2,186,228,114,58,124,207,121,221,112,213,1,68,52,86,26,46,60,63,134,18,163,163,178,248,210,138,242,44,51,60,4,14,141,108,131,91,169,209,11,147,216,200,161,40,169,119,8,142,126,34,79,142,11,230,231,210,235,201,139,103,169,225,1,80,102,100,104,56,49,122,217,144,23,57,14,13,53,134,172,232,135,80,143,142,13,109,203,91,228,212,89,135,122,4,220,160,57,253,86,127,156,46,105,79,70,68,99,165,67,115,220,24,72,8,251,0,83,165,205,9,234,121,62,120,4,24,15,25,253,70,58,244,186,49,28,114,34,26,43,141,209,208,143,135,183,163,231,31,168,50,205,36,104,253,140,123,35,238,84,84,61,136,182,107,236,219,220,61,67,181,52,22,114,20,162,177,229,134,197,71,11,94,71,209,227,95,74,140,251,101,87,227,147,222,86,58,158,215,212,145,107,59,161,74,61,218,227,166,238,233,186,124,235,93,36,75,190,41,186,173,91,198,15,236,124,233,211,46,188,236,71,38,190,210,149,93,17,30,254,190,176,205,127,54,191,78,209,98,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConditionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1625969-4540-44ac-a347-68cb2f7b00ce"),
				Name = "GetConditionData",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("73178e3b-a4d5-4ba7-bdf5-b8cea1d825cd"),
				Name = "resultColumntUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9e709a4a-e167-4622-b005-c7097b90d456"),
				Name = "activity",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,138,59,10,128,48,12,64,175,210,81,161,120,1,71,5,113,115,176,7,8,54,67,176,166,144,164,130,183,55,29,223,71,208,154,112,56,164,94,168,154,20,229,4,189,147,81,33,35,212,105,67,91,42,103,135,202,43,24,12,125,113,195,120,117,21,131,160,182,226,79,105,15,91,218,115,12,224,229,37,251,198,249,7,251,46,241,225,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityTitleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("81db869c-2daa-4d9a-8801-160388bbf54d"),
				Name = "GetActivityTitle",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,193,78,195,48,12,61,183,95,17,114,74,164,41,63,48,64,130,106,160,74,104,155,40,19,231,144,122,172,82,154,12,39,221,24,104,255,142,219,102,18,19,59,112,74,236,247,108,191,103,55,107,38,202,48,251,4,211,69,168,37,251,206,179,10,44,152,200,194,248,220,176,60,203,28,236,217,152,22,171,0,88,120,231,232,223,120,39,21,161,89,225,109,215,58,193,95,154,104,129,143,185,7,244,173,224,119,196,218,53,241,144,146,175,27,64,16,188,172,41,166,169,31,157,182,98,44,86,75,141,186,133,8,40,138,14,17,92,60,149,150,181,148,76,135,52,127,154,103,8,177,67,151,244,169,36,189,50,218,106,188,14,17,27,247,126,43,228,52,63,50,176,1,122,67,13,121,188,122,242,196,104,190,244,155,133,106,32,145,128,121,103,237,2,103,237,54,30,196,51,24,223,182,224,106,61,248,26,54,113,26,117,142,145,132,99,158,237,52,178,96,54,208,234,153,5,194,98,161,183,61,74,11,19,98,137,222,64,8,213,128,203,197,222,1,170,20,168,71,136,247,58,64,170,186,63,172,202,90,84,191,27,81,66,170,212,109,250,79,245,151,148,156,123,184,196,24,157,36,66,127,227,63,99,232,166,128,168,131,95,71,85,120,4,62,97,227,138,41,114,70,71,193,207,172,18,60,126,212,156,142,57,97,252,228,131,203,254,34,63,125,31,138,104,109,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6c994686-94e9-4e32-b50f-44cd23d536de"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6505ca01-33b7-4878-aace-a60cb6f48f8b"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				ModifiedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,141,177,10,194,64,16,68,123,191,194,50,1,185,31,72,37,71,138,128,133,40,249,128,245,50,132,5,179,39,187,123,33,254,189,39,36,205,20,243,30,51,47,50,132,72,146,240,238,55,164,226,44,115,243,33,165,5,14,181,182,59,141,6,141,89,4,201,57,75,24,238,154,19,204,122,153,89,16,30,88,242,138,107,101,43,251,119,103,55,54,135,64,155,88,84,33,126,224,97,186,156,199,127,28,69,221,53,183,253,31,211,211,201,139,85,163,237,126,196,51,187,98,152,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a90edad5-191a-4705-b810-74a77a1d3717"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,203,110,131,48,16,60,39,95,97,113,2,41,226,3,90,85,85,26,161,10,169,74,80,32,189,187,102,155,90,53,54,178,151,38,180,234,191,119,109,160,143,68,85,46,24,239,204,236,14,179,88,192,206,106,86,130,149,92,201,119,168,76,137,86,234,125,172,225,192,62,230,179,214,26,145,169,93,94,179,27,70,207,197,124,166,121,3,116,89,211,177,24,112,112,46,224,197,240,190,115,96,43,238,94,119,40,149,68,9,46,189,7,44,184,5,141,197,196,142,55,7,13,54,161,6,210,141,197,236,8,162,67,168,239,250,82,238,53,87,23,26,230,255,233,126,90,143,222,214,131,225,80,78,71,219,228,69,98,95,138,23,104,248,136,71,75,129,242,141,170,17,225,22,132,105,26,208,53,71,105,52,161,52,113,194,43,137,10,226,224,93,63,27,219,4,202,70,151,8,45,17,31,140,240,65,242,39,5,67,146,105,238,214,157,82,27,155,53,45,246,113,126,170,73,216,45,211,68,96,87,236,12,75,31,185,234,66,204,124,15,85,223,66,200,153,77,78,86,70,59,116,233,138,43,229,193,97,63,124,4,183,244,9,182,14,130,85,103,125,250,147,44,208,32,196,70,147,168,9,194,17,137,150,157,148,252,178,233,40,126,253,2,209,159,66,112,231,227,34,3,230,0,245,22,92,167,208,93,216,220,114,32,47,191,125,6,81,236,185,52,88,131,240,22,22,231,166,147,249,103,114,253,5,159,23,213,142,176,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityEntitySchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("df5eb1f9-b935-4092-b09d-f37ab7c6ac6c"),
				Name = "GetActivityEntitySchemaUId",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,76,46,201,44,203,44,169,116,206,207,43,46,41,214,131,113,93,243,74,128,100,112,114,70,106,110,98,168,103,138,53,0,165,56,27,204,46,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateActivityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("70b6da69-92be-4a62-b982-cb986399c8b4"),
				Name = "CreateActivity",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Terrasoft.Configuration.Activity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,87,93,111,219,32,20,125,110,126,133,215,135,42,153,152,181,61,71,125,232,146,110,178,84,181,85,155,238,157,217,55,41,155,13,25,198,137,162,169,255,125,23,12,4,136,210,217,79,182,47,231,28,14,151,107,62,118,84,102,180,84,108,199,212,33,187,206,56,236,179,21,72,73,91,177,86,249,66,240,53,219,116,146,42,38,120,126,99,97,211,151,22,36,54,113,40,117,124,54,159,56,129,252,25,212,18,214,11,81,119,13,255,65,235,14,218,105,216,92,84,216,197,247,142,85,249,61,236,245,51,106,93,29,182,96,16,174,35,236,163,85,109,190,160,117,173,219,94,138,42,64,123,16,85,176,17,242,208,107,131,74,227,211,68,63,234,145,169,26,98,154,9,69,182,158,21,149,106,137,106,8,68,219,250,45,201,64,190,232,164,4,174,116,52,71,45,251,169,145,43,214,160,26,201,140,72,193,73,54,125,148,162,132,182,93,218,172,62,130,100,162,154,217,118,251,21,244,190,236,32,233,251,212,24,201,156,218,89,253,228,51,28,222,171,216,23,252,185,124,133,170,171,65,98,71,73,100,62,97,235,108,250,176,231,32,49,199,31,236,4,222,54,91,117,152,101,127,39,23,94,201,65,174,51,251,54,159,92,104,234,19,52,140,87,95,97,45,36,104,254,103,67,59,242,250,246,149,48,44,100,43,217,193,252,44,96,64,54,62,125,201,62,102,97,175,103,211,18,130,124,106,46,222,38,111,147,29,254,23,165,169,227,59,160,122,76,199,142,48,49,13,205,251,34,111,243,111,90,224,112,79,113,158,47,53,244,114,214,39,44,32,227,152,121,87,215,217,213,85,230,190,207,229,16,127,160,224,239,9,68,136,161,162,246,155,81,191,41,75,209,113,245,158,148,133,216,63,202,188,59,54,150,174,66,220,123,108,11,49,108,251,62,143,210,242,176,221,10,169,58,222,175,27,67,178,19,48,226,36,133,82,65,174,146,240,168,148,5,92,18,10,205,226,65,44,69,217,53,248,171,14,28,129,131,199,246,189,72,224,61,140,141,50,238,136,196,75,36,150,11,190,19,172,132,129,142,45,58,54,236,36,2,191,65,104,148,93,203,35,78,32,49,187,160,237,80,167,26,26,219,52,228,192,163,251,30,101,80,147,136,161,38,214,30,100,101,86,155,65,149,171,177,73,205,26,122,88,173,46,48,174,78,53,139,244,228,196,32,174,88,191,112,127,25,104,209,162,99,147,78,34,176,25,132,70,25,181,60,226,4,210,137,198,37,66,210,193,110,29,60,153,112,39,18,78,122,16,27,55,241,150,72,188,68,98,249,9,254,224,249,68,181,3,45,59,120,108,217,139,4,150,195,216,40,203,142,72,188,68,98,249,142,181,138,241,205,208,221,168,71,39,27,146,149,8,247,164,99,104,220,182,212,243,136,19,56,173,223,45,200,193,187,131,131,159,84,112,47,18,151,176,143,141,173,97,67,36,94,34,173,226,87,202,55,131,23,44,3,78,42,184,23,8,235,215,71,198,85,175,161,17,75,63,169,220,26,134,47,172,22,157,214,109,47,17,149,173,15,141,172,90,195,35,78,224,180,12,126,214,208,12,175,2,141,62,41,2,35,17,215,128,11,141,45,1,205,35,78,192,152,245,20,123,72,188,197,6,176,39,167,228,210,81,215,98,15,213,19,180,93,173,250,139,67,255,110,27,142,119,30,237,42,147,166,173,119,161,94,138,247,142,145,168,228,114,128,39,89,213,225,58,147,155,190,147,171,70,225,60,242,13,227,144,223,84,149,13,232,159,16,240,124,236,79,196,68,123,39,218,34,210,43,166,217,120,60,166,211,212,20,241,158,102,179,255,117,119,199,248,111,27,89,137,91,174,244,109,208,156,202,201,201,192,34,229,220,220,187,138,246,120,179,107,182,53,40,208,25,89,211,186,197,243,190,189,52,57,68,156,44,157,8,9,170,147,220,199,230,255,0,153,6,55,196,186,14,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetParentProcessIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("40b51a06-74ea-477b-b6cb-dd606fd085a2"),
				Name = "GetParentProcessId",
				CreatedInSchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,86,40,72,44,74,205,43,9,128,242,108,21,252,203,243,82,139,172,185,220,75,51,83,20,10,32,162,158,41,64,113,20,117,122,161,158,41,214,92,229,25,153,57,169,26,168,6,40,218,42,228,149,230,228,104,86,115,113,18,208,205,137,110,51,170,26,168,59,106,185,138,82,75,74,139,242,16,110,177,6,0,233,89,27,175,186,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CallUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new CallUserTask(userConnection) {
				SchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09")
			};
		}

		#endregion

	}

	#endregion

	#region Class: CallUserTaskSchemaExtension

	/// <exclude/>
	public class CallUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var results = new Dictionary<Guid, string>();
			Select select = 
				new Select(userConnection).Distinct()
					.Column("ActivityResult", "Id")
					.Column("ActivityResult", "Name")
					.From("ActivityResult")
					.Join(JoinType.Inner, "ActivityCategoryResultEntry")
						.On("ActivityResult", "Id").IsEqual("ActivityCategoryResultEntry", "ActivityResultId")
					.Join(JoinType.Inner, "ActivityCategory")
						.On("ActivityCategoryResultEntry", "ActivityCategoryId").IsEqual("ActivityCategory", "Id")
					.Join(JoinType.Inner, "ActivityType")
						.On("ActivityCategory", "ActivityTypeId").IsEqual("ActivityType", "Id")
						.Where("ActivityType", "Code").IsEqual(Column.Parameter("Call"))
					as Select;
			using (var dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						results.Add(userConnection.DBTypeConverter.DBValueToGuid(dr[0]), dr.GetString(1));
					}
				}
			}
			return results;
		}

		#endregion

	}

	#endregion

	#region Class: CallUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Recommendation.Group", DescriptionResourceItem = "Parameters.Recommendation.Group")]
	[DesignModeGroup(Name = "Connected to", Position = 2, UseSolutionStorage = true, ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Lead.Group", DescriptionResourceItem = "Parameters.Lead.Group")]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityCategory", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.ActivityCategory.Caption", DescriptionResourceItem = "Parameters.ActivityCategory.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duration", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Duration.Caption", DescriptionResourceItem = "Parameters.Duration.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DurationPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.DurationPeriod.Caption", DescriptionResourceItem = "Parameters.DurationPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartIn", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.StartIn.Caption", DescriptionResourceItem = "Parameters.StartIn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartInPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.StartInPeriod.Caption", DescriptionResourceItem = "Parameters.StartInPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBefore", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.RemindBefore.Caption", DescriptionResourceItem = "Parameters.RemindBefore.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBeforePeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.RemindBeforePeriod.Caption", DescriptionResourceItem = "Parameters.RemindBeforePeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowInScheduler", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.ShowInScheduler.Caption", DescriptionResourceItem = "Parameters.ShowInScheduler.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Lead", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Lead.Caption", DescriptionResourceItem = "Parameters.Lead.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Account", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Account.Caption", DescriptionResourceItem = "Parameters.Account.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Opportunity", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Opportunity.Caption", DescriptionResourceItem = "Parameters.Opportunity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Invoice", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Invoice.Caption", DescriptionResourceItem = "Parameters.Invoice.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Document", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Document.Caption", DescriptionResourceItem = "Parameters.Document.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Incident", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Incident.Caption", DescriptionResourceItem = "Parameters.Incident.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Case", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Case.Caption", DescriptionResourceItem = "Parameters.Case.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityResult", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.ActivityResult.Caption", DescriptionResourceItem = "Parameters.ActivityResult.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentActivityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.CurrentActivityId.Caption", DescriptionResourceItem = "Parameters.CurrentActivityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActivityCompleted", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.IsActivityCompleted.Caption", DescriptionResourceItem = "Parameters.IsActivityCompleted.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExecutionContext", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.ExecutionContext.Caption", DescriptionResourceItem = "Parameters.ExecutionContext.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Order", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Order.Caption", DescriptionResourceItem = "Parameters.Order.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contract", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Contract.Caption", DescriptionResourceItem = "Parameters.Contract.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Requests", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Requests.Caption", DescriptionResourceItem = "Parameters.Requests.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Listing", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Listing.Caption", DescriptionResourceItem = "Parameters.Listing.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Property", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Property.Caption", DescriptionResourceItem = "Parameters.Property.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Project", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Project.Caption", DescriptionResourceItem = "Parameters.Project.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Problem", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Problem.Caption", DescriptionResourceItem = "Parameters.Problem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Release", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Release.Caption", DescriptionResourceItem = "Parameters.Release.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Change", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.Change.Caption", DescriptionResourceItem = "Parameters.Change.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "QueueItem", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e5da0e6400f2448ab79eceb25c1e6b09", CaptionResourceItem = "Parameters.QueueItem.Caption", DescriptionResourceItem = "Parameters.QueueItem.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class CallUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public CallUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("e5da0e64-00f2-448a-b79e-ceb25c1e6b09");
			_activityCategory = () => { return new Guid("e52bd583-7825-e011-8165-00155d043204"); };
		}

		#endregion

		#region Properties: Public

		private LocalizableString _recommendation;
		public virtual LocalizableString Recommendation {
			get {
				return _recommendation ?? (_recommendation = new LocalizableString());
			}
			set {
				_recommendation = value;
			}
		}

		private Func<Guid> _activityCategory;
		public virtual Guid ActivityCategory {
			get {
				return (_activityCategory ?? (_activityCategory = () => Guid.Empty)).Invoke();
			}
			set {
				_activityCategory = () => { return value; };
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

		private int _startIn = 0;
		public virtual int StartIn {
			get {
				return _startIn;
			}
			set {
				_startIn = value;
			}
		}

		private int _startInPeriod = 0;
		public virtual int StartInPeriod {
			get {
				return _startInPeriod;
			}
			set {
				_startInPeriod = value;
			}
		}

		private int _remindBefore = 0;
		public virtual int RemindBefore {
			get {
				return _remindBefore;
			}
			set {
				_remindBefore = value;
			}
		}

		private int _remindBeforePeriod = 0;
		public virtual int RemindBeforePeriod {
			get {
				return _remindBeforePeriod;
			}
			set {
				_remindBeforePeriod = value;
			}
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

		public virtual Guid Contract {
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

		public virtual Guid Project {
			get;
			set;
		}

		public virtual Guid Problem {
			get;
			set;
		}

		public virtual Guid Release {
			get;
			set;
		}

		public virtual Guid Change {
			get;
			set;
		}

		public virtual Guid QueueItem {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (Status == ProcessStatus.Error) {
				if (CurrentActivityId == Guid.Empty && !ProcessUserTaskUtilities.GetIsActivityCreated(UserConnection, UId)) {
					AfterActivitySaveScriptExecute(CreateActivity());
				}
			}
			bool isRunning = !CurrentActivityId.Equals(Guid.Empty) && !IsActivityCompleted;
			if (!isRunning) {
				AfterActivitySaveScriptExecute(CreateActivity());
			}
			InteractWithUser(context, isRunning, ShowExecutionPage);
			return false;
		}

		#endregion

		#region Methods: Public

		public virtual Guid GetActivityType() {
			Select select = 
				new Select(UserConnection).
					Column("Id").
						From("ActivityType").
							Where("Code").IsEqual(Column.Parameter("Call"))
				as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
					if (dr.Read()) {
						return UserConnection.DBTypeConverter.DBValueToGuid(dr[0]);
					}
				}
			}
			return Guid.Empty;
		}

		public virtual DateTime NewDate(DateTime oldDate, int offset, ProcessDurationPeriod offsetPeriod) {
			switch(offsetPeriod) {
				default:
				case ProcessDurationPeriod.Minutes:
					return oldDate.AddMinutes(offset);
				case ProcessDurationPeriod.Hours:
					return oldDate.AddHours(offset);
				case ProcessDurationPeriod.Days:
					return oldDate.AddDays(offset);
				case ProcessDurationPeriod.Weeks:
					return oldDate.AddDays(offset*7);
				case ProcessDurationPeriod.Months:
					return oldDate.AddMonths(offset);
			}
		}

		public virtual Guid GetActivityCategory(Guid activityType) {
			Select select = 
				new Select(UserConnection).
					Column("Id").
						From("ActivityCategory").
							Where("ActivityTypeId").IsEqual(Column.Parameter(activityType))
				as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
					if (dr.Read()) {
						return UserConnection.DBTypeConverter.DBValueToGuid(dr[0]);
					}
				}
			}
			return Guid.Empty;
		}

		public override bool CompleteExecuting(params object[] parameters) {
			var activity = parameters[0] as Terrasoft.Configuration.Activity;
			if (activity == null) {
				return false;
			}
			OwnerId = activity.OwnerId;
			var columnLead = activity.Schema.Columns.FindByName("Lead");
			if (columnLead != null) {
				object lead = activity.GetColumnValue(columnLead);
				if (lead != null) {
					Lead = (Guid)lead;
				}
			}
			Account = activity.AccountId;
			Contact = activity.ContactId;
			var columnOpportunity = activity.Schema.Columns.FindByName("Opportunity");
			if (columnOpportunity != null) {
				object opportunity = activity.GetColumnValue(columnOpportunity);
				if (opportunity != null) {
					Opportunity = (Guid)opportunity;
				}
			}
			var columnInvoice = activity.Schema.Columns.FindByName("Invoice");
			if (columnInvoice != null) {
				object invoice = activity.GetColumnValue(columnInvoice);
				if (invoice != null) {
					Invoice = (Guid)invoice;
				}
			}
			var columnOrder = activity.Schema.Columns.FindByName("Order");
			if (columnOrder != null) {
				object order = activity.GetColumnValue(columnOrder);
				if (order != null) {
					Order = (Guid)order;
				}
			}
			var columnProject = activity.Schema.Columns.FindByName("Project");
			if (columnProject != null) {
				object project = activity.GetColumnValue(columnProject);
				if (project != null) {
					Project = (Guid)project;
				}
			}
			var columnContract = activity.Schema.Columns.FindByName("Contract");
			if (columnContract != null) {
				object contract = activity.GetColumnValue(columnContract);
				if (contract != null) {
					Contract = (Guid)contract;
				}
			}
			var columnDocument = activity.Schema.Columns.FindByName("Document");
			if (columnDocument != null) {
				object document = activity.GetColumnValue(columnDocument);
				if (document != null) {
					Document = (Guid)document;
				}
			}
			var columnRequests = activity.Schema.Columns.FindByName("Requests");
			if (columnRequests != null) {
				object requests = activity.GetColumnValue(columnRequests);
				if (requests != null) {
					Requests = (Guid)requests;
				}
			}
			var columnListing = activity.Schema.Columns.FindByName("Listing");
			if (columnListing != null) {
				object listing = activity.GetColumnValue(columnListing);
				if (listing != null) {
					Listing = (Guid)listing;
				}
			}
			var columnProperty = activity.Schema.Columns.FindByName("Property");
			if (columnProperty != null) {
				object property = activity.GetColumnValue(columnProperty);
				if (property != null) {
					Property = (Guid)property;
				}
			}
			var columnChange = activity.Schema.Columns.FindByName("Change");
			if (columnChange != null) {
				object change = activity.GetColumnValue(columnChange);
				if (change != null) {
					Change = (Guid)change;
				}
			}
			var columnProblem = activity.Schema.Columns.FindByName("Problem");
			if (columnProblem != null) {
				object problem = activity.GetColumnValue(columnProblem);
				if (problem != null) {
					Problem = (Guid)problem;
				}
			}
			var columnRelease = activity.Schema.Columns.FindByName("Release");
			if (columnRelease != null) {
				object release = activity.GetColumnValue(columnRelease);
				if (release != null) {
					Release = (Guid)release;
				}
			}
			ActivityResult = activity.ResultId;
			IsActivityCompleted = true;
			bool result = base.CompleteExecuting(parameters);
			activity.SetColumnValue("ProcessElementId", null);
			activity.UseAdminRights = false;
			activity.Save();
			return result;
		}

		public virtual string GetConditionData(Guid resultColumntUId, Entity activity) {
			return ProcessUserTaskUtilities.GetConditionData(UserConnection, resultColumntUId, activity);
		}

		public virtual string GetActivityTitle() {
			if (IsExecuted) {
				Select select = 
					new Select(UserConnection).
						Column("Title").
						From("Activity").
						Where("Id").IsEqual(Column.Parameter(CurrentActivityId)) as Select;
				return select.ExecuteScalar<string>();
			} else {
				if (!LocalizableString.IsNullOrEmpty(Recommendation)) {
					return Recommendation;
				}
				var schemaElementCaption = ((ProcessSchema)Owner.Schema).GetBaseElementByUId(SchemaElementUId).Caption;
				if (!LocalizableString.IsNullOrEmpty(schemaElementCaption)) {
					return schemaElementCaption;
				}
				return new LocalizableString("Terrasoft.Core", string.Concat("ProcessSchema", Schema.Name, ".Caption"));
			}
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
			UserConnection.IProcessEngine.RemoveActivityProcessListener(CurrentActivityId, UId, ActivityConsts.CanceledStatusUId);
		}

		public override string GetExecutionData() {
			return SerializeToString(new {
				procElUId = UId,
				name = Name,
				processId = ProcessUserTaskUtilities.GetParentProcessId(Owner),
				isProcessExecutedBySignal = ProcessUserTaskUtilities.GetIsProcessExecutedBySignal(Owner),
				processName = Owner.Name,
				entitySchemaName = "Activity",
				recommendation = GetActivityTitle(),
				informationOnStep = LocalizableString.IsNullOrEmpty(InformationOnStep) ? null : InformationOnStep.Value,
				pageTypeId =  ActivityConsts.CallTypeUId,
				activityRecordId = CurrentActivityId,
				executionContext = ExecutionContext,
				nextProcElUId = "nextProcElUIdValue",
				allowedResults = ProcessUserTaskUtilities.GetAllowedActivityResults(UserConnection, CurrentActivityId)
			});
		}

		public virtual Guid GetActivityEntitySchemaUId() {
			return ActivityConsts.ActivityEntitySchemaUId;
		}

		public virtual Terrasoft.Configuration.Activity CreateActivity() {
			var activity = new Terrasoft.Configuration.Activity(UserConnection);
			activity.SetDefColumnValues();
			activity.Id = Guid.NewGuid();
			activity.TypeId = ActivityConsts.CallTypeUId;
			activity.ActivityCategoryId = GetActivityCategory(activity.TypeId);
			activity.Title = GetActivityTitle();
			activity.StartDate = NewDate(UserConnection.CurrentUser.GetCurrentDateTime(), StartIn, (ProcessDurationPeriod)StartInPeriod);
			activity.DueDate = NewDate(activity.StartDate, Duration, (ProcessDurationPeriod)DurationPeriod);
			activity.ShowInScheduler = ShowInScheduler;
			if (OwnerId != Guid.Empty) {
				activity.OwnerId = OwnerId;
				if (RemindBefore != 0) {
					activity.RemindToOwner = true;
					activity.RemindToOwnerDate = NewDate(activity.StartDate, -1 * RemindBefore, (ProcessDurationPeriod)RemindBeforePeriod);
				}
			}
			var columnLead = activity.Schema.Columns.FindByName("Lead");
			if (columnLead != null && Lead != Guid.Empty) {
				activity.SetColumnValue(columnLead, Lead);
			}
			if (Account != Guid.Empty) {
				activity.AccountId = Account;
			}
			if (Contact != Guid.Empty) {
				activity.ContactId = Contact;
			}
			var columnOpportunity = activity.Schema.Columns.FindByName("Opportunity");
			if (columnOpportunity != null && Opportunity != Guid.Empty) {
				activity.SetColumnValue(columnOpportunity, Opportunity);
			}
			var columnDocument = activity.Schema.Columns.FindByName("Document");
			if (columnDocument != null && Document != Guid.Empty) {
				activity.SetColumnValue(columnDocument, Document);
			}
			var columnInvoice = activity.Schema.Columns.FindByName("Invoice");
			if (columnInvoice != null && Invoice != Guid.Empty) {
				activity.SetColumnValue(columnInvoice, Invoice);
			}
			var columnCase = activity.Schema.Columns.FindByName("Case");
			if (columnCase != null && Case != Guid.Empty) {
				activity.SetColumnValue(columnCase, Case);
			}
			var columnOrder = activity.Schema.Columns.FindByName("Order");
			if (columnOrder != null && Order != Guid.Empty) {
				activity.SetColumnValue(columnOrder, Order);
			}
			var columnProject = activity.Schema.Columns.FindByName("Project");
			if (columnProject != null && Project != Guid.Empty) {
				activity.SetColumnValue(columnProject, Project);
			}
			var columnContract = activity.Schema.Columns.FindByName("Contract");
			if (columnContract != null && Contract != Guid.Empty) {
				activity.SetColumnValue(columnContract, Contract);
			}
			var columnRequests = activity.Schema.Columns.FindByName("Requests");
			if (columnRequests != null && Requests != Guid.Empty) {
				activity.SetColumnValue(columnRequests, Requests);
			}
			var columnListing = activity.Schema.Columns.FindByName("Listing");
			if (columnListing != null && Listing != Guid.Empty) {
				activity.SetColumnValue(columnListing, Listing);
			}
			var columnProperty = activity.Schema.Columns.FindByName("Property");
			if (columnProperty != null && Property != Guid.Empty) {
				activity.SetColumnValue(columnProperty, Property);
			}
			var columnChange = activity.Schema.Columns.FindByName("Change");
			if (columnChange != null && Change != Guid.Empty) {
				activity.SetColumnValue(columnChange, Change);
			}
			var columnRelease = activity.Schema.Columns.FindByName("Release");
			if (columnRelease != null && Release != Guid.Empty) {
				activity.SetColumnValue(columnRelease, Release);
			}
			var columnProblem = activity.Schema.Columns.FindByName("Problem");
			if (columnProblem != null && Problem != Guid.Empty) {
				activity.SetColumnValue(columnProblem, Problem);
			}
			activity.ProcessElementId = UId;
			activity.AllowedResult = GetResultAllowedValues();
			Guid resultColumntUId = activity.Schema.Columns.GetByName("Status").UId;
			UserConnection.IProcessEngine.AddProcessListener(activity, UId, GetConditionData(resultColumntUId, activity));
			UserConnection.IProcessEngine.LinkProcessToEntity(Owner, activity.Schema.UId, activity.Id);
			IsActivityCompleted = false;
			CurrentActivityId = activity.Id;
			return activity;
		}

		public virtual Guid GetParentProcessId() {
			Process parentProcess = Owner;
			Guid processId = parentProcess.UId;
			while(parentProcess != null){
				processId = parentProcess.UId;
				parentProcess = parentProcess.Owner;
			}
			return processId;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
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
			if (!HasMapping("Contract")) {
				writer.WriteValue("Contract", Contract, Guid.Empty);
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
			if (!HasMapping("Project")) {
				writer.WriteValue("Project", Project, Guid.Empty);
			}
			if (!HasMapping("Problem")) {
				writer.WriteValue("Problem", Problem, Guid.Empty);
			}
			if (!HasMapping("Release")) {
				writer.WriteValue("Release", Release, Guid.Empty);
			}
			if (!HasMapping("Change")) {
				writer.WriteValue("Change", Change, Guid.Empty);
			}
			if (!HasMapping("QueueItem")) {
				writer.WriteValue("QueueItem", QueueItem, Guid.Empty);
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
				case "Contract":
					Contract = reader.GetGuidValue();
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
				case "Project":
					Project = reader.GetGuidValue();
				break;
				case "Problem":
					Problem = reader.GetGuidValue();
				break;
				case "Release":
					Release = reader.GetGuidValue();
				break;
				case "Change":
					Change = reader.GetGuidValue();
				break;
				case "QueueItem":
					QueueItem = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

