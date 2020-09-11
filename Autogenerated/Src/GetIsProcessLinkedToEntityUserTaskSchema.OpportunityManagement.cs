namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: GetIsProcessLinkedToEntityUserTaskSchema

	/// <exclude/>
	public class GetIsProcessLinkedToEntityUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public GetIsProcessLinkedToEntityUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public GetIsProcessLinkedToEntityUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3");
			RealUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3");
			Name = "GetIsProcessLinkedToEntityUserTask";
			CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,148,81,111,211,48,16,199,159,155,79,97,242,228,72,149,5,175,45,27,140,170,157,42,1,43,13,211,30,208,30,172,228,182,90,74,236,238,108,83,34,196,119,231,28,123,109,90,168,120,153,120,180,239,238,127,191,255,57,151,247,249,119,137,204,86,27,104,37,187,96,183,22,112,102,180,134,202,41,163,197,92,59,229,186,178,143,126,146,90,62,2,138,133,210,245,210,65,251,161,187,93,214,124,152,177,172,139,105,118,144,163,48,41,242,164,253,234,130,105,223,52,5,123,151,194,34,196,39,140,243,18,26,106,87,100,35,13,59,22,15,252,152,163,16,51,211,248,86,243,60,167,162,60,47,196,2,77,75,167,178,179,177,117,184,187,219,0,2,93,198,140,165,157,63,121,217,240,88,41,86,18,101,11,14,240,148,184,160,198,98,254,3,42,239,160,172,100,35,241,237,181,87,245,37,79,94,192,62,145,139,128,54,44,252,226,1,59,254,239,105,141,89,15,185,66,83,129,181,31,205,35,161,77,51,210,20,87,117,157,76,133,211,218,24,23,11,197,10,85,43,177,75,220,159,137,58,85,172,205,110,102,188,118,132,243,38,178,61,168,134,28,217,115,124,139,62,76,66,77,4,12,157,158,93,13,114,99,26,137,132,38,51,4,233,32,94,221,41,183,217,207,205,242,103,185,118,43,81,89,163,191,118,91,16,253,144,199,217,40,207,191,29,124,70,146,201,225,226,254,104,54,253,27,142,15,95,9,49,37,39,97,42,252,79,182,35,232,255,136,27,57,215,80,25,172,207,96,30,1,110,99,249,11,18,198,41,76,150,245,100,127,184,23,105,126,55,59,77,235,88,158,153,226,17,11,197,212,3,227,201,94,233,164,243,150,182,143,118,50,124,235,98,222,110,93,87,176,159,67,19,49,233,5,172,132,13,232,181,2,243,9,1,113,141,254,2,61,236,77,41,191,246,198,104,129,20,237,232,205,22,80,134,47,154,192,78,175,74,135,170,114,226,74,215,113,107,22,3,249,36,147,94,11,205,206,38,103,215,224,226,139,15,150,229,228,23,52,205,214,96,125,19,182,47,20,138,184,138,151,236,245,52,67,112,30,53,115,232,97,154,255,6,231,147,196,153,81,5,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntitySchemaIdParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateProcessStatusIdParameter());
			Parameters.Add(CreateResultParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("02b52c49-239a-4cbf-9e6e-ebabb0d063e5"),
				Name = "EntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8a5fe980-f911-4d4c-b4ab-994d5495f4c0"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateProcessStatusIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3d35e2ba-d5e0-491c-b6f7-6aeaea5a19d6"),
				Name = "ProcessStatusId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("dc1e2217-9af0-4216-935b-ace805adc929"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateResultParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8193ae6b-bd1a-4de6-b046-c5d198416b7e"),
				Name = "Result",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("334bb5b5-df74-4596-a406-dc3bc61c2484"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("92f366d0-155c-461f-98ae-f2833b5936f6"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				ModifiedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1acdfda1-283a-4f61-bd4e-b08ceb7969eb"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				ModifiedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,193,106,195,64,12,68,207,245,87,136,156,28,8,254,1,183,133,144,132,156,10,46,134,94,74,15,194,86,147,133,245,110,43,105,99,76,233,191,87,241,246,96,2,185,106,70,111,102,46,200,64,242,13,79,16,104,132,67,80,167,83,219,157,105,192,215,68,60,149,73,136,119,49,4,234,212,197,80,45,13,47,24,240,68,188,129,85,59,73,195,177,35,145,86,81,147,172,214,117,97,208,106,219,247,91,239,179,123,23,125,26,130,148,38,101,136,29,124,166,2,199,81,172,193,245,229,72,122,43,223,116,48,192,197,74,51,73,242,218,32,227,64,74,108,57,111,232,19,201,255,146,189,155,205,200,211,227,49,185,126,3,162,236,194,233,249,154,255,25,153,176,59,67,57,115,226,8,46,87,88,195,79,241,112,143,251,110,142,170,97,55,24,50,111,153,239,31,150,183,80,246,78,190,60,46,13,117,241,91,48,105,226,112,183,114,253,7,162,99,64,36,133,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("caf4cb91-97ac-45c1-8d29-ddee26b4b5ac"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4165d885-90b2-404b-809f-8fdf14a9b9c4"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				ModifiedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
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
				UId = new Guid("ebd917fa-50e3-4087-892f-b593f3458dce"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3354c458-60ec-4572-9036-4e8ad4a65ed0"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				ModifiedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
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
				UId = new Guid("7e14ca17-158d-45c4-bc6a-c183e7b8bd9a"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"),
				CreatedInPackageId = new Guid("7f1915c3-7f07-42fa-9d85-bbbe0c864173"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GetIsProcessLinkedToEntityUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new GetIsProcessLinkedToEntityUserTask(userConnection) {
				SchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3")
			};
		}

		#endregion

	}

	#endregion

	#region Class: GetIsProcessLinkedToEntityUserTaskSchemaExtension

	/// <exclude/>
	public class GetIsProcessLinkedToEntityUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysProcessStatus");
			esq.AddAllSchemaColumns();
			EntityCollection rows = esq.GetEntityCollection(userConnection);
			var resultParameterAllValues = new Dictionary<Guid, string>();
			foreach (var row in rows) {
				resultParameterAllValues[row.PrimaryColumnValue] = row.PrimaryDisplayColumnValue;
			}
			return resultParameterAllValues;
		}

		#endregion

	}

	#endregion

	#region Class: GetIsProcessLinkedToEntityUserTask

	[DesignModeProperty(Name = "EntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "922701f4cd044753acb8d8a0e37f6ad3", CaptionResourceItem = "Parameters.EntitySchemaId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "922701f4cd044753acb8d8a0e37f6ad3", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ProcessStatusId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "922701f4cd044753acb8d8a0e37f6ad3", CaptionResourceItem = "Parameters.ProcessStatusId.Caption", DescriptionResourceItem = "Parameters.ProcessStatusId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Result", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "922701f4cd044753acb8d8a0e37f6ad3", CaptionResourceItem = "Parameters.Result.Caption", DescriptionResourceItem = "Parameters.Result.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class GetIsProcessLinkedToEntityUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public GetIsProcessLinkedToEntityUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("922701f4-cd04-4753-acb8-d8a0e37f6ad3");
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntitySchemaId {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual Guid ProcessStatusId {
			get;
			set;
		}

		public virtual bool Result {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var schema = UserConnection.EntitySchemaManager.FindItemByUId(EntitySchemaId);
			var schemaUId = (schema != null) ? schema.UId : ((Select)
				new Select(UserConnection).Column("UId").From("SysSchema").Where("Id").IsEqual(Column.Parameter(EntitySchemaId)))
				.ExecuteScalar<Guid>();
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysProcessLog");
			esq.AddColumn(esq.RootSchema.PrimaryColumn.Name);
			esq.RowCount = 1;
			var filters = new EntitySchemaQueryFilterCollection(esq);
			var entitySchemaFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[SysProcessEntity:SysProcess].EntitySchemaUId", schemaUId);
			filters.Add(entitySchemaFilter);
			var entityFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[SysProcessEntity:SysProcess].EntityId", RecordId);
			filters.Add(entityFilter);
			var processFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[SysSchema:Id:SysSchema].UId", Owner.SchemaUId);
			filters.Add(processFilter);
			if (ProcessStatusId != Guid.Empty) {
			var processStatusFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Status", ProcessStatusId);
				filters.Add(processStatusFilter);
			}
			filters.LogicalOperation = LogicalOperationStrict.And;
			esq.Filters.Add(filters);
			var rows = esq.GetEntityCollection(UserConnection);
			Result = rows.Count > 0;
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

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("EntitySchemaId")) {
				writer.WriteValue("EntitySchemaId", EntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("ProcessStatusId")) {
				writer.WriteValue("ProcessStatusId", ProcessStatusId, Guid.Empty);
			}
			if (!HasMapping("Result")) {
				writer.WriteValue("Result", Result, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntitySchemaId":
					EntitySchemaId = reader.GetGuidValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "ProcessStatusId":
					ProcessStatusId = reader.GetGuidValue();
				break;
				case "Result":
					Result = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

