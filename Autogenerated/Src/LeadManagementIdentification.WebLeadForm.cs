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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: LeadManagementIdentificationSchema

	/// <exclude/>
	public class LeadManagementIdentificationSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementIdentificationSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementIdentificationSchema(LeadManagementIdentificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementIdentification";
			UId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = false;
			Tag = @"LeadManagementIdentification";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,193,74,195,64,16,61,55,208,127,24,123,74,160,236,15,104,133,16,212,22,60,168,88,60,136,135,77,51,41,11,155,221,56,59,91,45,226,191,59,155,138,16,108,61,120,8,44,111,222,155,55,239,145,105,214,199,218,154,13,236,12,113,212,22,118,222,52,80,110,216,120,87,182,140,180,106,208,177,105,205,70,39,40,47,224,99,154,77,2,147,113,91,208,125,111,191,7,107,178,176,128,3,174,174,186,158,247,231,194,51,45,228,143,72,164,131,111,89,61,97,173,150,204,189,42,107,33,234,193,35,12,72,229,29,227,59,171,42,18,137,29,156,45,192,69,107,15,102,147,95,54,227,149,149,239,58,239,210,115,205,198,26,54,24,212,13,242,157,78,171,202,145,246,63,199,168,7,124,141,24,184,72,129,62,229,219,105,2,139,186,185,151,186,126,138,89,162,237,145,228,182,202,234,16,174,101,159,167,125,58,227,226,246,56,245,50,119,248,6,226,37,238,49,177,75,218,198,78,252,158,95,134,208,39,166,249,44,6,36,25,56,28,78,158,205,97,61,2,138,249,159,234,113,151,162,30,3,69,202,56,36,61,145,80,157,254,53,82,208,85,147,196,210,210,52,251,2,31,101,196,242,90,2,0,0 };
			RealUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			Version = 0;
			PackageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1300b53e-296c-4858-8368-493adc25a74c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIdentificationPassedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("27623c14-f1c7-4872-8f1c-45103cd82954"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"IdentificationPassed",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateIdentificationPassedParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f7cf3a22-2a33-428e-9e2b-5f3622d92f72"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,162,40,83,242,173,72,221,34,64,209,4,136,145,75,149,195,138,92,219,68,37,75,32,233,180,174,225,127,239,82,178,85,167,112,17,183,151,70,23,145,131,225,236,236,107,23,169,26,156,251,12,13,70,211,104,142,214,130,107,23,254,250,131,169,61,218,143,182,221,116,209,85,228,208,26,168,205,15,212,3,62,211,198,191,7,15,244,100,87,254,82,40,163,105,121,94,163,140,174,202,200,120,108,28,113,232,137,72,43,20,121,12,12,19,21,51,161,164,96,185,150,192,98,153,232,34,225,60,206,85,58,48,255,36,126,211,54,29,88,28,98,244,242,139,254,56,223,118,129,154,16,160,122,138,113,237,250,0,166,193,132,155,173,161,170,81,211,221,219,13,18,228,173,105,40,27,156,155,6,239,193,82,172,160,211,6,136,72,11,168,93,96,213,184,240,179,239,157,69,231,76,187,126,205,92,189,105,214,167,108,18,192,241,122,176,19,247,30,3,243,30,252,170,151,184,37,91,251,222,229,187,229,210,226,18,188,121,62,53,241,21,183,61,239,178,250,209,3,77,93,122,132,122,131,39,49,95,102,114,3,157,31,18,26,194,19,193,154,229,234,226,92,199,138,189,150,46,39,176,59,146,47,212,60,155,3,159,16,248,28,128,65,229,120,44,163,47,183,238,238,219,26,237,131,90,97,3,67,213,158,174,9,253,13,24,245,167,187,36,141,227,42,75,145,241,98,162,152,200,179,156,229,233,36,103,162,72,65,43,158,129,20,106,255,52,248,48,174,171,97,251,56,134,251,132,160,15,37,11,63,66,228,66,243,12,171,130,186,17,75,38,164,152,176,74,101,21,75,19,148,9,7,208,26,128,58,28,190,208,136,118,105,20,212,119,29,90,56,244,32,62,63,162,47,102,59,164,111,219,214,15,73,141,229,11,110,122,47,199,33,225,152,84,74,102,5,3,41,105,72,114,158,176,10,56,103,169,202,18,81,105,81,196,80,145,25,218,239,80,225,135,118,99,213,97,159,220,176,216,255,180,176,255,97,13,255,102,179,206,206,246,37,179,250,86,166,240,205,76,218,62,218,255,4,66,214,75,222,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a01e5fd1-7cbb-4e06-9188-a9656c381385"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4db6d4f9-57aa-44ef-8934-56b12a060e0e"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc3c82bb-8c59-485f-9376-5880ae2ce035"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf6ac2d-9970-48a9-80e2-c7d41b6c0c2e"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76636537-e5df-47a7-9eb6-124881330bf3"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("232523cc-cb63-410d-8f7c-58cdcf2ef818"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("6c984967-8a07-4d65-aefc-418e5a11cdcd"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3cd6198-af4e-409b-8ba3-0851372ea038"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("7e4ceefa-cd15-47a3-8a3b-c8ad4ed1ef7f"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("0a326237-a485-4b38-9337-3aa27272cdd9"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("f7b52dbf-c358-489e-bf2c-3c4ff7924a2c"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("dd6ab013-fc1e-4bc5-a25b-6855ace31f97"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("c6cfc815-55cb-4def-b83c-14b182d467ce"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("72ded882-b97d-4f56-91cb-1e6e212f4218"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a075eb5-bcac-445c-993d-bd329be8d6dc"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17573208-3be8-4476-9823-f565b0714f28"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("807ae5d1-ceac-47d5-8eb5-4720a6cd38c0"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("5770885f-4a81-42ac-b246-d9db3aa13a28"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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

		protected virtual void InitializeReadContactsByLeadCommunicationsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b62c39d0-3349-4a21-9582-0f3e9fab1b13"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,75,115,219,70,12,254,43,26,157,218,25,175,103,223,220,245,173,117,213,78,14,77,50,141,39,151,216,135,125,96,109,78,41,81,67,82,105,92,143,255,123,65,82,150,237,68,86,24,213,174,21,87,58,112,100,24,11,2,216,15,216,15,171,171,113,40,92,93,191,118,83,24,31,141,79,160,170,92,93,166,230,240,215,188,104,160,250,173,42,23,243,241,193,184,134,42,119,69,254,55,196,94,62,137,121,243,139,107,28,46,185,58,189,181,112,58,62,58,93,111,227,116,124,112,58,206,27,152,214,168,131,75,52,165,142,130,6,162,64,91,34,99,82,196,139,168,8,139,38,243,49,25,97,124,234,53,31,50,62,249,148,215,77,221,191,162,179,158,186,175,39,151,243,86,83,161,32,148,211,185,171,242,186,156,45,133,172,149,230,245,100,230,124,1,17,5,77,181,0,20,53,85,62,197,104,224,36,159,194,91,87,225,187,90,67,101,43,66,165,228,138,186,213,42,32,53,147,79,243,10,234,58,47,103,155,157,59,46,139,197,116,118,87,27,13,192,234,207,165,63,180,115,178,213,124,235,154,139,206,196,135,227,114,214,184,208,28,151,211,233,98,150,7,215,160,250,209,82,120,118,248,10,189,190,238,130,248,233,252,188,130,115,252,247,71,184,13,228,79,184,236,172,12,203,46,46,136,184,135,239,93,177,128,59,30,221,143,243,216,205,155,62,220,211,241,210,141,81,184,235,220,168,236,20,70,63,248,203,81,31,204,104,169,247,99,247,138,122,225,251,77,170,55,167,108,3,88,168,76,82,187,144,17,47,25,39,82,183,225,112,173,9,11,156,113,3,160,156,23,95,219,143,22,10,240,16,90,216,58,180,136,157,7,203,235,197,212,183,225,172,67,196,141,35,55,144,24,150,195,53,144,224,102,35,38,110,124,64,165,42,63,191,24,28,244,42,117,95,139,155,163,112,126,163,60,208,230,250,64,52,10,63,182,130,222,202,205,87,44,186,87,245,155,191,102,80,189,11,23,48,117,125,234,206,14,81,250,153,96,82,192,20,102,205,209,149,147,78,167,68,3,97,204,38,76,166,96,196,25,206,137,54,82,210,76,27,176,160,174,113,193,202,161,163,43,29,172,145,86,103,196,56,154,97,73,106,69,28,164,64,36,51,152,123,198,66,12,177,93,50,153,53,121,115,217,67,226,232,42,1,8,30,13,35,25,112,73,164,19,146,88,134,155,40,168,17,32,163,180,194,164,235,179,62,220,188,158,23,238,242,253,42,170,63,192,197,81,129,15,44,173,170,110,70,109,65,141,202,52,194,244,46,138,38,159,157,183,229,90,64,104,183,242,112,50,117,121,209,217,105,91,12,174,6,19,124,82,138,18,6,41,18,73,177,153,24,208,156,80,193,50,41,32,33,128,16,47,215,248,193,53,76,91,158,89,163,9,120,141,249,240,50,16,103,129,17,74,209,109,207,25,75,144,109,222,186,87,179,135,106,83,126,159,181,121,175,129,247,106,67,202,116,88,38,215,160,155,109,110,221,189,214,151,69,218,118,216,15,59,85,166,93,32,119,202,244,6,143,192,130,81,65,144,144,130,39,49,49,70,172,231,14,19,195,162,166,128,133,16,116,103,111,245,194,91,72,223,86,250,96,43,95,84,211,210,26,226,253,172,131,124,81,158,227,230,22,111,230,80,185,101,150,233,122,80,222,67,115,219,131,170,178,108,250,206,178,242,117,221,169,223,249,177,106,223,209,112,21,168,37,209,81,108,223,82,100,196,74,132,9,179,224,132,98,145,43,217,82,131,214,179,24,4,11,66,68,226,141,82,88,185,150,19,71,5,16,234,121,80,134,57,239,156,220,83,171,109,169,213,176,236,126,55,212,42,5,129,231,18,88,162,157,166,45,45,72,196,51,105,137,0,227,84,138,9,233,98,216,222,184,240,34,51,49,35,89,82,190,5,173,32,216,213,12,9,26,172,4,17,162,209,176,231,109,155,15,132,97,57,220,243,182,221,226,109,146,38,72,44,90,146,44,62,36,151,26,143,113,154,136,48,22,184,210,206,133,40,31,133,183,253,94,250,188,128,209,252,162,156,193,93,250,166,19,21,154,227,27,33,82,36,142,212,99,164,28,123,149,228,38,242,246,27,150,247,138,190,121,154,152,50,201,17,165,61,122,171,192,19,31,145,111,226,33,233,4,77,26,65,22,247,117,186,185,78,135,229,112,95,167,187,85,167,22,71,42,103,148,32,20,199,29,34,141,74,196,216,36,9,51,220,100,88,34,206,129,127,148,58,253,121,81,231,51,204,251,151,149,170,50,107,133,215,140,40,108,243,68,90,99,137,7,45,177,92,133,149,10,63,50,196,190,82,31,160,157,236,9,105,231,48,122,208,58,38,45,82,33,239,29,17,146,33,254,33,80,156,23,241,17,176,28,76,116,206,105,171,30,117,4,148,59,223,62,182,28,1,135,101,114,63,2,254,223,70,192,36,147,113,94,40,146,217,12,27,69,22,2,54,69,73,9,55,56,4,234,200,44,83,169,243,238,169,92,187,231,77,160,90,219,140,11,18,51,133,180,194,35,64,157,103,158,32,191,113,128,141,65,242,144,161,55,227,131,110,119,223,149,139,42,44,233,65,221,255,104,176,213,143,1,207,49,136,62,226,108,249,249,192,182,213,29,247,51,48,171,111,37,75,107,153,202,144,126,241,18,56,197,139,187,179,125,134,235,216,127,113,188,62,112,186,109,131,190,123,231,208,208,147,227,191,60,29,190,241,190,239,229,118,207,225,215,88,91,93,79,237,91,238,110,183,220,151,122,221,178,199,221,110,227,110,127,125,176,238,80,250,166,219,128,103,24,244,247,228,98,32,185,120,194,73,242,122,124,253,15,149,133,232,176,122,38,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15307ea3-405b-4286-937e-bbd0152634bb"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0de7902-f6c1-44eb-87ff-109bad0eb346"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d29cd82a-8e0d-4086-8795-48b2899e16af"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("daf2cf98-3c7e-4055-b671-143255e4ffb9"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("34ed4a32-1e5a-4623-ae6a-18a622bf6230"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97666c94-b7fa-4cf1-858f-96a7f5e41511"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("10568b26-1c18-4f39-9578-4a72a1c5fb66"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("935c4f95-44b6-44e3-920e-5b06a85a9a77"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("567adf56-c83c-4371-b0d7-e3c15c4a747e"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("7ad0d0ed-5315-4834-9632-bc717ea4b547"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("06ba8c97-f038-45da-8d5c-e5fa72c64ac0"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("085f20cb-53af-486b-a15f-5bc389f586df"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("7b7d4ca0-20b2-450c-a302-c217ce695e2c"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("316aa43c-1aa6-47f1-aaf7-572b6f838fcf"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2cc24615-28c1-4668-8f49-c93ae2c5896a"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4d0581e-c249-4b18-a38c-f40592d4085d"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("2729cf7a-36f6-4003-b06a-e8cb957b2269"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("f215686f-4d81-4543-93aa-539f611453e4"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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

		protected virtual void InitializeChangeLeadContactAllParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("9a626ad2-321e-427a-9f24-760d9280a022"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("564a7988-620b-401f-9bfc-8041ac06be95"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7b1963b-962d-4921-a62e-3119d14d8a66"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,93,111,155,48,20,253,47,60,215,21,96,8,144,183,169,203,166,74,211,90,169,81,95,70,31,174,237,75,98,13,2,178,157,110,89,148,255,190,107,32,44,157,50,53,219,203,202,3,152,163,227,115,207,253,218,7,178,6,107,63,67,131,193,60,88,162,49,96,219,202,93,127,208,181,67,243,209,180,219,46,184,10,44,26,13,181,254,129,106,192,23,74,187,247,224,128,174,236,203,95,10,101,48,47,207,107,148,193,85,25,104,135,141,37,14,93,17,2,35,153,85,138,73,201,11,150,200,48,103,69,150,10,134,0,32,132,74,185,4,62,48,255,36,126,211,54,29,24,28,98,244,242,85,127,92,238,58,79,141,8,144,61,69,219,118,51,130,220,155,176,139,13,136,26,21,253,59,179,69,130,156,209,13,101,131,75,221,224,61,24,138,229,117,90,15,17,169,130,218,122,86,141,149,91,124,239,12,90,171,219,205,107,230,234,109,179,57,101,147,0,78,191,163,157,176,247,232,153,247,224,214,189,196,45,217,58,244,46,223,173,86,6,87,224,244,243,169,137,175,184,235,121,151,213,143,46,40,234,210,35,212,91,60,137,249,50,147,27,232,220,144,208,16,158,8,70,175,214,23,231,58,85,236,181,116,99,2,187,35,249,66,205,179,57,196,51,2,159,61,48,168,28,143,101,240,229,214,222,125,219,160,121,144,107,108,96,168,218,211,53,161,191,1,147,254,124,31,241,48,20,41,71,22,23,51,201,146,60,205,89,206,103,57,75,10,14,74,198,41,100,137,60,60,13,62,180,237,106,216,61,78,225,62,33,168,177,100,254,67,72,21,23,66,228,97,194,162,144,199,44,81,72,125,41,162,148,137,34,205,147,162,10,69,85,69,212,97,255,248,70,180,43,45,161,190,235,208,192,216,131,240,252,136,190,152,109,159,190,105,91,55,36,53,149,207,187,233,189,28,135,4,68,22,115,65,209,179,2,66,150,164,42,97,144,209,171,152,225,44,22,228,19,148,31,55,218,111,95,225,135,118,107,228,184,79,118,88,236,127,90,216,255,176,134,127,179,89,103,103,251,146,89,125,43,83,248,102,38,237,16,28,126,2,4,255,142,248,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d16c9f4-5c23-4097-8d07-fac1cb716e39"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,83,219,48,16,253,43,30,193,49,202,88,214,135,37,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,59,99,43,237,208,76,254,123,21,39,1,66,219,83,117,176,165,213,190,183,187,207,207,27,114,30,95,87,72,42,242,128,125,15,67,23,226,244,162,235,113,122,219,119,14,135,97,122,221,57,104,234,95,96,27,188,133,30,150,24,177,127,132,102,141,195,117,61,196,73,118,10,35,19,114,254,99,188,37,213,211,134,204,34,46,191,207,124,98,47,181,65,225,138,130,218,160,25,21,121,238,169,78,33,42,180,194,80,50,163,188,100,9,236,186,102,189,108,111,48,194,45,196,23,82,109,200,200,150,8,192,11,147,123,169,105,46,5,80,225,181,164,166,16,138,122,175,133,82,104,185,209,156,108,39,100,112,47,184,132,177,232,59,88,48,8,169,154,161,165,204,45,21,104,45,213,14,28,13,129,27,171,132,22,12,221,14,124,200,127,7,62,157,61,205,134,111,63,91,236,239,71,222,42,64,51,224,98,154,162,159,2,87,13,46,177,141,213,70,74,93,148,192,29,149,22,29,21,65,66,154,217,104,90,26,94,42,45,10,102,57,223,38,192,155,154,213,134,229,82,105,91,40,202,28,211,9,194,13,53,178,76,59,40,11,96,78,6,171,212,14,114,213,198,58,190,94,140,26,85,27,192,28,133,116,64,157,48,50,161,176,164,192,141,167,28,108,89,148,26,153,98,229,118,113,182,216,13,230,235,97,213,192,235,227,159,243,221,33,248,204,117,109,168,251,37,142,187,8,46,14,153,125,205,154,221,85,154,177,110,50,104,125,182,122,233,90,28,166,95,234,126,136,89,157,190,108,214,133,172,199,97,221,196,186,125,78,200,166,65,23,235,174,157,206,252,190,234,234,196,48,31,235,110,230,123,223,205,73,53,255,151,243,14,239,189,206,167,222,251,108,187,57,153,204,201,125,183,238,221,142,145,167,195,229,135,129,199,34,99,202,167,227,209,103,41,210,174,155,230,16,185,132,8,199,196,99,184,243,117,168,209,207,218,251,163,189,70,150,252,176,232,95,30,199,181,239,237,127,96,55,208,194,51,246,95,147,0,239,189,191,117,249,144,100,60,18,219,194,200,188,100,129,150,8,38,249,92,21,84,123,6,212,48,99,3,47,121,17,66,49,162,239,48,96,143,173,195,211,198,152,178,200,149,100,84,7,44,168,96,210,36,188,207,41,232,156,123,161,52,247,158,31,240,195,168,246,238,7,63,244,181,147,106,75,182,219,197,246,55,23,17,232,91,84,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddContactByLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("c43dec79-6b59-4fc6-94f0-bcc6a7f8c091"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61b7d5bc-8334-4d0a-8ec3-aac02f0f6b0d"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ec4e60e4-4bd2-476d-bfa5-f3879991dce5"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("fc9a7fd7-6ae6-4198-801f-ed65a0714560"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0698fbce-2359-4022-88df-2b5fa4260af7"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,155,107,111,91,199,17,134,255,10,203,4,104,3,120,140,189,95,8,20,5,154,56,133,139,184,53,172,52,95,108,127,152,217,157,73,88,80,164,65,82,109,93,65,255,189,179,148,228,91,26,214,106,232,198,46,169,15,71,34,117,118,207,238,158,121,246,125,103,207,158,203,233,231,219,151,47,120,58,155,126,203,235,53,110,86,178,189,255,229,106,205,247,31,175,87,141,55,155,251,223,172,26,46,230,255,68,90,240,99,92,227,57,111,121,253,29,46,46,120,243,205,124,179,189,55,121,187,216,244,222,244,243,191,237,254,59,157,61,189,156,62,220,242,249,95,30,118,173,61,167,36,57,186,0,134,217,64,240,54,3,86,9,208,188,75,38,216,22,115,68,45,220,86,139,139,243,229,35,222,226,99,220,254,48,157,93,78,119,181,105,5,24,91,195,92,29,132,220,59,4,87,16,138,23,130,216,170,163,222,107,22,41,211,171,123,211,77,251,129,207,113,119,209,215,133,109,34,246,41,90,40,194,90,131,141,21,74,239,6,176,24,223,67,42,190,119,63,10,223,156,255,186,224,211,207,158,62,220,252,249,239,75,94,159,237,234,157,9,46,54,252,252,190,126,251,206,23,15,22,124,206,203,237,236,18,3,38,17,211,192,218,42,16,146,183,122,25,231,32,149,16,76,78,133,43,199,43,45,240,106,52,103,151,169,213,18,106,202,80,208,100,8,61,69,64,150,166,13,45,28,209,218,214,91,31,69,30,44,183,243,237,203,47,119,99,52,187,44,41,50,185,40,224,107,176,58,34,94,0,67,51,208,114,241,193,167,130,25,229,234,249,103,207,39,191,250,237,228,108,187,158,47,191,191,255,224,252,197,246,229,228,119,147,255,139,110,205,38,191,249,152,251,33,204,222,245,98,33,179,134,125,64,31,160,218,150,193,155,226,57,244,80,125,249,20,111,207,123,119,235,35,191,61,85,155,142,37,122,48,165,17,132,162,1,87,198,132,100,139,43,185,96,68,100,250,4,111,207,123,119,107,246,81,119,35,24,97,177,189,130,84,61,4,23,146,202,133,209,57,161,84,118,49,33,182,30,70,55,190,248,98,76,219,125,190,121,177,192,151,223,253,120,246,126,194,216,39,11,61,220,255,122,190,222,108,39,115,21,164,201,74,38,107,222,92,44,182,122,83,39,170,56,11,110,219,249,106,169,2,182,220,98,219,78,150,218,246,159,184,241,63,167,190,29,16,119,170,224,193,57,206,23,135,104,201,109,69,119,111,194,239,47,54,243,165,250,128,201,139,31,86,203,131,140,202,143,106,156,221,181,134,71,43,154,47,248,182,252,117,8,188,120,203,155,188,25,4,151,207,174,45,206,179,233,236,217,79,153,156,155,223,215,97,255,182,205,121,215,225,60,155,222,123,54,61,91,93,172,219,168,209,235,135,175,222,136,190,221,69,118,167,188,243,241,214,210,232,55,203,139,197,226,230,155,175,112,139,183,39,222,126,189,234,115,153,115,127,184,60,187,117,50,187,90,204,205,15,252,155,195,237,207,117,219,126,78,177,71,184,196,239,121,253,39,29,128,215,109,127,213,202,111,117,24,111,43,238,157,60,90,102,48,153,203,224,218,1,101,172,208,13,39,91,200,24,161,190,43,253,132,133,215,188,108,252,95,54,236,9,111,118,163,61,188,228,77,187,198,80,93,77,175,174,238,189,233,48,165,56,145,200,2,182,5,212,6,81,129,154,40,2,21,169,174,233,228,17,141,219,235,48,11,165,98,80,165,140,67,210,249,41,233,129,146,55,192,177,81,232,104,61,198,120,92,14,51,116,211,154,215,174,120,86,29,9,197,234,136,20,68,189,110,110,152,200,169,45,75,99,22,62,224,28,252,181,222,218,201,95,87,52,209,118,44,248,186,234,19,219,71,207,118,48,206,20,211,213,101,102,205,9,132,61,84,26,31,73,90,239,205,70,107,218,94,182,91,236,185,133,238,65,212,167,66,48,250,87,9,169,66,66,133,190,104,2,153,13,30,23,219,204,217,21,215,19,56,239,212,40,6,189,26,73,38,176,212,29,91,241,9,99,57,48,219,79,184,205,95,204,181,155,191,222,220,120,162,19,221,39,186,103,83,195,88,130,77,2,17,221,200,248,59,169,217,199,4,165,4,111,90,14,33,217,190,151,238,26,26,149,28,149,200,174,181,4,46,6,40,106,14,148,123,101,171,25,81,137,137,143,139,238,150,133,108,53,12,209,118,189,199,109,148,138,58,174,205,103,171,211,32,25,148,124,96,186,191,98,37,121,59,250,121,226,250,23,225,154,92,141,42,143,2,153,149,230,192,202,117,233,22,161,218,74,226,179,87,123,236,246,113,157,209,165,234,156,70,126,138,26,105,20,135,34,80,0,38,142,53,113,176,181,151,59,113,29,189,103,71,21,53,234,162,146,149,186,50,102,98,130,228,88,167,32,207,100,82,218,203,181,15,33,120,189,50,212,158,104,172,53,25,168,94,9,151,194,24,162,56,236,20,142,139,107,196,210,244,118,6,173,94,104,172,130,7,160,170,62,166,136,141,154,171,160,139,220,14,204,245,31,79,102,252,147,198,186,21,167,38,87,180,37,138,3,4,159,19,84,36,15,45,42,2,170,6,148,41,221,9,107,84,245,64,204,12,58,93,104,162,29,148,237,146,245,35,247,94,17,157,186,241,176,31,107,75,42,74,226,189,70,189,27,45,82,165,86,63,210,135,31,177,86,180,189,214,186,227,194,186,84,52,166,139,5,223,253,88,84,79,30,200,135,6,174,230,210,155,100,54,200,135,150,235,213,100,185,218,78,46,54,60,225,235,213,193,19,221,191,0,221,213,80,138,36,5,140,236,162,36,216,1,83,5,23,52,225,205,25,165,154,252,63,53,227,153,178,247,196,21,140,38,198,154,41,139,210,237,123,131,40,216,189,88,5,52,238,79,181,51,235,132,21,146,134,113,215,28,67,21,188,104,5,174,65,205,193,7,178,226,106,240,199,69,119,208,179,155,38,49,64,110,60,50,19,20,40,220,25,154,118,181,71,143,18,252,7,164,251,236,209,217,137,237,19,219,187,68,27,141,52,148,4,185,212,174,86,162,135,17,136,4,145,217,248,198,86,141,130,223,203,182,243,69,83,234,28,64,196,42,158,28,204,88,70,203,224,163,161,94,187,230,12,165,31,23,219,49,152,148,155,120,176,94,226,88,187,208,238,233,141,133,106,90,162,222,91,206,217,127,56,182,79,194,125,130,251,149,45,47,82,114,178,154,175,139,221,61,249,119,42,185,154,31,118,181,211,70,37,221,71,217,47,220,152,168,73,18,6,52,105,236,176,82,71,142,78,157,168,20,87,185,177,137,210,235,113,193,157,155,227,194,165,2,18,90,189,16,169,132,251,146,212,207,132,98,170,203,189,231,67,175,145,191,1,247,205,243,237,19,221,39,186,103,211,26,75,202,162,145,238,226,88,156,75,206,67,101,103,244,208,209,119,213,109,19,227,94,186,85,158,25,185,71,85,252,160,128,154,166,101,73,3,90,169,23,78,217,166,134,71,182,150,102,149,109,211,117,8,76,28,165,50,147,78,152,45,171,45,39,245,71,193,120,196,254,225,232,22,252,199,137,237,19,219,131,109,155,165,122,91,29,80,15,109,164,205,25,72,2,3,5,99,172,41,182,247,255,240,252,171,113,119,197,180,6,57,232,188,16,108,142,80,75,77,192,24,171,195,202,197,98,58,60,219,59,114,247,193,241,234,132,83,136,31,123,136,119,162,34,209,88,200,62,162,122,203,58,22,133,146,1,91,163,101,155,56,181,152,247,134,184,168,64,81,55,94,195,18,11,4,77,173,160,214,172,81,106,90,174,69,39,249,90,63,64,136,127,204,242,133,210,177,161,250,125,59,180,60,100,45,79,86,212,254,119,147,106,72,221,231,235,157,190,7,148,175,51,45,182,197,241,231,73,186,126,17,174,127,238,179,32,246,173,186,241,208,208,134,170,9,77,240,69,133,98,108,153,32,137,157,56,80,9,249,78,92,167,110,50,141,39,64,214,209,112,149,234,166,42,217,172,66,20,26,146,102,162,201,149,253,143,120,209,123,155,53,128,77,149,4,65,19,78,229,186,16,24,171,29,107,227,113,146,63,50,174,93,204,104,189,179,32,33,106,26,94,82,25,110,64,185,174,226,92,205,41,217,126,232,21,165,63,240,178,243,250,196,244,39,201,180,161,22,123,81,110,10,151,177,73,183,117,32,21,121,240,134,188,239,86,241,114,119,212,106,140,89,245,163,141,5,226,54,54,91,106,166,216,156,198,174,69,223,10,166,192,110,255,66,146,100,21,229,228,80,149,73,39,152,80,49,3,122,46,32,46,8,149,38,157,89,142,139,233,160,67,154,7,196,169,73,30,219,79,205,208,106,245,64,182,185,38,41,250,218,237,161,55,91,174,78,59,54,62,81,162,99,64,204,163,188,16,170,38,246,177,99,195,249,170,50,32,94,140,97,246,28,239,166,210,84,156,94,86,205,51,142,80,237,205,65,245,62,1,197,16,201,187,36,153,247,39,152,157,196,25,199,13,90,208,32,14,185,18,80,83,175,217,53,232,201,150,228,157,177,199,69,244,251,190,6,121,64,162,31,156,158,246,156,246,76,223,34,77,172,225,70,153,192,81,210,57,70,200,3,145,170,173,66,133,165,155,94,27,217,253,123,166,11,155,18,53,98,177,7,181,153,216,212,64,52,219,212,135,19,155,90,114,234,225,200,214,131,223,247,157,211,3,34,253,246,155,140,39,178,79,100,171,88,155,104,107,176,4,13,199,142,2,17,188,121,27,130,162,96,138,88,83,219,47,214,37,180,88,76,65,200,69,185,12,182,106,2,137,9,193,5,205,254,163,230,219,198,208,113,145,253,190,47,197,31,144,236,119,223,114,62,177,125,164,108,63,191,250,23,14,145,72,204,99,71,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77a80f56-4b60-48bc-be27-e96ffd4cc59b"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeAddContactAdressParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("5a0a517a-3cd6-4838-89ed-dd198ad96f83"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"d54d2218-61c8-413a-a1b7-5748c7e25f56",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dcf0939b-5ae1-4506-a7a2-453c0eb2f2d8"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,75,115,19,71,16,254,43,148,206,12,204,251,193,141,24,146,184,42,5,84,76,113,0,115,152,167,217,202,74,171,218,93,145,56,148,255,123,122,87,178,44,217,122,140,182,0,43,96,31,100,105,170,183,167,187,191,249,122,187,123,190,140,124,105,155,230,149,29,199,209,179,209,219,88,215,182,169,82,251,228,215,162,108,99,253,91,93,205,166,163,199,163,38,214,133,45,139,127,99,152,175,191,12,69,251,194,182,22,30,249,114,126,163,225,124,244,236,124,179,142,243,209,227,243,81,209,198,113,3,50,240,136,145,154,70,31,18,18,202,83,196,141,52,72,51,207,17,139,49,48,42,73,242,66,207,37,183,41,63,169,198,83,91,199,249,30,189,250,212,127,125,123,57,237,68,9,44,248,94,164,104,170,201,98,145,117,70,52,47,39,214,149,49,192,239,182,158,69,88,106,235,98,12,222,196,183,197,56,190,177,53,236,213,233,169,186,37,16,74,182,108,58,169,50,166,246,229,63,211,58,54,77,81,77,246,25,87,206,198,147,85,105,80,16,151,63,23,230,224,222,198,78,242,141,109,63,245,42,78,193,172,171,222,202,231,23,23,117,188,176,109,241,121,213,136,191,226,101,47,151,23,63,120,32,0,74,239,108,57,139,43,123,174,123,114,98,167,237,220,161,249,246,32,80,23,23,159,178,125,93,70,108,159,187,20,22,167,215,194,153,58,55,250,64,37,44,126,238,22,230,90,174,191,158,143,62,156,54,175,255,158,196,250,204,127,138,99,59,143,218,199,39,176,122,107,97,169,255,217,23,194,48,118,130,69,68,141,244,136,107,161,33,146,82,67,76,153,13,158,10,171,184,191,250,56,183,163,104,166,165,189,124,183,220,238,143,104,195,34,100,221,63,88,209,74,105,45,41,69,212,5,208,161,140,70,38,113,140,152,39,196,90,236,157,48,14,16,134,63,120,70,19,131,173,73,30,25,29,28,226,36,41,164,35,8,99,31,73,226,222,144,36,226,238,56,237,96,88,148,132,226,148,44,10,202,5,196,131,96,200,70,97,144,99,132,123,199,163,163,78,238,86,126,58,217,70,46,254,255,36,215,243,16,58,153,185,64,14,203,242,98,184,225,132,146,221,52,91,24,242,168,237,165,59,194,197,20,235,56,241,113,126,78,151,78,175,89,124,151,152,29,212,31,142,138,154,189,227,43,212,92,208,130,39,237,104,144,10,41,18,48,226,34,57,164,141,138,200,7,110,25,214,214,40,143,123,125,203,13,127,175,198,115,151,111,200,157,173,228,14,79,231,202,128,116,31,123,218,113,226,85,138,26,37,197,35,48,62,145,142,118,6,97,167,29,11,138,18,143,241,30,102,52,175,102,101,185,141,29,116,19,59,200,143,199,142,188,56,126,71,118,20,61,44,139,224,118,30,112,197,18,164,113,130,56,235,78,76,82,4,25,204,192,66,102,132,163,154,40,167,247,84,25,15,57,48,47,134,15,57,112,111,14,76,78,89,150,164,69,137,73,135,8,39,24,201,164,9,34,94,38,41,162,192,140,179,245,28,248,203,172,41,38,96,227,173,60,152,173,232,78,30,188,81,120,157,11,141,113,156,18,197,16,119,22,56,44,148,66,22,243,128,24,100,214,68,131,199,214,243,7,134,236,169,197,179,98,248,192,144,189,12,81,18,187,36,53,84,225,78,70,20,18,33,200,25,173,17,198,36,72,28,13,211,94,174,51,228,69,44,1,147,250,242,22,67,178,21,221,97,200,141,194,158,33,29,252,101,117,81,120,91,190,158,198,218,46,176,217,242,50,95,59,253,93,143,82,87,85,123,11,171,174,101,232,183,94,190,69,179,154,128,206,16,6,101,39,161,201,160,200,224,136,113,97,44,210,221,7,9,66,219,40,57,228,227,48,184,93,144,144,54,160,221,81,136,122,7,13,165,165,24,129,82,131,24,172,70,165,173,74,196,125,245,162,136,30,125,50,56,169,102,147,182,63,14,25,137,32,47,134,135,39,130,165,17,59,114,192,170,204,178,14,234,13,236,44,79,137,81,165,69,66,194,66,15,3,117,27,244,48,218,82,228,5,5,74,232,232,177,241,63,33,186,127,198,139,94,60,7,220,188,16,30,14,238,89,11,142,63,157,214,213,231,2,80,221,137,241,181,185,27,33,182,210,233,104,164,68,137,99,200,35,180,171,211,8,164,21,42,40,247,196,113,103,196,207,8,241,251,98,154,135,111,94,252,54,225,187,19,222,247,167,111,158,78,171,166,181,229,35,95,133,184,5,60,46,131,183,148,18,20,116,18,136,7,195,144,117,198,35,207,25,39,70,91,2,47,131,159,16,188,147,162,205,76,189,121,1,28,144,122,123,11,118,229,221,107,129,187,160,58,42,36,60,69,16,75,130,35,110,34,69,142,67,147,108,137,21,208,85,121,238,216,158,241,222,15,9,234,162,90,205,195,53,47,134,7,179,114,105,195,93,224,190,67,201,151,87,200,109,179,4,127,69,75,40,53,201,112,9,149,177,163,18,170,101,163,145,86,52,129,57,212,50,21,148,240,6,90,201,171,209,227,62,190,103,213,172,246,139,27,151,102,126,245,51,232,74,231,30,46,106,14,185,123,217,120,251,145,211,12,29,203,61,197,183,189,139,24,116,199,112,15,131,129,65,189,254,150,214,121,8,250,107,77,110,238,244,250,224,17,245,61,76,158,7,14,81,6,207,102,31,206,78,222,196,239,224,145,222,67,96,243,6,69,223,114,18,116,216,96,103,208,192,230,30,138,198,1,163,149,225,35,139,35,245,111,125,184,48,188,93,63,82,247,86,26,235,225,221,236,145,250,182,218,119,14,239,234,142,212,185,91,253,215,119,105,126,190,89,47,115,53,186,250,15,57,71,56,128,194,38,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55cf3377-2bf5-4a73-8eb5-34e7b911258b"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,4,0,183,239,220,131,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("6d55db5f-8e6c-420b-9a07-be564e8b90da"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6aa29df7-9dcf-4eea-b7dd-70cbb55c6070"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,219,142,27,69,16,253,21,99,120,0,105,219,233,251,197,18,66,16,2,90,41,64,148,132,60,144,205,67,117,119,53,88,120,103,86,227,49,40,172,246,223,57,227,221,37,155,0,134,144,85,46,100,253,96,123,122,166,106,170,187,235,212,57,53,115,58,255,104,124,122,194,243,229,252,33,15,3,109,250,54,46,110,247,3,47,238,13,125,225,205,102,113,183,47,180,94,253,70,121,205,247,104,160,99,30,121,120,68,235,45,111,238,174,54,227,193,236,121,179,249,193,252,163,95,118,103,231,203,199,167,243,195,145,143,191,63,172,240,174,34,145,162,40,69,109,69,10,91,44,139,44,11,9,138,205,20,227,172,175,117,50,46,253,122,123,220,125,195,35,221,163,241,167,249,242,116,190,243,6,7,158,85,116,41,71,225,200,25,97,157,9,34,171,198,162,5,226,88,178,85,206,219,249,217,193,124,83,126,226,99,218,221,244,153,113,117,182,106,173,162,240,170,68,97,149,193,141,85,14,194,5,27,75,96,237,154,243,147,241,197,245,207,12,31,127,248,248,112,243,221,175,29,15,15,118,126,151,141,214,27,126,178,192,232,11,3,119,214,124,204,221,184,60,37,75,190,53,89,132,82,169,9,235,141,194,36,181,22,62,90,43,131,143,156,216,157,193,224,143,213,92,158,250,146,162,77,62,136,72,50,8,91,189,19,196,173,32,208,200,142,148,42,181,212,201,228,78,55,174,198,167,183,119,107,180,60,13,62,71,235,139,23,158,154,19,86,22,45,146,11,94,184,226,106,46,178,122,45,229,217,147,15,159,76,19,171,171,205,201,154,158,62,250,243,252,238,51,213,217,26,95,139,175,86,195,102,156,173,176,101,179,190,205,6,222,108,215,227,170,251,113,134,61,89,115,25,87,125,183,248,188,86,140,111,206,125,158,60,151,14,87,189,158,30,157,103,213,209,124,121,244,119,121,117,241,123,190,138,207,103,214,139,73,117,52,63,56,154,63,232,183,67,153,60,26,28,124,121,101,58,187,155,236,46,121,225,240,50,139,48,210,109,215,235,139,145,47,105,164,203,11,47,135,251,186,106,43,174,135,221,131,203,228,217,121,145,23,31,241,23,95,151,159,243,216,94,197,236,27,234,232,71,30,190,197,2,60,139,253,143,40,31,98,25,47,29,23,217,164,245,26,25,130,173,21,22,123,44,162,101,39,146,85,169,150,232,148,207,106,103,125,159,27,15,220,21,254,143,129,221,231,205,110,181,39,248,94,196,53,45,213,217,252,236,236,224,42,168,179,139,182,144,50,194,32,131,39,88,121,145,152,73,104,100,58,23,74,218,134,182,23,212,202,26,87,106,203,176,85,90,88,206,22,85,193,39,17,101,210,149,165,10,222,135,247,11,212,86,187,152,125,146,162,113,80,216,227,64,34,234,16,69,147,20,114,170,213,134,120,221,160,190,141,219,223,32,250,141,32,58,235,228,100,80,77,4,38,0,136,189,22,177,42,18,73,165,220,76,48,186,53,189,15,209,14,32,147,217,195,192,48,114,204,218,40,50,174,20,148,81,12,60,23,93,26,191,20,162,1,97,230,130,164,85,81,90,97,163,6,162,117,246,162,145,181,173,56,202,20,247,211,116,40,94,201,160,139,200,164,225,128,178,17,81,105,18,222,4,171,200,112,70,5,123,191,16,205,170,161,200,25,76,42,52,212,184,74,70,144,105,94,84,171,147,37,170,88,39,127,205,136,254,225,240,222,173,147,126,51,210,26,163,149,111,192,253,70,192,109,180,163,96,160,88,101,179,19,56,105,162,107,208,92,240,210,55,148,113,105,168,188,86,186,174,181,6,51,213,8,19,17,149,109,108,69,140,181,8,67,73,121,8,136,232,201,239,167,107,47,147,137,46,10,106,25,228,100,192,247,57,230,34,156,86,46,1,76,17,66,244,173,0,183,162,22,165,174,73,164,166,209,44,104,137,64,83,65,93,100,153,165,116,178,82,226,23,192,29,2,186,19,132,0,206,245,16,87,211,180,50,67,107,113,66,153,168,182,20,52,31,255,12,83,8,228,217,182,43,125,215,86,195,49,87,192,175,27,169,140,179,76,27,28,245,221,14,194,179,85,215,250,225,152,206,217,119,96,26,113,110,224,210,15,117,118,88,111,208,250,78,82,49,196,55,27,239,148,136,141,81,230,1,8,216,87,9,82,145,166,90,31,77,173,230,165,208,234,172,202,50,134,137,73,37,192,134,254,23,226,26,156,74,90,114,10,17,65,25,181,23,173,5,213,38,53,132,208,108,196,140,106,4,220,147,247,162,152,22,108,181,178,38,247,158,117,204,181,176,145,12,42,54,217,192,74,66,156,228,132,222,89,198,28,18,214,195,160,82,92,51,21,63,24,129,238,91,39,67,255,203,10,41,115,131,237,119,18,219,80,191,104,77,19,200,192,67,189,217,22,139,136,206,71,225,106,179,185,106,138,57,169,151,194,54,235,106,42,186,57,116,187,224,95,203,211,63,135,198,89,201,2,213,224,155,55,94,238,197,118,85,170,82,161,12,7,166,66,102,131,168,208,6,100,145,164,69,230,35,155,75,77,215,143,237,113,192,207,30,108,92,158,191,73,240,215,156,224,83,19,232,114,155,164,230,174,8,90,208,80,8,73,104,20,52,252,161,150,100,120,173,82,83,89,170,182,101,22,236,166,167,59,201,85,72,205,56,53,61,248,52,54,201,133,188,55,193,165,71,62,83,209,2,179,106,231,116,154,202,68,12,12,157,86,33,198,106,160,247,140,188,66,202,182,74,212,175,144,160,7,82,50,34,57,157,5,203,20,100,140,217,185,114,221,125,228,237,126,219,141,195,205,195,161,119,147,181,100,106,133,21,138,130,83,14,201,165,147,71,194,20,0,17,220,0,9,152,200,151,246,82,160,38,89,244,244,178,70,104,23,64,58,37,34,150,138,142,73,5,15,41,105,117,115,145,246,179,86,78,210,33,116,16,39,226,176,211,51,43,66,250,139,234,12,4,114,201,90,214,124,253,160,254,248,109,70,181,247,209,105,10,78,100,173,25,75,146,166,142,161,226,150,41,42,11,38,151,202,168,9,213,179,15,62,157,125,189,93,213,197,157,227,147,241,233,39,179,207,102,255,139,89,45,49,141,187,125,255,243,246,100,225,100,52,33,79,174,77,155,130,243,80,51,54,103,81,89,70,27,152,75,85,121,209,114,152,30,158,145,104,6,231,193,115,82,248,22,149,80,5,162,201,177,147,198,154,253,37,240,227,255,246,202,107,54,21,184,191,222,134,87,113,119,101,254,87,207,44,190,216,110,86,221,205,155,182,119,181,244,254,155,92,254,167,210,251,228,236,119,91,78,13,171,156,31,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9f11eba-9282-49e7-842b-28c1d0f2190f"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeAddContactWebParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("97a7e2ca-58ad-4a27-8a87-3f50772b77be"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"004a9121-21f8-4a1e-8918-45c0f756ea41",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f713b4e-bdb9-470a-b959-23af1cb99aaa"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,93,111,155,48,20,253,47,60,215,21,216,134,64,222,170,46,155,34,77,109,165,70,221,195,210,135,139,125,73,172,153,128,108,210,45,139,242,223,119,129,36,75,167,180,205,42,109,45,47,192,209,241,253,56,215,247,172,3,101,193,251,43,40,49,24,6,19,116,14,124,85,52,231,31,141,109,208,125,114,213,178,14,206,2,143,206,128,53,63,81,247,248,72,155,230,3,52,64,71,214,211,223,17,166,193,112,122,60,198,52,56,155,6,166,193,210,19,135,142,20,58,17,170,40,34,166,162,168,96,50,213,192,50,94,72,150,228,185,202,178,44,148,156,99,207,124,42,248,101,85,214,224,176,207,209,133,47,186,207,201,170,110,169,17,1,170,163,24,95,45,182,160,104,139,240,163,5,228,22,53,253,55,110,137,4,53,206,148,212,13,78,76,137,55,224,40,87,27,167,106,33,34,21,96,125,203,178,88,52,163,31,181,67,239,77,181,120,169,56,187,44,23,135,108,10,128,251,223,109,57,97,87,99,203,188,129,102,222,133,24,83,89,155,174,202,139,217,204,225,12,26,243,112,88,196,55,92,117,188,211,244,163,3,154,166,116,7,118,137,7,57,31,119,114,9,117,211,55,212,167,39,130,51,179,249,201,189,238,21,123,169,93,78,96,189,35,159,24,243,104,15,60,33,240,161,5,250,40,187,207,105,240,117,236,175,191,47,208,221,170,57,150,208,171,118,127,78,232,31,192,62,254,112,29,137,48,204,99,129,140,103,137,34,37,227,148,165,34,73,153,204,4,104,197,99,24,72,181,185,239,235,48,190,182,176,186,219,167,251,140,160,183,146,181,47,66,146,144,39,185,26,8,166,82,9,76,230,57,205,37,6,201,210,60,141,52,231,185,148,177,162,9,211,67,103,68,138,92,167,82,50,14,92,50,169,84,202,50,13,17,19,3,206,69,33,7,74,232,232,121,157,198,254,106,105,237,83,59,192,143,237,0,127,247,59,240,5,115,111,218,180,167,44,194,105,26,30,185,68,209,179,139,64,53,244,150,213,9,188,203,219,77,205,86,51,163,192,94,215,232,96,203,15,143,107,250,104,24,237,157,117,85,213,244,55,113,175,87,123,133,186,76,187,134,178,65,40,64,133,146,65,17,103,76,242,12,88,154,8,186,70,131,84,105,29,135,9,87,130,164,33,83,110,59,186,173,150,78,109,77,208,247,110,252,42,151,125,3,239,252,27,59,60,106,72,167,24,204,123,177,142,127,107,15,111,176,245,175,88,228,255,178,73,155,96,243,11,184,24,168,34,211,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9021827f-1e50-40f2-8b7f-ec1b0e056ccb"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,4,0,183,239,220,131,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("aa2e3f7d-4042-4910-b0eb-0f5b57896d58"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7a98d7a0-39d9-4231-b19a-9c603fa6baf0"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,149,75,111,220,54,16,199,191,202,66,201,209,92,240,253,216,91,225,164,128,1,167,53,226,52,61,216,62,12,201,97,34,84,43,25,146,182,133,187,216,239,158,145,188,27,63,218,218,6,138,162,45,16,29,36,145,226,60,56,250,255,56,219,234,245,120,115,141,213,170,250,128,125,15,67,87,198,229,113,215,227,242,172,239,18,14,195,242,180,75,208,212,191,67,108,240,12,122,88,227,136,253,71,104,54,56,156,214,195,120,180,120,104,86,29,85,175,127,157,191,86,171,139,109,117,50,226,250,167,147,76,222,179,202,218,154,16,152,3,237,153,230,46,50,47,193,50,101,4,198,44,101,240,5,200,56,117,205,102,221,190,195,17,206,96,252,92,173,182,213,236,141,28,164,34,165,213,198,179,36,18,103,58,243,196,160,160,97,90,88,171,139,204,198,113,172,118,71,213,144,62,227,26,230,160,119,198,156,107,8,66,10,38,69,161,232,32,144,249,32,232,205,36,94,156,177,8,90,76,198,251,245,119,134,23,175,46,78,134,31,127,107,177,63,159,253,174,10,52,3,94,45,105,246,209,196,219,6,215,216,142,171,173,128,226,185,204,129,133,34,21,211,146,91,22,67,66,6,200,35,231,134,103,8,184,35,131,175,213,92,109,157,3,207,139,177,76,71,75,123,243,49,177,136,210,49,12,182,148,172,83,50,33,238,174,94,93,77,41,230,122,184,110,224,230,227,31,51,253,46,231,197,166,77,93,91,234,126,141,121,65,111,35,164,113,17,97,160,81,215,46,26,132,188,168,219,210,245,107,24,235,174,93,30,247,8,35,125,235,49,117,125,94,156,228,219,16,215,15,254,243,253,32,219,203,91,185,92,86,171,203,191,18,204,254,121,91,158,135,146,121,172,150,203,234,232,178,58,239,54,125,154,60,42,26,188,185,183,187,57,200,188,228,209,240,32,15,154,105,55,77,179,159,121,3,35,28,22,30,166,187,92,151,26,243,73,123,126,80,197,236,133,239,47,246,39,183,195,117,155,219,223,49,123,7,45,124,194,254,7,42,192,93,238,95,179,252,64,101,60,56,142,50,24,238,68,97,14,33,48,141,86,50,159,5,176,32,66,44,202,41,89,138,156,173,223,99,193,30,219,132,15,19,19,54,162,178,70,48,95,80,18,17,38,144,125,230,140,84,53,97,231,85,206,106,111,63,204,213,158,184,220,231,53,149,106,87,237,118,71,247,105,149,81,104,233,4,201,176,56,77,130,180,137,5,29,10,243,66,128,8,147,194,75,126,146,86,46,75,2,52,142,21,40,64,59,210,133,5,101,29,139,198,43,225,192,162,196,244,159,160,21,52,16,99,116,152,8,65,251,211,86,9,170,154,148,204,122,77,135,148,245,24,208,60,162,213,166,224,117,160,205,120,224,142,78,34,107,136,237,146,168,238,30,13,8,145,114,202,147,201,219,118,172,199,155,227,185,70,171,45,58,163,130,160,66,10,157,5,29,11,66,177,24,157,163,178,40,157,13,90,170,116,121,158,241,247,19,194,19,199,203,239,235,126,24,23,53,253,178,69,87,136,224,97,211,140,117,251,137,168,111,26,76,51,222,63,99,252,6,244,191,2,116,206,81,145,108,145,113,135,126,146,136,100,209,17,218,153,163,21,158,218,64,137,249,41,160,95,156,216,75,129,206,74,113,235,18,48,200,115,66,164,117,144,201,50,11,60,33,58,239,147,226,79,2,45,100,17,217,41,98,89,37,106,186,96,36,11,49,83,255,70,142,9,74,86,37,234,127,2,232,211,174,251,101,115,189,204,94,219,20,233,20,41,194,103,194,52,144,7,85,202,212,33,69,161,216,224,157,90,90,240,17,2,245,77,218,105,98,185,8,65,57,74,160,170,137,108,57,6,229,147,125,14,176,125,188,227,110,189,222,180,117,154,251,228,162,187,158,31,19,40,223,160,250,223,118,201,151,104,232,57,168,174,118,95,0,154,186,196,212,49,11,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("89ff5387-057a-41f9-a2cd-98c33da073a9"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeReadContactsByLeadEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6514abc-f96a-4d19-b5f8-f55b1ac00b83"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,75,111,27,55,16,254,43,194,158,90,32,52,200,37,151,203,213,45,112,148,194,151,36,104,140,92,34,31,248,24,202,139,236,67,216,165,210,168,130,254,123,103,31,146,173,68,86,84,183,137,93,160,62,24,210,232,227,240,155,225,55,143,77,100,11,221,182,111,116,9,209,52,186,134,166,209,109,237,195,197,235,188,8,208,252,214,212,171,101,244,34,106,161,201,117,145,255,9,110,176,207,92,30,94,233,160,241,200,102,126,231,97,30,77,231,199,125,204,163,23,243,40,15,80,182,136,193,35,154,102,14,116,236,72,146,104,71,132,225,146,232,76,90,34,157,22,34,225,82,74,166,6,228,67,206,103,95,242,54,180,195,21,189,119,223,127,188,94,47,59,100,130,6,91,151,75,221,228,109,93,141,70,214,89,243,118,86,105,83,128,67,67,104,86,128,166,208,228,37,70,3,215,121,9,239,116,131,119,117,142,234,206,132,32,175,139,182,67,21,224,195,236,203,178,129,182,205,235,234,52,185,203,186,88,149,213,125,52,58,128,253,215,145,15,237,73,118,200,119,58,220,246,46,62,94,214,85,208,54,92,214,101,185,170,114,171,3,194,167,163,241,230,226,10,89,111,251,32,94,46,22,13,44,240,231,207,112,23,200,39,88,247,94,206,203,46,30,112,248,134,31,116,177,130,123,140,14,227,188,212,203,48,132,59,143,70,26,19,123,159,220,164,238,1,147,95,204,122,50,4,51,25,113,191,246,87,180,43,51,60,82,123,58,101,39,196,146,100,158,167,194,25,146,198,74,19,65,121,70,12,143,25,209,222,41,154,73,231,99,235,190,247,30,157,20,224,33,181,176,99,106,225,207,94,44,111,86,165,233,194,57,166,136,29,145,157,36,206,203,225,17,73,196,234,164,38,118,28,16,212,228,139,219,179,131,222,167,238,123,113,199,104,92,238,192,103,250,60,30,136,68,227,231,206,48,120,217,125,196,162,187,106,223,254,81,65,243,222,222,66,169,135,212,221,92,160,245,43,195,172,128,18,170,48,221,104,161,165,247,212,18,198,50,79,132,228,152,71,21,199,68,42,33,104,42,21,100,144,108,241,192,158,208,116,35,109,166,68,38,83,162,52,77,137,112,50,33,26,188,37,130,41,72,52,99,214,89,215,29,153,85,33,15,235,65,18,211,141,7,224,177,83,140,164,16,11,34,52,23,36,99,54,37,156,42,14,194,137,140,43,191,189,25,194,205,219,101,161,215,31,246,81,253,14,218,77,10,252,135,165,213,180,97,210,21,212,164,246,19,76,239,170,8,121,181,232,202,181,0,219,61,229,197,172,212,121,209,251,233,90,12,158,182,50,6,74,169,33,92,161,84,186,174,129,55,39,200,193,114,169,124,166,140,73,24,42,15,255,240,12,103,25,128,224,41,66,144,171,48,30,136,118,113,70,40,79,56,149,248,99,108,244,233,167,187,170,30,170,77,241,223,172,205,131,6,62,192,206,41,211,243,50,121,68,221,236,116,235,30,80,223,22,105,215,97,63,62,171,50,237,3,185,87,166,163,30,1,152,85,137,229,196,122,107,136,243,140,145,204,196,154,80,202,156,164,128,133,96,101,239,111,127,225,157,164,239,42,253,108,47,223,84,211,232,13,245,126,211,75,190,168,23,248,184,197,219,37,52,122,204,50,61,46,202,3,53,119,61,168,169,235,48,116,150,61,215,99,83,191,231,177,211,133,145,206,106,16,158,184,76,96,57,198,158,19,195,164,39,169,74,82,236,235,38,139,57,237,217,253,40,106,7,108,52,7,212,35,19,120,61,83,200,134,33,27,74,61,225,38,49,10,89,42,3,30,217,224,226,216,189,238,251,122,213,216,113,246,182,195,198,248,168,77,240,41,22,188,127,113,103,251,122,17,122,212,130,243,4,107,203,223,221,68,142,174,1,231,244,139,255,7,246,51,28,216,79,48,139,255,193,120,125,96,186,61,70,125,7,115,232,220,201,241,51,167,195,15,109,246,219,104,251,23,61,201,224,253,26,16,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("881a211c-0037-4de8-9966-fd5b76082530"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b0558b6-d02e-43db-a632-da912ff74169"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38ac0d8a-57fb-4d3c-a724-83243171725c"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2306c9f4-91b3-4ae6-9d0d-b85b15f043a5"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("91e3ad56-02d2-495e-8f8d-6839c1e13901"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("09b2ffa0-b537-4970-bb51-a8da7fb89215"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,176,50,212,241,76,1,82,6,0,110,89,182,126,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f289649e-c0c3-403b-8124-ffe171aafe33"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("e7d2a1ae-2033-4d71-9990-c4c12f4faa89"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("681c5445-3ca2-45de-bf7c-0f37318944d1"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("95b392b6-a727-407b-a3ec-157c1314469b"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("0eadc500-3c91-49a1-8071-9d0668f51d38"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("849f1602-4ec0-45ef-a640-370b4ec656e7"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("847ce0c0-4e8f-4238-a637-16f20d906278"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cfe3a33-faaf-4cb5-b49e-d1eadaa81bec"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f61ce3ad-7460-43d4-b04a-9a8735ba629d"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("98cf1789-f51a-4231-b152-7212be2cdca3"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("1921c84b-08d6-4bab-b0f8-1e4173f757ea"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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

		protected virtual void InitializeChangeLeadContactEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("788c3395-e8dc-443e-9c81-e57decd44c14"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("40c79c51-5e3e-4a77-881f-bfb3b5148e9c"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3da883c3-07af-4baf-9a48-e1f261dbd978"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,111,138,190,21,169,91,4,40,154,0,49,114,169,114,88,145,43,155,168,100,9,36,157,214,53,252,239,93,74,182,234,20,46,226,246,210,232,34,105,48,156,157,93,206,238,2,217,128,181,159,161,197,96,22,44,208,24,176,93,237,174,63,232,198,161,249,104,186,77,31,92,5,22,141,134,70,255,64,53,226,115,165,221,123,112,64,71,118,229,47,133,50,152,149,231,53,202,224,170,12,180,195,214,18,135,142,240,58,170,64,242,138,129,72,144,165,200,37,43,64,198,172,86,40,98,80,144,136,180,30,153,127,18,191,233,218,30,12,142,53,6,249,122,248,92,108,123,79,141,8,144,3,69,219,110,125,0,19,111,194,206,215,80,53,168,232,223,153,13,18,228,140,110,169,27,92,232,22,239,193,80,45,175,211,121,136,72,53,52,214,179,26,172,221,252,123,111,208,90,221,173,95,51,215,108,218,245,41,155,4,112,250,61,216,9,7,143,158,121,15,110,53,72,220,146,173,253,224,242,221,114,105,112,9,78,63,159,154,248,138,219,129,119,217,252,232,128,162,91,122,132,102,131,39,53,95,118,114,3,189,27,27,26,203,19,193,232,229,234,226,94,167,137,189,214,110,76,96,127,36,95,168,121,182,135,56,39,240,217,3,163,202,241,179,12,190,220,218,187,111,107,52,15,114,133,45,140,83,123,186,38,244,55,96,210,159,237,162,36,12,171,140,134,24,139,92,178,180,200,10,86,36,121,193,82,145,128,146,113,6,60,149,251,167,209,135,182,125,3,219,199,169,220,39,4,117,24,153,127,17,18,231,153,80,60,229,172,66,37,88,42,99,82,227,94,28,5,64,21,39,69,86,3,221,176,127,252,69,116,75,45,161,185,235,209,192,225,14,194,243,17,125,145,109,223,190,233,58,55,54,53,141,207,187,25,188,28,67,34,34,5,188,80,20,146,40,231,44,141,34,193,42,17,102,172,78,185,228,105,146,84,153,160,144,236,105,191,253,132,31,186,141,145,135,125,178,227,98,255,211,194,254,135,53,252,155,205,58,155,237,75,178,250,86,82,248,102,146,182,15,246,63,1,88,136,108,183,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bec4aa50-4e70-47b5-99c8-d0f15b4b12f8"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,82,219,48,16,253,21,143,224,24,101,36,91,182,36,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,155,177,149,118,210,140,255,189,178,147,0,161,237,169,58,216,214,106,223,219,221,231,167,29,57,15,219,87,36,37,121,192,174,131,190,245,97,126,209,118,56,191,237,90,139,125,63,191,110,45,212,213,47,48,53,222,66,7,107,12,216,61,66,189,193,254,186,234,195,44,57,133,145,25,57,255,49,157,146,242,105,71,22,1,215,223,23,46,178,91,103,85,206,210,130,58,229,13,21,169,226,20,12,203,105,202,160,40,28,79,65,115,19,193,182,173,55,235,230,6,3,220,66,120,33,229,142,76,108,145,0,156,208,204,229,138,178,92,0,21,78,229,84,167,34,242,57,37,138,2,77,166,85,70,134,25,233,237,11,174,97,42,250,14,22,28,188,210,168,169,204,89,172,142,198,80,101,193,82,239,51,109,10,161,4,71,59,130,15,249,239,192,167,179,167,69,255,237,103,131,221,253,196,91,122,168,123,92,205,99,244,83,224,170,198,53,54,161,220,33,75,81,42,166,168,146,169,166,194,106,73,141,102,146,114,161,164,79,145,203,84,170,33,2,222,212,44,119,2,57,50,169,51,10,57,218,40,14,8,106,164,137,179,89,31,123,229,133,100,136,35,228,170,9,85,216,94,76,26,149,59,64,134,34,183,64,173,208,57,21,30,37,133,76,59,154,129,25,107,32,47,184,28,86,103,171,113,48,87,245,175,53,108,31,255,156,239,14,193,37,182,109,124,213,173,113,250,10,96,67,159,152,109,82,143,71,113,198,170,158,127,169,186,62,36,85,252,157,73,235,147,14,251,77,29,170,230,57,166,215,53,218,80,181,205,124,225,246,165,94,79,92,242,177,216,110,185,55,219,146,148,203,127,217,237,240,222,139,123,106,184,207,94,91,146,217,146,220,183,155,206,142,140,89,220,92,126,152,114,42,50,165,124,218,30,205,21,35,205,166,174,15,145,75,8,112,76,60,134,91,87,249,10,221,162,185,63,122,106,98,97,135,69,255,242,56,174,125,111,255,3,187,129,6,158,177,251,26,5,120,239,253,173,203,135,40,227,145,216,164,58,103,146,123,42,17,162,225,176,72,169,114,28,168,230,218,248,76,102,169,247,233,132,190,67,143,29,54,22,79,27,227,133,193,172,200,57,85,30,83,42,120,174,35,222,49,10,138,101,78,20,42,115,46,59,224,251,73,237,241,86,31,250,26,165,26,200,48,172,134,223,213,184,64,99,73,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadContactsByLeadPhoneParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55598db2-619f-4f92-a9b5-d03ddb173ed0"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,223,111,219,54,16,254,87,12,63,109,64,25,144,18,69,145,126,219,50,111,200,195,218,98,13,250,82,231,225,68,30,29,97,250,97,72,114,215,44,200,255,222,163,100,59,73,227,184,106,214,44,65,17,63,24,242,249,120,186,59,126,223,241,227,229,212,22,208,182,175,161,196,233,108,122,138,77,3,109,237,187,163,223,243,162,195,230,143,166,94,175,166,175,166,45,54,57,20,249,191,232,6,251,220,229,221,111,208,1,45,185,92,92,71,88,76,103,139,253,49,22,211,87,139,105,222,97,217,146,15,45,209,18,184,74,149,102,137,77,50,38,69,138,12,208,39,204,26,157,197,158,131,115,220,15,158,247,5,159,127,202,219,174,29,94,209,71,247,253,227,233,197,42,120,38,100,176,117,185,130,38,111,235,106,99,20,193,154,183,243,10,178,2,29,25,186,102,141,100,234,154,188,164,106,240,52,47,241,45,52,244,174,16,168,14,38,114,242,80,180,193,171,64,223,205,63,173,26,108,219,188,174,14,39,119,92,23,235,178,186,233,77,1,112,247,115,147,15,239,147,12,158,111,161,59,239,67,124,56,174,171,14,108,119,92,151,229,186,202,45,116,228,62,219,24,207,142,78,40,235,171,190,136,95,150,203,6,151,244,247,71,188,46,228,111,188,232,163,140,235,46,45,112,180,135,239,161,88,227,141,140,110,215,121,12,171,110,40,119,49,221,164,49,177,55,147,155,212,189,195,228,167,236,98,50,20,51,217,248,253,220,191,162,93,103,195,38,181,135,91,118,0,44,113,172,0,211,44,97,58,226,158,201,40,226,76,103,220,50,224,34,150,73,156,72,110,213,131,131,71,153,136,208,122,203,68,10,156,73,31,27,166,141,140,232,73,122,237,29,202,20,226,175,109,118,192,25,222,7,69,177,15,138,241,179,71,226,235,117,153,133,114,246,193,109,155,200,22,111,227,122,184,7,111,145,62,8,184,109,14,228,212,228,203,243,209,69,239,90,247,181,186,35,50,174,182,206,35,99,238,47,68,145,241,99,48,12,81,182,143,196,232,147,246,205,63,21,54,239,236,57,150,48,180,238,236,136,172,95,24,230,5,150,88,117,179,75,144,160,188,39,120,11,97,8,237,42,22,12,116,20,49,165,165,228,68,106,52,152,92,209,130,93,66,179,75,69,196,150,70,165,76,3,79,153,116,42,9,124,183,196,124,141,9,8,97,157,117,97,201,188,234,242,238,98,128,196,236,210,72,136,65,39,49,227,218,210,148,208,137,167,93,243,146,9,29,233,84,67,2,128,217,213,217,80,110,222,174,10,184,120,191,171,234,47,4,55,41,232,139,168,213,180,221,36,16,106,82,251,9,181,119,93,116,121,181,12,179,160,64,27,182,242,232,215,117,155,87,212,247,201,234,188,174,176,15,24,6,25,133,145,60,66,163,8,46,161,44,74,65,72,150,57,31,17,189,33,118,105,202,17,140,38,8,210,135,214,100,206,26,231,41,65,207,227,128,50,3,76,167,177,98,96,45,149,233,141,64,239,94,152,122,152,169,227,122,248,194,212,231,197,84,201,61,122,225,12,243,134,190,100,36,105,195,12,29,133,177,54,24,37,10,192,58,249,93,152,250,103,157,229,5,222,229,41,38,25,151,105,76,121,90,5,76,6,45,145,101,17,176,196,8,58,142,29,213,26,249,129,167,1,132,69,189,36,113,80,188,89,97,3,27,132,136,253,44,186,69,191,176,49,77,93,119,67,187,119,27,187,79,17,245,185,109,49,61,78,30,132,196,210,40,74,141,18,9,75,29,196,76,102,225,156,210,128,140,186,43,45,160,49,212,199,195,216,58,169,238,27,30,114,223,240,144,207,126,120,220,106,235,224,54,102,142,140,235,228,30,250,137,195,18,115,240,186,59,69,130,88,251,240,172,230,72,95,200,141,57,178,101,10,10,171,19,27,51,146,67,25,115,94,8,102,2,83,56,23,78,113,52,177,14,96,164,165,187,23,206,75,200,139,222,116,61,138,70,71,185,67,247,77,52,34,226,217,125,92,228,143,200,69,23,211,213,34,13,154,66,209,32,164,3,61,98,25,215,25,211,50,166,211,5,133,32,69,216,103,247,88,169,221,202,198,91,169,156,50,156,165,70,16,74,169,167,140,4,142,98,218,138,196,113,103,148,49,41,101,67,23,220,176,187,239,234,117,99,55,226,160,29,110,182,15,186,177,62,197,69,244,59,222,45,191,188,176,61,232,34,246,160,11,214,19,136,177,111,213,87,123,197,205,152,33,243,35,200,144,31,247,194,240,130,188,231,141,188,23,1,124,231,208,253,54,61,251,4,82,245,63,168,207,123,196,223,67,208,126,75,166,141,21,86,255,167,120,122,84,45,116,53,189,250,12,116,41,210,195,225,23,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("519549f0-c248-40b5-be93-602f4ff55bac"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1675f40-4a8b-469f-807f-482b441e6236"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8aacc82f-451e-44f0-a1ea-c48fac82b9aa"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a7cefdb-8943-464e-9818-f056350796f1"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a45be9e6-9a59-46ac-b1b7-9def07669d0c"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("6b161822-7e93-4124-b2d6-c1605b5f5657"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("97881864-f21d-4f49-b39f-662c780efdc9"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("83016a9c-a67e-4328-a96e-bfacfc2c77c6"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("a0d9ba4a-555e-4324-ae31-f59d0233fbc6"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("5b48e127-d50b-49a3-8459-4a9a52bf6988"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("6ef7572f-4836-4cfe-ad97-3868281a4281"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("ce2e72d3-d7a5-4f50-9ecf-44b4bf27b6ea"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("98faeefc-cf3f-4be3-a9b9-40bd344629d3"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("e75f4ff2-ebaa-43f4-aff7-36f8fa2f00cd"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a5f9685-0340-43a4-85bd-917ac7f8b75a"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a757dc8-11a2-46d0-962c-01dc9f7cf05c"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("d1a04b45-329c-4e0c-90b8-b7463582c944"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("822209b4-c7f7-4d36-9ddf-32a904b93bda"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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

		protected virtual void InitializeChangeLeadContactPhoneParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("cfc1a8ae-2a77-49bb-a728-a1637ee8c94a"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5feb2bce-5433-4c25-a83d-3f8d28ccc8ab"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9acd36f8-ce89-4f92-bdb8-e4eea778daf4"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,201,110,219,48,16,253,23,157,195,64,251,226,91,145,186,69,128,162,9,16,35,151,42,135,17,57,146,137,106,3,73,165,117,13,255,123,135,146,172,58,133,139,184,189,52,186,136,124,120,124,243,102,219,59,188,6,173,63,67,131,206,202,217,160,82,160,187,210,92,127,144,181,65,245,81,117,67,239,92,57,26,149,132,90,254,64,49,225,107,33,205,123,48,64,79,246,249,47,133,220,89,229,231,53,114,231,42,119,164,193,70,19,199,62,137,35,207,245,124,96,169,39,60,22,22,194,103,25,102,116,77,146,64,132,34,206,10,224,51,243,15,226,55,93,211,131,194,41,198,40,95,142,199,205,174,183,84,143,0,62,82,164,238,218,25,12,172,9,189,110,161,168,81,208,221,168,1,9,50,74,54,148,13,110,100,131,247,160,40,150,213,233,44,68,164,18,106,109,89,53,150,102,253,189,87,168,181,236,218,215,204,213,67,211,158,178,73,0,151,235,108,199,29,61,90,230,61,152,237,40,113,75,182,14,163,203,119,85,165,176,2,35,159,79,77,124,197,221,200,187,172,126,244,64,80,151,30,161,30,240,36,230,203,76,110,160,55,83,66,83,120,34,40,89,109,47,206,117,169,216,107,233,250,4,246,71,242,133,154,103,115,240,99,2,159,45,48,169,28,143,185,243,229,86,223,125,107,81,61,240,45,54,48,85,237,233,154,208,223,128,69,127,181,247,2,215,45,162,0,153,159,197,156,133,105,148,178,52,136,83,22,102,1,8,238,71,144,132,252,240,52,249,144,186,175,97,247,184,132,251,132,32,230,146,217,31,33,81,26,23,156,158,48,79,4,212,151,82,20,12,16,19,230,11,207,11,203,36,224,126,86,82,135,237,103,27,209,85,146,67,125,215,163,130,185,7,238,249,17,125,49,219,54,125,213,117,102,74,106,41,159,117,51,122,57,14,73,192,139,194,13,162,136,65,226,39,44,20,60,97,148,105,204,162,40,2,215,139,5,162,176,227,70,251,109,43,252,208,13,138,207,251,164,167,197,254,167,133,253,15,107,248,55,155,117,118,182,47,153,213,183,50,133,111,102,210,14,206,225,39,8,233,7,64,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15555f52-d536-4815-a506-977a98d2f0f3"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,16,253,21,70,201,209,242,0,18,66,226,154,164,51,158,73,218,76,146,230,18,251,176,146,86,9,51,24,60,32,183,227,50,252,123,5,182,147,216,109,79,213,1,208,106,223,219,221,199,83,79,46,253,110,131,164,32,79,216,182,208,53,206,207,175,154,22,231,247,109,99,176,235,230,183,141,129,170,252,5,186,194,123,104,97,141,30,219,103,168,182,216,221,150,157,159,69,167,48,50,35,151,63,166,83,82,188,244,100,225,113,253,125,97,3,59,119,185,114,194,74,42,56,179,148,107,149,82,41,164,164,104,19,163,132,86,26,156,12,96,211,84,219,117,125,135,30,238,193,191,145,162,39,19,91,32,0,203,85,108,51,73,227,140,3,229,86,102,84,165,92,80,107,37,23,2,53,83,146,145,97,70,58,243,134,107,152,138,126,128,121,18,232,21,42,154,103,177,166,28,181,166,210,128,161,206,49,165,5,151,60,65,51,130,15,249,31,192,151,139,151,69,247,237,103,141,237,227,196,91,56,168,58,92,205,67,244,44,112,83,225,26,107,95,244,9,67,29,231,156,209,212,101,9,229,82,112,170,92,134,161,209,148,199,160,165,69,157,14,1,240,174,102,209,171,92,202,100,76,116,105,18,196,113,92,209,48,143,163,66,164,38,151,49,58,107,212,8,185,169,125,233,119,87,147,70,69,15,24,35,207,12,80,195,85,22,80,152,83,96,202,82,6,58,79,115,137,137,72,242,97,117,177,26,7,179,101,183,169,96,247,252,231,124,15,8,54,50,77,237,202,118,141,211,151,7,227,187,72,239,162,106,60,218,188,53,53,118,243,47,101,219,249,168,12,255,51,106,92,212,98,183,173,124,89,191,134,252,170,66,227,203,166,158,47,236,190,214,230,196,38,159,171,245,203,189,219,150,164,88,254,203,111,135,247,94,221,83,199,157,155,109,73,102,75,242,216,108,91,51,50,178,176,185,254,52,230,84,100,74,57,219,30,221,21,34,245,182,170,14,145,107,240,112,76,60,134,27,91,186,18,237,162,126,60,154,106,98,137,15,139,254,229,113,92,251,222,254,7,118,7,53,188,98,251,53,8,240,209,251,123,151,79,65,198,35,177,78,85,22,231,137,163,57,130,10,238,22,225,110,217,4,168,74,148,118,44,103,169,115,233,132,126,64,135,45,214,6,79,27,75,132,70,38,130,89,165,195,148,242,36,83,1,111,99,10,50,102,150,11,201,172,101,7,124,55,169,61,94,235,67,95,163,84,3,25,134,213,240,27,159,253,156,215,74,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("3719e46d-8e08-48ad-8083-1ccf953996c6"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("08550f59-4992-48fb-b252-df02ec268766"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44584732-acad-4754-bde4-a1b1cfd19199"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,77,111,155,64,16,253,47,156,179,17,222,15,12,190,85,169,91,69,170,154,72,177,114,41,57,12,236,96,175,10,6,237,174,211,186,150,255,123,103,193,166,78,229,42,110,47,13,23,224,233,237,155,55,179,111,118,81,89,131,115,159,161,193,104,22,45,208,90,112,109,229,175,63,152,218,163,253,104,219,77,23,93,69,14,173,129,218,252,64,61,224,115,109,252,123,240,64,71,118,249,47,133,60,154,229,231,53,242,232,42,143,140,199,198,17,135,142,84,83,40,132,230,138,65,146,112,38,49,153,50,40,17,216,36,137,185,146,124,42,5,20,3,243,79,226,55,109,211,129,197,161,70,47,95,245,159,139,109,23,168,19,2,202,158,98,92,187,62,128,34,152,112,243,53,20,53,106,250,247,118,131,4,121,107,26,234,6,23,166,193,123,176,84,43,232,180,1,34,82,5,181,11,172,26,43,63,255,222,89,116,206,180,235,215,204,213,155,102,125,202,38,1,28,127,15,118,226,222,99,96,222,131,95,245,18,183,100,107,223,187,124,183,92,90,92,130,55,207,167,38,190,226,182,231,93,54,63,58,160,233,150,30,161,222,224,73,205,151,157,220,64,231,135,134,134,242,68,176,102,185,186,184,215,113,98,175,181,203,9,236,142,228,11,53,207,246,192,19,2,159,3,48,168,28,63,243,232,203,173,187,251,182,70,251,80,174,176,129,97,106,79,215,132,254,6,140,250,179,221,68,196,113,161,4,50,158,37,37,147,169,74,89,42,146,148,201,76,128,46,185,130,169,44,247,79,131,15,227,186,26,182,143,99,185,79,8,250,48,178,240,34,164,0,5,42,147,5,83,89,165,152,84,105,198,10,57,33,181,42,141,85,44,65,196,42,220,112,120,194,69,180,75,83,66,125,215,161,133,195,29,196,231,35,250,34,219,161,125,219,182,126,104,106,28,95,112,211,123,57,134,68,203,66,199,83,46,152,170,148,166,144,0,197,133,103,130,113,45,176,210,105,166,164,12,102,104,191,195,132,31,218,141,45,15,251,228,134,197,254,167,133,253,15,107,248,55,155,117,54,219,151,100,245,173,164,240,205,36,109,31,237,127,2,5,14,193,196,62,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("33aca163-6ecf-4e71-9484-09432fbc4746"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,203,110,219,48,16,252,21,129,201,209,52,40,241,33,81,183,34,233,193,64,210,6,117,146,75,236,195,146,92,54,2,244,8,40,185,69,106,232,223,75,203,118,28,167,237,169,60,72,218,229,206,236,112,53,220,146,203,225,245,5,73,73,238,49,4,232,59,63,204,175,186,128,243,187,208,89,236,251,249,77,103,161,174,126,129,169,241,14,2,52,56,96,120,132,122,131,253,77,213,15,179,228,28,70,102,228,242,199,180,75,202,167,45,89,12,216,60,44,92,100,87,50,83,78,230,154,114,233,44,21,40,44,5,76,61,101,220,243,204,74,147,59,41,34,216,118,245,166,105,111,113,128,59,24,158,73,185,37,19,91,36,0,39,52,115,178,160,76,10,160,194,21,146,234,76,40,234,92,33,148,66,195,117,193,201,56,35,189,125,198,6,166,166,39,176,72,193,23,26,53,205,37,51,177,187,49,180,176,96,169,247,92,27,37,10,145,162,221,129,15,245,39,224,211,197,211,162,255,250,179,197,176,156,120,75,15,117,143,235,121,204,126,72,124,174,177,193,118,40,183,187,86,44,115,154,106,159,113,42,50,166,168,209,22,227,113,153,97,76,50,7,26,199,8,120,155,102,185,205,115,40,152,151,138,10,163,24,21,133,177,212,96,150,83,212,202,123,39,172,149,218,140,235,139,245,78,162,171,250,151,26,94,31,255,84,250,201,185,100,211,218,174,245,85,104,208,37,241,107,0,59,36,6,250,24,117,109,82,35,184,164,106,125,23,26,24,170,174,157,95,5,132,33,238,5,180,93,112,201,194,237,91,188,156,253,231,247,77,182,171,189,93,86,164,92,253,203,48,135,247,126,60,231,150,249,232,150,21,153,173,200,178,219,4,187,99,228,49,184,126,119,186,169,201,84,242,33,60,218,35,102,218,77,93,31,50,215,48,192,177,240,152,238,92,229,43,116,139,118,121,116,197,196,194,14,139,254,229,113,92,123,109,255,3,187,133,22,190,99,248,18,7,112,210,254,166,242,62,142,241,72,108,50,45,89,30,111,67,142,160,163,61,85,70,11,151,2,213,169,54,158,231,60,243,62,155,208,223,208,99,192,214,226,185,176,84,25,228,74,166,180,240,152,81,145,74,29,241,142,209,232,42,238,132,42,184,115,252,128,239,167,105,239,238,229,65,215,110,84,35,25,199,245,248,27,101,185,213,237,11,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadLandingPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd3fabe0-1945-4d5e-9fb8-9e85ee54cc3b"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,208,147,162,124,43,82,39,8,80,52,65,19,164,135,58,135,21,185,84,136,234,5,138,78,235,26,254,247,46,37,199,77,10,23,113,123,105,129,234,32,72,131,217,225,236,139,155,64,214,48,12,239,161,193,96,30,220,162,181,48,116,218,157,158,155,218,161,189,176,221,170,15,78,130,1,173,129,218,124,67,53,225,11,101,220,91,112,64,33,155,229,15,133,101,48,95,30,214,88,6,39,203,192,56,108,6,226,80,8,104,153,149,82,32,139,85,166,88,170,242,152,65,153,23,44,147,37,34,134,161,46,35,156,152,191,18,63,235,154,30,44,78,103,140,242,122,252,188,93,247,158,26,17,32,71,138,25,186,118,7,38,222,196,176,104,161,172,81,209,191,179,43,36,200,89,211,80,54,120,107,26,188,6,75,103,121,157,206,67,68,210,80,15,158,85,163,118,139,175,189,197,97,48,93,251,154,185,122,213,180,207,217,36,128,251,223,157,157,112,244,232,153,215,224,30,70,137,75,178,181,29,93,190,169,42,139,21,56,243,248,220,196,103,92,143,188,227,234,71,1,138,186,116,7,245,10,159,157,249,50,147,51,232,221,148,208,116,60,17,172,169,30,142,206,117,95,177,215,210,141,9,236,159,200,71,106,30,204,33,230,4,62,122,96,82,121,250,92,6,159,46,135,171,47,45,218,27,249,128,13,76,85,187,63,37,244,39,96,81,99,131,173,155,111,32,5,174,117,40,89,20,21,154,165,60,137,24,136,56,102,92,164,105,152,115,129,5,102,91,10,216,27,154,111,184,44,68,90,240,156,9,8,115,42,61,207,24,160,150,44,141,4,102,16,69,82,73,229,67,22,173,51,110,61,77,194,124,83,36,162,80,177,40,24,79,4,103,169,160,128,162,84,25,139,101,38,242,56,73,98,206,227,237,253,148,174,25,250,26,214,119,251,172,62,32,168,89,77,47,218,40,59,184,153,223,163,89,167,103,84,222,85,237,76,91,205,104,138,106,148,190,141,167,239,160,85,30,234,161,154,38,192,247,148,68,116,20,114,46,57,50,29,150,200,210,60,225,76,168,60,98,121,132,97,153,151,28,19,205,105,246,252,227,71,164,171,140,132,250,170,71,11,187,233,8,15,47,207,139,173,243,141,177,93,231,166,114,239,27,123,129,173,215,65,245,17,203,243,206,54,163,175,167,81,166,170,0,79,116,198,144,135,33,85,70,134,12,36,53,67,132,41,10,157,69,18,121,70,198,232,22,242,115,112,211,173,172,220,109,253,48,93,63,127,116,173,252,133,203,226,119,246,255,224,6,30,179,81,255,217,174,252,147,195,189,13,182,223,1,65,118,3,35,87,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c84ed90e-913c-4d79-be6e-0aeb6dbde695"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("528b68b1-c488-499b-b6a9-98d627973317"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7db9bc2b-3431-4feb-8af1-b2fcbc5cf552"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50c50a69-929a-4ae1-8501-1657483ac91c"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a09f02d-d645-448c-a427-3dc0ad363ad0"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("2793b917-606e-429f-8d6b-56caf9a5d36b"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				UId = new Guid("a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0010511-9818-4608-8cc6-966c057c7fb7"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("5ce1ad73-33d5-4d54-99dc-103fe2185918"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("f1d51e05-81e8-439e-be55-ef17ce69d451"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("5400d0e0-9171-4da4-9833-ee4bc440d882"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("fe6f5c9f-37df-4b0d-b855-65847152e915"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("ec12f3b9-746c-4f92-ba49-ce658079412a"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				UId = new Guid("6dc416c9-504c-4429-b04e-93f543f173c4"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b66e4485-d571-44cb-9e32-b832c83541ca"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c52f53d-1e03-445c-bcbe-0982a59c336a"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("aadf92c2-302e-499d-a17e-33c74ef006bd"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("b3f6ea08-bb3d-48ff-bb96-9f7e3530b585"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
			ProcessSchemaLaneSet schemaLeadIdentificationProcess = CreateLeadIdentificationProcessLaneSet();
			LaneSets.Add(schemaLeadIdentificationProcess);
			ProcessSchemaLane schemaLeadIdentification = CreateLeadIdentificationLane();
			schemaLeadIdentificationProcess.Lanes.Add(schemaLeadIdentification);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent leadisidentified = CreateLeadIsIdentifiedTerminateEvent();
			FlowElements.Add(leadisidentified);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaExclusiveGateway exclusiveleadhascommunication = CreateExclusiveLeadHasCommunicationExclusiveGateway();
			FlowElements.Add(exclusiveleadhascommunication);
			ProcessSchemaTerminateEvent leaddisqualified = CreateLeadDisqualifiedTerminateEvent();
			FlowElements.Add(leaddisqualified);
			ProcessSchemaUserTask readcontactsbyleadcommunications = CreateReadContactsByLeadCommunicationsUserTask();
			FlowElements.Add(readcontactsbyleadcommunications);
			ProcessSchemaUserTask changeleadcontactall = CreateChangeLeadContactAllUserTask();
			FlowElements.Add(changeleadcontactall);
			ProcessSchemaUserTask addcontactbylead = CreateAddContactByLeadUserTask();
			FlowElements.Add(addcontactbylead);
			ProcessSchemaUserTask addcontactadress = CreateAddContactAdressUserTask();
			FlowElements.Add(addcontactadress);
			ProcessSchemaUserTask addcontactweb = CreateAddContactWebUserTask();
			FlowElements.Add(addcontactweb);
			ProcessSchemaParallelGateway parallelgatewayaddcontactcommunication = CreateParallelGatewayAddContactCommunicationParallelGateway();
			FlowElements.Add(parallelgatewayaddcontactcommunication);
			ProcessSchemaParallelGateway parallelgateway1 = CreateParallelGateway1ParallelGateway();
			FlowElements.Add(parallelgateway1);
			ProcessSchemaUserTask readcontactsbyleademail = CreateReadContactsByLeadEmailUserTask();
			FlowElements.Add(readcontactsbyleademail);
			ProcessSchemaUserTask changeleadcontactemail = CreateChangeLeadContactEmailUserTask();
			FlowElements.Add(changeleadcontactemail);
			ProcessSchemaExclusiveGateway exclusiveinleadcommunication = CreateExclusiveInLeadCommunicationExclusiveGateway();
			FlowElements.Add(exclusiveinleadcommunication);
			ProcessSchemaUserTask readcontactsbyleadphone = CreateReadContactsByLeadPhoneUserTask();
			FlowElements.Add(readcontactsbyleadphone);
			ProcessSchemaUserTask changeleadcontactphone = CreateChangeLeadContactPhoneUserTask();
			FlowElements.Add(changeleadcontactphone);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaScriptTask actionafteridentificationscripttask = CreateActionAfterIdentificationScriptTaskScriptTask();
			FlowElements.Add(actionafteridentificationscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readlandingpage = CreateReadLandingPageUserTask();
			FlowElements.Add(readlandingpage);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			FlowElements.Add(CreateContactFoundAllConditionalFlow());
			FlowElements.Add(CreateContactNotFoundAllSequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateConditionalFlowCommunicationAllConditionalFlow());
			FlowElements.Add(CreateConditionalFlowEmailOnlyConditionalFlow());
			FlowElements.Add(CreateContactFoundEmailConditionalFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateConditionalFlowPhonesOnlyConditionalFlow());
			FlowElements.Add(CreateCntactFoundPhoneConditionalFlow());
			FlowElements.Add(CreateContactNotFoundEmailSequenceFlow());
			FlowElements.Add(CreateContactNotFoundPhoneSequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateSequenceFlowLeadReadSequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateIsNotFromLandingFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateDontContactFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaConditionalFlow CreateContactFoundAllConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContactFoundAll",
				UId = new Guid("e86cf8b0-28a2-4a9b-b145-adf2cced025e"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{55827a3c-5bec-4f5a-bf98-793768421b33}].[Parameter:{10568b26-1c18-4f39-9578-4a72a1c5fb66}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(743, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundAllSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundAll",
				UId = new Guid("de6d680f-d07c-44e0-bad0-0e782cd4ab9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(663, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("685ffe7e-d19d-424d-af66-eab647e50e57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(827, 406),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("ac04a55d-ac74-402d-bd4c-e1838bf4708c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(942, 299),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("520f849c-7cf5-482e-8278-85ac18ec9297"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(952, 407),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(977, 505));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("18317a84-4d39-4605-b176-feb243f51a99"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1086, 544),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("f6a451c0-89fd-4ccc-ab61-d3c20b1a0644"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1086, 594),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1222, 505));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("09a82fde-8ba3-4a5d-9cc0-6aecd8a4bd9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1165, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("7441390e-adc4-42b8-a095-363e9352da36"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1012, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 71));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowCommunicationAllConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowCommunicationAll",
				UId = new Guid("146a48af-ec3c-47df-b53d-49db5dfca733"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] != String.Empty && ([#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] != String.Empty || [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] != String.Empty)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(564, 112),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(560, 71));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowEmailOnlyConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowEmailOnly",
				UId = new Guid("94e08796-33d0-450f-a94d-43d4d8c7e5b4"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] != String.Empty && [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] == String.Empty && [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] == String.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(568, 220),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateContactFoundEmailConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContactFoundEmail",
				UId = new Guid("8ad3bb27-05b3-4197-85fe-9fca6ddb677c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e02e7808-8729-4c97-b907-1487f2e17278}].[Parameter:{4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(672, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("d616bcad-397a-4fb0-9ad7-a6b4eecacb7a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1082, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1120, 189));
			schemaFlow.PolylinePointPositions.Add(new Point(1120, 190));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("04aca506-6521-4495-8b71-07a6e4990984"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1288, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowPhonesOnlyConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowPhonesOnly",
				UId = new Guid("421b74c1-62c2-430b-965d-8d776c88a27f"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] == String.Empty && ([#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] != String.Empty || [#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] != String.Empty)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(465, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(626, 189));
			schemaFlow.PolylinePointPositions.Add(new Point(626, 302));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateCntactFoundPhoneConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "CntactFoundPhone",
				UId = new Guid("9bfd01fc-78f4-4b49-a5a3-0359fc93fab2"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{13eb0743-2f51-4864-9f5e-dd240ab8deb2}].[Parameter:{97881864-f21d-4f49-b39f-662c780efdc9}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(668, 412),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundEmailSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundEmail",
				UId = new Guid("42aea126-6049-4745-ad69-161540c3e406"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(670, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				SourceSequenceFlowPointLocalPosition = new Point(1, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(734, 414));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundPhoneSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundPhone",
				UId = new Guid("df707572-c541-4e4e-862e-378909dd23f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(670, 438),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(700, 414));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("4d08fda8-cd6a-41a3-93c1-ea29843a1dd8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1004, 269),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 302));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("730e6ac4-b34e-4059-a3b7-fdb00cfe6b88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(130, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("d51e9369-1e01-464b-b9e0-a5a76570f27f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1295, 314),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 414));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowLeadDefined",
				UId = new Guid("809c0113-c2cd-4fc6-81a2-709589e406ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(322, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadReadSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowLeadRead",
				UId = new Guid("39aa9aa5-0e89-45d2-ab91-45a36ea7120a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(393, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(241, 190));
			schemaFlow.PolylinePointPositions.Add(new Point(241, 189));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("86bf0460-da87-44e8-9e19-16d6bb74396c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{1300b53e-296c-4858-8368-493adc25a74c}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(468, 408),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(100, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("820777f0-a887-4f88-bf50-9a94194c500e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1423, 214),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsNotFromLandingFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsNotFromLandingFlow",
				UId = new Guid("b15dccc1-cb8b-4db6-9245-c999d8b93476"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{9389d289-6386-48fc-9bd5-2c5872332662}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(282, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("20f61163-eea7-47a5-b9f2-2e0896ee1530"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateDontContactFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "DontContactFlow",
				UId = new Guid("6e54dca1-2410-4933-8d29-b9c06c6eb9c5"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{17eaa635-03e6-4644-8e7d-7a81a8f837a6}].[Parameter:{a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76}].[EntityColumn:{7e336bc1-838f-48c6-a4d7-6f5bb3930bb2}]#] == false",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(471, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("d4060814-2d0d-4e64-93e2-903d9f427c42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(560, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("ba39820c-a979-4d6a-9f26-dab9940fce00"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("704f89d9-2ad0-404e-8ce3-94ce9f308188"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadIdentificationProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadIdentificationProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bc24ba6a-fa71-49d5-8e0e-37de1a155822"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIdentificationProcess",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLeadIdentificationProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadIdentificationLane() {
			ProcessSchemaLane schemaLeadIdentification = new ProcessSchemaLane(this) {
				UId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bc24ba6a-fa71-49d5-8e0e-37de1a155822"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIdentification",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLeadIdentification;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"Start",
				Position = new Point(20, 176),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateLeadIsIdentifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIsIdentified",
				Position = new Point(1593, 176),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadLeadData",
				Position = new Point(160, 162),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveLeadHasCommunicationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveLeadHasCommunication",
				Position = new Point(532, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateLeadDisqualifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadDisqualified",
				Position = new Point(722, 576),
				SerializeToDB = false,
				Size = new Size(31, 31),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadCommunicationsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadCommunications",
				Position = new Point(665, 43),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadContactsByLeadCommunicationsParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactAllUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactAll",
				Position = new Point(823, 43),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadContactAllParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactByLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactByLead",
				Position = new Point(830, 386),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddContactByLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactAdressUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactAdress",
				Position = new Point(1068, 477),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddContactAdressParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactWebUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactWeb",
				Position = new Point(1068, 386),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddContactWebParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGatewayAddContactCommunicationParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ParallelGatewayAddContactCommunication",
				Position = new Point(949, 386),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ParallelGateway1",
				Position = new Point(1194, 386),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadEmailUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadEmail",
				Position = new Point(665, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadContactsByLeadEmailParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactEmailUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactEmail",
				Position = new Point(823, 161),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadContactEmailParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveInLeadCommunicationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveInLeadCommunication",
				Position = new Point(1348, 162),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadPhoneUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadPhone",
				Position = new Point(665, 274),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadContactsByLeadPhoneParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactPhoneUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactPhone",
				Position = new Point(823, 274),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadContactPhoneParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(1285, 386),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGatewayIsLeadSet",
				Position = new Point(72, 162),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateActionAfterIdentificationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ActionAfterIdentificationScriptTask",
				Position = new Point(1451, 162),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,201,204,207,115,76,43,73,45,242,76,73,205,43,201,76,203,76,78,4,9,105,104,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,0,140,232,210,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGateway1",
				Position = new Point(254, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadLandingPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadLandingPage",
				Position = new Point(340, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLandingPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGateway2",
				Position = new Point(443, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10509a8f-ce1f-49d4-9a6e-2dbe803346be"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5d1dacad-ecaf-4a19-8976-6e14d8694860"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementIdentification(userConnection);
		}

		public override object Clone() {
			return new LeadManagementIdentificationSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50c67976-474a-4cfb-b066-5ca727be0505"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementIdentification

	/// <exclude/>
	public class LeadManagementIdentification : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadIdentification

		/// <exclude/>
		public class ProcessLeadIdentification : ProcessLane
		{

			public ProcessLeadIdentification(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,162,40,83,242,173,72,221,34,64,209,4,136,145,75,149,195,138,92,219,68,37,75,32,233,180,174,225,127,239,82,178,85,167,112,17,183,151,70,23,145,131,225,236,236,107,23,169,26,156,251,12,13,70,211,104,142,214,130,107,23,254,250,131,169,61,218,143,182,221,116,209,85,228,208,26,168,205,15,212,3,62,211,198,191,7,15,244,100,87,254,82,40,163,105,121,94,163,140,174,202,200,120,108,28,113,232,137,72,43,20,121,12,12,19,21,51,161,164,96,185,150,192,98,153,232,34,225,60,206,85,58,48,255,36,126,211,54,29,88,28,98,244,242,139,254,56,223,118,129,154,16,160,122,138,113,237,250,0,166,193,132,155,173,161,170,81,211,221,219,13,18,228,173,105,40,27,156,155,6,239,193,82,172,160,211,6,136,72,11,168,93,96,213,184,240,179,239,157,69,231,76,187,126,205,92,189,105,214,167,108,18,192,241,122,176,19,247,30,3,243,30,252,170,151,184,37,91,251,222,229,187,229,210,226,18,188,121,62,53,241,21,183,61,239,178,250,209,3,77,93,122,132,122,131,39,49,95,102,114,3,157,31,18,26,194,19,193,154,229,234,226,92,199,138,189,150,46,39,176,59,146,47,212,60,155,3,159,16,248,28,128,65,229,120,44,163,47,183,238,238,219,26,237,131,90,97,3,67,213,158,174,9,253,13,24,245,167,187,36,141,227,42,75,145,241,98,162,152,200,179,156,229,233,36,103,162,72,65,43,158,129,20,106,255,52,248,48,174,171,97,251,56,134,251,132,160,15,37,11,63,66,228,66,243,12,171,130,186,17,75,38,164,152,176,74,101,21,75,19,148,9,7,208,26,128,58,28,190,208,136,118,105,20,212,119,29,90,56,244,32,62,63,162,47,102,59,164,111,219,214,15,73,141,229,11,110,122,47,199,33,225,152,84,74,102,5,3,41,105,72,114,158,176,10,56,103,169,202,18,81,105,81,196,80,145,25,218,239,80,225,135,118,99,213,97,159,220,176,216,255,180,176,255,97,13,255,102,179,206,206,246,37,179,250,86,166,240,205,76,218,62,218,255,4,66,214,75,222,62,6,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })));
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
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
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

		#region Class: ReadContactsByLeadCommunicationsFlowElement

		/// <exclude/>
		public class ReadContactsByLeadCommunicationsFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadCommunicationsFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadCommunications";
				IsLogging = true;
				SchemaElementUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,75,115,219,70,12,254,43,26,157,218,25,175,103,223,220,245,173,117,213,78,14,77,50,141,39,151,216,135,125,96,109,78,41,81,67,82,105,92,143,255,123,65,82,150,237,68,86,24,213,174,21,87,58,112,100,24,11,2,216,15,216,15,171,171,113,40,92,93,191,118,83,24,31,141,79,160,170,92,93,166,230,240,215,188,104,160,250,173,42,23,243,241,193,184,134,42,119,69,254,55,196,94,62,137,121,243,139,107,28,46,185,58,189,181,112,58,62,58,93,111,227,116,124,112,58,206,27,152,214,168,131,75,52,165,142,130,6,162,64,91,34,99,82,196,139,168,8,139,38,243,49,25,97,124,234,53,31,50,62,249,148,215,77,221,191,162,179,158,186,175,39,151,243,86,83,161,32,148,211,185,171,242,186,156,45,133,172,149,230,245,100,230,124,1,17,5,77,181,0,20,53,85,62,197,104,224,36,159,194,91,87,225,187,90,67,101,43,66,165,228,138,186,213,42,32,53,147,79,243,10,234,58,47,103,155,157,59,46,139,197,116,118,87,27,13,192,234,207,165,63,180,115,178,213,124,235,154,139,206,196,135,227,114,214,184,208,28,151,211,233,98,150,7,215,160,250,209,82,120,118,248,10,189,190,238,130,248,233,252,188,130,115,252,247,71,184,13,228,79,184,236,172,12,203,46,46,136,184,135,239,93,177,128,59,30,221,143,243,216,205,155,62,220,211,241,210,141,81,184,235,220,168,236,20,70,63,248,203,81,31,204,104,169,247,99,247,138,122,225,251,77,170,55,167,108,3,88,168,76,82,187,144,17,47,25,39,82,183,225,112,173,9,11,156,113,3,160,156,23,95,219,143,22,10,240,16,90,216,58,180,136,157,7,203,235,197,212,183,225,172,67,196,141,35,55,144,24,150,195,53,144,224,102,35,38,110,124,64,165,42,63,191,24,28,244,42,117,95,139,155,163,112,126,163,60,208,230,250,64,52,10,63,182,130,222,202,205,87,44,186,87,245,155,191,102,80,189,11,23,48,117,125,234,206,14,81,250,153,96,82,192,20,102,205,209,149,147,78,167,68,3,97,204,38,76,166,96,196,25,206,137,54,82,210,76,27,176,160,174,113,193,202,161,163,43,29,172,145,86,103,196,56,154,97,73,106,69,28,164,64,36,51,152,123,198,66,12,177,93,50,153,53,121,115,217,67,226,232,42,1,8,30,13,35,25,112,73,164,19,146,88,134,155,40,168,17,32,163,180,194,164,235,179,62,220,188,158,23,238,242,253,42,170,63,192,197,81,129,15,44,173,170,110,70,109,65,141,202,52,194,244,46,138,38,159,157,183,229,90,64,104,183,242,112,50,117,121,209,217,105,91,12,174,6,19,124,82,138,18,6,41,18,73,177,153,24,208,156,80,193,50,41,32,33,128,16,47,215,248,193,53,76,91,158,89,163,9,120,141,249,240,50,16,103,129,17,74,209,109,207,25,75,144,109,222,186,87,179,135,106,83,126,159,181,121,175,129,247,106,67,202,116,88,38,215,160,155,109,110,221,189,214,151,69,218,118,216,15,59,85,166,93,32,119,202,244,6,143,192,130,81,65,144,144,130,39,49,49,70,172,231,14,19,195,162,166,128,133,16,116,103,111,245,194,91,72,223,86,250,96,43,95,84,211,210,26,226,253,172,131,124,81,158,227,230,22,111,230,80,185,101,150,233,122,80,222,67,115,219,131,170,178,108,250,206,178,242,117,221,169,223,249,177,106,223,209,112,21,168,37,209,81,108,223,82,100,196,74,132,9,179,224,132,98,145,43,217,82,131,214,179,24,4,11,66,68,226,141,82,88,185,150,19,71,5,16,234,121,80,134,57,239,156,220,83,171,109,169,213,176,236,126,55,212,42,5,129,231,18,88,162,157,166,45,45,72,196,51,105,137,0,227,84,138,9,233,98,216,222,184,240,34,51,49,35,89,82,190,5,173,32,216,213,12,9,26,172,4,17,162,209,176,231,109,155,15,132,97,57,220,243,182,221,226,109,146,38,72,44,90,146,44,62,36,151,26,143,113,154,136,48,22,184,210,206,133,40,31,133,183,253,94,250,188,128,209,252,162,156,193,93,250,166,19,21,154,227,27,33,82,36,142,212,99,164,28,123,149,228,38,242,246,27,150,247,138,190,121,154,152,50,201,17,165,61,122,171,192,19,31,145,111,226,33,233,4,77,26,65,22,247,117,186,185,78,135,229,112,95,167,187,85,167,22,71,42,103,148,32,20,199,29,34,141,74,196,216,36,9,51,220,100,88,34,206,129,127,148,58,253,121,81,231,51,204,251,151,149,170,50,107,133,215,140,40,108,243,68,90,99,137,7,45,177,92,133,149,10,63,50,196,190,82,31,160,157,236,9,105,231,48,122,208,58,38,45,82,33,239,29,17,146,33,254,33,80,156,23,241,17,176,28,76,116,206,105,171,30,117,4,148,59,223,62,182,28,1,135,101,114,63,2,254,223,70,192,36,147,113,94,40,146,217,12,27,69,22,2,54,69,73,9,55,56,4,234,200,44,83,169,243,238,169,92,187,231,77,160,90,219,140,11,18,51,133,180,194,35,64,157,103,158,32,191,113,128,141,65,242,144,161,55,227,131,110,119,223,149,139,42,44,233,65,221,255,104,176,213,143,1,207,49,136,62,226,108,249,249,192,182,213,29,247,51,48,171,111,37,75,107,153,202,144,126,241,18,56,197,139,187,179,125,134,235,216,127,113,188,62,112,186,109,131,190,123,231,208,208,147,227,191,60,29,190,241,190,239,229,118,207,225,215,88,91,93,79,237,91,238,110,183,220,151,122,221,178,199,221,110,227,110,127,125,176,238,80,250,166,219,128,103,24,244,247,228,98,32,185,120,194,73,242,122,124,253,15,149,133,232,176,122,38,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })));
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
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
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

		#region Class: ChangeLeadContactAllFlowElement

		/// <exclude/>
		public class ChangeLeadContactAllFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactAllFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactAll";
				IsLogging = true;
				SchemaElementUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,93,111,155,48,20,253,47,60,215,21,96,8,144,183,169,203,166,74,211,90,169,81,95,70,31,174,237,75,98,13,2,178,157,110,89,148,255,190,107,32,44,157,50,53,219,203,202,3,152,163,227,115,207,253,218,7,178,6,107,63,67,131,193,60,88,162,49,96,219,202,93,127,208,181,67,243,209,180,219,46,184,10,44,26,13,181,254,129,106,192,23,74,187,247,224,128,174,236,203,95,10,101,48,47,207,107,148,193,85,25,104,135,141,37,14,93,17,2,35,153,85,138,73,201,11,150,200,48,103,69,150,10,134,0,32,132,74,185,4,62,48,255,36,126,211,54,29,24,28,98,244,242,85,127,92,238,58,79,141,8,144,61,69,219,118,51,130,220,155,176,139,13,136,26,21,253,59,179,69,130,156,209,13,101,131,75,221,224,61,24,138,229,117,90,15,17,169,130,218,122,86,141,149,91,124,239,12,90,171,219,205,107,230,234,109,179,57,101,147,0,78,191,163,157,176,247,232,153,247,224,214,189,196,45,217,58,244,46,223,173,86,6,87,224,244,243,169,137,175,184,235,121,151,213,143,46,40,234,210,35,212,91,60,137,249,50,147,27,232,220,144,208,16,158,8,70,175,214,23,231,58,85,236,181,116,99,2,187,35,249,66,205,179,57,196,51,2,159,61,48,168,28,143,101,240,229,214,222,125,219,160,121,144,107,108,96,168,218,211,53,161,191,1,147,254,124,31,241,48,20,41,71,22,23,51,201,146,60,205,89,206,103,57,75,10,14,74,198,41,100,137,60,60,13,62,180,237,106,216,61,78,225,62,33,168,177,100,254,67,72,21,23,66,228,97,194,162,144,199,44,81,72,125,41,162,148,137,34,205,147,162,10,69,85,69,212,97,255,248,70,180,43,45,161,190,235,208,192,216,131,240,252,136,190,152,109,159,190,105,91,55,36,53,149,207,187,233,189,28,135,4,68,22,115,65,209,179,2,66,150,164,42,97,144,209,171,152,225,44,22,228,19,148,31,55,218,111,95,225,135,118,107,228,184,79,118,88,236,127,90,216,255,176,134,127,179,89,103,103,251,146,89,125,43,83,248,102,38,237,16,28,126,2,4,255,142,248,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,83,219,48,16,253,43,30,193,49,202,88,214,135,37,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,59,99,43,237,208,76,254,123,21,39,1,66,219,83,117,176,165,213,190,183,187,207,207,27,114,30,95,87,72,42,242,128,125,15,67,23,226,244,162,235,113,122,219,119,14,135,97,122,221,57,104,234,95,96,27,188,133,30,150,24,177,127,132,102,141,195,117,61,196,73,118,10,35,19,114,254,99,188,37,213,211,134,204,34,46,191,207,124,98,47,181,65,225,138,130,218,160,25,21,121,238,169,78,33,42,180,194,80,50,163,188,100,9,236,186,102,189,108,111,48,194,45,196,23,82,109,200,200,150,8,192,11,147,123,169,105,46,5,80,225,181,164,166,16,138,122,175,133,82,104,185,209,156,108,39,100,112,47,184,132,177,232,59,88,48,8,169,154,161,165,204,45,21,104,45,213,14,28,13,129,27,171,132,22,12,221,14,124,200,127,7,62,157,61,205,134,111,63,91,236,239,71,222,42,64,51,224,98,154,162,159,2,87,13,46,177,141,213,70,74,93,148,192,29,149,22,29,21,65,66,154,217,104,90,26,94,42,45,10,102,57,223,38,192,155,154,213,134,229,82,105,91,40,202,28,211,9,194,13,53,178,76,59,40,11,96,78,6,171,212,14,114,213,198,58,190,94,140,26,85,27,192,28,133,116,64,157,48,50,161,176,164,192,141,167,28,108,89,148,26,153,98,229,118,113,182,216,13,230,235,97,213,192,235,227,159,243,221,33,248,204,117,109,168,251,37,142,187,8,46,14,153,125,205,154,221,85,154,177,110,50,104,125,182,122,233,90,28,166,95,234,126,136,89,157,190,108,214,133,172,199,97,221,196,186,125,78,200,166,65,23,235,174,157,206,252,190,234,234,196,48,31,235,110,230,123,223,205,73,53,255,151,243,14,239,189,206,167,222,251,108,187,57,153,204,201,125,183,238,221,142,145,167,195,229,135,129,199,34,99,202,167,227,209,103,41,210,174,155,230,16,185,132,8,199,196,99,184,243,117,168,209,207,218,251,163,189,70,150,252,176,232,95,30,199,181,239,237,127,96,55,208,194,51,246,95,147,0,239,189,191,117,249,144,100,60,18,219,194,200,188,100,129,150,8,38,249,92,21,84,123,6,212,48,99,3,47,121,17,66,49,162,239,48,96,143,173,195,211,198,152,178,200,149,100,84,7,44,168,96,210,36,188,207,41,232,156,123,161,52,247,158,31,240,195,168,246,238,7,63,244,181,147,106,75,182,219,197,246,55,23,17,232,91,84,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactAll.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: AddContactByLeadFlowElement

		/// <exclude/>
		public class AddContactByLeadFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactByLeadFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactByLead";
				IsLogging = true;
				SchemaElementUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Name = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null)) : (((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) : (((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) : ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)))));
				_recordDefValues_JobTitle = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("FullJobTitle").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("FullJobTitle") : null)));
				_recordDefValues_Dear = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Dear").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Dear") : null)));
				_recordDefValues_Department = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Department").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DepartmentId") : Guid.Empty)));
				_recordDefValues_Job = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Job").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("JobId") : Guid.Empty)));
				_recordDefValues_DoNotUseEmail = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseEmail").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseEmail") : false)));
				_recordDefValues_DoNotUseSms = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseSMS").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseSMS") : false)));
				_recordDefValues_DoNotUseMail = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseMail").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseMail") : false)));
				_recordDefValues_DoNotUseCall = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUsePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUsePhone") : false)));
				_recordDefValues_DoNotUseFax = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseFax").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseFax") : false)));
				_recordDefValues_Confirmed = () => (bool)(false);
				_recordDefValues_SalutationType = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("TitleId") : Guid.Empty)));
				_recordDefValues_Gender = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Gender").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("GenderId") : Guid.Empty)));
				_recordDefValues_DecisionRole = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DecisionRole").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DecisionRoleId") : Guid.Empty)));
				_recordDefValues_Email = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_recordDefValues_MobilePhone = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)));
				_recordDefValues_Phone = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Name", () => _recordDefValues_Name.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_JobTitle", () => _recordDefValues_JobTitle.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Dear", () => _recordDefValues_Dear.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Department", () => _recordDefValues_Department.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Job", () => _recordDefValues_Job.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseEmail", () => _recordDefValues_DoNotUseEmail.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseSms", () => _recordDefValues_DoNotUseSms.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseMail", () => _recordDefValues_DoNotUseMail.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseCall", () => _recordDefValues_DoNotUseCall.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseFax", () => _recordDefValues_DoNotUseFax.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Confirmed", () => _recordDefValues_Confirmed.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SalutationType", () => _recordDefValues_SalutationType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Gender", () => _recordDefValues_Gender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DecisionRole", () => _recordDefValues_DecisionRole.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Email", () => _recordDefValues_Email.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MobilePhone", () => _recordDefValues_MobilePhone.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Phone", () => _recordDefValues_Phone.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Name;
			internal Func<string> _recordDefValues_JobTitle;
			internal Func<string> _recordDefValues_Dear;
			internal Func<Guid> _recordDefValues_Department;
			internal Func<Guid> _recordDefValues_Job;
			internal Func<bool> _recordDefValues_DoNotUseEmail;
			internal Func<bool> _recordDefValues_DoNotUseSms;
			internal Func<bool> _recordDefValues_DoNotUseMail;
			internal Func<bool> _recordDefValues_DoNotUseCall;
			internal Func<bool> _recordDefValues_DoNotUseFax;
			internal Func<bool> _recordDefValues_Confirmed;
			internal Func<Guid> _recordDefValues_SalutationType;
			internal Func<Guid> _recordDefValues_Gender;
			internal Func<Guid> _recordDefValues_DecisionRole;
			internal Func<string> _recordDefValues_Email;
			internal Func<string> _recordDefValues_MobilePhone;
			internal Func<string> _recordDefValues_Phone;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,0,0,33,223,219,244,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,155,107,111,91,199,17,134,255,10,203,4,104,3,120,140,189,95,8,20,5,154,56,133,139,184,53,172,52,95,108,127,152,217,157,73,88,80,164,65,82,109,93,65,255,189,179,148,228,91,26,214,106,232,198,46,169,15,71,34,117,118,207,238,158,121,246,125,103,207,158,203,233,231,219,151,47,120,58,155,126,203,235,53,110,86,178,189,255,229,106,205,247,31,175,87,141,55,155,251,223,172,26,46,230,255,68,90,240,99,92,227,57,111,121,253,29,46,46,120,243,205,124,179,189,55,121,187,216,244,222,244,243,191,237,254,59,157,61,189,156,62,220,242,249,95,30,118,173,61,167,36,57,186,0,134,217,64,240,54,3,86,9,208,188,75,38,216,22,115,68,45,220,86,139,139,243,229,35,222,226,99,220,254,48,157,93,78,119,181,105,5,24,91,195,92,29,132,220,59,4,87,16,138,23,130,216,170,163,222,107,22,41,211,171,123,211,77,251,129,207,113,119,209,215,133,109,34,246,41,90,40,194,90,131,141,21,74,239,6,176,24,223,67,42,190,119,63,10,223,156,255,186,224,211,207,158,62,220,252,249,239,75,94,159,237,234,157,9,46,54,252,252,190,126,251,206,23,15,22,124,206,203,237,236,18,3,38,17,211,192,218,42,16,146,183,122,25,231,32,149,16,76,78,133,43,199,43,45,240,106,52,103,151,169,213,18,106,202,80,208,100,8,61,69,64,150,166,13,45,28,209,218,214,91,31,69,30,44,183,243,237,203,47,119,99,52,187,44,41,50,185,40,224,107,176,58,34,94,0,67,51,208,114,241,193,167,130,25,229,234,249,103,207,39,191,250,237,228,108,187,158,47,191,191,255,224,252,197,246,229,228,119,147,255,139,110,205,38,191,249,152,251,33,204,222,245,98,33,179,134,125,64,31,160,218,150,193,155,226,57,244,80,125,249,20,111,207,123,119,235,35,191,61,85,155,142,37,122,48,165,17,132,162,1,87,198,132,100,139,43,185,96,68,100,250,4,111,207,123,119,107,246,81,119,35,24,97,177,189,130,84,61,4,23,146,202,133,209,57,161,84,118,49,33,182,30,70,55,190,248,98,76,219,125,190,121,177,192,151,223,253,120,246,126,194,216,39,11,61,220,255,122,190,222,108,39,115,21,164,201,74,38,107,222,92,44,182,122,83,39,170,56,11,110,219,249,106,169,2,182,220,98,219,78,150,218,246,159,184,241,63,167,190,29,16,119,170,224,193,57,206,23,135,104,201,109,69,119,111,194,239,47,54,243,165,250,128,201,139,31,86,203,131,140,202,143,106,156,221,181,134,71,43,154,47,248,182,252,117,8,188,120,203,155,188,25,4,151,207,174,45,206,179,233,236,217,79,153,156,155,223,215,97,255,182,205,121,215,225,60,155,222,123,54,61,91,93,172,219,168,209,235,135,175,222,136,190,221,69,118,167,188,243,241,214,210,232,55,203,139,197,226,230,155,175,112,139,183,39,222,126,189,234,115,153,115,127,184,60,187,117,50,187,90,204,205,15,252,155,195,237,207,117,219,126,78,177,71,184,196,239,121,253,39,29,128,215,109,127,213,202,111,117,24,111,43,238,157,60,90,102,48,153,203,224,218,1,101,172,208,13,39,91,200,24,161,190,43,253,132,133,215,188,108,252,95,54,236,9,111,118,163,61,188,228,77,187,198,80,93,77,175,174,238,189,233,48,165,56,145,200,2,182,5,212,6,81,129,154,40,2,21,169,174,233,228,17,141,219,235,48,11,165,98,80,165,140,67,210,249,41,233,129,146,55,192,177,81,232,104,61,198,120,92,14,51,116,211,154,215,174,120,86,29,9,197,234,136,20,68,189,110,110,152,200,169,45,75,99,22,62,224,28,252,181,222,218,201,95,87,52,209,118,44,248,186,234,19,219,71,207,118,48,206,20,211,213,101,102,205,9,132,61,84,26,31,73,90,239,205,70,107,218,94,182,91,236,185,133,238,65,212,167,66,48,250,87,9,169,66,66,133,190,104,2,153,13,30,23,219,204,217,21,215,19,56,239,212,40,6,189,26,73,38,176,212,29,91,241,9,99,57,48,219,79,184,205,95,204,181,155,191,222,220,120,162,19,221,39,186,103,83,195,88,130,77,2,17,221,200,248,59,169,217,199,4,165,4,111,90,14,33,217,190,151,238,26,26,149,28,149,200,174,181,4,46,6,40,106,14,148,123,101,171,25,81,137,137,143,139,238,150,133,108,53,12,209,118,189,199,109,148,138,58,174,205,103,171,211,32,25,148,124,96,186,191,98,37,121,59,250,121,226,250,23,225,154,92,141,42,143,2,153,149,230,192,202,117,233,22,161,218,74,226,179,87,123,236,246,113,157,209,165,234,156,70,126,138,26,105,20,135,34,80,0,38,142,53,113,176,181,151,59,113,29,189,103,71,21,53,234,162,146,149,186,50,102,98,130,228,88,167,32,207,100,82,218,203,181,15,33,120,189,50,212,158,104,172,53,25,168,94,9,151,194,24,162,56,236,20,142,139,107,196,210,244,118,6,173,94,104,172,130,7,160,170,62,166,136,141,154,171,160,139,220,14,204,245,31,79,102,252,147,198,186,21,167,38,87,180,37,138,3,4,159,19,84,36,15,45,42,2,170,6,148,41,221,9,107,84,245,64,204,12,58,93,104,162,29,148,237,146,245,35,247,94,17,157,186,241,176,31,107,75,42,74,226,189,70,189,27,45,82,165,86,63,210,135,31,177,86,180,189,214,186,227,194,186,84,52,166,139,5,223,253,88,84,79,30,200,135,6,174,230,210,155,100,54,200,135,150,235,213,100,185,218,78,46,54,60,225,235,213,193,19,221,191,0,221,213,80,138,36,5,140,236,162,36,216,1,83,5,23,52,225,205,25,165,154,252,63,53,227,153,178,247,196,21,140,38,198,154,41,139,210,237,123,131,40,216,189,88,5,52,238,79,181,51,235,132,21,146,134,113,215,28,67,21,188,104,5,174,65,205,193,7,178,226,106,240,199,69,119,208,179,155,38,49,64,110,60,50,19,20,40,220,25,154,118,181,71,143,18,252,7,164,251,236,209,217,137,237,19,219,187,68,27,141,52,148,4,185,212,174,86,162,135,17,136,4,145,217,248,198,86,141,130,223,203,182,243,69,83,234,28,64,196,42,158,28,204,88,70,203,224,163,161,94,187,230,12,165,31,23,219,49,152,148,155,120,176,94,226,88,187,208,238,233,141,133,106,90,162,222,91,206,217,127,56,182,79,194,125,130,251,149,45,47,82,114,178,154,175,139,221,61,249,119,42,185,154,31,118,181,211,70,37,221,71,217,47,220,152,168,73,18,6,52,105,236,176,82,71,142,78,157,168,20,87,185,177,137,210,235,113,193,157,155,227,194,165,2,18,90,189,16,169,132,251,146,212,207,132,98,170,203,189,231,67,175,145,191,1,247,205,243,237,19,221,39,186,103,211,26,75,202,162,145,238,226,88,156,75,206,67,101,103,244,208,209,119,213,109,19,227,94,186,85,158,25,185,71,85,252,160,128,154,166,101,73,3,90,169,23,78,217,166,134,71,182,150,102,149,109,211,117,8,76,28,165,50,147,78,152,45,171,45,39,245,71,193,120,196,254,225,232,22,252,199,137,237,19,219,131,109,155,165,122,91,29,80,15,109,164,205,25,72,2,3,5,99,172,41,182,247,255,240,252,171,113,119,197,180,6,57,232,188,16,108,142,80,75,77,192,24,171,195,202,197,98,58,60,219,59,114,247,193,241,234,132,83,136,31,123,136,119,162,34,209,88,200,62,162,122,203,58,22,133,146,1,91,163,101,155,56,181,152,247,134,184,168,64,81,55,94,195,18,11,4,77,173,160,214,172,81,106,90,174,69,39,249,90,63,64,136,127,204,242,133,210,177,161,250,125,59,180,60,100,45,79,86,212,254,119,147,106,72,221,231,235,157,190,7,148,175,51,45,182,197,241,231,73,186,126,17,174,127,238,179,32,246,173,186,241,208,208,134,170,9,77,240,69,133,98,108,153,32,137,157,56,80,9,249,78,92,167,110,50,141,39,64,214,209,112,149,234,166,42,217,172,66,20,26,146,102,162,201,149,253,143,120,209,123,155,53,128,77,149,4,65,19,78,229,186,16,24,171,29,107,227,113,146,63,50,174,93,204,104,189,179,32,33,106,26,94,82,25,110,64,185,174,226,92,205,41,217,126,232,21,165,63,240,178,243,250,196,244,39,201,180,161,22,123,81,110,10,151,177,73,183,117,32,21,121,240,134,188,239,86,241,114,119,212,106,140,89,245,163,141,5,226,54,54,91,106,166,216,156,198,174,69,223,10,166,192,110,255,66,146,100,21,229,228,80,149,73,39,152,80,49,3,122,46,32,46,8,149,38,157,89,142,139,233,160,67,154,7,196,169,73,30,219,79,205,208,106,245,64,182,185,38,41,250,218,237,161,55,91,174,78,59,54,62,81,162,99,64,204,163,188,16,170,38,246,177,99,195,249,170,50,32,94,140,97,246,28,239,166,210,84,156,94,86,205,51,142,80,237,205,65,245,62,1,197,16,201,187,36,153,247,39,152,157,196,25,199,13,90,208,32,14,185,18,80,83,175,217,53,232,201,150,228,157,177,199,69,244,251,190,6,121,64,162,31,156,158,246,156,246,76,223,34,77,172,225,70,153,192,81,210,57,70,200,3,145,170,173,66,133,165,155,94,27,217,253,123,166,11,155,18,53,98,177,7,181,153,216,212,64,52,219,212,135,19,155,90,114,234,225,200,214,131,223,247,157,211,3,34,253,246,155,140,39,178,79,100,171,88,155,104,107,176,4,13,199,142,2,17,188,121,27,130,162,96,138,88,83,219,47,214,37,180,88,76,65,200,69,185,12,182,106,2,137,9,193,5,205,254,163,230,219,198,208,113,145,253,190,47,197,31,144,236,119,223,114,62,177,125,164,108,63,191,250,23,14,145,72,204,99,71,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactByLead.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddContactAdressFlowElement

		/// <exclude/>
		public class AddContactAdressFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactAdressFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactAdress";
				IsLogging = true;
				SchemaElementUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Address = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Address").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Address") : null)));
				_recordDefValues_City = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("City").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CityId") : Guid.Empty)));
				_recordDefValues_Zip = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Zip").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Zip") : null)));
				_recordDefValues_Contact = () => (Guid)((process.AddContactByLead.RecordId));
				_recordDefValues_Region = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Region").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("RegionId") : Guid.Empty)));
				_recordDefValues_Primary = () => (bool)(true);
				_recordDefValues_Country = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Country").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CountryId") : Guid.Empty)));
				_recordDefValues_AddressType = () => (Guid)((((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty)) != Guid.Empty) ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty)) : new Guid("fb7a3f6a-f36b-1410-6f81-1c6f65e50343"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Address", () => _recordDefValues_Address.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_City", () => _recordDefValues_City.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Zip", () => _recordDefValues_Zip.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Region", () => _recordDefValues_Region.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Primary", () => _recordDefValues_Primary.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Country", () => _recordDefValues_Country.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_AddressType", () => _recordDefValues_AddressType.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Address;
			internal Func<Guid> _recordDefValues_City;
			internal Func<string> _recordDefValues_Zip;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Region;
			internal Func<bool> _recordDefValues_Primary;
			internal Func<Guid> _recordDefValues_Country;
			internal Func<Guid> _recordDefValues_AddressType;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,75,115,19,71,16,254,43,148,206,12,204,251,193,141,24,146,184,42,5,84,76,113,0,115,152,167,217,202,74,171,218,93,145,56,148,255,123,122,87,178,44,217,122,140,182,0,43,96,31,100,105,170,183,167,187,191,249,122,187,123,190,140,124,105,155,230,149,29,199,209,179,209,219,88,215,182,169,82,251,228,215,162,108,99,253,91,93,205,166,163,199,163,38,214,133,45,139,127,99,152,175,191,12,69,251,194,182,22,30,249,114,126,163,225,124,244,236,124,179,142,243,209,227,243,81,209,198,113,3,50,240,136,145,154,70,31,18,18,202,83,196,141,52,72,51,207,17,139,49,48,42,73,242,66,207,37,183,41,63,169,198,83,91,199,249,30,189,250,212,127,125,123,57,237,68,9,44,248,94,164,104,170,201,98,145,117,70,52,47,39,214,149,49,192,239,182,158,69,88,106,235,98,12,222,196,183,197,56,190,177,53,236,213,233,169,186,37,16,74,182,108,58,169,50,166,246,229,63,211,58,54,77,81,77,246,25,87,206,198,147,85,105,80,16,151,63,23,230,224,222,198,78,242,141,109,63,245,42,78,193,172,171,222,202,231,23,23,117,188,176,109,241,121,213,136,191,226,101,47,151,23,63,120,32,0,74,239,108,57,139,43,123,174,123,114,98,167,237,220,161,249,246,32,80,23,23,159,178,125,93,70,108,159,187,20,22,167,215,194,153,58,55,250,64,37,44,126,238,22,230,90,174,191,158,143,62,156,54,175,255,158,196,250,204,127,138,99,59,143,218,199,39,176,122,107,97,169,255,217,23,194,48,118,130,69,68,141,244,136,107,161,33,146,82,67,76,153,13,158,10,171,184,191,250,56,183,163,104,166,165,189,124,183,220,238,143,104,195,34,100,221,63,88,209,74,105,45,41,69,212,5,208,161,140,70,38,113,140,152,39,196,90,236,157,48,14,16,134,63,120,70,19,131,173,73,30,25,29,28,226,36,41,164,35,8,99,31,73,226,222,144,36,226,238,56,237,96,88,148,132,226,148,44,10,202,5,196,131,96,200,70,97,144,99,132,123,199,163,163,78,238,86,126,58,217,70,46,254,255,36,215,243,16,58,153,185,64,14,203,242,98,184,225,132,146,221,52,91,24,242,168,237,165,59,194,197,20,235,56,241,113,126,78,151,78,175,89,124,151,152,29,212,31,142,138,154,189,227,43,212,92,208,130,39,237,104,144,10,41,18,48,226,34,57,164,141,138,200,7,110,25,214,214,40,143,123,125,203,13,127,175,198,115,151,111,200,157,173,228,14,79,231,202,128,116,31,123,218,113,226,85,138,26,37,197,35,48,62,145,142,118,6,97,167,29,11,138,18,143,241,30,102,52,175,102,101,185,141,29,116,19,59,200,143,199,142,188,56,126,71,118,20,61,44,139,224,118,30,112,197,18,164,113,130,56,235,78,76,82,4,25,204,192,66,102,132,163,154,40,167,247,84,25,15,57,48,47,134,15,57,112,111,14,76,78,89,150,164,69,137,73,135,8,39,24,201,164,9,34,94,38,41,162,192,140,179,245,28,248,203,172,41,38,96,227,173,60,152,173,232,78,30,188,81,120,157,11,141,113,156,18,197,16,119,22,56,44,148,66,22,243,128,24,100,214,68,131,199,214,243,7,134,236,169,197,179,98,248,192,144,189,12,81,18,187,36,53,84,225,78,70,20,18,33,200,25,173,17,198,36,72,28,13,211,94,174,51,228,69,44,1,147,250,242,22,67,178,21,221,97,200,141,194,158,33,29,252,101,117,81,120,91,190,158,198,218,46,176,217,242,50,95,59,253,93,143,82,87,85,123,11,171,174,101,232,183,94,190,69,179,154,128,206,16,6,101,39,161,201,160,200,224,136,113,97,44,210,221,7,9,66,219,40,57,228,227,48,184,93,144,144,54,160,221,81,136,122,7,13,165,165,24,129,82,131,24,172,70,165,173,74,196,125,245,162,136,30,125,50,56,169,102,147,182,63,14,25,137,32,47,134,135,39,130,165,17,59,114,192,170,204,178,14,234,13,236,44,79,137,81,165,69,66,194,66,15,3,117,27,244,48,218,82,228,5,5,74,232,232,177,241,63,33,186,127,198,139,94,60,7,220,188,16,30,14,238,89,11,142,63,157,214,213,231,2,80,221,137,241,181,185,27,33,182,210,233,104,164,68,137,99,200,35,180,171,211,8,164,21,42,40,247,196,113,103,196,207,8,241,251,98,154,135,111,94,252,54,225,187,19,222,247,167,111,158,78,171,166,181,229,35,95,133,184,5,60,46,131,183,148,18,20,116,18,136,7,195,144,117,198,35,207,25,39,70,91,2,47,131,159,16,188,147,162,205,76,189,121,1,28,144,122,123,11,118,229,221,107,129,187,160,58,42,36,60,69,16,75,130,35,110,34,69,142,67,147,108,137,21,208,85,121,238,216,158,241,222,15,9,234,162,90,205,195,53,47,134,7,179,114,105,195,93,224,190,67,201,151,87,200,109,179,4,127,69,75,40,53,201,112,9,149,177,163,18,170,101,163,145,86,52,129,57,212,50,21,148,240,6,90,201,171,209,227,62,190,103,213,172,246,139,27,151,102,126,245,51,232,74,231,30,46,106,14,185,123,217,120,251,145,211,12,29,203,61,197,183,189,139,24,116,199,112,15,131,129,65,189,254,150,214,121,8,250,107,77,110,238,244,250,224,17,245,61,76,158,7,14,81,6,207,102,31,206,78,222,196,239,224,145,222,67,96,243,6,69,223,114,18,116,216,96,103,208,192,230,30,138,198,1,163,149,225,35,139,35,245,111,125,184,48,188,93,63,82,247,86,26,235,225,221,236,145,250,182,218,119,14,239,234,142,212,185,91,253,215,119,105,126,190,89,47,115,53,186,250,15,57,71,56,128,194,38,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,4,0,183,239,220,131,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,219,142,27,69,16,253,21,99,120,0,105,219,233,251,197,18,66,16,2,90,41,64,148,132,60,144,205,67,117,119,53,88,120,103,86,227,49,40,172,246,223,57,227,221,37,155,0,134,144,85,46,100,253,96,123,122,166,106,170,187,235,212,57,53,115,58,255,104,124,122,194,243,229,252,33,15,3,109,250,54,46,110,247,3,47,238,13,125,225,205,102,113,183,47,180,94,253,70,121,205,247,104,160,99,30,121,120,68,235,45,111,238,174,54,227,193,236,121,179,249,193,252,163,95,118,103,231,203,199,167,243,195,145,143,191,63,172,240,174,34,145,162,40,69,109,69,10,91,44,139,44,11,9,138,205,20,227,172,175,117,50,46,253,122,123,220,125,195,35,221,163,241,167,249,242,116,190,243,6,7,158,85,116,41,71,225,200,25,97,157,9,34,171,198,162,5,226,88,178,85,206,219,249,217,193,124,83,126,226,99,218,221,244,153,113,117,182,106,173,162,240,170,68,97,149,193,141,85,14,194,5,27,75,96,237,154,243,147,241,197,245,207,12,31,127,248,248,112,243,221,175,29,15,15,118,126,151,141,214,27,126,178,192,232,11,3,119,214,124,204,221,184,60,37,75,190,53,89,132,82,169,9,235,141,194,36,181,22,62,90,43,131,143,156,216,157,193,224,143,213,92,158,250,146,162,77,62,136,72,50,8,91,189,19,196,173,32,208,200,142,148,42,181,212,201,228,78,55,174,198,167,183,119,107,180,60,13,62,71,235,139,23,158,154,19,86,22,45,146,11,94,184,226,106,46,178,122,45,229,217,147,15,159,76,19,171,171,205,201,154,158,62,250,243,252,238,51,213,217,26,95,139,175,86,195,102,156,173,176,101,179,190,205,6,222,108,215,227,170,251,113,134,61,89,115,25,87,125,183,248,188,86,140,111,206,125,158,60,151,14,87,189,158,30,157,103,213,209,124,121,244,119,121,117,241,123,190,138,207,103,214,139,73,117,52,63,56,154,63,232,183,67,153,60,26,28,124,121,101,58,187,155,236,46,121,225,240,50,139,48,210,109,215,235,139,145,47,105,164,203,11,47,135,251,186,106,43,174,135,221,131,203,228,217,121,145,23,31,241,23,95,151,159,243,216,94,197,236,27,234,232,71,30,190,197,2,60,139,253,143,40,31,98,25,47,29,23,217,164,245,26,25,130,173,21,22,123,44,162,101,39,146,85,169,150,232,148,207,106,103,125,159,27,15,220,21,254,143,129,221,231,205,110,181,39,248,94,196,53,45,213,217,252,236,236,224,42,168,179,139,182,144,50,194,32,131,39,88,121,145,152,73,104,100,58,23,74,218,134,182,23,212,202,26,87,106,203,176,85,90,88,206,22,85,193,39,17,101,210,149,165,10,222,135,247,11,212,86,187,152,125,146,162,113,80,216,227,64,34,234,16,69,147,20,114,170,213,134,120,221,160,190,141,219,223,32,250,141,32,58,235,228,100,80,77,4,38,0,136,189,22,177,42,18,73,165,220,76,48,186,53,189,15,209,14,32,147,217,195,192,48,114,204,218,40,50,174,20,148,81,12,60,23,93,26,191,20,162,1,97,230,130,164,85,81,90,97,163,6,162,117,246,162,145,181,173,56,202,20,247,211,116,40,94,201,160,139,200,164,225,128,178,17,81,105,18,222,4,171,200,112,70,5,123,191,16,205,170,161,200,25,76,42,52,212,184,74,70,144,105,94,84,171,147,37,170,88,39,127,205,136,254,225,240,222,173,147,126,51,210,26,163,149,111,192,253,70,192,109,180,163,96,160,88,101,179,19,56,105,162,107,208,92,240,210,55,148,113,105,168,188,86,186,174,181,6,51,213,8,19,17,149,109,108,69,140,181,8,67,73,121,8,136,232,201,239,167,107,47,147,137,46,10,106,25,228,100,192,247,57,230,34,156,86,46,1,76,17,66,244,173,0,183,162,22,165,174,73,164,166,209,44,104,137,64,83,65,93,100,153,165,116,178,82,226,23,192,29,2,186,19,132,0,206,245,16,87,211,180,50,67,107,113,66,153,168,182,20,52,31,255,12,83,8,228,217,182,43,125,215,86,195,49,87,192,175,27,169,140,179,76,27,28,245,221,14,194,179,85,215,250,225,152,206,217,119,96,26,113,110,224,210,15,117,118,88,111,208,250,78,82,49,196,55,27,239,148,136,141,81,230,1,8,216,87,9,82,145,166,90,31,77,173,230,165,208,234,172,202,50,134,137,73,37,192,134,254,23,226,26,156,74,90,114,10,17,65,25,181,23,173,5,213,38,53,132,208,108,196,140,106,4,220,147,247,162,152,22,108,181,178,38,247,158,117,204,181,176,145,12,42,54,217,192,74,66,156,228,132,222,89,198,28,18,214,195,160,82,92,51,21,63,24,129,238,91,39,67,255,203,10,41,115,131,237,119,18,219,80,191,104,77,19,200,192,67,189,217,22,139,136,206,71,225,106,179,185,106,138,57,169,151,194,54,235,106,42,186,57,116,187,224,95,203,211,63,135,198,89,201,2,213,224,155,55,94,238,197,118,85,170,82,161,12,7,166,66,102,131,168,208,6,100,145,164,69,230,35,155,75,77,215,143,237,113,192,207,30,108,92,158,191,73,240,215,156,224,83,19,232,114,155,164,230,174,8,90,208,80,8,73,104,20,52,252,161,150,100,120,173,82,83,89,170,182,101,22,236,166,167,59,201,85,72,205,56,53,61,248,52,54,201,133,188,55,193,165,71,62,83,209,2,179,106,231,116,154,202,68,12,12,157,86,33,198,106,160,247,140,188,66,202,182,74,212,175,144,160,7,82,50,34,57,157,5,203,20,100,140,217,185,114,221,125,228,237,126,219,141,195,205,195,161,119,147,181,100,106,133,21,138,130,83,14,201,165,147,71,194,20,0,17,220,0,9,152,200,151,246,82,160,38,89,244,244,178,70,104,23,64,58,37,34,150,138,142,73,5,15,41,105,117,115,145,246,179,86,78,210,33,116,16,39,226,176,211,51,43,66,250,139,234,12,4,114,201,90,214,124,253,160,254,248,109,70,181,247,209,105,10,78,100,173,25,75,146,166,142,161,226,150,41,42,11,38,151,202,168,9,213,179,15,62,157,125,189,93,213,197,157,227,147,241,233,39,179,207,102,255,139,89,45,49,141,187,125,255,243,246,100,225,100,52,33,79,174,77,155,130,243,80,51,54,103,81,89,70,27,152,75,85,121,209,114,152,30,158,145,104,6,231,193,115,82,248,22,149,80,5,162,201,177,147,198,154,253,37,240,227,255,246,202,107,54,21,184,191,222,134,87,113,119,101,254,87,207,44,190,216,110,86,221,205,155,182,119,181,244,254,155,92,254,167,210,251,228,236,119,91,78,13,171,156,31,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactAdress.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddContactWebFlowElement

		/// <exclude/>
		public class AddContactWebFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactWebFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactWeb";
				IsLogging = true;
				SchemaElementUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Contact = () => (Guid)((process.AddContactByLead.RecordId));
				_recordDefValues_Number = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Website").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Website") : null)));
				_recordDefValues_CommunicationType = () => (Guid)(new Guid("6a8ba927-67cc-df11-9b2a-001d60e938c6"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Number", () => _recordDefValues_Number.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CommunicationType", () => _recordDefValues_CommunicationType.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Contact;
			internal Func<string> _recordDefValues_Number;
			internal Func<Guid> _recordDefValues_CommunicationType;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,93,111,155,48,20,253,47,60,215,21,216,134,64,222,170,46,155,34,77,109,165,70,221,195,210,135,139,125,73,172,153,128,108,210,45,139,242,223,119,129,36,75,167,180,205,42,109,45,47,192,209,241,253,56,215,247,172,3,101,193,251,43,40,49,24,6,19,116,14,124,85,52,231,31,141,109,208,125,114,213,178,14,206,2,143,206,128,53,63,81,247,248,72,155,230,3,52,64,71,214,211,223,17,166,193,112,122,60,198,52,56,155,6,166,193,210,19,135,142,20,58,17,170,40,34,166,162,168,96,50,213,192,50,94,72,150,228,185,202,178,44,148,156,99,207,124,42,248,101,85,214,224,176,207,209,133,47,186,207,201,170,110,169,17,1,170,163,24,95,45,182,160,104,139,240,163,5,228,22,53,253,55,110,137,4,53,206,148,212,13,78,76,137,55,224,40,87,27,167,106,33,34,21,96,125,203,178,88,52,163,31,181,67,239,77,181,120,169,56,187,44,23,135,108,10,128,251,223,109,57,97,87,99,203,188,129,102,222,133,24,83,89,155,174,202,139,217,204,225,12,26,243,112,88,196,55,92,117,188,211,244,163,3,154,166,116,7,118,137,7,57,31,119,114,9,117,211,55,212,167,39,130,51,179,249,201,189,238,21,123,169,93,78,96,189,35,159,24,243,104,15,60,33,240,161,5,250,40,187,207,105,240,117,236,175,191,47,208,221,170,57,150,208,171,118,127,78,232,31,192,62,254,112,29,137,48,204,99,129,140,103,137,34,37,227,148,165,34,73,153,204,4,104,197,99,24,72,181,185,239,235,48,190,182,176,186,219,167,251,140,160,183,146,181,47,66,146,144,39,185,26,8,166,82,9,76,230,57,205,37,6,201,210,60,141,52,231,185,148,177,162,9,211,67,103,68,138,92,167,82,50,14,92,50,169,84,202,50,13,17,19,3,206,69,33,7,74,232,232,121,157,198,254,106,105,237,83,59,192,143,237,0,127,247,59,240,5,115,111,218,180,167,44,194,105,26,30,185,68,209,179,139,64,53,244,150,213,9,188,203,219,77,205,86,51,163,192,94,215,232,96,203,15,143,107,250,104,24,237,157,117,85,213,244,55,113,175,87,123,133,186,76,187,134,178,65,40,64,133,146,65,17,103,76,242,12,88,154,8,186,70,131,84,105,29,135,9,87,130,164,33,83,110,59,186,173,150,78,109,77,208,247,110,252,42,151,125,3,239,252,27,59,60,106,72,167,24,204,123,177,142,127,107,15,111,176,245,175,88,228,255,178,73,155,96,243,11,184,24,168,34,211,8,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,4,0,183,239,220,131,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,149,75,111,220,54,16,199,191,202,66,201,209,92,240,253,216,91,225,164,128,1,167,53,226,52,61,216,62,12,201,97,34,84,43,25,146,182,133,187,216,239,158,145,188,27,63,218,218,6,138,162,45,16,29,36,145,226,60,56,250,255,56,219,234,245,120,115,141,213,170,250,128,125,15,67,87,198,229,113,215,227,242,172,239,18,14,195,242,180,75,208,212,191,67,108,240,12,122,88,227,136,253,71,104,54,56,156,214,195,120,180,120,104,86,29,85,175,127,157,191,86,171,139,109,117,50,226,250,167,147,76,222,179,202,218,154,16,152,3,237,153,230,46,50,47,193,50,101,4,198,44,101,240,5,200,56,117,205,102,221,190,195,17,206,96,252,92,173,182,213,236,141,28,164,34,165,213,198,179,36,18,103,58,243,196,160,160,97,90,88,171,139,204,198,113,172,118,71,213,144,62,227,26,230,160,119,198,156,107,8,66,10,38,69,161,232,32,144,249,32,232,205,36,94,156,177,8,90,76,198,251,245,119,134,23,175,46,78,134,31,127,107,177,63,159,253,174,10,52,3,94,45,105,246,209,196,219,6,215,216,142,171,173,128,226,185,204,129,133,34,21,211,146,91,22,67,66,6,200,35,231,134,103,8,184,35,131,175,213,92,109,157,3,207,139,177,76,71,75,123,243,49,177,136,210,49,12,182,148,172,83,50,33,238,174,94,93,77,41,230,122,184,110,224,230,227,31,51,253,46,231,197,166,77,93,91,234,126,141,121,65,111,35,164,113,17,97,160,81,215,46,26,132,188,168,219,210,245,107,24,235,174,93,30,247,8,35,125,235,49,117,125,94,156,228,219,16,215,15,254,243,253,32,219,203,91,185,92,86,171,203,191,18,204,254,121,91,158,135,146,121,172,150,203,234,232,178,58,239,54,125,154,60,42,26,188,185,183,187,57,200,188,228,209,240,32,15,154,105,55,77,179,159,121,3,35,28,22,30,166,187,92,151,26,243,73,123,126,80,197,236,133,239,47,246,39,183,195,117,155,219,223,49,123,7,45,124,194,254,7,42,192,93,238,95,179,252,64,101,60,56,142,50,24,238,68,97,14,33,48,141,86,50,159,5,176,32,66,44,202,41,89,138,156,173,223,99,193,30,219,132,15,19,19,54,162,178,70,48,95,80,18,17,38,144,125,230,140,84,53,97,231,85,206,106,111,63,204,213,158,184,220,231,53,149,106,87,237,118,71,247,105,149,81,104,233,4,201,176,56,77,130,180,137,5,29,10,243,66,128,8,147,194,75,126,146,86,46,75,2,52,142,21,40,64,59,210,133,5,101,29,139,198,43,225,192,162,196,244,159,160,21,52,16,99,116,152,8,65,251,211,86,9,170,154,148,204,122,77,135,148,245,24,208,60,162,213,166,224,117,160,205,120,224,142,78,34,107,136,237,146,168,238,30,13,8,145,114,202,147,201,219,118,172,199,155,227,185,70,171,45,58,163,130,160,66,10,157,5,29,11,66,177,24,157,163,178,40,157,13,90,170,116,121,158,241,247,19,194,19,199,203,239,235,126,24,23,53,253,178,69,87,136,224,97,211,140,117,251,137,168,111,26,76,51,222,63,99,252,6,244,191,2,116,206,81,145,108,145,113,135,126,146,136,100,209,17,218,153,163,21,158,218,64,137,249,41,160,95,156,216,75,129,206,74,113,235,18,48,200,115,66,164,117,144,201,50,11,60,33,58,239,147,226,79,2,45,100,17,217,41,98,89,37,106,186,96,36,11,49,83,255,70,142,9,74,86,37,234,127,2,232,211,174,251,101,115,189,204,94,219,20,233,20,41,194,103,194,52,144,7,85,202,212,33,69,161,216,224,157,90,90,240,17,2,245,77,218,105,98,185,8,65,57,74,160,170,137,108,57,6,229,147,125,14,176,125,188,227,110,189,222,180,117,154,251,228,162,187,158,31,19,40,223,160,250,223,118,201,151,104,232,57,168,174,118,95,0,154,186,196,212,49,11,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactWeb.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ParallelGatewayAddContactCommunicationFlowElement

		/// <exclude/>
		public class ParallelGatewayAddContactCommunicationFlowElement : ProcessParallelGateway
		{

			public ParallelGatewayAddContactCommunicationFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGatewayAddContactCommunication";
				IsLogging = true;
				SchemaElementUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "AddContactByLead", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = true;
				SchemaElementUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "AddContactWeb", false }, { "AddContactAdress", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: ReadContactsByLeadEmailFlowElement

		/// <exclude/>
		public class ReadContactsByLeadEmailFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadEmailFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadEmail";
				IsLogging = true;
				SchemaElementUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,75,111,27,55,16,254,43,194,158,90,32,52,200,37,151,203,213,45,112,148,194,151,36,104,140,92,34,31,248,24,202,139,236,67,216,165,210,168,130,254,123,103,31,146,173,68,86,84,183,137,93,160,62,24,210,232,227,240,155,225,55,143,77,100,11,221,182,111,116,9,209,52,186,134,166,209,109,237,195,197,235,188,8,208,252,214,212,171,101,244,34,106,161,201,117,145,255,9,110,176,207,92,30,94,233,160,241,200,102,126,231,97,30,77,231,199,125,204,163,23,243,40,15,80,182,136,193,35,154,102,14,116,236,72,146,104,71,132,225,146,232,76,90,34,157,22,34,225,82,74,166,6,228,67,206,103,95,242,54,180,195,21,189,119,223,127,188,94,47,59,100,130,6,91,151,75,221,228,109,93,141,70,214,89,243,118,86,105,83,128,67,67,104,86,128,166,208,228,37,70,3,215,121,9,239,116,131,119,117,142,234,206,132,32,175,139,182,67,21,224,195,236,203,178,129,182,205,235,234,52,185,203,186,88,149,213,125,52,58,128,253,215,145,15,237,73,118,200,119,58,220,246,46,62,94,214,85,208,54,92,214,101,185,170,114,171,3,194,167,163,241,230,226,10,89,111,251,32,94,46,22,13,44,240,231,207,112,23,200,39,88,247,94,206,203,46,30,112,248,134,31,116,177,130,123,140,14,227,188,212,203,48,132,59,143,70,26,19,123,159,220,164,238,1,147,95,204,122,50,4,51,25,113,191,246,87,180,43,51,60,82,123,58,101,39,196,146,100,158,167,194,25,146,198,74,19,65,121,70,12,143,25,209,222,41,154,73,231,99,235,190,247,30,157,20,224,33,181,176,99,106,225,207,94,44,111,86,165,233,194,57,166,136,29,145,157,36,206,203,225,17,73,196,234,164,38,118,28,16,212,228,139,219,179,131,222,167,238,123,113,199,104,92,238,192,103,250,60,30,136,68,227,231,206,48,120,217,125,196,162,187,106,223,254,81,65,243,222,222,66,169,135,212,221,92,160,245,43,195,172,128,18,170,48,221,104,161,165,247,212,18,198,50,79,132,228,152,71,21,199,68,42,33,104,42,21,100,144,108,241,192,158,208,116,35,109,166,68,38,83,162,52,77,137,112,50,33,26,188,37,130,41,72,52,99,214,89,215,29,153,85,33,15,235,65,18,211,141,7,224,177,83,140,164,16,11,34,52,23,36,99,54,37,156,42,14,194,137,140,43,191,189,25,194,205,219,101,161,215,31,246,81,253,14,218,77,10,252,135,165,213,180,97,210,21,212,164,246,19,76,239,170,8,121,181,232,202,181,0,219,61,229,197,172,212,121,209,251,233,90,12,158,182,50,6,74,169,33,92,161,84,186,174,129,55,39,200,193,114,169,124,166,140,73,24,42,15,255,240,12,103,25,128,224,41,66,144,171,48,30,136,118,113,70,40,79,56,149,248,99,108,244,233,167,187,170,30,170,77,241,223,172,205,131,6,62,192,206,41,211,243,50,121,68,221,236,116,235,30,80,223,22,105,215,97,63,62,171,50,237,3,185,87,166,163,30,1,152,85,137,229,196,122,107,136,243,140,145,204,196,154,80,202,156,164,128,133,96,101,239,111,127,225,157,164,239,42,253,108,47,223,84,211,232,13,245,126,211,75,190,168,23,248,184,197,219,37,52,122,204,50,61,46,202,3,53,119,61,168,169,235,48,116,150,61,215,99,83,191,231,177,211,133,145,206,106,16,158,184,76,96,57,198,158,19,195,164,39,169,74,82,236,235,38,139,57,237,217,253,40,106,7,108,52,7,212,35,19,120,61,83,200,134,33,27,74,61,225,38,49,10,89,42,3,30,217,224,226,216,189,238,251,122,213,216,113,246,182,195,198,248,168,77,240,41,22,188,127,113,103,251,122,17,122,212,130,243,4,107,203,223,221,68,142,174,1,231,244,139,255,7,246,51,28,216,79,48,139,255,193,120,125,96,186,61,70,125,7,115,232,220,201,241,51,167,195,15,109,246,219,104,251,23,61,201,224,253,26,16,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,176,50,212,241,76,1,82,6,0,110,89,182,126,20,0,0,0 })));
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
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
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

		#region Class: ChangeLeadContactEmailFlowElement

		/// <exclude/>
		public class ChangeLeadContactEmailFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactEmailFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactEmail";
				IsLogging = true;
				SchemaElementUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,111,138,190,21,169,91,4,40,154,0,49,114,169,114,88,145,43,155,168,100,9,36,157,214,53,252,239,93,74,182,234,20,46,226,246,210,232,34,105,48,156,157,93,206,238,2,217,128,181,159,161,197,96,22,44,208,24,176,93,237,174,63,232,198,161,249,104,186,77,31,92,5,22,141,134,70,255,64,53,226,115,165,221,123,112,64,71,118,229,47,133,50,152,149,231,53,202,224,170,12,180,195,214,18,135,142,240,58,170,64,242,138,129,72,144,165,200,37,43,64,198,172,86,40,98,80,144,136,180,30,153,127,18,191,233,218,30,12,142,53,6,249,122,248,92,108,123,79,141,8,144,3,69,219,110,125,0,19,111,194,206,215,80,53,168,232,223,153,13,18,228,140,110,169,27,92,232,22,239,193,80,45,175,211,121,136,72,53,52,214,179,26,172,221,252,123,111,208,90,221,173,95,51,215,108,218,245,41,155,4,112,250,61,216,9,7,143,158,121,15,110,53,72,220,146,173,253,224,242,221,114,105,112,9,78,63,159,154,248,138,219,129,119,217,252,232,128,162,91,122,132,102,131,39,53,95,118,114,3,189,27,27,26,203,19,193,232,229,234,226,94,167,137,189,214,110,76,96,127,36,95,168,121,182,135,56,39,240,217,3,163,202,241,179,12,190,220,218,187,111,107,52,15,114,133,45,140,83,123,186,38,244,55,96,210,159,237,162,36,12,171,140,134,24,139,92,178,180,200,10,86,36,121,193,82,145,128,146,113,6,60,149,251,167,209,135,182,125,3,219,199,169,220,39,4,117,24,153,127,17,18,231,153,80,60,229,172,66,37,88,42,99,82,227,94,28,5,64,21,39,69,86,3,221,176,127,252,69,116,75,45,161,185,235,209,192,225,14,194,243,17,125,145,109,223,190,233,58,55,54,53,141,207,187,25,188,28,67,34,34,5,188,80,20,146,40,231,44,141,34,193,42,17,102,172,78,185,228,105,146,84,153,160,144,236,105,191,253,132,31,186,141,145,135,125,178,227,98,255,211,194,254,135,53,252,155,205,58,155,237,75,178,250,86,82,248,102,146,182,15,246,63,1,88,136,108,183,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,82,219,48,16,253,21,143,224,24,101,36,91,182,36,95,129,206,100,6,90,6,40,23,146,195,74,90,129,103,28,155,177,149,118,210,140,255,189,178,147,0,161,237,169,58,216,214,106,223,219,221,231,167,29,57,15,219,87,36,37,121,192,174,131,190,245,97,126,209,118,56,191,237,90,139,125,63,191,110,45,212,213,47,48,53,222,66,7,107,12,216,61,66,189,193,254,186,234,195,44,57,133,145,25,57,255,49,157,146,242,105,71,22,1,215,223,23,46,178,91,103,85,206,210,130,58,229,13,21,169,226,20,12,203,105,202,160,40,28,79,65,115,19,193,182,173,55,235,230,6,3,220,66,120,33,229,142,76,108,145,0,156,208,204,229,138,178,92,0,21,78,229,84,167,34,242,57,37,138,2,77,166,85,70,134,25,233,237,11,174,97,42,250,14,22,28,188,210,168,169,204,89,172,142,198,80,101,193,82,239,51,109,10,161,4,71,59,130,15,249,239,192,167,179,167,69,255,237,103,131,221,253,196,91,122,168,123,92,205,99,244,83,224,170,198,53,54,161,220,33,75,81,42,166,168,146,169,166,194,106,73,141,102,146,114,161,164,79,145,203,84,170,33,2,222,212,44,119,2,57,50,169,51,10,57,218,40,14,8,106,164,137,179,89,31,123,229,133,100,136,35,228,170,9,85,216,94,76,26,149,59,64,134,34,183,64,173,208,57,21,30,37,133,76,59,154,129,25,107,32,47,184,28,86,103,171,113,48,87,245,175,53,108,31,255,156,239,14,193,37,182,109,124,213,173,113,250,10,96,67,159,152,109,82,143,71,113,198,170,158,127,169,186,62,36,85,252,157,73,235,147,14,251,77,29,170,230,57,166,215,53,218,80,181,205,124,225,246,165,94,79,92,242,177,216,110,185,55,219,146,148,203,127,217,237,240,222,139,123,106,184,207,94,91,146,217,146,220,183,155,206,142,140,89,220,92,126,152,114,42,50,165,124,218,30,205,21,35,205,166,174,15,145,75,8,112,76,60,134,91,87,249,10,221,162,185,63,122,106,98,97,135,69,255,242,56,174,125,111,255,3,187,129,6,158,177,251,26,5,120,239,253,173,203,135,40,227,145,216,164,58,103,146,123,42,17,162,225,176,72,169,114,28,168,230,218,248,76,102,169,247,233,132,190,67,143,29,54,22,79,27,227,133,193,172,200,57,85,30,83,42,120,174,35,222,49,10,138,101,78,20,42,115,46,59,224,251,73,237,241,86,31,250,26,165,26,200,48,172,134,223,213,184,64,99,73,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactEmail.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ReadContactsByLeadPhoneFlowElement

		/// <exclude/>
		public class ReadContactsByLeadPhoneFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadPhoneFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadPhone";
				IsLogging = true;
				SchemaElementUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,223,111,219,54,16,254,87,12,63,109,64,25,144,18,69,145,126,219,50,111,200,195,218,98,13,250,82,231,225,68,30,29,97,250,97,72,114,215,44,200,255,222,163,100,59,73,227,184,106,214,44,65,17,63,24,242,249,120,186,59,126,223,241,227,229,212,22,208,182,175,161,196,233,108,122,138,77,3,109,237,187,163,223,243,162,195,230,143,166,94,175,166,175,166,45,54,57,20,249,191,232,6,251,220,229,221,111,208,1,45,185,92,92,71,88,76,103,139,253,49,22,211,87,139,105,222,97,217,146,15,45,209,18,184,74,149,102,137,77,50,38,69,138,12,208,39,204,26,157,197,158,131,115,220,15,158,247,5,159,127,202,219,174,29,94,209,71,247,253,227,233,197,42,120,38,100,176,117,185,130,38,111,235,106,99,20,193,154,183,243,10,178,2,29,25,186,102,141,100,234,154,188,164,106,240,52,47,241,45,52,244,174,16,168,14,38,114,242,80,180,193,171,64,223,205,63,173,26,108,219,188,174,14,39,119,92,23,235,178,186,233,77,1,112,247,115,147,15,239,147,12,158,111,161,59,239,67,124,56,174,171,14,108,119,92,151,229,186,202,45,116,228,62,219,24,207,142,78,40,235,171,190,136,95,150,203,6,151,244,247,71,188,46,228,111,188,232,163,140,235,46,45,112,180,135,239,161,88,227,141,140,110,215,121,12,171,110,40,119,49,221,164,49,177,55,147,155,212,189,195,228,167,236,98,50,20,51,217,248,253,220,191,162,93,103,195,38,181,135,91,118,0,44,113,172,0,211,44,97,58,226,158,201,40,226,76,103,220,50,224,34,150,73,156,72,110,213,131,131,71,153,136,208,122,203,68,10,156,73,31,27,166,141,140,232,73,122,237,29,202,20,226,175,109,118,192,25,222,7,69,177,15,138,241,179,71,226,235,117,153,133,114,246,193,109,155,200,22,111,227,122,184,7,111,145,62,8,184,109,14,228,212,228,203,243,209,69,239,90,247,181,186,35,50,174,182,206,35,99,238,47,68,145,241,99,48,12,81,182,143,196,232,147,246,205,63,21,54,239,236,57,150,48,180,238,236,136,172,95,24,230,5,150,88,117,179,75,144,160,188,39,120,11,97,8,237,42,22,12,116,20,49,165,165,228,68,106,52,152,92,209,130,93,66,179,75,69,196,150,70,165,76,3,79,153,116,42,9,124,183,196,124,141,9,8,97,157,117,97,201,188,234,242,238,98,128,196,236,210,72,136,65,39,49,227,218,210,148,208,137,167,93,243,146,9,29,233,84,67,2,128,217,213,217,80,110,222,174,10,184,120,191,171,234,47,4,55,41,232,139,168,213,180,221,36,16,106,82,251,9,181,119,93,116,121,181,12,179,160,64,27,182,242,232,215,117,155,87,212,247,201,234,188,174,176,15,24,6,25,133,145,60,66,163,8,46,161,44,74,65,72,150,57,31,17,189,33,118,105,202,17,140,38,8,210,135,214,100,206,26,231,41,65,207,227,128,50,3,76,167,177,98,96,45,149,233,141,64,239,94,152,122,152,169,227,122,248,194,212,231,197,84,201,61,122,225,12,243,134,190,100,36,105,195,12,29,133,177,54,24,37,10,192,58,249,93,152,250,103,157,229,5,222,229,41,38,25,151,105,76,121,90,5,76,6,45,145,101,17,176,196,8,58,142,29,213,26,249,129,167,1,132,69,189,36,113,80,188,89,97,3,27,132,136,253,44,186,69,191,176,49,77,93,119,67,187,119,27,187,79,17,245,185,109,49,61,78,30,132,196,210,40,74,141,18,9,75,29,196,76,102,225,156,210,128,140,186,43,45,160,49,212,199,195,216,58,169,238,27,30,114,223,240,144,207,126,120,220,106,235,224,54,102,142,140,235,228,30,250,137,195,18,115,240,186,59,69,130,88,251,240,172,230,72,95,200,141,57,178,101,10,10,171,19,27,51,146,67,25,115,94,8,102,2,83,56,23,78,113,52,177,14,96,164,165,187,23,206,75,200,139,222,116,61,138,70,71,185,67,247,77,52,34,226,217,125,92,228,143,200,69,23,211,213,34,13,154,66,209,32,164,3,61,98,25,215,25,211,50,166,211,5,133,32,69,216,103,247,88,169,221,202,198,91,169,156,50,156,165,70,16,74,169,167,140,4,142,98,218,138,196,113,103,148,49,41,101,67,23,220,176,187,239,234,117,99,55,226,160,29,110,182,15,186,177,62,197,69,244,59,222,45,191,188,176,61,232,34,246,160,11,214,19,136,177,111,213,87,123,197,205,152,33,243,35,200,144,31,247,194,240,130,188,231,141,188,23,1,124,231,208,253,54,61,251,4,82,245,63,168,207,123,196,223,67,208,126,75,166,141,21,86,255,167,120,122,84,45,116,53,189,250,12,116,41,210,195,225,23,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })));
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
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
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

		#region Class: ChangeLeadContactPhoneFlowElement

		/// <exclude/>
		public class ChangeLeadContactPhoneFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactPhoneFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactPhone";
				IsLogging = true;
				SchemaElementUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,201,110,219,48,16,253,23,157,195,64,251,226,91,145,186,69,128,162,9,16,35,151,42,135,17,57,146,137,106,3,73,165,117,13,255,123,135,146,172,58,133,139,184,189,52,186,136,124,120,124,243,102,219,59,188,6,173,63,67,131,206,202,217,160,82,160,187,210,92,127,144,181,65,245,81,117,67,239,92,57,26,149,132,90,254,64,49,225,107,33,205,123,48,64,79,246,249,47,133,220,89,229,231,53,114,231,42,119,164,193,70,19,199,62,137,35,207,245,124,96,169,39,60,22,22,194,103,25,102,116,77,146,64,132,34,206,10,224,51,243,15,226,55,93,211,131,194,41,198,40,95,142,199,205,174,183,84,143,0,62,82,164,238,218,25,12,172,9,189,110,161,168,81,208,221,168,1,9,50,74,54,148,13,110,100,131,247,160,40,150,213,233,44,68,164,18,106,109,89,53,150,102,253,189,87,168,181,236,218,215,204,213,67,211,158,178,73,0,151,235,108,199,29,61,90,230,61,152,237,40,113,75,182,14,163,203,119,85,165,176,2,35,159,79,77,124,197,221,200,187,172,126,244,64,80,151,30,161,30,240,36,230,203,76,110,160,55,83,66,83,120,34,40,89,109,47,206,117,169,216,107,233,250,4,246,71,242,133,154,103,115,240,99,2,159,45,48,169,28,143,185,243,229,86,223,125,107,81,61,240,45,54,48,85,237,233,154,208,223,128,69,127,181,247,2,215,45,162,0,153,159,197,156,133,105,148,178,52,136,83,22,102,1,8,238,71,144,132,252,240,52,249,144,186,175,97,247,184,132,251,132,32,230,146,217,31,33,81,26,23,156,158,48,79,4,212,151,82,20,12,16,19,230,11,207,11,203,36,224,126,86,82,135,237,103,27,209,85,146,67,125,215,163,130,185,7,238,249,17,125,49,219,54,125,213,117,102,74,106,41,159,117,51,122,57,14,73,192,139,194,13,162,136,65,226,39,44,20,60,97,148,105,204,162,40,2,215,139,5,162,176,227,70,251,109,43,252,208,13,138,207,251,164,167,197,254,167,133,253,15,107,248,55,155,117,118,182,47,153,213,183,50,133,111,102,210,14,206,225,39,8,233,7,64,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,16,253,21,70,201,209,242,0,18,66,226,154,164,51,158,73,218,76,146,230,18,251,176,146,86,9,51,24,60,32,183,227,50,252,123,5,182,147,216,109,79,213,1,208,106,223,219,221,199,83,79,46,253,110,131,164,32,79,216,182,208,53,206,207,175,154,22,231,247,109,99,176,235,230,183,141,129,170,252,5,186,194,123,104,97,141,30,219,103,168,182,216,221,150,157,159,69,167,48,50,35,151,63,166,83,82,188,244,100,225,113,253,125,97,3,59,119,185,114,194,74,42,56,179,148,107,149,82,41,164,164,104,19,163,132,86,26,156,12,96,211,84,219,117,125,135,30,238,193,191,145,162,39,19,91,32,0,203,85,108,51,73,227,140,3,229,86,102,84,165,92,80,107,37,23,2,53,83,146,145,97,70,58,243,134,107,152,138,126,128,121,18,232,21,42,154,103,177,166,28,181,166,210,128,161,206,49,165,5,151,60,65,51,130,15,249,31,192,151,139,151,69,247,237,103,141,237,227,196,91,56,168,58,92,205,67,244,44,112,83,225,26,107,95,244,9,67,29,231,156,209,212,101,9,229,82,112,170,92,134,161,209,148,199,160,165,69,157,14,1,240,174,102,209,171,92,202,100,76,116,105,18,196,113,92,209,48,143,163,66,164,38,151,49,58,107,212,8,185,169,125,233,119,87,147,70,69,15,24,35,207,12,80,195,85,22,80,152,83,96,202,82,6,58,79,115,137,137,72,242,97,117,177,26,7,179,101,183,169,96,247,252,231,124,15,8,54,50,77,237,202,118,141,211,151,7,227,187,72,239,162,106,60,218,188,53,53,118,243,47,101,219,249,168,12,255,51,106,92,212,98,183,173,124,89,191,134,252,170,66,227,203,166,158,47,236,190,214,230,196,38,159,171,245,203,189,219,150,164,88,254,203,111,135,247,94,221,83,199,157,155,109,73,102,75,242,216,108,91,51,50,178,176,185,254,52,230,84,100,74,57,219,30,221,21,34,245,182,170,14,145,107,240,112,76,60,134,27,91,186,18,237,162,126,60,154,106,98,137,15,139,254,229,113,92,251,222,254,7,118,7,53,188,98,251,53,8,240,209,251,123,151,79,65,198,35,177,78,85,22,231,137,163,57,130,10,238,22,225,110,217,4,168,74,148,118,44,103,169,115,233,132,126,64,135,45,214,6,79,27,75,132,70,38,130,89,165,195,148,242,36,83,1,111,99,10,50,102,150,11,201,172,101,7,124,55,169,61,94,235,67,95,163,84,3,25,134,213,240,27,159,253,156,215,74,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactPhone.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)((process.AddContactByLead.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,77,111,155,64,16,253,47,156,179,17,222,15,12,190,85,169,91,69,170,154,72,177,114,41,57,12,236,96,175,10,6,237,174,211,186,150,255,123,103,193,166,78,229,42,110,47,13,23,224,233,237,155,55,179,111,118,81,89,131,115,159,161,193,104,22,45,208,90,112,109,229,175,63,152,218,163,253,104,219,77,23,93,69,14,173,129,218,252,64,61,224,115,109,252,123,240,64,71,118,249,47,133,60,154,229,231,53,242,232,42,143,140,199,198,17,135,142,84,83,40,132,230,138,65,146,112,38,49,153,50,40,17,216,36,137,185,146,124,42,5,20,3,243,79,226,55,109,211,129,197,161,70,47,95,245,159,139,109,23,168,19,2,202,158,98,92,187,62,128,34,152,112,243,53,20,53,106,250,247,118,131,4,121,107,26,234,6,23,166,193,123,176,84,43,232,180,1,34,82,5,181,11,172,26,43,63,255,222,89,116,206,180,235,215,204,213,155,102,125,202,38,1,28,127,15,118,226,222,99,96,222,131,95,245,18,183,100,107,223,187,124,183,92,90,92,130,55,207,167,38,190,226,182,231,93,54,63,58,160,233,150,30,161,222,224,73,205,151,157,220,64,231,135,134,134,242,68,176,102,185,186,184,215,113,98,175,181,203,9,236,142,228,11,53,207,246,192,19,2,159,3,48,168,28,63,243,232,203,173,187,251,182,70,251,80,174,176,129,97,106,79,215,132,254,6,140,250,179,221,68,196,113,161,4,50,158,37,37,147,169,74,89,42,146,148,201,76,128,46,185,130,169,44,247,79,131,15,227,186,26,182,143,99,185,79,8,250,48,178,240,34,164,0,5,42,147,5,83,89,165,152,84,105,198,10,57,33,181,42,141,85,44,65,196,42,220,112,120,194,69,180,75,83,66,125,215,161,133,195,29,196,231,35,250,34,219,161,125,219,182,126,104,106,28,95,112,211,123,57,134,68,203,66,199,83,46,152,170,148,166,144,0,197,133,103,130,113,45,176,210,105,166,164,12,102,104,191,195,132,31,218,141,45,15,251,228,134,197,254,167,133,253,15,107,248,55,155,117,54,219,151,100,245,173,164,240,205,36,109,31,237,127,2,5,14,193,196,62,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,203,110,219,48,16,252,21,129,201,209,52,40,241,33,81,183,34,233,193,64,210,6,117,146,75,236,195,146,92,54,2,244,8,40,185,69,106,232,223,75,203,118,28,167,237,169,60,72,218,229,206,236,112,53,220,146,203,225,245,5,73,73,238,49,4,232,59,63,204,175,186,128,243,187,208,89,236,251,249,77,103,161,174,126,129,169,241,14,2,52,56,96,120,132,122,131,253,77,213,15,179,228,28,70,102,228,242,199,180,75,202,167,45,89,12,216,60,44,92,100,87,50,83,78,230,154,114,233,44,21,40,44,5,76,61,101,220,243,204,74,147,59,41,34,216,118,245,166,105,111,113,128,59,24,158,73,185,37,19,91,36,0,39,52,115,178,160,76,10,160,194,21,146,234,76,40,234,92,33,148,66,195,117,193,201,56,35,189,125,198,6,166,166,39,176,72,193,23,26,53,205,37,51,177,187,49,180,176,96,169,247,92,27,37,10,145,162,221,129,15,245,39,224,211,197,211,162,255,250,179,197,176,156,120,75,15,117,143,235,121,204,126,72,124,174,177,193,118,40,183,187,86,44,115,154,106,159,113,42,50,166,168,209,22,227,113,153,97,76,50,7,26,199,8,120,155,102,185,205,115,40,152,151,138,10,163,24,21,133,177,212,96,150,83,212,202,123,39,172,149,218,140,235,139,245,78,162,171,250,151,26,94,31,255,84,250,201,185,100,211,218,174,245,85,104,208,37,241,107,0,59,36,6,250,24,117,109,82,35,184,164,106,125,23,26,24,170,174,157,95,5,132,33,238,5,180,93,112,201,194,237,91,188,156,253,231,247,77,182,171,189,93,86,164,92,253,203,48,135,247,126,60,231,150,249,232,150,21,153,173,200,178,219,4,187,99,228,49,184,126,119,186,169,201,84,242,33,60,218,35,102,218,77,93,31,50,215,48,192,177,240,152,238,92,229,43,116,139,118,121,116,197,196,194,14,139,254,229,113,92,123,109,255,3,187,133,22,190,99,248,18,7,112,210,254,166,242,62,142,241,72,108,50,45,89,30,111,67,142,160,163,61,85,70,11,151,2,213,169,54,158,231,60,243,62,155,208,223,208,99,192,214,226,185,176,84,25,228,74,166,180,240,152,81,145,74,29,241,142,209,232,42,238,132,42,184,115,252,128,239,167,105,239,238,229,65,215,110,84,35,25,199,245,248,27,101,185,213,237,11,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ReadLandingPageFlowElement

		/// <exclude/>
		public class ReadLandingPageFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLandingPageFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLandingPage";
				IsLogging = true;
				SchemaElementUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,208,147,162,124,43,82,39,8,80,52,65,19,164,135,58,135,21,185,84,136,234,5,138,78,235,26,254,247,46,37,199,77,10,23,113,123,105,129,234,32,72,131,217,225,236,139,155,64,214,48,12,239,161,193,96,30,220,162,181,48,116,218,157,158,155,218,161,189,176,221,170,15,78,130,1,173,129,218,124,67,53,225,11,101,220,91,112,64,33,155,229,15,133,101,48,95,30,214,88,6,39,203,192,56,108,6,226,80,8,104,153,149,82,32,139,85,166,88,170,242,152,65,153,23,44,147,37,34,134,161,46,35,156,152,191,18,63,235,154,30,44,78,103,140,242,122,252,188,93,247,158,26,17,32,71,138,25,186,118,7,38,222,196,176,104,161,172,81,209,191,179,43,36,200,89,211,80,54,120,107,26,188,6,75,103,121,157,206,67,68,210,80,15,158,85,163,118,139,175,189,197,97,48,93,251,154,185,122,213,180,207,217,36,128,251,223,157,157,112,244,232,153,215,224,30,70,137,75,178,181,29,93,190,169,42,139,21,56,243,248,220,196,103,92,143,188,227,234,71,1,138,186,116,7,245,10,159,157,249,50,147,51,232,221,148,208,116,60,17,172,169,30,142,206,117,95,177,215,210,141,9,236,159,200,71,106,30,204,33,230,4,62,122,96,82,121,250,92,6,159,46,135,171,47,45,218,27,249,128,13,76,85,187,63,37,244,39,96,81,99,131,173,155,111,32,5,174,117,40,89,20,21,154,165,60,137,24,136,56,102,92,164,105,152,115,129,5,102,91,10,216,27,154,111,184,44,68,90,240,156,9,8,115,42,61,207,24,160,150,44,141,4,102,16,69,82,73,229,67,22,173,51,110,61,77,194,124,83,36,162,80,177,40,24,79,4,103,169,160,128,162,84,25,139,101,38,242,56,73,98,206,227,237,253,148,174,25,250,26,214,119,251,172,62,32,168,89,77,47,218,40,59,184,153,223,163,89,167,103,84,222,85,237,76,91,205,104,138,106,148,190,141,167,239,160,85,30,234,161,154,38,192,247,148,68,116,20,114,46,57,50,29,150,200,210,60,225,76,168,60,98,121,132,97,153,151,28,19,205,105,246,252,227,71,164,171,140,132,250,170,71,11,187,233,8,15,47,207,139,173,243,141,177,93,231,166,114,239,27,123,129,173,215,65,245,17,203,243,206,54,163,175,167,81,166,170,0,79,116,198,144,135,33,85,70,134,12,36,53,67,132,41,10,157,69,18,121,70,198,232,22,242,115,112,211,173,172,220,109,253,48,93,63,127,116,173,252,133,203,226,119,246,255,224,6,30,179,81,255,217,174,252,147,195,189,13,182,223,1,65,118,3,35,87,7,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })));
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
								new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"));
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

		public LeadManagementIdentification(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementIdentification";
			SchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_identificationPassed = () => { return (bool)(true); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementIdentification, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementIdentification, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public virtual Guid LeadId {
			get;
			set;
		}

		private Func<bool> _identificationPassed;
		public virtual bool IdentificationPassed {
			get {
				return (_identificationPassed ?? (_identificationPassed = () => false)).Invoke();
			}
			set {
				_identificationPassed = () => { return value; };
			}
		}

		private ProcessLeadIdentification _leadIdentification;
		public ProcessLeadIdentification LeadIdentification {
			get {
				return _leadIdentification ?? ((_leadIdentification) = new ProcessLeadIdentification(UserConnection, this));
			}
		}

		private ProcessFlowElement _start;
		public ProcessFlowElement Start {
			get {
				return _start ?? (_start = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start",
					SchemaElementUId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _leadIsIdentified;
		public ProcessTerminateEvent LeadIsIdentified {
			get {
				return _leadIsIdentified ?? (_leadIsIdentified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "LeadIsIdentified",
					SchemaElementUId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveLeadHasCommunication;
		public ProcessExclusiveGateway ExclusiveLeadHasCommunication {
			get {
				return _exclusiveLeadHasCommunication ?? (_exclusiveLeadHasCommunication = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveLeadHasCommunication",
					SchemaElementUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveLeadHasCommunication.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _leadDisqualified;
		public ProcessTerminateEvent LeadDisqualified {
			get {
				return _leadDisqualified ?? (_leadDisqualified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "LeadDisqualified",
					SchemaElementUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ReadContactsByLeadCommunicationsFlowElement _readContactsByLeadCommunications;
		public ReadContactsByLeadCommunicationsFlowElement ReadContactsByLeadCommunications {
			get {
				return _readContactsByLeadCommunications ?? (_readContactsByLeadCommunications = new ReadContactsByLeadCommunicationsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactAllFlowElement _changeLeadContactAll;
		public ChangeLeadContactAllFlowElement ChangeLeadContactAll {
			get {
				return _changeLeadContactAll ?? (_changeLeadContactAll = new ChangeLeadContactAllFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactByLeadFlowElement _addContactByLead;
		public AddContactByLeadFlowElement AddContactByLead {
			get {
				return _addContactByLead ?? (_addContactByLead = new AddContactByLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactAdressFlowElement _addContactAdress;
		public AddContactAdressFlowElement AddContactAdress {
			get {
				return _addContactAdress ?? (_addContactAdress = new AddContactAdressFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactWebFlowElement _addContactWeb;
		public AddContactWebFlowElement AddContactWeb {
			get {
				return _addContactWeb ?? (_addContactWeb = new AddContactWebFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ParallelGatewayAddContactCommunicationFlowElement _parallelGatewayAddContactCommunication;
		public ParallelGatewayAddContactCommunicationFlowElement ParallelGatewayAddContactCommunication {
			get {
				return _parallelGatewayAddContactCommunication ?? ((_parallelGatewayAddContactCommunication) = new ParallelGatewayAddContactCommunicationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ParallelGateway1FlowElement _parallelGateway1;
		public ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadContactsByLeadEmailFlowElement _readContactsByLeadEmail;
		public ReadContactsByLeadEmailFlowElement ReadContactsByLeadEmail {
			get {
				return _readContactsByLeadEmail ?? (_readContactsByLeadEmail = new ReadContactsByLeadEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactEmailFlowElement _changeLeadContactEmail;
		public ChangeLeadContactEmailFlowElement ChangeLeadContactEmail {
			get {
				return _changeLeadContactEmail ?? (_changeLeadContactEmail = new ChangeLeadContactEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveInLeadCommunication;
		public ProcessExclusiveGateway ExclusiveInLeadCommunication {
			get {
				return _exclusiveInLeadCommunication ?? (_exclusiveInLeadCommunication = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveInLeadCommunication",
					SchemaElementUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveInLeadCommunication.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadContactsByLeadPhoneFlowElement _readContactsByLeadPhone;
		public ReadContactsByLeadPhoneFlowElement ReadContactsByLeadPhone {
			get {
				return _readContactsByLeadPhone ?? (_readContactsByLeadPhone = new ReadContactsByLeadPhoneFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactPhoneFlowElement _changeLeadContactPhone;
		public ChangeLeadContactPhoneFlowElement ChangeLeadContactPhone {
			get {
				return _changeLeadContactPhone ?? (_changeLeadContactPhone = new ChangeLeadContactPhoneFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayIsLeadSet;
		public ProcessExclusiveGateway ExclusiveGatewayIsLeadSet {
			get {
				return _exclusiveGatewayIsLeadSet ?? (_exclusiveGatewayIsLeadSet = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayIsLeadSet",
					SchemaElementUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayIsLeadSet.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _actionAfterIdentificationScriptTask;
		public ProcessScriptTask ActionAfterIdentificationScriptTask {
			get {
				return _actionAfterIdentificationScriptTask ?? (_actionAfterIdentificationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActionAfterIdentificationScriptTask",
					SchemaElementUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ActionAfterIdentificationScriptTaskExecute,
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
					SchemaElementUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadLandingPageFlowElement _readLandingPage;
		public ReadLandingPageFlowElement ReadLandingPage {
			get {
				return _readLandingPage ?? (_readLandingPage = new ReadLandingPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessConditionalFlow _contactFoundAll;
		public ProcessConditionalFlow ContactFoundAll {
			get {
				return _contactFoundAll ?? (_contactFoundAll = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContactFoundAll",
					SchemaElementUId = new Guid("e86cf8b0-28a2-4a9b-b145-adf2cced025e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowCommunicationAll;
		public ProcessConditionalFlow ConditionalFlowCommunicationAll {
			get {
				return _conditionalFlowCommunicationAll ?? (_conditionalFlowCommunicationAll = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowCommunicationAll",
					SchemaElementUId = new Guid("146a48af-ec3c-47df-b53d-49db5dfca733"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowEmailOnly;
		public ProcessConditionalFlow ConditionalFlowEmailOnly {
			get {
				return _conditionalFlowEmailOnly ?? (_conditionalFlowEmailOnly = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowEmailOnly",
					SchemaElementUId = new Guid("94e08796-33d0-450f-a94d-43d4d8c7e5b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _contactFoundEmail;
		public ProcessConditionalFlow ContactFoundEmail {
			get {
				return _contactFoundEmail ?? (_contactFoundEmail = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContactFoundEmail",
					SchemaElementUId = new Guid("8ad3bb27-05b3-4197-85fe-9fca6ddb677c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowPhonesOnly;
		public ProcessConditionalFlow ConditionalFlowPhonesOnly {
			get {
				return _conditionalFlowPhonesOnly ?? (_conditionalFlowPhonesOnly = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowPhonesOnly",
					SchemaElementUId = new Guid("421b74c1-62c2-430b-965d-8d776c88a27f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _cntactFoundPhone;
		public ProcessConditionalFlow CntactFoundPhone {
			get {
				return _cntactFoundPhone ?? (_cntactFoundPhone = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "CntactFoundPhone",
					SchemaElementUId = new Guid("9bfd01fc-78f4-4b49-a5a3-0359fc93fab2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowLeadUndefined;
		public ProcessConditionalFlow ConditionalFlowLeadUndefined {
			get {
				return _conditionalFlowLeadUndefined ?? (_conditionalFlowLeadUndefined = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowLeadUndefined",
					SchemaElementUId = new Guid("86bf0460-da87-44e8-9e19-16d6bb74396c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _isNotFromLandingFlow;
		public ProcessConditionalFlow IsNotFromLandingFlow {
			get {
				return _isNotFromLandingFlow ?? (_isNotFromLandingFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsNotFromLandingFlow",
					SchemaElementUId = new Guid("b15dccc1-cb8b-4db6-9245-c999d8b93476"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _dontContactFlow;
		public ProcessConditionalFlow DontContactFlow {
			get {
				return _dontContactFlow ?? (_dontContactFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "DontContactFlow",
					SchemaElementUId = new Guid("6e54dca1-2410-4933-8d29-b9c06c6eb9c5"),
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
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[LeadIsIdentified.SchemaElementUId] = new Collection<ProcessFlowElement> { LeadIsIdentified };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ExclusiveLeadHasCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveLeadHasCommunication };
			FlowElements[LeadDisqualified.SchemaElementUId] = new Collection<ProcessFlowElement> { LeadDisqualified };
			FlowElements[ReadContactsByLeadCommunications.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadCommunications };
			FlowElements[ChangeLeadContactAll.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactAll };
			FlowElements[AddContactByLead.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactByLead };
			FlowElements[AddContactAdress.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactAdress };
			FlowElements[AddContactWeb.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactWeb };
			FlowElements[ParallelGatewayAddContactCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGatewayAddContactCommunication };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[ReadContactsByLeadEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadEmail };
			FlowElements[ChangeLeadContactEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactEmail };
			FlowElements[ExclusiveInLeadCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveInLeadCommunication };
			FlowElements[ReadContactsByLeadPhone.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadPhone };
			FlowElements[ChangeLeadContactPhone.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactPhone };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[ActionAfterIdentificationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActionAfterIdentificationScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadLandingPage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLandingPage };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "LeadIsIdentified":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveLeadHasCommunication":
						if (ConditionalFlowCommunicationAllExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadCommunications", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowEmailOnlyExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadEmail", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowPhonesOnlyExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadPhone", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
						break;
					case "LeadDisqualified":
						CompleteProcess();
						break;
					case "ReadContactsByLeadCommunications":
						if (ContactFoundAllExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactAll", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadEmail", e.Context.SenderName));
						break;
					case "ChangeLeadContactAll":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "AddContactByLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGatewayAddContactCommunication", e.Context.SenderName));
						break;
					case "AddContactAdress":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "AddContactWeb":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "ParallelGatewayAddContactCommunication":
						if (ParallelGatewayAddContactCommunication.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactWeb", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactAdress", e.Context.SenderName));
						}
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						}
						break;
					case "ReadContactsByLeadEmail":
						if (ContactFoundEmailExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactEmail", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactByLead", e.Context.SenderName));
						break;
					case "ChangeLeadContactEmail":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ExclusiveInLeadCommunication":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActionAfterIdentificationScriptTask", e.Context.SenderName));
						break;
					case "ReadContactsByLeadPhone":
						if (CntactFoundPhoneExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactPhone", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactByLead", e.Context.SenderName));
						break;
					case "ChangeLeadContactPhone":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "ActionAfterIdentificationScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadIsIdentified", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (IsNotFromLandingFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLandingPage", e.Context.SenderName));
						break;
					case "ReadLandingPage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (DontContactFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveLeadHasCommunication", e.Context.SenderName));
						break;
			}
		}

		private bool ContactFoundAllExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadCommunications", "ContactFoundAll", "((ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowCommunicationAllExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowCommunicationAll", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) != String.Empty)", result);
			return result;
		}

		private bool ConditionalFlowEmailOnlyExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) == String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) == String.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowEmailOnly", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) == String.Empty && ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) == String.Empty", result);
			return result;
		}

		private bool ContactFoundEmailExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadEmail", "ContactFoundEmail", "((ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowPhonesOnlyExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) == String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowPhonesOnly", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) == String.Empty && (((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) != String.Empty || ((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) != String.Empty)", result);
			return result;
		}

		private bool CntactFoundPhoneExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadPhone", "CntactFoundPhone", "((ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsLeadSet", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool IsNotFromLandingFlowExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("WebForm").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("WebFormId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "IsNotFromLandingFlow", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"WebForm\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>(\"WebFormId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private bool DontContactFlowExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLandingPage.ResultEntity.IsColumnValueLoaded(ReadLandingPage.ResultEntity.Schema.Columns.GetByName("CreateContact").ColumnValueName) ? ReadLandingPage.ResultEntity.GetTypedColumnValue<bool>("CreateContact") : false)) == false);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "DontContactFlow", "((ReadLandingPage.ResultEntity.IsColumnValueLoaded(ReadLandingPage.ResultEntity.Schema.Columns.GetByName(\"CreateContact\").ColumnValueName) ? ReadLandingPage.ResultEntity.GetTypedColumnValue<bool>(\"CreateContact\") : false)) == false", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("IdentificationPassed")) {
				writer.WriteValue("IdentificationPassed", IdentificationPassed, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start", string.Empty));
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
			MetaPathParameterValues.Add("1300b53e-296c-4858-8368-493adc25a74c", () => LeadId);
			MetaPathParameterValues.Add("27623c14-f1c7-4872-8f1c-45103cd82954", () => IdentificationPassed);
			MetaPathParameterValues.Add("f7cf3a22-2a33-428e-9e2b-5f3622d92f72", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("a01e5fd1-7cbb-4e06-9188-a9656c381385", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("4db6d4f9-57aa-44ef-8934-56b12a060e0e", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("dc3c82bb-8c59-485f-9376-5880ae2ce035", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("bcf6ac2d-9970-48a9-80e2-c7d41b6c0c2e", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("76636537-e5df-47a7-9eb6-124881330bf3", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("232523cc-cb63-410d-8f7c-58cdcf2ef818", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("6c984967-8a07-4d65-aefc-418e5a11cdcd", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("e3cd6198-af4e-409b-8ba3-0851372ea038", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("7e4ceefa-cd15-47a3-8a3b-c8ad4ed1ef7f", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("0a326237-a485-4b38-9337-3aa27272cdd9", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("f7b52dbf-c358-489e-bf2c-3c4ff7924a2c", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("dd6ab013-fc1e-4bc5-a25b-6855ace31f97", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("c6cfc815-55cb-4def-b83c-14b182d467ce", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("72ded882-b97d-4f56-91cb-1e6e212f4218", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("0a075eb5-bcac-445c-993d-bd329be8d6dc", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("17573208-3be8-4476-9823-f565b0714f28", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("807ae5d1-ceac-47d5-8eb5-4720a6cd38c0", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("5770885f-4a81-42ac-b246-d9db3aa13a28", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("b62c39d0-3349-4a21-9582-0f3e9fab1b13", () => ReadContactsByLeadCommunications.DataSourceFilters);
			MetaPathParameterValues.Add("15307ea3-405b-4286-937e-bbd0152634bb", () => ReadContactsByLeadCommunications.ResultType);
			MetaPathParameterValues.Add("b0de7902-f6c1-44eb-87ff-109bad0eb346", () => ReadContactsByLeadCommunications.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d29cd82a-8e0d-4086-8795-48b2899e16af", () => ReadContactsByLeadCommunications.NumberOfRecords);
			MetaPathParameterValues.Add("daf2cf98-3c7e-4055-b671-143255e4ffb9", () => ReadContactsByLeadCommunications.FunctionType);
			MetaPathParameterValues.Add("34ed4a32-1e5a-4623-ae6a-18a622bf6230", () => ReadContactsByLeadCommunications.AggregationColumnName);
			MetaPathParameterValues.Add("97666c94-b7fa-4cf1-858f-96a7f5e41511", () => ReadContactsByLeadCommunications.OrderInfo);
			MetaPathParameterValues.Add("10568b26-1c18-4f39-9578-4a72a1c5fb66", () => ReadContactsByLeadCommunications.ResultEntity);
			MetaPathParameterValues.Add("935c4f95-44b6-44e3-920e-5b06a85a9a77", () => ReadContactsByLeadCommunications.ResultCount);
			MetaPathParameterValues.Add("567adf56-c83c-4371-b0d7-e3c15c4a747e", () => ReadContactsByLeadCommunications.ResultIntegerFunction);
			MetaPathParameterValues.Add("7ad0d0ed-5315-4834-9632-bc717ea4b547", () => ReadContactsByLeadCommunications.ResultFloatFunction);
			MetaPathParameterValues.Add("06ba8c97-f038-45da-8d5c-e5fa72c64ac0", () => ReadContactsByLeadCommunications.ResultDateTimeFunction);
			MetaPathParameterValues.Add("085f20cb-53af-486b-a15f-5bc389f586df", () => ReadContactsByLeadCommunications.ResultRowsCount);
			MetaPathParameterValues.Add("7b7d4ca0-20b2-450c-a302-c217ce695e2c", () => ReadContactsByLeadCommunications.CanReadUncommitedData);
			MetaPathParameterValues.Add("316aa43c-1aa6-47f1-aaf7-572b6f838fcf", () => ReadContactsByLeadCommunications.ResultEntityCollection);
			MetaPathParameterValues.Add("2cc24615-28c1-4668-8f49-c93ae2c5896a", () => ReadContactsByLeadCommunications.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b4d0581e-c249-4b18-a38c-f40592d4085d", () => ReadContactsByLeadCommunications.IgnoreDisplayValues);
			MetaPathParameterValues.Add("2729cf7a-36f6-4003-b06a-e8cb957b2269", () => ReadContactsByLeadCommunications.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f215686f-4d81-4543-93aa-539f611453e4", () => ReadContactsByLeadCommunications.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9a626ad2-321e-427a-9f24-760d9280a022", () => ChangeLeadContactAll.EntitySchemaUId);
			MetaPathParameterValues.Add("564a7988-620b-401f-9bfc-8041ac06be95", () => ChangeLeadContactAll.IsMatchConditions);
			MetaPathParameterValues.Add("b7b1963b-962d-4921-a62e-3119d14d8a66", () => ChangeLeadContactAll.DataSourceFilters);
			MetaPathParameterValues.Add("5d16c9f4-5c23-4097-8d07-fac1cb716e39", () => ChangeLeadContactAll.RecordColumnValues);
			MetaPathParameterValues.Add("c43dec79-6b59-4fc6-94f0-bcc6a7f8c091", () => AddContactByLead.EntitySchemaId);
			MetaPathParameterValues.Add("61b7d5bc-8334-4d0a-8ec3-aac02f0f6b0d", () => AddContactByLead.DataSourceFilters);
			MetaPathParameterValues.Add("ec4e60e4-4bd2-476d-bfa5-f3879991dce5", () => AddContactByLead.RecordAddMode);
			MetaPathParameterValues.Add("fc9a7fd7-6ae6-4198-801f-ed65a0714560", () => AddContactByLead.FilterEntitySchemaId);
			MetaPathParameterValues.Add("0698fbce-2359-4022-88df-2b5fa4260af7", () => AddContactByLead.RecordDefValues);
			MetaPathParameterValues.Add("77a80f56-4b60-48bc-be27-e96ffd4cc59b", () => AddContactByLead.RecordId);
			MetaPathParameterValues.Add("5a0a517a-3cd6-4838-89ed-dd198ad96f83", () => AddContactAdress.EntitySchemaId);
			MetaPathParameterValues.Add("dcf0939b-5ae1-4506-a7a2-453c0eb2f2d8", () => AddContactAdress.DataSourceFilters);
			MetaPathParameterValues.Add("55cf3377-2bf5-4a73-8eb5-34e7b911258b", () => AddContactAdress.RecordAddMode);
			MetaPathParameterValues.Add("6d55db5f-8e6c-420b-9a07-be564e8b90da", () => AddContactAdress.FilterEntitySchemaId);
			MetaPathParameterValues.Add("6aa29df7-9dcf-4eea-b7dd-70cbb55c6070", () => AddContactAdress.RecordDefValues);
			MetaPathParameterValues.Add("b9f11eba-9282-49e7-842b-28c1d0f2190f", () => AddContactAdress.RecordId);
			MetaPathParameterValues.Add("97a7e2ca-58ad-4a27-8a87-3f50772b77be", () => AddContactWeb.EntitySchemaId);
			MetaPathParameterValues.Add("2f713b4e-bdb9-470a-b959-23af1cb99aaa", () => AddContactWeb.DataSourceFilters);
			MetaPathParameterValues.Add("9021827f-1e50-40f2-8b7f-ec1b0e056ccb", () => AddContactWeb.RecordAddMode);
			MetaPathParameterValues.Add("aa2e3f7d-4042-4910-b0eb-0f5b57896d58", () => AddContactWeb.FilterEntitySchemaId);
			MetaPathParameterValues.Add("7a98d7a0-39d9-4231-b19a-9c603fa6baf0", () => AddContactWeb.RecordDefValues);
			MetaPathParameterValues.Add("89ff5387-057a-41f9-a2cd-98c33da073a9", () => AddContactWeb.RecordId);
			MetaPathParameterValues.Add("d6514abc-f96a-4d19-b5f8-f55b1ac00b83", () => ReadContactsByLeadEmail.DataSourceFilters);
			MetaPathParameterValues.Add("881a211c-0037-4de8-9966-fd5b76082530", () => ReadContactsByLeadEmail.ResultType);
			MetaPathParameterValues.Add("1b0558b6-d02e-43db-a632-da912ff74169", () => ReadContactsByLeadEmail.ReadSomeTopRecords);
			MetaPathParameterValues.Add("38ac0d8a-57fb-4d3c-a724-83243171725c", () => ReadContactsByLeadEmail.NumberOfRecords);
			MetaPathParameterValues.Add("2306c9f4-91b3-4ae6-9d0d-b85b15f043a5", () => ReadContactsByLeadEmail.FunctionType);
			MetaPathParameterValues.Add("91e3ad56-02d2-495e-8f8d-6839c1e13901", () => ReadContactsByLeadEmail.AggregationColumnName);
			MetaPathParameterValues.Add("09b2ffa0-b537-4970-bb51-a8da7fb89215", () => ReadContactsByLeadEmail.OrderInfo);
			MetaPathParameterValues.Add("4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee", () => ReadContactsByLeadEmail.ResultEntity);
			MetaPathParameterValues.Add("f289649e-c0c3-403b-8124-ffe171aafe33", () => ReadContactsByLeadEmail.ResultCount);
			MetaPathParameterValues.Add("e7d2a1ae-2033-4d71-9990-c4c12f4faa89", () => ReadContactsByLeadEmail.ResultIntegerFunction);
			MetaPathParameterValues.Add("681c5445-3ca2-45de-bf7c-0f37318944d1", () => ReadContactsByLeadEmail.ResultFloatFunction);
			MetaPathParameterValues.Add("95b392b6-a727-407b-a3ec-157c1314469b", () => ReadContactsByLeadEmail.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0eadc500-3c91-49a1-8071-9d0668f51d38", () => ReadContactsByLeadEmail.ResultRowsCount);
			MetaPathParameterValues.Add("849f1602-4ec0-45ef-a640-370b4ec656e7", () => ReadContactsByLeadEmail.CanReadUncommitedData);
			MetaPathParameterValues.Add("847ce0c0-4e8f-4238-a637-16f20d906278", () => ReadContactsByLeadEmail.ResultEntityCollection);
			MetaPathParameterValues.Add("1cfe3a33-faaf-4cb5-b49e-d1eadaa81bec", () => ReadContactsByLeadEmail.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("f61ce3ad-7460-43d4-b04a-9a8735ba629d", () => ReadContactsByLeadEmail.IgnoreDisplayValues);
			MetaPathParameterValues.Add("98cf1789-f51a-4231-b152-7212be2cdca3", () => ReadContactsByLeadEmail.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1921c84b-08d6-4bab-b0f8-1e4173f757ea", () => ReadContactsByLeadEmail.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("788c3395-e8dc-443e-9c81-e57decd44c14", () => ChangeLeadContactEmail.EntitySchemaUId);
			MetaPathParameterValues.Add("40c79c51-5e3e-4a77-881f-bfb3b5148e9c", () => ChangeLeadContactEmail.IsMatchConditions);
			MetaPathParameterValues.Add("3da883c3-07af-4baf-9a48-e1f261dbd978", () => ChangeLeadContactEmail.DataSourceFilters);
			MetaPathParameterValues.Add("bec4aa50-4e70-47b5-99c8-d0f15b4b12f8", () => ChangeLeadContactEmail.RecordColumnValues);
			MetaPathParameterValues.Add("55598db2-619f-4f92-a9b5-d03ddb173ed0", () => ReadContactsByLeadPhone.DataSourceFilters);
			MetaPathParameterValues.Add("519549f0-c248-40b5-be93-602f4ff55bac", () => ReadContactsByLeadPhone.ResultType);
			MetaPathParameterValues.Add("c1675f40-4a8b-469f-807f-482b441e6236", () => ReadContactsByLeadPhone.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8aacc82f-451e-44f0-a1ea-c48fac82b9aa", () => ReadContactsByLeadPhone.NumberOfRecords);
			MetaPathParameterValues.Add("1a7cefdb-8943-464e-9818-f056350796f1", () => ReadContactsByLeadPhone.FunctionType);
			MetaPathParameterValues.Add("a45be9e6-9a59-46ac-b1b7-9def07669d0c", () => ReadContactsByLeadPhone.AggregationColumnName);
			MetaPathParameterValues.Add("6b161822-7e93-4124-b2d6-c1605b5f5657", () => ReadContactsByLeadPhone.OrderInfo);
			MetaPathParameterValues.Add("97881864-f21d-4f49-b39f-662c780efdc9", () => ReadContactsByLeadPhone.ResultEntity);
			MetaPathParameterValues.Add("83016a9c-a67e-4328-a96e-bfacfc2c77c6", () => ReadContactsByLeadPhone.ResultCount);
			MetaPathParameterValues.Add("a0d9ba4a-555e-4324-ae31-f59d0233fbc6", () => ReadContactsByLeadPhone.ResultIntegerFunction);
			MetaPathParameterValues.Add("5b48e127-d50b-49a3-8459-4a9a52bf6988", () => ReadContactsByLeadPhone.ResultFloatFunction);
			MetaPathParameterValues.Add("6ef7572f-4836-4cfe-ad97-3868281a4281", () => ReadContactsByLeadPhone.ResultDateTimeFunction);
			MetaPathParameterValues.Add("ce2e72d3-d7a5-4f50-9ecf-44b4bf27b6ea", () => ReadContactsByLeadPhone.ResultRowsCount);
			MetaPathParameterValues.Add("98faeefc-cf3f-4be3-a9b9-40bd344629d3", () => ReadContactsByLeadPhone.CanReadUncommitedData);
			MetaPathParameterValues.Add("e75f4ff2-ebaa-43f4-aff7-36f8fa2f00cd", () => ReadContactsByLeadPhone.ResultEntityCollection);
			MetaPathParameterValues.Add("1a5f9685-0340-43a4-85bd-917ac7f8b75a", () => ReadContactsByLeadPhone.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4a757dc8-11a2-46d0-962c-01dc9f7cf05c", () => ReadContactsByLeadPhone.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d1a04b45-329c-4e0c-90b8-b7463582c944", () => ReadContactsByLeadPhone.ResultCompositeObjectList);
			MetaPathParameterValues.Add("822209b4-c7f7-4d36-9ddf-32a904b93bda", () => ReadContactsByLeadPhone.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("cfc1a8ae-2a77-49bb-a728-a1637ee8c94a", () => ChangeLeadContactPhone.EntitySchemaUId);
			MetaPathParameterValues.Add("5feb2bce-5433-4c25-a83d-3f8d28ccc8ab", () => ChangeLeadContactPhone.IsMatchConditions);
			MetaPathParameterValues.Add("9acd36f8-ce89-4f92-bdb8-e4eea778daf4", () => ChangeLeadContactPhone.DataSourceFilters);
			MetaPathParameterValues.Add("15555f52-d536-4815-a506-977a98d2f0f3", () => ChangeLeadContactPhone.RecordColumnValues);
			MetaPathParameterValues.Add("3719e46d-8e08-48ad-8083-1ccf953996c6", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("08550f59-4992-48fb-b252-df02ec268766", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("44584732-acad-4754-bde4-a1b1cfd19199", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("33aca163-6ecf-4e71-9484-09432fbc4746", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("cd3fabe0-1945-4d5e-9fb8-9e85ee54cc3b", () => ReadLandingPage.DataSourceFilters);
			MetaPathParameterValues.Add("c84ed90e-913c-4d79-be6e-0aeb6dbde695", () => ReadLandingPage.ResultType);
			MetaPathParameterValues.Add("528b68b1-c488-499b-b6a9-98d627973317", () => ReadLandingPage.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7db9bc2b-3431-4feb-8af1-b2fcbc5cf552", () => ReadLandingPage.NumberOfRecords);
			MetaPathParameterValues.Add("50c50a69-929a-4ae1-8501-1657483ac91c", () => ReadLandingPage.FunctionType);
			MetaPathParameterValues.Add("5a09f02d-d645-448c-a427-3dc0ad363ad0", () => ReadLandingPage.AggregationColumnName);
			MetaPathParameterValues.Add("2793b917-606e-429f-8d6b-56caf9a5d36b", () => ReadLandingPage.OrderInfo);
			MetaPathParameterValues.Add("a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76", () => ReadLandingPage.ResultEntity);
			MetaPathParameterValues.Add("e0010511-9818-4608-8cc6-966c057c7fb7", () => ReadLandingPage.ResultCount);
			MetaPathParameterValues.Add("5ce1ad73-33d5-4d54-99dc-103fe2185918", () => ReadLandingPage.ResultIntegerFunction);
			MetaPathParameterValues.Add("f1d51e05-81e8-439e-be55-ef17ce69d451", () => ReadLandingPage.ResultFloatFunction);
			MetaPathParameterValues.Add("5400d0e0-9171-4da4-9833-ee4bc440d882", () => ReadLandingPage.ResultDateTimeFunction);
			MetaPathParameterValues.Add("fe6f5c9f-37df-4b0d-b855-65847152e915", () => ReadLandingPage.ResultRowsCount);
			MetaPathParameterValues.Add("ec12f3b9-746c-4f92-ba49-ce658079412a", () => ReadLandingPage.CanReadUncommitedData);
			MetaPathParameterValues.Add("6dc416c9-504c-4429-b04e-93f543f173c4", () => ReadLandingPage.ResultEntityCollection);
			MetaPathParameterValues.Add("b66e4485-d571-44cb-9e32-b832c83541ca", () => ReadLandingPage.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("1c52f53d-1e03-445c-bcbe-0982a59c336a", () => ReadLandingPage.IgnoreDisplayValues);
			MetaPathParameterValues.Add("aadf92c2-302e-499d-a17e-33c74ef006bd", () => ReadLandingPage.ResultCompositeObjectList);
			MetaPathParameterValues.Add("b3f6ea08-bb3d-48ff-bb96-9f7e3530b585", () => ReadLandingPage.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "IdentificationPassed":
					if (!hasValueToRead) break;
					IdentificationPassed = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ActionAfterIdentificationScriptTaskExecute(ProcessExecutingContext context) {
			ActionAfterIdentification();
			return true;
		}

			
			public virtual void ActionAfterIdentification() {
				string applicationUrl = string.Empty;
				if (Terrasoft.Web.Http.Abstractions.HttpContext.Current != null) {
					applicationUrl = Terrasoft.Web.Common.WebUtilities.GetParentApplicationUrl(Terrasoft.Web.Http.Abstractions.HttpContext.Current.Request);
				}
				var leadQualificationHelper = ClassFactory.Get<LeadQualificationHelper>(new ConstructorArgument[]{
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("applicationUrl", applicationUrl)
				});
				leadQualificationHelper.ActionAfterIdentification(LeadId);
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
			var cloneItem = (LeadManagementIdentification)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

