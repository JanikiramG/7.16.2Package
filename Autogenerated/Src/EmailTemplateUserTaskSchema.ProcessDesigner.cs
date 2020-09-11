namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using ProcessDesigner = Terrasoft.Configuration.ProcessDesigner;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Globalization;
	using System.Linq;
	using System.Runtime.Serialization.Formatters;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Mail.Sender;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: EmailTemplateUserTaskSchema

	/// <exclude/>
	public class EmailTemplateUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public EmailTemplateUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19");
			RealUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19");
			Name = "EmailTemplateUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.General;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = new Guid("562c3d08-766b-4c9c-8112-177d266d63e7");
			DcmParametersEditPageSchemaV2UId = new Guid("e2798191-2960-4650-b387-efda1b07d965");
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,80,74,202,207,207,81,40,74,45,46,205,41,81,176,85,72,75,204,41,78,181,230,42,46,207,44,73,206,208,208,8,40,202,79,78,45,46,118,73,45,206,76,207,75,45,210,11,78,205,75,113,205,77,204,204,9,169,44,72,213,68,229,41,84,115,113,38,39,22,167,42,224,213,164,231,88,90,146,111,197,197,201,9,183,82,1,36,2,87,163,161,105,13,148,76,42,74,77,204,182,38,202,60,223,196,188,210,196,28,20,19,33,66,8,35,147,243,243,74,82,43,74,144,77,174,181,230,42,74,45,41,45,202,131,122,221,90,9,0,212,138,59,38,10,1,0,0 };
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
			Parameters.Add(CreateActivityResultParameter());
			Parameters.Add(CreateIncidentParameter());
			Parameters.Add(CreateCaseParameter());
			Parameters.Add(CreateActivityIdParameter());
			Parameters.Add(CreateIsActivityCompletedParameter());
			Parameters.Add(CreateExecutionContextParameter());
			Parameters.Add(CreateInformationOnStepParameter());
			Parameters.Add(CreateOrderParameter());
			Parameters.Add(CreateContractParameter());
			Parameters.Add(CreatePropertyParameter());
			Parameters.Add(CreateListingParameter());
			Parameters.Add(CreateRequestsParameter());
			Parameters.Add(CreateProjectParameter());
			Parameters.Add(CreateProblemParameter());
			Parameters.Add(CreateChangeParameter());
			Parameters.Add(CreateReleaseParameter());
			Parameters.Add(CreateQueueItemParameter());
			Parameters.Add(CreateSenderParameter());
			Parameters.Add(CreateImportanceParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateIgnoreErrorsParameter());
			Parameters.Add(CreateSendEmailTypeParameter());
			Parameters.Add(CreateBodyTemplateTypeParameter());
			Parameters.Add(CreateEmailTemplateIdParameter());
			Parameters.Add(CreateEmailTemplateEntityIdParameter());
			Parameters.Add(CreateBodyParameter());
			Parameters.Add(CreateBodyConfigParameter());
		}

		protected virtual ProcessSchemaParameter CreateRecommendationParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0222ed95-9f70-49d7-8d75-e219a7cc47d2"),
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
				UId = new Guid("5d4e5f6b-3859-465c-9009-ab954203ddba"),
				Name = "ActivityCategory",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.961e2086-a12b-4d27-b095-40b1e64d6cc0.8038a396-7825-e011-8165-00155d043204#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("c607553c-af04-4d5a-9be3-52d2289ed1bb"),
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
				UId = new Guid("4e951b83-3f3a-4f07-84db-c18a37ff1cb4"),
				Name = "Duration",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"5",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("5ba4fe85-fe56-41a8-bb7a-b6eb9cb7b0b3"),
				Name = "DurationPeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("9a04bd1e-135d-41a8-ace4-573cecc38492"),
				Name = "StartIn",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("aa8c62b7-1e23-42c3-9f6f-12d00fdd649f"),
				Name = "StartInPeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("ea9fa37f-9983-4da4-a42a-33258432ee3c"),
				Name = "RemindBefore",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("8141d6fd-9d55-455b-a28f-7cdf7e0c965b"),
				Name = "RemindBeforePeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("597c84ef-46ad-4061-a400-e2a212632562"),
				Name = "ShowInScheduler",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("0ebcc14f-e89c-4c15-be9f-435687de293d"),
				Name = "ShowExecutionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				UId = new Guid("5273dca7-70cb-4dd7-a4b9-122892cb2eb1"),
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
				UId = new Guid("13c9aa2d-f118-4c69-bcc2-626174702f48"),
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
				UId = new Guid("6eaedb21-2322-49f9-bae0-793620616856"),
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
				UId = new Guid("7db0c409-fdf5-404c-87ea-c31f2e334528"),
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
				UId = new Guid("7590bd23-7352-46a0-8b0b-80237b699da1"),
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
				UId = new Guid("7de5dab3-4224-4615-8e8b-f7de0ffbba7e"),
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

		protected virtual ProcessSchemaParameter CreateActivityResultParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("2e4cbd70-f7b5-4144-9b71-cd3ce531bdb2"),
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

		protected virtual ProcessSchemaParameter CreateIncidentParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("560a6088-1e48-497f-a31c-fc2763015bd5"),
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
				UId = new Guid("865a3d6a-4bc6-41f2-b816-1491c67d8cfe"),
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

		protected virtual ProcessSchemaParameter CreateActivityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("66b32bce-fc66-441c-9439-1248771b01ac"),
				Name = "ActivityId",
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
				UId = new Guid("0459be9f-de4f-4674-8c67-87cc7d2d0419"),
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
				UId = new Guid("addfa63c-9ff3-4256-b226-2905a0f6c475"),
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
				UId = new Guid("c37dbb20-6ed1-4699-ace1-e0a88b5bfd44"),
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
				UId = new Guid("529ab2fb-59d7-4de0-bee6-0a0b9b7f79da"),
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

		protected virtual ProcessSchemaParameter CreatePropertyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f12f023b-dbb0-494b-acab-d2f2869eb396"),
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

		protected virtual ProcessSchemaParameter CreateListingParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("67d97045-ecbb-4960-bf0c-47c0bf70dd6a"),
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

		protected virtual ProcessSchemaParameter CreateRequestsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("39b0b2dc-8756-4724-875e-7a09ae726f2f"),
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

		protected virtual ProcessSchemaParameter CreateProjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0141e241-8397-41dd-892c-206f7ff195dd"),
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
				UId = new Guid("ddbadd8c-4432-4fba-8571-966bf8875805"),
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
				UId = new Guid("2b2f8115-6d2a-4027-95b9-77a8d2f25b5c"),
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
				UId = new Guid("7ce22bdc-e676-475f-a4dc-51bcc372b76d"),
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
				UId = new Guid("7bf99f91-0c7a-414a-a1cc-89f047b8d978"),
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

		protected virtual ProcessSchemaParameter CreateSenderParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("dbbe08ab-3ea9-4104-9be8-8d76a7dfd2b3"),
				Name = "Sender",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateImportanceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bcee98ff-66da-4a9f-b6c4-887247ec2e5b"),
				Name = "Importance",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"1",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c86fee83-f221-48e1-91af-b96730c70411"),
				Name = "Subject",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIgnoreErrorsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("cd55806c-be67-452b-a729-3d51d37bfb5c"),
				Name = "IgnoreErrors",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSendEmailTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("781f088f-b617-47f9-bfce-7f7a759e1bef"),
				Name = "SendEmailType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateBodyTemplateTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6ef6cd7d-c2cc-40de-984a-e0fad55ebf86"),
				Name = "BodyTemplateType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailTemplateIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("6b992b79-6228-42d8-97a8-75e14f6f59cb"),
				Name = "EmailTemplateId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailTemplateEntityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("1e6be52c-a9d5-43c5-9fa8-f045f2842347"),
				Name = "EmailTemplateEntityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateBodyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("54c88afb-c624-414b-8a0f-d0de606db991"),
				Name = "Body",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = true
			};
		}

		protected virtual ProcessSchemaParameter CreateBodyConfigParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d0812391-61c2-4df5-b377-8f13a059b4a1"),
				Name = "BodyConfig",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetActivityTypeMethod());
			Methods.Add(CreateNewDateMethod());
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateGetConditionDataMethod());
			Methods.Add(CreateGetActivityTitleMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateGetActivityEntitySchemaUIdMethod());
			Methods.Add(CreateCreateActivityMethod());
			Methods.Add(CreateGetParentProcessIdMethod());
			Methods.Add(CreateManualSendEmailMethod());
			Methods.Add(CreateAutoSendEmailMethod());
			Methods.Add(CreateGetSenderNameMethod());
			Methods.Add(CreateGetEmailAddressCollectionMethod());
			Methods.Add(CreateSendEmailWithDefaultSenderMethod());
			Methods.Add(CreateGetEmailAddressesMethod());
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
		}

		protected override void InitializeUsings() {
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
				UId = new Guid("792b72bc-d124-414c-9dbb-e192c85da525"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d171e6ed-5a2d-4058-899a-3f485c0371f8"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9062ffbb-e5ac-442d-9cdc-100d3e1a8a83"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdc5f976-dfbc-4f8e-8996-52b5cba48caa"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6544d19-4797-4e4e-828c-af3a095d1fbe"),
				Name = "Terrasoft.Configuration.ProcessDesigner",
				Alias = "ProcessDesigner",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9e14ce7a-39fa-43c0-8a93-25f618798b88"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a4f5e52b-300b-4132-921a-1e5d82a2f4c8"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e54f1f96-3cc7-460a-b543-26ace1e2b815"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("9699e90c-76f3-4dce-bcc0-7af30750695e")
			});
		}

		protected virtual SchemaMethod CreateGetActivityTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ffd6b283-f645-4423-a432-351c970169ad"),
				Name = "GetActivityType",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,79,193,78,196,32,20,60,195,87,16,78,112,33,222,27,15,110,91,77,111,198,93,245,96,60,224,242,86,73,40,172,15,168,54,102,255,93,186,52,217,104,66,2,243,134,153,55,179,5,7,251,196,98,189,174,25,37,30,190,216,246,12,197,99,4,108,131,247,229,109,131,151,138,18,210,6,151,71,47,248,96,248,25,147,91,12,163,224,55,229,199,100,211,188,155,143,176,18,228,249,3,16,4,111,131,89,70,67,236,63,179,118,162,26,168,123,141,122,132,4,40,120,63,106,235,184,148,148,232,184,110,110,104,142,214,191,51,49,105,100,230,173,255,134,125,78,1,75,190,191,145,84,239,99,70,232,54,151,145,144,146,253,80,178,234,135,78,39,253,0,218,64,241,89,244,181,168,170,142,80,25,113,217,80,197,196,30,152,48,168,22,122,245,35,4,33,101,244,255,3,116,155,165,114,25,76,128,165,77,193,79,218,101,216,133,187,108,77,241,120,185,122,149,77,145,159,104,57,39,186,154,44,164,234,199,99,154,155,95,198,43,103,211,129,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNewDateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5013ad1f-a250-4a30-8194-2455d8730194"),
				Name = "NewDate",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DateTime"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("da42dbdb-c00e-449b-8ce0-04fb7b2c0f60"),
				Name = "oldDate",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1d89073-c6b5-45ed-a34a-64478b333aa9"),
				Name = "offset",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0fdc8547-0a82-489a-aefb-05d0bc59bbcb"),
				Name = "offsetPeriod",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessDurationPeriod",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,208,49,11,194,48,16,134,225,57,253,21,25,173,67,215,130,78,66,6,151,66,55,231,144,92,104,176,228,224,238,66,17,241,191,87,107,193,41,182,243,251,241,112,28,79,81,220,112,192,16,24,164,7,138,232,107,253,172,148,135,96,243,40,167,74,57,203,160,123,66,7,204,38,147,149,136,233,59,108,186,152,178,0,191,71,138,64,50,37,141,163,55,86,160,185,120,191,198,149,174,207,127,165,43,102,42,56,75,218,167,24,251,40,32,159,178,207,184,1,220,183,145,99,187,193,116,152,100,40,125,102,105,191,115,94,51,179,171,30,60,133,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("230606fd-4856-4d73-84ab-79f1c17e11ab"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,95,79,194,48,16,127,238,62,69,179,167,46,33,141,62,35,38,194,38,193,7,53,64,244,193,248,80,217,5,154,140,86,175,45,72,12,223,221,110,29,110,2,130,201,178,117,119,247,251,211,246,110,37,144,34,24,87,88,218,163,10,214,52,149,51,43,181,18,184,185,26,58,153,119,168,177,40,213,252,154,37,221,136,76,160,128,153,165,38,124,122,52,34,37,36,68,153,51,128,3,173,20,84,4,9,79,165,177,82,249,68,18,17,194,7,186,112,75,197,226,27,159,93,73,187,25,87,162,113,135,198,163,60,62,83,113,47,150,16,106,110,81,47,15,42,170,204,157,150,138,149,175,233,230,29,248,200,219,64,143,220,85,14,132,133,185,198,26,145,41,139,155,10,70,248,195,159,158,248,200,100,31,78,20,236,36,75,75,36,132,119,219,249,159,161,35,46,206,168,236,210,167,45,182,15,246,180,147,50,120,194,69,188,87,122,92,182,34,105,36,9,127,94,0,194,97,126,160,115,104,225,195,149,243,71,129,254,134,45,32,139,179,165,144,69,156,120,18,97,234,198,234,70,206,248,14,164,44,237,103,159,48,115,86,35,205,223,126,150,61,250,187,241,120,166,140,67,72,251,77,136,37,9,253,138,72,77,51,74,133,21,99,16,57,120,158,102,217,171,219,154,7,102,8,97,214,40,5,18,178,94,200,2,40,107,144,188,252,212,18,132,132,97,226,55,121,190,55,16,60,237,151,167,224,3,43,64,191,87,255,255,36,10,7,83,93,206,89,139,239,229,226,53,233,180,156,241,33,216,73,53,132,236,50,41,167,144,108,35,255,108,35,4,235,80,213,227,219,253,6,40,206,14,166,202,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3a3f999b-6f6c-416e-86fb-7e1589bb39df"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a1f660e0-d13e-44e9-95f3-68c276b73956"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,151,205,142,219,32,20,133,215,228,41,220,172,18,169,138,186,143,178,72,59,233,104,164,81,167,154,153,118,83,117,65,236,155,12,149,13,46,63,105,71,213,188,123,193,128,141,205,141,228,37,248,240,113,14,87,185,16,118,42,86,79,192,171,67,67,89,253,252,218,66,177,219,21,43,198,245,250,171,20,37,40,117,3,138,157,57,200,205,72,181,217,27,45,214,197,191,5,145,160,141,228,197,145,42,216,124,18,77,91,131,134,195,95,40,141,102,252,188,106,169,164,141,157,145,106,189,93,188,45,46,84,22,180,212,236,194,244,107,177,43,134,175,63,62,252,44,168,42,158,65,74,170,196,73,91,20,63,177,179,145,84,51,193,55,251,176,102,187,96,214,239,64,216,21,220,212,117,234,227,68,107,5,110,171,135,63,214,244,93,101,119,137,242,77,152,218,118,54,74,81,155,134,223,3,29,73,158,202,23,104,168,221,221,125,84,155,207,140,87,31,95,191,88,147,171,165,147,46,215,222,65,178,248,93,226,65,28,127,65,169,139,122,2,189,5,237,129,223,105,109,32,89,108,105,196,225,234,41,136,4,95,171,91,195,170,181,251,108,149,111,54,213,190,44,133,225,58,165,135,41,151,203,30,154,182,243,233,215,48,53,78,253,208,182,66,106,195,125,21,230,132,79,86,140,207,32,69,33,71,33,240,157,208,19,73,80,241,96,196,21,58,25,39,240,199,148,136,195,105,13,137,239,248,69,176,18,102,166,13,234,113,210,136,64,82,178,156,142,38,12,136,152,142,33,68,50,56,245,169,130,40,75,244,32,43,144,115,171,231,180,147,186,117,203,177,138,77,185,120,173,156,170,175,82,198,34,209,93,168,140,27,101,9,108,131,233,118,156,151,33,168,199,41,34,2,201,209,230,116,52,73,64,196,44,45,66,36,131,83,159,39,140,179,68,238,199,38,233,236,72,81,62,206,212,67,144,80,37,178,1,154,42,66,98,172,18,131,146,196,175,15,22,101,89,178,27,81,154,6,248,220,100,81,62,78,214,67,144,100,21,178,1,154,44,66,98,178,10,131,146,196,175,79,22,101,89,178,71,248,109,64,105,53,51,89,148,143,147,245,16,36,153,68,54,64,147,69,72,76,38,49,40,73,252,250,100,81,150,37,187,103,202,221,193,115,175,55,175,158,220,112,1,129,93,114,57,29,191,231,188,174,191,234,16,34,25,156,134,11,207,143,177,142,209,130,156,125,105,69,121,214,51,60,4,111,26,217,6,215,186,70,39,76,218,70,14,37,137,95,31,44,202,66,178,180,117,188,80,126,158,123,63,121,241,164,109,120,0,214,52,50,52,222,50,58,89,223,48,114,28,233,61,134,102,209,13,177,34,29,107,104,230,215,200,169,179,18,117,8,188,66,83,250,181,2,57,93,82,159,140,72,6,167,125,117,220,24,105,17,246,5,166,230,22,39,168,167,13,194,35,208,254,144,209,175,180,135,78,55,116,135,156,72,6,167,177,55,116,227,254,241,232,249,143,160,76,61,234,180,126,198,61,18,239,84,84,197,199,188,123,135,106,105,44,228,40,68,109,237,134,197,115,94,252,195,121,141,19,45,195,159,139,131,61,110,112,111,215,229,123,159,34,89,242,77,193,190,106,24,127,100,231,151,174,221,133,167,253,192,164,23,88,217,21,225,229,239,141,109,255,3,173,44,185,247,209,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConditionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1625969-4540-44ac-a347-68cb2f7b00ce"),
				Name = "GetConditionData",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
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
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6505ca01-33b7-4878-aace-a60cb6f48f8b"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				ModifiedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,142,189,10,194,64,16,132,107,243,20,87,38,32,247,2,33,133,196,20,130,133,248,243,0,103,50,134,5,179,23,118,247,196,32,190,187,17,98,97,51,197,124,195,204,208,205,229,39,112,215,12,129,238,231,105,132,171,42,151,19,91,113,144,216,66,117,11,165,158,33,254,47,229,55,201,98,225,94,217,234,26,20,190,14,220,226,222,60,209,38,35,238,243,49,72,24,96,16,45,202,108,37,176,36,92,102,239,236,162,144,58,50,163,53,138,236,151,137,134,123,98,248,35,134,248,192,102,70,15,178,105,97,123,82,195,60,159,215,73,4,108,63,188,235,214,238,242,149,159,49,215,170,233,242,4,221,201,130,37,157,19,69,249,1,141,247,153,99,227,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("19abe264-1495-47e8-b482-c3b289d792f1"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,209,106,194,64,16,69,159,205,87,44,62,37,16,242,1,21,41,169,13,69,40,26,140,246,125,155,140,118,233,102,55,236,78,170,182,248,239,157,221,36,182,42,165,47,9,204,61,51,115,247,142,216,178,176,0,85,101,53,23,114,125,108,128,77,167,44,20,10,163,220,232,18,172,125,4,43,118,10,76,114,65,37,105,139,58,98,95,193,200,0,182,70,49,139,70,168,93,146,213,13,30,39,193,41,232,203,5,24,193,165,248,132,181,46,60,17,42,216,187,182,134,166,103,114,51,175,216,148,209,55,14,70,138,215,180,156,45,232,23,119,58,109,247,122,239,100,99,193,172,185,125,223,160,144,2,5,216,228,9,48,231,6,20,230,3,29,46,247,228,53,162,1,194,246,197,236,0,101,139,80,61,28,11,122,8,151,52,208,67,201,252,47,226,103,253,162,243,212,241,189,51,90,39,240,88,148,111,80,243,94,31,167,37,138,15,170,142,99,23,72,169,235,154,194,226,40,180,34,149,92,14,250,90,160,132,208,219,83,91,109,106,143,44,85,129,208,16,248,172,75,151,21,127,149,208,133,69,22,23,173,148,75,227,99,13,231,215,61,17,187,103,138,0,118,199,110,180,228,133,203,214,39,201,119,224,78,230,163,100,131,147,153,86,22,109,114,62,104,119,3,222,171,43,122,131,169,124,199,172,53,46,225,161,207,99,224,3,163,85,52,5,225,128,132,101,87,37,119,80,250,229,191,206,60,190,40,120,123,46,47,46,165,222,67,181,2,219,74,180,255,156,59,237,224,244,236,211,55,133,142,165,197,10,74,103,33,190,53,29,5,167,104,242,13,243,200,105,47,236,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityEntitySchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("30dafa17-3650-4588-819d-e413ad351d24"),
				Name = "GetActivityEntitySchemaUId",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,76,46,201,44,203,44,169,116,206,207,43,46,41,214,131,113,93,243,74,128,100,112,114,70,106,110,98,168,103,138,53,0,165,56,27,204,46,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateActivityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("70e5e65b-bf05-4152-9cf4-709d1e3410dd"),
				Name = "CreateActivity",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Terrasoft.Configuration.Activity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,87,193,110,219,56,20,60,39,95,161,230,80,216,5,45,216,77,211,102,97,244,144,218,110,107,32,109,138,196,217,187,86,122,118,184,43,145,46,69,197,48,22,249,247,125,164,72,154,164,225,172,116,178,244,56,51,28,61,142,41,234,57,19,73,150,75,250,76,229,62,249,156,48,216,37,43,16,34,171,249,90,166,51,206,214,116,211,136,76,82,206,210,27,3,27,60,214,32,112,136,65,174,234,195,233,185,21,72,31,64,206,97,61,227,101,83,177,63,179,178,129,122,224,15,47,11,156,226,91,67,139,244,39,236,212,111,48,186,218,111,65,35,236,68,56,71,45,235,116,81,101,180,84,131,143,203,194,131,255,128,186,206,54,112,138,117,215,200,13,167,108,227,216,1,121,69,101,9,202,12,72,203,211,165,192,208,131,204,132,156,103,82,1,209,176,186,138,158,61,157,53,66,0,147,170,154,162,150,185,85,200,21,173,80,141,36,90,100,201,72,50,248,37,120,142,158,231,166,159,191,64,80,94,12,205,184,185,243,102,159,55,16,205,125,108,140,36,86,237,164,126,116,59,61,167,235,100,224,122,133,26,27,46,246,233,226,119,147,149,245,64,175,205,162,218,202,253,112,248,239,249,89,12,51,1,209,43,119,113,61,190,188,190,185,252,227,227,232,211,245,251,171,209,98,60,153,140,174,39,31,175,70,227,241,228,234,106,62,254,112,249,126,252,225,2,231,123,57,60,82,172,23,174,155,41,250,11,240,196,119,75,246,144,63,65,209,148,32,16,28,85,60,236,61,228,176,165,216,124,68,185,107,111,124,198,183,123,31,19,220,123,184,47,37,101,69,12,62,46,250,12,94,168,206,168,159,116,197,31,164,192,212,133,177,175,191,203,170,52,48,41,26,104,23,225,110,199,64,96,11,222,152,255,68,219,247,4,251,238,152,22,242,57,49,87,211,243,51,69,189,135,10,13,125,129,53,23,160,248,99,77,59,243,154,161,198,87,92,179,220,164,167,0,29,98,54,154,36,239,18,127,214,147,121,243,65,46,115,103,47,24,131,103,220,106,114,189,53,220,66,166,158,233,48,17,174,103,149,165,237,190,81,167,95,149,192,254,103,134,127,160,11,5,189,48,169,245,200,248,204,172,41,203,228,237,219,196,222,159,234,33,238,73,222,134,228,137,16,77,213,9,109,255,19,57,111,112,181,95,145,50,16,19,91,125,109,217,184,39,72,196,189,198,54,16,205,54,215,211,160,45,119,219,45,23,178,97,237,86,220,165,59,30,35,108,146,47,229,245,42,42,247,106,153,199,37,190,208,48,124,136,57,207,155,170,253,215,116,121,2,11,15,237,59,17,207,187,95,235,101,220,18,137,147,136,44,47,217,51,167,57,116,116,108,208,161,97,43,225,249,245,74,189,236,26,30,177,2,145,217,89,86,119,117,170,160,161,77,77,246,60,218,251,94,6,21,137,104,106,100,237,78,20,122,183,233,148,92,133,141,50,171,233,126,90,109,161,95,78,21,139,180,228,200,32,238,88,127,227,139,187,163,69,131,14,77,90,9,207,166,87,234,101,212,240,136,21,136,23,26,183,8,145,117,118,107,225,209,130,91,17,127,209,189,90,191,133,55,68,226,36,34,203,247,240,27,143,124,178,238,104,217,194,67,203,78,196,179,236,215,122,89,182,68,226,36,34,203,183,180,150,248,190,238,250,54,106,209,209,11,201,72,248,239,164,67,169,223,107,169,229,17,43,112,156,223,45,136,206,111,7,11,63,74,112,43,18,70,216,213,250,102,88,19,137,147,208,150,253,24,63,101,108,211,121,199,210,224,40,194,173,128,31,96,87,233,23,95,77,35,134,126,20,221,18,186,239,172,6,29,7,183,149,8,114,235,74,61,99,171,121,196,10,28,231,224,175,18,170,238,49,80,232,163,20,104,137,48,4,182,212,55,3,138,71,172,64,120,230,55,167,196,5,14,128,57,58,133,223,113,55,101,201,119,80,220,67,221,148,178,253,36,107,175,205,192,225,59,82,185,74,132,30,107,93,200,199,229,107,231,72,84,178,61,192,163,172,108,112,163,73,245,220,209,71,156,181,200,54,148,65,122,83,20,166,160,254,132,128,231,99,119,34,38,202,58,81,14,145,93,80,69,198,227,113,54,136,61,17,103,105,56,252,159,217,110,41,251,199,84,86,124,193,164,250,190,214,135,114,114,244,88,129,48,126,75,163,244,178,62,124,245,86,219,18,36,168,126,172,241,83,14,143,251,230,99,212,34,194,86,169,54,8,144,141,96,174,54,253,15,173,173,151,85,12,16,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetParentProcessIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bfd10958-b016-4f47-a663-75b2e752aa62"),
				Name = "GetParentProcessId",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,86,40,72,44,74,205,43,9,128,242,108,21,252,203,243,82,139,172,185,220,75,51,83,20,10,32,162,158,41,64,113,20,117,122,161,158,41,214,92,229,25,153,57,169,26,168,6,40,218,42,228,149,230,228,104,86,115,113,18,208,205,137,110,51,170,26,168,59,106,185,138,82,75,74,139,242,16,110,177,6,0,233,89,27,175,186,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateManualSendEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9211d642-ac2a-4319-ab2c-f0bcd1c4f484"),
				Name = "ManualSendEmail",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("688a0d4a-e16e-495f-bae4-d78515d5aea0"),
				Name = "context",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Var,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,193,110,131,64,12,68,207,240,21,230,18,129,132,248,1,196,33,66,40,226,22,149,162,158,183,96,130,85,178,75,119,189,105,162,138,127,239,2,37,173,90,245,208,235,120,198,243,108,234,32,172,88,176,53,144,101,112,212,170,65,99,86,33,41,180,86,58,130,119,223,35,231,202,173,214,40,121,223,48,93,136,111,101,59,7,14,150,218,164,56,143,124,131,221,14,130,207,124,109,80,63,10,243,82,51,13,196,132,38,57,32,151,102,139,230,26,5,99,27,206,182,92,73,137,78,87,50,134,186,108,163,165,206,219,119,140,122,179,87,226,130,85,163,105,228,226,138,141,101,12,215,5,219,60,140,162,212,247,38,127,242,159,149,26,128,204,131,149,146,228,9,50,8,126,65,39,197,171,21,131,9,191,192,163,133,252,27,157,58,143,3,58,190,212,159,207,14,238,251,22,180,255,147,77,254,159,95,41,165,91,38,26,126,34,238,231,105,200,61,153,24,26,229,244,43,187,135,252,120,208,29,37,134,170,87,111,107,169,155,28,197,9,93,147,70,182,90,66,231,238,195,244,3,240,215,71,183,217,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAutoSendEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ba7bf55c-046b-45fb-85ac-c7656cc83b71"),
				Name = "AutoSendEmail",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,221,78,195,48,12,133,175,215,167,8,187,106,165,105,47,176,31,105,43,29,154,4,8,49,16,215,89,234,117,65,109,50,57,41,211,132,250,238,216,109,17,217,134,224,42,201,113,108,31,127,137,222,137,248,25,20,28,52,24,47,102,51,97,234,178,76,196,103,52,64,240,53,26,225,177,134,73,212,68,31,18,197,14,109,37,102,226,14,252,6,76,14,248,40,43,136,187,109,50,137,238,181,243,83,231,81,155,98,46,240,187,166,235,18,178,74,234,114,145,231,8,206,129,251,105,73,121,92,25,56,252,132,218,162,246,39,202,136,179,80,72,214,213,193,162,151,70,193,69,27,165,168,146,254,163,81,106,15,167,176,217,89,246,246,223,244,101,169,77,126,89,131,13,87,20,151,5,80,146,129,163,104,179,30,122,137,216,173,58,80,204,107,20,13,94,44,237,127,128,144,178,169,183,239,160,136,183,232,119,164,45,109,206,147,243,66,167,128,197,25,27,10,165,138,196,208,57,39,43,22,207,230,137,154,73,164,233,117,217,196,120,237,178,234,224,79,113,210,62,45,63,89,107,249,77,251,253,45,236,100,93,246,47,26,247,115,209,148,191,125,128,214,74,90,114,253,149,84,222,34,251,75,75,233,92,127,28,19,194,105,118,117,107,30,51,165,212,26,34,95,179,178,192,162,174,40,30,15,107,7,72,1,67,16,180,53,67,154,229,245,76,73,194,31,210,153,12,161,247,182,175,141,141,196,69,157,73,228,201,46,77,31,84,26,243,18,204,220,8,37,189,218,243,45,70,119,179,118,235,194,88,132,12,209,162,107,217,13,252,30,237,145,240,52,196,36,68,244,5,113,209,177,38,74,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSenderNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("48b23bfd-d6e3-4850-a027-7d0db828902a"),
				Name = "GetSenderName",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2b47fa5e-515d-4a51-98b1-228a93187eea"),
				Name = "mailboxId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,207,75,195,48,20,62,219,191,34,228,148,194,40,187,79,7,82,170,236,48,113,116,234,65,60,100,237,115,11,164,47,243,37,153,22,241,127,55,49,21,36,234,245,125,239,251,121,146,196,6,169,244,206,188,109,229,78,67,211,110,216,5,67,120,101,13,58,229,198,182,59,192,32,55,30,104,20,119,22,168,54,136,208,57,101,176,250,249,176,150,40,247,64,51,198,215,73,172,29,177,107,193,57,133,123,203,203,69,113,10,62,22,176,7,106,162,221,101,223,19,88,91,27,237,7,12,134,89,132,42,224,9,19,188,253,197,138,122,57,225,74,105,7,100,35,81,228,88,77,32,29,164,143,7,229,14,183,146,228,0,241,93,164,99,109,134,163,36,101,13,110,199,35,84,205,139,151,58,84,89,245,124,246,157,108,213,151,83,139,233,240,213,94,129,253,35,252,53,184,180,77,168,160,211,88,217,118,65,74,61,51,145,73,85,181,241,232,216,146,205,75,246,94,156,17,56,79,152,251,61,206,159,162,65,12,58,77,116,47,181,135,115,235,40,108,189,20,255,141,92,221,132,206,193,247,163,152,116,57,95,20,159,251,58,171,113,254,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailAddressCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6399aace-6106-42db-8c15-a33ec63050b6"),
				Name = "GetEmailAddressCollection",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "EmailAddressCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8891e540-592e-43b5-b75a-efd2936d9afb"),
				Name = "emailAddresses",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IEnumerable<string>",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,205,77,204,204,113,76,73,41,74,45,46,118,206,207,201,73,77,46,201,204,207,83,176,85,200,75,45,87,112,197,42,169,161,105,205,149,150,95,148,154,152,156,161,160,81,134,102,134,66,102,30,10,63,181,88,83,161,154,139,19,187,53,122,64,17,13,100,41,160,201,181,92,69,169,37,165,69,121,56,92,102,13,0,101,53,250,1,181,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSendEmailWithDefaultSenderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7ec32900-0f19-429f-a62c-47945cd4d963"),
				Name = "SendEmailWithDefaultSender",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("91c0783e-3e70-4446-8bc3-1857a7aada6e"),
				Name = "emailMessage",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EmailMessage",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,77,107,227,48,16,134,207,241,175,208,250,36,131,48,123,119,91,104,188,161,219,67,150,128,211,94,74,15,178,60,73,181,200,82,25,201,27,204,146,255,190,163,196,78,157,210,30,10,89,48,254,24,141,158,119,230,245,104,41,181,41,17,26,176,65,75,227,153,154,188,95,51,11,59,182,124,151,241,55,153,253,116,62,208,42,247,1,181,221,102,107,64,148,222,109,66,94,58,4,186,217,141,222,118,40,131,118,54,175,122,95,65,8,148,231,243,59,8,143,210,116,192,31,60,32,165,89,80,49,71,176,180,106,195,107,164,166,153,72,102,43,135,17,175,109,200,87,18,61,240,11,9,68,110,154,229,107,87,29,234,230,89,20,163,204,202,155,216,77,237,156,185,84,47,11,43,107,19,193,233,160,129,191,100,11,151,247,108,36,159,100,86,210,251,157,195,230,255,72,141,244,52,75,246,69,114,228,63,61,179,224,72,14,90,26,148,37,120,47,183,64,30,211,117,75,186,61,207,138,100,17,151,110,155,6,105,181,116,198,28,185,76,41,218,70,162,31,47,243,51,96,169,62,231,212,95,1,205,85,36,253,145,200,60,53,85,26,77,115,61,76,122,117,10,188,115,128,54,44,223,16,172,29,158,215,19,68,78,71,68,6,24,82,248,220,53,189,96,85,87,255,38,130,32,131,196,244,100,229,227,111,19,73,192,14,196,65,253,135,62,104,73,236,175,238,58,221,8,182,238,94,13,92,213,125,128,167,103,193,142,102,223,220,240,239,25,149,211,158,108,161,42,148,122,11,204,15,94,212,211,208,10,181,67,29,250,56,18,177,141,241,59,59,243,101,140,22,5,213,212,199,83,62,105,174,2,219,140,173,13,216,179,134,168,162,61,83,50,168,151,184,81,111,24,255,118,239,239,183,150,230,109,129,232,208,103,49,62,11,47,232,118,69,50,219,39,251,127,223,222,223,185,120,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailAddressesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b5e160d6-e8e9-4f28-b295-3bb5d59f7b09"),
				Name = "GetEmailAddresses",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a5542334-3cae-48d4-923f-29890b111c8e"),
				Name = "addresses",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,189,14,194,48,12,132,231,240,20,102,74,34,85,121,129,210,110,12,72,8,134,86,98,64,12,81,107,32,82,250,35,39,133,162,170,239,78,255,128,5,15,94,238,62,223,153,49,102,174,32,156,39,83,222,212,206,29,26,107,143,180,45,106,255,18,58,207,9,157,67,39,37,116,43,54,12,161,111,168,132,18,159,176,55,206,111,102,44,22,50,28,229,126,92,15,77,224,176,214,164,125,69,14,162,201,156,221,53,157,47,208,1,15,121,0,60,224,208,79,196,114,239,27,164,146,218,26,47,126,188,156,98,85,130,22,51,47,90,136,98,104,85,74,166,16,114,145,78,119,36,156,149,245,223,47,218,143,51,173,198,206,67,215,55,33,147,181,172,244,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("12cb1ed5-1bbe-4a0f-9b60-be0766369315"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ff842732-2083-432b-b8c3-7b9582428b25"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("573437e5-b95f-401c-abae-c9814ebd2266"),
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
			return new EmailTemplateUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new EmailTemplateUserTask(userConnection) {
				SchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19")
			};
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateUserTaskSchemaExtension

	/// <exclude/>
	public class EmailTemplateUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var result = new Dictionary<Guid, string>();
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
						.Where("ActivityType", "Code").IsEqual(Column.Parameter("Email"))
				as Select;
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						result.Add(userConnection.DBTypeConverter.DBValueToGuid(dataReader[0]), dataReader.GetString(1));
					}
				}
			}
			return result;
		}

		public override void SynchronizeDynamicParameters(UserConnection userConnection, ProcessUserTaskSchema target) {
			base.SynchronizeDynamicParameters(userConnection, target);
			ProcessUserTaskUtilities.SynchronizeActivityConnectionParameters(userConnection, target);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Recommendation.Group", DescriptionResourceItem = "Parameters.Recommendation.Group")]
	[DesignModeGroup(Name = "Connected to", Position = 2, UseSolutionStorage = true, ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Lead.Group", DescriptionResourceItem = "Parameters.Lead.Group")]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityCategory", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.ActivityCategory.Caption", DescriptionResourceItem = "Parameters.ActivityCategory.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duration", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Duration.Caption", DescriptionResourceItem = "Parameters.Duration.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DurationPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.DurationPeriod.Caption", DescriptionResourceItem = "Parameters.DurationPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartIn", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.StartIn.Caption", DescriptionResourceItem = "Parameters.StartIn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartInPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.StartInPeriod.Caption", DescriptionResourceItem = "Parameters.StartInPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBefore", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.RemindBefore.Caption", DescriptionResourceItem = "Parameters.RemindBefore.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBeforePeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.RemindBeforePeriod.Caption", DescriptionResourceItem = "Parameters.RemindBeforePeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowInScheduler", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.ShowInScheduler.Caption", DescriptionResourceItem = "Parameters.ShowInScheduler.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Lead", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Lead.Caption", DescriptionResourceItem = "Parameters.Lead.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Account", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Account.Caption", DescriptionResourceItem = "Parameters.Account.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Opportunity", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Opportunity.Caption", DescriptionResourceItem = "Parameters.Opportunity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Invoice", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Invoice.Caption", DescriptionResourceItem = "Parameters.Invoice.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Document", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Document.Caption", DescriptionResourceItem = "Parameters.Document.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityResult", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.ActivityResult.Caption", DescriptionResourceItem = "Parameters.ActivityResult.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Incident", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Incident.Caption", DescriptionResourceItem = "Parameters.Incident.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Case", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Case.Caption", DescriptionResourceItem = "Parameters.Case.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.ActivityId.Caption", DescriptionResourceItem = "Parameters.ActivityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActivityCompleted", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.IsActivityCompleted.Caption", DescriptionResourceItem = "Parameters.IsActivityCompleted.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExecutionContext", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.ExecutionContext.Caption", DescriptionResourceItem = "Parameters.ExecutionContext.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Order", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Order.Caption", DescriptionResourceItem = "Parameters.Order.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contract", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Contract.Caption", DescriptionResourceItem = "Parameters.Contract.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Property", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Property.Caption", DescriptionResourceItem = "Parameters.Property.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Listing", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Listing.Caption", DescriptionResourceItem = "Parameters.Listing.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Requests", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Requests.Caption", DescriptionResourceItem = "Parameters.Requests.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Project", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Project.Caption", DescriptionResourceItem = "Parameters.Project.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Problem", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Problem.Caption", DescriptionResourceItem = "Parameters.Problem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Change", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Change.Caption", DescriptionResourceItem = "Parameters.Change.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Release", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Release.Caption", DescriptionResourceItem = "Parameters.Release.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "QueueItem", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.QueueItem.Caption", DescriptionResourceItem = "Parameters.QueueItem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Sender", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Sender.Caption", DescriptionResourceItem = "Parameters.Sender.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Importance", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Importance.Caption", DescriptionResourceItem = "Parameters.Importance.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Subject", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Subject.Caption", DescriptionResourceItem = "Parameters.Subject.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IgnoreErrors", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.IgnoreErrors.Caption", DescriptionResourceItem = "Parameters.IgnoreErrors.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SendEmailType", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.SendEmailType.Caption", DescriptionResourceItem = "Parameters.SendEmailType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "BodyTemplateType", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.BodyTemplateType.Caption", DescriptionResourceItem = "Parameters.BodyTemplateType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EmailTemplateId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.EmailTemplateId.Caption", DescriptionResourceItem = "Parameters.EmailTemplateId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EmailTemplateEntityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.EmailTemplateEntityId.Caption", DescriptionResourceItem = "Parameters.EmailTemplateEntityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Body", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.Body.Caption", DescriptionResourceItem = "Parameters.Body.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "BodyConfig", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "184dbb27ce134d378dffc2ff1df9cf19", CaptionResourceItem = "Parameters.BodyConfig.Caption", DescriptionResourceItem = "Parameters.BodyConfig.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class EmailTemplateUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public EmailTemplateUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("184dbb27-ce13-4d37-8dff-c2ff1df9cf19");
			_activityCategory = () => { return new Guid("8038a396-7825-e011-8165-00155d043204"); };
			_importance = () => { return 1; };
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

		public virtual Guid ActivityResult {
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

		public virtual Guid ActivityId {
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

		public virtual Guid Property {
			get;
			set;
		}

		public virtual Guid Listing {
			get;
			set;
		}

		public virtual Guid Requests {
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

		public virtual Guid Sender {
			get;
			set;
		}

		private Func<int> _importance;
		public virtual int Importance {
			get {
				return (_importance ?? (_importance = () => 0)).Invoke();
			}
			set {
				_importance = () => { return value; };
			}
		}

		private LocalizableString _subject;
		public virtual LocalizableString Subject {
			get {
				return _subject ?? (_subject = new LocalizableString());
			}
			set {
				_subject = value;
			}
		}

		private bool _ignoreErrors = true;
		public virtual bool IgnoreErrors {
			get {
				return _ignoreErrors;
			}
			set {
				_ignoreErrors = value;
			}
		}

		public virtual int SendEmailType {
			get;
			set;
		}

		public virtual int BodyTemplateType {
			get;
			set;
		}

		public virtual Guid EmailTemplateId {
			get;
			set;
		}

		public virtual Guid EmailTemplateEntityId {
			get;
			set;
		}

		public virtual string Body {
			get;
			set;
		}

		public virtual string BodyConfig {
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
			if (!HasMapping("ActivityResult")) {
				writer.WriteValue("ActivityResult", ActivityResult, Guid.Empty);
			}
			if (!HasMapping("Incident")) {
				writer.WriteValue("Incident", Incident, Guid.Empty);
			}
			if (!HasMapping("Case")) {
				writer.WriteValue("Case", Case, Guid.Empty);
			}
			if (!HasMapping("ActivityId")) {
				writer.WriteValue("ActivityId", ActivityId, Guid.Empty);
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
			if (!HasMapping("Property")) {
				writer.WriteValue("Property", Property, Guid.Empty);
			}
			if (!HasMapping("Listing")) {
				writer.WriteValue("Listing", Listing, Guid.Empty);
			}
			if (!HasMapping("Requests")) {
				writer.WriteValue("Requests", Requests, Guid.Empty);
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
			if (!HasMapping("Sender")) {
				writer.WriteValue("Sender", Sender, Guid.Empty);
			}
			if (!HasMapping("Importance")) {
				writer.WriteValue("Importance", Importance, 0);
			}
			if (!HasMapping("IgnoreErrors")) {
				writer.WriteValue("IgnoreErrors", IgnoreErrors, false);
			}
			if (!HasMapping("SendEmailType")) {
				writer.WriteValue("SendEmailType", SendEmailType, 0);
			}
			if (!HasMapping("BodyTemplateType")) {
				writer.WriteValue("BodyTemplateType", BodyTemplateType, 0);
			}
			if (!HasMapping("EmailTemplateId")) {
				writer.WriteValue("EmailTemplateId", EmailTemplateId, Guid.Empty);
			}
			if (!HasMapping("EmailTemplateEntityId")) {
				writer.WriteValue("EmailTemplateEntityId", EmailTemplateEntityId, Guid.Empty);
			}
			if (!HasMapping("Body")) {
				writer.WriteValue("Body", Body, null);
			}
			if (!HasMapping("BodyConfig")) {
				writer.WriteValue("BodyConfig", BodyConfig, null);
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
				case "ActivityResult":
					ActivityResult = reader.GetGuidValue();
				break;
				case "Incident":
					Incident = reader.GetGuidValue();
				break;
				case "Case":
					Case = reader.GetGuidValue();
				break;
				case "ActivityId":
					ActivityId = reader.GetGuidValue();
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
				case "Property":
					Property = reader.GetGuidValue();
				break;
				case "Listing":
					Listing = reader.GetGuidValue();
				break;
				case "Requests":
					Requests = reader.GetGuidValue();
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
				case "Sender":
					Sender = reader.GetGuidValue();
				break;
				case "Importance":
					Importance = reader.GetIntValue();
				break;
				case "Subject":
					Subject = reader.GetLocalizableStringValue();
				break;
				case "IgnoreErrors":
					IgnoreErrors = reader.GetBoolValue();
				break;
				case "SendEmailType":
					SendEmailType = reader.GetIntValue();
				break;
				case "BodyTemplateType":
					BodyTemplateType = reader.GetIntValue();
				break;
				case "EmailTemplateId":
					EmailTemplateId = reader.GetGuidValue();
				break;
				case "EmailTemplateEntityId":
					EmailTemplateEntityId = reader.GetGuidValue();
				break;
				case "Body":
					Body = reader.GetStringValue();
				break;
				case "BodyConfig":
					BodyConfig = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

