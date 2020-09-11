namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: IntegrationLogSchema

	/// <exclude/>
	public class IntegrationLogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public IntegrationLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public IntegrationLogSchema(IntegrationLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public IntegrationLogSchema(IntegrationLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086");
			RealUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086");
			Name = "IntegrationLog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cc2ebf21-ef2d-4ef3-80da-6345649c70c9")) == null) {
				Columns.Add(CreateIntegrationSystemColumn());
			}
			if (Columns.FindByUId(new Guid("0712b7db-3846-47e5-b735-6fc5d962f759")) == null) {
				Columns.Add(CreateSessionNumberColumn());
			}
			if (Columns.FindByUId(new Guid("0c2b0beb-339d-4e42-bba6-3f06267b831b")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("4f45a347-95cf-4c1b-be43-be69fc62806d")) == null) {
				Columns.Add(CreateDirectionColumn());
			}
			if (Columns.FindByUId(new Guid("384024d7-330a-4487-90e8-a8bbaf58bb49")) == null) {
				Columns.Add(CreateOperationColumn());
			}
			if (Columns.FindByUId(new Guid("40ad9faa-f737-4828-83d4-90c845b435a5")) == null) {
				Columns.Add(CreateResultColumn());
			}
			if (Columns.FindByUId(new Guid("e272fb1a-d751-4cbe-b633-f24086f64cf2")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("98bfc088-c17b-4fdd-bafd-fa59253b2c66")) == null) {
				Columns.Add(CreateErrorDescriptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIntegrationSystemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cc2ebf21-ef2d-4ef3-80da-6345649c70c9"),
				Name = @"IntegrationSystem",
				ReferenceSchemaUId = new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateSessionNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0712b7db-3846-47e5-b735-6fc5d962f759"),
				Name = @"SessionNumber",
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("0c2b0beb-339d-4e42-bba6-3f06267b831b"),
				Name = @"Date",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDirectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4f45a347-95cf-4c1b-be43-be69fc62806d"),
				Name = @"Direction",
				ReferenceSchemaUId = new Guid("0ad85e2e-9a97-41f2-9fe5-7e6b8af16844"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateOperationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("384024d7-330a-4487-90e8-a8bbaf58bb49"),
				Name = @"Operation",
				ReferenceSchemaUId = new Guid("e8feefe8-3d22-4f8d-aca2-32d180f7fa92"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("40ad9faa-f737-4828-83d4-90c845b435a5"),
				Name = @"Result",
				ReferenceSchemaUId = new Guid("fb695ee6-670b-4dc7-9118-7df4ccf95ed7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("e272fb1a-d751-4cbe-b633-f24086f64cf2"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("98bfc088-c17b-4fdd-bafd-fa59253b2c66"),
				Name = @"ErrorDescription",
				CreatedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				ModifiedInSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateIntegrationLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateIntegrationLogEventsProcessSchema() {
			var schema = new IntegrationLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new IntegrationLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new IntegrationLog_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new IntegrationLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new IntegrationLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"));
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLog

	/// <summary>
	/// Integration log.
	/// </summary>
	public class IntegrationLog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public IntegrationLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "IntegrationLog";
		}

		public IntegrationLog(IntegrationLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid IntegrationSystemId {
			get {
				return GetTypedColumnValue<Guid>("IntegrationSystemId");
			}
			set {
				SetColumnValue("IntegrationSystemId", value);
				_integrationSystem = null;
			}
		}

		/// <exclude/>
		public string IntegrationSystemName {
			get {
				return GetTypedColumnValue<string>("IntegrationSystemName");
			}
			set {
				SetColumnValue("IntegrationSystemName", value);
				if (_integrationSystem != null) {
					_integrationSystem.Name = value;
				}
			}
		}

		private IntegrationSystem _integrationSystem;
		/// <summary>
		/// Integration system.
		/// </summary>
		public IntegrationSystem IntegrationSystem {
			get {
				return _integrationSystem ??
					(_integrationSystem = LookupColumnEntities.GetEntity("IntegrationSystem") as IntegrationSystem);
			}
		}

		/// <summary>
		/// Session number.
		/// </summary>
		public int SessionNumber {
			get {
				return GetTypedColumnValue<int>("SessionNumber");
			}
			set {
				SetColumnValue("SessionNumber", value);
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <exclude/>
		public Guid DirectionId {
			get {
				return GetTypedColumnValue<Guid>("DirectionId");
			}
			set {
				SetColumnValue("DirectionId", value);
				_direction = null;
			}
		}

		/// <exclude/>
		public string DirectionName {
			get {
				return GetTypedColumnValue<string>("DirectionName");
			}
			set {
				SetColumnValue("DirectionName", value);
				if (_direction != null) {
					_direction.Name = value;
				}
			}
		}

		private IntegrationDirection _direction;
		/// <summary>
		/// Direction.
		/// </summary>
		public IntegrationDirection Direction {
			get {
				return _direction ??
					(_direction = LookupColumnEntities.GetEntity("Direction") as IntegrationDirection);
			}
		}

		/// <exclude/>
		public Guid OperationId {
			get {
				return GetTypedColumnValue<Guid>("OperationId");
			}
			set {
				SetColumnValue("OperationId", value);
				_operation = null;
			}
		}

		/// <exclude/>
		public string OperationName {
			get {
				return GetTypedColumnValue<string>("OperationName");
			}
			set {
				SetColumnValue("OperationName", value);
				if (_operation != null) {
					_operation.Name = value;
				}
			}
		}

		private IntegrationOperation _operation;
		/// <summary>
		/// Operation.
		/// </summary>
		public IntegrationOperation Operation {
			get {
				return _operation ??
					(_operation = LookupColumnEntities.GetEntity("Operation") as IntegrationOperation);
			}
		}

		/// <exclude/>
		public Guid ResultId {
			get {
				return GetTypedColumnValue<Guid>("ResultId");
			}
			set {
				SetColumnValue("ResultId", value);
				_result = null;
			}
		}

		/// <exclude/>
		public string ResultName {
			get {
				return GetTypedColumnValue<string>("ResultName");
			}
			set {
				SetColumnValue("ResultName", value);
				if (_result != null) {
					_result.Name = value;
				}
			}
		}

		private IntegrationResult _result;
		/// <summary>
		/// Result.
		/// </summary>
		public IntegrationResult Result {
			get {
				return _result ??
					(_result = LookupColumnEntities.GetEntity("Result") as IntegrationResult);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Error details.
		/// </summary>
		public string ErrorDescription {
			get {
				return GetTypedColumnValue<string>("ErrorDescription");
			}
			set {
				SetColumnValue("ErrorDescription", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new IntegrationLog_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("IntegrationLogDeleted", e);
			Deleting += (s, e) => ThrowEvent("IntegrationLogDeleting", e);
			Inserting += (s, e) => ThrowEvent("IntegrationLogInserting", e);
			Saving += (s, e) => ThrowEvent("IntegrationLogSaving", e);
			Validating += (s, e) => ThrowEvent("IntegrationLogValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntegrationLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLog_BaseEventsProcess

	/// <exclude/>
	public partial class IntegrationLog_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : IntegrationLog
	{

		public IntegrationLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IntegrationLog_BaseEventsProcess";
			SchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _integrationLogEventSubProcess;
		public ProcessFlowElement IntegrationLogEventSubProcess {
			get {
				return _integrationLogEventSubProcess ?? (_integrationLogEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "IntegrationLogEventSubProcess",
					SchemaElementUId = new Guid("c277160d-4a50-4519-a473-356332dfadf5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _integrationLogInsertingStartMessage;
		public ProcessFlowElement IntegrationLogInsertingStartMessage {
			get {
				return _integrationLogInsertingStartMessage ?? (_integrationLogInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IntegrationLogInsertingStartMessage",
					SchemaElementUId = new Guid("eaeb9c4a-d166-4866-b55b-0873436da347"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _integrationLogSavingStartMessage;
		public ProcessFlowElement IntegrationLogSavingStartMessage {
			get {
				return _integrationLogSavingStartMessage ?? (_integrationLogSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IntegrationLogSavingStartMessage",
					SchemaElementUId = new Guid("bf3a5391-db38-4a89-8685-07f1be7ba68b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _integrationLogDeletingStartMessage;
		public ProcessFlowElement IntegrationLogDeletingStartMessage {
			get {
				return _integrationLogDeletingStartMessage ?? (_integrationLogDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "IntegrationLogDeletingStartMessage",
					SchemaElementUId = new Guid("f789eeda-4e58-4a07-9dfc-822b07ec308b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _integrationLogCheckCanExecuteOperationsScriptTask;
		public ProcessScriptTask IntegrationLogCheckCanExecuteOperationsScriptTask {
			get {
				return _integrationLogCheckCanExecuteOperationsScriptTask ?? (_integrationLogCheckCanExecuteOperationsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "IntegrationLogCheckCanExecuteOperationsScriptTask",
					SchemaElementUId = new Guid("287bacc9-0174-496a-96de-319678893477"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = IntegrationLogCheckCanExecuteOperationsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[IntegrationLogEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { IntegrationLogEventSubProcess };
			FlowElements[IntegrationLogInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { IntegrationLogInsertingStartMessage };
			FlowElements[IntegrationLogSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { IntegrationLogSavingStartMessage };
			FlowElements[IntegrationLogDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { IntegrationLogDeletingStartMessage };
			FlowElements[IntegrationLogCheckCanExecuteOperationsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { IntegrationLogCheckCanExecuteOperationsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "IntegrationLogEventSubProcess":
						break;
					case "IntegrationLogInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("IntegrationLogCheckCanExecuteOperationsScriptTask");
						break;
					case "IntegrationLogSavingStartMessage":
						e.Context.QueueTasks.Enqueue("IntegrationLogCheckCanExecuteOperationsScriptTask");
						break;
					case "IntegrationLogDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("IntegrationLogCheckCanExecuteOperationsScriptTask");
						break;
					case "IntegrationLogCheckCanExecuteOperationsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("IntegrationLogInsertingStartMessage");
			ActivatedEventElements.Add("IntegrationLogSavingStartMessage");
			ActivatedEventElements.Add("IntegrationLogDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "IntegrationLogEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "IntegrationLogInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntegrationLogInsertingStartMessage";
					result = IntegrationLogInsertingStartMessage.Execute(context);
					break;
				case "IntegrationLogSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntegrationLogSavingStartMessage";
					result = IntegrationLogSavingStartMessage.Execute(context);
					break;
				case "IntegrationLogDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntegrationLogDeletingStartMessage";
					result = IntegrationLogDeletingStartMessage.Execute(context);
					break;
				case "IntegrationLogCheckCanExecuteOperationsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntegrationLogCheckCanExecuteOperationsScriptTask";
					result = IntegrationLogCheckCanExecuteOperationsScriptTask.Execute(context, IntegrationLogCheckCanExecuteOperationsScriptTaskExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
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

		#endregion

		#region Methods: Public

		public virtual bool IntegrationLogCheckCanExecuteOperationsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "IntegrationLogInserting":
							if (ActivatedEventElements.Contains("IntegrationLogInsertingStartMessage")) {
							context.QueueTasks.Enqueue("IntegrationLogInsertingStartMessage");
						}
						break;
					case "IntegrationLogSaving":
							if (ActivatedEventElements.Contains("IntegrationLogSavingStartMessage")) {
							context.QueueTasks.Enqueue("IntegrationLogSavingStartMessage");
						}
						break;
					case "IntegrationLogDeleting":
							if (ActivatedEventElements.Contains("IntegrationLogDeletingStartMessage")) {
							context.QueueTasks.Enqueue("IntegrationLogDeletingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationLog_BaseEventsProcess

	/// <exclude/>
	public class IntegrationLog_BaseEventsProcess : IntegrationLog_BaseEventsProcess<IntegrationLog>
	{

		public IntegrationLog_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IntegrationLog_BaseEventsProcess

	public partial class IntegrationLog_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: IntegrationLogEventsProcessSchema

	/// <exclude/>
	public class IntegrationLogEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public IntegrationLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public IntegrationLogEventsProcessSchema(IntegrationLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "IntegrationLog_BaseEventsProcess";
			UId = new Guid("dfadceca-2179-47e4-a579-04f787228da5");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaIntegrationLogLaneSet = CreateIntegrationLogLaneSetLaneSet();
			LaneSets.Add(schemaIntegrationLogLaneSet);
			ProcessSchemaLane schemaIntegrationLogLane = CreateIntegrationLogLaneLane();
			schemaIntegrationLogLaneSet.Lanes.Add(schemaIntegrationLogLane);
			ProcessSchemaEventSubProcess integrationlogeventsubprocess = CreateIntegrationLogEventSubProcessEventSubProcess();
			FlowElements.Add(integrationlogeventsubprocess);
			ProcessSchemaStartMessageEvent integrationloginsertingstartmessage = CreateIntegrationLogInsertingStartMessageStartMessageEvent();
			integrationlogeventsubprocess.FlowElements.Add(integrationloginsertingstartmessage);
			ProcessSchemaStartMessageEvent integrationlogsavingstartmessage = CreateIntegrationLogSavingStartMessageStartMessageEvent();
			integrationlogeventsubprocess.FlowElements.Add(integrationlogsavingstartmessage);
			ProcessSchemaStartMessageEvent integrationlogdeletingstartmessage = CreateIntegrationLogDeletingStartMessageStartMessageEvent();
			integrationlogeventsubprocess.FlowElements.Add(integrationlogdeletingstartmessage);
			ProcessSchemaScriptTask integrationlogcheckcanexecuteoperationsscripttask = CreateIntegrationLogCheckCanExecuteOperationsScriptTaskScriptTask();
			FlowElements.Add(integrationlogcheckcanexecuteoperationsscripttask);
			FlowElements.Add(CreateIntegrationLogInsertingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateIntegrationLogSavingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateIntegrationLogDeletingSequenceFlowSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateIntegrationLogInsertingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "IntegrationLogInsertingSequenceFlow",
				UId = new Guid("3509b305-b90d-4153-b2c6-85b36438233c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				CurveCenterPosition = new Point(244, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eaeb9c4a-d166-4866-b55b-0873436da347"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("287bacc9-0174-496a-96de-319678893477"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateIntegrationLogSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "IntegrationLogSavingSequenceFlow",
				UId = new Guid("eb1e4e7c-e7a5-4c86-89ed-9e80d9ae82d7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				CurveCenterPosition = new Point(228, 125),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf3a5391-db38-4a89-8685-07f1be7ba68b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("287bacc9-0174-496a-96de-319678893477"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateIntegrationLogDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "IntegrationLogDeletingSequenceFlow",
				UId = new Guid("31f777be-eba2-4423-9905-0d6f0c20cb93"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				CurveCenterPosition = new Point(225, 159),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f789eeda-4e58-4a07-9dfc-822b07ec308b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("287bacc9-0174-496a-96de-319678893477"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateIntegrationLogLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaIntegrationLogLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a75b584d-e163-48e3-a534-6282c763f17c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Name = @"IntegrationLogLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(796, 256),
				UseBackgroundMode = false
			};
			return schemaIntegrationLogLaneSet;
		}

		protected virtual ProcessSchemaLane CreateIntegrationLogLaneLane() {
			ProcessSchemaLane schemaIntegrationLogLane = new ProcessSchemaLane(this) {
				UId = new Guid("edcaf452-0ea0-4232-8f64-f44c4ae8f889"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a75b584d-e163-48e3-a534-6282c763f17c"),
				CreatedInOwnerSchemaUId = new Guid("d5bb4bdc-06d3-4275-8d23-96ae2a19b086"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Name = @"IntegrationLogLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(767, 256),
				UseBackgroundMode = false
			};
			return schemaIntegrationLogLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateIntegrationLogEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaIntegrationLogEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c277160d-4a50-4519-a473-356332dfadf5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edcaf452-0ea0-4232-8f64-f44c4ae8f889"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Name = @"IntegrationLogEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(154, 233),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaIntegrationLogEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIntegrationLogInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("eaeb9c4a-d166-4866-b55b-0873436da347"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c277160d-4a50-4519-a473-356332dfadf5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"IntegrationLogInserting",
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Name = @"IntegrationLogInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIntegrationLogSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bf3a5391-db38-4a89-8685-07f1be7ba68b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c277160d-4a50-4519-a473-356332dfadf5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"IntegrationLogSaving",
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Name = @"IntegrationLogSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 98),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateIntegrationLogDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f789eeda-4e58-4a07-9dfc-822b07ec308b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c277160d-4a50-4519-a473-356332dfadf5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"IntegrationLogDeleting",
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Name = @"IntegrationLogDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateIntegrationLogCheckCanExecuteOperationsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("287bacc9-0174-496a-96de-319678893477"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edcaf452-0ea0-4232-8f64-f44c4ae8f889"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("e9b28642-acb7-4727-a3d6-6b2ec7e400a4"),
				CreatedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("dfadceca-2179-47e4-a579-04f787228da5"),
				Name = @"IntegrationLogCheckCanExecuteOperationsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(260, 93),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,29,83,114,51,243,50,139,75,32,18,74,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,208,129,106,2,98,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntegrationLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfadceca-2179-47e4-a579-04f787228da5"));
		}

		#endregion

	}

	#endregion


	#region Class: IntegrationLogEventsProcess

	/// <exclude/>
	public class IntegrationLogEventsProcess : IntegrationLog_BaseEventsProcess
	{

		public IntegrationLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

