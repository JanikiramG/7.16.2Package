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

	#region Class: VwSysEntitySchemaColumnRightSchema

	/// <exclude/>
	public class VwSysEntitySchemaColumnRightSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwSysEntitySchemaColumnRightSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysEntitySchemaColumnRightSchema(VwSysEntitySchemaColumnRightSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysEntitySchemaColumnRightSchema(VwSysEntitySchemaColumnRightSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555");
			RealUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555");
			Name = "VwSysEntitySchemaColumnRight";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4e633c16-e807-4873-9c46-375d376d0a2a")) == null) {
				Columns.Add(CreateSysAdminUnitColumn());
			}
			if (Columns.FindByUId(new Guid("4d7ac7e2-9285-462a-b942-b8ae69d229ea")) == null) {
				Columns.Add(CreateRightLevelColumn());
			}
			if (Columns.FindByUId(new Guid("90af7c81-0689-48a8-83fb-3ecaeba22b7f")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("6bae586e-5d9c-4484-b8d0-5c9a59f3bfb9")) == null) {
				Columns.Add(CreateSubjectColumnUIdColumn());
			}
			if (Columns.FindByUId(new Guid("c55f4107-514d-4fe3-8ed6-f56e272c31a7")) == null) {
				Columns.Add(CreateSubjectSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysAdminUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4e633c16-e807-4873-9c46-375d376d0a2a"),
				Name = @"SysAdminUnit",
				ReferenceSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				ModifiedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreateRightLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4d7ac7e2-9285-462a-b942-b8ae69d229ea"),
				Name = @"RightLevel",
				ReferenceSchemaUId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0"),
				CreatedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				ModifiedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("90af7c81-0689-48a8-83fb-3ecaeba22b7f"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				ModifiedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectColumnUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("6bae586e-5d9c-4484-b8d0-5c9a59f3bfb9"),
				Name = @"SubjectColumnUId",
				CreatedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				ModifiedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("c55f4107-514d-4fe3-8ed6-f56e272c31a7"),
				Name = @"SubjectSchemaUId",
				CreatedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				ModifiedInSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysEntitySchemaColumnRightEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysEntitySchemaColumnRightEventsProcessSchema() {
			var schema = new VwSysEntitySchemaColumnRightEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysEntitySchemaColumnRight(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysEntitySchemaColumnRight_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysEntitySchemaColumnRightSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysEntitySchemaColumnRightSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysEntitySchemaColumnRight

	/// <summary>
	/// Columns permissions (view).
	/// </summary>
	public class VwSysEntitySchemaColumnRight : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwSysEntitySchemaColumnRight(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysEntitySchemaColumnRight";
		}

		public VwSysEntitySchemaColumnRight(VwSysEntitySchemaColumnRight source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		private VwSysAdminUnit _sysAdminUnit;
		/// <summary>
		/// User/role.
		/// </summary>
		public VwSysAdminUnit SysAdminUnit {
			get {
				return _sysAdminUnit ??
					(_sysAdminUnit = LookupColumnEntities.GetEntity("SysAdminUnit") as VwSysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid RightLevelId {
			get {
				return GetTypedColumnValue<Guid>("RightLevelId");
			}
			set {
				SetColumnValue("RightLevelId", value);
				_rightLevel = null;
			}
		}

		/// <exclude/>
		public string RightLevelName {
			get {
				return GetTypedColumnValue<string>("RightLevelName");
			}
			set {
				SetColumnValue("RightLevelName", value);
				if (_rightLevel != null) {
					_rightLevel.Name = value;
				}
			}
		}

		private SysEntitySchemaColRightLevel _rightLevel;
		/// <summary>
		/// Access level.
		/// </summary>
		public SysEntitySchemaColRightLevel RightLevel {
			get {
				return _rightLevel ??
					(_rightLevel = LookupColumnEntities.GetEntity("RightLevel") as SysEntitySchemaColRightLevel);
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

		/// <summary>
		/// Column.
		/// </summary>
		public Guid SubjectColumnUId {
			get {
				return GetTypedColumnValue<Guid>("SubjectColumnUId");
			}
			set {
				SetColumnValue("SubjectColumnUId", value);
			}
		}

		/// <summary>
		/// Object.
		/// </summary>
		public Guid SubjectSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SubjectSchemaUId");
			}
			set {
				SetColumnValue("SubjectSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysEntitySchemaColumnRight_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysEntitySchemaColumnRightDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysEntitySchemaColumnRightDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwSysEntitySchemaColumnRightInserted", e);
			Inserting += (s, e) => ThrowEvent("VwSysEntitySchemaColumnRightInserting", e);
			Saved += (s, e) => ThrowEvent("VwSysEntitySchemaColumnRightSaved", e);
			Saving += (s, e) => ThrowEvent("VwSysEntitySchemaColumnRightSaving", e);
			Validating += (s, e) => ThrowEvent("VwSysEntitySchemaColumnRightValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysEntitySchemaColumnRight(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysEntitySchemaColumnRight_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysEntitySchemaColumnRight_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwSysEntitySchemaColumnRight
	{

		public VwSysEntitySchemaColumnRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysEntitySchemaColumnRight_BaseEventsProcess";
			SchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f302c13d-4a72-483f-9744-345f6b0eb555");
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
					SchemaElementUId = new Guid("7dc55ddf-768e-43f5-929b-35c0bed0ed41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysEntitySchemaColumnRightDeleting_StartMessage;
		public ProcessFlowElement VwSysEntitySchemaColumnRightDeleting_StartMessage {
			get {
				return _vwSysEntitySchemaColumnRightDeleting_StartMessage ?? (_vwSysEntitySchemaColumnRightDeleting_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysEntitySchemaColumnRightDeleting_StartMessage",
					SchemaElementUId = new Guid("077ce5c9-cb9b-4f2b-b264-bae3d8077126"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _vwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent {
			get {
				return _vwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent ?? (_vwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("35db4659-08ec-4f12-9412-28cf20b0dd0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "VwSysEntitySchemaColumnRightDeleting",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _prepareDataLogDelete_ScriptTask;
		public ProcessScriptTask PrepareDataLogDelete_ScriptTask {
			get {
				return _prepareDataLogDelete_ScriptTask ?? (_prepareDataLogDelete_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareDataLogDelete_ScriptTask",
					SchemaElementUId = new Guid("040c1776-93f0-4d25-ad79-47b5cc15cf86"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareDataLogDelete_ScriptTaskExecute,
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
					SchemaElementUId = new Guid("0706dc68-b5d6-4f5e-8973-066289d286dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysEntitySchemaColumnRightDeleted_StartMessage;
		public ProcessFlowElement VwSysEntitySchemaColumnRightDeleted_StartMessage {
			get {
				return _vwSysEntitySchemaColumnRightDeleted_StartMessage ?? (_vwSysEntitySchemaColumnRightDeleted_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysEntitySchemaColumnRightDeleted_StartMessage",
					SchemaElementUId = new Guid("3bd5234f-61db-42fe-9802-53b9f4367096"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _vwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent {
			get {
				return _vwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent ?? (_vwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("908c2bcd-aea5-4646-aaaa-31a31c620d84"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "VwSysEntitySchemaColumnRightDeleted",
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
					SchemaElementUId = new Guid("aabed8db-9f14-47eb-a6ba-15c861cb66bb"),
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
					SchemaElementUId = new Guid("23720d90-e233-4c61-975c-82f8890f8700"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysEntitySchemaColumnRightSaved_StartMessage;
		public ProcessFlowElement VwSysEntitySchemaColumnRightSaved_StartMessage {
			get {
				return _vwSysEntitySchemaColumnRightSaved_StartMessage ?? (_vwSysEntitySchemaColumnRightSaved_StartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysEntitySchemaColumnRightSaved_StartMessage",
					SchemaElementUId = new Guid("6750d03e-e76d-4339-a84b-419c3b9d5315"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _vwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent {
			get {
				return _vwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent ?? (_vwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("b92e64f2-5ea0-49fa-98a4-41e1fa99e65d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "VwSysEntitySchemaColumnRightSaved",
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
					SchemaElementUId = new Guid("240a9511-4bbd-4279-a8b4-ab1b5ad9a267"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogSave_ScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[VwSysEntitySchemaColumnRightDeleting_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysEntitySchemaColumnRightDeleting_StartMessage };
			FlowElements[VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent };
			FlowElements[PrepareDataLogDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareDataLogDelete_ScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[VwSysEntitySchemaColumnRightDeleted_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysEntitySchemaColumnRightDeleted_StartMessage };
			FlowElements[VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent };
			FlowElements[LogDelete_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogDelete_ScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[VwSysEntitySchemaColumnRightSaved_StartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysEntitySchemaColumnRightSaved_StartMessage };
			FlowElements[VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent };
			FlowElements[LogSave_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogSave_ScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "VwSysEntitySchemaColumnRightDeleting_StartMessage":
						e.Context.QueueTasks.Enqueue("PrepareDataLogDelete_ScriptTask");
						break;
					case "VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent":
						break;
					case "PrepareDataLogDelete_ScriptTask":
						e.Context.QueueTasks.Enqueue("VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent");
						break;
					case "EventSubProcess2":
						break;
					case "VwSysEntitySchemaColumnRightDeleted_StartMessage":
						e.Context.QueueTasks.Enqueue("LogDelete_ScriptTask");
						break;
					case "VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent":
						break;
					case "LogDelete_ScriptTask":
						e.Context.QueueTasks.Enqueue("VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent");
						break;
					case "EventSubProcess3":
						break;
					case "VwSysEntitySchemaColumnRightSaved_StartMessage":
						e.Context.QueueTasks.Enqueue("LogSave_ScriptTask");
						break;
					case "VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent":
						break;
					case "LogSave_ScriptTask":
						e.Context.QueueTasks.Enqueue("VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("VwSysEntitySchemaColumnRightDeleting_StartMessage");
			ActivatedEventElements.Add("VwSysEntitySchemaColumnRightDeleted_StartMessage");
			ActivatedEventElements.Add("VwSysEntitySchemaColumnRightSaved_StartMessage");
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
				case "VwSysEntitySchemaColumnRightDeleting_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysEntitySchemaColumnRightDeleting_StartMessage";
					result = VwSysEntitySchemaColumnRightDeleting_StartMessage.Execute(context);
					break;
				case "VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "VwSysEntitySchemaColumnRightDeleting");
					result = VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "PrepareDataLogDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareDataLogDelete_ScriptTask";
					result = PrepareDataLogDelete_ScriptTask.Execute(context, PrepareDataLogDelete_ScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "VwSysEntitySchemaColumnRightDeleted_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysEntitySchemaColumnRightDeleted_StartMessage";
					result = VwSysEntitySchemaColumnRightDeleted_StartMessage.Execute(context);
					break;
				case "VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "VwSysEntitySchemaColumnRightDeleted");
					result = VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "LogDelete_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogDelete_ScriptTask";
					result = LogDelete_ScriptTask.Execute(context, LogDelete_ScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "VwSysEntitySchemaColumnRightSaved_StartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysEntitySchemaColumnRightSaved_StartMessage";
					result = VwSysEntitySchemaColumnRightSaved_StartMessage.Execute(context);
					break;
				case "VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "VwSysEntitySchemaColumnRightSaved");
					result = VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent.Execute(context);
					break;
				case "LogSave_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogSave_ScriptTask";
					result = LogSave_ScriptTask.Execute(context, LogSave_ScriptTaskExecute);
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

		public virtual bool PrepareDataLogDelete_ScriptTaskExecute(ProcessExecutingContext context) {
			AdminUnitName = Entity.GetTypedColumnValue<string>(Entity.Schema.GetSchemaColumnByPath("SysAdminUnit").DisplayColumnValueName);
			return true;
		}

		public virtual bool LogDelete_ScriptTaskExecute(ProcessExecutingContext context) {
			var schemaUId = Entity.GetTypedColumnValue<Guid>("SubjectSchemaUId");
			var columnUId = Entity.GetTypedColumnValue<Guid>("SubjectColumnUId");
			OperationLogger.Instance.LogEntitySchemaColumnRightDelete(UserConnection, AdminUnitName, schemaUId, columnUId);
			return true;
		}

		public virtual bool LogSave_ScriptTaskExecute(ProcessExecutingContext context) {
			var adminUnitName = Entity.GetTypedColumnValue<string>(Entity.Schema.GetSchemaColumnByPath("SysAdminUnit").DisplayColumnValueName);
			var schemaUId = Entity.GetTypedColumnValue<Guid>("SubjectSchemaUId");
			var columnUId = Entity.GetTypedColumnValue<Guid>("SubjectColumnUId");
			var rightLevelId = Entity.GetTypedColumnValue<Guid>(Entity.Schema.GetSchemaColumnByPath("RightLevel").ColumnValueName);
			var position = Entity.GetTypedColumnValue<int>("Position");
			OperationLogger.Instance.LogEntitySchemaColumnRightEdit(UserConnection, adminUnitName, schemaUId, columnUId, rightLevelId, position);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwSysEntitySchemaColumnRightDeleting":
							if (ActivatedEventElements.Contains("VwSysEntitySchemaColumnRightDeleting_StartMessage")) {
							context.QueueTasks.Enqueue("VwSysEntitySchemaColumnRightDeleting_StartMessage");
						}
						break;
					case "VwSysEntitySchemaColumnRightDeleted":
							if (ActivatedEventElements.Contains("VwSysEntitySchemaColumnRightDeleted_StartMessage")) {
							context.QueueTasks.Enqueue("VwSysEntitySchemaColumnRightDeleted_StartMessage");
						}
						break;
					case "VwSysEntitySchemaColumnRightSaved":
							if (ActivatedEventElements.Contains("VwSysEntitySchemaColumnRightSaved_StartMessage")) {
							context.QueueTasks.Enqueue("VwSysEntitySchemaColumnRightSaved_StartMessage");
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

	#region Class: VwSysEntitySchemaColumnRight_BaseEventsProcess

	/// <exclude/>
	public class VwSysEntitySchemaColumnRight_BaseEventsProcess : VwSysEntitySchemaColumnRight_BaseEventsProcess<VwSysEntitySchemaColumnRight>
	{

		public VwSysEntitySchemaColumnRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysEntitySchemaColumnRight_BaseEventsProcess

	public partial class VwSysEntitySchemaColumnRight_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysEntitySchemaColumnRightEventsProcessSchema

	/// <exclude/>
	public class VwSysEntitySchemaColumnRightEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysEntitySchemaColumnRightEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysEntitySchemaColumnRightEventsProcessSchema(VwSysEntitySchemaColumnRightEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysEntitySchemaColumnRight_BaseEventsProcess";
			UId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7");
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

		protected virtual ProcessSchemaParameter CreateAdminUnitNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e98d7056-bedc-4398-a5a8-e32db18d2ebc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
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
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent vwsysentityschemacolumnrightdeleting_startmessage = CreateVwSysEntitySchemaColumnRightDeleting_StartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(vwsysentityschemacolumnrightdeleting_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent vwsysentityschemacolumnrightdeleting_intermediatethrowmessageevent = CreateVwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(vwsysentityschemacolumnrightdeleting_intermediatethrowmessageevent);
			ProcessSchemaScriptTask preparedatalogdelete_scripttask = CreatePrepareDataLogDelete_ScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(preparedatalogdelete_scripttask);
			ProcessSchemaStartMessageEvent vwsysentityschemacolumnrightdeleted_startmessage = CreateVwSysEntitySchemaColumnRightDeleted_StartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(vwsysentityschemacolumnrightdeleted_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent vwsysentityschemacolumnrightdeleted_intermediatethrowmessageevent = CreateVwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(vwsysentityschemacolumnrightdeleted_intermediatethrowmessageevent);
			ProcessSchemaScriptTask logdelete_scripttask = CreateLogDelete_ScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(logdelete_scripttask);
			ProcessSchemaStartMessageEvent vwsysentityschemacolumnrightsaved_startmessage = CreateVwSysEntitySchemaColumnRightSaved_StartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(vwsysentityschemacolumnrightsaved_startmessage);
			ProcessSchemaIntermediateThrowMessageEvent vwsysentityschemacolumnrightsaved_intermediatethrowmessageevent = CreateVwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess3.FlowElements.Add(vwsysentityschemacolumnrightsaved_intermediatethrowmessageevent);
			ProcessSchemaScriptTask logsave_scripttask = CreateLogSave_ScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(logsave_scripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("8c10144f-433a-4d1a-8570-7ef9bc0b479f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				CurveCenterPosition = new Point(288, 448),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3bd5234f-61db-42fe-9802-53b9f4367096"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aabed8db-9f14-47eb-a6ba-15c861cb66bb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("6b581e48-6f8c-46dd-ad69-95f934a707fb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				CurveCenterPosition = new Point(289, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("077ce5c9-cb9b-4f2b-b264-bae3d8077126"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("040c1776-93f0-4d25-ad79-47b5cc15cf86"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("2445eb19-7dad-4687-ad6c-872ebfb2f6e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				CurveCenterPosition = new Point(290, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6750d03e-e76d-4339-a84b-419c3b9d5315"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("240a9511-4bbd-4279-a8b4-ab1b5ad9a267"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("1394b8ea-10f2-45f4-b099-d0f5c5e95bee"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				CurveCenterPosition = new Point(290, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("240a9511-4bbd-4279-a8b4-ab1b5ad9a267"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b92e64f2-5ea0-49fa-98a4-41e1fa99e65d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("36dcddaf-e172-4056-9165-f8c58340efa3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				CurveCenterPosition = new Point(289, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("040c1776-93f0-4d25-ad79-47b5cc15cf86"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("35db4659-08ec-4f12-9412-28cf20b0dd0d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("fb896421-6d14-4593-bd70-8e5aec19a1ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				CurveCenterPosition = new Point(288, 448),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aabed8db-9f14-47eb-a6ba-15c861cb66bb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("908c2bcd-aea5-4646-aaaa-31a31c620d84"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b6039dd8-e811-4b63-81cf-f85cdcbcb2a4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(707, 533),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e9b4bf86-fa80-441c-9922-d97e926e7f87"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("b6039dd8-e811-4b63-81cf-f85cdcbcb2a4"),
				CreatedInOwnerSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 189),
				Size = new Size(678, 344),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("f1f02bfc-c402-4010-90f8-763f694ed9be"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b6039dd8-e811-4b63-81cf-f85cdcbcb2a4"),
				CreatedInOwnerSchemaUId = new Guid("f302c13d-4a72-483f-9744-345f6b0eb555"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(678, 184),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7dc55ddf-768e-43f5-929b-35c0bed0ed41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9b4bf86-fa80-441c-9922-d97e926e7f87"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(406, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysEntitySchemaColumnRightDeleting_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("077ce5c9-cb9b-4f2b-b264-bae3d8077126"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dc55ddf-768e-43f5-929b-35c0bed0ed41"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysEntitySchemaColumnRightDeleting",
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"VwSysEntitySchemaColumnRightDeleting_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateVwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("35db4659-08ec-4f12-9412-28cf20b0dd0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dc55ddf-768e-43f5-929b-35c0bed0ed41"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"VwSysEntitySchemaColumnRightDeleting",
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"VwSysEntitySchemaColumnRightDeleting_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(337, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareDataLogDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("040c1776-93f0-4d25-ad79-47b5cc15cf86"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7dc55ddf-768e-43f5-929b-35c0bed0ed41"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"PrepareDataLogDelete_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,201,205,204,11,205,203,44,241,75,204,77,85,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,41,46,41,202,204,75,183,211,128,42,9,78,206,72,205,77,4,169,132,176,32,74,157,42,3,18,75,50,52,148,130,43,139,29,97,70,43,105,234,185,100,22,23,228,36,86,34,25,7,178,79,211,154,151,171,40,181,164,180,40,79,161,164,168,52,213,26,0,141,62,68,235,141,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0706dc68-b5d6-4f5e-8973-066289d286dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9b4bf86-fa80-441c-9922-d97e926e7f87"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 175),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(406, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysEntitySchemaColumnRightDeleted_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3bd5234f-61db-42fe-9802-53b9f4367096"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0706dc68-b5d6-4f5e-8973-066289d286dc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysEntitySchemaColumnRightDeleted",
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"VwSysEntitySchemaColumnRightDeleted_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateVwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("908c2bcd-aea5-4646-aaaa-31a31c620d84"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0706dc68-b5d6-4f5e-8973-066289d286dc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"VwSysEntitySchemaColumnRightDeleted",
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"VwSysEntitySchemaColumnRightDeleted_IntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(337, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLogDelete_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("aabed8db-9f14-47eb-a6ba-15c861cb66bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0706dc68-b5d6-4f5e-8973-066289d286dc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"LogDelete_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,209,10,130,48,20,134,239,131,222,97,120,101,32,190,128,21,132,133,8,81,144,217,253,218,14,115,225,206,100,158,9,190,125,75,17,175,187,60,240,127,223,255,159,129,59,214,139,6,12,175,75,201,14,236,130,164,105,76,11,160,231,216,129,204,109,235,13,190,120,235,97,95,120,45,143,113,84,249,247,7,4,85,11,20,237,178,237,102,8,26,49,101,255,212,228,11,52,105,238,29,56,78,218,226,213,42,5,46,45,177,39,142,2,210,112,207,202,185,118,166,30,90,53,116,134,22,8,226,186,7,151,91,196,160,12,120,194,78,210,104,172,81,211,141,27,72,214,23,147,117,230,175,208,1,121,135,140,156,135,236,11,171,84,120,229,11,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("23720d90-e233-4c61-975c-82f8890f8700"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1f02bfc-c402-4010-90f8-763f694ed9be"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(56, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(406, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysEntitySchemaColumnRightSaved_StartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6750d03e-e76d-4339-a84b-419c3b9d5315"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23720d90-e233-4c61-975c-82f8890f8700"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysEntitySchemaColumnRightSaved",
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"VwSysEntitySchemaColumnRightSaved_StartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateVwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b92e64f2-5ea0-49fa-98a4-41e1fa99e65d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23720d90-e233-4c61-975c-82f8890f8700"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"VwSysEntitySchemaColumnRightSaved",
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"VwSysEntitySchemaColumnRightSaved_IntermediateThrowMessageEvent",
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
				UId = new Guid("240a9511-4bbd-4279-a8b4-ab1b5ad9a267"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("23720d90-e233-4c61-975c-82f8890f8700"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b"),
				CreatedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"),
				Name = @"LogSave_ScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,203,106,195,48,16,69,247,133,254,131,241,202,1,227,31,72,26,104,157,16,2,161,9,77,221,189,106,13,246,20,123,100,164,145,65,127,95,249,153,100,209,144,238,36,184,115,230,112,165,86,232,64,200,26,41,35,228,119,81,67,240,18,108,137,145,93,178,3,254,116,13,200,84,85,182,166,47,81,89,88,25,214,72,197,58,26,35,231,188,132,90,116,201,225,52,68,223,220,73,112,25,133,103,103,94,39,116,184,72,54,104,154,74,184,43,92,183,111,177,124,126,106,189,132,233,1,217,94,222,23,216,89,148,107,143,182,223,63,144,143,91,253,80,56,97,242,62,251,79,76,58,13,205,24,141,69,201,7,104,161,122,140,244,80,31,31,51,212,183,241,71,13,141,50,200,168,232,254,82,36,246,246,167,49,219,91,31,27,208,162,187,29,84,81,128,78,246,100,88,80,14,137,191,15,164,107,165,94,101,43,145,163,204,128,78,21,145,175,193,15,199,183,159,33,190,60,75,124,169,54,190,169,39,158,157,59,13,13,108,53,5,172,45,44,127,1,222,206,191,126,92,2,0,0 }
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
				UId = new Guid("1e4d67bc-21aa-4aba-9542-a705053da06b"),
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
			return new VwSysEntitySchemaColumnRightEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7896e3e3-9a82-44c0-9fdf-dcfd251906c7"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysEntitySchemaColumnRightEventsProcess

	/// <exclude/>
	public class VwSysEntitySchemaColumnRightEventsProcess : VwSysEntitySchemaColumnRight_BaseEventsProcess
	{

		public VwSysEntitySchemaColumnRightEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

