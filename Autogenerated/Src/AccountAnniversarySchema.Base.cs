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

	#region Class: AccountAnniversarySchema

	/// <exclude/>
	public class AccountAnniversarySchema : Terrasoft.Configuration.BaseAnniversarySchema
	{

		#region Constructors: Public

		public AccountAnniversarySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAnniversarySchema(AccountAnniversarySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAnniversarySchema(AccountAnniversarySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8");
			RealUId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8");
			Name = "AccountAnniversary";
			ParentSchemaUId = new Guid("c3d34c7a-3acf-4394-a9fe-50e48f92ca9f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a16dce5a-2cbe-4675-a7eb-5cfa6f36e958")) == null) {
				Columns.Add(CreateAccountColumn());
			}
		}

		protected override EntitySchemaColumn CreateDateColumn() {
			EntitySchemaColumn column = base.CreateDateColumn();
			column.ModifiedInSchemaUId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8");
			return column;
		}

		protected override EntitySchemaColumn CreateAnniversaryTypeColumn() {
			EntitySchemaColumn column = base.CreateAnniversaryTypeColumn();
			column.ModifiedInSchemaUId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8");
			return column;
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a16dce5a-2cbe-4675-a7eb-5cfa6f36e958"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8"),
				ModifiedInSchemaUId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountAnniversaryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAccountAnniversaryEventsProcessSchema() {
			var schema = new AccountAnniversaryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountAnniversary(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAnniversary_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAnniversarySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAnniversarySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2420b84-1c49-441b-b875-159f8089e3d8"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnniversary

	/// <summary>
	/// Noteworthy event of account.
	/// </summary>
	public class AccountAnniversary : Terrasoft.Configuration.BaseAnniversary
	{

		#region Constructors: Public

		public AccountAnniversary(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAnniversary";
		}

		public AccountAnniversary(AccountAnniversary source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAnniversary_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAnniversaryDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountAnniversaryDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountAnniversaryInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAnniversaryInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAnniversarySaved", e);
			Saving += (s, e) => ThrowEvent("AccountAnniversarySaving", e);
			Validating += (s, e) => ThrowEvent("AccountAnniversaryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAnniversary(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnniversary_BaseEventsProcess

	/// <exclude/>
	public partial class AccountAnniversary_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseAnniversary_BaseEventsProcess<TEntity> where TEntity : AccountAnniversary
	{

		public AccountAnniversary_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAnniversary_BaseEventsProcess";
			SchemaUId = new Guid("b2420b84-1c49-441b-b875-159f8089e3d8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b2420b84-1c49-441b-b875-159f8089e3d8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsDateChanged {
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
					SchemaElementUId = new Guid("be4de872-76c4-4b87-86b0-4b64ec0806da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountAnniversarySaved;
		public ProcessFlowElement AccountAnniversarySaved {
			get {
				return _accountAnniversarySaved ?? (_accountAnniversarySaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountAnniversarySaved",
					SchemaElementUId = new Guid("f8ee61e9-4b10-4058-a0bb-0a4c685354f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateRemindings;
		public ProcessScriptTask UpdateRemindings {
			get {
				return _updateRemindings ?? (_updateRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateRemindings",
					SchemaElementUId = new Guid("0941540b-9c03-40da-9392-31348aa8fa4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private ProcessFlowElement _accountAnniversaryDeleted;
		public ProcessFlowElement AccountAnniversaryDeleted {
			get {
				return _accountAnniversaryDeleted ?? (_accountAnniversaryDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountAnniversaryDeleted",
					SchemaElementUId = new Guid("a30caf29-bad5-49e4-b180-92799a2a577a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleted_InitDateChanged;
		public ProcessScriptTask Deleted_InitDateChanged {
			get {
				return _deleted_InitDateChanged ?? (_deleted_InitDateChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Deleted_InitDateChanged",
					SchemaElementUId = new Guid("46fb7038-ea21-4079-9436-29bc08c47ea1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Deleted_InitDateChangedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c;
		public ProcessFlowElement EventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c {
			get {
				return _eventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c ?? (_eventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c",
					SchemaElementUId = new Guid("d7e07ada-ec9f-4dfb-8d14-fd55bcf57b4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountAnniversarySaving_Base;
		public ProcessFlowElement AccountAnniversarySaving_Base {
			get {
				return _accountAnniversarySaving_Base ?? (_accountAnniversarySaving_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountAnniversarySaving_Base",
					SchemaElementUId = new Guid("c4c9869c-a113-4c3b-a706-6037458c9375"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _saving_InitDateChanged;
		public ProcessScriptTask Saving_InitDateChanged {
			get {
				return _saving_InitDateChanged ?? (_saving_InitDateChanged = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Saving_InitDateChanged",
					SchemaElementUId = new Guid("a740381b-b76d-41bc-a03f-ba1afe0082de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Saving_InitDateChangedExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[AccountAnniversarySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountAnniversarySaved };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[AccountAnniversaryDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountAnniversaryDeleted };
			FlowElements[Deleted_InitDateChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { Deleted_InitDateChanged };
			FlowElements[EventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c };
			FlowElements[AccountAnniversarySaving_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountAnniversarySaving_Base };
			FlowElements[Saving_InitDateChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { Saving_InitDateChanged };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "AccountAnniversarySaved":
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "UpdateRemindings":
						break;
					case "AccountAnniversaryDeleted":
						e.Context.QueueTasks.Enqueue("Deleted_InitDateChanged");
						break;
					case "Deleted_InitDateChanged":
						break;
					case "EventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c":
						break;
					case "AccountAnniversarySaving_Base":
						e.Context.QueueTasks.Enqueue("Saving_InitDateChanged");
						break;
					case "Saving_InitDateChanged":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AccountAnniversarySaved");
			ActivatedEventElements.Add("AccountAnniversaryDeleted");
			ActivatedEventElements.Add("AccountAnniversarySaving_Base");
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
				case "AccountAnniversarySaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountAnniversarySaved";
					result = AccountAnniversarySaved.Execute(context);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "AccountAnniversaryDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountAnniversaryDeleted";
					result = AccountAnniversaryDeleted.Execute(context);
					break;
				case "Deleted_InitDateChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "Deleted_InitDateChanged";
					result = Deleted_InitDateChanged.Execute(context, Deleted_InitDateChangedExecute);
					break;
				case "EventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c":
					context.QueueTasks.Dequeue();
					break;
				case "AccountAnniversarySaving_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountAnniversarySaving_Base";
					result = AccountAnniversarySaving_Base.Execute(context);
					break;
				case "Saving_InitDateChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "Saving_InitDateChanged";
					result = Saving_InitDateChanged.Execute(context, Saving_InitDateChangedExecute);
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
				case "IsDateChanged":
					IsDateChanged = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			UpdateRemindingsExecute();
			return true;
		}

		public virtual bool Deleted_InitDateChangedExecute(ProcessExecutingContext context) {
			Guid id = Entity.GetTypedColumnValue<Guid>("AccountId");
			Guid schemaUId = Entity.Account.Schema.UId;
			AccountAnniversaryReminding remindingsGenerator = new AccountAnniversaryReminding(UserConnection, id);
			remindingsGenerator.DeleteRecordRemindings(schemaUId);
			return true;
		}

		public virtual bool Saving_InitDateChangedExecute(ProcessExecutingContext context) {
			IsDateChanged = Entity.GetChangedColumnValues().Any(col => col.Name == "Date");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AccountAnniversarySaved":
							if (ActivatedEventElements.Contains("AccountAnniversarySaved")) {
							context.QueueTasks.Enqueue("AccountAnniversarySaved");
						}
						break;
					case "AccountAnniversaryDeleted":
							if (ActivatedEventElements.Contains("AccountAnniversaryDeleted")) {
							context.QueueTasks.Enqueue("AccountAnniversaryDeleted");
						}
						break;
					case "AccountAnniversarySaving":
							if (ActivatedEventElements.Contains("AccountAnniversarySaving_Base")) {
							context.QueueTasks.Enqueue("AccountAnniversarySaving_Base");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsDateChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsDateChanged", IsDateChanged, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnniversary_BaseEventsProcess

	/// <exclude/>
	public class AccountAnniversary_BaseEventsProcess : AccountAnniversary_BaseEventsProcess<AccountAnniversary>
	{

		public AccountAnniversary_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAnniversary_BaseEventsProcess

	public partial class AccountAnniversary_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateRemindingsExecute() {
			if (!IsDateChanged) {
				return;
			}
			Guid id = Entity.GetTypedColumnValue<Guid>("AccountId");
			AccountAnniversaryReminding remindingsGenerator = new AccountAnniversaryReminding(UserConnection, id);
			remindingsGenerator.Options = new [] { AccountAnniversaryReminding.AccountOption };
			remindingsGenerator.GenerateActualRemindings();
		}

		#endregion

	}

	#endregion

	#region Class: AccountAnniversaryEventsProcessSchema

	/// <exclude/>
	public class AccountAnniversaryEventsProcessSchema : Terrasoft.Configuration.BaseAnniversaryEventsProcessSchema
	{

		#region Constructors: Public

		public AccountAnniversaryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountAnniversaryEventsProcessSchema(AccountAnniversaryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountAnniversary_BaseEventsProcess";
			UId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc");
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

		protected virtual ProcessSchemaParameter CreateIsDateChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f0d2536b-5a18-4c37-9c1c-2f7b632ab01c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"IsDateChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsDateChangedParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3_d7e07adaec9f4dfb8d14fd55bcf57b4c = CreateEventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4cEventSubProcess();
			FlowElements.Add(eventsubprocess3_d7e07adaec9f4dfb8d14fd55bcf57b4c);
			ProcessSchemaStartMessageEvent accountanniversarysaved = CreateAccountAnniversarySavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(accountanniversarysaved);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			eventsubprocess1.FlowElements.Add(updateremindings);
			ProcessSchemaStartMessageEvent accountanniversarydeleted = CreateAccountAnniversaryDeletedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(accountanniversarydeleted);
			ProcessSchemaScriptTask deleted_initdatechanged = CreateDeleted_InitDateChangedScriptTask();
			eventsubprocess1.FlowElements.Add(deleted_initdatechanged);
			ProcessSchemaStartMessageEvent accountanniversarysaving_base = CreateAccountAnniversarySaving_BaseStartMessageEvent();
			eventsubprocess3_d7e07adaec9f4dfb8d14fd55bcf57b4c.FlowElements.Add(accountanniversarysaving_base);
			ProcessSchemaScriptTask saving_initdatechanged = CreateSaving_InitDateChangedScriptTask();
			eventsubprocess3_d7e07adaec9f4dfb8d14fd55bcf57b4c.FlowElements.Add(saving_initdatechanged);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2_1a3cdee1c4bf43f39c8cdfc451d147dbSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_1d6d577a86e74848a984d98d0478b114SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("622d7103-ca8c-4bfb-98ee-7af7c75279df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f8ee61e9-4b10-4058-a0bb-0a4c685354f3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0941540b-9c03-40da-9392-31348aa8fa4f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_1a3cdee1c4bf43f39c8cdfc451d147dbSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_1a3cdee1c4bf43f39c8cdfc451d147db",
				UId = new Guid("1a3cdee1-c4bf-43f3-9c8c-dfc451d147db"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c4c9869c-a113-4c3b-a706-6037458c9375"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a740381b-b76d-41bc-a03f-ba1afe0082de"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(435, 143));
			schemaFlow.PolylinePointPositions.Add(new Point(435, 137));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_1d6d577a86e74848a984d98d0478b114SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_1d6d577a86e74848a984d98d0478b114",
				UId = new Guid("1d6d577a-86e7-4848-a984-d98d0478b114"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a30caf29-bad5-49e4-b180-92799a2a577a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46fb7038-ea21-4079-9436-29bc08c47ea1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5c58e1df-5a7d-4d39-8267-8a417c60f84a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("4677acfd-9bd0-4a4b-8b73-6f2d62a7c65e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c58e1df-5a7d-4d39-8267-8a417c60f84a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("be4de872-76c4-4b87-86b0-4b64ec0806da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4677acfd-9bd0-4a4b-8b73-6f2d62a7c65e"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 60),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(257, 276),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountAnniversarySavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f8ee61e9-4b10-4058-a0bb-0a4c685354f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be4de872-76c4-4b87-86b0-4b64ec0806da"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountAnniversarySaved",
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"AccountAnniversarySaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0941540b-9c03-40da-9392-31348aa8fa4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be4de872-76c4-4b87-86b0-4b64ec0806da"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(146, 26),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,74,205,205,204,75,201,204,75,47,118,173,72,77,46,45,73,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,103,2,161,1,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountAnniversaryDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a30caf29-bad5-49e4-b180-92799a2a577a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be4de872-76c4-4b87-86b0-4b64ec0806da"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountAnniversaryDeleted",
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"AccountAnniversaryDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 200),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleted_InitDateChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("46fb7038-ea21-4079-9436-29bc08c47ea1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("be4de872-76c4-4b87-86b0-4b64ec0806da"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"Deleted_InitDateChanged",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(146, 186),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,193,10,194,48,16,68,239,126,69,232,169,130,244,7,170,66,169,82,122,173,214,123,73,6,13,180,27,217,108,148,254,189,177,212,226,65,132,61,44,51,243,134,221,42,88,163,226,236,212,145,196,202,152,85,144,243,120,135,41,93,31,6,186,116,125,192,182,138,161,125,154,20,90,187,64,82,155,100,157,175,222,154,242,250,134,161,107,235,47,126,14,101,167,201,202,162,151,175,102,173,32,178,15,176,239,120,108,48,88,50,150,174,138,63,155,175,64,224,78,28,199,50,194,83,253,161,210,214,131,75,71,4,45,214,209,38,126,16,79,250,81,149,29,208,67,208,64,59,54,11,238,211,229,240,9,147,192,164,132,3,242,23,153,231,123,139,15,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4cEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d7e07ada-ec9f-4dfb-8d14-fd55bcf57b4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4677acfd-9bd0-4a4b-8b73-6f2d62a7c65e"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"EventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(340, 60),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(254, 180),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_d7e07adaec9f4dfb8d14fd55bcf57b4c;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountAnniversarySaving_BaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c4c9869c-a113-4c3b-a706-6037458c9375"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7e07ada-ec9f-4dfb-8d14-fd55bcf57b4c"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountAnniversarySaving",
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"AccountAnniversarySaving_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSaving_InitDateChangedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a740381b-b76d-41bc-a03f-ba1afe0082de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d7e07ada-ec9f-4dfb-8d14-fd55bcf57b4c"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				Name = @"Saving_InitDateChanged",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(143, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,118,73,44,73,117,206,72,204,75,79,77,81,176,85,112,205,43,201,44,169,212,115,79,45,129,138,57,231,231,148,230,230,133,37,230,148,166,22,107,104,234,57,230,85,106,36,231,231,40,216,218,41,0,41,61,191,196,220,84,5,91,91,5,37,144,41,74,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,100,212,200,123,92,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateRemindingsExecuteMethod());
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
				UId = new Guid("7d50c547-8c87-482e-96e8-c95503b00c1c"),
				Name = "System.Linq",
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

		protected virtual SchemaMethod CreateUpdateRemindingsExecuteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("459f9e88-b8f3-41cf-b2b6-e9c1eed007e3"),
				Name = "UpdateRemindingsExecute",
				CreatedInSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,65,11,130,64,16,133,207,237,175,216,60,41,132,127,192,10,196,66,60,5,81,93,162,195,226,78,182,160,179,178,59,91,136,248,223,91,201,58,73,48,135,55,204,123,223,27,117,231,225,178,176,59,65,144,61,4,86,32,35,222,179,133,1,114,6,19,54,176,220,41,201,253,108,248,30,73,81,23,231,64,167,174,5,153,233,218,53,120,17,181,131,245,104,218,134,65,90,150,218,33,21,50,136,18,54,45,41,162,122,130,177,194,116,71,104,20,74,133,21,55,95,101,115,64,48,130,180,241,5,8,47,254,39,21,158,45,152,76,35,66,73,74,227,202,127,229,107,102,80,241,161,29,13,118,66,94,111,188,255,199,141,167,219,39,197,135,121,230,164,32,45,201,137,250,23,182,97,148,188,1,138,212,192,65,68,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAnniversaryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"));
		}

		#endregion

	}

	#endregion


	#region Class: AccountAnniversaryEventsProcess

	/// <exclude/>
	public class AccountAnniversaryEventsProcess : AccountAnniversary_BaseEventsProcess
	{

		public AccountAnniversaryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

