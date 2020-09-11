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

	#region Class: SysOperationAuditArchSchema

	/// <exclude/>
	public class SysOperationAuditArchSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysOperationAuditArchSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysOperationAuditArchSchema(SysOperationAuditArchSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysOperationAuditArchSchema(SysOperationAuditArchSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			RealUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			Name = "SysOperationAuditArch";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateClientIPColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("aa6999c4-0a5e-4013-ba29-78dbd6bfcb0d")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("d62f7a30-6130-4496-9c2a-ecca64cfd7c8")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("c8a2e079-b969-49bf-a572-2c3ece20dd9b")) == null) {
				Columns.Add(CreateResultColumn());
			}
			if (Columns.FindByUId(new Guid("19f4d83d-045c-492b-85d5-aede10046819")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("a1e9811a-a1c2-4dc6-be08-a34ec5ffe9ab")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("aa6999c4-0a5e-4013-ba29-78dbd6bfcb0d"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("7a8084be-bb98-48f0-b227-bae6050a1a40"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("d62f7a30-6130-4496-9c2a-ecca64cfd7c8"),
				Name = @"Date",
				CreatedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c8a2e079-b969-49bf-a572-2c3ece20dd9b"),
				Name = @"Result",
				ReferenceSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("19f4d83d-045c-492b-85d5-aede10046819"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateClientIPColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("bea6436e-911d-4aec-bbf7-d9cd48d1c903"),
				Name = @"ClientIP",
				CreatedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a1e9811a-a1c2-4dc6-be08-a34ec5ffe9ab"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				ModifiedInSchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysOperationAuditArchEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysOperationAuditArchEventsProcessSchema() {
			var schema = new SysOperationAuditArchEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysOperationAuditArch(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysOperationAuditArch_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysOperationAuditArchSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysOperationAuditArchSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7"));
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationAuditArch

	/// <summary>
	/// Archive of system operations audit log.
	/// </summary>
	public class SysOperationAuditArch : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysOperationAuditArch(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysOperationAuditArch";
		}

		public SysOperationAuditArch(SysOperationAuditArch source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SysOperationType _type;
		/// <summary>
		/// Event type.
		/// </summary>
		public SysOperationType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as SysOperationType);
			}
		}

		/// <summary>
		/// Event date.
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

		private SysOperationResult _result;
		/// <summary>
		/// Event result.
		/// </summary>
		public SysOperationResult Result {
			get {
				return _result ??
					(_result = LookupColumnEntities.GetEntity("Result") as SysOperationResult);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <summary>
		/// IP address.
		/// </summary>
		public string ClientIP {
			get {
				return GetTypedColumnValue<string>("ClientIP");
			}
			set {
				SetColumnValue("ClientIP", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysOperationAuditArch_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysOperationAuditArchDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysOperationAuditArchInserting", e);
			Loading += (s, e) => ThrowEvent("SysOperationAuditArchLoading", e);
			Validating += (s, e) => ThrowEvent("SysOperationAuditArchValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysOperationAuditArch(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationAuditArch_BaseEventsProcess

	/// <exclude/>
	public partial class SysOperationAuditArch_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysOperationAuditArch
	{

		public SysOperationAuditArch_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysOperationAuditArch_BaseEventsProcess";
			SchemaUId = new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ad2cf340-cf67-4694-b1ab-a07d163420a7");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _sysOperationAuditArchEventSubProcess;
		public ProcessFlowElement SysOperationAuditArchEventSubProcess {
			get {
				return _sysOperationAuditArchEventSubProcess ?? (_sysOperationAuditArchEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysOperationAuditArchEventSubProcess",
					SchemaElementUId = new Guid("7e1be344-1e91-4c1e-8d5e-af7caa35a7b8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysOperationAuditArchLoadingStartMessage;
		public ProcessFlowElement BaseSysOperationAuditArchLoadingStartMessage {
			get {
				return _baseSysOperationAuditArchLoadingStartMessage ?? (_baseSysOperationAuditArchLoadingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysOperationAuditArchLoadingStartMessage",
					SchemaElementUId = new Guid("e2c89e03-cff3-45fc-9284-e0dc66b2f3e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysOperationAuditArchChekCanRightScriptTask;
		public ProcessScriptTask SysOperationAuditArchChekCanRightScriptTask {
			get {
				return _sysOperationAuditArchChekCanRightScriptTask ?? (_sysOperationAuditArchChekCanRightScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysOperationAuditArchChekCanRightScriptTask",
					SchemaElementUId = new Guid("ce323912-8fa6-47bd-ada3-c5993bd005a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysOperationAuditArchChekCanRightScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SysOperationAuditArchEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysOperationAuditArchEventSubProcess };
			FlowElements[BaseSysOperationAuditArchLoadingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysOperationAuditArchLoadingStartMessage };
			FlowElements[SysOperationAuditArchChekCanRightScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysOperationAuditArchChekCanRightScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SysOperationAuditArchEventSubProcess":
						break;
					case "BaseSysOperationAuditArchLoadingStartMessage":
						e.Context.QueueTasks.Enqueue("SysOperationAuditArchChekCanRightScriptTask");
						break;
					case "SysOperationAuditArchChekCanRightScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseSysOperationAuditArchLoadingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SysOperationAuditArchEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseSysOperationAuditArchLoadingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysOperationAuditArchLoadingStartMessage";
					result = BaseSysOperationAuditArchLoadingStartMessage.Execute(context);
					break;
				case "SysOperationAuditArchChekCanRightScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysOperationAuditArchChekCanRightScriptTask";
					result = SysOperationAuditArchChekCanRightScriptTask.Execute(context, SysOperationAuditArchChekCanRightScriptTaskExecute);
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

		public virtual bool SysOperationAuditArchChekCanRightScriptTaskExecute(ProcessExecutingContext context) {
			CheckCanViewSysOperationAudit();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysOperationAuditArchLoading":
							if (ActivatedEventElements.Contains("BaseSysOperationAuditArchLoadingStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysOperationAuditArchLoadingStartMessage");
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

	#region Class: SysOperationAuditArch_BaseEventsProcess

	/// <exclude/>
	public class SysOperationAuditArch_BaseEventsProcess : SysOperationAuditArch_BaseEventsProcess<SysOperationAuditArch>
	{

		public SysOperationAuditArch_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysOperationAuditArch_BaseEventsProcess

	public partial class SysOperationAuditArch_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CheckCanViewSysOperationAudit() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanViewSysOperationAudit");
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationAuditArchEventsProcessSchema

	/// <exclude/>
	public class SysOperationAuditArchEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysOperationAuditArchEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysOperationAuditArchEventsProcessSchema(SysOperationAuditArchEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysOperationAuditArch_BaseEventsProcess";
			UId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc");
			CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
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
			ProcessSchemaLaneSet schemaSysOperationAuditArchLaneSet1 = CreateSysOperationAuditArchLaneSet1LaneSet();
			LaneSets.Add(schemaSysOperationAuditArchLaneSet1);
			ProcessSchemaLane schemaSysOperationAuditArchLane1 = CreateSysOperationAuditArchLane1Lane();
			schemaSysOperationAuditArchLaneSet1.Lanes.Add(schemaSysOperationAuditArchLane1);
			ProcessSchemaEventSubProcess sysoperationauditarcheventsubprocess = CreateSysOperationAuditArchEventSubProcessEventSubProcess();
			FlowElements.Add(sysoperationauditarcheventsubprocess);
			ProcessSchemaStartMessageEvent basesysoperationauditarchloadingstartmessage = CreateBaseSysOperationAuditArchLoadingStartMessageStartMessageEvent();
			sysoperationauditarcheventsubprocess.FlowElements.Add(basesysoperationauditarchloadingstartmessage);
			ProcessSchemaScriptTask sysoperationauditarchchekcanrightscripttask = CreateSysOperationAuditArchChekCanRightScriptTaskScriptTask();
			FlowElements.Add(sysoperationauditarchchekcanrightscripttask);
			FlowElements.Add(CreateSysOperationAuditArchSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysOperationAuditArchSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysOperationAuditArchSequenceFlow1",
				UId = new Guid("8595e3dd-92de-4569-978e-b7d60d33cae4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e2c89e03-cff3-45fc-9284-e0dc66b2f3e3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ce323912-8fa6-47bd-ada3-c5993bd005a2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSysOperationAuditArchLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaSysOperationAuditArchLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("dcd2f9de-230c-4c02-93d1-906f18e0a3d4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				Name = @"SysOperationAuditArchLaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaSysOperationAuditArchLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateSysOperationAuditArchLane1Lane() {
			ProcessSchemaLane schemaSysOperationAuditArchLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("776f4875-cf6a-4166-9c51-e34405ac549d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dcd2f9de-230c-4c02-93d1-906f18e0a3d4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				Name = @"SysOperationAuditArchLane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaSysOperationAuditArchLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysOperationAuditArchEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysOperationAuditArchEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7e1be344-1e91-4c1e-8d5e-af7caa35a7b8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("776f4875-cf6a-4166-9c51-e34405ac549d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				Name = @"SysOperationAuditArchEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(119, 101),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(114, 119),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysOperationAuditArchEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysOperationAuditArchLoadingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e2c89e03-cff3-45fc-9284-e0dc66b2f3e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1be344-1e91-4c1e-8d5e-af7caa35a7b8"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysOperationAuditArchLoading",
				ModifiedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				Name = @"BaseSysOperationAuditArchLoadingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(34, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysOperationAuditArchChekCanRightScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ce323912-8fa6-47bd-ada3-c5993bd005a2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("776f4875-cf6a-4166-9c51-e34405ac549d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				Name = @"SysOperationAuditArchChekCanRightScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(262, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,72,77,206,118,78,204,11,203,76,45,15,174,44,246,47,72,45,74,44,201,204,207,115,44,77,201,44,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,199,42,120,252,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCheckCanViewSysOperationAuditMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
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

		protected virtual SchemaMethod CreateCheckCanViewSysOperationAuditMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("74eefe30-ab4c-47c3-abb6-18150c6cfc9b"),
				Name = "CheckCanViewSysOperationAudit",
				CreatedInSchemaUId = new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,195,50,83,203,131,43,139,225,130,142,165,41,153,37,74,154,214,0,72,212,102,77,85,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysOperationAuditArchEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56e2e1f0-5ffd-4c60-b7a0-df290e6f9ddc"));
		}

		#endregion

	}

	#endregion


	#region Class: SysOperationAuditArchEventsProcess

	/// <exclude/>
	public class SysOperationAuditArchEventsProcess : SysOperationAuditArch_BaseEventsProcess
	{

		public SysOperationAuditArchEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

