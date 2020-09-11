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
	using Terrasoft.Configuration;
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

	#region Class: AccountCommunicationSchema

	/// <exclude/>
	public class AccountCommunicationSchema : Terrasoft.Configuration.BaseCommunicationSchema
	{

		#region Constructors: Public

		public AccountCommunicationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountCommunicationSchema(AccountCommunicationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountCommunicationSchema(AccountCommunicationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("81c43461-0619-44dd-8071-b724128085c6");
			RealUId = new Guid("81c43461-0619-44dd-8071-b724128085c6");
			Name = "AccountCommunication";
			ParentSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateAccountColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("83980e6d-09cc-4104-8a0b-64e974eecbdd")) == null) {
				Columns.Add(CreatePrimaryColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6");
			return column;
		}

		protected override EntitySchemaColumn CreateCommunicationTypeColumn() {
			EntitySchemaColumn column = base.CreateCommunicationTypeColumn();
			column.ModifiedInSchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3aee4a24-ecca-4e16-b795-483233d9d577"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6"),
				ModifiedInSchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("83980e6d-09cc-4104-8a0b-64e974eecbdd"),
				Name = @"Primary",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6"),
				ModifiedInSchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountCommunicationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAccountCommunicationEventsProcessSchema() {
			var schema = new AccountCommunicationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountCommunication(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountCommunication_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountCommunicationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountCommunicationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81c43461-0619-44dd-8071-b724128085c6"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountCommunication

	/// <summary>
	/// Account communication option.
	/// </summary>
	public class AccountCommunication : Terrasoft.Configuration.BaseCommunication
	{

		#region Constructors: Public

		public AccountCommunication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountCommunication";
		}

		public AccountCommunication(AccountCommunication source)
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

		/// <summary>
		/// Primary.
		/// </summary>
		public bool Primary {
			get {
				return GetTypedColumnValue<bool>("Primary");
			}
			set {
				SetColumnValue("Primary", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountCommunication_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountCommunicationDeleted", e);
			Inserting += (s, e) => ThrowEvent("AccountCommunicationInserting", e);
			Saved += (s, e) => ThrowEvent("AccountCommunicationSaved", e);
			Saving += (s, e) => ThrowEvent("AccountCommunicationSaving", e);
			Validating += (s, e) => ThrowEvent("AccountCommunicationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountCommunication(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountCommunication_BaseEventsProcess

	/// <exclude/>
	public partial class AccountCommunication_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCommunication_BaseEventsProcess<TEntity> where TEntity : AccountCommunication
	{

		public AccountCommunication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountCommunication_BaseEventsProcess";
			SchemaUId = new Guid("81c43461-0619-44dd-8071-b724128085c6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("81c43461-0619-44dd-8071-b724128085c6");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool DeletedMain {
			get;
			set;
		}

		public virtual bool IsNew {
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
					SchemaElementUId = new Guid("6e3db018-97ec-4f4e-ad47-985b036fd8d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountCommunicationSaved;
		public ProcessFlowElement AccountCommunicationSaved {
			get {
				return _accountCommunicationSaved ?? (_accountCommunicationSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountCommunicationSaved",
					SchemaElementUId = new Guid("bd2b3360-67f3-45c7-a46f-47b7fb613938"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAccountCommunicationSaved;
		public ProcessScriptTask ScriptAccountCommunicationSaved {
			get {
				return _scriptAccountCommunicationSaved ?? (_scriptAccountCommunicationSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAccountCommunicationSaved",
					SchemaElementUId = new Guid("db608945-b58d-4730-a558-52386ad98988"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAccountCommunicationSavedExecute,
				});
			}
		}

		private ProcessScriptTask _scriptAccountCommunicationDeleted;
		public ProcessScriptTask ScriptAccountCommunicationDeleted {
			get {
				return _scriptAccountCommunicationDeleted ?? (_scriptAccountCommunicationDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAccountCommunicationDeleted",
					SchemaElementUId = new Guid("d4fb080d-ac0a-4010-b67d-2f92301cdf50"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAccountCommunicationDeletedExecute,
				});
			}
		}

		private ProcessFlowElement _accountCommunicationDeleted;
		public ProcessFlowElement AccountCommunicationDeleted {
			get {
				return _accountCommunicationDeleted ?? (_accountCommunicationDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountCommunicationDeleted",
					SchemaElementUId = new Guid("8c720986-f9d5-4a74-98c8-33efdc8aa5cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("c55a733c-3f20-475c-afca-1ac8ee10ef7b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountCommunicationSaving;
		public ProcessFlowElement AccountCommunicationSaving {
			get {
				return _accountCommunicationSaving ?? (_accountCommunicationSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountCommunicationSaving",
					SchemaElementUId = new Guid("0f606ff6-ae30-478e-91b3-f3bc17fd3b0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _accountCommunicationSavingScriptTask;
		public ProcessScriptTask AccountCommunicationSavingScriptTask {
			get {
				return _accountCommunicationSavingScriptTask ?? (_accountCommunicationSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AccountCommunicationSavingScriptTask",
					SchemaElementUId = new Guid("44f7d30b-805e-4511-8b77-de9af6d133a9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AccountCommunicationSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[AccountCommunicationSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountCommunicationSaved };
			FlowElements[ScriptAccountCommunicationSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAccountCommunicationSaved };
			FlowElements[ScriptAccountCommunicationDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAccountCommunicationDeleted };
			FlowElements[AccountCommunicationDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountCommunicationDeleted };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[AccountCommunicationSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountCommunicationSaving };
			FlowElements[AccountCommunicationSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountCommunicationSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "AccountCommunicationSaved":
						e.Context.QueueTasks.Enqueue("ScriptAccountCommunicationSaved");
						break;
					case "ScriptAccountCommunicationSaved":
						break;
					case "ScriptAccountCommunicationDeleted":
						break;
					case "AccountCommunicationDeleted":
						e.Context.QueueTasks.Enqueue("ScriptAccountCommunicationDeleted");
						break;
					case "SubProcess2":
						break;
					case "AccountCommunicationSaving":
						e.Context.QueueTasks.Enqueue("AccountCommunicationSavingScriptTask");
						break;
					case "AccountCommunicationSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AccountCommunicationSaved");
			ActivatedEventElements.Add("AccountCommunicationDeleted");
			ActivatedEventElements.Add("AccountCommunicationSaving");
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
				case "AccountCommunicationSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountCommunicationSaved";
					result = AccountCommunicationSaved.Execute(context);
					break;
				case "ScriptAccountCommunicationSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAccountCommunicationSaved";
					result = ScriptAccountCommunicationSaved.Execute(context, ScriptAccountCommunicationSavedExecute);
					break;
				case "ScriptAccountCommunicationDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAccountCommunicationDeleted";
					result = ScriptAccountCommunicationDeleted.Execute(context, ScriptAccountCommunicationDeletedExecute);
					break;
				case "AccountCommunicationDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountCommunicationDeleted";
					result = AccountCommunicationDeleted.Execute(context);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "AccountCommunicationSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountCommunicationSaving";
					result = AccountCommunicationSaving.Execute(context);
					break;
				case "AccountCommunicationSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountCommunicationSavingScriptTask";
					result = AccountCommunicationSavingScriptTask.Execute(context, AccountCommunicationSavingScriptTaskExecute);
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
				case "IsNew":
					IsNew = reader.GetValue<System.Boolean>();
				break;
				case "DeletedMain":
					DeletedMain = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptAccountCommunicationSavedExecute(ProcessExecutingContext context) {
			OnAccountCommunicationSaved();
			RemoveDuplicates();
			return true;
		}

		public virtual bool ScriptAccountCommunicationDeletedExecute(ProcessExecutingContext context) {
			OnAccountCommunicationDeleted();
			return true;
		}

		public virtual bool AccountCommunicationSavingScriptTaskExecute(ProcessExecutingContext context) {
			OnAccountCommunicationSaving();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AccountCommunicationSaved":
							if (ActivatedEventElements.Contains("AccountCommunicationSaved")) {
							context.QueueTasks.Enqueue("AccountCommunicationSaved");
						}
						break;
					case "AccountCommunicationDeleted":
							if (ActivatedEventElements.Contains("AccountCommunicationDeleted")) {
							context.QueueTasks.Enqueue("AccountCommunicationDeleted");
						}
						break;
					case "AccountCommunicationSaving":
							if (ActivatedEventElements.Contains("AccountCommunicationSaving")) {
							context.QueueTasks.Enqueue("AccountCommunicationSaving");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsNew") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNew", IsNew, false);
			}
			if (!HasMapping("DeletedMain") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DeletedMain", DeletedMain, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AccountCommunication_BaseEventsProcess

	/// <exclude/>
	public class AccountCommunication_BaseEventsProcess : AccountCommunication_BaseEventsProcess<AccountCommunication>
	{

		public AccountCommunication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountCommunication_BaseEventsProcess

	public partial class AccountCommunication_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnAccountCommunicationSaved() {
			var typeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			var typedColumnName = GetColumnNameByCommunicationType(typeId);
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			UpdateCommunicationParentEntity("Account", accountId, typedColumnName);
		}

		public virtual void OnAccountCommunicationDeleted() {
			var accountESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Account");
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			var number = Entity.GetTypedColumnValue<string>("Number");
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			bool isPrimary = Entity.GetTypedColumnValue<bool>("Primary");
			var columnName = GetColumnNameByCommunicationType(communicationTypeId);
			bool isCanEdit = GetCanEditColumn("Account", columnName);
			if (!string.IsNullOrEmpty(columnName) && isPrimary) {
				accountESQ.AddAllSchemaColumns();
				var accountEntity = accountESQ.GetEntity(UserConnection, accountId);
				if (isCanEdit && accountEntity != null) {
					var value = accountEntity.GetTypedColumnValue<string>(columnName);
					if (value == number) {
						accountEntity.SetColumnValue(columnName, string.Empty);
						accountEntity.Save();
					}
				}
			}
		}

		public virtual void OnAccountCommunicationSaving() {
			IsNew = GetIsNew();
			if (IsNew) {
				ActualizePrimaryState();
				Entity.SetColumnValue("Primary", true);
			} else {
				ClearOldCommunication();
			}
		}

		public virtual string GetColumnNameByCommunicationType(Guid communicationType) {
			string columnName;
			switch (communicationType.ToString()) {
				case CommunicationTypeConsts.WebId:
					columnName = "Web";
					break;
				case CommunicationTypeConsts.MainPhoneId:
					columnName = "Phone";
					break;
				case CommunicationTypeConsts.AdditionalPhoneId:
					columnName = "AdditionalPhone";
					break;
				case CommunicationTypeConsts.FaxId:
					columnName = "Fax";
					break;
				default:
					columnName = string.Empty;
					break;
			}
			return columnName;
		}

		public virtual void ClearOldCommunication() {
			var oldCommunicationTypeId = Entity.GetTypedOldColumnValue<Guid>("CommunicationTypeId");
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			if (!oldCommunicationTypeId.Equals(Guid.Empty) && !oldCommunicationTypeId.Equals(communicationTypeId)) {
				ActualizePrimaryState();
				Entity.SetColumnValue("Primary", true);
				var columnName = GetColumnNameByCommunicationType(oldCommunicationTypeId);
				bool isCanEdit = GetCanEditColumn("Account", columnName);
				if (isCanEdit && !string.IsNullOrEmpty(columnName)) {
					var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
					var update = new Update(UserConnection, "Account")
							.Set(columnName, Column.Const(string.Empty))
						.Where("Id")
							.IsEqual(Column.Const(accountId));
					update.Execute();
				}
			}
		}

		public virtual void ActualizePrimaryState() {
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			var update = new Update(UserConnection, "AccountCommunication")
				.Set("Primary", Column.Parameter(false))
			.Where("AccountId").IsEqual(Column.Parameter(accountId))
			.And("CommunicationTypeId").IsEqual(Column.Parameter(communicationTypeId)) as Update;
			update.Execute();
		}

		public virtual bool GetIsNew() {
			string oldNumber = Entity.GetTypedOldColumnValue<string>("Number");
			string newNumber = Entity.GetTypedColumnValue<string>("Number");
			return (string.IsNullOrEmpty(oldNumber) && !newNumber.Equals(oldNumber));
		}

		public virtual void RemoveDuplicates() {
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			var number = Entity.GetTypedColumnValue<string>("Number");
			var id = Entity.GetTypedColumnValue<Guid>("Id");
			var del = new Delete(UserConnection).From("AccountCommunication")
				.Where("AccountId").IsEqual(Column.Parameter(accountId)).
				And("CommunicationTypeId").IsEqual(Column.Parameter(communicationTypeId)).
				And("Number").IsEqual(Column.Parameter(number)).
				And("Id").Not().IsEqual(Column.Parameter(id)) as Delete;
			del.Execute();
		}

		public override Entity GetCommunicationParentEntity(string schemaName, Guid id) {
			var accountESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, schemaName);
			accountESQ.AddAllSchemaColumns();
			return accountESQ.GetEntity(UserConnection, id);
		}

		public override void SetCommunicationParentEntityColumns(Entity parentEntity) {
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			var typeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			var columnName = GetColumnNameByCommunicationType(typeId);
			if (string.IsNullOrEmpty(columnName)) {
				return;
			}
			var number = Entity.GetTypedColumnValue<string>("Number");
			parentEntity.SetColumnValue(columnName, number);
		}

		#endregion

	}

	#endregion

	#region Class: AccountCommunicationEventsProcessSchema

	/// <exclude/>
	public class AccountCommunicationEventsProcessSchema : Terrasoft.Configuration.BaseCommunicationEventsProcessSchema
	{

		#region Constructors: Public

		public AccountCommunicationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountCommunicationEventsProcessSchema(AccountCommunicationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountCommunication_BaseEventsProcess";
			UId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6");
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

		protected virtual ProcessSchemaParameter CreateDeletedMainParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f7d096a9-45be-4f3a-be71-be6fbb167138"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"DeletedMain",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("04846fdd-b869-4851-8bb7-1415e6aad401"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"IsNew",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDeletedMainParameter());
			Parameters.Add(CreateIsNewParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet775 = CreateLaneSet775LaneSet();
			LaneSets.Add(schemaLaneSet775);
			ProcessSchemaLane schemaLane2783 = CreateLane2783Lane();
			schemaLaneSet775.Lanes.Add(schemaLane2783);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaStartMessageEvent accountcommunicationsaved = CreateAccountCommunicationSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(accountcommunicationsaved);
			ProcessSchemaScriptTask scriptaccountcommunicationsaved = CreateScriptAccountCommunicationSavedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptaccountcommunicationsaved);
			ProcessSchemaScriptTask scriptaccountcommunicationdeleted = CreateScriptAccountCommunicationDeletedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptaccountcommunicationdeleted);
			ProcessSchemaStartMessageEvent accountcommunicationdeleted = CreateAccountCommunicationDeletedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(accountcommunicationdeleted);
			ProcessSchemaStartMessageEvent accountcommunicationsaving = CreateAccountCommunicationSavingStartMessageEvent();
			subprocess2.FlowElements.Add(accountcommunicationsaving);
			ProcessSchemaScriptTask accountcommunicationsavingscripttask = CreateAccountCommunicationSavingScriptTaskScriptTask();
			subprocess2.FlowElements.Add(accountcommunicationsavingscripttask);
			FlowElements.Add(CreateSequenceFlow16372SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16372SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16372",
				UId = new Guid("18b068d6-fd96-4fad-8f3e-b0e33c65cb92"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CurveCenterPosition = new Point(216, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8c720986-f9d5-4a74-98c8-33efdc8aa5cd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d4fb080d-ac0a-4010-b67d-2f92301cdf50"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ab15a0d1-d96f-4ce6-9bba-cd4f11ced1c8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CurveCenterPosition = new Point(176, 391),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f606ff6-ae30-478e-91b3-f3bc17fd3b0d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44f7d30b-805e-4511-8b77-de9af6d133a9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f75534b9-21ed-44ab-93f6-c2873b6ff11d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CurveCenterPosition = new Point(228, 122),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bd2b3360-67f3-45c7-a46f-47b7fb613938"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db608945-b58d-4730-a558-52386ad98988"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet775LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet775 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ff4219a9-f813-4d42-bc11-29d3a69ef252"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"LaneSet775",
				Position = new Point(5, 5),
				Size = new Size(1164, 497),
				UseBackgroundMode = false
			};
			return schemaLaneSet775;
		}

		protected virtual ProcessSchemaLane CreateLane2783Lane() {
			ProcessSchemaLane schemaLane2783 = new ProcessSchemaLane(this) {
				UId = new Guid("60469563-b6a3-4816-b3a2-6e749fa20524"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ff4219a9-f813-4d42-bc11-29d3a69ef252"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"Lane2783",
				Position = new Point(29, 0),
				Size = new Size(1135, 497),
				UseBackgroundMode = false
			};
			return schemaLane2783;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6e3db018-97ec-4f4e-ad47-985b036fd8d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60469563-b6a3-4816-b3a2-6e749fa20524"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"EventSubProcess1",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(280, 242),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountCommunicationSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bd2b3360-67f3-45c7-a46f-47b7fb613938"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e3db018-97ec-4f4e-ad47-985b036fd8d3"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AccountCommunicationSaved",
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"AccountCommunicationSaved",
				Position = new Point(35, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAccountCommunicationSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("db608945-b58d-4730-a558-52386ad98988"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e3db018-97ec-4f4e-ad47-985b036fd8d3"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"ScriptAccountCommunicationSaved",
				Position = new Point(161, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,76,78,206,47,205,43,113,206,207,205,45,205,203,76,78,44,201,204,207,11,78,44,75,77,209,208,180,230,229,10,74,205,205,47,75,117,41,45,200,1,73,165,22,131,5,139,82,75,74,139,242,20,74,138,74,83,129,60,0,181,242,29,250,67,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAccountCommunicationDeletedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d4fb080d-ac0a-4010-b67d-2f92301cdf50"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e3db018-97ec-4f4e-ad47-985b036fd8d3"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"ScriptAccountCommunicationDeleted",
				Position = new Point(161, 133),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,76,78,206,47,205,43,113,206,207,205,45,205,203,76,78,44,201,204,207,115,73,205,73,45,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,5,242,0,31,197,182,170,48,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountCommunicationDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8c720986-f9d5-4a74-98c8-33efdc8aa5cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6e3db018-97ec-4f4e-ad47-985b036fd8d3"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountCommunicationDeleted",
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"AccountCommunicationDeleted",
				Position = new Point(35, 147),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c55a733c-3f20-475c-afca-1ac8ee10ef7b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("60469563-b6a3-4816-b3a2-6e749fa20524"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"SubProcess2",
				Position = new Point(42, 259),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(278, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountCommunicationSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0f606ff6-ae30-478e-91b3-f3bc17fd3b0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c55a733c-3f20-475c-afca-1ac8ee10ef7b"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountCommunicationSaving",
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"AccountCommunicationSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAccountCommunicationSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("44f7d30b-805e-4511-8b77-de9af6d133a9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c55a733c-3f20-475c-afca-1ac8ee10ef7b"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Name = @"AccountCommunicationSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,76,78,206,47,205,43,113,206,207,205,45,205,203,76,78,44,201,204,207,11,78,44,203,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,61,23,212,57,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnAccountCommunicationSavedMethod());
			Methods.Add(CreateOnAccountCommunicationDeletedMethod());
			Methods.Add(CreateOnAccountCommunicationSavingMethod());
			Methods.Add(CreateGetColumnNameByCommunicationTypeMethod());
			Methods.Add(CreateClearOldCommunicationMethod());
			Methods.Add(CreateActualizePrimaryStateMethod());
			Methods.Add(CreateGetIsNewMethod());
			Methods.Add(CreateRemoveDuplicatesMethod());
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
				UId = new Guid("232234a9-4f02-43a0-bada-6089682a1ffb"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7")
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

		protected override SchemaMethod CreateGetCommunicationParentEntityMethod() {
			SchemaMethod method = base.CreateGetCommunicationParentEntityMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,65,10,131,48,16,0,239,5,255,176,71,5,201,7,196,131,136,244,212,130,72,31,176,36,75,13,36,27,216,108,90,252,125,105,61,40,61,14,12,51,47,20,64,107,83,97,157,150,25,122,96,122,195,196,234,117,91,236,74,17,231,66,178,213,143,76,50,38,102,178,234,19,155,179,112,67,198,39,73,11,249,135,119,140,212,116,213,229,136,154,193,185,33,132,221,30,83,40,145,115,253,85,132,180,8,159,246,230,74,186,167,255,134,45,120,215,116,31,44,187,245,64,172,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetCommunicationParentEntityColumnsMethod() {
			SchemaMethod method = base.CreateSetCommunicationParentEntityColumnsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,205,10,130,64,20,70,215,9,190,195,224,202,129,240,5,172,160,68,196,141,45,146,246,211,56,197,128,115,149,241,142,32,209,187,55,141,63,5,65,180,188,112,206,185,95,207,52,97,156,55,6,48,175,200,150,164,128,18,135,40,19,88,14,173,168,146,166,54,10,206,172,54,98,147,25,89,237,194,96,63,211,1,141,125,175,183,62,90,242,79,57,105,148,50,32,57,67,217,64,233,188,37,195,29,94,48,37,108,202,54,146,229,62,12,95,94,56,62,125,185,242,74,194,14,181,132,91,148,119,133,169,235,163,78,85,139,67,248,14,82,74,238,190,183,210,2,141,6,171,60,198,143,96,212,69,232,223,195,199,178,157,94,56,216,173,109,153,22,128,147,116,154,151,58,254,227,233,122,234,211,248,9,219,204,91,1,101,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnAccountCommunicationSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6ea8b8bd-5bea-472b-b0bd-ba4f86385f15"),
				Name = "OnAccountCommunicationSaved",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("f2b2bf98-7d51-4b6d-9e0b-dcf9524e962a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,169,44,72,245,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,1,10,165,56,231,231,148,230,230,133,37,230,148,166,218,184,151,102,166,216,105,40,57,231,231,230,150,230,101,38,39,150,100,230,231,133,128,245,41,105,90,243,114,149,65,141,129,234,241,75,204,77,5,154,7,52,8,193,119,170,196,208,172,1,177,25,102,64,98,114,114,126,105,94,9,145,78,113,132,169,6,59,32,180,32,37,177,36,21,197,134,128,196,162,212,188,18,136,65,112,229,74,58,8,107,116,208,157,172,105,13,0,222,35,206,108,15,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnAccountCommunicationDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bed9ba76-86a8-4e85-be77-fa9449745ab7"),
				Name = "OnAccountCommunicationDeleted",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("f2b2bf98-7d51-4b6d-9e0b-dcf9524e962a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,93,107,194,48,20,134,175,43,248,31,162,23,82,161,244,15,108,14,92,41,210,139,117,19,183,221,199,38,115,129,124,72,154,116,148,225,127,95,62,106,155,234,112,187,104,33,225,188,207,121,207,155,211,64,9,96,85,9,205,85,190,219,130,21,224,248,11,228,92,17,213,238,170,79,204,224,86,99,217,198,111,53,150,153,224,28,87,138,8,158,134,5,79,144,195,3,150,9,152,175,61,103,190,188,155,78,154,129,91,32,131,245,138,116,131,213,107,123,196,40,19,84,51,254,14,169,198,247,27,77,208,67,124,86,23,168,215,115,205,246,88,222,22,215,74,18,126,48,242,210,21,247,218,74,48,166,57,169,160,245,107,85,255,116,145,93,235,28,115,47,4,5,164,126,145,132,65,217,222,70,217,90,131,234,106,3,75,182,164,132,12,27,185,209,101,253,249,177,189,106,27,255,50,64,224,35,131,60,71,68,117,32,127,240,188,62,200,121,18,116,180,82,242,1,226,153,207,43,45,234,82,83,250,44,115,118,84,109,28,212,129,197,98,24,115,9,190,167,147,104,88,143,116,141,208,154,82,255,238,190,93,29,91,116,20,60,183,15,198,56,11,116,198,164,191,190,88,164,100,216,17,135,177,22,135,225,140,149,49,115,102,214,211,216,246,182,92,207,198,6,30,244,250,123,81,198,153,68,174,101,71,89,117,27,215,241,163,49,116,119,126,49,199,11,56,9,232,66,117,97,122,234,165,22,54,216,7,21,157,204,207,124,167,31,5,158,195,102,121,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnAccountCommunicationSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5d94a164-4121-44c4-806e-1183fa32356c"),
				Name = "OnAccountCommunicationSaving",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("f2b2bf98-7d51-4b6d-9e0b-dcf9524e962a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,204,193,10,194,48,16,132,225,115,251,20,75,79,41,136,47,32,30,36,136,244,162,66,193,251,82,71,88,216,36,144,110,144,42,125,119,141,120,155,129,143,127,152,207,120,210,158,78,176,161,78,215,239,90,121,144,251,157,158,222,109,115,152,172,176,202,11,215,44,129,243,50,26,27,42,107,142,209,196,150,237,8,243,73,75,136,55,214,2,215,253,93,183,33,203,5,95,184,18,116,70,109,121,5,231,139,222,125,10,161,68,153,216,36,197,218,90,63,89,41,185,2,136,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnNameByCommunicationTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ce9693b6-3289-45af-ba59-c9318d2eb4cc"),
				Name = "GetColumnNameByCommunicationType",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ac88a0de-06d4-4e72-9df4-6b1fb1df7e84"),
				Name = "communicationType",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				ModifiedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,205,10,130,64,16,128,207,10,190,195,226,201,46,62,64,210,33,164,160,67,17,36,116,30,215,41,151,220,89,217,31,74,162,119,79,189,84,102,132,215,111,190,249,14,51,198,106,65,103,198,85,229,36,237,64,98,18,248,230,42,44,47,89,196,149,148,142,4,7,43,20,101,77,141,113,166,14,189,31,205,102,236,30,248,30,7,131,44,29,106,169,34,99,77,124,196,124,83,204,91,203,123,213,217,130,133,45,15,147,14,231,26,225,146,252,203,108,65,208,190,84,132,163,177,126,50,37,183,44,10,209,33,168,126,71,7,206,148,252,26,110,163,201,150,15,50,5,158,192,85,246,219,53,253,137,227,149,172,109,243,177,242,8,124,141,214,105,122,127,215,19,231,191,100,116,193,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearOldCommunicationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c1692018-d06a-423d-aa6a-2d74151f55eb"),
				Name = "ClearOldCommunication",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,205,78,195,48,16,132,207,233,83,152,28,42,71,170,252,2,252,72,165,138,170,94,90,164,82,56,27,199,128,37,199,46,246,186,16,80,223,29,175,157,150,34,34,209,227,90,51,227,111,103,119,220,17,171,155,153,109,219,96,148,224,160,172,185,239,182,114,209,144,107,82,27,80,208,177,185,4,124,106,86,168,211,161,53,15,92,7,121,53,15,170,185,161,229,128,181,172,46,71,187,24,44,206,73,61,63,82,61,19,122,49,12,203,234,183,192,181,167,24,192,234,118,11,93,69,198,99,242,143,122,128,175,170,200,215,168,152,10,136,2,245,41,239,156,106,185,235,214,192,65,210,136,80,244,240,107,9,39,220,180,236,117,229,132,128,11,18,133,121,127,148,44,121,43,227,218,243,131,5,231,219,238,15,22,29,102,197,172,39,107,53,81,126,198,77,221,40,232,179,242,144,35,105,57,21,194,6,3,17,224,231,83,180,98,103,63,78,172,196,131,83,230,133,45,252,50,104,189,114,169,44,122,98,74,5,36,124,158,51,207,60,218,244,160,198,83,229,128,176,109,98,111,209,109,228,59,217,164,129,110,188,116,51,107,140,20,184,227,132,28,201,171,104,42,10,108,246,132,102,66,242,79,44,90,60,208,158,61,31,56,25,216,227,171,116,241,0,248,109,14,88,248,116,93,250,203,120,92,165,74,112,25,140,213,31,82,132,254,176,251,209,254,27,11,134,38,170,12,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizePrimaryStateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f5edc28-cab1-4ad7-9c53-e76f6c4ea1b9"),
				Name = "ActualizePrimaryState",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,203,10,194,48,16,69,215,246,43,66,86,9,72,126,160,42,72,41,197,157,224,107,61,36,35,6,154,137,166,137,218,191,183,85,43,136,10,46,51,228,220,59,103,206,16,152,246,206,37,178,26,162,245,180,110,143,184,48,108,202,74,138,54,182,170,194,216,143,76,225,235,228,104,11,117,194,73,149,172,153,9,94,124,114,92,230,217,185,139,4,173,125,162,248,103,208,124,248,61,224,233,104,32,98,199,18,94,216,230,254,16,155,6,67,225,137,80,247,117,99,54,80,111,91,112,153,141,212,10,163,224,203,96,29,132,150,143,217,163,80,45,33,128,195,136,65,236,161,110,80,202,76,237,14,24,240,173,94,45,154,242,148,160,22,31,208,203,168,7,231,100,126,232,255,14,248,114,101,41,25,52,79,191,60,123,72,171,242,138,58,117,190,50,191,1,164,10,2,41,156,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsNewMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f144386d-96a7-4f87-a4d8-bba7d6ebc7d3"),
				Name = "GetIsNew",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,41,202,204,75,87,200,207,73,241,43,205,77,74,45,82,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,241,207,73,113,206,207,41,205,205,11,75,204,41,77,181,41,6,107,176,211,80,130,168,87,210,180,230,130,8,41,228,165,150,227,50,131,128,1,69,169,37,165,69,121,10,26,16,41,61,207,98,191,210,156,28,255,34,215,220,130,146,74,13,184,211,52,21,212,212,20,20,225,182,232,185,22,150,38,230,20,35,201,107,90,3,0,215,101,213,54,206,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveDuplicatesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("18b27b6b-b3d1-4ca9-b549-794875f1ca98"),
				Name = "RemoveDuplicates",
				CreatedInSchemaUId = new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,193,110,2,33,16,134,207,154,248,14,100,79,112,225,5,212,38,102,93,141,23,227,193,234,153,194,68,73,96,104,89,208,250,246,142,90,55,107,234,26,175,100,190,255,103,190,57,168,200,116,240,62,163,213,42,217,128,235,211,55,44,12,27,179,10,147,77,39,57,135,116,121,50,101,112,217,227,70,185,12,163,121,182,230,131,23,229,127,174,16,195,65,255,64,153,74,235,144,49,189,153,52,185,79,55,60,102,255,5,241,53,92,167,104,113,71,248,242,58,220,176,246,189,210,86,155,1,71,8,194,145,77,193,65,2,254,89,67,44,3,34,232,203,110,66,206,98,240,205,55,31,246,46,196,160,223,147,219,61,68,120,216,67,46,234,234,39,43,199,111,205,114,165,162,242,20,29,121,163,70,8,73,236,4,77,135,202,238,136,39,23,107,133,221,117,116,243,55,187,45,228,90,183,12,137,191,128,44,117,48,85,255,41,34,115,100,77,86,191,160,51,9,19,195,51,51,147,51,86,74,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountCommunicationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1ed52dc-ad84-464c-a410-ff383b969bf6"));
		}

		#endregion

	}

	#endregion


	#region Class: AccountCommunicationEventsProcess

	/// <exclude/>
	public class AccountCommunicationEventsProcess : AccountCommunication_BaseEventsProcess
	{

		public AccountCommunicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

