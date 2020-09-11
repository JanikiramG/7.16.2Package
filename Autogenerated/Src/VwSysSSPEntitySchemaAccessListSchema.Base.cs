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

	#region Class: VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema(VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema(VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			RealUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			Name = "VwSysSSPEntitySchemaAccessList_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("317015be-6ee9-410c-9498-b07b82cfb6f3")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("4fa3d6c4-bcbe-4a4f-b36d-de76dd97e2a9")) == null) {
				Columns.Add(CreateWorkspaceIdColumn());
			}
			if (Columns.FindByUId(new Guid("229a3213-ff4e-4e32-a76d-b1098b341659")) == null) {
				Columns.Add(CreateSysSchemaColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			column.CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae");
			return column;
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("317015be-6ee9-410c-9498-b07b82cfb6f3"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"),
				ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateWorkspaceIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("4fa3d6c4-bcbe-4a4f-b36d-de76dd97e2a9"),
				Name = @"WorkspaceId",
				CreatedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"),
				ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("229a3213-ff4e-4e32-a76d-b1098b341659"),
				Name = @"SysSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"),
				ModifiedInSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"),
				CreatedInPackageId = new Guid("6bf5758c-66bd-49a0-954e-ca6d0303eb69")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema() {
			var schema = new VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysSSPEntitySchemaAccessList_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysSSPEntitySchemaAccessList_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysSSPEntitySchemaAccessList_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList_Base_Terrasoft

	/// <summary>
	/// SSP Entity Schema Access List (View).
	/// </summary>
	public class VwSysSSPEntitySchemaAccessList_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwSysSSPEntitySchemaAccessList_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysSSPEntitySchemaAccessList_Base_Terrasoft";
		}

		public VwSysSSPEntitySchemaAccessList_Base_Terrasoft(VwSysSSPEntitySchemaAccessList_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Object Id.
		/// </summary>
		public Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Workspace Id.
		/// </summary>
		public Guid WorkspaceId {
			get {
				return GetTypedColumnValue<Guid>("WorkspaceId");
			}
			set {
				SetColumnValue("WorkspaceId", value);
			}
		}

		/// <exclude/>
		public Guid SysSchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysSchemaId");
			}
			set {
				SetColumnValue("SysSchemaId", value);
				_sysSchema = null;
			}
		}

		/// <exclude/>
		public string SysSchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysSchemaCaption");
			}
			set {
				SetColumnValue("SysSchemaCaption", value);
				if (_sysSchema != null) {
					_sysSchema.Caption = value;
				}
			}
		}

		private SysSchema _sysSchema;
		/// <summary>
		/// Object.
		/// </summary>
		public SysSchema SysSchema {
			get {
				return _sysSchema ??
					(_sysSchema = LookupColumnEntities.GetEntity("SysSchema") as SysSchema);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysSSPEntitySchemaAccessList_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysSSPEntitySchemaAccessList_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwSysSSPEntitySchemaAccessList_Base_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("VwSysSSPEntitySchemaAccessList_Base_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("VwSysSSPEntitySchemaAccessList_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("VwSysSSPEntitySchemaAccessList_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysSSPEntitySchemaAccessList_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList_BaseEventsProcess

	/// <exclude/>
	public partial class VwSysSSPEntitySchemaAccessList_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : VwSysSSPEntitySchemaAccessList_Base_Terrasoft
	{

		public VwSysSSPEntitySchemaAccessList_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysSSPEntitySchemaAccessList_BaseEventsProcess";
			SchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _vwSysSSPEntitySchemaAccessListEventSubProcess;
		public ProcessFlowElement VwSysSSPEntitySchemaAccessListEventSubProcess {
			get {
				return _vwSysSSPEntitySchemaAccessListEventSubProcess ?? (_vwSysSSPEntitySchemaAccessListEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "VwSysSSPEntitySchemaAccessListEventSubProcess",
					SchemaElementUId = new Guid("8fdb7ac9-5be7-4e92-b456-de15dee14d03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysSSPEntitySchemaAccessListInsertingStartMessage;
		public ProcessFlowElement VwSysSSPEntitySchemaAccessListInsertingStartMessage {
			get {
				return _vwSysSSPEntitySchemaAccessListInsertingStartMessage ?? (_vwSysSSPEntitySchemaAccessListInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysSSPEntitySchemaAccessListInsertingStartMessage",
					SchemaElementUId = new Guid("7271bffd-7aa3-47d4-907c-5c1b48e32645"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysSSPEntitySchemaAccessListSavingStartMessage;
		public ProcessFlowElement VwSysSSPEntitySchemaAccessListSavingStartMessage {
			get {
				return _vwSysSSPEntitySchemaAccessListSavingStartMessage ?? (_vwSysSSPEntitySchemaAccessListSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysSSPEntitySchemaAccessListSavingStartMessage",
					SchemaElementUId = new Guid("80b414d7-268c-437c-8d22-17d4a0a7aa2d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _vwSysSSPEntitySchemaAccessListDeletingStartMessage;
		public ProcessFlowElement VwSysSSPEntitySchemaAccessListDeletingStartMessage {
			get {
				return _vwSysSSPEntitySchemaAccessListDeletingStartMessage ?? (_vwSysSSPEntitySchemaAccessListDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "VwSysSSPEntitySchemaAccessListDeletingStartMessage",
					SchemaElementUId = new Guid("e0153570-d317-41d5-b04a-fc49842828d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkCanManageLookupsScriptTask;
		public ProcessScriptTask CheckCanManageLookupsScriptTask {
			get {
				return _checkCanManageLookupsScriptTask ?? (_checkCanManageLookupsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckCanManageLookupsScriptTask",
					SchemaElementUId = new Guid("866a0395-7f15-4d45-a855-3b679bf72692"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckCanManageLookupsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[VwSysSSPEntitySchemaAccessListEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysSSPEntitySchemaAccessListEventSubProcess };
			FlowElements[VwSysSSPEntitySchemaAccessListInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysSSPEntitySchemaAccessListInsertingStartMessage };
			FlowElements[VwSysSSPEntitySchemaAccessListSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysSSPEntitySchemaAccessListSavingStartMessage };
			FlowElements[VwSysSSPEntitySchemaAccessListDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { VwSysSSPEntitySchemaAccessListDeletingStartMessage };
			FlowElements[CheckCanManageLookupsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckCanManageLookupsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "VwSysSSPEntitySchemaAccessListEventSubProcess":
						break;
					case "VwSysSSPEntitySchemaAccessListInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "VwSysSSPEntitySchemaAccessListSavingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "VwSysSSPEntitySchemaAccessListDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("CheckCanManageLookupsScriptTask");
						break;
					case "CheckCanManageLookupsScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("VwSysSSPEntitySchemaAccessListInsertingStartMessage");
			ActivatedEventElements.Add("VwSysSSPEntitySchemaAccessListSavingStartMessage");
			ActivatedEventElements.Add("VwSysSSPEntitySchemaAccessListDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "VwSysSSPEntitySchemaAccessListEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "VwSysSSPEntitySchemaAccessListInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysSSPEntitySchemaAccessListInsertingStartMessage";
					result = VwSysSSPEntitySchemaAccessListInsertingStartMessage.Execute(context);
					break;
				case "VwSysSSPEntitySchemaAccessListSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysSSPEntitySchemaAccessListSavingStartMessage";
					result = VwSysSSPEntitySchemaAccessListSavingStartMessage.Execute(context);
					break;
				case "VwSysSSPEntitySchemaAccessListDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "VwSysSSPEntitySchemaAccessListDeletingStartMessage";
					result = VwSysSSPEntitySchemaAccessListDeletingStartMessage.Execute(context);
					break;
				case "CheckCanManageLookupsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckCanManageLookupsScriptTask";
					result = CheckCanManageLookupsScriptTask.Execute(context, CheckCanManageLookupsScriptTaskExecute);
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

		public virtual bool CheckCanManageLookupsScriptTaskExecute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageLookups");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwSysSSPEntitySchemaAccessList_Base_TerrasoftInserting":
							if (ActivatedEventElements.Contains("VwSysSSPEntitySchemaAccessListInsertingStartMessage")) {
							context.QueueTasks.Enqueue("VwSysSSPEntitySchemaAccessListInsertingStartMessage");
						}
						break;
					case "VwSysSSPEntitySchemaAccessList_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("VwSysSSPEntitySchemaAccessListSavingStartMessage")) {
							context.QueueTasks.Enqueue("VwSysSSPEntitySchemaAccessListSavingStartMessage");
						}
						break;
					case "VwSysSSPEntitySchemaAccessList_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("VwSysSSPEntitySchemaAccessListDeletingStartMessage")) {
							context.QueueTasks.Enqueue("VwSysSSPEntitySchemaAccessListDeletingStartMessage");
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

	#region Class: VwSysSSPEntitySchemaAccessList_BaseEventsProcess

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessList_BaseEventsProcess : VwSysSSPEntitySchemaAccessList_BaseEventsProcess<VwSysSSPEntitySchemaAccessList_Base_Terrasoft>
	{

		public VwSysSSPEntitySchemaAccessList_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList_BaseEventsProcess

	public partial class VwSysSSPEntitySchemaAccessList_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema(VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysSSPEntitySchemaAccessList_BaseEventsProcess";
			UId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc");
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
			ProcessSchemaLaneSet schemaVwSysSSPEntitySchemaAccessListLaneSet = CreateVwSysSSPEntitySchemaAccessListLaneSetLaneSet();
			LaneSets.Add(schemaVwSysSSPEntitySchemaAccessListLaneSet);
			ProcessSchemaLane schemaVwSysSSPEntitySchemaAccessListLane = CreateVwSysSSPEntitySchemaAccessListLaneLane();
			schemaVwSysSSPEntitySchemaAccessListLaneSet.Lanes.Add(schemaVwSysSSPEntitySchemaAccessListLane);
			ProcessSchemaEventSubProcess vwsyssspentityschemaaccesslisteventsubprocess = CreateVwSysSSPEntitySchemaAccessListEventSubProcessEventSubProcess();
			FlowElements.Add(vwsyssspentityschemaaccesslisteventsubprocess);
			ProcessSchemaStartMessageEvent vwsyssspentityschemaaccesslistinsertingstartmessage = CreateVwSysSSPEntitySchemaAccessListInsertingStartMessageStartMessageEvent();
			vwsyssspentityschemaaccesslisteventsubprocess.FlowElements.Add(vwsyssspentityschemaaccesslistinsertingstartmessage);
			ProcessSchemaStartMessageEvent vwsyssspentityschemaaccesslistsavingstartmessage = CreateVwSysSSPEntitySchemaAccessListSavingStartMessageStartMessageEvent();
			vwsyssspentityschemaaccesslisteventsubprocess.FlowElements.Add(vwsyssspentityschemaaccesslistsavingstartmessage);
			ProcessSchemaStartMessageEvent vwsyssspentityschemaaccesslistdeletingstartmessage = CreateVwSysSSPEntitySchemaAccessListDeletingStartMessageStartMessageEvent();
			vwsyssspentityschemaaccesslisteventsubprocess.FlowElements.Add(vwsyssspentityschemaaccesslistdeletingstartmessage);
			ProcessSchemaScriptTask checkcanmanagelookupsscripttask = CreateCheckCanManageLookupsScriptTaskScriptTask();
			FlowElements.Add(checkcanmanagelookupsscripttask);
			FlowElements.Add(CreateVwSysSSPEntitySchemaAccessListSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateVwSysSSPEntitySchemaAccessListSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateVwSysSSPEntitySchemaAccessListSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateVwSysSSPEntitySchemaAccessListSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "VwSysSSPEntitySchemaAccessListSequenceFlow1",
				UId = new Guid("8c927e1d-e176-4eb4-a35c-933f612816be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				CurveCenterPosition = new Point(202, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7271bffd-7aa3-47d4-907c-5c1b48e32645"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("866a0395-7f15-4d45-a855-3b679bf72692"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateVwSysSSPEntitySchemaAccessListSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "VwSysSSPEntitySchemaAccessListSequenceFlow2",
				UId = new Guid("e18f433f-426d-4749-a1f7-0d89899ceef3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				CurveCenterPosition = new Point(192, 108),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80b414d7-268c-437c-8d22-17d4a0a7aa2d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("866a0395-7f15-4d45-a855-3b679bf72692"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateVwSysSSPEntitySchemaAccessListSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "VwSysSSPEntitySchemaAccessListSequenceFlow3",
				UId = new Guid("dec75fdc-5714-4a24-8d04-61fbd2609d7c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				CurveCenterPosition = new Point(198, 143),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e0153570-d317-41d5-b04a-fc49842828d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("866a0395-7f15-4d45-a855-3b679bf72692"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateVwSysSSPEntitySchemaAccessListLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaVwSysSSPEntitySchemaAccessListLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3702a129-3391-4cc7-9040-d2bab9df60f5"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Name = @"VwSysSSPEntitySchemaAccessListLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(560, 241),
				UseBackgroundMode = false
			};
			return schemaVwSysSSPEntitySchemaAccessListLaneSet;
		}

		protected virtual ProcessSchemaLane CreateVwSysSSPEntitySchemaAccessListLaneLane() {
			ProcessSchemaLane schemaVwSysSSPEntitySchemaAccessListLane = new ProcessSchemaLane(this) {
				UId = new Guid("7e36a4a1-ce50-4610-ac17-228dc48a229d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("3702a129-3391-4cc7-9040-d2bab9df60f5"),
				CreatedInOwnerSchemaUId = new Guid("a7982d2c-1ee2-43ce-a6e1-43d6c67c5a51"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Name = @"VwSysSSPEntitySchemaAccessListLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(531, 241),
				UseBackgroundMode = false
			};
			return schemaVwSysSSPEntitySchemaAccessListLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateVwSysSSPEntitySchemaAccessListEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaVwSysSSPEntitySchemaAccessListEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8fdb7ac9-5be7-4e92-b456-de15dee14d03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e36a4a1-ce50-4610-ac17-228dc48a229d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Name = @"VwSysSSPEntitySchemaAccessListEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(106, 220),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaVwSysSSPEntitySchemaAccessListEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysSSPEntitySchemaAccessListInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7271bffd-7aa3-47d4-907c-5c1b48e32645"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fdb7ac9-5be7-4e92-b456-de15dee14d03"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysSSPEntitySchemaAccessListInserting",
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Name = @"VwSysSSPEntitySchemaAccessListInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysSSPEntitySchemaAccessListSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("80b414d7-268c-437c-8d22-17d4a0a7aa2d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fdb7ac9-5be7-4e92-b456-de15dee14d03"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysSSPEntitySchemaAccessListSaving",
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Name = @"VwSysSSPEntitySchemaAccessListSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 79),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateVwSysSSPEntitySchemaAccessListDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e0153570-d317-41d5-b04a-fc49842828d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8fdb7ac9-5be7-4e92-b456-de15dee14d03"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwSysSSPEntitySchemaAccessListDeleting",
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Name = @"VwSysSSPEntitySchemaAccessListDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckCanManageLookupsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("866a0395-7f15-4d45-a855-3b679bf72692"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e36a4a1-ce50-4610-ac17-228dc48a229d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("405a3e7e-e05d-42ab-853f-d735e8887459"),
				CreatedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("f663fb8e-2710-4953-b392-24294b581dbc"),
				Name = @"CheckCanManageLookupsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(204, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,125,242,243,179,75,11,138,149,52,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,55,130,180,236,91,0,0,0 }
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysSSPEntitySchemaAccessList_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f663fb8e-2710-4953-b392-24294b581dbc"));
		}

		#endregion

	}

	#endregion

}

