namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
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

	#region Class: LeadManagementProceedToOrderSchema

	/// <exclude/>
	public class LeadManagementProceedToOrderSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementProceedToOrderSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementProceedToOrderSchema(LeadManagementProceedToOrderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementProceedToOrder";
			UId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			Version = 0;
			PackageUId = new Guid("23109609-1650-4a4b-aecb-d0974c538074");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateNewOrderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2a65c94d-ad96-4e1a-8678-3223fff78f0d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"NewOrder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3dad7563-c615-43f4-ad63-595693663fd7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{233e216d-e42b-4488-bb80-ae2955e15772}].[Parameter:{39c2ee29-de07-42d7-9978-27bbe105b922}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateActivityOwnerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56720a3e-4608-4bb3-8953-ed86f7f2fb7b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ActivityOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("947f5e54-f169-418b-9dfc-7652c84973d9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"AccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNewOrderParameter());
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateActivityOwnerParameter());
			Parameters.Add(CreateAccountIdParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("39c2ee29-de07-42d7-9978-27bbe105b922"),
				ContainerUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
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

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51e58f82-c660-4f51-a482-2e47790531e4"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,111,156,48,16,253,43,136,115,28,129,13,107,216,91,148,110,171,72,85,19,53,81,46,165,135,1,15,196,42,95,178,189,73,211,213,254,247,142,97,179,77,170,173,178,237,165,45,23,204,227,205,243,155,25,143,55,97,213,130,181,31,160,195,112,25,222,160,49,96,135,218,157,190,213,173,67,243,206,12,235,49,60,9,45,26,13,173,254,134,106,198,87,74,187,55,224,128,66,54,197,15,133,34,92,22,135,53,138,240,164,8,181,195,206,18,135,66,146,69,46,165,44,19,150,44,132,100,137,146,49,131,84,229,140,231,16,213,89,41,177,202,235,153,249,43,241,243,161,27,193,224,188,199,36,95,79,203,155,199,209,83,99,2,170,137,162,237,208,239,64,225,77,216,85,15,101,139,138,190,157,89,35,65,206,232,142,178,193,27,221,225,21,24,218,203,235,12,30,34,82,13,173,245,172,22,107,183,250,58,26,180,86,15,253,107,230,218,117,215,63,103,147,0,238,63,119,118,162,201,163,103,94,129,187,155,36,46,200,214,118,114,121,214,52,6,27,112,250,254,185,137,47,248,56,241,142,171,31,5,40,234,210,45,180,107,124,182,231,203,76,206,97,116,115,66,243,246,68,48,186,185,59,58,215,125,197,94,75,151,19,56,62,145,143,212,60,152,3,95,16,120,239,129,89,229,105,89,132,159,46,236,229,67,143,230,186,186,195,14,230,170,125,62,37,244,39,96,213,98,135,189,91,110,184,16,200,227,133,98,152,240,146,37,73,150,177,178,204,34,6,200,243,52,197,56,149,146,111,41,96,111,104,185,17,121,197,145,126,51,133,17,149,158,43,201,242,92,102,140,203,178,196,56,74,203,156,83,200,108,92,219,177,133,199,219,189,191,247,8,42,208,125,80,20,69,120,246,0,218,233,190,9,44,180,232,129,192,58,104,48,128,94,5,142,18,13,134,122,250,21,104,59,241,47,141,162,122,208,226,244,35,86,131,81,187,94,249,23,41,163,172,19,36,179,140,71,17,103,137,200,129,229,66,150,172,82,34,205,69,133,21,207,57,29,45,255,248,19,48,52,186,130,246,114,68,3,187,230,71,135,103,227,197,80,249,186,155,97,112,115,53,247,125,243,89,77,94,158,78,103,156,72,206,69,86,179,18,171,138,37,113,178,96,192,75,193,196,130,103,34,170,211,56,225,64,102,232,98,241,173,189,30,214,166,218,13,178,157,111,148,63,186,41,254,194,252,255,206,72,31,28,170,99,134,228,191,61,254,255,204,209,220,134,219,239,224,191,239,2,232,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("72785b41-22fc-440b-9e25-09541a823da1"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba95284a-479c-4695-b20e-f63e9d809aef"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cfa6a66-c948-435e-a77c-ce3c093762b0"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38ad1df5-1e23-417a-b816-604ee5ebd463"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("43a2921d-cbf9-4ccf-9e18-3b7e690771cf"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b56a9823-aa72-425f-bd71-e269cc7c6b9e"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("b63e014f-03e2-411a-b56e-cd11fcd2dedf"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c5ddbc71-2bb8-4428-9200-8670e0c41529"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("39c0f849-1bbe-41f7-a8ec-60baac586e9d"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("362c2b06-2632-4385-811f-5d44097aba94"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f78dac62-b855-47c2-98b1-8d7452f88518"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("dbb1f233-5174-43e1-b1c7-d09d994ca216"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1156c6f8-f42f-40e6-aabd-037e9316c30f"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("f91976d0-6fa2-4bfa-aa99-75e535e05b15"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f0036525-a88d-4f8f-9e33-96275cc4add9"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21c581af-6689-4593-83b0-ade1bc6ace04"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c841b42-21d7-449c-9c25-e5d9006c569c"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a849651b-3c94-415e-8f28-495c77cb69c2"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("233422b6-ee14-4a8a-ba4e-5872f8b8c777"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,111,212,48,16,253,43,81,206,245,42,113,190,247,86,149,5,85,66,180,162,85,47,132,195,56,158,164,22,249,146,237,109,41,171,253,239,140,147,221,165,69,139,186,112,1,114,137,243,242,230,249,205,140,199,27,191,106,193,152,15,208,161,191,244,111,81,107,48,67,109,23,111,85,107,81,191,211,195,122,244,207,124,131,90,65,171,190,161,156,241,149,84,246,13,88,160,144,77,249,67,161,244,151,229,113,141,210,63,43,125,101,177,51,196,161,144,76,164,81,157,70,49,203,147,176,102,49,198,200,32,72,83,150,166,153,192,12,211,56,66,156,153,191,18,191,24,186,17,52,206,123,76,242,245,180,188,125,26,29,53,36,160,154,40,202,12,253,14,140,156,9,179,234,65,180,40,233,219,234,53,18,100,181,234,40,27,188,85,29,94,131,166,189,156,206,224,32,34,213,208,26,199,106,177,182,171,175,163,70,99,212,208,191,102,174,93,119,253,115,54,9,224,225,115,103,39,152,60,58,230,53,216,251,73,226,61,130,92,92,146,183,237,100,245,188,105,52,54,96,213,195,115,39,95,240,105,34,159,86,68,10,144,212,170,59,104,215,248,108,227,151,233,92,192,104,231,172,102,15,83,152,86,205,253,201,41,31,10,247,90,214,156,192,113,79,62,81,243,104,22,60,37,240,193,1,179,202,126,89,250,159,46,205,213,99,143,250,166,186,199,14,230,186,125,94,16,250,19,176,106,177,195,222,46,55,60,138,144,135,169,100,24,115,193,226,56,207,153,16,121,192,0,121,145,36,24,38,89,198,183,20,112,48,180,220,68,69,197,145,126,51,137,65,198,98,46,51,86,20,89,206,120,38,4,134,65,34,10,78,33,179,113,101,198,22,158,238,14,254,92,133,61,213,123,101,89,250,231,143,160,172,234,27,207,64,139,14,240,140,133,6,61,232,165,103,41,81,111,168,167,95,158,50,19,255,74,75,170,7,45,22,31,177,26,180,188,156,123,229,94,164,140,113,200,49,73,67,150,203,34,98,113,21,33,37,130,156,137,60,12,177,170,48,139,242,132,14,151,123,220,25,24,26,85,65,123,53,162,134,93,251,131,227,35,242,98,182,92,221,245,48,216,185,154,135,190,185,172,174,245,32,215,149,157,44,237,143,105,46,131,172,16,174,62,137,160,99,26,84,84,92,42,26,11,67,94,135,0,34,203,69,65,158,232,154,113,29,190,25,214,186,218,141,181,153,239,151,63,186,55,254,194,109,240,219,3,126,116,192,78,25,152,255,118,20,254,181,99,186,245,183,223,1,13,174,94,98,2,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e73147b-3fca-4520-ae87-958d8a954ecb"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4741dc21-15cb-41c2-8680-9e717f617814"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1830ecce-1fbf-4a1d-927b-835b4390eef4"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be29adc6-c305-4fb0-b446-ae26278a5cf6"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fd6ce9f-f292-41a0-a8ba-d343dfc9cb25"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f5c8e8e8-ec65-413b-b1ef-1e44cb614020"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,177,50,180,50,212,241,76,177,50,176,50,0,0,230,77,107,227,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("83189d35-e077-4319-b18e-c6f2b2393707"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17afe864-aaad-4c4e-ad01-768cbd0e842d"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("53363eca-d6fd-4903-a89f-afc707231e89"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("2d30b140-c803-410d-99de-46fefa3903f9"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e8a3eb91-0b0d-419f-8a07-a279783a4aed"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("9e8fe1c5-61e9-4c8c-93e5-05ed37a5a23b"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("de74e707-3683-47dc-acb1-0620c233b644"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("6afe29bc-36f3-4e7b-a2a6-ed65c01eaae2"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77c33b50-7f50-4a1e-846b-d24d080ce656"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abe22acf-b177-4dbf-a6d4-52b190f66261"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a36f8fca-865d-4aa4-8cc3-db83862aa504"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d1cd5032-a015-49e6-8905-762ec1677544"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("28914bf3-2c8b-4583-b644-625e18978559"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1ffede0-fe00-42d9-a867-6030c7ce74a0"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86435d98-74c1-4ada-b6e5-22961dde1a37"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("1f919ca3-5929-45db-98dd-c0fa939af046"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b610c3e-7085-4d3f-963b-b33fd03a0d68"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,153,93,79,91,71,16,134,255,138,229,228,146,177,246,251,131,187,10,82,9,41,31,40,164,185,9,92,204,238,204,38,86,141,141,142,143,83,81,196,127,239,28,131,67,160,173,3,170,168,68,139,47,12,62,156,153,179,59,126,159,125,103,151,139,241,203,254,252,140,199,187,227,15,220,117,184,92,180,126,178,183,232,120,114,216,45,42,47,151,147,215,139,138,179,233,239,88,102,124,136,29,158,114,207,221,71,156,173,120,249,122,186,236,119,70,183,195,198,59,227,151,95,215,127,29,239,126,186,24,31,244,124,250,203,1,73,118,163,181,207,28,20,228,148,25,156,39,13,152,53,3,113,75,6,91,38,175,81,130,235,98,182,58,157,191,225,30,15,177,255,50,222,189,24,175,179,73,130,26,149,82,84,173,36,64,73,208,162,3,116,150,33,38,206,62,7,229,170,201,227,203,157,241,178,126,225,83,92,63,244,38,56,41,147,157,79,6,84,40,94,130,17,1,147,111,96,173,177,236,189,13,37,234,33,248,250,254,155,192,79,47,62,29,44,223,253,54,231,238,104,157,119,183,225,108,201,39,19,185,122,231,194,171,25,159,242,188,223,189,192,226,67,82,62,66,86,186,128,11,38,65,118,177,0,71,205,217,170,160,145,233,82,2,190,85,115,247,162,4,203,74,187,6,202,178,1,167,53,130,36,97,168,164,117,171,100,136,169,13,33,175,230,253,180,63,223,91,215,104,247,194,202,156,50,178,131,214,180,5,151,154,135,220,60,73,113,49,58,239,19,163,247,151,39,47,78,134,137,209,116,121,54,195,243,143,127,158,223,123,70,26,17,246,56,154,201,111,147,159,167,221,178,31,77,229,123,27,45,218,168,227,229,106,214,79,231,159,71,242,197,204,184,246,211,197,124,242,83,173,139,213,188,191,74,124,118,75,19,223,167,190,56,190,146,214,241,120,247,248,239,196,117,253,243,170,148,183,229,117,87,89,199,227,157,227,241,209,98,213,213,33,163,149,15,251,223,205,105,253,144,245,45,119,62,110,164,36,87,230,171,217,236,250,202,190,204,119,115,227,230,242,130,166,109,202,116,48,63,218,40,104,157,69,93,191,224,47,222,54,175,171,177,253,147,176,55,56,199,207,220,189,149,2,220,140,253,219,40,63,72,25,55,137,139,201,94,69,221,32,50,102,112,28,12,36,18,193,100,157,75,179,209,154,214,204,58,250,61,55,238,120,94,249,246,192,140,167,88,53,22,208,196,74,180,162,52,20,167,132,12,195,138,69,57,134,2,95,199,47,215,213,30,24,190,30,215,80,170,203,241,229,229,206,247,100,59,213,162,198,170,0,117,22,241,38,29,161,232,132,162,247,80,148,85,166,132,144,183,146,157,56,229,228,43,202,60,132,103,87,37,85,174,5,193,184,16,172,205,202,232,240,63,35,27,201,101,69,62,129,242,14,193,81,18,178,165,26,64,148,164,38,92,108,78,246,49,200,222,91,204,123,172,207,100,63,77,178,117,40,108,131,215,144,218,90,107,62,75,60,9,151,73,89,114,33,89,34,251,32,178,177,133,236,171,53,96,124,21,48,13,121,73,40,96,6,139,78,217,106,170,162,180,149,236,98,91,13,198,201,50,83,48,136,142,179,140,72,165,10,85,137,188,181,77,193,180,248,24,100,191,94,44,126,93,157,77,156,54,74,43,175,64,59,65,206,69,148,241,103,111,160,90,82,198,201,122,23,83,156,232,102,145,172,9,192,173,137,119,162,116,24,56,176,154,125,228,40,221,137,13,201,253,136,180,235,231,189,235,136,187,209,178,199,126,181,156,232,201,104,191,195,246,12,211,211,132,233,62,218,121,16,76,181,69,68,37,24,16,7,89,211,165,119,133,204,228,192,146,230,18,72,171,70,109,43,76,77,73,235,236,76,4,237,185,138,113,139,169,200,5,15,150,43,57,171,73,73,27,252,136,48,85,45,45,124,20,131,206,202,58,112,42,4,16,187,99,8,210,190,187,202,169,97,74,147,210,216,138,139,19,20,18,155,116,137,34,160,145,183,100,156,245,98,119,209,85,124,16,76,103,120,62,120,239,6,170,195,25,206,231,76,207,76,61,73,166,238,35,161,135,49,229,116,33,89,168,193,91,105,56,93,109,14,82,114,4,54,149,28,180,42,77,155,176,149,169,16,74,43,34,126,176,74,9,229,84,197,60,67,182,64,2,155,0,201,134,172,122,76,131,18,102,125,137,50,126,150,161,187,164,170,216,78,147,214,50,83,19,130,148,56,108,158,164,16,43,106,239,161,52,89,132,28,226,80,240,104,100,227,171,197,209,29,203,35,253,131,152,34,158,77,191,114,119,254,12,213,127,1,170,251,104,232,65,80,113,41,197,149,86,33,149,193,168,178,52,124,178,67,147,37,189,122,239,40,216,152,194,246,147,26,139,222,137,51,149,97,213,23,193,90,163,1,125,208,192,210,130,54,103,93,42,244,152,80,81,53,62,22,167,37,3,75,65,131,172,12,153,171,1,155,201,181,90,179,81,136,19,175,168,197,40,205,113,44,82,122,71,165,2,42,67,242,81,182,87,37,123,106,164,238,9,213,254,6,167,1,14,145,246,170,155,114,247,12,211,147,132,233,62,218,121,152,67,81,78,69,139,146,177,161,232,76,108,6,114,137,94,182,80,150,152,197,13,107,136,219,143,61,189,111,142,100,48,232,220,112,230,16,196,7,138,147,62,84,204,178,133,48,180,129,246,17,97,202,20,84,148,170,201,98,48,156,44,182,146,64,246,145,13,154,146,50,13,167,59,137,227,164,26,74,67,135,39,70,62,220,196,169,8,240,214,66,20,220,107,145,197,35,228,114,79,152,14,175,251,189,53,75,111,23,115,168,184,252,178,233,2,159,161,122,146,80,221,71,67,15,130,42,212,144,90,150,62,15,85,29,28,74,87,40,94,71,32,20,227,10,68,85,108,111,43,84,210,218,133,148,10,131,236,186,172,244,141,226,85,152,43,203,86,74,50,160,99,196,230,31,3,170,163,243,229,71,236,166,195,255,82,38,123,171,78,106,213,75,197,249,71,108,72,216,112,106,247,245,78,232,232,38,246,153,137,127,153,9,50,154,243,208,112,85,21,134,173,140,54,80,76,10,208,80,99,210,81,147,44,215,219,152,184,247,192,182,48,113,114,249,7,178,152,132,144,189,27,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c960984-040e-414d-913e-c8e671a175c3"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				UId = new Guid("3a8fb70e-eb46-4374-ad70-c1d1df862c33"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed01677f-c36f-4d12-bdce-2d077bf60563"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a6c6ca26-ca85-48d8-aa3f-ea21bffa2172"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,79,220,48,16,253,43,81,206,24,57,206,247,222,16,221,86,72,85,65,5,113,33,61,76,226,73,176,154,47,217,94,40,93,237,127,239,56,89,150,165,218,138,109,47,109,115,137,243,242,230,249,205,120,198,107,191,106,193,152,79,208,161,191,240,111,80,107,48,67,109,79,223,171,214,162,254,160,135,213,232,159,248,6,181,130,86,125,71,57,227,75,169,236,59,176,64,33,235,226,69,161,240,23,197,97,141,194,63,41,124,101,177,51,196,161,144,80,200,42,19,33,103,60,76,57,139,56,175,88,22,150,37,203,33,145,60,72,74,193,81,204,204,95,137,159,15,221,8,26,231,61,38,249,122,90,222,60,141,142,26,16,80,77,20,101,134,126,11,134,206,132,89,246,80,182,40,233,219,234,21,18,100,181,234,40,27,188,81,29,94,129,166,189,156,206,224,32,34,213,208,26,199,106,177,182,203,111,163,70,99,212,208,191,101,174,93,117,253,62,155,4,112,247,185,181,195,39,143,142,121,5,246,126,146,184,32,91,155,201,229,89,211,104,108,192,170,135,125,19,95,241,105,226,29,87,63,10,144,116,74,183,208,174,112,111,207,215,153,156,195,104,231,132,230,237,137,160,85,115,127,116,174,187,138,189,149,174,32,112,124,38,31,169,121,48,7,145,16,248,224,128,89,229,121,89,248,119,23,230,242,177,71,125,93,221,99,7,115,213,190,156,18,250,19,176,108,177,195,222,46,214,34,12,81,4,137,100,24,137,146,69,81,150,177,178,204,56,3,20,121,28,99,16,167,169,216,80,192,206,208,98,29,230,149,64,250,205,36,242,148,69,66,166,44,207,211,140,137,180,44,49,224,113,153,11,10,153,141,43,51,182,240,116,187,243,247,17,65,122,170,247,138,162,240,207,30,65,89,213,55,158,129,22,29,224,25,11,13,122,208,75,207,82,162,222,80,79,191,60,101,38,254,165,150,84,15,90,156,126,198,106,208,114,123,86,238,69,202,129,20,177,68,76,24,240,52,100,145,172,41,145,60,202,89,156,37,81,152,132,1,114,89,82,107,185,199,117,192,208,168,10,218,203,17,53,108,15,159,31,158,141,87,67,229,234,174,135,193,206,213,220,157,155,203,106,242,242,210,157,65,128,18,169,39,49,141,89,148,66,202,74,78,165,173,115,81,199,181,132,168,12,42,50,67,23,139,59,218,235,97,165,171,237,32,155,249,70,249,163,155,226,47,204,255,239,140,244,193,161,58,102,72,254,219,246,255,103,90,115,227,111,126,0,26,22,211,201,232,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b2c3e896-818e-48fd-bd84-3c8320d25e1a"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,16,253,21,143,146,163,229,145,144,4,18,215,164,7,207,36,173,167,73,115,177,125,88,164,85,227,25,12,30,129,219,73,25,254,189,2,219,113,236,182,167,234,0,236,178,239,237,99,247,209,145,219,246,109,135,36,39,207,24,2,52,181,111,103,119,117,192,217,34,212,22,155,102,246,80,91,40,55,191,160,40,113,1,1,182,216,98,120,129,114,143,205,195,166,105,167,147,75,24,153,146,219,31,227,91,146,47,59,50,111,113,251,109,238,34,187,70,166,81,22,25,85,222,113,42,11,238,41,48,159,82,134,222,50,41,24,202,68,70,176,173,203,253,182,122,196,22,22,208,190,146,188,35,35,91,36,72,157,117,76,48,73,177,112,41,149,200,56,213,142,25,154,161,65,116,70,89,237,144,244,83,210,216,87,220,194,216,244,12,150,28,188,54,24,171,21,43,34,184,40,168,182,96,169,247,194,20,169,212,146,163,29,192,199,250,51,112,121,179,156,55,95,126,86,24,158,70,222,220,67,217,224,122,22,179,87,137,79,37,110,177,106,243,14,184,6,38,77,66,65,114,70,165,4,136,79,42,54,204,156,226,202,121,39,18,219,71,192,251,52,243,46,179,38,101,70,75,202,36,67,42,185,116,212,112,129,212,106,76,51,14,60,83,86,244,235,155,245,32,209,109,154,93,9,111,47,127,42,189,11,8,45,78,234,224,48,204,14,129,155,4,180,49,49,153,187,3,122,119,177,194,143,248,110,117,112,194,138,228,171,127,121,225,120,63,124,249,165,27,174,141,176,34,211,21,121,170,247,193,14,140,34,6,247,31,132,143,77,198,146,171,240,180,249,152,169,246,101,121,204,220,67,11,167,194,83,186,118,27,191,65,55,175,158,78,11,31,89,216,241,208,191,92,78,231,160,237,127,96,143,80,193,119,12,159,227,0,206,218,223,85,62,199,49,158,136,139,196,40,150,69,183,103,8,38,58,47,77,162,109,57,196,253,154,194,139,76,36,222,39,35,250,43,122,12,88,89,188,20,166,89,98,164,210,9,101,105,161,168,244,131,155,180,242,84,136,68,160,82,34,45,50,126,196,55,227,180,135,95,238,168,107,24,85,79,250,126,221,255,6,192,163,119,195,230,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("ae68593e-fa7c-4048-b895-2278f193bf56"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			objectSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(objectSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("660ef167-9f42-438e-8e32-a0abcc62314c"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			pageSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(pageSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"23d86ac4-1d23-4314-a5e3-5da5e61b495a",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7df2eca1-dc6c-4087-9840-bee0cc1e644b"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"EditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			editModeParameter.SourceValue = new ProcessSchemaParameterValue(editModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f101f976-de4b-4470-b288-dc04974ea7d9"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,171,86,82,41,169,44,72,85,178,82,10,73,45,42,74,44,206,79,43,209,115,206,47,74,213,11,40,202,79,78,45,46,214,243,201,79,78,204,201,172,74,76,202,73,13,72,44,74,204,77,45,73,45,10,75,204,41,77,45,246,201,44,46,209,81,64,213,166,164,163,164,82,6,150,85,178,138,142,173,5,0,199,127,71,237,94,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("6cff8c4f-e5db-4f8a-aa7a-f5ac4428b6ea"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a18a0492-a410-44aa-a45b-87d515dfd32c}].[Parameter:{7c960984-040e-414d-913e-c8e671a175c3}]#]",
				MetaPath = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a18a0492-a410-44aa-a45b-87d515dfd32c}].[Parameter:{7c960984-040e-414d-913e-c8e671a175c3}]#]",
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5ec6ce6-b474-4ec1-956c-dfb129b1a5ce"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutedMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			executedModeParameter.SourceValue = new ProcessSchemaParameterValue(executedModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executedModeParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b956b76e-964d-46ce-823f-beb59ae28699"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("00eecca3-2d14-485a-8a8d-eb397d8ffbe8"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bdac390a-ff58-46a2-907b-14a0c0565f2d"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"GenerateDecisionsFromColumn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			generateDecisionsFromColumnParameter.SourceValue = new ProcessSchemaParameterValue(generateDecisionsFromColumnParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f6bbd23d-5104-4c79-9ac8-67b6d9a5d3bd"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			decisionalColumnMetaPathParameter.SourceValue = new ProcessSchemaParameterValue(decisionalColumnMetaPathParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7ec73e2-62cc-4a89-a496-e288aec50bdd"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ResultParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			resultParameterParameter.SourceValue = new ProcessSchemaParameterValue(resultParameterParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultParameterParameter);
			var isReexecutionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("07ade664-1878-4494-93a7-397c9d9a6ba7"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsReexecution",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isReexecutionParameter.SourceValue = new ProcessSchemaParameterValue(isReexecutionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isReexecutionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a25f8f25-a5bc-45f5-a3af-e84d2a250555"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Fill in the needed fields and save the order",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("c5bf469a-ca79-4c27-93c4-428493383a2b"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("109924be-1b7d-46bd-8855-110f7046c49a"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{56720a3e-4608-4bb3-8953-ed86f7f2fb7b}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44c80af5-265f-4ca1-8c98-78e4479635ae"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2f936e7-236a-4f61-9aa8-1cadbac9d2fd"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2983e005-8470-45c9-be2e-d84d93a53203"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("61ea02d3-de9d-4459-b975-072fcd9eff4e"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c610af2b-9150-43b8-aa79-239e85143fb7"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41ec49be-7cd4-437d-910a-78a49a359978"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("16cb3b84-997b-460f-931d-69d58bf053af"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9060fb85-9faf-4a13-809f-40fd6d37daa4"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("3ca71ac5-ea92-4f42-a671-9da656bf2653"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3dad7563-c615-43f4-ad63-595693663fd7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("1e40cbb6-dc33-43c4-907a-c06736c03f8c"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("42b3fc94-7228-4d8e-a9a0-44a7c7f1a17f"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("68804ba6-68d6-4d9a-8543-e1311e13aa63"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("dba832e4-be08-4c39-a60b-c029abee42d9"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("24b1894d-cb19-4761-95a7-21945965fd96"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("79b75417-25b2-4638-9fc0-4ba8602c8164"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("493d3b26-b741-456e-a4a9-1660de4605f1"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("1b88a7ef-d511-4681-afe2-7e7af45479bb"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("b8c8487c-7ec9-4fd7-8382-45adcafaa80a"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("9bba3ff9-9d5d-49eb-9944-5a24a927c8ee"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("02d10657-558f-4de5-bc41-185610ee3c4e"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var pageTypeUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9ddc804c-6acd-4c8d-abf1-0a89835fc9f5"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageTypeUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageTypeUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0f985d04-5e4c-4f3f-8bb9-7b29315ceede"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(activitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activitySchemaUIdParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17fa3835-9993-4c3b-910d-6fb4b4eb8ab5"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("1ea2f7f3-5e09-433d-a01f-16a9ece5d11f"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2a65c94d-ad96-4e1a-8678-3223fff78f0d}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e83dfcb-d1d1-445a-9f96-e47984017cff"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("fae4b282-9884-4e09-9382-4e83f9cec633"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("985510b3-2488-477a-a863-3ebb94e621e1"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("38999ad9-2ac8-48c0-8d33-55e204924212"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var problemParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa4a8316-c6cc-40b6-8c02-edb5ba71cba1"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("26e8d57d-215d-4749-8846-746c59eb9b24"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
				UId = new Guid("cbc1205a-31ec-4838-8fc9-aef608dfbee4"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("f54e7ee6-df35-43bf-a417-1b4b63aa77d4"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
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
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaExclusiveGateway exclusivegatewayuseproduct = CreateExclusiveGatewayUseProductExclusiveGateway();
			FlowElements.Add(exclusivegatewayuseproduct);
			ProcessSchemaExclusiveGateway exclusivegatewaycontainsowner = CreateExclusiveGatewayContainsOwnerExclusiveGateway();
			FlowElements.Add(exclusivegatewaycontainsowner);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ce9777c8-0300-4372-ad96-9248f5e91a0c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("81b3a4f0-4c35-4ef8-9bd7-f217b5163dfd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("2939990e-abae-4748-8572-9190deffcb21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e51e6ffc-424c-4ce3-a4f5-8ee830d2b8ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("10679508-f2c3-44a1-b1e6-4833590364ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b2d1b2d-8ccf-4962-9073-d5cecdf6c2dd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(83, 231));
			schemaFlow.PolylinePointPositions.Add(new Point(84, 231));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("a7178c4c-176e-442c-bd14-a31bac9eaac7"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{233e216d-e42b-4488-bb80-ae2955e15772}].[Parameter:{39c2ee29-de07-42d7-9978-27bbe105b922}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("391c3d74-5ca7-44c2-accb-5eeba7b07f80"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1074, 317));
			schemaFlow.PolylinePointPositions.Add(new Point(1074, 188));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("4c6443fd-d84a-42e5-b51a-0c57c0acdc37"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36a74fd9-906b-4e48-b36f-eeba6b29c35b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("f496c1c2-9114-4581-a08e-d8cfb472041e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5e01239b-825b-4e46-9b8c-d2bd7e7a7502"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("2464e066-7e89-42fe-a792-c0681c0223a7"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{6c6198b1-4959-4529-90ea-d61784ab5100}].[Parameter:{17afe864-aaad-4c4e-ad01-768cbd0e842d}]#] > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(792, 317));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("fbe102fe-3947-4c2d-bbe1-07cf19332670"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow4",
				UId = new Guid("d1345e84-0430-446e-bd62-9a9b023143e4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow4",
				UId = new Guid("b57d3370-16d1-44e5-8e6f-851093a1cab2"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(644, 316));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("744348fe-7225-44dc-a649-19685cf5b691"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(705, 188));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cab6cd99-d30a-49a7-b146-48197ae12bf5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cab6cd99-d30a-49a7-b146-48197ae12bf5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("36a74fd9-906b-4e48-b36f-eeba6b29c35b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"Terminate1",
				Position = new Point(1220, 175),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(70, 63),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("bc0c2d60-5a3d-4840-aa4e-c60ea776e206");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ReadDataUserTask1",
				Position = new Point(183, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ReadDataUserTask2",
				Position = new Point(287, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"AddDataUserTask1",
				Position = new Point(393, 161),
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
				UId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(504, 161),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ExclusiveGateway1",
				Position = new Point(56, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("6b2d1b2d-8ccf-4962-9073-d5cecdf6c2dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"TerminateEvent1",
				Position = new Point(71, 287),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ScriptTask1",
				Position = new Point(980, 290),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,93,83,219,56,20,125,14,191,66,205,67,199,233,102,188,244,21,10,59,52,64,39,51,93,72,75,216,125,216,217,97,132,125,3,158,250,131,74,50,109,182,205,127,95,93,73,182,101,203,113,236,148,23,72,162,251,113,116,116,207,213,181,71,247,89,22,147,39,22,5,240,119,36,30,151,244,59,112,114,66,150,192,24,229,217,74,248,179,140,129,252,147,174,162,135,156,81,17,101,169,127,179,230,55,32,68,148,62,112,255,3,136,191,104,156,195,59,140,115,234,221,114,96,210,56,133,0,45,167,100,188,168,69,30,79,15,70,163,21,141,57,76,142,15,70,33,4,81,66,99,34,232,247,5,176,0,82,81,255,241,44,201,242,250,111,153,160,113,249,235,130,101,97,30,8,149,225,156,10,250,25,158,50,30,137,140,173,229,126,182,46,157,144,20,190,145,237,190,141,45,32,206,103,202,52,67,31,35,46,46,89,150,84,4,236,69,213,135,60,10,91,168,122,79,57,44,138,52,138,169,16,86,52,143,133,135,14,19,68,130,31,36,20,144,49,75,75,9,161,102,215,194,140,195,199,22,22,188,98,183,192,191,26,147,139,84,68,98,125,19,60,66,66,63,229,224,240,227,219,6,127,210,148,62,0,195,157,206,83,46,104,26,192,251,245,21,77,192,27,127,4,26,154,116,99,181,21,153,194,63,11,195,89,22,231,73,234,141,205,154,143,214,227,142,245,219,52,18,93,235,178,204,118,44,251,166,214,186,204,20,35,93,6,243,176,107,117,150,51,6,105,176,238,176,105,91,250,199,172,225,30,143,204,231,226,255,191,254,85,158,220,3,187,94,97,153,160,5,31,30,162,70,222,101,20,11,96,28,189,61,252,62,99,64,5,232,95,81,176,11,202,228,89,160,137,39,75,81,255,62,203,146,39,202,34,158,165,203,245,19,248,23,95,115,26,203,202,197,195,29,79,9,254,155,235,66,213,146,81,105,177,157,96,124,89,20,186,86,36,214,88,23,79,139,214,162,21,241,10,71,169,37,169,116,114,74,14,39,228,135,196,128,65,35,94,22,62,191,72,233,125,12,161,140,223,168,73,172,63,126,41,183,147,51,48,70,222,248,214,82,23,255,152,61,68,129,162,66,101,108,137,170,83,214,181,191,136,130,47,192,100,190,89,76,57,191,164,1,54,12,204,246,110,190,168,219,156,122,40,30,9,137,11,150,163,217,25,123,200,19,89,117,222,56,175,97,149,180,97,154,81,131,9,133,76,65,59,11,2,100,97,30,146,87,13,161,27,132,35,183,31,52,0,35,194,114,185,10,168,115,108,138,68,78,152,70,58,242,250,117,147,103,93,231,2,127,245,95,28,103,159,92,59,182,208,68,66,126,254,220,218,200,183,163,222,118,83,248,115,41,167,136,198,209,127,160,78,27,131,234,222,78,126,52,155,244,116,107,222,205,212,78,195,253,27,64,113,20,26,32,39,167,133,142,144,29,84,157,209,186,125,149,20,77,229,14,219,210,196,95,102,138,192,73,197,206,198,168,7,220,102,237,170,167,165,163,31,31,148,74,72,40,91,23,253,109,30,190,224,253,135,88,113,92,176,19,72,117,160,177,127,145,60,137,245,164,64,17,152,213,207,178,95,221,200,147,144,8,219,52,57,115,205,134,202,178,77,149,77,4,114,253,25,152,104,239,11,5,134,210,168,3,129,9,26,1,183,16,27,32,45,91,174,208,100,44,4,102,74,64,31,27,182,220,126,247,242,181,229,59,110,236,79,137,77,214,60,44,163,4,220,58,177,21,41,35,155,175,133,189,154,37,70,43,89,18,52,120,36,158,117,33,144,40,45,239,6,163,50,53,132,206,249,21,64,184,204,150,244,139,238,212,168,20,187,93,180,245,126,217,148,94,86,246,74,141,50,106,135,238,151,108,173,58,85,99,120,26,168,211,41,201,114,225,164,209,154,53,115,158,90,170,137,109,7,71,127,56,241,124,203,253,104,72,43,169,252,116,89,148,67,184,98,114,47,40,234,211,14,20,38,139,5,164,154,197,116,147,127,229,240,162,231,16,238,57,221,201,106,226,26,115,171,110,85,241,154,47,161,126,186,88,102,69,16,207,201,102,46,236,145,147,205,244,248,105,155,122,172,139,170,122,218,217,139,196,101,229,126,68,60,67,215,196,162,212,98,179,34,81,122,221,217,115,175,219,56,116,215,151,144,220,110,98,70,67,109,209,50,179,141,70,110,32,121,143,213,145,168,193,126,218,121,246,178,37,74,73,90,71,175,31,6,122,167,48,171,243,112,71,158,182,75,179,111,14,28,161,7,38,64,151,187,170,154,245,127,19,167,127,98,28,251,63,229,84,45,238,72,239,104,168,21,65,203,243,68,111,48,178,156,20,9,123,149,239,208,78,164,147,245,7,167,174,52,5,239,10,190,169,47,189,93,45,130,207,53,137,254,117,10,3,10,80,181,4,221,177,76,59,24,226,188,135,151,238,87,251,36,67,164,123,122,159,71,92,13,224,165,251,97,111,87,235,90,153,186,227,228,224,48,216,200,101,160,183,131,161,227,123,130,169,245,230,169,186,95,186,107,186,184,81,250,30,40,250,216,253,162,113,27,234,101,231,49,198,126,103,54,44,35,242,185,172,94,147,213,143,182,151,180,183,58,151,111,228,228,37,225,89,183,216,27,99,69,126,39,222,219,195,67,242,155,67,235,134,64,204,193,236,163,22,70,95,204,111,108,15,25,70,70,49,41,43,48,197,227,162,14,95,190,4,252,5,98,172,224,251,210,227,132,216,244,111,160,85,144,226,243,175,205,56,214,124,166,246,106,209,188,199,216,211,49,227,56,243,80,185,129,142,209,103,200,41,89,220,52,55,211,82,79,251,5,110,144,190,245,220,232,51,120,229,11,107,52,219,28,48,16,57,75,137,124,126,131,227,255,1,44,139,95,110,63,23,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"OpenEditPageUserTask1",
				Position = new Point(1100, 161),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"FormulaTask1",
				Position = new Point(851, 290),
				ResultParameterMetaPath = @"2a65c94d-ad96-4e1a-8678-3223fff78f0d",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,187,14,131,48,12,64,209,143,97,118,21,19,135,60,246,14,76,69,234,136,50,184,137,81,7,194,16,144,58,32,254,157,204,221,174,142,116,231,110,30,247,215,111,147,250,78,95,41,28,22,94,119,137,143,166,127,240,92,165,200,118,132,147,209,177,34,223,3,19,42,32,98,110,101,62,224,108,54,104,242,146,117,159,174,54,76,92,185,200,33,53,156,54,249,65,121,71,160,72,9,16,82,6,143,90,32,57,25,44,50,90,147,244,21,187,120,3,152,79,215,44,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayUseProductExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("951af993-3900-4618-9898-be413728166b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ExclusiveGatewayUseProduct",
				Position = new Point(765, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayContainsOwnerExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ExclusiveGatewayContainsOwner",
				Position = new Point(617, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"FormulaTask2",
				Position = new Point(671, 288),
				ResultParameterMetaPath = @"56720a3e-4608-4bb3-8953-ed86f7f2fb7b",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,204,187,10,194,48,20,128,225,135,113,62,146,147,123,179,74,7,39,5,199,210,33,151,19,20,154,8,109,68,164,244,221,173,171,235,15,223,63,28,134,243,114,121,87,154,111,241,78,197,187,236,167,133,198,227,94,255,66,63,81,161,218,220,234,131,210,150,41,3,29,195,0,82,115,11,157,52,1,200,32,117,130,105,244,148,182,29,92,253,236,11,53,154,221,26,180,32,134,50,3,19,196,65,34,122,216,39,4,49,33,230,152,120,162,148,127,164,175,237,209,62,167,231,244,42,213,173,138,91,52,66,90,144,145,33,72,134,10,188,209,26,98,64,22,77,80,74,70,187,141,135,241,11,154,157,117,132,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("32e89cc2-c170-4148-993c-07ae3aa76178"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b0ad8bea-22e0-4780-944c-36847851410d"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b1e601a2-10f6-4a89-94e0-aa4ecaa830e9"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementProceedToOrder(userConnection);
		}

		public override object Clone() {
			return new LeadManagementProceedToOrderSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementProceedToOrder

	/// <exclude/>
	public class LeadManagementProceedToOrder : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ab568057-901b-4628-947b-e71e93061aed");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,111,156,48,16,253,43,136,115,28,129,13,107,216,91,148,110,171,72,85,19,53,81,46,165,135,1,15,196,42,95,178,189,73,211,213,254,247,142,97,179,77,170,173,178,237,165,45,23,204,227,205,243,155,25,143,55,97,213,130,181,31,160,195,112,25,222,160,49,96,135,218,157,190,213,173,67,243,206,12,235,49,60,9,45,26,13,173,254,134,106,198,87,74,187,55,224,128,66,54,197,15,133,34,92,22,135,53,138,240,164,8,181,195,206,18,135,66,146,69,46,165,44,19,150,44,132,100,137,146,49,131,84,229,140,231,16,213,89,41,177,202,235,153,249,43,241,243,161,27,193,224,188,199,36,95,79,203,155,199,209,83,99,2,170,137,162,237,208,239,64,225,77,216,85,15,101,139,138,190,157,89,35,65,206,232,142,178,193,27,221,225,21,24,218,203,235,12,30,34,82,13,173,245,172,22,107,183,250,58,26,180,86,15,253,107,230,218,117,215,63,103,147,0,238,63,119,118,162,201,163,103,94,129,187,155,36,46,200,214,118,114,121,214,52,6,27,112,250,254,185,137,47,248,56,241,142,171,31,5,40,234,210,45,180,107,124,182,231,203,76,206,97,116,115,66,243,246,68,48,186,185,59,58,215,125,197,94,75,151,19,56,62,145,143,212,60,152,3,95,16,120,239,129,89,229,105,89,132,159,46,236,229,67,143,230,186,186,195,14,230,170,125,62,37,244,39,96,213,98,135,189,91,110,184,16,200,227,133,98,152,240,146,37,73,150,177,178,204,34,6,200,243,52,197,56,149,146,111,41,96,111,104,185,17,121,197,145,126,51,133,17,149,158,43,201,242,92,102,140,203,178,196,56,74,203,156,83,200,108,92,219,177,133,199,219,189,191,247,8,42,208,125,80,20,69,120,246,0,218,233,190,9,44,180,232,129,192,58,104,48,128,94,5,142,18,13,134,122,250,21,104,59,241,47,141,162,122,208,226,244,35,86,131,81,187,94,249,23,41,163,172,19,36,179,140,71,17,103,137,200,129,229,66,150,172,82,34,205,69,133,21,207,57,29,45,255,248,19,48,52,186,130,246,114,68,3,187,230,71,135,103,227,197,80,249,186,155,97,112,115,53,247,125,243,89,77,94,158,78,103,156,72,206,69,86,179,18,171,138,37,113,178,96,192,75,193,196,130,103,34,170,211,56,225,64,102,232,98,241,173,189,30,214,166,218,13,178,157,111,148,63,186,41,254,194,252,255,206,72,31,28,170,99,134,228,191,61,254,255,204,209,220,134,219,239,224,191,239,2,232,6,0,0 })));
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

			private bool _canReadUncommitedData = false;
			public override bool CanReadUncommitedData {
				get {
					return _canReadUncommitedData;
				}
				set {
					_canReadUncommitedData = value;
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

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,111,212,48,16,253,43,81,206,245,42,113,190,247,86,149,5,85,66,180,162,85,47,132,195,56,158,164,22,249,146,237,109,41,171,253,239,140,147,221,165,69,139,186,112,1,114,137,243,242,230,249,205,140,199,27,191,106,193,152,15,208,161,191,244,111,81,107,48,67,109,23,111,85,107,81,191,211,195,122,244,207,124,131,90,65,171,190,161,156,241,149,84,246,13,88,160,144,77,249,67,161,244,151,229,113,141,210,63,43,125,101,177,51,196,161,144,76,164,81,157,70,49,203,147,176,102,49,198,200,32,72,83,150,166,153,192,12,211,56,66,156,153,191,18,191,24,186,17,52,206,123,76,242,245,180,188,125,26,29,53,36,160,154,40,202,12,253,14,140,156,9,179,234,65,180,40,233,219,234,53,18,100,181,234,40,27,188,85,29,94,131,166,189,156,206,224,32,34,213,208,26,199,106,177,182,171,175,163,70,99,212,208,191,102,174,93,119,253,115,54,9,224,225,115,103,39,152,60,58,230,53,216,251,73,226,61,130,92,92,146,183,237,100,245,188,105,52,54,96,213,195,115,39,95,240,105,34,159,86,68,10,144,212,170,59,104,215,248,108,227,151,233,92,192,104,231,172,102,15,83,152,86,205,253,201,41,31,10,247,90,214,156,192,113,79,62,81,243,104,22,60,37,240,193,1,179,202,126,89,250,159,46,205,213,99,143,250,166,186,199,14,230,186,125,94,16,250,19,176,106,177,195,222,46,55,60,138,144,135,169,100,24,115,193,226,56,207,153,16,121,192,0,121,145,36,24,38,89,198,183,20,112,48,180,220,68,69,197,145,126,51,137,65,198,98,46,51,86,20,89,206,120,38,4,134,65,34,10,78,33,179,113,101,198,22,158,238,14,254,92,133,61,213,123,101,89,250,231,143,160,172,234,27,207,64,139,14,240,140,133,6,61,232,165,103,41,81,111,168,167,95,158,50,19,255,74,75,170,7,45,22,31,177,26,180,188,156,123,229,94,164,140,113,200,49,73,67,150,203,34,98,113,21,33,37,130,156,137,60,12,177,170,48,139,242,132,14,151,123,220,25,24,26,85,65,123,53,162,134,93,251,131,227,35,242,98,182,92,221,245,48,216,185,154,135,190,185,172,174,245,32,215,149,157,44,237,143,105,46,131,172,16,174,62,137,160,99,26,84,84,92,42,26,11,67,94,135,0,34,203,69,65,158,232,154,113,29,190,25,214,186,218,141,181,153,239,151,63,186,55,254,194,109,240,219,3,126,116,192,78,25,152,255,118,20,254,181,99,186,245,183,223,1,13,174,94,98,2,7,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,177,50,180,50,212,241,76,177,50,176,50,0,0,230,77,107,227,15,0,0,0 })));
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
								new Guid("1f66152e-4108-49d8-9953-69045f06df88")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("1f66152e-4108-49d8-9953-69045f06df88"));
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

			public AddDataUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_recordDefValues_Status = () => (Guid)(new Guid("1f3ad326-effd-4ac3-a3e2-957e7def3684"));
				_recordDefValues_PaymentStatus = () => (Guid)(new Guid("bfe38d3d-bd57-48d7-a2d7-82435cd274ca"));
				_recordDefValues_DeliveryStatus = () => (Guid)(new Guid("867ca155-bfa5-4aaa-9172-7813dd4e85f5"));
				_recordDefValues_DeliveryType = () => (Guid)(new Guid("50df77d0-7b1f-4dbc-a02d-7b6ebb95dfd0"));
				_recordDefValues_PaymentType = () => (Guid)(new Guid("c2d88243-685d-4e8b-a533-73f4cb8e869b"));
				_recordDefValues_Date = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDate")));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Status", () => _recordDefValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PaymentStatus", () => _recordDefValues_PaymentStatus.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DeliveryStatus", () => _recordDefValues_DeliveryStatus.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DeliveryType", () => _recordDefValues_DeliveryType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PaymentType", () => _recordDefValues_PaymentType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Date", () => _recordDefValues_Date.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Account;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Status;
			internal Func<Guid> _recordDefValues_PaymentStatus;
			internal Func<Guid> _recordDefValues_DeliveryStatus;
			internal Func<Guid> _recordDefValues_DeliveryType;
			internal Func<Guid> _recordDefValues_PaymentType;
			internal Func<DateTime> _recordDefValues_Date;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,153,93,79,91,71,16,134,255,138,229,228,146,177,246,251,131,187,10,82,9,41,31,40,164,185,9,92,204,238,204,38,86,141,141,142,143,83,81,196,127,239,28,131,67,160,173,3,170,168,68,139,47,12,62,156,153,179,59,126,159,125,103,151,139,241,203,254,252,140,199,187,227,15,220,117,184,92,180,126,178,183,232,120,114,216,45,42,47,151,147,215,139,138,179,233,239,88,102,124,136,29,158,114,207,221,71,156,173,120,249,122,186,236,119,70,183,195,198,59,227,151,95,215,127,29,239,126,186,24,31,244,124,250,203,1,73,118,163,181,207,28,20,228,148,25,156,39,13,152,53,3,113,75,6,91,38,175,81,130,235,98,182,58,157,191,225,30,15,177,255,50,222,189,24,175,179,73,130,26,149,82,84,173,36,64,73,208,162,3,116,150,33,38,206,62,7,229,170,201,227,203,157,241,178,126,225,83,92,63,244,38,56,41,147,157,79,6,84,40,94,130,17,1,147,111,96,173,177,236,189,13,37,234,33,248,250,254,155,192,79,47,62,29,44,223,253,54,231,238,104,157,119,183,225,108,201,39,19,185,122,231,194,171,25,159,242,188,223,189,192,226,67,82,62,66,86,186,128,11,38,65,118,177,0,71,205,217,170,160,145,233,82,2,190,85,115,247,162,4,203,74,187,6,202,178,1,167,53,130,36,97,168,164,117,171,100,136,169,13,33,175,230,253,180,63,223,91,215,104,247,194,202,156,50,178,131,214,180,5,151,154,135,220,60,73,113,49,58,239,19,163,247,151,39,47,78,134,137,209,116,121,54,195,243,143,127,158,223,123,70,26,17,246,56,154,201,111,147,159,167,221,178,31,77,229,123,27,45,218,168,227,229,106,214,79,231,159,71,242,197,204,184,246,211,197,124,242,83,173,139,213,188,191,74,124,118,75,19,223,167,190,56,190,146,214,241,120,247,248,239,196,117,253,243,170,148,183,229,117,87,89,199,227,157,227,241,209,98,213,213,33,163,149,15,251,223,205,105,253,144,245,45,119,62,110,164,36,87,230,171,217,236,250,202,190,204,119,115,227,230,242,130,166,109,202,116,48,63,218,40,104,157,69,93,191,224,47,222,54,175,171,177,253,147,176,55,56,199,207,220,189,149,2,220,140,253,219,40,63,72,25,55,137,139,201,94,69,221,32,50,102,112,28,12,36,18,193,100,157,75,179,209,154,214,204,58,250,61,55,238,120,94,249,246,192,140,167,88,53,22,208,196,74,180,162,52,20,167,132,12,195,138,69,57,134,2,95,199,47,215,213,30,24,190,30,215,80,170,203,241,229,229,206,247,100,59,213,162,198,170,0,117,22,241,38,29,161,232,132,162,247,80,148,85,166,132,144,183,146,157,56,229,228,43,202,60,132,103,87,37,85,174,5,193,184,16,172,205,202,232,240,63,35,27,201,101,69,62,129,242,14,193,81,18,178,165,26,64,148,164,38,92,108,78,246,49,200,222,91,204,123,172,207,100,63,77,178,117,40,108,131,215,144,218,90,107,62,75,60,9,151,73,89,114,33,89,34,251,32,178,177,133,236,171,53,96,124,21,48,13,121,73,40,96,6,139,78,217,106,170,162,180,149,236,98,91,13,198,201,50,83,48,136,142,179,140,72,165,10,85,137,188,181,77,193,180,248,24,100,191,94,44,126,93,157,77,156,54,74,43,175,64,59,65,206,69,148,241,103,111,160,90,82,198,201,122,23,83,156,232,102,145,172,9,192,173,137,119,162,116,24,56,176,154,125,228,40,221,137,13,201,253,136,180,235,231,189,235,136,187,209,178,199,126,181,156,232,201,104,191,195,246,12,211,211,132,233,62,218,121,16,76,181,69,68,37,24,16,7,89,211,165,119,133,204,228,192,146,230,18,72,171,70,109,43,76,77,73,235,236,76,4,237,185,138,113,139,169,200,5,15,150,43,57,171,73,73,27,252,136,48,85,45,45,124,20,131,206,202,58,112,42,4,16,187,99,8,210,190,187,202,169,97,74,147,210,216,138,139,19,20,18,155,116,137,34,160,145,183,100,156,245,98,119,209,85,124,16,76,103,120,62,120,239,6,170,195,25,206,231,76,207,76,61,73,166,238,35,161,135,49,229,116,33,89,168,193,91,105,56,93,109,14,82,114,4,54,149,28,180,42,77,155,176,149,169,16,74,43,34,126,176,74,9,229,84,197,60,67,182,64,2,155,0,201,134,172,122,76,131,18,102,125,137,50,126,150,161,187,164,170,216,78,147,214,50,83,19,130,148,56,108,158,164,16,43,106,239,161,52,89,132,28,226,80,240,104,100,227,171,197,209,29,203,35,253,131,152,34,158,77,191,114,119,254,12,213,127,1,170,251,104,232,65,80,113,41,197,149,86,33,149,193,168,178,52,124,178,67,147,37,189,122,239,40,216,152,194,246,147,26,139,222,137,51,149,97,213,23,193,90,163,1,125,208,192,210,130,54,103,93,42,244,152,80,81,53,62,22,167,37,3,75,65,131,172,12,153,171,1,155,201,181,90,179,81,136,19,175,168,197,40,205,113,44,82,122,71,165,2,42,67,242,81,182,87,37,123,106,164,238,9,213,254,6,167,1,14,145,246,170,155,114,247,12,211,147,132,233,62,218,121,152,67,81,78,69,139,146,177,161,232,76,108,6,114,137,94,182,80,150,152,197,13,107,136,219,143,61,189,111,142,100,48,232,220,112,230,16,196,7,138,147,62,84,204,178,133,48,180,129,246,17,97,202,20,84,148,170,201,98,48,156,44,182,146,64,246,145,13,154,146,50,13,167,59,137,227,164,26,74,67,135,39,70,62,220,196,169,8,240,214,66,20,220,107,145,197,35,228,114,79,152,14,175,251,189,53,75,111,23,115,168,184,252,178,233,2,159,161,122,146,80,221,71,67,15,130,42,212,144,90,150,62,15,85,29,28,74,87,40,94,71,32,20,227,10,68,85,108,111,43,84,210,218,133,148,10,131,236,186,172,244,141,226,85,152,43,203,86,74,50,160,99,196,230,31,3,170,163,243,229,71,236,166,195,255,82,38,123,171,78,106,213,75,197,249,71,108,72,216,112,106,247,245,78,232,232,38,246,153,137,127,153,9,50,154,243,208,112,85,21,134,173,140,54,80,76,10,208,80,99,210,81,147,44,215,219,152,184,247,192,182,48,113,114,249,7,178,152,132,144,189,27,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "83ce9b125c1b43478e8d24010d4b812d",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("23109609-1650-4a4b-aecb-d0974c538074");
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Order = () => (Guid)((process.AddDataUserTask1.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Order", () => _recordColumnValues_Order.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Order;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,79,220,48,16,253,43,81,206,24,57,206,247,222,16,221,86,72,85,65,5,113,33,61,76,226,73,176,154,47,217,94,40,93,237,127,239,56,89,150,165,218,138,109,47,109,115,137,243,242,230,249,205,120,198,107,191,106,193,152,79,208,161,191,240,111,80,107,48,67,109,79,223,171,214,162,254,160,135,213,232,159,248,6,181,130,86,125,71,57,227,75,169,236,59,176,64,33,235,226,69,161,240,23,197,97,141,194,63,41,124,101,177,51,196,161,144,80,200,42,19,33,103,60,76,57,139,56,175,88,22,150,37,203,33,145,60,72,74,193,81,204,204,95,137,159,15,221,8,26,231,61,38,249,122,90,222,60,141,142,26,16,80,77,20,101,134,126,11,134,206,132,89,246,80,182,40,233,219,234,21,18,100,181,234,40,27,188,81,29,94,129,166,189,156,206,224,32,34,213,208,26,199,106,177,182,203,111,163,70,99,212,208,191,101,174,93,117,253,62,155,4,112,247,185,181,195,39,143,142,121,5,246,126,146,184,32,91,155,201,229,89,211,104,108,192,170,135,125,19,95,241,105,226,29,87,63,10,144,116,74,183,208,174,112,111,207,215,153,156,195,104,231,132,230,237,137,160,85,115,127,116,174,187,138,189,149,174,32,112,124,38,31,169,121,48,7,145,16,248,224,128,89,229,121,89,248,119,23,230,242,177,71,125,93,221,99,7,115,213,190,156,18,250,19,176,108,177,195,222,46,214,34,12,81,4,137,100,24,137,146,69,81,150,177,178,204,56,3,20,121,28,99,16,167,169,216,80,192,206,208,98,29,230,149,64,250,205,36,242,148,69,66,166,44,207,211,140,137,180,44,49,224,113,153,11,10,153,141,43,51,182,240,116,187,243,247,17,65,122,170,247,138,162,240,207,30,65,89,213,55,158,129,22,29,224,25,11,13,122,208,75,207,82,162,222,80,79,191,60,101,38,254,165,150,84,15,90,156,126,198,106,208,114,123,86,238,69,202,129,20,177,68,76,24,240,52,100,145,172,41,145,60,202,89,156,37,81,152,132,1,114,89,82,107,185,199,117,192,208,168,10,218,203,17,53,108,15,159,31,158,141,87,67,229,234,174,135,193,206,213,220,157,155,203,106,242,242,210,157,65,128,18,169,39,49,141,89,148,66,202,74,78,165,173,115,81,199,181,132,168,12,42,50,67,23,139,59,218,235,97,165,171,237,32,155,249,70,249,163,155,226,47,204,255,239,140,244,193,161,58,102,72,254,219,246,255,103,90,115,227,111,126,0,26,22,211,201,232,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,16,253,21,143,146,163,229,145,144,4,18,215,164,7,207,36,173,167,73,115,177,125,88,164,85,227,25,12,30,129,219,73,25,254,189,2,219,113,236,182,167,234,0,236,178,239,237,99,247,209,145,219,246,109,135,36,39,207,24,2,52,181,111,103,119,117,192,217,34,212,22,155,102,246,80,91,40,55,191,160,40,113,1,1,182,216,98,120,129,114,143,205,195,166,105,167,147,75,24,153,146,219,31,227,91,146,47,59,50,111,113,251,109,238,34,187,70,166,81,22,25,85,222,113,42,11,238,41,48,159,82,134,222,50,41,24,202,68,70,176,173,203,253,182,122,196,22,22,208,190,146,188,35,35,91,36,72,157,117,76,48,73,177,112,41,149,200,56,213,142,25,154,161,65,116,70,89,237,144,244,83,210,216,87,220,194,216,244,12,150,28,188,54,24,171,21,43,34,184,40,168,182,96,169,247,194,20,169,212,146,163,29,192,199,250,51,112,121,179,156,55,95,126,86,24,158,70,222,220,67,217,224,122,22,179,87,137,79,37,110,177,106,243,14,184,6,38,77,66,65,114,70,165,4,136,79,42,54,204,156,226,202,121,39,18,219,71,192,251,52,243,46,179,38,101,70,75,202,36,67,42,185,116,212,112,129,212,106,76,51,14,60,83,86,244,235,155,245,32,209,109,154,93,9,111,47,127,42,189,11,8,45,78,234,224,48,204,14,129,155,4,180,49,49,153,187,3,122,119,177,194,143,248,110,117,112,194,138,228,171,127,121,225,120,63,124,249,165,27,174,141,176,34,211,21,121,170,247,193,14,140,34,6,247,31,132,143,77,198,146,171,240,180,249,152,169,246,101,121,204,220,67,11,167,194,83,186,118,27,191,65,55,175,158,78,11,31,89,216,241,208,191,92,78,231,160,237,127,96,143,80,193,119,12,159,227,0,206,218,223,85,62,199,49,158,136,139,196,40,150,69,183,103,8,38,58,47,77,162,109,57,196,253,154,194,139,76,36,222,39,35,250,43,122,12,88,89,188,20,166,89,98,164,210,9,101,105,161,168,244,131,155,180,242,84,136,68,160,82,34,45,50,126,196,55,227,180,135,95,238,168,107,24,85,79,250,126,221,255,6,192,163,119,195,230,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "83ce9b125c1b43478e8d24010d4b812d",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("23109609-1650-4a4b-aecb-d0974c538074");
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

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordId = () => (Guid)((process.AddDataUserTask1.RecordId));
				_ownerId = () => (Guid)((process.ActivityOwner));
				_lead = () => (Guid)((process.LeadId));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_order = () => (Guid)((process.NewOrder));
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("23d86ac4-1d23-4314-a5e3-5da5e61b495a");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 1;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
				}
			}

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("83ce9b125c1b43478e8d24010d4b812d",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
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

			private int _duration = 5;
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

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			private int _remindBefore = 1;
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

			internal Func<Guid> _order;
			public override Guid Order {
				get {
					return (_order ?? (_order = () => Guid.Empty)).Invoke();
				}
				set {
					_order = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public LeadManagementProceedToOrder(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementProceedToOrder";
			SchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_leadId = () => { return (Guid)((StartSignal1.RecordId)); };
			_activityOwner = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty))); };
			_accountId = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementProceedToOrder, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementProceedToOrder, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid NewOrder {
			get;
			set;
		}

		private Func<Guid> _leadId;
		public virtual Guid LeadId {
			get {
				return (_leadId ?? (_leadId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadId = () => { return value; };
			}
		}

		private Func<Guid> _activityOwner;
		public virtual Guid ActivityOwner {
			get {
				return (_activityOwner ?? (_activityOwner = () => Guid.Empty)).Invoke();
			}
			set {
				_activityOwner = () => { return value; };
			}
		}

		private Func<Guid> _accountId;
		public virtual Guid AccountId {
			get {
				return (_accountId ?? (_accountId = () => Guid.Empty)).Invoke();
			}
			set {
				_accountId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("36a74fd9-906b-4e48-b36f-eeba6b29c35b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
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

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
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

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("6b2d1b2d-8ccf-4962-9073-d5cecdf6c2dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayUseProduct;
		public ProcessExclusiveGateway ExclusiveGatewayUseProduct {
			get {
				return _exclusiveGatewayUseProduct ?? (_exclusiveGatewayUseProduct = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayUseProduct",
					SchemaElementUId = new Guid("951af993-3900-4618-9898-be413728166b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayUseProduct.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayContainsOwner;
		public ProcessExclusiveGateway ExclusiveGatewayContainsOwner {
			get {
				return _exclusiveGatewayContainsOwner ?? (_exclusiveGatewayContainsOwner = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayContainsOwner",
					SchemaElementUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayContainsOwner.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask2Execute,
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
					SchemaElementUId = new Guid("a7178c4c-176e-442c-bd14-a31bac9eaac7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2;
		public ProcessConditionalFlow ConditionalSequenceFlow2 {
			get {
				return _conditionalSequenceFlow2 ?? (_conditionalSequenceFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2",
					SchemaElementUId = new Guid("2464e066-7e89-42fe-a792-c0681c0223a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow4;
		public ProcessConditionalFlow ConditionalSequenceFlow4 {
			get {
				return _conditionalSequenceFlow4 ?? (_conditionalSequenceFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow4",
					SchemaElementUId = new Guid("b57d3370-16d1-44e5-8e6f-851093a1cab2"),
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
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ExclusiveGatewayUseProduct.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayUseProduct };
			FlowElements[ExclusiveGatewayContainsOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayContainsOwner };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayContainsOwner", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "ExclusiveGatewayUseProduct":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGatewayContainsOwner":
						if (ConditionalSequenceFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayUseProduct", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayUseProduct", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((StartSignal1.RecordId) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "(StartSignal1.RecordId) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadDataUserTask2.ResultCount) > 0);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayUseProduct", "ConditionalSequenceFlow2", "(ReadDataUserTask2.ResultCount) > 0", result);
			return result;
		}

		private bool ConditionalSequenceFlow4ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayContainsOwner", "ConditionalSequenceFlow4", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"Owner\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"OwnerId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("NewOrder")) {
				writer.WriteValue("NewOrder", NewOrder, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("ActivityOwner")) {
				writer.WriteValue("ActivityOwner", ActivityOwner, Guid.Empty);
			}
			if (!HasMapping("AccountId")) {
				writer.WriteValue("AccountId", AccountId, Guid.Empty);
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
			MetaPathParameterValues.Add("2a65c94d-ad96-4e1a-8678-3223fff78f0d", () => NewOrder);
			MetaPathParameterValues.Add("3dad7563-c615-43f4-ad63-595693663fd7", () => LeadId);
			MetaPathParameterValues.Add("56720a3e-4608-4bb3-8953-ed86f7f2fb7b", () => ActivityOwner);
			MetaPathParameterValues.Add("947f5e54-f169-418b-9dfc-7652c84973d9", () => AccountId);
			MetaPathParameterValues.Add("39c2ee29-de07-42d7-9978-27bbe105b922", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("51e58f82-c660-4f51-a482-2e47790531e4", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("72785b41-22fc-440b-9e25-09541a823da1", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("ba95284a-479c-4695-b20e-f63e9d809aef", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("9cfa6a66-c948-435e-a77c-ce3c093762b0", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("38ad1df5-1e23-417a-b816-604ee5ebd463", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("43a2921d-cbf9-4ccf-9e18-3b7e690771cf", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("b56a9823-aa72-425f-bd71-e269cc7c6b9e", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("b63e014f-03e2-411a-b56e-cd11fcd2dedf", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("c5ddbc71-2bb8-4428-9200-8670e0c41529", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("39c0f849-1bbe-41f7-a8ec-60baac586e9d", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("362c2b06-2632-4385-811f-5d44097aba94", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("f78dac62-b855-47c2-98b1-8d7452f88518", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("dbb1f233-5174-43e1-b1c7-d09d994ca216", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("1156c6f8-f42f-40e6-aabd-037e9316c30f", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("f91976d0-6fa2-4bfa-aa99-75e535e05b15", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("f0036525-a88d-4f8f-9e33-96275cc4add9", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("21c581af-6689-4593-83b0-ade1bc6ace04", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("1c841b42-21d7-449c-9c25-e5d9006c569c", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("a849651b-3c94-415e-8f28-495c77cb69c2", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("233422b6-ee14-4a8a-ba4e-5872f8b8c777", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("0e73147b-3fca-4520-ae87-958d8a954ecb", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("4741dc21-15cb-41c2-8680-9e717f617814", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("1830ecce-1fbf-4a1d-927b-835b4390eef4", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("be29adc6-c305-4fb0-b446-ae26278a5cf6", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("4fd6ce9f-f292-41a0-a8ba-d343dfc9cb25", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("f5c8e8e8-ec65-413b-b1ef-1e44cb614020", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("83189d35-e077-4319-b18e-c6f2b2393707", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("17afe864-aaad-4c4e-ad01-768cbd0e842d", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("53363eca-d6fd-4903-a89f-afc707231e89", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("2d30b140-c803-410d-99de-46fefa3903f9", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("e8a3eb91-0b0d-419f-8a07-a279783a4aed", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("9e8fe1c5-61e9-4c8c-93e5-05ed37a5a23b", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("de74e707-3683-47dc-acb1-0620c233b644", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("6afe29bc-36f3-4e7b-a2a6-ed65c01eaae2", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("77c33b50-7f50-4a1e-846b-d24d080ce656", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("abe22acf-b177-4dbf-a6d4-52b190f66261", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a36f8fca-865d-4aa4-8cc3-db83862aa504", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("d1cd5032-a015-49e6-8905-762ec1677544", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("28914bf3-2c8b-4583-b644-625e18978559", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("c1ffede0-fe00-42d9-a867-6030c7ce74a0", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("86435d98-74c1-4ada-b6e5-22961dde1a37", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("1f919ca3-5929-45db-98dd-c0fa939af046", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("9b610c3e-7085-4d3f-963b-b33fd03a0d68", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("7c960984-040e-414d-913e-c8e671a175c3", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("3a8fb70e-eb46-4374-ad70-c1d1df862c33", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("ed01677f-c36f-4d12-bdce-2d077bf60563", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("a6c6ca26-ca85-48d8-aa3f-ea21bffa2172", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("b2c3e896-818e-48fd-bd84-3c8320d25e1a", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("ae68593e-fa7c-4048-b895-2278f193bf56", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("660ef167-9f42-438e-8e32-a0abcc62314c", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("7df2eca1-dc6c-4087-9840-bee0cc1e644b", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("f101f976-de4b-4470-b288-dc04974ea7d9", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("6cff8c4f-e5db-4f8a-aa7a-f5ac4428b6ea", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("e5ec6ce6-b474-4ec1-956c-dfb129b1a5ce", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("b956b76e-964d-46ce-823f-beb59ae28699", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("00eecca3-2d14-485a-8a8d-eb397d8ffbe8", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("bdac390a-ff58-46a2-907b-14a0c0565f2d", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("f6bbd23d-5104-4c79-9ac8-67b6d9a5d3bd", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("a7ec73e2-62cc-4a89-a496-e288aec50bdd", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("07ade664-1878-4494-93a7-397c9d9a6ba7", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("a25f8f25-a5bc-45f5-a3af-e84d2a250555", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("c5bf469a-ca79-4c27-93c4-428493383a2b", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("109924be-1b7d-46bd-8855-110f7046c49a", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("44c80af5-265f-4ca1-8c98-78e4479635ae", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("c2f936e7-236a-4f61-9aa8-1cadbac9d2fd", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("2983e005-8470-45c9-be2e-d84d93a53203", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("61ea02d3-de9d-4459-b975-072fcd9eff4e", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("c610af2b-9150-43b8-aa79-239e85143fb7", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("41ec49be-7cd4-437d-910a-78a49a359978", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("16cb3b84-997b-460f-931d-69d58bf053af", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("9060fb85-9faf-4a13-809f-40fd6d37daa4", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("3ca71ac5-ea92-4f42-a671-9da656bf2653", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("1e40cbb6-dc33-43c4-907a-c06736c03f8c", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("42b3fc94-7228-4d8e-a9a0-44a7c7f1a17f", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("68804ba6-68d6-4d9a-8543-e1311e13aa63", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("dba832e4-be08-4c39-a60b-c029abee42d9", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("24b1894d-cb19-4761-95a7-21945965fd96", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("79b75417-25b2-4638-9fc0-4ba8602c8164", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("493d3b26-b741-456e-a4a9-1660de4605f1", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("1b88a7ef-d511-4681-afe2-7e7af45479bb", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("b8c8487c-7ec9-4fd7-8382-45adcafaa80a", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("9bba3ff9-9d5d-49eb-9944-5a24a927c8ee", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("02d10657-558f-4de5-bc41-185610ee3c4e", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("9ddc804c-6acd-4c8d-abf1-0a89835fc9f5", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("0f985d04-5e4c-4f3f-8bb9-7b29315ceede", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("17fa3835-9993-4c3b-910d-6fb4b4eb8ab5", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("1ea2f7f3-5e09-433d-a01f-16a9ece5d11f", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("2e83dfcb-d1d1-445a-9f96-e47984017cff", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("fae4b282-9884-4e09-9382-4e83f9cec633", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("985510b3-2488-477a-a863-3ebb94e621e1", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("38999ad9-2ac8-48c0-8d33-55e204924212", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("fa4a8316-c6cc-40b6-8c02-edb5ba71cba1", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("26e8d57d-215d-4749-8846-746c59eb9b24", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("cbc1205a-31ec-4838-8fc9-aef608dfbee4", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("f54e7ee6-df35-43bf-a417-1b4b63aa77d4", () => OpenEditPageUserTask1.Project);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "NewOrder":
					if (!hasValueToRead) break;
					NewOrder = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "ActivityOwner":
					if (!hasValueToRead) break;
					ActivityOwner = reader.GetValue<System.Guid>();
				break;
				case "AccountId":
					if (!hasValueToRead) break;
					AccountId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
				bool priceWithTaxes = Terrasoft.Core.Configuration.SysSettings.GetValue<bool>(UserConnection, "PriceWithTaxes",
					false);
				decimal taxPercent;
				decimal taxAmount;
				decimal totalAmount;
				ProductPriceDataRepository productPriceDataRepository = new ProductPriceDataRepository(UserConnection);
				var priceListFromSysSetting = Terrasoft.Core.Configuration.SysSettings.GetValue<Guid>(UserConnection, "BasePriceList",
					default(Guid));
				Guid preSetPriceList = default(Guid);
				ProductPriceData productPriceData = new ProductPriceData();
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager.GetInstanceByName("LeadProduct"));
				esq.AddColumn("Product.Name");
				esq.AddColumn("Product.Unit");
				esq.AddColumn("Product.Tax");
				esq.AddColumn("Product.Tax.Percent");
				esq.AddColumn("Product.Price");
				esq.AddColumn("Product.Id");
				esq.AddColumn("Product.Currency");
				esq.AddColumn("Product");
				esq.AddColumn("[ProductUnit:Product:Product].NumberOfBaseUnits");
				esq.AddColumn("[ProductUnit:Product:Product].Unit");
				esq.Filters.Add(esq.CreateFilterWithParameters(
					FilterComparisonType.Equal, "Lead", LeadId));
				var products = esq.GetEntityCollection(UserConnection);
				if (products.Count > 0) {
					var isPriceListsEnabled = UserConnection.GetIsFeatureEnabled("UsePriceListsLogic");
					if (isPriceListsEnabled) {
						var priceListPicker = ClassFactory.Get<IPriceListPicker>(new ConstructorArgument("userConnection", 
							UserConnection));
						if (AccountId != default(Guid)) {
							preSetPriceList = priceListPicker.GetPriceList(AccountId);
						}
						if (preSetPriceList == default(Guid) && UserConnection.CurrentUser.AccountId != default(Guid)) {
							preSetPriceList = priceListPicker.GetPriceList(UserConnection.CurrentUser.AccountId);
						}
						if (preSetPriceList != default(Guid) || priceListFromSysSetting != default(Guid)) {
							productPriceDataRepository.Initialize(new List<Guid> { preSetPriceList, priceListFromSysSetting },
							products.Select(product => product.GetTypedColumnValue<Guid>("Product_Id")).ToList());
						}
					}
					var entitySchemaManager = UserConnection.EntitySchemaManager;
					var primaryCurrencyId = Terrasoft.Core.Configuration.SysSettings.GetValue<Guid>(UserConnection, 
						"PrimaryCurrency", Guid.Empty);
					var currencyRateStorage = ClassFactory.Get<CurrencyRateStorage>(new ConstructorArgument("userConnection", 
						UserConnection));
					var currencyRateConverter = ClassFactory.Get<CurrencyConverter>(new ConstructorArgument("currenciesRateStorage", 
						currencyRateStorage));
					var orderProductSchema = entitySchemaManager.GetInstanceByName("OrderProduct");
					var currentUserDateTime = UserConnection.CurrentUser.GetCurrentDateTime();
					foreach (var product in products) {
						bool IsNeedToTakePriceFromPriceList = isPriceListsEnabled && (preSetPriceList != default(Guid) || priceListFromSysSetting != default(Guid))
							&& productPriceDataRepository.TryGetProductPriceData(product.GetTypedColumnValue<Guid>("Product_Id"), out productPriceData);
						Guid productCurrencyId = IsNeedToTakePriceFromPriceList ? productPriceData.CurrencyId : product.GetTypedColumnValue<Guid>("Product_CurrencyId");
						decimal price = IsNeedToTakePriceFromPriceList ? productPriceData.Price : product.GetTypedColumnValue<decimal>("Product_Price");
						if (!productCurrencyId.Equals(primaryCurrencyId)) {
							price = currencyRateConverter.GetConvertedAmountToCurrency(productCurrencyId, 
								primaryCurrencyId, price, currentUserDateTime);
						}
						taxPercent = IsNeedToTakePriceFromPriceList ? productPriceData.TaxPercent : (decimal)product.GetColumnValue("Product_Tax_Percent");
						var orderProductEntity = orderProductSchema.CreateEntity(UserConnection);
						orderProductEntity.SetColumnValue("Name", product.GetTypedColumnValue<string>("Product_Name"));
						orderProductEntity.SetColumnValue("ProductId", product.GetTypedColumnValue<Guid>("Product_Id"));
						orderProductEntity.SetColumnValue("UnitId", product.GetTypedColumnValue<Guid>("ProductUnit_Product_Product_UnitId"));
						orderProductEntity.SetColumnValue("BaseQuantity", product.GetTypedColumnValue<decimal>("ProductUnit_Product_Product_NumberOfBaseUnits"));
						orderProductEntity.SetColumnValue("TaxId", IsNeedToTakePriceFromPriceList ? productPriceData.TaxId : product.GetTypedColumnValue<Guid>("Product_TaxId"));
						orderProductEntity.SetColumnValue("OrderId", NewOrder);
						orderProductEntity.SetColumnValue("Quantity", Decimal.One);
						orderProductEntity.SetColumnValue("PrimaryPrice", price);
						orderProductEntity.SetColumnValue("Price", price);
						orderProductEntity.SetColumnValue("Amount", price);
						orderProductEntity.SetColumnValue("PrimaryAmount", price);
						orderProductEntity.SetColumnValue("DiscountAmount", 0);
						orderProductEntity.SetColumnValue("CurrencyId", primaryCurrencyId);
						orderProductEntity.SetColumnValue("CurrencyRate", 1);
						orderProductEntity.SetColumnValue("DiscountTax", taxPercent);
						if (IsNeedToTakePriceFromPriceList) {
							orderProductEntity.SetColumnValue("PriceListId", productPriceData.PriceListId);
						}
						if (priceWithTaxes) {
							orderProductEntity.SetColumnValue("PrimaryTotalAmount", price);
							orderProductEntity.SetColumnValue("TotalAmount", price);
							taxAmount = (taxPercent * price) / (100 + taxPercent);
						} else {
							taxAmount = (price * taxPercent) / 100;
							totalAmount = price + taxAmount;
							orderProductEntity.SetColumnValue("PrimaryTotalAmount", totalAmount);
							orderProductEntity.SetColumnValue("TotalAmount", totalAmount);
						}
						orderProductEntity.SetColumnValue("TaxAmount", taxAmount);
						if (!productCurrencyId.Equals(primaryCurrencyId)) {
							decimal primaryTaxAmount = currencyRateConverter.GetConvertedAmountToCurrency(
								primaryCurrencyId, productCurrencyId, taxAmount, currentUserDateTime);
							orderProductEntity.SetColumnValue("PrimaryTaxAmount", primaryTaxAmount);
						} else {
							orderProductEntity.SetColumnValue("PrimaryTaxAmount", taxAmount);
						}
						orderProductEntity.Save(false);
					}
				}
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localNewOrder = (AddDataUserTask1.RecordId);
			NewOrder = (System.Guid)localNewOrder;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localActivityOwner = ((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty));
			ActivityOwner = (System.Guid)localActivityOwner;
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
			var cloneItem = (LeadManagementProceedToOrder)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

