namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration.OpportunityManagement;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: StartOpportunityManagementProcessUserTaskSchema

	/// <exclude/>
	public class StartOpportunityManagementProcessUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public StartOpportunityManagementProcessUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public StartOpportunityManagementProcessUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba");
			RealUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba");
			Name = "StartOpportunityManagementProcessUserTask";
			CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,219,110,219,48,12,125,182,191,66,245,147,12,4,2,246,156,11,134,58,73,145,13,105,131,165,151,135,97,15,170,195,38,218,108,201,147,229,116,222,144,127,47,37,95,26,37,233,128,92,100,138,228,57,60,36,253,57,90,105,149,66,89,174,211,29,228,124,201,37,223,130,38,197,37,227,152,60,148,160,19,37,37,164,70,40,201,46,133,14,195,155,74,108,136,253,142,137,231,240,176,216,12,67,241,66,232,165,228,108,46,228,102,97,32,191,174,209,143,158,6,198,100,60,38,178,202,178,152,252,11,131,38,57,165,107,200,144,73,44,225,149,52,71,234,19,140,217,189,42,232,167,56,12,2,150,168,172,202,37,141,34,204,22,69,206,52,215,42,71,195,186,110,113,90,243,211,14,52,160,221,249,177,69,57,251,93,241,140,54,241,108,197,53,207,193,128,62,167,24,187,232,217,31,72,43,3,235,148,103,92,143,172,22,19,26,15,195,67,232,249,251,2,99,49,55,96,60,7,138,129,113,35,215,149,231,203,102,146,63,103,176,113,66,104,48,149,150,196,232,10,44,196,84,184,178,185,174,71,165,209,66,110,7,164,249,159,16,137,172,31,121,86,193,146,23,8,103,37,251,216,155,118,200,205,51,106,112,139,210,223,233,167,157,192,202,10,158,2,77,170,210,168,28,41,23,160,77,237,50,151,177,227,116,130,148,168,60,199,81,249,82,118,63,83,192,30,9,158,137,191,48,250,152,194,228,50,130,173,242,24,224,123,20,221,21,133,210,166,146,194,212,182,99,63,16,211,51,225,12,172,93,206,174,170,132,75,28,147,121,166,94,103,114,43,36,248,243,216,20,241,173,146,239,14,109,99,124,191,129,39,169,37,70,32,43,193,6,183,254,93,143,145,144,223,193,68,3,55,125,214,147,145,29,134,193,139,66,135,116,71,232,87,104,234,94,113,161,207,58,250,235,232,146,8,233,211,177,52,130,61,199,69,238,230,245,140,69,63,201,165,219,189,235,250,22,31,233,113,86,134,248,150,79,224,150,182,79,68,174,218,85,180,24,14,100,111,35,238,235,2,44,72,231,199,166,220,240,199,238,134,245,39,155,48,192,157,195,93,199,165,204,11,37,65,154,165,218,64,198,236,53,74,177,199,134,35,142,241,158,198,196,198,253,39,16,231,42,213,162,48,74,51,92,166,62,144,246,228,92,41,129,122,254,137,74,55,148,49,169,7,194,218,147,125,49,180,51,227,233,225,78,77,154,86,75,182,118,123,251,62,162,103,2,14,26,40,23,117,8,237,167,11,109,223,20,231,3,112,8,143,247,58,122,3,94,199,37,106,163,5,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateProcessSchemaUIdParameter());
			Parameters.Add(CreateOpportunityIdParameter());
			Parameters.Add(CreateCustomPropertyValuesParameter());
		}

		protected virtual ProcessSchemaParameter CreateProcessSchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("ec041f05-fa90-43a4-af0d-a50b7cc4263e"),
				Name = "ProcessSchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("842e74a2-e737-476c-b3d0-8aa3d5ddd229"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateOpportunityIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("53b1b56f-772a-4553-b19b-7cb34972c719"),
				Name = "OpportunityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCustomPropertyValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("71c068b3-6887-4bd1-be00-0685a2b7efc7"),
				Name = "CustomPropertyValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
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
			Methods.Add(CreateRunFlowEngineProcessMethod());
			Methods.Add(CreateGetProcessSchemaMethod());
			Methods.Add(CreateCanUseFlowEngineMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("be92ace7-9c33-4a2a-aa5d-920d4c19e119"),
				Name = "Terrasoft.Configuration.OpportunityManagement",
				Alias = "",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7a38fb3d-f032-4539-8468-4f1a5a6f2d8f"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a9c019f8-7264-4af6-94cb-7d457d663baf"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				ModifiedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2e2b05b4-45a6-4e68-95d6-1c6ae80daee0"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				ModifiedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("32056b0c-e780-4e2e-ac5d-b2c9d172ae46"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("288bd2c6-100f-436f-a3e9-a000d1cb2412"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				ModifiedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c77dadaf-f6a0-4cd1-ad6b-70491ef90429"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aa5e518d-3002-47df-a892-e3cdeb5a39a5"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				ModifiedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fd6cf0fb-02a0-483a-a876-b10518e20e66"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRunFlowEngineProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d7439803-a9b1-4990-84d8-3b4c8963c773"),
				Name = "RunFlowEngineProcess",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8d97d738-b50d-4a37-bb42-99cf750c5fb4"),
				Name = "processSchema",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("721bdbf0-592c-437c-99f0-b5a4abf26466"),
				Name = "nameValueMap",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,203,201,47,119,205,75,207,204,75,85,176,85,200,75,45,87,112,131,11,104,132,22,167,22,57,231,231,229,165,38,151,100,230,231,105,90,115,33,20,235,5,149,230,5,20,229,39,167,22,23,107,20,64,232,224,228,140,212,220,68,29,133,188,196,220,212,176,196,156,210,84,223,196,2,77,107,0,38,190,191,238,100,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetProcessSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d8c4f56-d601-4e55-95ec-b9c33c0ea85d"),
				Name = "GetProcessSchema",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				CreatedInPackageId = new Guid("00697402-ddea-4784-a224-dd27006293fb"),
				ResultValueTypeName = "ProcessSchema"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("37f9288a-08c0-48cf-8a12-f87db64a896f"),
				Name = "uid",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("00697402-ddea-4784-a224-dd27006293fb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,11,40,202,79,78,45,46,14,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,241,204,43,46,73,204,75,78,117,170,12,245,76,209,40,205,76,209,180,6,0,10,45,109,225,65,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCanUseFlowEngineMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3d9245a6-5dee-486c-b0aa-37b790e7b3c7"),
				Name = "CanUseFlowEngine",
				CreatedInSchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"),
				CreatedInPackageId = new Guid("00697402-ddea-4784-a224-dd27006293fb"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fe44627c-76f4-40ee-b2f9-f5b3436ed2bc"),
				Name = "processSchema",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchema",
				CreatedInPackageId = new Guid("00697402-ddea-4784-a224-dd27006293fb")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,40,202,79,78,45,46,14,78,206,72,205,77,244,77,204,75,76,79,45,210,115,79,45,113,78,204,11,45,78,117,203,201,47,119,205,75,207,204,75,213,0,242,138,156,243,243,242,82,147,75,50,243,243,116,20,10,144,53,106,90,3,0,143,15,77,101,79,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new StartOpportunityManagementProcessUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new StartOpportunityManagementProcessUserTask(userConnection) {
				SchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba")
			};
		}

		#endregion

	}

	#endregion

	#region Class: StartOpportunityManagementProcessUserTask

	[DesignModeProperty(Name = "ProcessSchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c5d7981de1a342e493e7ced58a337bba", CaptionResourceItem = "Parameters.ProcessSchemaUId.Caption", DescriptionResourceItem = "Parameters.ProcessSchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OpportunityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c5d7981de1a342e493e7ced58a337bba", CaptionResourceItem = "Parameters.OpportunityId.Caption", DescriptionResourceItem = "Parameters.OpportunityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CustomPropertyValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "c5d7981de1a342e493e7ced58a337bba", CaptionResourceItem = "Parameters.CustomPropertyValues.Caption", DescriptionResourceItem = "Parameters.CustomPropertyValues.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class StartOpportunityManagementProcessUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public StartOpportunityManagementProcessUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("c5d7981d-e1a3-42e4-93e7-ced58a337bba");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ProcessSchemaUId {
			get;
			set;
		}

		public virtual Guid OpportunityId {
			get;
			set;
		}

		public virtual string CustomPropertyValues {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			ProcessSchemaManager processSchemaManager = UserConnection.ProcessSchemaManager;
			Guid uid = ProcessSchemaUId;
			if (processSchemaManager.FindItemByUId(ProcessSchemaUId) == null) {
				uid = ((Select)new Select(UserConnection).Top(1)
					.Column("UId")
					.From("SysSchema")
					.Where("Id").IsEqual(Column.Parameter(ProcessSchemaUId)))
					.ExecuteScalar<Guid>();
			}
			ProcessSchema processSchema = GetProcessSchema(uid);
			if (!processSchema.Enabled) {
				return true;
			}
			Dictionary<string, string> nameValueMap = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(CustomPropertyValues)) {
				nameValueMap = Common.Json.Json.Deserialize<Dictionary<string, string>>(CustomPropertyValues);
			}
			nameValueMap["OpportunityId"] = OpportunityId.ToString();
			if (CanUseFlowEngine(processSchema)) {
				RunFlowEngineProcess(processSchema, nameValueMap);
			} else {
				Process process = processSchema.CreateProcess(UserConnection);
				foreach (KeyValuePair<string, string> keyValuePair in nameValueMap) {
					var parameter = processSchema.Parameters.FindByName(keyValuePair.Key);
					if (parameter  != null){
						var valueType = parameter.DataValueType.ValueType;
						System.ComponentModel.TypeConverter typeConverter = 
							System.ComponentModel.TypeDescriptor.GetConverter(valueType);
						object value = typeConverter.ConvertFromString(keyValuePair.Value);
						process.SetPropertyValue(keyValuePair.Key, value);
					}
				}
				process.Execute(UserConnection);
			}
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

		public virtual void RunFlowEngineProcess(ProcessSchema processSchema, Dictionary<string, string> nameValueMap) {
			var flowEngine = new FlowEngine(UserConnection);
			flowEngine.RunProcess(processSchema, nameValueMap);
		}

		public virtual ProcessSchema GetProcessSchema(Guid uid) {
			return UserConnection.ProcessSchemaManager.GetInstanceByUId(uid);
		}

		public virtual bool CanUseFlowEngine(ProcessSchema processSchema) {
			return ProcessSchemaManager.GetCanUseFlowEngine(UserConnection, processSchema);
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ProcessSchemaUId")) {
				writer.WriteValue("ProcessSchemaUId", ProcessSchemaUId, Guid.Empty);
			}
			if (!HasMapping("OpportunityId")) {
				writer.WriteValue("OpportunityId", OpportunityId, Guid.Empty);
			}
			if (!HasMapping("CustomPropertyValues")) {
				writer.WriteValue("CustomPropertyValues", CustomPropertyValues, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ProcessSchemaUId":
					ProcessSchemaUId = reader.GetGuidValue();
				break;
				case "OpportunityId":
					OpportunityId = reader.GetGuidValue();
				break;
				case "CustomPropertyValues":
					CustomPropertyValues = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

