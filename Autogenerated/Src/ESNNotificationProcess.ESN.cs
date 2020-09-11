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
	using Terrasoft.Messaging.Common;

	#region Class: ESNNotificationProcessSchema

	/// <exclude/>
	public class ESNNotificationProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ESNNotificationProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ESNNotificationProcessSchema(ESNNotificationProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ESNNotificationProcess";
			UId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
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
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			Version = 0;
			PackageUId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateNotificationIdParameterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"NotificationIdParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNotificationIdParameterParameter());
		}

		protected virtual void InitializeOnPostCommentedStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d70075ca-9e0b-44df-a779-e59e0e2f85b4"),
				ContainerUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
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
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f478e43-a126-41ef-bd27-886141b52843"),
				ContainerUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"b0e78c23-7095-4d59-b8eb-c10243bcd67b",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadCommentedPostUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba9ba9d2-475d-40f2-8404-7ac59bcee891"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,208,131,162,36,223,138,212,45,114,104,19,52,65,46,113,14,43,114,169,16,213,11,20,157,214,53,252,239,93,74,142,235,20,46,226,246,210,2,213,73,28,12,135,179,207,77,32,107,24,134,143,208,96,48,15,110,209,90,24,58,237,206,223,153,218,161,125,111,187,85,31,156,5,3,90,3,181,249,134,106,194,23,202,184,183,224,128,174,108,150,63,20,150,193,124,121,92,99,25,156,45,3,227,176,25,136,67,87,210,52,73,242,52,83,44,141,57,103,28,64,178,82,101,130,9,85,8,17,73,45,203,40,155,152,191,18,191,232,154,30,44,78,111,140,242,122,252,189,93,247,158,26,17,32,71,138,25,186,118,7,38,222,196,176,104,161,172,81,209,217,217,21,18,228,172,105,40,26,188,53,13,94,131,165,183,188,78,231,33,34,105,168,7,207,170,81,187,197,215,222,226,48,152,174,125,205,92,189,106,218,67,54,9,224,254,184,179,19,142,30,61,243,26,220,227,40,113,73,182,182,163,203,55,85,101,177,2,103,158,14,77,124,198,245,200,59,45,127,116,65,81,149,238,160,94,225,193,155,47,35,185,128,222,77,1,77,207,19,193,154,234,241,228,88,247,25,123,45,220,152,192,254,153,124,162,230,209,24,98,65,224,147,7,38,149,231,223,101,112,127,57,92,125,105,209,222,200,71,108,96,202,218,195,57,161,63,1,139,26,27,108,221,124,163,5,143,64,114,201,210,50,79,40,143,49,176,50,202,115,6,88,132,121,25,166,73,26,234,45,93,216,27,154,111,226,72,114,93,20,156,149,144,229,140,115,129,140,78,49,83,34,215,113,24,37,69,46,18,127,101,209,58,227,214,83,39,204,55,10,99,30,138,92,176,164,212,49,227,89,90,176,82,104,201,114,204,211,162,12,203,56,149,114,251,48,133,107,134,190,134,245,221,62,170,79,8,106,70,205,236,45,207,124,50,104,178,236,224,102,126,158,102,157,158,81,154,87,181,51,109,69,164,186,70,233,203,233,83,232,233,13,149,0,42,28,133,125,117,73,78,133,168,121,200,129,101,162,84,140,23,81,204,242,76,132,228,76,73,206,11,1,73,24,81,23,250,207,55,75,87,25,9,245,85,143,22,118,125,18,30,31,163,23,243,231,75,100,187,206,77,137,223,151,248,166,147,180,72,62,28,152,122,238,104,17,203,60,17,89,194,84,152,166,140,71,25,48,16,60,101,82,42,42,139,78,35,21,83,71,111,105,25,249,12,220,116,43,43,119,195,63,76,91,232,143,182,203,95,216,25,191,179,6,142,14,226,41,131,245,159,141,204,191,215,217,219,96,251,29,100,60,254,6,91,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9a60810c-41d3-474d-908b-832435849593"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("56642892-05c7-42ae-8a57-ac21482d70bb"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c54e3ed-b510-44aa-95e8-d5869d6647b7"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3ea11d01-ccd4-45c3-9644-14df37bc5ce0"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd3d7954-cc74-4986-a523-d221d7761c23"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("92450397-12f0-4f17-a75d-d38567c6327b"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("5a1f2b83-ed26-4c92-8480-206a321e9963"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e4064fd-64ed-4abc-8260-c6a14fb6a6c5"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fd53a939-0d8c-44b8-9ef1-fc1e8c5694e4"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("d146f3f2-4cb7-4239-92bf-c9081aa150f5"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4508d2c7-78c9-422c-977e-5f7441f0ef76"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("0cc7df16-22da-417e-b78a-80ea545febad"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("15a46e90-2180-4324-bb5b-dcb14fbe07ee"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("720d957d-e275-469f-8956-e925ee0c382a"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d7c50aae-200a-41d3-8177-d3acea16b585"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9702aa85-1629-4ea9-8aa4-2753d1f1692e"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("6a3574e7-1c32-41ba-9a16-e9ed315eef65"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f2c99b37-6016-4f45-af48-6e6f1c684e46"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeAddCommentNotificationUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("d2f54b5a-bf50-4842-a4f0-4d72ad23d06c"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
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
				Value = @"104d30b1-458a-49b9-8464-aef17d78b411",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7f07f8e3-92dd-4b85-b1a9-b8d1a524e5d5"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9abee62b-56b1-4c28-93ae-c885bfff3a39"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("a806be87-94ba-47b4-9129-331e6d19c0a5"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8bbeac4-174d-4926-9467-5e78622c517a"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,219,110,219,70,16,134,95,69,96,114,233,17,246,124,208,109,226,2,6,156,212,136,211,220,216,190,216,195,108,34,148,34,13,146,106,225,10,122,247,14,105,201,167,182,138,139,54,5,130,154,23,18,185,218,127,118,118,248,253,154,221,84,175,135,155,107,172,22,213,71,236,186,208,183,101,152,191,105,59,156,159,117,109,194,190,159,159,182,41,212,203,223,66,172,241,44,116,97,133,3,118,159,66,189,198,254,116,217,15,71,179,199,178,234,168,122,253,203,244,107,181,184,216,84,39,3,174,126,58,201,20,61,88,244,154,75,6,204,185,12,42,38,13,161,40,15,33,34,227,129,25,175,188,36,113,106,235,245,170,121,135,67,56,11,195,151,106,177,169,166,104,20,32,210,12,205,147,135,24,72,171,68,96,224,147,229,96,76,146,86,24,33,116,177,213,246,168,234,211,23,92,133,105,209,123,49,103,42,75,22,57,40,237,2,40,31,61,56,101,20,4,44,220,102,235,162,226,124,20,239,230,223,11,47,94,93,156,244,63,254,218,96,119,62,197,93,148,80,247,120,53,167,209,39,3,199,53,174,176,25,22,27,143,197,121,155,16,148,44,5,148,21,25,124,182,26,132,15,78,39,33,145,123,220,146,224,174,154,139,141,14,188,136,232,36,96,22,6,84,242,130,210,115,12,4,51,65,10,142,222,27,57,74,142,155,97,57,220,188,153,106,180,216,96,44,38,70,47,193,133,64,170,192,56,120,198,50,36,131,193,216,80,10,10,190,189,122,117,53,110,44,47,251,235,58,220,124,250,227,254,62,96,200,179,212,174,198,228,49,207,174,219,126,152,229,48,132,249,15,203,142,110,151,244,6,103,109,153,117,216,175,235,97,217,124,166,185,117,141,105,88,182,13,189,241,102,8,105,184,93,226,250,17,29,15,23,217,92,222,66,118,89,45,46,255,10,179,221,247,109,81,31,131,246,148,177,203,234,232,178,58,111,215,93,26,35,74,122,120,251,96,119,211,34,211,148,39,143,123,168,104,164,89,215,245,110,228,45,109,117,63,113,63,220,230,101,89,98,62,105,206,247,44,77,81,216,238,130,63,249,216,95,183,185,253,19,217,187,208,132,207,216,189,167,2,220,231,126,151,229,71,42,227,62,112,20,94,51,203,11,88,12,30,20,26,162,38,243,0,158,251,88,164,149,162,20,49,169,63,96,193,14,155,132,143,19,227,38,162,52,154,131,35,82,64,113,77,166,200,153,65,112,76,102,101,156,204,89,238,244,253,84,237,209,205,187,188,198,82,109,171,237,246,232,161,199,147,35,95,75,69,64,154,146,70,139,42,240,6,29,72,180,89,138,236,130,203,225,160,199,179,53,86,161,36,25,35,115,42,33,44,196,228,34,88,175,181,35,127,140,57,254,251,30,159,28,124,200,36,119,19,94,16,255,143,17,247,44,26,29,139,3,86,70,162,184,34,88,173,245,32,148,96,116,19,138,103,246,16,226,207,78,236,185,136,7,83,148,229,6,129,39,36,200,56,253,195,59,102,9,83,84,204,161,206,2,19,59,136,184,83,42,105,178,29,216,146,45,5,72,22,28,207,25,52,129,239,162,101,73,233,242,45,218,216,105,219,254,188,190,158,107,150,82,116,206,65,80,138,186,104,198,8,94,231,49,160,72,158,92,155,189,83,115,193,208,100,148,26,200,115,212,88,172,46,180,191,236,65,26,110,156,51,92,37,99,190,214,86,118,235,29,159,191,159,53,237,64,176,165,48,182,140,217,104,146,249,125,187,161,145,27,42,252,212,118,94,218,200,119,217,70,158,131,212,223,242,152,207,202,170,28,51,216,172,169,11,208,153,136,114,145,148,149,86,148,43,55,197,71,119,208,99,200,121,14,81,145,67,24,29,56,21,227,138,248,149,28,44,179,140,37,89,56,47,238,255,117,84,12,200,80,233,20,32,209,33,26,84,65,11,65,250,12,50,68,43,172,67,110,184,253,182,71,197,147,252,98,239,239,210,222,145,161,117,196,34,185,103,68,39,211,41,49,58,242,120,226,76,40,25,83,54,54,126,205,222,87,219,223,1,44,76,134,219,103,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f640e209-6e76-4601-93eb-8e3eda7f8505"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
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

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b16c2a23-8fa1-410c-8bf0-9ded1dcbf5b3"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,110,219,48,16,252,149,64,231,208,16,37,74,34,125,43,82,183,200,161,73,208,4,185,196,57,144,212,202,33,42,153,2,73,39,77,13,255,123,151,146,227,58,133,139,184,189,180,245,197,210,96,118,118,246,165,117,162,91,233,253,133,236,32,153,38,55,224,156,244,182,9,147,15,166,13,224,62,58,187,234,147,211,196,131,51,178,53,223,160,30,241,89,109,194,123,25,36,134,172,231,63,20,230,201,116,126,88,99,158,156,206,19,19,160,243,200,193,144,162,76,43,197,105,65,184,202,51,194,184,162,132,11,166,8,112,1,160,160,100,156,177,145,249,43,241,51,219,245,210,193,152,99,144,111,134,199,155,231,62,82,41,2,122,160,24,111,151,91,48,143,38,252,108,41,85,11,53,190,7,183,2,132,130,51,29,86,3,55,166,131,43,233,48,87,212,177,17,66,82,35,91,31,89,45,52,97,246,181,119,224,189,177,203,183,204,181,171,110,185,207,70,1,216,189,110,237,164,131,199,200,188,146,225,97,144,56,71,91,155,193,229,187,197,194,193,66,6,243,184,111,226,11,60,15,188,227,250,135,1,53,78,233,86,182,43,216,203,249,186,146,51,217,135,177,160,49,61,18,156,89,60,28,93,235,174,99,111,149,155,33,216,191,144,143,212,60,88,67,86,34,248,24,129,81,229,229,113,158,220,157,251,203,167,37,184,107,253,0,157,28,187,118,63,65,244,39,96,214,66,7,203,48,93,167,188,97,180,22,130,8,158,115,194,40,151,68,21,149,32,178,162,85,149,85,89,145,150,106,131,1,59,67,211,117,93,165,105,85,104,73,4,164,138,48,86,55,200,198,16,40,16,128,172,225,133,98,155,251,209,184,241,125,43,159,111,119,254,46,224,233,4,183,50,230,62,233,173,15,80,79,62,131,182,174,222,54,62,254,33,45,207,25,175,181,206,8,173,21,186,226,50,35,130,213,26,167,203,53,173,120,33,10,174,113,79,226,47,142,211,46,140,150,237,101,15,78,110,39,153,30,94,244,87,23,18,155,232,172,13,99,107,118,67,184,182,26,79,253,19,78,78,46,96,48,245,178,115,74,83,42,152,174,136,20,180,33,76,151,138,240,76,48,162,83,85,230,185,200,74,74,51,116,133,159,139,56,176,107,187,114,122,123,158,126,252,78,252,209,253,255,133,171,254,157,67,61,120,42,199,172,254,127,187,212,255,222,142,110,146,205,119,175,169,228,159,199,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("310495bd-78ef-46e8-bd4f-08a98a050897"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb3ef4f3-9764-4095-a7f4-5e41a35ac0ac"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("54c3435c-6332-48a2-a3e3-e3146231388c"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("48f7c6e0-02c8-4675-80b8-8367b0ef9190"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d5e71c2a-4e7a-4bbc-8424-96fac9c00de2"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("062d7511-3234-4dc6-98d1-9a2bd134a872"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,113,46,74,77,44,73,77,113,170,4,243,60,83,64,20,0,81,116,18,230,43,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("21c4f994-ba78-446e-9942-d68f20139863"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("66e87786-c605-4fec-b02e-830988bb2e7d"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a122acd7-cc81-49fd-8c39-9aab1b9c747c"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("677eaf70-16e1-4664-bae1-944189695e0b"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f8162883-d725-4f4b-b85f-218697d31396"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fc9471e4-6058-424b-acd0-8b0ae601c0c6"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e98494ea-7338-4c9a-b507-c8b3dc9be58f"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("e0adb813-1f6d-4072-b83f-eafcb5ba680c"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("49fd90d6-76c8-48f2-8b16-ea83004edbda"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b833533c-49e1-4ebc-ac9f-1a911d02ccc4"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7c3db1aa-d065-4619-9e55-0615dfb22975"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fa088023-44c1-4370-afa4-5c6b45d07773"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeOnLikeAddedStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4cf7a08-cf11-4efc-aad9-78919c7c9593"),
				ContainerUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
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
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f836b77b-679f-4dfa-a647-9a7e89c1ec39"),
				ContainerUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("39c452ee-d582-4fc4-89da-188114ddf6aa"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,205,110,19,49,16,126,149,104,207,117,180,217,63,103,115,67,37,160,74,136,86,36,234,133,244,48,177,199,169,213,221,236,202,118,10,33,202,129,62,3,15,146,86,234,1,80,203,43,184,111,132,119,55,13,45,10,106,64,66,136,189,172,253,233,243,55,223,140,103,188,240,88,6,90,191,134,28,189,158,55,68,165,64,23,194,180,95,200,204,160,122,169,138,89,233,237,121,26,149,132,76,126,64,222,224,125,46,205,115,48,224,142,44,70,63,20,70,94,111,180,93,99,228,237,141,60,105,48,215,142,83,29,17,64,121,66,57,241,163,36,36,81,2,29,2,212,247,201,152,241,32,226,99,0,74,187,107,230,47,196,247,139,188,4,133,77,140,90,94,212,203,225,188,172,168,29,7,176,154,34,117,49,93,131,97,101,66,247,167,48,206,144,187,189,81,51,116,144,81,50,119,217,224,80,230,120,4,202,197,170,116,138,10,114,36,1,153,174,88,25,10,211,127,95,42,212,90,22,211,167,204,101,179,124,250,144,237,4,112,179,93,219,241,107,143,21,243,8,204,105,45,113,224,108,45,107,151,207,38,19,133,19,48,242,252,161,137,51,156,215,188,221,234,231,14,112,119,75,199,144,205,240,65,204,199,153,236,67,105,154,132,154,240,142,160,228,228,116,231,92,55,21,123,42,221,192,129,229,61,121,71,205,173,57,4,137,3,207,43,160,81,185,95,142,188,183,7,250,240,221,20,213,128,157,98,14,77,213,78,218,14,253,9,232,103,152,227,212,244,22,157,49,165,60,142,66,18,240,174,112,117,236,34,1,22,197,36,76,40,198,52,166,145,8,196,210,29,216,24,234,45,48,98,130,130,223,37,76,116,58,36,66,193,8,0,79,9,237,166,157,148,81,150,198,105,184,60,105,140,75,93,102,48,63,222,248,179,159,236,173,189,180,43,123,101,191,218,107,123,211,114,191,149,253,108,191,180,236,141,93,181,236,55,123,123,247,241,238,162,101,175,90,13,225,238,194,94,183,223,32,43,20,175,91,163,250,170,27,44,38,146,65,118,88,162,130,245,229,249,219,123,251,209,80,84,117,83,69,97,154,106,108,234,62,40,152,155,238,87,242,12,107,215,247,61,22,184,132,124,26,80,215,84,97,76,34,145,250,4,2,142,36,100,34,141,252,32,78,24,77,156,37,247,60,84,23,52,40,102,138,173,199,81,55,239,194,31,205,251,63,152,226,223,25,204,173,163,177,75,171,255,159,77,252,247,27,110,233,45,191,3,59,36,9,75,132,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab5d3b2f-e2fb-4c08-99ff-2f80f260179f"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb26905a-bd71-46d4-8d6a-d6ed38d0edde"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c33a347d-db7a-4e6a-919d-dcec7662e460"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9e247ae1-2b40-42ab-805b-c5d6096d9ba4"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a73401c-113f-4c6f-861a-7262b910e6cb"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("a2463ef1-b5d5-415d-b646-059986b3a408"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,178,50,180,50,212,113,46,74,77,44,73,77,241,207,179,50,176,50,208,9,206,79,206,76,204,241,77,45,46,78,76,79,5,139,120,166,128,40,0,3,32,50,156,47,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				UId = new Guid("d73fb076-b90d-4745-a4b2-fac13c95af7d"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("16d9166d-3ef0-42f4-8408-44ae67b0bbf8"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7375ce45-bc51-437e-87e1-eedd8eff6e54"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("fe779b3d-abd3-45e1-aeab-f8081843611c"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("41b06c6a-fc83-481d-8934-d1b75bfe8a0f"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("074acb9f-4b51-4a71-96b0-a688dc1e4df0"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("f30a6c29-f244-4a31-9102-fcea5bed4454"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				UId = new Guid("5556b314-99f0-40b0-8172-959a76296469"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("990df6b1-021b-4232-9284-f92fa22ee682"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("272ed838-6e7e-4ec3-b267-81140797856d"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("daa71dc2-1fb1-4636-bb5a-75c107201ba4"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("489232d2-1dc4-492b-a5a8-1ef8e65ac76c"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeAddLikedNotificationUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("da240fb2-c774-4c74-99fd-2e1fdfae3964"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
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
				Value = @"104d30b1-458a-49b9-8464-aef17d78b411",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17ac42d2-21e6-4d36-ba16-b249f630b24b"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e8734de8-8d7a-4251-a4ab-c545f58d718b"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("644e1f0f-142c-4e1f-8cad-d8d970d36e91"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("56e0b34b-5e15-42e9-b5c8-2bb82ace64b4"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,89,79,220,72,16,199,191,138,229,228,145,26,245,125,204,43,97,37,36,200,34,72,242,2,60,244,81,29,70,49,54,178,61,187,98,71,243,221,183,60,48,92,187,33,100,47,109,36,252,48,99,183,171,202,213,255,174,159,171,189,170,223,142,215,87,88,207,235,15,216,247,97,232,202,56,219,237,122,156,29,245,93,194,97,152,29,116,41,52,139,223,66,108,240,40,244,225,18,71,236,63,133,102,137,195,193,98,24,119,170,199,110,245,78,253,246,151,205,221,122,126,186,170,247,71,188,252,184,159,41,186,9,193,56,103,52,88,35,61,40,148,22,60,103,25,82,49,62,187,156,66,73,130,156,83,215,44,47,219,67,28,195,81,24,47,234,249,170,222,68,163,0,217,26,75,110,10,60,51,10,148,16,22,98,114,17,172,215,218,69,39,21,215,190,94,239,212,67,186,192,203,176,121,232,189,51,103,42,75,22,57,40,237,2,40,31,61,56,69,97,2,22,110,179,117,81,113,62,57,223,218,223,59,150,208,12,56,221,201,139,225,170,9,215,159,190,106,112,245,72,156,135,38,171,179,27,141,207,234,249,217,215,84,190,253,63,217,36,255,88,231,167,18,159,213,59,103,245,73,183,236,211,20,81,210,197,187,7,185,109,30,178,49,121,114,185,213,148,70,218,101,211,220,142,188,11,99,216,26,110,135,187,188,40,11,204,251,237,201,86,202,77,20,118,123,192,159,252,108,143,155,220,254,142,219,97,104,195,103,236,223,147,0,247,185,223,101,249,129,100,220,6,246,44,26,29,139,3,86,74,2,197,21,7,103,173,7,161,4,163,147,80,60,179,27,239,99,44,216,99,155,240,47,38,118,140,195,70,237,169,152,111,243,154,164,90,215,235,245,206,195,18,199,40,74,17,130,129,10,84,156,138,51,13,206,48,9,88,138,193,98,11,58,148,207,150,184,83,42,105,148,6,108,201,83,128,100,193,241,156,65,83,225,187,104,89,82,186,252,243,37,126,250,230,160,235,190,44,175,102,154,165,20,157,115,16,148,210,160,50,70,240,58,79,1,69,242,166,164,236,157,154,169,88,178,112,66,67,178,129,56,230,82,66,244,30,129,101,19,101,142,49,40,205,223,156,63,71,204,221,243,246,78,222,87,109,55,82,177,165,48,46,186,182,154,32,153,53,139,47,152,171,107,82,188,186,234,134,241,38,214,43,92,255,49,92,81,120,205,44,47,96,113,90,102,52,2,92,230,129,222,217,62,22,105,229,84,233,207,193,245,146,90,250,46,184,34,11,76,88,154,26,122,69,180,59,145,32,114,142,144,165,84,204,163,85,33,170,103,225,66,206,51,217,16,26,76,18,162,140,43,136,40,57,88,70,81,147,44,156,23,247,111,192,117,186,63,252,252,107,139,253,141,62,243,77,191,56,159,209,232,147,129,189,6,47,177,29,231,43,95,74,212,33,41,72,89,83,163,155,166,235,163,200,128,90,4,141,65,89,149,253,154,28,238,10,121,190,202,86,150,200,172,33,20,169,165,146,133,38,221,163,128,18,18,151,201,235,80,108,158,92,246,218,113,49,94,239,110,52,154,175,92,50,70,49,82,68,82,79,38,148,109,4,231,147,1,180,89,83,187,166,243,44,215,231,223,130,249,24,67,174,198,11,172,38,112,171,76,197,52,251,105,209,15,99,181,160,181,171,186,82,245,56,44,155,113,209,126,174,104,113,26,76,19,234,179,67,226,145,74,241,149,238,31,146,238,200,208,186,36,36,193,227,39,186,181,135,232,8,241,196,153,80,50,166,108,108,252,46,186,93,38,154,60,21,185,207,150,32,11,174,80,192,105,179,24,2,138,192,152,241,194,63,75,119,244,202,107,158,40,143,144,40,35,242,1,159,40,148,49,73,90,97,132,208,197,254,47,232,78,82,242,92,98,6,150,72,117,21,117,6,87,60,77,55,24,35,73,214,34,114,126,66,183,147,66,59,203,61,189,16,44,165,167,105,201,162,64,4,73,115,246,65,6,195,184,252,35,221,24,139,137,209,75,112,180,243,38,73,25,167,157,243,180,225,54,24,12,237,142,10,10,254,66,186,111,90,242,212,141,95,204,247,110,215,142,33,189,118,239,31,147,111,110,168,53,26,77,27,106,170,18,152,190,172,200,63,51,8,142,73,34,213,201,156,229,183,248,62,95,255,14,154,213,88,85,91,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8010ef15-aad8-4dba-850c-692c850d65b9"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
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

		protected virtual void InitializeReadLikedPostUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb823b89-4655-4e40-9e5c-0e10daf24deb"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,144,37,234,229,91,145,186,69,14,109,130,38,200,165,206,97,69,46,101,34,212,3,20,157,214,53,252,239,93,74,182,235,20,46,226,246,210,2,213,137,26,12,135,179,207,77,32,12,244,253,71,168,49,152,5,247,104,45,244,173,114,151,239,180,113,104,223,219,118,213,5,23,65,143,86,131,209,223,80,142,248,92,106,247,22,28,208,149,205,226,135,194,34,152,45,78,107,44,130,139,69,160,29,214,61,113,232,10,202,44,70,16,9,203,83,16,140,135,113,198,160,76,50,22,35,79,99,84,81,50,141,162,145,249,43,241,171,182,238,192,226,248,198,32,175,134,227,253,186,243,212,41,1,98,160,232,190,109,118,96,236,77,244,243,6,74,131,146,254,157,93,33,65,206,234,154,162,193,123,93,227,45,88,122,203,235,180,30,34,146,2,211,123,150,65,229,230,95,59,139,125,175,219,230,53,115,102,85,55,199,108,18,192,195,239,206,78,56,120,244,204,91,112,203,65,226,154,108,109,7,151,111,170,202,98,5,78,63,31,155,120,194,245,192,59,47,127,116,65,82,149,30,192,172,240,232,205,151,145,92,65,231,198,128,198,231,137,96,117,181,60,59,214,67,198,94,11,55,34,176,219,147,207,212,60,25,67,148,18,248,236,129,81,101,127,92,4,159,175,251,155,47,13,218,59,177,196,26,198,172,61,94,18,250,19,48,55,88,99,227,102,155,66,169,50,1,193,153,144,9,103,188,224,130,21,101,36,25,38,17,36,8,60,227,178,216,210,133,131,161,217,134,50,175,202,48,75,89,89,132,146,17,35,97,192,203,136,41,16,211,88,20,9,168,76,250,43,243,198,105,183,30,59,97,182,201,69,154,242,144,3,139,179,52,102,124,154,149,44,47,68,202,48,147,73,10,64,103,25,111,31,199,112,117,223,25,88,63,28,162,250,132,32,39,110,137,19,163,159,112,226,179,65,163,101,123,55,241,3,53,105,213,132,242,188,50,78,55,213,132,218,201,160,240,245,188,252,64,201,135,10,7,73,95,87,18,74,194,28,48,43,20,203,212,52,103,60,14,51,86,96,2,44,229,17,231,17,134,42,242,99,177,245,159,111,147,182,210,2,204,77,135,22,118,29,18,158,30,160,23,147,231,139,99,219,214,141,41,63,20,247,174,21,180,66,142,77,237,123,89,198,146,115,30,78,25,151,121,196,120,34,11,6,113,153,176,130,151,89,90,100,178,20,42,39,87,180,134,124,232,119,237,202,138,221,216,247,227,254,249,163,189,242,23,182,197,239,44,128,147,35,120,206,72,253,103,195,242,239,117,246,54,216,126,7,244,220,118,151,85,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df4038dc-6372-4684-8eec-b443a51b08be"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b90f1d0e-459b-4ff2-84b9-84bdd7ae294d"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55f43d53-adf7-49ba-b7fc-3fdfc2fb2ef5"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be6e2286-7b11-4750-807e-4ce55e79daca"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e88fd04-f4da-40e3-b8c4-35afe197eb57"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8e49b308-b01a-4375-803d-4e3f3770a686"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("83258719-cd7a-45a9-b2ee-39499a3a6013"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c164263e-1a79-4940-9a57-e2dccc8fa7a0"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("eec87964-39ad-40af-a379-61083fb27433"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("c2061afa-5a06-4890-9015-495796290789"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("56e6c97a-488f-4add-9847-e81524046833"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("8e5240fe-f6fb-4a6b-9ab0-214fcca33c93"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ef6b4042-e216-4b4f-a5ee-db4fe2678424"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("8c09f3bd-485d-4bc4-8868-7ed8fdc1494b"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3001471f-45f4-4b10-bb93-e968de3645f2"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e2be980a-5e5d-46f0-b248-73fd2d5c1967"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("7eced334-87e9-445d-b4fc-c349d0303875"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4e2a3f16-2ed0-4300-85ef-3daad88e98d6"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("985f26f9-02d6-49a5-afcc-1da4c66649df"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,115,211,48,16,253,43,29,159,171,142,109,201,118,156,27,83,2,211,3,180,67,75,47,164,135,149,180,74,53,216,177,71,82,10,37,147,255,206,202,78,66,203,132,105,224,2,248,98,251,205,211,219,183,95,90,39,170,1,239,223,67,139,201,52,185,65,231,192,119,38,156,189,177,77,64,247,214,117,171,62,57,77,60,58,11,141,253,134,122,196,103,218,134,215,16,128,142,172,231,63,20,230,201,116,126,88,99,158,156,206,19,27,176,245,196,161,35,82,114,201,203,26,152,202,114,195,4,47,74,86,215,233,132,113,33,56,55,92,9,94,195,200,252,149,248,121,215,246,224,112,140,49,200,155,225,243,230,177,143,212,140,0,53,80,172,239,150,91,144,71,19,126,182,4,217,160,166,255,224,86,72,80,112,182,165,108,240,198,182,120,5,142,98,69,157,46,66,68,50,208,248,200,106,208,132,217,215,222,161,247,182,91,190,100,174,89,181,203,167,108,18,192,253,239,214,78,58,120,140,204,43,8,247,131,196,5,217,218,12,46,95,45,22,14,23,16,236,195,83,19,159,241,113,224,29,87,63,58,160,169,75,183,208,172,240,73,204,231,153,156,67,31,198,132,198,240,68,112,118,113,127,116,174,251,138,189,148,110,78,96,191,35,31,169,121,48,135,188,36,240,33,2,163,202,238,115,158,124,186,240,151,95,150,232,174,213,61,182,48,86,237,238,140,208,159,128,89,131,45,46,195,116,61,41,106,35,141,17,44,211,90,49,145,101,130,129,212,57,43,32,173,243,138,163,49,121,181,161,3,123,67,211,181,74,203,10,120,109,88,134,19,42,189,40,12,131,156,215,12,69,10,169,50,40,50,81,110,238,70,227,214,247,13,60,222,238,253,125,164,69,58,137,145,169,42,39,160,53,234,179,15,168,58,167,183,133,143,47,162,41,52,19,37,132,98,192,75,205,132,225,37,155,20,121,206,68,133,144,73,172,121,33,21,205,73,124,98,59,187,133,85,208,92,246,232,96,219,201,244,240,160,63,219,144,88,68,215,117,97,44,205,190,9,215,157,162,85,127,55,122,28,76,237,102,110,194,43,46,164,41,89,201,43,96,2,101,193,100,165,51,150,167,26,50,204,101,38,85,69,174,232,186,136,13,187,238,86,78,109,215,211,143,247,196,31,237,255,95,216,234,223,89,212,131,171,114,204,232,255,183,67,253,239,205,232,38,217,124,7,148,77,44,171,199,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("14407ed4-7b93-4bb0-8947-61bee5163314"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4825dd82-7b93-46dc-930d-b83505b1dfac"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8dbf8aa1-5f3b-4120-a9f7-2ce998b5271d"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97994f7a-bac7-48f6-b00e-124a48fb410b"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4410d85f-c656-4d35-8868-6b0cf395c87f"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("cd03c654-a7de-4ffc-89fa-6c63a3c8eb4e"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,176,50,212,9,206,79,206,76,204,241,77,45,46,78,76,79,5,138,24,232,120,166,128,40,0,102,106,230,161,38,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"),
				UId = new Guid("d92065a7-8e79-43e7-9061-f16b60b4846f"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("152ec142-0c82-4d70-a402-a52fef871f70"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("b2c24b55-7356-45da-b7fa-06d890b61f98"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("1533582a-753c-4ea4-a4b7-fbee9273241e"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4d80d870-a1ef-4838-819a-2b0dfb2ceee5"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("379f0ed1-624c-4682-bc40-71ebf792b7c5"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("264b43ca-f583-4d03-9225-6c4c86add08b"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"),
				UId = new Guid("5965ef63-7801-4c91-9a41-a15ad70a5605"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("838e5c55-a218-4d7e-8db5-2a2360539a1e"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9af0e793-7b1b-40b6-b726-89e6b53d8b6b"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("5bd1a28f-6eb3-4163-9ad0-e598003c1907"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("e9dd48c5-c7fe-46e1-b496-5b5dae63c6ee"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeOnMentionAddedStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c067a39f-1e8f-445f-a239-e40a0cfe4146"),
				ContainerUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
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
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50d03153-866c-49a1-b09f-f3572ef11b73"),
				ContainerUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"99ab74f3-cdbf-4054-83d8-96c433f423fe",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("242ce24d-3ddd-45ff-9b66-b7ca7b504cbc"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,77,111,219,48,12,253,43,129,207,85,33,91,178,108,231,54,116,217,208,195,214,98,45,122,105,122,144,101,202,21,230,47,72,74,183,44,200,127,31,101,167,89,58,100,104,182,203,6,204,39,153,120,124,122,124,36,181,137,84,35,157,251,40,91,136,230,209,45,88,43,93,175,253,249,59,211,120,176,239,109,191,26,162,179,200,129,53,178,49,223,160,154,226,139,202,248,183,210,75,76,217,44,127,48,44,163,249,242,56,199,50,58,91,70,198,67,235,16,131,41,52,206,170,56,203,74,82,229,188,36,156,166,140,20,185,16,132,197,105,197,132,46,69,66,139,9,249,43,242,139,190,29,164,133,233,142,145,94,143,199,219,245,16,160,49,6,212,8,49,174,239,118,65,22,68,184,69,39,203,6,42,252,247,118,5,24,242,214,180,88,13,220,154,22,174,165,197,187,2,79,31,66,8,210,178,113,1,213,128,246,139,175,131,5,231,76,223,189,38,174,89,181,221,33,26,9,96,255,187,147,67,71,141,1,121,45,253,227,72,113,137,178,182,163,202,55,117,109,161,150,222,60,29,138,248,12,235,17,119,154,127,152,80,97,151,238,100,179,130,131,59,95,86,114,33,7,63,21,52,93,143,0,107,234,199,147,107,221,59,246,90,185,9,6,135,103,240,137,156,71,107,72,4,6,159,66,96,98,121,62,46,163,251,75,119,245,165,3,123,163,30,161,149,147,107,15,231,24,253,41,176,104,160,133,206,207,55,130,209,36,214,52,33,32,84,65,184,80,9,201,99,90,18,41,53,231,37,205,179,92,149,91,76,216,11,154,111,170,34,161,34,149,25,201,33,195,20,6,25,41,168,136,137,142,69,41,104,201,115,46,116,72,89,116,222,248,245,52,9,243,141,140,25,23,84,101,68,176,20,27,198,165,38,5,83,64,226,76,39,101,201,43,150,241,106,251,48,149,107,220,208,200,245,221,190,170,79,32,171,89,208,139,94,206,130,25,184,89,214,249,89,216,167,89,175,103,104,243,170,241,166,171,103,56,77,13,168,128,59,255,128,222,203,26,70,198,208,86,228,97,160,243,148,165,156,164,92,113,194,139,68,16,201,69,70,50,29,211,34,137,25,139,147,20,199,47,124,97,74,250,218,40,217,92,13,96,229,110,64,232,241,253,121,177,120,161,55,182,239,253,228,248,190,183,55,189,194,23,228,80,212,126,148,203,52,69,3,81,75,137,238,243,92,80,34,115,244,83,165,185,46,18,158,75,5,20,85,225,43,20,74,191,233,87,86,237,182,222,77,207,207,31,61,43,127,225,177,248,157,253,63,186,129,167,108,212,127,182,43,255,222,100,111,163,237,119,103,52,45,139,84,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0cd58999-5230-4ef3-a513-99389ff530c0"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99ae8ad0-6499-4567-8c65-86a56bbea68f"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4c952f0e-dffd-4986-846d-384a7af8a09a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8117a6f-4913-432b-b814-eeab6e96632d"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0dca8765-93e1-4123-8811-6ec3651653bf"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("69d9d40d-db8f-43e9-88ae-a3abf24a965a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,241,76,1,81,0,255,202,163,187,29,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("8cc5ccbc-2b9c-463a-9bab-aa349cb77cd2"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c4950dc-eb9d-4ad4-ab50-8fbb9420594b"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("290fc9b4-9025-4e3f-98b9-1747c5e4346a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("575e6cd5-8a18-469a-9cd6-55e129df411f"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("4ae0aeb5-961a-4027-9a0c-5ac3d4a5ac77"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("68d9c290-aed7-4455-8d6c-9b0597a13528"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("cb390c3d-53e0-4db5-8ba9-d854ceef7d5e"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("e177f00d-bbb5-4a71-96a5-6b3bd5c30c02"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d9a88fc-ab6e-4c1a-b52c-764cccb74f1a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ea463a5-4871-446f-af0b-1667f7dedda3"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("48bd0458-36a0-4710-9baf-d55b64ad2ab2"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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
				UId = new Guid("ad88c443-aa08-4a50-8ab0-0e7f5effc244"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
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

		protected virtual void InitializeAddMentionNotificationUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("e037ba80-32fe-4970-89b0-011247b9cfca"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
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
				Value = @"104d30b1-458a-49b9-8464-aef17d78b411",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa175d01-463f-4eaa-b6dd-6e062b0a9fbe"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("31adc4d6-d5e5-44b1-a41c-9f6561db382d"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("75b974c3-f286-497f-b22e-63339fcad82c"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
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
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4772da4a-5d0b-4678-8701-ff35ab251456"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,219,110,219,70,16,134,95,133,96,114,233,17,246,124,208,173,227,2,6,236,212,176,147,220,88,190,216,195,108,44,84,18,13,146,106,225,10,122,247,14,105,201,39,52,78,211,54,5,130,154,23,20,185,220,153,157,253,249,127,220,213,166,126,219,223,222,96,61,173,63,96,219,134,174,41,253,228,176,105,113,114,214,54,9,187,110,114,210,164,176,152,255,30,226,2,207,66,27,150,216,99,251,41,44,214,216,157,204,187,254,160,122,26,86,31,212,111,127,29,159,214,211,203,77,125,220,227,242,227,113,166,236,168,153,115,82,100,176,153,33,168,24,45,56,155,4,20,197,74,148,129,171,196,52,5,167,102,177,94,174,78,177,15,103,161,191,174,167,155,122,204,70,9,178,53,86,161,84,224,153,81,160,132,176,16,147,139,96,189,214,46,58,169,184,246,245,246,160,238,210,53,46,195,56,232,67,48,103,42,75,22,57,40,237,2,40,31,61,56,69,105,2,22,110,179,117,81,113,62,4,239,250,63,4,150,176,232,112,120,146,231,221,205,34,220,126,250,98,135,155,39,226,60,238,178,153,221,105,60,171,167,179,47,169,188,251,189,24,139,127,170,243,115,137,103,245,193,172,190,104,214,109,26,50,74,186,121,247,168,182,113,144,177,203,179,219,189,166,212,178,90,47,22,187,150,119,161,15,251,142,251,230,38,207,203,28,243,241,234,98,47,229,152,133,237,14,248,147,211,254,184,171,237,159,132,157,134,85,248,140,237,123,18,224,161,246,251,42,63,144,140,251,196,158,69,163,99,113,192,74,73,160,184,226,228,40,235,65,40,193,232,34,20,207,236,24,125,142,5,91,92,37,252,155,133,157,99,55,170,61,152,121,87,215,32,213,182,222,110,15,30,91,220,250,44,109,137,14,130,50,100,113,140,6,66,98,14,184,113,182,200,82,208,33,127,209,226,78,169,164,81,26,176,37,91,154,81,34,70,120,206,160,201,248,46,90,150,148,46,255,190,197,47,223,156,52,205,47,235,155,137,102,41,69,231,134,250,149,6,149,49,130,215,121,72,40,146,55,37,101,239,212,196,233,16,153,138,12,138,17,106,24,70,129,67,154,51,197,234,66,99,48,151,205,155,171,151,136,185,31,239,232,226,125,181,106,122,50,91,10,253,188,89,85,3,36,147,37,174,134,27,204,213,109,179,174,230,212,122,141,213,146,216,32,91,220,37,126,37,237,63,38,45,10,175,153,229,5,44,6,79,198,54,2,92,230,1,60,247,177,72,43,69,41,226,37,210,254,138,177,190,137,52,33,139,177,197,123,200,200,34,165,137,145,10,34,244,83,97,153,251,92,180,247,234,69,210,144,243,28,162,34,78,152,100,116,226,10,34,74,14,150,89,198,146,44,156,23,247,61,72,187,60,238,126,254,109,133,237,157,62,211,113,241,184,154,80,235,179,134,163,5,14,28,76,55,70,50,193,11,19,128,38,145,244,134,86,76,199,105,206,33,20,69,20,58,235,82,220,82,192,189,145,167,155,236,5,51,58,208,183,3,73,18,37,209,14,75,38,135,194,77,52,44,42,170,181,12,33,71,196,89,127,123,56,106,52,221,4,46,149,97,244,197,49,82,147,164,42,20,240,50,33,112,91,68,140,52,97,171,242,246,234,107,100,159,99,200,213,142,224,42,147,151,38,63,205,219,174,175,230,244,234,170,166,84,45,118,235,69,63,95,125,174,232,221,44,48,13,253,38,167,175,112,255,192,112,71,134,100,66,33,137,29,63,192,173,61,68,90,17,32,113,38,148,140,41,27,27,191,9,238,92,100,32,207,113,32,204,104,93,47,194,131,143,206,211,130,195,57,227,210,9,197,197,139,112,71,175,188,230,132,75,12,137,42,18,129,129,79,150,131,49,73,90,97,132,208,197,254,191,224,102,153,154,139,29,222,145,29,246,206,154,162,66,208,64,219,140,168,189,145,145,5,245,157,224,62,108,86,125,72,253,43,220,63,36,220,228,42,218,143,106,218,89,23,20,48,252,197,162,248,204,32,56,38,201,83,78,230,44,191,6,247,213,246,15,226,240,5,62,100,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d9562bc-844a-4dc6-86f8-0bfb638f3379"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaESNNotificationsLaneSet = CreateESNNotificationsLaneSetLaneSet();
			LaneSets.Add(schemaESNNotificationsLaneSet);
			ProcessSchemaLane schemaPostCommentLane = CreatePostCommentLaneLane();
			schemaESNNotificationsLaneSet.Lanes.Add(schemaPostCommentLane);
			ProcessSchemaTerminateEvent terminateprocess = CreateTerminateProcessTerminateEvent();
			FlowElements.Add(terminateprocess);
			ProcessSchemaStartSignalEvent onpostcommentedstartsignal = CreateOnPostCommentedStartSignalStartSignalEvent();
			FlowElements.Add(onpostcommentedstartsignal);
			ProcessSchemaUserTask readcommentedpostusertask = CreateReadCommentedPostUserTaskUserTask();
			FlowElements.Add(readcommentedpostusertask);
			ProcessSchemaUserTask addcommentnotificationusertask = CreateAddCommentNotificationUserTaskUserTask();
			FlowElements.Add(addcommentnotificationusertask);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaStartSignalEvent onlikeaddedstartsignal = CreateOnLikeAddedStartSignalStartSignalEvent();
			FlowElements.Add(onlikeaddedstartsignal);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask addlikednotificationusertask = CreateAddLikedNotificationUserTaskUserTask();
			FlowElements.Add(addlikednotificationusertask);
			ProcessSchemaUserTask readlikedpostusertask = CreateReadLikedPostUserTaskUserTask();
			FlowElements.Add(readlikedpostusertask);
			ProcessSchemaScriptTask sendnotificationscripttask = CreateSendNotificationScriptTaskScriptTask();
			FlowElements.Add(sendnotificationscripttask);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaInclusiveGateway inclusivegateway1 = CreateInclusiveGateway1InclusiveGateway();
			FlowElements.Add(inclusivegateway1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaStartSignalEvent onmentionaddedstartsignal = CreateOnMentionAddedStartSignalStartSignalEvent();
			FlowElements.Add(onmentionaddedstartsignal);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaUserTask addmentionnotificationusertask = CreateAddMentionNotificationUserTaskUserTask();
			FlowElements.Add(addmentionnotificationusertask);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			FlowElements.Add(CreateCommentAddedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateLikeAddedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateMentionAddedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateCommentAddedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CommentAddedSequenceFlow",
				UId = new Guid("0156db7a-f82d-4ed9-a5ef-8530400fce08"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(168, 316),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b43be58a-f5cb-4c05-9b13-4b8c5b8464c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(350, 314),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateLikeAddedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "LikeAddedSequenceFlow",
				UId = new Guid("32aa6322-db45-4d67-9c50-41a911ad85c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(192, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("bfdef988-ecab-417f-91d7-9a0b65d48de3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(476, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("125e3237-d312-47eb-a932-945ac6d5edda"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(782, 216),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("7850594b-b39d-4a6f-abe8-17e96c27fc2b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(825, 242),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b31e7b6c-362c-41a5-9e34-85da4aeff8e1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c62d023f-d7a2-438c-8edc-ec8862fe1137"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(298, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("ad6782a6-6114-4142-b433-ce08d7b4364a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(294, 388),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow13",
				UId = new Guid("3644824f-fc0f-4f3a-9911-ec3d6c880567"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(803, 301),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d965760d-4fd1-46a1-b3fb-ba8ccfd6f025"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(737, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("35a7daa0-7cf9-4d50-b40b-d99484b2a4fa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(656, 234),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("7fb09131-0ba8-4de8-9bfb-5a01072bee92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(788, 194),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateMentionAddedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "MentionAddedSequenceFlow",
				UId = new Guid("57280d6b-6f93-4766-bcb4-4b19793e96b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(216, 363),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("bb7c2e57-a962-4bca-b5d6-73ab487208a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(368, 363),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("5f1ffd43-e907-4974-9701-526673cc6cdc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(527, 365),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("633c7a4b-8103-4372-9ed1-991ca224e83d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(674, 364),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("a0334895-3f8d-43e7-846a-72782b717b40"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(781, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateESNNotificationsLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaESNNotificationsLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bbb40bf8-7fa3-4cea-89cf-ea95f81755d8"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ESNNotificationsLaneSet",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaESNNotificationsLaneSet;
		}

		protected virtual ProcessSchemaLane CreatePostCommentLaneLane() {
			ProcessSchemaLane schemaPostCommentLane = new ProcessSchemaLane(this) {
				UId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bbb40bf8-7fa3-4cea-89cf-ea95f81755d8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"PostCommentLane",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaPostCommentLane;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("b31e7b6c-362c-41a5-9e34-85da4aeff8e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"TerminateProcess",
				Position = new Point(971, 212),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateOnPostCommentedStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"OnPostCommentedStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(113, 51),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeOnPostCommentedStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadCommentedPostUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadCommentedPostUserTask",
				Position = new Point(358, 37),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadCommentedPostUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddCommentNotificationUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"AddCommentNotificationUserTask",
				Position = new Point(512, 37),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddCommentNotificationUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask1",
				Position = new Point(204, 37),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateOnLikeAddedStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"OnLikeAddedStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(113, 212),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeOnLikeAddedStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask2",
				Position = new Point(204, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddLikedNotificationUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"AddLikedNotificationUserTask",
				Position = new Point(512, 198),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddLikedNotificationUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLikedPostUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadLikedPostUserTask",
				Position = new Point(358, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLikedPostUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendNotificationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"SendNotificationScriptTask",
				Position = new Point(871, 198),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,89,109,111,219,54,16,254,156,2,251,15,154,63,73,128,32,116,109,247,165,107,50,56,110,210,121,91,211,172,78,58,96,77,81,168,18,157,112,208,139,43,82,201,188,192,255,125,119,36,37,145,20,165,200,13,176,47,117,205,123,123,238,33,121,119,116,110,227,202,171,25,169,22,101,81,144,132,211,178,240,14,189,75,99,225,167,239,158,220,130,22,97,95,65,84,144,59,239,164,224,148,111,87,201,13,201,227,63,106,82,109,125,211,67,164,43,188,141,139,248,154,84,161,55,59,89,157,157,149,156,174,105,18,163,214,44,0,199,224,52,58,175,104,30,87,91,225,105,81,102,117,94,68,75,54,207,238,226,45,91,145,12,92,66,88,94,213,68,225,72,42,18,115,146,190,43,164,46,8,209,201,60,77,229,119,127,182,104,20,68,4,52,97,101,66,227,236,45,97,12,160,44,211,33,195,149,174,22,45,83,183,253,5,249,135,79,243,160,62,221,110,36,71,83,193,52,218,99,190,36,223,151,251,185,108,141,220,158,207,227,138,20,124,170,75,169,61,200,156,20,239,151,184,114,57,158,191,238,120,79,22,12,255,125,50,248,118,51,114,96,46,64,26,89,218,115,113,5,70,45,164,138,97,117,22,231,100,212,6,21,76,84,73,89,60,132,44,209,162,168,107,115,60,194,252,162,81,209,115,106,237,198,32,118,150,6,206,214,246,252,166,228,229,148,192,66,177,181,47,239,10,82,13,155,189,67,113,171,92,104,181,229,148,102,156,84,202,66,122,151,75,127,82,126,3,91,14,32,225,11,243,229,226,162,204,55,113,69,89,89,8,218,78,190,214,113,6,245,10,72,8,61,189,98,45,211,214,180,169,93,210,1,67,84,126,31,128,11,26,83,168,222,16,117,96,33,155,76,214,77,171,140,162,53,93,123,134,95,22,45,202,186,128,138,120,232,61,13,188,251,239,158,28,84,132,215,85,225,173,227,140,97,133,220,245,35,98,213,214,93,124,124,250,201,46,165,150,10,130,67,42,20,211,31,226,172,38,175,94,131,234,5,205,201,145,111,85,96,177,231,13,216,86,22,253,70,139,20,113,54,118,248,61,250,189,76,226,76,2,215,131,55,58,209,106,67,18,186,222,162,110,231,42,52,125,92,22,76,104,81,146,6,50,99,198,43,90,92,119,233,172,228,247,206,47,124,198,34,11,177,193,43,82,65,5,160,255,18,61,4,170,253,85,22,100,89,172,203,232,146,39,174,189,91,166,54,81,170,119,105,60,185,91,206,20,130,223,212,52,61,242,157,189,170,165,216,217,141,166,56,151,20,89,238,187,86,54,28,160,169,188,223,152,129,89,237,31,10,211,22,224,71,69,179,90,192,112,208,166,187,125,99,52,179,57,62,20,230,145,68,186,154,231,180,144,143,37,117,164,187,26,0,100,175,156,30,68,239,173,61,71,243,196,81,186,70,79,182,221,124,251,216,18,215,13,30,198,39,154,232,103,105,213,107,214,251,34,235,186,167,129,75,235,202,211,129,245,90,185,219,229,190,48,29,157,222,237,88,117,243,61,152,108,27,252,103,101,107,183,248,61,124,189,147,22,173,7,104,166,171,45,155,167,57,45,46,11,202,31,247,70,209,61,205,2,108,83,240,22,18,43,239,233,245,13,199,230,45,58,45,180,29,21,158,26,227,137,110,175,141,42,182,228,125,89,114,25,26,51,53,154,8,50,238,7,106,190,48,140,244,89,195,146,1,206,111,30,115,128,19,30,39,28,102,29,181,23,65,203,44,82,68,9,115,164,54,125,122,105,156,76,28,92,152,185,149,141,117,55,179,232,10,226,220,48,11,215,192,185,161,246,93,65,112,230,67,23,173,151,236,20,104,172,43,104,37,241,151,140,164,254,76,159,0,63,60,155,5,18,61,90,219,80,14,173,151,116,180,168,43,44,157,24,197,49,41,72,71,38,15,7,176,2,76,28,88,111,101,108,212,167,101,149,195,76,203,187,255,30,122,139,44,102,236,20,118,175,172,182,136,254,213,160,221,145,143,177,240,102,0,62,184,241,53,218,204,171,235,58,7,128,254,204,4,14,103,193,218,76,36,236,0,137,148,59,98,244,20,103,79,132,39,252,73,190,225,91,63,192,184,63,143,54,123,212,120,57,161,127,89,24,30,21,252,193,168,50,156,154,44,245,164,85,89,53,9,66,103,174,146,34,214,79,97,106,93,2,233,113,145,144,227,45,36,226,91,36,6,226,80,98,60,227,185,1,147,168,57,126,226,130,44,111,61,61,113,148,150,121,51,108,218,181,58,68,241,73,63,139,94,102,66,241,61,129,83,157,226,68,220,185,130,25,25,69,67,19,173,17,66,72,155,77,18,235,111,170,178,222,168,152,189,31,130,132,134,85,195,205,187,37,52,142,203,116,139,63,5,181,103,26,79,60,46,250,200,200,107,42,54,2,174,152,106,104,80,207,190,252,13,187,115,36,185,57,184,215,126,24,10,181,167,207,46,52,197,178,255,117,42,170,145,182,106,243,230,138,104,99,74,43,108,126,242,9,29,83,186,84,218,5,226,227,130,242,140,244,178,17,171,83,211,185,80,99,133,130,34,81,202,16,88,69,240,56,217,15,152,21,41,82,119,225,88,158,245,212,246,45,25,151,142,146,209,15,30,225,135,72,241,227,39,239,222,62,222,59,241,162,243,8,212,66,145,167,249,178,59,222,182,47,59,41,136,144,186,24,192,220,223,95,205,110,177,168,94,205,94,94,205,238,159,238,174,0,208,213,44,165,108,147,197,219,15,157,228,7,37,217,200,114,44,110,140,38,126,6,226,221,78,158,72,109,204,178,14,67,216,187,95,129,86,44,28,37,101,12,54,77,77,204,205,189,49,241,90,21,163,143,214,89,8,195,177,250,54,34,236,42,211,80,94,120,162,127,101,98,66,63,35,119,28,14,72,185,230,17,174,136,127,224,28,220,146,138,71,23,165,76,189,255,238,236,68,193,96,144,1,218,48,93,39,117,183,253,125,182,78,0,80,214,231,248,249,24,199,47,154,3,35,232,65,23,63,238,156,156,247,8,237,45,52,156,133,238,134,228,92,110,209,56,119,75,18,164,243,135,149,224,255,188,36,242,17,167,23,195,80,123,108,5,77,17,90,209,124,147,17,133,93,245,48,99,205,23,170,198,82,164,10,254,196,205,111,43,186,153,67,123,83,187,221,55,136,196,229,231,98,25,97,227,183,23,237,254,14,252,248,23,218,191,52,133,118,129,10,93,231,56,212,54,199,145,109,111,152,149,19,136,169,244,11,137,155,26,42,234,120,175,151,162,201,91,118,189,184,137,161,16,103,106,10,241,114,245,121,232,245,100,81,51,153,160,229,178,19,123,137,250,60,108,172,229,28,195,73,46,103,24,19,170,72,136,174,253,198,234,123,216,227,58,83,63,245,29,168,213,232,188,100,188,217,112,35,49,97,190,19,175,0,53,15,139,191,248,252,7,221,184,202,208,158,26,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"FormulaTask1",
				Position = new Point(659, 37),
				ResultParameterMetaPath = @"f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,173,14,131,48,20,6,208,135,65,223,229,246,23,168,159,152,218,146,73,82,113,91,190,102,130,34,10,201,4,225,221,135,158,61,201,153,186,233,177,61,191,43,218,59,127,80,37,20,89,54,196,219,165,127,112,95,80,177,238,225,96,73,26,37,9,101,167,13,89,54,160,52,107,71,106,224,34,179,22,157,189,58,175,240,146,38,21,59,90,56,138,183,12,205,35,121,244,158,172,103,69,163,65,162,1,6,179,244,101,112,236,206,216,197,31,234,102,75,234,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway1InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"InclusiveGateway1",
				Position = new Point(785, 198),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"FormulaTask2",
				Position = new Point(659, 198),
				ResultParameterMetaPath = @"f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,177,10,195,32,16,128,225,135,201,124,69,79,79,212,189,67,167,22,58,6,135,83,47,116,136,25,76,160,67,200,187,215,185,219,207,7,255,60,205,143,253,249,221,164,191,203,71,26,199,133,215,93,210,109,232,31,220,87,105,178,29,241,20,131,193,6,116,32,170,32,216,234,12,120,36,11,89,107,85,13,57,44,44,215,24,94,220,185,201,33,61,158,94,105,37,139,38,96,174,126,44,153,193,147,42,224,2,150,17,213,81,14,87,154,210,15,163,88,133,182,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask3",
				Position = new Point(204, 352),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateOnMentionAddedStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"OnMentionAddedStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(113, 366),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeOnMentionAddedStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask4",
				Position = new Point(358, 352),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddMentionNotificationUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"AddMentionNotificationUserTask",
				Position = new Point(512, 352),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddMentionNotificationUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"FormulaTask3",
				Position = new Point(659, 352),
				ResultParameterMetaPath = @"f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,59,14,131,48,12,0,208,195,48,187,34,159,218,33,123,7,166,86,234,136,50,56,137,173,14,192,16,144,58,32,238,94,230,174,79,122,83,55,141,219,243,187,74,123,151,143,44,28,149,231,77,210,237,210,63,120,204,178,200,186,199,195,80,230,64,189,135,234,4,193,27,69,96,205,12,72,72,100,43,7,131,246,188,194,139,27,47,178,75,139,135,173,195,29,109,46,16,188,103,240,181,32,4,212,0,125,214,140,46,168,115,52,156,169,75,63,109,26,49,214,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed792714-f7cc-4d65-861b-bf1701dd5157"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("09668c8e-1e00-4d2a-a040-35cd7a7045d1"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("257f42e9-08c7-402e-8ccc-800826314b17"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("982aa7db-afb3-478f-ad21-ce96e46fb25b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("22aaf901-be11-4228-b8c4-b254129c86d7"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ESNNotificationProcess(userConnection);
		}

		public override object Clone() {
			return new ESNNotificationProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"));
		}

		#endregion

	}

	#endregion

	#region Class: ESNNotificationProcess

	/// <exclude/>
	public class ESNNotificationProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessPostCommentLane

		/// <exclude/>
		public class ProcessPostCommentLane : ProcessLane
		{

			public ProcessPostCommentLane(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadCommentedPostUserTaskFlowElement

		/// <exclude/>
		public class ReadCommentedPostUserTaskFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCommentedPostUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCommentedPostUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,208,131,162,36,223,138,212,45,114,104,19,52,65,46,113,14,43,114,169,16,213,11,20,157,214,53,252,239,93,74,142,235,20,46,226,246,210,2,213,73,28,12,135,179,207,77,32,107,24,134,143,208,96,48,15,110,209,90,24,58,237,206,223,153,218,161,125,111,187,85,31,156,5,3,90,3,181,249,134,106,194,23,202,184,183,224,128,174,108,150,63,20,150,193,124,121,92,99,25,156,45,3,227,176,25,136,67,87,210,52,73,242,52,83,44,141,57,103,28,64,178,82,101,130,9,85,8,17,73,45,203,40,155,152,191,18,191,232,154,30,44,78,111,140,242,122,252,189,93,247,158,26,17,32,71,138,25,186,118,7,38,222,196,176,104,161,172,81,209,217,217,21,18,228,172,105,40,26,188,53,13,94,131,165,183,188,78,231,33,34,105,168,7,207,170,81,187,197,215,222,226,48,152,174,125,205,92,189,106,218,67,54,9,224,254,184,179,19,142,30,61,243,26,220,227,40,113,73,182,182,163,203,55,85,101,177,2,103,158,14,77,124,198,245,200,59,45,127,116,65,81,149,238,160,94,225,193,155,47,35,185,128,222,77,1,77,207,19,193,154,234,241,228,88,247,25,123,45,220,152,192,254,153,124,162,230,209,24,98,65,224,147,7,38,149,231,223,101,112,127,57,92,125,105,209,222,200,71,108,96,202,218,195,57,161,63,1,139,26,27,108,221,124,163,5,143,64,114,201,210,50,79,40,143,49,176,50,202,115,6,88,132,121,25,166,73,26,234,45,93,216,27,154,111,226,72,114,93,20,156,149,144,229,140,115,129,140,78,49,83,34,215,113,24,37,69,46,18,127,101,209,58,227,214,83,39,204,55,10,99,30,138,92,176,164,212,49,227,89,90,176,82,104,201,114,204,211,162,12,203,56,149,114,251,48,133,107,134,190,134,245,221,62,170,79,8,106,70,205,236,45,207,124,50,104,178,236,224,102,126,158,102,157,158,81,154,87,181,51,109,69,164,186,70,233,203,233,83,232,233,13,149,0,42,28,133,125,117,73,78,133,168,121,200,129,101,162,84,140,23,81,204,242,76,132,228,76,73,206,11,1,73,24,81,23,250,207,55,75,87,25,9,245,85,143,22,118,125,18,30,31,163,23,243,231,75,100,187,206,77,137,223,151,248,166,147,180,72,62,28,152,122,238,104,17,203,60,17,89,194,84,152,166,140,71,25,48,16,60,101,82,42,42,139,78,35,21,83,71,111,105,25,249,12,220,116,43,43,119,195,63,76,91,232,143,182,203,95,216,25,191,179,6,142,14,226,41,131,245,159,141,204,191,215,217,219,96,251,29,100,60,254,6,91,7,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })));
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
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
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

		#region Class: AddCommentNotificationUserTaskFlowElement

		/// <exclude/>
		public class AddCommentNotificationUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddCommentNotificationUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddCommentNotificationUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Owner = () => (Guid)(((process.ReadCommentedPostUserTask.ResultEntity.IsColumnValueLoaded(process.ReadCommentedPostUserTask.ResultEntity.Schema.Columns.GetByName("CreatedBy").ColumnValueName) ? process.ReadCommentedPostUserTask.ResultEntity.GetTypedColumnValue<Guid>("CreatedById") : Guid.Empty)));
				_recordDefValues_IsRead = () => (bool)(false);
				_recordDefValues_Type = () => (Guid)(new Guid("20e6de35-8b86-475f-bed9-361688614c66"));
				_recordDefValues_SocialMessage = () => (Guid)(((process.ReadCommentedPostUserTask.ResultEntity.IsColumnValueLoaded(process.ReadCommentedPostUserTask.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCommentedPostUserTask.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsRead", () => _recordDefValues_IsRead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SocialMessage", () => _recordDefValues_SocialMessage.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Owner;
			internal Func<bool> _recordDefValues_IsRead;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_SocialMessage;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,150,219,110,219,70,16,134,95,69,96,114,233,17,246,124,208,109,226,2,6,156,212,136,211,220,216,190,216,195,108,34,148,34,13,146,106,225,10,122,247,14,105,201,167,182,138,139,54,5,130,154,23,18,185,218,127,118,118,248,253,154,221,84,175,135,155,107,172,22,213,71,236,186,208,183,101,152,191,105,59,156,159,117,109,194,190,159,159,182,41,212,203,223,66,172,241,44,116,97,133,3,118,159,66,189,198,254,116,217,15,71,179,199,178,234,168,122,253,203,244,107,181,184,216,84,39,3,174,126,58,201,20,61,88,244,154,75,6,204,185,12,42,38,13,161,40,15,33,34,227,129,25,175,188,36,113,106,235,245,170,121,135,67,56,11,195,151,106,177,169,166,104,20,32,210,12,205,147,135,24,72,171,68,96,224,147,229,96,76,146,86,24,33,116,177,213,246,168,234,211,23,92,133,105,209,123,49,103,42,75,22,57,40,237,2,40,31,61,56,101,20,4,44,220,102,235,162,226,124,20,239,230,223,11,47,94,93,156,244,63,254,218,96,119,62,197,93,148,80,247,120,53,167,209,39,3,199,53,174,176,25,22,27,143,197,121,155,16,148,44,5,148,21,25,124,182,26,132,15,78,39,33,145,123,220,146,224,174,154,139,141,14,188,136,232,36,96,22,6,84,242,130,210,115,12,4,51,65,10,142,222,27,57,74,142,155,97,57,220,188,153,106,180,216,96,44,38,70,47,193,133,64,170,192,56,120,198,50,36,131,193,216,80,10,10,190,189,122,117,53,110,44,47,251,235,58,220,124,250,227,254,62,96,200,179,212,174,198,228,49,207,174,219,126,152,229,48,132,249,15,203,142,110,151,244,6,103,109,153,117,216,175,235,97,217,124,166,185,117,141,105,88,182,13,189,241,102,8,105,184,93,226,250,17,29,15,23,217,92,222,66,118,89,45,46,255,10,179,221,247,109,81,31,131,246,148,177,203,234,232,178,58,111,215,93,26,35,74,122,120,251,96,119,211,34,211,148,39,143,123,168,104,164,89,215,245,110,228,45,109,117,63,113,63,220,230,101,89,98,62,105,206,247,44,77,81,216,238,130,63,249,216,95,183,185,253,19,217,187,208,132,207,216,189,167,2,220,231,126,151,229,71,42,227,62,112,20,94,51,203,11,88,12,30,20,26,162,38,243,0,158,251,88,164,149,162,20,49,169,63,96,193,14,155,132,143,19,227,38,162,52,154,131,35,82,64,113,77,166,200,153,65,112,76,102,101,156,204,89,238,244,253,84,237,209,205,187,188,198,82,109,171,237,246,232,161,199,147,35,95,75,69,64,154,146,70,139,42,240,6,29,72,180,89,138,236,130,203,225,160,199,179,53,86,161,36,25,35,115,42,33,44,196,228,34,88,175,181,35,127,140,57,254,251,30,159,28,124,200,36,119,19,94,16,255,143,17,247,44,26,29,139,3,86,70,162,184,34,88,173,245,32,148,96,116,19,138,103,246,16,226,207,78,236,185,136,7,83,148,229,6,129,39,36,200,56,253,195,59,102,9,83,84,204,161,206,2,19,59,136,184,83,42,105,178,29,216,146,45,5,72,22,28,207,25,52,129,239,162,101,73,233,242,45,218,216,105,219,254,188,190,158,107,150,82,116,206,65,80,138,186,104,198,8,94,231,49,160,72,158,92,155,189,83,115,193,208,100,148,26,200,115,212,88,172,46,180,191,236,65,26,110,156,51,92,37,99,190,214,86,118,235,29,159,191,159,53,237,64,176,165,48,182,140,217,104,146,249,125,187,161,145,27,42,252,212,118,94,218,200,119,217,70,158,131,212,223,242,152,207,202,170,28,51,216,172,169,11,208,153,136,114,145,148,149,86,148,43,55,197,71,119,208,99,200,121,14,81,145,67,24,29,56,21,227,138,248,149,28,44,179,140,37,89,56,47,238,255,117,84,12,200,80,233,20,32,209,33,26,84,65,11,65,250,12,50,68,43,172,67,110,184,253,182,71,197,147,252,98,239,239,210,222,145,161,117,196,34,185,103,68,39,211,41,49,58,242,120,226,76,40,25,83,54,54,126,205,222,87,219,223,1,44,76,134,219,103,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "5ca46f1711e94116b7e56dc129a6bce3",
							"BaseElements.AddCommentNotificationUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509");
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

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,110,219,48,16,252,149,64,231,208,16,37,74,34,125,43,82,183,200,161,73,208,4,185,196,57,144,212,202,33,42,153,2,73,39,77,13,255,123,151,146,227,58,133,139,184,189,180,245,197,210,96,118,118,246,165,117,162,91,233,253,133,236,32,153,38,55,224,156,244,182,9,147,15,166,13,224,62,58,187,234,147,211,196,131,51,178,53,223,160,30,241,89,109,194,123,25,36,134,172,231,63,20,230,201,116,126,88,99,158,156,206,19,19,160,243,200,193,144,162,76,43,197,105,65,184,202,51,194,184,162,132,11,166,8,112,1,160,160,100,156,177,145,249,43,241,51,219,245,210,193,152,99,144,111,134,199,155,231,62,82,41,2,122,160,24,111,151,91,48,143,38,252,108,41,85,11,53,190,7,183,2,132,130,51,29,86,3,55,166,131,43,233,48,87,212,177,17,66,82,35,91,31,89,45,52,97,246,181,119,224,189,177,203,183,204,181,171,110,185,207,70,1,216,189,110,237,164,131,199,200,188,146,225,97,144,56,71,91,155,193,229,187,197,194,193,66,6,243,184,111,226,11,60,15,188,227,250,135,1,53,78,233,86,182,43,216,203,249,186,146,51,217,135,177,160,49,61,18,156,89,60,28,93,235,174,99,111,149,155,33,216,191,144,143,212,60,88,67,86,34,248,24,129,81,229,229,113,158,220,157,251,203,167,37,184,107,253,0,157,28,187,118,63,65,244,39,96,214,66,7,203,48,93,167,188,97,180,22,130,8,158,115,194,40,151,68,21,149,32,178,162,85,149,85,89,145,150,106,131,1,59,67,211,117,93,165,105,85,104,73,4,164,138,48,86,55,200,198,16,40,16,128,172,225,133,98,155,251,209,184,241,125,43,159,111,119,254,46,224,233,4,183,50,230,62,233,173,15,80,79,62,131,182,174,222,54,62,254,33,45,207,25,175,181,206,8,173,21,186,226,50,35,130,213,26,167,203,53,173,120,33,10,174,113,79,226,47,142,211,46,140,150,237,101,15,78,110,39,153,30,94,244,87,23,18,155,232,172,13,99,107,118,67,184,182,26,79,253,19,78,78,46,96,48,245,178,115,74,83,42,152,174,136,20,180,33,76,151,138,240,76,48,162,83,85,230,185,200,74,74,51,116,133,159,139,56,176,107,187,114,122,123,158,126,252,78,252,209,253,255,133,171,254,157,67,61,120,42,199,172,254,127,187,212,255,222,142,110,146,205,119,175,169,228,159,199,6,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,113,46,74,77,44,73,77,113,170,4,243,60,83,64,20,0,81,116,18,230,43,0,0,0 })));
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
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,205,110,19,49,16,126,149,104,207,117,180,217,63,103,115,67,37,160,74,136,86,36,234,133,244,48,177,199,169,213,221,236,202,118,10,33,202,129,62,3,15,146,86,234,1,80,203,43,184,111,132,119,55,13,45,10,106,64,66,136,189,172,253,233,243,55,223,140,103,188,240,88,6,90,191,134,28,189,158,55,68,165,64,23,194,180,95,200,204,160,122,169,138,89,233,237,121,26,149,132,76,126,64,222,224,125,46,205,115,48,224,142,44,70,63,20,70,94,111,180,93,99,228,237,141,60,105,48,215,142,83,29,17,64,121,66,57,241,163,36,36,81,2,29,2,212,247,201,152,241,32,226,99,0,74,187,107,230,47,196,247,139,188,4,133,77,140,90,94,212,203,225,188,172,168,29,7,176,154,34,117,49,93,131,97,101,66,247,167,48,206,144,187,189,81,51,116,144,81,50,119,217,224,80,230,120,4,202,197,170,116,138,10,114,36,1,153,174,88,25,10,211,127,95,42,212,90,22,211,167,204,101,179,124,250,144,237,4,112,179,93,219,241,107,143,21,243,8,204,105,45,113,224,108,45,107,151,207,38,19,133,19,48,242,252,161,137,51,156,215,188,221,234,231,14,112,119,75,199,144,205,240,65,204,199,153,236,67,105,154,132,154,240,142,160,228,228,116,231,92,55,21,123,42,221,192,129,229,61,121,71,205,173,57,4,137,3,207,43,160,81,185,95,142,188,183,7,250,240,221,20,213,128,157,98,14,77,213,78,218,14,253,9,232,103,152,227,212,244,22,157,49,165,60,142,66,18,240,174,112,117,236,34,1,22,197,36,76,40,198,52,166,145,8,196,210,29,216,24,234,45,48,98,130,130,223,37,76,116,58,36,66,193,8,0,79,9,237,166,157,148,81,150,198,105,184,60,105,140,75,93,102,48,63,222,248,179,159,236,173,189,180,43,123,101,191,218,107,123,211,114,191,149,253,108,191,180,236,141,93,181,236,55,123,123,247,241,238,162,101,175,90,13,225,238,194,94,183,223,32,43,20,175,91,163,250,170,27,44,38,146,65,118,88,162,130,245,229,249,219,123,251,209,80,84,117,83,69,97,154,106,108,234,62,40,152,155,238,87,242,12,107,215,247,61,22,184,132,124,26,80,215,84,97,76,34,145,250,4,2,142,36,100,34,141,252,32,78,24,77,156,37,247,60,84,23,52,40,102,138,173,199,81,55,239,194,31,205,251,63,152,226,223,25,204,173,163,177,75,171,255,159,77,252,247,27,110,233,45,191,3,59,36,9,75,132,6,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,178,50,180,50,212,113,46,74,77,44,73,77,241,207,179,50,176,50,208,9,206,79,206,76,204,241,77,45,46,78,76,79,5,139,120,166,128,40,0,3,32,50,156,47,0,0,0 })));
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
								new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"));
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

		#region Class: AddLikedNotificationUserTaskFlowElement

		/// <exclude/>
		public class AddLikedNotificationUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddLikedNotificationUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddLikedNotificationUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_IsRead = () => (bool)(false);
				_recordDefValues_Type = () => (Guid)(new Guid("4bfd2825-c7a9-4133-b99e-0d6b3dbba451"));
				_recordDefValues_SocialMessage = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("SocialMessage").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("SocialMessageId") : Guid.Empty)));
				_recordDefValues_Owner = () => (Guid)(((process.ReadLikedPostUserTask.ResultEntity.IsColumnValueLoaded(process.ReadLikedPostUserTask.ResultEntity.Schema.Columns.GetByName("CreatedBy").ColumnValueName) ? process.ReadLikedPostUserTask.ResultEntity.GetTypedColumnValue<Guid>("CreatedById") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_IsRead", () => _recordDefValues_IsRead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SocialMessage", () => _recordDefValues_SocialMessage.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordDefValues_IsRead;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_SocialMessage;
			internal Func<Guid> _recordDefValues_Owner;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,89,79,220,72,16,199,191,138,229,228,145,26,245,125,204,43,97,37,36,200,34,72,242,2,60,244,81,29,70,49,54,178,61,187,98,71,243,221,183,60,48,92,187,33,100,47,109,36,252,48,99,183,171,202,213,255,174,159,171,189,170,223,142,215,87,88,207,235,15,216,247,97,232,202,56,219,237,122,156,29,245,93,194,97,152,29,116,41,52,139,223,66,108,240,40,244,225,18,71,236,63,133,102,137,195,193,98,24,119,170,199,110,245,78,253,246,151,205,221,122,126,186,170,247,71,188,252,184,159,41,186,9,193,56,103,52,88,35,61,40,148,22,60,103,25,82,49,62,187,156,66,73,130,156,83,215,44,47,219,67,28,195,81,24,47,234,249,170,222,68,163,0,217,26,75,110,10,60,51,10,148,16,22,98,114,17,172,215,218,69,39,21,215,190,94,239,212,67,186,192,203,176,121,232,189,51,103,42,75,22,57,40,237,2,40,31,61,56,69,97,2,22,110,179,117,81,113,62,57,223,218,223,59,150,208,12,56,221,201,139,225,170,9,215,159,190,106,112,245,72,156,135,38,171,179,27,141,207,234,249,217,215,84,190,253,63,217,36,255,88,231,167,18,159,213,59,103,245,73,183,236,211,20,81,210,197,187,7,185,109,30,178,49,121,114,185,213,148,70,218,101,211,220,142,188,11,99,216,26,110,135,187,188,40,11,204,251,237,201,86,202,77,20,118,123,192,159,252,108,143,155,220,254,142,219,97,104,195,103,236,223,147,0,247,185,223,101,249,129,100,220,6,246,44,26,29,139,3,86,74,2,197,21,7,103,173,7,161,4,163,147,80,60,179,27,239,99,44,216,99,155,240,47,38,118,140,195,70,237,169,152,111,243,154,164,90,215,235,245,206,195,18,199,40,74,17,130,129,10,84,156,138,51,13,206,48,9,88,138,193,98,11,58,148,207,150,184,83,42,105,148,6,108,201,83,128,100,193,241,156,65,83,225,187,104,89,82,186,252,243,37,126,250,230,160,235,190,44,175,102,154,165,20,157,115,16,148,210,160,50,70,240,58,79,1,69,242,166,164,236,157,154,169,88,178,112,66,67,178,129,56,230,82,66,244,30,129,101,19,101,142,49,40,205,223,156,63,71,204,221,243,246,78,222,87,109,55,82,177,165,48,46,186,182,154,32,153,53,139,47,152,171,107,82,188,186,234,134,241,38,214,43,92,255,49,92,81,120,205,44,47,96,113,90,102,52,2,92,230,129,222,217,62,22,105,229,84,233,207,193,245,146,90,250,46,184,34,11,76,88,154,26,122,69,180,59,145,32,114,142,144,165,84,204,163,85,33,170,103,225,66,206,51,217,16,26,76,18,162,140,43,136,40,57,88,70,81,147,44,156,23,247,111,192,117,186,63,252,252,107,139,253,141,62,243,77,191,56,159,209,232,147,129,189,6,47,177,29,231,43,95,74,212,33,41,72,89,83,163,155,166,235,163,200,128,90,4,141,65,89,149,253,154,28,238,10,121,190,202,86,150,200,172,33,20,169,165,146,133,38,221,163,128,18,18,151,201,235,80,108,158,92,246,218,113,49,94,239,110,52,154,175,92,50,70,49,82,68,82,79,38,148,109,4,231,147,1,180,89,83,187,166,243,44,215,231,223,130,249,24,67,174,198,11,172,38,112,171,76,197,52,251,105,209,15,99,181,160,181,171,186,82,245,56,44,155,113,209,126,174,104,113,26,76,19,234,179,67,226,145,74,241,149,238,31,146,238,200,208,186,36,36,193,227,39,186,181,135,232,8,241,196,153,80,50,166,108,108,252,46,186,93,38,154,60,21,185,207,150,32,11,174,80,192,105,179,24,2,138,192,152,241,194,63,75,119,244,202,107,158,40,143,144,40,35,242,1,159,40,148,49,73,90,97,132,208,197,254,47,232,78,82,242,92,98,6,150,72,117,21,117,6,87,60,77,55,24,35,73,214,34,114,126,66,183,147,66,59,203,61,189,16,44,165,167,105,201,162,64,4,73,115,246,65,6,195,184,252,35,221,24,139,137,209,75,112,180,243,38,73,25,167,157,243,180,225,54,24,12,237,142,10,10,254,66,186,111,90,242,212,141,95,204,247,110,215,142,33,189,118,239,31,147,111,110,168,53,26,77,27,106,170,18,152,190,172,200,63,51,8,142,73,34,213,201,156,229,183,248,62,95,255,14,154,213,88,85,91,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "5ca46f1711e94116b7e56dc129a6bce3",
							"BaseElements.AddLikedNotificationUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509");
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

		#region Class: ReadLikedPostUserTaskFlowElement

		/// <exclude/>
		public class ReadLikedPostUserTaskFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLikedPostUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLikedPostUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,203,110,219,48,16,252,21,67,231,48,144,37,234,229,91,145,186,69,14,109,130,38,200,165,206,97,69,46,101,34,212,3,20,157,214,53,252,239,93,74,182,235,20,46,226,246,210,2,213,137,26,12,135,179,207,77,32,12,244,253,71,168,49,152,5,247,104,45,244,173,114,151,239,180,113,104,223,219,118,213,5,23,65,143,86,131,209,223,80,142,248,92,106,247,22,28,208,149,205,226,135,194,34,152,45,78,107,44,130,139,69,160,29,214,61,113,232,10,202,44,70,16,9,203,83,16,140,135,113,198,160,76,50,22,35,79,99,84,81,50,141,162,145,249,43,241,171,182,238,192,226,248,198,32,175,134,227,253,186,243,212,41,1,98,160,232,190,109,118,96,236,77,244,243,6,74,131,146,254,157,93,33,65,206,234,154,162,193,123,93,227,45,88,122,203,235,180,30,34,146,2,211,123,150,65,229,230,95,59,139,125,175,219,230,53,115,102,85,55,199,108,18,192,195,239,206,78,56,120,244,204,91,112,203,65,226,154,108,109,7,151,111,170,202,98,5,78,63,31,155,120,194,245,192,59,47,127,116,65,82,149,30,192,172,240,232,205,151,145,92,65,231,198,128,198,231,137,96,117,181,60,59,214,67,198,94,11,55,34,176,219,147,207,212,60,25,67,148,18,248,236,129,81,101,127,92,4,159,175,251,155,47,13,218,59,177,196,26,198,172,61,94,18,250,19,48,55,88,99,227,102,155,66,169,50,1,193,153,144,9,103,188,224,130,21,101,36,25,38,17,36,8,60,227,178,216,210,133,131,161,217,134,50,175,202,48,75,89,89,132,146,17,35,97,192,203,136,41,16,211,88,20,9,168,76,250,43,243,198,105,183,30,59,97,182,201,69,154,242,144,3,139,179,52,102,124,154,149,44,47,68,202,48,147,73,10,64,103,25,111,31,199,112,117,223,25,88,63,28,162,250,132,32,39,110,137,19,163,159,112,226,179,65,163,101,123,55,241,3,53,105,213,132,242,188,50,78,55,213,132,218,201,160,240,245,188,252,64,201,135,10,7,73,95,87,18,74,194,28,48,43,20,203,212,52,103,60,14,51,86,96,2,44,229,17,231,17,134,42,242,99,177,245,159,111,147,182,210,2,204,77,135,22,118,29,18,158,30,160,23,147,231,139,99,219,214,141,41,63,20,247,174,21,180,66,142,77,237,123,89,198,146,115,30,78,25,151,121,196,120,34,11,6,113,153,176,130,151,89,90,100,178,20,42,39,87,180,134,124,232,119,237,202,138,221,216,247,227,254,249,163,189,242,23,182,197,239,44,128,147,35,120,206,72,253,103,195,242,239,117,246,54,216,126,7,244,220,118,151,85,7,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })));
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
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
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

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,115,211,48,16,253,43,29,159,171,142,109,201,118,156,27,83,2,211,3,180,67,75,47,164,135,149,180,74,53,216,177,71,82,10,37,147,255,206,202,78,66,203,132,105,224,2,248,98,251,205,211,219,183,95,90,39,170,1,239,223,67,139,201,52,185,65,231,192,119,38,156,189,177,77,64,247,214,117,171,62,57,77,60,58,11,141,253,134,122,196,103,218,134,215,16,128,142,172,231,63,20,230,201,116,126,88,99,158,156,206,19,27,176,245,196,161,35,82,114,201,203,26,152,202,114,195,4,47,74,86,215,233,132,113,33,56,55,92,9,94,195,200,252,149,248,121,215,246,224,112,140,49,200,155,225,243,230,177,143,212,140,0,53,80,172,239,150,91,144,71,19,126,182,4,217,160,166,255,224,86,72,80,112,182,165,108,240,198,182,120,5,142,98,69,157,46,66,68,50,208,248,200,106,208,132,217,215,222,161,247,182,91,190,100,174,89,181,203,167,108,18,192,253,239,214,78,58,120,140,204,43,8,247,131,196,5,217,218,12,46,95,45,22,14,23,16,236,195,83,19,159,241,113,224,29,87,63,58,160,169,75,183,208,172,240,73,204,231,153,156,67,31,198,132,198,240,68,112,118,113,127,116,174,251,138,189,148,110,78,96,191,35,31,169,121,48,135,188,36,240,33,2,163,202,238,115,158,124,186,240,151,95,150,232,174,213,61,182,48,86,237,238,140,208,159,128,89,131,45,46,195,116,61,41,106,35,141,17,44,211,90,49,145,101,130,129,212,57,43,32,173,243,138,163,49,121,181,161,3,123,67,211,181,74,203,10,120,109,88,134,19,42,189,40,12,131,156,215,12,69,10,169,50,40,50,81,110,238,70,227,214,247,13,60,222,238,253,125,164,69,58,137,145,169,42,39,160,53,234,179,15,168,58,167,183,133,143,47,162,41,52,19,37,132,98,192,75,205,132,225,37,155,20,121,206,68,133,144,73,172,121,33,21,205,73,124,98,59,187,133,85,208,92,246,232,96,219,201,244,240,160,63,219,144,88,68,215,117,97,44,205,190,9,215,157,162,85,127,55,122,28,76,237,102,110,194,43,46,164,41,89,201,43,96,2,101,193,100,165,51,150,167,26,50,204,101,38,85,69,174,232,186,136,13,187,238,86,78,109,215,211,143,247,196,31,237,255,95,216,234,223,89,212,131,171,114,204,232,255,183,67,253,239,205,232,38,217,124,7,148,77,44,171,199,6,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,176,50,212,9,206,79,206,76,204,241,77,45,46,78,76,79,5,138,24,232,120,166,128,40,0,102,106,230,161,38,0,0,0 })));
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
								new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"));
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

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,77,111,219,48,12,253,43,129,207,85,33,91,178,108,231,54,116,217,208,195,214,98,45,122,105,122,144,101,202,21,230,47,72,74,183,44,200,127,31,101,167,89,58,100,104,182,203,6,204,39,153,120,124,122,124,36,181,137,84,35,157,251,40,91,136,230,209,45,88,43,93,175,253,249,59,211,120,176,239,109,191,26,162,179,200,129,53,178,49,223,160,154,226,139,202,248,183,210,75,76,217,44,127,48,44,163,249,242,56,199,50,58,91,70,198,67,235,16,131,41,52,206,170,56,203,74,82,229,188,36,156,166,140,20,185,16,132,197,105,197,132,46,69,66,139,9,249,43,242,139,190,29,164,133,233,142,145,94,143,199,219,245,16,160,49,6,212,8,49,174,239,118,65,22,68,184,69,39,203,6,42,252,247,118,5,24,242,214,180,88,13,220,154,22,174,165,197,187,2,79,31,66,8,210,178,113,1,213,128,246,139,175,131,5,231,76,223,189,38,174,89,181,221,33,26,9,96,255,187,147,67,71,141,1,121,45,253,227,72,113,137,178,182,163,202,55,117,109,161,150,222,60,29,138,248,12,235,17,119,154,127,152,80,97,151,238,100,179,130,131,59,95,86,114,33,7,63,21,52,93,143,0,107,234,199,147,107,221,59,246,90,185,9,6,135,103,240,137,156,71,107,72,4,6,159,66,96,98,121,62,46,163,251,75,119,245,165,3,123,163,30,161,149,147,107,15,231,24,253,41,176,104,160,133,206,207,55,130,209,36,214,52,33,32,84,65,184,80,9,201,99,90,18,41,53,231,37,205,179,92,149,91,76,216,11,154,111,170,34,161,34,149,25,201,33,195,20,6,25,41,168,136,137,142,69,41,104,201,115,46,116,72,89,116,222,248,245,52,9,243,141,140,25,23,84,101,68,176,20,27,198,165,38,5,83,64,226,76,39,101,201,43,150,241,106,251,48,149,107,220,208,200,245,221,190,170,79,32,171,89,208,139,94,206,130,25,184,89,214,249,89,216,167,89,175,103,104,243,170,241,166,171,103,56,77,13,168,128,59,255,128,222,203,26,70,198,208,86,228,97,160,243,148,165,156,164,92,113,194,139,68,16,201,69,70,50,29,211,34,137,25,139,147,20,199,47,124,97,74,250,218,40,217,92,13,96,229,110,64,232,241,253,121,177,120,161,55,182,239,253,228,248,190,183,55,189,194,23,228,80,212,126,148,203,52,69,3,81,75,137,238,243,92,80,34,115,244,83,165,185,46,18,158,75,5,20,85,225,43,20,74,191,233,87,86,237,182,222,77,207,207,31,61,43,127,225,177,248,157,253,63,186,129,167,108,212,127,182,43,255,222,100,111,163,237,119,103,52,45,139,84,7,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,241,76,1,81,0,255,202,163,187,29,0,0,0 })));
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
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
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

		#region Class: AddMentionNotificationUserTaskFlowElement

		/// <exclude/>
		public class AddMentionNotificationUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddMentionNotificationUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddMentionNotificationUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_IsRead = () => (bool)(false);
				_recordDefValues_Type = () => (Guid)(new Guid("85ab04b0-f624-49b4-8eb8-0cc5fb4108d6"));
				_recordDefValues_SocialMessage = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("SocialMessage").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("SocialMessageId") : Guid.Empty)));
				_recordDefValues_Owner = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_IsRead", () => _recordDefValues_IsRead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SocialMessage", () => _recordDefValues_SocialMessage.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordDefValues_IsRead;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_SocialMessage;
			internal Func<Guid> _recordDefValues_Owner;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,151,219,110,219,70,16,134,95,133,96,114,233,17,246,124,208,173,227,2,6,236,212,176,147,220,88,190,216,195,108,44,84,18,13,146,106,225,10,122,247,14,105,201,39,52,78,211,54,5,130,154,23,20,185,220,153,157,253,249,127,220,213,166,126,219,223,222,96,61,173,63,96,219,134,174,41,253,228,176,105,113,114,214,54,9,187,110,114,210,164,176,152,255,30,226,2,207,66,27,150,216,99,251,41,44,214,216,157,204,187,254,160,122,26,86,31,212,111,127,29,159,214,211,203,77,125,220,227,242,227,113,166,236,168,153,115,82,100,176,153,33,168,24,45,56,155,4,20,197,74,148,129,171,196,52,5,167,102,177,94,174,78,177,15,103,161,191,174,167,155,122,204,70,9,178,53,86,161,84,224,153,81,160,132,176,16,147,139,96,189,214,46,58,169,184,246,245,246,160,238,210,53,46,195,56,232,67,48,103,42,75,22,57,40,237,2,40,31,61,56,69,105,2,22,110,179,117,81,113,62,4,239,250,63,4,150,176,232,112,120,146,231,221,205,34,220,126,250,98,135,155,39,226,60,238,178,153,221,105,60,171,167,179,47,169,188,251,189,24,139,127,170,243,115,137,103,245,193,172,190,104,214,109,26,50,74,186,121,247,168,182,113,144,177,203,179,219,189,166,212,178,90,47,22,187,150,119,161,15,251,142,251,230,38,207,203,28,243,241,234,98,47,229,152,133,237,14,248,147,211,254,184,171,237,159,132,157,134,85,248,140,237,123,18,224,161,246,251,42,63,144,140,251,196,158,69,163,99,113,192,74,73,160,184,226,228,40,235,65,40,193,232,34,20,207,236,24,125,142,5,91,92,37,252,155,133,157,99,55,170,61,152,121,87,215,32,213,182,222,110,15,30,91,220,250,44,109,137,14,130,50,100,113,140,6,66,98,14,184,113,182,200,82,208,33,127,209,226,78,169,164,81,26,176,37,91,154,81,34,70,120,206,160,201,248,46,90,150,148,46,255,190,197,47,223,156,52,205,47,235,155,137,102,41,69,231,134,250,149,6,149,49,130,215,121,72,40,146,55,37,101,239,212,196,233,16,153,138,12,138,17,106,24,70,129,67,154,51,197,234,66,99,48,151,205,155,171,151,136,185,31,239,232,226,125,181,106,122,50,91,10,253,188,89,85,3,36,147,37,174,134,27,204,213,109,179,174,230,212,122,141,213,146,216,32,91,220,37,126,37,237,63,38,45,10,175,153,229,5,44,6,79,198,54,2,92,230,1,60,247,177,72,43,69,41,226,37,210,254,138,177,190,137,52,33,139,177,197,123,200,200,34,165,137,145,10,34,244,83,97,153,251,92,180,247,234,69,210,144,243,28,162,34,78,152,100,116,226,10,34,74,14,150,89,198,146,44,156,23,247,61,72,187,60,238,126,254,109,133,237,157,62,211,113,241,184,154,80,235,179,134,163,5,14,28,76,55,70,50,193,11,19,128,38,145,244,134,86,76,199,105,206,33,20,69,20,58,235,82,220,82,192,189,145,167,155,236,5,51,58,208,183,3,73,18,37,209,14,75,38,135,194,77,52,44,42,170,181,12,33,71,196,89,127,123,56,106,52,221,4,46,149,97,244,197,49,82,147,164,42,20,240,50,33,112,91,68,140,52,97,171,242,246,234,107,100,159,99,200,213,142,224,42,147,151,38,63,205,219,174,175,230,244,234,170,166,84,45,118,235,69,63,95,125,174,232,221,44,48,13,253,38,167,175,112,255,192,112,71,134,100,66,33,137,29,63,192,173,61,68,90,17,32,113,38,148,140,41,27,27,191,9,238,92,100,32,207,113,32,204,104,93,47,194,131,143,206,211,130,195,57,227,210,9,197,197,139,112,71,175,188,230,132,75,12,137,42,18,129,129,79,150,131,49,73,90,97,132,208,197,254,191,224,102,153,154,139,29,222,145,29,246,206,154,162,66,208,64,219,140,168,189,145,145,5,245,157,224,62,108,86,125,72,253,43,220,63,36,220,228,42,218,143,106,218,89,23,20,48,252,197,162,248,204,32,56,38,201,83,78,230,44,191,6,247,213,246,15,226,240,5,62,100,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "5ca46f1711e94116b7e56dc129a6bce3",
							"BaseElements.AddMentionNotificationUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509");
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

		public ESNNotificationProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ESNNotificationProcess";
			SchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ESNNotificationProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ESNNotificationProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid NotificationIdParameter {
			get;
			set;
		}

		private ProcessPostCommentLane _postCommentLane;
		public ProcessPostCommentLane PostCommentLane {
			get {
				return _postCommentLane ?? ((_postCommentLane) = new ProcessPostCommentLane(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminateProcess;
		public ProcessTerminateEvent TerminateProcess {
			get {
				return _terminateProcess ?? (_terminateProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateProcess",
					SchemaElementUId = new Guid("b31e7b6c-362c-41a5-9e34-85da4aeff8e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _onPostCommentedStartSignal;
		public ProcessStartSignalEvent OnPostCommentedStartSignal {
			get {
				return _onPostCommentedStartSignal ?? (_onPostCommentedStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "OnPostCommentedStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadCommentedPostUserTaskFlowElement _readCommentedPostUserTask;
		public ReadCommentedPostUserTaskFlowElement ReadCommentedPostUserTask {
			get {
				return _readCommentedPostUserTask ?? (_readCommentedPostUserTask = new ReadCommentedPostUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddCommentNotificationUserTaskFlowElement _addCommentNotificationUserTask;
		public AddCommentNotificationUserTaskFlowElement AddCommentNotificationUserTask {
			get {
				return _addCommentNotificationUserTask ?? (_addCommentNotificationUserTask = new AddCommentNotificationUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessStartSignalEvent _onLikeAddedStartSignal;
		public ProcessStartSignalEvent OnLikeAddedStartSignal {
			get {
				return _onLikeAddedStartSignal ?? (_onLikeAddedStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "OnLikeAddedStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddLikedNotificationUserTaskFlowElement _addLikedNotificationUserTask;
		public AddLikedNotificationUserTaskFlowElement AddLikedNotificationUserTask {
			get {
				return _addLikedNotificationUserTask ?? (_addLikedNotificationUserTask = new AddLikedNotificationUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLikedPostUserTaskFlowElement _readLikedPostUserTask;
		public ReadLikedPostUserTaskFlowElement ReadLikedPostUserTask {
			get {
				return _readLikedPostUserTask ?? (_readLikedPostUserTask = new ReadLikedPostUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _sendNotificationScriptTask;
		public ProcessScriptTask SendNotificationScriptTask {
			get {
				return _sendNotificationScriptTask ?? (_sendNotificationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendNotificationScriptTask",
					SchemaElementUId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendNotificationScriptTaskExecute,
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
					SchemaElementUId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.InclusiveGateway1.Question"),
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
					SchemaElementUId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessStartSignalEvent _onMentionAddedStartSignal;
		public ProcessStartSignalEvent OnMentionAddedStartSignal {
			get {
				return _onMentionAddedStartSignal ?? (_onMentionAddedStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "OnMentionAddedStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddMentionNotificationUserTaskFlowElement _addMentionNotificationUserTask;
		public AddMentionNotificationUserTaskFlowElement AddMentionNotificationUserTask {
			get {
				return _addMentionNotificationUserTask ?? (_addMentionNotificationUserTask = new AddMentionNotificationUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask3Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateProcess };
			FlowElements[OnPostCommentedStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPostCommentedStartSignal };
			FlowElements[ReadCommentedPostUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCommentedPostUserTask };
			FlowElements[AddCommentNotificationUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddCommentNotificationUserTask };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[OnLikeAddedStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { OnLikeAddedStartSignal };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[AddLikedNotificationUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddLikedNotificationUserTask };
			FlowElements[ReadLikedPostUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLikedPostUserTask };
			FlowElements[SendNotificationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendNotificationScriptTask };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[OnMentionAddedStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { OnMentionAddedStartSignal };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[AddMentionNotificationUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddMentionNotificationUserTask };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateProcess":
						CompleteProcess();
						break;
					case "OnPostCommentedStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ReadCommentedPostUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddCommentNotificationUserTask", e.Context.SenderName));
						break;
					case "AddCommentNotificationUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCommentedPostUserTask", e.Context.SenderName));
						break;
					case "OnLikeAddedStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLikedPostUserTask", e.Context.SenderName));
						break;
					case "AddLikedNotificationUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "ReadLikedPostUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddLikedNotificationUserTask", e.Context.SenderName));
						break;
					case "SendNotificationScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateProcess", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "InclusiveGateway1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendNotificationScriptTask", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
						break;
					case "OnMentionAddedStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddMentionNotificationUserTask", e.Context.SenderName));
						break;
					case "AddMentionNotificationUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("NotificationIdParameter")) {
				writer.WriteValue("NotificationIdParameter", NotificationIdParameter, Guid.Empty);
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
			MetaPathParameterValues.Add("f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4", () => NotificationIdParameter);
			MetaPathParameterValues.Add("d70075ca-9e0b-44df-a779-e59e0e2f85b4", () => OnPostCommentedStartSignal.RecordId);
			MetaPathParameterValues.Add("2f478e43-a126-41ef-bd27-886141b52843", () => OnPostCommentedStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("ba9ba9d2-475d-40f2-8404-7ac59bcee891", () => ReadCommentedPostUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("9a60810c-41d3-474d-908b-832435849593", () => ReadCommentedPostUserTask.ResultType);
			MetaPathParameterValues.Add("56642892-05c7-42ae-8a57-ac21482d70bb", () => ReadCommentedPostUserTask.ReadSomeTopRecords);
			MetaPathParameterValues.Add("0c54e3ed-b510-44aa-95e8-d5869d6647b7", () => ReadCommentedPostUserTask.NumberOfRecords);
			MetaPathParameterValues.Add("3ea11d01-ccd4-45c3-9644-14df37bc5ce0", () => ReadCommentedPostUserTask.FunctionType);
			MetaPathParameterValues.Add("fd3d7954-cc74-4986-a523-d221d7761c23", () => ReadCommentedPostUserTask.AggregationColumnName);
			MetaPathParameterValues.Add("92450397-12f0-4f17-a75d-d38567c6327b", () => ReadCommentedPostUserTask.OrderInfo);
			MetaPathParameterValues.Add("5a1f2b83-ed26-4c92-8480-206a321e9963", () => ReadCommentedPostUserTask.ResultEntity);
			MetaPathParameterValues.Add("2e4064fd-64ed-4abc-8260-c6a14fb6a6c5", () => ReadCommentedPostUserTask.ResultCount);
			MetaPathParameterValues.Add("fd53a939-0d8c-44b8-9ef1-fc1e8c5694e4", () => ReadCommentedPostUserTask.ResultIntegerFunction);
			MetaPathParameterValues.Add("d146f3f2-4cb7-4239-92bf-c9081aa150f5", () => ReadCommentedPostUserTask.ResultFloatFunction);
			MetaPathParameterValues.Add("4508d2c7-78c9-422c-977e-5f7441f0ef76", () => ReadCommentedPostUserTask.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0cc7df16-22da-417e-b78a-80ea545febad", () => ReadCommentedPostUserTask.ResultRowsCount);
			MetaPathParameterValues.Add("15a46e90-2180-4324-bb5b-dcb14fbe07ee", () => ReadCommentedPostUserTask.CanReadUncommitedData);
			MetaPathParameterValues.Add("720d957d-e275-469f-8956-e925ee0c382a", () => ReadCommentedPostUserTask.ResultEntityCollection);
			MetaPathParameterValues.Add("d7c50aae-200a-41d3-8177-d3acea16b585", () => ReadCommentedPostUserTask.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9702aa85-1629-4ea9-8aa4-2753d1f1692e", () => ReadCommentedPostUserTask.IgnoreDisplayValues);
			MetaPathParameterValues.Add("6a3574e7-1c32-41ba-9a16-e9ed315eef65", () => ReadCommentedPostUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f2c99b37-6016-4f45-af48-6e6f1c684e46", () => ReadCommentedPostUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("d2f54b5a-bf50-4842-a4f0-4d72ad23d06c", () => AddCommentNotificationUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("7f07f8e3-92dd-4b85-b1a9-b8d1a524e5d5", () => AddCommentNotificationUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("9abee62b-56b1-4c28-93ae-c885bfff3a39", () => AddCommentNotificationUserTask.RecordAddMode);
			MetaPathParameterValues.Add("a806be87-94ba-47b4-9129-331e6d19c0a5", () => AddCommentNotificationUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("b8bbeac4-174d-4926-9467-5e78622c517a", () => AddCommentNotificationUserTask.RecordDefValues);
			MetaPathParameterValues.Add("f640e209-6e76-4601-93eb-8e3eda7f8505", () => AddCommentNotificationUserTask.RecordId);
			MetaPathParameterValues.Add("b16c2a23-8fa1-410c-8bf0-9ded1dcbf5b3", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("310495bd-78ef-46e8-bd4f-08a98a050897", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("cb3ef4f3-9764-4095-a7f4-5e41a35ac0ac", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("54c3435c-6332-48a2-a3e3-e3146231388c", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("48f7c6e0-02c8-4675-80b8-8367b0ef9190", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("d5e71c2a-4e7a-4bbc-8424-96fac9c00de2", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("062d7511-3234-4dc6-98d1-9a2bd134a872", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("21c4f994-ba78-446e-9942-d68f20139863", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("66e87786-c605-4fec-b02e-830988bb2e7d", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("a122acd7-cc81-49fd-8c39-9aab1b9c747c", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("677eaf70-16e1-4664-bae1-944189695e0b", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("f8162883-d725-4f4b-b85f-218697d31396", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("fc9471e4-6058-424b-acd0-8b0ae601c0c6", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("e98494ea-7338-4c9a-b507-c8b3dc9be58f", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("e0adb813-1f6d-4072-b83f-eafcb5ba680c", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("49fd90d6-76c8-48f2-8b16-ea83004edbda", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b833533c-49e1-4ebc-ac9f-1a911d02ccc4", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("7c3db1aa-d065-4619-9e55-0615dfb22975", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("fa088023-44c1-4370-afa4-5c6b45d07773", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e4cf7a08-cf11-4efc-aad9-78919c7c9593", () => OnLikeAddedStartSignal.RecordId);
			MetaPathParameterValues.Add("f836b77b-679f-4dfa-a647-9a7e89c1ec39", () => OnLikeAddedStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("39c452ee-d582-4fc4-89da-188114ddf6aa", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("ab5d3b2f-e2fb-4c08-99ff-2f80f260179f", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("eb26905a-bd71-46d4-8d6a-d6ed38d0edde", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("c33a347d-db7a-4e6a-919d-dcec7662e460", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("9e247ae1-2b40-42ab-805b-c5d6096d9ba4", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("0a73401c-113f-4c6f-861a-7262b910e6cb", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("a2463ef1-b5d5-415d-b646-059986b3a408", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("d73fb076-b90d-4745-a4b2-fac13c95af7d", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("16d9166d-3ef0-42f4-8408-44ae67b0bbf8", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("7375ce45-bc51-437e-87e1-eedd8eff6e54", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("fe779b3d-abd3-45e1-aeab-f8081843611c", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("41b06c6a-fc83-481d-8934-d1b75bfe8a0f", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("074acb9f-4b51-4a71-96b0-a688dc1e4df0", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("f30a6c29-f244-4a31-9102-fcea5bed4454", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("5556b314-99f0-40b0-8172-959a76296469", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("990df6b1-021b-4232-9284-f92fa22ee682", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("272ed838-6e7e-4ec3-b267-81140797856d", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("daa71dc2-1fb1-4636-bb5a-75c107201ba4", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("489232d2-1dc4-492b-a5a8-1ef8e65ac76c", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("da240fb2-c774-4c74-99fd-2e1fdfae3964", () => AddLikedNotificationUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("17ac42d2-21e6-4d36-ba16-b249f630b24b", () => AddLikedNotificationUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("e8734de8-8d7a-4251-a4ab-c545f58d718b", () => AddLikedNotificationUserTask.RecordAddMode);
			MetaPathParameterValues.Add("644e1f0f-142c-4e1f-8cad-d8d970d36e91", () => AddLikedNotificationUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("56e0b34b-5e15-42e9-b5c8-2bb82ace64b4", () => AddLikedNotificationUserTask.RecordDefValues);
			MetaPathParameterValues.Add("8010ef15-aad8-4dba-850c-692c850d65b9", () => AddLikedNotificationUserTask.RecordId);
			MetaPathParameterValues.Add("bb823b89-4655-4e40-9e5c-0e10daf24deb", () => ReadLikedPostUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("df4038dc-6372-4684-8eec-b443a51b08be", () => ReadLikedPostUserTask.ResultType);
			MetaPathParameterValues.Add("b90f1d0e-459b-4ff2-84b9-84bdd7ae294d", () => ReadLikedPostUserTask.ReadSomeTopRecords);
			MetaPathParameterValues.Add("55f43d53-adf7-49ba-b7fc-3fdfc2fb2ef5", () => ReadLikedPostUserTask.NumberOfRecords);
			MetaPathParameterValues.Add("be6e2286-7b11-4750-807e-4ce55e79daca", () => ReadLikedPostUserTask.FunctionType);
			MetaPathParameterValues.Add("4e88fd04-f4da-40e3-b8c4-35afe197eb57", () => ReadLikedPostUserTask.AggregationColumnName);
			MetaPathParameterValues.Add("8e49b308-b01a-4375-803d-4e3f3770a686", () => ReadLikedPostUserTask.OrderInfo);
			MetaPathParameterValues.Add("83258719-cd7a-45a9-b2ee-39499a3a6013", () => ReadLikedPostUserTask.ResultEntity);
			MetaPathParameterValues.Add("c164263e-1a79-4940-9a57-e2dccc8fa7a0", () => ReadLikedPostUserTask.ResultCount);
			MetaPathParameterValues.Add("eec87964-39ad-40af-a379-61083fb27433", () => ReadLikedPostUserTask.ResultIntegerFunction);
			MetaPathParameterValues.Add("c2061afa-5a06-4890-9015-495796290789", () => ReadLikedPostUserTask.ResultFloatFunction);
			MetaPathParameterValues.Add("56e6c97a-488f-4add-9847-e81524046833", () => ReadLikedPostUserTask.ResultDateTimeFunction);
			MetaPathParameterValues.Add("8e5240fe-f6fb-4a6b-9ab0-214fcca33c93", () => ReadLikedPostUserTask.ResultRowsCount);
			MetaPathParameterValues.Add("ef6b4042-e216-4b4f-a5ee-db4fe2678424", () => ReadLikedPostUserTask.CanReadUncommitedData);
			MetaPathParameterValues.Add("8c09f3bd-485d-4bc4-8868-7ed8fdc1494b", () => ReadLikedPostUserTask.ResultEntityCollection);
			MetaPathParameterValues.Add("3001471f-45f4-4b10-bb93-e968de3645f2", () => ReadLikedPostUserTask.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("e2be980a-5e5d-46f0-b248-73fd2d5c1967", () => ReadLikedPostUserTask.IgnoreDisplayValues);
			MetaPathParameterValues.Add("7eced334-87e9-445d-b4fc-c349d0303875", () => ReadLikedPostUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4e2a3f16-2ed0-4300-85ef-3daad88e98d6", () => ReadLikedPostUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("985f26f9-02d6-49a5-afcc-1da4c66649df", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("14407ed4-7b93-4bb0-8947-61bee5163314", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("4825dd82-7b93-46dc-930d-b83505b1dfac", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8dbf8aa1-5f3b-4120-a9f7-2ce998b5271d", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("97994f7a-bac7-48f6-b00e-124a48fb410b", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("4410d85f-c656-4d35-8868-6b0cf395c87f", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("cd03c654-a7de-4ffc-89fa-6c63a3c8eb4e", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("d92065a7-8e79-43e7-9061-f16b60b4846f", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("152ec142-0c82-4d70-a402-a52fef871f70", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("b2c24b55-7356-45da-b7fa-06d890b61f98", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("1533582a-753c-4ea4-a4b7-fbee9273241e", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("4d80d870-a1ef-4838-819a-2b0dfb2ceee5", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("379f0ed1-624c-4682-bc40-71ebf792b7c5", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("264b43ca-f583-4d03-9225-6c4c86add08b", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("5965ef63-7801-4c91-9a41-a15ad70a5605", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("838e5c55-a218-4d7e-8db5-2a2360539a1e", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9af0e793-7b1b-40b6-b726-89e6b53d8b6b", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("5bd1a28f-6eb3-4163-9ad0-e598003c1907", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("e9dd48c5-c7fe-46e1-b496-5b5dae63c6ee", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("c067a39f-1e8f-445f-a239-e40a0cfe4146", () => OnMentionAddedStartSignal.RecordId);
			MetaPathParameterValues.Add("50d03153-866c-49a1-b09f-f3572ef11b73", () => OnMentionAddedStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("242ce24d-3ddd-45ff-9b66-b7ca7b504cbc", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("0cd58999-5230-4ef3-a513-99389ff530c0", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("99ae8ad0-6499-4567-8c65-86a56bbea68f", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("4c952f0e-dffd-4986-846d-384a7af8a09a", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("f8117a6f-4913-432b-b814-eeab6e96632d", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("0dca8765-93e1-4123-8811-6ec3651653bf", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("69d9d40d-db8f-43e9-88ae-a3abf24a965a", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("8cc5ccbc-2b9c-463a-9bab-aa349cb77cd2", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("1c4950dc-eb9d-4ad4-ab50-8fbb9420594b", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("290fc9b4-9025-4e3f-98b9-1747c5e4346a", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("575e6cd5-8a18-469a-9cd6-55e129df411f", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("4ae0aeb5-961a-4027-9a0c-5ac3d4a5ac77", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("68d9c290-aed7-4455-8d6c-9b0597a13528", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("cb390c3d-53e0-4db5-8ba9-d854ceef7d5e", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("e177f00d-bbb5-4a71-96a5-6b3bd5c30c02", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("7d9a88fc-ab6e-4c1a-b52c-764cccb74f1a", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("6ea463a5-4871-446f-af0b-1667f7dedda3", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("48bd0458-36a0-4710-9baf-d55b64ad2ab2", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("ad88c443-aa08-4a50-8ab0-0e7f5effc244", () => ReadDataUserTask4.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e037ba80-32fe-4970-89b0-011247b9cfca", () => AddMentionNotificationUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("aa175d01-463f-4eaa-b6dd-6e062b0a9fbe", () => AddMentionNotificationUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("31adc4d6-d5e5-44b1-a41c-9f6561db382d", () => AddMentionNotificationUserTask.RecordAddMode);
			MetaPathParameterValues.Add("75b974c3-f286-497f-b22e-63339fcad82c", () => AddMentionNotificationUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("4772da4a-5d0b-4678-8701-ff35ab251456", () => AddMentionNotificationUserTask.RecordDefValues);
			MetaPathParameterValues.Add("2d9562bc-844a-4dc6-86f8-0bfb638f3379", () => AddMentionNotificationUserTask.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "NotificationIdParameter":
					if (!hasValueToRead) break;
					NotificationIdParameter = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SendNotificationScriptTaskExecute(ProcessExecutingContext context) {
			var userConnection = UserConnection;
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "ESNNotification");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			var createdOnColumn = esq.AddColumn("CreatedOn");
			var socialMessageIdColumn = esq.AddColumn("SocialMessage.Id");
			var socialMessageTextColumn = esq.AddColumn("SocialMessage.Message");
			var socialMessageEntityIdColumn = esq.AddColumn("SocialMessage.EntityId");
			var socialMessageEntitySchemaUIdColumn = esq.AddColumn("SocialMessage.EntitySchemaUId");
			var socialMessageParentIdColumn = esq.AddColumn("SocialMessage.Parent.Id");
			var socialMessageParentEntityIdColumn = esq.AddColumn("SocialMessage.Parent.EntityId");
			var socialMessageParentEntitySchemaUIdColumn = esq.AddColumn("SocialMessage.Parent.EntitySchemaUId");
			var typeIdColumn = esq.AddColumn("Type.Id");
			var typeActionColumn = esq.AddColumn("Type.Action");
			var typeNameColumn = esq.AddColumn("Type.Name");
			var typeIconIdColumn = esq.AddColumn("Type.Icon");
			var createdByIdColumn = esq.AddColumn("CreatedBy.Id");
			var createdByNameColumn = esq.AddColumn("CreatedBy.Name");
			var createdByPhotoIdColumn = esq.AddColumn("CreatedBy.Photo");
			var ownerIdColumn = esq.AddColumn("Owner");
			var notificationFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", NotificationIdParameter);
			esq.Filters.Add(notificationFilter);
			var notifications = esq.GetEntityCollection(userConnection);
			if (notifications.Count == 0) {
				return false;
			}
			var notification = notifications[0];
			var createdOn = notification.GetTypedColumnValue<DateTime>(createdOnColumn.Name);
			if (createdOn.Kind == DateTimeKind.Local) {
				createdOn = DateTime.SpecifyKind(createdOn, DateTimeKind.Unspecified);
			}
			string createdOnString = DateTimeDataValueType.Serialize(createdOn, TimeZoneInfo.Utc);
			var notificationId = notification.PrimaryColumnValue;
			var socialMessageId = notification.GetTypedColumnValue<Guid>(socialMessageIdColumn.Name);
			var socialMessageText = notification.GetTypedColumnValue<string>(socialMessageTextColumn.Name);
			var socialMessageEntityId = notification.GetTypedColumnValue<Guid>(socialMessageEntityIdColumn.Name);
			var socialMessageEntitySchemaUId = notification.GetTypedColumnValue<Guid>(socialMessageEntitySchemaUIdColumn.Name);
			var socialMessageParentId = notification.GetTypedColumnValue<Guid>(socialMessageParentIdColumn.Name);
			var socialMessageParentEntityId = notification.GetTypedColumnValue<Guid>(socialMessageParentEntityIdColumn.Name);
			var socialMessageParentEntitySchemaUId = notification.GetTypedColumnValue<Guid>(socialMessageParentEntitySchemaUIdColumn.Name);
			var typeId = notification.GetTypedColumnValue<Guid>(typeIdColumn.Name);
			var typeAction = notification.GetTypedColumnValue<string>(typeActionColumn.Name);
			var typeIconId = notification.GetTypedColumnValue<Guid>("Type_IconId");
			var typeName = notification.GetTypedColumnValue<string>(typeNameColumn.Name);
			var createdById = notification.GetTypedColumnValue<Guid>(createdByIdColumn.Name);
			var createdByName = notification.GetTypedColumnValue<string>(createdByNameColumn.Name);
			var createdByPhotoId = notification.GetTypedColumnValue<Guid>("CreatedBy_PhotoId");
			var ownerId = notification.GetTypedColumnValue<Guid>("OwnerId");
			var esqSysAdminUnit = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysAdminUnit"){
				UseAdminRights = false
			};
			var idColumn = esqSysAdminUnit.AddColumn(esqSysAdminUnit.RootSchema.GetPrimaryColumnName());
			esqSysAdminUnit.Filters.Add(esqSysAdminUnit
				.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", ownerId));
			var entities = esqSysAdminUnit.GetEntityCollection(userConnection);
			if (entities.Count == 0) {
				return false;
			}
			var sysAdminUnit = entities[0];
			var sysAdminUnitId = sysAdminUnit.GetTypedColumnValue<Guid>(idColumn.Name);
			if (UserConnection.GetIsFeatureEnabled("NotificationV2")) {
				if (sysAdminUnitId == userConnection.CurrentUser.PrimaryColumnValue) {
					return false;	
				}
				ESNNotificationTextFormer textFormer = ClassFactory.Get<ESNNotificationTextFormer>(
					new ConstructorArgument("userConnection", userConnection));
				Guid entitySchemaUId = socialMessageParentId.IsEmpty()
					? socialMessageEntitySchemaUId
					: socialMessageParentEntitySchemaUId;
				Guid entityId = socialMessageParentId.IsEmpty()
					? socialMessageEntityId
					: socialMessageParentEntityId;
				string entitySchemaName = userConnection
					.EntitySchemaManager
					.FindInstanceByUId(entitySchemaUId).Name;
				NotificationInfo notificationInfo = new NotificationInfo {
					ImageId = createdByPhotoId,
					EntitySchemaName =  entitySchemaName,
					RemindTime = createdOn,
					MessageId = notificationId,
					EntityId = entityId,
					GroupName = "ESNNotification",
					SysAdminUnit = sysAdminUnitId,
					Body = textFormer.GetBody(new Dictionary<string, object> {
						{"CreatedOn", createdOn },
						{"CreatedByName", createdByName },
						{"Action", typeAction },
						{"Message", socialMessageText },
					}),
					Title = textFormer.GetTitle(new Dictionary<string, object> {
						{"TypeName", typeName }
					})
				};
				var notificationSender = ClassFactory.Get<INotificationSender>(
					new ConstructorArgument("userConnection", UserConnection));
				notificationSender.Send(new [] {notificationInfo});
			} else {
				string createdByString = string.Format("{{\"value\":\"{0}\", \"displayValue\":\"{1}\", \"primaryImageValue\":\"{2}\"}}",
					createdById, createdByName, createdByPhotoId);
				string socialMessageParentString = string.Format("{{\"id\":\"{0}\", \"entityId\":\"{1}\", \"entitySchemaUId\":\"{2}\"}}",
					socialMessageParentId, socialMessageParentEntityId, socialMessageParentEntitySchemaUId);
				string socialMessageTextJson = Newtonsoft.Json.JsonConvert.ToString(socialMessageText.ToString());
				string socialMessageString = string.Format(
					"{{\"id\":\"{0}\", \"value\":\"{1}\", \"displayValue\":{2}, \"entityId\":\"{3}\", \"entitySchemaUId\":\"{4}\", \"parent\":{5}}}",
					socialMessageId, socialMessageId, socialMessageTextJson, socialMessageEntityId, socialMessageEntitySchemaUId, socialMessageParentString);
				string typeString = string.Format("{{\"value\":\"{0}\", \"displayValue\":\"{1}\", \"primaryImageValue\":\"{2}\"}}",
					typeId, typeAction, typeIconId);
				var SimpleMessage = new SimpleMessage();
				SimpleMessage.Body = string.Format(
					"{{\"id\":\"{0}\", \"createdOn\":\"{1}\", \"createdBy\":{2}, \"socialMessage\":{3}, \"type\":{4}}}",
					NotificationIdParameter, createdOnString, createdByString, socialMessageString, typeString);
				SimpleMessage.Id = sysAdminUnitId;
				SimpleMessage.Header.Sender = "ESNNotification";
				MsgChannelManager manager = MsgChannelManager.Instance;
				IMsgChannel channel = manager.FindItemByUId(sysAdminUnitId);
				if(channel != null) {
					channel.PostMessage(SimpleMessage);
				}
			}
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localNotificationIdParameter = (AddCommentNotificationUserTask.RecordId);
			NotificationIdParameter = (System.Guid)localNotificationIdParameter;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localNotificationIdParameter = (AddLikedNotificationUserTask.RecordId);
			NotificationIdParameter = (System.Guid)localNotificationIdParameter;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localNotificationIdParameter = (AddMentionNotificationUserTask.RecordId);
			NotificationIdParameter = (System.Guid)localNotificationIdParameter;
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
			var cloneItem = (ESNNotificationProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

