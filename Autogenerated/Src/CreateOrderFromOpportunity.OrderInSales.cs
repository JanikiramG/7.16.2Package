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

	#region Class: CreateOrderFromOpportunitySchema

	/// <exclude/>
	public class CreateOrderFromOpportunitySchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CreateOrderFromOpportunitySchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CreateOrderFromOpportunitySchema(CreateOrderFromOpportunitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CreateOrderFromOpportunity";
			UId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"CreateOrderFromOpportunity";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			Version = 0;
			PackageUId = new Guid("b8e3670d-40ce-4674-8aa5-3d4805a5932d");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCurrentOpportunityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("515496b8-401a-4a70-b54d-64bfd7124238"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"CurrentOpportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewOrderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d828a3fe-e2a4-4160-a91c-92ab92b04cfc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"NewOrder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateProductItemsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6c324739-8a48-4082-998b-fa670868c7ce"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ProductItems",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCopyAllProductParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d7f0950e-8bc1-4a4d-b695-906d525716a4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"IsCopyAllProduct",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOpportunityParameter());
			Parameters.Add(CreateNewOrderParameter());
			Parameters.Add(CreateProductItemsParameter());
			Parameters.Add(CreateIsCopyAllProductParameter());
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e1d83148-df86-4cc1-810a-5310eb1688e8"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,149,66,231,48,208,131,148,76,223,10,215,45,114,169,3,196,200,165,202,97,37,45,109,162,146,40,144,84,90,215,240,191,151,148,28,197,9,92,196,237,165,209,137,26,14,103,103,95,251,160,172,193,152,175,208,96,48,15,214,168,53,24,37,236,245,103,89,91,212,95,180,234,187,224,42,48,168,37,212,242,23,86,35,190,172,164,253,4,22,220,147,125,254,172,144,7,243,252,188,70,30,92,229,129,180,216,24,199,113,79,10,224,192,5,7,194,25,10,66,133,136,9,80,150,146,40,228,140,150,33,163,33,173,70,230,159,196,23,170,233,64,227,24,99,144,23,195,113,189,235,60,53,114,64,57,80,164,81,237,17,76,188,9,179,108,161,168,209,203,91,221,163,131,172,150,141,203,6,215,178,193,91,208,46,150,215,81,30,114,36,1,181,241,172,26,133,93,254,236,52,26,35,85,251,150,185,186,111,218,83,182,19,192,233,247,104,39,28,60,122,230,45,216,237,32,113,227,108,29,6,151,31,55,27,141,27,176,242,241,212,196,119,220,13,188,203,234,231,30,84,174,75,247,80,247,120,18,243,101,38,11,232,236,152,208,24,222,17,180,220,108,47,206,117,170,216,91,233,198,14,236,158,200,23,106,158,205,33,78,29,248,232,129,81,229,233,152,7,223,110,204,234,71,139,250,174,220,98,3,99,213,30,174,29,250,10,152,244,231,123,22,49,202,211,98,70,104,24,1,161,144,133,164,96,180,34,41,45,68,149,69,49,141,147,217,225,97,244,33,77,87,195,238,126,10,183,232,181,198,214,126,80,93,167,180,237,91,105,119,3,209,151,209,93,139,12,178,164,136,50,226,154,65,9,45,89,69,32,227,140,240,168,224,88,85,140,149,105,233,218,237,63,223,21,181,145,37,212,171,14,53,28,27,18,158,159,215,23,131,238,107,161,149,178,99,134,83,45,87,175,44,77,131,83,198,51,164,85,66,34,74,19,66,121,84,18,206,99,36,0,60,77,50,145,178,148,70,206,147,219,121,95,245,59,213,235,242,184,99,102,92,246,127,90,226,255,176,154,127,179,109,103,231,253,146,249,125,47,147,249,222,6,238,16,28,126,3,89,198,42,102,89,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3898f5c3-ee0f-45d0-95ac-9cd9a0d94564"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cea4bbf0-8f34-4f22-ab35-9a44c8f81e1e"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f5a484b3-8778-45a8-abde-f587d34577ef"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ebe4df04-3e0e-419e-833f-8e94cd7d6497"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2db847b-3042-4668-bddd-dc4935ba4078"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f824e334-f632-4f09-a820-7cf5de24447a"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("9809e6b3-5ddb-4caf-aa53-a91b85840985"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d44e8b3-9be9-44d9-989e-801007f332a2"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("af44f78e-77ce-4e84-89aa-a4a8589acaca"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a3bbda1d-938c-4804-bae7-3e6727495500"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d90e7819-b5bb-4322-b1a1-688430cac361"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("adbeddd4-1b47-439f-b56f-eaf1ce7c22bd"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1f3ec804-485b-4fb7-ba6c-b97ab3bcb1a8"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("44077e26-c243-4885-bf41-802b99ca00f2"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87d3453d-f7b9-41d7-953c-1ce1e1ade596"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e68ae20-c6e7-4bff-bc6f-c7c1e2476fe2"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a15e8fcf-ba82-439f-bb6f-99ba54972dbc"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("832f2f71-b292-40cd-aa19-4b7009297b25"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("4fb1e2ff-2cc4-4788-bae0-e74102fa14e8"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("30aa1c24-3e58-45a3-a546-cdf3bedb9b62"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c831eecc-a5e6-4e9b-8f0a-6d639e5e35fb"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("874c268f-6319-4d17-ad59-f40c4f774b05"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("01172481-a565-47df-a5be-cb9da2fc12a3"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d828a3fe-e2a4-4160-a91c-92ab92b04cfc}]#]",
				MetaPath = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d828a3fe-e2a4-4160-a91c-92ab92b04cfc}]#]",
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("30f2bca3-c96e-4e5c-88c8-085b0ae8cf0d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("1408b6b8-cf8c-4425-b12e-fbad9c403b3d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c7f158e2-218b-4b9f-8725-909927e9b8b5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3d20f3f7-5984-43c4-9f1d-394a5d9dc018"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e46b1b8b-1819-4789-a14f-65ddf3741c3b"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab96af1a-57c8-4824-96f8-6ba447e62e14"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("2450b4ac-bc00-4be2-9f76-e7e372ca7f07"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("67908e65-2f58-45f9-983b-2c1da6379cd5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("4dea05bc-b597-4eb2-8f8e-707838c63a9e"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("08b712e2-4919-4423-b244-28f0ab6e324e"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a4574b01-f7d9-4d5b-b3e8-504a67746654"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69a2aa31-7c0d-4a87-9dba-2547b60626e5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9f8a922-41df-4718-9bb2-5709eef02ce4"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("d01eb000-e5aa-49b1-a95c-82a0dbd4a4a8"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("540dcd0c-778c-4a17-ac36-7def92eab44c"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ba4e133-0564-4f7f-91ad-971ae82a9e2d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e4d0ff6-c547-4b65-ad49-292460443cd8"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("73d80e1b-1dc6-4b92-92e4-c0ff21953dad"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("5d24cbb8-ba27-4390-9faf-4ac736c965fe"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("f6a640ee-aeff-4e52-a0ef-83b05ca53c8c"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("71ebff1e-d62b-43b6-9539-02c2dffd16a2"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("c29a5757-0505-47ee-b548-5293e3acbd89"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("d6fc85c9-a2f4-455e-b336-fa9b65be5720"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("13610d95-0021-419e-88ad-79b772cbba42"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("e4606663-de9c-46d9-8891-543f07160143"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("89f85502-0eb1-4d21-9eaa-96ebe6cf07ff"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("b9d6544d-94ae-49b4-af5c-ec4c5ed0dc76"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("30207a75-7e4e-4522-904b-474a8b804296"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("1c1730bc-905c-42f3-add5-b5767a8cc78c"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("251964b1-f33f-4a0d-bf37-4b2a62a2a899"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("29a2680c-fd32-4012-916a-2548fffff631"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9101517-77b1-4251-8334-6c0beefd8041"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("88dfbdf6-104a-448e-8a68-5256a4d8de7d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("bcaeafa8-ef4e-4977-81f8-d000782ce97f"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5da83713-07c4-4e79-9df3-1e7de802bcee"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("fa6dc17d-dd86-43d4-b71a-1d6b901489b5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("eb233771-7ac3-4db6-aa21-e29355f9b0f1"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("975dc8f2-6321-4417-9c7b-bd02cf1f0781"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("b3793aa7-c2bf-4f7e-ba51-134097f27019"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("2d39a734-7bc1-4c2e-b145-d00733f01f98"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("e4f8491d-13aa-43d4-b1a6-366538d33a50"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("99c0a079-b569-486d-8118-2ff619216465"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("c29c1ea2-c50d-4de5-ac66-516920f18b79"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a9808a0-acf6-420e-bba5-93f802478e80"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("627ad3cd-7998-4ecb-b7bc-4e7f08515ed5"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("87fa38ed-1e46-464b-bfb2-1adf9fb90a14"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1644d055-35f1-46be-b85d-cbd5030192cb"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,75,111,27,55,16,199,191,138,176,201,209,35,240,253,208,173,112,82,192,128,83,27,113,154,139,237,195,144,28,198,66,229,93,97,181,106,225,10,250,238,29,201,82,252,104,235,52,40,124,48,226,61,72,90,138,51,67,14,255,63,206,172,154,183,195,205,156,154,73,243,137,250,30,23,93,29,198,135,93,79,227,211,190,203,180,88,140,143,187,140,179,233,159,152,102,116,138,61,94,211,64,253,103,156,45,105,113,60,93,12,7,163,135,102,205,65,243,246,247,237,191,205,228,124,213,28,13,116,253,235,81,97,239,78,8,25,181,49,16,101,12,96,164,140,144,130,246,224,138,211,197,123,37,165,138,108,156,187,217,242,186,253,64,3,158,226,112,213,76,86,205,214,27,59,200,94,8,81,178,134,24,144,192,84,111,0,141,38,240,129,162,141,78,152,204,14,214,7,205,34,95,209,53,110,131,222,25,7,161,162,177,65,129,112,201,178,49,34,96,176,21,180,86,154,172,213,46,121,185,49,222,205,191,51,60,127,115,126,180,56,249,163,165,254,108,235,119,82,113,182,160,203,49,143,62,26,120,63,163,107,106,135,201,42,59,242,198,230,8,228,2,199,162,156,33,20,254,21,164,10,74,87,103,84,144,107,54,248,154,205,201,42,6,17,201,37,13,182,148,4,38,99,5,68,171,1,163,76,193,6,35,98,176,27,147,247,237,48,29,110,14,183,57,154,172,76,138,150,116,173,80,139,85,96,144,36,36,129,22,84,182,82,240,184,180,232,215,151,111,46,55,27,43,211,197,124,134,55,159,255,190,191,143,132,101,212,205,231,93,63,44,91,246,62,42,56,224,248,231,105,191,24,70,83,62,190,81,87,71,61,45,150,179,97,218,126,25,241,249,204,40,15,211,174,29,255,148,115,183,108,135,91,255,243,7,210,184,31,97,117,113,171,176,139,102,114,241,111,26,219,125,223,102,244,161,202,30,11,236,162,57,184,104,206,186,101,159,55,30,53,191,188,187,183,181,109,144,237,148,71,175,123,69,241,72,187,156,205,118,35,239,120,171,251,137,251,225,174,76,235,148,202,81,123,182,23,210,214,139,216,61,240,15,31,251,231,118,109,255,199,236,3,182,248,133,250,95,56,1,119,107,255,186,202,79,156,198,189,227,164,162,21,94,86,240,132,145,85,230,20,171,76,226,6,175,84,181,215,170,86,181,181,254,72,149,122,106,51,61,92,152,178,197,103,137,9,100,33,1,198,10,22,143,17,12,136,34,65,44,28,85,28,237,236,23,219,108,111,80,222,173,107,147,170,117,179,94,31,220,7,188,68,87,176,84,9,38,50,214,38,145,130,24,67,130,172,170,34,43,85,242,40,158,4,220,87,18,6,171,131,234,243,198,65,226,29,25,169,33,57,91,48,146,169,90,231,31,11,112,228,163,224,64,8,217,196,205,166,200,3,234,88,64,99,242,138,239,61,233,228,115,2,126,84,94,217,126,145,108,35,25,87,83,240,144,133,202,155,194,16,0,139,150,172,54,165,115,41,49,154,92,191,139,109,167,170,35,116,6,68,229,114,99,60,106,8,92,177,193,197,130,53,134,106,157,86,79,178,93,139,22,92,162,3,72,93,184,250,99,225,226,237,140,224,202,133,218,7,244,198,69,253,28,108,31,119,221,111,203,249,56,231,138,130,36,65,246,149,241,83,86,66,168,41,67,178,145,68,144,190,122,42,99,180,222,70,206,16,56,69,133,195,232,8,193,90,15,37,43,231,124,176,217,122,250,22,107,187,120,39,125,161,126,148,175,176,109,105,54,62,185,99,239,21,168,23,9,212,127,209,207,247,1,69,54,74,47,25,0,242,220,186,57,238,139,131,226,165,137,232,34,202,138,46,203,167,187,225,64,129,75,6,151,134,80,184,7,54,57,11,136,57,33,40,227,156,214,81,40,233,126,176,110,216,25,20,54,85,4,109,5,227,91,82,133,84,249,178,169,201,250,200,55,12,243,76,207,88,44,15,187,118,192,252,218,13,191,76,192,165,75,164,221,22,107,238,91,141,180,124,247,151,34,24,11,161,139,113,65,151,162,191,5,248,229,250,47,40,94,223,132,76,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e61c73fa-a1cd-4ced-8c2f-a8a753e62a94"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				UId = new Guid("ad435e49-6d29-49c1-b37f-07b4169035df"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8ee27e9-0fe2-4341-8e23-4267f53b9416"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a050532e-2c9a-4f51-81bb-cf840e62ef62"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,77,111,219,48,12,253,43,129,207,85,33,127,203,185,13,93,54,20,24,214,98,45,118,169,123,160,101,58,21,102,91,134,44,119,203,2,255,247,81,118,154,116,253,90,209,195,48,96,167,200,12,249,248,72,62,114,235,201,26,250,254,51,52,232,45,189,75,52,6,122,93,217,227,15,170,182,104,62,26,61,116,222,145,215,163,81,80,171,159,88,206,246,85,169,236,123,176,64,33,219,252,128,144,123,203,252,105,140,220,59,202,61,101,177,233,201,135,66,178,64,196,190,240,145,241,52,41,88,84,165,130,21,41,132,76,38,92,22,97,192,121,33,252,217,243,57,240,211,118,134,159,144,171,233,121,185,233,156,87,68,6,169,155,14,140,234,117,187,51,134,46,127,191,106,161,168,177,164,111,107,6,36,147,53,170,161,66,240,82,53,120,14,134,210,56,28,237,76,7,167,26,43,187,250,209,25,236,123,165,219,151,105,157,232,122,104,218,251,222,4,128,251,207,29,27,62,81,116,158,231,96,111,38,136,179,174,211,198,14,173,178,155,220,27,39,182,239,214,107,131,107,176,234,214,197,84,80,247,142,205,55,220,76,1,175,107,33,5,148,52,168,175,80,15,184,75,238,243,71,53,157,64,103,231,210,30,16,33,79,131,21,26,108,37,94,200,27,108,96,95,243,35,63,181,190,185,7,233,6,125,245,66,163,246,221,254,83,175,2,50,118,119,206,47,55,255,252,224,246,68,221,65,66,198,91,103,152,81,238,158,185,119,117,218,159,125,111,209,204,21,206,157,190,62,38,235,3,195,170,198,6,91,187,220,202,4,211,40,150,25,195,68,196,44,66,41,153,40,233,37,252,64,4,97,149,68,129,240,71,10,216,19,90,110,51,193,51,76,138,144,197,101,73,227,146,80,49,128,56,100,144,249,133,136,69,196,51,17,187,144,85,107,169,163,179,140,150,91,64,142,148,8,152,140,50,74,84,97,202,32,204,74,22,66,145,6,169,64,63,241,211,241,122,46,87,245,93,13,155,175,251,170,190,32,148,11,125,152,210,194,53,132,150,210,244,118,225,86,113,161,171,5,181,122,168,173,106,215,11,146,99,141,210,169,224,248,180,156,0,221,143,211,25,164,36,167,74,176,56,131,136,69,188,36,10,65,16,177,34,246,137,127,192,233,239,152,20,59,142,215,163,147,109,173,215,74,66,125,214,161,129,157,166,248,211,187,247,219,210,186,217,24,173,237,3,145,125,162,26,38,50,119,170,143,179,50,174,170,148,179,50,165,166,71,24,20,12,18,224,44,74,184,144,105,16,102,105,34,136,13,221,44,87,237,133,30,140,196,249,80,244,243,177,122,211,17,250,251,247,229,77,39,227,153,21,124,205,74,253,103,203,242,239,104,123,244,198,95,234,208,18,128,132,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9bdd0c6-ef02-470d-918b-9984c37e8456"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,20,252,21,143,146,163,229,65,72,32,137,107,210,131,103,146,212,83,167,185,216,62,60,164,167,198,51,24,60,2,55,147,50,252,123,101,12,113,236,182,167,234,0,163,229,237,190,229,105,213,146,219,230,125,143,36,35,207,232,61,212,149,107,102,119,149,199,217,194,87,6,235,122,246,80,25,40,182,191,32,47,112,1,30,118,216,160,127,129,226,128,245,195,182,110,166,147,75,26,153,146,219,159,253,87,146,173,90,50,111,112,247,125,110,131,186,140,185,22,2,56,77,164,146,84,176,68,208,156,69,57,101,10,36,8,22,129,211,54,144,77,85,28,118,229,35,54,176,128,230,149,100,45,233,213,130,64,106,141,141,120,36,40,230,54,165,2,35,70,149,141,52,149,168,17,173,78,140,178,72,186,41,169,205,43,238,160,111,122,38,11,6,78,105,12,213,73,232,41,48,207,169,50,96,168,115,92,231,169,80,130,161,57,146,135,250,51,113,117,179,154,215,95,223,74,244,203,94,55,115,80,212,184,153,5,244,10,248,82,224,14,203,38,107,173,86,145,82,46,161,34,214,17,21,161,5,5,101,20,5,153,167,177,118,9,79,141,236,2,225,99,154,89,139,41,51,146,59,160,192,140,165,194,160,13,246,98,23,120,32,19,142,105,12,90,116,155,155,205,209,162,221,214,251,2,222,95,254,116,250,132,111,147,202,91,244,179,59,143,208,160,157,120,52,1,152,204,237,137,186,191,56,191,207,228,118,125,138,193,154,100,235,127,5,97,120,159,126,251,50,10,215,41,88,147,233,154,44,171,131,55,71,69,30,54,247,159,92,247,77,250,146,171,237,120,236,1,41,15,69,49,32,247,208,192,88,56,194,149,221,186,45,218,121,185,28,79,187,87,137,134,69,255,242,24,215,201,219,255,208,30,161,132,31,232,159,194,0,206,222,63,92,62,135,49,142,194,121,172,147,72,50,23,66,10,58,196,46,141,67,102,25,80,205,116,238,184,228,177,115,113,207,254,134,14,61,150,6,47,141,169,40,214,34,81,49,141,210,60,228,201,65,72,136,74,28,229,60,230,152,132,36,229,146,13,252,186,159,246,241,190,13,190,142,163,234,72,215,109,186,223,80,198,255,101,227,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startbusinessprocess = CreateStartBusinessProcessStartEvent();
			FlowElements.Add(startbusinessprocess);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaScriptTask copyproductscripttask = CreateCopyProductScriptTaskScriptTask();
			FlowElements.Add(copyproductscripttask);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e547bf8f-5a9b-4973-836c-fa05e0c51a0f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5afbdb3d-b891-4182-a1de-b0b6cd7afbb5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("e47d7853-ced5-43da-a7db-fd3385011ab1"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{515496b8-401a-4a70-b54d-64bfd7124238}]#]== Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(202, 122),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a7eafc6e-049d-4a84-90b6-6ed571fef54e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("55f5bf80-a21a-4643-9564-9d88b48ef8a5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(438, 300),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("589ffe59-36f0-4ca1-a22c-97cb3e65f133"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(282, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("1ec6908e-e69c-424f-9c8c-d14758de5c50"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(708, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("4cb57c2d-2023-4f58-87a5-9a9bfc3c9e3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(846, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("a865471d-c404-4675-9fa5-733f6f1e378a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(846, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2e20440b-bd9c-4844-8378-0cd290e3bd3b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("bfd2a0e9-ab44-4ff1-92dd-dacb801c9d9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(438, 300),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("f2263e84-a07c-46fe-9fcb-c50b6a8f03d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b6fb0ad3-6ee4-4e3f-a948-15ac8ee3c7f4"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(846, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9572b96f-ef1d-462d-8516-9a36c0b9a189"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9572b96f-ef1d-462d-8516-9a36c0b9a189"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartBusinessProcessStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("5afbdb3d-b891-4182-a1de-b0b6cd7afbb5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"StartBusinessProcess",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("a7eafc6e-049d-4a84-90b6-6ed571fef54e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"Terminate1",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ExclusiveGateway1",
				Position = new Point(141, 170),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ReadDataUserTask1",
				Position = new Point(295, 170),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"FormulaTask1",
				Position = new Point(568, 170),
				ResultParameterMetaPath = @"d828a3fe-e2a4-4160-a91c-92ab92b04cfc",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,173,14,131,48,16,0,224,135,65,223,2,253,111,253,4,106,75,38,73,197,237,122,151,9,138,40,36,19,132,119,95,245,236,151,124,203,176,204,251,227,187,113,123,209,135,43,38,193,117,231,124,235,250,7,247,149,43,111,71,58,75,12,99,8,98,193,168,56,130,17,209,128,129,2,160,127,59,21,197,106,71,254,234,225,137,13,43,31,220,210,201,110,34,175,5,1,39,42,96,136,11,4,82,210,31,122,171,217,41,140,230,202,67,254,1,206,164,124,32,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCopyProductScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"CopyProductScriptTask",
				Position = new Point(701, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,65,106,195,64,12,60,59,144,63,168,62,217,16,246,3,105,10,193,52,197,151,186,208,244,1,198,145,205,130,189,107,36,109,83,211,228,239,221,181,211,226,134,20,122,212,104,70,26,141,116,13,201,11,217,131,171,36,23,236,88,237,237,171,144,54,77,146,194,221,6,226,24,78,39,200,57,179,253,176,109,219,11,51,133,207,229,34,122,47,9,42,143,95,64,46,122,164,82,180,53,176,129,93,89,137,37,141,172,178,182,100,158,202,65,61,161,220,123,101,180,71,162,146,109,45,42,179,166,214,141,155,132,42,172,41,232,128,244,61,115,71,182,43,250,222,146,56,163,101,248,89,241,144,132,49,6,143,243,77,214,176,144,11,229,150,26,215,161,145,36,118,140,228,27,6,171,32,139,87,240,246,11,72,211,181,31,116,243,10,245,248,129,149,19,76,194,150,63,12,7,19,255,55,125,155,237,189,242,152,103,20,205,68,249,193,167,152,57,34,127,197,12,94,77,188,160,31,25,207,120,28,139,9,191,254,19,123,198,53,54,49,231,47,247,164,121,233,251,231,144,202,121,185,32,20,71,6,124,168,184,254,2,137,107,141,169,41,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2e20440b-bd9c-4844-8378-0cd290e3bd3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"Terminate2",
				Position = new Point(1044, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"OpenEditPageUserTask1",
				Position = new Point(939, 170),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"AddDataUserTask1",
				Position = new Point(428, 170),
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
				UId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b6fb0ad3-6ee4-4e3f-a948-15ac8ee3c7f4"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(820, 170),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new CreateOrderFromOpportunity(userConnection);
		}

		public override object Clone() {
			return new CreateOrderFromOpportunitySchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"));
		}

		#endregion

	}

	#endregion

	#region Class: CreateOrderFromOpportunity

	/// <exclude/>
	public class CreateOrderFromOpportunity : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, CreateOrderFromOpportunity process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,203,110,219,48,16,252,149,66,231,48,208,131,148,76,223,10,215,45,114,169,3,196,200,165,202,97,37,45,109,162,146,40,144,84,90,215,240,191,151,148,28,197,9,92,196,237,165,209,137,26,14,103,103,95,251,160,172,193,152,175,208,96,48,15,214,168,53,24,37,236,245,103,89,91,212,95,180,234,187,224,42,48,168,37,212,242,23,86,35,190,172,164,253,4,22,220,147,125,254,172,144,7,243,252,188,70,30,92,229,129,180,216,24,199,113,79,10,224,192,5,7,194,25,10,66,133,136,9,80,150,146,40,228,140,150,33,163,33,173,70,230,159,196,23,170,233,64,227,24,99,144,23,195,113,189,235,60,53,114,64,57,80,164,81,237,17,76,188,9,179,108,161,168,209,203,91,221,163,131,172,150,141,203,6,215,178,193,91,208,46,150,215,81,30,114,36,1,181,241,172,26,133,93,254,236,52,26,35,85,251,150,185,186,111,218,83,182,19,192,233,247,104,39,28,60,122,230,45,216,237,32,113,227,108,29,6,151,31,55,27,141,27,176,242,241,212,196,119,220,13,188,203,234,231,30,84,174,75,247,80,247,120,18,243,101,38,11,232,236,152,208,24,222,17,180,220,108,47,206,117,170,216,91,233,198,14,236,158,200,23,106,158,205,33,78,29,248,232,129,81,229,233,152,7,223,110,204,234,71,139,250,174,220,98,3,99,213,30,174,29,250,10,152,244,231,123,22,49,202,211,98,70,104,24,1,161,144,133,164,96,180,34,41,45,68,149,69,49,141,147,217,225,97,244,33,77,87,195,238,126,10,183,232,181,198,214,126,80,93,167,180,237,91,105,119,3,209,151,209,93,139,12,178,164,136,50,226,154,65,9,45,89,69,32,227,140,240,168,224,88,85,140,149,105,233,218,237,63,223,21,181,145,37,212,171,14,53,28,27,18,158,159,215,23,131,238,107,161,149,178,99,134,83,45,87,175,44,77,131,83,198,51,164,85,66,34,74,19,66,121,84,18,206,99,36,0,60,77,50,145,178,148,70,206,147,219,121,95,245,59,213,235,242,184,99,102,92,246,127,90,226,255,176,154,127,179,109,103,231,253,146,249,125,47,147,249,222,6,238,16,28,126,3,89,198,42,102,89,6,0,0 })));
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

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordId = () => (Guid)((process.NewOrder));
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

			#endregion

		}

		#endregion

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_recordDefValues_Opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_SourceOrder = () => (Guid)(new Guid("a5759923-62ed-4f39-8557-dc266785c57e"));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SourceOrder", () => _recordDefValues_SourceOrder.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Account;
			internal Func<Guid> _recordDefValues_Opportunity;
			internal Func<Guid> _recordDefValues_SourceOrder;
			internal Func<Guid> _recordDefValues_Contact;

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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,75,111,27,55,16,199,191,138,176,201,209,35,240,253,208,173,112,82,192,128,83,27,113,154,139,237,195,144,28,198,66,229,93,97,181,106,225,10,250,238,29,201,82,252,104,235,52,40,124,48,226,61,72,90,138,51,67,14,255,63,206,172,154,183,195,205,156,154,73,243,137,250,30,23,93,29,198,135,93,79,227,211,190,203,180,88,140,143,187,140,179,233,159,152,102,116,138,61,94,211,64,253,103,156,45,105,113,60,93,12,7,163,135,102,205,65,243,246,247,237,191,205,228,124,213,28,13,116,253,235,81,97,239,78,8,25,181,49,16,101,12,96,164,140,144,130,246,224,138,211,197,123,37,165,138,108,156,187,217,242,186,253,64,3,158,226,112,213,76,86,205,214,27,59,200,94,8,81,178,134,24,144,192,84,111,0,141,38,240,129,162,141,78,152,204,14,214,7,205,34,95,209,53,110,131,222,25,7,161,162,177,65,129,112,201,178,49,34,96,176,21,180,86,154,172,213,46,121,185,49,222,205,191,51,60,127,115,126,180,56,249,163,165,254,108,235,119,82,113,182,160,203,49,143,62,26,120,63,163,107,106,135,201,42,59,242,198,230,8,228,2,199,162,156,33,20,254,21,164,10,74,87,103,84,144,107,54,248,154,205,201,42,6,17,201,37,13,182,148,4,38,99,5,68,171,1,163,76,193,6,35,98,176,27,147,247,237,48,29,110,14,183,57,154,172,76,138,150,116,173,80,139,85,96,144,36,36,129,22,84,182,82,240,184,180,232,215,151,111,46,55,27,43,211,197,124,134,55,159,255,190,191,143,132,101,212,205,231,93,63,44,91,246,62,42,56,224,248,231,105,191,24,70,83,62,190,81,87,71,61,45,150,179,97,218,126,25,241,249,204,40,15,211,174,29,255,148,115,183,108,135,91,255,243,7,210,184,31,97,117,113,171,176,139,102,114,241,111,26,219,125,223,102,244,161,202,30,11,236,162,57,184,104,206,186,101,159,55,30,53,191,188,187,183,181,109,144,237,148,71,175,123,69,241,72,187,156,205,118,35,239,120,171,251,137,251,225,174,76,235,148,202,81,123,182,23,210,214,139,216,61,240,15,31,251,231,118,109,255,199,236,3,182,248,133,250,95,56,1,119,107,255,186,202,79,156,198,189,227,164,162,21,94,86,240,132,145,85,230,20,171,76,226,6,175,84,181,215,170,86,181,181,254,72,149,122,106,51,61,92,152,178,197,103,137,9,100,33,1,198,10,22,143,17,12,136,34,65,44,28,85,28,237,236,23,219,108,111,80,222,173,107,147,170,117,179,94,31,220,7,188,68,87,176,84,9,38,50,214,38,145,130,24,67,130,172,170,34,43,85,242,40,158,4,220,87,18,6,171,131,234,243,198,65,226,29,25,169,33,57,91,48,146,169,90,231,31,11,112,228,163,224,64,8,217,196,205,166,200,3,234,88,64,99,242,138,239,61,233,228,115,2,126,84,94,217,126,145,108,35,25,87,83,240,144,133,202,155,194,16,0,139,150,172,54,165,115,41,49,154,92,191,139,109,167,170,35,116,6,68,229,114,99,60,106,8,92,177,193,197,130,53,134,106,157,86,79,178,93,139,22,92,162,3,72,93,184,250,99,225,226,237,140,224,202,133,218,7,244,198,69,253,28,108,31,119,221,111,203,249,56,231,138,130,36,65,246,149,241,83,86,66,168,41,67,178,145,68,144,190,122,42,99,180,222,70,206,16,56,69,133,195,232,8,193,90,15,37,43,231,124,176,217,122,250,22,107,187,120,39,125,161,126,148,175,176,109,105,54,62,185,99,239,21,168,23,9,212,127,209,207,247,1,69,54,74,47,25,0,242,220,186,57,238,139,131,226,165,137,232,34,202,138,46,203,167,187,225,64,129,75,6,151,134,80,184,7,54,57,11,136,57,33,40,227,156,214,81,40,233,126,176,110,216,25,20,54,85,4,109,5,227,91,82,133,84,249,178,169,201,250,200,55,12,243,76,207,88,44,15,187,118,192,252,218,13,191,76,192,165,75,164,221,22,107,238,91,141,180,124,247,151,34,24,11,161,139,113,65,151,162,191,5,248,229,250,47,40,94,223,132,76,15,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "be82d4e046384058975d050a3dcff8b5",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("b8e3670d-40ce-4674-8aa5-3d4805a5932d");
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,77,111,219,48,12,253,43,129,207,85,33,127,203,185,13,93,54,20,24,214,98,45,118,169,123,160,101,58,21,102,91,134,44,119,203,2,255,247,81,118,154,116,253,90,209,195,48,96,167,200,12,249,248,72,62,114,235,201,26,250,254,51,52,232,45,189,75,52,6,122,93,217,227,15,170,182,104,62,26,61,116,222,145,215,163,81,80,171,159,88,206,246,85,169,236,123,176,64,33,219,252,128,144,123,203,252,105,140,220,59,202,61,101,177,233,201,135,66,178,64,196,190,240,145,241,52,41,88,84,165,130,21,41,132,76,38,92,22,97,192,121,33,252,217,243,57,240,211,118,134,159,144,171,233,121,185,233,156,87,68,6,169,155,14,140,234,117,187,51,134,46,127,191,106,161,168,177,164,111,107,6,36,147,53,170,161,66,240,82,53,120,14,134,210,56,28,237,76,7,167,26,43,187,250,209,25,236,123,165,219,151,105,157,232,122,104,218,251,222,4,128,251,207,29,27,62,81,116,158,231,96,111,38,136,179,174,211,198,14,173,178,155,220,27,39,182,239,214,107,131,107,176,234,214,197,84,80,247,142,205,55,220,76,1,175,107,33,5,148,52,168,175,80,15,184,75,238,243,71,53,157,64,103,231,210,30,16,33,79,131,21,26,108,37,94,200,27,108,96,95,243,35,63,181,190,185,7,233,6,125,245,66,163,246,221,254,83,175,2,50,118,119,206,47,55,255,252,224,246,68,221,65,66,198,91,103,152,81,238,158,185,119,117,218,159,125,111,209,204,21,206,157,190,62,38,235,3,195,170,198,6,91,187,220,202,4,211,40,150,25,195,68,196,44,66,41,153,40,233,37,252,64,4,97,149,68,129,240,71,10,216,19,90,110,51,193,51,76,138,144,197,101,73,227,146,80,49,128,56,100,144,249,133,136,69,196,51,17,187,144,85,107,169,163,179,140,150,91,64,142,148,8,152,140,50,74,84,97,202,32,204,74,22,66,145,6,169,64,63,241,211,241,122,46,87,245,93,13,155,175,251,170,190,32,148,11,125,152,210,194,53,132,150,210,244,118,225,86,113,161,171,5,181,122,168,173,106,215,11,146,99,141,210,169,224,248,180,156,0,221,143,211,25,164,36,167,74,176,56,131,136,69,188,36,10,65,16,177,34,246,137,127,192,233,239,152,20,59,142,215,163,147,109,173,215,74,66,125,214,161,129,157,166,248,211,187,247,219,210,186,217,24,173,237,3,145,125,162,26,38,50,119,170,143,179,50,174,170,148,179,50,165,166,71,24,20,12,18,224,44,74,184,144,105,16,102,105,34,136,13,221,44,87,237,133,30,140,196,249,80,244,243,177,122,211,17,250,251,247,229,77,39,227,153,21,124,205,74,253,103,203,242,239,104,123,244,198,95,234,208,18,128,132,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,114,155,48,20,252,21,143,146,163,229,65,72,32,137,107,210,131,103,146,212,83,167,185,216,62,60,164,167,198,51,24,60,2,55,147,50,252,123,101,12,113,236,182,167,234,0,163,229,237,190,229,105,213,146,219,230,125,143,36,35,207,232,61,212,149,107,102,119,149,199,217,194,87,6,235,122,246,80,25,40,182,191,32,47,112,1,30,118,216,160,127,129,226,128,245,195,182,110,166,147,75,26,153,146,219,159,253,87,146,173,90,50,111,112,247,125,110,131,186,140,185,22,2,56,77,164,146,84,176,68,208,156,69,57,101,10,36,8,22,129,211,54,144,77,85,28,118,229,35,54,176,128,230,149,100,45,233,213,130,64,106,141,141,120,36,40,230,54,165,2,35,70,149,141,52,149,168,17,173,78,140,178,72,186,41,169,205,43,238,160,111,122,38,11,6,78,105,12,213,73,232,41,48,207,169,50,96,168,115,92,231,169,80,130,161,57,146,135,250,51,113,117,179,154,215,95,223,74,244,203,94,55,115,80,212,184,153,5,244,10,248,82,224,14,203,38,107,173,86,145,82,46,161,34,214,17,21,161,5,5,101,20,5,153,167,177,118,9,79,141,236,2,225,99,154,89,139,41,51,146,59,160,192,140,165,194,160,13,246,98,23,120,32,19,142,105,12,90,116,155,155,205,209,162,221,214,251,2,222,95,254,116,250,132,111,147,202,91,244,179,59,143,208,160,157,120,52,1,152,204,237,137,186,191,56,191,207,228,118,125,138,193,154,100,235,127,5,97,120,159,126,251,50,10,215,41,88,147,233,154,44,171,131,55,71,69,30,54,247,159,92,247,77,250,146,171,237,120,236,1,41,15,69,49,32,247,208,192,88,56,194,149,221,186,45,218,121,185,28,79,187,87,137,134,69,255,242,24,215,201,219,255,208,30,161,132,31,232,159,194,0,206,222,63,92,62,135,49,142,194,121,172,147,72,50,23,66,10,58,196,46,141,67,102,25,80,205,116,238,184,228,177,115,113,207,254,134,14,61,150,6,47,141,169,40,214,34,81,49,141,210,60,228,201,65,72,136,74,28,229,60,230,152,132,36,229,146,13,252,186,159,246,241,190,13,190,142,163,234,72,215,109,186,223,80,198,255,101,227,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "be82d4e046384058975d050a3dcff8b5",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("b8e3670d-40ce-4674-8aa5-3d4805a5932d");
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

		public CreateOrderFromOpportunity(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CreateOrderFromOpportunity";
			SchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: CreateOrderFromOpportunity, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: CreateOrderFromOpportunity, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public virtual Guid NewOrder {
			get;
			set;
		}

		public virtual string ProductItems {
			get;
			set;
		}

		public virtual bool IsCopyAllProduct {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startBusinessProcess;
		public ProcessFlowElement StartBusinessProcess {
			get {
				return _startBusinessProcess ?? (_startBusinessProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartBusinessProcess",
					SchemaElementUId = new Guid("5afbdb3d-b891-4182-a1de-b0b6cd7afbb5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("a7eafc6e-049d-4a84-90b6-6ed571fef54e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
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

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessScriptTask _copyProductScriptTask;
		public ProcessScriptTask CopyProductScriptTask {
			get {
				return _copyProductScriptTask ?? (_copyProductScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CopyProductScriptTask",
					SchemaElementUId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CopyProductScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("2e20440b-bd9c-4844-8378-0cd290e3bd3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("e47d7853-ced5-43da-a7db-fd3385011ab1"),
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
			FlowElements[StartBusinessProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartBusinessProcess };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[CopyProductScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CopyProductScriptTask };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartBusinessProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CopyProductScriptTask", e.Context.SenderName));
						break;
					case "CopyProductScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "OpenEditPageUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((CurrentOpportunity)== Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "(CurrentOpportunity)== Guid.Empty", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("NewOrder")) {
				writer.WriteValue("NewOrder", NewOrder, Guid.Empty);
			}
			if (!HasMapping("ProductItems")) {
				writer.WriteValue("ProductItems", ProductItems, null);
			}
			if (!HasMapping("IsCopyAllProduct")) {
				writer.WriteValue("IsCopyAllProduct", IsCopyAllProduct, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartBusinessProcess", string.Empty));
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
			MetaPathParameterValues.Add("515496b8-401a-4a70-b54d-64bfd7124238", () => CurrentOpportunity);
			MetaPathParameterValues.Add("d828a3fe-e2a4-4160-a91c-92ab92b04cfc", () => NewOrder);
			MetaPathParameterValues.Add("6c324739-8a48-4082-998b-fa670868c7ce", () => ProductItems);
			MetaPathParameterValues.Add("d7f0950e-8bc1-4a4d-b695-906d525716a4", () => IsCopyAllProduct);
			MetaPathParameterValues.Add("e1d83148-df86-4cc1-810a-5310eb1688e8", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("3898f5c3-ee0f-45d0-95ac-9cd9a0d94564", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("cea4bbf0-8f34-4f22-ab35-9a44c8f81e1e", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("f5a484b3-8778-45a8-abde-f587d34577ef", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("ebe4df04-3e0e-419e-833f-8e94cd7d6497", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("c2db847b-3042-4668-bddd-dc4935ba4078", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("f824e334-f632-4f09-a820-7cf5de24447a", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("9809e6b3-5ddb-4caf-aa53-a91b85840985", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("2d44e8b3-9be9-44d9-989e-801007f332a2", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("af44f78e-77ce-4e84-89aa-a4a8589acaca", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("a3bbda1d-938c-4804-bae7-3e6727495500", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("d90e7819-b5bb-4322-b1a1-688430cac361", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("adbeddd4-1b47-439f-b56f-eaf1ce7c22bd", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("1f3ec804-485b-4fb7-ba6c-b97ab3bcb1a8", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("44077e26-c243-4885-bf41-802b99ca00f2", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("87d3453d-f7b9-41d7-953c-1ce1e1ade596", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("8e68ae20-c6e7-4bff-bc6f-c7c1e2476fe2", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a15e8fcf-ba82-439f-bb6f-99ba54972dbc", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("832f2f71-b292-40cd-aa19-4b7009297b25", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("4fb1e2ff-2cc4-4788-bae0-e74102fa14e8", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("30aa1c24-3e58-45a3-a546-cdf3bedb9b62", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("c831eecc-a5e6-4e9b-8f0a-6d639e5e35fb", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("874c268f-6319-4d17-ad59-f40c4f774b05", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("01172481-a565-47df-a5be-cb9da2fc12a3", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("30f2bca3-c96e-4e5c-88c8-085b0ae8cf0d", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("1408b6b8-cf8c-4425-b12e-fbad9c403b3d", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("c7f158e2-218b-4b9f-8725-909927e9b8b5", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("3d20f3f7-5984-43c4-9f1d-394a5d9dc018", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("e46b1b8b-1819-4789-a14f-65ddf3741c3b", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("ab96af1a-57c8-4824-96f8-6ba447e62e14", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("2450b4ac-bc00-4be2-9f76-e7e372ca7f07", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("67908e65-2f58-45f9-983b-2c1da6379cd5", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("4dea05bc-b597-4eb2-8f8e-707838c63a9e", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("08b712e2-4919-4423-b244-28f0ab6e324e", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("a4574b01-f7d9-4d5b-b3e8-504a67746654", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("69a2aa31-7c0d-4a87-9dba-2547b60626e5", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("f9f8a922-41df-4718-9bb2-5709eef02ce4", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("d01eb000-e5aa-49b1-a95c-82a0dbd4a4a8", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("540dcd0c-778c-4a17-ac36-7def92eab44c", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("6ba4e133-0564-4f7f-91ad-971ae82a9e2d", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("3e4d0ff6-c547-4b65-ad49-292460443cd8", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("73d80e1b-1dc6-4b92-92e4-c0ff21953dad", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("5d24cbb8-ba27-4390-9faf-4ac736c965fe", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("f6a640ee-aeff-4e52-a0ef-83b05ca53c8c", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("71ebff1e-d62b-43b6-9539-02c2dffd16a2", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("c29a5757-0505-47ee-b548-5293e3acbd89", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("d6fc85c9-a2f4-455e-b336-fa9b65be5720", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("13610d95-0021-419e-88ad-79b772cbba42", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("e4606663-de9c-46d9-8891-543f07160143", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("89f85502-0eb1-4d21-9eaa-96ebe6cf07ff", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("b9d6544d-94ae-49b4-af5c-ec4c5ed0dc76", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("30207a75-7e4e-4522-904b-474a8b804296", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("1c1730bc-905c-42f3-add5-b5767a8cc78c", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("251964b1-f33f-4a0d-bf37-4b2a62a2a899", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("29a2680c-fd32-4012-916a-2548fffff631", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("b9101517-77b1-4251-8334-6c0beefd8041", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("88dfbdf6-104a-448e-8a68-5256a4d8de7d", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("bcaeafa8-ef4e-4977-81f8-d000782ce97f", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("5da83713-07c4-4e79-9df3-1e7de802bcee", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("fa6dc17d-dd86-43d4-b71a-1d6b901489b5", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("eb233771-7ac3-4db6-aa21-e29355f9b0f1", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("975dc8f2-6321-4417-9c7b-bd02cf1f0781", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("b3793aa7-c2bf-4f7e-ba51-134097f27019", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("2d39a734-7bc1-4c2e-b145-d00733f01f98", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("e4f8491d-13aa-43d4-b1a6-366538d33a50", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("99c0a079-b569-486d-8118-2ff619216465", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("c29c1ea2-c50d-4de5-ac66-516920f18b79", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("2a9808a0-acf6-420e-bba5-93f802478e80", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("627ad3cd-7998-4ecb-b7bc-4e7f08515ed5", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("87fa38ed-1e46-464b-bfb2-1adf9fb90a14", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("1644d055-35f1-46be-b85d-cbd5030192cb", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("e61c73fa-a1cd-4ced-8c2f-a8a753e62a94", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("ad435e49-6d29-49c1-b37f-07b4169035df", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("f8ee27e9-0fe2-4341-8e23-4267f53b9416", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("a050532e-2c9a-4f51-81bb-cf840e62ef62", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("a9bdd0c6-ef02-470d-918b-9984c37e8456", () => ChangeDataUserTask1.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "NewOrder":
					if (!hasValueToRead) break;
					NewOrder = reader.GetValue<System.Guid>();
				break;
				case "ProductItems":
					if (!hasValueToRead) break;
					ProductItems = reader.GetValue<System.String>();
				break;
				case "IsCopyAllProduct":
					if (!hasValueToRead) break;
					IsCopyAllProduct = reader.GetValue<System.Boolean>();
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
			var localNewOrder = (AddDataUserTask1.RecordId);
			NewOrder = (System.Guid)localNewOrder;
			return true;
		}

		public virtual bool CopyProductScriptTaskExecute(ProcessExecutingContext context) {
			if (ProductItems.ToString() != "" || IsCopyAllProduct) {
				var copyProductsOperation = Factories.ClassFactory.Get<
					Terrasoft.Configuration.CopyOrderProductsFromOpportunityOperation>(
					new Factories.ConstructorArgument("userConnection", UserConnection));
				copyProductsOperation.Execute(new Terrasoft.Configuration
					.CopyOrderProductsFromOpportunityOperation
					.CopyOrderProductsArgs {
						OpportunityId = CurrentOpportunity,
						OrderId = NewOrder,
						IsCopyAllProducts = IsCopyAllProduct,
						ProductItems = ProductItems
				});
			}
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
			var cloneItem = (CreateOrderFromOpportunity)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

