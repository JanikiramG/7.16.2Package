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

	#region Class: OppManagerPerceptionAnalysisSchema

	/// <exclude/>
	public class OppManagerPerceptionAnalysisSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public OppManagerPerceptionAnalysisSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public OppManagerPerceptionAnalysisSchema(OppManagerPerceptionAnalysisSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OppManagerPerceptionAnalysis";
			UId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a");
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
			RealUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a");
			Version = 0;
			PackageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCurrentOpportunityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d027b201-fbd7-4889-8413-e3656350f7d8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpportunityStageChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ff6f79f1-b910-436f-9c38-487012f07520"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"OpportunityStageChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMainContactParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f0e8319b-9385-4f8f-a4bf-74799cd7173a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"MainContact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOpportunityParameter());
			Parameters.Add(CreateOpportunityStageChangedParameter());
			Parameters.Add(CreateMainContactParameter());
		}

		protected virtual void InitializeReadOpportunityDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0aef70fd-d49f-49e9-9592-dc554a56cb2a"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,75,242,135,156,227,178,45,123,73,3,77,75,33,89,194,179,244,148,21,248,43,178,68,179,152,253,239,149,215,217,20,114,40,133,158,2,58,72,239,105,230,205,12,210,252,96,167,207,182,245,232,106,3,237,132,73,216,233,154,52,146,151,192,0,40,67,149,81,145,85,5,149,121,153,81,201,192,164,186,200,141,74,75,146,244,208,97,77,86,244,86,91,79,18,235,177,155,234,187,249,15,169,119,1,147,7,115,62,124,83,7,236,224,251,50,0,80,20,166,169,74,170,82,166,168,0,172,40,104,158,81,144,140,43,173,165,20,202,144,85,11,26,193,121,218,112,154,69,0,21,58,151,180,145,70,71,65,133,144,138,51,110,26,70,146,22,141,223,62,143,14,167,201,14,125,61,227,235,254,246,56,70,149,235,236,205,208,134,174,39,73,135,30,110,192,31,22,33,41,138,92,1,85,66,230,84,24,44,41,112,169,41,135,166,100,101,133,89,145,69,167,10,70,191,208,146,157,38,137,6,15,63,160,13,120,102,158,109,212,200,120,154,85,121,17,177,25,143,118,56,75,105,85,68,119,70,23,70,34,47,164,108,244,37,175,47,193,198,189,157,174,67,135,206,170,151,216,49,230,55,184,122,86,67,239,221,208,46,212,215,231,235,183,248,236,215,112,95,90,63,87,67,62,214,23,16,57,37,97,194,77,107,177,247,219,94,13,218,246,143,43,231,233,20,33,221,8,206,78,151,20,182,79,1,90,146,56,251,120,248,107,90,155,48,249,161,123,71,86,147,104,51,114,196,71,118,150,187,188,65,109,167,177,133,227,249,92,147,143,79,97,240,87,155,224,92,4,127,24,198,113,112,62,244,214,31,215,6,121,67,80,147,123,162,83,86,54,44,205,168,105,116,73,69,85,73,90,137,140,211,104,50,47,120,158,154,82,87,247,36,138,250,255,81,119,187,233,235,175,254,242,67,86,79,251,79,177,250,166,112,115,65,214,243,191,168,59,237,23,125,251,83,92,191,1,165,164,59,204,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("98d24394-7aa3-4639-bf4a-afdbc28c23d0"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4b5ed227-1d59-4cad-b76a-fb250899afba"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c69ff36d-f445-4822-bdf3-4ef53fc5fbbc"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b86f45ca-1532-4835-a794-01e949e70302"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6c9261b3-581b-4c7b-819a-3bc7c38dcac3"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("2fb4cbc9-3b9f-44e4-a1d9-d848464d35ec"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("bb080e41-77f3-4cde-8f54-28f530986932"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5561b4ed-a190-4d26-86ab-59ce13b43b28"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("9e050f13-ceab-4083-8446-c5ebe3cf5bb2"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("b8406a60-245b-4655-b3cb-805fec26409d"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("7a286138-0dc8-47cd-aa12-a5e4885cb5f7"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("0637f70e-054a-448b-9dc7-eca6bb4d33b4"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("ca96d206-d1af-4dc4-b7b1-76406a1734a1"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("f3dde4b3-fab9-432e-aa72-0b434eb5bf90"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5cadac1a-8fa6-44ba-9818-6cf47a157a26"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e98f559-9433-4f6f-bfdd-da8018abfc21"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("e645f6b3-94d5-4fcb-b03d-327db7f9fea3"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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
				UId = new Guid("f90f341d-a43d-43bc-905d-ab5365aad618"),
				ContainerUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
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

		protected virtual void InitializeUserQuestionUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var branchingDecisionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d5f5d3ae-3eba-476f-8afe-7cae29c1de03"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"BranchingDecisions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableParameterValuesListDataValueType")
			};
			branchingDecisionsParameter.SourceValue = new ProcessSchemaParameterValue(branchingDecisionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,77,107,2,49,20,69,255,74,9,46,39,146,73,102,242,225,86,41,8,34,46,172,80,74,23,47,153,23,58,116,236,72,18,11,85,230,191,55,99,161,84,74,165,187,7,247,158,199,61,103,50,73,31,7,36,51,178,197,16,32,246,62,77,231,125,192,233,38,244,14,99,156,174,122,7,93,123,2,219,225,6,2,236,49,97,216,65,119,196,184,106,99,42,238,174,49,82,144,201,251,37,37,179,167,51,89,38,220,63,44,155,252,221,213,53,54,76,114,42,107,215,208,202,104,75,141,247,140,10,175,21,19,74,65,233,234,12,143,221,51,185,124,200,16,247,220,114,103,13,245,156,219,12,73,73,181,55,249,82,182,18,74,51,97,153,34,67,65,214,121,214,79,110,129,174,141,109,255,198,198,112,14,135,148,239,49,111,227,202,157,118,95,165,20,142,88,124,19,143,121,112,238,46,208,207,95,208,189,226,213,140,109,174,146,97,40,174,124,42,133,194,160,160,182,1,153,7,113,67,141,129,134,106,86,90,169,121,163,44,138,95,62,22,42,229,164,227,180,54,78,209,74,131,162,198,89,65,53,87,149,22,134,249,90,136,91,62,229,191,125,214,253,223,58,247,208,197,209,231,121,248,4,117,45,206,4,253,1,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(branchingDecisionsParameter);
			var resultDecisionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("26fb2285-bd22-4bfa-899e-b86587547eb6"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ResultDecisions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			resultDecisionsParameter.SourceValue = new ProcessSchemaParameterValue(resultDecisionsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDecisionsParameter);
			var decisionModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7981bd1a-6e1f-4618-95b2-b2e01cd1a7ff"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"DecisionMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			decisionModeParameter.SourceValue = new ProcessSchemaParameterValue(decisionModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(decisionModeParameter);
			var isDecisionRequiredParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8421eda1-c015-47d1-870d-db890151040b"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"IsDecisionRequired",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isDecisionRequiredParameter.SourceValue = new ProcessSchemaParameterValue(isDecisionRequiredParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(isDecisionRequiredParameter);
			var questionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("875ec9e9-dd3b-4094-8404-8a34db3ed419"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Question",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			questionParameter.SourceValue = new ProcessSchemaParameterValue(questionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Is proposal calculation required?",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(questionParameter);
			var windowCaptionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("039c67ed-06da-4917-829a-f6aac39e6957"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			windowCaptionParameter.SourceValue = new ProcessSchemaParameterValue(windowCaptionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Page for selecting answer to the ""Is proposal calculation required?"" item",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(windowCaptionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("adf0b461-8884-454d-8f38-9df0346f9773"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Is proposal calculation required?",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("5487762e-5d14-4fc1-8ebf-cd9d2610b431"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("4b999032-20f7-417c-af5d-b127483cc612"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a0d5ba33-923f-4031-b6c0-51adad28f67d}].[Parameter:{bb080e41-77f3-4cde-8f54-28f530986932}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea22e001-dcbe-4bc4-9a02-2c1b41f9af29"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7b874cd5-90b5-48d0-be34-b1fb34197a54"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b15e0992-0fc2-4dfe-a4f9-fa3fcd90e0f8"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("79dd7651-d12b-4acf-8138-3259b2335266"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("961107c6-ccdc-4170-bcb4-629e74de93b4"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("945a533b-c1ad-4bcd-92b8-0d63bcd8b3cd"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38b1176b-b184-4d13-85a1-e0dbc5518fd7"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("65e35847-2142-45e3-ab99-3b423fd43b14"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("104c7104-92e9-4712-aef0-0961190b310a"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("f17aac24-7ead-45a5-82e0-d1d50d68b92c"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a0d5ba33-923f-4031-b6c0-51adad28f67d}].[Parameter:{bb080e41-77f3-4cde-8f54-28f530986932}].[EntityColumn:{4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("e30b2ace-5428-4350-8646-c86fbd585444"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{f0e8319b-9385-4f8f-a4bf-74799cd7173a}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("4bf9d5bf-be82-4415-a923-d3ec28b02c80"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d027b201-fbd7-4889-8413-e3656350f7d8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("1af535fd-8887-4455-a919-bd7878e93ebd"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("a1613930-25b4-443a-9990-ebd497dc416d"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6084c27f-3d67-4dfa-88ab-14eb3e2d03ee"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77ede53f-6608-4aa1-b205-4508dcc36f3d"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("46091d70-d4f5-47b0-ae4c-6c9a13b83cae"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cde0a3c8-be8a-47ee-8f6c-da2c9754fe85"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("49a4e1b3-c652-48b7-806c-3dbd7ee553fe"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c0a34689-fed1-436d-8be6-8b384239cd5b"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f0dacc10-0333-4a64-9349-953fe7a85056"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
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
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("ea49d15a-798f-44dc-946b-2695d954c509"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e647fdca-2e8e-42a1-bd7d-aa5bf251bafe"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7aee44c6-a081-4f10-bac5-bb0452bbd3b0"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("46c20e90-2010-4928-b8a4-fe4ab0378027"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("a3f2a145-5dcb-4c2f-b908-54287d2899c5"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("143df26b-7ada-46d0-92e5-e54a8a2c7d34"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5ec1b134-513c-4a6a-a568-41bfd0fe8824"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fdd5cd49-af63-455e-8f97-c818c27db7e5"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0e20a88-f99c-49c2-8c2c-29c9c259358c"),
				ContainerUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
		}

		protected virtual void InitializeIntermediateCatchSignalEvent1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e58bb00-85b9-4485-ab15-611681bef565"),
				ContainerUId = new Guid("c85ba0dd-4fb6-4533-8e65-3b621ddaa77d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c85ba0dd-4fb6-4533-8e65-3b621ddaa77d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d027b201-fbd7-4889-8413-e3656350f7d8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeActivityUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f6d122ec-ed31-4da2-af2b-bc63817e61c0"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Prepare and upload proposal calculation",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("4a7ad5c8-3553-4a30-9e8c-6f20c2b4cf26"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"42c74c49-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0f7320c4-65ec-4b5d-b99a-6bdfda10d4d5"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{6bca4f14-5d1b-458e-bf57-0ec26c9a89ac}].[Parameter:{2493dc71-1d44-484f-90c7-87266ec877f3}].[EntityColumn:{e5b2fbc9-3939-43d2-8443-aa5c9b863253}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4dd4b7c8-a585-4621-a8e5-2c6193905762"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"60",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ecba22d1-7f1b-4774-a89e-6c9790386be3"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("798ed239-aa86-40e7-a9d2-21f2cff2055d"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a7cb1fc-3038-4276-9865-f826c33b81f2"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6fcf2440-4c47-41dc-b130-c2b28982e192"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9be165b-d1d9-4e4b-b480-a93e814c7229"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("75d77b6a-50ff-4a3d-b6b9-247c84b15572"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b2d15a10-3425-4bb4-bd3b-b951bfa787ea"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("dec1e674-7bff-4be2-ad87-b0ea10536aff"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("3811eae7-1dde-401b-a2df-a8a17263d06b"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a0d5ba33-923f-4031-b6c0-51adad28f67d}].[Parameter:{bb080e41-77f3-4cde-8f54-28f530986932}].[EntityColumn:{4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5be7e4d7-53b0-403c-9048-957d9a3b15d1"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{f0e8319b-9385-4f8f-a4bf-74799cd7173a}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("ce3f0499-a11f-4777-bdba-2792136dd144"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d027b201-fbd7-4889-8413-e3656350f7d8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("6d6780cb-c931-4c5d-b52b-fe5c9444d93f"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("fe45e260-5800-4213-b40c-7a8aea2a3f4b"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("45fb95cc-842d-4a68-a5eb-979402a99a4f"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("323513f2-934c-4919-8fde-d89a309fb149"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b74655c-15c6-4fe2-a89a-e94c705cc7b8"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b05554ca-f5bf-4d84-9e04-900d8950c40e"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e9034b35-4d0a-4813-97c6-81cd3ce8090d"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a4c4aae4-38a3-4a5d-b6ee-1017d419f3f8"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a09eff2b-cafb-41cc-be73-30c58c379b1e"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("1c79b3f3-cd4b-418f-883c-e74b16c576ba"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f42a2702-fc89-4bac-9232-11bdf7f72eff"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8778df1b-c517-462c-bc52-8393851a71b2"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9df4f5ee-edbb-47b2-9e3a-bab440f8b95b"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("5cc558c6-e331-4f28-a8f6-1d9bb233bb74"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("6e358665-5347-4829-a3de-00fb17d6ce97"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2218d180-e503-40f9-b4bb-8debb4a49f8e"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("053bd064-4bd8-4a5a-8abe-64bc1f10676a"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1ccd02a9-4fbc-4785-9912-b95942d3c5da"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
			var queueItemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("272aeb9e-8c7d-4be2-be62-6a8b547d9fb1"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"QueueItem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			queueItemParameter.SourceValue = new ProcessSchemaParameterValue(queueItemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(queueItemParameter);
			var applicationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("45c9f17d-3937-4111-8ec3-76a85af38587"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Application",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			applicationParameter.SourceValue = new ProcessSchemaParameterValue(applicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(applicationParameter);
			var finApplicationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("367e0f84-4fd7-4897-a879-47c7a48900ba"),
				ContainerUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"FinApplication",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			finApplicationParameter.SourceValue = new ProcessSchemaParameterValue(finApplicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(finApplicationParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b1f60a31-863b-480c-8bc3-aa61b3fb7a1a"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,203,106,220,48,20,134,95,101,208,162,43,107,144,172,155,237,46,167,147,146,77,26,218,180,20,146,16,116,57,74,4,190,197,150,219,4,51,239,94,121,156,105,33,139,146,85,161,96,132,46,254,255,115,206,167,163,249,46,140,103,161,142,48,84,94,215,35,100,211,185,171,16,128,43,180,102,20,187,146,27,204,25,23,216,40,78,176,228,74,89,197,153,40,37,67,89,171,27,168,208,170,222,187,16,81,22,34,52,99,117,61,255,49,141,195,4,217,157,63,46,190,216,7,104,244,215,37,128,112,5,23,210,112,76,5,16,204,29,164,0,36,13,218,27,74,188,84,165,176,4,173,185,88,198,57,179,158,98,74,169,199,73,229,112,41,40,197,134,90,171,168,23,38,55,5,202,106,240,113,255,212,15,48,142,161,107,171,25,126,207,175,158,251,148,229,26,123,215,213,83,211,162,172,129,168,47,117,124,168,144,6,2,92,88,141,45,47,5,230,30,20,214,172,116,152,105,163,114,85,0,149,84,161,204,234,62,46,182,232,220,161,204,233,168,191,233,122,130,163,243,28,82,142,57,35,180,16,50,105,41,179,137,87,78,112,33,11,133,189,147,190,4,38,203,210,184,19,175,143,83,72,243,48,94,76,13,12,193,190,96,135,196,175,27,170,217,118,109,28,186,122,177,190,56,254,126,5,79,113,133,251,114,244,125,45,40,166,253,69,132,14,217,52,194,174,14,208,198,125,107,59,23,218,251,213,243,112,72,146,166,215,67,24,79,20,246,143,147,174,81,54,132,251,135,191,210,218,77,99,236,154,255,168,212,44,149,153,60,82,147,29,211,93,122,208,133,177,175,245,243,113,93,161,119,143,83,23,223,127,6,237,54,93,223,119,67,156,218,16,159,55,75,129,219,179,48,140,113,179,244,238,166,243,155,4,98,170,99,178,222,216,174,174,193,46,23,191,253,16,126,132,5,207,106,131,94,133,171,208,13,210,196,9,163,25,195,101,206,82,155,146,244,120,140,180,4,11,170,157,118,121,145,154,218,109,141,33,69,234,55,138,149,242,12,115,235,0,23,94,112,156,142,5,35,101,33,75,150,111,169,240,196,147,146,98,144,50,57,229,206,224,130,40,131,61,183,185,118,146,49,101,228,13,74,48,254,117,137,215,231,227,167,159,237,233,29,175,228,111,183,105,247,213,198,190,134,38,93,81,53,191,133,201,33,9,46,79,161,170,249,45,132,22,201,190,141,169,184,245,61,87,243,91,144,29,110,23,104,183,135,244,253,2,33,23,41,100,245,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2fe9045d-6440-4eb3-ac16-7fd16fdb3c5d"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a190c1e8-f1a5-409c-b95a-f15ddea09916"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("80617af5-3a47-4462-b09d-b91c8cf423f2"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cc314aa-e2fc-4b79-bfe7-f771e1a3b5ca"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b43ffc26-c36e-4c5a-b5ea-81958624b05b"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("8b419064-13ee-4fed-9d2e-e10f90b4997a"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("2493dc71-1d44-484f-90c7-87266ec877f3"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb1f890a-8160-4bc0-bf9f-ad9ce0e9ba82"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("3717acd4-7111-4122-bc21-1aa485a407f6"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("88d3d801-11fc-4791-a92a-b5b26e1f818e"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("ff3548b2-c85a-4779-bd53-9be5414d281f"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("2c81b463-7773-4aba-9151-5c328ed14a9f"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("d70b4471-679e-4831-ab61-882b32617add"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("4f236a81-793b-457d-af14-eb430c15709b"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b2c21bd6-b96e-4ed8-80fa-cb41d20e1f71"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a7c8b5a-a762-4033-9fb8-c142ad321e08"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("bb406099-fe3c-410d-aab9-d4025a822060"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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
				UId = new Guid("79f4f5be-b15d-48db-92dd-a805b575a4be"),
				ContainerUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
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

		protected virtual void InitializeActivityUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8ee5f381-95c2-4025-af01-25db6c3e5c45"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Prepare proposal",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("bb72bde9-74fb-4bfc-be67-c6b1f314d2f4"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("38ba2f38-a350-4595-966b-724236e775e9"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a0d5ba33-923f-4031-b6c0-51adad28f67d}].[Parameter:{bb080e41-77f3-4cde-8f54-28f530986932}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("de37bc76-4310-46f9-9cdc-468af57e60d5"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"60",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5961b815-4117-4e48-8cd6-ca632bf2581a"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc5c39a8-b962-49b8-94f3-bf9b148b60ac"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c02c9f22-9855-4be3-9b7f-f8cc0a479932"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bd75e7df-6e74-495d-a1d5-9bd65d4df2eb"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("57d1cc0f-bd95-4535-ba84-55b3bd705701"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca4fafea-24a3-4413-a66c-7b94505c990e"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b153d9e9-920c-47ee-92f5-ad7e7ef13e9c"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("2f46f59b-3247-41cc-ad06-0849525cb94b"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("67d02137-5faa-4273-a8b9-655956f3d4fc"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a0d5ba33-923f-4031-b6c0-51adad28f67d}].[Parameter:{bb080e41-77f3-4cde-8f54-28f530986932}].[EntityColumn:{4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("72659f14-5f26-43bb-a73c-c2e4e118d9b8"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{f0e8319b-9385-4f8f-a4bf-74799cd7173a}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("a4925509-b538-4a41-ab96-bcb7da256540"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d027b201-fbd7-4889-8413-e3656350f7d8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a")
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("fe556693-b069-4e2a-9bd2-fe1d3c268f91"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("5b711f0f-6471-4cd1-be75-f2937c3206eb"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3dc8a5c0-ae73-4170-9e7b-c0b0f0a2cfca"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d9ad0e4-6cf0-4c6b-b445-a90210bfa8a8"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0472965c-60fc-4253-8014-274d038e592e"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87c759c6-136c-4798-9295-b0169a855ee1"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f70aa8a9-7f09-4abe-91b8-c3e978f4362a"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Out,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("66cd5dd2-0542-4627-aab3-ddaf89e3948f"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("efd90ccc-95fa-4f02-9423-c033c8c2d301"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
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
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("bb30c075-eefd-4293-953a-e7b5c8573465"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f0d929be-54bb-4729-8f99-62e33b75ab01"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38907c0a-b8b0-4d11-a591-15da0fe09428"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dab63c0c-9c7f-4b8e-ba8a-feb6b81e78a1"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("76efa7d6-f78d-46f9-abd4-76f2b001d455"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("b46cf18b-36dc-45f3-8038-c84f6689571e"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a3442d97-35bd-480d-948c-9138fa5b6d0d"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0443cfd-7502-4a81-b9cb-4a0bfac2aaab"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bedb7dde-f390-46f5-a7fe-41023598db22"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
			var queueItemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8a117d74-72b0-4316-9299-a894df5f2d40"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"QueueItem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			queueItemParameter.SourceValue = new ProcessSchemaParameterValue(queueItemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(queueItemParameter);
			var applicationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6da33aa0-3665-4a71-890f-794704556f23"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"Application",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			applicationParameter.SourceValue = new ProcessSchemaParameterValue(applicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(applicationParameter);
			var finApplicationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("900bf29b-d939-455f-8b89-259f75503edf"),
				ContainerUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				Name = @"FinApplication",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			finApplicationParameter.SourceValue = new ProcessSchemaParameterValue(finApplicationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(finApplicationParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaPerceptionAnalysis = CreatePerceptionAnalysisLaneSet();
			LaneSets.Add(schemaPerceptionAnalysis);
			ProcessSchemaLane schemaSalesManager = CreateSalesManagerLane();
			schemaPerceptionAnalysis.Lanes.Add(schemaSalesManager);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaUserTask readopportunitydata = CreateReadOpportunityDataUserTask();
			FlowElements.Add(readopportunitydata);
			ProcessSchemaUserTask userquestionusertask1 = CreateUserQuestionUserTask1UserTask();
			FlowElements.Add(userquestionusertask1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignalevent1 = CreateIntermediateCatchSignalEvent1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignalevent1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaUserTask activityusertask1 = CreateActivityUserTask1UserTask();
			FlowElements.Add(activityusertask1);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask activityusertask2 = CreateActivityUserTask2UserTask();
			FlowElements.Add(activityusertask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("73926172-4fa9-4fa9-90e4-c91aafa609f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9540a38b-8c8e-4525-8d92-a53523b91ea2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b7c27984-ad8a-4bc3-a529-008fc7118c87"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(274, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("cc0a85af-816b-4649-bed7-cfe426c255c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(422, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"), new Collection<Guid>() {
						new Guid("ba47c6c2-59c7-48a7-9cb3-82748390f533"),
					}},
				}
			};
			schemaFlow.PolylinePointPositions.Add(new Point(371, 70));
			schemaFlow.PolylinePointPositions.Add(new Point(812, 70));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("a553590e-3a93-49d3-811c-fb424ebfdbaf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(336, 179),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("a633210b-92a5-44b7-ad20-587d9a384df2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(112, 134),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9540a38b-8c8e-4525-8d92-a53523b91ea2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c85ba0dd-4fb6-4533-8e65-3b621ddaa77d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("60f82561-6879-421b-9604-fcd5efaa2d8d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(184, 220),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c85ba0dd-4fb6-4533-8e65-3b621ddaa77d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b79f2937-3593-4f7a-9f21-3763902fb453"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("5fc513b6-ebc0-432a-b6bb-46fc57bacf21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(567, 253),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"), new Collection<Guid>() {
						new Guid("dbbf0e10-f46b-1410-6598-00155d043204"),
						new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("fbb76b0f-ca2a-4108-a20b-7b4bab5db151"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(312, 336),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b79f2937-3593-4f7a-9f21-3763902fb453"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5fa358d6-acc2-45ff-ac54-b3a5c4570643"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("0d6ca324-4fcc-4870-b805-0c10ab7fea05"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(600, 142),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("150bc815-4bbd-4f49-b40a-eef6dfcf5f49"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				CurveCenterPosition = new Point(888, 141),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b5b8332-3dd3-40cc-8ed9-44da361b5724"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"), new Collection<Guid>() {
						new Guid("dbbf0e10-f46b-1410-6598-00155d043204"),
						new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreatePerceptionAnalysisLaneSet() {
			ProcessSchemaLaneSet schemaPerceptionAnalysis = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1fba2fe7-7801-467b-a302-949b9b17567d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"PerceptionAnalysis",
				Position = new Point(5, 5),
				Size = new Size(996, 430),
				UseBackgroundMode = false
			};
			return schemaPerceptionAnalysis;
		}

		protected virtual ProcessSchemaLane CreateSalesManagerLane() {
			ProcessSchemaLane schemaSalesManager = new ProcessSchemaLane(this) {
				UId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("1fba2fe7-7801-467b-a302-949b9b17567d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"SalesManager",
				Position = new Point(29, 0),
				Size = new Size(967, 430),
				UseBackgroundMode = false
			};
			return schemaSalesManager;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("9540a38b-8c8e-4525-8d92-a53523b91ea2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"Start1",
				Position = new Point(78, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadOpportunityDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"ReadOpportunityData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(148, 107),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadOpportunityDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserQuestionUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"UserQuestionUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(302, 107),
				SchemaUId = new Guid("fe10dd95-2d61-4aa1-8111-9fb23b032603"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeUserQuestionUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("0b5b8332-3dd3-40cc-8ed9-44da361b5724"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"Terminate1",
				Position = new Point(925, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignalEvent1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("c85ba0dd-4fb6-4533-8e65-3b621ddaa77d"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"IntermediateCatchSignalEvent1",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(78, 261),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("797ac352-4979-4d28-906f-82feb6dbc9dc");
			InitializeIntermediateCatchSignalEvent1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("b79f2937-3593-4f7a-9f21-3763902fb453"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"FormulaTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(148, 247),
				ResultParameterMetaPath = @"ff6f79f1-b910-436f-9c38-487012f07520",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,41,42,77,5,0,141,76,252,253,4,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateActivityUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"ActivityUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(596, 107),
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeActivityUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("5fa358d6-acc2-45ff-ac54-b3a5c4570643"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"Terminate2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(323, 261),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"ReadDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(442, 107),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateActivityUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("04bfd708-c72d-4af8-9316-6ddc051e9e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("ff492f2e-7ec3-4894-8115-3064a4dbdf58"),
				CreatedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				ModifiedInSchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"),
				Name = @"ActivityUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(743, 107),
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeActivityUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new OppManagerPerceptionAnalysis(userConnection);
		}

		public override object Clone() {
			return new OppManagerPerceptionAnalysisSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a"));
		}

		#endregion

	}

	#endregion

	#region Class: OppManagerPerceptionAnalysis

	/// <exclude/>
	public class OppManagerPerceptionAnalysis : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessSalesManager

		/// <exclude/>
		public class ProcessSalesManager : ProcessLane
		{

			public ProcessSalesManager(UserConnection userConnection, OppManagerPerceptionAnalysis process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadOpportunityDataFlowElement

		/// <exclude/>
		public class ReadOpportunityDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadOpportunityDataFlowElement(UserConnection userConnection, OppManagerPerceptionAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadOpportunityData";
				IsLogging = true;
				SchemaElementUId = new Guid("a0d5ba33-923f-4031-b6c0-51adad28f67d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,75,242,135,156,227,178,45,123,73,3,77,75,33,89,194,179,244,148,21,248,43,178,68,179,152,253,239,149,215,217,20,114,40,133,158,2,58,72,239,105,230,205,12,210,252,96,167,207,182,245,232,106,3,237,132,73,216,233,154,52,146,151,192,0,40,67,149,81,145,85,5,149,121,153,81,201,192,164,186,200,141,74,75,146,244,208,97,77,86,244,86,91,79,18,235,177,155,234,187,249,15,169,119,1,147,7,115,62,124,83,7,236,224,251,50,0,80,20,166,169,74,170,82,166,168,0,172,40,104,158,81,144,140,43,173,165,20,202,144,85,11,26,193,121,218,112,154,69,0,21,58,151,180,145,70,71,65,133,144,138,51,110,26,70,146,22,141,223,62,143,14,167,201,14,125,61,227,235,254,246,56,70,149,235,236,205,208,134,174,39,73,135,30,110,192,31,22,33,41,138,92,1,85,66,230,84,24,44,41,112,169,41,135,166,100,101,133,89,145,69,167,10,70,191,208,146,157,38,137,6,15,63,160,13,120,102,158,109,212,200,120,154,85,121,17,177,25,143,118,56,75,105,85,68,119,70,23,70,34,47,164,108,244,37,175,47,193,198,189,157,174,67,135,206,170,151,216,49,230,55,184,122,86,67,239,221,208,46,212,215,231,235,183,248,236,215,112,95,90,63,87,67,62,214,23,16,57,37,97,194,77,107,177,247,219,94,13,218,246,143,43,231,233,20,33,221,8,206,78,151,20,182,79,1,90,146,56,251,120,248,107,90,155,48,249,161,123,71,86,147,104,51,114,196,71,118,150,187,188,65,109,167,177,133,227,249,92,147,143,79,97,240,87,155,224,92,4,127,24,198,113,112,62,244,214,31,215,6,121,67,80,147,123,162,83,86,54,44,205,168,105,116,73,69,85,73,90,137,140,211,104,50,47,120,158,154,82,87,247,36,138,250,255,81,119,187,233,235,175,254,242,67,86,79,251,79,177,250,166,112,115,65,214,243,191,168,59,237,23,125,251,83,92,191,1,165,164,59,204,232,3,0,0 })));
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

		#region Class: UserQuestionUserTask1FlowElement

		/// <exclude/>
		public class UserQuestionUserTask1FlowElement : UserQuestionUserTask
		{

			#region Constructors: Public

			public UserQuestionUserTask1FlowElement(UserConnection userConnection, OppManagerPerceptionAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserQuestionUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadOpportunityData.ResultEntity.IsColumnValueLoaded(process.ReadOpportunityData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadOpportunityData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_account = () => (Guid)(((process.ReadOpportunityData.ResultEntity.IsColumnValueLoaded(process.ReadOpportunityData.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadOpportunityData.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)((process.MainContact));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _branchingDecisions;
			public override LocalizableString BranchingDecisions {
				get {
					if (_branchingDecisions == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,77,75,3,49,16,134,255,138,4,143,155,146,38,187,249,232,181,69,40,20,233,161,246,34,30,38,179,19,92,220,186,37,73,5,91,246,191,155,173,23,139,224,193,219,192,51,207,59,243,94,216,125,254,60,18,91,176,29,197,8,105,8,121,182,28,34,205,182,113,64,74,105,182,25,16,250,238,12,190,167,45,68,56,80,166,184,135,254,68,105,211,165,92,221,221,106,172,98,247,31,87,202,22,207,23,182,206,116,120,90,183,37,29,155,134,90,161,37,215,13,182,188,118,214,115,23,130,224,42,88,35,148,49,48,199,166,200,211,238,133,93,19,138,36,131,244,18,189,227,65,74,95,36,173,185,13,174,76,198,215,202,88,161,188,48,108,172,216,99,121,235,167,183,34,236,82,55,188,139,9,46,225,152,203,60,241,46,109,240,188,255,94,202,241,68,133,174,40,44,95,9,223,232,230,240,174,64,54,142,213,77,131,218,144,114,164,184,111,65,151,23,164,227,206,65,203,173,152,123,109,101,107,60,169,95,13,60,212,6,53,74,222,56,52,188,182,96,184,67,175,184,149,166,182,202,137,208,40,245,87,131,249,127,27,60,64,159,166,10,47,227,23,58,215,13,191,226,1,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "bcb1d0f8c1a9475481812f8570571c3a",
							"BaseElements.UserQuestionUserTask1.Parameters.BranchingDecisions.Value");
						dataList.LoadLocalizableValues();
						_branchingDecisions = dataList.GetSerializedItems();
						};
					return _branchingDecisions;
				}
				set {
					_branchingDecisions = value;
				}
			}

			private int _decisionMode = 0;
			public override int DecisionMode {
				get {
					return _decisionMode;
				}
				set {
					_decisionMode = value;
				}
			}

			private bool _isDecisionRequired = true;
			public override bool IsDecisionRequired {
				get {
					return _isDecisionRequired;
				}
				set {
					_isDecisionRequired = value;
				}
			}

			private LocalizableString _question;
			public override LocalizableString Question {
				get {
					return _question ?? (_question = GetLocalizableString("bcb1d0f8c1a9475481812f8570571c3a",
						 "BaseElements.UserQuestionUserTask1.Parameters.Question.Value"));
				}
				set {
					_question = value;
				}
			}

			private LocalizableString _windowCaption;
			public override LocalizableString WindowCaption {
				get {
					return _windowCaption ?? (_windowCaption = GetLocalizableString("bcb1d0f8c1a9475481812f8570571c3a",
						 "BaseElements.UserQuestionUserTask1.Parameters.WindowCaption.Value"));
				}
				set {
					_windowCaption = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("bcb1d0f8c1a9475481812f8570571c3a",
						 "BaseElements.UserQuestionUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _opportunity;
			public override Guid Opportunity {
				get {
					return (_opportunity ?? (_opportunity = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunity = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: IntermediateCatchSignalEvent1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignalEvent1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignalEvent1FlowElement(UserConnection userConnection, OppManagerPerceptionAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignalEvent1";
				IsLogging = false;
				SchemaElementUId = new Guid("c85ba0dd-4fb6-4533-8e65-3b621ddaa77d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""797ac352-4979-4d28-906f-82feb6dbc9dc""]}";
				EntityFilters = @"{_isFilter:false,uId:""94a72b9e-d505-4587-803b-619d9ea8a6a9"",name:""FilterEdit"",items:[]}";
				_recordId = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ActivityUserTask1FlowElement

		/// <exclude/>
		public class ActivityUserTask1FlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTask1FlowElement(UserConnection userConnection, OppManagerPerceptionAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("SalesDirector").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("SalesDirectorId") : Guid.Empty)));
				_account = () => (Guid)(((process.ReadOpportunityData.ResultEntity.IsColumnValueLoaded(process.ReadOpportunityData.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadOpportunityData.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)((process.MainContact));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("bcb1d0f8c1a9475481812f8570571c3a",
						 "BaseElements.ActivityUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _activityCategory = new Guid("42c74c49-58e6-df11-971b-001d60e938c6");
			public override Guid ActivityCategory {
				get {
					return _activityCategory;
				}
				set {
					_activityCategory = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			private int _duration = 60;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _remindBefore = 5;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _opportunity;
			public override Guid Opportunity {
				get {
					return (_opportunity ?? (_opportunity = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunity = () => { return value; };
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"dbbf0e10-f46b-1410-6598-00155d043204\",\"632afdd2-f616-4ea6-87d2-8ed38eed8aff\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OppManagerPerceptionAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("6bca4f14-5d1b-458e-bf57-0ec26c9a89ac");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,203,106,220,48,20,134,95,101,208,162,43,107,144,172,155,237,46,167,147,146,77,26,218,180,20,146,16,116,57,74,4,190,197,150,219,4,51,239,94,121,156,105,33,139,146,85,161,96,132,46,254,255,115,206,167,163,249,46,140,103,161,142,48,84,94,215,35,100,211,185,171,16,128,43,180,102,20,187,146,27,204,25,23,216,40,78,176,228,74,89,197,153,40,37,67,89,171,27,168,208,170,222,187,16,81,22,34,52,99,117,61,255,49,141,195,4,217,157,63,46,190,216,7,104,244,215,37,128,112,5,23,210,112,76,5,16,204,29,164,0,36,13,218,27,74,188,84,165,176,4,173,185,88,198,57,179,158,98,74,169,199,73,229,112,41,40,197,134,90,171,168,23,38,55,5,202,106,240,113,255,212,15,48,142,161,107,171,25,126,207,175,158,251,148,229,26,123,215,213,83,211,162,172,129,168,47,117,124,168,144,6,2,92,88,141,45,47,5,230,30,20,214,172,116,152,105,163,114,85,0,149,84,161,204,234,62,46,182,232,220,161,204,233,168,191,233,122,130,163,243,28,82,142,57,35,180,16,50,105,41,179,137,87,78,112,33,11,133,189,147,190,4,38,203,210,184,19,175,143,83,72,243,48,94,76,13,12,193,190,96,135,196,175,27,170,217,118,109,28,186,122,177,190,56,254,126,5,79,113,133,251,114,244,125,45,40,166,253,69,132,14,217,52,194,174,14,208,198,125,107,59,23,218,251,213,243,112,72,146,166,215,67,24,79,20,246,143,147,174,81,54,132,251,135,191,210,218,77,99,236,154,255,168,212,44,149,153,60,82,147,29,211,93,122,208,133,177,175,245,243,113,93,161,119,143,83,23,223,127,6,237,54,93,223,119,67,156,218,16,159,55,75,129,219,179,48,140,113,179,244,238,166,243,155,4,98,170,99,178,222,216,174,174,193,46,23,191,253,16,126,132,5,207,106,131,94,133,171,208,13,210,196,9,163,25,195,101,206,82,155,146,244,120,140,180,4,11,170,157,118,121,145,154,218,109,141,33,69,234,55,138,149,242,12,115,235,0,23,94,112,156,142,5,35,101,33,75,150,111,169,240,196,147,146,98,144,50,57,229,206,224,130,40,131,61,183,185,118,146,49,101,228,13,74,48,254,117,137,215,231,227,167,159,237,233,29,175,228,111,183,105,247,213,198,190,134,38,93,81,53,191,133,201,33,9,46,79,161,170,249,45,132,22,201,190,141,169,184,245,61,87,243,91,144,29,110,23,104,183,135,244,253,2,33,23,41,100,245,4,0,0 })));
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
								new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"));
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

		#region Class: ActivityUserTask2FlowElement

		/// <exclude/>
		public class ActivityUserTask2FlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTask2FlowElement(UserConnection userConnection, OppManagerPerceptionAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadOpportunityData.ResultEntity.IsColumnValueLoaded(process.ReadOpportunityData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadOpportunityData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_account = () => (Guid)(((process.ReadOpportunityData.ResultEntity.IsColumnValueLoaded(process.ReadOpportunityData.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadOpportunityData.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)((process.MainContact));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("bcb1d0f8c1a9475481812f8570571c3a",
						 "BaseElements.ActivityUserTask2.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _activityCategory = new Guid("f51c4643-58e6-df11-971b-001d60e938c6");
			public override Guid ActivityCategory {
				get {
					return _activityCategory;
				}
				set {
					_activityCategory = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			private int _duration = 60;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _remindBefore = 5;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _opportunity;
			public override Guid Opportunity {
				get {
					return (_opportunity ?? (_opportunity = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunity = () => { return value; };
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"dbbf0e10-f46b-1410-6598-00155d043204\",\"632afdd2-f616-4ea6-87d2-8ed38eed8aff\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		public OppManagerPerceptionAnalysis(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OppManagerPerceptionAnalysis";
			SchemaUId = new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bcb1d0f8-c1a9-4754-8181-2f8570571c3a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: OppManagerPerceptionAnalysis, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: OppManagerPerceptionAnalysis, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public virtual bool OpportunityStageChanged {
			get;
			set;
		}

		public virtual Guid MainContact {
			get;
			set;
		}

		private ProcessSalesManager _salesManager;
		public ProcessSalesManager SalesManager {
			get {
				return _salesManager ?? ((_salesManager) = new ProcessSalesManager(UserConnection, this));
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
					SchemaElementUId = new Guid("9540a38b-8c8e-4525-8d92-a53523b91ea2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadOpportunityDataFlowElement _readOpportunityData;
		public ReadOpportunityDataFlowElement ReadOpportunityData {
			get {
				return _readOpportunityData ?? (_readOpportunityData = new ReadOpportunityDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private UserQuestionUserTask1FlowElement _userQuestionUserTask1;
		public UserQuestionUserTask1FlowElement UserQuestionUserTask1 {
			get {
				return _userQuestionUserTask1 ?? (_userQuestionUserTask1 = new UserQuestionUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("0b5b8332-3dd3-40cc-8ed9-44da361b5724"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private IntermediateCatchSignalEvent1FlowElement _intermediateCatchSignalEvent1;
		public IntermediateCatchSignalEvent1FlowElement IntermediateCatchSignalEvent1 {
			get {
				return _intermediateCatchSignalEvent1 ?? ((_intermediateCatchSignalEvent1) = new IntermediateCatchSignalEvent1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("b79f2937-3593-4f7a-9f21-3763902fb453"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ActivityUserTask1FlowElement _activityUserTask1;
		public ActivityUserTask1FlowElement ActivityUserTask1 {
			get {
				return _activityUserTask1 ?? (_activityUserTask1 = new ActivityUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminate2;
		public ProcessTerminateEvent Terminate2 {
			get {
				return _terminate2 ?? (_terminate2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate2",
					SchemaElementUId = new Guid("5fa358d6-acc2-45ff-ac54-b3a5c4570643"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ActivityUserTask2FlowElement _activityUserTask2;
		public ActivityUserTask2FlowElement ActivityUserTask2 {
			get {
				return _activityUserTask2 ?? (_activityUserTask2 = new ActivityUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("cc0a85af-816b-4649-bed7-cfe426c255c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2"), new Collection<Guid>() {
							new Guid("ba47c6c2-59c7-48a7-9cb3-82748390f533"),
						}},
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
					SchemaElementUId = new Guid("5fc513b6-ebc0-432a-b6bb-46fc57bacf21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("eea30567-7162-4e0d-aa1d-48ac2f04f64a"), new Collection<Guid>() {
							new Guid("dbbf0e10-f46b-1410-6598-00155d043204"),
							new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("150bc815-4bbd-4f49-b40a-eef6dfcf5f49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("0e8cb779-36dd-4baa-b112-2baabb68b571"), new Collection<Guid>() {
							new Guid("dbbf0e10-f46b-1410-6598-00155d043204"),
							new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[ReadOpportunityData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadOpportunityData };
			FlowElements[UserQuestionUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionUserTask1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[IntermediateCatchSignalEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignalEvent1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ActivityUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTask1 };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ActivityUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadOpportunityData", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignalEvent1", e.Context.SenderName));
						break;
					case "ReadOpportunityData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserQuestionUserTask1", e.Context.SenderName));
						break;
					case "UserQuestionUserTask1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "IntermediateCatchSignalEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "ActivityUserTask1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask2", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ActivityUserTask1");
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask1", e.Context.SenderName));
						break;
					case "ActivityUserTask2":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ActivityUserTask2");
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalFlow1.ProcessActivitiesSelectedResults[new Guid("1ea05e75-3ee4-4839-b778-9a746dab4ce2")])) != 0;
			Log.InfoFormat(ConditionalExpressionLogMessage, "UserQuestionUserTask1", "ConditionalFlow1", "System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalFlow1.ProcessActivitiesSelectedResults[new Guid(\"1ea05e75-3ee4-4839-b778-9a746dab4ce2\")])) != 0", result);
			Log.Info($"UserQuestionUserTask1.ResultDecisions: {UserQuestionUserTask1.ResultDecisions}");
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = ActivityUserTask1.ActivityResult == new Guid("dbbf0e10-f46b-1410-6598-00155d043204") || ActivityUserTask1.ActivityResult == new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTask1", "ConditionalFlow2", "ActivityUserTask1.ActivityResult == new Guid(\"dbbf0e10-f46b-1410-6598-00155d043204\") || ActivityUserTask1.ActivityResult == new Guid(\"632afdd2-f616-4ea6-87d2-8ed38eed8aff\")", result);
			Log.Info($"ActivityUserTask1.ActivityResult: {ActivityUserTask1.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = ActivityUserTask2.ActivityResult == new Guid("dbbf0e10-f46b-1410-6598-00155d043204") || ActivityUserTask2.ActivityResult == new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTask2", "ConditionalFlow4", "ActivityUserTask2.ActivityResult == new Guid(\"dbbf0e10-f46b-1410-6598-00155d043204\") || ActivityUserTask2.ActivityResult == new Guid(\"632afdd2-f616-4ea6-87d2-8ed38eed8aff\")", result);
			Log.Info($"ActivityUserTask2.ActivityResult: {ActivityUserTask2.ActivityResult}");
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("MainContact")) {
				writer.WriteValue("MainContact", MainContact, Guid.Empty);
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
			MetaPathParameterValues.Add("d027b201-fbd7-4889-8413-e3656350f7d8", () => CurrentOpportunity);
			MetaPathParameterValues.Add("ff6f79f1-b910-436f-9c38-487012f07520", () => OpportunityStageChanged);
			MetaPathParameterValues.Add("f0e8319b-9385-4f8f-a4bf-74799cd7173a", () => MainContact);
			MetaPathParameterValues.Add("0aef70fd-d49f-49e9-9592-dc554a56cb2a", () => ReadOpportunityData.DataSourceFilters);
			MetaPathParameterValues.Add("98d24394-7aa3-4639-bf4a-afdbc28c23d0", () => ReadOpportunityData.ResultType);
			MetaPathParameterValues.Add("4b5ed227-1d59-4cad-b76a-fb250899afba", () => ReadOpportunityData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("c69ff36d-f445-4822-bdf3-4ef53fc5fbbc", () => ReadOpportunityData.NumberOfRecords);
			MetaPathParameterValues.Add("b86f45ca-1532-4835-a794-01e949e70302", () => ReadOpportunityData.FunctionType);
			MetaPathParameterValues.Add("6c9261b3-581b-4c7b-819a-3bc7c38dcac3", () => ReadOpportunityData.AggregationColumnName);
			MetaPathParameterValues.Add("2fb4cbc9-3b9f-44e4-a1d9-d848464d35ec", () => ReadOpportunityData.OrderInfo);
			MetaPathParameterValues.Add("bb080e41-77f3-4cde-8f54-28f530986932", () => ReadOpportunityData.ResultEntity);
			MetaPathParameterValues.Add("5561b4ed-a190-4d26-86ab-59ce13b43b28", () => ReadOpportunityData.ResultCount);
			MetaPathParameterValues.Add("9e050f13-ceab-4083-8446-c5ebe3cf5bb2", () => ReadOpportunityData.ResultIntegerFunction);
			MetaPathParameterValues.Add("b8406a60-245b-4655-b3cb-805fec26409d", () => ReadOpportunityData.ResultFloatFunction);
			MetaPathParameterValues.Add("7a286138-0dc8-47cd-aa12-a5e4885cb5f7", () => ReadOpportunityData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0637f70e-054a-448b-9dc7-eca6bb4d33b4", () => ReadOpportunityData.ResultRowsCount);
			MetaPathParameterValues.Add("ca96d206-d1af-4dc4-b7b1-76406a1734a1", () => ReadOpportunityData.CanReadUncommitedData);
			MetaPathParameterValues.Add("f3dde4b3-fab9-432e-aa72-0b434eb5bf90", () => ReadOpportunityData.ResultEntityCollection);
			MetaPathParameterValues.Add("5cadac1a-8fa6-44ba-9818-6cf47a157a26", () => ReadOpportunityData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("8e98f559-9433-4f6f-bfdd-da8018abfc21", () => ReadOpportunityData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("e645f6b3-94d5-4fcb-b03d-327db7f9fea3", () => ReadOpportunityData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f90f341d-a43d-43bc-905d-ab5365aad618", () => ReadOpportunityData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("d5f5d3ae-3eba-476f-8afe-7cae29c1de03", () => UserQuestionUserTask1.BranchingDecisions);
			MetaPathParameterValues.Add("26fb2285-bd22-4bfa-899e-b86587547eb6", () => UserQuestionUserTask1.ResultDecisions);
			MetaPathParameterValues.Add("7981bd1a-6e1f-4618-95b2-b2e01cd1a7ff", () => UserQuestionUserTask1.DecisionMode);
			MetaPathParameterValues.Add("8421eda1-c015-47d1-870d-db890151040b", () => UserQuestionUserTask1.IsDecisionRequired);
			MetaPathParameterValues.Add("875ec9e9-dd3b-4094-8404-8a34db3ed419", () => UserQuestionUserTask1.Question);
			MetaPathParameterValues.Add("039c67ed-06da-4917-829a-f6aac39e6957", () => UserQuestionUserTask1.WindowCaption);
			MetaPathParameterValues.Add("adf0b461-8884-454d-8f38-9df0346f9773", () => UserQuestionUserTask1.Recommendation);
			MetaPathParameterValues.Add("5487762e-5d14-4fc1-8ebf-cd9d2610b431", () => UserQuestionUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("4b999032-20f7-417c-af5d-b127483cc612", () => UserQuestionUserTask1.OwnerId);
			MetaPathParameterValues.Add("ea22e001-dcbe-4bc4-9a02-2c1b41f9af29", () => UserQuestionUserTask1.Duration);
			MetaPathParameterValues.Add("7b874cd5-90b5-48d0-be34-b1fb34197a54", () => UserQuestionUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("b15e0992-0fc2-4dfe-a4f9-fa3fcd90e0f8", () => UserQuestionUserTask1.StartIn);
			MetaPathParameterValues.Add("79dd7651-d12b-4acf-8138-3259b2335266", () => UserQuestionUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("961107c6-ccdc-4170-bcb4-629e74de93b4", () => UserQuestionUserTask1.RemindBefore);
			MetaPathParameterValues.Add("945a533b-c1ad-4bcd-92b8-0d63bcd8b3cd", () => UserQuestionUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("38b1176b-b184-4d13-85a1-e0dbc5518fd7", () => UserQuestionUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("65e35847-2142-45e3-ab99-3b423fd43b14", () => UserQuestionUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("104c7104-92e9-4712-aef0-0961190b310a", () => UserQuestionUserTask1.Lead);
			MetaPathParameterValues.Add("f17aac24-7ead-45a5-82e0-d1d50d68b92c", () => UserQuestionUserTask1.Account);
			MetaPathParameterValues.Add("e30b2ace-5428-4350-8646-c86fbd585444", () => UserQuestionUserTask1.Contact);
			MetaPathParameterValues.Add("4bf9d5bf-be82-4415-a923-d3ec28b02c80", () => UserQuestionUserTask1.Opportunity);
			MetaPathParameterValues.Add("1af535fd-8887-4455-a919-bd7878e93ebd", () => UserQuestionUserTask1.Invoice);
			MetaPathParameterValues.Add("a1613930-25b4-443a-9990-ebd497dc416d", () => UserQuestionUserTask1.Document);
			MetaPathParameterValues.Add("6084c27f-3d67-4dfa-88ab-14eb3e2d03ee", () => UserQuestionUserTask1.Incident);
			MetaPathParameterValues.Add("77ede53f-6608-4aa1-b205-4508dcc36f3d", () => UserQuestionUserTask1.Case);
			MetaPathParameterValues.Add("46091d70-d4f5-47b0-ae4c-6c9a13b83cae", () => UserQuestionUserTask1.ActivityResult);
			MetaPathParameterValues.Add("cde0a3c8-be8a-47ee-8f6c-da2c9754fe85", () => UserQuestionUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("49a4e1b3-c652-48b7-806c-3dbd7ee553fe", () => UserQuestionUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("c0a34689-fed1-436d-8be6-8b384239cd5b", () => UserQuestionUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("f0dacc10-0333-4a64-9349-953fe7a85056", () => UserQuestionUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("ea49d15a-798f-44dc-946b-2695d954c509", () => UserQuestionUserTask1.Order);
			MetaPathParameterValues.Add("e647fdca-2e8e-42a1-bd7d-aa5bf251bafe", () => UserQuestionUserTask1.Requests);
			MetaPathParameterValues.Add("7aee44c6-a081-4f10-bac5-bb0452bbd3b0", () => UserQuestionUserTask1.Listing);
			MetaPathParameterValues.Add("46c20e90-2010-4928-b8a4-fe4ab0378027", () => UserQuestionUserTask1.Property);
			MetaPathParameterValues.Add("a3f2a145-5dcb-4c2f-b908-54287d2899c5", () => UserQuestionUserTask1.Contract);
			MetaPathParameterValues.Add("143df26b-7ada-46d0-92e5-e54a8a2c7d34", () => UserQuestionUserTask1.Project);
			MetaPathParameterValues.Add("5ec1b134-513c-4a6a-a568-41bfd0fe8824", () => UserQuestionUserTask1.Problem);
			MetaPathParameterValues.Add("fdd5cd49-af63-455e-8f97-c818c27db7e5", () => UserQuestionUserTask1.Change);
			MetaPathParameterValues.Add("b0e20a88-f99c-49c2-8c2c-29c9c259358c", () => UserQuestionUserTask1.Release);
			MetaPathParameterValues.Add("0e58bb00-85b9-4485-ab15-611681bef565", () => IntermediateCatchSignalEvent1.RecordId);
			MetaPathParameterValues.Add("f6d122ec-ed31-4da2-af2b-bc63817e61c0", () => ActivityUserTask1.Recommendation);
			MetaPathParameterValues.Add("4a7ad5c8-3553-4a30-9e8c-6f20c2b4cf26", () => ActivityUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("0f7320c4-65ec-4b5d-b99a-6bdfda10d4d5", () => ActivityUserTask1.OwnerId);
			MetaPathParameterValues.Add("4dd4b7c8-a585-4621-a8e5-2c6193905762", () => ActivityUserTask1.Duration);
			MetaPathParameterValues.Add("ecba22d1-7f1b-4774-a89e-6c9790386be3", () => ActivityUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("798ed239-aa86-40e7-a9d2-21f2cff2055d", () => ActivityUserTask1.StartIn);
			MetaPathParameterValues.Add("4a7cb1fc-3038-4276-9865-f826c33b81f2", () => ActivityUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("6fcf2440-4c47-41dc-b130-c2b28982e192", () => ActivityUserTask1.RemindBefore);
			MetaPathParameterValues.Add("f9be165b-d1d9-4e4b-b480-a93e814c7229", () => ActivityUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("75d77b6a-50ff-4a3d-b6b9-247c84b15572", () => ActivityUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("b2d15a10-3425-4bb4-bd3b-b951bfa787ea", () => ActivityUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("dec1e674-7bff-4be2-ad87-b0ea10536aff", () => ActivityUserTask1.Lead);
			MetaPathParameterValues.Add("3811eae7-1dde-401b-a2df-a8a17263d06b", () => ActivityUserTask1.Account);
			MetaPathParameterValues.Add("5be7e4d7-53b0-403c-9048-957d9a3b15d1", () => ActivityUserTask1.Contact);
			MetaPathParameterValues.Add("ce3f0499-a11f-4777-bdba-2792136dd144", () => ActivityUserTask1.Opportunity);
			MetaPathParameterValues.Add("6d6780cb-c931-4c5d-b52b-fe5c9444d93f", () => ActivityUserTask1.Invoice);
			MetaPathParameterValues.Add("fe45e260-5800-4213-b40c-7a8aea2a3f4b", () => ActivityUserTask1.Document);
			MetaPathParameterValues.Add("45fb95cc-842d-4a68-a5eb-979402a99a4f", () => ActivityUserTask1.Incident);
			MetaPathParameterValues.Add("323513f2-934c-4919-8fde-d89a309fb149", () => ActivityUserTask1.Case);
			MetaPathParameterValues.Add("9b74655c-15c6-4fe2-a89a-e94c705cc7b8", () => ActivityUserTask1.ActivityResult);
			MetaPathParameterValues.Add("b05554ca-f5bf-4d84-9e04-900d8950c40e", () => ActivityUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("e9034b35-4d0a-4813-97c6-81cd3ce8090d", () => ActivityUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("a4c4aae4-38a3-4a5d-b6ee-1017d419f3f8", () => ActivityUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("a09eff2b-cafb-41cc-be73-30c58c379b1e", () => ActivityUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("1c79b3f3-cd4b-418f-883c-e74b16c576ba", () => ActivityUserTask1.Order);
			MetaPathParameterValues.Add("f42a2702-fc89-4bac-9232-11bdf7f72eff", () => ActivityUserTask1.Requests);
			MetaPathParameterValues.Add("8778df1b-c517-462c-bc52-8393851a71b2", () => ActivityUserTask1.Listing);
			MetaPathParameterValues.Add("9df4f5ee-edbb-47b2-9e3a-bab440f8b95b", () => ActivityUserTask1.Property);
			MetaPathParameterValues.Add("5cc558c6-e331-4f28-a8f6-1d9bb233bb74", () => ActivityUserTask1.Contract);
			MetaPathParameterValues.Add("6e358665-5347-4829-a3de-00fb17d6ce97", () => ActivityUserTask1.Project);
			MetaPathParameterValues.Add("2218d180-e503-40f9-b4bb-8debb4a49f8e", () => ActivityUserTask1.Problem);
			MetaPathParameterValues.Add("053bd064-4bd8-4a5a-8abe-64bc1f10676a", () => ActivityUserTask1.Change);
			MetaPathParameterValues.Add("1ccd02a9-4fbc-4785-9912-b95942d3c5da", () => ActivityUserTask1.Release);
			MetaPathParameterValues.Add("272aeb9e-8c7d-4be2-be62-6a8b547d9fb1", () => ActivityUserTask1.QueueItem);
			MetaPathParameterValues.Add("45c9f17d-3937-4111-8ec3-76a85af38587", () => ActivityUserTask1.Application);
			MetaPathParameterValues.Add("367e0f84-4fd7-4897-a879-47c7a48900ba", () => ActivityUserTask1.FinApplication);
			MetaPathParameterValues.Add("b1f60a31-863b-480c-8bc3-aa61b3fb7a1a", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("2fe9045d-6440-4eb3-ac16-7fd16fdb3c5d", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("a190c1e8-f1a5-409c-b95a-f15ddea09916", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("80617af5-3a47-4462-b09d-b91c8cf423f2", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("9cc314aa-e2fc-4b79-bfe7-f771e1a3b5ca", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("b43ffc26-c36e-4c5a-b5ea-81958624b05b", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("8b419064-13ee-4fed-9d2e-e10f90b4997a", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("2493dc71-1d44-484f-90c7-87266ec877f3", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("bb1f890a-8160-4bc0-bf9f-ad9ce0e9ba82", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("3717acd4-7111-4122-bc21-1aa485a407f6", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("88d3d801-11fc-4791-a92a-b5b26e1f818e", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("ff3548b2-c85a-4779-bd53-9be5414d281f", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2c81b463-7773-4aba-9151-5c328ed14a9f", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("d70b4471-679e-4831-ab61-882b32617add", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("4f236a81-793b-457d-af14-eb430c15709b", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("b2c21bd6-b96e-4ed8-80fa-cb41d20e1f71", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5a7c8b5a-a762-4033-9fb8-c142ad321e08", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("bb406099-fe3c-410d-aab9-d4025a822060", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("79f4f5be-b15d-48db-92dd-a805b575a4be", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("8ee5f381-95c2-4025-af01-25db6c3e5c45", () => ActivityUserTask2.Recommendation);
			MetaPathParameterValues.Add("bb72bde9-74fb-4bfc-be67-c6b1f314d2f4", () => ActivityUserTask2.ActivityCategory);
			MetaPathParameterValues.Add("38ba2f38-a350-4595-966b-724236e775e9", () => ActivityUserTask2.OwnerId);
			MetaPathParameterValues.Add("de37bc76-4310-46f9-9cdc-468af57e60d5", () => ActivityUserTask2.Duration);
			MetaPathParameterValues.Add("5961b815-4117-4e48-8cd6-ca632bf2581a", () => ActivityUserTask2.DurationPeriod);
			MetaPathParameterValues.Add("bc5c39a8-b962-49b8-94f3-bf9b148b60ac", () => ActivityUserTask2.StartIn);
			MetaPathParameterValues.Add("c02c9f22-9855-4be3-9b7f-f8cc0a479932", () => ActivityUserTask2.StartInPeriod);
			MetaPathParameterValues.Add("bd75e7df-6e74-495d-a1d5-9bd65d4df2eb", () => ActivityUserTask2.RemindBefore);
			MetaPathParameterValues.Add("57d1cc0f-bd95-4535-ba84-55b3bd705701", () => ActivityUserTask2.RemindBeforePeriod);
			MetaPathParameterValues.Add("ca4fafea-24a3-4413-a66c-7b94505c990e", () => ActivityUserTask2.ShowInScheduler);
			MetaPathParameterValues.Add("b153d9e9-920c-47ee-92f5-ad7e7ef13e9c", () => ActivityUserTask2.ShowExecutionPage);
			MetaPathParameterValues.Add("2f46f59b-3247-41cc-ad06-0849525cb94b", () => ActivityUserTask2.Lead);
			MetaPathParameterValues.Add("67d02137-5faa-4273-a8b9-655956f3d4fc", () => ActivityUserTask2.Account);
			MetaPathParameterValues.Add("72659f14-5f26-43bb-a73c-c2e4e118d9b8", () => ActivityUserTask2.Contact);
			MetaPathParameterValues.Add("a4925509-b538-4a41-ab96-bcb7da256540", () => ActivityUserTask2.Opportunity);
			MetaPathParameterValues.Add("fe556693-b069-4e2a-9bd2-fe1d3c268f91", () => ActivityUserTask2.Invoice);
			MetaPathParameterValues.Add("5b711f0f-6471-4cd1-be75-f2937c3206eb", () => ActivityUserTask2.Document);
			MetaPathParameterValues.Add("3dc8a5c0-ae73-4170-9e7b-c0b0f0a2cfca", () => ActivityUserTask2.Incident);
			MetaPathParameterValues.Add("5d9ad0e4-6cf0-4c6b-b445-a90210bfa8a8", () => ActivityUserTask2.Case);
			MetaPathParameterValues.Add("0472965c-60fc-4253-8014-274d038e592e", () => ActivityUserTask2.ActivityResult);
			MetaPathParameterValues.Add("87c759c6-136c-4798-9295-b0169a855ee1", () => ActivityUserTask2.CurrentActivityId);
			MetaPathParameterValues.Add("f70aa8a9-7f09-4abe-91b8-c3e978f4362a", () => ActivityUserTask2.IsActivityCompleted);
			MetaPathParameterValues.Add("66cd5dd2-0542-4627-aab3-ddaf89e3948f", () => ActivityUserTask2.ExecutionContext);
			MetaPathParameterValues.Add("efd90ccc-95fa-4f02-9423-c033c8c2d301", () => ActivityUserTask2.InformationOnStep);
			MetaPathParameterValues.Add("bb30c075-eefd-4293-953a-e7b5c8573465", () => ActivityUserTask2.Order);
			MetaPathParameterValues.Add("f0d929be-54bb-4729-8f99-62e33b75ab01", () => ActivityUserTask2.Requests);
			MetaPathParameterValues.Add("38907c0a-b8b0-4d11-a591-15da0fe09428", () => ActivityUserTask2.Listing);
			MetaPathParameterValues.Add("dab63c0c-9c7f-4b8e-ba8a-feb6b81e78a1", () => ActivityUserTask2.Property);
			MetaPathParameterValues.Add("76efa7d6-f78d-46f9-abd4-76f2b001d455", () => ActivityUserTask2.Contract);
			MetaPathParameterValues.Add("b46cf18b-36dc-45f3-8038-c84f6689571e", () => ActivityUserTask2.Project);
			MetaPathParameterValues.Add("a3442d97-35bd-480d-948c-9138fa5b6d0d", () => ActivityUserTask2.Problem);
			MetaPathParameterValues.Add("e0443cfd-7502-4a81-b9cb-4a0bfac2aaab", () => ActivityUserTask2.Change);
			MetaPathParameterValues.Add("bedb7dde-f390-46f5-a7fe-41023598db22", () => ActivityUserTask2.Release);
			MetaPathParameterValues.Add("8a117d74-72b0-4316-9299-a894df5f2d40", () => ActivityUserTask2.QueueItem);
			MetaPathParameterValues.Add("6da33aa0-3665-4a71-890f-794704556f23", () => ActivityUserTask2.Application);
			MetaPathParameterValues.Add("900bf29b-d939-455f-8b89-259f75503edf", () => ActivityUserTask2.FinApplication);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "MainContact":
					if (!hasValueToRead) break;
					MainContact = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localOpportunityStageChanged = true;
			OpportunityStageChanged = (System.Boolean)localOpportunityStageChanged;
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
			var cloneItem = (OppManagerPerceptionAnalysis)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

