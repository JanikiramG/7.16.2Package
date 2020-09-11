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

	#region Class: SysAdminUnitIPRangeSchema

	/// <exclude/>
	public class SysAdminUnitIPRangeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysAdminUnitIPRangeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminUnitIPRangeSchema(SysAdminUnitIPRangeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminUnitIPRangeSchema(SysAdminUnitIPRangeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			RealUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			Name = "SysAdminUnitIPRange";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("80562de5-dd61-480f-af1f-84ceefea423f")) == null) {
				Columns.Add(CreateBeginIPColumn());
			}
			if (Columns.FindByUId(new Guid("3df16c98-3a83-4b7b-94b0-c138ba6ded0d")) == null) {
				Columns.Add(CreateEndIPColumn());
			}
			if (Columns.FindByUId(new Guid("1e3c68d3-97a9-45a6-ae30-951580afc7c5")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			column.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			column.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			column.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			column.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			column.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			column.CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBeginIPColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("80562de5-dd61-480f-af1f-84ceefea423f"),
				Name = @"BeginIP",
				CreatedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"),
				ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			};
		}

		protected virtual EntitySchemaColumn CreateEndIPColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3df16c98-3a83-4b7b-94b0-c138ba6ded0d"),
				Name = @"EndIP",
				CreatedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"),
				ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			};
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1e3c68d3-97a9-45a6-ae30-951580afc7c5"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"),
				ModifiedInSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"),
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminUnitIPRangeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminUnitIPRangeEventsProcessSchema() {
			var schema = new SysAdminUnitIPRangeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminUnitIPRange(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminUnitIPRange_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminUnitIPRangeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminUnitIPRangeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRange

	/// <summary>
	/// IP range.
	/// </summary>
	public class SysAdminUnitIPRange : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysAdminUnitIPRange(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminUnitIPRange";
		}

		public SysAdminUnitIPRange(SysAdminUnitIPRange source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Start IP address.
		/// </summary>
		public string BeginIP {
			get {
				return GetTypedColumnValue<string>("BeginIP");
			}
			set {
				SetColumnValue("BeginIP", value);
			}
		}

		/// <summary>
		/// End IP address.
		/// </summary>
		public string EndIP {
			get {
				return GetTypedColumnValue<string>("EndIP");
			}
			set {
				SetColumnValue("EndIP", value);
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
		/// Object.
		/// </summary>
		public SysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as SysAdminUnit);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysAdminUnitIPRange_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysAdminUnitIPRangeDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysAdminUnitIPRangeDeleting", e);
			Inserting += (s, e) => ThrowEvent("SysAdminUnitIPRangeInserting", e);
			Saved += (s, e) => ThrowEvent("SysAdminUnitIPRangeSaved", e);
			Saving += (s, e) => ThrowEvent("SysAdminUnitIPRangeSaving", e);
			Validating += (s, e) => ThrowEvent("SysAdminUnitIPRangeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminUnitIPRange(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRange_BaseEventsProcess

	/// <exclude/>
	public partial class SysAdminUnitIPRange_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysAdminUnitIPRange
	{

		public SysAdminUnitIPRange_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminUnitIPRange_BaseEventsProcess";
			SchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual string AdminUnitName {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("70bac210-61ba-4444-b50c-575288f98f25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitIPRangeSaved_StartMessage;
		public ProcessFlowElement SysAdminUnitIPRangeSaved_StartMessage {
			get {
				return _sysAdminUnitIPRangeSaved_StartMessage ?? (_sysAdminUnitIPRangeSaved_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitIPRangeSaved_StartMessage",
					SchemaElementUId = new Guid("e11386a7-5da6-487d-b415-b987eafae95e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent {
			get {
				return _sysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent ?? (_sysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("c2b2dfc0-e59e-4a1f-8551-d0607663b1f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysAdminUnitIPRangeSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _logSave_ScriptTask;
		public ProcessScriptTask LogSave_ScriptTask {
			get {
				return _logSave_ScriptTask ?? (_logSave_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogSave_ScriptTask",
					SchemaElementUId = new Guid("c7d5f13d-ae26-4efc-97ca-5b4e5289197a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogSave_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("da4fecdd-fde3-4a7b-b3bb-c610ded2e81a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitIPRangeDeleted_StartMessage;
		public ProcessFlowElement SysAdminUnitIPRangeDeleted_StartMessage {
			get {
				return _sysAdminUnitIPRangeDeleted_StartMessage ?? (_sysAdminUnitIPRangeDeleted_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitIPRangeDeleted_StartMessage",
					SchemaElementUId = new Guid("5ea447b2-2e91-426f-a427-56d142ad8f04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent {
			get {
				return _sysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent ?? (_sysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("ab11b8bd-723f-4609-8dc5-2a9b4d5f64d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysAdminUnitIPRangeDeleted",
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
					SchemaElementUId = new Guid("4f64a6c3-b88f-41af-8400-b5a9591cfbce"),
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
					SchemaElementUId = new Guid("e9bee84e-c359-4b2a-a3a5-bf54e0e94c54"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitIPRangeDeleting_StartMessage;
		public ProcessFlowElement SysAdminUnitIPRangeDeleting_StartMessage {
			get {
				return _sysAdminUnitIPRangeDeleting_StartMessage ?? (_sysAdminUnitIPRangeDeleting_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitIPRangeDeleting_StartMessage",
					SchemaElementUId = new Guid("9577f9b9-71fa-46d6-9aa5-3d731c8f71a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _sysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent {
			get {
				return _sysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent ?? (_sysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("e9eedd7b-c7e7-47c4-937a-5fb132e750c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SysAdminUnitIPRangeDeleting",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _getAdminUnit_ScriptTask;
		public ProcessScriptTask GetAdminUnit_ScriptTask {
			get {
				return _getAdminUnit_ScriptTask ?? (_getAdminUnit_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "GetAdminUnit_ScriptTask",
					SchemaElementUId = new Guid("c8a66c40-97b7-49c6-b729-71ed34a3013b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = GetAdminUnit_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("23ee951e-642e-4ba5-9bb3-c489d6b12442"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysAdminUnitIPRangeSaving;
		public ProcessFlowElement SysAdminUnitIPRangeSaving {
			get {
				return _sysAdminUnitIPRangeSaving ?? (_sysAdminUnitIPRangeSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysAdminUnitIPRangeSaving",
					SchemaElementUId = new Guid("89288b34-e6f9-40bb-8379-a1f4d3f7a731"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("a56e1fb6-ea80-46c3-a226-f375289003b5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SysAdminUnitIPRangeSaved_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeSaved_StartMessage };
			FlowElements[SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent };
			FlowElements[LogSave_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogSave_ScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SysAdminUnitIPRangeDeleted_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeDeleted_StartMessage };
			FlowElements[SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent };
			FlowElements[LogDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogDelete_ScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[SysAdminUnitIPRangeDeleting_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeDeleting_StartMessage };
			FlowElements[SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent };
			FlowElements[GetAdminUnit_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GetAdminUnit_ScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[SysAdminUnitIPRangeSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminUnitIPRangeSaving };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SysAdminUnitIPRangeSaved_StartMessage":
						e.Context.QueueTasks.Enqueue("LogSave_ScriptTask");
						break;
					case "SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent":
						break;
					case "LogSave_ScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent");
						break;
					case "EventSubProcess2":
						break;
					case "SysAdminUnitIPRangeDeleted_StartMessage":
						e.Context.QueueTasks.Enqueue("LogDelete_ScriptTask");
						break;
					case "SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent":
						break;
					case "LogDelete_ScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent");
						break;
					case "EventSubProcess3":
						break;
					case "SysAdminUnitIPRangeDeleting_StartMessage":
						e.Context.QueueTasks.Enqueue("GetAdminUnit_ScriptTask");
						break;
					case "SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent":
						break;
					case "GetAdminUnit_ScriptTask":
						e.Context.QueueTasks.Enqueue("SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent");
						break;
					case "EventSubProcess4":
						break;
					case "SysAdminUnitIPRangeSaving":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysAdminUnitIPRangeSaved_StartMessage");
			ActivatedEventElements.Add("SysAdminUnitIPRangeDeleted_StartMessage");
			ActivatedEventElements.Add("SysAdminUnitIPRangeDeleting_StartMessage");
			ActivatedEventElements.Add("SysAdminUnitIPRangeSaving");
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
				case "SysAdminUnitIPRangeSaved_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitIPRangeSaved_StartMessage";
					result = SysAdminUnitIPRangeSaved_StartMessage.Execute(context);
					break;
				case "SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysAdminUnitIPRangeSaved");
					result = SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "LogSave_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogSave_ScriptTask";
					result = LogSave_ScriptTask.Execute(context, LogSave_ScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminUnitIPRangeDeleted_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitIPRangeDeleted_StartMessage";
					result = SysAdminUnitIPRangeDeleted_StartMessage.Execute(context);
					break;
				case "SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysAdminUnitIPRangeDeleted");
					result = SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "LogDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogDelete_ScriptTask";
					result = LogDelete_ScriptTask.Execute(context, LogDelete_ScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminUnitIPRangeDeleting_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitIPRangeDeleting_StartMessage";
					result = SysAdminUnitIPRangeDeleting_StartMessage.Execute(context);
					break;
				case "SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SysAdminUnitIPRangeDeleting");
					result = SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "GetAdminUnit_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GetAdminUnit_ScriptTask";
					result = GetAdminUnit_ScriptTask.Execute(context, GetAdminUnit_ScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "SysAdminUnitIPRangeSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysAdminUnitIPRangeSaving";
					result = SysAdminUnitIPRangeSaving.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "AdminUnitName":
					AdminUnitName = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool LogSave_ScriptTaskExecute(ProcessExecutingContext context) {
			var sysAdminUnitName = Entity.GetTypedColumnValue<string>(Entity.Schema.GetSchemaColumnByPath("SysAdminUnit").DisplayColumnValueName);
			var beginIP = Entity.GetTypedColumnValue<string>("BeginIP");
			var endIP = Entity.GetTypedColumnValue<string>("EndIP");
			OperationLogger.Instance.LogClientIPRangeEdit(UserConnection, sysAdminUnitName, beginIP, endIP);
			return true;
		}

		public virtual bool LogDelete_ScriptTaskExecute(ProcessExecutingContext context) {
			var beginIP = Entity.GetTypedColumnValue<string>("BeginIP");
			var endIP = Entity.GetTypedColumnValue<string>("EndIP");
			OperationLogger.Instance.LogClientIPRangeDelete(UserConnection, AdminUnitName, beginIP, endIP);
			return true;
		}

		public virtual bool GetAdminUnit_ScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			var ipRangeId = Entity.GetTypedColumnValue<Guid>("Id");
			var selectAdminUnitId = 
				new Select(UserConnection)
					.Column("SysAdminUnitId")
				.From("SysAdminUnitIPRange")
				.Where("Id").IsEqual(Column.Parameter(ipRangeId)) as Select;
			var selectAdminName = 
				new Select(UserConnection)
					.Column("Name")
				.From("SysAdminUnit")
				.Where("Id").IsEqual(selectAdminUnitId) as Select;
			AdminUnitName = selectAdminName.ExecuteScalar<string>();
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysAdminUnitIPRangeSaved":
							if (ActivatedEventElements.Contains("SysAdminUnitIPRangeSaved_StartMessage")) {
							context.QueueTasks.Enqueue("SysAdminUnitIPRangeSaved_StartMessage");
						}
						break;
					case "SysAdminUnitIPRangeDeleted":
							if (ActivatedEventElements.Contains("SysAdminUnitIPRangeDeleted_StartMessage")) {
							context.QueueTasks.Enqueue("SysAdminUnitIPRangeDeleted_StartMessage");
						}
						break;
					case "SysAdminUnitIPRangeDeleting":
							if (ActivatedEventElements.Contains("SysAdminUnitIPRangeDeleting_StartMessage")) {
							context.QueueTasks.Enqueue("SysAdminUnitIPRangeDeleting_StartMessage");
						}
						break;
					case "SysAdminUnitIPRangeSaving":
							if (ActivatedEventElements.Contains("SysAdminUnitIPRangeSaving")) {
							context.QueueTasks.Enqueue("SysAdminUnitIPRangeSaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("AdminUnitName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("AdminUnitName", AdminUnitName, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRange_BaseEventsProcess

	/// <exclude/>
	public class SysAdminUnitIPRange_BaseEventsProcess : SysAdminUnitIPRange_BaseEventsProcess<SysAdminUnitIPRange>
	{

		public SysAdminUnitIPRange_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminUnitIPRange_BaseEventsProcess

	public partial class SysAdminUnitIPRange_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysAdminUnitIPRangeEventsProcessSchema

	/// <exclude/>
	public class SysAdminUnitIPRangeEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminUnitIPRangeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminUnitIPRangeEventsProcessSchema(SysAdminUnitIPRangeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminUnitIPRange_BaseEventsProcess";
			UId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c");
			CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376");
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

		protected virtual ProcessSchemaParameter CreateAdminUnitNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c89da71e-f96e-407b-a3c2-775c09762816"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"AdminUnitName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateAdminUnitNameParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaStartMessageEvent sysadminunitiprangesaved_startmessage = CreateSysAdminUnitIPRangeSaved_StartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminunitiprangesaved_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent sysadminunitiprangesaved_intermediatethrowmessageevent = CreateSysAdminUnitIPRangeSaved_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(sysadminunitiprangesaved_intermediatethrowmessageevent);
			ProcessSchemaScriptTask logsave_scripttask = CreateLogSave_ScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(logsave_scripttask);
			ProcessSchemaStartMessageEvent sysadminunitiprangedeleted_startmessage = CreateSysAdminUnitIPRangeDeleted_StartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(sysadminunitiprangedeleted_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent sysadminunitiprangedeleted_intermediatethrowmessageevent = CreateSysAdminUnitIPRangeDeleted_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(sysadminunitiprangedeleted_intermediatethrowmessageevent);
			ProcessSchemaScriptTask logdelete_scripttask = CreateLogDelete_ScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(logdelete_scripttask);
			ProcessSchemaStartMessageEvent sysadminunitiprangedeleting_startmessage = CreateSysAdminUnitIPRangeDeleting_StartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(sysadminunitiprangedeleting_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent sysadminunitiprangedeleting_intermediatethrowmessageevent = CreateSysAdminUnitIPRangeDeleting_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(sysadminunitiprangedeleting_intermediatethrowmessageevent);
			ProcessSchemaScriptTask getadminunit_scripttask = CreateGetAdminUnit_ScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(getadminunit_scripttask);
			ProcessSchemaStartMessageEvent sysadminunitiprangesaving = CreateSysAdminUnitIPRangeSavingStartMessageEvent();
			eventsubprocess4.FlowElements.Add(sysadminunitiprangesaving);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess4.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a446763a-05ee-4ce7-bdef-44bbd8e925be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				CurveCenterPosition = new Point(268, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ea447b2-2e91-426f-a427-56d142ad8f04"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f64a6c3-b88f-41af-8400-b5a9591cfbce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("2c87ddd7-830e-4a2a-a059-61c760c486b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				CurveCenterPosition = new Point(262, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e11386a7-5da6-487d-b415-b987eafae95e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c7d5f13d-ae26-4efc-97ca-5b4e5289197a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("bb4bff80-5200-44a3-94fa-b7098a46d090"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				CurveCenterPosition = new Point(262, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7d5f13d-ae26-4efc-97ca-5b4e5289197a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c2b2dfc0-e59e-4a1f-8551-d0607663b1f0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("e2e2de52-dfdf-4dda-b553-23b6cb52d267"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				CurveCenterPosition = new Point(268, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f64a6c3-b88f-41af-8400-b5a9591cfbce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab11b8bd-723f-4609-8dc5-2a9b4d5f64d3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("80e8740b-630c-4be9-84de-b8f330fb585d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				CurveCenterPosition = new Point(295, 434),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9577f9b9-71fa-46d6-9aa5-3d731c8f71a0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c8a66c40-97b7-49c6-b729-71ed34a3013b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("1974dbc0-9810-4cd4-88b4-7d57188782e1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				CurveCenterPosition = new Point(295, 434),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c8a66c40-97b7-49c6-b729-71ed34a3013b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e9eedd7b-c7e7-47c4-937a-5fb132e750c7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("abf06101-a5ee-49af-b537-5df9c073097e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("89288b34-e6f9-40bb-8379-a1f4d3f7a731"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a56e1fb6-ea80-46c3-a226-f375289003b5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("37d72ce3-b92c-4225-8cfb-604f01b6fd51"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(616, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ea76ac68-a51f-4cd6-aa37-ea7fad21ac2a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("37d72ce3-b92c-4225-8cfb-604f01b6fd51"),
				CreatedInOwnerSchemaUId = new Guid("ba5b0dfd-5632-4ca1-b50e-0d56ba338add"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(587, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("70bac210-61ba-4444-b50c-575288f98f25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea76ac68-a51f-4cd6-aa37-ea7fad21ac2a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(407, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitIPRangeSaved_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e11386a7-5da6-487d-b415-b987eafae95e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70bac210-61ba-4444-b50c-575288f98f25"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitIPRangeSaved",
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"SysAdminUnitIPRangeSaved_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminUnitIPRangeSaved_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c2b2dfc0-e59e-4a1f-8551-d0607663b1f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70bac210-61ba-4444-b50c-575288f98f25"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysAdminUnitIPRangeSaved",
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"SysAdminUnitIPRangeSaved_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(337, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogSave_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c7d5f13d-ae26-4efc-97ca-5b4e5289197a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70bac210-61ba-4444-b50c-575288f98f25"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"LogSave_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,10,130,64,16,199,239,65,239,32,158,20,196,23,232,3,210,36,132,40,169,236,62,233,176,13,232,40,187,99,176,111,95,155,5,66,151,110,51,240,251,127,204,60,64,123,198,154,77,221,18,151,76,114,128,22,189,149,151,177,144,216,120,135,114,177,61,214,105,215,12,45,95,161,25,112,105,68,19,171,117,240,65,206,213,29,91,112,228,56,141,104,98,11,144,123,224,159,39,214,126,24,111,201,244,13,216,137,157,203,11,23,243,217,227,213,227,134,138,56,47,254,139,247,147,145,246,191,106,228,250,111,109,230,216,183,242,216,163,6,161,142,247,157,82,168,227,156,141,0,87,24,191,246,180,33,100,201,139,19,176,194,172,38,9,74,131,58,237,152,177,114,146,232,231,115,209,247,134,104,172,227,18,52,202,160,217,19,61,224,226,9,125,158,118,83,110,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("da4fecdd-fde3-4a7b-b3bb-c610ded2e81a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea76ac68-a51f-4cd6-aa37-ea7fad21ac2a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(407, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitIPRangeDeleted_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5ea447b2-2e91-426f-a427-56d142ad8f04"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da4fecdd-fde3-4a7b-b3bb-c610ded2e81a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitIPRangeDeleted",
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"SysAdminUnitIPRangeDeleted_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminUnitIPRangeDeleted_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ab11b8bd-723f-4609-8dc5-2a9b4d5f64d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da4fecdd-fde3-4a7b-b3bb-c610ded2e81a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysAdminUnitIPRangeDeleted",
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"SysAdminUnitIPRangeDeleted_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(337, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4f64a6c3-b88f-41af-8400-b5a9591cfbce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da4fecdd-fde3-4a7b-b3bb-c610ded2e81a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"LogDelete_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,193,10,130,64,20,69,247,65,255,48,184,50,16,127,192,10,202,36,132,40,137,108,63,233,101,24,24,223,200,243,141,224,223,151,73,251,150,23,206,225,222,59,106,86,47,24,75,101,165,118,170,32,177,50,165,103,200,99,234,209,230,222,133,142,158,218,5,108,7,97,75,102,31,71,199,133,142,54,217,122,53,126,108,80,251,183,91,204,236,215,188,245,96,45,214,211,197,27,3,78,75,26,68,83,131,244,147,115,103,65,82,86,119,77,6,39,56,8,226,122,0,231,158,8,205,44,37,234,208,118,150,106,178,114,213,29,146,223,133,100,89,51,23,48,36,48,41,225,128,236,13,129,243,72,89,229,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e9bee84e-c359-4b2a-a3a5-bf54e0e94c54"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea76ac68-a51f-4cd6-aa37-ea7fad21ac2a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 350),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(413, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitIPRangeDeleting_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9577f9b9-71fa-46d6-9aa5-3d731c8f71a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9bee84e-c359-4b2a-a3a5-bf54e0e94c54"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitIPRangeDeleting",
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"SysAdminUnitIPRangeDeleting_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSysAdminUnitIPRangeDeleting_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e9eedd7b-c7e7-47c4-937a-5fb132e750c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9bee84e-c359-4b2a-a3a5-bf54e0e94c54"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SysAdminUnitIPRangeDeleting",
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"SysAdminUnitIPRangeDeleting_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(337, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateGetAdminUnit_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c8a66c40-97b7-49c6-b729-71ed34a3013b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9bee84e-c359-4b2a-a3a5-bf54e0e94c54"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"GetAdminUnit_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,203,78,195,48,16,69,215,173,212,127,176,178,114,54,254,129,150,74,16,66,149,69,161,34,4,214,163,100,148,90,36,147,116,108,3,249,123,156,135,34,218,170,11,182,115,230,94,29,123,50,131,28,53,68,152,91,221,144,122,124,72,49,119,172,109,23,83,169,9,85,116,196,252,51,2,138,127,252,220,226,75,139,12,253,166,12,252,112,15,4,37,222,23,181,38,109,236,8,130,112,189,90,126,1,11,221,190,2,149,152,20,226,78,196,100,125,165,218,161,125,235,90,44,162,166,114,53,189,67,229,112,179,115,186,216,202,32,41,230,160,193,202,219,12,173,25,105,59,20,172,150,11,194,111,145,14,72,102,103,210,161,135,11,53,118,202,32,237,204,159,104,208,67,245,196,77,125,65,14,131,220,136,63,142,200,56,42,168,196,196,39,7,149,28,235,212,1,24,106,180,200,114,126,78,24,10,48,147,201,181,241,179,95,255,151,111,31,184,101,121,91,239,234,143,206,165,102,48,233,92,8,170,233,154,105,14,21,240,198,159,78,83,185,149,253,1,24,173,99,18,150,29,174,127,1,51,146,168,161,28,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("23ee951e-642e-4ba5-9bb3-c489d6b12442"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ea76ac68-a51f-4cd6-aa37-ea7fad21ac2a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 540),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(407, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysAdminUnitIPRangeSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("89288b34-e6f9-40bb-8379-a1f4d3f7a731"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23ee951e-642e-4ba5-9bb3-c489d6b12442"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminUnitIPRangeSaving",
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"SysAdminUnitIPRangeSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(58, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a56e1fb6-ea80-46c3-a226-f375289003b5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23ee951e-642e-4ba5-9bb3-c489d6b12442"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(191, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,29,83,114,51,243,50,139,75,32,18,74,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,30,174,216,187,97,0,0,0 }
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
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("37aefb40-6ad6-4c1f-86e0-69ea7c717376")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0aabbae4-c11b-44b7-9b43-0a41a45f76a1"),
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
			return new SysAdminUnitIPRangeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83c780da-3753-4058-bf83-c27333ef7a1c"));
		}

		#endregion

	}

	#endregion


	#region Class: SysAdminUnitIPRangeEventsProcess

	/// <exclude/>
	public class SysAdminUnitIPRangeEventsProcess : SysAdminUnitIPRange_BaseEventsProcess
	{

		public SysAdminUnitIPRangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

