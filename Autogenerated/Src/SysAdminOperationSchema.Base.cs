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

	#region Class: SysAdminOperationSchema

	/// <exclude/>
	public class SysAdminOperationSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysAdminOperationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysAdminOperationSchema(SysAdminOperationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysAdminOperationSchema(SysAdminOperationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638");
			RealUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638");
			Name = "SysAdminOperation";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2aec9cef-232e-413a-9a5a-9ddde2e8a2af")) == null) {
				Columns.Add(CreateCodeColumn());
			}
			if (Columns.FindByUId(new Guid("a2987d84-12ca-4f95-a27f-54d1cfc2517d")) == null) {
				Columns.Add(CreateSysFolderColumn());
			}
			if (Columns.FindByUId(new Guid("ea5c0817-d558-42ef-a5f9-9379560f16f1")) == null) {
				Columns.Add(CreateUseSystemOperationRestrictionsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("2aec9cef-232e-413a-9a5a-9ddde2e8a2af"),
				Name = @"Code",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				ModifiedInSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateSysFolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a2987d84-12ca-4f95-a27f-54d1cfc2517d"),
				Name = @"SysFolder",
				ReferenceSchemaUId = new Guid("a3421ccc-16ab-4ef5-a941-a868bba1aefd"),
				CreatedInSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				ModifiedInSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateUseSystemOperationRestrictionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ea5c0817-d558-42ef-a5f9-9379560f16f1"),
				Name = @"UseSystemOperationRestrictions",
				CreatedInSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				ModifiedInSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysAdminOperationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysAdminOperationEventsProcessSchema() {
			var schema = new SysAdminOperationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysAdminOperation(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysAdminOperation_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysAdminOperationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysAdminOperationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"));
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminOperation

	/// <summary>
	/// Administrated operation.
	/// </summary>
	public class SysAdminOperation : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysAdminOperation(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysAdminOperation";
		}

		public SysAdminOperation(SysAdminOperation source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <exclude/>
		public Guid SysFolderId {
			get {
				return GetTypedColumnValue<Guid>("SysFolderId");
			}
			set {
				SetColumnValue("SysFolderId", value);
				_sysFolder = null;
			}
		}

		/// <exclude/>
		public string SysFolderName {
			get {
				return GetTypedColumnValue<string>("SysFolderName");
			}
			set {
				SetColumnValue("SysFolderName", value);
				if (_sysFolder != null) {
					_sysFolder.Name = value;
				}
			}
		}

		private SysAdminOperationFolder _sysFolder;
		/// <summary>
		/// Folder.
		/// </summary>
		public SysAdminOperationFolder SysFolder {
			get {
				return _sysFolder ??
					(_sysFolder = LookupColumnEntities.GetEntity("SysFolder") as SysAdminOperationFolder);
			}
		}

		/// <summary>
		/// Use restrictions on operations by system.
		/// </summary>
		public bool UseSystemOperationRestrictions {
			get {
				return GetTypedColumnValue<bool>("UseSystemOperationRestrictions");
			}
			set {
				SetColumnValue("UseSystemOperationRestrictions", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysAdminOperation_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysAdminOperationDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysAdminOperationDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysAdminOperationInserted", e);
			Inserting += (s, e) => ThrowEvent("SysAdminOperationInserting", e);
			Loading += (s, e) => ThrowEvent("SysAdminOperationLoading", e);
			Saved += (s, e) => ThrowEvent("SysAdminOperationSaved", e);
			Saving += (s, e) => ThrowEvent("SysAdminOperationSaving", e);
			Validating += (s, e) => ThrowEvent("SysAdminOperationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminOperation(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminOperation_BaseEventsProcess

	/// <exclude/>
	public partial class SysAdminOperation_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : SysAdminOperation
	{

		public SysAdminOperation_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysAdminOperation_BaseEventsProcess";
			SchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _sysAdminOperationEventSubProcess;
		public ProcessFlowElement SysAdminOperationEventSubProcess {
			get {
				return _sysAdminOperationEventSubProcess ?? (_sysAdminOperationEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysAdminOperationEventSubProcess",
					SchemaElementUId = new Guid("bef2c72a-43c9-4ff2-801c-e7f14cf2a523"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysAdminOperationSavingStartMessage;
		public ProcessFlowElement BaseSysAdminOperationSavingStartMessage {
			get {
				return _baseSysAdminOperationSavingStartMessage ?? (_baseSysAdminOperationSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysAdminOperationSavingStartMessage",
					SchemaElementUId = new Guid("b74e3c6a-9096-48b4-81c9-76578e09e044"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysAdminOperationInsertingStartMessage;
		public ProcessFlowElement BaseSysAdminOperationInsertingStartMessage {
			get {
				return _baseSysAdminOperationInsertingStartMessage ?? (_baseSysAdminOperationInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysAdminOperationInsertingStartMessage",
					SchemaElementUId = new Guid("06f042a4-4f3d-42fc-8a64-1a783fab322a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysAdminOperationDeletingStartMessage;
		public ProcessFlowElement BaseSysAdminOperationDeletingStartMessage {
			get {
				return _baseSysAdminOperationDeletingStartMessage ?? (_baseSysAdminOperationDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysAdminOperationDeletingStartMessage",
					SchemaElementUId = new Guid("9e3085f1-6ddd-40e6-baf8-9bebd9ab1fe4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysAdminOperationLoadingStartMessage;
		public ProcessFlowElement BaseSysAdminOperationLoadingStartMessage {
			get {
				return _baseSysAdminOperationLoadingStartMessage ?? (_baseSysAdminOperationLoadingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysAdminOperationLoadingStartMessage",
					SchemaElementUId = new Guid("73cbb533-a610-4648-abe4-79177b431a56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseSysAdminOperationCheckCanChangeScriptTask;
		public ProcessScriptTask BaseSysAdminOperationCheckCanChangeScriptTask {
			get {
				return _baseSysAdminOperationCheckCanChangeScriptTask ?? (_baseSysAdminOperationCheckCanChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseSysAdminOperationCheckCanChangeScriptTask",
					SchemaElementUId = new Guid("be2e37ec-dffe-42a8-8e77-5ef077924294"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseSysAdminOperationCheckCanChangeScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _baseSysAdminOperationCheckCanReadScriptTask;
		public ProcessScriptTask BaseSysAdminOperationCheckCanReadScriptTask {
			get {
				return _baseSysAdminOperationCheckCanReadScriptTask ?? (_baseSysAdminOperationCheckCanReadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseSysAdminOperationCheckCanReadScriptTask",
					SchemaElementUId = new Guid("35df9c08-0318-4108-b09a-ebd0b01d740b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseSysAdminOperationCheckCanReadScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SysAdminOperationEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysAdminOperationEventSubProcess };
			FlowElements[BaseSysAdminOperationSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysAdminOperationSavingStartMessage };
			FlowElements[BaseSysAdminOperationInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysAdminOperationInsertingStartMessage };
			FlowElements[BaseSysAdminOperationDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysAdminOperationDeletingStartMessage };
			FlowElements[BaseSysAdminOperationLoadingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysAdminOperationLoadingStartMessage };
			FlowElements[BaseSysAdminOperationCheckCanChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysAdminOperationCheckCanChangeScriptTask };
			FlowElements[BaseSysAdminOperationCheckCanReadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysAdminOperationCheckCanReadScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SysAdminOperationEventSubProcess":
						break;
					case "BaseSysAdminOperationSavingStartMessage":
						e.Context.QueueTasks.Enqueue("BaseSysAdminOperationCheckCanChangeScriptTask");
						break;
					case "BaseSysAdminOperationInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("BaseSysAdminOperationCheckCanChangeScriptTask");
						break;
					case "BaseSysAdminOperationDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("BaseSysAdminOperationCheckCanChangeScriptTask");
						break;
					case "BaseSysAdminOperationLoadingStartMessage":
						e.Context.QueueTasks.Enqueue("BaseSysAdminOperationCheckCanReadScriptTask");
						break;
					case "BaseSysAdminOperationCheckCanChangeScriptTask":
						break;
					case "BaseSysAdminOperationCheckCanReadScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseSysAdminOperationSavingStartMessage");
			ActivatedEventElements.Add("BaseSysAdminOperationInsertingStartMessage");
			ActivatedEventElements.Add("BaseSysAdminOperationDeletingStartMessage");
			ActivatedEventElements.Add("BaseSysAdminOperationLoadingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SysAdminOperationEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseSysAdminOperationSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysAdminOperationSavingStartMessage";
					result = BaseSysAdminOperationSavingStartMessage.Execute(context);
					break;
				case "BaseSysAdminOperationInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysAdminOperationInsertingStartMessage";
					result = BaseSysAdminOperationInsertingStartMessage.Execute(context);
					break;
				case "BaseSysAdminOperationDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysAdminOperationDeletingStartMessage";
					result = BaseSysAdminOperationDeletingStartMessage.Execute(context);
					break;
				case "BaseSysAdminOperationLoadingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysAdminOperationLoadingStartMessage";
					result = BaseSysAdminOperationLoadingStartMessage.Execute(context);
					break;
				case "BaseSysAdminOperationCheckCanChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysAdminOperationCheckCanChangeScriptTask";
					result = BaseSysAdminOperationCheckCanChangeScriptTask.Execute(context, BaseSysAdminOperationCheckCanChangeScriptTaskExecute);
					break;
				case "BaseSysAdminOperationCheckCanReadScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysAdminOperationCheckCanReadScriptTask";
					result = BaseSysAdminOperationCheckCanReadScriptTask.Execute(context, BaseSysAdminOperationCheckCanReadScriptTaskExecute);
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

		public virtual bool BaseSysAdminOperationCheckCanChangeScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public virtual bool BaseSysAdminOperationCheckCanReadScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanViewConfiguration") ||
					UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageSysSettings")) {
				return true;
			}
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysAdminOperationSaving":
							if (ActivatedEventElements.Contains("BaseSysAdminOperationSavingStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysAdminOperationSavingStartMessage");
						}
						break;
					case "SysAdminOperationInserting":
							if (ActivatedEventElements.Contains("BaseSysAdminOperationInsertingStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysAdminOperationInsertingStartMessage");
						}
						break;
					case "SysAdminOperationDeleting":
							if (ActivatedEventElements.Contains("BaseSysAdminOperationDeletingStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysAdminOperationDeletingStartMessage");
						}
						break;
					case "SysAdminOperationLoading":
							if (ActivatedEventElements.Contains("BaseSysAdminOperationLoadingStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysAdminOperationLoadingStartMessage");
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

	#region Class: SysAdminOperation_BaseEventsProcess

	/// <exclude/>
	public class SysAdminOperation_BaseEventsProcess : SysAdminOperation_BaseEventsProcess<SysAdminOperation>
	{

		public SysAdminOperation_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysAdminOperation_BaseEventsProcess

	public partial class SysAdminOperation_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

	#region Class: SysAdminOperationEventsProcessSchema

	/// <exclude/>
	public class SysAdminOperationEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysAdminOperationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysAdminOperationEventsProcessSchema(SysAdminOperationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysAdminOperation_BaseEventsProcess";
			UId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea");
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
			ProcessSchemaLaneSet schemaSysAdminOperationLaneSet = CreateSysAdminOperationLaneSetLaneSet();
			LaneSets.Add(schemaSysAdminOperationLaneSet);
			ProcessSchemaLane schemaSysAdminOperationLane = CreateSysAdminOperationLaneLane();
			schemaSysAdminOperationLaneSet.Lanes.Add(schemaSysAdminOperationLane);
			ProcessSchemaEventSubProcess sysadminoperationeventsubprocess = CreateSysAdminOperationEventSubProcessEventSubProcess();
			FlowElements.Add(sysadminoperationeventsubprocess);
			ProcessSchemaStartMessageEvent basesysadminoperationsavingstartmessage = CreateBaseSysAdminOperationSavingStartMessageStartMessageEvent();
			sysadminoperationeventsubprocess.FlowElements.Add(basesysadminoperationsavingstartmessage);
			ProcessSchemaStartMessageEvent basesysadminoperationinsertingstartmessage = CreateBaseSysAdminOperationInsertingStartMessageStartMessageEvent();
			sysadminoperationeventsubprocess.FlowElements.Add(basesysadminoperationinsertingstartmessage);
			ProcessSchemaStartMessageEvent basesysadminoperationdeletingstartmessage = CreateBaseSysAdminOperationDeletingStartMessageStartMessageEvent();
			sysadminoperationeventsubprocess.FlowElements.Add(basesysadminoperationdeletingstartmessage);
			ProcessSchemaStartMessageEvent basesysadminoperationloadingstartmessage = CreateBaseSysAdminOperationLoadingStartMessageStartMessageEvent();
			sysadminoperationeventsubprocess.FlowElements.Add(basesysadminoperationloadingstartmessage);
			ProcessSchemaScriptTask basesysadminoperationcheckcanchangescripttask = CreateBaseSysAdminOperationCheckCanChangeScriptTaskScriptTask();
			FlowElements.Add(basesysadminoperationcheckcanchangescripttask);
			ProcessSchemaScriptTask basesysadminoperationcheckcanreadscripttask = CreateBaseSysAdminOperationCheckCanReadScriptTaskScriptTask();
			FlowElements.Add(basesysadminoperationcheckcanreadscripttask);
			FlowElements.Add(CreateSysAdminOperationSavingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSysAdminOperationInsertingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSysAdminOperationDeletingSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4_42e394d9a1ed46edacde65b2743611f6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysAdminOperationSavingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysAdminOperationSavingSequenceFlow",
				UId = new Guid("1a628a40-8db9-4141-b355-bac52dbca652"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				CurveCenterPosition = new Point(194, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b74e3c6a-9096-48b4-81c9-76578e09e044"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("be2e37ec-dffe-42a8-8e77-5ef077924294"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(170, 81));
			schemaFlow.PolylinePointPositions.Add(new Point(170, 151));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysAdminOperationInsertingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysAdminOperationInsertingSequenceFlow",
				UId = new Guid("449a1195-302c-4995-b6ea-c30fc7beb5fe"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				CurveCenterPosition = new Point(224, 148),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("06f042a4-4f3d-42fc-8a64-1a783fab322a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("be2e37ec-dffe-42a8-8e77-5ef077924294"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysAdminOperationDeletingSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysAdminOperationDeletingSequenceFlow",
				UId = new Guid("948b7973-216e-4f63-b536-2be651cb05b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				CurveCenterPosition = new Point(217, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e3085f1-6ddd-40e6-baf8-9bebd9ab1fe4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("be2e37ec-dffe-42a8-8e77-5ef077924294"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(170, 221));
			schemaFlow.PolylinePointPositions.Add(new Point(170, 151));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_42e394d9a1ed46edacde65b2743611f6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_42e394d9a1ed46edacde65b2743611f6",
				UId = new Guid("42e394d9-a1ed-46ed-acde-65b2743611f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("73cbb533-a610-4648-abe4-79177b431a56"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("35df9c08-0318-4108-b09a-ebd0b01d740b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSysAdminOperationLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaSysAdminOperationLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("afbb418f-22c2-4c3e-965a-6912d2e2cb4a"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"SysAdminOperationLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(560, 298),
				UseBackgroundMode = false
			};
			return schemaSysAdminOperationLaneSet;
		}

		protected virtual ProcessSchemaLane CreateSysAdminOperationLaneLane() {
			ProcessSchemaLane schemaSysAdminOperationLane = new ProcessSchemaLane(this) {
				UId = new Guid("ee5ed392-fa51-499f-880b-a9fbb5aa0bfc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("afbb418f-22c2-4c3e-965a-6912d2e2cb4a"),
				CreatedInOwnerSchemaUId = new Guid("c8fd2fd0-1f44-48c7-84e4-045250b9a638"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"SysAdminOperationLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(531, 298),
				UseBackgroundMode = false
			};
			return schemaSysAdminOperationLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysAdminOperationEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysAdminOperationEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bef2c72a-43c9-4ff2-801c-e7f14cf2a523"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ee5ed392-fa51-499f-880b-a9fbb5aa0bfc"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"SysAdminOperationEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(31, 31),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(108, 329),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysAdminOperationEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysAdminOperationSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b74e3c6a-9096-48b4-81c9-76578e09e044"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bef2c72a-43c9-4ff2-801c-e7f14cf2a523"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminOperationSaving",
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"BaseSysAdminOperationSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysAdminOperationInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("06f042a4-4f3d-42fc-8a64-1a783fab322a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bef2c72a-43c9-4ff2-801c-e7f14cf2a523"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminOperationInserting",
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"BaseSysAdminOperationInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysAdminOperationDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9e3085f1-6ddd-40e6-baf8-9bebd9ab1fe4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bef2c72a-43c9-4ff2-801c-e7f14cf2a523"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminOperationDeleting",
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"BaseSysAdminOperationDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysAdminOperationLoadingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("73cbb533-a610-4648-abe4-79177b431a56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bef2c72a-43c9-4ff2-801c-e7f14cf2a523"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysAdminOperationLoading",
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"BaseSysAdminOperationLoadingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseSysAdminOperationCheckCanChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("be2e37ec-dffe-42a8-8e77-5ef077924294"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ee5ed392-fa51-499f-880b-a9fbb5aa0bfc"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("bc74f040-1e92-44f3-b554-0124b41c1915"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"BaseSysAdminOperationCheckCanChangeScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(246, 124),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,29,83,114,51,243,50,139,75,32,18,74,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,208,129,106,2,98,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseSysAdminOperationCheckCanReadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("35df9c08-0318-4108-b09a-ebd0b01d740b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ee5ed392-fa51-499f-880b-a9fbb5aa0bfc"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0"),
				CreatedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"),
				Name = @"BaseSysAdminOperationCheckCanReadScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(246, 264),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,142,177,10,194,48,20,69,231,230,43,66,166,102,233,15,116,210,90,156,196,161,232,30,234,109,124,136,175,37,121,65,139,245,223,173,136,224,164,131,235,225,222,123,46,117,58,223,69,132,170,103,70,43,212,115,177,90,54,104,83,32,25,107,246,196,40,214,144,202,113,125,157,169,96,59,32,184,103,46,55,51,220,19,46,115,181,35,159,94,212,88,61,77,42,203,254,216,220,56,118,30,205,24,27,136,16,251,104,172,213,55,149,5,72,10,172,37,36,148,234,174,126,25,170,35,218,211,119,199,226,112,38,166,40,239,235,165,250,116,60,0,188,31,232,86,27,1,0,0 }
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

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysAdminOperationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8014aa77-e963-4cdb-9b5d-d760714c8eea"));
		}

		#endregion

	}

	#endregion


	#region Class: SysAdminOperationEventsProcess

	/// <exclude/>
	public class SysAdminOperationEventsProcess : SysAdminOperation_BaseEventsProcess
	{

		public SysAdminOperationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

