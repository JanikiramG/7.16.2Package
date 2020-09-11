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

	#region Class: AccountAddressSchema

	/// <exclude/>
	public class AccountAddressSchema : Terrasoft.Configuration.BaseAddressSchema
	{

		#region Constructors: Public

		public AccountAddressSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountAddressSchema(AccountAddressSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountAddressSchema(AccountAddressSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da");
			RealUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da");
			Name = "AccountAddress";
			ParentSchemaUId = new Guid("400e8687-9616-480d-9d81-61de0235cc86");
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
			if (Columns.FindByUId(new Guid("8465542c-0dec-454b-87b2-4454adbe2a93")) == null) {
				Columns.Add(CreateGPSNColumn());
			}
			if (Columns.FindByUId(new Guid("4642e9b3-c514-4e94-b146-d19985e8e23a")) == null) {
				Columns.Add(CreateGPSEColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ad9016a8-9510-48da-b065-8d2e1701d0e9"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da"),
				ModifiedInSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateGPSNColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("8465542c-0dec-454b-87b2-4454adbe2a93"),
				Name = @"GPSN",
				CreatedInSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da"),
				ModifiedInSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da"),
				CreatedInPackageId = new Guid("4e5d5de2-9756-4189-8eb7-b9c0d14b74c2")
			};
		}

		protected virtual EntitySchemaColumn CreateGPSEColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4642e9b3-c514-4e94-b146-d19985e8e23a"),
				Name = @"GPSE",
				CreatedInSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da"),
				ModifiedInSchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da"),
				CreatedInPackageId = new Guid("4e5d5de2-9756-4189-8eb7-b9c0d14b74c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAccountAddressEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAccountAddressEventsProcessSchema() {
			var schema = new AccountAddressEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountAddress(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountAddress_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountAddressSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountAddressSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress

	/// <summary>
	/// Account address.
	/// </summary>
	public class AccountAddress : Terrasoft.Configuration.BaseAddress
	{

		#region Constructors: Public

		public AccountAddress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountAddress";
		}

		public AccountAddress(AccountAddress source)
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
		/// GPS N.
		/// </summary>
		public string GPSN {
			get {
				return GetTypedColumnValue<string>("GPSN");
			}
			set {
				SetColumnValue("GPSN", value);
			}
		}

		/// <summary>
		/// GPS E.
		/// </summary>
		public string GPSE {
			get {
				return GetTypedColumnValue<string>("GPSE");
			}
			set {
				SetColumnValue("GPSE", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountAddress_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountAddressDeleted", e);
			Inserted += (s, e) => ThrowEvent("AccountAddressInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountAddressInserting", e);
			Saved += (s, e) => ThrowEvent("AccountAddressSaved", e);
			Saving += (s, e) => ThrowEvent("AccountAddressSaving", e);
			Validating += (s, e) => ThrowEvent("AccountAddressValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAddress(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress_BaseEventsProcess

	/// <exclude/>
	public partial class AccountAddress_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseAddress_BaseEventsProcess<TEntity> where TEntity : AccountAddress
	{

		public AccountAddress_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountAddress_BaseEventsProcess";
			SchemaUId = new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8ab0fe8a-0340-41ac-8b09-b11f65dd83da");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid DeleteAccountId {
			get;
			set;
		}

		public virtual bool ClearPrimaryAddress {
			get;
			set;
		}

		public virtual Object AddressSynchronizer {
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
					SchemaElementUId = new Guid("7e58b355-af7a-4fd4-88dd-7b7e922910ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountAddressSaved;
		public ProcessFlowElement AccountAddressSaved {
			get {
				return _accountAddressSaved ?? (_accountAddressSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountAddressSaved",
					SchemaElementUId = new Guid("b6d4a672-5f08-41e2-bb93-959affdb2cea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _synchronizeAccountScript;
		public ProcessScriptTask SynchronizeAccountScript {
			get {
				return _synchronizeAccountScript ?? (_synchronizeAccountScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SynchronizeAccountScript",
					SchemaElementUId = new Guid("6d3df735-15b5-4a36-80e6-d1ba51215caf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SynchronizeAccountScriptExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("137d37d3-0ca9-4beb-b64b-899a7979bb0a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountAddressDeleted;
		public ProcessFlowElement AccountAddressDeleted {
			get {
				return _accountAddressDeleted ?? (_accountAddressDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountAddressDeleted",
					SchemaElementUId = new Guid("6ebb6a7a-e512-46c0-a56f-6709c6d1431e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptAccountAddressDeleted;
		public ProcessScriptTask ScriptAccountAddressDeleted {
			get {
				return _scriptAccountAddressDeleted ?? (_scriptAccountAddressDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptAccountAddressDeleted",
					SchemaElementUId = new Guid("e1ebe14f-d153-44a3-b934-fd70d25280da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptAccountAddressDeletedExecute,
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
					SchemaElementUId = new Guid("19c0109c-ae58-4785-abb6-bb64173505bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _accountAddressSavingStartMessage;
		public ProcessFlowElement AccountAddressSavingStartMessage {
			get {
				return _accountAddressSavingStartMessage ?? (_accountAddressSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AccountAddressSavingStartMessage",
					SchemaElementUId = new Guid("55a21698-24e0-4c0b-829e-4ccc55841834"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskAccountAddressSaving;
		public ProcessScriptTask ScriptTaskAccountAddressSaving {
			get {
				return _scriptTaskAccountAddressSaving ?? (_scriptTaskAccountAddressSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskAccountAddressSaving",
					SchemaElementUId = new Guid("e52bbc5c-3f9d-4d7d-ac9f-6b4f614a4ef5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskAccountAddressSavingExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[AccountAddressSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountAddressSaved };
			FlowElements[SynchronizeAccountScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeAccountScript };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[AccountAddressDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountAddressDeleted };
			FlowElements[ScriptAccountAddressDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptAccountAddressDeleted };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[AccountAddressSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AccountAddressSavingStartMessage };
			FlowElements[ScriptTaskAccountAddressSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskAccountAddressSaving };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "AccountAddressSaved":
						e.Context.QueueTasks.Enqueue("SynchronizeAccountScript");
						break;
					case "SynchronizeAccountScript":
						break;
					case "SubProcess1":
						break;
					case "AccountAddressDeleted":
						e.Context.QueueTasks.Enqueue("ScriptAccountAddressDeleted");
						break;
					case "ScriptAccountAddressDeleted":
						break;
					case "SubProcess2":
						break;
					case "AccountAddressSavingStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskAccountAddressSaving");
						break;
					case "ScriptTaskAccountAddressSaving":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AccountAddressSaved");
			ActivatedEventElements.Add("AccountAddressDeleted");
			ActivatedEventElements.Add("AccountAddressSavingStartMessage");
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
				case "AccountAddressSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountAddressSaved";
					result = AccountAddressSaved.Execute(context);
					break;
				case "SynchronizeAccountScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeAccountScript";
					result = SynchronizeAccountScript.Execute(context, SynchronizeAccountScriptExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "AccountAddressDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountAddressDeleted";
					result = AccountAddressDeleted.Execute(context);
					break;
				case "ScriptAccountAddressDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptAccountAddressDeleted";
					result = ScriptAccountAddressDeleted.Execute(context, ScriptAccountAddressDeletedExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "AccountAddressSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AccountAddressSavingStartMessage";
					result = AccountAddressSavingStartMessage.Execute(context);
					break;
				case "ScriptTaskAccountAddressSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskAccountAddressSaving";
					result = ScriptTaskAccountAddressSaving.Execute(context, ScriptTaskAccountAddressSavingExecute);
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
				case "AddressSynchronizer":
					AddressSynchronizer = reader.GetSerializableObjectValue();
				break;
				case "ClearPrimaryAddress":
					ClearPrimaryAddress = reader.GetValue<System.Boolean>();
				break;
				case "DeleteAccountId":
					DeleteAccountId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SynchronizeAccountScriptExecute(ProcessExecutingContext context) {
			var isPrimaryAddress = Entity.GetTypedColumnValue<bool>("Primary");
			if (isPrimaryAddress) {
				var synchronizer = GetAddressSynchronizer();
				synchronizer.ResetPrimaryColumn();
				synchronizer.SyncAddressWithMasterEntity();
			}
			return true;
		}

		public virtual bool ScriptAccountAddressDeletedExecute(ProcessExecutingContext context) {
			var isPrimaryAddress = Entity.GetTypedColumnValue<bool>("Primary");
			if (isPrimaryAddress) {
				ClearAccountAddress();
				var synchronizer = GetAddressSynchronizer();
				synchronizer.SetPrimaryAddress();
			}
			return true;
		}

		public virtual bool ScriptTaskAccountAddressSavingExecute(ProcessExecutingContext context) {
			var oldPrimaryValue = Entity.GetTypedOldColumnValue<bool>("Primary");
			var isPrimaryAddress = Entity.GetTypedColumnValue<bool>("Primary");
			if (oldPrimaryValue && !isPrimaryAddress) {
				ClearAccountAddress();
				return true;
			}
			if (isPrimaryAddress) {
				return true;
			}
			var synchronizer = GetAddressSynchronizer();
			var primaryCount = synchronizer.GetAddressesCount();
			if (primaryCount == 0) {
				Entity.SetColumnValue("Primary", true);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AccountAddressSaved":
							if (ActivatedEventElements.Contains("AccountAddressSaved")) {
							context.QueueTasks.Enqueue("AccountAddressSaved");
						}
						break;
					case "AccountAddressDeleted":
							if (ActivatedEventElements.Contains("AccountAddressDeleted")) {
							context.QueueTasks.Enqueue("AccountAddressDeleted");
						}
						break;
					case "AccountAddressSaving":
							if (ActivatedEventElements.Contains("AccountAddressSavingStartMessage")) {
							context.QueueTasks.Enqueue("AccountAddressSavingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (AddressSynchronizer != null) {
				if (AddressSynchronizer.GetType().IsSerializable ||
					AddressSynchronizer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("AddressSynchronizer", AddressSynchronizer, null);
				}
			}
			if (!HasMapping("ClearPrimaryAddress") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ClearPrimaryAddress", ClearPrimaryAddress, false);
			}
			if (!HasMapping("DeleteAccountId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DeleteAccountId", DeleteAccountId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AccountAddress_BaseEventsProcess

	/// <exclude/>
	public class AccountAddress_BaseEventsProcess : AccountAddress_BaseEventsProcess<AccountAddress>
	{

		public AccountAddress_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountAddressEventsProcessSchema

	/// <exclude/>
	public class AccountAddressEventsProcessSchema : Terrasoft.Configuration.BaseAddressEventsProcessSchema
	{

		#region Constructors: Public

		public AccountAddressEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AccountAddressEventsProcessSchema(AccountAddressEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AccountAddress_BaseEventsProcess";
			UId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de");
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

		protected virtual ProcessSchemaParameter CreateDeleteAccountIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2c7a1b71-8101-4e53-bc69-867502e3b1aa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"DeleteAccountId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateClearPrimaryAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1e5f96d6-c987-4281-a52b-c411a3bf0a24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"ClearPrimaryAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddressSynchronizerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("66ff7be2-91c2-4c0d-a94c-d3842a35ed25"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"AddressSynchronizer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDeleteAccountIdParameter());
			Parameters.Add(CreateClearPrimaryAddressParameter());
			Parameters.Add(CreateAddressSynchronizerParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet757 = CreateLaneSet757LaneSet();
			LaneSets.Add(schemaLaneSet757);
			ProcessSchemaLane schemaLane2765 = CreateLane2765Lane();
			schemaLaneSet757.Lanes.Add(schemaLane2765);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaStartMessageEvent accountaddresssaved = CreateAccountAddressSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(accountaddresssaved);
			ProcessSchemaScriptTask synchronizeaccountscript = CreateSynchronizeAccountScriptScriptTask();
			eventsubprocess1.FlowElements.Add(synchronizeaccountscript);
			ProcessSchemaStartMessageEvent accountaddressdeleted = CreateAccountAddressDeletedStartMessageEvent();
			subprocess1.FlowElements.Add(accountaddressdeleted);
			ProcessSchemaScriptTask scriptaccountaddressdeleted = CreateScriptAccountAddressDeletedScriptTask();
			subprocess1.FlowElements.Add(scriptaccountaddressdeleted);
			ProcessSchemaStartMessageEvent accountaddresssavingstartmessage = CreateAccountAddressSavingStartMessageStartMessageEvent();
			subprocess2.FlowElements.Add(accountaddresssavingstartmessage);
			ProcessSchemaScriptTask scripttaskaccountaddresssaving = CreateScriptTaskAccountAddressSavingScriptTask();
			subprocess2.FlowElements.Add(scripttaskaccountaddresssaving);
			FlowElements.Add(CreateSequenceFlow16344SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16346SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16348SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16344SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16344",
				UId = new Guid("797ebd2c-c04b-4b09-a6e0-a0fc00d4bd0e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				CurveCenterPosition = new Point(194, 138),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b6d4a672-5f08-41e2-bb93-959affdb2cea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d3df735-15b5-4a36-80e6-d1ba51215caf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16346SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16346",
				UId = new Guid("558e5a18-0c60-4f91-b724-0556eac43c11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				CurveCenterPosition = new Point(198, 330),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6ebb6a7a-e512-46c0-a56f-6709c6d1431e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e1ebe14f-d153-44a3-b934-fd70d25280da"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16348SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16348",
				UId = new Guid("fbaef01f-e7ff-4091-8381-8ca8f15cb2c8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				CurveCenterPosition = new Point(202, 510),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55a21698-24e0-4c0b-829e-4ccc55841834"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e52bbc5c-3f9d-4d7d-ac9f-6b4f614a4ef5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet757LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet757 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("892dc35b-5db2-4b72-8852-4aef0e842e3b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"LaneSet757",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet757;
		}

		protected virtual ProcessSchemaLane CreateLane2765Lane() {
			ProcessSchemaLane schemaLane2765 = new ProcessSchemaLane(this) {
				UId = new Guid("81b566da-143a-4ea8-87f6-5d4b06d17b53"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("892dc35b-5db2-4b72-8852-4aef0e842e3b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"Lane2765",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane2765;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7e58b355-af7a-4fd4-88dd-7b7e922910ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("81b566da-143a-4ea8-87f6-5d4b06d17b53"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 49),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(301, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountAddressSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b6d4a672-5f08-41e2-bb93-959affdb2cea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e58b355-af7a-4fd4-88dd-7b7e922910ff"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AccountAddressSaved",
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"AccountAddressSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 68),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSynchronizeAccountScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6d3df735-15b5-4a36-80e6-d1ba51215caf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e58b355-af7a-4fd4-88dd-7b7e922910ff"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"SynchronizeAccountScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(182, 54),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,206,177,10,194,48,16,198,241,185,129,190,67,232,148,46,125,129,170,32,34,157,4,81,209,57,218,147,6,210,68,46,151,66,20,223,221,212,102,40,226,124,255,251,241,13,18,185,114,123,84,189,196,176,110,91,4,231,248,146,111,13,41,10,85,3,116,10,15,104,55,86,251,222,156,165,246,176,184,90,171,87,162,72,47,69,89,231,76,221,185,248,69,74,254,202,89,54,68,222,5,115,235,208,26,245,4,140,116,52,83,114,156,29,196,232,100,243,180,58,128,3,74,232,52,224,79,52,26,137,187,40,234,118,210,17,224,180,254,91,191,115,134,64,30,13,39,244,80,127,0,45,146,144,143,239,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("137d37d3-0ca9-4beb-b64b-899a7979bb0a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("81b566da-143a-4ea8-87f6-5d4b06d17b53"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"SubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 238),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(303, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountAddressDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6ebb6a7a-e512-46c0-a56f-6709c6d1431e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("137d37d3-0ca9-4beb-b64b-899a7979bb0a"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountAddressDeleted",
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"AccountAddressDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptAccountAddressDeletedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e1ebe14f-d153-44a3-b934-fd70d25280da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("137d37d3-0ca9-4beb-b64b-899a7979bb0a"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"ScriptAccountAddressDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(190, 58),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,203,10,194,48,20,68,215,13,244,31,66,87,233,166,63,224,3,74,17,183,66,197,125,76,174,24,72,19,185,185,41,68,241,223,141,154,69,117,59,115,102,206,44,145,155,112,64,51,73,76,189,214,8,33,240,13,223,57,50,148,186,61,208,49,221,64,15,222,198,201,157,164,141,176,62,123,111,183,162,41,147,166,93,213,204,92,184,248,63,105,249,163,102,213,96,65,98,175,148,143,142,74,33,222,139,106,206,222,144,156,186,162,119,230,14,152,157,89,86,144,113,81,124,241,37,218,141,64,191,174,15,243,172,25,2,69,116,156,48,66,14,94,107,200,180,123,219,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("19c0109c-ae58-4785-abb6-bb64173505bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("81b566da-143a-4ea8-87f6-5d4b06d17b53"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"SubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 427),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(297, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAccountAddressSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("55a21698-24e0-4c0b-829e-4ccc55841834"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19c0109c-ae58-4785-abb6-bb64173505bf"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AccountAddressSaving",
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"AccountAddressSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskAccountAddressSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e52bbc5c-3f9d-4d7d-ac9f-6b4f614a4ef5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("19c0109c-ae58-4785-abb6-bb64173505bf"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				Name = @"ScriptTaskAccountAddressSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(182, 44),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,203,10,194,48,16,69,215,21,250,15,177,139,146,130,136,123,173,80,138,184,84,80,220,215,102,196,64,154,200,36,17,170,248,239,166,109,164,245,1,46,147,153,123,56,119,174,5,18,37,216,22,121,85,96,125,40,132,5,146,146,149,52,220,212,211,53,152,125,125,1,182,17,44,87,194,86,178,157,47,142,74,137,37,141,124,38,74,230,225,232,234,48,92,251,159,140,49,4,173,191,57,127,32,252,68,232,167,75,28,147,241,39,56,33,247,112,20,228,2,10,204,202,82,89,105,252,128,54,148,0,193,88,148,196,160,5,247,124,116,220,223,140,175,213,166,135,174,101,121,70,37,249,13,208,117,112,242,62,179,27,12,232,171,245,165,195,230,141,134,219,30,134,167,125,20,116,187,64,95,53,223,83,41,153,117,62,254,94,59,48,131,83,245,71,154,180,166,73,167,58,116,127,2,208,1,125,30,198,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearAccountAddressMethod());
			Methods.Add(CreateGetAddressSynchronizerMethod());
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

		protected virtual SchemaMethod CreateClearAccountAddressMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("488a4d66-871c-4367-b133-b2dc6fd7a746"),
				Name = "ClearAccountAddress",
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				CreatedInPackageId = new Guid("e63e45b4-0bf6-4e6f-9a89-2f7851e26fd2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,174,204,75,206,40,202,207,203,172,74,45,82,176,85,112,79,45,113,76,73,41,74,45,46,14,70,146,208,208,180,230,229,66,86,169,231,156,147,154,88,228,155,88,92,146,90,228,154,87,146,89,82,9,213,5,84,9,0,4,111,146,169,86,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAddressSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bf645f7e-c553-43da-9c59-b997595c4e1c"),
				Name = "GetAddressSynchronizer",
				CreatedInSchemaUId = new Guid("7c445852-6a4c-43de-9763-ad457fa759de"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "BaseAddressSynchronizer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,81,10,194,48,16,68,191,155,83,44,253,74,160,120,129,170,37,22,245,0,226,1,66,186,104,65,55,176,187,65,226,233,173,244,75,8,254,13,51,60,102,198,79,19,163,200,165,80,188,115,162,249,141,12,59,240,21,119,24,192,52,227,35,136,156,66,212,196,101,115,70,221,250,24,83,38,173,0,123,107,154,134,240,5,99,34,81,206,95,198,243,45,63,145,212,182,89,144,151,128,48,234,156,168,237,224,250,99,184,14,254,209,97,173,59,146,206,90,22,120,21,206,245,134,81,51,19,216,67,16,172,140,114,181,107,253,7,155,34,29,207,5,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountAddressEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c445852-6a4c-43de-9763-ad457fa759de"));
		}

		#endregion

	}

	#endregion


	#region Class: AccountAddressEventsProcess

	/// <exclude/>
	public class AccountAddressEventsProcess : AccountAddress_BaseEventsProcess
	{

		public AccountAddressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

