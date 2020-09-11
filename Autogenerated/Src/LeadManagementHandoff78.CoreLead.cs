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

	#region Class: LeadManagementHandoff78Schema

	/// <exclude/>
	public class LeadManagementHandoff78Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementHandoff78Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementHandoff78Schema(LeadManagementHandoff78Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementHandoff78";
			UId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"LeadManagementHandoff78";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0");
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOpenTaskPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("33fe706c-8bb5-40f7-890a-9d67b92dbea5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"OpenTaskPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFeedMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e99feae2-362b-4143-b7aa-31d837292ee6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"FeedMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateUsePreconfiguredPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a87c19b-078d-4508-a1ee-049df3ff5ec3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"UsePreconfiguredPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#BooleanValue.True#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateOpenTaskPageParameter());
			Parameters.Add(CreateFeedMessageParameter());
			Parameters.Add(CreateUsePreconfiguredPageParameter());
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,162,41,81,242,173,72,221,34,64,209,4,136,145,75,149,195,74,90,218,68,245,2,73,167,117,13,255,123,73,209,86,157,194,69,220,94,26,157,196,193,236,236,236,107,23,85,13,24,243,25,90,140,230,209,18,181,6,211,75,123,253,65,53,22,245,71,221,111,134,232,42,50,168,21,52,234,7,214,1,95,212,202,190,7,11,46,100,87,252,82,40,162,121,113,94,163,136,174,138,72,89,108,141,227,184,16,42,120,157,243,24,136,40,19,70,56,48,73,50,201,74,146,82,224,178,142,171,92,82,22,152,127,18,191,233,219,1,52,134,28,163,188,28,127,151,219,193,83,99,7,84,35,69,153,190,59,128,51,111,194,44,58,40,27,172,221,219,234,13,58,200,106,213,186,106,112,169,90,188,7,237,114,121,157,222,67,142,36,161,49,158,213,160,180,139,239,131,70,99,84,223,189,102,174,217,180,221,41,219,9,224,244,60,216,161,163,71,207,188,7,187,30,37,110,157,173,253,232,242,221,106,165,113,5,86,61,159,154,248,138,219,145,119,89,255,92,64,237,166,244,8,205,6,79,114,190,172,228,6,6,27,10,10,233,29,65,171,213,250,226,90,167,142,189,86,46,115,224,112,36,95,168,121,182,6,150,58,240,217,3,65,229,248,91,68,95,110,205,221,183,14,245,67,181,198,22,66,215,158,174,29,250,27,48,233,207,119,9,7,10,121,157,147,164,170,107,194,147,10,72,198,210,156,8,140,103,113,134,130,138,146,237,159,130,15,101,134,6,182,143,83,186,79,8,161,97,190,111,238,13,169,76,69,28,87,132,150,76,16,142,85,73,202,140,81,34,120,10,73,37,89,146,167,210,205,215,127,126,12,253,74,85,208,220,13,168,225,48,1,122,126,65,95,108,182,47,94,247,189,13,37,77,205,155,188,28,87,68,148,82,102,9,203,136,200,83,32,156,198,130,64,22,103,132,114,65,121,60,19,128,210,69,238,221,117,251,254,62,244,27,93,29,174,201,132,179,254,167,115,253,15,71,248,55,119,117,118,179,47,217,212,183,178,131,111,102,211,246,209,254,39,155,163,148,188,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				UId = new Guid("f48e62d0-d4f7-4f42-92ff-f5017c0cdc13"),
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
				UId = new Guid("231945a3-a6a9-4bc6-819d-1c7d1762bbf6"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Direction = ProcessSchemaParameterDirection.Variable,
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
				Direction = ProcessSchemaParameterDirection.Variable,
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				UId = new Guid("99e9cc26-01cd-4e03-9c89-1d86e4dbc2c2"),
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
				UId = new Guid("f125cd4c-65d2-4885-9b77-e4bcc5b9f876"),
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
			var confItemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				UId = new Guid("daaab24c-2ab3-4250-b22d-67689b92d5bf"),
				ContainerUId = new Guid("888b3946-3b9f-4fde-8dee-395aa81311cc"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ConfItem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			confItemParameter.SourceValue = new ProcessSchemaParameterValue(confItemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(confItemParameter);
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,15,82,15,223,138,212,45,2,20,77,128,24,185,84,57,44,197,149,77,84,47,144,84,90,215,240,191,151,20,109,213,41,92,196,237,165,209,73,28,12,103,103,150,187,187,160,106,64,235,207,208,98,176,8,86,168,20,232,190,54,215,31,100,99,80,125,84,253,56,4,87,129,70,37,161,145,63,80,120,124,41,164,121,15,6,236,149,93,249,75,161,12,22,229,121,141,50,184,42,3,105,176,213,150,99,175,80,154,51,100,5,39,85,198,66,66,121,157,144,156,179,132,0,205,235,48,6,22,81,158,122,230,159,196,111,250,118,0,133,190,198,36,95,79,191,171,237,224,168,145,5,170,137,34,117,223,29,192,196,153,208,203,14,120,131,194,158,141,26,209,66,70,201,214,166,193,149,108,241,30,148,173,229,116,122,7,89,82,13,141,118,172,6,107,179,252,62,40,212,90,246,221,107,230,154,177,237,78,217,86,0,231,227,193,78,56,121,116,204,123,48,155,73,226,214,218,218,79,46,223,173,215,10,215,96,228,243,169,137,175,184,157,120,151,245,207,94,16,246,149,30,161,25,241,164,230,203,36,55,48,24,31,200,151,183,4,37,215,155,139,179,206,29,123,45,110,108,193,225,72,190,80,243,108,134,56,181,224,179,3,188,202,241,183,12,190,220,234,187,111,29,170,135,106,131,45,248,174,61,93,91,244,55,96,214,95,236,24,133,16,10,81,16,86,9,65,40,171,128,228,113,90,144,12,163,36,202,49,11,51,30,239,159,188,15,169,135,6,182,143,115,185,79,8,190,97,174,111,246,140,144,84,117,30,69,132,101,57,18,26,37,57,1,94,71,36,7,42,210,156,243,42,202,10,251,190,238,115,207,208,175,101,5,205,221,128,10,14,47,16,158,31,208,23,147,237,194,171,190,55,62,210,220,188,217,203,113,68,98,158,177,84,36,25,137,35,78,9,21,192,72,145,9,70,56,64,74,235,130,242,152,133,214,140,221,110,215,223,135,126,84,213,97,155,180,95,235,127,90,215,255,176,132,127,179,87,103,39,251,146,73,125,43,51,248,102,38,109,31,236,127,2,0,193,94,137,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,203,110,219,48,16,252,21,131,201,209,107,240,37,82,244,181,185,4,112,130,160,73,115,137,115,88,146,203,70,168,108,25,146,92,32,53,252,239,165,21,187,137,131,166,13,80,244,82,148,7,10,164,118,102,7,59,26,109,216,105,255,184,34,54,101,55,212,182,216,53,169,159,124,104,90,154,92,181,77,160,174,155,204,154,128,117,245,13,125,77,87,216,226,130,122,106,111,177,94,83,55,171,186,126,60,58,134,177,49,59,253,58,188,101,211,187,13,59,239,105,241,233,60,102,118,36,201,117,50,5,96,146,37,104,206,3,248,194,43,8,133,46,60,218,100,69,33,51,56,52,245,122,177,188,160,30,175,176,127,96,211,13,27,216,50,129,243,210,186,96,13,112,41,20,232,84,8,192,16,13,40,167,12,9,110,156,143,154,109,199,172,11,15,180,192,161,233,51,88,11,76,165,35,7,182,224,30,52,121,15,101,192,0,41,41,231,141,46,181,160,176,3,239,235,159,129,119,39,179,166,249,178,94,77,100,76,34,132,210,128,145,54,128,142,121,195,40,18,240,72,37,145,71,175,121,152,36,91,114,99,162,2,180,138,114,155,92,238,189,115,64,218,218,20,188,211,94,150,39,247,187,70,177,234,86,53,62,222,190,217,239,146,40,142,22,216,175,219,170,127,156,92,54,253,168,90,230,201,83,215,83,124,162,88,29,185,241,146,100,51,127,50,117,206,166,243,183,108,221,63,175,135,105,29,27,251,218,211,57,27,207,217,117,179,110,195,142,81,229,195,217,11,245,67,147,161,228,213,241,96,98,190,89,174,235,122,127,115,134,61,30,10,15,215,77,172,82,69,241,124,121,125,240,110,96,225,251,5,63,217,14,235,73,219,159,192,46,112,137,159,169,189,204,3,120,214,254,67,229,77,30,227,129,216,75,87,112,155,61,183,132,46,187,107,36,148,81,32,56,225,124,82,86,201,148,228,128,254,72,41,59,181,12,116,44,236,61,159,208,30,223,13,211,222,165,103,175,107,55,170,45,219,110,199,47,51,85,234,96,76,169,36,168,84,228,76,217,50,167,75,37,3,78,150,69,178,62,40,12,238,151,153,242,129,7,25,13,135,2,85,132,28,3,14,136,154,32,24,78,104,173,201,153,53,127,51,83,82,105,17,162,128,252,35,200,145,14,185,189,227,66,128,73,214,56,69,201,144,214,147,66,96,12,138,2,168,130,231,34,47,178,70,158,27,150,158,148,231,36,68,226,239,205,212,140,48,142,186,62,219,253,63,80,255,68,160,222,241,253,252,46,80,247,219,239,173,114,87,101,2,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,150,245,162,111,69,234,22,1,138,38,64,140,92,170,28,86,228,202,38,42,89,2,73,167,117,13,255,123,151,162,173,58,133,139,184,189,52,62,201,131,225,236,204,62,118,145,108,192,218,207,208,98,52,139,22,104,12,216,174,118,215,31,116,227,208,124,52,221,166,143,174,34,139,70,67,163,127,160,10,248,92,105,247,30,28,208,147,93,249,75,161,140,102,229,121,141,50,186,42,35,237,176,181,196,161,39,121,193,101,12,85,205,38,117,197,89,82,115,193,64,73,193,120,37,164,192,36,139,167,82,5,230,159,196,111,186,182,7,131,161,198,32,95,15,159,139,109,239,169,19,2,228,64,209,182,91,31,192,169,55,97,231,107,168,26,244,242,206,108,144,32,103,116,75,105,112,161,91,188,7,67,181,188,78,231,33,34,213,208,88,207,106,176,118,243,239,189,65,107,117,183,126,205,92,179,105,215,167,108,18,192,241,239,193,14,31,60,122,230,61,184,213,32,113,75,182,246,131,203,119,203,165,193,37,56,253,124,106,226,43,110,7,222,101,253,163,7,138,166,244,8,205,6,79,106,190,76,114,3,189,11,129,66,121,34,24,189,92,93,156,117,236,216,107,113,99,2,251,35,249,66,205,179,25,226,140,192,103,15,4,149,227,103,25,125,185,181,119,223,214,104,30,228,10,91,8,93,123,186,38,244,55,96,212,159,237,210,4,56,8,37,88,42,149,98,73,42,129,21,113,38,88,142,147,233,164,192,156,231,85,188,127,10,62,180,237,27,216,62,142,229,62,33,132,134,249,190,13,83,129,184,22,105,194,84,81,211,84,210,36,97,197,84,40,6,85,145,229,130,83,133,42,163,249,250,159,31,67,183,212,18,154,187,30,13,28,38,192,207,47,232,139,205,246,225,77,215,185,16,105,108,222,232,229,184,34,28,107,41,146,34,101,152,37,21,75,80,22,228,3,18,134,56,81,42,86,57,151,74,146,25,186,110,223,223,135,110,99,228,225,154,108,56,235,127,58,215,255,112,132,127,115,87,103,55,251,146,77,125,43,59,248,102,54,109,31,237,127,2,70,38,162,189,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,79,219,64,16,253,43,200,112,204,88,251,229,253,200,181,92,144,2,66,133,114,33,28,102,119,103,193,106,18,71,182,131,68,163,252,247,110,76,82,8,42,45,82,213,67,165,250,176,214,142,247,189,121,154,183,207,235,226,164,127,90,82,49,46,174,169,109,177,107,82,95,126,106,90,42,47,219,38,80,215,149,147,38,224,172,254,134,126,70,151,216,226,156,122,106,111,112,182,162,110,82,119,253,232,232,16,86,140,138,147,199,225,107,49,190,93,23,103,61,205,191,156,197,204,206,133,77,210,7,3,78,200,10,148,66,13,168,152,0,173,173,203,101,101,13,227,25,28,154,217,106,190,56,167,30,47,177,127,40,198,235,98,96,203,4,206,11,227,130,209,192,4,151,160,82,197,1,67,212,32,157,212,196,153,118,62,170,98,51,42,186,240,64,115,28,154,190,128,21,199,100,29,57,48,21,243,160,200,123,176,1,3,164,36,157,215,202,42,78,97,11,222,157,127,1,222,30,79,154,230,235,106,89,138,152,120,8,86,131,22,38,128,138,121,193,200,19,176,72,150,200,163,87,44,148,149,151,145,51,165,33,5,174,65,85,193,2,86,200,65,56,27,83,176,149,169,148,62,190,219,54,138,117,183,156,225,211,205,187,253,46,136,226,209,28,251,85,91,247,79,229,105,221,133,230,145,90,138,207,240,229,129,19,175,9,214,211,103,67,167,197,120,250,158,165,187,247,213,48,169,67,83,223,250,57,45,70,211,226,170,89,181,97,203,40,243,230,244,149,242,161,201,112,228,205,118,111,96,174,44,86,179,217,174,114,138,61,238,15,238,203,77,172,83,77,241,108,113,181,247,109,96,97,187,7,126,178,236,159,103,109,127,2,59,199,5,222,83,123,145,7,240,162,253,135,202,235,60,198,61,177,23,174,98,38,251,109,8,93,190,64,90,128,141,28,193,113,231,147,52,82,164,36,6,244,103,74,217,166,69,160,67,97,31,185,62,59,124,55,76,123,155,156,157,174,237,168,54,197,102,51,122,157,39,233,133,16,206,84,32,21,113,80,154,36,88,73,22,98,165,185,13,26,73,27,247,203,60,249,192,130,136,154,65,133,50,66,142,0,3,68,69,16,52,35,52,70,147,96,250,111,230,73,72,197,67,228,144,51,147,227,28,114,123,199,56,7,157,140,118,146,146,38,165,74,174,66,10,90,41,32,73,89,163,51,4,54,255,5,128,162,146,121,240,222,50,39,63,152,167,9,97,60,234,250,108,119,121,177,106,183,177,90,220,255,207,210,191,153,165,15,92,157,223,101,233,110,243,29,220,23,104,72,249,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,18,169,151,111,69,234,22,1,138,38,64,140,92,170,28,86,228,202,38,42,89,2,73,167,117,13,255,123,151,146,173,58,133,139,184,189,52,58,137,131,225,236,204,114,119,23,200,6,172,253,12,45,6,179,96,129,198,128,237,106,119,253,65,55,14,205,71,211,109,250,224,42,176,104,52,52,250,7,170,17,159,43,237,222,131,3,186,178,43,127,41,148,193,172,60,175,81,6,87,101,160,29,182,150,56,254,138,192,52,6,145,177,42,140,19,38,144,43,86,73,64,198,139,68,242,88,212,42,169,243,3,243,15,226,55,93,219,131,193,177,198,32,95,15,191,139,109,239,169,17,1,114,160,104,219,173,15,32,247,38,236,124,13,85,131,138,206,206,108,144,32,103,116,75,105,112,161,91,188,7,67,181,188,78,231,33,34,213,208,88,207,106,176,118,243,239,189,65,107,117,183,126,205,92,179,105,215,167,108,18,192,233,120,176,19,14,30,61,243,30,220,106,144,184,37,91,251,193,229,187,229,210,224,18,156,126,62,53,241,21,183,3,239,178,254,209,5,69,175,244,8,205,6,79,106,190,76,114,3,189,27,3,141,229,137,96,244,114,117,113,214,169,99,175,197,141,9,236,143,228,11,53,207,102,136,83,2,159,61,48,170,28,127,203,224,203,173,189,251,182,70,243,32,87,216,194,216,181,167,107,66,127,3,38,253,217,46,17,16,66,161,10,150,72,165,152,72,36,176,60,78,11,150,97,196,163,28,179,48,171,226,253,211,232,67,219,190,129,237,227,84,238,19,194,216,48,223,55,58,167,80,228,80,241,138,33,70,17,19,74,166,44,23,162,102,92,113,148,192,179,58,229,146,222,215,127,254,25,186,165,150,208,220,245,104,224,240,2,225,249,1,125,49,217,62,188,233,58,55,70,154,154,55,121,57,142,72,132,177,136,1,11,38,100,150,49,1,121,197,138,58,169,200,86,138,113,200,19,158,228,21,153,161,237,246,253,125,232,54,70,30,182,201,142,107,253,79,235,250,31,150,240,111,246,234,236,100,95,50,169,111,101,6,223,204,164,237,131,253,79,179,156,160,52,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,197,68,70,233,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				UId = new Guid("260b8bbe-7c18-4113-a716-497ebb6bb353"),
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
				UId = new Guid("1b5dc904-f14a-44b2-b858-11ecf54914b7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,110,219,48,16,252,21,67,231,208,176,222,148,111,110,226,22,185,36,1,98,228,82,231,176,162,150,54,17,189,64,210,105,93,67,255,222,165,100,187,78,225,34,110,47,109,117,145,56,152,29,206,190,180,243,68,9,198,220,65,133,222,212,91,160,214,96,26,105,199,31,85,105,81,127,210,205,166,245,174,60,131,90,65,169,190,97,49,224,243,66,217,27,176,64,33,187,229,15,133,165,55,93,158,215,88,122,87,75,79,89,172,12,113,40,4,57,134,50,206,5,195,4,35,22,97,42,24,228,50,101,34,76,252,40,79,138,56,203,210,129,249,43,241,235,166,106,65,227,112,71,47,47,251,207,197,182,117,84,159,0,209,83,148,105,234,61,24,58,19,102,94,67,94,98,65,103,171,55,72,144,213,170,162,108,112,161,42,124,0,77,119,57,157,198,65,68,146,80,26,199,42,81,218,249,215,86,163,49,170,169,223,51,87,110,170,250,148,77,2,120,60,238,237,76,122,143,142,249,0,118,221,75,220,146,173,174,119,57,91,173,52,174,192,170,215,83,19,47,184,237,121,151,213,143,2,10,234,210,19,148,27,60,185,243,109,38,215,208,218,33,161,225,122,34,104,181,90,95,156,235,177,98,239,165,27,16,216,30,200,23,106,158,205,33,72,8,124,117,192,160,114,248,92,122,159,111,205,253,151,26,245,163,88,99,5,67,213,158,199,132,254,4,204,75,172,176,182,211,29,231,60,15,179,40,97,97,158,73,22,201,2,25,47,16,89,152,197,0,220,15,125,95,136,142,2,142,134,166,187,40,72,51,63,246,35,38,100,146,81,233,163,156,193,36,3,150,39,65,10,162,16,50,67,222,61,15,198,149,105,75,216,62,29,253,45,192,188,76,71,55,40,85,141,163,15,179,187,197,216,33,163,125,217,221,139,72,32,82,72,51,30,48,95,166,72,158,120,200,184,160,35,4,41,10,25,114,30,166,130,166,196,61,174,153,205,74,9,40,239,91,212,176,239,227,228,252,152,191,217,15,87,66,221,52,118,40,204,177,5,51,65,3,167,236,182,247,115,24,182,52,12,16,18,223,103,241,196,101,204,253,130,1,143,3,38,179,56,15,32,11,121,92,80,116,71,255,9,215,169,199,102,163,197,126,47,205,240,131,248,163,197,255,11,235,252,59,27,122,118,71,46,153,249,255,118,154,255,169,241,236,188,238,59,157,108,106,160,187,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				UId = new Guid("4f2ea1db-be28-4357-9aa5-ae1cdd70083b"),
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
				UId = new Guid("124f6347-3524-4f19-b6a5-0d076865f111"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,75,111,219,70,16,254,43,2,147,131,3,104,133,125,63,116,109,210,194,128,237,6,113,154,139,229,195,236,238,108,44,64,38,13,146,138,145,26,250,239,25,210,82,98,187,173,18,56,65,114,168,9,130,4,151,59,143,157,153,239,155,185,169,158,247,31,175,176,154,87,111,177,109,161,107,74,63,251,173,105,113,246,186,109,18,118,221,236,168,73,176,90,254,13,113,133,175,161,133,75,236,177,125,7,171,53,118,71,203,174,159,78,238,139,85,211,234,249,135,241,111,53,63,187,169,14,123,188,252,235,48,147,246,136,25,163,11,200,36,104,195,180,204,200,64,91,96,33,8,21,147,143,209,38,79,194,169,89,173,47,235,99,236,225,53,244,23,213,252,166,26,181,13,10,184,179,224,130,36,217,144,153,118,57,50,31,68,102,214,74,161,180,0,30,51,86,155,105,213,165,11,188,132,209,232,93,97,116,62,73,197,28,15,100,61,155,192,162,199,200,146,224,82,147,253,108,93,28,132,183,251,191,8,158,61,59,59,236,254,188,174,177,61,29,245,206,11,172,58,60,159,209,234,131,133,207,193,153,223,24,13,28,66,14,204,164,76,174,154,4,204,75,27,152,67,161,132,71,199,93,148,155,243,103,231,131,197,188,236,174,86,240,241,221,63,13,31,33,228,219,61,87,247,226,126,119,215,205,226,54,125,139,106,190,248,175,4,110,223,183,238,222,79,225,195,236,45,170,233,162,58,109,214,109,26,52,42,250,120,121,199,189,209,200,184,229,193,231,46,93,180,82,175,87,171,237,202,75,232,97,183,113,183,220,228,101,89,98,62,172,79,119,89,26,181,240,237,197,254,229,177,187,110,125,251,30,177,99,168,225,61,182,39,20,128,47,190,127,246,242,45,133,113,167,88,42,46,188,177,142,129,80,137,105,37,57,243,214,59,86,178,45,1,149,13,33,230,81,250,13,22,108,177,78,248,72,199,222,96,55,70,123,192,201,214,175,33,84,155,106,179,153,222,69,15,183,182,64,176,200,132,2,170,95,30,4,11,89,68,6,62,106,107,114,148,116,239,69,15,56,8,130,3,21,34,207,156,105,20,132,60,147,18,115,84,166,69,102,25,68,9,63,30,61,53,94,79,254,88,47,243,193,162,34,132,22,31,144,64,96,120,36,7,34,193,55,65,98,165,168,16,173,246,90,96,90,84,47,246,65,226,113,218,158,192,243,127,7,143,44,62,163,242,200,80,120,106,31,32,29,11,26,44,83,142,138,8,21,231,46,165,189,224,41,81,187,228,69,161,19,73,170,127,239,35,139,178,68,198,141,22,38,250,12,94,167,31,15,158,211,190,93,214,239,169,180,234,4,253,193,163,26,17,134,80,16,80,50,101,37,193,68,104,197,162,35,18,80,34,123,229,100,144,136,118,104,68,211,201,171,250,195,178,109,234,75,172,251,217,9,94,31,45,107,170,239,111,183,249,106,133,131,40,89,204,146,7,69,244,228,37,10,106,125,212,255,64,123,58,50,10,78,121,167,186,8,124,115,223,73,41,99,209,177,0,43,134,114,164,173,85,12,36,247,228,164,224,136,201,36,195,113,112,114,47,55,60,12,214,239,136,249,152,128,75,53,187,231,120,35,186,49,79,250,102,114,1,117,110,74,153,28,108,17,79,218,38,45,118,235,85,255,98,118,210,244,216,109,29,120,162,147,159,76,39,137,23,174,45,97,150,30,212,185,98,34,58,209,104,8,194,34,228,228,141,176,81,252,84,58,73,46,36,149,149,102,210,83,7,214,42,36,22,36,39,124,23,48,1,188,76,186,192,94,58,193,88,108,140,65,49,15,196,66,52,43,82,51,231,60,179,100,17,44,113,82,65,41,126,229,36,251,61,96,70,103,188,73,3,217,16,215,83,202,144,130,99,76,100,46,59,229,137,109,35,209,206,215,71,223,111,196,229,120,154,167,17,249,151,192,50,202,96,184,163,158,232,16,2,77,96,86,50,159,135,169,82,132,88,148,83,178,20,185,15,150,4,91,154,5,12,213,22,149,59,181,38,170,99,159,105,52,5,207,85,214,214,171,156,213,215,96,121,190,249,4,164,124,36,49,190,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,146,37,81,242,173,72,221,34,64,209,4,136,145,75,149,195,138,92,202,68,245,2,73,165,117,13,255,123,73,209,86,157,194,69,220,94,26,157,196,193,112,118,102,185,187,11,88,3,90,127,134,22,131,101,176,70,165,64,247,194,92,127,144,141,65,245,81,245,227,16,92,5,26,149,132,70,254,64,238,241,21,151,230,61,24,176,87,118,229,47,133,50,88,150,231,53,202,224,170,12,164,193,86,91,142,189,34,162,42,74,242,132,17,33,24,35,9,229,17,41,242,2,9,82,96,25,20,57,167,2,61,243,79,226,55,125,59,128,66,95,99,146,23,211,239,122,59,56,106,100,1,54,81,164,238,187,3,184,112,38,244,170,131,170,65,110,207,70,141,104,33,163,100,107,211,224,90,182,120,15,202,214,114,58,189,131,44,73,64,163,29,171,65,97,86,223,7,133,90,203,190,123,205,92,51,182,221,41,219,10,224,124,60,216,9,39,143,142,121,15,102,51,73,220,90,91,251,201,229,187,186,86,88,131,145,207,167,38,190,226,118,226,93,214,63,123,129,219,87,122,132,102,196,147,154,47,147,220,192,96,124,32,95,222,18,148,172,55,23,103,157,59,246,90,220,216,130,195,145,124,161,230,217,12,113,102,193,103,7,120,149,227,111,25,124,185,213,119,223,58,84,15,108,131,45,248,174,61,93,91,244,55,96,214,95,238,210,4,66,40,120,65,82,198,57,73,82,6,36,143,179,130,80,140,22,81,142,52,164,85,188,127,242,62,164,30,26,216,62,206,229,62,33,248,134,185,190,217,51,11,33,23,85,94,145,48,198,140,36,97,68,73,21,179,152,136,40,138,69,66,139,98,122,149,189,251,220,51,244,181,100,208,220,13,168,224,240,2,225,249,1,125,49,217,46,188,234,123,227,35,205,205,155,189,28,71,36,227,121,78,11,180,51,145,9,74,18,145,113,2,33,21,132,166,21,98,186,200,242,52,170,172,25,187,221,174,191,15,253,168,216,97,155,180,95,235,127,90,215,255,176,132,127,179,87,103,39,251,146,73,125,43,51,248,102,38,109,31,236,127,2,172,119,96,187,60,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,152,75,111,27,71,12,128,255,138,176,205,161,5,76,97,222,15,223,218,166,7,3,78,26,212,105,46,177,15,156,33,39,17,42,75,134,118,149,32,53,252,223,203,149,237,36,14,26,197,65,157,6,2,164,195,8,90,45,57,28,14,191,33,57,151,221,163,225,221,5,119,135,221,115,94,173,176,95,182,97,250,235,114,197,211,103,171,101,229,190,159,30,47,43,206,103,127,99,153,243,51,92,225,57,15,188,122,129,243,53,247,199,179,126,56,152,220,21,235,14,186,71,111,54,255,118,135,47,47,187,163,129,207,255,60,34,209,158,60,170,90,155,130,168,85,2,87,141,1,204,148,32,103,76,100,147,166,164,80,132,235,114,190,62,95,60,225,1,159,225,240,186,59,188,236,54,218,68,65,169,170,26,10,10,60,90,2,151,156,2,68,199,80,131,98,140,49,176,81,161,187,58,232,250,250,154,207,113,51,233,7,97,167,177,165,204,25,162,87,5,28,151,2,169,98,133,214,108,46,65,148,105,174,163,240,205,251,31,4,95,254,112,188,92,254,181,190,152,26,99,157,174,164,193,23,107,197,126,153,62,43,173,33,180,24,178,229,22,216,185,105,196,172,178,146,25,188,45,30,156,207,178,62,83,44,40,100,206,42,152,80,125,248,225,108,156,136,102,253,197,28,223,189,248,236,124,199,140,52,233,7,124,197,211,159,223,226,108,152,45,94,77,122,156,243,181,248,197,157,157,248,88,193,229,233,245,134,158,118,135,167,159,219,210,155,239,147,141,167,238,110,234,167,251,121,218,29,156,118,39,203,245,170,142,26,173,252,120,252,145,229,155,73,54,175,124,242,243,118,3,229,201,98,61,159,223,60,121,140,3,222,190,120,251,120,73,179,54,99,58,90,156,220,238,219,70,139,186,249,192,191,12,183,159,107,219,254,139,216,19,92,136,131,87,79,197,1,31,108,127,111,229,115,113,227,173,226,98,178,87,81,55,136,140,89,2,40,24,72,164,17,178,206,165,217,104,77,107,102,35,253,7,55,94,241,162,242,93,195,238,19,62,55,242,253,198,219,35,57,55,118,141,174,186,234,174,174,14,62,230,73,107,211,66,228,10,190,58,225,169,25,13,165,114,4,19,169,176,171,186,178,214,91,121,202,197,196,92,99,0,101,180,88,212,188,6,172,20,192,102,27,88,171,144,11,185,111,201,19,53,93,107,10,16,76,172,224,72,6,36,241,175,34,78,204,5,139,83,117,26,66,179,150,229,148,240,226,34,97,190,54,64,113,55,132,224,163,203,92,91,192,122,79,158,158,50,211,228,28,135,245,106,54,188,155,158,8,73,61,172,132,177,119,123,160,118,19,168,123,196,207,87,1,69,161,37,163,99,4,114,77,11,161,88,160,68,197,144,173,139,62,105,129,165,249,173,64,165,100,74,211,20,193,142,118,56,35,105,46,169,138,80,90,214,182,38,81,107,218,183,0,234,229,81,255,251,219,5,175,174,253,115,216,112,222,243,217,84,158,126,242,224,183,57,159,243,98,56,188,100,50,42,219,172,33,25,150,149,122,34,64,151,50,20,193,94,168,79,62,100,117,37,2,239,3,249,240,18,35,54,51,158,14,173,177,36,95,93,8,74,145,125,35,77,69,147,73,132,181,92,157,125,9,197,13,38,130,225,176,156,188,198,5,45,91,155,252,120,131,206,152,222,86,220,175,231,195,79,211,95,214,244,138,165,178,40,216,243,164,174,87,227,238,239,49,253,62,152,102,137,5,201,79,6,76,145,90,203,5,43,113,153,44,74,140,219,146,106,208,77,85,218,134,233,189,13,187,47,166,168,124,77,205,51,196,156,21,184,172,3,36,45,177,156,45,169,28,4,254,138,118,43,166,190,170,134,49,7,40,42,73,222,211,38,72,222,19,240,106,35,170,198,123,155,81,237,42,166,218,120,142,53,59,32,150,141,114,205,69,64,149,24,44,231,22,66,201,222,217,244,96,152,110,114,232,100,57,174,105,15,231,78,230,80,29,10,219,32,133,95,106,66,184,211,62,139,60,73,95,149,148,37,23,146,37,178,95,5,39,219,164,152,70,51,106,194,49,100,45,160,206,22,60,249,98,88,17,201,129,177,21,78,110,213,26,175,198,252,107,71,5,226,165,212,208,129,164,85,85,67,105,38,180,188,171,112,50,58,194,84,68,164,230,56,122,155,32,143,107,203,52,214,43,49,42,50,252,96,112,62,97,222,180,140,132,3,79,228,189,201,48,59,223,247,142,223,7,83,50,154,51,55,7,85,5,7,78,105,3,197,72,229,218,80,99,210,81,19,190,239,253,254,159,28,202,209,196,16,141,144,161,19,141,205,104,21,131,154,2,227,88,58,209,24,36,156,183,151,186,190,134,28,162,114,82,124,115,26,49,181,144,132,78,16,246,67,149,83,35,88,81,176,163,152,6,211,138,102,89,91,225,36,107,43,202,67,54,65,218,245,88,91,147,134,32,54,82,15,134,233,166,43,29,145,219,163,185,147,25,84,114,90,225,98,36,121,102,43,3,51,75,242,108,6,208,184,136,190,85,9,161,244,117,229,45,234,152,53,34,36,25,193,161,148,183,25,157,135,102,169,82,180,36,232,108,191,214,25,19,103,104,186,64,206,146,125,93,193,38,170,188,3,21,165,81,118,164,66,244,117,87,209,36,133,89,250,242,12,193,102,57,183,162,22,72,181,30,187,0,41,251,125,141,148,169,61,24,154,143,185,206,250,217,114,177,201,156,243,217,98,143,232,62,123,94,223,188,86,76,185,54,15,38,21,55,54,89,90,162,48,218,241,226,148,117,73,89,21,129,100,27,162,232,20,6,215,80,122,51,22,198,21,11,227,46,74,27,234,115,213,212,74,201,118,103,47,138,140,53,82,228,83,0,103,199,251,130,42,231,23,70,91,165,61,87,218,75,94,69,74,238,129,59,80,154,189,217,128,186,231,115,39,83,168,151,136,240,65,72,210,158,229,40,39,246,80,148,12,40,101,152,146,106,52,251,250,69,62,207,174,254,1,204,178,65,6,199,28,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,15,202,146,124,11,82,183,8,80,52,1,98,228,82,229,176,146,150,50,81,189,64,82,105,93,195,255,222,165,104,43,73,225,34,110,15,69,116,162,6,195,225,204,62,118,94,217,128,214,95,160,69,111,233,173,81,41,208,189,48,151,31,101,99,80,125,82,253,56,120,23,158,70,37,161,145,63,177,114,248,170,146,230,3,24,160,43,187,252,89,33,247,150,249,105,141,220,187,200,61,105,176,213,196,161,43,28,1,69,200,83,6,105,156,50,46,66,58,21,105,200,68,86,22,97,28,113,81,96,225,152,127,18,191,238,219,1,20,186,55,38,121,49,29,215,219,193,82,3,2,202,137,34,117,223,29,192,200,154,208,171,14,138,6,43,250,55,106,68,130,140,146,45,165,193,181,108,241,14,20,189,101,117,122,11,61,147,26,20,102,245,99,80,168,181,236,187,183,188,53,99,219,189,100,147,0,206,191,7,55,254,100,209,50,239,192,108,38,137,27,114,181,159,76,94,213,181,194,26,140,124,178,84,1,141,182,38,190,225,118,226,157,87,62,186,80,81,147,30,160,25,241,197,155,175,147,92,195,96,92,32,247,60,17,148,172,55,103,103,157,11,246,86,220,144,192,225,72,62,83,243,100,134,112,65,224,147,5,156,202,241,152,123,95,111,244,237,247,14,213,125,185,193,22,92,213,30,47,9,253,13,152,245,151,187,152,131,15,89,149,177,184,172,42,198,227,18,88,26,46,50,150,96,16,5,41,38,126,82,132,251,71,231,67,234,161,129,237,195,252,220,103,4,87,48,91,55,250,23,2,163,48,162,54,4,97,92,50,78,141,96,105,150,32,35,60,225,49,6,69,228,7,212,95,251,217,54,244,181,44,161,185,29,80,193,161,3,254,233,249,124,53,216,54,188,234,123,227,34,205,197,155,189,28,71,100,145,128,224,139,164,160,96,165,207,120,66,167,84,80,176,8,176,168,170,132,11,94,196,100,134,150,219,214,247,190,31,85,121,88,38,237,182,250,159,182,245,255,239,224,223,172,213,201,193,62,103,80,223,203,8,190,155,65,219,123,251,95,122,12,133,58,58,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,203,110,19,75,16,253,149,168,97,233,178,250,53,253,200,14,193,38,82,128,136,112,217,96,22,213,221,213,96,97,123,162,153,241,189,10,145,255,253,150,39,54,137,17,4,75,60,36,36,102,49,86,183,251,156,170,169,58,167,235,70,60,30,174,175,72,156,138,215,212,117,216,183,117,152,62,109,59,154,94,116,109,166,190,159,158,183,25,23,243,79,152,22,116,129,29,46,105,160,238,13,46,214,212,159,207,251,97,114,114,8,19,19,241,248,223,241,95,113,250,246,70,156,13,180,252,231,172,48,123,178,104,149,147,17,82,138,1,172,43,13,96,172,196,203,130,186,122,235,130,50,12,206,237,98,189,92,61,167,1,47,112,248,32,78,111,196,200,182,37,200,50,235,226,36,52,104,10,216,96,37,32,90,130,236,36,161,247,142,180,116,98,51,17,125,254,64,75,28,131,222,129,173,194,26,34,69,240,141,76,96,41,37,8,25,51,212,106,98,114,76,166,40,111,193,187,243,119,192,183,143,206,219,246,227,250,106,170,181,177,42,23,5,77,50,6,108,230,240,81,42,5,174,122,23,13,85,71,214,78,61,70,25,37,71,104,76,106,192,54,252,165,81,39,3,18,137,162,116,218,229,198,61,122,183,13,84,230,253,213,2,175,223,124,51,222,57,97,57,233,7,124,79,211,39,255,225,124,152,175,222,159,244,184,160,91,248,213,65,39,238,19,220,204,110,27,58,19,167,179,111,181,116,247,123,57,86,234,176,169,95,246,115,38,38,51,113,217,174,187,188,101,52,188,120,118,47,243,49,200,120,228,139,229,190,129,188,179,90,47,22,187,157,103,56,224,254,224,126,187,45,243,58,167,114,182,186,220,247,109,100,145,187,7,190,242,218,63,183,185,253,8,236,57,174,184,192,221,11,46,192,93,238,159,179,124,205,101,220,19,39,29,27,233,85,5,79,24,89,64,78,67,40,10,33,170,152,170,241,70,215,170,71,244,43,170,212,209,42,211,97,98,199,200,103,135,239,199,106,111,157,179,203,107,91,170,141,216,108,38,247,253,20,141,215,77,83,17,164,215,108,135,196,185,160,212,76,104,208,153,236,217,20,77,249,142,159,48,40,79,134,45,225,152,64,178,86,67,144,22,66,19,163,149,70,201,226,194,207,247,211,76,188,236,10,117,51,241,144,9,14,14,253,149,250,111,150,186,209,13,122,147,2,200,106,61,88,139,18,184,159,26,88,83,172,214,32,165,193,252,144,212,143,78,236,88,169,215,210,104,101,89,93,33,110,111,126,44,9,18,133,12,197,89,173,36,154,236,172,124,80,234,49,105,31,217,19,192,6,97,243,213,70,1,230,226,192,68,227,72,73,23,83,177,191,114,116,148,170,114,14,14,156,246,25,108,225,23,22,190,74,100,161,64,148,48,89,153,167,206,85,99,168,4,30,29,84,121,188,229,10,200,55,11,56,215,120,27,41,87,135,249,200,209,241,130,168,156,44,113,88,119,243,225,122,122,201,67,163,135,142,199,201,245,223,217,241,103,206,142,35,244,243,61,67,189,219,252,15,169,50,49,141,233,9,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeIntermediateCatchSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0666ed69-b39c-40e3-8809-2b5e4de75265"),
				ContainerUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeLinkLeadToProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entityIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("7c89538d-7e55-4c93-9f0f-a2c2f80b1e80"),
				ContainerUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{54a0a9d9-5cdd-45ca-8269-7e1318e707b2}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("ba921970-53ef-41a3-b7a6-07acd54a2917"),
				ContainerUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
		}

		protected virtual void InitializePreconfiguredPageHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var buttonsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd439ed6-0ae1-4e89-bae6-1c0a8a3ca336"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("21620f25-166f-42f1-8b4d-224a959040a3"),
				Name = @"Buttons",
				SourceParameterUId = new Guid("c49bd85e-159a-49ee-b10a-3c3bca63d7d5"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableParameterValuesListDataValueType")
			};
			buttonsParameter.SourceValue = new ProcessSchemaParameterValue(buttonsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,209,106,194,48,20,64,127,101,4,31,91,105,108,154,164,62,206,177,33,200,16,116,190,140,61,220,166,55,82,168,141,36,81,152,210,127,95,234,192,85,230,166,143,225,158,115,115,57,71,50,240,159,91,36,99,178,68,107,193,25,237,135,19,99,113,56,183,70,161,115,195,153,81,80,87,7,40,106,156,131,133,13,122,180,43,168,119,232,102,149,243,209,195,165,70,34,50,216,159,166,100,252,126,36,83,143,155,183,105,25,182,235,68,164,200,57,196,41,71,21,51,81,138,56,87,225,137,89,158,141,202,66,39,25,164,65,238,216,35,57,109,184,87,106,35,242,26,206,234,123,143,59,239,77,19,23,200,41,147,133,164,57,205,24,36,34,167,8,136,82,83,158,102,165,204,242,78,93,194,186,111,46,96,143,79,224,161,27,77,96,235,43,211,116,227,202,205,212,97,245,205,120,187,195,232,66,232,224,57,90,109,236,102,82,27,23,58,173,47,206,89,6,163,199,156,255,184,130,188,96,131,22,60,46,170,117,3,117,159,32,109,27,245,131,42,38,25,21,44,137,181,150,161,77,194,117,44,249,136,199,84,9,169,133,228,137,44,244,175,160,119,73,127,7,77,65,130,226,92,200,60,47,25,0,151,201,136,134,174,88,4,95,177,92,93,9,250,19,228,222,162,39,227,86,210,103,168,221,173,166,103,230,223,168,31,237,23,98,94,143,130,3,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(buttonsParameter);
			var meetingTimeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea4da8b1-8c97-415d-9fa4-9deeba770d2e"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354"),
				Name = @"MeetingTime",
				SourceParameterUId = new Guid("e9f72f6a-0eff-4e68-864d-f1dcad242111"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			meetingTimeParameter.SourceValue = new ProcessSchemaParameterValue(meetingTimeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{efc32501-4c3a-4500-8fa4-1d70c6bf26f9}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(meetingTimeParameter);
			var budgetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7af2cd6-ffed-41bd-bba9-d1db1d28dacb"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354"),
				Name = @"Budget",
				SourceParameterUId = new Guid("90277d47-bd39-4223-988d-7d344e992a89"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Money")
			};
			budgetParameter.SourceValue = new ProcessSchemaParameterValue(budgetParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{882bf1d7-3d1f-4208-80ca-bf913c8d4f2f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(budgetParameter);
			var leadTypeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("62fb1e04-be88-4b05-9260-97cff70e7fd0"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354"),
				Name = @"LeadType",
				SourceParameterUId = new Guid("3fc34788-da60-4f98-b727-c7043c8e78dc"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadTypeParameter.SourceValue = new ProcessSchemaParameterValue(leadTypeParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{5c696704-62e8-4503-86bf-ed66c3dd63d5}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(leadTypeParameter);
			var opportunityResponsibleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("125e7c94-de3b-4f47-a08e-3e9f66b95438"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354"),
				Name = @"OpportunityResponsible",
				SourceParameterUId = new Guid("50f1b745-60ef-42d8-b86e-03cdf1d46efa"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityResponsibleParameter.SourceValue = new ProcessSchemaParameterValue(opportunityResponsibleParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(opportunityResponsibleParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("232d61d6-434e-4c16-a73c-93015b1ead84"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354"),
				Name = @"OpportunityDepartment",
				SourceParameterUId = new Guid("2b37d4d0-30ee-4776-be71-29ae6ab51140"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(opportunityDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{a40a64fa-a0ea-40e6-9476-a59c1dfbb93f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
			var decisionDateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d0a9cab9-639d-4714-b110-49e8c5c7d9df"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354"),
				Name = @"DecisionDate",
				SourceParameterUId = new Guid("c9be7aef-b3d0-47ad-8caa-37a8899e4533"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Date")
			};
			decisionDateParameter.SourceValue = new ProcessSchemaParameterValue(decisionDateParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{4c3a6f1b-99d3-4baf-8954-076274d0675c}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(decisionDateParameter);
			var commentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("22bf4bfa-f58e-4663-a208-3110eec5c50e"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354"),
				Name = @"Comment",
				SourceParameterUId = new Guid("a4d71df5-ff52-429a-b041-1e1440312506"),
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			commentParameter.SourceValue = new ProcessSchemaParameterValue(commentParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{7a0cc7e5-2317-4ecb-bfb1-88b6b2ef9dd0}].[Parameter:{946dd2c0-da26-457d-ad8c-4ba3167aa54d}].[EntityColumn:{070b689f-c9d8-46e3-bb52-bcb1f430f5cf}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(commentParameter);
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e7977a6-2f27-4cb3-b264-9a642764dc2b"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Value = @"Proceed to handoff: Information",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b8a75bc-4bec-42a7-8fa7-04edbe01e963"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Value = @"Specify information that is required for proceeding to handoff",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var clientUnitSchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6aa10889-0cc7-4466-87e8-176439593643"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Value = @"067c50a0-c32f-4029-b05b-7eb828899354",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8015a032-1f65-4d40-89af-7a79e32c707a"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21c8281e-f66e-4376-bcab-61b34f7bfa6e"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				UId = new Guid("1944babc-7a76-4073-9b5e-a9f5ee8e12d1"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("27221e08-6c14-4e5c-ac15-1e683d22e43e"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("e7585c2b-4f9e-46ec-955b-7d738f8eb372"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("92191d80-a9a5-41bf-8d86-a3e1f1ed5221"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Value = @"[#BooleanValue.True#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bdd7fed1-0061-4a97-8b63-1981ccb2a7ae"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Use the page to specify information about customer's budget, decision date, need type (the BANT criteria) and the information required to create an opportunity (owner and sales division).",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("30f55d3c-cc99-414a-bfa6-eecd40544ec0"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var templateParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				UId = new Guid("bfd8d126-f643-4fc1-b105-58d57466e759"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				UId = new Guid("0d9fd7f7-e06e-4c0b-9894-be5848266fae"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				UId = new Guid("eb3bde6c-e6a3-4c15-9d6d-338beeae6b82"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
				UId = new Guid("36ce5854-701f-4703-9b07-bbf3a76b8847"),
				ContainerUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
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
		}

		protected virtual void InitializeAutoGeneratedPageHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37ca1e6d-f9a7-4c7f-ba6c-9ca142ff1579"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("92313c1a-6c83-4de1-b493-4b387b234357"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41d66075-70c0-453a-8022-cff5949370b2"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""853857d6-cc8a-4f66-a1ca-f7261718597c"",""isEnabled"":true,""performValidation"":true,""caption"":""Save"",""name"":""SaveButton"",""style"":""green"",""generateSignal"":""""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"{""$type"":""System.Collections.Generic.List`1[[System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib]], mscorlib"",""$values"":[{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""3a8ae276-d1a6-4833-8edd-18a3802457a6"",""controlEditType"":""SelectionField"",""caption"":""Need type"",""name"":""LeadType"",""dataSource"":null,""dataFilter"":"""",""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""396b79de-3b3c-45d3-aea7-bdab8f0a023e"",""controlEditType"":""4"",""caption"":""Budget, base currency"",""name"":""Budget"",""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""55254183-6074-4e56-9aab-59ca46e386f2"",""controlEditType"":""SelectionField"",""caption"":""Sales owner"",""name"":""OpportunityResponsible"",""dataSource"":null,""dataFilter"":"""",""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""476a3574-3ae8-49f9-a144-15e4daebec38"",""controlEditType"":""SelectionField"",""caption"":""Sales division"",""name"":""OpportunityDepartment"",""dataSource"":null,""dataFilter"":"""",""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""968839fa-bdc5-40db-84fc-b1c7ba66460b"",""controlEditType"":""DateTimeField"",""caption"":""Meeting date and time"",""name"":""MeetingTime"",""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""1cda6777-d842-406e-9075-3c837bf46d26"",""controlEditType"":""DateTimeField"",""caption"":""Decision timeline"",""name"":""DecisionDate"",""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""8""},{""$type"":""System.Collections.Generic.Dictionary`2[[System.String, mscorlib],[System.Object, mscorlib]], mscorlib"",""Id"":""765a88b1-8502-4f19-801f-b1be417dd065"",""controlEditType"":""1"",""caption"":""Notes"",""name"":""Comment"",""isMultiline"":true,""dataSource"":null,""controlDataValueType"":""10"",""dateTimeFormat"":""7""}]}",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysVariable.CurrentUserContact#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var leadTypeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("3a8ae276-d1a6-4833-8edd-18a3802457a6"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(leadTypeParameter);
			var budgetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("396b79de-3b3c-45d3-aea7-bdab8f0a023e"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"Budget",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			budgetParameter.SourceValue = new ProcessSchemaParameterValue(budgetParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dd2ac32-09a4-4dbc-8842-1a47347c5896}].[Parameter:{69f1e87b-3dd8-44cf-8c4f-97bd0653ad06}].[EntityColumn:{882bf1d7-3d1f-4208-80ca-bf913c8d4f2f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(budgetParameter);
			var opportunityResponsibleParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("55254183-6074-4e56-9aab-59ca46e386f2"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(opportunityResponsibleParameter);
			var meetingTimeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("968839fa-bdc5-40db-84fc-b1c7ba66460b"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(meetingTimeParameter);
			var commentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("765a88b1-8502-4f19-801f-b1be417dd065"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(commentParameter);
			var decisionDateParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cda6777-d842-406e-9075-3c837bf46d26"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(decisionDateParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				UId = new Guid("476a3574-3ae8-49f9-a144-15e4daebec38"),
				ContainerUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadHandoffProcess = CreateLeadHandoffProcessLaneSet();
			LaneSets.Add(schemaLeadHandoffProcess);
			ProcessSchemaLane schemaLeadHandoff = CreateLeadHandoffLane();
			schemaLeadHandoffProcess.Lanes.Add(schemaLeadHandoff);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
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
			ProcessSchemaParallelGateway parallelgateway1 = CreateParallelGateway1ParallelGateway();
			FlowElements.Add(parallelgateway1);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignal1 = CreateIntermediateCatchSignal1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignal1);
			ProcessSchemaUserTask linkleadtoprocess = CreateLinkLeadToProcessUserTask();
			FlowElements.Add(linkleadtoprocess);
			ProcessSchemaUserTask preconfiguredpagehandoff = CreatePreconfiguredPageHandoffUserTask();
			FlowElements.Add(preconfiguredpagehandoff);
			ProcessSchemaUserTask autogeneratedpagehandoff = CreateAutoGeneratedPageHandoffUserTask();
			FlowElements.Add(autogeneratedpagehandoff);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow9ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow7ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateUsePreconfiguredPageSequenceFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5b260b1a-a023-4cd9-a40d-481707a20898"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00836aec-4306-4338-9ac5-67ea748b499b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(182, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(242, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(566, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(560, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(546, 413));
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(582, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(581, 294));
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(956, 180),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fc72f013-94f8-4bb7-bf05-844971922387"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(712, 163),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(353, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(326, 164),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(512, 125));
			schemaFlow.PolylinePointPositions.Add(new Point(425, 125));
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(1148, 189),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(952, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("8cdb95ca-c8ea-4880-b7cc-741fa584081f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("00276668-9718-4e94-8d54-1a9582a96ad4"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
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
			schemaFlow.PolylinePointPositions.Add(new Point(546, 52));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("8a89a1de-5431-429e-96cb-23ab20de3310"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(311, 522));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("a03340ad-f234-41cf-98dc-8ca1a3a48685"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf288ac2-175d-42be-a7ba-9dfdcc1724f5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1353, 522));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("450418d7-0200-4475-b7ff-5b9a030033d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("be291346-793f-4516-aa5b-d5092e1c6503"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf8af50c-5791-4531-ac0c-21f2700e557b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("47eaf747-e0b8-4eff-bce4-6df58989cb81"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f6aebbc8-6ffc-46ca-8d74-2aaafaae30a1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1194, 367));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateUsePreconfiguredPageSequenceFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "UsePreconfiguredPageSequenceFlow",
				UId = new Guid("240af2fa-289a-4821-8d0a-77442e4a7b10"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3a87c19b-078d-4508-a1ee-049df3ff5ec3}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc72f013-94f8-4bb7-bf05-844971922387"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(952, 367));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("f9d37bfb-b7d4-4928-96f7-c876cc010762"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc72f013-94f8-4bb7-bf05-844971922387"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"LeadHandoffProcess",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"LeadHandoff",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"Start",
				Position = new Point(79, 80),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayLeadDefinedExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("797c933b-e134-4396-92fb-4ffdc2451daf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ExclusiveGatewayLeadDefined",
				Position = new Point(65, 155),
				SerializeToDB = false,
				Size = new Size(55, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"TerminateLeadUndefined",
				Position = new Point(79, 281),
				SerializeToDB = false,
				Size = new Size(27, 27),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ReadLeadData",
				Position = new Point(391, 155),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ActivityUserTaskBANT",
				Position = new Point(512, 155),
				SchemaUId = new Guid("b5c726f2-af5b-4381-bac6-913074144308"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ChangeLeadStateToNoInterest",
				Position = new Point(699, 386),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ChangeLeadNurturing",
				Position = new Point(699, 267),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"TerminateOpportunity",
				Position = new Point(1340, 169),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadForHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4dd2ac32-09a4-4dbc-8842-1a47347c5896"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ReadLeadForHandoff",
				Position = new Point(825, 155),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ReadActivityData",
				Position = new Point(699, 155),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"AddDataUserTask1",
				Position = new Point(1160, 155),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(1251, 155),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
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
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ChangeDataUserTask2",
				Position = new Point(1210, 25),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ParallelGateway1",
				Position = new Point(284, 155),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignal1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"IntermediateCatchSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(782, 508),
				SerializeToDB = true,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("bc0c2d60-5a3d-4840-aa4e-c60ea776e206");
			InitializeIntermediateCatchSignal1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateLinkLeadToProcessUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"LinkLeadToProcess",
				Position = new Point(171, 155),
				SchemaUId = new Guid("fcace79b-6103-4992-8a1f-8e443114321a"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeLinkLeadToProcessParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreatePreconfiguredPageHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ed209391-82e1-45dd-a489-be109bd85690"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"PreconfiguredPageHandoff",
				Position = new Point(1051, 340),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializePreconfiguredPageHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAutoGeneratedPageHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7f0328f3-6b56-45dd-bacd-6d4cb7a2b473"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"AutoGeneratedPageHandoff",
				Position = new Point(1035, 155),
				SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAutoGeneratedPageHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("fc72f013-94f8-4bb7-bf05-844971922387"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7aa4cc41-8f72-475b-881a-a2f9ad4cbc74"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb"),
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"ExclusiveGateway1",
				Position = new Point(925, 155),
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

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementHandoff78(userConnection);
		}

		public override object Clone() {
			return new LeadManagementHandoff78Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementHandoff78

	/// <exclude/>
	public class LeadManagementHandoff78 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadHandoff

		/// <exclude/>
		public class ProcessLeadHandoff : ProcessLane
		{

			public ProcessLeadHandoff(UserConnection userConnection, LeadManagementHandoff78 process)
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

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,162,41,81,242,173,72,221,34,64,209,4,136,145,75,149,195,74,90,218,68,245,2,73,167,117,13,255,123,73,209,86,157,194,69,220,94,26,157,196,193,236,236,236,107,23,85,13,24,243,25,90,140,230,209,18,181,6,211,75,123,253,65,53,22,245,71,221,111,134,232,42,50,168,21,52,234,7,214,1,95,212,202,190,7,11,46,100,87,252,82,40,162,121,113,94,163,136,174,138,72,89,108,141,227,184,16,42,120,157,243,24,136,40,19,70,56,48,73,50,201,74,146,82,224,178,142,171,92,82,22,152,127,18,191,233,219,1,52,134,28,163,188,28,127,151,219,193,83,99,7,84,35,69,153,190,59,128,51,111,194,44,58,40,27,172,221,219,234,13,58,200,106,213,186,106,112,169,90,188,7,237,114,121,157,222,67,142,36,161,49,158,213,160,180,139,239,131,70,99,84,223,189,102,174,217,180,221,41,219,9,224,244,60,216,161,163,71,207,188,7,187,30,37,110,157,173,253,232,242,221,106,165,113,5,86,61,159,154,248,138,219,145,119,89,255,92,64,237,166,244,8,205,6,79,114,190,172,228,6,6,27,10,10,233,29,65,171,213,250,226,90,167,142,189,86,46,115,224,112,36,95,168,121,182,6,150,58,240,217,3,65,229,248,91,68,95,110,205,221,183,14,245,67,181,198,22,66,215,158,174,29,250,27,48,233,207,119,9,7,10,121,157,147,164,170,107,194,147,10,72,198,210,156,8,140,103,113,134,130,138,146,237,159,130,15,101,134,6,182,143,83,186,79,8,161,97,190,111,238,13,169,76,69,28,87,132,150,76,16,142,85,73,202,140,81,34,120,10,73,37,89,146,167,210,205,215,127,126,12,253,74,85,208,220,13,168,225,48,1,122,126,65,95,108,182,47,94,247,189,13,37,77,205,155,188,28,87,68,148,82,102,9,203,136,200,83,32,156,198,130,64,22,103,132,114,65,121,60,19,128,210,69,238,221,117,251,254,62,244,27,93,29,174,201,132,179,254,167,115,253,15,71,248,55,119,117,118,179,47,217,212,183,178,131,111,102,211,246,209,254,39,155,163,148,188,60,6,0,0 })));
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

		#region Class: ActivityUserTaskBANTFlowElement

		/// <exclude/>
		public class ActivityUserTaskBANTFlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTaskBANTFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
					return _recommendation ?? (_recommendation = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
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

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startIn = 0;
			public override int StartIn {
				get {
					return _startIn;
				}
				set {
					_startIn = value;
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

			private int _remindBefore = 0;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
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

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			private bool _showExecutionPage = false;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.ActivityUserTaskBANT.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			public virtual Guid ConfItem {
				get;
				set;
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

			public ChangeLeadStateToNoInterestFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,15,82,15,223,138,212,45,2,20,77,128,24,185,84,57,44,197,149,77,84,47,144,84,90,215,240,191,151,20,109,213,41,92,196,237,165,209,73,28,12,103,103,150,187,187,160,106,64,235,207,208,98,176,8,86,168,20,232,190,54,215,31,100,99,80,125,84,253,56,4,87,129,70,37,161,145,63,80,120,124,41,164,121,15,6,236,149,93,249,75,161,12,22,229,121,141,50,184,42,3,105,176,213,150,99,175,80,154,51,100,5,39,85,198,66,66,121,157,144,156,179,132,0,205,235,48,6,22,81,158,122,230,159,196,111,250,118,0,133,190,198,36,95,79,191,171,237,224,168,145,5,170,137,34,117,223,29,192,196,153,208,203,14,120,131,194,158,141,26,209,66,70,201,214,166,193,149,108,241,30,148,173,229,116,122,7,89,82,13,141,118,172,6,107,179,252,62,40,212,90,246,221,107,230,154,177,237,78,217,86,0,231,227,193,78,56,121,116,204,123,48,155,73,226,214,218,218,79,46,223,173,215,10,215,96,228,243,169,137,175,184,157,120,151,245,207,94,16,246,149,30,161,25,241,164,230,203,36,55,48,24,31,200,151,183,4,37,215,155,139,179,206,29,123,45,110,108,193,225,72,190,80,243,108,134,56,181,224,179,3,188,202,241,183,12,190,220,234,187,111,29,170,135,106,131,45,248,174,61,93,91,244,55,96,214,95,236,24,133,16,10,81,16,86,9,65,40,171,128,228,113,90,144,12,163,36,202,49,11,51,30,239,159,188,15,169,135,6,182,143,115,185,79,8,190,97,174,111,246,140,144,84,117,30,69,132,101,57,18,26,37,57,1,94,71,36,7,42,210,156,243,42,202,10,251,190,238,115,207,208,175,101,5,205,221,128,10,14,47,16,158,31,208,23,147,237,194,171,190,55,62,210,220,188,217,203,113,68,98,158,177,84,36,25,137,35,78,9,21,192,72,145,9,70,56,64,74,235,130,242,152,133,214,140,221,110,215,223,135,126,84,213,97,155,180,95,235,127,90,215,255,176,132,127,179,87,103,39,251,146,73,125,43,51,248,102,38,109,31,236,127,2,0,193,94,137,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,203,110,219,48,16,252,21,131,201,209,107,240,37,82,244,181,185,4,112,130,160,73,115,137,115,88,146,203,70,168,108,25,146,92,32,53,252,239,165,21,187,137,131,166,13,80,244,82,148,7,10,164,118,102,7,59,26,109,216,105,255,184,34,54,101,55,212,182,216,53,169,159,124,104,90,154,92,181,77,160,174,155,204,154,128,117,245,13,125,77,87,216,226,130,122,106,111,177,94,83,55,171,186,126,60,58,134,177,49,59,253,58,188,101,211,187,13,59,239,105,241,233,60,102,118,36,201,117,50,5,96,146,37,104,206,3,248,194,43,8,133,46,60,218,100,69,33,51,56,52,245,122,177,188,160,30,175,176,127,96,211,13,27,216,50,129,243,210,186,96,13,112,41,20,232,84,8,192,16,13,40,167,12,9,110,156,143,154,109,199,172,11,15,180,192,161,233,51,88,11,76,165,35,7,182,224,30,52,121,15,101,192,0,41,41,231,141,46,181,160,176,3,239,235,159,129,119,39,179,166,249,178,94,77,100,76,34,132,210,128,145,54,128,142,121,195,40,18,240,72,37,145,71,175,121,152,36,91,114,99,162,2,180,138,114,155,92,238,189,115,64,218,218,20,188,211,94,150,39,247,187,70,177,234,86,53,62,222,190,217,239,146,40,142,22,216,175,219,170,127,156,92,54,253,168,90,230,201,83,215,83,124,162,88,29,185,241,146,100,51,127,50,117,206,166,243,183,108,221,63,175,135,105,29,27,251,218,211,57,27,207,217,117,179,110,195,142,81,229,195,217,11,245,67,147,161,228,213,241,96,98,190,89,174,235,122,127,115,134,61,30,10,15,215,77,172,82,69,241,124,121,125,240,110,96,225,251,5,63,217,14,235,73,219,159,192,46,112,137,159,169,189,204,3,120,214,254,67,229,77,30,227,129,216,75,87,112,155,61,183,132,46,187,107,36,148,81,32,56,225,124,82,86,201,148,228,128,254,72,41,59,181,12,116,44,236,61,159,208,30,223,13,211,222,165,103,175,107,55,170,45,219,110,199,47,51,85,234,96,76,169,36,168,84,228,76,217,50,167,75,37,3,78,150,69,178,62,40,12,238,151,153,242,129,7,25,13,135,2,85,132,28,3,14,136,154,32,24,78,104,173,201,153,53,127,51,83,82,105,17,162,128,252,35,200,145,14,185,189,227,66,128,73,214,56,69,201,144,214,147,66,96,12,138,2,168,130,231,34,47,178,70,158,27,150,158,148,231,36,68,226,239,205,212,140,48,142,186,62,219,253,63,80,255,68,160,222,241,253,252,46,80,247,219,239,173,114,87,101,2,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "cb7254e015204e0a81829b0d833246e0",
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

			public ChangeLeadNurturingFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,128,150,245,162,111,69,234,22,1,138,38,64,140,92,170,28,86,228,202,38,42,89,2,73,167,117,13,255,123,151,162,173,58,133,139,184,189,52,62,201,131,225,236,204,62,118,145,108,192,218,207,208,98,52,139,22,104,12,216,174,118,215,31,116,227,208,124,52,221,166,143,174,34,139,70,67,163,127,160,10,248,92,105,247,30,28,208,147,93,249,75,161,140,102,229,121,141,50,186,42,35,237,176,181,196,161,39,121,193,101,12,85,205,38,117,197,89,82,115,193,64,73,193,120,37,164,192,36,139,167,82,5,230,159,196,111,186,182,7,131,161,198,32,95,15,159,139,109,239,169,19,2,228,64,209,182,91,31,192,169,55,97,231,107,168,26,244,242,206,108,144,32,103,116,75,105,112,161,91,188,7,67,181,188,78,231,33,34,213,208,88,207,106,176,118,243,239,189,65,107,117,183,126,205,92,179,105,215,167,108,18,192,241,239,193,14,31,60,122,230,61,184,213,32,113,75,182,246,131,203,119,203,165,193,37,56,253,124,106,226,43,110,7,222,101,253,163,7,138,166,244,8,205,6,79,106,190,76,114,3,189,11,129,66,121,34,24,189,92,93,156,117,236,216,107,113,99,2,251,35,249,66,205,179,25,226,140,192,103,15,4,149,227,103,25,125,185,181,119,223,214,104,30,228,10,91,8,93,123,186,38,244,55,96,212,159,237,210,4,56,8,37,88,42,149,98,73,42,129,21,113,38,88,142,147,233,164,192,156,231,85,188,127,10,62,180,237,27,216,62,142,229,62,33,132,134,249,190,13,83,129,184,22,105,194,84,81,211,84,210,36,97,197,84,40,6,85,145,229,130,83,133,42,163,249,250,159,31,67,183,212,18,154,187,30,13,28,38,192,207,47,232,139,205,246,225,77,215,185,16,105,108,222,232,229,184,34,28,107,41,146,34,101,152,37,21,75,80,22,228,3,18,134,56,81,42,86,57,151,74,146,25,186,110,223,223,135,110,99,228,225,154,108,56,235,127,58,215,255,112,132,127,115,87,103,55,251,146,77,125,43,59,248,102,54,109,31,237,127,2,70,38,162,189,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,79,219,64,16,253,43,200,112,204,88,251,229,253,200,181,92,144,2,66,133,114,33,28,102,119,103,193,106,18,71,182,131,68,163,252,247,110,76,82,8,42,45,82,213,67,165,250,176,214,142,247,189,121,154,183,207,235,226,164,127,90,82,49,46,174,169,109,177,107,82,95,126,106,90,42,47,219,38,80,215,149,147,38,224,172,254,134,126,70,151,216,226,156,122,106,111,112,182,162,110,82,119,253,232,232,16,86,140,138,147,199,225,107,49,190,93,23,103,61,205,191,156,197,204,206,133,77,210,7,3,78,200,10,148,66,13,168,152,0,173,173,203,101,101,13,227,25,28,154,217,106,190,56,167,30,47,177,127,40,198,235,98,96,203,4,206,11,227,130,209,192,4,151,160,82,197,1,67,212,32,157,212,196,153,118,62,170,98,51,42,186,240,64,115,28,154,190,128,21,199,100,29,57,48,21,243,160,200,123,176,1,3,164,36,157,215,202,42,78,97,11,222,157,127,1,222,30,79,154,230,235,106,89,138,152,120,8,86,131,22,38,128,138,121,193,200,19,176,72,150,200,163,87,44,148,149,151,145,51,165,33,5,174,65,85,193,2,86,200,65,56,27,83,176,149,169,148,62,190,219,54,138,117,183,156,225,211,205,187,253,46,136,226,209,28,251,85,91,247,79,229,105,221,133,230,145,90,138,207,240,229,129,19,175,9,214,211,103,67,167,197,120,250,158,165,187,247,213,48,169,67,83,223,250,57,45,70,211,226,170,89,181,97,203,40,243,230,244,149,242,161,201,112,228,205,118,111,96,174,44,86,179,217,174,114,138,61,238,15,238,203,77,172,83,77,241,108,113,181,247,109,96,97,187,7,126,178,236,159,103,109,127,2,59,199,5,222,83,123,145,7,240,162,253,135,202,235,60,198,61,177,23,174,98,38,251,109,8,93,190,64,90,128,141,28,193,113,231,147,52,82,164,36,6,244,103,74,217,166,69,160,67,97,31,185,62,59,124,55,76,123,155,156,157,174,237,168,54,197,102,51,122,157,39,233,133,16,206,84,32,21,113,80,154,36,88,73,22,98,165,185,13,26,73,27,247,203,60,249,192,130,136,154,65,133,50,66,142,0,3,68,69,16,52,35,52,70,147,96,250,111,230,73,72,197,67,228,144,51,147,227,28,114,123,199,56,7,157,140,118,146,146,38,165,74,174,66,10,90,41,32,73,89,163,51,4,54,255,5,128,162,146,121,240,222,50,39,63,152,167,9,97,60,234,250,108,119,121,177,106,183,177,90,220,255,207,210,191,153,165,15,92,157,223,101,233,110,243,29,220,23,104,72,249,6,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "cb7254e015204e0a81829b0d833246e0",
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

		#region Class: ReadLeadForHandoffFlowElement

		/// <exclude/>
		public class ReadLeadForHandoffFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadForHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,18,169,151,111,69,234,22,1,138,38,64,140,92,170,28,86,228,202,38,42,89,2,73,167,117,13,255,123,151,146,173,58,133,139,184,189,52,58,137,131,225,236,204,114,119,23,200,6,172,253,12,45,6,179,96,129,198,128,237,106,119,253,65,55,14,205,71,211,109,250,224,42,176,104,52,52,250,7,170,17,159,43,237,222,131,3,186,178,43,127,41,148,193,172,60,175,81,6,87,101,160,29,182,150,56,254,138,192,52,6,145,177,42,140,19,38,144,43,86,73,64,198,139,68,242,88,212,42,169,243,3,243,15,226,55,93,219,131,193,177,198,32,95,15,191,139,109,239,169,17,1,114,160,104,219,173,15,32,247,38,236,124,13,85,131,138,206,206,108,144,32,103,116,75,105,112,161,91,188,7,67,181,188,78,231,33,34,213,208,88,207,106,176,118,243,239,189,65,107,117,183,126,205,92,179,105,215,167,108,18,192,233,120,176,19,14,30,61,243,30,220,106,144,184,37,91,251,193,229,187,229,210,224,18,156,126,62,53,241,21,183,3,239,178,254,209,5,69,175,244,8,205,6,79,106,190,76,114,3,189,27,3,141,229,137,96,244,114,117,113,214,169,99,175,197,141,9,236,143,228,11,53,207,102,136,83,2,159,61,48,170,28,127,203,224,203,173,189,251,182,70,243,32,87,216,194,216,181,167,107,66,127,3,38,253,217,46,17,16,66,161,10,150,72,165,152,72,36,176,60,78,11,150,97,196,163,28,179,48,171,226,253,211,232,67,219,190,129,237,227,84,238,19,194,216,48,223,55,58,167,80,228,80,241,138,33,70,17,19,74,166,44,23,162,102,92,113,148,192,179,58,229,146,222,215,127,254,25,186,165,150,208,220,245,104,224,240,2,225,249,1,125,49,217,62,188,233,58,55,70,154,154,55,121,57,142,72,132,177,136,1,11,38,100,150,49,1,121,197,138,58,169,200,86,138,113,200,19,158,228,21,153,161,237,246,253,125,232,54,70,30,182,201,142,107,253,79,235,250,31,150,240,111,246,234,236,100,95,50,169,111,101,6,223,204,164,237,131,253,79,179,156,160,52,60,6,0,0 })));
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

		#region Class: ReadActivityDataFlowElement

		/// <exclude/>
		public class ReadActivityDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadActivityDataFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,110,219,48,16,252,21,67,231,208,176,222,148,111,110,226,22,185,36,1,98,228,82,231,176,162,150,54,17,189,64,210,105,93,67,255,222,165,100,187,78,225,34,110,47,109,117,145,56,152,29,206,190,180,243,68,9,198,220,65,133,222,212,91,160,214,96,26,105,199,31,85,105,81,127,210,205,166,245,174,60,131,90,65,169,190,97,49,224,243,66,217,27,176,64,33,187,229,15,133,165,55,93,158,215,88,122,87,75,79,89,172,12,113,40,4,57,134,50,206,5,195,4,35,22,97,42,24,228,50,101,34,76,252,40,79,138,56,203,210,129,249,43,241,235,166,106,65,227,112,71,47,47,251,207,197,182,117,84,159,0,209,83,148,105,234,61,24,58,19,102,94,67,94,98,65,103,171,55,72,144,213,170,162,108,112,161,42,124,0,77,119,57,157,198,65,68,146,80,26,199,42,81,218,249,215,86,163,49,170,169,223,51,87,110,170,250,148,77,2,120,60,238,237,76,122,143,142,249,0,118,221,75,220,146,173,174,119,57,91,173,52,174,192,170,215,83,19,47,184,237,121,151,213,143,2,10,234,210,19,148,27,60,185,243,109,38,215,208,218,33,161,225,122,34,104,181,90,95,156,235,177,98,239,165,27,16,216,30,200,23,106,158,205,33,72,8,124,117,192,160,114,248,92,122,159,111,205,253,151,26,245,163,88,99,5,67,213,158,199,132,254,4,204,75,172,176,182,211,29,231,60,15,179,40,97,97,158,73,22,201,2,25,47,16,89,152,197,0,220,15,125,95,136,142,2,142,134,166,187,40,72,51,63,246,35,38,100,146,81,233,163,156,193,36,3,150,39,65,10,162,16,50,67,222,61,15,198,149,105,75,216,62,29,253,45,192,188,76,71,55,40,85,141,163,15,179,187,197,216,33,163,125,217,221,139,72,32,82,72,51,30,48,95,166,72,158,120,200,184,160,35,4,41,10,25,114,30,166,130,166,196,61,174,153,205,74,9,40,239,91,212,176,239,227,228,252,152,191,217,15,87,66,221,52,118,40,204,177,5,51,65,3,167,236,182,247,115,24,182,52,12,16,18,223,103,241,196,101,204,253,130,1,143,3,38,179,56,15,32,11,121,92,80,116,71,255,9,215,169,199,102,163,197,126,47,205,240,131,248,163,197,255,11,235,252,59,27,122,118,71,46,153,249,255,118,154,255,169,241,236,188,238,59,157,108,106,160,187,6,0,0 })));
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

			public AddDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
				_recordDefValues_Message = () => new LocalizableString(String.Concat((process.FeedMessage), Environment.NewLine, (process.PreconfiguredPageHandoff.Comment)));
				_recordDefValues_CreatedBy = () => (Guid)((process.PreconfiguredPageHandoff.OwnerId));
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,75,111,219,70,16,254,43,2,147,131,3,104,133,125,63,116,109,210,194,128,237,6,113,154,139,229,195,236,238,108,44,64,38,13,146,138,145,26,250,239,25,210,82,98,187,173,18,56,65,114,168,9,130,4,151,59,143,157,153,239,155,185,169,158,247,31,175,176,154,87,111,177,109,161,107,74,63,251,173,105,113,246,186,109,18,118,221,236,168,73,176,90,254,13,113,133,175,161,133,75,236,177,125,7,171,53,118,71,203,174,159,78,238,139,85,211,234,249,135,241,111,53,63,187,169,14,123,188,252,235,48,147,246,136,25,163,11,200,36,104,195,180,204,200,64,91,96,33,8,21,147,143,209,38,79,194,169,89,173,47,235,99,236,225,53,244,23,213,252,166,26,181,13,10,184,179,224,130,36,217,144,153,118,57,50,31,68,102,214,74,161,180,0,30,51,86,155,105,213,165,11,188,132,209,232,93,97,116,62,73,197,28,15,100,61,155,192,162,199,200,146,224,82,147,253,108,93,28,132,183,251,191,8,158,61,59,59,236,254,188,174,177,61,29,245,206,11,172,58,60,159,209,234,131,133,207,193,153,223,24,13,28,66,14,204,164,76,174,154,4,204,75,27,152,67,161,132,71,199,93,148,155,243,103,231,131,197,188,236,174,86,240,241,221,63,13,31,33,228,219,61,87,247,226,126,119,215,205,226,54,125,139,106,190,248,175,4,110,223,183,238,222,79,225,195,236,45,170,233,162,58,109,214,109,26,52,42,250,120,121,199,189,209,200,184,229,193,231,46,93,180,82,175,87,171,237,202,75,232,97,183,113,183,220,228,101,89,98,62,172,79,119,89,26,181,240,237,197,254,229,177,187,110,125,251,30,177,99,168,225,61,182,39,20,128,47,190,127,246,242,45,133,113,167,88,42,46,188,177,142,129,80,137,105,37,57,243,214,59,86,178,45,1,149,13,33,230,81,250,13,22,108,177,78,248,72,199,222,96,55,70,123,192,201,214,175,33,84,155,106,179,153,222,69,15,183,182,64,176,200,132,2,170,95,30,4,11,89,68,6,62,106,107,114,148,116,239,69,15,56,8,130,3,21,34,207,156,105,20,132,60,147,18,115,84,166,69,102,25,68,9,63,30,61,53,94,79,254,88,47,243,193,162,34,132,22,31,144,64,96,120,36,7,34,193,55,65,98,165,168,16,173,246,90,96,90,84,47,246,65,226,113,218,158,192,243,127,7,143,44,62,163,242,200,80,120,106,31,32,29,11,26,44,83,142,138,8,21,231,46,165,189,224,41,81,187,228,69,161,19,73,170,127,239,35,139,178,68,198,141,22,38,250,12,94,167,31,15,158,211,190,93,214,239,169,180,234,4,253,193,163,26,17,134,80,16,80,50,101,37,193,68,104,197,162,35,18,80,34,123,229,100,144,136,118,104,68,211,201,171,250,195,178,109,234,75,172,251,217,9,94,31,45,107,170,239,111,183,249,106,133,131,40,89,204,146,7,69,244,228,37,10,106,125,212,255,64,123,58,50,10,78,121,167,186,8,124,115,223,73,41,99,209,177,0,43,134,114,164,173,85,12,36,247,228,164,224,136,201,36,195,113,112,114,47,55,60,12,214,239,136,249,152,128,75,53,187,231,120,35,186,49,79,250,102,114,1,117,110,74,153,28,108,17,79,218,38,45,118,235,85,255,98,118,210,244,216,109,29,120,162,147,159,76,39,137,23,174,45,97,150,30,212,185,98,34,58,209,104,8,194,34,228,228,141,176,81,252,84,58,73,46,36,149,149,102,210,83,7,214,42,36,22,36,39,124,23,48,1,188,76,186,192,94,58,193,88,108,140,65,49,15,196,66,52,43,82,51,231,60,179,100,17,44,113,82,65,41,126,229,36,251,61,96,70,103,188,73,3,217,16,215,83,202,144,130,99,76,100,46,59,229,137,109,35,209,206,215,71,223,111,196,229,120,154,167,17,249,151,192,50,202,96,184,163,158,232,16,2,77,96,86,50,159,135,169,82,132,88,148,83,178,20,185,15,150,4,91,154,5,12,213,22,149,59,181,38,170,99,159,105,52,5,207,85,214,214,171,156,213,215,96,121,190,249,4,164,124,36,49,190,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "cb7254e015204e0a81829b0d833246e0",
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
				_recordColumnValues_Budget = () => (Decimal)((process.PreconfiguredPageHandoff.Budget));
				_recordColumnValues_SalesOwner = () => (Guid)((process.PreconfiguredPageHandoff.OpportunityResponsible));
				_recordColumnValues_MeetingDate = () => (DateTime)((process.PreconfiguredPageHandoff.MeetingTime));
				_recordColumnValues_LeadType = () => (Guid)((process.PreconfiguredPageHandoff.LeadType));
				_recordColumnValues_DecisionDate = () => (DateTime)((process.PreconfiguredPageHandoff.DecisionDate));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.PreconfiguredPageHandoff.OpportunityDepartment));
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,146,37,81,242,173,72,221,34,64,209,4,136,145,75,149,195,138,92,202,68,245,2,73,165,117,13,255,123,73,209,86,157,194,69,220,94,26,157,196,193,112,118,102,185,187,11,88,3,90,127,134,22,131,101,176,70,165,64,247,194,92,127,144,141,65,245,81,245,227,16,92,5,26,149,132,70,254,64,238,241,21,151,230,61,24,176,87,118,229,47,133,50,88,150,231,53,202,224,170,12,164,193,86,91,142,189,34,162,42,74,242,132,17,33,24,35,9,229,17,41,242,2,9,82,96,25,20,57,167,2,61,243,79,226,55,125,59,128,66,95,99,146,23,211,239,122,59,56,106,100,1,54,81,164,238,187,3,184,112,38,244,170,131,170,65,110,207,70,141,104,33,163,100,107,211,224,90,182,120,15,202,214,114,58,189,131,44,73,64,163,29,171,65,97,86,223,7,133,90,203,190,123,205,92,51,182,221,41,219,10,224,124,60,216,9,39,143,142,121,15,102,51,73,220,90,91,251,201,229,187,186,86,88,131,145,207,167,38,190,226,118,226,93,214,63,123,129,219,87,122,132,102,196,147,154,47,147,220,192,96,124,32,95,222,18,148,172,55,23,103,157,59,246,90,220,216,130,195,145,124,161,230,217,12,113,102,193,103,7,120,149,227,111,25,124,185,213,119,223,58,84,15,108,131,45,248,174,61,93,91,244,55,96,214,95,238,210,4,66,40,120,65,82,198,57,73,82,6,36,143,179,130,80,140,22,81,142,52,164,85,188,127,242,62,164,30,26,216,62,206,229,62,33,248,134,185,190,217,51,11,33,23,85,94,145,48,198,140,36,97,68,73,21,179,152,136,40,138,69,66,139,98,122,149,189,251,220,51,244,181,100,208,220,13,168,224,240,2,225,249,1,125,49,217,46,188,234,123,227,35,205,205,155,189,28,71,36,227,121,78,11,180,51,145,9,74,18,145,113,2,33,21,132,166,21,98,186,200,242,52,170,172,25,187,221,174,191,15,253,168,216,97,155,180,95,235,127,90,215,255,176,132,127,179,87,103,39,251,146,73,125,43,51,248,102,38,109,31,236,127,2,172,119,96,187,60,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,152,75,111,27,71,12,128,255,138,176,205,161,5,76,97,222,15,223,218,166,7,3,78,26,212,105,46,177,15,156,33,39,17,42,75,134,118,149,32,53,252,223,203,149,237,36,14,26,197,65,157,6,2,164,195,8,90,45,57,28,14,191,33,57,151,221,163,225,221,5,119,135,221,115,94,173,176,95,182,97,250,235,114,197,211,103,171,101,229,190,159,30,47,43,206,103,127,99,153,243,51,92,225,57,15,188,122,129,243,53,247,199,179,126,56,152,220,21,235,14,186,71,111,54,255,118,135,47,47,187,163,129,207,255,60,34,209,158,60,170,90,155,130,168,85,2,87,141,1,204,148,32,103,76,100,147,166,164,80,132,235,114,190,62,95,60,225,1,159,225,240,186,59,188,236,54,218,68,65,169,170,26,10,10,60,90,2,151,156,2,68,199,80,131,98,140,49,176,81,161,187,58,232,250,250,154,207,113,51,233,7,97,167,177,165,204,25,162,87,5,28,151,2,169,98,133,214,108,46,65,148,105,174,163,240,205,251,31,4,95,254,112,188,92,254,181,190,152,26,99,157,174,164,193,23,107,197,126,153,62,43,173,33,180,24,178,229,22,216,185,105,196,172,178,146,25,188,45,30,156,207,178,62,83,44,40,100,206,42,152,80,125,248,225,108,156,136,102,253,197,28,223,189,248,236,124,199,140,52,233,7,124,197,211,159,223,226,108,152,45,94,77,122,156,243,181,248,197,157,157,248,88,193,229,233,245,134,158,118,135,167,159,219,210,155,239,147,141,167,238,110,234,167,251,121,218,29,156,118,39,203,245,170,142,26,173,252,120,252,145,229,155,73,54,175,124,242,243,118,3,229,201,98,61,159,223,60,121,140,3,222,190,120,251,120,73,179,54,99,58,90,156,220,238,219,70,139,186,249,192,191,12,183,159,107,219,254,139,216,19,92,136,131,87,79,197,1,31,108,127,111,229,115,113,227,173,226,98,178,87,81,55,136,140,89,2,40,24,72,164,17,178,206,165,217,104,77,107,102,35,253,7,55,94,241,162,242,93,195,238,19,62,55,242,253,198,219,35,57,55,118,141,174,186,234,174,174,14,62,230,73,107,211,66,228,10,190,58,225,169,25,13,165,114,4,19,169,176,171,186,178,214,91,121,202,197,196,92,99,0,101,180,88,212,188,6,172,20,192,102,27,88,171,144,11,185,111,201,19,53,93,107,10,16,76,172,224,72,6,36,241,175,34,78,204,5,139,83,117,26,66,179,150,229,148,240,226,34,97,190,54,64,113,55,132,224,163,203,92,91,192,122,79,158,158,50,211,228,28,135,245,106,54,188,155,158,8,73,61,172,132,177,119,123,160,118,19,168,123,196,207,87,1,69,161,37,163,99,4,114,77,11,161,88,160,68,197,144,173,139,62,105,129,165,249,173,64,165,100,74,211,20,193,142,118,56,35,105,46,169,138,80,90,214,182,38,81,107,218,183,0,234,229,81,255,251,219,5,175,174,253,115,216,112,222,243,217,84,158,126,242,224,183,57,159,243,98,56,188,100,50,42,219,172,33,25,150,149,122,34,64,151,50,20,193,94,168,79,62,100,117,37,2,239,3,249,240,18,35,54,51,158,14,173,177,36,95,93,8,74,145,125,35,77,69,147,73,132,181,92,157,125,9,197,13,38,130,225,176,156,188,198,5,45,91,155,252,120,131,206,152,222,86,220,175,231,195,79,211,95,214,244,138,165,178,40,216,243,164,174,87,227,238,239,49,253,62,152,102,137,5,201,79,6,76,145,90,203,5,43,113,153,44,74,140,219,146,106,208,77,85,218,134,233,189,13,187,47,166,168,124,77,205,51,196,156,21,184,172,3,36,45,177,156,45,169,28,4,254,138,118,43,166,190,170,134,49,7,40,42,73,222,211,38,72,222,19,240,106,35,170,198,123,155,81,237,42,166,218,120,142,53,59,32,150,141,114,205,69,64,149,24,44,231,22,66,201,222,217,244,96,152,110,114,232,100,57,174,105,15,231,78,230,80,29,10,219,32,133,95,106,66,184,211,62,139,60,73,95,149,148,37,23,146,37,178,95,5,39,219,164,152,70,51,106,194,49,100,45,160,206,22,60,249,98,88,17,201,129,177,21,78,110,213,26,175,198,252,107,71,5,226,165,212,208,129,164,85,85,67,105,38,180,188,171,112,50,58,194,84,68,164,230,56,122,155,32,143,107,203,52,214,43,49,42,50,252,96,112,62,97,222,180,140,132,3,79,228,189,201,48,59,223,247,142,223,7,83,50,154,51,55,7,85,5,7,78,105,3,197,72,229,218,80,99,210,81,19,190,239,253,254,159,28,202,209,196,16,141,144,161,19,141,205,104,21,131,154,2,227,88,58,209,24,36,156,183,151,186,190,134,28,162,114,82,124,115,26,49,181,144,132,78,16,246,67,149,83,35,88,81,176,163,152,6,211,138,102,89,91,225,36,107,43,202,67,54,65,218,245,88,91,147,134,32,54,82,15,134,233,166,43,29,145,219,163,185,147,25,84,114,90,225,98,36,121,102,43,3,51,75,242,108,6,208,184,136,190,85,9,161,244,117,229,45,234,152,53,34,36,25,193,161,148,183,25,157,135,102,169,82,180,36,232,108,191,214,25,19,103,104,186,64,206,146,125,93,193,38,170,188,3,21,165,81,118,164,66,244,117,87,209,36,133,89,250,242,12,193,102,57,183,162,22,72,181,30,187,0,41,251,125,141,148,169,61,24,154,143,185,206,250,217,114,177,201,156,243,217,98,143,232,62,123,94,223,188,86,76,185,54,15,38,21,55,54,89,90,162,48,218,241,226,148,117,73,89,21,129,100,27,162,232,20,6,215,80,122,51,22,198,21,11,227,46,74,27,234,115,213,212,74,201,118,103,47,138,140,53,82,228,83,0,103,199,251,130,42,231,23,70,91,165,61,87,218,75,94,69,74,238,129,59,80,154,189,217,128,186,231,115,39,83,168,151,136,240,65,72,210,158,229,40,39,246,80,148,12,40,101,152,146,106,52,251,250,69,62,207,174,254,1,204,178,65,6,199,28,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "cb7254e015204e0a81829b0d833246e0",
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

			public ChangeDataUserTask2FlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,23,157,195,64,15,202,146,124,11,82,183,8,80,52,1,98,228,82,229,176,146,150,50,81,189,64,82,105,93,195,255,222,165,104,43,73,225,34,110,15,69,116,162,6,195,225,204,62,118,94,217,128,214,95,160,69,111,233,173,81,41,208,189,48,151,31,101,99,80,125,82,253,56,120,23,158,70,37,161,145,63,177,114,248,170,146,230,3,24,160,43,187,252,89,33,247,150,249,105,141,220,187,200,61,105,176,213,196,161,43,28,1,69,200,83,6,105,156,50,46,66,58,21,105,200,68,86,22,97,28,113,81,96,225,152,127,18,191,238,219,1,20,186,55,38,121,49,29,215,219,193,82,3,2,202,137,34,117,223,29,192,200,154,208,171,14,138,6,43,250,55,106,68,130,140,146,45,165,193,181,108,241,14,20,189,101,117,122,11,61,147,26,20,102,245,99,80,168,181,236,187,183,188,53,99,219,189,100,147,0,206,191,7,55,254,100,209,50,239,192,108,38,137,27,114,181,159,76,94,213,181,194,26,140,124,178,84,1,141,182,38,190,225,118,226,157,87,62,186,80,81,147,30,160,25,241,197,155,175,147,92,195,96,92,32,247,60,17,148,172,55,103,103,157,11,246,86,220,144,192,225,72,62,83,243,100,134,112,65,224,147,5,156,202,241,152,123,95,111,244,237,247,14,213,125,185,193,22,92,213,30,47,9,253,13,152,245,151,187,152,131,15,89,149,177,184,172,42,198,227,18,88,26,46,50,150,96,16,5,41,38,126,82,132,251,71,231,67,234,161,129,237,195,252,220,103,4,87,48,91,55,250,23,2,163,48,162,54,4,97,92,50,78,141,96,105,150,32,35,60,225,49,6,69,228,7,212,95,251,217,54,244,181,44,161,185,29,80,193,161,3,254,233,249,124,53,216,54,188,234,123,227,34,205,197,155,189,28,71,100,145,128,224,139,164,160,96,165,207,120,66,167,84,80,176,8,176,168,170,132,11,94,196,100,134,150,219,214,247,190,31,85,121,88,38,237,182,250,159,182,245,255,239,224,223,172,213,201,193,62,103,80,223,203,8,190,155,65,219,123,251,95,122,12,133,58,58,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,203,110,19,75,16,253,149,168,97,233,178,250,53,253,200,14,193,38,82,128,136,112,217,96,22,213,221,213,96,97,123,162,153,241,189,10,145,255,253,150,39,54,137,17,4,75,60,36,36,102,49,86,183,251,156,170,169,58,167,235,70,60,30,174,175,72,156,138,215,212,117,216,183,117,152,62,109,59,154,94,116,109,166,190,159,158,183,25,23,243,79,152,22,116,129,29,46,105,160,238,13,46,214,212,159,207,251,97,114,114,8,19,19,241,248,223,241,95,113,250,246,70,156,13,180,252,231,172,48,123,178,104,149,147,17,82,138,1,172,43,13,96,172,196,203,130,186,122,235,130,50,12,206,237,98,189,92,61,167,1,47,112,248,32,78,111,196,200,182,37,200,50,235,226,36,52,104,10,216,96,37,32,90,130,236,36,161,247,142,180,116,98,51,17,125,254,64,75,28,131,222,129,173,194,26,34,69,240,141,76,96,41,37,8,25,51,212,106,98,114,76,166,40,111,193,187,243,119,192,183,143,206,219,246,227,250,106,170,181,177,42,23,5,77,50,6,108,230,240,81,42,5,174,122,23,13,85,71,214,78,61,70,25,37,71,104,76,106,192,54,252,165,81,39,3,18,137,162,116,218,229,198,61,122,183,13,84,230,253,213,2,175,223,124,51,222,57,97,57,233,7,124,79,211,39,255,225,124,152,175,222,159,244,184,160,91,248,213,65,39,238,19,220,204,110,27,58,19,167,179,111,181,116,247,123,57,86,234,176,169,95,246,115,38,38,51,113,217,174,187,188,101,52,188,120,118,47,243,49,200,120,228,139,229,190,129,188,179,90,47,22,187,157,103,56,224,254,224,126,187,45,243,58,167,114,182,186,220,247,109,100,145,187,7,190,242,218,63,183,185,253,8,236,57,174,184,192,221,11,46,192,93,238,159,179,124,205,101,220,19,39,29,27,233,85,5,79,24,89,64,78,67,40,10,33,170,152,170,241,70,215,170,71,244,43,170,212,209,42,211,97,98,199,200,103,135,239,199,106,111,157,179,203,107,91,170,141,216,108,38,247,253,20,141,215,77,83,17,164,215,108,135,196,185,160,212,76,104,208,153,236,217,20,77,249,142,159,48,40,79,134,45,225,152,64,178,86,67,144,22,66,19,163,149,70,201,226,194,207,247,211,76,188,236,10,117,51,241,144,9,14,14,253,149,250,111,150,186,209,13,122,147,2,200,106,61,88,139,18,184,159,26,88,83,172,214,32,165,193,252,144,212,143,78,236,88,169,215,210,104,101,89,93,33,110,111,126,44,9,18,133,12,197,89,173,36,154,236,172,124,80,234,49,105,31,217,19,192,6,97,243,213,70,1,230,226,192,68,227,72,73,23,83,177,191,114,116,148,170,114,14,14,156,246,25,108,225,23,22,190,74,100,161,64,148,48,89,153,167,206,85,99,168,4,30,29,84,121,188,229,10,200,55,11,56,215,120,27,41,87,135,249,200,209,241,130,168,156,44,113,88,119,243,225,122,122,201,67,163,135,142,199,201,245,223,217,241,103,206,142,35,244,243,61,67,189,219,252,15,169,50,49,141,233,9,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "cb7254e015204e0a81829b0d833246e0",
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

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = true;
				SchemaElementUId = new Guid("e281f5d2-4042-49f3-aa3b-bd9d624f82b3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "LinkLeadToProcess", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: IntermediateCatchSignal1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal1";
				IsLogging = true;
				SchemaElementUId = new Guid("b01fb747-257a-4b84-99f8-31e2cc624524");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""bc0c2d60-5a3d-4840-aa4e-c60ea776e206""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Lead\"",\""key\"":\""ff91b700-bf5f-4cda-aef7-97d68bbfe418\""}"",""dataSourceFilters"":""{\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Lead\""}""}";
				_recordId = () => (Guid)((process.LeadId));
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

		#region Class: LinkLeadToProcessFlowElement

		/// <exclude/>
		public class LinkLeadToProcessFlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkLeadToProcessFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkLeadToProcess";
				IsLogging = true;
				SchemaElementUId = new Guid("ac44c289-2248-415c-9bcc-0d83ab8b4357");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _entityId;
			public override Guid EntityId {
				get {
					return (_entityId ?? (_entityId = () => Guid.Empty)).Invoke();
				}
				set {
					_entityId = () => { return value; };
				}
			}

			private Guid _entitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: PreconfiguredPageHandoffFlowElement

		/// <exclude/>
		public class PreconfiguredPageHandoffFlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public PreconfiguredPageHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "PreconfiguredPageHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("ed209391-82e1-45dd-a489-be109bd85690");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadHandoff;
				SerializeToDB = true;
				_meetingTime = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_budget = () => (Decimal)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Budget").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Decimal>("Budget") : 0m)));
				_leadType = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_opportunityResponsible = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_opportunityDepartment = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("OpportunityDepartment").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("OpportunityDepartmentId") : Guid.Empty)));
				_decisionDate = () => (DateTime)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("DecisionDate").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<DateTime>("DecisionDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))));
				_comment = () => new LocalizableString(((process.ReadActivityData.ResultEntity.IsColumnValueLoaded(process.ReadActivityData.ResultEntity.Schema.Columns.GetByName("DetailedResult").ColumnValueName) ? process.ReadActivityData.ResultEntity.GetTypedColumnValue<string>("DetailedResult") : null)));
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_showExecutionPage = () => (bool)(true);
			}

			#endregion

			#region Properties: Public

			private LocalizableString _buttons;
			public virtual LocalizableString Buttons {
				get {
					if (_buttons == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,95,107,194,48,20,71,191,202,8,62,182,210,218,52,127,124,156,99,67,144,33,232,124,25,123,184,77,111,164,80,27,73,162,48,165,223,125,169,3,237,152,219,132,61,150,223,57,55,229,28,201,192,191,111,145,140,201,18,173,5,103,180,31,78,140,197,225,220,26,133,206,13,103,70,65,93,29,160,168,113,14,22,54,232,209,174,160,222,161,155,85,206,71,119,95,53,18,145,193,254,180,146,241,235,145,76,61,110,94,166,101,184,174,19,158,33,99,16,103,12,85,76,121,201,99,169,194,39,230,50,31,149,133,78,114,200,130,220,177,71,114,186,112,171,212,70,228,57,252,86,223,187,223,121,111,154,184,64,150,82,81,136,84,166,57,133,132,203,20,1,81,232,148,101,121,41,114,217,169,75,88,247,205,5,236,241,1,60,116,211,4,182,190,50,77,55,87,110,166,14,171,79,198,219,29,134,117,142,86,27,187,153,212,198,133,48,235,47,239,47,3,66,46,204,249,232,21,228,9,27,180,224,113,81,173,27,168,251,4,105,219,168,95,80,81,65,83,78,147,88,107,17,98,36,76,199,130,141,88,156,42,46,52,23,44,17,133,254,86,240,38,233,231,130,25,8,80,140,113,33,101,73,1,152,72,70,105,8,137,69,240,21,149,234,74,193,75,144,127,37,124,132,218,253,213,240,204,252,26,241,173,253,0,208,134,146,209,228,2,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "cb7254e015204e0a81829b0d833246e0",
							"BaseElements.PreconfiguredPageHandoff.Parameters.Buttons.Value");
						dataList.LoadLocalizableValues();
						_buttons = dataList.GetSerializedItems();
						};
					return _buttons;
				}
				set {
					_buttons = value;
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

			internal Func<Decimal> _budget;
			public virtual Decimal Budget {
				get {
					return (_budget ?? (_budget = () => 0m)).Invoke();
				}
				set {
					_budget = () => { return value; };
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

			internal Func<Guid> _opportunityResponsible;
			public virtual Guid OpportunityResponsible {
				get {
					return (_opportunityResponsible ?? (_opportunityResponsible = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityResponsible = () => { return value; };
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

			internal Func<DateTime> _decisionDate;
			public virtual DateTime DecisionDate {
				get {
					return (_decisionDate ?? (_decisionDate = () => DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))).Invoke();
				}
				set {
					_decisionDate = () => { return value; };
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

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.PreconfiguredPageHandoff.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.PreconfiguredPageHandoff.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("067c50a0-c32f-4029-b05b-7eb828899354");
			public override Guid ClientUnitSchemaUId {
				get {
					return _clientUnitSchemaUId;
				}
				set {
					_clientUnitSchemaUId = value;
				}
			}

			private bool _useCardProcessModule = false;
			public override bool UseCardProcessModule {
				get {
					return _useCardProcessModule;
				}
				set {
					_useCardProcessModule = value;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.PreconfiguredPageHandoff.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
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

			public AutoGeneratedPageHandoffFlowElement(UserConnection userConnection, LeadManagementHandoff78 process)
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
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
				_showExecutionPage = () => (bool)(false);
				_leadType = () => (Guid)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("LeadType").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Guid>("LeadTypeId") : Guid.Empty)));
				_budget = () => (Decimal)(((process.ReadLeadForHandoff.ResultEntity.IsColumnValueLoaded(process.ReadLeadForHandoff.ResultEntity.Schema.Columns.GetByName("Budget").ColumnValueName) ? process.ReadLeadForHandoff.ResultEntity.GetTypedColumnValue<Decimal>("Budget") : 0m)));
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
					return _title ?? (_title = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private LocalizableString _buttons;
			public override LocalizableString Buttons {
				get {
					return _buttons ?? (_buttons = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Buttons.Value"));
				}
				set {
					_buttons = value;
				}
			}

			private LocalizableString _elements;
			public override LocalizableString Elements {
				get {
					return _elements ?? (_elements = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "BaseElements.AutoGeneratedPageHandoff.Parameters.Elements.Value"));
				}
				set {
					_elements = value;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
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

			internal Func<Decimal> _budget;
			public virtual Decimal Budget {
				get {
					return (_budget ?? (_budget = () => 0m)).Invoke();
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

		public LeadManagementHandoff78(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementHandoff78";
			SchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_usePreconfiguredPage = () => { return (bool)(true); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementHandoff78, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementHandoff78, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual bool OpenTaskPage {
			get;
			set;
		}

		private string _feedMessage;
		public virtual string FeedMessage {
			get {
				return _feedMessage ?? (_feedMessage = GetLocalizableString("cb7254e015204e0a81829b0d833246e0",
						 "Parameters.FeedMessage.Value"));
			}
			set {
				_feedMessage = value;
			}
		}

		private Func<bool> _usePreconfiguredPage;
		public virtual bool UsePreconfiguredPage {
			get {
				return (_usePreconfiguredPage ?? (_usePreconfiguredPage = () => false)).Invoke();
			}
			set {
				_usePreconfiguredPage = () => { return value; };
			}
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
					IsLogging = true,
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
					IsLogging = true,
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
					IsLogging = true,
				});
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

		private ParallelGateway1FlowElement _parallelGateway1;
		public ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private LinkLeadToProcessFlowElement _linkLeadToProcess;
		public LinkLeadToProcessFlowElement LinkLeadToProcess {
			get {
				return _linkLeadToProcess ?? (_linkLeadToProcess = new LinkLeadToProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private PreconfiguredPageHandoffFlowElement _preconfiguredPageHandoff;
		public PreconfiguredPageHandoffFlowElement PreconfiguredPageHandoff {
			get {
				return _preconfiguredPageHandoff ?? (_preconfiguredPageHandoff = new PreconfiguredPageHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AutoGeneratedPageHandoffFlowElement _autoGeneratedPageHandoff;
		public AutoGeneratedPageHandoffFlowElement AutoGeneratedPageHandoff {
			get {
				return _autoGeneratedPageHandoff ?? (_autoGeneratedPageHandoff = new AutoGeneratedPageHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("fc72f013-94f8-4bb7-bf05-844971922387"),
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

		private ProcessConditionalFlow _usePreconfiguredPageSequenceFlow;
		public ProcessConditionalFlow UsePreconfiguredPageSequenceFlow {
			get {
				return _usePreconfiguredPageSequenceFlow ?? (_usePreconfiguredPageSequenceFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "UsePreconfiguredPageSequenceFlow",
					SchemaElementUId = new Guid("240af2fa-289a-4821-8d0a-77442e4a7b10"),
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
			FlowElements[ExclusiveGatewayLeadDefined.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayLeadDefined };
			FlowElements[TerminateLeadUndefined.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateLeadUndefined };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ActivityUserTaskBANT.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTaskBANT };
			FlowElements[ChangeLeadStateToNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadStateToNoInterest };
			FlowElements[ChangeLeadNurturing.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadNurturing };
			FlowElements[TerminateOpportunity.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateOpportunity };
			FlowElements[ReadLeadForHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadForHandoff };
			FlowElements[ReadActivityData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadActivityData };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ChangeDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask2 };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[LinkLeadToProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkLeadToProcess };
			FlowElements[PreconfiguredPageHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { PreconfiguredPageHandoff };
			FlowElements[AutoGeneratedPageHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { AutoGeneratedPageHandoff };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayLeadDefined", e.Context.SenderName));
						break;
					case "ExclusiveGatewayLeadDefined":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateLeadUndefined", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkLeadToProcess", e.Context.SenderName));
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
						break;
					case "ChangeLeadNurturing":
						break;
					case "TerminateOpportunity":
						CompleteProcess();
						break;
					case "ReadLeadForHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ReadActivityData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadForHandoff", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						break;
					case "ChangeDataUserTask2":
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						}
						break;
					case "IntermediateCatchSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateOpportunity", e.Context.SenderName));
						break;
					case "LinkLeadToProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "PreconfiguredPageHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "AutoGeneratedPageHandoff":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (UsePreconfiguredPageSequenceFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PreconfiguredPageHandoff", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AutoGeneratedPageHandoff", e.Context.SenderName));
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

		private bool UsePreconfiguredPageSequenceFlowExpressionExecute() {
			bool result = Convert.ToBoolean((UsePreconfiguredPage));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "UsePreconfiguredPageSequenceFlow", "(UsePreconfiguredPage)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ActivityUserTaskBANT.ConfItem")) {
				writer.WriteValue("ActivityUserTaskBANT.ConfItem", ActivityUserTaskBANT.ConfItem, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.MeetingTime")) {
				writer.WriteValue("PreconfiguredPageHandoff.MeetingTime", PreconfiguredPageHandoff.MeetingTime, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("PreconfiguredPageHandoff.Budget")) {
				writer.WriteValue("PreconfiguredPageHandoff.Budget", PreconfiguredPageHandoff.Budget, 0m);
			}
			if (!HasMapping("PreconfiguredPageHandoff.LeadType")) {
				writer.WriteValue("PreconfiguredPageHandoff.LeadType", PreconfiguredPageHandoff.LeadType, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.OpportunityResponsible")) {
				writer.WriteValue("PreconfiguredPageHandoff.OpportunityResponsible", PreconfiguredPageHandoff.OpportunityResponsible, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.OpportunityDepartment")) {
				writer.WriteValue("PreconfiguredPageHandoff.OpportunityDepartment", PreconfiguredPageHandoff.OpportunityDepartment, Guid.Empty);
			}
			if (!HasMapping("PreconfiguredPageHandoff.DecisionDate")) {
				writer.WriteValue("PreconfiguredPageHandoff.DecisionDate", PreconfiguredPageHandoff.DecisionDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("PreconfiguredPageHandoff.Comment")) {
				writer.WriteValue("PreconfiguredPageHandoff.Comment", PreconfiguredPageHandoff.Comment, null);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.LeadType")) {
				writer.WriteValue("AutoGeneratedPageHandoff.LeadType", AutoGeneratedPageHandoff.LeadType, Guid.Empty);
			}
			if (!HasMapping("AutoGeneratedPageHandoff.Budget")) {
				writer.WriteValue("AutoGeneratedPageHandoff.Budget", AutoGeneratedPageHandoff.Budget, 0m);
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
			if (!HasMapping("OpenTaskPage")) {
				writer.WriteValue("OpenTaskPage", OpenTaskPage, false);
			}
			if (!HasMapping("FeedMessage")) {
				writer.WriteValue("FeedMessage", FeedMessage, null);
			}
			if (!HasMapping("UsePreconfiguredPage")) {
				writer.WriteValue("UsePreconfiguredPage", UsePreconfiguredPage, false);
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
			MetaPathParameterValues.Add("33fe706c-8bb5-40f7-890a-9d67b92dbea5", () => OpenTaskPage);
			MetaPathParameterValues.Add("e99feae2-362b-4143-b7aa-31d837292ee6", () => FeedMessage);
			MetaPathParameterValues.Add("3a87c19b-078d-4508-a1ee-049df3ff5ec3", () => UsePreconfiguredPage);
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
			MetaPathParameterValues.Add("f48e62d0-d4f7-4f42-92ff-f5017c0cdc13", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("231945a3-a6a9-4bc6-819d-1c7d1762bbf6", () => ReadLeadData.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("99e9cc26-01cd-4e03-9c89-1d86e4dbc2c2", () => ActivityUserTaskBANT.Application);
			MetaPathParameterValues.Add("f125cd4c-65d2-4885-9b77-e4bcc5b9f876", () => ActivityUserTaskBANT.FinApplication);
			MetaPathParameterValues.Add("daaab24c-2ab3-4250-b22d-67689b92d5bf", () => ActivityUserTaskBANT.ConfItem);
			MetaPathParameterValues.Add("2c070493-7483-4c5e-a83b-3eb1c5d78ab7", () => ChangeLeadStateToNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("c600955c-8b94-4c98-aee1-79c3c61d4140", () => ChangeLeadStateToNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("24bf952c-9579-4dcf-981f-f2cce1dbc830", () => ChangeLeadStateToNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("0c8a0e7e-306d-4ecc-b6cd-fbb09ef8707a", () => ChangeLeadStateToNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("091ab17a-49f8-4d9e-be81-1ca9c9dcb055", () => ChangeLeadNurturing.EntitySchemaUId);
			MetaPathParameterValues.Add("cbaa2dfb-5f4a-4bfc-9df0-93ddbbb25a13", () => ChangeLeadNurturing.IsMatchConditions);
			MetaPathParameterValues.Add("6f0df01f-2acd-4bc7-adec-34cfc25c9246", () => ChangeLeadNurturing.DataSourceFilters);
			MetaPathParameterValues.Add("38717ef0-c344-40ce-a5f4-e39c87df0d1d", () => ChangeLeadNurturing.RecordColumnValues);
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
			MetaPathParameterValues.Add("260b8bbe-7c18-4113-a716-497ebb6bb353", () => ReadLeadForHandoff.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1b5dc904-f14a-44b2-b858-11ecf54914b7", () => ReadLeadForHandoff.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("4f2ea1db-be28-4357-9aa5-ae1cdd70083b", () => ReadActivityData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("124f6347-3524-4f19-b6a5-0d076865f111", () => ReadActivityData.ConsiderTimeInFilter);
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
			MetaPathParameterValues.Add("0666ed69-b39c-40e3-8809-2b5e4de75265", () => IntermediateCatchSignal1.RecordId);
			MetaPathParameterValues.Add("7c89538d-7e55-4c93-9f0f-a2c2f80b1e80", () => LinkLeadToProcess.EntityId);
			MetaPathParameterValues.Add("ba921970-53ef-41a3-b7a6-07acd54a2917", () => LinkLeadToProcess.EntitySchemaId);
			MetaPathParameterValues.Add("fd439ed6-0ae1-4e89-bae6-1c0a8a3ca336", () => PreconfiguredPageHandoff.Buttons);
			MetaPathParameterValues.Add("ea4da8b1-8c97-415d-9fa4-9deeba770d2e", () => PreconfiguredPageHandoff.MeetingTime);
			MetaPathParameterValues.Add("a7af2cd6-ffed-41bd-bba9-d1db1d28dacb", () => PreconfiguredPageHandoff.Budget);
			MetaPathParameterValues.Add("62fb1e04-be88-4b05-9260-97cff70e7fd0", () => PreconfiguredPageHandoff.LeadType);
			MetaPathParameterValues.Add("125e7c94-de3b-4f47-a08e-3e9f66b95438", () => PreconfiguredPageHandoff.OpportunityResponsible);
			MetaPathParameterValues.Add("232d61d6-434e-4c16-a73c-93015b1ead84", () => PreconfiguredPageHandoff.OpportunityDepartment);
			MetaPathParameterValues.Add("d0a9cab9-639d-4714-b110-49e8c5c7d9df", () => PreconfiguredPageHandoff.DecisionDate);
			MetaPathParameterValues.Add("22bf4bfa-f58e-4663-a208-3110eec5c50e", () => PreconfiguredPageHandoff.Comment);
			MetaPathParameterValues.Add("6e7977a6-2f27-4cb3-b264-9a642764dc2b", () => PreconfiguredPageHandoff.Title);
			MetaPathParameterValues.Add("1b8a75bc-4bec-42a7-8fa7-04edbe01e963", () => PreconfiguredPageHandoff.Recommendation);
			MetaPathParameterValues.Add("6aa10889-0cc7-4466-87e8-176439593643", () => PreconfiguredPageHandoff.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("8015a032-1f65-4d40-89af-7a79e32c707a", () => PreconfiguredPageHandoff.EntityId);
			MetaPathParameterValues.Add("21c8281e-f66e-4376-bcab-61b34f7bfa6e", () => PreconfiguredPageHandoff.EntryPointId);
			MetaPathParameterValues.Add("1944babc-7a76-4073-9b5e-a9f5ee8e12d1", () => PreconfiguredPageHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("27221e08-6c14-4e5c-ac15-1e683d22e43e", () => PreconfiguredPageHandoff.UseCardProcessModule);
			MetaPathParameterValues.Add("e7585c2b-4f9e-46ec-955b-7d738f8eb372", () => PreconfiguredPageHandoff.OwnerId);
			MetaPathParameterValues.Add("92191d80-a9a5-41bf-8d86-a3e1f1ed5221", () => PreconfiguredPageHandoff.ShowExecutionPage);
			MetaPathParameterValues.Add("bdd7fed1-0061-4a97-8b63-1981ccb2a7ae", () => PreconfiguredPageHandoff.InformationOnStep);
			MetaPathParameterValues.Add("30f55d3c-cc99-414a-bfa6-eecd40544ec0", () => PreconfiguredPageHandoff.IsRunning);
			MetaPathParameterValues.Add("bfd8d126-f643-4fc1-b105-58d57466e759", () => PreconfiguredPageHandoff.Template);
			MetaPathParameterValues.Add("0d9fd7f7-e06e-4c0b-9894-be5848266fae", () => PreconfiguredPageHandoff.Module);
			MetaPathParameterValues.Add("eb3bde6c-e6a3-4c15-9d6d-338beeae6b82", () => PreconfiguredPageHandoff.PressedButtonCode);
			MetaPathParameterValues.Add("36ce5854-701f-4703-9b07-bbf3a76b8847", () => PreconfiguredPageHandoff.Url);
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
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ActivityUserTaskBANT.ConfItem":
					ActivityUserTaskBANT.ConfItem = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.MeetingTime":
					PreconfiguredPageHandoff.MeetingTime = reader.GetValue<System.DateTime>();
				break;
				case "PreconfiguredPageHandoff.Budget":
					PreconfiguredPageHandoff.Budget = reader.GetValue<System.Decimal>();
				break;
				case "PreconfiguredPageHandoff.LeadType":
					PreconfiguredPageHandoff.LeadType = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.OpportunityResponsible":
					PreconfiguredPageHandoff.OpportunityResponsible = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.OpportunityDepartment":
					PreconfiguredPageHandoff.OpportunityDepartment = reader.GetValue<System.Guid>();
				break;
				case "PreconfiguredPageHandoff.DecisionDate":
					PreconfiguredPageHandoff.DecisionDate = reader.GetValue<System.DateTime>();
				break;
				case "PreconfiguredPageHandoff.Comment":
					PreconfiguredPageHandoff.Comment = reader.GetValue<System.String>();
				break;
				case "AutoGeneratedPageHandoff.LeadType":
					AutoGeneratedPageHandoff.LeadType = reader.GetValue<System.Guid>();
				break;
				case "AutoGeneratedPageHandoff.Budget":
					AutoGeneratedPageHandoff.Budget = reader.GetValue<System.Decimal>();
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
				case "OpenTaskPage":
					if (!hasValueToRead) break;
					OpenTaskPage = reader.GetValue<System.Boolean>();
				break;
				case "FeedMessage":
					if (!hasValueToRead) break;
					FeedMessage = reader.GetValue<System.String>();
				break;
				case "UsePreconfiguredPage":
					if (!hasValueToRead) break;
					UsePreconfiguredPage = reader.GetValue<System.Boolean>();
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
			var cloneItem = (LeadManagementHandoff78)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

