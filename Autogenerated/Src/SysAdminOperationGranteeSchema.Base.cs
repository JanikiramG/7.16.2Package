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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SysAdminOperationGranteeSchema

	/// <exclude/>
	public class SysAdminOperationGranteeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysAdminOperationGranteeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminOperationGranteeSchema(SysAdminOperationGranteeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminOperationGranteeSchema(SysAdminOperationGranteeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a");
			RealUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a");
			Name = "SysAdminOperationGrantee";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a64eb826-4dc1-45fb-a5ac-d768275eb719")) == null) {
				Columns.Add(CreateSysAdminOperationColumn());
			}
			if (Columns.FindByUId(new Guid("423b165f-9759-437b-b532-95ef1b78063b")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("e1f978af-3b07-4c9f-a422-c6170cd1b1a4")) == null) {
				Columns.Add(CreateCanExecuteColumn());
			}
			if (Columns.FindByUId(new Guid("9d032101-3db5-4bba-ab16-294104cd15ad")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysAdminOperationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a64eb826-4dc1-45fb-a5ac-d768275eb719"),
				Name = @"SysAdminOperation",
				ReferenceSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				ModifiedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("423b165f-9759-437b-b532-95ef1b78063b"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				ModifiedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateCanExecuteColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e1f978af-3b07-4c9f-a422-c6170cd1b1a4"),
				Name = @"CanExecute",
				CreatedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				ModifiedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9d032101-3db5-4bba-ab16-294104cd15ad"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				ModifiedInSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminOperationGranteeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminOperationGranteeEventsProcessSchema() {
			var schema = new SysAdminOperationGranteeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminOperationGrantee(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminOperationGrantee_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminOperationGranteeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminOperationGranteeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminOperationGrantee

	/// <summary>
	/// Permission granted to.
	/// </summary>
	public class SysAdminOperationGrantee : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysAdminOperationGrantee(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminOperationGrantee";
		}

		public SysAdminOperationGrantee(SysAdminOperationGrantee source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysAdminOperationId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminOperationId");
			}
			set {
				SetColumnValue("SysAdminOperationId", value);
				_sysAdminOperation = null;
			}
		}

		/// <exclude/>
		public string SysAdminOperationName {
			get {
				return GetTypedColumnValue<string>("SysAdminOperationName");
			}
			set {
				SetColumnValue("SysAdminOperationName", value);
				if (_sysAdminOperation != null) {
					_sysAdminOperation.Name = value;
				}
			}
		}

		private SysAdminOperation _sysAdminOperation;
		/// <summary>
		/// Operation.
		/// </summary>
		public SysAdminOperation SysAdminOperation {
			get {
				return _sysAdminOperation ??
					(_sysAdminOperation = LookupColumnEntities.GetEntity("SysAdminOperation") as SysAdminOperation);
			}
		}

		/// <exclude/>
		public Guid SysAdminUnitId {
			get {
				return GetTypedColumnValue<Guid>("SysAdminUnitId");
			}
			set {
				SetColumnValue("SysAdminUnitId", value);
				_sysAdminUnit = null;
			}
		}

		/// <exclude/>
		public string SysAdminUnitName {
			get {
				return GetTypedColumnValue<string>("SysAdminUnitName");
			}
			set {
				SetColumnValue("SysAdminUnitName", value);
				if (_sysAdminUnit != null) {
					_sysAdminUnit.Name = value;
				}
			}
		}

		private SysAdminUnit _sysAdminUnit;
		/// <summary>
		/// User/role.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		/// <summary>
		/// Access level.
		/// </summary>
		public bool CanExecute {
			get {
				return GetTypedColumnValue<bool>("CanExecute");
			}
			set {
				SetColumnValue("CanExecute", value);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysAdminOperationGrantee_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysAdminOperationGranteeDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysAdminOperationGranteeDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysAdminOperationGranteeInserted", e);
			Inserting += (s, e) => ThrowEvent("SysAdminOperationGranteeInserting", e);
			Saved += (s, e) => ThrowEvent("SysAdminOperationGranteeSaved", e);
			Saving += (s, e) => ThrowEvent("SysAdminOperationGranteeSaving", e);
			Updated += (s, e) => ThrowEvent("SysAdminOperationGranteeUpdated", e);
			Validating += (s, e) => ThrowEvent("SysAdminOperationGranteeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminOperationGrantee(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminOperationGrantee_BaseEventsProcess

	/// <exclude/>
	public partial class SysAdminOperationGrantee_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysAdminOperationGrantee
	{

		public SysAdminOperationGrantee_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminOperationGrantee_BaseEventsProcess";
			SchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("866cebdd-d009-445b-ad0b-8535a1e65bca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminOperationGranteeInserted_StartMessage;
		public ProcessFlowElement SysAdminOperationGranteeInserted_StartMessage {
			get {
				return _sysAdminOperationGranteeInserted_StartMessage ?? (_sysAdminOperationGranteeInserted_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminOperationGranteeInserted_StartMessage",
					SchemaElementUId = new Guid("e50cdb5f-bc9e-4e1c-a2b8-47c7e6e2a018"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminOperationGranteeInserted_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent {
			get {
				return _sysAdminOperationGranteeInserted_IntermediateThrowMessageEvent ?? (_sysAdminOperationGranteeInserted_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("5fabeb90-f222-4a7c-b38f-18532cc12256"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysAdminOperationGranteeInserted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _inserted_ScriptTask;
		public ProcessScriptTask Inserted_ScriptTask {
			get {
				return _inserted_ScriptTask ?? (_inserted_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Inserted_ScriptTask",
					SchemaElementUId = new Guid("f71f5db7-998e-49d2-8170-34d1149a2794"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Inserted_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("ca6ac841-a7fa-489c-b566-127a460fbfb6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminOperationGranteeDeleting_StartMessage;
		public ProcessFlowElement SysAdminOperationGranteeDeleting_StartMessage {
			get {
				return _sysAdminOperationGranteeDeleting_StartMessage ?? (_sysAdminOperationGranteeDeleting_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminOperationGranteeDeleting_StartMessage",
					SchemaElementUId = new Guid("012997eb-40cb-4ea0-8482-8f47f8128397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent {
			get {
				return _sysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent ?? (_sysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("18f3157c-90f4-46c1-a50c-5a7d5c52b337"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysAdminOperationGranteeDeleting",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _logDelete_ScriptTask;
		public ProcessScriptTask LogDelete_ScriptTask {
			get {
				return _logDelete_ScriptTask ?? (_logDelete_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogDelete_ScriptTask",
					SchemaElementUId = new Guid("591ef89f-616e-4692-a6b5-11d0a9131713"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogDelete_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("dc65fb93-2ff2-4f70-bcad-2b5a827d4b20"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updated_ScriptTask;
		public ProcessScriptTask Updated_ScriptTask {
			get {
				return _updated_ScriptTask ?? (_updated_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Updated_ScriptTask",
					SchemaElementUId = new Guid("5dcf602a-02b3-4529-b8a8-d140a3355d2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Updated_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysAdminOperationGranteeUpdated_StartMessage;
		public ProcessFlowElement SysAdminOperationGranteeUpdated_StartMessage {
			get {
				return _sysAdminOperationGranteeUpdated_StartMessage ?? (_sysAdminOperationGranteeUpdated_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminOperationGranteeUpdated_StartMessage",
					SchemaElementUId = new Guid("1efe4bd4-34fb-46da-8f31-d74bbfa24aab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent {
			get {
				return _sysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent ?? (_sysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("2a9fca7e-0c7e-4140-a7cd-97267300c4a6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysAdminOperationGranteeUpdated",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SysAdminOperationGranteeInserted_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminOperationGranteeInserted_StartMessage };
			FlowElements[SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent };
			FlowElements[Inserted_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Inserted_ScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SysAdminOperationGranteeDeleting_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminOperationGranteeDeleting_StartMessage };
			FlowElements[SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent };
			FlowElements[LogDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogDelete_ScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[Updated_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Updated_ScriptTask };
			FlowElements[SysAdminOperationGranteeUpdated_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminOperationGranteeUpdated_StartMessage };
			FlowElements[SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SysAdminOperationGranteeInserted_StartMessage":
						e.Context.QueueTasks.Enqueue("Inserted_ScriptTask");
						break;
					case "SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent":
						break;
					case "Inserted_ScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent");
						break;
					case "EventSubProcess2":
						break;
					case "SysAdminOperationGranteeDeleting_StartMessage":
						e.Context.QueueTasks.Enqueue("LogDelete_ScriptTask");
						break;
					case "SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent":
						break;
					case "LogDelete_ScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent");
						break;
					case "EventSubProcess3":
						break;
					case "Updated_ScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent");
						break;
					case "SysAdminOperationGranteeUpdated_StartMessage":
						e.Context.QueueTasks.Enqueue("Updated_ScriptTask");
						break;
					case "SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysAdminOperationGranteeInserted_StartMessage");
			ActivatedEventElements.Add("SysAdminOperationGranteeDeleting_StartMessage");
			ActivatedEventElements.Add("SysAdminOperationGranteeUpdated_StartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminOperationGranteeInserted_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminOperationGranteeInserted_StartMessage";
					result = SysAdminOperationGranteeInserted_StartMessage.Execute(context);
					break;
				case "SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysAdminOperationGranteeInserted");
					result = SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "Inserted_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Inserted_ScriptTask";
					result = Inserted_ScriptTask.Execute(context, Inserted_ScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminOperationGranteeDeleting_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminOperationGranteeDeleting_StartMessage";
					result = SysAdminOperationGranteeDeleting_StartMessage.Execute(context);
					break;
				case "SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysAdminOperationGranteeDeleting");
					result = SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "LogDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogDelete_ScriptTask";
					result = LogDelete_ScriptTask.Execute(context, LogDelete_ScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "Updated_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Updated_ScriptTask";
					result = Updated_ScriptTask.Execute(context, Updated_ScriptTaskExecute);
					break;
				case "SysAdminOperationGranteeUpdated_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminOperationGranteeUpdated_StartMessage";
					result = SysAdminOperationGranteeUpdated_StartMessage.Execute(context);
					break;
				case "SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysAdminOperationGranteeUpdated");
					result = SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool Inserted_ScriptTaskExecute(ProcessExecutingContext context) {
			OperationLogger.Instance.LogAdminOperationRightAdd(UserConnection, Entity.PrimaryColumnValue);
			return true;
		}

		public virtual bool LogDelete_ScriptTaskExecute(ProcessExecutingContext context) {
			OperationLogger.Instance.LogAdminOperationRightDelete(UserConnection, Entity.PrimaryColumnValue);
			return true;
		}

		public virtual bool Updated_ScriptTaskExecute(ProcessExecutingContext context) {
			var eventArgs = (context.ThrowEventArgs as Terrasoft.Core.Entities.EntityAfterEventArgs);
			var modifiedColumnValues = eventArgs.ModifiedColumnValues;
			bool positionChanged = modifiedColumnValues.FindByName("Position") != null;
			OperationLogger.Instance.LogAdminOperationRightChange(UserConnection, Entity.PrimaryColumnValue, positionChanged);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysAdminOperationGranteeInserted":
							if (ActivatedEventElements.Contains("SysAdminOperationGranteeInserted_StartMessage")) {
							context.QueueTasks.Enqueue("SysAdminOperationGranteeInserted_StartMessage");
						}
						break;
					case "SysAdminOperationGranteeDeleting":
							if (ActivatedEventElements.Contains("SysAdminOperationGranteeDeleting_StartMessage")) {
							context.QueueTasks.Enqueue("SysAdminOperationGranteeDeleting_StartMessage");
						}
						break;
					case "SysAdminOperationGranteeUpdated":
							if (ActivatedEventElements.Contains("SysAdminOperationGranteeUpdated_StartMessage")) {
							context.QueueTasks.Enqueue("SysAdminOperationGranteeUpdated_StartMessage");
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

	#region Class: SysAdminOperationGrantee_BaseEventsProcess

	/// <exclude/>
	public class SysAdminOperationGrantee_BaseEventsProcess : SysAdminOperationGrantee_BaseEventsProcess<SysAdminOperationGrantee>
	{

		public SysAdminOperationGrantee_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminOperationGrantee_BaseEventsProcess

	public partial class SysAdminOperationGrantee_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysAdminOperationGranteeEventsProcessSchema

	/// <exclude/>
	public class SysAdminOperationGranteeEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminOperationGranteeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminOperationGranteeEventsProcessSchema(SysAdminOperationGranteeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminOperationGrantee_BaseEventsProcess";
			UId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent sysadminoperationgranteeinserted_startmessage = CreateSysAdminOperationGranteeInserted_StartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminoperationgranteeinserted_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent sysadminoperationgranteeinserted_intermediatethrowmessageevent = CreateSysAdminOperationGranteeInserted_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminoperationgranteeinserted_intermediatethrowmessageevent);
			ProcessSchemaScriptTask inserted_scripttask = CreateInserted_ScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(inserted_scripttask);
			ProcessSchemaStartMessageEvent sysadminoperationgranteedeleting_startmessage = CreateSysAdminOperationGranteeDeleting_StartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(sysadminoperationgranteedeleting_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent sysadminoperationgranteedeleting_intermediatethrowmessageevent = CreateSysAdminOperationGranteeDeleting_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(sysadminoperationgranteedeleting_intermediatethrowmessageevent);
			ProcessSchemaScriptTask logdelete_scripttask = CreateLogDelete_ScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(logdelete_scripttask);
			ProcessSchemaScriptTask updated_scripttask = CreateUpdated_ScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(updated_scripttask);
			ProcessSchemaStartMessageEvent sysadminoperationgranteeupdated_startmessage = CreateSysAdminOperationGranteeUpdated_StartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(sysadminoperationgranteeupdated_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent sysadminoperationgranteeupdated_intermediatethrowmessageevent = CreateSysAdminOperationGranteeUpdated_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(sysadminoperationgranteeupdated_intermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9485635a-48ec-4709-abc6-94aa7d18a500"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				CurveCenterPosition = new Point(278, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("012997eb-40cb-4ea0-8482-8f47f8128397"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("591ef89f-616e-4692-a6b5-11d0a9131713"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b4f4d79d-379e-426e-a015-33f1d81f36c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				CurveCenterPosition = new Point(282, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e50cdb5f-bc9e-4e1c-a2b8-47c7e6e2a018"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f71f5db7-998e-49d2-8170-34d1149a2794"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("d46ed698-3b8c-48c4-bb4c-2f424771f665"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				CurveCenterPosition = new Point(278, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("591ef89f-616e-4692-a6b5-11d0a9131713"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18f3157c-90f4-46c1-a50c-5a7d5c52b337"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("84efdd82-4928-4048-9db8-b4e9b4395a18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				CurveCenterPosition = new Point(192, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1efe4bd4-34fb-46da-8f31-d74bbfa24aab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5dcf602a-02b3-4529-b8a8-d140a3355d2f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("cfa1614e-0232-4b50-8679-63e6821eb45c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				CurveCenterPosition = new Point(350, 415),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5dcf602a-02b3-4529-b8a8-d140a3355d2f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2a9fca7e-0c7e-4140-a7cd-97267300c4a6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("6faba8bb-ef3b-46d6-aaaf-edfb24807d96"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				CurveCenterPosition = new Point(282, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f71f5db7-998e-49d2-8170-34d1149a2794"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5fabeb90-f222-4a7c-b38f-18532cc12256"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0afe6112-2900-4154-8c88-b07b72e03519"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(781, 499),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("0aed757e-7222-413d-b208-247291715c2e"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0afe6112-2900-4154-8c88-b07b72e03519"),
				CreatedInOwnerSchemaUId = new Guid("3987bdc6-38bb-4b41-bcf7-90bb3995117a"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(752, 499),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("866cebdd-d009-445b-ad0b-8535a1e65bca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aed757e-7222-413d-b208-247291715c2e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminOperationGranteeInserted_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e50cdb5f-bc9e-4e1c-a2b8-47c7e6e2a018"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("866cebdd-d009-445b-ad0b-8535a1e65bca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminOperationGranteeInserted",
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"SysAdminOperationGranteeInserted_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminOperationGranteeInserted_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("5fabeb90-f222-4a7c-b38f-18532cc12256"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("866cebdd-d009-445b-ad0b-8535a1e65bca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysAdminOperationGranteeInserted",
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"SysAdminOperationGranteeInserted_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(309, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInserted_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f71f5db7-998e-49d2-8170-34d1149a2794"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("866cebdd-d009-445b-ad0b-8535a1e65bca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"Inserted_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,45,74,44,201,204,207,243,201,79,79,79,45,210,243,204,43,46,73,204,75,78,213,3,242,29,83,114,51,243,252,97,10,130,50,211,51,74,28,83,82,52,66,139,83,139,156,243,243,242,82,147,65,194,58,10,174,121,37,153,37,149,122,1,69,153,185,137,69,149,206,249,57,165,185,121,97,137,57,165,169,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,105,141,232,127,108,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ca6ac841-a7fa-489c-b566-127a460fbfb6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aed757e-7222-413d-b208-247291715c2e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminOperationGranteeDeleting_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("012997eb-40cb-4ea0-8482-8f47f8128397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca6ac841-a7fa-489c-b566-127a460fbfb6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminOperationGranteeDeleting",
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"SysAdminOperationGranteeDeleting_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminOperationGranteeDeleting_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("18f3157c-90f4-46c1-a50c-5a7d5c52b337"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca6ac841-a7fa-489c-b566-127a460fbfb6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysAdminOperationGranteeDeleting",
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"SysAdminOperationGranteeDeleting_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(309, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("591ef89f-616e-4692-a6b5-11d0a9131713"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca6ac841-a7fa-489c-b566-127a460fbfb6"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"LogDelete_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,45,74,44,201,204,207,243,201,79,79,79,45,210,243,204,43,46,73,204,75,78,213,3,242,29,83,114,51,243,252,97,10,130,50,211,51,74,92,82,115,82,75,82,53,66,139,83,139,156,243,243,242,82,147,65,50,58,10,174,121,37,153,37,149,122,1,69,153,185,137,69,149,206,249,57,165,185,121,97,137,57,165,169,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,170,202,250,175,111,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dc65fb93-2ff2-4f70-bcad-2b5a827d4b20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0aed757e-7222-413d-b208-247291715c2e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 329),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(378, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdated_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5dcf602a-02b3-4529-b8a8-d140a3355d2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc65fb93-2ff2-4f70-bcad-2b5a827d4b20"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"Updated_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,205,106,195,48,12,190,15,250,14,94,79,41,20,191,64,233,33,11,29,12,246,83,70,215,187,23,43,142,193,150,138,44,103,203,219,215,33,35,148,209,155,164,239,79,223,96,88,193,0,40,53,187,164,246,170,106,9,5,126,69,159,122,166,159,195,130,152,164,78,192,108,18,117,162,27,98,208,7,20,47,30,210,60,140,117,39,192,11,127,179,91,61,12,197,58,146,245,157,7,219,80,200,17,207,38,100,152,82,150,68,253,118,135,80,180,223,68,65,93,40,149,4,194,166,55,232,192,22,221,61,59,253,236,209,62,141,239,38,66,181,62,254,73,214,27,245,184,87,152,67,40,102,31,23,96,51,93,95,201,57,96,253,130,73,12,182,160,203,94,219,232,113,33,124,122,215,203,28,87,125,37,224,134,16,161,157,144,173,154,107,234,35,251,104,120,188,249,96,251,255,209,169,60,131,100,70,37,156,97,119,5,161,204,26,127,100,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminOperationGranteeUpdated_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1efe4bd4-34fb-46da-8f31-d74bbfa24aab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc65fb93-2ff2-4f70-bcad-2b5a827d4b20"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminOperationGranteeUpdated",
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"SysAdminOperationGranteeUpdated_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminOperationGranteeUpdated_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2a9fca7e-0c7e-4140-a7cd-97267300c4a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc65fb93-2ff2-4f70-bcad-2b5a827d4b20"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0e850392-6b68-4c42-8cac-7764bc62a6bb"),
				CreatedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysAdminOperationGranteeUpdated",
				ModifiedInSchemaUId = new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"),
				Name = @"SysAdminOperationGranteeUpdated_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(309, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
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
				UId = new Guid("7b864581-ad3d-43cc-9cde-c95d6f7c4e8a"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
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
			return new SysAdminOperationGranteeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3dff627-7abc-4d01-a87d-5ef77b346a58"));
		}

		#endregion

	}

	#endregion


	#region Class: SysAdminOperationGranteeEventsProcess

	/// <exclude/>
	public class SysAdminOperationGranteeEventsProcess : SysAdminOperationGrantee_BaseEventsProcess
	{

		public SysAdminOperationGranteeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

