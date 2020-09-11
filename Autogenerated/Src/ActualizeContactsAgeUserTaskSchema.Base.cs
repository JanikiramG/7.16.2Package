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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ActualizeContactsAgeUserTaskSchema

	/// <exclude/>
	public class ActualizeContactsAgeUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ActualizeContactsAgeUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ActualizeContactsAgeUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb");
			RealUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb");
			Name = "ActualizeContactsAgeUserTask";
			CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,106,195,48,16,132,207,245,83,8,157,28,8,122,129,80,168,107,19,40,244,199,196,105,239,66,25,185,162,138,4,171,21,169,91,250,238,149,75,154,75,125,232,69,172,118,71,243,205,234,70,182,49,176,54,220,24,206,218,187,15,80,51,66,152,165,230,181,8,56,137,37,125,253,156,64,101,16,96,216,197,176,22,237,107,14,111,67,153,174,197,131,126,239,48,18,240,100,123,77,218,123,120,151,142,103,73,79,209,32,37,23,198,14,94,79,171,77,229,172,168,239,210,197,189,241,126,7,19,233,176,18,159,213,213,82,44,181,203,225,210,168,139,195,151,128,79,248,151,252,118,234,65,46,30,234,78,51,182,20,75,172,185,218,199,217,166,218,131,72,167,104,89,181,145,80,142,96,221,152,73,207,43,170,97,74,3,152,75,242,164,74,209,193,190,104,159,255,254,132,148,247,58,113,1,255,66,127,158,207,20,41,207,52,119,132,122,140,39,53,95,10,152,192,153,130,96,202,216,200,111,2,4,70,22,160,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateDateFromParameter());
			Parameters.Add(CreateDateToParameter());
			Parameters.Add(CreateIsActualizeAllRecordParameter());
			Parameters.Add(CreateChunkSizeParameter());
			Parameters.Add(CreateMaxDegreeOfParallelismParameter());
			Parameters.Add(CreateChunkProcessingDelayParameter());
		}

		protected virtual ProcessSchemaParameter CreateDateFromParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("4c0e5ec3-a043-4126-9fbd-a7b4fcc6b7f9"),
				Name = "DateFrom",
				DataValueType = DataValueTypeManager.GetInstanceByName("Date"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDateToParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("54371e2d-e3a6-4116-903b-646824ca0600"),
				Name = "DateTo",
				DataValueType = DataValueTypeManager.GetInstanceByName("Date"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsActualizeAllRecordParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("5164fe00-7a42-4d3c-8be2-a7ec1c562a6c"),
				Name = "IsActualizeAllRecord",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkSizeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bda69c67-6147-49e1-8db9-e2ddce36f858"),
				Name = "ChunkSize",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxDegreeOfParallelismParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f6e37510-fdca-43d5-9b59-2d5879aa1ede"),
				Name = "MaxDegreeOfParallelism",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkProcessingDelayParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("914f7693-4614-4685-851c-a66f01a47dc6"),
				Name = "ChunkProcessingDelay",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
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
			Methods.Add(CreateSynchronizeParametersMethod());
			Methods.Add(CreateGetNotificationDataMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bac265dc-06aa-4fd1-8c71-dd2690cd87f5"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6746b4d2-00e6-4060-b77d-4e9d82cb3a36"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6391eb2c-6735-4fd4-b6fb-1391d9fc2d57"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("42c464a9-9677-4bbd-86c1-308caea3de84")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7aad6ce8-372b-4f69-b414-9418512ab4f8"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c9b9a9f6-04d5-4d37-8a31-13f3f8869554"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				ModifiedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d3151137-c9e4-47ac-9efc-4cf231922536"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				ModifiedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("98108804-d6c4-48c5-a334-be3e61941de1"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9e5b9841-f593-406e-a53a-69a10ac50222"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				ModifiedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d9844ab-33e8-4b4e-9f7e-e436b870370f"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2c76e749-2325-4a7d-8b80-42f9864f9c72"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				ModifiedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bd1cd2f9-d747-44a4-a49b-aa4665d79042"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("49cefb71-65a9-49f4-8629-dd822f9636fa"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ecab1dce-3640-4b24-81e6-1781bba27099"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8720af74-3956-4805-b56a-62d9f5d5a797"),
				Name = "target",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("121669e3-bd1b-4473-b36b-990fa0bf32d2"),
				Name = "SynchronizeParameters",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c6d2d089-624c-4ff2-85d2-32595f1ca60c"),
				Name = "schemaElement",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,13,72,44,74,204,77,45,73,45,42,214,40,78,206,72,205,77,116,205,73,205,77,205,43,209,180,6,0,231,209,250,48,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2fcbde52-645c-46dc-b05e-24d15ebc22be"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"),
				CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283"),
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
			return new ActualizeContactsAgeUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ActualizeContactsAgeUserTask(userConnection) {
				SchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ActualizeContactsAgeUserTask

	[DesignModeProperty(Name = "DateFrom", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b807605b93a34b3ab75e805e388c09bb", CaptionResourceItem = "Parameters.DateFrom.Caption", DescriptionResourceItem = "Parameters.DateFrom.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DateTo", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b807605b93a34b3ab75e805e388c09bb", CaptionResourceItem = "Parameters.DateTo.Caption", DescriptionResourceItem = "Parameters.DateTo.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActualizeAllRecord", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b807605b93a34b3ab75e805e388c09bb", CaptionResourceItem = "Parameters.IsActualizeAllRecord.Caption", DescriptionResourceItem = "Parameters.IsActualizeAllRecord.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ChunkSize", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b807605b93a34b3ab75e805e388c09bb", CaptionResourceItem = "Parameters.ChunkSize.Caption", DescriptionResourceItem = "Parameters.ChunkSize.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "MaxDegreeOfParallelism", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b807605b93a34b3ab75e805e388c09bb", CaptionResourceItem = "Parameters.MaxDegreeOfParallelism.Caption", DescriptionResourceItem = "Parameters.MaxDegreeOfParallelism.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ChunkProcessingDelay", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b807605b93a34b3ab75e805e388c09bb", CaptionResourceItem = "Parameters.ChunkProcessingDelay.Caption", DescriptionResourceItem = "Parameters.ChunkProcessingDelay.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ActualizeContactsAgeUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ActualizeContactsAgeUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b807605b-93a3-4b3a-b75e-805e388c09bb");
		}

		#endregion

		#region Properties: Public

		public virtual DateTime DateFrom {
			get;
			set;
		}

		public virtual DateTime DateTo {
			get;
			set;
		}

		public virtual bool IsActualizeAllRecord {
			get;
			set;
		}

		public virtual int ChunkSize {
			get;
			set;
		}

		public virtual int MaxDegreeOfParallelism {
			get;
			set;
		}

		public virtual int ChunkProcessingDelay {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			ContactActualizerAge contactActualizerAge = new ContactActualizerAge(UserConnection, ChunkSize, MaxDegreeOfParallelism, ChunkProcessingDelay);
			if (IsActualizeAllRecord) {
				contactActualizerAge.RunActualize();
			} else {
				contactActualizerAge.RunActualizeByPeriod(DateFrom, DateTo);
			}
			Terrasoft.Core.Configuration.SysSettings.SetDefValue(UserConnection, "LastAgeActualizationDate", DateTime.Now.Date);
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
			if (!HasMapping("DateFrom")) {
				writer.WriteValue("DateFrom", DateFrom, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("DateTo")) {
				writer.WriteValue("DateTo", DateTo, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("IsActualizeAllRecord")) {
				writer.WriteValue("IsActualizeAllRecord", IsActualizeAllRecord, false);
			}
			if (!HasMapping("ChunkSize")) {
				writer.WriteValue("ChunkSize", ChunkSize, 0);
			}
			if (!HasMapping("MaxDegreeOfParallelism")) {
				writer.WriteValue("MaxDegreeOfParallelism", MaxDegreeOfParallelism, 0);
			}
			if (!HasMapping("ChunkProcessingDelay")) {
				writer.WriteValue("ChunkProcessingDelay", ChunkProcessingDelay, 0);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "DateFrom":
					DateFrom = reader.GetDateTimeValue();
				break;
				case "DateTo":
					DateTo = reader.GetDateTimeValue();
				break;
				case "IsActualizeAllRecord":
					IsActualizeAllRecord = reader.GetBoolValue();
				break;
				case "ChunkSize":
					ChunkSize = reader.GetIntValue();
				break;
				case "MaxDegreeOfParallelism":
					MaxDegreeOfParallelism = reader.GetIntValue();
				break;
				case "ChunkProcessingDelay":
					ChunkProcessingDelay = reader.GetIntValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

