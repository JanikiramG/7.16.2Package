namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: OpportunityManagementEndOfStageSchema

	/// <exclude/>
	public class OpportunityManagementEndOfStageSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public OpportunityManagementEndOfStageSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public OpportunityManagementEndOfStageSchema(OpportunityManagementEndOfStageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OpportunityManagementEndOfStage";
			UId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8");
			CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.15.2.501";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"OpportunityManagement";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8");
			Version = 0;
			PackageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCurrentOpportunityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dfce71b8-964d-4c09-bd58-0c97f1365945"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNextOpportunityStageNumberParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d7748fee-12d1-4402-9af3-177336bb4bb3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextOpportunityStageNumber",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentStageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7411fdec-830d-495b-8fcc-4494af5fe84c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"CurrentStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{456fe102-f895-4fd8-8351-a77859dd709e}].[Parameter:{e11d0fd9-aca0-4ee9-b9cf-f8d97c1fc2ba}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateRecommendationParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c26d6544-4636-434b-b986-690a58c482d2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsStageChangedByUserParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2d124c72-8de2-4327-a821-7370bb4f3f04"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"IsStageChangedByUser",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDontShowPageEndOfStageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4a896c50-5660-4509-bcfa-09fdb87708e7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"DontShowPageEndOfStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNextStageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b84b8659-7d6c-46df-be98-b96c5d0e5b85"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextStage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOpportunityParameter());
			Parameters.Add(CreateNextOpportunityStageNumberParameter());
			Parameters.Add(CreateCurrentStageParameter());
			Parameters.Add(CreateRecommendationParameter());
			Parameters.Add(CreateIsStageChangedByUserParameter());
			Parameters.Add(CreateDontShowPageEndOfStageParameter());
			Parameters.Add(CreateNextStageParameter());
		}

		protected virtual void InitializeReadCurrentStageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a180ecd0-2639-46fe-8f28-b1f4bf23afb2"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,98,73,182,37,185,199,176,41,185,164,161,105,75,33,9,65,31,163,68,224,143,141,45,211,4,179,255,189,227,117,182,133,28,74,78,133,130,14,210,72,243,206,204,163,153,249,62,142,231,177,73,48,212,193,52,35,100,211,133,175,9,120,0,107,133,166,0,204,208,66,84,37,181,166,10,84,50,14,210,176,146,113,198,72,214,153,22,106,178,122,239,124,76,36,139,9,218,177,190,153,255,136,166,97,130,236,62,28,15,215,238,17,90,243,109,9,224,92,144,94,49,65,131,83,130,22,210,120,106,161,98,84,5,97,133,213,202,148,69,32,107,46,74,27,91,105,76,195,86,2,104,193,67,73,53,4,78,189,0,3,144,151,194,201,138,100,13,132,180,123,222,15,48,142,177,239,234,25,126,239,191,190,236,49,203,53,246,89,223,76,109,71,178,22,146,185,50,233,177,38,6,114,40,74,103,168,43,116,73,139,0,146,26,161,61,21,198,74,46,21,176,138,73,146,57,179,79,139,44,185,240,36,243,38,153,239,166,153,224,168,60,71,204,145,139,156,169,178,66,95,38,28,242,226,57,85,149,146,52,248,42,104,16,149,214,214,159,120,125,154,34,238,227,120,57,181,48,68,247,138,29,144,95,63,212,179,235,187,52,244,205,34,125,121,124,254,21,158,211,10,247,245,234,199,90,80,66,251,226,68,14,217,52,194,89,19,161,75,187,206,245,62,118,15,171,230,225,128,46,237,222,12,113,60,81,216,61,77,166,33,217,16,31,30,255,74,235,108,26,83,223,254,71,165,102,88,38,106,96,147,29,211,93,122,208,199,113,223,152,151,227,185,38,31,158,166,62,125,252,2,198,111,250,253,190,31,210,212,197,244,178,89,10,220,158,199,97,76,155,165,119,55,125,216,32,136,169,73,40,189,113,125,211,128,91,62,126,123,157,204,3,172,26,228,77,172,154,220,18,96,42,148,121,206,168,87,136,162,96,210,82,197,184,160,82,7,101,139,92,179,34,175,182,75,131,123,87,228,180,4,193,105,225,115,75,181,231,146,50,164,198,0,27,158,115,187,149,90,26,39,74,188,215,82,227,35,174,168,206,113,242,20,15,96,43,111,157,246,238,150,32,137,127,90,223,205,197,248,249,103,119,154,224,149,249,221,22,173,111,12,187,6,90,252,28,108,168,119,0,57,160,195,213,41,84,61,191,7,207,226,178,235,18,86,182,78,114,61,191,135,215,225,110,33,118,119,192,245,11,168,26,12,170,239,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("42e7b0d0-17c7-4dcc-a264-7be5a6a0e0b1"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1ee60d4e-4844-4702-9e5b-a9ef2faca871"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8cf2516-53d6-45f6-ba8d-4bfdabb48124"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9fa8b3c-2f06-4b34-bbef-4f29b1947858"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9ce46aa-34eb-48fb-be04-e9c34eceff5f"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5061fcf5-7f96-49fa-8be4-619e0f5209ae"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("e11d0fd9-aca0-4ee9-b9cf-f8d97c1fc2ba"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bbaa560d-a45c-4f10-ac9f-e0a221e816e8"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c64386d0-db34-457e-833d-a14939236608"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5dde80e-3396-4686-a165-fafbfad811d2"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c161dd2c-4540-45be-9271-b9b410ff5929"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1ca50f2d-35c9-435b-85de-6154c601ed28"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("30c203aa-798c-414b-b6e2-e7435cabddcd"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("18002008-4ddc-4cdc-9996-18caf8454929"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d1b816f-c970-49b1-bfdb-4212142710ce"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e979c3ad-ef25-4300-b738-0666bbd3e28a"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44bc81d4-fd3b-4974-a8bb-bcee7f140f1c"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("79113b9d-850d-46d7-ac7e-4451742b9d4f"),
				ContainerUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeUpdateOpportunityStageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("e99fa34f-868e-4b57-a3a8-13c100885498"),
				ContainerUId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05fb8dfb-1204-478c-a016-5e0dacf67068"),
				ContainerUId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cc2f766d-1506-48eb-8d63-91ddc235a521"),
				ContainerUId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,91,178,62,220,227,178,45,123,73,3,77,75,33,89,130,44,61,101,5,254,138,44,209,4,179,255,189,178,157,77,33,135,82,232,169,160,131,244,158,102,222,204,32,205,247,110,250,228,218,0,190,182,170,157,32,139,7,83,35,213,16,163,168,206,113,35,76,129,41,37,26,55,37,112,204,181,201,5,151,70,48,166,81,214,171,14,106,180,161,247,198,5,148,185,0,221,84,223,206,191,73,131,143,144,221,219,245,240,85,159,160,83,223,214,1,64,153,109,4,199,58,47,53,166,10,4,86,134,20,88,201,146,104,99,164,164,218,162,77,139,225,165,229,101,147,99,66,184,192,84,64,131,155,92,72,44,148,224,148,41,166,75,168,80,214,130,13,251,167,209,195,52,185,161,175,103,120,221,223,60,143,73,229,54,123,55,180,177,235,81,214,65,80,215,42,156,22,33,57,208,74,43,172,169,172,48,181,201,164,34,210,96,162,26,94,114,1,5,43,56,202,180,26,195,66,139,14,6,101,70,5,245,93,181,17,86,230,217,37,141,37,201,11,81,177,132,45,82,84,148,148,57,22,44,185,179,134,89,9,132,73,217,152,75,94,159,163,75,123,55,93,197,14,188,211,47,177,67,202,111,240,245,172,135,62,248,161,93,168,175,214,235,55,240,20,182,112,95,90,63,54,67,33,213,23,16,58,103,113,130,93,235,160,15,251,94,15,198,245,15,27,231,249,156,32,221,168,188,155,46,41,236,31,163,106,81,230,221,195,233,143,105,237,226,20,134,238,63,178,154,37,155,137,35,61,178,85,238,242,6,141,155,198,86,61,175,231,26,189,127,140,67,248,184,139,222,39,240,187,97,28,7,31,98,239,194,243,214,64,111,8,106,116,135,140,213,192,139,70,96,201,168,193,233,55,72,220,152,74,224,92,75,110,11,194,42,73,171,59,148,68,253,251,168,219,195,244,229,103,127,249,33,155,167,227,135,84,125,83,184,190,32,235,249,111,212,157,143,139,190,227,57,173,95,183,102,100,70,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0b1a99dc-d621-4151-8384-3e221142a390"),
				ContainerUId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,81,111,218,48,20,133,255,10,114,251,136,81,98,155,56,206,235,186,7,164,182,67,107,215,23,224,225,250,250,122,69,10,9,74,194,182,46,202,127,159,49,48,160,219,94,230,72,137,108,231,59,231,216,247,246,236,182,123,219,18,43,216,51,53,13,180,181,239,38,31,234,134,38,243,166,70,106,219,201,125,141,80,174,127,130,45,105,14,13,108,168,163,230,5,202,29,181,247,235,182,27,143,174,49,54,102,183,223,226,46,43,22,61,155,117,180,249,50,115,65,157,80,106,229,19,199,17,173,231,42,87,41,55,128,130,163,52,168,82,48,9,230,54,192,88,151,187,77,245,64,29,204,161,123,101,69,207,162,90,16,208,70,3,202,169,224,202,104,195,149,19,57,55,73,230,121,46,60,217,204,89,52,14,217,48,102,45,190,210,6,162,233,25,6,82,153,183,185,230,152,8,228,10,40,231,224,100,202,193,8,137,206,25,163,208,239,225,227,255,103,112,113,179,152,181,159,190,87,212,60,69,221,194,67,217,210,106,18,86,223,45,124,44,105,67,85,87,244,78,100,56,245,70,113,107,50,224,42,9,54,185,75,129,59,41,108,18,30,167,114,51,4,224,247,109,22,189,151,33,135,86,130,59,237,52,87,146,2,162,132,225,228,133,16,211,44,165,148,236,176,186,89,237,35,186,117,187,45,225,237,229,207,164,79,29,124,165,17,85,110,242,72,63,186,81,187,159,30,152,237,85,225,46,169,126,121,168,255,146,21,203,127,117,192,241,123,56,239,117,15,188,47,255,146,141,151,236,169,222,53,184,87,148,251,201,169,28,209,33,57,14,254,151,215,105,28,52,34,246,0,85,56,67,243,24,28,35,30,183,238,160,131,104,254,28,114,159,132,173,48,211,68,167,158,107,130,208,29,148,137,195,165,155,212,88,47,181,20,222,139,72,127,38,79,13,85,72,215,193,16,189,118,121,42,185,199,92,114,165,193,113,75,89,40,131,151,86,90,147,195,84,249,200,71,231,115,152,83,167,134,149,106,87,150,209,160,141,231,223,183,254,49,248,113,231,238,162,114,23,10,181,91,251,53,185,89,245,63,87,53,176,97,88,13,191,0,171,83,77,107,197,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeShowEndOfStagePageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var clientUnitSchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3fc920dd-5c62-4946-a873-1c00873e193a"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ClientUnitSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			clientUnitSchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(clientUnitSchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"e1ba28db-8dae-4e66-869f-e505d74c589a",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95bf65a8-5bdc-4b02-b95a-1f12ff622cbd"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("29a26301-669f-494a-8967-ef76ebcb346b"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{dfce71b8-964d-4c09-bd58-0c97f1365945}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f14e9164-cb48-4c4d-9eda-2a426442f1fd"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntryPointId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entryPointIdParameter.SourceValue = new ProcessSchemaParameterValue(entryPointIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entryPointIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("63792a62-2e22-48b7-8c75-26ed007ef6a2"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9895f5a-79bc-4b95-be4c-0b420f907431"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Stage end",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17508aa3-5868-4feb-acab-c83ec5a89cff"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"UseCardProcessModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCardProcessModuleParameter.SourceValue = new ProcessSchemaParameterValue(useCardProcessModuleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("37dae5df-0de8-4721-b69a-620d86c5a9c6"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4ecc7287-ee70-49bd-b052-12d9c04640cc"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("81c142cf-f5e8-4758-b878-a1157cb21f63"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1f3d14a9-bcd1-4c8e-a749-366397869b93"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"IsRunning",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isRunningParameter.SourceValue = new ProcessSchemaParameterValue(isRunningParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var templateParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("36a84788-1028-4b2e-98d6-2fbe879744a3"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Template",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			templateParameter.SourceValue = new ProcessSchemaParameterValue(templateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.21620f25-166f-42f1-8b4d-224a959040a3#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(templateParameter);
			var moduleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("06aa8216-8b15-4df3-b9df-e7d918b5236f"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Module",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			moduleParameter.SourceValue = new ProcessSchemaParameterValue(moduleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.90fa6d02-3e93-45d6-a72b-58dcffa411ae.eb89c336-08b9-4951-bffd-3f5abc433174#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(moduleParameter);
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1ad0b383-15c7-4249-8e72-97d1c9d85d78"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"PressedButtonCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			pressedButtonCodeParameter.SourceValue = new ProcessSchemaParameterValue(pressedButtonCodeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(pressedButtonCodeParameter);
			var urlParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("888d6ff6-d3d4-442c-9b04-b603fcb72adb"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Url",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			urlParameter.SourceValue = new ProcessSchemaParameterValue(urlParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"""[Module]/[Page]/add""",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48")
			};
			parametrizedElement.Parameters.Add(urlParameter);
			var nextStageResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7584122f-a24d-4575-a5b9-b55b2a9abc8a"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextStageResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			nextStageResultParameter.SourceValue = new ProcessSchemaParameterValue(nextStageResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(nextStageResultParameter);
			var currentStageIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("8de5380d-ac3d-411c-8a77-2c835c3d43d4"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"CurrentStageId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			currentStageIdParameter.SourceValue = new ProcessSchemaParameterValue(currentStageIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e18f5001-d887-417b-8123-79f8b4091406}].[Parameter:{be61dc40-5e32-4d0b-9d27-1e361e54f22b}].[EntityColumn:{797ac352-4979-4d28-906f-82feb6dbc9dc}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(currentStageIdParameter);
			var nextStageIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("f3923742-d7d7-43e1-8429-ef222561e1eb"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"NextStageId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			nextStageIdParameter.SourceValue = new ProcessSchemaParameterValue(nextStageIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{b84b8659-7d6c-46df-be98-b96c5d0e5b85}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(nextStageIdParameter);
			var opportunityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("7b3decd5-3d89-4cff-b95d-730a6013cb27"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"OpportunityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityIdParameter.SourceValue = new ProcessSchemaParameterValue(opportunityIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{dfce71b8-964d-4c09-bd58-0c97f1365945}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(opportunityIdParameter);
			var isStageChangedByUserParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61077983-3941-4d4a-9630-edfbacf49a87"),
				ContainerUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"IsStageChangedByUser",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isStageChangedByUserParameter.SourceValue = new ProcessSchemaParameterValue(isStageChangedByUserParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2d124c72-8de2-4327-a821-7370bb4f3f04}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(isStageChangedByUserParameter);
		}

		protected virtual void InitializeReadOpportunityParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e5d457b-42b9-4672-8b52-c52e77513010"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,217,178,45,185,199,101,91,246,146,6,154,150,66,178,4,89,122,202,10,252,21,125,208,44,198,255,189,178,189,155,66,14,165,208,83,65,7,233,73,51,111,102,120,154,30,141,251,100,90,15,182,214,162,117,144,132,131,170,145,102,148,202,60,83,184,17,153,192,52,147,128,25,101,12,115,218,64,169,152,44,68,83,161,164,23,29,212,104,67,239,149,241,40,49,30,58,87,223,79,191,73,189,13,144,60,234,245,240,85,158,160,19,223,150,6,2,104,169,27,86,97,153,102,18,83,1,12,11,149,19,44,120,150,75,165,56,167,82,163,139,22,66,10,208,156,96,194,210,20,83,74,26,204,89,169,177,226,10,56,7,94,164,4,80,210,130,246,251,151,209,130,115,102,232,235,9,94,247,119,231,49,170,220,122,239,134,54,116,61,74,58,240,226,86,248,211,34,36,5,90,72,129,37,229,5,166,26,42,44,114,174,112,30,29,102,21,3,82,146,232,84,138,209,47,180,232,160,80,162,132,23,223,69,27,96,101,158,76,212,152,229,41,97,69,25,177,36,143,118,242,44,197,172,140,238,180,42,53,135,188,228,188,81,215,188,62,7,19,247,198,221,132,14,172,145,151,216,33,230,55,216,122,146,67,239,237,208,46,212,55,235,243,59,120,241,91,184,151,171,31,155,33,31,235,11,8,205,73,112,176,107,13,244,126,223,203,65,153,254,105,227,156,231,8,233,70,97,141,187,166,176,127,14,162,69,137,53,79,167,63,166,181,11,206,15,221,127,100,53,137,54,35,71,28,178,85,238,50,131,202,184,177,21,231,245,92,163,247,207,97,240,31,119,193,218,8,126,55,140,227,96,125,232,141,63,111,23,232,13,65,141,30,144,210,18,42,210,196,169,47,169,194,84,166,28,55,170,96,56,149,188,210,36,47,11,78,139,7,20,69,253,123,171,251,131,251,242,179,191,254,144,205,211,241,67,172,190,41,220,94,145,245,244,55,234,230,227,162,239,56,199,245,11,18,14,35,26,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8447c567-6c37-4e2b-a3dd-2447daaaaf66"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e8e3ca1-4e02-4cfd-9534-dfc91c400628"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7f19d59d-6e3e-4583-9422-7df884633ba7"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbccc177-264d-4b7a-81b0-a23219940711"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d4181cb4-8130-424d-ae68-c843f87a8855"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50b25f81-e993-4f01-a6e6-374b3659b858"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("be61dc40-5e32-4d0b-9d27-1e361e54f22b"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("06755d62-3109-44a6-a9ab-3f4754d27ca3"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("daf5e600-722b-43e1-a28d-5cefd2a1ba80"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f1cb258f-287d-4c5c-b4ac-277f0f9884bb"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("797c93d6-bc60-4d21-a669-039897df02c3"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0f2ed61f-3f3e-487a-8430-3fb6764f469d"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e8bf658-f625-4d19-ad5b-727fb3b2847e"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("3d15909c-f006-4a7a-8b1c-fede8e2a9eae"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86e11392-27d0-4340-9d60-c67a8335b463"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4b80d1c9-90f8-4449-82d6-693bf426b73b"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb8874a6-c6ee-4d18-adde-6d01cef9bdaa"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("49436b7b-e767-4b4d-b557-358ddfc2bba0"),
				ContainerUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadNextStageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a75219e0-00f3-4d5d-a9f7-651b6e4376ef"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,75,107,220,48,16,254,43,65,135,158,172,98,91,90,75,118,143,203,22,246,178,13,244,65,33,89,194,72,26,237,10,252,138,37,211,4,179,255,189,178,221,109,75,14,33,208,83,193,8,107,196,247,152,79,163,233,193,249,143,174,14,56,84,22,106,143,201,184,55,21,209,178,208,5,50,160,130,103,140,114,109,44,149,134,107,154,105,169,115,107,37,148,185,32,73,11,13,86,100,69,239,140,11,36,113,1,27,95,221,77,127,72,195,48,98,242,96,151,205,103,125,198,6,190,46,2,218,10,35,35,183,213,50,10,8,48,84,97,145,81,105,153,98,170,148,176,225,150,172,94,108,42,242,178,220,112,154,67,106,41,231,165,166,37,150,156,34,114,41,212,166,144,194,166,36,169,209,134,221,83,63,160,247,174,107,171,9,127,255,127,121,238,163,203,85,123,219,213,99,211,146,164,193,0,183,16,206,21,217,104,107,51,195,4,213,41,43,41,47,52,82,208,44,46,220,8,80,24,213,54,209,136,134,62,204,180,228,48,54,10,7,146,24,8,240,13,234,17,23,246,201,69,159,133,42,148,224,152,83,153,167,134,242,50,141,36,105,38,104,174,4,139,217,105,155,171,244,154,217,190,13,120,154,121,156,143,140,56,56,189,6,133,49,197,110,168,38,221,181,97,232,234,153,252,240,55,96,77,249,215,233,247,181,51,183,30,205,80,114,73,70,143,219,218,97,27,118,173,238,140,107,79,235,181,94,46,17,213,244,48,56,127,77,100,247,56,66,77,146,193,157,206,175,38,183,29,125,232,154,255,176,229,36,182,27,153,226,224,45,182,231,185,52,206,247,53,60,47,251,138,188,123,28,187,240,225,128,79,225,198,7,56,225,77,187,220,238,90,38,47,224,21,185,39,70,8,46,45,34,205,114,147,197,81,76,115,90,130,101,52,19,130,177,66,41,174,20,187,39,209,210,191,10,221,237,253,167,31,237,245,197,172,253,28,223,199,234,139,194,237,21,89,77,111,241,118,57,206,238,142,151,248,253,4,53,63,19,217,248,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b64d0a3c-c0d0-4958-81f1-b5ede9765ad4"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24325d83-50e7-4573-8f91-35e07a45c717"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f3903c6b-98c5-40bf-916d-98a7b572a579"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a0182d1d-381b-4c10-a8ec-d985836d5cc9"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85950cf7-252d-4b5c-9bfd-ad509d940e2f"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("81c297c2-fc42-4e9b-89ee-73751508db6a"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("92ea37fd-45c4-4fb2-98b7-eb6e66edd5ff"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7ab26365-d3e5-4729-92b4-d09e2de024d0"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95f97244-d092-4885-aea6-53b76e1303a7"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2cc4d02b-1588-44de-9fa7-b09506a2c14f"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cb876d9-d17b-4fc0-a745-da0b4ea53266"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4201c6a3-e0ab-4f41-b531-0fb631720790"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("96bc11af-2c34-4987-a0f6-2575203da254"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				UId = new Guid("92ba46a0-d926-4f32-868c-882c9bef0c1b"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3df688c3-a044-4e2f-b4d5-974b22314e82"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3d4eab8-cdc4-425a-be85-68f08022c240"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ce276b8c-5973-4455-b979-03e17f80e74a"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ac39acaf-4b66-41c8-9aa8-d7137b54ece2"),
				ContainerUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadCountNotFinishedActivitiesParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6a1d2bd1-de4f-40aa-9125-c113b2d391c5"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,75,107,28,57,16,254,43,166,15,123,106,25,189,90,143,201,45,131,179,24,150,196,144,108,88,8,38,148,164,82,220,164,167,123,210,173,102,109,6,255,247,173,233,241,36,198,76,150,36,155,61,228,38,149,84,239,239,171,218,189,111,167,23,109,87,112,92,101,232,38,172,231,203,180,170,188,54,198,130,4,22,124,118,76,75,21,24,196,148,89,224,141,13,30,156,202,86,85,117,15,27,92,85,7,237,139,212,150,170,110,11,110,166,213,187,221,23,163,101,156,177,126,159,151,203,235,120,131,27,248,115,239,32,106,237,147,83,146,129,142,145,233,192,5,185,74,13,115,32,100,212,18,200,173,175,14,177,112,29,130,142,158,51,163,162,100,58,130,100,161,49,134,73,0,237,164,205,82,66,168,234,14,115,185,184,221,142,56,77,237,208,175,118,248,249,252,230,110,75,81,30,124,175,135,110,222,244,85,189,193,2,87,80,110,86,149,54,78,39,29,128,98,48,129,233,36,128,121,149,3,179,28,163,132,140,169,177,185,170,35,108,203,222,108,245,106,187,29,198,50,247,109,185,171,234,17,51,142,216,71,124,148,24,160,54,57,56,203,34,151,148,24,160,99,144,148,96,224,165,138,41,121,175,35,217,75,80,224,45,116,51,46,193,237,90,82,12,210,55,220,138,204,44,130,103,26,141,100,110,137,70,248,144,149,85,50,103,121,44,249,31,195,240,113,222,82,185,167,151,243,6,199,54,62,244,14,169,9,195,184,218,197,161,47,227,208,237,141,191,124,164,112,232,209,195,227,95,135,186,116,203,203,94,177,186,175,231,9,215,93,139,125,185,232,227,144,218,254,195,210,190,251,123,210,217,108,97,108,167,99,53,47,62,205,208,81,1,218,15,55,255,90,245,245,60,149,97,243,171,229,91,83,174,100,134,16,187,196,188,7,116,106,167,109,7,119,203,125,85,253,246,105,30,202,179,245,60,82,247,203,217,240,5,19,135,135,234,137,129,163,66,202,17,173,8,142,121,163,19,33,153,123,22,82,227,24,143,222,102,161,76,227,117,243,96,225,190,254,57,46,223,93,78,175,254,238,143,212,59,148,237,250,156,164,79,4,87,71,237,213,238,91,162,188,191,62,198,121,77,232,248,169,116,71,148,141,143,146,190,194,158,149,58,113,154,58,209,50,107,147,80,34,217,16,247,95,127,148,238,209,37,167,179,143,44,104,71,116,183,62,48,15,209,144,31,33,179,210,202,208,120,57,15,70,56,244,78,49,205,57,125,66,68,230,140,110,88,54,208,168,156,148,108,48,62,154,9,175,11,148,121,58,127,209,246,208,157,77,203,229,36,226,61,15,166,9,52,79,121,206,84,4,161,5,115,214,122,38,181,228,116,128,236,185,61,34,254,249,48,116,8,253,119,64,126,125,131,241,227,243,225,246,41,224,227,94,30,72,126,10,238,139,205,255,192,239,207,176,249,181,18,62,65,240,167,244,89,62,254,15,240,86,209,36,174,76,102,17,53,109,179,208,208,102,69,151,25,74,238,69,18,77,99,157,248,113,120,19,121,132,85,84,108,238,52,39,120,43,138,33,10,77,11,211,5,131,42,249,224,253,35,228,94,141,67,36,179,103,251,181,125,178,131,82,113,225,26,99,25,8,69,137,41,201,137,9,180,220,114,50,217,163,50,222,135,116,236,224,239,115,155,190,163,125,111,240,182,156,26,208,133,228,95,29,207,95,195,235,37,121,237,186,125,187,254,1,230,230,161,81,208,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0959d33a-0a66-4437-b25b-f3bda29e8610"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb79a7c9-22cc-4cfa-8454-2c336d3bbfa5"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24dd4a10-4e2c-4dbc-ac53-610bca6745d2"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc43106b-6ad4-40bf-a590-bdcc5c40964f"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0d8bea86-be3d-47ce-be07-e371b62fc691"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37082b06-1012-4b4d-a2ad-042c8195bd8d"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("1fd1d50c-01de-4e1b-90a2-28e34e2af4be"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("adb67efb-8644-4a2e-a47b-ead879586020"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4741ed6-a5d9-425f-89cb-d88bb25d9d90"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2708fded-c17f-4033-9321-837e75a17968"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86a273c0-dc2f-4650-9c6c-5b7ffee3cd43"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbd49361-8bca-4903-b561-a67607267747"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ce29d90c-dbf6-45ef-b05c-543edaf33473"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("59ffe7bc-8788-4279-be21-1c5a28993330"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f2b89827-46fd-4c18-b956-876018f44ca1"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c76447c0-1087-47a0-b5f1-4dbe3d1a44b8"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("efe44f1f-d24a-4664-a89f-56513698f293"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cac0e459-da85-49e8-aa8a-fba8ae4ff5f4"),
				ContainerUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaUserTask readcurrentstage = CreateReadCurrentStageUserTask();
			FlowElements.Add(readcurrentstage);
			ProcessSchemaUserTask updateopportunitystage = CreateUpdateOpportunityStageUserTask();
			FlowElements.Add(updateopportunitystage);
			ProcessSchemaUserTask showendofstagepage = CreateShowEndOfStagePageUserTask();
			FlowElements.Add(showendofstagepage);
			ProcessSchemaUserTask readopportunity = CreateReadOpportunityUserTask();
			FlowElements.Add(readopportunity);
			ProcessSchemaUserTask readnextstage = CreateReadNextStageUserTask();
			FlowElements.Add(readnextstage);
			ProcessSchemaFormulaTask setnextstagenumber = CreateSetNextStageNumberFormulaTask();
			FlowElements.Add(setnextstagenumber);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readcountnotfinishedactivities = CreateReadCountNotFinishedActivitiesUserTask();
			FlowElements.Add(readcountnotfinishedactivities);
			ProcessSchemaFormulaTask setshowendofstagepage = CreateSetShowEndOfStagePageFormulaTask();
			FlowElements.Add(setshowendofstagepage);
			ProcessSchemaFormulaTask setnextstagebyprocess = CreateSetNextStageByProcessFormulaTask();
			FlowElements.Add(setnextstagebyprocess);
			ProcessSchemaExclusiveGateway exclusivegateway3 = CreateExclusiveGateway3ExclusiveGateway();
			FlowElements.Add(exclusivegateway3);
			ProcessSchemaExclusiveGateway exclusivegateway4 = CreateExclusiveGateway4ExclusiveGateway();
			FlowElements.Add(exclusivegateway4);
			ProcessSchemaFormulaTask setnextstagebyuser = CreateSetNextStageByUserFormulaTask();
			FlowElements.Add(setnextstagebyuser);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateConditionalFlow5ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b3f9e0ab-7904-428d-b390-7329ccaaea72"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2f9628a-148c-457c-86a9-7f7baece560b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3442dd87-3f5e-436c-9d5c-f6787c0fab8d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("4fabb2fd-fc21-47f9-bdc2-021c87df6c32"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(1002, 202),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a12d765-1b7d-47e3-a00b-5c931dab802d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("de86ae86-1ff7-41f6-a500-595b3738ef05"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(260, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("7446a197-1d3b-4d89-ae1b-7b1cff8b47a1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(638, 214),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2cc075ef-e2dc-4bbc-8186-706550bc8b21"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("78c5c0a9-ea1b-4e76-b049-2da3afc80ec6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("dc49463a-2212-4b84-8e05-c80a9aaceadd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("126115de-6094-4d04-b02d-edb4098a40a6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(1200, 213),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("88c362ec-c9e0-406d-8843-df7ff2006237"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(411, 215),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2cc075ef-e2dc-4bbc-8186-706550bc8b21"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("61b4d6d8-8e40-41d0-97fb-42dc65fd11af"),
				ConditionExpression = @"![#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2d124c72-8de2-4327-a821-7370bb4f3f04}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(210, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3442dd87-3f5e-436c-9d5c-f6787c0fab8d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow7",
				UId = new Guid("274be584-2828-4da3-beb0-c801d5ce9ff7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(198, 264),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3442dd87-3f5e-436c-9d5c-f6787c0fab8d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("a7181db3-fab9-4d7c-8eee-d4d845df77f3"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{868321fe-9c79-4ab3-8a81-b41ecb0e6d15}].[Parameter:{adb67efb-8644-4a2e-a47b-ead879586020}]#] > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(310, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(315, 315));
			schemaFlow.PolylinePointPositions.Add(new Point(315, 254));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow8",
				UId = new Guid("c5adeff7-f3e3-4188-a300-892a510bc2dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(199, 391),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f941b7c-c6b4-4ad8-959c-b82b3f3767e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("0ce357c0-1c14-46c6-84d5-8ecb0f975c95"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(289, 316),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f941b7c-c6b4-4ad8-959c-b82b3f3767e5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("d1371036-7604-4d06-bb84-ab1771858c58"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{4a896c50-5660-4509-bcfa-09fdb87708e7}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(944, 201),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("78c5c0a9-ea1b-4e76-b049-2da3afc80ec6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a12d765-1b7d-47e3-a00b-5c931dab802d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(763, 105));
			schemaFlow.PolylinePointPositions.Add(new Point(1442, 105));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("afad4434-030b-4ed8-9fde-a8b0477c8747"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(777, 258),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("78c5c0a9-ea1b-4e76-b049-2da3afc80ec6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ee1eb647-192e-47bf-9462-02ad7e99bd9e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow12",
				UId = new Guid("a1d18a8e-b062-4566-a237-1d628e789f17"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(828, 250),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ee1eb647-192e-47bf-9462-02ad7e99bd9e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow5ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow5",
				UId = new Guid("3bdfa389-17e8-4004-86a8-c6c06af091ae"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2d124c72-8de2-4327-a821-7370bb4f3f04}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(837, 346),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ee1eb647-192e-47bf-9462-02ad7e99bd9e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55b8d26d-8e5c-487a-81de-2f9292f3aa90"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("a2626743-6dbb-41a7-b547-aaed96410cf4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(1030, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2b19d13a-f7cf-4d1c-b231-8775fd9b48d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("3d3b7a67-cde7-4567-b363-dac27ac781cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(1174, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2b19d13a-f7cf-4d1c-b231-8775fd9b48d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("03de0816-6c46-488e-b4ce-bfb9d85b7edb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				CurveCenterPosition = new Point(1108, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55b8d26d-8e5c-487a-81de-2f9292f3aa90"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("7563325b-66c4-4b05-af10-d2119fcd7b6c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1465, 570),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("7563325b-66c4-4b05-af10-d2119fcd7b6c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1436, 570),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("f2f9628a-148c-457c-86a9-7f7baece560b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"Start1",
				Position = new Point(50, 191),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2a12d765-1b7d-47e3-a00b-5c931dab802d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"Terminate1",
				Position = new Point(1394, 191),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadCurrentStageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ReadCurrentStage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(449, 177),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadCurrentStageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateUpdateOpportunityStageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"UpdateOpportunityStage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1261, 177),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeUpdateOpportunityStageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateShowEndOfStagePageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ShowEndOfStagePage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1142, 177),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeShowEndOfStagePageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadOpportunityUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e18f5001-d887-417b-8123-79f8b4091406"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ReadOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(309, 177),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadOpportunityParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadNextStageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ReadNextStage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(897, 177),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadNextStageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSetNextStageNumberFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("2cc075ef-e2dc-4bbc-8186-706550bc8b21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"SetNextStageNumber",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(582, 177),
				ResultParameterMetaPath = @"d7748fee-12d1-4402-9af3-177336bb4bb3",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,204,65,11,130,64,16,134,225,191,34,120,140,137,221,220,117,29,175,209,161,83,65,71,241,48,206,206,80,160,6,106,68,136,255,189,237,218,229,59,188,240,124,77,222,156,231,203,123,148,233,198,119,25,168,86,234,103,105,247,169,254,133,83,47,131,140,75,189,58,95,170,88,115,0,173,208,131,211,88,65,85,120,11,20,66,229,49,198,96,80,182,4,174,52,209,32,139,76,245,42,214,70,163,17,129,152,12,56,17,132,14,89,211,67,196,192,86,249,208,209,143,156,198,229,177,124,142,207,254,53,140,245,234,89,213,198,34,0,155,2,193,149,44,201,23,105,92,12,212,137,67,246,186,181,121,155,237,50,251,5,232,159,135,158,200,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("3442dd87-3f5e-436c-9d5c-f6787c0fab8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(134, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadCountNotFinishedActivitiesUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ReadCountNotFinishedActivities",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(127, 282),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadCountNotFinishedActivitiesParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSetShowEndOfStagePageFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("4f941b7c-c6b4-4ad8-959c-b82b3f3767e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"SetShowEndOfStagePage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(127, 394),
				ResultParameterMetaPath = @"4a896c50-5660-4509-bcfa-09fdb87708e7",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateSetNextStageByProcessFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("2b19d13a-f7cf-4d1c-b231-8775fd9b48d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"SetNextStageByProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1016, 177),
				ResultParameterMetaPath = @"b84b8659-7d6c-46df-be98-b96c5d0e5b85",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,205,10,130,64,20,6,208,135,105,125,99,212,249,81,183,225,162,85,65,75,113,113,231,206,55,20,56,6,106,68,136,239,222,180,109,123,224,244,135,254,188,92,222,19,230,155,220,145,184,141,60,46,24,142,89,255,160,27,145,48,173,237,86,137,21,49,214,80,144,34,146,22,101,136,21,43,242,33,22,2,120,23,160,247,28,174,60,115,194,138,185,221,154,18,92,185,24,72,27,209,164,163,47,169,169,189,35,120,11,107,17,130,137,241,87,186,105,125,172,159,211,115,124,165,169,221,24,10,57,48,137,110,76,94,112,196,85,19,168,98,239,74,87,163,176,133,219,135,195,240,5,112,43,96,236,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway3ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("78c5c0a9-ea1b-4e76-b049-2da3afc80ec6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ExclusiveGateway3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(701, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway4ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ee1eb647-192e-47bf-9462-02ad7e99bd9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"ExclusiveGateway4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(792, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateSetNextStageByUserFormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("55b8d26d-8e5c-487a-81de-2f9292f3aa90"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6c23f386-0505-4ea2-980f-92a547bf98fe"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9348111f-aee1-4e53-aa53-fbb2eacd54f6"),
				CreatedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"),
				Name = @"SetNextStageByUser",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1016, 310),
				ResultParameterMetaPath = @"b84b8659-7d6c-46df-be98-b96c5d0e5b85",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,187,10,194,48,20,0,208,143,113,190,146,247,107,149,14,78,10,142,165,67,30,55,40,52,17,218,136,72,233,191,27,87,215,3,103,60,140,231,245,242,174,184,220,226,29,139,119,217,207,43,78,199,174,127,48,204,88,176,54,183,33,53,89,18,66,33,25,163,65,80,29,192,80,198,65,219,108,130,32,150,10,162,246,30,174,126,241,5,27,46,110,11,168,104,138,130,128,68,206,64,36,18,192,38,166,129,34,87,20,165,200,140,133,95,25,106,123,180,207,233,57,191,74,117,155,182,218,71,46,123,176,218,246,197,12,88,162,50,24,150,49,168,20,162,77,113,159,14,211,23,183,37,236,205,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new OpportunityManagementEndOfStage(userConnection);
		}

		public override object Clone() {
			return new OpportunityManagementEndOfStageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityManagementEndOfStage

	/// <exclude/>
	public class OpportunityManagementEndOfStage : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, OpportunityManagementEndOfStage process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadCurrentStageFlowElement

		/// <exclude/>
		public class ReadCurrentStageFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCurrentStageFlowElement(UserConnection userConnection, OpportunityManagementEndOfStage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCurrentStage";
				IsLogging = true;
				SchemaElementUId = new Guid("456fe102-f895-4fd8-8351-a77859dd709e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,98,73,182,37,185,199,176,41,185,164,161,105,75,33,9,65,31,163,68,224,143,141,45,211,4,179,255,189,227,117,182,133,28,74,78,133,130,14,210,72,243,206,204,163,153,249,62,142,231,177,73,48,212,193,52,35,100,211,133,175,9,120,0,107,133,166,0,204,208,66,84,37,181,166,10,84,50,14,210,176,146,113,198,72,214,153,22,106,178,122,239,124,76,36,139,9,218,177,190,153,255,136,166,97,130,236,62,28,15,215,238,17,90,243,109,9,224,92,144,94,49,65,131,83,130,22,210,120,106,161,98,84,5,97,133,213,202,148,69,32,107,46,74,27,91,105,76,195,86,2,104,193,67,73,53,4,78,189,0,3,144,151,194,201,138,100,13,132,180,123,222,15,48,142,177,239,234,25,126,239,191,190,236,49,203,53,246,89,223,76,109,71,178,22,146,185,50,233,177,38,6,114,40,74,103,168,43,116,73,139,0,146,26,161,61,21,198,74,46,21,176,138,73,146,57,179,79,139,44,185,240,36,243,38,153,239,166,153,224,168,60,71,204,145,139,156,169,178,66,95,38,28,242,226,57,85,149,146,52,248,42,104,16,149,214,214,159,120,125,154,34,238,227,120,57,181,48,68,247,138,29,144,95,63,212,179,235,187,52,244,205,34,125,121,124,254,21,158,211,10,247,245,234,199,90,80,66,251,226,68,14,217,52,194,89,19,161,75,187,206,245,62,118,15,171,230,225,128,46,237,222,12,113,60,81,216,61,77,166,33,217,16,31,30,255,74,235,108,26,83,223,254,71,165,102,88,38,106,96,147,29,211,93,122,208,199,113,223,152,151,227,185,38,31,158,166,62,125,252,2,198,111,250,253,190,31,210,212,197,244,178,89,10,220,158,199,97,76,155,165,119,55,125,216,32,136,169,73,40,189,113,125,211,128,91,62,126,123,157,204,3,172,26,228,77,172,154,220,18,96,42,148,121,206,168,87,136,162,96,210,82,197,184,160,82,7,101,139,92,179,34,175,182,75,131,123,87,228,180,4,193,105,225,115,75,181,231,146,50,164,198,0,27,158,115,187,149,90,26,39,74,188,215,82,227,35,174,168,206,113,242,20,15,96,43,111,157,246,238,150,32,137,127,90,223,205,197,248,249,103,119,154,224,149,249,221,22,173,111,12,187,6,90,252,28,108,168,119,0,57,160,195,213,41,84,61,191,7,207,226,178,235,18,86,182,78,114,61,191,135,215,225,110,33,118,119,192,245,11,168,26,12,170,239,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: UpdateOpportunityStageFlowElement

		/// <exclude/>
		public class UpdateOpportunityStageFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public UpdateOpportunityStageFlowElement(UserConnection userConnection, OpportunityManagementEndOfStage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UpdateOpportunityStage";
				IsLogging = true;
				SchemaElementUId = new Guid("ff16041c-18d5-46f3-baed-a5b8b559b3fa");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Stage = () => (Guid)((process.ShowEndOfStagePage.NextStageId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Stage", () => _recordColumnValues_Stage.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Stage;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,91,178,62,220,227,178,45,123,73,3,77,75,33,89,130,44,61,101,5,254,138,44,209,4,179,255,189,178,157,77,33,135,82,232,169,160,131,244,158,102,222,204,32,205,247,110,250,228,218,0,190,182,170,157,32,139,7,83,35,213,16,163,168,206,113,35,76,129,41,37,26,55,37,112,204,181,201,5,151,70,48,166,81,214,171,14,106,180,161,247,198,5,148,185,0,221,84,223,206,191,73,131,143,144,221,219,245,240,85,159,160,83,223,214,1,64,153,109,4,199,58,47,53,166,10,4,86,134,20,88,201,146,104,99,164,164,218,162,77,139,225,165,229,101,147,99,66,184,192,84,64,131,155,92,72,44,148,224,148,41,166,75,168,80,214,130,13,251,167,209,195,52,185,161,175,103,120,221,223,60,143,73,229,54,123,55,180,177,235,81,214,65,80,215,42,156,22,33,57,208,74,43,172,169,172,48,181,201,164,34,210,96,162,26,94,114,1,5,43,56,202,180,26,195,66,139,14,6,101,70,5,245,93,181,17,86,230,217,37,141,37,201,11,81,177,132,45,82,84,148,148,57,22,44,185,179,134,89,9,132,73,217,152,75,94,159,163,75,123,55,93,197,14,188,211,47,177,67,202,111,240,245,172,135,62,248,161,93,168,175,214,235,55,240,20,182,112,95,90,63,54,67,33,213,23,16,58,103,113,130,93,235,160,15,251,94,15,198,245,15,27,231,249,156,32,221,168,188,155,46,41,236,31,163,106,81,230,221,195,233,143,105,237,226,20,134,238,63,178,154,37,155,137,35,61,178,85,238,242,6,141,155,198,86,61,175,231,26,189,127,140,67,248,184,139,222,39,240,187,97,28,7,31,98,239,194,243,214,64,111,8,106,116,135,140,213,192,139,70,96,201,168,193,233,55,72,220,152,74,224,92,75,110,11,194,42,73,171,59,148,68,253,251,168,219,195,244,229,103,127,249,33,155,167,227,135,84,125,83,184,190,32,235,249,111,212,157,143,139,190,227,57,173,95,183,102,100,70,232,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,81,111,218,48,20,133,255,10,114,251,136,81,98,155,56,206,235,186,7,164,182,67,107,215,23,224,225,250,250,122,69,10,9,74,194,182,46,202,127,159,49,48,160,219,94,230,72,137,108,231,59,231,216,247,246,236,182,123,219,18,43,216,51,53,13,180,181,239,38,31,234,134,38,243,166,70,106,219,201,125,141,80,174,127,130,45,105,14,13,108,168,163,230,5,202,29,181,247,235,182,27,143,174,49,54,102,183,223,226,46,43,22,61,155,117,180,249,50,115,65,157,80,106,229,19,199,17,173,231,42,87,41,55,128,130,163,52,168,82,48,9,230,54,192,88,151,187,77,245,64,29,204,161,123,101,69,207,162,90,16,208,70,3,202,169,224,202,104,195,149,19,57,55,73,230,121,46,60,217,204,89,52,14,217,48,102,45,190,210,6,162,233,25,6,82,153,183,185,230,152,8,228,10,40,231,224,100,202,193,8,137,206,25,163,208,239,225,227,255,103,112,113,179,152,181,159,190,87,212,60,69,221,194,67,217,210,106,18,86,223,45,124,44,105,67,85,87,244,78,100,56,245,70,113,107,50,224,42,9,54,185,75,129,59,41,108,18,30,167,114,51,4,224,247,109,22,189,151,33,135,86,130,59,237,52,87,146,2,162,132,225,228,133,16,211,44,165,148,236,176,186,89,237,35,186,117,187,45,225,237,229,207,164,79,29,124,165,17,85,110,242,72,63,186,81,187,159,30,152,237,85,225,46,169,126,121,168,255,146,21,203,127,117,192,241,123,56,239,117,15,188,47,255,146,141,151,236,169,222,53,184,87,148,251,201,169,28,209,33,57,14,254,151,215,105,28,52,34,246,0,85,56,67,243,24,28,35,30,183,238,160,131,104,254,28,114,159,132,173,48,211,68,167,158,107,130,208,29,148,137,195,165,155,212,88,47,181,20,222,139,72,127,38,79,13,85,72,215,193,16,189,118,121,42,185,199,92,114,165,193,113,75,89,40,131,151,86,90,147,195,84,249,200,71,231,115,152,83,167,134,149,106,87,150,209,160,141,231,223,183,254,49,248,113,231,238,162,114,23,10,181,91,251,53,185,89,245,63,87,53,176,97,88,13,191,0,171,83,77,107,197,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "fea753aeb6dc408abac3b7d60bec1df8",
							"BaseElements.UpdateOpportunityStage.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ShowEndOfStagePageFlowElement

		/// <exclude/>
		public class ShowEndOfStagePageFlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public ShowEndOfStagePageFlowElement(UserConnection userConnection, OpportunityManagementEndOfStage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ShowEndOfStagePage";
				IsLogging = true;
				SchemaElementUId = new Guid("d26c5f94-b96a-4031-8d1a-d32b0b0bd489");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.CurrentOpportunity));
				_currentStageId = () => (Guid)(((process.ReadOpportunity.ResultEntity.IsColumnValueLoaded(process.ReadOpportunity.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? process.ReadOpportunity.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty)));
				_nextStageId = () => (Guid)((process.NextStage));
				_opportunityId = () => (Guid)((process.CurrentOpportunity));
				_isStageChangedByUser = () => (bool)((process.IsStageChangedByUser));
			}

			#endregion

			#region Properties: Public

			private Guid _clientUnitSchemaUId = new Guid("e1ba28db-8dae-4e66-869f-e505d74c589a");
			public override Guid ClientUnitSchemaUId {
				get {
					return _clientUnitSchemaUId;
				}
				set {
					_clientUnitSchemaUId = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("fea753aeb6dc408abac3b7d60bec1df8",
						 "BaseElements.ShowEndOfStagePage.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			internal Func<Guid> _entityId;
			public override Guid EntityId {
				get {
					return (_entityId ?? (_entityId = () => Guid.Empty)).Invoke();
				}
				set {
					_entityId = () => { return value; };
				}
			}

			private Guid _entitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("fea753aeb6dc408abac3b7d60bec1df8",
						 "BaseElements.ShowEndOfStagePage.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private bool _useCardProcessModule = true;
			public override bool UseCardProcessModule {
				get {
					return _useCardProcessModule;
				}
				set {
					_useCardProcessModule = value;
				}
			}

			public virtual string NextStageResult {
				get;
				set;
			}

			internal Func<Guid> _currentStageId;
			public virtual Guid CurrentStageId {
				get {
					return (_currentStageId ?? (_currentStageId = () => Guid.Empty)).Invoke();
				}
				set {
					_currentStageId = () => { return value; };
				}
			}

			internal Func<Guid> _nextStageId;
			public virtual Guid NextStageId {
				get {
					return (_nextStageId ?? (_nextStageId = () => Guid.Empty)).Invoke();
				}
				set {
					_nextStageId = () => { return value; };
				}
			}

			internal Func<Guid> _opportunityId;
			public virtual Guid OpportunityId {
				get {
					return (_opportunityId ?? (_opportunityId = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityId = () => { return value; };
				}
			}

			internal Func<bool> _isStageChangedByUser;
			public virtual bool IsStageChangedByUser {
				get {
					return (_isStageChangedByUser ?? (_isStageChangedByUser = () => false)).Invoke();
				}
				set {
					_isStageChangedByUser = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadOpportunityFlowElement

		/// <exclude/>
		public class ReadOpportunityFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOpportunityFlowElement(UserConnection userConnection, OpportunityManagementEndOfStage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOpportunity";
				IsLogging = true;
				SchemaElementUId = new Guid("e18f5001-d887-417b-8123-79f8b4091406");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,217,178,45,185,199,101,91,246,146,6,154,150,66,178,4,89,122,202,10,252,21,125,208,44,198,255,189,178,189,155,66,14,165,208,83,65,7,233,73,51,111,102,120,154,30,141,251,100,90,15,182,214,162,117,144,132,131,170,145,102,148,202,60,83,184,17,153,192,52,147,128,25,101,12,115,218,64,169,152,44,68,83,161,164,23,29,212,104,67,239,149,241,40,49,30,58,87,223,79,191,73,189,13,144,60,234,245,240,85,158,160,19,223,150,6,2,104,169,27,86,97,153,102,18,83,1,12,11,149,19,44,120,150,75,165,56,167,82,163,139,22,66,10,208,156,96,194,210,20,83,74,26,204,89,169,177,226,10,56,7,94,164,4,80,210,130,246,251,151,209,130,115,102,232,235,9,94,247,119,231,49,170,220,122,239,134,54,116,61,74,58,240,226,86,248,211,34,36,5,90,72,129,37,229,5,166,26,42,44,114,174,112,30,29,102,21,3,82,146,232,84,138,209,47,180,232,160,80,162,132,23,223,69,27,96,101,158,76,212,152,229,41,97,69,25,177,36,143,118,242,44,197,172,140,238,180,42,53,135,188,228,188,81,215,188,62,7,19,247,198,221,132,14,172,145,151,216,33,230,55,216,122,146,67,239,237,208,46,212,55,235,243,59,120,241,91,184,151,171,31,155,33,31,235,11,8,205,73,112,176,107,13,244,126,223,203,65,153,254,105,227,156,231,8,233,70,97,141,187,166,176,127,14,162,69,137,53,79,167,63,166,181,11,206,15,221,127,100,53,137,54,35,71,28,178,85,238,50,131,202,184,177,21,231,245,92,163,247,207,97,240,31,119,193,218,8,126,55,140,227,96,125,232,141,63,111,23,232,13,65,141,30,144,210,18,42,210,196,169,47,169,194,84,166,28,55,170,96,56,149,188,210,36,47,11,78,139,7,20,69,253,123,171,251,131,251,242,179,191,254,144,205,211,241,67,172,190,41,220,94,145,245,244,55,234,230,227,162,239,56,199,245,11,18,14,35,26,232,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadNextStageFlowElement

		/// <exclude/>
		public class ReadNextStageFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadNextStageFlowElement(UserConnection userConnection, OpportunityManagementEndOfStage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadNextStage";
				IsLogging = true;
				SchemaElementUId = new Guid("3c6cc565-dc1f-4c05-a0a0-bdf1ceeb7de4");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,75,107,220,48,16,254,43,65,135,158,172,98,91,90,75,118,143,203,22,246,178,13,244,65,33,89,194,72,26,237,10,252,138,37,211,4,179,255,189,178,221,109,75,14,33,208,83,193,8,107,196,247,152,79,163,233,193,249,143,174,14,56,84,22,106,143,201,184,55,21,209,178,208,5,50,160,130,103,140,114,109,44,149,134,107,154,105,169,115,107,37,148,185,32,73,11,13,86,100,69,239,140,11,36,113,1,27,95,221,77,127,72,195,48,98,242,96,151,205,103,125,198,6,190,46,2,218,10,35,35,183,213,50,10,8,48,84,97,145,81,105,153,98,170,148,176,225,150,172,94,108,42,242,178,220,112,154,67,106,41,231,165,166,37,150,156,34,114,41,212,166,144,194,166,36,169,209,134,221,83,63,160,247,174,107,171,9,127,255,127,121,238,163,203,85,123,219,213,99,211,146,164,193,0,183,16,206,21,217,104,107,51,195,4,213,41,43,41,47,52,82,208,44,46,220,8,80,24,213,54,209,136,134,62,204,180,228,48,54,10,7,146,24,8,240,13,234,17,23,246,201,69,159,133,42,148,224,152,83,153,167,134,242,50,141,36,105,38,104,174,4,139,217,105,155,171,244,154,217,190,13,120,154,121,156,143,140,56,56,189,6,133,49,197,110,168,38,221,181,97,232,234,153,252,240,55,96,77,249,215,233,247,181,51,183,30,205,80,114,73,70,143,219,218,97,27,118,173,238,140,107,79,235,181,94,46,17,213,244,48,56,127,77,100,247,56,66,77,146,193,157,206,175,38,183,29,125,232,154,255,176,229,36,182,27,153,226,224,45,182,231,185,52,206,247,53,60,47,251,138,188,123,28,187,240,225,128,79,225,198,7,56,225,77,187,220,238,90,38,47,224,21,185,39,70,8,46,45,34,205,114,147,197,81,76,115,90,130,101,52,19,130,177,66,41,174,20,187,39,209,210,191,10,221,237,253,167,31,237,245,197,172,253,28,223,199,234,139,194,237,21,89,77,111,241,118,57,206,238,142,151,248,253,4,53,63,19,217,248,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadCountNotFinishedActivitiesFlowElement

		/// <exclude/>
		public class ReadCountNotFinishedActivitiesFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCountNotFinishedActivitiesFlowElement(UserConnection userConnection, OpportunityManagementEndOfStage process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCountNotFinishedActivities";
				IsLogging = true;
				SchemaElementUId = new Guid("868321fe-9c79-4ab3-8a81-b41ecb0e6d15");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,75,107,28,57,16,254,43,166,15,123,106,25,189,90,143,201,45,131,179,24,150,196,144,108,88,8,38,148,164,82,220,164,167,123,210,173,102,109,6,255,247,173,233,241,36,198,76,150,36,155,61,228,38,149,84,239,239,171,218,189,111,167,23,109,87,112,92,101,232,38,172,231,203,180,170,188,54,198,130,4,22,124,118,76,75,21,24,196,148,89,224,141,13,30,156,202,86,85,117,15,27,92,85,7,237,139,212,150,170,110,11,110,166,213,187,221,23,163,101,156,177,126,159,151,203,235,120,131,27,248,115,239,32,106,237,147,83,146,129,142,145,233,192,5,185,74,13,115,32,100,212,18,200,173,175,14,177,112,29,130,142,158,51,163,162,100,58,130,100,161,49,134,73,0,237,164,205,82,66,168,234,14,115,185,184,221,142,56,77,237,208,175,118,248,249,252,230,110,75,81,30,124,175,135,110,222,244,85,189,193,2,87,80,110,86,149,54,78,39,29,128,98,48,129,233,36,128,121,149,3,179,28,163,132,140,169,177,185,170,35,108,203,222,108,245,106,187,29,198,50,247,109,185,171,234,17,51,142,216,71,124,148,24,160,54,57,56,203,34,151,148,24,160,99,144,148,96,224,165,138,41,121,175,35,217,75,80,224,45,116,51,46,193,237,90,82,12,210,55,220,138,204,44,130,103,26,141,100,110,137,70,248,144,149,85,50,103,121,44,249,31,195,240,113,222,82,185,167,151,243,6,199,54,62,244,14,169,9,195,184,218,197,161,47,227,208,237,141,191,124,164,112,232,209,195,227,95,135,186,116,203,203,94,177,186,175,231,9,215,93,139,125,185,232,227,144,218,254,195,210,190,251,123,210,217,108,97,108,167,99,53,47,62,205,208,81,1,218,15,55,255,90,245,245,60,149,97,243,171,229,91,83,174,100,134,16,187,196,188,7,116,106,167,109,7,119,203,125,85,253,246,105,30,202,179,245,60,82,247,203,217,240,5,19,135,135,234,137,129,163,66,202,17,173,8,142,121,163,19,33,153,123,22,82,227,24,143,222,102,161,76,227,117,243,96,225,190,254,57,46,223,93,78,175,254,238,143,212,59,148,237,250,156,164,79,4,87,71,237,213,238,91,162,188,191,62,198,121,77,232,248,169,116,71,148,141,143,146,190,194,158,149,58,113,154,58,209,50,107,147,80,34,217,16,247,95,127,148,238,209,37,167,179,143,44,104,71,116,183,62,48,15,209,144,31,33,179,210,202,208,120,57,15,70,56,244,78,49,205,57,125,66,68,230,140,110,88,54,208,168,156,148,108,48,62,154,9,175,11,148,121,58,127,209,246,208,157,77,203,229,36,226,61,15,166,9,52,79,121,206,84,4,161,5,115,214,122,38,181,228,116,128,236,185,61,34,254,249,48,116,8,253,119,64,126,125,131,241,227,243,225,246,41,224,227,94,30,72,126,10,238,139,205,255,192,239,207,176,249,181,18,62,65,240,167,244,89,62,254,15,240,86,209,36,174,76,102,17,53,109,179,208,208,102,69,151,25,74,238,69,18,77,99,157,248,113,120,19,121,132,85,84,108,238,52,39,120,43,138,33,10,77,11,211,5,131,42,249,224,253,35,228,94,141,67,36,179,103,251,181,125,178,131,82,113,225,26,99,25,8,69,137,41,201,137,9,180,220,114,50,217,163,50,222,135,116,236,224,239,115,155,190,163,125,111,240,182,156,26,208,133,228,95,29,207,95,195,235,37,121,237,186,125,187,254,1,230,230,161,81,208,8,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		public OpportunityManagementEndOfStage(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityManagementEndOfStage";
			SchemaUId = new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_currentStage = () => { return (Guid)(((ReadCurrentStage.ResultEntity.IsColumnValueLoaded(ReadCurrentStage.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadCurrentStage.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty))); };
			_recommendation = () => { return new LocalizableString("You have completed all steps of the \"" + ((ReadCurrentStage.ResultEntity.IsColumnValueLoaded(ReadCurrentStage.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? ReadCurrentStage.ResultEntity.GetTypedColumnValue<string>("Name") : null)) + "\". Select the next action:"); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fea753ae-b6dc-408a-bac3-b7d60bec1df8");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: OpportunityManagementEndOfStage, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: OpportunityManagementEndOfStage, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public virtual int NextOpportunityStageNumber {
			get;
			set;
		}

		private Func<Guid> _currentStage;
		public virtual Guid CurrentStage {
			get {
				return (_currentStage ?? (_currentStage = () => Guid.Empty)).Invoke();
			}
			set {
				_currentStage = () => { return value; };
			}
		}

		private Func<LocalizableString> _recommendation;
		public virtual LocalizableString Recommendation {
			get {
				return (_recommendation ?? (_recommendation = () => null)).Invoke();
			}
			set {
				_recommendation = () => { return value; };
			}
		}

		public virtual bool IsStageChangedByUser {
			get;
			set;
		}

		public virtual bool DontShowPageEndOfStage {
			get;
			set;
		}

		public virtual Guid NextStage {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("f2f9628a-148c-457c-86a9-7f7baece560b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("2a12d765-1b7d-47e3-a00b-5c931dab802d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadCurrentStageFlowElement _readCurrentStage;
		public ReadCurrentStageFlowElement ReadCurrentStage {
			get {
				return _readCurrentStage ?? (_readCurrentStage = new ReadCurrentStageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private UpdateOpportunityStageFlowElement _updateOpportunityStage;
		public UpdateOpportunityStageFlowElement UpdateOpportunityStage {
			get {
				return _updateOpportunityStage ?? (_updateOpportunityStage = new UpdateOpportunityStageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ShowEndOfStagePageFlowElement _showEndOfStagePage;
		public ShowEndOfStagePageFlowElement ShowEndOfStagePage {
			get {
				return _showEndOfStagePage ?? (_showEndOfStagePage = new ShowEndOfStagePageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadOpportunityFlowElement _readOpportunity;
		public ReadOpportunityFlowElement ReadOpportunity {
			get {
				return _readOpportunity ?? (_readOpportunity = new ReadOpportunityFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadNextStageFlowElement _readNextStage;
		public ReadNextStageFlowElement ReadNextStage {
			get {
				return _readNextStage ?? (_readNextStage = new ReadNextStageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _setNextStageNumber;
		public ProcessScriptTask SetNextStageNumber {
			get {
				return _setNextStageNumber ?? (_setNextStageNumber = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SetNextStageNumber",
					SchemaElementUId = new Guid("2cc075ef-e2dc-4bbc-8186-706550bc8b21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SetNextStageNumberExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("3442dd87-3f5e-436c-9d5c-f6787c0fab8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadCountNotFinishedActivitiesFlowElement _readCountNotFinishedActivities;
		public ReadCountNotFinishedActivitiesFlowElement ReadCountNotFinishedActivities {
			get {
				return _readCountNotFinishedActivities ?? (_readCountNotFinishedActivities = new ReadCountNotFinishedActivitiesFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _setShowEndOfStagePage;
		public ProcessScriptTask SetShowEndOfStagePage {
			get {
				return _setShowEndOfStagePage ?? (_setShowEndOfStagePage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SetShowEndOfStagePage",
					SchemaElementUId = new Guid("4f941b7c-c6b4-4ad8-959c-b82b3f3767e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SetShowEndOfStagePageExecute,
				});
			}
		}

		private ProcessScriptTask _setNextStageByProcess;
		public ProcessScriptTask SetNextStageByProcess {
			get {
				return _setNextStageByProcess ?? (_setNextStageByProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SetNextStageByProcess",
					SchemaElementUId = new Guid("2b19d13a-f7cf-4d1c-b231-8775fd9b48d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SetNextStageByProcessExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("78c5c0a9-ea1b-4e76-b049-2da3afc80ec6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4;
		public ProcessExclusiveGateway ExclusiveGateway4 {
			get {
				return _exclusiveGateway4 ?? (_exclusiveGateway4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4",
					SchemaElementUId = new Guid("ee1eb647-192e-47bf-9462-02ad7e99bd9e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _setNextStageByUser;
		public ProcessScriptTask SetNextStageByUser {
			get {
				return _setNextStageByUser ?? (_setNextStageByUser = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "SetNextStageByUser",
					SchemaElementUId = new Guid("55b8d26d-8e5c-487a-81de-2f9292f3aa90"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = SetNextStageByUserExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("61b4d6d8-8e40-41d0-97fb-42dc65fd11af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("a7181db3-fab9-4d7c-8eee-d4d845df77f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("d1371036-7604-4d06-bb84-ab1771858c58"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow5;
		public ProcessConditionalFlow ConditionalFlow5 {
			get {
				return _conditionalFlow5 ?? (_conditionalFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow5",
					SchemaElementUId = new Guid("3bdfa389-17e8-4004-86a8-c6c06af091ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ReadCurrentStage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCurrentStage };
			FlowElements[UpdateOpportunityStage.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateOpportunityStage };
			FlowElements[ShowEndOfStagePage.SchemaElementUId] = new Collection<ProcessFlowElement> { ShowEndOfStagePage };
			FlowElements[ReadOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOpportunity };
			FlowElements[ReadNextStage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadNextStage };
			FlowElements[SetNextStageNumber.SchemaElementUId] = new Collection<ProcessFlowElement> { SetNextStageNumber };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadCountNotFinishedActivities.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCountNotFinishedActivities };
			FlowElements[SetShowEndOfStagePage.SchemaElementUId] = new Collection<ProcessFlowElement> { SetShowEndOfStagePage };
			FlowElements[SetNextStageByProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SetNextStageByProcess };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
			FlowElements[ExclusiveGateway4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4 };
			FlowElements[SetNextStageByUser.SchemaElementUId] = new Collection<ProcessFlowElement> { SetNextStageByUser };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadCurrentStage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetNextStageNumber", e.Context.SenderName));
						break;
					case "UpdateOpportunityStage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ShowEndOfStagePage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UpdateOpportunityStage", e.Context.SenderName));
						break;
					case "ReadOpportunity":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCurrentStage", e.Context.SenderName));
						break;
					case "ReadNextStage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetNextStageByProcess", e.Context.SenderName));
						break;
					case "SetNextStageNumber":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOpportunity", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCountNotFinishedActivities", e.Context.SenderName));
						break;
					case "ReadCountNotFinishedActivities":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOpportunity", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetShowEndOfStagePage", e.Context.SenderName));
						break;
					case "SetShowEndOfStagePage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOpportunity", e.Context.SenderName));
						break;
					case "SetNextStageByProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ShowEndOfStagePage", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway4", e.Context.SenderName));
						break;
					case "ExclusiveGateway4":
						if (ConditionalFlow5ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetNextStageByUser", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadNextStage", e.Context.SenderName));
						break;
					case "SetNextStageByUser":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ShowEndOfStagePage", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(!(IsStageChangedByUser));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "!(IsStageChangedByUser)", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadCountNotFinishedActivities.ResultCount) > 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadCountNotFinishedActivities", "ConditionalFlow3", "(ReadCountNotFinishedActivities.ResultCount) > 0", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((DontShowPageEndOfStage));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway3", "ConditionalFlow2", "(DontShowPageEndOfStage)", result);
			return result;
		}

		private bool ConditionalFlow5ExpressionExecute() {
			bool result = Convert.ToBoolean((IsStageChangedByUser));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway4", "ConditionalFlow5", "(IsStageChangedByUser)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ShowEndOfStagePage.NextStageResult")) {
				writer.WriteValue("ShowEndOfStagePage.NextStageResult", ShowEndOfStagePage.NextStageResult, null);
			}
			if (!HasMapping("ShowEndOfStagePage.CurrentStageId")) {
				writer.WriteValue("ShowEndOfStagePage.CurrentStageId", ShowEndOfStagePage.CurrentStageId, Guid.Empty);
			}
			if (!HasMapping("ShowEndOfStagePage.NextStageId")) {
				writer.WriteValue("ShowEndOfStagePage.NextStageId", ShowEndOfStagePage.NextStageId, Guid.Empty);
			}
			if (!HasMapping("ShowEndOfStagePage.OpportunityId")) {
				writer.WriteValue("ShowEndOfStagePage.OpportunityId", ShowEndOfStagePage.OpportunityId, Guid.Empty);
			}
			if (!HasMapping("ShowEndOfStagePage.IsStageChangedByUser")) {
				writer.WriteValue("ShowEndOfStagePage.IsStageChangedByUser", ShowEndOfStagePage.IsStageChangedByUser, false);
			}
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("NextOpportunityStageNumber")) {
				writer.WriteValue("NextOpportunityStageNumber", NextOpportunityStageNumber, 0);
			}
			if (!HasMapping("IsStageChangedByUser")) {
				writer.WriteValue("IsStageChangedByUser", IsStageChangedByUser, false);
			}
			if (!HasMapping("DontShowPageEndOfStage")) {
				writer.WriteValue("DontShowPageEndOfStage", DontShowPageEndOfStage, false);
			}
			if (!HasMapping("NextStage")) {
				writer.WriteValue("NextStage", NextStage, Guid.Empty);
			}
			if (!HasMapping("CurrentStage")) {
				writer.WriteValue("CurrentStage", CurrentStage, Guid.Empty);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("dfce71b8-964d-4c09-bd58-0c97f1365945", () => CurrentOpportunity);
			MetaPathParameterValues.Add("d7748fee-12d1-4402-9af3-177336bb4bb3", () => NextOpportunityStageNumber);
			MetaPathParameterValues.Add("7411fdec-830d-495b-8fcc-4494af5fe84c", () => CurrentStage);
			MetaPathParameterValues.Add("c26d6544-4636-434b-b986-690a58c482d2", () => Recommendation);
			MetaPathParameterValues.Add("2d124c72-8de2-4327-a821-7370bb4f3f04", () => IsStageChangedByUser);
			MetaPathParameterValues.Add("4a896c50-5660-4509-bcfa-09fdb87708e7", () => DontShowPageEndOfStage);
			MetaPathParameterValues.Add("b84b8659-7d6c-46df-be98-b96c5d0e5b85", () => NextStage);
			MetaPathParameterValues.Add("a180ecd0-2639-46fe-8f28-b1f4bf23afb2", () => ReadCurrentStage.DataSourceFilters);
			MetaPathParameterValues.Add("42e7b0d0-17c7-4dcc-a264-7be5a6a0e0b1", () => ReadCurrentStage.ResultType);
			MetaPathParameterValues.Add("1ee60d4e-4844-4702-9e5b-a9ef2faca871", () => ReadCurrentStage.ReadSomeTopRecords);
			MetaPathParameterValues.Add("f8cf2516-53d6-45f6-ba8d-4bfdabb48124", () => ReadCurrentStage.NumberOfRecords);
			MetaPathParameterValues.Add("b9fa8b3c-2f06-4b34-bbef-4f29b1947858", () => ReadCurrentStage.FunctionType);
			MetaPathParameterValues.Add("a9ce46aa-34eb-48fb-be04-e9c34eceff5f", () => ReadCurrentStage.AggregationColumnName);
			MetaPathParameterValues.Add("5061fcf5-7f96-49fa-8be4-619e0f5209ae", () => ReadCurrentStage.OrderInfo);
			MetaPathParameterValues.Add("e11d0fd9-aca0-4ee9-b9cf-f8d97c1fc2ba", () => ReadCurrentStage.ResultEntity);
			MetaPathParameterValues.Add("bbaa560d-a45c-4f10-ac9f-e0a221e816e8", () => ReadCurrentStage.ResultCount);
			MetaPathParameterValues.Add("c64386d0-db34-457e-833d-a14939236608", () => ReadCurrentStage.ResultIntegerFunction);
			MetaPathParameterValues.Add("e5dde80e-3396-4686-a165-fafbfad811d2", () => ReadCurrentStage.ResultFloatFunction);
			MetaPathParameterValues.Add("c161dd2c-4540-45be-9271-b9b410ff5929", () => ReadCurrentStage.ResultDateTimeFunction);
			MetaPathParameterValues.Add("1ca50f2d-35c9-435b-85de-6154c601ed28", () => ReadCurrentStage.ResultRowsCount);
			MetaPathParameterValues.Add("30c203aa-798c-414b-b6e2-e7435cabddcd", () => ReadCurrentStage.CanReadUncommitedData);
			MetaPathParameterValues.Add("18002008-4ddc-4cdc-9996-18caf8454929", () => ReadCurrentStage.ResultEntityCollection);
			MetaPathParameterValues.Add("7d1b816f-c970-49b1-bfdb-4212142710ce", () => ReadCurrentStage.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("e979c3ad-ef25-4300-b738-0666bbd3e28a", () => ReadCurrentStage.IgnoreDisplayValues);
			MetaPathParameterValues.Add("44bc81d4-fd3b-4974-a8bb-bcee7f140f1c", () => ReadCurrentStage.ResultCompositeObjectList);
			MetaPathParameterValues.Add("79113b9d-850d-46d7-ac7e-4451742b9d4f", () => ReadCurrentStage.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e99fa34f-868e-4b57-a3a8-13c100885498", () => UpdateOpportunityStage.EntitySchemaUId);
			MetaPathParameterValues.Add("05fb8dfb-1204-478c-a016-5e0dacf67068", () => UpdateOpportunityStage.IsMatchConditions);
			MetaPathParameterValues.Add("cc2f766d-1506-48eb-8d63-91ddc235a521", () => UpdateOpportunityStage.DataSourceFilters);
			MetaPathParameterValues.Add("0b1a99dc-d621-4151-8384-3e221142a390", () => UpdateOpportunityStage.RecordColumnValues);
			MetaPathParameterValues.Add("3fc920dd-5c62-4946-a873-1c00873e193a", () => ShowEndOfStagePage.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("95bf65a8-5bdc-4b02-b95a-1f12ff622cbd", () => ShowEndOfStagePage.Recommendation);
			MetaPathParameterValues.Add("29a26301-669f-494a-8967-ef76ebcb346b", () => ShowEndOfStagePage.EntityId);
			MetaPathParameterValues.Add("f14e9164-cb48-4c4d-9eda-2a426442f1fd", () => ShowEndOfStagePage.EntryPointId);
			MetaPathParameterValues.Add("63792a62-2e22-48b7-8c75-26ed007ef6a2", () => ShowEndOfStagePage.EntitySchemaUId);
			MetaPathParameterValues.Add("a9895f5a-79bc-4b95-be4c-0b420f907431", () => ShowEndOfStagePage.Title);
			MetaPathParameterValues.Add("17508aa3-5868-4feb-acab-c83ec5a89cff", () => ShowEndOfStagePage.UseCardProcessModule);
			MetaPathParameterValues.Add("37dae5df-0de8-4721-b69a-620d86c5a9c6", () => ShowEndOfStagePage.OwnerId);
			MetaPathParameterValues.Add("4ecc7287-ee70-49bd-b052-12d9c04640cc", () => ShowEndOfStagePage.ShowExecutionPage);
			MetaPathParameterValues.Add("81c142cf-f5e8-4758-b878-a1157cb21f63", () => ShowEndOfStagePage.InformationOnStep);
			MetaPathParameterValues.Add("1f3d14a9-bcd1-4c8e-a749-366397869b93", () => ShowEndOfStagePage.IsRunning);
			MetaPathParameterValues.Add("36a84788-1028-4b2e-98d6-2fbe879744a3", () => ShowEndOfStagePage.Template);
			MetaPathParameterValues.Add("06aa8216-8b15-4df3-b9df-e7d918b5236f", () => ShowEndOfStagePage.Module);
			MetaPathParameterValues.Add("1ad0b383-15c7-4249-8e72-97d1c9d85d78", () => ShowEndOfStagePage.PressedButtonCode);
			MetaPathParameterValues.Add("888d6ff6-d3d4-442c-9b04-b603fcb72adb", () => ShowEndOfStagePage.Url);
			MetaPathParameterValues.Add("7584122f-a24d-4575-a5b9-b55b2a9abc8a", () => ShowEndOfStagePage.NextStageResult);
			MetaPathParameterValues.Add("8de5380d-ac3d-411c-8a77-2c835c3d43d4", () => ShowEndOfStagePage.CurrentStageId);
			MetaPathParameterValues.Add("f3923742-d7d7-43e1-8429-ef222561e1eb", () => ShowEndOfStagePage.NextStageId);
			MetaPathParameterValues.Add("7b3decd5-3d89-4cff-b95d-730a6013cb27", () => ShowEndOfStagePage.OpportunityId);
			MetaPathParameterValues.Add("61077983-3941-4d4a-9630-edfbacf49a87", () => ShowEndOfStagePage.IsStageChangedByUser);
			MetaPathParameterValues.Add("4e5d457b-42b9-4672-8b52-c52e77513010", () => ReadOpportunity.DataSourceFilters);
			MetaPathParameterValues.Add("8447c567-6c37-4e2b-a3dd-2447daaaaf66", () => ReadOpportunity.ResultType);
			MetaPathParameterValues.Add("0e8e3ca1-4e02-4cfd-9534-dfc91c400628", () => ReadOpportunity.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7f19d59d-6e3e-4583-9422-7df884633ba7", () => ReadOpportunity.NumberOfRecords);
			MetaPathParameterValues.Add("fbccc177-264d-4b7a-81b0-a23219940711", () => ReadOpportunity.FunctionType);
			MetaPathParameterValues.Add("d4181cb4-8130-424d-ae68-c843f87a8855", () => ReadOpportunity.AggregationColumnName);
			MetaPathParameterValues.Add("50b25f81-e993-4f01-a6e6-374b3659b858", () => ReadOpportunity.OrderInfo);
			MetaPathParameterValues.Add("be61dc40-5e32-4d0b-9d27-1e361e54f22b", () => ReadOpportunity.ResultEntity);
			MetaPathParameterValues.Add("06755d62-3109-44a6-a9ab-3f4754d27ca3", () => ReadOpportunity.ResultCount);
			MetaPathParameterValues.Add("daf5e600-722b-43e1-a28d-5cefd2a1ba80", () => ReadOpportunity.ResultIntegerFunction);
			MetaPathParameterValues.Add("f1cb258f-287d-4c5c-b4ac-277f0f9884bb", () => ReadOpportunity.ResultFloatFunction);
			MetaPathParameterValues.Add("797c93d6-bc60-4d21-a669-039897df02c3", () => ReadOpportunity.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0f2ed61f-3f3e-487a-8430-3fb6764f469d", () => ReadOpportunity.ResultRowsCount);
			MetaPathParameterValues.Add("4e8bf658-f625-4d19-ad5b-727fb3b2847e", () => ReadOpportunity.CanReadUncommitedData);
			MetaPathParameterValues.Add("3d15909c-f006-4a7a-8b1c-fede8e2a9eae", () => ReadOpportunity.ResultEntityCollection);
			MetaPathParameterValues.Add("86e11392-27d0-4340-9d60-c67a8335b463", () => ReadOpportunity.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4b80d1c9-90f8-4449-82d6-693bf426b73b", () => ReadOpportunity.IgnoreDisplayValues);
			MetaPathParameterValues.Add("cb8874a6-c6ee-4d18-adde-6d01cef9bdaa", () => ReadOpportunity.ResultCompositeObjectList);
			MetaPathParameterValues.Add("49436b7b-e767-4b4d-b557-358ddfc2bba0", () => ReadOpportunity.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a75219e0-00f3-4d5d-a9f7-651b6e4376ef", () => ReadNextStage.DataSourceFilters);
			MetaPathParameterValues.Add("b64d0a3c-c0d0-4958-81f1-b5ede9765ad4", () => ReadNextStage.ResultType);
			MetaPathParameterValues.Add("24325d83-50e7-4573-8f91-35e07a45c717", () => ReadNextStage.ReadSomeTopRecords);
			MetaPathParameterValues.Add("f3903c6b-98c5-40bf-916d-98a7b572a579", () => ReadNextStage.NumberOfRecords);
			MetaPathParameterValues.Add("a0182d1d-381b-4c10-a8ec-d985836d5cc9", () => ReadNextStage.FunctionType);
			MetaPathParameterValues.Add("85950cf7-252d-4b5c-9bfd-ad509d940e2f", () => ReadNextStage.AggregationColumnName);
			MetaPathParameterValues.Add("81c297c2-fc42-4e9b-89ee-73751508db6a", () => ReadNextStage.OrderInfo);
			MetaPathParameterValues.Add("92ea37fd-45c4-4fb2-98b7-eb6e66edd5ff", () => ReadNextStage.ResultEntity);
			MetaPathParameterValues.Add("7ab26365-d3e5-4729-92b4-d09e2de024d0", () => ReadNextStage.ResultCount);
			MetaPathParameterValues.Add("95f97244-d092-4885-aea6-53b76e1303a7", () => ReadNextStage.ResultIntegerFunction);
			MetaPathParameterValues.Add("2cc4d02b-1588-44de-9fa7-b09506a2c14f", () => ReadNextStage.ResultFloatFunction);
			MetaPathParameterValues.Add("1cb876d9-d17b-4fc0-a745-da0b4ea53266", () => ReadNextStage.ResultDateTimeFunction);
			MetaPathParameterValues.Add("4201c6a3-e0ab-4f41-b531-0fb631720790", () => ReadNextStage.ResultRowsCount);
			MetaPathParameterValues.Add("96bc11af-2c34-4987-a0f6-2575203da254", () => ReadNextStage.CanReadUncommitedData);
			MetaPathParameterValues.Add("92ba46a0-d926-4f32-868c-882c9bef0c1b", () => ReadNextStage.ResultEntityCollection);
			MetaPathParameterValues.Add("3df688c3-a044-4e2f-b4d5-974b22314e82", () => ReadNextStage.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("e3d4eab8-cdc4-425a-be85-68f08022c240", () => ReadNextStage.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ce276b8c-5973-4455-b979-03e17f80e74a", () => ReadNextStage.ResultCompositeObjectList);
			MetaPathParameterValues.Add("ac39acaf-4b66-41c8-9aa8-d7137b54ece2", () => ReadNextStage.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("6a1d2bd1-de4f-40aa-9125-c113b2d391c5", () => ReadCountNotFinishedActivities.DataSourceFilters);
			MetaPathParameterValues.Add("0959d33a-0a66-4437-b25b-f3bda29e8610", () => ReadCountNotFinishedActivities.ResultType);
			MetaPathParameterValues.Add("bb79a7c9-22cc-4cfa-8454-2c336d3bbfa5", () => ReadCountNotFinishedActivities.ReadSomeTopRecords);
			MetaPathParameterValues.Add("24dd4a10-4e2c-4dbc-ac53-610bca6745d2", () => ReadCountNotFinishedActivities.NumberOfRecords);
			MetaPathParameterValues.Add("fc43106b-6ad4-40bf-a590-bdcc5c40964f", () => ReadCountNotFinishedActivities.FunctionType);
			MetaPathParameterValues.Add("0d8bea86-be3d-47ce-be07-e371b62fc691", () => ReadCountNotFinishedActivities.AggregationColumnName);
			MetaPathParameterValues.Add("37082b06-1012-4b4d-a2ad-042c8195bd8d", () => ReadCountNotFinishedActivities.OrderInfo);
			MetaPathParameterValues.Add("1fd1d50c-01de-4e1b-90a2-28e34e2af4be", () => ReadCountNotFinishedActivities.ResultEntity);
			MetaPathParameterValues.Add("adb67efb-8644-4a2e-a47b-ead879586020", () => ReadCountNotFinishedActivities.ResultCount);
			MetaPathParameterValues.Add("b4741ed6-a5d9-425f-89cb-d88bb25d9d90", () => ReadCountNotFinishedActivities.ResultIntegerFunction);
			MetaPathParameterValues.Add("2708fded-c17f-4033-9321-837e75a17968", () => ReadCountNotFinishedActivities.ResultFloatFunction);
			MetaPathParameterValues.Add("86a273c0-dc2f-4650-9c6c-5b7ffee3cd43", () => ReadCountNotFinishedActivities.ResultDateTimeFunction);
			MetaPathParameterValues.Add("cbd49361-8bca-4903-b561-a67607267747", () => ReadCountNotFinishedActivities.ResultRowsCount);
			MetaPathParameterValues.Add("ce29d90c-dbf6-45ef-b05c-543edaf33473", () => ReadCountNotFinishedActivities.CanReadUncommitedData);
			MetaPathParameterValues.Add("59ffe7bc-8788-4279-be21-1c5a28993330", () => ReadCountNotFinishedActivities.ResultEntityCollection);
			MetaPathParameterValues.Add("f2b89827-46fd-4c18-b956-876018f44ca1", () => ReadCountNotFinishedActivities.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("c76447c0-1087-47a0-b5f1-4dbe3d1a44b8", () => ReadCountNotFinishedActivities.IgnoreDisplayValues);
			MetaPathParameterValues.Add("efe44f1f-d24a-4664-a89f-56513698f293", () => ReadCountNotFinishedActivities.ResultCompositeObjectList);
			MetaPathParameterValues.Add("cac0e459-da85-49e8-aa8a-fba8ae4ff5f4", () => ReadCountNotFinishedActivities.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ShowEndOfStagePage.NextStageResult":
					ShowEndOfStagePage.NextStageResult = reader.GetValue<System.String>();
				break;
				case "ShowEndOfStagePage.CurrentStageId":
					ShowEndOfStagePage.CurrentStageId = reader.GetValue<System.Guid>();
				break;
				case "ShowEndOfStagePage.NextStageId":
					ShowEndOfStagePage.NextStageId = reader.GetValue<System.Guid>();
				break;
				case "ShowEndOfStagePage.OpportunityId":
					ShowEndOfStagePage.OpportunityId = reader.GetValue<System.Guid>();
				break;
				case "ShowEndOfStagePage.IsStageChangedByUser":
					ShowEndOfStagePage.IsStageChangedByUser = reader.GetValue<System.Boolean>();
				break;
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "NextOpportunityStageNumber":
					if (!hasValueToRead) break;
					NextOpportunityStageNumber = reader.GetValue<System.Int32>();
				break;
				case "IsStageChangedByUser":
					if (!hasValueToRead) break;
					IsStageChangedByUser = reader.GetValue<System.Boolean>();
				break;
				case "DontShowPageEndOfStage":
					if (!hasValueToRead) break;
					DontShowPageEndOfStage = reader.GetValue<System.Boolean>();
				break;
				case "NextStage":
					if (!hasValueToRead) break;
					NextStage = reader.GetValue<System.Guid>();
				break;
				case "CurrentStage":
					if (!hasValueToRead) break;
					CurrentStage = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SetNextStageNumberExecute(ProcessExecutingContext context) {
			var localNextOpportunityStageNumber = ((ReadCurrentStage.ResultEntity.IsColumnValueLoaded(ReadCurrentStage.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? ReadCurrentStage.ResultEntity.GetTypedColumnValue<int>("Number") : 0)) + 1;
			NextOpportunityStageNumber = (System.Int32)localNextOpportunityStageNumber;
			return true;
		}

		public virtual bool SetShowEndOfStagePageExecute(ProcessExecutingContext context) {
			var localDontShowPageEndOfStage = true;
			DontShowPageEndOfStage = (System.Boolean)localDontShowPageEndOfStage;
			return true;
		}

		public virtual bool SetNextStageByProcessExecute(ProcessExecutingContext context) {
			var localNextStage = ((ReadNextStage.ResultEntity.IsColumnValueLoaded(ReadNextStage.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadNextStage.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty));
			NextStage = (System.Guid)localNextStage;
			return true;
		}

		public virtual bool SetNextStageByUserExecute(ProcessExecutingContext context) {
			var localNextStage = ((ReadOpportunity.ResultEntity.IsColumnValueLoaded(ReadOpportunity.ResultEntity.Schema.Columns.GetByName("Stage").ColumnValueName) ? ReadOpportunity.ResultEntity.GetTypedColumnValue<Guid>("StageId") : Guid.Empty));
			NextStage = (System.Guid)localNextStage;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (OpportunityManagementEndOfStage)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

