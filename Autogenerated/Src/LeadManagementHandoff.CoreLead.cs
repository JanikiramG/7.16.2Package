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

	#region Class: LeadManagementHandoffSchema

	/// <exclude/>
	public class LeadManagementHandoffSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementHandoffSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementHandoffSchema(LeadManagementHandoffSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementHandoff";
			UId = new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.15.4.3055";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"LeadManagementHandoff";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			Version = 0;
			PackageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("54a0a9d9-5cdd-45ca-8269-7e1318e707b2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa68c1b9-9e12-4b99-bdde-6eb1806d8874"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,201,150,45,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,203,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,63,126,244,117,192,161,116,80,143,152,76,7,91,18,89,57,167,242,84,81,169,11,160,130,113,73,65,113,69,153,144,76,240,76,2,58,36,73,11,13,150,100,67,239,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,222,173,151,175,230,132,13,124,91,26,8,14,78,105,212,84,230,172,162,2,171,138,42,3,134,58,151,233,170,16,74,112,52,100,211,194,164,176,58,214,83,89,229,41,21,144,58,170,92,90,209,130,129,112,150,27,237,88,74,146,26,93,216,63,245,3,142,163,239,218,114,198,215,248,230,185,143,42,183,222,187,174,158,154,150,36,13,6,184,134,112,42,9,32,67,145,27,160,70,232,156,10,135,113,210,76,91,154,65,37,83,169,144,23,92,146,196,64,31,22,90,114,176,36,177,16,224,59,212,19,174,204,179,143,26,211,140,113,149,23,17,203,51,67,69,150,50,170,10,37,169,179,133,211,152,21,90,87,246,226,215,167,201,199,216,143,87,83,131,131,55,47,182,99,244,175,27,202,217,116,109,24,186,122,161,190,90,203,111,240,41,108,230,190,60,253,216,6,10,49,191,128,200,57,153,70,220,213,30,219,176,111,77,103,125,251,176,113,158,207,17,210,244,48,248,241,226,194,254,113,130,154,36,131,127,56,253,209,173,221,52,134,174,249,143,70,77,226,152,145,35,46,217,42,119,217,65,235,199,190,134,231,245,94,146,119,143,83,23,62,124,70,176,91,68,222,32,74,114,71,114,1,12,180,213,52,55,214,210,117,43,84,90,196,29,69,158,113,133,146,201,42,189,35,81,197,63,112,223,30,198,47,63,219,203,31,216,84,31,223,199,236,155,196,245,5,89,206,127,35,231,124,92,4,29,207,241,252,2,68,247,49,72,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99786611-0f56-4e3c-8f29-a4185ad1f427"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c21a605f-a60b-42ed-9061-294cc87b69a0"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8bb1e66c-1b41-4f67-ab42-57cdc5d866a6"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("745423dc-b077-4526-8e74-98d8ad204cb8"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e1878c2-6cac-4d8b-baa8-a59f16943d8b"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("1053c0e9-6404-4b90-bd4a-07157c475327"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("8bc11220-5b0b-4d4e-a16c-25109fbcecd2"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("952c2d22-d6b6-4a51-82ac-ec6cfa9a867e"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("ff499ce0-d575-4f90-b31d-15c099b5f8ee"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("ddfda365-0d3d-45c9-84c5-ef97a50abd3e"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("7ced0725-a5ff-48ab-8329-db8cd92d45fc"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("1bdef657-82b6-4e4c-9cba-7cc3f773ead3"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("0e7bc406-b400-4ee2-8857-94f4a2ed4291"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("a4c0fd5e-3b7e-4c6a-bf78-0b172e842a9f"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed0eae90-a660-43ec-85fa-c1bc0b2c7a5c"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fb15793-1f5f-4afb-a9c5-7ee6d16f6cd6"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("f119f93a-7a57-4328-9ec1-6701da4a0e61"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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
				UId = new Guid("6b3bdbfb-ea17-43b3-9552-de9277711d72"),
				ContainerUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
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

		protected virtual void InitializeActivityUserTaskBANTParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5141e1f7-4af9-4bf4-b6d1-8874c0d2dc5f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Value = @"Contact customer, specify need, budget, decision-making role.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("5b4637a8-7fc7-40e0-bfac-9cb675816ccf"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0902eded-b1a4-4f75-aa93-09fdf0aac605"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba47d7d3-1ca5-41d1-9d6b-42ce60295158"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fdd5f4d6-8792-40d3-a46d-47a3545e3715"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("5f4c4e07-469e-451a-88f4-305e2f6792b2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("abdfdb50-a1ba-4d57-9207-b1dd297f6e84"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("d6ff80f1-90c6-416a-90bb-260e00d506f7"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e14fc2e-ed85-4967-92f6-4ffd68e2401a"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("0685b12b-443e-4c64-ab26-d4859f0c8c4b"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("53d8ba23-d026-4fd0-9523-ad2d59cb13a1"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("54f32772-50b2-49b4-a2a7-eee12cea8efc"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("531d1563-ba9a-4e91-98ce-d35b182bca5f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fdb90180-2f4b-4831-b679-403593dd3b6f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{cf8af50c-5791-4531-ac0c-21f2700e557b}].[Parameter:{8bc11220-5b0b-4d4e-a16c-25109fbcecd2}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("41dcb696-2cb1-4512-b3cf-dd1a7583a4ff"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("d329e26e-4b48-4034-a14b-d1f9fe83945f"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("a61fc569-1cd9-4ee0-913c-ffb7359a1776"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("f7625075-971c-47b4-b67f-f12b29f07881"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("71e2fad8-087d-4d30-853f-4284671382e2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("b9471d7d-f83c-40ed-8479-ac97045d505d"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("42791514-cf69-4e4b-a09a-b627acdcf9e8"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("85441486-29f4-4732-bedf-744579a8ec72"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("1ec1c9c1-eadf-4d15-a0fa-5e9731a46b43"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("4c515728-a780-4846-a088-022faab38f6a"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Contact customer, get in touch with contact persons, define interest and BANT. As a result, either proceed to handoff, order or continue lead nurturing.",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("5cf10363-3ca3-4fcf-a2e0-2c6f612c9aef"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("38749114-70e5-4e48-85a8-d4f5a5ff24c3"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("725e7498-44eb-49c5-8104-b615cd2a44b3"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("24e0015e-591a-49d6-b47e-f60c309ab061"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("ed86a088-1c5e-4485-b084-878f1a8d39df"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("b14902c4-2013-48e9-b69e-d810c180118b"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("1138fd23-4b02-4812-9de6-6ecb917db660"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("948d7cec-52ca-4a20-9991-67a3f04cc7c2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("4b5d863d-2006-4c46-8f37-592fbfa512c0"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("af9569bc-af68-4326-b7bd-5c4ef9e17ea0"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("e8ffa5ea-c8e8-4fc0-98f4-73f789ed7258"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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
				UId = new Guid("64b8da49-5949-4ca0-b9d2-c4b529a2e6d2"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
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

		protected virtual void InitializeChangeLeadStateToNoInterestParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("2c070493-7483-4c5e-a83b-3eb1c5d78ab7"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c600955c-8b94-4c98-aee1-79c3c61d4140"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24bf952c-9579-4dcf-981f-f2cce1dbc830"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,182,228,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,95,177,101,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,163,121,111,222,60,70,243,189,31,63,250,58,224,80,57,168,71,164,211,193,86,36,211,165,40,108,94,178,44,213,156,113,11,130,169,210,10,166,1,10,238,20,215,153,72,8,109,161,193,138,108,232,189,245,129,80,31,176,25,171,219,249,55,105,24,38,164,247,110,189,124,53,39,108,224,219,210,128,167,224,164,66,197,74,145,104,198,81,107,38,13,24,230,92,174,116,193,37,79,209,144,77,11,231,82,160,80,154,153,88,203,184,118,57,147,90,228,12,184,116,73,6,34,229,186,32,180,70,23,246,79,253,128,227,232,187,182,154,241,53,190,121,238,163,202,173,247,174,171,167,166,37,180,193,0,215,16,78,21,1,76,144,11,3,204,112,37,24,119,88,50,200,149,101,57,232,50,43,37,166,69,90,18,106,160,15,11,45,57,88,66,45,4,248,14,245,132,43,243,236,23,191,242,36,149,162,136,216,52,55,140,231,89,194,100,33,75,230,108,225,20,230,133,82,218,94,252,250,52,249,24,251,241,106,106,112,240,230,197,118,140,254,117,67,53,155,174,13,67,87,47,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,211,105,196,93,237,177,13,251,214,116,214,183,15,27,231,249,28,33,77,15,131,31,47,46,236,31,39,168,9,29,252,195,233,143,110,237,166,49,116,205,127,52,42,141,99,70,142,184,100,171,220,101,7,173,31,251,26,158,215,123,69,222,61,78,93,248,240,25,193,110,17,121,131,168,200,29,17,28,18,80,86,49,97,172,101,235,86,200,172,136,59,138,105,158,74,44,147,82,103,119,36,170,248,7,238,219,195,248,229,103,123,249,3,155,234,227,251,152,125,147,184,190,32,171,249,111,228,156,143,139,160,227,57,158,95,209,224,137,218,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a"),
				ContainerUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,79,27,49,20,252,43,200,112,204,139,252,181,254,200,181,92,144,0,161,66,185,16,14,207,246,115,89,53,201,70,187,155,74,52,202,127,175,179,36,34,169,74,133,144,42,245,80,31,188,218,181,103,230,237,27,143,215,236,172,127,94,18,155,176,59,106,91,236,154,220,143,63,53,45,141,111,218,38,82,215,141,47,155,136,179,250,7,134,25,221,96,139,115,234,169,189,199,217,138,186,203,186,235,71,39,199,48,54,98,103,223,135,85,54,121,88,179,139,158,230,95,46,82,97,231,182,226,20,140,129,164,132,0,109,20,7,31,73,129,228,42,40,39,200,101,35,10,56,54,179,213,124,113,69,61,222,96,255,196,38,107,54,176,21,2,31,164,245,209,26,224,82,40,208,185,18,128,49,25,80,94,25,18,220,248,144,52,219,140,88,23,159,104,142,131,232,43,88,11,204,206,147,135,82,69,0,77,33,128,139,24,33,103,229,131,209,78,11,138,91,240,110,255,43,240,225,244,178,105,190,173,150,99,153,178,136,209,25,48,210,70,208,169,76,152,68,6,158,200,17,5,12,154,199,113,182,142,27,147,20,160,85,84,100,202,246,16,188,7,210,214,230,24,188,14,210,157,62,110,133,82,221,45,103,248,124,255,166,222,53,81,58,153,99,191,106,235,254,121,124,221,244,39,245,162,116,158,186,158,210,11,197,242,200,141,67,146,245,244,197,212,41,155,76,223,178,117,247,188,29,186,117,108,236,175,158,78,217,104,202,110,155,85,27,183,140,106,251,178,239,241,160,192,119,3,126,51,237,199,11,199,0,187,194,5,126,165,246,186,40,14,240,97,233,28,123,28,196,239,74,221,123,226,32,125,197,109,105,178,37,244,165,157,70,130,75,2,193,11,31,178,178,74,230,44,7,244,103,202,165,53,139,72,199,133,189,199,179,1,63,40,191,22,179,63,126,229,203,98,53,155,13,2,221,240,255,219,243,188,43,124,183,114,126,96,228,1,67,147,234,92,83,186,88,124,164,85,27,182,217,140,14,195,227,132,228,153,115,1,73,123,11,218,113,2,228,193,129,180,188,34,239,44,37,147,254,24,158,16,121,148,201,112,168,80,165,66,160,57,32,106,130,104,56,161,181,134,36,55,127,51,60,82,105,17,147,128,42,168,146,221,88,228,61,47,215,128,201,214,120,69,217,144,214,227,74,96,138,138,34,168,138,151,77,65,148,26,121,17,116,129,84,224,36,68,230,239,13,207,109,95,78,216,255,208,124,44,52,239,240,234,95,13,205,227,230,39,76,136,243,144,207,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeLeadNurturingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("091ab17a-49f8-4d9e-be81-1ca9c9dcb055"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6f0df01f-2acd-4bc7-adec-34cfc25c9246"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,75,107,220,48,16,254,47,58,244,100,21,217,150,109,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,95,177,100,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,99,127,143,249,24,205,247,206,127,116,77,192,177,182,208,120,76,166,131,169,9,67,171,37,23,5,197,146,43,202,81,11,10,10,56,69,76,141,201,76,197,180,209,36,233,160,197,154,108,232,189,113,129,36,46,96,235,235,219,249,55,105,24,39,76,238,237,122,249,170,79,216,194,183,69,128,167,96,133,68,73,171,130,45,2,74,81,161,65,83,107,115,169,74,46,120,138,81,96,245,82,9,166,51,80,150,166,86,49,202,45,147,20,140,150,148,41,169,37,242,50,203,181,33,73,131,54,236,159,134,17,189,119,125,87,207,248,90,223,60,15,209,229,166,189,235,155,169,237,72,210,98,128,107,8,167,154,0,50,228,133,6,170,185,44,34,59,86,20,114,105,104,14,170,202,42,129,105,153,86,36,209,48,132,133,150,28,162,148,129,0,223,161,153,112,101,158,93,244,152,229,44,21,69,25,177,105,174,41,207,51,70,69,41,42,106,77,105,37,230,165,148,202,92,242,250,52,185,88,59,127,53,181,56,58,253,18,59,198,252,250,177,158,117,223,133,177,111,22,234,171,245,247,27,124,10,91,184,47,159,126,108,3,133,216,95,64,228,156,76,30,119,141,195,46,236,59,221,27,215,61,108,156,231,115,132,180,3,140,206,95,82,216,63,78,208,144,100,116,15,167,63,166,181,155,124,232,219,255,104,212,36,142,25,57,226,146,173,118,151,29,52,206,15,13,60,175,247,154,188,123,156,250,240,225,51,130,217,42,242,6,81,147,59,82,112,96,32,141,164,133,54,134,174,91,33,178,50,238,40,166,121,42,176,98,149,202,238,72,116,241,15,220,183,7,255,229,103,119,121,3,155,235,227,251,216,125,211,184,190,32,235,249,111,236,156,143,139,161,227,57,158,95,203,128,158,28,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38717ef0-c344-40ce-a5f4-e39c87df0d1d"),
				ContainerUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,83,203,110,219,48,16,252,149,128,201,209,43,240,37,74,244,181,185,4,72,130,160,73,115,137,115,88,146,203,70,168,108,25,122,4,72,13,255,123,105,197,134,237,162,41,140,2,5,122,40,15,20,40,106,102,86,59,59,43,118,209,191,45,137,77,217,3,181,45,118,77,236,179,79,77,75,217,93,219,120,234,186,236,186,241,88,87,223,209,213,116,135,45,206,169,167,246,17,235,129,186,235,170,235,39,103,199,48,54,97,23,175,227,45,155,62,173,216,85,79,243,47,87,33,177,231,70,105,73,17,193,105,171,65,59,39,1,121,46,65,112,21,74,23,130,13,70,36,176,111,234,97,190,184,161,30,239,176,127,97,211,21,27,217,18,129,117,178,176,190,48,192,165,80,160,99,46,0,125,48,160,172,50,36,184,177,46,104,182,158,176,206,191,208,28,71,209,61,88,11,140,165,37,11,69,206,29,104,114,14,74,143,30,98,84,214,25,93,106,65,126,3,222,126,191,7,62,157,95,55,205,183,97,153,201,16,133,247,165,1,35,11,15,58,164,13,131,136,192,3,149,68,14,157,230,62,203,157,10,130,107,3,209,11,3,58,247,37,96,142,2,164,45,67,244,101,94,228,218,156,63,111,132,66,213,45,107,124,123,252,80,239,150,40,156,205,177,31,218,170,127,203,46,171,206,55,175,212,82,120,135,47,143,156,56,36,88,205,222,13,157,177,233,236,35,75,183,207,251,177,83,199,166,254,236,231,140,77,102,236,190,25,90,191,97,84,155,195,174,191,163,2,223,46,248,197,182,91,239,28,35,236,6,23,248,149,218,219,164,56,194,199,171,75,236,113,20,127,72,117,239,136,157,180,57,47,82,131,11,66,155,28,51,18,202,32,16,172,176,46,170,66,201,24,229,136,254,76,49,245,101,225,233,184,176,83,252,26,241,163,242,190,152,221,232,165,55,139,161,174,71,129,110,252,255,205,44,111,11,223,222,92,30,152,120,192,208,132,42,86,20,174,22,127,210,170,53,91,175,39,135,193,9,150,114,103,81,1,161,72,193,17,185,1,231,92,132,220,10,83,8,109,99,140,248,219,224,56,207,189,12,134,67,142,42,64,154,117,14,136,154,192,27,78,88,20,134,36,55,127,51,56,82,105,225,131,128,20,142,148,91,159,228,45,23,2,76,44,140,85,20,13,105,157,9,237,163,55,90,3,41,74,53,218,130,160,76,113,7,10,90,37,195,93,201,173,58,49,56,247,125,154,176,77,96,250,182,114,67,95,53,139,255,145,57,49,50,39,56,245,175,70,230,121,253,3,75,134,78,110,201,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAutoGeneratedPageHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37ca1e6d-f9a7-4c7f-ba6c-9ca142ff1579"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Title",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Proceed to handoff: Information",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("92313c1a-6c83-4de1-b493-4b387b234357"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5854a389-d5a2-4dce-814f-9c06510637e6"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Specify information that is required for proceeding to handoff",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41d66075-70c0-453a-8022-cff5949370b2"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.In,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3111f593-81b1-42b5-99a0-cd853a60b279"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			buttonsParameter.SourceValue = new ProcessSchemaParameterValue(buttonsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""853857d6-cc8a-4f66-a1ca-f7261718597c"",""name"":""SaveButton"",""caption"":""Save"",""style"":""green"",""performValidation"":true,""isEnabled"":true,""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var elementsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d88c0edd-7a1d-4087-b13e-ce975c3e925f"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"Elements",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			elementsParameter.SourceValue = new ProcessSchemaParameterValue(elementsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""3a8ae276-d1a6-4833-8edd-18a3802457a6"",""name"":""LeadType"",""caption"":""Need type"",""controlEditType"":""SelectionField"",""isRequired"":true,""dataFilter"":"""",""controlDataValueType"":""11"",""dataSource"":""e0dbeb22-4932-4eee-a8f2-a247a5fce888""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""396b79de-3b3c-45d3-aea7-bdab8f0a023e"",""name"":""Budget"",""caption"":""Budget, base currency"",""controlEditType"":""4"",""isRequired"":false},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""55254183-6074-4e56-9aab-59ca46e386f2"",""name"":""OpportunityResponsible"",""caption"":""Sales owner"",""controlEditType"":""SelectionField"",""isRequired"":false,""dataFilter"":"""",""controlDataValueType"":""10"",""dataSource"":""16be3651-8fe2-4159-8dd0-a803d4683dd3""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""476a3574-3ae8-49f9-a144-15e4daebec38"",""name"":""OpportunityDepartment"",""caption"":""Sales division"",""controlEditType"":""SelectionField"",""isRequired"":false,""dataFilter"":"""",""controlDataValueType"":""11"",""dataSource"":""5d8456b4-15e0-4de5-b0e5-afb10f6795c0""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""968839fa-bdc5-40db-84fc-b1c7ba66460b"",""name"":""MeetingTime"",""caption"":""Meeting date and time"",""controlEditType"":""DateTimeField"",""isRequired"":false,""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""1cda6777-d842-406e-9075-3c837bf46d26"",""name"":""DecisionDate"",""caption"":""Decision timeline"",""controlEditType"":""DateTimeField"",""isRequired"":false,""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""765a88b1-8502-4f19-801f-b1be417dd065"",""name"":""Comment"",""caption"":""Notes"",""controlEditType"":""1"",""isMultiline"":true,""isRequired"":false}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(elementsParameter);
			var extendedClientModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d35cac3-bad2-40c8-842e-1b639ac400c8"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"ExtendedClientModule",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			extendedClientModuleParameter.SourceValue = new ProcessSchemaParameterValue(extendedClientModuleParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(extendedClientModuleParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f2e508ca-4b2f-4b48-976b-52653e3dbe10"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
			var pressedButtonCodeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("478f0294-5119-41e8-ab5b-bc27d9882a36"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("9d600d04-bc01-4cd3-86a4-a9bb56f488b7"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
				UId = new Guid("a698c3a6-4b9a-4404-9178-0cd67c688925"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("03fc2e34-8cdc-4158-9dd1-dafee46392f4"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Use the page to specify information about customer's budget, decision date, need type (the BANT criteria) and the information required to create an opportunity (owner and sales division).",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97a4e728-73b0-4b7e-8a0e-313bec8ab330"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
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
			var leadTypeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("3a8ae276-d1a6-4833-8edd-18a3802457a6"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadTypeParameter.SourceValue = new ProcessSchemaParameterValue(leadTypeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{5c696704-62e8-4503-86bf-ed66c3dd63d5}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(leadTypeParameter);
			var budgetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("396b79de-3b3c-45d3-aea7-bdab8f0a023e"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"Budget",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			budgetParameter.SourceValue = new ProcessSchemaParameterValue(budgetParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{882bf1d7-3d1f-4208-80ca-bf913c8d4f2f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(budgetParameter);
			var opportunityResponsibleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("55254183-6074-4e56-9aab-59ca46e386f2"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"OpportunityResponsible",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityResponsibleParameter.SourceValue = new ProcessSchemaParameterValue(opportunityResponsibleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(opportunityResponsibleParameter);
			var meetingTimeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("968839fa-bdc5-40db-84fc-b1c7ba66460b"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"MeetingTime",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			meetingTimeParameter.SourceValue = new ProcessSchemaParameterValue(meetingTimeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(meetingTimeParameter);
			var commentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("765a88b1-8502-4f19-801f-b1be417dd065"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"Comment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			commentParameter.SourceValue = new ProcessSchemaParameterValue(commentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0}].[Parameter:{946dd2c0-da26-457d-ad8c-4ba3167aa54d}].[EntityColumn:{070b689f-c9d8-46e3-bb52-bcb1f430f5cf}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(commentParameter);
			var decisionDateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cda6777-d842-406e-9075-3c837bf46d26"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"DecisionDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			decisionDateParameter.SourceValue = new ProcessSchemaParameterValue(decisionDateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{4c3a6f1b-99d3-4baf-8954-076274d0675c}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(decisionDateParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("476a3574-3ae8-49f9-a144-15e4daebec38"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"OpportunityDepartment",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(opportunityDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{a40a64fa-a0ea-40e6-9476-a59c1dfbb93f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
		}

		protected virtual void InitializeReadLeadForHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e73bc51-9c3d-46b9-99dc-388c60d1dae1"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,91,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,201,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,231,63,186,38,224,88,89,104,60,38,211,193,84,36,67,38,24,160,162,66,151,37,21,32,107,170,108,94,83,97,10,100,41,207,121,46,107,146,116,208,98,69,54,244,222,184,64,18,23,176,245,213,237,252,155,52,140,19,38,247,118,189,124,213,39,108,225,219,210,64,100,96,165,138,13,202,60,141,180,88,215,84,106,208,212,90,174,234,66,72,145,161,38,155,22,45,176,96,32,74,90,167,44,143,165,220,208,90,3,82,174,114,205,153,176,38,183,146,36,13,218,176,127,26,70,244,222,245,93,53,227,107,124,243,60,68,149,91,239,93,223,76,109,71,146,22,3,92,67,56,85,4,48,69,145,107,160,90,168,200,110,177,164,192,149,161,28,234,146,149,18,179,34,43,73,162,97,8,11,45,57,24,146,24,8,240,29,154,9,87,230,217,69,141,140,167,153,204,139,136,205,184,166,130,179,148,202,66,150,212,154,194,42,228,133,82,181,185,248,245,105,114,49,118,254,106,106,113,116,250,197,118,140,254,245,99,53,235,190,11,99,223,44,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,39,147,199,93,227,176,11,251,78,247,198,117,15,27,231,249,28,33,237,0,163,243,23,23,246,143,19,52,36,25,221,195,233,143,110,237,38,31,250,246,63,26,53,137,99,70,142,184,100,171,220,101,7,141,243,67,3,207,235,189,34,239,30,167,62,124,248,140,96,182,136,188,65,84,228,142,228,2,82,80,70,209,92,27,67,215,173,144,172,136,59,138,25,207,36,150,105,89,179,59,18,85,252,3,247,237,193,127,249,217,93,254,192,166,250,248,62,102,223,36,174,47,200,106,254,27,57,231,227,34,232,120,142,231,23,149,211,217,112,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c3ef0854-9dec-41d4-8d16-407475422cc6"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("976150fd-e561-4fa6-9f3f-911949e5c42c"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51bcbfaa-b77d-4c21-947e-02e0676d3545"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("663137f9-795a-4269-b94a-83f9c02d10da"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b1c37761-25d6-438c-bdbc-43b2a149b1ca"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("73074895-abf7-4e2d-ad95-2629a87fc3d5"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("69f1e87b-3dd8-44cf-8c4f-97bd0653ad06"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("225fc2e7-3024-4f80-b9c4-c881e8aadeed"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("38d606ea-c1d2-4017-915e-893f7f96a610"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("d8b37a80-9357-459a-9ca1-945f0af37bb5"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("3207b919-eb4b-44b7-9c43-5080d06b54a1"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("f24a8102-fb92-4bc4-b65f-c475f479a843"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("8f0a63b7-c987-4e12-93c8-76a709a96645"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("4af22b59-f62b-47c3-ad50-2c78bf148bf7"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a1770417-d693-4416-9df8-379715d76f1e"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5e6e3bcd-5e15-4652-84f8-98664792001d"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("845950b8-706c-45cb-a415-aa0655156cee"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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
				UId = new Guid("c7919aea-f3b6-4b2d-b0e6-831cf54e90a3"),
				ContainerUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
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

		protected virtual void InitializeReadActivityDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7a60eae-1035-42aa-a3a1-1572936331df"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,111,212,48,20,252,43,149,15,156,226,85,28,59,137,29,78,176,44,104,47,75,37,22,132,212,174,170,23,251,185,107,145,143,109,226,136,86,81,254,59,206,166,11,82,15,168,7,46,72,62,216,207,158,121,51,163,231,241,206,245,31,93,229,177,43,44,84,61,70,195,214,20,36,231,9,66,198,24,77,227,76,81,33,153,161,32,211,132,90,149,150,9,40,46,83,131,36,106,160,198,130,44,232,141,113,158,68,206,99,221,23,55,227,31,82,223,13,24,221,217,243,225,139,62,98,13,95,231,6,90,8,101,36,79,40,8,173,169,40,99,70,75,101,82,42,129,37,90,132,22,86,42,178,104,65,137,220,166,165,166,152,161,160,2,115,77,161,180,57,213,60,99,162,204,76,170,84,78,162,10,173,223,60,158,58,236,123,215,54,197,136,191,247,251,167,83,80,185,244,94,183,213,80,55,36,170,209,195,53,248,99,65,0,99,20,169,6,170,133,74,169,176,152,83,224,202,80,14,101,158,228,18,89,198,2,187,134,147,159,105,201,214,144,200,128,135,111,80,13,120,102,30,93,208,152,240,152,201,52,11,88,198,131,29,158,196,84,102,50,167,214,100,86,33,207,148,42,205,37,175,79,131,11,123,215,239,134,26,59,167,159,99,199,144,95,219,21,163,110,27,223,181,213,76,189,59,63,223,227,163,95,194,125,190,250,190,24,242,161,62,131,200,20,13,61,174,43,135,141,223,52,186,53,174,185,95,56,167,41,64,234,19,116,174,191,164,176,121,24,160,34,81,231,238,143,127,77,107,61,244,190,173,255,35,171,81,176,25,56,194,144,157,229,206,51,104,92,127,170,224,233,124,46,200,155,135,161,245,111,247,208,255,40,174,62,160,117,13,94,189,127,183,219,175,230,202,213,214,44,215,228,5,77,65,110,137,148,178,228,74,100,148,151,202,134,1,49,72,165,65,164,92,165,0,146,113,198,180,94,137,36,87,44,101,130,106,59,255,23,20,37,133,88,1,45,179,36,7,109,116,72,70,222,146,160,255,95,169,186,217,246,159,127,54,151,47,181,132,112,88,133,234,139,194,166,194,58,164,85,140,175,177,49,5,192,245,165,85,49,190,198,212,116,152,109,29,166,176,126,1,177,30,142,224,74,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51205379-8b3b-4d44-91b1-2cf7e081b07f"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9078003-1806-4096-a752-6ce6fcaf6be3"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76950e9e-10e8-40f4-86ff-2e96d8188d1b"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("93775e4e-88f1-48e9-ad74-74ac5f28d089"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("60cd6a65-a50a-4617-80ad-ed2c447da612"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("72a0125d-b3d1-40d6-87c7-019a59320276"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("946dd2c0-da26-457d-ad8c-4ba3167aa54d"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd269b97-48c0-45a2-b046-e6a8730dbc7b"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("af08f6d6-b7c6-43d1-9f43-0d58376f1628"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("1374d32a-f908-40e6-bf89-db89d892800d"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("5b57f2b2-ecee-4016-9433-31ce467f75e4"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("c8013d26-15c8-4309-8bd8-b47ac03d9b59"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("16f2c6ff-c1c8-4618-a4e9-e3c0db708ee5"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("0d16c05d-2fc2-4a8a-8988-a0236870a419"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6aa112f-0172-4d91-a4d7-4aca0c91d611"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa42b756-be31-4168-9f40-03d0cd697284"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("44aa8999-c364-4c34-9712-487ff5e54b10"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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
				UId = new Guid("b5541d21-6f2d-4f0c-b4d2-52124ba20d66"),
				ContainerUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
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

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("de2b38a3-9f52-4d0b-8df6-067cb01d12fa"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Value = @"b0e78c23-7095-4d59-b8eb-c10243bcd67b",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2486b970-ba2a-4d75-ad7e-6a6ca3693558"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0582550-2e0c-4765-8c6b-c7cbbd545084"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("0b9fe44f-dae0-43df-bf4f-456291e2c0f3"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85beb4a5-021f-4174-8075-c753178d9f8c"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,77,111,219,70,16,253,43,2,147,67,11,104,133,253,254,208,181,9,10,1,78,106,212,73,46,150,15,179,187,179,177,0,137,52,72,42,70,42,232,191,119,72,203,141,156,166,106,235,166,104,81,151,7,10,34,119,222,204,206,190,55,51,220,85,207,251,143,55,88,205,171,55,216,182,208,53,165,159,125,215,180,56,59,111,155,132,93,55,59,107,18,172,87,63,65,92,227,57,180,176,193,30,219,119,176,222,98,119,182,234,250,233,228,161,89,53,173,158,127,24,223,86,243,203,93,181,232,113,243,118,145,9,61,233,140,96,161,48,48,50,48,237,162,101,224,179,96,82,71,0,105,117,9,168,200,56,53,235,237,166,126,133,61,156,67,127,93,205,119,213,136,70,0,145,59,11,46,72,166,101,200,4,144,35,243,65,100,102,173,20,74,11,224,49,99,181,159,86,93,186,198,13,140,78,143,141,209,249,36,21,115,60,24,166,179,9,44,122,140,44,9,46,181,138,41,91,23,7,227,195,250,79,134,151,207,46,23,221,15,183,53,182,23,35,238,188,192,186,195,171,25,61,253,236,193,47,201,153,239,140,6,14,33,7,102,82,166,80,77,2,230,165,13,204,161,80,194,163,227,46,202,253,213,179,171,193,99,94,117,55,107,248,248,238,215,142,207,16,242,221,154,155,7,121,63,94,181,91,222,29,223,178,154,47,127,235,0,15,191,119,225,62,60,194,207,79,111,89,77,151,213,69,179,109,211,128,168,134,63,247,217,28,61,240,195,197,190,112,187,191,238,48,70,179,87,80,195,123,108,95,147,199,209,124,124,245,2,122,24,157,191,161,184,239,129,165,226,194,27,235,24,8,149,152,86,146,51,111,189,99,37,219,129,24,54,132,152,71,235,31,177,96,139,117,194,71,6,54,122,254,20,204,61,209,232,73,189,93,175,71,7,221,184,255,129,185,135,192,15,111,94,28,157,212,17,66,147,87,101,133,121,81,63,38,162,125,181,223,79,143,101,146,147,180,81,58,199,82,82,192,116,52,130,1,119,156,169,108,141,18,166,120,161,202,73,153,128,131,32,56,16,227,120,230,76,163,0,22,76,74,204,17,31,139,204,50,136,18,190,190,76,106,188,157,124,191,93,229,111,150,21,73,177,248,128,196,118,195,35,5,16,73,167,9,18,43,69,133,104,181,215,2,211,178,250,246,20,247,31,135,246,191,74,158,140,74,180,51,169,104,202,129,203,133,120,90,168,33,4,49,176,130,68,98,99,48,37,24,113,82,37,37,106,151,188,160,110,36,36,1,120,31,89,148,37,50,110,180,48,209,103,240,58,125,125,149,92,244,237,170,126,79,28,170,19,244,68,238,69,93,154,118,3,253,170,169,39,16,155,109,63,185,25,88,136,153,86,77,250,102,114,13,117,110,74,161,60,77,39,47,235,15,171,182,169,55,88,247,179,215,120,123,182,170,137,151,127,188,59,189,92,227,96,58,223,185,194,149,244,69,49,27,141,165,222,68,13,42,66,162,54,154,117,138,14,36,37,70,237,31,182,51,103,13,80,134,4,243,134,83,251,45,34,80,113,161,220,69,17,81,11,151,51,183,102,104,103,39,53,253,55,236,253,32,217,209,224,26,39,45,118,219,117,63,105,202,151,145,200,245,102,64,56,196,249,223,175,22,137,23,174,173,116,140,110,212,9,98,162,106,161,209,176,160,69,200,201,27,97,163,120,18,213,194,40,73,76,165,158,26,129,164,170,115,241,12,44,41,215,24,154,66,85,118,153,139,112,178,90,96,44,54,198,160,152,7,32,205,0,23,44,112,158,89,178,52,210,58,40,5,165,248,39,71,207,191,34,238,144,45,109,133,107,70,252,16,76,167,76,187,180,160,25,132,72,24,101,40,141,238,247,103,213,63,41,197,113,87,79,101,182,141,50,24,238,168,94,58,4,162,31,90,201,232,195,135,198,50,17,98,81,78,201,82,228,41,29,146,78,169,183,211,32,232,137,103,140,250,19,149,95,170,185,244,249,196,85,214,214,171,156,213,191,85,135,87,251,159,1,20,28,214,87,96,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca953947-82c9-4fca-ad12-345201627164"),
				ContainerUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("f7d955b1-b130-45d2-b90b-36a4a2ff1c1b"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86baa44f-1be5-4c2b-afba-f50c69444878"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad1909b2-86a5-4387-ac62-e67d8d19b991"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,107,109,235,195,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,118,54,133,28,74,233,173,160,195,104,70,239,205,155,199,104,186,247,225,163,111,34,14,149,131,38,32,29,247,182,34,194,42,37,53,34,67,225,36,43,156,176,12,50,233,152,44,107,196,50,23,170,228,53,161,29,180,88,145,21,189,179,62,18,234,35,182,161,186,157,126,147,198,97,68,122,239,150,203,87,115,196,22,190,205,13,10,14,78,105,212,137,49,171,89,129,117,205,148,1,195,156,203,117,45,10,85,112,52,100,213,226,120,205,83,98,174,25,195,10,105,57,211,9,202,80,130,17,160,149,149,14,9,109,208,197,221,211,105,192,16,124,223,85,19,190,198,55,207,167,164,114,237,189,237,155,177,237,8,109,49,194,53,196,99,69,0,51,44,74,3,204,20,186,76,147,162,100,144,107,203,114,168,229,70,42,228,130,75,66,13,156,226,76,75,246,150,80,11,17,190,67,51,226,194,60,249,164,113,147,103,92,149,34,97,121,158,52,230,155,140,41,161,36,115,86,56,141,185,208,186,182,23,191,62,141,62,197,62,92,141,45,14,222,188,216,142,201,191,126,168,38,211,119,113,232,155,153,250,106,121,126,131,79,113,53,247,165,244,99,29,40,166,252,12,34,103,58,6,220,54,30,187,184,235,76,111,125,247,176,114,158,207,9,210,158,96,240,225,226,194,238,113,132,134,208,193,63,28,255,232,214,118,12,177,111,255,163,81,105,26,51,113,164,37,91,228,206,59,104,125,56,53,240,188,220,43,242,238,113,236,227,135,207,8,118,141,200,27,68,69,238,72,89,64,6,218,106,86,26,107,217,178,21,106,35,210,142,34,207,185,66,153,201,122,115,71,146,138,127,224,190,221,135,47,63,187,203,31,88,85,31,222,167,236,155,196,245,5,89,77,127,35,231,124,152,5,29,206,233,252,2,227,206,64,245,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea16bf89-752e-4e21-a5fa-2779bbe6a5de"),
				ContainerUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,152,77,111,27,55,16,134,255,138,160,228,104,10,252,28,146,190,181,77,15,6,146,52,168,211,92,98,31,134,156,97,44,84,150,12,237,42,129,107,248,191,119,118,109,55,118,208,40,70,227,0,81,29,29,86,240,82,195,33,57,124,230,157,241,197,244,105,127,126,198,211,253,233,107,94,175,177,91,181,126,246,203,106,205,179,87,235,85,229,174,155,61,95,85,92,204,255,194,178,224,87,184,198,83,238,121,253,6,23,27,238,158,207,187,126,111,114,215,108,186,55,125,250,126,28,157,238,191,189,152,30,244,124,250,199,1,201,236,58,37,230,218,138,2,168,69,249,16,139,202,6,80,105,44,200,46,178,49,214,138,113,93,45,54,167,203,23,220,227,43,236,79,166,251,23,211,113,54,153,160,84,93,45,129,86,1,29,41,159,188,86,136,158,85,5,205,24,35,176,213,48,189,220,155,118,245,132,79,113,116,250,209,216,27,108,41,115,86,49,104,241,206,165,168,84,177,170,214,92,46,32,147,25,174,131,241,245,239,63,26,190,125,242,124,181,250,115,115,54,179,214,121,83,201,168,80,156,83,190,138,251,172,141,81,208,34,100,199,13,216,251,89,196,172,179,22,15,193,149,32,155,204,73,101,91,156,108,146,57,107,176,80,3,60,57,30,28,209,188,59,91,224,249,155,207,250,59,236,241,29,207,126,250,128,243,126,190,124,55,233,112,193,87,150,103,119,130,112,219,246,226,232,42,150,71,211,253,163,207,69,243,250,251,112,60,164,187,241,252,52,148,71,211,189,163,233,225,106,179,174,195,140,110,248,227,230,104,71,15,250,250,163,254,229,113,243,185,154,99,52,123,129,75,217,209,250,165,120,28,205,199,161,103,216,227,232,252,181,172,251,102,226,98,115,208,209,52,21,25,179,4,11,172,74,100,80,238,75,46,205,69,103,91,179,163,245,239,220,120,205,203,202,119,23,118,159,80,141,246,163,231,143,139,185,185,117,242,102,185,89,44,70,7,221,184,255,225,26,95,47,252,122,228,217,173,248,221,154,97,69,243,54,103,58,88,254,151,163,186,156,94,94,238,221,102,38,4,103,16,114,84,84,130,28,4,214,32,27,241,77,105,67,89,238,112,171,92,205,86,102,114,177,49,215,8,74,91,35,39,209,130,81,88,9,148,203,14,216,104,200,133,252,183,100,134,154,169,53,129,2,27,171,242,36,15,36,137,171,38,150,100,80,176,120,93,103,0,205,57,166,36,204,112,19,174,107,83,40,97,150,60,17,162,207,146,50,0,235,61,153,121,201,76,147,83,236,55,235,121,127,62,59,20,100,58,181,102,164,243,31,228,220,147,156,123,4,108,39,200,241,148,117,68,106,42,104,52,66,142,54,42,139,72,40,242,148,146,201,206,81,134,173,228,164,100,75,51,20,149,27,246,239,173,78,42,233,138,170,180,108,92,77,228,155,109,223,130,156,183,7,221,111,31,150,188,190,58,133,253,134,139,142,143,103,242,246,147,23,191,46,248,148,151,253,254,69,108,218,217,52,240,82,2,136,228,16,169,34,140,43,32,95,75,68,91,124,116,151,98,240,207,141,221,191,112,25,74,204,196,202,21,87,7,19,167,80,36,84,21,194,146,154,70,109,29,95,30,127,137,185,107,30,6,113,234,79,120,178,230,110,179,232,39,171,54,57,27,6,152,198,129,213,228,4,151,180,106,109,246,243,134,222,177,148,11,5,59,158,212,205,122,184,125,143,134,203,12,82,23,56,182,74,194,193,202,131,147,11,145,28,202,229,114,37,85,48,77,87,218,198,229,189,23,246,189,115,41,220,249,106,170,83,81,50,187,242,14,229,32,80,20,45,26,180,84,131,73,217,132,173,92,134,170,27,198,12,170,232,36,138,102,44,136,162,9,105,181,17,85,43,130,153,81,239,42,151,33,216,224,141,108,11,116,244,178,60,177,203,40,39,20,114,69,15,236,18,52,251,224,92,142,42,57,89,13,123,123,44,52,126,173,74,26,40,236,64,106,169,212,4,105,111,164,54,75,68,210,142,36,237,200,67,114,68,110,55,104,68,135,9,67,81,181,72,99,230,193,84,185,163,134,84,140,54,20,110,162,117,180,93,37,185,85,103,131,136,171,175,146,205,124,16,151,169,161,87,34,156,186,66,105,22,90,222,85,26,51,72,138,206,77,36,95,18,147,242,154,100,121,190,201,9,153,26,11,2,120,208,229,193,105,124,193,60,182,123,132,253,163,105,247,200,26,206,220,188,170,26,36,237,105,99,85,177,82,131,54,52,152,76,52,132,215,237,218,255,93,28,163,201,146,66,242,80,120,203,253,244,141,80,33,8,92,36,165,55,25,105,247,42,181,47,136,35,100,136,218,75,249,206,105,192,209,169,36,20,42,38,128,42,89,9,28,133,93,197,113,200,84,108,165,149,149,76,45,38,73,58,251,196,98,103,18,186,164,173,15,17,225,193,113,28,27,202,129,177,199,194,226,215,74,35,75,154,228,98,69,21,179,147,7,51,139,42,54,171,208,250,136,161,85,78,41,237,4,139,236,80,118,40,181,152,134,32,253,31,72,123,148,69,16,37,251,163,100,40,204,186,160,219,202,226,160,136,208,76,81,57,75,127,229,11,54,149,114,240,74,71,233,173,61,105,136,161,238,42,139,166,18,66,28,218,233,228,37,202,26,88,73,187,29,148,52,198,46,150,230,129,236,195,179,248,140,235,188,155,175,150,147,126,126,202,139,249,242,209,48,249,67,31,111,202,85,73,44,197,72,185,138,148,164,228,148,90,91,229,68,85,146,19,153,156,161,22,204,126,43,147,130,46,130,151,146,14,53,75,185,170,89,26,44,47,146,130,210,97,25,106,165,100,183,179,255,212,145,125,160,11,210,55,74,226,18,237,207,45,43,52,94,74,241,192,158,144,11,87,151,190,81,243,72,243,247,35,153,143,5,200,175,21,201,32,105,51,64,25,99,163,165,216,227,160,138,150,7,182,98,116,131,152,67,253,110,129,60,190,252,27,87,141,100,109,49,28,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("96352b96-718c-4854-ab6d-31d33673a18b"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702f5fbb-ed10-4780-81d7-ed81fe787102"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("24e70e39-6f35-420e-8745-11cb3e30fc29"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,127,200,150,228,30,183,219,178,80,210,64,183,37,144,44,97,36,141,178,2,127,197,150,105,130,241,127,175,108,103,83,200,161,148,222,10,58,140,198,122,111,222,60,207,76,247,110,248,228,42,143,125,105,161,26,48,26,15,166,36,5,7,203,10,174,104,174,117,76,25,15,145,176,133,164,25,160,50,134,51,203,84,78,162,6,106,44,201,134,222,27,231,73,228,60,214,67,121,59,253,38,245,253,136,209,189,93,47,223,244,25,107,248,190,20,96,9,88,33,81,82,158,199,138,50,84,161,128,6,77,173,205,164,42,152,96,9,106,178,105,97,8,104,83,38,40,136,92,80,102,211,16,41,145,82,43,181,74,243,140,89,133,138,68,190,119,245,71,240,120,116,53,94,67,31,148,133,130,199,118,73,109,26,42,180,126,255,212,245,56,12,174,109,202,9,95,227,227,115,23,218,216,196,237,218,106,172,27,18,5,56,92,131,63,151,4,48,70,150,107,160,154,201,60,148,71,78,33,147,38,88,161,120,202,5,38,69,194,73,164,161,243,11,45,57,24,18,25,240,240,3,170,17,87,230,201,133,38,210,44,78,68,94,4,108,146,105,202,178,52,166,162,16,156,90,83,88,137,89,33,165,50,23,67,63,143,46,196,110,184,26,107,236,157,126,249,47,24,12,110,251,114,210,109,227,251,182,90,168,175,214,231,71,124,242,155,251,47,159,110,182,134,124,200,47,32,50,71,227,128,187,202,97,227,247,141,110,141,107,30,54,206,121,14,144,186,131,222,13,23,23,246,143,35,84,36,234,221,195,249,143,110,237,198,193,183,245,127,212,106,212,93,134,98,149,187,12,169,113,67,87,193,243,122,47,201,187,199,177,245,31,190,32,152,45,34,111,16,37,185,35,57,131,24,164,145,97,45,140,161,235,84,136,52,172,5,199,36,75,4,242,152,171,244,142,4,21,255,192,125,123,24,190,254,108,46,75,178,169,62,189,15,217,55,137,215,225,46,167,191,145,51,159,22,65,167,57,156,95,86,230,180,189,235,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa996c30-4714-41b7-ba32-536d65ced754"),
				ContainerUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,77,79,27,49,16,253,43,200,112,204,68,254,90,127,228,86,149,11,18,80,84,40,23,194,97,108,143,33,106,146,141,118,55,173,40,202,127,175,179,4,65,170,66,163,170,149,80,213,61,120,181,107,191,121,99,191,55,158,123,118,208,221,45,136,141,216,5,53,13,182,117,238,134,239,235,134,134,103,77,29,169,109,135,199,117,196,233,228,27,134,41,157,97,131,51,234,168,185,196,233,146,218,227,73,219,13,246,182,97,108,192,14,190,244,179,108,116,117,207,142,58,154,125,58,74,37,122,148,222,5,226,4,49,136,8,90,10,130,224,132,0,47,83,8,33,43,68,84,5,28,235,233,114,54,63,161,14,207,176,187,101,163,123,214,71,43,1,66,228,81,38,195,161,66,149,64,59,205,1,81,151,120,134,19,90,107,72,114,195,86,3,214,198,91,154,97,79,250,4,214,2,179,243,228,193,86,60,128,166,16,192,69,140,144,179,242,193,148,96,130,226,26,188,89,255,4,188,218,63,174,235,207,203,197,80,74,165,69,76,2,170,160,20,232,88,232,61,47,249,155,108,141,87,148,13,105,61,180,232,185,231,133,161,82,161,2,93,121,87,246,23,20,112,36,242,220,72,19,43,179,127,189,38,74,147,118,49,197,187,203,23,249,206,59,188,161,225,187,175,56,233,38,243,155,189,22,167,244,128,92,108,137,240,28,123,63,126,208,114,204,70,227,151,212,220,188,207,251,67,218,214,243,71,41,199,108,48,102,231,245,178,137,235,136,106,253,241,120,180,61,3,223,60,240,147,225,241,121,136,209,195,78,112,94,118,212,156,22,198,30,222,79,29,98,135,61,249,69,201,251,49,112,144,190,226,86,100,176,132,190,136,101,36,184,36,16,188,240,197,40,86,201,156,101,143,254,72,153,26,154,71,218,78,108,23,169,122,124,207,252,148,204,163,235,202,159,249,114,58,237,9,218,126,255,107,27,111,18,223,204,28,62,211,239,89,132,58,77,242,132,210,209,252,119,142,106,197,86,171,193,243,154,177,60,155,236,180,131,202,39,7,58,4,15,168,139,167,84,240,60,219,224,50,134,240,139,154,65,39,44,169,98,123,83,106,134,23,172,115,92,131,171,188,215,92,9,158,140,251,243,53,51,102,31,154,68,205,152,189,102,244,173,69,255,190,167,149,172,208,170,224,128,103,109,65,107,228,80,14,80,130,53,188,216,210,113,174,48,190,230,233,157,19,123,243,158,182,50,196,192,203,197,104,75,73,106,233,28,32,175,18,72,27,172,9,49,106,74,249,85,79,251,32,173,143,214,0,151,162,84,119,174,4,96,76,6,148,87,134,4,55,62,36,253,55,251,64,202,34,70,103,192,72,91,250,88,42,3,166,114,87,241,68,142,40,96,208,60,14,141,201,74,81,169,217,170,92,55,165,87,197,12,88,174,46,48,166,178,218,83,204,6,227,142,125,224,148,40,237,205,176,91,54,147,238,110,120,94,218,64,11,13,97,186,251,223,13,118,236,6,59,8,246,86,43,231,122,245,29,108,182,158,127,159,9,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadHandoffProcess = CreateLeadHandoffProcessLaneSet();
			LaneSets.Add(schemaLeadHandoffProcess);
			ProcessSchemaLane schemaLeadHandoff = CreateLeadHandoffLane();
			schemaLeadHandoffProcess.Lanes.Add(schemaLeadHandoff);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminatenurturing = CreateTerminateNurturingTerminateEvent();
			FlowElements.Add(terminatenurturing);
			ProcessSchemaExclusiveGateway exclusivegatewayleaddefined = CreateExclusiveGatewayLeadDefinedExclusiveGateway();
			FlowElements.Add(exclusivegatewayleaddefined);
			ProcessSchemaTerminateEvent terminateleadundefined = CreateTerminateLeadUndefinedTerminateEvent();
			FlowElements.Add(terminateleadundefined);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask activityusertaskbant = CreateActivityUserTaskBANTUserTask();
			FlowElements.Add(activityusertaskbant);
			ProcessSchemaUserTask changeleadstatetonointerest = CreateChangeLeadStateToNoInterestUserTask();
			FlowElements.Add(changeleadstatetonointerest);
			ProcessSchemaUserTask changeleadnurturing = CreateChangeLeadNurturingUserTask();
			FlowElements.Add(changeleadnurturing);
			ProcessSchemaTerminateEvent terminateopportunity = CreateTerminateOpportunityTerminateEvent();
			FlowElements.Add(terminateopportunity);
			ProcessSchemaTerminateEvent terminatenointerest = CreateTerminateNoInterestTerminateEvent();
			FlowElements.Add(terminatenointerest);
			ProcessSchemaUserTask autogeneratedpagehandoff = CreateAutoGeneratedPageHandoffUserTask();
			FlowElements.Add(autogeneratedpagehandoff);
			ProcessSchemaUserTask readleadforhandoff = CreateReadLeadForHandoffUserTask();
			FlowElements.Add(readleadforhandoff);
			ProcessSchemaUserTask readactivitydata = CreateReadActivityDataUserTask();
			FlowElements.Add(readactivitydata);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaUserTask changedatausertask2 = CreateChangeDataUserTask2UserTask();
			FlowElements.Add(changedatausertask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow9ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow7ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5b260b1a-a023-4cd9-a40d-481707a20898"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("c46387cf-300b-4cd8-be2d-4740b8665e12"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(182, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowLeadDefined",
				UId = new Guid("ec60176a-01ca-46d0-bf66-047ed4a197d9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(242, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("f4359b3c-140b-4cfa-a64a-624975aad45f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(566, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow9ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow9",
				UId = new Guid("1c27d27e-3f1d-4f64-a277-78d7380f5bb1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(560, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("e07f0e4a-f36b-1410-6698-00155d043204"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow7ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow7",
				UId = new Guid("37f09d58-5453-451a-97f7-c4f7dcacee68"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(582, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("d76ddb1d-3dc5-4e4a-a026-c27588143f72"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(956, 295),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("4c30ec94-2c81-4c4f-889c-bea3f5a1139b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(923, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("31b52b04-44cf-4b5c-9b9b-5d4441942c8f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(956, 180),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("da8b2a97-17f6-4b09-944c-d3169e2a7cf5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(712, 163),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("98857f24-89e8-4af8-bd7b-bd7edc0c46e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(353, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("23ff5267-6922-4cdf-bc26-a9d0f2ececcd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(326, 164),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("d87d32bc-f36b-1410-6598-00155d043204"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("528b01b5-68f3-4731-884e-9434c98dfe97"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(1148, 189),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1251ae43-7225-4df5-993b-23aae9b2351a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(952, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("b189122e-cd60-4368-8d1c-eed898c517dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2dc83e6e-1ed4-44d5-8886-72aa55f8985d"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(1162, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("8cdb95ca-c8ea-4880-b7cc-741fa584081f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
				ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
					{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
						new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a"),
					}},
				}
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("31f7cb76-83b3-441e-ba96-e7cef52d36de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadHandoffProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadHandoffProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c46f8bb0-50e4-4535-913d-d89bd088077f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadHandoffProcess",
				Position = new Point(5, 5),
				Size = new Size(1232, 599),
				UseBackgroundMode = false
			};
			return schemaLeadHandoffProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadHandoffLane() {
			ProcessSchemaLane schemaLeadHandoff = new ProcessSchemaLane(this) {
				UId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("c46f8bb0-50e4-4535-913d-d89bd088077f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadHandoff",
				Position = new Point(29, 0),
				Size = new Size(1203, 599),
				UseBackgroundMode = false
			};
			return schemaLeadHandoff;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"Start",
				Position = new Point(50, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNurturingTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateNurturing",
				Position = new Point(673, 282),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayLeadDefinedExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ExclusiveGatewayLeadDefined",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(120, 156),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateLeadUndefinedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateLeadUndefined",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(134, 289),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(218, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateActivityUserTaskBANTUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ActivityUserTaskBANT",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(337, 156),
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeActivityUserTaskBANTParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadStateToNoInterestUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeLeadStateToNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 387),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadStateToNoInterestParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadNurturingUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeLeadNurturing",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 268),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadNurturingParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateOpportunityTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateOpportunity",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1149, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNoInterestTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"TerminateNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(673, 401),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"AutoGeneratedPageHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(785, 156),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAutoGeneratedPageHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadForHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ReadLeadForHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(652, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadForHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadActivityDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ReadActivityData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(526, 156),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadActivityDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("80b19196-e5d8-462a-b1ba-f02f4dd04777"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"AddDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(911, 156),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("2dc83e6e-1ed4-44d5-8886-72aa55f8985d"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1037, 156),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("329898b3-751a-44ed-9cd2-058defed0313"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"ChangeDataUserTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1039, 34),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementHandoff(userConnection);
		}

		public override object Clone() {
			return new LeadManagementHandoffSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ee7590a-758b-4ee3-990c-188743946765"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementHandoff

	/// <exclude/>
	public class LeadManagementHandoff : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadHandoff

		/// <exclude/>
		public class ProcessLeadHandoff : ProcessLane
		{

			public ProcessLeadHandoff(UserConnection userConnection, LeadManagementHandoff process)
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

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,201,150,45,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,203,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,63,126,244,117,192,161,116,80,143,152,76,7,91,18,89,57,167,242,84,81,169,11,160,130,113,73,65,113,69,153,144,76,240,76,2,58,36,73,11,13,150,100,67,239,173,15,36,241,1,155,177,188,157,127,147,134,97,194,228,222,173,151,175,230,132,13,124,91,26,8,14,78,105,212,84,230,172,162,2,171,138,42,3,134,58,151,233,170,16,74,112,52,100,211,194,164,176,58,214,83,89,229,41,21,144,58,170,92,90,209,130,129,112,150,27,237,88,74,146,26,93,216,63,245,3,142,163,239,218,114,198,215,248,230,185,143,42,183,222,187,174,158,154,150,36,13,6,184,134,112,42,9,32,67,145,27,160,70,232,156,10,135,113,210,76,91,154,65,37,83,169,144,23,92,146,196,64,31,22,90,114,176,36,177,16,224,59,212,19,174,204,179,143,26,211,140,113,149,23,17,203,51,67,69,150,50,170,10,37,169,179,133,211,152,21,90,87,246,226,215,167,201,199,216,143,87,83,131,131,55,47,182,99,244,175,27,202,217,116,109,24,186,122,161,190,90,203,111,240,41,108,230,190,60,253,216,6,10,49,191,128,200,57,153,70,220,213,30,219,176,111,77,103,125,251,176,113,158,207,17,210,244,48,248,241,226,194,254,113,130,154,36,131,127,56,253,209,173,221,52,134,174,249,143,70,77,226,152,145,35,46,217,42,119,217,65,235,199,190,134,231,245,94,146,119,143,83,23,62,124,70,176,91,68,222,32,74,114,71,114,1,12,180,213,52,55,214,210,117,43,84,90,196,29,69,158,113,133,146,201,42,189,35,81,197,63,112,223,30,198,47,63,219,203,31,216,84,31,223,199,236,155,196,245,5,89,206,127,35,231,124,92,4,29,207,241,252,2,68,247,49,72,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })));
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

		#region Class: ActivityUserTaskBANTFlowElement

		/// <exclude/>
		public class ActivityUserTaskBANTFlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTaskBANTFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTaskBANT";
				IsLogging = true;
				SchemaElementUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_lead = () => (Guid)((process.LeadId));
				_account = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.ActivityUserTaskBANT.Parameters.Recommendation.Value"));
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

			private int _remindBefore = 0;
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

			private bool _showExecutionPage = true;
			public override bool ShowExecutionPage {
				get {
					return _showExecutionPage;
				}
				set {
					_showExecutionPage = value;
				}
			}

			internal Func<Guid> _lead;
			public override Guid Lead {
				get {
					return (_lead ?? (_lead = () => Guid.Empty)).Invoke();
				}
				set {
					_lead = () => { return value; };
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

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.ActivityUserTaskBANT.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"89a7d2c0-103f-4f41-87f7-265a34bf1d89\",\"e07f0e4a-f36b-1410-6698-00155d043204\",\"a08e24ec-c5d1-4951-b49f-5e70dde6a7d9\",\"d87d32bc-f36b-1410-6598-00155d043204\",\"fdc13e7b-c600-487f-a398-7240d059ee6a\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: ChangeLeadStateToNoInterestFlowElement

		/// <exclude/>
		public class ChangeLeadStateToNoInterestFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadStateToNoInterestFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadStateToNoInterest";
				IsLogging = true;
				SchemaElementUId = new Guid("b880e90f-00c4-47a6-9cb8-73750ad9d396");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("f78066d3-a73e-4e86-bb99-e477fcb94b28"));
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("51adc3ec-3503-4b10-a00b-8be3b0e11f08"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_QualifyStatus;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,127,72,182,228,30,151,109,89,40,105,160,105,41,36,75,24,73,163,172,192,95,177,101,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,163,121,111,222,60,70,243,189,31,63,250,58,224,80,57,168,71,164,211,193,86,36,211,165,40,108,94,178,44,213,156,113,11,130,169,210,10,166,1,10,238,20,215,153,72,8,109,161,193,138,108,232,189,245,129,80,31,176,25,171,219,249,55,105,24,38,164,247,110,189,124,53,39,108,224,219,210,128,167,224,164,66,197,74,145,104,198,81,107,38,13,24,230,92,174,116,193,37,79,209,144,77,11,231,82,160,80,154,153,88,203,184,118,57,147,90,228,12,184,116,73,6,34,229,186,32,180,70,23,246,79,253,128,227,232,187,182,154,241,53,190,121,238,163,202,173,247,174,171,167,166,37,180,193,0,215,16,78,21,1,76,144,11,3,204,112,37,24,119,88,50,200,149,101,57,232,50,43,37,166,69,90,18,106,160,15,11,45,57,88,66,45,4,248,14,245,132,43,243,236,23,191,242,36,149,162,136,216,52,55,140,231,89,194,100,33,75,230,108,225,20,230,133,82,218,94,252,250,52,249,24,251,241,106,106,112,240,230,197,118,140,254,117,67,53,155,174,13,67,87,47,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,211,105,196,93,237,177,13,251,214,116,214,183,15,27,231,249,28,33,77,15,131,31,47,46,236,31,39,168,9,29,252,195,233,143,110,237,166,49,116,205,127,52,42,141,99,70,142,184,100,171,220,101,7,173,31,251,26,158,215,123,69,222,61,78,93,248,240,25,193,110,17,121,131,168,200,29,17,28,18,80,86,49,97,172,101,235,86,200,172,136,59,138,105,158,74,44,147,82,103,119,36,170,248,7,238,219,195,248,229,103,123,249,3,155,234,227,251,152,125,147,184,190,32,171,249,111,228,156,143,139,160,227,57,158,95,209,224,137,218,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,79,27,49,20,252,43,200,112,204,139,252,181,254,200,181,92,144,0,161,66,185,16,14,207,246,115,89,53,201,70,187,155,74,52,202,127,175,179,36,34,169,74,133,144,42,245,80,31,188,218,181,103,230,237,27,143,215,236,172,127,94,18,155,176,59,106,91,236,154,220,143,63,53,45,141,111,218,38,82,215,141,47,155,136,179,250,7,134,25,221,96,139,115,234,169,189,199,217,138,186,203,186,235,71,39,199,48,54,98,103,223,135,85,54,121,88,179,139,158,230,95,46,82,97,231,182,226,20,140,129,164,132,0,109,20,7,31,73,129,228,42,40,39,200,101,35,10,56,54,179,213,124,113,69,61,222,96,255,196,38,107,54,176,21,2,31,164,245,209,26,224,82,40,208,185,18,128,49,25,80,94,25,18,220,248,144,52,219,140,88,23,159,104,142,131,232,43,88,11,204,206,147,135,82,69,0,77,33,128,139,24,33,103,229,131,209,78,11,138,91,240,110,255,43,240,225,244,178,105,190,173,150,99,153,178,136,209,25,48,210,70,208,169,76,152,68,6,158,200,17,5,12,154,199,113,182,142,27,147,20,160,85,84,100,202,246,16,188,7,210,214,230,24,188,14,210,157,62,110,133,82,221,45,103,248,124,255,166,222,53,81,58,153,99,191,106,235,254,121,124,221,244,39,245,162,116,158,186,158,210,11,197,242,200,141,67,146,245,244,197,212,41,155,76,223,178,117,247,188,29,186,117,108,236,175,158,78,217,104,202,110,155,85,27,183,140,106,251,178,239,241,160,192,119,3,126,51,237,199,11,199,0,187,194,5,126,165,246,186,40,14,240,97,233,28,123,28,196,239,74,221,123,226,32,125,197,109,105,178,37,244,165,157,70,130,75,2,193,11,31,178,178,74,230,44,7,244,103,202,165,53,139,72,199,133,189,199,179,1,63,40,191,22,179,63,126,229,203,98,53,155,13,2,221,240,255,219,243,188,43,124,183,114,126,96,228,1,67,147,234,92,83,186,88,124,164,85,27,182,217,140,14,195,227,132,228,153,115,1,73,123,11,218,113,2,228,193,129,180,188,34,239,44,37,147,254,24,158,16,121,148,201,112,168,80,165,66,160,57,32,106,130,104,56,161,181,134,36,55,127,51,60,82,105,17,147,128,42,168,146,221,88,228,61,47,215,128,201,214,120,69,217,144,214,227,74,96,138,138,34,168,138,151,77,65,148,26,121,17,116,129,84,224,36,68,230,239,13,207,109,95,78,216,255,208,124,44,52,239,240,234,95,13,205,227,230,39,76,136,243,144,207,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeLeadStateToNoInterest.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: ChangeLeadNurturingFlowElement

		/// <exclude/>
		public class ChangeLeadNurturingFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadNurturingFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadNurturing";
				IsLogging = true;
				SchemaElementUId = new Guid("6afd73b3-e775-41ce-b0b8-a700f595514c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("5b3d1046-fc16-45c8-a5a1-298dfc857546"));
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("14cfc644-e3ed-497e-8279-ed4319bb8093"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_QualifyStatus;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,75,107,220,48,16,254,47,58,244,100,21,217,150,109,201,61,46,219,178,80,210,64,211,82,72,150,48,146,70,89,129,95,177,100,154,96,246,191,87,182,179,41,228,80,74,111,5,29,70,99,127,143,249,24,205,247,206,127,116,77,192,177,182,208,120,76,166,131,169,9,67,171,37,23,5,197,146,43,202,81,11,10,10,56,69,76,141,201,76,197,180,209,36,233,160,197,154,108,232,189,113,129,36,46,96,235,235,219,249,55,105,24,39,76,238,237,122,249,170,79,216,194,183,69,128,167,96,133,68,73,171,130,45,2,74,81,161,65,83,107,115,169,74,46,120,138,81,96,245,82,9,166,51,80,150,166,86,49,202,45,147,20,140,150,148,41,169,37,242,50,203,181,33,73,131,54,236,159,134,17,189,119,125,87,207,248,90,223,60,15,209,229,166,189,235,155,169,237,72,210,98,128,107,8,167,154,0,50,228,133,6,170,185,44,34,59,86,20,114,105,104,14,170,202,42,129,105,153,86,36,209,48,132,133,150,28,162,148,129,0,223,161,153,112,101,158,93,244,152,229,44,21,69,25,177,105,174,41,207,51,70,69,41,42,106,77,105,37,230,165,148,202,92,242,250,52,185,88,59,127,53,181,56,58,253,18,59,198,252,250,177,158,117,223,133,177,111,22,234,171,245,247,27,124,10,91,184,47,159,126,108,3,133,216,95,64,228,156,76,30,119,141,195,46,236,59,221,27,215,61,108,156,231,115,132,180,3,140,206,95,82,216,63,78,208,144,100,116,15,167,63,166,181,155,124,232,219,255,104,212,36,142,25,57,226,146,173,118,151,29,52,206,15,13,60,175,247,154,188,123,156,250,240,225,51,130,217,42,242,6,81,147,59,82,112,96,32,141,164,133,54,134,174,91,33,178,50,238,40,166,121,42,176,98,149,202,238,72,116,241,15,220,183,7,255,229,103,119,121,3,155,235,227,251,216,125,211,184,190,32,235,249,111,236,156,143,139,161,227,57,158,95,203,128,158,28,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,83,203,110,219,48,16,252,149,128,201,209,43,240,37,74,244,181,185,4,72,130,160,73,115,137,115,88,146,203,70,168,108,25,122,4,72,13,255,123,105,197,134,237,162,41,140,2,5,122,40,15,20,40,106,102,86,59,59,43,118,209,191,45,137,77,217,3,181,45,118,77,236,179,79,77,75,217,93,219,120,234,186,236,186,241,88,87,223,209,213,116,135,45,206,169,167,246,17,235,129,186,235,170,235,39,103,199,48,54,97,23,175,227,45,155,62,173,216,85,79,243,47,87,33,177,231,70,105,73,17,193,105,171,65,59,39,1,121,46,65,112,21,74,23,130,13,70,36,176,111,234,97,190,184,161,30,239,176,127,97,211,21,27,217,18,129,117,178,176,190,48,192,165,80,160,99,46,0,125,48,160,172,50,36,184,177,46,104,182,158,176,206,191,208,28,71,209,61,88,11,140,165,37,11,69,206,29,104,114,14,74,143,30,98,84,214,25,93,106,65,126,3,222,126,191,7,62,157,95,55,205,183,97,153,201,16,133,247,165,1,35,11,15,58,164,13,131,136,192,3,149,68,14,157,230,62,203,157,10,130,107,3,209,11,3,58,247,37,96,142,2,164,45,67,244,101,94,228,218,156,63,111,132,66,213,45,107,124,123,252,80,239,150,40,156,205,177,31,218,170,127,203,46,171,206,55,175,212,82,120,135,47,143,156,56,36,88,205,222,13,157,177,233,236,35,75,183,207,251,177,83,199,166,254,236,231,140,77,102,236,190,25,90,191,97,84,155,195,174,191,163,2,223,46,248,197,182,91,239,28,35,236,6,23,248,149,218,219,164,56,194,199,171,75,236,113,20,127,72,117,239,136,157,180,57,47,82,131,11,66,155,28,51,18,202,32,16,172,176,46,170,66,201,24,229,136,254,76,49,245,101,225,233,184,176,83,252,26,241,163,242,190,152,221,232,165,55,139,161,174,71,129,110,252,255,205,44,111,11,223,222,92,30,152,120,192,208,132,42,86,20,174,22,127,210,170,53,91,175,39,135,193,9,150,114,103,81,1,161,72,193,17,185,1,231,92,132,220,10,83,8,109,99,140,248,219,224,56,207,189,12,134,67,142,42,64,154,117,14,136,154,192,27,78,88,20,134,36,55,127,51,56,82,105,225,131,128,20,142,148,91,159,228,45,23,2,76,44,140,85,20,13,105,157,9,237,163,55,90,3,41,74,53,218,130,160,76,113,7,10,90,37,195,93,201,173,58,49,56,247,125,154,176,77,96,250,182,114,67,95,53,139,255,145,57,49,50,39,56,245,175,70,230,121,253,3,75,134,78,110,201,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeLeadNurturing.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: AutoGeneratedPageHandoffFlowElement

		/// <exclude/>
		public class AutoGeneratedPageHandoffFlowElement : AutoGeneratedPageUserTask
		{

			#region Constructors: Public

			public AutoGeneratedPageHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AutoGeneratedPageHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_showExecutionPage = () => (bool)(true);
				_leadType = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_budget = () => (int)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Budget").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Decimal>("Budget") : 0m)));
				_opportunityResponsible = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_meetingTime = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_comment = () => new LocalizableString(((process.ReadActivityData.ResultEntity.IsColumnValueLoaded(process.ReadActivityData.ResultEntity.Schema.Columns.GetByName("DetailedResult").ColumnValueName) ? process.ReadActivityData.ResultEntity.GetTypedColumnValue<string>("DetailedResult") : null)));
				_decisionDate = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("DecisionDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("DecisionDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_opportunityDepartment = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("OpportunityDepartment").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OpportunityDepartmentId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Elements.Value"));
				}
				set {
					_elements = value;
				}
			}

			internal Func<bool> _showExecutionPage;
			public override bool ShowExecutionPage {
				get {
					return (_showExecutionPage ?? (_showExecutionPage = () => false)).Invoke();
				}
				set {
					_showExecutionPage = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("7ee7590a758b4ee3990c188743946765",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			internal Func<Guid> _leadType;
			public virtual Guid LeadType {
				get {
					return (_leadType ?? (_leadType = () => Guid.Empty)).Invoke();
				}
				set {
					_leadType = () => { return value; };
				}
			}

			internal Func<int> _budget;
			public virtual int Budget {
				get {
					return (_budget ?? (_budget = () => 0)).Invoke();
				}
				set {
					_budget = () => { return value; };
				}
			}

			internal Func<Guid> _opportunityResponsible;
			public virtual Guid OpportunityResponsible {
				get {
					return (_opportunityResponsible ?? (_opportunityResponsible = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityResponsible = () => { return value; };
				}
			}

			internal Func<DateTime> _meetingTime;
			public virtual DateTime MeetingTime {
				get {
					return (_meetingTime ?? (_meetingTime = () => DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).Invoke();
				}
				set {
					_meetingTime = () => { return value; };
				}
			}

			internal Func<string> _comment;
			public virtual string Comment {
				get {
					return (_comment ?? (_comment = () => null)).Invoke();
				}
				set {
					_comment = () => { return value; };
				}
			}

			internal Func<DateTime> _decisionDate;
			public virtual DateTime DecisionDate {
				get {
					return (_decisionDate ?? (_decisionDate = () => DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).Invoke();
				}
				set {
					_decisionDate = () => { return value; };
				}
			}

			internal Func<Guid> _opportunityDepartment;
			public virtual Guid OpportunityDepartment {
				get {
					return (_opportunityDepartment ?? (_opportunityDepartment = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityDepartment = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadLeadForHandoffFlowElement

		/// <exclude/>
		public class ReadLeadForHandoffFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadForHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadForHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,91,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,191,98,201,52,193,236,127,175,108,103,83,200,161,148,222,10,58,140,70,243,222,188,121,140,230,123,231,63,186,38,224,88,89,104,60,38,211,193,84,36,67,38,24,160,162,66,151,37,21,32,107,170,108,94,83,97,10,100,41,207,121,46,107,146,116,208,98,69,54,244,222,184,64,18,23,176,245,213,237,252,155,52,140,19,38,247,118,189,124,213,39,108,225,219,210,64,100,96,165,138,13,202,60,141,180,88,215,84,106,208,212,90,174,234,66,72,145,161,38,155,22,45,176,96,32,74,90,167,44,143,165,220,208,90,3,82,174,114,205,153,176,38,183,146,36,13,218,176,127,26,70,244,222,245,93,53,227,107,124,243,60,68,149,91,239,93,223,76,109,71,146,22,3,92,67,56,85,4,48,69,145,107,160,90,168,200,110,177,164,192,149,161,28,234,146,149,18,179,34,43,73,162,97,8,11,45,57,24,146,24,8,240,29,154,9,87,230,217,69,141,140,167,153,204,139,136,205,184,166,130,179,148,202,66,150,212,154,194,42,228,133,82,181,185,248,245,105,114,49,118,254,106,106,113,116,250,197,118,140,254,245,99,53,235,190,11,99,223,44,212,87,107,249,13,62,133,205,220,151,167,31,219,64,33,230,23,16,57,39,147,199,93,227,176,11,251,78,247,198,117,15,27,231,249,28,33,237,0,163,243,23,23,246,143,19,52,36,25,221,195,233,143,110,237,38,31,250,246,63,26,53,137,99,70,142,184,100,171,220,101,7,141,243,67,3,207,235,189,34,239,30,167,62,124,248,140,96,182,136,188,65,84,228,142,228,2,82,80,70,209,92,27,67,215,173,144,172,136,59,138,25,207,36,150,105,89,179,59,18,85,252,3,247,237,193,127,249,217,93,254,192,166,250,248,62,102,223,36,174,47,200,106,254,27,57,231,227,34,232,120,142,231,23,149,211,217,112,202,3,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })));
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

		#region Class: ReadActivityDataFlowElement

		/// <exclude/>
		public class ReadActivityDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadActivityDataFlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadActivityData";
				IsLogging = true;
				SchemaElementUId = new Guid("7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,111,212,48,20,252,43,149,15,156,226,85,28,59,137,29,78,176,44,104,47,75,37,22,132,212,174,170,23,251,185,107,145,143,109,226,136,86,81,254,59,206,166,11,82,15,168,7,46,72,62,216,207,158,121,51,163,231,241,206,245,31,93,229,177,43,44,84,61,70,195,214,20,36,231,9,66,198,24,77,227,76,81,33,153,161,32,211,132,90,149,150,9,40,46,83,131,36,106,160,198,130,44,232,141,113,158,68,206,99,221,23,55,227,31,82,223,13,24,221,217,243,225,139,62,98,13,95,231,6,90,8,101,36,79,40,8,173,169,40,99,70,75,101,82,42,129,37,90,132,22,86,42,178,104,65,137,220,166,165,166,152,161,160,2,115,77,161,180,57,213,60,99,162,204,76,170,84,78,162,10,173,223,60,158,58,236,123,215,54,197,136,191,247,251,167,83,80,185,244,94,183,213,80,55,36,170,209,195,53,248,99,65,0,99,20,169,6,170,133,74,169,176,152,83,224,202,80,14,101,158,228,18,89,198,2,187,134,147,159,105,201,214,144,200,128,135,111,80,13,120,102,30,93,208,152,240,152,201,52,11,88,198,131,29,158,196,84,102,50,167,214,100,86,33,207,148,42,205,37,175,79,131,11,123,215,239,134,26,59,167,159,99,199,144,95,219,21,163,110,27,223,181,213,76,189,59,63,223,227,163,95,194,125,190,250,190,24,242,161,62,131,200,20,13,61,174,43,135,141,223,52,186,53,174,185,95,56,167,41,64,234,19,116,174,191,164,176,121,24,160,34,81,231,238,143,127,77,107,61,244,190,173,255,35,171,81,176,25,56,194,144,157,229,206,51,104,92,127,170,224,233,124,46,200,155,135,161,245,111,247,208,255,40,174,62,160,117,13,94,189,127,183,219,175,230,202,213,214,44,215,228,5,77,65,110,137,148,178,228,74,100,148,151,202,134,1,49,72,165,65,164,92,165,0,146,113,198,180,94,137,36,87,44,101,130,106,59,255,23,20,37,133,88,1,45,179,36,7,109,116,72,70,222,146,160,255,95,169,186,217,246,159,127,54,151,47,181,132,112,88,133,234,139,194,166,194,58,164,85,140,175,177,49,5,192,245,165,85,49,190,198,212,116,152,109,29,166,176,126,1,177,30,142,224,74,4,0,0 })));
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

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_EntityId = () => (Guid)((process.LeadId));
				_recordDefValues_EntitySchemaUId = () => (Guid)(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
				_recordDefValues_Message = () => new LocalizableString(String.Concat("Information about proceeding to handoff:", Environment.NewLine, (process.AutoGeneratedPageHandoff.Comment)));
				_recordDefValues_CreatedBy = () => (Guid)((process.AutoGeneratedPageHandoff.OwnerId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_EntityId", () => _recordDefValues_EntityId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_EntitySchemaUId", () => _recordDefValues_EntitySchemaUId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Message", () => _recordDefValues_Message.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CreatedBy", () => _recordDefValues_CreatedBy.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_EntityId;
			internal Func<Guid> _recordDefValues_EntitySchemaUId;
			internal Func<string> _recordDefValues_Message;
			internal Func<Guid> _recordDefValues_CreatedBy;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,77,111,219,70,16,253,43,2,147,67,11,104,133,253,254,208,181,9,10,1,78,106,212,73,46,150,15,179,187,179,177,0,137,52,72,42,70,42,232,191,119,72,203,141,156,166,106,235,166,104,81,151,7,10,34,119,222,204,206,190,55,51,220,85,207,251,143,55,88,205,171,55,216,182,208,53,165,159,125,215,180,56,59,111,155,132,93,55,59,107,18,172,87,63,65,92,227,57,180,176,193,30,219,119,176,222,98,119,182,234,250,233,228,161,89,53,173,158,127,24,223,86,243,203,93,181,232,113,243,118,145,9,61,233,140,96,161,48,48,50,48,237,162,101,224,179,96,82,71,0,105,117,9,168,200,56,53,235,237,166,126,133,61,156,67,127,93,205,119,213,136,70,0,145,59,11,46,72,166,101,200,4,144,35,243,65,100,102,173,20,74,11,224,49,99,181,159,86,93,186,198,13,140,78,143,141,209,249,36,21,115,60,24,166,179,9,44,122,140,44,9,46,181,138,41,91,23,7,227,195,250,79,134,151,207,46,23,221,15,183,53,182,23,35,238,188,192,186,195,171,25,61,253,236,193,47,201,153,239,140,6,14,33,7,102,82,166,80,77,2,230,165,13,204,161,80,194,163,227,46,202,253,213,179,171,193,99,94,117,55,107,248,248,238,215,142,207,16,242,221,154,155,7,121,63,94,181,91,222,29,223,178,154,47,127,235,0,15,191,119,225,62,60,194,207,79,111,89,77,151,213,69,179,109,211,128,168,134,63,247,217,28,61,240,195,197,190,112,187,191,238,48,70,179,87,80,195,123,108,95,147,199,209,124,124,245,2,122,24,157,191,161,184,239,129,165,226,194,27,235,24,8,149,152,86,146,51,111,189,99,37,219,129,24,54,132,152,71,235,31,177,96,139,117,194,71,6,54,122,254,20,204,61,209,232,73,189,93,175,71,7,221,184,255,129,185,135,192,15,111,94,28,157,212,17,66,147,87,101,133,121,81,63,38,162,125,181,223,79,143,101,146,147,180,81,58,199,82,82,192,116,52,130,1,119,156,169,108,141,18,166,120,161,202,73,153,128,131,32,56,16,227,120,230,76,163,0,22,76,74,204,17,31,139,204,50,136,18,190,190,76,106,188,157,124,191,93,229,111,150,21,73,177,248,128,196,118,195,35,5,16,73,167,9,18,43,69,133,104,181,215,2,211,178,250,246,20,247,31,135,246,191,74,158,140,74,180,51,169,104,202,129,203,133,120,90,168,33,4,49,176,130,68,98,99,48,37,24,113,82,37,37,106,151,188,160,110,36,36,1,120,31,89,148,37,50,110,180,48,209,103,240,58,125,125,149,92,244,237,170,126,79,28,170,19,244,68,238,69,93,154,118,3,253,170,169,39,16,155,109,63,185,25,88,136,153,86,77,250,102,114,13,117,110,74,161,60,77,39,47,235,15,171,182,169,55,88,247,179,215,120,123,182,170,137,151,127,188,59,189,92,227,96,58,223,185,194,149,244,69,49,27,141,165,222,68,13,42,66,162,54,154,117,138,14,36,37,70,237,31,182,51,103,13,80,134,4,243,134,83,251,45,34,80,113,161,220,69,17,81,11,151,51,183,102,104,103,39,53,253,55,236,253,32,217,209,224,26,39,45,118,219,117,63,105,202,151,145,200,245,102,64,56,196,249,223,175,22,137,23,174,173,116,140,110,212,9,98,162,106,161,209,176,160,69,200,201,27,97,163,120,18,213,194,40,73,76,165,158,26,129,164,170,115,241,12,44,41,215,24,154,66,85,118,153,139,112,178,90,96,44,54,198,160,152,7,32,205,0,23,44,112,158,89,178,52,210,58,40,5,165,248,39,71,207,191,34,238,144,45,109,133,107,70,252,16,76,167,76,187,180,160,25,132,72,24,101,40,141,238,247,103,213,63,41,197,113,87,79,101,182,141,50,24,238,168,94,58,4,162,31,90,201,232,195,135,198,50,17,98,81,78,201,82,228,41,29,146,78,169,183,211,32,232,137,103,140,250,19,149,95,170,185,244,249,196,85,214,214,171,156,213,191,85,135,87,251,159,1,20,28,214,87,96,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("c372c156-65a4-46a9-b80a-7bb88ba2cd2c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("7a90900b-53b5-4598-92b3-0aee90626c56"));
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("66f33ed8-53ef-48cf-abf3-665749ecf6ac"));
				_recordColumnValues_Budget = () => (Decimal)((process.AutoGeneratedPageHandoff.Budget));
				_recordColumnValues_SalesOwner = () => (Guid)((process.AutoGeneratedPageHandoff.OpportunityResponsible));
				_recordColumnValues_MeetingDate = () => (DateTime)((process.AutoGeneratedPageHandoff.MeetingTime));
				_recordColumnValues_LeadType = () => (Guid)((process.AutoGeneratedPageHandoff.LeadType));
				_recordColumnValues_DecisionDate = () => (DateTime)((process.AutoGeneratedPageHandoff.DecisionDate));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.AutoGeneratedPageHandoff.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Budget", () => _recordColumnValues_Budget.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SalesOwner", () => _recordColumnValues_SalesOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_MeetingDate", () => _recordColumnValues_MeetingDate.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadType", () => _recordColumnValues_LeadType.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_DecisionDate", () => _recordColumnValues_DecisionDate.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Decimal> _recordColumnValues_Budget;
			internal Func<Guid> _recordColumnValues_SalesOwner;
			internal Func<DateTime> _recordColumnValues_MeetingDate;
			internal Func<Guid> _recordColumnValues_LeadType;
			internal Func<DateTime> _recordColumnValues_DecisionDate;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,107,109,235,195,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,118,54,133,28,74,233,173,160,195,104,70,239,205,155,199,104,186,247,225,163,111,34,14,149,131,38,32,29,247,182,34,194,42,37,53,34,67,225,36,43,156,176,12,50,233,152,44,107,196,50,23,170,228,53,161,29,180,88,145,21,189,179,62,18,234,35,182,161,186,157,126,147,198,97,68,122,239,150,203,87,115,196,22,190,205,13,10,14,78,105,212,137,49,171,89,129,117,205,148,1,195,156,203,117,45,10,85,112,52,100,213,226,120,205,83,98,174,25,195,10,105,57,211,9,202,80,130,17,160,149,149,14,9,109,208,197,221,211,105,192,16,124,223,85,19,190,198,55,207,167,164,114,237,189,237,155,177,237,8,109,49,194,53,196,99,69,0,51,44,74,3,204,20,186,76,147,162,100,144,107,203,114,168,229,70,42,228,130,75,66,13,156,226,76,75,246,150,80,11,17,190,67,51,226,194,60,249,164,113,147,103,92,149,34,97,121,158,52,230,155,140,41,161,36,115,86,56,141,185,208,186,182,23,191,62,141,62,197,62,92,141,45,14,222,188,216,142,201,191,126,168,38,211,119,113,232,155,153,250,106,121,126,131,79,113,53,247,165,244,99,29,40,166,252,12,34,103,58,6,220,54,30,187,184,235,76,111,125,247,176,114,158,207,9,210,158,96,240,225,226,194,238,113,132,134,208,193,63,28,255,232,214,118,12,177,111,255,163,81,105,26,51,113,164,37,91,228,206,59,104,125,56,53,240,188,220,43,242,238,113,236,227,135,207,8,118,141,200,27,68,69,238,72,89,64,6,218,106,86,26,107,217,178,21,106,35,210,142,34,207,185,66,153,201,122,115,71,146,138,127,224,190,221,135,47,63,187,203,31,88,85,31,222,167,236,155,196,245,5,89,77,127,35,231,124,152,5,29,206,233,252,2,227,206,64,245,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,152,77,111,27,55,16,134,255,138,160,228,104,10,252,28,146,190,181,77,15,6,146,52,168,211,92,98,31,134,156,97,44,84,150,12,237,42,129,107,248,191,119,118,109,55,118,208,40,70,227,0,81,29,29,86,240,82,195,33,57,124,230,157,241,197,244,105,127,126,198,211,253,233,107,94,175,177,91,181,126,246,203,106,205,179,87,235,85,229,174,155,61,95,85,92,204,255,194,178,224,87,184,198,83,238,121,253,6,23,27,238,158,207,187,126,111,114,215,108,186,55,125,250,126,28,157,238,191,189,152,30,244,124,250,199,1,201,236,58,37,230,218,138,2,168,69,249,16,139,202,6,80,105,44,200,46,178,49,214,138,113,93,45,54,167,203,23,220,227,43,236,79,166,251,23,211,113,54,153,160,84,93,45,129,86,1,29,41,159,188,86,136,158,85,5,205,24,35,176,213,48,189,220,155,118,245,132,79,113,116,250,209,216,27,108,41,115,86,49,104,241,206,165,168,84,177,170,214,92,46,32,147,25,174,131,241,245,239,63,26,190,125,242,124,181,250,115,115,54,179,214,121,83,201,168,80,156,83,190,138,251,172,141,81,208,34,100,199,13,216,251,89,196,172,179,22,15,193,149,32,155,204,73,101,91,156,108,146,57,107,176,80,3,60,57,30,28,209,188,59,91,224,249,155,207,250,59,236,241,29,207,126,250,128,243,126,190,124,55,233,112,193,87,150,103,119,130,112,219,246,226,232,42,150,71,211,253,163,207,69,243,250,251,112,60,164,187,241,252,52,148,71,211,189,163,233,225,106,179,174,195,140,110,248,227,230,104,71,15,250,250,163,254,229,113,243,185,154,99,52,123,129,75,217,209,250,165,120,28,205,199,161,103,216,227,232,252,181,172,251,102,226,98,115,208,209,52,21,25,179,4,11,172,74,100,80,238,75,46,205,69,103,91,179,163,245,239,220,120,205,203,202,119,23,118,159,80,141,246,163,231,143,139,185,185,117,242,102,185,89,44,70,7,221,184,255,225,26,95,47,252,122,228,217,173,248,221,154,97,69,243,54,103,58,88,254,151,163,186,156,94,94,238,221,102,38,4,103,16,114,84,84,130,28,4,214,32,27,241,77,105,67,89,238,112,171,92,205,86,102,114,177,49,215,8,74,91,35,39,209,130,81,88,9,148,203,14,216,104,200,133,252,183,100,134,154,169,53,129,2,27,171,242,36,15,36,137,171,38,150,100,80,176,120,93,103,0,205,57,166,36,204,112,19,174,107,83,40,97,150,60,17,162,207,146,50,0,235,61,153,121,201,76,147,83,236,55,235,121,127,62,59,20,100,58,181,102,164,243,31,228,220,147,156,123,4,108,39,200,241,148,117,68,106,42,104,52,66,142,54,42,139,72,40,242,148,146,201,206,81,134,173,228,164,100,75,51,20,149,27,246,239,173,78,42,233,138,170,180,108,92,77,228,155,109,223,130,156,183,7,221,111,31,150,188,190,58,133,253,134,139,142,143,103,242,246,147,23,191,46,248,148,151,253,254,69,108,218,217,52,240,82,2,136,228,16,169,34,140,43,32,95,75,68,91,124,116,151,98,240,207,141,221,191,112,25,74,204,196,202,21,87,7,19,167,80,36,84,21,194,146,154,70,109,29,95,30,127,137,185,107,30,6,113,234,79,120,178,230,110,179,232,39,171,54,57,27,6,152,198,129,213,228,4,151,180,106,109,246,243,134,222,177,148,11,5,59,158,212,205,122,184,125,143,134,203,12,82,23,56,182,74,194,193,202,131,147,11,145,28,202,229,114,37,85,48,77,87,218,198,229,189,23,246,189,115,41,220,249,106,170,83,81,50,187,242,14,229,32,80,20,45,26,180,84,131,73,217,132,173,92,134,170,27,198,12,170,232,36,138,102,44,136,162,9,105,181,17,85,43,130,153,81,239,42,151,33,216,224,141,108,11,116,244,178,60,177,203,40,39,20,114,69,15,236,18,52,251,224,92,142,42,57,89,13,123,123,44,52,126,173,74,26,40,236,64,106,169,212,4,105,111,164,54,75,68,210,142,36,237,200,67,114,68,110,55,104,68,135,9,67,81,181,72,99,230,193,84,185,163,134,84,140,54,20,110,162,117,180,93,37,185,85,103,131,136,171,175,146,205,124,16,151,169,161,87,34,156,186,66,105,22,90,222,85,26,51,72,138,206,77,36,95,18,147,242,154,100,121,190,201,9,153,26,11,2,120,208,229,193,105,124,193,60,182,123,132,253,163,105,247,200,26,206,220,188,170,26,36,237,105,99,85,177,82,131,54,52,152,76,52,132,215,237,218,255,93,28,163,201,146,66,242,80,120,203,253,244,141,80,33,8,92,36,165,55,25,105,247,42,181,47,136,35,100,136,218,75,249,206,105,192,209,169,36,20,42,38,128,42,89,9,28,133,93,197,113,200,84,108,165,149,149,76,45,38,73,58,251,196,98,103,18,186,164,173,15,17,225,193,113,28,27,202,129,177,199,194,226,215,74,35,75,154,228,98,69,21,179,147,7,51,139,42,54,171,208,250,136,161,85,78,41,237,4,139,236,80,118,40,181,152,134,32,253,31,72,123,148,69,16,37,251,163,100,40,204,186,160,219,202,226,160,136,208,76,81,57,75,127,229,11,54,149,114,240,74,71,233,173,61,105,136,161,238,42,139,166,18,66,28,218,233,228,37,202,26,88,73,187,29,148,52,198,46,150,230,129,236,195,179,248,140,235,188,155,175,150,147,126,126,202,139,249,242,209,48,249,67,31,111,202,85,73,44,197,72,185,138,148,164,228,148,90,91,229,68,85,146,19,153,156,161,22,204,126,43,147,130,46,130,151,146,14,53,75,185,170,89,26,44,47,146,130,210,97,25,106,165,100,183,179,255,212,145,125,160,11,210,55,74,226,18,237,207,45,43,52,94,74,241,192,158,144,11,87,151,190,81,243,72,243,247,35,153,143,5,200,175,21,201,32,105,51,64,25,99,163,165,216,227,160,138,150,7,182,98,116,131,152,67,253,110,129,60,190,252,27,87,141,100,109,49,28,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		#region Class: ChangeDataUserTask2FlowElement

		/// <exclude/>
		public class ChangeDataUserTask2FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, LeadManagementHandoff process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("329898b3-751a-44ed-9cd2-058defed0313");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("7a90900b-53b5-4598-92b3-0aee90626c56"));
				_recordColumnValues_SaleType = () => new LocalizableString("Order");
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("66f33ed8-53ef-48cf-abf3-665749ecf6ac"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SaleType", () => _recordColumnValues_SaleType.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<string> _recordColumnValues_SaleType;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,127,200,150,228,30,183,219,178,80,210,64,183,37,144,44,97,36,141,178,2,127,197,150,105,130,241,127,175,108,103,83,200,161,148,222,10,58,140,198,122,111,222,60,207,76,247,110,248,228,42,143,125,105,161,26,48,26,15,166,36,5,7,203,10,174,104,174,117,76,25,15,145,176,133,164,25,160,50,134,51,203,84,78,162,6,106,44,201,134,222,27,231,73,228,60,214,67,121,59,253,38,245,253,136,209,189,93,47,223,244,25,107,248,190,20,96,9,88,33,81,82,158,199,138,50,84,161,128,6,77,173,205,164,42,152,96,9,106,178,105,97,8,104,83,38,40,136,92,80,102,211,16,41,145,82,43,181,74,243,140,89,133,138,68,190,119,245,71,240,120,116,53,94,67,31,148,133,130,199,118,73,109,26,42,180,126,255,212,245,56,12,174,109,202,9,95,227,227,115,23,218,216,196,237,218,106,172,27,18,5,56,92,131,63,151,4,48,70,150,107,160,154,201,60,148,71,78,33,147,38,88,161,120,202,5,38,69,194,73,164,161,243,11,45,57,24,18,25,240,240,3,170,17,87,230,201,133,38,210,44,78,68,94,4,108,146,105,202,178,52,166,162,16,156,90,83,88,137,89,33,165,50,23,67,63,143,46,196,110,184,26,107,236,157,126,249,47,24,12,110,251,114,210,109,227,251,182,90,168,175,214,231,71,124,242,155,251,47,159,110,182,134,124,200,47,32,50,71,227,128,187,202,97,227,247,141,110,141,107,30,54,206,121,14,144,186,131,222,13,23,23,246,143,35,84,36,234,221,195,249,143,110,237,198,193,183,245,127,212,106,212,93,134,98,149,187,12,169,113,67,87,193,243,122,47,201,187,199,177,245,31,190,32,152,45,34,111,16,37,185,35,57,131,24,164,145,97,45,140,161,235,84,136,52,172,5,199,36,75,4,242,152,171,244,142,4,21,255,192,125,123,24,190,254,108,46,75,178,169,62,189,15,217,55,137,215,225,46,167,191,145,51,159,22,65,167,57,156,95,86,230,180,189,235,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,77,79,27,49,16,253,43,200,112,204,68,254,90,127,228,86,149,11,18,80,84,40,23,194,97,108,143,33,106,146,141,118,55,173,40,202,127,175,179,4,65,170,66,163,170,149,80,213,61,120,181,107,191,121,99,191,55,158,123,118,208,221,45,136,141,216,5,53,13,182,117,238,134,239,235,134,134,103,77,29,169,109,135,199,117,196,233,228,27,134,41,157,97,131,51,234,168,185,196,233,146,218,227,73,219,13,246,182,97,108,192,14,190,244,179,108,116,117,207,142,58,154,125,58,74,37,122,148,222,5,226,4,49,136,8,90,10,130,224,132,0,47,83,8,33,43,68,84,5,28,235,233,114,54,63,161,14,207,176,187,101,163,123,214,71,43,1,66,228,81,38,195,161,66,149,64,59,205,1,81,151,120,134,19,90,107,72,114,195,86,3,214,198,91,154,97,79,250,4,214,2,179,243,228,193,86,60,128,166,16,192,69,140,144,179,242,193,148,96,130,226,26,188,89,255,4,188,218,63,174,235,207,203,197,80,74,165,69,76,2,170,160,20,232,88,232,61,47,249,155,108,141,87,148,13,105,61,180,232,185,231,133,161,82,161,2,93,121,87,246,23,20,112,36,242,220,72,19,43,179,127,189,38,74,147,118,49,197,187,203,23,249,206,59,188,161,225,187,175,56,233,38,243,155,189,22,167,244,128,92,108,137,240,28,123,63,126,208,114,204,70,227,151,212,220,188,207,251,67,218,214,243,71,41,199,108,48,102,231,245,178,137,235,136,106,253,241,120,180,61,3,223,60,240,147,225,241,121,136,209,195,78,112,94,118,212,156,22,198,30,222,79,29,98,135,61,249,69,201,251,49,112,144,190,226,86,100,176,132,190,136,101,36,184,36,16,188,240,197,40,86,201,156,101,143,254,72,153,26,154,71,218,78,108,23,169,122,124,207,252,148,204,163,235,202,159,249,114,58,237,9,218,126,255,107,27,111,18,223,204,28,62,211,239,89,132,58,77,242,132,210,209,252,119,142,106,197,86,171,193,243,154,177,60,155,236,180,131,202,39,7,58,4,15,168,139,167,84,240,60,219,224,50,134,240,139,154,65,39,44,169,98,123,83,106,134,23,172,115,92,131,171,188,215,92,9,158,140,251,243,53,51,102,31,154,68,205,152,189,102,244,173,69,255,190,167,149,172,208,170,224,128,103,109,65,107,228,80,14,80,130,53,188,216,210,113,174,48,190,230,233,157,19,123,243,158,182,50,196,192,203,197,104,75,73,106,233,28,32,175,18,72,27,172,9,49,106,74,249,85,79,251,32,173,143,214,0,151,162,84,119,174,4,96,76,6,148,87,134,4,55,62,36,253,55,251,64,202,34,70,103,192,72,91,250,88,42,3,166,114,87,241,68,142,40,96,208,60,14,141,201,74,81,169,217,170,92,55,165,87,197,12,88,174,46,48,166,178,218,83,204,6,227,142,125,224,148,40,237,205,176,91,54,147,238,110,120,94,218,64,11,13,97,186,251,223,13,118,236,6,59,8,246,86,43,231,122,245,29,108,182,158,127,159,9,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "7ee7590a758b4ee3990c188743946765",
							"BaseElements.ChangeDataUserTask2.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
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

		public LeadManagementHandoff(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementHandoff";
			SchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7ee7590a-758b-4ee3-990c-188743946765");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementHandoff, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementHandoff, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		private ProcessLeadHandoff _leadHandoff;
		public ProcessLeadHandoff LeadHandoff {
			get {
				return _leadHandoff ?? ((_leadHandoff) = new ProcessLeadHandoff(UserConnection, this));
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
					SchemaElementUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateNurturing;
		public ProcessTerminateEvent TerminateNurturing {
			get {
				return _terminateNurturing ?? (_terminateNurturing = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNurturing",
					SchemaElementUId = new Guid("75650cf9-cc74-4582-bca5-d68dbfe34907"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayLeadDefined;
		public ProcessExclusiveGateway ExclusiveGatewayLeadDefined {
			get {
				return _exclusiveGatewayLeadDefined ?? (_exclusiveGatewayLeadDefined = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayLeadDefined",
					SchemaElementUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayLeadDefined.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateLeadUndefined;
		public ProcessTerminateEvent TerminateLeadUndefined {
			get {
				return _terminateLeadUndefined ?? (_terminateLeadUndefined = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateLeadUndefined",
					SchemaElementUId = new Guid("417b4b0e-9802-41ee-a1ee-f7c063ac01d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ActivityUserTaskBANTFlowElement _activityUserTaskBANT;
		public ActivityUserTaskBANTFlowElement ActivityUserTaskBANT {
			get {
				return _activityUserTaskBANT ?? (_activityUserTaskBANT = new ActivityUserTaskBANTFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadStateToNoInterestFlowElement _changeLeadStateToNoInterest;
		public ChangeLeadStateToNoInterestFlowElement ChangeLeadStateToNoInterest {
			get {
				return _changeLeadStateToNoInterest ?? (_changeLeadStateToNoInterest = new ChangeLeadStateToNoInterestFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadNurturingFlowElement _changeLeadNurturing;
		public ChangeLeadNurturingFlowElement ChangeLeadNurturing {
			get {
				return _changeLeadNurturing ?? (_changeLeadNurturing = new ChangeLeadNurturingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateOpportunity;
		public ProcessTerminateEvent TerminateOpportunity {
			get {
				return _terminateOpportunity ?? (_terminateOpportunity = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateOpportunity",
					SchemaElementUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateNoInterest;
		public ProcessTerminateEvent TerminateNoInterest {
			get {
				return _terminateNoInterest ?? (_terminateNoInterest = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNoInterest",
					SchemaElementUId = new Guid("5061ca01-0d15-463d-b233-768fa17131d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AutoGeneratedPageHandoffFlowElement _autoGeneratedPageHandoff;
		public AutoGeneratedPageHandoffFlowElement AutoGeneratedPageHandoff {
			get {
				return _autoGeneratedPageHandoff ?? (_autoGeneratedPageHandoff = new AutoGeneratedPageHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadForHandoffFlowElement _readLeadForHandoff;
		public ReadLeadForHandoffFlowElement ReadLeadForHandoff {
			get {
				return _readLeadForHandoff ?? (_readLeadForHandoff = new ReadLeadForHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadActivityDataFlowElement _readActivityData;
		public ReadActivityDataFlowElement ReadActivityData {
			get {
				return _readActivityData ?? (_readActivityData = new ReadActivityDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask2FlowElement _changeDataUserTask2;
		public ChangeDataUserTask2FlowElement ChangeDataUserTask2 {
			get {
				return _changeDataUserTask2 ?? (_changeDataUserTask2 = new ChangeDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("c46387cf-300b-4cd8-be2d-4740b8665e12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("f4359b3c-140b-4cfa-a64a-624975aad45f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow9;
		public ProcessConditionalFlow ConditionalFlow9 {
			get {
				return _conditionalFlow9 ?? (_conditionalFlow9 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow9",
					SchemaElementUId = new Guid("1c27d27e-3f1d-4f64-a277-78d7380f5bb1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("e07f0e4a-f36b-1410-6698-00155d043204"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow7;
		public ProcessConditionalFlow ConditionalFlow7 {
			get {
				return _conditionalFlow7 ?? (_conditionalFlow7 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow7",
					SchemaElementUId = new Guid("37f09d58-5453-451a-97f7-c4f7dcacee68"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9"),
						}},
					},
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
					SchemaElementUId = new Guid("23ff5267-6922-4cdf-bc26-a9d0f2ececcd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("d87d32bc-f36b-1410-6598-00155d043204"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("8cdb95ca-c8ea-4880-b7cc-741fa584081f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"), new Collection<Guid>() {
							new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[TerminateNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNurturing };
			FlowElements[ExclusiveGatewayLeadDefined.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayLeadDefined };
			FlowElements[TerminateLeadUndefined.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateLeadUndefined };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ActivityUserTaskBANT.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTaskBANT };
			FlowElements[ChangeLeadStateToNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadStateToNoInterest };
			FlowElements[ChangeLeadNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadNurturing };
			FlowElements[TerminateOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateOpportunity };
			FlowElements[TerminateNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNoInterest };
			FlowElements[AutoGeneratedPageHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageHandoff };
			FlowElements[ReadLeadForHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadForHandoff };
			FlowElements[ReadActivityData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadActivityData };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayLeadDefined", e.Context.SenderName));
						break;
					case "TerminateNurturing":
						CompleteProcess();
						break;
					case "ExclusiveGatewayLeadDefined":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateLeadUndefined", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "TerminateLeadUndefined":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTaskBANT", e.Context.SenderName));
						break;
					case "ActivityUserTaskBANT":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadActivityData", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow9ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadStateToNoInterest", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow7ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadNurturing", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
							break;
						}
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask2", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "ActivityUserTaskBANT");
						break;
					case "ChangeLeadStateToNoInterest":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNoInterest", e.Context.SenderName));
						break;
					case "ChangeLeadNurturing":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNurturing", e.Context.SenderName));
						break;
					case "TerminateOpportunity":
						CompleteProcess();
						break;
					case "TerminateNoInterest":
						CompleteProcess();
						break;
					case "AutoGeneratedPageHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ReadLeadForHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageHandoff", e.Context.SenderName));
						break;
					case "ReadActivityData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadForHandoff", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateOpportunity", e.Context.SenderName));
						break;
					case "ChangeDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateOpportunity", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayLeadDefined", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlow4ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("89a7d2c0-103f-4f41-87f7-265a34bf1d89");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow4", "ActivityUserTaskBANT.ActivityResult == new Guid(\"89a7d2c0-103f-4f41-87f7-265a34bf1d89\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow9ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("e07f0e4a-f36b-1410-6698-00155d043204");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow9", "ActivityUserTaskBANT.ActivityResult == new Guid(\"e07f0e4a-f36b-1410-6698-00155d043204\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow7ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("a08e24ec-c5d1-4951-b49f-5e70dde6a7d9");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow7", "ActivityUserTaskBANT.ActivityResult == new Guid(\"a08e24ec-c5d1-4951-b49f-5e70dde6a7d9\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("d87d32bc-f36b-1410-6598-00155d043204");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalFlow1", "ActivityUserTaskBANT.ActivityResult == new Guid(\"d87d32bc-f36b-1410-6598-00155d043204\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = ActivityUserTaskBANT.ActivityResult == new Guid("fdc13e7b-c600-487f-a398-7240d059ee6a");
			Log.InfoFormat(ConditionalExpressionLogMessage, "ActivityUserTaskBANT", "ConditionalSequenceFlow1", "ActivityUserTaskBANT.ActivityResult == new Guid(\"fdc13e7b-c600-487f-a398-7240d059ee6a\")", result);
			Log.Info($"ActivityUserTaskBANT.ActivityResult: {ActivityUserTaskBANT.ActivityResult}");
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("AutoGeneratedPageHandoff.LeadType")) {
				writer.WriteValue("AutoGeneratedPageHandoff.LeadType", AutoGeneratedPageHandoff.LeadType, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.Budget")) {
				writer.WriteValue("AutoGeneratedPageHandoff.Budget", AutoGeneratedPageHandoff.Budget, 0);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.OpportunityResponsible")) {
				writer.WriteValue("AutoGeneratedPageHandoff.OpportunityResponsible", AutoGeneratedPageHandoff.OpportunityResponsible, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.MeetingTime")) {
				writer.WriteValue("AutoGeneratedPageHandoff.MeetingTime", AutoGeneratedPageHandoff.MeetingTime, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("AutoGeneratedPageHandoff.Comment")) {
				writer.WriteValue("AutoGeneratedPageHandoff.Comment", AutoGeneratedPageHandoff.Comment, null);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.DecisionDate")) {
				writer.WriteValue("AutoGeneratedPageHandoff.DecisionDate", AutoGeneratedPageHandoff.DecisionDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("AutoGeneratedPageHandoff.OpportunityDepartment")) {
				writer.WriteValue("AutoGeneratedPageHandoff.OpportunityDepartment", AutoGeneratedPageHandoff.OpportunityDepartment, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
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
			MetaPathParameterValues.Add("54a0a9d9-5cdd-45ca-8269-7e1318e707b2", () => LeadId);
			MetaPathParameterValues.Add("fa68c1b9-9e12-4b99-bdde-6eb1806d8874", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("99786611-0f56-4e3c-8f29-a4185ad1f427", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("c21a605f-a60b-42ed-9061-294cc87b69a0", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8bb1e66c-1b41-4f67-ab42-57cdc5d866a6", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("745423dc-b077-4526-8e74-98d8ad204cb8", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("5e1878c2-6cac-4d8b-baa8-a59f16943d8b", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("1053c0e9-6404-4b90-bd4a-07157c475327", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("8bc11220-5b0b-4d4e-a16c-25109fbcecd2", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("952c2d22-d6b6-4a51-82ac-ec6cfa9a867e", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("ff499ce0-d575-4f90-b31d-15c099b5f8ee", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("ddfda365-0d3d-45c9-84c5-ef97a50abd3e", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("7ced0725-a5ff-48ab-8329-db8cd92d45fc", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("1bdef657-82b6-4e4c-9cba-7cc3f773ead3", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("0e7bc406-b400-4ee2-8857-94f4a2ed4291", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("a4c0fd5e-3b7e-4c6a-bf78-0b172e842a9f", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("ed0eae90-a660-43ec-85fa-c1bc0b2c7a5c", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4fb15793-1f5f-4afb-a9c5-7ee6d16f6cd6", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("f119f93a-7a57-4328-9ec1-6701da4a0e61", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("6b3bdbfb-ea17-43b3-9552-de9277711d72", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("5141e1f7-4af9-4bf4-b6d1-8874c0d2dc5f", () => ActivityUserTaskBANT.Recommendation);
			MetaPathParameterValues.Add("5b4637a8-7fc7-40e0-bfac-9cb675816ccf", () => ActivityUserTaskBANT.ActivityCategory);
			MetaPathParameterValues.Add("0902eded-b1a4-4f75-aa93-09fdf0aac605", () => ActivityUserTaskBANT.OwnerId);
			MetaPathParameterValues.Add("ba47d7d3-1ca5-41d1-9d6b-42ce60295158", () => ActivityUserTaskBANT.Duration);
			MetaPathParameterValues.Add("fdd5f4d6-8792-40d3-a46d-47a3545e3715", () => ActivityUserTaskBANT.DurationPeriod);
			MetaPathParameterValues.Add("5f4c4e07-469e-451a-88f4-305e2f6792b2", () => ActivityUserTaskBANT.StartIn);
			MetaPathParameterValues.Add("abdfdb50-a1ba-4d57-9207-b1dd297f6e84", () => ActivityUserTaskBANT.StartInPeriod);
			MetaPathParameterValues.Add("d6ff80f1-90c6-416a-90bb-260e00d506f7", () => ActivityUserTaskBANT.RemindBefore);
			MetaPathParameterValues.Add("4e14fc2e-ed85-4967-92f6-4ffd68e2401a", () => ActivityUserTaskBANT.RemindBeforePeriod);
			MetaPathParameterValues.Add("0685b12b-443e-4c64-ab26-d4859f0c8c4b", () => ActivityUserTaskBANT.ShowInScheduler);
			MetaPathParameterValues.Add("53d8ba23-d026-4fd0-9523-ad2d59cb13a1", () => ActivityUserTaskBANT.ShowExecutionPage);
			MetaPathParameterValues.Add("54f32772-50b2-49b4-a2a7-eee12cea8efc", () => ActivityUserTaskBANT.Lead);
			MetaPathParameterValues.Add("531d1563-ba9a-4e91-98ce-d35b182bca5f", () => ActivityUserTaskBANT.Account);
			MetaPathParameterValues.Add("fdb90180-2f4b-4831-b679-403593dd3b6f", () => ActivityUserTaskBANT.Contact);
			MetaPathParameterValues.Add("41dcb696-2cb1-4512-b3cf-dd1a7583a4ff", () => ActivityUserTaskBANT.Opportunity);
			MetaPathParameterValues.Add("d329e26e-4b48-4034-a14b-d1f9fe83945f", () => ActivityUserTaskBANT.Invoice);
			MetaPathParameterValues.Add("a61fc569-1cd9-4ee0-913c-ffb7359a1776", () => ActivityUserTaskBANT.Document);
			MetaPathParameterValues.Add("f7625075-971c-47b4-b67f-f12b29f07881", () => ActivityUserTaskBANT.Incident);
			MetaPathParameterValues.Add("71e2fad8-087d-4d30-853f-4284671382e2", () => ActivityUserTaskBANT.Case);
			MetaPathParameterValues.Add("b9471d7d-f83c-40ed-8479-ac97045d505d", () => ActivityUserTaskBANT.ActivityResult);
			MetaPathParameterValues.Add("42791514-cf69-4e4b-a09a-b627acdcf9e8", () => ActivityUserTaskBANT.CurrentActivityId);
			MetaPathParameterValues.Add("85441486-29f4-4732-bedf-744579a8ec72", () => ActivityUserTaskBANT.IsActivityCompleted);
			MetaPathParameterValues.Add("1ec1c9c1-eadf-4d15-a0fa-5e9731a46b43", () => ActivityUserTaskBANT.ExecutionContext);
			MetaPathParameterValues.Add("4c515728-a780-4846-a088-022faab38f6a", () => ActivityUserTaskBANT.InformationOnStep);
			MetaPathParameterValues.Add("5cf10363-3ca3-4fcf-a2e0-2c6f612c9aef", () => ActivityUserTaskBANT.Order);
			MetaPathParameterValues.Add("38749114-70e5-4e48-85a8-d4f5a5ff24c3", () => ActivityUserTaskBANT.Requests);
			MetaPathParameterValues.Add("725e7498-44eb-49c5-8104-b615cd2a44b3", () => ActivityUserTaskBANT.Listing);
			MetaPathParameterValues.Add("24e0015e-591a-49d6-b47e-f60c309ab061", () => ActivityUserTaskBANT.Property);
			MetaPathParameterValues.Add("ed86a088-1c5e-4485-b084-878f1a8d39df", () => ActivityUserTaskBANT.Contract);
			MetaPathParameterValues.Add("b14902c4-2013-48e9-b69e-d810c180118b", () => ActivityUserTaskBANT.Project);
			MetaPathParameterValues.Add("1138fd23-4b02-4812-9de6-6ecb917db660", () => ActivityUserTaskBANT.Problem);
			MetaPathParameterValues.Add("948d7cec-52ca-4a20-9991-67a3f04cc7c2", () => ActivityUserTaskBANT.Change);
			MetaPathParameterValues.Add("4b5d863d-2006-4c46-8f37-592fbfa512c0", () => ActivityUserTaskBANT.Release);
			MetaPathParameterValues.Add("af9569bc-af68-4326-b7bd-5c4ef9e17ea0", () => ActivityUserTaskBANT.QueueItem);
			MetaPathParameterValues.Add("e8ffa5ea-c8e8-4fc0-98f4-73f789ed7258", () => ActivityUserTaskBANT.Application);
			MetaPathParameterValues.Add("64b8da49-5949-4ca0-b9d2-c4b529a2e6d2", () => ActivityUserTaskBANT.FinApplication);
			MetaPathParameterValues.Add("2c070493-7483-4c5e-a83b-3eb1c5d78ab7", () => ChangeLeadStateToNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("c600955c-8b94-4c98-aee1-79c3c61d4140", () => ChangeLeadStateToNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("24bf952c-9579-4dcf-981f-f2cce1dbc830", () => ChangeLeadStateToNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a", () => ChangeLeadStateToNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("091ab17a-49f8-4d9e-be81-1ca9c9dcb055", () => ChangeLeadNurturing.EntitySchemaUId);
			MetaPathParameterValues.Add("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13", () => ChangeLeadNurturing.IsMatchConditions);
			MetaPathParameterValues.Add("6f0df01f-2acd-4bc7-adec-34cfc25c9246", () => ChangeLeadNurturing.DataSourceFilters);
			MetaPathParameterValues.Add("38717ef0-c344-40ce-a5f4-e39c87df0d1d", () => ChangeLeadNurturing.RecordColumnValues);
			MetaPathParameterValues.Add("37ca1e6d-f9a7-4c7f-ba6c-9ca142ff1579", () => AutoGeneratedPageHandoff.Title);
			MetaPathParameterValues.Add("92313c1a-6c83-4de1-b493-4b387b234357", () => AutoGeneratedPageHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("5854a389-d5a2-4dce-814f-9c06510637e6", () => AutoGeneratedPageHandoff.Recommendation);
			MetaPathParameterValues.Add("41d66075-70c0-453a-8022-cff5949370b2", () => AutoGeneratedPageHandoff.EntityId);
			MetaPathParameterValues.Add("3111f593-81b1-42b5-99a0-cd853a60b279", () => AutoGeneratedPageHandoff.Buttons);
			MetaPathParameterValues.Add("d88c0edd-7a1d-4087-b13e-ce975c3e925f", () => AutoGeneratedPageHandoff.Elements);
			MetaPathParameterValues.Add("7d35cac3-bad2-40c8-842e-1b639ac400c8", () => AutoGeneratedPageHandoff.ExtendedClientModule);
			MetaPathParameterValues.Add("f2e508ca-4b2f-4b48-976b-52653e3dbe10", () => AutoGeneratedPageHandoff.EntryPointId);
			MetaPathParameterValues.Add("478f0294-5119-41e8-ab5b-bc27d9882a36", () => AutoGeneratedPageHandoff.PressedButtonCode);
			MetaPathParameterValues.Add("9d600d04-bc01-4cd3-86a4-a9bb56f488b7", () => AutoGeneratedPageHandoff.OwnerId);
			MetaPathParameterValues.Add("a698c3a6-4b9a-4404-9178-0cd67c688925", () => AutoGeneratedPageHandoff.ShowExecutionPage);
			MetaPathParameterValues.Add("03fc2e34-8cdc-4158-9dd1-dafee46392f4", () => AutoGeneratedPageHandoff.InformationOnStep);
			MetaPathParameterValues.Add("97a4e728-73b0-4b7e-8a0e-313bec8ab330", () => AutoGeneratedPageHandoff.IsRunning);
			MetaPathParameterValues.Add("3a8ae276-d1a6-4833-8edd-18a3802457a6", () => AutoGeneratedPageHandoff.LeadType);
			MetaPathParameterValues.Add("396b79de-3b3c-45d3-aea7-bdab8f0a023e", () => AutoGeneratedPageHandoff.Budget);
			MetaPathParameterValues.Add("55254183-6074-4e56-9aab-59ca46e386f2", () => AutoGeneratedPageHandoff.OpportunityResponsible);
			MetaPathParameterValues.Add("968839fa-bdc5-40db-84fc-b1c7ba66460b", () => AutoGeneratedPageHandoff.MeetingTime);
			MetaPathParameterValues.Add("765a88b1-8502-4f19-801f-b1be417dd065", () => AutoGeneratedPageHandoff.Comment);
			MetaPathParameterValues.Add("1cda6777-d842-406e-9075-3c837bf46d26", () => AutoGeneratedPageHandoff.DecisionDate);
			MetaPathParameterValues.Add("476a3574-3ae8-49f9-a144-15e4daebec38", () => AutoGeneratedPageHandoff.OpportunityDepartment);
			MetaPathParameterValues.Add("6e73bc51-9c3d-46b9-99dc-388c60d1dae1", () => ReadLeadForHandoff.DataSourceFilters);
			MetaPathParameterValues.Add("c3ef0854-9dec-41d4-8d16-407475422cc6", () => ReadLeadForHandoff.ResultType);
			MetaPathParameterValues.Add("976150fd-e561-4fa6-9f3f-911949e5c42c", () => ReadLeadForHandoff.ReadSomeTopRecords);
			MetaPathParameterValues.Add("51bcbfaa-b77d-4c21-947e-02e0676d3545", () => ReadLeadForHandoff.NumberOfRecords);
			MetaPathParameterValues.Add("663137f9-795a-4269-b94a-83f9c02d10da", () => ReadLeadForHandoff.FunctionType);
			MetaPathParameterValues.Add("b1c37761-25d6-438c-bdbc-43b2a149b1ca", () => ReadLeadForHandoff.AggregationColumnName);
			MetaPathParameterValues.Add("73074895-abf7-4e2d-ad95-2629a87fc3d5", () => ReadLeadForHandoff.OrderInfo);
			MetaPathParameterValues.Add("69f1e87b-3dd8-44cf-8c4f-97bd0653ad06", () => ReadLeadForHandoff.ResultEntity);
			MetaPathParameterValues.Add("225fc2e7-3024-4f80-b9c4-c881e8aadeed", () => ReadLeadForHandoff.ResultCount);
			MetaPathParameterValues.Add("38d606ea-c1d2-4017-915e-893f7f96a610", () => ReadLeadForHandoff.ResultIntegerFunction);
			MetaPathParameterValues.Add("d8b37a80-9357-459a-9ca1-945f0af37bb5", () => ReadLeadForHandoff.ResultFloatFunction);
			MetaPathParameterValues.Add("3207b919-eb4b-44b7-9c43-5080d06b54a1", () => ReadLeadForHandoff.ResultDateTimeFunction);
			MetaPathParameterValues.Add("f24a8102-fb92-4bc4-b65f-c475f479a843", () => ReadLeadForHandoff.ResultRowsCount);
			MetaPathParameterValues.Add("8f0a63b7-c987-4e12-93c8-76a709a96645", () => ReadLeadForHandoff.CanReadUncommitedData);
			MetaPathParameterValues.Add("4af22b59-f62b-47c3-ad50-2c78bf148bf7", () => ReadLeadForHandoff.ResultEntityCollection);
			MetaPathParameterValues.Add("a1770417-d693-4416-9df8-379715d76f1e", () => ReadLeadForHandoff.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("5e6e3bcd-5e15-4652-84f8-98664792001d", () => ReadLeadForHandoff.IgnoreDisplayValues);
			MetaPathParameterValues.Add("845950b8-706c-45cb-a415-aa0655156cee", () => ReadLeadForHandoff.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c7919aea-f3b6-4b2d-b0e6-831cf54e90a3", () => ReadLeadForHandoff.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("b7a60eae-1035-42aa-a3a1-1572936331df", () => ReadActivityData.DataSourceFilters);
			MetaPathParameterValues.Add("51205379-8b3b-4d44-91b1-2cf7e081b07f", () => ReadActivityData.ResultType);
			MetaPathParameterValues.Add("f9078003-1806-4096-a752-6ce6fcaf6be3", () => ReadActivityData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("76950e9e-10e8-40f4-86ff-2e96d8188d1b", () => ReadActivityData.NumberOfRecords);
			MetaPathParameterValues.Add("93775e4e-88f1-48e9-ad74-74ac5f28d089", () => ReadActivityData.FunctionType);
			MetaPathParameterValues.Add("60cd6a65-a50a-4617-80ad-ed2c447da612", () => ReadActivityData.AggregationColumnName);
			MetaPathParameterValues.Add("72a0125d-b3d1-40d6-87c7-019a59320276", () => ReadActivityData.OrderInfo);
			MetaPathParameterValues.Add("946dd2c0-da26-457d-ad8c-4ba3167aa54d", () => ReadActivityData.ResultEntity);
			MetaPathParameterValues.Add("cd269b97-48c0-45a2-b046-e6a8730dbc7b", () => ReadActivityData.ResultCount);
			MetaPathParameterValues.Add("af08f6d6-b7c6-43d1-9f43-0d58376f1628", () => ReadActivityData.ResultIntegerFunction);
			MetaPathParameterValues.Add("1374d32a-f908-40e6-bf89-db89d892800d", () => ReadActivityData.ResultFloatFunction);
			MetaPathParameterValues.Add("5b57f2b2-ecee-4016-9433-31ce467f75e4", () => ReadActivityData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("c8013d26-15c8-4309-8bd8-b47ac03d9b59", () => ReadActivityData.ResultRowsCount);
			MetaPathParameterValues.Add("16f2c6ff-c1c8-4618-a4e9-e3c0db708ee5", () => ReadActivityData.CanReadUncommitedData);
			MetaPathParameterValues.Add("0d16c05d-2fc2-4a8a-8988-a0236870a419", () => ReadActivityData.ResultEntityCollection);
			MetaPathParameterValues.Add("d6aa112f-0172-4d91-a4d7-4aca0c91d611", () => ReadActivityData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("aa42b756-be31-4168-9f40-03d0cd697284", () => ReadActivityData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("44aa8999-c364-4c34-9712-487ff5e54b10", () => ReadActivityData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("b5541d21-6f2d-4f0c-b4d2-52124ba20d66", () => ReadActivityData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("de2b38a3-9f52-4d0b-8df6-067cb01d12fa", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("2486b970-ba2a-4d75-ad7e-6a6ca3693558", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("d0582550-2e0c-4765-8c6b-c7cbbd545084", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("0b9fe44f-dae0-43df-bf4f-456291e2c0f3", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("85beb4a5-021f-4174-8075-c753178d9f8c", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("ca953947-82c9-4fca-ad12-345201627164", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("f7d955b1-b130-45d2-b90b-36a4a2ff1c1b", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("86baa44f-1be5-4c2b-afba-f50c69444878", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("ad1909b2-86a5-4387-ac62-e67d8d19b991", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("ea16bf89-752e-4e21-a5fa-2779bbe6a5de", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("96352b96-718c-4854-ab6d-31d33673a18b", () => ChangeDataUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("702f5fbb-ed10-4780-81d7-ed81fe787102", () => ChangeDataUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("24e70e39-6f35-420e-8745-11cb3e30fc29", () => ChangeDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("aa996c30-4714-41b7-ba32-536d65ced754", () => ChangeDataUserTask2.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "AutoGeneratedPageHandoff.LeadType":
					AutoGeneratedPageHandoff.LeadType = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageHandoff.Budget":
					AutoGeneratedPageHandoff.Budget = reader.GetValue<System.Int32>();
				break;
				case "AutoGeneratedPageHandoff.OpportunityResponsible":
					AutoGeneratedPageHandoff.OpportunityResponsible = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageHandoff.MeetingTime":
					AutoGeneratedPageHandoff.MeetingTime = reader.GetValue<System.DateTime>();
				break;
				case "AutoGeneratedPageHandoff.Comment":
					AutoGeneratedPageHandoff.Comment = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageHandoff.DecisionDate":
					AutoGeneratedPageHandoff.DecisionDate = reader.GetValue<System.DateTime>();
				break;
				case "AutoGeneratedPageHandoff.OpportunityDepartment":
					AutoGeneratedPageHandoff.OpportunityDepartment = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (LeadManagementHandoff)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

