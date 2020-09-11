namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.ML;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: MLBatchPredictionUserTaskSchema

	/// <exclude/>
	public class MLBatchPredictionUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public MLBatchPredictionUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public MLBatchPredictionUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178");
			RealUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178");
			Name = "MLBatchPredictionUserTask";
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,139,221,10,69,64,16,128,239,207,83,76,174,40,121,1,63,137,58,34,91,110,60,192,218,157,162,180,83,51,67,121,123,114,235,246,251,169,163,211,50,44,86,221,58,49,250,205,233,70,97,160,5,74,104,119,43,242,183,78,137,175,172,67,45,122,51,54,159,176,138,147,252,247,253,179,137,201,161,136,33,143,123,60,11,114,75,33,224,171,83,48,227,203,123,255,188,140,122,112,0,229,3,243,232,6,214,105,248,147,143,0,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateMLModelIdParameter());
		}

		protected virtual ProcessSchemaParameter CreateMLModelIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ed7c7596-5aa7-4a45-9113-2ed432a8110f"),
				Name = "MLModelId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
			Methods.Add(CreateGetNotificationDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("50a7afe8-80af-43ad-8f57-076892821ebe"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("38557c7f-9ae6-4430-a95e-fa08acbc471a"),
				Name = "Terrasoft.Configuration.ML",
				Alias = "",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c8b7592c-8edd-4dc9-a450-623e91d1d914"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f94a752f-0171-4cea-8cac-1a68daa6b032"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("21d1b802-fa39-4d82-8358-75edaf99111e"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				ModifiedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e6fd8c32-39cf-46a8-8062-0f264af034a6"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				ModifiedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0096245e-c6b2-4fc7-9909-56d0ff5c7ca3"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3fced7c9-cc81-4548-b11a-de3f7db737b0"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				ModifiedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7455451d-6af6-4065-956d-34efbbb4e551"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3837a98e-4dbf-4397-9a63-ad9e4479eb21"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				ModifiedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0d896134-954f-426d-9351-11f941f70e12"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d4d5814a-2293-4370-98e9-113b2b176e12"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b70e52c0-face-4840-8bcd-ef04a194f280"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5438d72b-48bf-4254-88c8-bc1ddfa20c78"),
				Name = "target",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6d11cca7-aa24-488c-8c73-762d121d91ad"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178"),
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				ResultValueTypeName = "ProcessElementNotification",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,79,45,241,203,47,201,76,203,76,78,44,201,204,207,115,73,44,73,212,208,180,6,0,189,127,96,121,34,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLBatchPredictionUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7edc51db-9436-426a-aea6-9b87383ea178"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new MLBatchPredictionUserTask(userConnection) {
				SchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178")
			};
		}

		#endregion

	}

	#endregion

	#region Class: MLBatchPredictionUserTask

	[DesignModeProperty(Name = "MLModelId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "7edc51db9436426aaea69b87383ea178", CaptionResourceItem = "Parameters.MLModelId.Caption", DescriptionResourceItem = "Parameters.MLModelId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class MLBatchPredictionUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public MLBatchPredictionUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("7edc51db-9436-426a-aea6-9b87383ea178");
		}

		#endregion

		#region Properties: Public

		public virtual Guid MLModelId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var batchPredictionJob = ClassFactory.Get<IMLBatchPredictionJob>();
			batchPredictionJob.ProcessModel(UserConnection, MLModelId);
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("MLModelId")) {
				writer.WriteValue("MLModelId", MLModelId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "MLModelId":
					MLModelId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

