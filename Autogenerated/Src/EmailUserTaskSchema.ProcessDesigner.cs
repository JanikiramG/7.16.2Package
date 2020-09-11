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

	#region Class: EmailUserTaskSchema

	/// <exclude/>
	public class EmailUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public EmailUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public EmailUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0");
			RealUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0");
			Name = "EmailUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.General;
			ParametersEditPageSchemaUId = new Guid("56f0d988-512f-4761-a3fd-ea5daa39c4f3");
			ParametersEditPageSchemaV2UId = new Guid("c49aac50-3e6f-4601-923e-f8aed83bf969");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,193,106,195,48,16,68,207,241,87,40,57,4,27,140,126,192,24,26,130,9,190,148,80,199,244,172,218,107,71,212,145,204,106,149,38,20,255,123,37,187,106,75,79,133,222,196,236,204,104,223,62,108,100,199,226,138,4,89,195,242,156,29,81,55,96,204,34,240,2,81,99,194,222,163,149,119,237,45,34,40,218,53,36,175,146,238,101,235,3,7,43,91,94,92,70,186,179,237,150,173,63,243,181,1,60,9,243,90,147,28,36,73,48,252,0,84,154,16,221,35,8,130,54,246,182,189,86,10,156,174,85,202,234,178,77,230,239,86,39,64,20,70,119,196,221,188,147,189,69,225,45,60,52,48,17,30,57,91,218,194,36,78,50,151,223,117,4,24,164,74,92,161,106,80,142,84,220,160,177,4,113,72,123,239,20,77,209,139,214,3,147,230,201,42,37,85,239,59,127,179,242,210,60,106,154,65,227,100,70,253,129,163,47,227,0,14,40,139,252,157,214,95,69,51,203,63,81,254,78,50,69,165,114,94,167,60,75,58,251,219,198,141,118,202,141,210,111,182,148,85,103,253,182,164,221,22,71,209,131,139,34,144,69,197,58,49,24,200,54,31,170,115,34,96,21,2,0,0 };
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
			Parameters.Add(CreateActivityResultParameter());
			Parameters.Add(CreateIncidentParameter());
			Parameters.Add(CreateCaseParameter());
			Parameters.Add(CreateCurrentActivityIdParameter());
			Parameters.Add(CreateIsActivityCompletedParameter());
			Parameters.Add(CreateExecutionContextParameter());
			Parameters.Add(CreateRecepientParameter());
			Parameters.Add(CreateCopyRecepientParameter());
			Parameters.Add(CreateBlindCopyRecepientParameter());
			Parameters.Add(CreateBodyParameter());
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
					Value = @"[#Lookup.961e2086-a12b-4d27-b095-40b1e64d6cc0.8038a396-7825-e011-8165-00155d043204#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
					ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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

		protected virtual ProcessSchemaParameter CreateIncidentParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("388c386c-9d57-42c3-95c1-33e5cf5ad23a"),
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
				UId = new Guid("ffb7e0f0-4f13-4b5b-b452-80a321d34a1e"),
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

		protected virtual ProcessSchemaParameter CreateRecepientParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8e410182-250c-42c3-a0b3-049f68f86ea3"),
				Name = "Recepient",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCopyRecepientParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("53d5ce25-4949-4226-9543-ecf4fedfbb6b"),
				Name = "CopyRecepient",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateBlindCopyRecepientParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("913abf88-c449-4dac-a599-9e8942613651"),
				Name = "BlindCopyRecepient",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
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
				UId = new Guid("31ad8bd6-f2c1-4b31-8af1-71db68fdb368"),
				Name = "Body",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
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
				UId = new Guid("d69ae1d0-f70d-47da-822a-811f75671f71"),
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
				UId = new Guid("2127b3b0-9dc5-4864-8909-0ffc382e4bf9"),
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
				UId = new Guid("e2e0fa87-041d-4124-8bad-771f8f3602cf"),
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
				UId = new Guid("af78e7ab-5e80-4572-ab97-e390511834f0"),
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
				UId = new Guid("cabb0714-f805-4ce5-b044-85a0fb767458"),
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
				UId = new Guid("a01a51b7-bae1-40cb-b3c9-1570fe35e01e"),
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
				UId = new Guid("692b6f46-c082-4a0e-91d0-9397ad2f3e4a"),
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
				UId = new Guid("5ce30cb7-9519-46b3-a234-5c79bf78126c"),
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
				UId = new Guid("1d825bc6-3fe5-4de8-8ed0-50cd0ab8fbf6"),
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
				UId = new Guid("90215614-b361-4786-8a21-05ad98d9ea6a"),
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
				UId = new Guid("b4a2952b-c9e2-45d5-b3b3-df2b5f209dd4"),
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
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateGetConditionDataMethod());
			Methods.Add(CreateGetActivityTitleMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateGetActivityEntitySchemaUIdMethod());
			Methods.Add(CreateCreateActivityMethod());
			Methods.Add(CreateGetParentProcessIdMethod());
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
			Methods.Add(CreateGetNotificationDataMethod());
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

		protected virtual SchemaMethod CreateGetActivityTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ffd6b283-f645-4423-a432-351c970169ad"),
				Name = "GetActivityType",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "DateTime"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("da42dbdb-c00e-449b-8ce0-04fb7b2c0f60"),
				Name = "oldDate",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f1d89073-c6b5-45ed-a34a-64478b333aa9"),
				Name = "offset",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0fdc8547-0a82-489a-aefb-05d0bc59bbcb"),
				Name = "offsetPeriod",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,81,79,194,48,16,126,238,126,69,179,167,46,33,141,62,35,38,176,77,50,31,212,0,209,7,227,67,101,23,104,50,90,189,182,32,49,252,119,187,117,4,4,4,147,101,75,239,238,251,238,187,245,187,165,64,138,96,92,101,13,237,81,5,43,154,201,169,149,90,9,92,223,12,157,44,59,212,88,148,106,118,203,146,110,52,134,10,166,150,154,240,233,209,136,212,136,16,101,206,0,166,90,41,104,240,9,207,164,177,82,249,68,18,17,194,83,93,185,133,98,113,223,103,151,210,174,71,77,211,184,67,227,162,140,47,84,60,136,5,132,154,59,212,139,163,138,38,115,175,165,98,245,107,178,254,0,94,120,25,232,145,219,202,84,88,152,105,108,17,185,178,184,110,96,132,63,254,169,137,23,38,255,116,162,98,103,89,246,154,132,240,118,156,255,9,58,161,226,66,151,109,250,188,196,253,31,123,94,73,29,60,163,34,62,40,61,221,182,33,217,181,36,252,101,14,8,199,249,84,151,176,135,15,87,206,159,4,250,27,182,128,44,206,23,66,86,113,82,147,8,211,58,171,27,57,227,29,72,217,210,155,181,124,207,191,96,234,172,70,239,191,223,150,227,185,50,14,33,27,236,66,44,73,232,119,68,90,124,145,9,43,70,32,74,240,60,53,62,24,153,7,70,8,25,182,235,16,192,100,53,151,21,80,86,34,175,43,90,74,66,218,181,225,253,178,60,240,62,207,6,245,192,62,176,4,244,99,249,243,179,168,28,76,116,189,81,158,232,245,234,45,233,120,9,124,8,118,220,172,23,187,78,252,126,17,178,137,252,179,137,16,172,67,181,221,204,238,15,76,160,213,219,166,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3a3f999b-6f6c-416e-86fb-7e1589bb39df"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool",
				IsOverride = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a1f660e0-d13e-44e9-95f3-68c276b73956"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,151,77,111,220,32,16,134,207,236,175,112,247,180,145,162,85,239,171,28,210,124,41,82,212,68,249,232,165,234,129,197,236,46,173,13,46,224,109,163,42,255,189,96,24,27,155,89,201,71,236,151,119,230,153,145,7,124,164,186,160,204,138,163,176,239,197,69,209,80,77,107,110,185,54,223,63,255,40,168,41,94,185,214,212,168,157,93,95,41,185,19,251,86,83,43,148,92,95,198,61,155,133,216,21,171,193,225,162,144,109,85,157,21,255,22,68,115,219,106,89,236,104,101,248,102,241,177,120,252,35,185,190,47,93,20,144,175,227,163,205,226,232,210,96,170,106,107,249,192,233,72,242,194,14,188,166,46,186,127,105,214,183,66,150,95,222,191,186,36,87,75,47,93,158,133,12,146,205,159,146,28,212,246,39,103,182,168,38,166,119,220,6,195,111,180,106,121,178,217,185,17,111,87,77,141,72,204,107,117,215,138,242,204,191,118,202,15,71,117,201,152,106,165,77,221,227,35,207,229,138,102,221,243,244,109,124,52,166,126,108,26,165,109,43,67,23,230,192,39,59,198,53,72,173,144,82,40,60,18,90,145,196,10,10,163,78,184,147,49,65,40,83,34,142,213,26,136,239,229,81,9,198,103,210,70,245,152,20,44,16,74,145,187,163,132,209,2,232,4,226,72,134,76,3,85,20,101,68,143,186,228,122,110,247,188,118,210,183,110,59,214,177,169,47,222,43,175,234,187,148,121,17,200,46,118,198,175,50,130,39,173,186,136,243,24,162,122,76,1,22,8,71,147,187,163,36,209,2,88,26,196,145,12,153,6,158,184,206,136,252,199,166,233,108,36,144,143,153,122,19,4,138,33,1,80,42,48,1,44,134,153,146,36,223,0,6,178,140,236,90,177,182,230,114,46,25,200,199,100,189,9,66,86,34,1,80,50,48,1,178,18,51,37,73,190,129,12,100,25,217,51,255,221,114,99,205,76,50,144,143,201,122,19,132,76,35,1,80,50,48,1,50,141,153,146,36,223,64,6,178,140,236,65,24,43,228,126,238,241,22,212,147,19,46,90,96,135,92,238,142,159,115,65,215,31,117,136,35,25,50,141,7,94,88,99,19,163,225,122,246,161,5,242,108,102,4,19,124,104,100,1,78,77,141,78,152,140,141,220,148,36,249,6,48,144,69,178,116,116,28,168,220,207,61,159,130,120,50,54,130,1,54,52,50,107,124,100,116,178,126,96,228,118,164,207,49,14,139,110,137,53,105,91,241,122,126,143,188,58,107,81,103,129,119,104,234,126,170,65,94,151,244,39,115,36,67,166,125,119,252,26,25,17,238,6,102,230,54,39,170,167,3,34,88,160,243,33,115,63,49,30,58,221,48,29,114,71,50,100,10,179,161,91,71,34,199,203,184,49,111,134,235,87,106,126,189,89,81,9,43,184,89,191,112,123,253,46,105,45,216,19,220,200,187,200,102,101,15,194,156,247,137,185,216,112,19,127,230,166,173,70,211,58,60,241,23,205,123,3,170,43,85,55,149,179,243,119,89,171,91,151,200,86,169,202,33,199,205,91,151,220,26,68,55,127,57,107,253,119,191,26,254,11,92,196,161,230,227,170,44,35,206,141,107,25,247,247,223,229,121,168,68,178,197,161,94,150,181,144,207,98,127,232,70,102,252,61,24,60,233,145,175,220,142,248,247,16,18,219,252,7,70,87,86,174,167,12,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConditionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1625969-4540-44ac-a347-68cb2f7b00ce"),
				Name = "GetConditionData",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,202,49,10,128,48,16,4,192,175,164,84,8,126,192,74,44,196,78,196,60,32,36,11,30,106,2,119,171,224,239,237,156,122,20,188,181,184,69,107,130,89,48,232,22,237,8,148,83,40,176,110,2,135,68,121,132,239,38,60,209,112,23,243,110,69,170,215,133,146,35,165,22,239,198,91,21,229,175,115,110,251,15,79,127,220,206,90,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6c994686-94e9-4e32-b50f-44cd23d536de"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6505ca01-33b7-4878-aace-a60cb6f48f8b"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				ModifiedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
				UId = new Guid("19abe264-1495-47e8-b482-c3b289d792f1"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,203,110,131,48,16,60,39,95,97,113,2,41,226,3,90,85,85,26,161,10,169,74,80,32,189,187,102,155,90,245,3,217,75,19,90,245,223,187,24,232,35,81,149,11,198,59,51,187,195,44,14,176,117,134,149,224,36,87,242,29,42,91,162,147,102,31,27,56,176,143,249,172,113,86,100,106,151,215,236,134,209,115,49,159,25,174,129,46,107,58,22,3,14,222,7,188,24,222,119,30,92,197,253,235,14,165,146,40,193,167,247,128,5,119,96,176,152,216,241,230,96,192,37,212,64,250,177,152,29,65,180,8,245,93,87,202,189,225,234,66,195,252,63,221,79,235,209,219,122,48,28,202,233,104,155,188,72,236,74,241,2,154,143,120,180,20,40,223,168,26,17,238,64,88,173,193,212,28,165,53,132,210,196,9,175,36,42,136,131,119,243,108,157,14,148,141,41,17,26,34,62,88,209,7,201,159,20,12,73,166,185,95,183,74,109,92,166,27,236,226,252,84,147,176,91,102,136,192,174,216,25,150,62,114,213,134,152,249,30,170,174,129,144,51,155,156,172,172,241,232,211,76,115,169,122,116,88,16,31,209,45,125,131,171,131,98,213,186,62,254,73,23,104,16,114,163,81,212,5,225,136,68,203,78,74,253,182,233,40,126,253,3,209,159,66,176,215,231,197,149,178,7,168,183,224,91,133,254,194,234,150,3,121,249,237,51,136,226,158,75,131,13,136,222,194,226,220,116,50,255,76,174,191,0,204,139,229,229,177,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityEntitySchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("30dafa17-3650-4588-819d-e413ad351d24"),
				Name = "GetActivityEntitySchemaUId",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
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
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Terrasoft.Configuration.Activity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,87,77,111,227,54,16,61,39,191,66,205,97,97,23,180,96,111,54,219,20,198,30,178,182,219,26,72,55,139,196,233,93,181,198,14,187,18,233,165,168,24,70,177,255,189,67,138,148,135,52,156,74,39,73,195,247,30,31,135,35,126,188,102,42,201,214,154,191,114,125,72,62,37,2,246,201,10,148,202,42,185,209,233,76,138,13,223,214,42,211,92,138,244,206,193,6,207,21,40,108,18,176,54,241,225,244,210,11,164,79,160,231,176,153,201,162,46,197,95,89,81,67,53,160,205,203,28,187,248,189,230,121,250,5,246,230,25,180,174,14,59,176,8,223,17,246,81,233,42,93,148,25,47,76,227,243,50,39,240,63,161,170,178,45,156,99,61,212,122,43,185,216,182,236,128,188,226,186,0,99,6,180,231,217,80,96,232,73,103,74,207,51,109,128,104,216,188,69,99,79,103,181,82,32,180,137,166,168,229,62,13,114,197,75,84,99,137,21,89,10,150,12,190,42,185,70,207,115,151,207,175,160,184,204,135,174,221,125,145,222,231,53,68,125,159,26,99,137,87,59,171,31,125,78,47,249,38,25,180,185,66,141,173,84,135,116,241,189,206,138,106,96,231,102,81,238,244,97,56,252,247,242,34,134,185,2,177,51,119,117,59,190,190,189,187,254,245,227,232,151,219,247,55,163,197,120,50,25,221,78,62,222,140,198,227,201,205,205,124,252,225,250,253,248,195,21,246,247,227,56,164,88,47,156,55,23,164,19,240,34,247,75,241,180,126,129,188,46,64,33,56,138,16,236,35,172,97,199,49,249,136,106,223,73,251,76,238,14,20,19,124,19,220,231,130,139,60,6,159,6,41,67,230,38,51,230,145,174,228,147,86,88,117,97,217,87,127,232,178,112,48,173,106,104,38,225,97,47,64,97,10,126,114,255,68,147,247,4,243,222,50,61,228,83,226,222,166,151,23,134,250,8,37,26,250,12,27,169,192,240,199,150,118,65,146,97,218,87,210,178,218,78,207,1,58,148,217,104,146,252,156,208,94,207,214,27,5,181,53,119,241,3,203,224,21,151,154,181,93,26,238,33,51,99,58,118,132,243,89,102,105,179,110,84,233,111,70,224,240,37,195,31,232,202,64,175,92,213,18,50,142,89,212,69,145,188,123,151,248,239,115,57,196,53,137,44,72,68,132,89,170,173,208,230,159,88,203,26,103,251,13,41,7,113,101,107,223,61,27,215,4,141,184,183,216,14,98,217,238,125,26,164,229,97,183,147,74,215,162,89,138,187,100,135,48,194,36,81,41,146,171,40,220,43,101,132,203,168,208,48,28,196,92,174,235,178,249,107,186,140,192,195,67,251,173,8,241,78,99,189,140,123,34,107,37,34,203,75,241,42,249,26,58,58,118,232,208,176,151,32,126,73,168,151,93,199,99,94,32,50,59,203,170,174,78,13,52,180,105,201,196,163,255,238,101,208,144,152,165,70,214,30,84,110,87,155,78,149,107,176,81,205,90,58,173,86,31,232,87,167,134,197,26,114,100,16,87,172,127,112,227,238,104,209,161,67,147,94,130,216,36,161,94,70,29,143,121,129,120,162,113,137,80,89,103,183,30,30,77,184,23,161,147,78,98,253,38,222,17,89,43,17,89,126,132,239,120,228,211,85,71,203,30,30,90,110,69,136,101,26,235,101,217,19,89,43,17,89,190,231,149,198,253,186,235,110,212,160,163,13,201,73,208,61,233,24,234,183,45,53,60,230,5,78,235,119,7,170,243,238,224,225,39,21,220,136,132,37,220,198,250,214,176,37,178,86,194,90,166,101,252,146,137,109,231,21,203,130,163,18,110,4,104,1,183,145,126,229,107,105,204,209,79,74,183,128,238,43,171,67,199,133,219,72,4,117,219,134,122,150,173,229,49,47,112,90,7,127,23,80,118,47,3,131,62,169,2,43,17,22,129,15,245,173,1,195,99,94,192,154,117,135,67,115,49,90,101,213,183,103,205,11,174,57,84,70,98,33,180,189,167,145,91,162,126,225,248,143,250,126,232,225,217,9,45,80,24,220,209,43,188,7,222,21,133,220,67,254,8,85,93,232,230,74,215,188,187,134,227,61,212,140,42,81,182,173,233,92,63,47,223,58,135,162,146,207,33,30,133,117,141,11,85,106,251,142,46,129,75,239,81,108,185,128,244,46,207,93,192,252,197,128,7,236,246,72,205,140,119,102,44,34,61,231,134,141,231,235,108,16,155,34,169,24,254,95,119,247,92,124,115,145,149,108,82,219,92,45,216,201,192,2,101,188,141,163,246,178,58,222,155,203,93,1,26,76,70,54,120,25,196,11,131,187,206,122,68,152,44,147,8,5,186,86,162,141,77,255,3,31,87,223,39,78,16,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetParentProcessIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bfd10958-b016-4f47-a663-75b2e752aa62"),
				Name = "GetParentProcessId",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,40,202,79,78,45,46,86,40,72,44,74,205,43,9,128,242,108,21,252,203,243,82,139,172,185,220,75,51,83,20,10,32,162,158,41,64,113,20,117,122,161,158,41,214,92,229,25,153,57,169,26,168,6,40,218,42,228,149,230,228,104,86,115,113,18,208,205,137,110,51,170,26,168,59,106,185,138,82,75,74,139,242,16,110,177,6,0,233,89,27,175,186,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e31af13f-b1ff-465c-83f7-84c13f622fd7"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("08a8ab3c-caa3-4cec-ae37-af72280f7775"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9248e73f-d416-4489-97fb-96a72ebd617e"),
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

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ab0a75f4-2ce3-448e-838a-422ab0da7d24"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"),
				CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90"),
				ResultValueTypeName = "ProcessElementNotification",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,205,10,130,80,16,133,247,61,197,93,38,132,47,32,46,132,34,218,196,165,244,1,166,235,41,134,244,14,204,140,239,159,96,144,210,238,124,112,254,162,74,130,217,105,192,136,236,87,113,126,114,34,103,201,33,175,161,14,15,50,148,103,108,60,71,114,218,23,213,46,46,45,157,65,91,178,119,231,60,176,51,172,108,204,248,149,255,34,235,234,67,184,33,201,56,207,247,95,190,59,169,95,126,34,66,89,250,121,70,225,147,110,143,85,31,16,177,181,236,193,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new EmailUserTask(userConnection) {
				SchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0")
			};
		}

		#endregion

	}

	#endregion

	#region Class: EmailUserTaskSchemaExtension

	/// <exclude/>
	public class EmailUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
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
						.Where("ActivityType", "Code").IsEqual(Column.Parameter("Email"))
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

		public override void SynchronizeDynamicParameters(UserConnection userConnection, ProcessUserTaskSchema target) {
			base.SynchronizeDynamicParameters(userConnection, target);
			ProcessUserTaskUtilities.SynchronizeActivityConnectionParameters(userConnection, target);
		}

		#endregion

	}

	#endregion

	#region Class: EmailUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Recommendation.Group", DescriptionResourceItem = "Parameters.Recommendation.Group")]
	[DesignModeGroup(Name = "Connected to", Position = 2, UseSolutionStorage = true, ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Lead.Group", DescriptionResourceItem = "Parameters.Lead.Group")]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityCategory", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.ActivityCategory.Caption", DescriptionResourceItem = "Parameters.ActivityCategory.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duration", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Duration.Caption", DescriptionResourceItem = "Parameters.Duration.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DurationPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.DurationPeriod.Caption", DescriptionResourceItem = "Parameters.DurationPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartIn", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.StartIn.Caption", DescriptionResourceItem = "Parameters.StartIn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartInPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.StartInPeriod.Caption", DescriptionResourceItem = "Parameters.StartInPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBefore", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.RemindBefore.Caption", DescriptionResourceItem = "Parameters.RemindBefore.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBeforePeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.RemindBeforePeriod.Caption", DescriptionResourceItem = "Parameters.RemindBeforePeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowInScheduler", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.ShowInScheduler.Caption", DescriptionResourceItem = "Parameters.ShowInScheduler.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Lead", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Lead.Caption", DescriptionResourceItem = "Parameters.Lead.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Account", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Account.Caption", DescriptionResourceItem = "Parameters.Account.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Opportunity", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Opportunity.Caption", DescriptionResourceItem = "Parameters.Opportunity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Invoice", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Invoice.Caption", DescriptionResourceItem = "Parameters.Invoice.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Document", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Document.Caption", DescriptionResourceItem = "Parameters.Document.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityResult", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.ActivityResult.Caption", DescriptionResourceItem = "Parameters.ActivityResult.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Incident", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Incident.Caption", DescriptionResourceItem = "Parameters.Incident.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Case", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Case.Caption", DescriptionResourceItem = "Parameters.Case.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentActivityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.CurrentActivityId.Caption", DescriptionResourceItem = "Parameters.CurrentActivityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActivityCompleted", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.IsActivityCompleted.Caption", DescriptionResourceItem = "Parameters.IsActivityCompleted.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExecutionContext", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.ExecutionContext.Caption", DescriptionResourceItem = "Parameters.ExecutionContext.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Recepient", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Recepient.Caption", DescriptionResourceItem = "Parameters.Recepient.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CopyRecepient", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.CopyRecepient.Caption", DescriptionResourceItem = "Parameters.CopyRecepient.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "BlindCopyRecepient", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.BlindCopyRecepient.Caption", DescriptionResourceItem = "Parameters.BlindCopyRecepient.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Body", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Body.Caption", DescriptionResourceItem = "Parameters.Body.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Order", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Order.Caption", DescriptionResourceItem = "Parameters.Order.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contract", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Contract.Caption", DescriptionResourceItem = "Parameters.Contract.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Property", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Property.Caption", DescriptionResourceItem = "Parameters.Property.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Listing", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Listing.Caption", DescriptionResourceItem = "Parameters.Listing.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Requests", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Requests.Caption", DescriptionResourceItem = "Parameters.Requests.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Project", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Project.Caption", DescriptionResourceItem = "Parameters.Project.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Problem", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Problem.Caption", DescriptionResourceItem = "Parameters.Problem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Change", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Change.Caption", DescriptionResourceItem = "Parameters.Change.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Release", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.Release.Caption", DescriptionResourceItem = "Parameters.Release.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "QueueItem", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "97bb4a37a49d47b9b9e6b01ae7b5b9d0", CaptionResourceItem = "Parameters.QueueItem.Caption", DescriptionResourceItem = "Parameters.QueueItem.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class EmailUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public EmailUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("97bb4a37-a49d-47b9-b9e6-b01ae7b5b9d0");
			_activityCategory = () => { return new Guid("8038a396-7825-e011-8165-00155d043204"); };
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

		public virtual string Recepient {
			get;
			set;
		}

		public virtual string CopyRecepient {
			get;
			set;
		}

		public virtual string BlindCopyRecepient {
			get;
			set;
		}

		private LocalizableString _body;
		public virtual LocalizableString Body {
			get {
				return _body ?? (_body = new LocalizableString());
			}
			set {
				_body = value;
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

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (Status == ProcessStatus.Error) {
				if (CurrentActivityId == Guid.Empty && !ProcessUserTaskUtilities.GetIsActivityCreated(UserConnection, UId)) {
					Terrasoft.Configuration.Activity activity = CreateActivity();
					AfterActivitySaveScriptExecute(activity);
				}
			}
			bool isRunning = CurrentActivityId.IsNotEmpty() && !IsActivityCompleted;
			if (!isRunning) {
				Terrasoft.Configuration.Activity activity = CreateActivity();
				AfterActivitySaveScriptExecute(activity);
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
							Where("Code").IsEqual(Column.Parameter("Email"))
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
					Project = (Guid)Project;
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
			ProcessUserTaskUtilities.SetDynamicParameterValues(this, activity);
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
			return ProcessUserTaskUtilities.GetActivityTitle(this, Recommendation, CurrentActivityId);
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
				pageTypeId =  ActivityConsts.EmailTypeUId,
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
			activity.TypeId = ActivityConsts.EmailTypeUId;
			activity.MessageTypeId = ActivityConsts.OutgoingEmailTypeId;
			activity.Title = GetActivityTitle();
			activity.StartDate = NewDate(UserConnection.CurrentUser.GetCurrentDateTime(), StartIn, (ProcessDurationPeriod)StartInPeriod);
			activity.DueDate = NewDate(activity.StartDate, Duration, (ProcessDurationPeriod)DurationPeriod);
			if (ActivityCategory.Equals(Guid.Empty)){
				ActivityCategory = new Guid("8038A396-7825-E011-8165-00155D043204");
			}
			activity.ActivityCategoryId = ActivityCategory;
			activity.ShowInScheduler = ShowInScheduler;
			activity.Recepient = Recepient;
			activity.CopyRecepient = CopyRecepient;
			activity.BlindCopyRecepient = BlindCopyRecepient;
			activity.Body = Body.ToString();
			activity.IsHtmlBody = true;
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
			ProcessUserTaskUtilities.SetEntityColumnValues(this, activity);
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

		public override ProcessElementNotification GetNotificationData() {
			ProcessElementNotification notification = base.GetNotificationData();
			ProcessUserTaskUtilities.AssignNotificationData(notification, Recommendation, StartIn, StartInPeriod);
			return notification;
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
			if (!HasMapping("ActivityResult")) {
				writer.WriteValue("ActivityResult", ActivityResult, Guid.Empty);
			}
			if (!HasMapping("Incident")) {
				writer.WriteValue("Incident", Incident, Guid.Empty);
			}
			if (!HasMapping("Case")) {
				writer.WriteValue("Case", Case, Guid.Empty);
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
			if (!HasMapping("Recepient")) {
				writer.WriteValue("Recepient", Recepient, null);
			}
			if (!HasMapping("CopyRecepient")) {
				writer.WriteValue("CopyRecepient", CopyRecepient, null);
			}
			if (!HasMapping("BlindCopyRecepient")) {
				writer.WriteValue("BlindCopyRecepient", BlindCopyRecepient, null);
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
				case "Recepient":
					Recepient = reader.GetStringValue();
				break;
				case "CopyRecepient":
					CopyRecepient = reader.GetStringValue();
				break;
				case "BlindCopyRecepient":
					BlindCopyRecepient = reader.GetStringValue();
				break;
				case "Body":
					Body = reader.GetLocalizableStringValue();
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
			}
		}

		#endregion

	}

	#endregion

}

