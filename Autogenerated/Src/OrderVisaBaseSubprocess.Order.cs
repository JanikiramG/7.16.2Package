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

	#region Class: OrderVisaBaseSubprocessSchema

	/// <exclude/>
	public class OrderVisaBaseSubprocessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public OrderVisaBaseSubprocessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public OrderVisaBaseSubprocessSchema(OrderVisaBaseSubprocessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "OrderVisaBaseSubprocess";
			UId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be");
			CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.16.0.4461";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
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
			RealUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be");
			Version = 0;
			PackageUId = new Guid("ef11e995-ba92-40e9-9077-1a6fee8d4c35");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateOrderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d61a0989-8779-4783-b113-deb50cf15b47"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVisaOwnerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9083bea5-93b0-4bc9-8a38-0da7a8890273"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVisaObjectiveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a7d20fb9-d1a3-4f6c-8cc6-b6e88a8c4343"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaObjective",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateVisaResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("31a29f35-3211-4fc9-a634-b719a4bcbe4f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsAllowedToDelegateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ab166058-c417-46eb-98a4-67cb25768bed"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"IsAllowedToDelegate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsPreviousVisaCountsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7a369c26-a919-430e-9fcc-b7dbd03e82cc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"IsPreviousVisaCounts",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateOrderParameter());
			Parameters.Add(CreateVisaOwnerParameter());
			Parameters.Add(CreateVisaObjectiveParameter());
			Parameters.Add(CreateVisaResultParameter());
			Parameters.Add(CreateIsAllowedToDelegateParameter());
			Parameters.Add(CreateIsPreviousVisaCountsParameter());
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("04f4034b-c6d8-4043-81ff-11c4f91ff61f"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,219,138,27,71,16,253,151,121,200,211,116,232,251,69,121,138,197,6,12,193,94,112,18,12,102,49,213,221,213,222,193,35,141,60,23,199,70,232,223,83,35,173,28,177,40,203,70,201,66,22,242,50,116,247,116,85,157,170,62,167,107,102,251,190,25,126,106,218,17,251,69,129,118,192,122,122,153,23,149,207,38,160,14,142,69,206,51,211,41,113,22,209,57,86,44,120,135,2,116,18,177,170,215,176,194,69,117,176,190,202,205,88,213,205,136,171,97,241,110,251,167,211,177,159,176,126,95,246,147,55,233,22,87,240,235,28,192,32,249,211,9,153,112,9,40,128,245,44,56,180,204,163,52,200,5,106,151,76,117,192,82,74,201,206,219,194,98,52,133,105,8,153,80,201,194,208,197,100,17,133,177,5,170,186,197,50,94,125,217,244,56,12,77,183,94,108,241,219,248,151,175,27,66,121,136,189,236,218,105,181,174,234,21,142,112,13,227,237,162,146,156,59,85,208,48,173,124,100,90,26,202,52,199,192,4,229,108,156,74,46,71,85,213,9,54,227,236,182,122,221,103,236,171,186,199,130,61,174,19,158,164,228,185,12,218,120,201,184,141,228,174,0,48,240,132,88,41,169,208,24,101,163,19,85,157,97,132,223,160,157,112,15,107,219,144,97,148,193,112,39,10,115,8,129,105,180,146,249,44,128,5,17,98,81,78,201,82,228,177,216,63,119,221,199,105,67,133,30,94,77,43,236,155,116,119,106,72,229,239,250,197,54,117,235,177,239,218,217,249,171,19,131,195,233,220,189,124,123,168,72,187,127,51,27,86,187,122,26,112,217,54,184,30,175,214,169,203,205,250,195,254,224,118,59,178,89,109,160,111,134,99,29,175,62,77,208,82,1,154,15,183,15,214,123,57,13,99,183,122,110,249,214,148,43,185,33,174,238,49,207,84,206,205,176,105,225,235,126,190,168,190,251,52,117,227,15,123,22,28,134,213,61,147,227,150,108,5,240,224,3,243,206,81,146,206,43,22,133,80,44,99,52,60,21,97,162,118,119,30,118,245,165,65,222,189,28,94,255,190,62,10,235,80,154,155,239,105,245,222,194,245,209,122,177,125,12,174,221,205,17,217,13,49,224,95,21,179,14,224,114,74,116,246,66,112,218,26,51,243,65,41,6,57,1,6,205,117,41,230,114,49,23,165,192,81,72,98,86,214,76,71,110,25,104,138,19,3,6,82,161,213,38,138,19,49,255,184,217,244,221,231,191,212,179,46,90,199,64,9,197,164,102,168,133,129,0,207,18,38,46,147,160,71,72,207,141,223,255,235,249,172,212,142,68,120,88,109,129,123,21,17,12,11,42,242,153,21,36,34,80,158,241,12,14,188,15,92,58,245,176,164,31,23,231,2,85,63,6,218,19,170,218,56,154,128,214,44,120,103,169,245,37,98,128,229,138,41,193,141,46,244,45,81,146,190,92,213,212,131,37,183,212,78,53,23,137,30,193,176,8,90,49,103,92,242,69,4,161,49,156,168,122,9,164,227,22,243,89,174,6,30,173,137,133,42,83,10,249,18,90,28,46,66,169,37,167,1,148,192,221,145,171,47,186,174,69,88,255,13,178,46,111,49,125,124,209,125,185,79,213,52,175,71,90,63,71,212,189,207,127,160,204,111,52,120,94,9,159,145,230,125,57,236,55,62,1,93,147,202,209,58,29,89,6,64,166,51,169,5,60,72,150,179,242,9,10,72,53,223,236,151,210,213,120,66,162,44,50,167,60,53,33,136,243,247,106,152,137,235,146,45,134,123,208,249,132,174,111,70,24,167,225,124,11,178,150,8,110,32,49,67,18,32,93,33,229,100,128,83,203,132,224,81,185,98,92,121,110,87,242,83,17,253,63,156,242,35,187,208,117,55,52,99,243,25,31,238,14,232,66,129,20,233,114,77,138,56,161,208,49,160,159,53,38,100,4,65,84,183,66,201,147,139,254,102,247,7,182,155,81,25,226,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e666ae4f-cd81-441a-9f61-c2de41eb84f2"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0eedbcbc-25ab-494a-bbeb-e21d15d3be92"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("382fa627-a8e0-4d33-862f-361c9d9220da"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3c107cd1-2016-4d0e-b57d-815d74cd3861"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0ca6bb93-a18e-49e0-ac02-7b6f8cdb0549"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("614e748d-e9f4-4f3b-bdc4-35ee7dcb1b74"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,79,202,74,77,46,201,44,75,181,50,180,50,4,0,6,191,96,252,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"),
				UId = new Guid("15145695-748a-430e-b902-b281b552c89f"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b3e85650-29fb-4199-af80-4eaf98698a27"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("31a4ff18-1803-4d14-8843-1882f4aebc11"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("12fa2c87-6548-4026-a641-3939fadc4b42"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e8720629-f6ec-43e7-8a7b-2c24630badb3"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c003ab55-826d-4b64-9e5f-8804a5848b21"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0ef917e9-7826-4a02-b4bd-171856e1ef12"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"),
				UId = new Guid("4ece07e9-a9db-4a55-87b9-48e11c9ff7e5"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4b15cb40-0f50-4078-a24f-a5956fc6b157"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3785519b-3fe4-434c-86da-2b81ae73e599"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("994245a7-9a7c-4cd9-b698-f14815f3db28"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("76f35d3a-cef1-4876-a692-ff20200917cf"),
				ContainerUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("1404379d-a79a-4596-893d-7c620dfd8caf"),
				ContainerUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
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
				Value = @"5ebe74ce-17ca-4c68-97e6-8e25e01e47c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55ef8b53-d3cc-43e6-b2cb-7bf702d94f72"),
				ContainerUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e99d85dc-8cbe-4f1e-ba54-7c57ddf21953"),
				ContainerUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,109,139,219,70,16,199,191,139,94,244,149,182,236,243,131,251,170,57,174,16,40,151,131,180,37,16,142,48,187,59,155,19,145,37,71,15,105,130,241,119,239,216,62,167,230,226,28,87,55,129,30,244,141,144,86,154,217,153,209,239,63,179,235,55,205,248,75,211,78,56,44,10,180,35,214,243,243,188,168,192,91,35,99,78,44,163,9,76,71,229,89,144,81,48,174,100,145,62,198,92,66,172,234,14,150,184,168,246,214,151,185,153,170,186,153,112,57,46,94,175,255,118,58,13,51,214,111,202,238,225,101,186,197,37,252,190,221,192,96,68,167,19,50,225,18,48,157,44,109,224,208,50,143,210,32,23,168,93,50,213,62,22,11,166,216,28,128,165,108,52,211,65,89,22,19,42,230,48,26,85,34,23,37,229,170,110,177,76,151,31,87,3,142,99,211,119,139,53,126,190,255,237,211,138,162,220,239,125,209,183,243,178,171,234,37,78,112,13,211,237,162,146,156,59,85,208,48,173,124,100,90,26,206,98,142,129,137,148,184,113,42,185,28,85,85,39,88,77,91,183,213,139,33,227,80,213,3,22,28,176,75,120,148,146,231,50,104,227,37,227,54,146,187,2,192,192,155,194,148,146,10,141,81,54,58,81,213,25,38,248,3,218,25,119,97,173,27,50,140,50,24,238,68,161,140,128,138,141,86,50,159,5,176,32,66,44,202,81,201,139,60,20,251,215,190,127,55,175,168,208,227,213,188,196,161,73,119,127,13,169,252,253,176,88,167,190,155,134,190,221,58,191,58,50,216,255,157,187,151,175,246,21,105,119,111,182,134,213,166,158,71,188,104,27,236,166,203,46,245,185,233,222,238,126,220,102,67,54,203,21,12,205,120,168,227,229,251,25,90,42,64,243,246,246,193,122,95,204,227,212,47,159,90,190,53,229,74,110,136,213,93,204,91,148,115,51,174,90,248,180,123,94,84,63,188,159,251,233,167,29,5,251,219,234,158,201,225,147,108,5,240,224,3,243,206,81,146,206,43,22,133,80,36,168,104,120,42,194,68,237,238,60,108,234,115,55,121,253,124,124,241,103,119,16,214,190,52,55,63,210,234,189,133,235,131,245,98,253,152,184,54,55,135,200,110,136,128,111,42,102,81,124,76,138,26,11,45,146,72,208,33,11,94,105,38,131,119,40,116,86,20,218,249,98,46,74,129,163,45,137,172,76,173,34,114,203,64,11,82,116,192,64,42,180,218,68,113,36,230,159,87,171,161,255,240,85,61,235,162,117,164,190,163,41,98,202,42,22,6,2,60,75,152,184,76,130,46,33,61,53,190,255,215,243,73,169,29,64,120,88,109,129,123,21,17,12,11,42,242,45,21,36,34,160,201,200,51,56,240,62,112,233,212,195,146,126,220,62,103,168,250,49,161,125,71,85,91,99,146,215,52,68,61,98,217,78,82,193,64,146,190,81,36,2,129,151,44,183,199,133,115,85,77,51,88,114,75,227,84,115,145,232,18,12,139,160,233,0,96,92,242,69,4,161,49,28,169,250,2,72,199,45,230,147,172,6,30,173,137,133,42,83,10,249,18,90,236,27,161,212,146,211,13,148,192,221,129,213,103,125,223,34,116,255,0,214,139,91,76,239,158,245,31,239,163,154,182,235,145,214,79,129,186,243,249,47,148,249,25,131,167,149,240,9,105,222,151,195,238,195,239,128,107,206,144,104,46,24,86,98,146,212,176,138,99,222,132,200,146,176,150,90,124,118,232,203,249,184,26,79,145,40,139,204,41,79,67,8,98,102,145,135,45,184,46,217,98,184,7,157,143,112,125,57,193,52,143,167,71,144,181,4,184,129,196,12,73,128,142,148,72,57,25,224,204,7,8,30,149,43,198,149,167,214,146,191,4,253,170,159,190,13,235,255,225,172,31,57,136,174,251,177,153,154,15,248,240,128,64,23,10,164,168,152,74,138,176,80,232,24,152,64,228,203,8,130,104,183,66,201,163,94,127,179,249,11,88,123,26,52,229,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb208bfe-de96-49f6-81bc-f82ec1afd252"),
				ContainerUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,79,195,32,24,254,43,134,120,28,11,116,180,192,174,122,89,50,205,226,215,197,122,120,75,95,92,147,174,93,40,51,209,165,255,93,138,93,182,25,119,145,3,180,125,120,62,120,202,158,92,251,207,45,146,57,121,66,231,160,107,173,159,222,180,14,167,43,215,26,236,186,233,178,53,80,87,95,80,212,184,2,7,27,244,232,94,160,222,97,183,172,58,63,185,58,167,145,9,185,254,136,40,153,191,238,201,194,227,230,121,81,6,117,147,88,101,84,146,209,153,80,146,10,38,11,170,132,78,232,12,56,38,12,10,206,116,17,200,166,173,119,155,230,14,61,172,192,175,201,124,79,162,218,32,32,203,132,101,0,129,203,77,152,116,74,11,16,51,42,83,105,148,229,154,11,212,164,159,144,206,172,113,3,209,244,72,78,177,64,41,12,82,46,77,80,48,153,162,90,98,70,21,38,41,50,142,66,154,116,32,143,251,143,68,239,194,18,128,178,234,182,53,124,190,92,194,183,103,213,156,238,216,231,63,13,231,100,158,95,234,120,92,31,99,244,243,150,127,23,156,147,73,78,30,219,157,51,131,226,108,120,57,28,56,58,176,113,208,63,166,195,248,209,136,180,59,104,224,29,221,125,112,140,244,8,221,130,135,104,254,20,114,31,132,53,43,178,180,176,138,50,107,67,255,92,112,170,164,212,52,17,9,11,15,96,53,147,145,253,128,22,29,54,6,255,25,44,58,31,195,28,238,66,248,210,236,234,58,26,116,241,252,195,229,26,131,143,200,237,201,95,58,81,104,203,202,86,88,46,154,255,36,234,73,223,191,245,223,157,251,14,74,39,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("8aad1115-eaba-4c12-98ce-a8b0ae405981"),
				ContainerUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
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
				Value = @"5ebe74ce-17ca-4c68-97e6-8e25e01e47c5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9df5d5d0-f073-472c-859b-f5e3b67221ea"),
				ContainerUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("443af2ec-aeea-4cc0-886a-e903dd5eefa7"),
				ContainerUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
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
				UId = new Guid("d0252b09-da98-4d4e-9dc0-ef8bb6f92f23"),
				ContainerUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
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
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("48aec832-cd69-4509-a9b4-abd75a914dc6"),
				ContainerUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,75,111,27,71,12,128,255,138,177,201,209,52,230,253,208,173,168,47,6,146,198,104,210,92,44,31,200,25,78,162,66,214,10,171,181,139,212,208,127,47,181,178,99,59,109,28,35,39,183,233,30,86,210,204,240,33,146,223,144,215,221,203,241,211,154,187,89,247,142,135,1,55,125,27,143,126,238,7,62,58,29,250,194,155,205,209,171,190,224,114,241,39,210,146,79,113,192,11,30,121,120,143,203,75,222,188,90,108,198,195,131,135,98,221,97,247,242,106,218,237,102,103,215,221,201,200,23,191,157,84,209,78,166,36,231,178,1,29,141,2,103,117,5,138,161,0,179,173,150,147,170,198,25,17,46,253,242,242,98,245,154,71,60,197,241,99,55,187,238,38,109,162,192,40,21,109,99,47,178,137,192,25,175,128,42,101,208,165,40,31,109,137,149,108,183,61,236,54,229,35,95,224,100,244,78,216,51,113,116,133,197,122,65,112,37,36,200,145,3,36,54,158,149,102,23,139,223,9,223,156,191,19,60,123,113,118,178,121,243,199,138,135,183,147,222,89,195,229,134,207,143,100,245,139,133,207,193,153,93,215,160,81,229,148,33,197,152,193,197,100,129,180,182,80,153,188,42,77,123,114,113,123,254,226,124,103,177,46,54,235,37,126,122,255,119,195,111,134,202,195,254,208,250,65,224,239,31,187,158,239,243,55,239,102,243,175,101,240,230,115,239,239,195,28,126,153,190,121,119,56,239,222,246,151,67,217,105,180,187,31,183,225,156,44,168,155,7,254,225,117,251,236,117,76,98,175,113,133,31,120,248,69,44,78,226,211,214,49,142,56,25,127,39,126,223,42,38,147,189,138,186,65,100,148,144,113,48,144,170,70,200,58,83,179,209,154,214,204,36,253,43,55,30,120,85,248,161,99,73,153,236,124,50,160,2,73,137,52,68,192,228,27,88,107,44,123,111,3,69,61,201,79,150,239,156,185,173,52,89,89,93,46,151,147,129,205,244,255,119,165,123,227,248,205,206,241,189,84,221,211,208,215,69,91,112,61,89,125,79,168,182,221,118,123,120,159,147,100,109,77,216,170,20,105,210,224,72,10,8,83,37,80,145,84,228,84,130,107,225,81,78,154,181,24,165,168,37,146,213,137,2,21,0,157,22,88,50,103,9,70,112,158,244,51,225,36,171,100,137,209,67,182,36,119,2,21,33,6,109,2,85,49,98,74,89,153,104,191,205,201,79,235,245,208,95,253,143,202,147,81,113,205,57,202,184,11,184,149,28,83,3,212,152,160,112,81,166,104,121,229,242,175,64,69,155,20,244,238,92,10,70,42,61,75,177,18,86,132,38,12,121,18,242,137,248,81,84,138,73,210,149,68,54,34,10,107,142,28,80,106,10,106,65,213,164,47,37,114,244,76,80,193,88,141,106,210,238,36,211,146,180,38,157,51,149,18,128,2,167,132,169,56,235,158,140,10,46,15,122,250,157,203,184,184,226,31,5,154,42,211,1,106,102,216,93,162,224,170,64,67,81,240,169,138,131,78,164,36,182,245,49,104,158,236,216,115,135,6,93,179,94,5,6,114,85,154,140,67,134,156,37,46,82,181,70,123,14,177,213,199,251,75,172,206,91,71,12,46,137,53,23,179,12,55,201,37,8,49,234,138,50,225,169,24,158,11,52,164,67,80,94,174,54,167,35,184,192,4,57,161,19,87,11,25,31,67,34,174,223,134,230,152,151,252,1,199,69,191,58,88,243,112,177,24,71,174,63,10,54,89,81,240,212,164,37,183,86,192,105,167,247,51,173,12,235,74,190,96,203,42,254,87,177,57,223,254,5,51,185,153,154,28,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("70f3c8ce-16ff-40fc-8eda-5a3419a1ec22"),
				ContainerUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
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

		protected virtual void InitializeIntermediateCatchSignalEvent1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbb5cec9-6a5b-44ae-829a-1f19c78d0339"),
				ContainerUId = new Guid("a5816ab2-fc89-46c9-b765-fc883a751c57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a5816ab2-fc89-46c9-b765-fc883a751c57"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{79386b89-3dc1-45f8-920c-163c2dd52bab}].[Parameter:{70f3c8ce-16ff-40fc-8eda-5a3419a1ec22}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeIntermediateCatchSignalEvent2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2baee59c-8079-46b4-8f24-2a77f99b38b2"),
				ContainerUId = new Guid("0840873f-90de-46aa-83ad-ffee9f1dbd9c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0840873f-90de-46aa-83ad-ffee9f1dbd9c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{79386b89-3dc1-45f8-920c-163c2dd52bab}].[Parameter:{70f3c8ce-16ff-40fc-8eda-5a3419a1ec22}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeIntermediateCatchSignalEvent3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dbcabc88-7940-493a-9211-1d7ef9018176"),
				ContainerUId = new Guid("6ab5ea91-43ce-458d-a7a4-4f584c10c14f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6ab5ea91-43ce-458d-a7a4-4f584c10c14f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{79386b89-3dc1-45f8-920c-163c2dd52bab}].[Parameter:{70f3c8ce-16ff-40fc-8eda-5a3419a1ec22}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaOrderVisa = CreateOrderVisaLaneSet();
			LaneSets.Add(schemaOrderVisa);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaOrderVisa.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startprocess = CreateStartProcessStartEvent();
			FlowElements.Add(startprocess);
			ProcessSchemaTerminateEvent errorendprocess = CreateErrorEndProcessTerminateEvent();
			FlowElements.Add(errorendprocess);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaTerminateEvent alreadyexistsvisaendprocess = CreateAlreadyExistsVisaEndProcessTerminateEvent();
			FlowElements.Add(alreadyexistsvisaendprocess);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaEventBasedGateway visaeventgateway = CreateVisaEventGatewayEventBasedGateway();
			FlowElements.Add(visaeventgateway);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignalevent1 = CreateIntermediateCatchSignalEvent1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignalevent1);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaTerminateEvent visaapprovedendprocess = CreateVisaApprovedEndProcessTerminateEvent();
			FlowElements.Add(visaapprovedendprocess);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignalevent2 = CreateIntermediateCatchSignalEvent2IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignalevent2);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			ProcessSchemaTerminateEvent visarejectedendprocess = CreateVisaRejectedEndProcessTerminateEvent();
			FlowElements.Add(visarejectedendprocess);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignalevent3 = CreateIntermediateCatchSignalEvent3IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignalevent3);
			ProcessSchemaFormulaTask formulatask5 = CreateFormulaTask5FormulaTask();
			FlowElements.Add(formulatask5);
			ProcessSchemaTerminateEvent visacanceledendprocess = CreateVisaCanceledEndProcessTerminateEvent();
			FlowElements.Add(visacanceledendprocess);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("8d149aa9-f724-4667-8861-9130e330ef44"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3ad3c2d7-2e4d-4801-90b9-adc3f9a1e128"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("da192822-0ea3-4542-ac3b-745985e64333"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("e24b4502-eda7-4443-bab4-eab12e044974"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9083bea5-93b0-4bc9-8a38-0da7a8890273}]#] == null || [#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d61a0989-8779-4783-b113-deb50cf15b47}]#] == null",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(241, 255),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da192822-0ea3-4542-ac3b-745985e64333"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("628ae4b5-5b8f-477c-ad0a-e2af292bde57"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a1268ea1-cf94-4054-ba62-50dd9f316349"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(234, 414),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("628ae4b5-5b8f-477c-ad0a-e2af292bde57"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0cf03be0-f5ba-4629-b8ac-e68a921b26d2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("c4ebf13f-3b7a-4280-88b0-b0585f1b8c72"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{7a369c26-a919-430e-9fcc-b7dbd03e82cc}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(392, 275),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3ce13491-ee06-4e1b-9ddd-8aa953f4f35a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("6b6fcea0-ef81-4fa0-bbcc-711ae6b9a4f1"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9}].[Parameter:{b3e85650-29fb-4199-af80-4eaf98698a27}]#] > 0
",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(388, 394),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("62965831-85c2-42aa-95cd-175d0d0ec167"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("24ddb40a-70ed-4876-987c-a8ba582c89b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(392, 502),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("62965831-85c2-42aa-95cd-175d0d0ec167"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("11d26795-fc8e-4951-92e8-475a7d324942"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("bf0addbd-fc4a-4c1e-9fb0-c25a90c78370"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(319, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da192822-0ea3-4542-ac3b-745985e64333"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3ce13491-ee06-4e1b-9ddd-8aa953f4f35a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("fb939242-ceeb-42c7-b74b-0313d1d2a983"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(463, 270),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow6",
				UId = new Guid("f75e062b-eee2-468d-b106-d706ab512610"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(460, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3ce13491-ee06-4e1b-9ddd-8aa953f4f35a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("2496e46d-4529-4988-8d95-51eb8d5c4507"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(584, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("e214a69d-1716-4815-b81b-22bfc27d203e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(741, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a13d0d86-8ec4-428b-9d85-22422b17e4b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("4afb8eef-8424-4618-b9a1-6576ff7169e6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(756, 132),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a13d0d86-8ec4-428b-9d85-22422b17e4b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a5816ab2-fc89-46c9-b765-fc883a751c57"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("456ef303-2cc2-4ea0-b2c3-a1639deb5d7b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(811, 81),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a5816ab2-fc89-46c9-b765-fc883a751c57"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b0824d06-aa50-4291-998c-158027d75f3c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("a385cbea-c321-4c4a-b01a-2771fe86487a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(957, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b0824d06-aa50-4291-998c-158027d75f3c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("645ce592-4039-4a09-81b6-0e17213a8913"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("416ed36c-73aa-40e0-a696-3d4087b84829"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(819, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a13d0d86-8ec4-428b-9d85-22422b17e4b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0840873f-90de-46aa-83ad-ffee9f1dbd9c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("3f4b6dc0-e5a5-40a7-91ce-c7883660f2d5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(927, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0840873f-90de-46aa-83ad-ffee9f1dbd9c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c2370307-718a-419a-b9c8-fabe4d772f0c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("fab7ffe0-79a3-4a17-ad3c-b1bc7a5ec243"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(1091, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c2370307-718a-419a-b9c8-fabe4d772f0c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cdb279c0-a2b0-4dca-8f8b-c4201c2e2a8a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("6b9424b7-cf36-41f9-8ba3-11cda9997246"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(804, 277),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a13d0d86-8ec4-428b-9d85-22422b17e4b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6ab5ea91-43ce-458d-a7a4-4f584c10c14f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("36b5865d-7cf0-494c-b2b8-fc81614eb219"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(926, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6ab5ea91-43ce-458d-a7a4-4f584c10c14f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fb598c27-623f-45e8-a356-973c10f8c81e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("8eece8cd-e6cc-45e7-8909-2fd4f891d664"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				CurveCenterPosition = new Point(1089, 324),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb598c27-623f-45e8-a356-973c10f8c81e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0bb38633-49c6-4537-a858-4d3cf3ad4e21"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateOrderVisaLaneSet() {
			ProcessSchemaLaneSet schemaOrderVisa = new ProcessSchemaLaneSet(this) {
				UId = new Guid("02520355-2dd5-47f3-a88b-281cf8d040e2"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"OrderVisa",
				Position = new Point(5, 5),
				Size = new Size(1190, 571),
				UseBackgroundMode = false
			};
			return schemaOrderVisa;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("02520355-2dd5-47f3-a88b-281cf8d040e2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1161, 571),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartProcessStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("3ad3c2d7-2e4d-4801-90b9-adc3f9a1e128"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"StartProcess",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateErrorEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("0cf03be0-f5ba-4629-b8ac-e68a921b26d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"ErrorEndProcess",
				Position = new Point(190, 443),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("da192822-0ea3-4542-ac3b-745985e64333"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(176, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("628ae4b5-5b8f-477c-ad0a-e2af292bde57"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"FormulaTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(169, 310),
				ResultParameterMetaPath = @"31a29f35-3211-4fc9-a634-b719a4bcbe4f",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,114,45,42,202,47,82,2,0,33,97,29,83,7,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("3ce13491-ee06-4e1b-9ddd-8aa953f4f35a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(330, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"ReadDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(323, 303),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("62965831-85c2-42aa-95cd-175d0d0ec167"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"FormulaTask2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(323, 415),
				ResultParameterMetaPath = @"31a29f35-3211-4fc9-a634-b719a4bcbe4f",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,114,44,40,40,202,47,75,77,81,2,0,254,184,194,168,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateAlreadyExistsVisaEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("11d26795-fc8e-4951-92e8-475a7d324942"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"AlreadyExistsVisaEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(344, 513),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"ChangeDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(463, 170),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventBasedGateway CreateVisaEventGatewayEventBasedGateway() {
			ProcessSchemaEventBasedGateway gateway = new ProcessSchemaEventBasedGateway(this) {
				UId = new Guid("a13d0d86-8ec4-428b-9d85-22422b17e4b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaEventGateway",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(694, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"AddDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(582, 170),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignalEvent1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("a5816ab2-fc89-46c9-b765-fc883a751c57"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"IntermediateCatchSignalEvent1",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(813, 58),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("58ebe36e-7384-4abd-b09c-407c6f508a4d");
			InitializeIntermediateCatchSignalEvent1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("b0824d06-aa50-4291-998c-158027d75f3c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"FormulaTask3",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(939, 44),
				ResultParameterMetaPath = @"31a29f35-3211-4fc9-a634-b719a4bcbe4f",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,114,44,40,40,202,47,75,77,81,2,0,254,184,194,168,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateVisaApprovedEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("645ce592-4039-4a09-81b6-0e17213a8913"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaApprovedEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1093, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignalEvent2IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("0840873f-90de-46aa-83ad-ffee9f1dbd9c"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"IntermediateCatchSignalEvent2",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(813, 184),
				SerializeToDB = true,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("58ebe36e-7384-4abd-b09c-407c6f508a4d");
			InitializeIntermediateCatchSignalEvent2Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("c2370307-718a-419a-b9c8-fabe4d772f0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"FormulaTask4",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(939, 170),
				ResultParameterMetaPath = @"31a29f35-3211-4fc9-a634-b719a4bcbe4f",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,10,74,205,74,77,46,73,77,81,2,0,44,45,80,187,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateVisaRejectedEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cdb279c0-a2b0-4dca-8f8b-c4201c2e2a8a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaRejectedEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1093, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignalEvent3IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("6ab5ea91-43ce-458d-a7a4-4f584c10c14f"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"IntermediateCatchSignalEvent3",
				NewEntityChangedColumns = false,
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(813, 303),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("c7d206aa-401c-4095-ba43-757c8f1914e9");
			InitializeIntermediateCatchSignalEvent3Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask5FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("fb598c27-623f-45e8-a356-973c10f8c81e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"FormulaTask5",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(939, 289),
				ResultParameterMetaPath = @"31a29f35-3211-4fc9-a634-b719a4bcbe4f",
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,114,78,204,75,78,205,73,77,81,2,0,58,56,90,188,10,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateVisaCanceledEndProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("0bb38633-49c6-4537-a858-4d3cf3ad4e21"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d97ac5-5685-456a-a06d-6b7aea7a8be1"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"),
				Name = @"VisaCanceledEndProcess",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1093, 303),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new OrderVisaBaseSubprocess(userConnection);
		}

		public override object Clone() {
			return new OrderVisaBaseSubprocessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderVisaBaseSubprocess

	/// <exclude/>
	public class OrderVisaBaseSubprocess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, OrderVisaBaseSubprocess process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OrderVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("8642a8d0-7f1d-4ca0-9233-1c4c3e6d33f9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,219,138,27,71,16,253,151,121,200,211,116,232,251,69,121,138,197,6,12,193,94,112,18,12,102,49,213,221,213,222,193,35,141,60,23,199,70,232,223,83,35,173,28,177,40,203,70,201,66,22,242,50,116,247,116,85,157,170,62,167,107,102,251,190,25,126,106,218,17,251,69,129,118,192,122,122,153,23,149,207,38,160,14,142,69,206,51,211,41,113,22,209,57,86,44,120,135,2,116,18,177,170,215,176,194,69,117,176,190,202,205,88,213,205,136,171,97,241,110,251,167,211,177,159,176,126,95,246,147,55,233,22,87,240,235,28,192,32,249,211,9,153,112,9,40,128,245,44,56,180,204,163,52,200,5,106,151,76,117,192,82,74,201,206,219,194,98,52,133,105,8,153,80,201,194,208,197,100,17,133,177,5,170,186,197,50,94,125,217,244,56,12,77,183,94,108,241,219,248,151,175,27,66,121,136,189,236,218,105,181,174,234,21,142,112,13,227,237,162,146,156,59,85,208,48,173,124,100,90,26,202,52,199,192,4,229,108,156,74,46,71,85,213,9,54,227,236,182,122,221,103,236,171,186,199,130,61,174,19,158,164,228,185,12,218,120,201,184,141,228,174,0,48,240,132,88,41,169,208,24,101,163,19,85,157,97,132,223,160,157,112,15,107,219,144,97,148,193,112,39,10,115,8,129,105,180,146,249,44,128,5,17,98,81,78,201,82,228,177,216,63,119,221,199,105,67,133,30,94,77,43,236,155,116,119,106,72,229,239,250,197,54,117,235,177,239,218,217,249,171,19,131,195,233,220,189,124,123,168,72,187,127,51,27,86,187,122,26,112,217,54,184,30,175,214,169,203,205,250,195,254,224,118,59,178,89,109,160,111,134,99,29,175,62,77,208,82,1,154,15,183,15,214,123,57,13,99,183,122,110,249,214,148,43,185,33,174,238,49,207,84,206,205,176,105,225,235,126,190,168,190,251,52,117,227,15,123,22,28,134,213,61,147,227,150,108,5,240,224,3,243,206,81,146,206,43,22,133,80,44,99,52,60,21,97,162,118,119,30,118,245,165,65,222,189,28,94,255,190,62,10,235,80,154,155,239,105,245,222,194,245,209,122,177,125,12,174,221,205,17,217,13,49,224,95,21,179,14,224,114,74,116,246,66,112,218,26,51,243,65,41,6,57,1,6,205,117,41,230,114,49,23,165,192,81,72,98,86,214,76,71,110,25,104,138,19,3,6,82,161,213,38,138,19,49,255,184,217,244,221,231,191,212,179,46,90,199,64,9,197,164,102,168,133,129,0,207,18,38,46,147,160,71,72,207,141,223,255,235,249,172,212,142,68,120,88,109,129,123,21,17,12,11,42,242,153,21,36,34,80,158,241,12,14,188,15,92,58,245,176,164,31,23,231,2,85,63,6,218,19,170,218,56,154,128,214,44,120,103,169,245,37,98,128,229,138,41,193,141,46,244,45,81,146,190,92,213,212,131,37,183,212,78,53,23,137,30,193,176,8,90,49,103,92,242,69,4,161,49,156,168,122,9,164,227,22,243,89,174,6,30,173,137,133,42,83,10,249,18,90,28,46,66,169,37,167,1,148,192,221,145,171,47,186,174,69,88,255,13,178,46,111,49,125,124,209,125,185,79,213,52,175,71,90,63,71,212,189,207,127,160,204,111,52,120,94,9,159,145,230,125,57,236,55,62,1,93,147,202,209,58,29,89,6,64,166,51,169,5,60,72,150,179,242,9,10,72,53,223,236,151,210,213,120,66,162,44,50,167,60,53,33,136,243,247,106,152,137,235,146,45,134,123,208,249,132,174,111,70,24,167,225,124,11,178,150,8,110,32,49,67,18,32,93,33,229,100,128,83,203,132,224,81,185,98,92,121,110,87,242,83,17,253,63,156,242,35,187,208,117,55,52,99,243,25,31,238,14,232,66,129,20,233,114,77,138,56,161,208,49,160,159,53,38,100,4,65,84,183,66,201,147,139,254,102,247,7,182,155,81,25,226,13,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,79,202,74,77,46,201,44,75,181,50,180,50,4,0,6,191,96,252,20,0,0,0 })));
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
								new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"));
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, OrderVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("607c2930-07fe-47db-a6d2-0c0ce46e5459");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_IsCanceled = () => (bool)(true);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_IsCanceled", () => _recordColumnValues_IsCanceled.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordColumnValues_IsCanceled;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,109,139,219,70,16,199,191,139,94,244,149,182,236,243,131,251,170,57,174,16,40,151,131,180,37,16,142,48,187,59,155,19,145,37,71,15,105,130,241,119,239,216,62,167,230,226,28,87,55,129,30,244,141,144,86,154,217,153,209,239,63,179,235,55,205,248,75,211,78,56,44,10,180,35,214,243,243,188,168,192,91,35,99,78,44,163,9,76,71,229,89,144,81,48,174,100,145,62,198,92,66,172,234,14,150,184,168,246,214,151,185,153,170,186,153,112,57,46,94,175,255,118,58,13,51,214,111,202,238,225,101,186,197,37,252,190,221,192,96,68,167,19,50,225,18,48,157,44,109,224,208,50,143,210,32,23,168,93,50,213,62,22,11,166,216,28,128,165,108,52,211,65,89,22,19,42,230,48,26,85,34,23,37,229,170,110,177,76,151,31,87,3,142,99,211,119,139,53,126,190,255,237,211,138,162,220,239,125,209,183,243,178,171,234,37,78,112,13,211,237,162,146,156,59,85,208,48,173,124,100,90,26,206,98,142,129,137,148,184,113,42,185,28,85,85,39,88,77,91,183,213,139,33,227,80,213,3,22,28,176,75,120,148,146,231,50,104,227,37,227,54,146,187,2,192,192,155,194,148,146,10,141,81,54,58,81,213,25,38,248,3,218,25,119,97,173,27,50,140,50,24,238,68,161,140,128,138,141,86,50,159,5,176,32,66,44,202,81,201,139,60,20,251,215,190,127,55,175,168,208,227,213,188,196,161,73,119,127,13,169,252,253,176,88,167,190,155,134,190,221,58,191,58,50,216,255,157,187,151,175,246,21,105,119,111,182,134,213,166,158,71,188,104,27,236,166,203,46,245,185,233,222,238,126,220,102,67,54,203,21,12,205,120,168,227,229,251,25,90,42,64,243,246,246,193,122,95,204,227,212,47,159,90,190,53,229,74,110,136,213,93,204,91,148,115,51,174,90,248,180,123,94,84,63,188,159,251,233,167,29,5,251,219,234,158,201,225,147,108,5,240,224,3,243,206,81,146,206,43,22,133,80,36,168,104,120,42,194,68,237,238,60,108,234,115,55,121,253,124,124,241,103,119,16,214,190,52,55,63,210,234,189,133,235,131,245,98,253,152,184,54,55,135,200,110,136,128,111,42,102,81,124,76,138,26,11,45,146,72,208,33,11,94,105,38,131,119,40,116,86,20,218,249,98,46,74,129,163,45,137,172,76,173,34,114,203,64,11,82,116,192,64,42,180,218,68,113,36,230,159,87,171,161,255,240,85,61,235,162,117,164,190,163,41,98,202,42,22,6,2,60,75,152,184,76,130,46,33,61,53,190,255,215,243,73,169,29,64,120,88,109,129,123,21,17,12,11,42,242,45,21,36,34,160,201,200,51,56,240,62,112,233,212,195,146,126,220,62,103,168,250,49,161,125,71,85,91,99,146,215,52,68,61,98,217,78,82,193,64,146,190,81,36,2,129,151,44,183,199,133,115,85,77,51,88,114,75,227,84,115,145,232,18,12,139,160,233,0,96,92,242,69,4,161,49,28,169,250,2,72,199,45,230,147,172,6,30,173,137,133,42,83,10,249,18,90,236,27,161,212,146,211,13,148,192,221,129,213,103,125,223,34,116,255,0,214,139,91,76,239,158,245,31,239,163,154,182,235,145,214,79,129,186,243,249,47,148,249,25,131,167,149,240,9,105,222,151,195,238,195,239,128,107,206,144,104,46,24,86,98,146,212,176,138,99,222,132,200,146,176,150,90,124,118,232,203,249,184,26,79,145,40,139,204,41,79,67,8,98,102,145,135,45,184,46,217,98,184,7,157,143,112,125,57,193,52,143,167,71,144,181,4,184,129,196,12,73,128,142,148,72,57,25,224,204,7,8,30,149,43,198,149,167,214,146,191,4,253,170,159,190,13,235,255,225,172,31,57,136,174,251,177,153,154,15,248,240,128,64,23,10,164,168,152,74,138,176,80,232,24,152,64,228,203,8,130,104,183,66,201,163,94,127,179,249,11,88,123,26,52,229,13,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,77,79,195,32,24,254,43,134,120,28,11,116,180,192,174,122,89,50,205,226,215,197,122,120,75,95,92,147,174,93,40,51,209,165,255,93,138,93,182,25,119,145,3,180,125,120,62,120,202,158,92,251,207,45,146,57,121,66,231,160,107,173,159,222,180,14,167,43,215,26,236,186,233,178,53,80,87,95,80,212,184,2,7,27,244,232,94,160,222,97,183,172,58,63,185,58,167,145,9,185,254,136,40,153,191,238,201,194,227,230,121,81,6,117,147,88,101,84,146,209,153,80,146,10,38,11,170,132,78,232,12,56,38,12,10,206,116,17,200,166,173,119,155,230,14,61,172,192,175,201,124,79,162,218,32,32,203,132,101,0,129,203,77,152,116,74,11,16,51,42,83,105,148,229,154,11,212,164,159,144,206,172,113,3,209,244,72,78,177,64,41,12,82,46,77,80,48,153,162,90,98,70,21,38,41,50,142,66,154,116,32,143,251,143,68,239,194,18,128,178,234,182,53,124,190,92,194,183,103,213,156,238,216,231,63,13,231,100,158,95,234,120,92,31,99,244,243,150,127,23,156,147,73,78,30,219,157,51,131,226,108,120,57,28,56,58,176,113,208,63,166,195,248,209,136,180,59,104,224,29,221,125,112,140,244,8,221,130,135,104,254,20,114,31,132,53,43,178,180,176,138,50,107,67,255,92,112,170,164,212,52,17,9,11,15,96,53,147,145,253,128,22,29,54,6,255,25,44,58,31,195,28,238,66,248,210,236,234,58,26,116,241,252,195,229,26,131,143,200,237,201,95,58,81,104,203,202,86,88,46,154,255,36,234,73,223,191,245,223,157,251,14,74,39,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f20cf97d26c94e96963d91df1c9d86be",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("ef11e995-ba92-40e9-9077-1a6fee8d4c35");
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

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, OrderVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("79386b89-3dc1-45f8-920c-163c2dd52bab");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Order = () => (Guid)((process.Order));
				_recordDefValues_VisaOwner = () => (Guid)((process.VisaOwner));
				_recordDefValues_Objective = () => new LocalizableString((process.VisaObjective));
				_recordDefValues_IsAllowedToDelegate = () => (bool)((process.IsAllowedToDelegate));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Order", () => _recordDefValues_Order.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_VisaOwner", () => _recordDefValues_VisaOwner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Objective", () => _recordDefValues_Objective.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsAllowedToDelegate", () => _recordDefValues_IsAllowedToDelegate.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Order;
			internal Func<Guid> _recordDefValues_VisaOwner;
			internal Func<string> _recordDefValues_Objective;
			internal Func<bool> _recordDefValues_IsAllowedToDelegate;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,75,111,27,71,12,128,255,138,177,201,209,52,230,253,208,173,168,47,6,146,198,104,210,92,44,31,200,25,78,162,66,214,10,171,181,139,212,208,127,47,181,178,99,59,109,28,35,39,183,233,30,86,210,204,240,33,146,223,144,215,221,203,241,211,154,187,89,247,142,135,1,55,125,27,143,126,238,7,62,58,29,250,194,155,205,209,171,190,224,114,241,39,210,146,79,113,192,11,30,121,120,143,203,75,222,188,90,108,198,195,131,135,98,221,97,247,242,106,218,237,102,103,215,221,201,200,23,191,157,84,209,78,166,36,231,178,1,29,141,2,103,117,5,138,161,0,179,173,150,147,170,198,25,17,46,253,242,242,98,245,154,71,60,197,241,99,55,187,238,38,109,162,192,40,21,109,99,47,178,137,192,25,175,128,42,101,208,165,40,31,109,137,149,108,183,61,236,54,229,35,95,224,100,244,78,216,51,113,116,133,197,122,65,112,37,36,200,145,3,36,54,158,149,102,23,139,223,9,223,156,191,19,60,123,113,118,178,121,243,199,138,135,183,147,222,89,195,229,134,207,143,100,245,139,133,207,193,153,93,215,160,81,229,148,33,197,152,193,197,100,129,180,182,80,153,188,42,77,123,114,113,123,254,226,124,103,177,46,54,235,37,126,122,255,119,195,111,134,202,195,254,208,250,65,224,239,31,187,158,239,243,55,239,102,243,175,101,240,230,115,239,239,195,28,126,153,190,121,119,56,239,222,246,151,67,217,105,180,187,31,183,225,156,44,168,155,7,254,225,117,251,236,117,76,98,175,113,133,31,120,248,69,44,78,226,211,214,49,142,56,25,127,39,126,223,42,38,147,189,138,186,65,100,148,144,113,48,144,170,70,200,58,83,179,209,154,214,204,36,253,43,55,30,120,85,248,161,99,73,153,236,124,50,160,2,73,137,52,68,192,228,27,88,107,44,123,111,3,69,61,201,79,150,239,156,185,173,52,89,89,93,46,151,147,129,205,244,255,119,165,123,227,248,205,206,241,189,84,221,211,208,215,69,91,112,61,89,125,79,168,182,221,118,123,120,159,147,100,109,77,216,170,20,105,210,224,72,10,8,83,37,80,145,84,228,84,130,107,225,81,78,154,181,24,165,168,37,146,213,137,2,21,0,157,22,88,50,103,9,70,112,158,244,51,225,36,171,100,137,209,67,182,36,119,2,21,33,6,109,2,85,49,98,74,89,153,104,191,205,201,79,235,245,208,95,253,143,202,147,81,113,205,57,202,184,11,184,149,28,83,3,212,152,160,112,81,166,104,121,229,242,175,64,69,155,20,244,238,92,10,70,42,61,75,177,18,86,132,38,12,121,18,242,137,248,81,84,138,73,210,149,68,54,34,10,107,142,28,80,106,10,106,65,213,164,47,37,114,244,76,80,193,88,141,106,210,238,36,211,146,180,38,157,51,149,18,128,2,167,132,169,56,235,158,140,10,46,15,122,250,157,203,184,184,226,31,5,154,42,211,1,106,102,216,93,162,224,170,64,67,81,240,169,138,131,78,164,36,182,245,49,104,158,236,216,115,135,6,93,179,94,5,6,114,85,154,140,67,134,156,37,46,82,181,70,123,14,177,213,199,251,75,172,206,91,71,12,46,137,53,23,179,12,55,201,37,8,49,234,138,50,225,169,24,158,11,52,164,67,80,94,174,54,167,35,184,192,4,57,161,19,87,11,25,31,67,34,174,223,134,230,152,151,252,1,199,69,191,58,88,243,112,177,24,71,174,63,10,54,89,81,240,212,164,37,183,86,192,105,167,247,51,173,12,235,74,190,96,203,42,254,87,177,57,223,254,5,51,185,153,154,28,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "f20cf97d26c94e96963d91df1c9d86be",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("ef11e995-ba92-40e9-9077-1a6fee8d4c35");
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

		#region Class: IntermediateCatchSignalEvent1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignalEvent1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignalEvent1FlowElement(UserConnection userConnection, OrderVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignalEvent1";
				IsLogging = false;
				SchemaElementUId = new Guid("a5816ab2-fc89-46c9-b765-fc883a751c57");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""58ebe36e-7384-4abd-b09c-407c6f508a4d""]}";
				EntityFilters = @"{_isFilter:false,uId:""9ab6c665-e152-40ba-a827-1ccb9ce9e285"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"",uId:""5c734bfa-8975-4adf-87ca-82ea5c384b5c"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""58ebe36e-7384-4abd-b09c-407c6f508a4d"",caption:""Status"",referenceSchemaUId:""66c8f5ac-57d2-4fe8-95a0-89a98e37f57f"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Positive&quot;"",parameterValue:""&quot;e79facb3-3c32-43e7-a59e-12ba125e6132&quot;""}]}},{_isFilter:true,_filterSchemaUId:""5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"",uId:""93604a91-4a82-4c7a-b1ec-420b8412c9b2"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""false""}]}}]}";
				_recordId = () => (Guid)((process.AddDataUserTask1.RecordId));
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

		#region Class: IntermediateCatchSignalEvent2FlowElement

		/// <exclude/>
		public class IntermediateCatchSignalEvent2FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignalEvent2FlowElement(UserConnection userConnection, OrderVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignalEvent2";
				IsLogging = false;
				SchemaElementUId = new Guid("0840873f-90de-46aa-83ad-ffee9f1dbd9c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""58ebe36e-7384-4abd-b09c-407c6f508a4d""]}";
				EntityFilters = @"{_isFilter:false,uId:""dc18c4b1-c7bc-4aee-9544-0b37b1596341"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"",uId:""b9cb58cf-39c5-4e9f-8a6f-c7db5ce0c14d"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""58ebe36e-7384-4abd-b09c-407c6f508a4d"",caption:""Status"",referenceSchemaUId:""66c8f5ac-57d2-4fe8-95a0-89a98e37f57f"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""b295071f-7ea9-4e62-8d1a-919bf3732ff2"",name:""Lookup"",isNumeric:false,editor:{controlTypeName:""LookupEdit"",controlXType:""lookupedit""},useClientEncoding:true},parameterValues:[{displayValue:""&quot;Negative&quot;"",parameterValue:""&quot;a93ab0b9-ca36-4b95-9b23-e01aa169c338&quot;""}]}},{_isFilter:true,_filterSchemaUId:""5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"",uId:""65704568-78e8-4381-802a-6558d898e85c"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""false""}]}}]}";
				_recordId = () => (Guid)((process.AddDataUserTask1.RecordId));
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

		#region Class: IntermediateCatchSignalEvent3FlowElement

		/// <exclude/>
		public class IntermediateCatchSignalEvent3FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignalEvent3FlowElement(UserConnection userConnection, OrderVisaBaseSubprocess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignalEvent3";
				IsLogging = false;
				SchemaElementUId = new Guid("6ab5ea91-43ce-458d-a7a4-4f584c10c14f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""c7d206aa-401c-4095-ba43-757c8f1914e9""]}";
				EntityFilters = @"{_isFilter:false,uId:""b7b3e303-3b88-49cb-b059-e921d77d816d"",name:""FilterEdit"",items:[{_isFilter:true,_filterSchemaUId:""5ebe74ce-17ca-4c68-97e6-8e25e01e47c5"",uId:""c01373f7-59e4-4771-af0b-8cee4ede4312"",leftExpression:{expressionType:""SchemaColumn"",metaPath:""c7d206aa-401c-4095-ba43-757c8f1914e9"",caption:""Canceled"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false}},comparisonType:""Equal"",rightExpression:{expressionType:""Parameter"",dataValueType:{id:""90b65bf8-0ffc-4141-8779-2420877af907"",name:""Boolean"",isNumeric:false,editor:{controlTypeName:""CheckBox"",controlXType:""checkbox""},useClientEncoding:false},parameterValues:[{parameterValue:""true""}]}}]}";
				_recordId = () => (Guid)((process.AddDataUserTask1.RecordId));
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

		public OrderVisaBaseSubprocess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderVisaBaseSubprocess";
			SchemaUId = new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be");
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
				return new Guid("f20cf97d-26c9-4e96-963d-91df1c9d86be");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: OrderVisaBaseSubprocess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: OrderVisaBaseSubprocess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid Order {
			get;
			set;
		}

		public virtual Guid VisaOwner {
			get;
			set;
		}

		public virtual string VisaObjective {
			get;
			set;
		}

		public virtual string VisaResult {
			get;
			set;
		}

		public virtual bool IsAllowedToDelegate {
			get;
			set;
		}

		public virtual bool IsPreviousVisaCounts {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startProcess;
		public ProcessFlowElement StartProcess {
			get {
				return _startProcess ?? (_startProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartProcess",
					SchemaElementUId = new Guid("3ad3c2d7-2e4d-4801-90b9-adc3f9a1e128"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _errorEndProcess;
		public ProcessTerminateEvent ErrorEndProcess {
			get {
				return _errorEndProcess ?? (_errorEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "ErrorEndProcess",
					SchemaElementUId = new Guid("0cf03be0-f5ba-4629-b8ac-e68a921b26d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("da192822-0ea3-4542-ac3b-745985e64333"),
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

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("628ae4b5-5b8f-477c-ad0a-e2af292bde57"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
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
					SchemaElementUId = new Guid("3ce13491-ee06-4e1b-9ddd-8aa953f4f35a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
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

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("62965831-85c2-42aa-95cd-175d0d0ec167"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ProcessTerminateEvent _alreadyExistsVisaEndProcess;
		public ProcessTerminateEvent AlreadyExistsVisaEndProcess {
			get {
				return _alreadyExistsVisaEndProcess ?? (_alreadyExistsVisaEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "AlreadyExistsVisaEndProcess",
					SchemaElementUId = new Guid("11d26795-fc8e-4951-92e8-475a7d324942"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveEventBasedGateway _visaEventGateway;
		public ProcessExclusiveEventBasedGateway VisaEventGateway {
			get {
				return _visaEventGateway ?? (_visaEventGateway = new ProcessExclusiveEventBasedGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventBasedGateway",
					Name = "VisaEventGateway",
					SchemaElementUId = new Guid("a13d0d86-8ec4-428b-9d85-22422b17e4b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Events = new Collection<string> { "IntermediateCatchSignalEvent1", "IntermediateCatchSignalEvent2", "IntermediateCatchSignalEvent3", },
				});
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignalEvent1FlowElement _intermediateCatchSignalEvent1;
		public IntermediateCatchSignalEvent1FlowElement IntermediateCatchSignalEvent1 {
			get {
				return _intermediateCatchSignalEvent1 ?? ((_intermediateCatchSignalEvent1) = new IntermediateCatchSignalEvent1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask3;
		public ProcessScriptTask FormulaTask3 {
			get {
				return _formulaTask3 ?? (_formulaTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask3",
					SchemaElementUId = new Guid("b0824d06-aa50-4291-998c-158027d75f3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessTerminateEvent _visaApprovedEndProcess;
		public ProcessTerminateEvent VisaApprovedEndProcess {
			get {
				return _visaApprovedEndProcess ?? (_visaApprovedEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "VisaApprovedEndProcess",
					SchemaElementUId = new Guid("645ce592-4039-4a09-81b6-0e17213a8913"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private IntermediateCatchSignalEvent2FlowElement _intermediateCatchSignalEvent2;
		public IntermediateCatchSignalEvent2FlowElement IntermediateCatchSignalEvent2 {
			get {
				return _intermediateCatchSignalEvent2 ?? ((_intermediateCatchSignalEvent2) = new IntermediateCatchSignalEvent2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask4;
		public ProcessScriptTask FormulaTask4 {
			get {
				return _formulaTask4 ?? (_formulaTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask4",
					SchemaElementUId = new Guid("c2370307-718a-419a-b9c8-fabe4d772f0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask4Execute,
				});
			}
		}

		private ProcessTerminateEvent _visaRejectedEndProcess;
		public ProcessTerminateEvent VisaRejectedEndProcess {
			get {
				return _visaRejectedEndProcess ?? (_visaRejectedEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "VisaRejectedEndProcess",
					SchemaElementUId = new Guid("cdb279c0-a2b0-4dca-8f8b-c4201c2e2a8a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private IntermediateCatchSignalEvent3FlowElement _intermediateCatchSignalEvent3;
		public IntermediateCatchSignalEvent3FlowElement IntermediateCatchSignalEvent3 {
			get {
				return _intermediateCatchSignalEvent3 ?? ((_intermediateCatchSignalEvent3) = new IntermediateCatchSignalEvent3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask5;
		public ProcessScriptTask FormulaTask5 {
			get {
				return _formulaTask5 ?? (_formulaTask5 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask5",
					SchemaElementUId = new Guid("fb598c27-623f-45e8-a356-973c10f8c81e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask5Execute,
				});
			}
		}

		private ProcessTerminateEvent _visaCanceledEndProcess;
		public ProcessTerminateEvent VisaCanceledEndProcess {
			get {
				return _visaCanceledEndProcess ?? (_visaCanceledEndProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "VisaCanceledEndProcess",
					SchemaElementUId = new Guid("0bb38633-49c6-4537-a858-4d3cf3ad4e21"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("e24b4502-eda7-4443-bab4-eab12e044974"),
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
					SchemaElementUId = new Guid("c4ebf13f-3b7a-4280-88b0-b0585f1b8c72"),
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
					SchemaElementUId = new Guid("6b6fcea0-ef81-4fa0-bbcc-711ae6b9a4f1"),
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
			FlowElements[StartProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartProcess };
			FlowElements[ErrorEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ErrorEndProcess };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[AlreadyExistsVisaEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AlreadyExistsVisaEndProcess };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[VisaEventGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaEventGateway };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[IntermediateCatchSignalEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignalEvent1 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[VisaApprovedEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaApprovedEndProcess };
			FlowElements[IntermediateCatchSignalEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignalEvent2 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
			FlowElements[VisaRejectedEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaRejectedEndProcess };
			FlowElements[IntermediateCatchSignalEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignalEvent3 };
			FlowElements[FormulaTask5.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask5 };
			FlowElements[VisaCanceledEndProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { VisaCanceledEndProcess };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ErrorEndProcess":
						CompleteProcess();
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ErrorEndProcess", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AlreadyExistsVisaEndProcess", e.Context.SenderName));
						break;
					case "AlreadyExistsVisaEndProcess":
						CompleteProcess();
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "VisaEventGateway":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignalEvent1", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignalEvent2", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignalEvent3", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaEventGateway", e.Context.SenderName));
						break;
					case "IntermediateCatchSignalEvent1":
						VisaEventGateway.CancelNonexecutedEvents("IntermediateCatchSignalEvent1");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaApprovedEndProcess", e.Context.SenderName));
						break;
					case "VisaApprovedEndProcess":
						CompleteProcess();
						break;
					case "IntermediateCatchSignalEvent2":
						VisaEventGateway.CancelNonexecutedEvents("IntermediateCatchSignalEvent2");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaRejectedEndProcess", e.Context.SenderName));
						break;
					case "VisaRejectedEndProcess":
						CompleteProcess();
						break;
					case "IntermediateCatchSignalEvent3":
						VisaEventGateway.CancelNonexecutedEvents("IntermediateCatchSignalEvent3");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask5", e.Context.SenderName));
						break;
					case "FormulaTask5":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("VisaCanceledEndProcess", e.Context.SenderName));
						break;
					case "VisaCanceledEndProcess":
						CompleteProcess();
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((VisaOwner) == null || (Order) == null);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalFlow1", "(VisaOwner) == null || (Order) == null", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((IsPreviousVisaCounts));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalFlow2", "(IsPreviousVisaCounts)", result);
			return result;
		}

		private bool ConditionalFlow3ExpressionExecute() {
			bool result = Convert.ToBoolean((ReadDataUserTask1.ResultCount) > 0
);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow3", "(ReadDataUserTask1.ResultCount) > 0\n", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("Order")) {
				writer.WriteValue("Order", Order, Guid.Empty);
			}
			if (!HasMapping("VisaOwner")) {
				writer.WriteValue("VisaOwner", VisaOwner, Guid.Empty);
			}
			if (!HasMapping("VisaObjective")) {
				writer.WriteValue("VisaObjective", VisaObjective, null);
			}
			if (!HasMapping("VisaResult")) {
				writer.WriteValue("VisaResult", VisaResult, null);
			}
			if (!HasMapping("IsAllowedToDelegate")) {
				writer.WriteValue("IsAllowedToDelegate", IsAllowedToDelegate, false);
			}
			if (!HasMapping("IsPreviousVisaCounts")) {
				writer.WriteValue("IsPreviousVisaCounts", IsPreviousVisaCounts, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartProcess", string.Empty));
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
			MetaPathParameterValues.Add("d61a0989-8779-4783-b113-deb50cf15b47", () => Order);
			MetaPathParameterValues.Add("9083bea5-93b0-4bc9-8a38-0da7a8890273", () => VisaOwner);
			MetaPathParameterValues.Add("a7d20fb9-d1a3-4f6c-8cc6-b6e88a8c4343", () => VisaObjective);
			MetaPathParameterValues.Add("31a29f35-3211-4fc9-a634-b719a4bcbe4f", () => VisaResult);
			MetaPathParameterValues.Add("ab166058-c417-46eb-98a4-67cb25768bed", () => IsAllowedToDelegate);
			MetaPathParameterValues.Add("7a369c26-a919-430e-9fcc-b7dbd03e82cc", () => IsPreviousVisaCounts);
			MetaPathParameterValues.Add("04f4034b-c6d8-4043-81ff-11c4f91ff61f", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("e666ae4f-cd81-441a-9f61-c2de41eb84f2", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("0eedbcbc-25ab-494a-bbeb-e21d15d3be92", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("382fa627-a8e0-4d33-862f-361c9d9220da", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("3c107cd1-2016-4d0e-b57d-815d74cd3861", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("0ca6bb93-a18e-49e0-ac02-7b6f8cdb0549", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("614e748d-e9f4-4f3b-bdc4-35ee7dcb1b74", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("15145695-748a-430e-b902-b281b552c89f", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("b3e85650-29fb-4199-af80-4eaf98698a27", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("31a4ff18-1803-4d14-8843-1882f4aebc11", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("12fa2c87-6548-4026-a641-3939fadc4b42", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("e8720629-f6ec-43e7-8a7b-2c24630badb3", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("c003ab55-826d-4b64-9e5f-8804a5848b21", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("0ef917e9-7826-4a02-b4bd-171856e1ef12", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("4ece07e9-a9db-4a55-87b9-48e11c9ff7e5", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("4b15cb40-0f50-4078-a24f-a5956fc6b157", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3785519b-3fe4-434c-86da-2b81ae73e599", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("994245a7-9a7c-4cd9-b698-f14815f3db28", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("76f35d3a-cef1-4876-a692-ff20200917cf", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("1404379d-a79a-4596-893d-7c620dfd8caf", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("55ef8b53-d3cc-43e6-b2cb-7bf702d94f72", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("e99d85dc-8cbe-4f1e-ba54-7c57ddf21953", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("cb208bfe-de96-49f6-81bc-f82ec1afd252", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("8aad1115-eaba-4c12-98ce-a8b0ae405981", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("9df5d5d0-f073-472c-859b-f5e3b67221ea", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("443af2ec-aeea-4cc0-886a-e903dd5eefa7", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("d0252b09-da98-4d4e-9dc0-ef8bb6f92f23", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("48aec832-cd69-4509-a9b4-abd75a914dc6", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("70f3c8ce-16ff-40fc-8eda-5a3419a1ec22", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("fbb5cec9-6a5b-44ae-829a-1f19c78d0339", () => IntermediateCatchSignalEvent1.RecordId);
			MetaPathParameterValues.Add("2baee59c-8079-46b4-8f24-2a77f99b38b2", () => IntermediateCatchSignalEvent2.RecordId);
			MetaPathParameterValues.Add("dbcabc88-7940-493a-9211-1d7ef9018176", () => IntermediateCatchSignalEvent3.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "Order":
					if (!hasValueToRead) break;
					Order = reader.GetValue<System.Guid>();
				break;
				case "VisaOwner":
					if (!hasValueToRead) break;
					VisaOwner = reader.GetValue<System.Guid>();
				break;
				case "VisaObjective":
					if (!hasValueToRead) break;
					VisaObjective = reader.GetValue<System.String>();
				break;
				case "VisaResult":
					if (!hasValueToRead) break;
					VisaResult = reader.GetValue<System.String>();
				break;
				case "IsAllowedToDelegate":
					if (!hasValueToRead) break;
					IsAllowedToDelegate = reader.GetValue<System.Boolean>();
				break;
				case "IsPreviousVisaCounts":
					if (!hasValueToRead) break;
					IsPreviousVisaCounts = reader.GetValue<System.Boolean>();
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
			var localVisaResult = "Error";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localVisaResult = "Approved";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localVisaResult = "Approved";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localVisaResult = "Rejected";
			VisaResult = (System.String)localVisaResult;
			return true;
		}

		public virtual bool FormulaTask5Execute(ProcessExecutingContext context) {
			var localVisaResult = "Canceled";
			VisaResult = (System.String)localVisaResult;
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
			var cloneItem = (OrderVisaBaseSubprocess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

