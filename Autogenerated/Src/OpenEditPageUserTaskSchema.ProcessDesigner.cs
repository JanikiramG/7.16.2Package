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
	using Terrasoft.Nui.ServiceModel.Extensions;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UserTaskExecutedMode = Terrasoft.Configuration.UserTaskExecutedMode;

	#region Class: OpenEditPageUserTaskSchema

	/// <exclude/>
	public class OpenEditPageUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public OpenEditPageUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public OpenEditPageUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae");
			RealUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae");
			Name = "OpenEditPageUserTask";
			CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("b3e5116b-7b74-40f1-bb8f-4535bbfa9ad2");
			ParametersEditPageSchemaV2UId = new Guid("a1cc99f2-4831-40c3-b891-64712e652679");
			DcmParametersEditPageSchemaV2UId = new Guid("409e066f-7f00-4ffa-ba31-c29cd19bde6a");
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,219,142,155,48,16,125,134,175,112,120,88,129,132,248,128,70,81,155,166,116,133,212,205,174,54,137,246,217,11,147,224,22,236,212,54,217,77,187,249,247,142,49,36,36,144,170,173,250,66,34,207,204,153,115,230,98,127,240,158,133,40,8,83,143,144,9,50,33,254,66,83,93,41,50,153,144,7,41,82,80,202,30,68,177,148,66,146,155,27,50,171,164,4,174,167,169,102,59,166,247,73,102,124,111,43,150,69,113,185,213,123,215,65,159,81,19,187,82,32,151,84,125,91,105,86,48,205,64,69,183,160,19,213,198,206,36,80,13,153,111,220,102,130,115,192,115,193,67,178,74,178,32,24,187,45,179,138,115,198,55,72,110,212,203,29,197,223,43,90,40,255,148,63,48,28,71,157,28,162,220,22,128,89,198,46,91,19,127,116,194,123,123,107,100,7,228,167,235,236,168,36,144,49,125,39,50,48,117,120,132,84,200,44,110,78,130,152,87,101,180,20,247,207,95,145,164,175,247,91,16,235,75,159,144,28,255,142,93,167,97,223,242,136,185,198,239,34,205,161,164,136,127,86,135,174,205,55,177,246,128,208,198,142,254,188,42,10,52,24,9,195,152,181,136,218,126,82,49,33,231,12,163,57,188,88,63,167,3,109,187,208,98,214,249,29,199,6,154,230,246,27,110,28,14,4,10,5,22,107,96,34,72,27,95,251,186,93,247,163,182,20,59,67,77,39,166,125,46,61,155,165,117,86,68,122,181,178,87,235,234,152,57,33,18,84,85,232,153,40,170,146,175,106,182,67,80,145,117,168,71,246,227,126,78,75,240,61,207,46,131,231,5,209,202,106,59,31,221,40,105,6,63,230,27,198,33,154,102,89,115,240,133,41,13,28,164,63,160,187,30,248,208,84,18,83,33,24,118,11,177,62,81,77,253,11,170,225,80,217,130,90,217,31,119,190,211,217,122,107,208,98,126,109,125,76,171,92,71,105,105,22,4,165,49,90,176,31,144,125,102,133,6,137,183,2,73,212,29,213,105,126,100,169,234,117,179,1,81,162,230,56,166,247,178,94,68,223,8,88,136,74,166,208,132,7,152,224,61,193,208,29,72,189,20,77,101,122,110,190,93,50,219,5,163,121,16,232,93,119,37,78,211,108,55,101,96,25,70,191,41,201,95,55,177,173,97,72,46,185,214,77,234,21,46,184,92,153,255,157,209,136,110,190,6,190,89,148,89,78,249,6,150,120,89,69,9,199,140,120,11,6,253,133,252,135,17,238,206,237,176,218,131,123,112,175,62,2,9,71,55,68,121,98,58,55,86,95,231,76,133,36,21,120,254,170,17,246,226,61,56,222,217,33,89,228,226,37,126,133,180,50,150,7,186,49,87,173,4,93,73,78,214,248,16,192,216,251,5,14,238,221,16,210,6,0,0 };
			SerializeToDB = true;
			IsUserTask = true;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateObjectSchemaIdParameter());
			Parameters.Add(CreatePageSchemaIdParameter());
			Parameters.Add(CreateEditModeParameter());
			Parameters.Add(CreateRecordColumnValuesParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateExecutedModeParameter());
			Parameters.Add(CreateIsMatchConditionsParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateGenerateDecisionsFromColumnParameter());
			Parameters.Add(CreateDecisionalColumnMetaPathParameter());
			Parameters.Add(CreateResultParameterParameter());
			Parameters.Add(CreateIsReexecutionParameter());
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
			Parameters.Add(CreatePageTypeUIdParameter());
			Parameters.Add(CreateActivitySchemaUIdParameter());
			Parameters.Add(CreateInformationOnStepParameter());
			Parameters.Add(CreateOrderParameter());
			Parameters.Add(CreateRequestsParameter());
			Parameters.Add(CreateListingParameter());
			Parameters.Add(CreatePropertyParameter());
			Parameters.Add(CreateContractParameter());
			Parameters.Add(CreateProblemParameter());
			Parameters.Add(CreateChangeParameter());
			Parameters.Add(CreateReleaseParameter());
			Parameters.Add(CreateProjectParameter());
		}

		protected virtual ProcessSchemaParameter CreateObjectSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f8879eb3-b522-4eef-9c3a-97c661a00369"),
				Name = "ObjectSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePageSchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bf9f5397-7c32-4177-b254-033219618752"),
				Name = "PageSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateEditModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b95863e0-fdf3-4d30-8f7f-79fe77f799d6"),
				Name = "EditMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordColumnValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b16ed342-8b8e-44d5-a8cf-ff4dd207c773"),
				Name = "RecordColumnValues",
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
				UId = new Guid("131deb9f-5109-45ee-8d6a-6e6d19242739"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateExecutedModeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c88c0bd6-ea61-44df-861a-e3967759a2b9"),
				Name = "ExecutedMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMatchConditionsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("26436ca8-dd6b-4b31-8911-2a7074ef2cc6"),
				Name = "IsMatchConditions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
				UId = new Guid("56058d2d-4e1c-4e6b-8787-bcbb5b9efb7e"),
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

		protected virtual ProcessSchemaParameter CreateGenerateDecisionsFromColumnParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f49a72ac-ceb6-4fe3-bd6e-596d658749ab"),
				Name = "GenerateDecisionsFromColumn",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDecisionalColumnMetaPathParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("865f04d4-e9e8-4827-a724-255432c25fba"),
				Name = "DecisionalColumnMetaPath",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
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
				UId = new Guid("e490494f-e43e-42ef-964f-8831565fed10"),
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

		protected virtual ProcessSchemaParameter CreateIsReexecutionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c44b100e-ccda-4cde-9731-ffe08fb21698"),
				Name = "IsReexecution",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
				UId = new Guid("f3075fea-6d6f-4d0c-9a7f-524a1ec0cb95"),
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
				UId = new Guid("573903b1-dc23-46bf-b200-54cef4ec9b5a"),
				Name = "ActivityCategory",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("40f06eb2-a6d1-4500-98d4-4bfaa6dee327"),
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
				UId = new Guid("ca258815-2770-49a5-a61c-8b732aa364c6"),
				Name = "Duration",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"5",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("4ac0ef9b-bc03-423c-a8c9-e33b5fa0b582"),
				Name = "DurationPeriod",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"0",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("edf0db0b-c3ac-4c16-8105-8819a2c05d09"),
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
				UId = new Guid("d4f17b40-c8d8-46ae-b2cb-5800f82fe2e9"),
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
				UId = new Guid("497809d1-98df-4ddd-9f15-8efac55f20fa"),
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
				UId = new Guid("1bcb40bc-bc5e-4981-9d13-c22dca3ad4d1"),
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
				UId = new Guid("e4e6f4c5-b012-425a-ac13-20d4f22e8169"),
				Name = "ShowInScheduler",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"False",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("2c7578b6-28a7-4933-9994-1708a45e5e62"),
				Name = "ShowExecutionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("0ae49c54-7264-41b1-a927-3fde69f96f89"),
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
				UId = new Guid("49074acf-499b-42ba-8be7-8dfde080f638"),
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
				UId = new Guid("bd6a65cf-f558-4c38-bba4-3864db7b5e72"),
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
				UId = new Guid("77b5ad16-67c0-491e-b4d0-116974c9b0fa"),
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
				UId = new Guid("3c1d7642-7820-49a0-86f5-0897c7cdcef5"),
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
				UId = new Guid("492bf503-4146-43ae-bd6e-53c90eb6c920"),
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
				UId = new Guid("5daedf58-18e3-4520-9f9e-0726576bae10"),
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
				UId = new Guid("b5a0cee0-7859-4bb1-98e4-9c0f0f2e2d58"),
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
				UId = new Guid("b82726d3-4703-48bf-bd21-2f4de186bff6"),
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
				UId = new Guid("c43e1382-4998-4d0b-966c-d95596a285b1"),
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
				UId = new Guid("674fdc03-3520-41af-ba89-a7a73fb1d62e"),
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
				UId = new Guid("0ec3f3ea-0a11-4010-bdd2-e48d2470d92f"),
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

		protected virtual ProcessSchemaParameter CreatePageTypeUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("864efe2c-3328-4a89-9b39-48f4bac9cfc4"),
				Name = "PageTypeUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateActivitySchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ea1ccb51-b8d8-413c-bb0b-e533f1dda05e"),
				Name = "ActivitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
				UId = new Guid("31454538-8abb-457e-b8a6-6d299d6a9ecf"),
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
				UId = new Guid("9d741e95-dfc5-4bf8-85e0-eced0d1aa22c"),
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
				UId = new Guid("98667ae6-3422-4dbd-b918-4dedc510a3e7"),
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
				UId = new Guid("b6e88b28-78cb-42c7-bf1f-841c1a2b4158"),
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
				UId = new Guid("00849d6e-52a9-41f1-9e14-ed523e04b54d"),
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
				UId = new Guid("6cd9ed27-3385-4b2b-b5b5-0e566eed0a5f"),
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

		protected virtual ProcessSchemaParameter CreateProblemParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("935a634f-f6ae-441f-9cc1-1a6b11b5ed08"),
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
				UId = new Guid("d9387287-8508-4dc2-9f68-0b8d3b3764c2"),
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
				UId = new Guid("ed5309d6-3e46-4162-84c6-fe054370e8cc"),
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

		protected virtual ProcessSchemaParameter CreateProjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("495edafa-f93d-41ae-8db6-01abc3ef3208"),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateGetIsMatchedConditionsMethod());
			Methods.Add(CreateGetResultParameterMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateCreateAccompaningActivityMethod());
			Methods.Add(CreateGetDateTimeMethod());
			Methods.Add(CreateGetActivityTypeMethod());
			Methods.Add(CreateGetActivityTitleMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateGetConditionDataMethod());
			Methods.Add(CreateSerializeCoreEntityColumnMethod());
			Methods.Add(CreateGetIsActivityEntitySchemaMethod());
			Methods.Add(CreateGetActionNameMethod());
			Methods.Add(CreateGetActivityEntitySchemaUIdMethod());
			Methods.Add(CreateCreateActivityMethod());
			Methods.Add(CreateGetActivityEntitySchemaMethod());
			Methods.Add(CreateGetIsExecutedMethod());
			Methods.Add(CreateSpecifyActivityColumnValuesMethod());
			Methods.Add(CreateGetNotificationDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c4737a57-a874-418e-9a0b-b448440e883f"),
				Name = "Terrasoft.Configuration.RecordEditMode",
				Alias = "RecordEditMode",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("70395403-b227-4925-ae3d-5d0bd8164097"),
				Name = "Terrasoft.Configuration.UserTaskExecutedMode",
				Alias = "UserTaskExecutedMode",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c6bee344-baee-4ebf-9c37-2bf2061a3e2c"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "Controls",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fe2cce0a-f4a1-47a5-a343-2646c529a64e"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("64f637eb-517a-413e-b6f9-31606987aaf9"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5058d249-f29d-4670-8c92-e15516c2f632"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2fa1e7a5-6e4e-43a5-996d-b7f7fe4d4402"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a2d08713-b30c-4989-a338-b690e6249dd5"),
				Name = "System.Runtime.Serialization.Formatters",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9809f727-ebd9-49f9-8453-4cec84f5cb2e"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a28ca7d4-76fc-4c15-8e48-94437647ebf7"),
				Name = "Terrasoft.UI.WebControls.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9ffd630-abdb-4b3e-9e19-c4cc7f5d9a64"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c6da64f-2c99-464a-afbf-0aafce6c0fa2"),
				Name = "Terrasoft.Nui.ServiceModel.Extensions",
				Alias = "",
				CreatedInPackageId = new Guid("3d056679-60f8-44c9-96b8-2632a52db69a")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ec0fcc6d-ebb5-4ae0-88e7-ec98e88d29ed"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("64e0630e-9b06-4885-95f7-834fba630a99"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("55815150-502b-4b0d-ac37-f709045c41f2"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,201,78,195,48,16,134,207,205,83,88,61,185,18,242,11,176,72,93,16,234,161,11,180,229,130,56,24,103,218,24,18,39,181,157,162,8,245,221,241,22,112,11,69,21,151,170,177,103,254,249,231,27,207,142,74,196,74,145,114,205,75,241,72,243,26,20,186,70,2,222,209,136,51,123,70,101,115,117,87,243,244,2,41,45,185,216,220,224,222,101,178,51,89,5,104,58,167,58,51,225,138,101,80,208,149,2,185,164,234,141,204,169,164,230,22,164,34,119,160,7,205,212,124,225,238,8,24,87,86,48,31,150,121,93,136,73,200,239,26,61,190,70,216,203,147,177,154,214,121,62,147,183,69,165,27,220,22,33,139,178,150,12,156,65,226,126,123,61,244,145,116,36,232,90,138,227,14,46,147,189,179,88,190,188,2,211,11,231,110,156,158,107,116,118,144,213,13,237,130,208,92,55,254,212,40,213,70,99,88,10,1,14,18,185,141,110,39,84,208,13,72,43,57,22,74,83,193,96,208,172,198,41,78,58,150,171,133,137,15,157,253,214,157,175,202,28,42,83,47,46,111,149,253,63,79,114,208,180,44,255,226,21,218,80,219,48,223,216,242,125,13,178,193,190,24,121,128,53,72,48,174,253,157,227,108,144,245,211,130,139,7,190,201,180,125,33,107,154,43,72,246,94,180,146,188,48,239,100,248,101,86,109,73,63,77,253,247,9,89,50,143,147,136,69,31,44,166,92,85,57,253,151,216,200,165,30,105,250,70,205,89,238,135,229,89,114,247,208,173,184,161,121,28,130,15,199,107,68,214,165,4,202,50,132,125,104,152,7,226,223,106,142,147,29,110,139,195,97,255,26,157,45,179,108,42,8,141,184,75,183,88,55,230,93,116,66,76,232,198,135,196,143,178,250,9,139,68,66,161,211,142,223,161,64,240,28,3,237,78,159,97,33,30,203,105,7,71,155,248,20,179,120,54,94,98,107,118,77,79,44,240,39,249,246,35,63,151,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3493d757-79f3-4070-be84-78a026a71c3b"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a4d800a7-ef4c-4d19-8dea-592100c4a66a"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,219,110,226,48,16,125,78,190,194,188,84,142,132,242,1,32,180,66,52,173,34,109,47,226,242,1,38,30,168,119,29,27,217,14,91,118,197,191,239,24,7,10,14,221,109,213,151,40,242,204,156,51,115,230,178,212,90,18,97,199,149,19,91,225,118,133,114,248,157,85,47,80,51,50,34,247,224,202,171,54,154,13,211,251,70,112,194,90,227,204,49,215,216,146,99,208,117,180,52,249,70,124,68,94,212,27,183,75,147,1,121,54,186,2,107,23,22,204,156,217,159,11,39,164,112,2,108,142,172,227,11,88,234,125,38,90,41,192,103,173,250,100,210,24,3,234,228,85,114,76,71,172,8,61,228,251,192,28,50,114,244,231,194,187,91,154,101,228,79,154,120,135,222,59,165,222,220,116,43,233,141,200,209,23,177,172,179,249,132,169,10,36,240,224,178,64,90,143,155,92,209,32,14,212,245,70,130,59,139,28,166,201,62,77,46,235,202,203,86,146,66,173,133,130,124,10,181,222,194,17,170,181,125,23,214,129,2,67,59,26,244,201,194,127,226,108,80,154,80,250,63,154,25,234,216,50,67,0,53,123,208,28,176,6,58,133,74,27,94,180,47,89,161,154,58,159,235,167,229,15,76,151,186,221,6,244,42,246,233,147,211,47,210,38,129,101,242,194,212,26,230,24,64,32,126,24,157,49,142,200,37,90,254,8,191,16,4,7,39,198,201,75,133,202,161,158,222,60,232,154,23,27,206,208,234,83,248,136,196,177,180,33,13,47,102,40,54,200,116,82,56,46,34,11,205,12,3,136,241,72,125,11,149,176,126,246,238,140,174,39,90,54,181,10,26,79,193,54,210,61,51,195,106,156,7,19,118,44,122,164,45,160,1,215,24,69,150,204,194,105,130,138,87,168,26,39,212,154,110,142,238,22,221,247,135,241,255,98,199,174,119,0,243,78,210,196,58,131,164,4,197,20,76,138,223,192,239,132,244,220,88,64,187,113,111,251,230,183,169,23,2,242,210,62,54,82,62,153,195,214,211,91,230,216,76,55,166,130,54,60,75,125,123,49,116,139,237,156,235,182,17,29,55,26,247,225,42,208,128,40,228,26,254,111,173,198,156,127,178,225,157,170,125,131,138,179,77,17,202,101,145,114,197,43,130,163,2,199,222,116,143,68,231,74,160,216,151,151,229,221,11,57,251,252,133,236,199,108,165,66,248,181,241,248,135,35,177,79,219,121,91,49,105,97,248,23,32,70,172,18,25,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsMatchedConditionsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c54b73fb-b703-43c7-b324-b86f5e53932e"),
				Name = "GetIsMatchedConditions",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,61,111,194,48,16,157,241,175,48,11,10,18,138,232,28,49,80,74,81,6,62,83,166,170,131,155,92,192,109,98,211,59,167,85,84,248,239,117,226,12,9,180,234,150,248,222,189,247,238,221,201,148,123,253,144,150,194,196,199,153,86,137,52,82,43,226,231,51,39,131,82,29,252,144,86,69,150,173,113,158,159,76,233,61,8,35,34,93,96,12,143,50,51,128,52,28,242,111,214,67,48,5,42,110,176,128,128,93,216,19,32,10,210,169,241,103,26,193,159,43,99,105,129,220,71,25,197,71,200,5,135,246,207,132,239,9,208,26,80,16,87,14,58,208,165,80,226,0,232,47,192,132,138,140,80,49,220,151,251,48,241,214,175,111,22,238,64,97,50,12,216,167,64,14,244,97,233,20,124,241,54,199,182,0,44,189,255,69,70,29,95,254,74,228,80,79,104,59,167,73,46,213,78,30,142,134,172,64,42,50,2,118,9,152,213,243,167,73,50,211,89,145,43,175,211,189,65,153,11,44,93,201,113,5,108,131,58,6,162,202,202,147,160,247,189,145,153,75,39,58,65,44,211,114,30,109,155,108,175,236,142,184,57,74,234,26,28,85,227,142,248,237,90,2,38,237,102,43,111,205,139,93,69,161,12,159,76,248,248,183,149,253,137,190,171,209,85,176,105,93,90,160,46,78,118,254,22,248,121,252,194,5,221,198,237,202,118,250,204,13,16,176,94,37,211,230,233,219,77,217,243,226,131,65,155,254,218,107,215,108,239,98,253,58,177,38,139,198,142,189,15,247,124,19,220,14,98,141,73,125,34,13,85,211,216,232,7,63,149,203,14,150,7,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetResultParameterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2cd8f233-356c-4dd3-9845-6653840fba2c"),
				Name = "GetResultParameter",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,203,110,194,48,16,60,55,95,225,114,50,18,178,122,167,84,130,20,80,14,60,74,95,103,55,94,136,43,199,1,123,221,42,170,248,247,218,113,138,2,168,55,123,61,222,153,157,29,185,37,212,162,145,122,199,50,187,116,74,173,204,180,220,99,77,31,33,151,86,86,154,171,180,82,174,212,11,64,190,230,88,244,251,228,39,185,49,128,206,104,50,119,82,176,6,63,76,142,73,184,17,3,214,41,92,115,195,75,64,48,153,32,163,51,216,23,55,4,52,74,172,159,243,2,74,238,159,95,45,152,180,210,26,114,244,132,108,218,121,93,112,205,119,96,216,28,48,211,22,185,206,97,82,191,102,130,174,62,62,61,60,130,50,209,143,125,243,70,233,169,111,151,38,116,136,167,56,206,164,254,27,232,255,73,91,177,246,224,123,105,248,38,93,97,79,14,76,77,187,12,141,47,126,148,177,40,165,222,200,93,129,214,255,219,114,101,33,57,118,245,5,101,246,192,198,66,68,62,218,149,205,150,222,55,207,28,16,51,169,188,131,54,32,105,184,167,6,56,66,172,190,75,44,78,38,91,26,139,105,85,238,185,145,182,210,47,245,30,216,244,224,184,26,144,94,38,122,3,178,129,188,50,194,91,229,155,199,65,60,187,138,150,183,75,235,20,162,68,239,217,37,148,158,47,203,55,147,62,65,151,255,89,90,57,141,228,118,68,238,218,184,92,135,226,234,207,76,26,139,236,141,43,7,129,57,140,208,58,212,212,238,67,138,30,90,179,34,172,89,194,88,73,110,251,33,127,109,40,175,200,134,191,190,5,20,241,229,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("60e3bca1-83e7-48f8-8fcb-3712356da5ef"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6d564a30-e3b5-4491-bf08-209dca3b5b4e"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,203,106,195,48,16,60,199,95,161,222,100,8,250,128,6,83,138,49,193,208,23,73,252,1,138,53,113,84,234,149,145,214,105,67,233,191,87,193,118,104,221,75,47,203,50,51,204,236,206,94,7,168,92,83,141,183,226,3,117,207,150,26,217,105,175,91,48,124,72,87,73,21,224,115,71,132,154,173,35,85,190,120,87,35,132,130,26,75,80,27,180,238,132,251,200,157,44,159,71,238,193,6,6,193,203,188,247,30,196,19,93,154,165,168,46,99,2,162,111,224,48,230,195,108,89,115,31,162,34,198,218,131,144,55,107,112,25,38,113,65,28,231,182,62,162,213,50,77,197,103,178,56,105,47,96,44,63,58,3,145,9,185,65,237,188,41,70,36,45,168,111,213,206,61,239,95,227,241,146,207,29,220,97,174,89,138,235,186,74,22,67,70,126,212,212,96,23,245,2,115,32,251,17,152,137,223,102,234,9,239,226,78,204,77,84,73,177,67,134,17,183,127,185,170,51,58,82,49,251,63,69,207,11,30,242,47,149,14,79,14,237,92,123,158,95,31,95,252,250,6,51,253,72,119,242,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateAccompaningActivityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ff512fc9-57f9-4c8d-a559-7af588072975"),
				Name = "CreateAccompaningActivity",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Entity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,193,110,219,48,12,61,219,95,161,230,228,12,174,177,157,131,29,218,36,24,124,104,27,212,233,238,130,69,39,194,108,57,160,228,6,198,208,127,31,21,75,142,146,45,94,79,54,169,199,199,71,82,212,90,25,105,250,162,220,67,195,25,47,141,124,63,155,223,217,155,6,92,182,74,1,29,180,42,91,7,224,39,174,248,14,48,251,1,38,87,218,112,85,194,99,255,204,27,72,102,15,142,102,54,95,196,67,200,200,76,156,151,73,178,37,2,55,48,192,146,203,124,20,238,193,25,157,60,136,70,170,87,185,219,27,77,52,21,175,53,44,98,109,80,170,29,163,232,26,200,75,106,124,246,173,117,37,33,71,1,102,217,214,93,163,126,242,186,35,157,39,196,44,29,130,175,128,43,168,2,172,158,230,233,15,144,11,34,242,169,169,4,109,116,182,229,250,151,61,123,203,5,133,175,168,204,173,108,128,81,179,208,88,107,208,235,253,87,197,103,203,14,17,148,177,94,219,100,103,142,232,121,202,10,75,148,171,52,142,146,13,182,37,104,189,234,144,219,224,13,160,108,197,220,1,156,53,81,65,225,37,81,17,163,188,80,179,240,63,151,146,71,108,202,124,234,148,221,16,115,101,78,168,89,117,224,180,248,180,83,232,177,233,132,221,181,216,95,78,194,57,39,139,223,183,199,92,217,235,40,186,26,144,162,175,60,20,44,43,150,188,28,21,96,46,216,29,245,160,147,34,91,55,7,211,207,217,239,56,186,73,237,66,136,210,253,17,85,100,185,94,129,238,178,120,132,170,69,176,132,95,79,60,183,137,6,252,182,61,209,216,43,139,157,109,74,20,253,127,48,247,223,216,23,22,230,187,57,161,16,52,78,233,179,162,254,158,88,244,17,127,196,197,1,74,89,245,231,205,8,118,202,19,135,195,217,160,108,56,134,56,230,218,253,12,71,251,181,155,152,235,51,95,115,168,193,128,56,191,8,110,81,60,34,23,193,155,243,15,250,69,140,96,58,84,35,102,241,7,154,126,182,221,19,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDateTimeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("84d274e2-57a1-41d3-aada-d220a5a4bee9"),
				Name = "GetDateTime",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "DateTime"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5347997b-c1fa-4d42-8cf7-b2d60a829722"),
				Name = "dateTime",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("06b9ef40-3300-45c8-a2df-8368e433ed77"),
				Name = "offset",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0e04e20f-12ff-43fe-b67e-a38c6abfd44c"),
				Name = "offsetPeriod",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessDurationPeriod",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,207,44,73,206,208,200,79,75,43,78,45,9,72,45,202,204,79,209,84,168,230,229,226,76,73,77,75,44,205,41,177,2,50,147,19,139,83,21,2,138,242,147,83,139,139,93,74,139,18,75,50,243,243,32,74,245,124,51,243,74,75,82,139,65,170,56,139,82,75,74,139,242,20,82,18,75,82,67,50,115,83,245,28,83,82,160,210,80,227,53,173,241,27,230,145,95,90,132,211,40,176,36,145,6,185,36,86,226,52,7,36,71,164,49,225,169,169,217,196,152,163,101,78,200,36,223,252,188,146,12,220,161,4,150,69,114,84,45,0,203,152,96,213,150,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cdb8aaa7-c567-49d1-817a-8584e516860b"),
				Name = "GetActivityType",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,193,106,3,33,16,134,207,187,79,49,201,33,236,94,124,129,176,151,132,37,44,37,77,104,155,222,173,78,186,150,221,49,184,90,144,146,119,175,70,161,66,65,16,199,111,230,255,180,39,171,172,127,21,35,206,28,176,60,116,112,89,208,236,53,17,10,171,52,177,190,184,61,114,226,159,104,216,1,237,64,139,229,36,112,231,47,131,108,78,31,95,1,79,208,32,219,109,125,213,6,185,24,155,111,110,64,232,201,205,244,206,39,135,160,8,94,80,104,35,247,127,197,133,165,173,133,159,186,42,227,18,147,251,131,89,41,26,29,74,106,231,143,104,249,153,219,177,41,242,216,19,250,96,83,169,43,228,50,123,230,51,66,215,193,250,205,223,112,13,155,77,233,151,76,96,213,1,185,105,122,8,85,241,9,54,176,131,12,10,205,193,41,217,254,235,8,17,143,140,204,133,254,200,177,126,190,89,159,166,84,6,173,51,148,39,69,254,94,135,117,175,115,253,28,62,54,26,133,223,220,254,2,201,18,170,94,158,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityTitleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a183ad5c-bfc0-44fc-ad97-eb22f5ec7755"),
				Name = "GetActivityTitle",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,202,49,10,128,48,16,4,192,175,164,84,8,126,192,74,44,196,78,196,60,32,36,11,30,106,2,119,171,224,239,237,156,122,20,188,181,184,69,107,130,89,48,232,22,237,8,148,83,40,176,110,2,135,68,121,132,239,38,60,209,112,23,243,110,69,170,215,133,146,35,165,22,239,198,91,21,229,175,115,110,251,15,79,127,220,206,90,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("75e3b674-193e-4e41-bd29-a6eef00bf794"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,77,111,219,48,12,61,219,191,66,200,161,176,129,192,216,185,89,59,52,169,81,24,203,23,154,100,151,97,7,213,102,18,173,182,148,73,114,91,111,237,127,47,245,49,199,110,211,237,146,88,228,35,249,248,72,41,229,154,233,102,149,239,161,162,4,186,135,11,178,81,32,39,130,115,200,53,19,60,73,59,222,25,229,116,7,50,185,1,157,113,165,41,207,97,220,108,178,34,90,220,253,68,184,3,101,69,60,10,31,168,36,5,108,105,93,234,137,40,235,138,127,163,101,13,10,211,115,120,36,215,204,230,166,178,249,172,180,100,124,55,36,194,102,184,140,48,118,43,36,208,124,31,153,28,249,49,152,48,78,110,33,23,178,232,102,76,220,95,76,254,132,193,49,0,235,116,187,50,132,221,151,11,29,55,51,208,116,73,245,62,234,20,72,190,66,131,229,3,182,37,145,183,39,215,84,83,235,92,55,7,100,160,200,84,136,251,250,208,55,63,63,147,143,224,51,20,128,157,136,137,195,32,8,206,206,176,208,77,205,138,184,203,194,254,198,73,250,171,166,165,178,238,36,173,14,186,137,109,143,65,46,176,49,94,3,18,125,9,131,19,26,127,247,92,230,180,130,31,40,196,10,36,163,37,251,13,19,212,213,77,211,193,125,143,67,242,190,250,40,124,177,35,132,130,233,153,40,0,211,68,78,251,212,91,226,148,215,85,178,22,110,242,145,198,158,196,246,45,102,72,218,207,81,104,100,61,230,187,32,125,108,50,135,71,219,224,169,142,6,75,41,114,80,106,202,148,6,14,82,13,254,221,88,111,246,206,166,204,14,140,27,35,74,244,62,93,60,68,101,35,198,117,236,243,236,41,223,217,65,37,184,232,32,53,20,86,19,183,173,132,218,245,53,185,144,6,230,189,106,207,102,127,37,232,90,242,35,189,181,88,217,176,200,172,62,118,120,112,213,179,2,131,61,19,115,231,214,84,221,111,52,43,153,102,96,217,46,169,196,70,150,127,209,209,226,17,185,26,166,38,65,90,110,108,2,252,69,11,119,84,12,3,60,49,229,131,210,39,200,107,228,62,110,86,108,199,105,249,159,130,217,71,113,253,210,8,240,173,91,115,226,171,58,81,208,122,84,7,173,221,81,248,168,222,116,60,76,218,101,176,29,221,250,79,159,242,1,177,183,71,239,164,150,70,149,43,239,177,48,19,92,85,192,11,234,25,248,145,24,192,154,233,18,167,98,84,225,248,176,84,22,178,224,43,13,7,4,78,69,110,70,68,239,74,112,51,74,50,53,175,203,114,33,237,149,139,178,183,49,49,249,66,56,2,200,57,121,231,115,119,103,216,174,112,251,228,157,88,105,220,202,154,107,114,73,62,97,194,83,15,229,57,177,117,140,130,118,24,88,5,31,101,13,79,26,19,166,111,76,136,66,5,14,37,104,104,93,189,65,152,251,54,160,69,49,48,35,164,110,179,221,254,249,131,93,38,20,174,125,109,144,150,91,118,127,60,239,66,147,118,165,141,176,28,25,44,59,43,57,232,25,108,63,131,240,37,30,189,2,20,217,249,250,117,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetConditionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f466893b-82a3-43d8-b001-161a357886b7"),
				Name = "GetConditionData",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1471c6c9-2565-413e-8c50-18727a4cda18"),
				Name = "resultColumntUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("eeb849f4-e912-42c7-b507-61e9594d3e06"),
				Name = "activity",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,138,59,10,128,48,12,64,175,210,81,161,120,1,71,5,113,115,176,7,8,54,67,176,166,144,164,130,183,55,29,223,71,208,154,112,56,164,94,168,154,20,229,4,189,147,81,33,35,212,105,67,91,42,103,135,202,43,24,12,125,113,195,120,117,21,131,160,182,226,79,105,15,91,218,115,12,224,229,37,251,198,249,7,251,46,241,225,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSerializeCoreEntityColumnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("79587080-1c50-4b07-8658-dcf2a2788e41"),
				Name = "SerializeCoreEntityColumn",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8"),
				ResultValueTypeName = "object"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a98ef862-57fe-4988-8cea-1352ec341dfa"),
				Name = "schemaColumn",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchemaColumn",
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("717948b0-5849-4213-b413-1c6d08a6af4c"),
				Name = "columnValue",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object",
				CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,219,110,212,48,16,125,78,190,194,188,57,82,228,126,192,182,149,96,119,139,42,46,170,216,93,42,241,102,146,89,106,225,216,193,151,66,160,251,239,216,206,5,59,155,162,62,37,153,241,57,115,230,204,56,236,136,176,174,30,160,161,107,201,109,35,208,213,21,18,150,115,244,244,132,170,16,249,76,185,133,49,92,160,63,121,166,192,88,37,144,54,138,137,111,100,219,180,166,91,229,167,156,205,168,200,134,26,26,208,251,174,5,196,52,122,35,37,7,42,146,120,204,232,19,62,118,48,140,51,195,64,147,112,236,181,246,193,203,175,14,125,141,35,81,197,98,213,91,253,94,202,239,182,157,200,123,157,67,55,53,211,45,167,93,192,175,242,236,145,42,212,42,214,80,213,173,227,110,209,64,118,71,21,109,192,128,194,255,215,246,214,178,58,213,86,12,236,10,142,160,64,84,176,11,34,29,117,162,246,83,154,30,64,177,202,29,112,168,140,195,229,89,38,224,39,234,191,241,65,131,90,75,33,220,59,147,162,112,201,140,244,156,120,86,146,220,245,13,110,122,210,161,240,71,215,151,71,145,27,37,155,51,200,148,189,127,112,241,231,24,99,42,231,251,246,135,165,28,159,219,89,32,170,7,217,171,105,214,190,21,55,28,215,110,111,120,228,93,233,194,177,3,46,123,110,8,217,254,130,202,26,167,136,114,170,46,251,33,95,99,39,250,228,215,34,184,72,13,236,89,3,233,30,206,6,144,38,157,208,205,18,106,21,246,108,153,240,85,116,53,226,178,174,18,30,201,138,168,61,231,65,76,230,175,214,120,140,124,96,163,101,222,155,209,42,199,238,64,167,20,71,222,49,81,251,226,35,216,127,147,131,208,45,84,236,200,160,238,57,146,75,252,175,208,46,156,234,60,102,98,44,159,167,234,203,95,92,164,91,71,214,86,185,181,48,62,74,60,238,139,20,48,93,184,199,89,205,196,53,178,3,197,40,103,191,33,190,53,229,242,204,66,171,37,26,43,220,138,163,36,7,83,21,231,219,84,207,70,141,153,48,197,50,231,94,110,133,109,112,81,70,75,24,158,195,6,189,232,159,52,174,93,242,87,250,11,244,192,238,189,84,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsActivityEntitySchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("093a2506-3c5e-495f-a788-2a7dbc8f0f65"),
				Name = "GetIsActivityEntitySchema",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,79,202,74,77,46,9,78,206,72,205,77,244,76,81,176,181,85,80,112,79,45,113,76,46,201,44,203,44,169,116,205,43,1,146,16,217,80,207,20,13,77,107,0,175,167,196,110,55,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActionNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d9ab0462-eae8-4fc2-813e-d3deae7ba908"),
				Name = "GetActionName",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,65,10,194,48,16,69,215,201,41,134,174,18,144,94,160,116,225,34,136,11,21,212,11,196,100,138,17,154,72,156,84,139,237,221,109,139,84,234,102,24,222,188,255,167,209,17,208,58,218,5,139,80,130,56,162,9,209,170,47,145,202,167,58,63,135,195,229,134,134,4,181,119,12,213,191,179,130,121,45,184,171,64,252,250,74,88,186,249,30,159,18,222,156,141,218,6,105,251,88,27,114,141,163,86,121,26,230,201,92,177,214,66,66,215,193,116,86,47,52,137,208,10,57,197,88,68,74,209,67,54,190,200,10,206,122,224,51,211,214,14,168,231,75,231,3,171,140,241,88,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityEntitySchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fa8c9025-6025-42c9-a823-a607fb06186a"),
				Name = "GetActivityEntitySchemaUId",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,76,46,201,44,203,44,169,116,206,207,43,46,41,214,131,113,93,243,74,128,100,112,114,70,106,110,98,168,103,138,53,0,165,56,27,204,46,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateActivityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2754b08c-766d-46cf-8f3d-0f1909636795"),
				Name = "CreateActivity",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "Entity"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,205,110,226,48,16,62,59,79,225,229,80,37,82,229,23,136,122,160,192,34,180,165,66,165,221,187,215,153,128,119,19,59,117,236,74,81,203,187,239,196,193,196,105,233,133,8,207,247,231,153,241,74,89,105,187,189,56,66,205,41,23,86,190,141,127,239,232,75,11,102,161,149,2,44,104,197,86,17,120,203,21,63,128,97,107,176,27,213,90,174,4,220,119,143,188,134,116,54,63,203,204,178,60,25,40,23,101,212,156,154,176,133,1,110,97,128,165,83,63,164,7,48,195,202,188,168,165,122,146,135,163,109,81,166,228,85,11,121,210,90,35,213,225,34,250,44,109,5,88,197,84,243,248,40,141,181,246,96,23,186,114,181,250,205,43,135,121,61,98,118,59,21,249,68,88,66,25,113,218,94,175,212,24,93,28,211,55,110,168,24,107,84,42,250,4,66,155,34,38,176,225,147,209,247,132,196,109,28,48,103,254,215,238,224,61,98,220,125,183,5,203,119,220,30,211,200,145,253,130,14,243,16,89,210,244,124,206,150,220,114,95,124,238,26,140,212,210,7,173,255,185,102,122,252,241,65,191,131,111,93,101,229,21,78,150,16,66,110,110,208,104,237,100,145,197,41,252,111,198,86,175,14,71,227,203,108,85,55,182,203,252,165,137,208,120,109,229,112,102,228,148,144,239,134,49,8,222,210,175,194,121,114,74,198,86,47,181,112,53,40,27,181,140,133,141,242,128,150,253,148,170,8,43,25,224,253,74,246,109,250,36,242,227,142,42,87,85,62,168,254,243,23,215,143,22,87,12,214,215,178,6,145,48,129,226,154,40,137,242,14,157,11,48,223,142,83,178,111,64,200,178,11,75,59,217,181,224,143,14,11,103,12,146,2,108,83,196,241,118,70,214,220,196,220,60,217,180,163,100,221,84,96,161,24,31,207,14,95,112,63,212,23,175,19,191,25,60,236,87,220,128,117,70,93,28,242,255,196,160,66,101,46,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivityEntitySchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d2f0bec7-8821-4d44-9aa5-3d3e7c26ec25"),
				Name = "GetActivityEntitySchema",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("f69f6aca-d587-4abd-9a90-ac4521baf251"),
				ResultValueTypeName = "EntitySchema"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,80,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,205,43,201,44,169,12,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,241,204,43,46,73,204,75,78,117,170,244,75,204,77,213,80,114,4,170,46,3,42,84,210,180,6,0,3,240,1,151,73,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsExecutedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0bc78e13-2b06-4ac0-ab8d-33d3a944e577"),
				Name = "GetIsExecuted",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("ed4eb7f3-db37-45ed-a4f6-bdc24b7921d2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,77,107,195,48,12,61,39,144,255,96,122,82,46,254,3,35,151,52,89,241,97,31,180,148,157,221,88,180,25,137,204,100,155,173,140,254,247,57,117,88,50,216,73,210,211,211,123,79,45,249,222,95,15,221,5,71,45,112,61,84,226,232,144,183,150,8,59,223,91,146,237,106,251,164,73,159,145,229,14,189,34,231,53,117,88,95,143,202,192,203,233,61,210,19,73,153,242,161,200,15,56,68,68,184,84,42,1,9,40,9,63,69,106,225,175,81,41,139,60,219,218,33,140,4,27,101,54,247,249,145,237,8,235,124,242,89,143,120,95,189,93,144,113,102,42,215,126,4,61,64,58,151,175,154,35,203,35,195,30,59,203,38,38,154,34,5,215,211,89,64,83,183,95,216,5,111,89,152,211,111,251,207,223,46,48,54,245,2,65,89,138,239,232,60,235,168,70,123,189,71,109,48,10,45,109,53,255,44,147,52,38,24,22,171,89,37,99,244,129,105,117,42,167,2,83,210,236,86,228,183,31,141,134,28,45,164,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSpecifyActivityColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a84206ee-67cd-4eab-9dc9-7fe7c0f214b5"),
				Name = "SpecifyActivityColumnValues",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("82999912-2a7e-440e-80c4-136bdd1fb9ea"),
				Name = "activity",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,148,193,110,195,32,12,134,239,123,138,168,167,86,170,250,2,85,15,40,155,182,72,149,86,181,235,238,140,120,45,43,129,12,76,167,190,253,12,33,90,118,217,101,62,249,183,12,31,232,7,91,40,212,87,141,183,99,0,255,34,195,229,9,76,15,126,117,232,65,233,247,155,40,213,173,115,151,216,215,206,196,206,190,74,19,97,46,75,101,89,205,132,82,46,90,156,45,171,162,22,235,59,241,127,108,237,44,82,74,216,162,120,176,91,144,45,49,83,224,1,62,247,189,243,24,45,101,196,157,100,60,248,123,167,98,7,217,222,81,242,128,27,123,117,90,1,113,139,98,122,54,25,18,51,5,190,127,224,127,62,130,103,251,9,245,89,218,83,190,107,22,60,208,61,24,24,28,40,138,7,187,243,238,205,64,71,216,162,216,176,31,144,173,45,138,169,37,124,11,62,53,67,138,92,190,126,70,8,24,178,177,131,100,154,7,58,160,182,167,52,18,6,197,230,44,109,201,35,97,148,4,30,23,172,14,128,211,141,105,185,130,16,30,232,101,169,193,155,52,161,142,77,26,80,1,61,221,169,146,198,184,47,104,247,16,162,193,106,83,61,2,14,90,12,133,140,9,243,191,142,16,83,4,241,127,33,23,235,111,35,143,172,42,9,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("61e15473-85ae-4655-8c76-7cc7a1b8153f"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			return new OpenEditPageUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new OpenEditPageUserTask(userConnection) {
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
		}

		#endregion

	}

	#endregion

	#region Class: OpenEditPageUserTaskSchemaExtension

	/// <exclude/>
	public class OpenEditPageUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var conditionValues = new Dictionary<Guid, string>();
			var metaPath = schemaUserTask.Parameters.GetByName("DecisionalColumnMetaPath");
			if (string.IsNullOrEmpty(metaPath.SourceValue.Value)) {
				return conditionValues;
			}
			var objectSchemaId = schemaUserTask.Parameters.GetByName("ObjectSchemaId");
			var entitySchema = userConnection.EntitySchemaManager.GetInstanceByUId(
				new Guid(objectSchemaId.SourceValue.Value));
			var column = entitySchema.GetSchemaColumnByMetaPath(metaPath.SourceValue.Value);
			var esq = new EntitySchemaQuery(column.ReferenceSchema) {
				UseAdminRights = false
			};
			var primaryColumn = esq.AddColumn(column.ReferenceSchema.PrimaryColumn.Name);
			var displaColumn = esq.AddColumn(column.ReferenceSchema.PrimaryDisplayColumn.Name);
			EntityCollection entities = esq.GetEntityCollection(userConnection);
			foreach (Entity entity in entities) {
				Guid primaryValue = entity.GetTypedColumnValue<Guid>(
					entity.Schema.Columns.GetByName(primaryColumn.Name).ColumnValueName);
				string displayValue = entity.GetTypedColumnValue<string>(
					entity.Schema.Columns.GetByName(displaColumn.Name).ColumnValueName);
				conditionValues[primaryValue] = displayValue;
			}
			return conditionValues;
		}

		#endregion

	}

	#endregion

	#region Class: OpenEditPageUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Recommendation.Group", DescriptionResourceItem = "Parameters.Recommendation.Group")]
	[DesignModeGroup(Name = "Connected to", Position = 2, UseSolutionStorage = true, ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Lead.Group", DescriptionResourceItem = "Parameters.Lead.Group")]
	[DesignModeProperty(Name = "ObjectSchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ObjectSchemaId.Caption", DescriptionResourceItem = "Parameters.ObjectSchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PageSchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.PageSchemaId.Caption", DescriptionResourceItem = "Parameters.PageSchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EditMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.EditMode.Caption", DescriptionResourceItem = "Parameters.EditMode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordColumnValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.RecordColumnValues.Caption", DescriptionResourceItem = "Parameters.RecordColumnValues.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExecutedMode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ExecutedMode.Caption", DescriptionResourceItem = "Parameters.ExecutedMode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsMatchConditions", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.IsMatchConditions.Caption", DescriptionResourceItem = "Parameters.IsMatchConditions.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "GenerateDecisionsFromColumn", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.GenerateDecisionsFromColumn.Caption", DescriptionResourceItem = "Parameters.GenerateDecisionsFromColumn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DecisionalColumnMetaPath", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.DecisionalColumnMetaPath.Caption", DescriptionResourceItem = "Parameters.DecisionalColumnMetaPath.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultParameter", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ResultParameter.Caption", DescriptionResourceItem = "Parameters.ResultParameter.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsReexecution", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.IsReexecution.Caption", DescriptionResourceItem = "Parameters.IsReexecution.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityCategory", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ActivityCategory.Caption", DescriptionResourceItem = "Parameters.ActivityCategory.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duration", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Duration.Caption", DescriptionResourceItem = "Parameters.Duration.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DurationPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.DurationPeriod.Caption", DescriptionResourceItem = "Parameters.DurationPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartIn", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.StartIn.Caption", DescriptionResourceItem = "Parameters.StartIn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartInPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.StartInPeriod.Caption", DescriptionResourceItem = "Parameters.StartInPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBefore", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.RemindBefore.Caption", DescriptionResourceItem = "Parameters.RemindBefore.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBeforePeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.RemindBeforePeriod.Caption", DescriptionResourceItem = "Parameters.RemindBeforePeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowInScheduler", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ShowInScheduler.Caption", DescriptionResourceItem = "Parameters.ShowInScheduler.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Lead", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Lead.Caption", DescriptionResourceItem = "Parameters.Lead.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Account", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Account.Caption", DescriptionResourceItem = "Parameters.Account.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Opportunity", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Opportunity.Caption", DescriptionResourceItem = "Parameters.Opportunity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Invoice", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Invoice.Caption", DescriptionResourceItem = "Parameters.Invoice.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Document", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Document.Caption", DescriptionResourceItem = "Parameters.Document.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Incident", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Incident.Caption", DescriptionResourceItem = "Parameters.Incident.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Case", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Case.Caption", DescriptionResourceItem = "Parameters.Case.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityResult", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ActivityResult.Caption", DescriptionResourceItem = "Parameters.ActivityResult.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentActivityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.CurrentActivityId.Caption", DescriptionResourceItem = "Parameters.CurrentActivityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActivityCompleted", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.IsActivityCompleted.Caption", DescriptionResourceItem = "Parameters.IsActivityCompleted.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExecutionContext", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ExecutionContext.Caption", DescriptionResourceItem = "Parameters.ExecutionContext.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PageTypeUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.PageTypeUId.Caption", DescriptionResourceItem = "Parameters.PageTypeUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivitySchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.ActivitySchemaUId.Caption", DescriptionResourceItem = "Parameters.ActivitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Order", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Order.Caption", DescriptionResourceItem = "Parameters.Order.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Requests", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Requests.Caption", DescriptionResourceItem = "Parameters.Requests.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Listing", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Listing.Caption", DescriptionResourceItem = "Parameters.Listing.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Property", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Property.Caption", DescriptionResourceItem = "Parameters.Property.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contract", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Contract.Caption", DescriptionResourceItem = "Parameters.Contract.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Problem", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Problem.Caption", DescriptionResourceItem = "Parameters.Problem.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Change", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Change.Caption", DescriptionResourceItem = "Parameters.Change.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Release", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Release.Caption", DescriptionResourceItem = "Parameters.Release.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Project", Group = "Connected to", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b0d3ad9f7a2746a39483ed70c26872ae", CaptionResourceItem = "Parameters.Project.Caption", DescriptionResourceItem = "Parameters.Project.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class OpenEditPageUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public OpenEditPageUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ObjectSchemaId {
			get;
			set;
		}

		public virtual Guid PageSchemaId {
			get;
			set;
		}

		public virtual int EditMode {
			get;
			set;
		}

		private EntityColumnMappingValues _recordColumnValues;
		public virtual EntityColumnMappingValues RecordColumnValues {
			get {
				return _recordColumnValues ?? ( _recordColumnValues = new EntityColumnMappingValues (
					new Dictionary<string, object>(),
					new Dictionary<string, string>()));
			}
			set {
				_recordColumnValues = value;
			}
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual int ExecutedMode {
			get;
			set;
		}

		public virtual bool IsMatchConditions {
			get;
			set;
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		public virtual bool GenerateDecisionsFromColumn {
			get;
			set;
		}

		public virtual string DecisionalColumnMetaPath {
			get;
			set;
		}

		public virtual Guid ResultParameter {
			get;
			set;
		}

		public virtual bool IsReexecution {
			get;
			set;
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

		public virtual Guid PageTypeUId {
			get;
			set;
		}

		public virtual Guid ActivitySchemaUId {
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

		public virtual Guid Project {
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
			if (!HasMapping("ObjectSchemaId")) {
				writer.WriteValue("ObjectSchemaId", ObjectSchemaId, Guid.Empty);
			}
			if (!HasMapping("PageSchemaId")) {
				writer.WriteValue("PageSchemaId", PageSchemaId, Guid.Empty);
			}
			if (!HasMapping("EditMode")) {
				writer.WriteValue("EditMode", EditMode, 0);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("ExecutedMode")) {
				writer.WriteValue("ExecutedMode", ExecutedMode, 0);
			}
			if (!HasMapping("IsMatchConditions")) {
				writer.WriteValue("IsMatchConditions", IsMatchConditions, false);
			}
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			if (!HasMapping("GenerateDecisionsFromColumn")) {
				writer.WriteValue("GenerateDecisionsFromColumn", GenerateDecisionsFromColumn, false);
			}
			if (!HasMapping("DecisionalColumnMetaPath")) {
				writer.WriteValue("DecisionalColumnMetaPath", DecisionalColumnMetaPath, null);
			}
			if (!HasMapping("ResultParameter")) {
				writer.WriteValue("ResultParameter", ResultParameter, Guid.Empty);
			}
			if (!HasMapping("IsReexecution")) {
				writer.WriteValue("IsReexecution", IsReexecution, false);
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
			if (!HasMapping("PageTypeUId")) {
				writer.WriteValue("PageTypeUId", PageTypeUId, Guid.Empty);
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("ActivitySchemaUId")) {
					writer.WriteValue("ActivitySchemaUId", ActivitySchemaUId, Guid.Empty);
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
			if (!HasMapping("Problem")) {
				writer.WriteValue("Problem", Problem, Guid.Empty);
			}
			if (!HasMapping("Change")) {
				writer.WriteValue("Change", Change, Guid.Empty);
			}
			if (!HasMapping("Release")) {
				writer.WriteValue("Release", Release, Guid.Empty);
			}
			if (!HasMapping("Project")) {
				writer.WriteValue("Project", Project, Guid.Empty);
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
				case "ObjectSchemaId":
					ObjectSchemaId = reader.GetGuidValue();
				break;
				case "PageSchemaId":
					PageSchemaId = reader.GetGuidValue();
				break;
				case "EditMode":
					EditMode = reader.GetIntValue();
				break;
				case "RecordColumnValues":
					if (UseFlowEngineMode) {
						RecordColumnValues = reader.GetValue<EntityColumnMappingValues>();
					}
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "ExecutedMode":
					ExecutedMode = reader.GetIntValue();
				break;
				case "IsMatchConditions":
					IsMatchConditions = reader.GetBoolValue();
				break;
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "GenerateDecisionsFromColumn":
					GenerateDecisionsFromColumn = reader.GetBoolValue();
				break;
				case "DecisionalColumnMetaPath":
					DecisionalColumnMetaPath = reader.GetStringValue();
				break;
				case "ResultParameter":
					ResultParameter = reader.GetGuidValue();
				break;
				case "IsReexecution":
					IsReexecution = reader.GetBoolValue();
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
				case "PageTypeUId":
					PageTypeUId = reader.GetGuidValue();
				break;
				case "ActivitySchemaUId":
					if (!UseFlowEngineMode) {
						break;
					}
					ActivitySchemaUId = reader.GetGuidValue();
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
				case "Problem":
					Problem = reader.GetGuidValue();
				break;
				case "Change":
					Change = reader.GetGuidValue();
				break;
				case "Release":
					Release = reader.GetGuidValue();
				break;
				case "Project":
					Project = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

