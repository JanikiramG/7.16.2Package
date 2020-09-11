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

	#region Class: SysUserSession_Base_TerrasoftSchema

	/// <exclude/>
	public class SysUserSession_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysUserSession_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysUserSession_Base_TerrasoftSchema(SysUserSession_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysUserSession_Base_TerrasoftSchema(SysUserSession_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateISysUserSessEndDateIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("97fc6e87-0eac-4738-a3a0-cded3ee2affe");
			index.Name = "ISysUserSessEndDateId";
			index.CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			index.ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			index.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			EntitySchemaIndexColumn sessionEndDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("99d28ef5-8120-4605-a15c-a47bf3268905"),
				ColumnUId = new Guid("86a0a1f4-7d2d-45da-b313-8f96c983215c"),
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sessionEndDateIndexColumn);
			EntitySchemaIndexColumn sessionIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("97d387d1-2969-4331-8bd8-cc9cac20c9c7"),
				ColumnUId = new Guid("f443b1a3-3c1c-4a25-8add-b3255ea19099"),
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sessionIdIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateISysUserSessionUserIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e1f2730f-03f5-4526-acf1-cd929fdbb3a0");
			index.Name = "ISysUserSessionUserId";
			index.CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			index.ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			index.CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf");
			EntitySchemaIndexColumn sysUserIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("cdda2024-8137-4a11-ad6f-11d702d8a8f6"),
				ColumnUId = new Guid("61b6df7e-99db-458f-980d-68308d2dd08c"),
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysUserIdIndexColumn);
			EntitySchemaIndexColumn sessionEndDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("ffcfaa0a-d163-4978-bf5d-73a7e781472a"),
				ColumnUId = new Guid("86a0a1f4-7d2d-45da-b313-8f96c983215c"),
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("6ff020f5-e34d-4da9-8c0d-3678e6f20dbf"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sessionEndDateIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			RealUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			Name = "SysUserSession_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("61b6df7e-99db-458f-980d-68308d2dd08c")) == null) {
				Columns.Add(CreateSysUserColumn());
			}
			if (Columns.FindByUId(new Guid("f443b1a3-3c1c-4a25-8add-b3255ea19099")) == null) {
				Columns.Add(CreateSessionIdColumn());
			}
			if (Columns.FindByUId(new Guid("a3557536-73b8-4621-8374-8f2c77fc1abd")) == null) {
				Columns.Add(CreateSessionStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("86a0a1f4-7d2d-45da-b313-8f96c983215c")) == null) {
				Columns.Add(CreateSessionEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("6ee436a9-5490-4cf4-a2e0-d79f6cdb901c")) == null) {
				Columns.Add(CreateSessionEndMethodColumn());
			}
			if (Columns.FindByUId(new Guid("ac2b69b9-8448-4b1d-b095-d2410c2b7321")) == null) {
				Columns.Add(CreateClientIPColumn());
			}
			if (Columns.FindByUId(new Guid("ac479e55-e8d2-408e-9284-0354087f213a")) == null) {
				Columns.Add(CreateAgentColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.IsIndexed = false;
			column.ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.IsIndexed = false;
			column.ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSysUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("61b6df7e-99db-458f-980d-68308d2dd08c"),
				Name = @"SysUser",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f443b1a3-3c1c-4a25-8add-b3255ea19099"),
				Name = @"SessionId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("a3557536-73b8-4621-8374-8f2c77fc1abd"),
				Name = @"SessionStartDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("86a0a1f4-7d2d-45da-b313-8f96c983215c"),
				Name = @"SessionEndDate",
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionEndMethodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("6ee436a9-5490-4cf4-a2e0-d79f6cdb901c"),
				Name = @"SessionEndMethod",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateClientIPColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("ac2b69b9-8448-4b1d-b095-d2410c2b7321"),
				Name = @"ClientIP",
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			};
		}

		protected virtual EntitySchemaColumn CreateAgentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("ac479e55-e8d2-408e-9284-0354087f213a"),
				Name = @"Agent",
				CreatedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				ModifiedInSchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"),
				CreatedInPackageId = new Guid("969515bc-541b-44a4-a988-eb0725df0b81")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateISysUserSessEndDateIdIndex());
			Indexes.Add(CreateISysUserSessionUserIdIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysUserSession_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysUserSession_Base_TerrasoftEventsProcessSchema() {
			var schema = new SysUserSession_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysUserSession_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysUserSession_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysUserSession_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysUserSession_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339"));
		}

		#endregion

	}

	#endregion

	#region Class: SysUserSession_Base_Terrasoft

	/// <summary>
	/// User session.
	/// </summary>
	public class SysUserSession_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysUserSession_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysUserSession_Base_Terrasoft";
		}

		public SysUserSession_Base_Terrasoft(SysUserSession_Base_Terrasoft source)
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

		/// <summary>
		/// Session Id.
		/// </summary>
		public string SessionId {
			get {
				return GetTypedColumnValue<string>("SessionId");
			}
			set {
				SetColumnValue("SessionId", value);
			}
		}

		/// <summary>
		/// Session start.
		/// </summary>
		public DateTime SessionStartDate {
			get {
				return GetTypedColumnValue<DateTime>("SessionStartDate");
			}
			set {
				SetColumnValue("SessionStartDate", value);
			}
		}

		/// <summary>
		/// Session end.
		/// </summary>
		public DateTime SessionEndDate {
			get {
				return GetTypedColumnValue<DateTime>("SessionEndDate");
			}
			set {
				SetColumnValue("SessionEndDate", value);
			}
		}

		/// <summary>
		/// Session end method.
		/// </summary>
		public int SessionEndMethod {
			get {
				return GetTypedColumnValue<int>("SessionEndMethod");
			}
			set {
				SetColumnValue("SessionEndMethod", value);
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
		/// Agent.
		/// </summary>
		public string Agent {
			get {
				return GetTypedColumnValue<string>("Agent");
			}
			set {
				SetColumnValue("Agent", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysUserSession_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysUserSession_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysUserSession_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysUserSession_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("SysUserSession_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("SysUserSession_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SysUserSession_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SysUserSession_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysUserSession_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysUserSession_BaseEventsProcess

	/// <exclude/>
	public partial class SysUserSession_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysUserSession_Base_Terrasoft
	{

		public SysUserSession_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysUserSession_BaseEventsProcess";
			SchemaUId = new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("43e6cdb7-e6fd-4218-bd45-278a1ce03339");
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
					SchemaElementUId = new Guid("c611cfd7-fa63-4e89-a530-8eeb62793fdb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysUserSessionSaving;
		public ProcessFlowElement SysUserSessionSaving {
			get {
				return _sysUserSessionSaving ?? (_sysUserSessionSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysUserSessionSaving",
					SchemaElementUId = new Guid("22729f53-31f9-40e1-85b4-4ca8f0d76db5"),
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
					SchemaElementUId = new Guid("55a3ea37-b315-46a4-b54b-2c8bae253a67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("4f3c7825-e61a-4a88-8d75-bfd3b08e0988"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysUserSessionDeleting;
		public ProcessFlowElement SysUserSessionDeleting {
			get {
				return _sysUserSessionDeleting ?? (_sysUserSessionDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysUserSessionDeleting",
					SchemaElementUId = new Guid("7f3eda8c-1c74-4bc7-b3a2-650ee5d22e62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("4596cf35-cf27-415f-be23-9e3b8afb725d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[SysUserSessionSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { SysUserSessionSaving };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SysUserSessionDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { SysUserSessionDeleting };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "SysUserSessionSaving":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "EventSubProcess2":
						break;
					case "SysUserSessionDeleting":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysUserSessionSaving");
			ActivatedEventElements.Add("SysUserSessionDeleting");
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
				case "SysUserSessionSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysUserSessionSaving";
					result = SysUserSessionSaving.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SysUserSessionDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysUserSessionDeleting";
					result = SysUserSessionDeleting.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysUserSession_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SysUserSessionSaving")) {
							context.QueueTasks.Enqueue("SysUserSessionSaving");
						}
						break;
					case "SysUserSession_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("SysUserSessionDeleting")) {
							context.QueueTasks.Enqueue("SysUserSessionDeleting");
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

	#region Class: SysUserSession_BaseEventsProcess

	/// <exclude/>
	public class SysUserSession_BaseEventsProcess : SysUserSession_BaseEventsProcess<SysUserSession_Base_Terrasoft>
	{

		public SysUserSession_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysUserSession_BaseEventsProcess

	public partial class SysUserSession_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysUserSession_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class SysUserSession_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysUserSession_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysUserSession_Base_TerrasoftEventsProcessSchema(SysUserSession_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysUserSession_BaseEventsProcess";
			UId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent sysusersessionsaving = CreateSysUserSessionSavingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(sysusersessionsaving);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent sysusersessiondeleting = CreateSysUserSessionDeletingStartMessageEvent();
			eventsubprocess2.FlowElements.Add(sysusersessiondeleting);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess2.FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5cf44777-07f1-4a8f-80a2-00588e45d53e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22729f53-31f9-40e1-85b4-4ca8f0d76db5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55a3ea37-b315-46a4-b54b-2c8bae253a67"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(169, 121));
			schemaFlow.PolylinePointPositions.Add(new Point(169, 122));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("7735b36f-c304-4d38-8b5f-6897db464ced"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7f3eda8c-1c74-4bc7-b3a2-650ee5d22e62"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4596cf35-cf27-415f-be23-9e3b8afb725d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d09ba1ff-4c8e-49ec-9df4-dc3c99c4c3d2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("29592791-41d9-4256-bac1-6c84976e8aee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d09ba1ff-4c8e-49ec-9df4-dc3c99c4c3d2"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c611cfd7-fa63-4e89-a530-8eeb62793fdb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29592791-41d9-4256-bac1-6c84976e8aee"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(518, 197),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysUserSessionSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("22729f53-31f9-40e1-85b4-4ca8f0d76db5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c611cfd7-fa63-4e89-a530-8eeb62793fdb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysUserSessionSaving",
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"SysUserSessionSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 85),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("55a3ea37-b315-46a4-b54b-2c8bae253a67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c611cfd7-fa63-4e89-a530-8eeb62793fdb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(223, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,78,45,114,206,207,203,75,77,46,201,204,207,211,115,113,10,78,77,46,45,202,44,169,116,205,75,207,204,75,213,115,206,72,77,206,118,78,204,115,173,0,138,151,164,250,23,164,22,37,130,84,106,40,1,5,125,19,243,18,211,83,29,83,114,51,243,50,139,75,32,18,74,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,30,174,216,187,97,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4f3c7825-e61a-4a88-8d75-bfd3b08e0988"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("29592791-41d9-4256-bac1-6c84976e8aee"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 246),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(520, 194),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysUserSessionDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7f3eda8c-1c74-4bc7-b3a2-650ee5d22e62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f3c7825-e61a-4a88-8d75-bfd3b08e0988"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysUserSessionDeleting",
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"SysUserSessionDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(45, 95),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4596cf35-cf27-415f-be23-9e3b8afb725d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f3c7825-e61a-4a88-8d75-bfd3b08e0988"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8d614e33-8093-46bf-987f-21093279b4e0"),
				CreatedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(220, 81),
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
			return new SysUserSession_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c883ec2-f33a-4227-b12c-f36334c6b22c"));
		}

		#endregion

	}

	#endregion

}

