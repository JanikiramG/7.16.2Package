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

	#region Class: ActivityUserTaskSchema

	/// <exclude/>
	public class ActivityUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ActivityUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ActivityUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5c726f2-af5b-4381-bac6-913074144308");
			RealUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308");
			Name = "ActivityUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.General;
			ParametersEditPageSchemaUId = new Guid("f3ad04c1-3caa-4a34-8473-46c8b9b3c60d");
			ParametersEditPageSchemaV2UId = new Guid("f771cce5-2ce8-4784-8c8d-dcf67ff3ac5d");
			DcmParametersEditPageSchemaV2UId = new Guid("89ebc3a4-2d81-431d-8342-d5c4d9cfc602");
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,80,226,42,74,45,41,45,202,83,40,41,42,77,181,86,2,0,198,62,116,56,16,0,0,0 };
			SerializeToDB = true;
			IsUserTask = true;
			IsPartial = true;
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
			Parameters.Add(CreateRequestsParameter());
			Parameters.Add(CreateListingParameter());
			Parameters.Add(CreatePropertyParameter());
			Parameters.Add(CreateContractParameter());
			Parameters.Add(CreateProjectParameter());
			Parameters.Add(CreateProblemParameter());
			Parameters.Add(CreateChangeParameter());
			Parameters.Add(CreateReleaseParameter());
			Parameters.Add(CreateQueueItemParameter());
			Parameters.Add(CreateApplicationParameter());
			Parameters.Add(CreateFinApplicationParameter());
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
					Value = @"20",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
					ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
				UId = new Guid("b29db95f-6891-4ce9-96a3-6d7e7b5f8749"),
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
				UId = new Guid("362d2e1f-0a28-4a88-99ca-1f16bbd99842"),
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
				UId = new Guid("4a0096fb-f2f6-4d1c-9607-8f2265709d0a"),
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
				UId = new Guid("e19de484-a298-481b-9e2b-720d33c05e21"),
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
				UId = new Guid("24bcfb1c-0520-4944-a512-47f36f54ce58"),
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
				UId = new Guid("daff8dea-e41f-4b62-8e59-c09ee35417e4"),
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
				UId = new Guid("f2f91371-2c72-4db6-9b37-08dd9c6cd375"),
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
				UId = new Guid("205960f5-1859-48af-a2ec-c1c321d31031"),
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
				UId = new Guid("b101bb28-fc50-4f60-af58-65a858dbb626"),
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
				UId = new Guid("3c8f0f17-098e-4907-9cb5-0203a22fa14f"),
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
				UId = new Guid("3f34876d-6ee0-45bd-8a42-7b97798b5467"),
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
				UId = new Guid("981da065-e9d9-4cbb-bdde-d29adc5f809f"),
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

		protected virtual ProcessSchemaParameter CreateQueueItemParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6d89e9bf-7034-49be-9292-71ec4fdde207"),
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

		protected virtual ProcessSchemaParameter CreateApplicationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2731d706-424e-4c79-b45b-b86e835c6689"),
				Name = "Application",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"Application",
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateFinApplicationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8e246f1d-b326-48aa-a454-e3fd322f6cf0"),
				Name = "FinApplication",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaName = @"FinApplication",
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
				UId = new Guid("82a9a7af-2490-41f7-83a9-e94e9249eb5c"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("230606fd-4856-4d73-84ab-79f1c17e11ab"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,110,211,64,16,61,219,95,177,242,201,150,146,109,172,182,161,85,8,82,19,59,85,122,128,170,9,112,64,28,22,123,105,44,28,187,236,174,83,34,20,9,202,129,3,8,16,63,192,47,68,64,165,170,45,225,23,214,127,196,236,218,37,109,154,168,146,101,237,206,188,121,51,179,111,118,71,132,33,70,121,22,11,142,154,40,161,199,200,139,2,17,165,9,97,227,251,187,89,20,86,16,23,44,74,14,31,216,78,195,28,1,250,136,48,50,220,1,204,40,18,227,54,17,244,48,101,99,136,229,193,128,14,201,99,78,89,159,240,87,120,95,193,168,160,140,227,93,42,90,227,135,176,179,173,197,56,11,72,215,214,144,252,33,103,40,255,32,47,229,76,94,228,31,229,84,254,145,103,249,23,36,127,195,246,43,146,223,228,121,126,34,207,228,79,176,207,242,247,106,13,112,189,80,208,41,56,46,180,123,42,79,229,37,146,231,114,10,174,83,249,11,208,239,52,147,37,191,231,159,228,95,197,175,185,79,242,207,150,89,116,134,200,66,81,79,72,156,81,232,200,234,108,186,237,141,250,198,122,117,115,203,175,87,189,142,235,86,183,239,185,173,106,173,230,122,245,154,191,189,190,213,174,91,13,51,122,137,236,165,167,130,123,105,198,2,170,249,202,53,106,54,209,62,75,3,202,121,79,31,216,255,115,210,168,2,132,219,105,194,133,54,56,232,173,105,172,42,240,238,164,250,223,48,39,90,57,78,99,26,136,82,230,158,222,216,25,232,5,217,18,170,69,119,176,23,113,17,37,224,112,76,195,128,58,226,108,152,204,101,59,208,147,98,85,144,213,13,173,59,16,74,112,133,193,29,150,14,111,1,148,99,47,141,18,91,253,250,227,35,138,187,80,4,131,184,197,126,138,0,63,17,106,90,32,234,209,202,122,112,151,251,175,51,18,223,30,179,235,28,215,82,20,230,162,21,252,116,64,217,146,9,93,17,122,229,190,145,183,56,140,249,232,219,75,133,3,22,117,177,44,199,65,132,151,58,52,204,140,171,81,180,149,78,225,11,255,13,13,50,145,50,208,234,166,64,216,79,120,198,168,215,154,155,108,71,207,72,25,223,245,136,32,7,148,132,20,120,84,124,33,58,46,24,105,225,177,231,25,138,96,227,120,16,197,20,217,33,195,10,81,82,26,70,249,50,224,157,48,92,152,20,236,181,148,106,96,24,81,6,173,194,94,55,215,79,85,111,64,244,172,246,220,169,64,9,234,246,247,244,61,179,93,7,110,187,97,76,76,248,38,38,163,34,99,201,213,227,211,248,7,160,123,42,66,137,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f9eddd2c-2a58-45fc-8ad9-1463ed906ff4"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("67d17315-007a-41d8-901f-6627a3074729"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9f9e1d03-37aa-47ce-a82d-515604f9da7d"),
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
			return new ActivityUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5c726f2-af5b-4381-bac6-913074144308"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ActivityUserTask(userConnection) {
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ActivityUserTaskSchemaExtension

	/// <exclude/>
	public class ActivityUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var results = new Dictionary<Guid, string>();
			var paramActivityCategory = schemaUserTask.Parameters.GetByName("ActivityCategory");
			// По умолчанию для Активности устанавливаем категорию "Выполнить"
			string activityCategoryValue = "F51C4643-58E6-DF11-971B-001D60E938C6";
			if (paramActivityCategory.SourceValue.Source == ProcessSchemaParameterValueSource.ConstValue) {
				activityCategoryValue = paramActivityCategory.SourceValue.Value;
			}
			var select = new Select(userConnection).Distinct()
					.Column("ActivityResult", "Id")
					.Column("ActivityResult", "Name")
				.From("ActivityResult")
				.Join(JoinType.Inner, "ActivityCategoryResultEntry")
				.On("ActivityResult", "Id").IsEqual("ActivityCategoryResultEntry", "ActivityResultId")
				.Where("ActivityCategoryResultEntry", "ActivityCategoryId").IsEqual(Column.Parameter(activityCategoryValue, "Guid")) as Select;
			using (var dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						results.Add(userConnection.DBTypeConverter.DBValueToGuid(dr[0]), dr.GetString(1));
					}
				}
			}
			return results;
		}

		public override void SynchronizeDynamicParameters(UserConnection userConnection, ProcessUserTaskSchema target) {
			base.SynchronizeDynamicParameters(userConnection, target);
			ProcessUserTaskUtilities.SynchronizeActivityConnectionParameters(userConnection, target);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Recommendation.Group", DescriptionResourceItem = "Parameters.Recommendation.Group")]
	[DesignModeGroup(Name = "Connected to", Position = 2, UseSolutionStorage = true, ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Lead.Group", DescriptionResourceItem = "Parameters.Lead.Group")]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityCategory", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.ActivityCategory.Caption", DescriptionResourceItem = "Parameters.ActivityCategory.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duration", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Duration.Caption", DescriptionResourceItem = "Parameters.Duration.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DurationPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.DurationPeriod.Caption", DescriptionResourceItem = "Parameters.DurationPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartIn", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.StartIn.Caption", DescriptionResourceItem = "Parameters.StartIn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartInPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.StartInPeriod.Caption", DescriptionResourceItem = "Parameters.StartInPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBefore", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.RemindBefore.Caption", DescriptionResourceItem = "Parameters.RemindBefore.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBeforePeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.RemindBeforePeriod.Caption", DescriptionResourceItem = "Parameters.RemindBeforePeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowInScheduler", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.ShowInScheduler.Caption", DescriptionResourceItem = "Parameters.ShowInScheduler.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Lead", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Lead.Caption", DescriptionResourceItem = "Parameters.Lead.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Account", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Account.Caption", DescriptionResourceItem = "Parameters.Account.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Opportunity", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Opportunity.Caption", DescriptionResourceItem = "Parameters.Opportunity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Invoice", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Invoice.Caption", DescriptionResourceItem = "Parameters.Invoice.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Document", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Document.Caption", DescriptionResourceItem = "Parameters.Document.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Incident", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Incident.Caption", DescriptionResourceItem = "Parameters.Incident.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Case", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Case.Caption", DescriptionResourceItem = "Parameters.Case.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityResult", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.ActivityResult.Caption", DescriptionResourceItem = "Parameters.ActivityResult.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentActivityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.CurrentActivityId.Caption", DescriptionResourceItem = "Parameters.CurrentActivityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActivityCompleted", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.IsActivityCompleted.Caption", DescriptionResourceItem = "Parameters.IsActivityCompleted.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExecutionContext", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.ExecutionContext.Caption", DescriptionResourceItem = "Parameters.ExecutionContext.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Order", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Order.Caption", DescriptionResourceItem = "Parameters.Order.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Requests", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Requests.Caption", DescriptionResourceItem = "Parameters.Requests.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Listing", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Listing.Caption", DescriptionResourceItem = "Parameters.Listing.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Property", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Property.Caption", DescriptionResourceItem = "Parameters.Property.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contract", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Contract.Caption", DescriptionResourceItem = "Parameters.Contract.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Project", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Project.Caption", DescriptionResourceItem = "Parameters.Project.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Problem", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Problem.Caption", DescriptionResourceItem = "Parameters.Problem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Change", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Change.Caption", DescriptionResourceItem = "Parameters.Change.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Release", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Release.Caption", DescriptionResourceItem = "Parameters.Release.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "QueueItem", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.QueueItem.Caption", DescriptionResourceItem = "Parameters.QueueItem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Application", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.Application.Caption", DescriptionResourceItem = "Parameters.Application.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "FinApplication", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b5c726f2af5b4381bac6913074144308", CaptionResourceItem = "Parameters.FinApplication.Caption", DescriptionResourceItem = "Parameters.FinApplication.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class ActivityUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ActivityUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308");
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

		public virtual Guid ActivityCategory {
			get;
			set;
		}

		public virtual Guid OwnerId {
			get;
			set;
		}

		private int _duration = 20;
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

		public virtual Guid QueueItem {
			get;
			set;
		}

		public virtual Guid Application {
			get;
			set;
		}

		public virtual Guid FinApplication {
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
			if (!HasMapping("QueueItem")) {
				writer.WriteValue("QueueItem", QueueItem, Guid.Empty);
			}
			if (!HasMapping("Application")) {
				writer.WriteValue("Application", Application, Guid.Empty);
			}
			if (!HasMapping("FinApplication")) {
				writer.WriteValue("FinApplication", FinApplication, Guid.Empty);
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
				case "QueueItem":
					QueueItem = reader.GetGuidValue();
				break;
				case "Application":
					Application = reader.GetGuidValue();
				break;
				case "FinApplication":
					FinApplication = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

