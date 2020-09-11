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

	#region Class: SysOperationAuditSchema

	/// <exclude/>
	public class SysOperationAuditSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysOperationAuditSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysOperationAuditSchema(SysOperationAuditSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysOperationAuditSchema(SysOperationAuditSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			RealUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			Name = "SysOperationAudit";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
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
			if (Columns.FindByUId(new Guid("ac32b7ac-2006-4789-9e8d-1e46436811a5")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("95d3ce80-8ed6-465a-9e57-0c9a8acf9f0e")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("bd277f78-c845-40cc-b686-7ea4bea1317f")) == null) {
				Columns.Add(CreateResultColumn());
			}
			if (Columns.FindByUId(new Guid("14260b25-ce7c-4d2f-a1e7-4788fe72af62")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("de44d071-4768-41f7-93d7-5b56260e1b15")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			column.CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			column.CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			column.CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			column.CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			column.CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			column.CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("ac32b7ac-2006-4789-9e8d-1e46436811a5"),
				Name = @"Date",
				CreatedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("95d3ce80-8ed6-465a-9e57-0c9a8acf9f0e"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("7a8084be-bb98-48f0-b227-bae6050a1a40"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			};
		}

		protected virtual EntitySchemaColumn CreateResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bd277f78-c845-40cc-b686-7ea4bea1317f"),
				Name = @"Result",
				ReferenceSchemaUId = new Guid("d13590dc-314e-4edc-a2c2-7db0e82e672e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("14260b25-ce7c-4d2f-a1e7-4788fe72af62"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			};
		}

		protected virtual EntitySchemaColumn CreateClientIPColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d98f99db-ab89-406d-abba-f406652f0e43"),
				Name = @"ClientIP",
				CreatedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("de44d071-4768-41f7-93d7-5b56260e1b15"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				ModifiedInSchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"),
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540"),
				IsMultiLineText = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysOperationAuditEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysOperationAuditEventsProcessSchema() {
			var schema = new SysOperationAuditEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysOperationAudit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysOperationAudit_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysOperationAuditSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysOperationAuditSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6"));
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationAudit

	/// <summary>
	/// Audit log.
	/// </summary>
	public class SysOperationAudit : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysOperationAudit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysOperationAudit";
		}

		public SysOperationAudit(SysOperationAudit source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		/// Type.
		/// </summary>
		public SysOperationType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as SysOperationType);
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
		/// Result.
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
			var process = new SysOperationAudit_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysOperationAuditDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysOperationAuditInserting", e);
			Loading += (s, e) => ThrowEvent("SysOperationAuditLoading", e);
			Validating += (s, e) => ThrowEvent("SysOperationAuditValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysOperationAudit(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationAudit_BaseEventsProcess

	/// <exclude/>
	public partial class SysOperationAudit_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysOperationAudit
	{

		public SysOperationAudit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysOperationAudit_BaseEventsProcess";
			SchemaUId = new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1685a98f-d6cc-4c1b-bcdc-c38145963ae6");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _sysOperationAuditEventSubProcess;
		public ProcessFlowElement SysOperationAuditEventSubProcess {
			get {
				return _sysOperationAuditEventSubProcess ?? (_sysOperationAuditEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SysOperationAuditEventSubProcess",
					SchemaElementUId = new Guid("ffc3697f-ed26-44fd-9241-5788ba8fe049"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _baseSysOperationAuditLoadingStartMessage;
		public ProcessFlowElement BaseSysOperationAuditLoadingStartMessage {
			get {
				return _baseSysOperationAuditLoadingStartMessage ?? (_baseSysOperationAuditLoadingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BaseSysOperationAuditLoadingStartMessage",
					SchemaElementUId = new Guid("2e208d63-0110-4cd1-805e-d797ed287705"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysOperationAuditChekCanRightScriptTask;
		public ProcessScriptTask SysOperationAuditChekCanRightScriptTask {
			get {
				return _sysOperationAuditChekCanRightScriptTask ?? (_sysOperationAuditChekCanRightScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysOperationAuditChekCanRightScriptTask",
					SchemaElementUId = new Guid("3c74ec06-8480-4e14-ad0d-ac6e3e7bd302"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysOperationAuditChekCanRightScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SysOperationAuditEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SysOperationAuditEventSubProcess };
			FlowElements[BaseSysOperationAuditLoadingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseSysOperationAuditLoadingStartMessage };
			FlowElements[SysOperationAuditChekCanRightScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysOperationAuditChekCanRightScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SysOperationAuditEventSubProcess":
						break;
					case "BaseSysOperationAuditLoadingStartMessage":
						e.Context.QueueTasks.Enqueue("SysOperationAuditChekCanRightScriptTask");
						break;
					case "SysOperationAuditChekCanRightScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BaseSysOperationAuditLoadingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SysOperationAuditEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BaseSysOperationAuditLoadingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseSysOperationAuditLoadingStartMessage";
					result = BaseSysOperationAuditLoadingStartMessage.Execute(context);
					break;
				case "SysOperationAuditChekCanRightScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysOperationAuditChekCanRightScriptTask";
					result = SysOperationAuditChekCanRightScriptTask.Execute(context, SysOperationAuditChekCanRightScriptTaskExecute);
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

		public virtual bool SysOperationAuditChekCanRightScriptTaskExecute(ProcessExecutingContext context) {
			CheckCanViewSysOperationAudit();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysOperationAuditLoading":
							if (ActivatedEventElements.Contains("BaseSysOperationAuditLoadingStartMessage")) {
							context.QueueTasks.Enqueue("BaseSysOperationAuditLoadingStartMessage");
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

	#region Class: SysOperationAudit_BaseEventsProcess

	/// <exclude/>
	public class SysOperationAudit_BaseEventsProcess : SysOperationAudit_BaseEventsProcess<SysOperationAudit>
	{

		public SysOperationAudit_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysOperationAudit_BaseEventsProcess

	public partial class SysOperationAudit_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CheckCanViewSysOperationAudit() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanViewSysOperationAudit");
		}

		#endregion

	}

	#endregion

	#region Class: SysOperationAuditEventsProcessSchema

	/// <exclude/>
	public class SysOperationAuditEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysOperationAuditEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysOperationAuditEventsProcessSchema(SysOperationAuditEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysOperationAudit_BaseEventsProcess";
			UId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a");
			CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540");
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
			ProcessSchemaLaneSet schemaSysOperationAuditLaneSet1 = CreateSysOperationAuditLaneSet1LaneSet();
			LaneSets.Add(schemaSysOperationAuditLaneSet1);
			ProcessSchemaLane schemaSysOperationAuditLane1 = CreateSysOperationAuditLane1Lane();
			schemaSysOperationAuditLaneSet1.Lanes.Add(schemaSysOperationAuditLane1);
			ProcessSchemaEventSubProcess sysoperationauditeventsubprocess = CreateSysOperationAuditEventSubProcessEventSubProcess();
			FlowElements.Add(sysoperationauditeventsubprocess);
			ProcessSchemaStartMessageEvent basesysoperationauditloadingstartmessage = CreateBaseSysOperationAuditLoadingStartMessageStartMessageEvent();
			sysoperationauditeventsubprocess.FlowElements.Add(basesysoperationauditloadingstartmessage);
			ProcessSchemaScriptTask sysoperationauditchekcanrightscripttask = CreateSysOperationAuditChekCanRightScriptTaskScriptTask();
			FlowElements.Add(sysoperationauditchekcanrightscripttask);
			FlowElements.Add(CreateSysOperationAuditSequenceFlowSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSysOperationAuditSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SysOperationAuditSequenceFlow",
				UId = new Guid("12e6ea83-efba-4478-9fc8-f9cf7b6d7f11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2e208d63-0110-4cd1-805e-d797ed287705"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c74ec06-8480-4e14-ad0d-ac6e3e7bd302"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSysOperationAuditLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaSysOperationAuditLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("60e776c0-383e-4c1d-bbd6-21001829374a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				Name = @"SysOperationAuditLaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaSysOperationAuditLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateSysOperationAuditLane1Lane() {
			ProcessSchemaLane schemaSysOperationAuditLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b3c3935e-fde9-4f90-9503-9e15cfa40d65"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60e776c0-383e-4c1d-bbd6-21001829374a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				Name = @"SysOperationAuditLane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaSysOperationAuditLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSysOperationAuditEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSysOperationAuditEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ffc3697f-ed26-44fd-9241-5788ba8fe049"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3c3935e-fde9-4f90-9503-9e15cfa40d65"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				Name = @"SysOperationAuditEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(86, 119),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(113, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSysOperationAuditEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBaseSysOperationAuditLoadingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2e208d63-0110-4cd1-805e-d797ed287705"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffc3697f-ed26-44fd-9241-5788ba8fe049"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysOperationAuditLoading",
				ModifiedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				Name = @"BaseSysOperationAuditLoadingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysOperationAuditChekCanRightScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3c74ec06-8480-4e14-ad0d-ac6e3e7bd302"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b3c3935e-fde9-4f90-9503-9e15cfa40d65"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				Name = @"SysOperationAuditChekCanRightScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(231, 161),
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
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b40b5a4a-23e9-4656-9186-2b322b13e540")
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
				UId = new Guid("f8aa9485-0af5-4a85-8ba2-75a75eb15902"),
				Name = "CheckCanViewSysOperationAudit",
				CreatedInSchemaUId = new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,195,50,83,203,131,43,139,225,130,142,165,41,153,37,74,154,214,0,72,212,102,77,85,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysOperationAuditEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3dbd44c5-e422-46b0-8063-2ec8e6f8569a"));
		}

		#endregion

	}

	#endregion


	#region Class: SysOperationAuditEventsProcess

	/// <exclude/>
	public class SysOperationAuditEventsProcess : SysOperationAudit_BaseEventsProcess
	{

		public SysOperationAuditEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

