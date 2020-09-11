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
	using Terrasoft.Web.Common;

	#region Class: SysUserInRole_Base_TerrasoftSchema

	/// <exclude/>
	public class SysUserInRole_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysUserInRole_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysUserInRole_Base_TerrasoftSchema(SysUserInRole_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysUserInRole_Base_TerrasoftSchema(SysUserInRole_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			RealUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			Name = "SysUserInRole_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c540ad32-33ed-4ad0-abb7-cc1575b9f6f2")) == null) {
				Columns.Add(CreateSysUserColumn());
			}
			if (Columns.FindByUId(new Guid("ceffac9c-08c8-4792-a3fc-2931b23bc538")) == null) {
				Columns.Add(CreateSysRoleColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c540ad32-33ed-4ad0-abb7-cc1575b9f6f2"),
				Name = @"SysUser",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInSchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a"),
				ModifiedInSchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateSysRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ceffac9c-08c8-4792-a3fc-2931b23bc538"),
				Name = @"SysRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInSchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a"),
				ModifiedInSchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysUserInRole_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysUserInRole_Base_TerrasoftEventsProcessSchema() {
			var schema = new SysUserInRole_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysUserInRole_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysUserInRole_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysUserInRole_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysUserInRole_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a"));
		}

		#endregion

	}

	#endregion

	#region Class: SysUserInRole_Base_Terrasoft

	/// <summary>
	/// User in roles.
	/// </summary>
	public class SysUserInRole_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysUserInRole_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysUserInRole_Base_Terrasoft";
		}

		public SysUserInRole_Base_Terrasoft(SysUserInRole_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysUserId {
			get {
				return GetTypedColumnValue<Guid>("SysUserId");
			}
			set {
				SetColumnValue("SysUserId", value);
				_sysUser = null;
			}
		}

		/// <exclude/>
		public string SysUserName {
			get {
				return GetTypedColumnValue<string>("SysUserName");
			}
			set {
				SetColumnValue("SysUserName", value);
				if (_sysUser != null) {
					_sysUser.Name = value;
				}
			}
		}

		private SysAdminUnit _sysUser;
		/// <summary>
		/// User.
		/// </summary>
		public SysAdminUnit SysUser {
			get {
				return _sysUser ??
					(_sysUser = LookupColumnEntities.GetEntity("SysUser") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid SysRoleId {
			get {
				return GetTypedColumnValue<Guid>("SysRoleId");
			}
			set {
				SetColumnValue("SysRoleId", value);
				_sysRole = null;
			}
		}

		/// <exclude/>
		public string SysRoleName {
			get {
				return GetTypedColumnValue<string>("SysRoleName");
			}
			set {
				SetColumnValue("SysRoleName", value);
				if (_sysRole != null) {
					_sysRole.Name = value;
				}
			}
		}

		private SysAdminUnit _sysRole;
		/// <summary>
		/// Role.
		/// </summary>
		public SysAdminUnit SysRole {
			get {
				return _sysRole ??
					(_sysRole = LookupColumnEntities.GetEntity("SysRole") as SysAdminUnit);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysUserInRole_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysUserInRole_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysUserInRole_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysUserInRole_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("SysUserInRole_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("SysUserInRole_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SysUserInRole_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SysUserInRole_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysUserInRole_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysUserInRole_BaseEventsProcess

	/// <exclude/>
	public partial class SysUserInRole_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysUserInRole_Base_Terrasoft
	{

		public SysUserInRole_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysUserInRole_BaseEventsProcess";
			SchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _actualizeOrganizationalStructureEventSubProcess;
		public ProcessFlowElement ActualizeOrganizationalStructureEventSubProcess {
			get {
				return _actualizeOrganizationalStructureEventSubProcess ?? (_actualizeOrganizationalStructureEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActualizeOrganizationalStructureEventSubProcess",
					SchemaElementUId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysUserInRoleSaved;
		public ProcessFlowElement SysUserInRoleSaved {
			get {
				return _sysUserInRoleSaved ?? (_sysUserInRoleSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysUserInRoleSaved",
					SchemaElementUId = new Guid("2da404f8-487d-47d3-9384-1293939346e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _actualizeOrganizationalStructureScriptTask;
		public ProcessScriptTask ActualizeOrganizationalStructureScriptTask {
			get {
				return _actualizeOrganizationalStructureScriptTask ?? (_actualizeOrganizationalStructureScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizeOrganizationalStructureScriptTask",
					SchemaElementUId = new Guid("109da2aa-f93c-492f-91c7-7f6290e75c90"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActualizeOrganizationalStructureScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sysUserInRoleDeleted;
		public ProcessFlowElement SysUserInRoleDeleted {
			get {
				return _sysUserInRoleDeleted ?? (_sysUserInRoleDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysUserInRoleDeleted",
					SchemaElementUId = new Guid("a539b7bb-f7d1-41b5-9b3c-7fddac1181db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysUserInRoleSavedLogScriptTask;
		public ProcessScriptTask SysUserInRoleSavedLogScriptTask {
			get {
				return _sysUserInRoleSavedLogScriptTask ?? (_sysUserInRoleSavedLogScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysUserInRoleSavedLogScriptTask",
					SchemaElementUId = new Guid("c5b2ebc6-8c3d-4af9-be56-0351fe3f6b79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysUserInRoleSavedLogScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _sysUserInRoleDeletedLogScriptTask;
		public ProcessScriptTask SysUserInRoleDeletedLogScriptTask {
			get {
				return _sysUserInRoleDeletedLogScriptTask ?? (_sysUserInRoleDeletedLogScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysUserInRoleDeletedLogScriptTask",
					SchemaElementUId = new Guid("9f805372-23cc-4587-be38-ca5b48718dfe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysUserInRoleDeletedLogScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _resetPersonalUserSessionTimeouts;
		public ProcessScriptTask ResetPersonalUserSessionTimeouts {
			get {
				return _resetPersonalUserSessionTimeouts ?? (_resetPersonalUserSessionTimeouts = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ResetPersonalUserSessionTimeouts",
					SchemaElementUId = new Guid("69dc0d70-f066-47fd-a84a-df8e2d30d11f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ResetPersonalUserSessionTimeoutsExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ActualizeOrganizationalStructureEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizeOrganizationalStructureEventSubProcess };
			FlowElements[SysUserInRoleSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { SysUserInRoleSaved };
			FlowElements[ActualizeOrganizationalStructureScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizeOrganizationalStructureScriptTask };
			FlowElements[SysUserInRoleDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { SysUserInRoleDeleted };
			FlowElements[SysUserInRoleSavedLogScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysUserInRoleSavedLogScriptTask };
			FlowElements[SysUserInRoleDeletedLogScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysUserInRoleDeletedLogScriptTask };
			FlowElements[ResetPersonalUserSessionTimeouts.SchemaElementUId] = new Collection<ProcessFlowElement> { ResetPersonalUserSessionTimeouts };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ActualizeOrganizationalStructureEventSubProcess":
						break;
					case "SysUserInRoleSaved":
						e.Context.QueueTasks.Enqueue("SysUserInRoleSavedLogScriptTask");
						break;
					case "ActualizeOrganizationalStructureScriptTask":
						break;
					case "SysUserInRoleDeleted":
						e.Context.QueueTasks.Enqueue("SysUserInRoleDeletedLogScriptTask");
						break;
					case "SysUserInRoleSavedLogScriptTask":
						e.Context.QueueTasks.Enqueue("ResetPersonalUserSessionTimeouts");
						break;
					case "SysUserInRoleDeletedLogScriptTask":
						e.Context.QueueTasks.Enqueue("ResetPersonalUserSessionTimeouts");
						break;
					case "ResetPersonalUserSessionTimeouts":
						e.Context.QueueTasks.Enqueue("ActualizeOrganizationalStructureScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysUserInRoleSaved");
			ActivatedEventElements.Add("SysUserInRoleDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ActualizeOrganizationalStructureEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SysUserInRoleSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysUserInRoleSaved";
					result = SysUserInRoleSaved.Execute(context);
					break;
				case "ActualizeOrganizationalStructureScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActualizeOrganizationalStructureScriptTask";
					result = ActualizeOrganizationalStructureScriptTask.Execute(context, ActualizeOrganizationalStructureScriptTaskExecute);
					break;
				case "SysUserInRoleDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysUserInRoleDeleted";
					result = SysUserInRoleDeleted.Execute(context);
					break;
				case "SysUserInRoleSavedLogScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysUserInRoleSavedLogScriptTask";
					result = SysUserInRoleSavedLogScriptTask.Execute(context, SysUserInRoleSavedLogScriptTaskExecute);
					break;
				case "SysUserInRoleDeletedLogScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysUserInRoleDeletedLogScriptTask";
					result = SysUserInRoleDeletedLogScriptTask.Execute(context, SysUserInRoleDeletedLogScriptTaskExecute);
					break;
				case "ResetPersonalUserSessionTimeouts":
					context.QueueTasks.Dequeue();
					context.SenderName = "ResetPersonalUserSessionTimeouts";
					result = ResetPersonalUserSessionTimeouts.Execute(context, ResetPersonalUserSessionTimeoutsExecute);
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

		public virtual bool ActualizeOrganizationalStructureScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool SysUserInRoleSavedLogScriptTaskExecute(ProcessExecutingContext context) {
			OperationLogger.Instance.LogUserRoleAdd(UserConnection, Entity.SysUserId, Entity.SysRoleId);
			return true;
		}

		public virtual bool SysUserInRoleDeletedLogScriptTaskExecute(ProcessExecutingContext context) {
			OperationLogger.Instance.LogUserRoleDelete(UserConnection, Entity.SysUserId, Entity.SysRoleId);
			return true;
		}

		public virtual bool ResetPersonalUserSessionTimeoutsExecute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-44388
			SessionHelper sessionHelper = new SessionHelper();
			sessionHelper.UpdatePersonalUserSessionTimeoutFromDB(UserConnection.AppConnection.SystemUserConnection, Entity.SysUserId);
			#endif
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysUserInRole_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("SysUserInRoleSaved")) {
							context.QueueTasks.Enqueue("SysUserInRoleSaved");
						}
						break;
					case "SysUserInRole_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("SysUserInRoleDeleted")) {
							context.QueueTasks.Enqueue("SysUserInRoleDeleted");
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

	#region Class: SysUserInRole_BaseEventsProcess

	/// <exclude/>
	public class SysUserInRole_BaseEventsProcess : SysUserInRole_BaseEventsProcess<SysUserInRole_Base_Terrasoft>
	{

		public SysUserInRole_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysUserInRole_BaseEventsProcess

	public partial class SysUserInRole_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysUserInRole_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SysUserInRole_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysUserInRole_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysUserInRole_Base_TerrasoftEventsProcessSchema(SysUserInRole_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysUserInRole_BaseEventsProcess";
			UId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128");
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
			ProcessSchemaLaneSet schemaActualizeOrganizationalStructureLaneSet = CreateActualizeOrganizationalStructureLaneSetLaneSet();
			LaneSets.Add(schemaActualizeOrganizationalStructureLaneSet);
			ProcessSchemaLane schemaActualizeOrganizationalStructureLane = CreateActualizeOrganizationalStructureLaneLane();
			schemaActualizeOrganizationalStructureLaneSet.Lanes.Add(schemaActualizeOrganizationalStructureLane);
			ProcessSchemaEventSubProcess actualizeorganizationalstructureeventsubprocess = CreateActualizeOrganizationalStructureEventSubProcessEventSubProcess();
			FlowElements.Add(actualizeorganizationalstructureeventsubprocess);
			ProcessSchemaStartMessageEvent sysuserinrolesaved = CreateSysUserInRoleSavedStartMessageEvent();
			actualizeorganizationalstructureeventsubprocess.FlowElements.Add(sysuserinrolesaved);
			ProcessSchemaScriptTask actualizeorganizationalstructurescripttask = CreateActualizeOrganizationalStructureScriptTaskScriptTask();
			actualizeorganizationalstructureeventsubprocess.FlowElements.Add(actualizeorganizationalstructurescripttask);
			ProcessSchemaStartMessageEvent sysuserinroledeleted = CreateSysUserInRoleDeletedStartMessageEvent();
			actualizeorganizationalstructureeventsubprocess.FlowElements.Add(sysuserinroledeleted);
			ProcessSchemaScriptTask sysuserinrolesavedlogscripttask = CreateSysUserInRoleSavedLogScriptTaskScriptTask();
			actualizeorganizationalstructureeventsubprocess.FlowElements.Add(sysuserinrolesavedlogscripttask);
			ProcessSchemaScriptTask sysuserinroledeletedlogscripttask = CreateSysUserInRoleDeletedLogScriptTaskScriptTask();
			actualizeorganizationalstructureeventsubprocess.FlowElements.Add(sysuserinroledeletedlogscripttask);
			ProcessSchemaScriptTask resetpersonalusersessiontimeouts = CreateResetPersonalUserSessionTimeoutsScriptTask();
			actualizeorganizationalstructureeventsubprocess.FlowElements.Add(resetpersonalusersessiontimeouts);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5_6dbaa5bc23c44bbeb24f387969ec48a9SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6b8fc690-8ba9-4188-9ce4-b44631ec69b4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CurveCenterPosition = new Point(194, 70),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2da404f8-487d-47d3-9384-1293939346e0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c5b2ebc6-8c3d-4af9-be56-0351fe3f6b79"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0ffc4ba9-206a-4df9-9450-73b8e1f29fd3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CurveCenterPosition = new Point(198, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a539b7bb-f7d1-41b5-9b3c-7fddac1181db"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9f805372-23cc-4587-be38-ca5b48718dfe"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("37489a5d-35b9-4f52-bda5-c174ccb4c9e5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CurveCenterPosition = new Point(542, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c5b2ebc6-8c3d-4af9-be56-0351fe3f6b79"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69dc0d70-f066-47fd-a84a-df8e2d30d11f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(324, 77));
			schemaFlow.PolylinePointPositions.Add(new Point(324, 75));
			schemaFlow.PolylinePointPositions.Add(new Point(405, 75));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("836654e4-8d43-44c7-99a6-ffd1219e9130"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CurveCenterPosition = new Point(546, 145),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9f805372-23cc-4587-be38-ca5b48718dfe"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69dc0d70-f066-47fd-a84a-df8e2d30d11f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(405, 182));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5_6dbaa5bc23c44bbeb24f387969ec48a9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5_6dbaa5bc23c44bbeb24f387969ec48a9",
				UId = new Guid("6dbaa5bc-23c4-4bbe-b24f-387969ec48a9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69dc0d70-f066-47fd-a84a-df8e2d30d11f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("109da2aa-f93c-492f-91c7-7f6290e75c90"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateActualizeOrganizationalStructureLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaActualizeOrganizationalStructureLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("041673fb-28df-43c5-9363-ff45c382f7ec"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"ActualizeOrganizationalStructureLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1566, 256),
				UseBackgroundMode = false
			};
			return schemaActualizeOrganizationalStructureLaneSet;
		}

		protected virtual ProcessSchemaLane CreateActualizeOrganizationalStructureLaneLane() {
			ProcessSchemaLane schemaActualizeOrganizationalStructureLane = new ProcessSchemaLane(this) {
				UId = new Guid("58ef0d42-606d-40fe-9c1b-bfc3d51b0557"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("041673fb-28df-43c5-9363-ff45c382f7ec"),
				CreatedInOwnerSchemaUId = new Guid("4b27f502-c296-47cf-af5d-3197d54e0d2a"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"ActualizeOrganizationalStructureLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1537, 256),
				UseBackgroundMode = false
			};
			return schemaActualizeOrganizationalStructureLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActualizeOrganizationalStructureEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActualizeOrganizationalStructureEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("58ef0d42-606d-40fe-9c1b-bfc3d51b0557"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"ActualizeOrganizationalStructureEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(615, 235),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActualizeOrganizationalStructureEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysUserInRoleSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2da404f8-487d-47d3-9384-1293939346e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysUserInRoleSaved",
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"SysUserInRoleSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActualizeOrganizationalStructureScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("109da2aa-f93c-492f-91c7-7f6290e75c90"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"ActualizeOrganizationalStructureScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(496, 85),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysUserInRoleDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a539b7bb-f7d1-41b5-9b3c-7fddac1181db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysUserInRoleDeleted",
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"SysUserInRoleDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 149),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysUserInRoleSavedLogScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c5b2ebc6-8c3d-4af9-be56-0351fe3f6b79"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"SysUserInRoleSavedLogScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(190, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,45,74,44,201,204,207,243,201,79,79,79,45,210,243,204,43,46,73,204,75,78,213,3,242,67,139,83,139,130,242,115,82,29,83,82,52,64,108,231,252,188,188,212,100,144,98,29,5,215,188,146,204,146,74,189,224,202,98,144,140,103,10,178,8,72,143,103,138,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,156,75,156,19,106,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSysUserInRoleDeletedLogScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9f805372-23cc-4587-be38-ca5b48718dfe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"SysUserInRoleDeletedLogScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(190, 135),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,47,72,45,74,44,201,204,207,243,201,79,79,79,45,210,243,204,43,46,73,204,75,78,213,3,242,67,139,83,139,130,242,115,82,93,82,115,82,75,82,53,64,92,231,252,188,188,212,100,144,122,29,5,215,188,146,204,146,74,189,224,202,98,144,140,103,10,178,8,72,155,103,138,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,47,176,148,41,109,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateResetPersonalUserSessionTimeoutsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("69dc0d70-f066-47fd-a84a-df8e2d30d11f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3941c985-81aa-48f6-94ee-3e3d4c559598"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"),
				Name = @"ResetPersonalUserSessionTimeouts",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(336, 85),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,141,193,10,130,64,20,69,247,126,197,11,55,6,165,81,46,4,105,97,142,81,139,52,116,92,135,228,19,6,244,205,48,51,18,254,125,10,45,114,121,56,231,114,93,209,193,38,207,120,197,147,156,37,37,59,190,14,16,4,192,11,86,64,90,62,246,97,120,138,34,167,66,99,132,164,27,246,10,53,152,21,157,129,240,3,171,194,219,198,206,42,242,107,213,54,22,159,168,141,164,166,175,13,234,223,128,139,1,229,104,175,90,14,236,226,45,34,149,68,248,182,179,243,19,165,254,168,154,140,197,97,157,236,32,35,43,236,180,200,197,220,219,249,218,69,106,69,231,104,180,163,38,176,122,196,248,11,203,130,152,223,231,0,0,0 }
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
				UId = new Guid("3262df1a-d5ad-4755-9a75-12b9b495ea65"),
				Name = "Terrasoft.Core.OperationLog",
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c32b5e04-55b6-40f6-ac41-b09c4c56be27"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysUserInRole_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e3a4d21-dd5e-4807-9ca3-42acf3c42128"));
		}

		#endregion

	}

	#endregion

}

