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

	#region Class: MailboxSyncSettings_Exchange_TerrasoftSchema

	/// <exclude/>
	public class MailboxSyncSettings_Exchange_TerrasoftSchema : Terrasoft.Configuration.MailboxSyncSettings_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public MailboxSyncSettings_Exchange_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailboxSyncSettings_Exchange_TerrasoftSchema(MailboxSyncSettings_Exchange_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailboxSyncSettings_Exchange_TerrasoftSchema(MailboxSyncSettings_Exchange_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1");
			Name = "MailboxSyncSettings_Exchange_Terrasoft";
			ParentSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315");
			ExtendParent = true;
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6c99d648-2324-4384-8330-b32cf258cb37")) == null) {
				Columns.Add(CreateMailSyncPeriodColumn());
			}
			if (Columns.FindByUId(new Guid("befec718-bb2e-4b77-95b3-f421c0a72196")) == null) {
				Columns.Add(CreateExchangeAutoSynchronizationColumn());
			}
			if (Columns.FindByUId(new Guid("d55aa1b5-9c33-4635-9aef-0e1d5a80f96e")) == null) {
				Columns.Add(CreateExchangeSyncIntervalColumn());
			}
			if (Columns.FindByUId(new Guid("a08de309-02eb-45f1-84a0-d627fcfe054f")) == null) {
				Columns.Add(CreateContactSyncIntervalColumn());
			}
			if (Columns.FindByUId(new Guid("e4fe0282-0d7d-4eaf-8dd2-69edeab162d7")) == null) {
				Columns.Add(CreateExchangeAutoSyncActivityColumn());
			}
			if (Columns.FindByUId(new Guid("6ddcc001-933c-4c78-8e0d-c9804c067489")) == null) {
				Columns.Add(CreateSyncDateMinutesOffsetColumn());
			}
		}

		protected override EntitySchemaColumn CreateEmailsCyclicallyAddingIntervalColumn() {
			EntitySchemaColumn column = base.CreateEmailsCyclicallyAddingIntervalColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"MailboxSyncInterval"
			};
			column.ModifiedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected virtual EntitySchemaColumn CreateMailSyncPeriodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6c99d648-2324-4384-8330-b32cf258cb37"),
				Name = @"MailSyncPeriod",
				ReferenceSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				ModifiedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"2d480351-94b7-4cad-b02f-885730c7eb3e"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateExchangeAutoSynchronizationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("befec718-bb2e-4b77-95b3-f421c0a72196"),
				Name = @"ExchangeAutoSynchronization",
				CreatedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				ModifiedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreateExchangeSyncIntervalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d55aa1b5-9c33-4635-9aef-0e1d5a80f96e"),
				Name = @"ExchangeSyncInterval",
				CreatedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				ModifiedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"MailboxSyncInterval"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateContactSyncIntervalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("a08de309-02eb-45f1-84a0-d627fcfe054f"),
				Name = @"ContactSyncInterval",
				CreatedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				ModifiedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				CreatedInPackageId = new Guid("649234ea-022f-4546-b594-8b15be33559c"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"MailboxSyncInterval"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateExchangeAutoSyncActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e4fe0282-0d7d-4eaf-8dd2-69edeab162d7"),
				Name = @"ExchangeAutoSyncActivity",
				CreatedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				ModifiedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				CreatedInPackageId = new Guid("649234ea-022f-4546-b594-8b15be33559c")
			};
		}

		protected virtual EntitySchemaColumn CreateSyncDateMinutesOffsetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("6ddcc001-933c-4c78-8e0d-c9804c067489"),
				Name = @"SyncDateMinutesOffset",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				ModifiedInSchemaUId = new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"),
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"5"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema() {
			var schema = new MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MailboxSyncSettings_Exchange_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MailboxSyncSettings_ExchangeEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MailboxSyncSettings_Exchange_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailboxSyncSettings_Exchange_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1"));
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_Exchange_Terrasoft

	/// <summary>
	/// Mailbox synchronization settings.
	/// </summary>
	public class MailboxSyncSettings_Exchange_Terrasoft : Terrasoft.Configuration.MailboxSyncSettings_Base_Terrasoft
	{

		#region Constructors: Public

		public MailboxSyncSettings_Exchange_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailboxSyncSettings_Exchange_Terrasoft";
		}

		public MailboxSyncSettings_Exchange_Terrasoft(MailboxSyncSettings_Exchange_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid MailSyncPeriodId {
			get {
				return GetTypedColumnValue<Guid>("MailSyncPeriodId");
			}
			set {
				SetColumnValue("MailSyncPeriodId", value);
				_mailSyncPeriod = null;
			}
		}

		/// <exclude/>
		public string MailSyncPeriodName {
			get {
				return GetTypedColumnValue<string>("MailSyncPeriodName");
			}
			set {
				SetColumnValue("MailSyncPeriodName", value);
				if (_mailSyncPeriod != null) {
					_mailSyncPeriod.Name = value;
				}
			}
		}

		private MailSyncPeriod _mailSyncPeriod;
		/// <summary>
		/// Sync existing emails for the following period.
		/// </summary>
		public MailSyncPeriod MailSyncPeriod {
			get {
				return _mailSyncPeriod ??
					(_mailSyncPeriod = LookupColumnEntities.GetEntity("MailSyncPeriod") as MailSyncPeriod);
			}
		}

		/// <summary>
		/// Synchronize contacts and activities cyclically.
		/// </summary>
		public bool ExchangeAutoSynchronization {
			get {
				return GetTypedColumnValue<bool>("ExchangeAutoSynchronization");
			}
			set {
				SetColumnValue("ExchangeAutoSynchronization", value);
			}
		}

		/// <summary>
		/// Contact and activity synchronization interval.
		/// </summary>
		public int ExchangeSyncInterval {
			get {
				return GetTypedColumnValue<int>("ExchangeSyncInterval");
			}
			set {
				SetColumnValue("ExchangeSyncInterval", value);
			}
		}

		/// <summary>
		/// ContactSyncInterval.
		/// </summary>
		public int ContactSyncInterval {
			get {
				return GetTypedColumnValue<int>("ContactSyncInterval");
			}
			set {
				SetColumnValue("ContactSyncInterval", value);
			}
		}

		/// <summary>
		/// ExchangeAutoSyncActivity.
		/// </summary>
		public bool ExchangeAutoSyncActivity {
			get {
				return GetTypedColumnValue<bool>("ExchangeAutoSyncActivity");
			}
			set {
				SetColumnValue("ExchangeAutoSyncActivity", value);
			}
		}

		/// <summary>
		/// SyncDateMinutesOffset.
		/// </summary>
		public int SyncDateMinutesOffset {
			get {
				return GetTypedColumnValue<int>("SyncDateMinutesOffset");
			}
			set {
				SetColumnValue("SyncDateMinutesOffset", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailboxSyncSettings_ExchangeEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MailboxSyncSettings_Exchange_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("MailboxSyncSettings_Exchange_TerrasoftDeleting", e);
			Updated += (s, e) => ThrowEvent("MailboxSyncSettings_Exchange_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("MailboxSyncSettings_Exchange_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailboxSyncSettings_Exchange_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_ExchangeEventsProcess

	/// <exclude/>
	public partial class MailboxSyncSettings_ExchangeEventsProcess<TEntity> : Terrasoft.Configuration.MailboxSyncSettings_BaseEventsProcess<TEntity> where TEntity : MailboxSyncSettings_Exchange_Terrasoft
	{

		public MailboxSyncSettings_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailboxSyncSettings_ExchangeEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e9ad8f21-9530-445e-ace0-84df96cff0c1");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("ff8c33ff-ed7d-4228-8d38-2d1494dc5dcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailboxSyncSettingsJobDeletingScriptTask;
		public ProcessScriptTask MailboxSyncSettingsJobDeletingScriptTask {
			get {
				return _mailboxSyncSettingsJobDeletingScriptTask ?? (_mailboxSyncSettingsJobDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxSyncSettingsJobDeletingScriptTask",
					SchemaElementUId = new Guid("f9a2767a-4bd9-495d-a9fc-169e31f37fb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxSyncSettingsJobDeletingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _mailboxSyncSettingsJobDeleting;
		public ProcessFlowElement MailboxSyncSettingsJobDeleting {
			get {
				return _mailboxSyncSettingsJobDeleting ?? (_mailboxSyncSettingsJobDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailboxSyncSettingsJobDeleting",
					SchemaElementUId = new Guid("9aa79d84-d06a-4622-8847-f8b2420d608f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage1;
		public ProcessThrowMessageEvent IntermediateThrowMessage1 {
			get {
				return _intermediateThrowMessage1 ?? (_intermediateThrowMessage1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage1",
					SchemaElementUId = new Guid("0c4e16ac-a45a-4d8e-aaba-d7e769975b56"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "MailboxSyncSettingsDeleting",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7_d80813d0de31491494a0aa9d76130357;
		public ProcessFlowElement EventSubProcess7_d80813d0de31491494a0aa9d76130357 {
			get {
				return _eventSubProcess7_d80813d0de31491494a0aa9d76130357 ?? (_eventSubProcess7_d80813d0de31491494a0aa9d76130357 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7_d80813d0de31491494a0aa9d76130357",
					SchemaElementUId = new Guid("d80813d0-de31-4914-94a0-aa9d76130357"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_131a01cf1b0c4e718160ce94f6211232;
		public ProcessFlowElement StartMessage3_131a01cf1b0c4e718160ce94f6211232 {
			get {
				return _startMessage3_131a01cf1b0c4e718160ce94f6211232 ?? (_startMessage3_131a01cf1b0c4e718160ce94f6211232 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_131a01cf1b0c4e718160ce94f6211232",
					SchemaElementUId = new Guid("131a01cf-1b0c-4e71-8160-ce94f6211232"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_5f2ee4deb773482cbfd5753884a96b7c;
		public ProcessScriptTask ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c {
			get {
				return _scriptTask3_5f2ee4deb773482cbfd5753884a96b7c ?? (_scriptTask3_5f2ee4deb773482cbfd5753884a96b7c = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c",
					SchemaElementUId = new Guid("5f2ee4de-b773-482c-bfd5-753884a96b7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_5f2ee4deb773482cbfd5753884a96b7cExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[MailboxSyncSettingsJobDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsJobDeletingScriptTask };
			FlowElements[MailboxSyncSettingsJobDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxSyncSettingsJobDeleting };
			FlowElements[IntermediateThrowMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1 };
			FlowElements[EventSubProcess7_d80813d0de31491494a0aa9d76130357.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7_d80813d0de31491494a0aa9d76130357 };
			FlowElements[StartMessage3_131a01cf1b0c4e718160ce94f6211232.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_131a01cf1b0c4e718160ce94f6211232 };
			FlowElements[ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess6":
						break;
					case "MailboxSyncSettingsJobDeletingScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage1");
						break;
					case "MailboxSyncSettingsJobDeleting":
						e.Context.QueueTasks.Enqueue("MailboxSyncSettingsJobDeletingScriptTask");
						break;
					case "IntermediateThrowMessage1":
						break;
					case "EventSubProcess7_d80813d0de31491494a0aa9d76130357":
						break;
					case "StartMessage3_131a01cf1b0c4e718160ce94f6211232":
						e.Context.QueueTasks.Enqueue("ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c");
						break;
					case "ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MailboxSyncSettingsJobDeleting");
			ActivatedEventElements.Add("StartMessage3_131a01cf1b0c4e718160ce94f6211232");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "MailboxSyncSettingsJobDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsJobDeletingScriptTask";
					result = MailboxSyncSettingsJobDeletingScriptTask.Execute(context, MailboxSyncSettingsJobDeletingScriptTaskExecute);
					break;
				case "MailboxSyncSettingsJobDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxSyncSettingsJobDeleting";
					result = MailboxSyncSettingsJobDeleting.Execute(context);
					break;
				case "IntermediateThrowMessage1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "MailboxSyncSettingsDeleting");
					result = IntermediateThrowMessage1.Execute(context);
					break;
				case "EventSubProcess7_d80813d0de31491494a0aa9d76130357":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_131a01cf1b0c4e718160ce94f6211232":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_131a01cf1b0c4e718160ce94f6211232";
					result = StartMessage3_131a01cf1b0c4e718160ce94f6211232.Execute(context);
					break;
				case "ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c";
					result = ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c.Execute(context, ScriptTask3_5f2ee4deb773482cbfd5753884a96b7cExecute);
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

		public virtual bool MailboxSyncSettingsJobDeletingScriptTaskExecute(ProcessExecutingContext context) {
			var serverId = Entity.MailServerId;
			var mailBoxSettingsEntity = UserConnection.EntitySchemaManager.GetInstanceByName("MailServer").
				CreateEntity(UserConnection);
			Guid serverTypeId = Guid.Empty;
			if(mailBoxSettingsEntity.FetchFromDB(serverId)) {
				serverTypeId = mailBoxSettingsEntity.GetTypedColumnValue<Guid>("TypeId");
			}
			#if !NETSTANDARD2_0 //TODO CRM-46901
			ExchangeUtility.RemoveAllSyncJob(UserConnection, Entity.MailboxName, serverTypeId);
			#endif
			return true;
		}

		public virtual bool ScriptTask3_5f2ee4deb773482cbfd5753884a96b7cExecute(ProcessExecutingContext context) {
			SendSyncStatus(Entity);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "MailboxSyncSettings_Exchange_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("MailboxSyncSettingsJobDeleting")) {
							context.QueueTasks.Enqueue("MailboxSyncSettingsJobDeleting");
							ProcessQueue(context);
							return;
						}
						break;
					case "MailboxSyncSettings_Exchange_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("StartMessage3_131a01cf1b0c4e718160ce94f6211232")) {
							context.QueueTasks.Enqueue("StartMessage3_131a01cf1b0c4e718160ce94f6211232");
							ProcessQueue(context);
							return;
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

	#region Class: MailboxSyncSettings_ExchangeEventsProcess

	/// <exclude/>
	public class MailboxSyncSettings_ExchangeEventsProcess : MailboxSyncSettings_ExchangeEventsProcess<MailboxSyncSettings_Exchange_Terrasoft>
	{

		public MailboxSyncSettings_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailboxSyncSettings_ExchangeEventsProcess

	public partial class MailboxSyncSettings_ExchangeEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void SendSyncStatus(Entity mailbox) {
			var userConnection = new ConstructorArgument("userConnection", UserConnection);
			SynchronizationErrorHelper helper = ClassFactory.Get<SynchronizationErrorHelper>(userConnection);
			helper.SendSynchronizationStatus(mailbox);
		}

		#endregion

	}

	#endregion

	#region Class: MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema : Terrasoft.Configuration.MailboxSyncSettings_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema(MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailboxSyncSettings_ExchangeEventsProcess";
			UId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet2.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocess7_d80813d0de31491494a0aa9d76130357 = CreateEventSubProcess7_d80813d0de31491494a0aa9d76130357EventSubProcess();
			FlowElements.Add(eventsubprocess7_d80813d0de31491494a0aa9d76130357);
			ProcessSchemaScriptTask mailboxsyncsettingsjobdeletingscripttask = CreateMailboxSyncSettingsJobDeletingScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(mailboxsyncsettingsjobdeletingscripttask);
			ProcessSchemaStartMessageEvent mailboxsyncsettingsjobdeleting = CreateMailboxSyncSettingsJobDeletingStartMessageEvent();
			eventsubprocess6.FlowElements.Add(mailboxsyncsettingsjobdeleting);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessage1 = CreateIntermediateThrowMessage1IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(intermediatethrowmessage1);
			ProcessSchemaStartMessageEvent startmessage3_131a01cf1b0c4e718160ce94f6211232 = CreateStartMessage3_131a01cf1b0c4e718160ce94f6211232StartMessageEvent();
			eventsubprocess7_d80813d0de31491494a0aa9d76130357.FlowElements.Add(startmessage3_131a01cf1b0c4e718160ce94f6211232);
			ProcessSchemaScriptTask scripttask3_5f2ee4deb773482cbfd5753884a96b7c = CreateScriptTask3_5f2ee4deb773482cbfd5753884a96b7cScriptTask();
			eventsubprocess7_d80813d0de31491494a0aa9d76130357.FlowElements.Add(scripttask3_5f2ee4deb773482cbfd5753884a96b7c);
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8_b6cab8d0e20c4a0c9c573d659f53ca1dSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("e37e6027-68bd-46b6-b4b2-c8dd8c10682b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9aa79d84-d06a-4622-8847-f8b2420d608f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f9a2767a-4bd9-495d-a9fc-169e31f37fb4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("59102005-752f-4b28-aa39-31a0ff93b4f0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f9a2767a-4bd9-495d-a9fc-169e31f37fb4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c4e16ac-a45a-4d8e-aaba-d7e769975b56"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8_b6cab8d0e20c4a0c9c573d659f53ca1dSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8_b6cab8d0e20c4a0c9c573d659f53ca1d",
				UId = new Guid("b6cab8d0-e20c-4a0c-9c57-3d659f53ca1d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("131a01cf-1b0c-4e71-8160-ce94f6211232"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5f2ee4de-b773-482c-bfd5-753884a96b7c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("713316c0-842d-40de-b6b3-74934f80ca77"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"LaneSet2",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("f7dae427-3f65-49db-a944-7c69d4226e5d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("713316c0-842d-40de-b6b3-74934f80ca77"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"Lane2",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ff8c33ff-ed7d-4228-8d38-2d1494dc5dcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7dae427-3f65-49db-a944-7c69d4226e5d"),
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(340, 244),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxSyncSettingsJobDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f9a2767a-4bd9-495d-a9fc-169e31f37fb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff8c33ff-ed7d-4228-8d38-2d1494dc5dcf"),
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"MailboxSyncSettingsJobDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(135, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,65,107,194,64,16,133,207,238,175,216,198,75,2,54,218,82,10,37,109,65,147,40,22,84,48,177,215,178,38,163,46,100,103,101,157,4,67,233,127,239,166,177,180,138,215,199,251,222,188,153,169,132,225,7,48,21,152,105,206,95,120,140,36,169,246,103,66,22,201,73,13,88,101,61,202,42,35,125,76,128,72,226,246,208,250,44,176,178,112,168,17,33,35,169,209,111,245,36,219,129,18,51,129,98,11,198,159,0,77,241,64,2,51,24,213,115,161,192,117,254,242,29,207,103,157,208,128,32,104,89,247,60,209,11,216,164,148,249,169,99,90,239,225,167,103,163,249,177,218,83,29,48,185,113,175,182,243,199,64,217,110,108,180,138,70,238,239,142,158,199,63,89,231,34,237,58,110,123,55,142,60,212,69,169,240,93,20,37,60,55,115,95,93,167,37,29,91,238,139,117,229,134,223,204,227,52,73,135,243,104,184,140,238,63,6,188,223,79,23,209,130,135,203,217,237,195,227,211,224,142,197,199,108,39,112,11,43,146,69,147,189,4,165,43,24,22,69,82,99,246,166,215,23,91,247,254,63,98,173,143,205,213,122,103,55,176,163,187,128,185,220,48,3,84,26,228,100,74,8,190,1,169,173,173,99,206,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailboxSyncSettingsJobDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9aa79d84-d06a-4622-8847-f8b2420d608f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff8c33ff-ed7d-4228-8d38-2d1494dc5dcf"),
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxSyncSettingsDeleting",
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"MailboxSyncSettingsJobDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 100),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessage1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0c4e16ac-a45a-4d8e-aaba-d7e769975b56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff8c33ff-ed7d-4228-8d38-2d1494dc5dcf"),
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("0a8025af-4bad-4c0f-be72-4e801d4fc8d4"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"MailboxSyncSettingsDeleting",
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"IntermediateThrowMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(253, 100),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess7_d80813d0de31491494a0aa9d76130357EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess7_d80813d0de31491494a0aa9d76130357 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d80813d0-de31-4914-94a0-aa9d76130357"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f7dae427-3f65-49db-a944-7c69d4226e5d"),
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"EventSubProcess7_d80813d0de31491494a0aa9d76130357",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 300),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(340, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess7_d80813d0de31491494a0aa9d76130357;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_131a01cf1b0c4e718160ce94f6211232StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("131a01cf-1b0c-4e71-8160-ce94f6211232"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d80813d0-de31-4914-94a0-aa9d76130357"),
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxSyncSettingsUpdated",
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"StartMessage3_131a01cf1b0c4e718160ce94f6211232",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 124),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_5f2ee4deb773482cbfd5753884a96b7cScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5f2ee4de-b773-482c-bfd5-753884a96b7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d80813d0-de31-4914-94a0-aa9d76130357"),
				CreatedInOwnerSchemaUId = new Guid("4cc9cc22-8b7a-4daf-a467-456bd39dcc8a"),
				CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6"),
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Name = @"ScriptTask3_5f2ee4deb773482cbfd5753884a96b7c",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(135, 110),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,205,75,9,174,204,75,14,46,73,44,41,45,214,112,205,43,201,44,169,212,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,204,130,196,11,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSendSyncStatusMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
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

		protected virtual SchemaMethod CreateSendSyncStatusMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f952c5b0-0d32-4d56-9060-7282274bd1f8"),
				Name = "SendSyncStatus",
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("138f14f0-9c20-4e0a-87df-0d6d5edc9601"),
				Name = "mailbox",
				CreatedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				ModifiedInSchemaUId = new Guid("70543829-3f01-44a2-98df-f3f44cca8641"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,141,77,10,194,48,16,133,247,158,98,232,42,5,233,5,106,5,41,254,236,131,7,24,227,96,3,233,164,76,38,106,61,189,150,174,90,112,245,224,227,125,239,61,81,32,39,146,54,50,147,83,31,25,26,96,122,193,15,36,149,236,52,202,65,30,185,39,86,83,44,155,197,22,174,11,80,214,27,59,178,235,36,178,255,224,68,142,34,81,46,20,6,18,232,230,104,160,13,152,210,9,167,233,177,58,147,238,254,75,123,147,215,15,243,76,101,137,239,43,207,42,106,78,166,71,31,110,241,93,214,95,253,47,24,127,220,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailboxSyncSettings_Exchange_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70543829-3f01-44a2-98df-f3f44cca8641"));
		}

		#endregion

	}

	#endregion

}

