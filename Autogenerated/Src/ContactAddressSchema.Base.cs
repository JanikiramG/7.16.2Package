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

	#region Class: ContactAddress_Base_TerrasoftSchema

	/// <exclude/>
	public class ContactAddress_Base_TerrasoftSchema : Terrasoft.Configuration.BaseAddressSchema
	{

		#region Constructors: Public

		public ContactAddress_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactAddress_Base_TerrasoftSchema(ContactAddress_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactAddress_Base_TerrasoftSchema(ContactAddress_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			RealUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			Name = "ContactAddress_Base_Terrasoft";
			ParentSchemaUId = new Guid("400e8687-9616-480d-9d81-61de0235cc86");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeMasterRecordColumn() {
			base.InitializeMasterRecordColumn();
			MasterRecordColumn = CreateContactColumn();
			if (Columns.FindByUId(MasterRecordColumn.UId) == null) {
				Columns.Add(MasterRecordColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressTypeColumn() {
			EntitySchemaColumn column = base.CreateAddressTypeColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected override EntitySchemaColumn CreateCountryColumn() {
			EntitySchemaColumn column = base.CreateCountryColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected override EntitySchemaColumn CreateRegionColumn() {
			EntitySchemaColumn column = base.CreateRegionColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected override EntitySchemaColumn CreateCityColumn() {
			EntitySchemaColumn column = base.CreateCityColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected override EntitySchemaColumn CreateZipColumn() {
			EntitySchemaColumn column = base.CreateZipColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryColumn() {
			EntitySchemaColumn column = base.CreatePrimaryColumn();
			column.ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("16093858-afb1-4336-b8bc-52159ff08af5"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56"),
				ModifiedInSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactAddress_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactAddress_Base_TerrasoftEventsProcessSchema() {
			var schema = new ContactAddress_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactAddress_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactAddress_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactAddress_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactAddress_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_Base_Terrasoft

	/// <summary>
	/// Contact address.
	/// </summary>
	public class ContactAddress_Base_Terrasoft : Terrasoft.Configuration.BaseAddress
	{

		#region Constructors: Public

		public ContactAddress_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactAddress_Base_Terrasoft";
		}

		public ContactAddress_Base_Terrasoft(ContactAddress_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactAddress_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactAddress_Base_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("ContactAddress_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactAddress_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactAddress_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactAddress_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ContactAddress_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactAddress_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_BaseEventsProcess

	/// <exclude/>
	public partial class ContactAddress_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseAddress_BaseEventsProcess<TEntity> where TEntity : ContactAddress_Base_Terrasoft
	{

		public ContactAddress_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactAddress_BaseEventsProcess";
			SchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool ClearPrimaryAddress {
			get;
			set;
		}

		public virtual Object AddressSynchronizer {
			get;
			set;
		}

		private ProcessFlowElement _handleContactAddressSavedSubProcess;
		public ProcessFlowElement HandleContactAddressSavedSubProcess {
			get {
				return _handleContactAddressSavedSubProcess ?? (_handleContactAddressSavedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "HandleContactAddressSavedSubProcess",
					SchemaElementUId = new Guid("442c3f31-e1a0-4ebd-a8b7-6c9b7cddcb6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactAddressSaved;
		public ProcessFlowElement ContactAddressSaved {
			get {
				return _contactAddressSaved ?? (_contactAddressSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactAddressSaved",
					SchemaElementUId = new Guid("bd27a1e6-bdf8-43cf-bae0-e4b67698ccde"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSynchronizeContact;
		public ProcessScriptTask ScriptSynchronizeContact {
			get {
				return _scriptSynchronizeContact ?? (_scriptSynchronizeContact = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSynchronizeContact",
					SchemaElementUId = new Guid("0e66c772-dfd1-4c6b-8467-79cc6e1cab48"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSynchronizeContactExecute,
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
					SchemaElementUId = new Guid("edd13844-fbc8-4d33-88fe-17d5925925f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactAddressDeleted;
		public ProcessFlowElement ContactAddressDeleted {
			get {
				return _contactAddressDeleted ?? (_contactAddressDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactAddressDeleted",
					SchemaElementUId = new Guid("05da27de-2069-425b-9552-a44b939d671b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _contactAddressDeletedScriptTask;
		public ProcessScriptTask ContactAddressDeletedScriptTask {
			get {
				return _contactAddressDeletedScriptTask ?? (_contactAddressDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ContactAddressDeletedScriptTask",
					SchemaElementUId = new Guid("8ceb2f63-12d2-4363-b8ff-c0c183ef46fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ContactAddressDeletedScriptTaskExecute,
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
					SchemaElementUId = new Guid("43f473b4-92df-49af-8392-6edf4f81bcea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskClearPrimaryAccount;
		public ProcessScriptTask ScriptTaskClearPrimaryAccount {
			get {
				return _scriptTaskClearPrimaryAccount ?? (_scriptTaskClearPrimaryAccount = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskClearPrimaryAccount",
					SchemaElementUId = new Guid("26715bd0-560d-42a0-9cfa-89d84ca900a6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskClearPrimaryAccountExecute,
				});
			}
		}

		private ProcessFlowElement _contactAddressSavingStartMessage;
		public ProcessFlowElement ContactAddressSavingStartMessage {
			get {
				return _contactAddressSavingStartMessage ?? (_contactAddressSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactAddressSavingStartMessage",
					SchemaElementUId = new Guid("35d5d675-8fe3-44fd-8cfc-092e6719c52d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[HandleContactAddressSavedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { HandleContactAddressSavedSubProcess };
			FlowElements[ContactAddressSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAddressSaved };
			FlowElements[ScriptSynchronizeContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSynchronizeContact };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[ContactAddressDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAddressDeleted };
			FlowElements[ContactAddressDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAddressDeletedScriptTask };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[ScriptTaskClearPrimaryAccount.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskClearPrimaryAccount };
			FlowElements[ContactAddressSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAddressSavingStartMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "HandleContactAddressSavedSubProcess":
						break;
					case "ContactAddressSaved":
						e.Context.QueueTasks.Enqueue("ScriptSynchronizeContact");
						break;
					case "ScriptSynchronizeContact":
						break;
					case "SubProcess1":
						break;
					case "ContactAddressDeleted":
						e.Context.QueueTasks.Enqueue("ContactAddressDeletedScriptTask");
						break;
					case "ContactAddressDeletedScriptTask":
						break;
					case "SubProcess2":
						break;
					case "ScriptTaskClearPrimaryAccount":
						break;
					case "ContactAddressSavingStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTaskClearPrimaryAccount");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ContactAddressSaved");
			ActivatedEventElements.Add("ContactAddressDeleted");
			ActivatedEventElements.Add("ContactAddressSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "HandleContactAddressSavedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ContactAddressSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAddressSaved";
					result = ContactAddressSaved.Execute(context);
					break;
				case "ScriptSynchronizeContact":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSynchronizeContact";
					result = ScriptSynchronizeContact.Execute(context, ScriptSynchronizeContactExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ContactAddressDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAddressDeleted";
					result = ContactAddressDeleted.Execute(context);
					break;
				case "ContactAddressDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAddressDeletedScriptTask";
					result = ContactAddressDeletedScriptTask.Execute(context, ContactAddressDeletedScriptTaskExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTaskClearPrimaryAccount":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskClearPrimaryAccount";
					result = ScriptTaskClearPrimaryAccount.Execute(context, ScriptTaskClearPrimaryAccountExecute);
					break;
				case "ContactAddressSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAddressSavingStartMessage";
					result = ContactAddressSavingStartMessage.Execute(context);
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
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptSynchronizeContactExecute(ProcessExecutingContext context) {
			SynchronizeContact();
			return true;
		}

		public virtual bool ContactAddressDeletedScriptTaskExecute(ProcessExecutingContext context) {
			OnContactAddressDeleted();
			return true;
		}

		public virtual bool ScriptTaskClearPrimaryAccountExecute(ProcessExecutingContext context) {
			var oldPrimaryValue = Entity.GetTypedOldColumnValue<bool>("Primary");
			var isPrimaryAddress = Entity.GetTypedColumnValue<bool>("Primary");
			if (oldPrimaryValue && !isPrimaryAddress) {
				ClearContactAddress();
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
					case "ContactAddress_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("ContactAddressSaved")) {
							context.QueueTasks.Enqueue("ContactAddressSaved");
						}
						break;
					case "ContactAddress_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("ContactAddressDeleted")) {
							context.QueueTasks.Enqueue("ContactAddressDeleted");
						}
						break;
					case "ContactAddress_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("ContactAddressSavingStartMessage")) {
							context.QueueTasks.Enqueue("ContactAddressSavingStartMessage");
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_BaseEventsProcess

	/// <exclude/>
	public class ContactAddress_BaseEventsProcess : ContactAddress_BaseEventsProcess<ContactAddress_Base_Terrasoft>
	{

		public ContactAddress_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactAddress_BaseEventsProcess

	public partial class ContactAddress_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ClearContactAddress() {
			var synchronizer = GetAddressSynchronizer();
			synchronizer.ClearMasterEntityAddress();
		}

		public virtual void SynchronizeContact() {
			var isPrimaryAddress = Entity.GetTypedColumnValue<bool>("Primary");
			if (isPrimaryAddress) {
				var synchronizer = GetAddressSynchronizer();
				synchronizer.ResetPrimaryColumn();
				synchronizer.SyncAddressWithMasterEntity();
			}
		}

		public virtual void OnContactAddressDeleted() {
			var isPrimaryAddress = Entity.GetTypedColumnValue<bool>("Primary");
			if (isPrimaryAddress) {
				ClearContactAddress();
				var synchronizer = GetAddressSynchronizer();
				synchronizer.SetPrimaryAddress();
			}
		}

		public virtual BaseAddressSynchronizer GetAddressSynchronizer() {
			AddressSynchronizer = AddressSynchronizer ?? 
				ClassFactory.Get<BaseAddressSynchronizer>(
					new ConstructorArgument("userConnection", UserConnection), new ConstructorArgument("addressEntity", Entity),
					new ConstructorArgument("masterEntityName", "Contact"));
			return (BaseAddressSynchronizer) AddressSynchronizer;
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class ContactAddress_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseAddressEventsProcessSchema
	{

		#region Constructors: Public

		public ContactAddress_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactAddress_Base_TerrasoftEventsProcessSchema(ContactAddress_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactAddress_BaseEventsProcess";
			UId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8");
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

		protected virtual ProcessSchemaParameter CreateClearPrimaryAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e8934f1a-e448-400f-a4f3-e78aab6d953b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"ClearPrimaryAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateAddressSynchronizerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fa841e42-9a6e-405c-adea-ed0d4a316aa0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"AddressSynchronizer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateClearPrimaryAddressParameter());
			Parameters.Add(CreateAddressSynchronizerParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet756 = CreateLaneSet756LaneSet();
			LaneSets.Add(schemaLaneSet756);
			ProcessSchemaLane schemaLane2764 = CreateLane2764Lane();
			schemaLaneSet756.Lanes.Add(schemaLane2764);
			ProcessSchemaEventSubProcess handlecontactaddresssavedsubprocess = CreateHandleContactAddressSavedSubProcessEventSubProcess();
			FlowElements.Add(handlecontactaddresssavedsubprocess);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaStartMessageEvent contactaddresssaved = CreateContactAddressSavedStartMessageEvent();
			handlecontactaddresssavedsubprocess.FlowElements.Add(contactaddresssaved);
			ProcessSchemaScriptTask scriptsynchronizecontact = CreateScriptSynchronizeContactScriptTask();
			handlecontactaddresssavedsubprocess.FlowElements.Add(scriptsynchronizecontact);
			ProcessSchemaStartMessageEvent contactaddressdeleted = CreateContactAddressDeletedStartMessageEvent();
			subprocess1.FlowElements.Add(contactaddressdeleted);
			ProcessSchemaScriptTask contactaddressdeletedscripttask = CreateContactAddressDeletedScriptTaskScriptTask();
			subprocess1.FlowElements.Add(contactaddressdeletedscripttask);
			ProcessSchemaScriptTask scripttaskclearprimaryaccount = CreateScriptTaskClearPrimaryAccountScriptTask();
			subprocess2.FlowElements.Add(scripttaskclearprimaryaccount);
			ProcessSchemaStartMessageEvent contactaddresssavingstartmessage = CreateContactAddressSavingStartMessageStartMessageEvent();
			subprocess2.FlowElements.Add(contactaddresssavingstartmessage);
			FlowElements.Add(CreateSequenceFlow16339SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16341SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16343SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16339SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16339",
				UId = new Guid("89ed8df3-15f9-419f-98b9-68342f4e833b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				CurveCenterPosition = new Point(194, 112),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bd27a1e6-bdf8-43cf-bae0-e4b67698ccde"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0e66c772-dfd1-4c6b-8467-79cc6e1cab48"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16341SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16341",
				UId = new Guid("4a000bab-a7d9-4311-9f86-4724d14854ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				CurveCenterPosition = new Point(182, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("05da27de-2069-425b-9552-a44b939d671b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8ceb2f63-12d2-4363-b8ff-c0c183ef46fb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16343SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16343",
				UId = new Guid("2c5a82d3-8980-4e42-9217-6d6f54e6e2aa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				CurveCenterPosition = new Point(190, 460),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("35d5d675-8fe3-44fd-8cfc-092e6719c52d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("26715bd0-560d-42a0-9cfa-89d84ca900a6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet756LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet756 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b98660fc-6990-4ebd-afbb-fe5b3fe00f22"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"LaneSet756",
				Position = new Point(5, 5),
				Size = new Size(1050, 543),
				UseBackgroundMode = false
			};
			return schemaLaneSet756;
		}

		protected virtual ProcessSchemaLane CreateLane2764Lane() {
			ProcessSchemaLane schemaLane2764 = new ProcessSchemaLane(this) {
				UId = new Guid("7f1efd8f-8674-48ef-99c2-1c2c24ba7223"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b98660fc-6990-4ebd-afbb-fe5b3fe00f22"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"Lane2764",
				Position = new Point(29, 0),
				Size = new Size(1021, 543),
				UseBackgroundMode = false
			};
			return schemaLane2764;
		}

		protected virtual ProcessSchemaEventSubProcess CreateHandleContactAddressSavedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaHandleContactAddressSavedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("442c3f31-e1a0-4ebd-a8b7-6c9b7cddcb6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f1efd8f-8674-48ef-99c2-1c2c24ba7223"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"HandleContactAddressSavedSubProcess",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(240, 169),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaHandleContactAddressSavedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactAddressSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bd27a1e6-bdf8-43cf-bae0-e4b67698ccde"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("442c3f31-e1a0-4ebd-a8b7-6c9b7cddcb6e"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ContactAddressSaved",
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"ContactAddressSaved",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSynchronizeContactScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0e66c772-dfd1-4c6b-8467-79cc6e1cab48"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("442c3f31-e1a0-4ebd-a8b7-6c9b7cddcb6e"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"ScriptSynchronizeContact",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,206,207,43,73,76,46,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,226,122,64,65,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("edd13844-fbc8-4d33-88fe-17d5925925f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f1efd8f-8674-48ef-99c2-1c2c24ba7223"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"SubProcess1",
				Position = new Point(35, 210),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(233, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactAddressDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("05da27de-2069-425b-9552-a44b939d671b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edd13844-fbc8-4d33-88fe-17d5925925f7"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactAddressDeleted",
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"ContactAddressDeleted",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateContactAddressDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8ceb2f63-12d2-4363-b8ff-c0c183ef46fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("edd13844-fbc8-4d33-88fe-17d5925925f7"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"ContactAddressDeletedScriptTask",
				Position = new Point(120, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,206,207,43,73,76,46,113,76,73,41,74,45,46,118,73,205,73,45,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,5,242,0,50,220,119,10,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("43f473b4-92df-49af-8392-6edf4f81bcea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7f1efd8f-8674-48ef-99c2-1c2c24ba7223"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"SubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 371),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskClearPrimaryAccountScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("26715bd0-560d-42a0-9cfa-89d84ca900a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43f473b4-92df-49af-8392-6edf4f81bcea"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"ScriptTaskClearPrimaryAccount",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,75,11,194,48,16,132,207,10,254,135,216,131,164,32,226,221,7,72,17,143,10,138,247,104,86,12,196,68,54,27,161,138,255,221,180,77,105,125,128,199,100,103,62,102,230,38,144,89,45,55,168,46,2,243,189,208,30,216,140,45,13,41,202,71,43,160,93,126,5,185,214,50,179,218,95,76,121,159,30,172,213,115,158,68,79,146,78,122,221,91,192,40,23,127,22,82,34,56,247,205,249,3,81,39,198,63,179,12,6,172,255,9,78,217,163,215,237,100,26,4,102,214,144,56,82,60,240,130,210,65,32,143,134,17,122,8,207,103,197,253,205,248,146,22,61,92,110,142,103,180,70,221,1,67,135,16,62,122,182,173,3,175,91,95,43,108,102,189,161,160,110,155,71,141,21,92,41,224,117,205,119,215,140,141,171,60,113,175,45,80,107,170,102,164,97,153,52,173,162,182,179,191,0,22,164,100,210,198,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactAddressSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("35d5d675-8fe3-44fd-8cfc-092e6719c52d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43f473b4-92df-49af-8392-6edf4f81bcea"),
				CreatedInOwnerSchemaUId = new Guid("6222325b-27a4-483d-9370-3a163a6aa65a"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactAddressSaving",
				ModifiedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				Name = @"ContactAddressSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearContactAddressMethod());
			Methods.Add(CreateSynchronizeContactMethod());
			Methods.Add(CreateOnContactAddressDeletedMethod());
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

		protected virtual SchemaMethod CreateClearContactAddressMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("24aa5c87-60c0-4525-83d3-2cd7403ca63a"),
				Name = "ClearContactAddress",
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				CreatedInPackageId = new Guid("88ca8859-5a70-4347-94ce-f17e86447db4"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,174,204,75,206,40,202,207,203,172,74,45,82,176,85,112,79,45,113,76,73,41,74,45,46,14,70,146,208,208,180,230,229,66,86,169,231,156,147,154,88,228,155,88,92,146,90,228,154,87,146,89,82,9,213,5,84,9,0,4,111,146,169,86,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeContactMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0c473b24-be60-4c62-bc82-cdcc510e7c0d"),
				Name = "SynchronizeContact",
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				CreatedInPackageId = new Guid("f2b2bf98-7d51-4b6d-9e0b-dcf9524e962a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,44,14,40,202,204,77,44,170,116,76,73,41,74,45,46,86,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,73,202,207,207,177,211,80,130,106,81,210,180,230,229,202,76,83,208,64,55,68,83,161,154,151,139,179,12,104,124,113,101,94,114,70,81,126,94,102,85,106,17,208,104,160,153,80,37,193,72,18,26,32,115,56,145,149,234,5,165,22,167,150,64,13,133,56,0,139,34,144,25,80,227,194,51,75,50,124,19,139,75,82,139,32,174,7,171,174,5,0,100,166,191,91,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnContactAddressDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0104a505-a5c7-4e56-b21a-d0eff04ec7e3"),
				Name = "OnContactAddressDeleted",
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				CreatedInPackageId = new Guid("f2b2bf98-7d51-4b6d-9e0b-dcf9524e962a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,44,14,40,202,204,77,44,170,116,76,73,41,74,45,46,86,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,73,202,207,207,177,211,80,130,106,81,210,180,230,202,76,83,208,64,55,67,83,161,154,139,211,57,39,53,177,200,57,63,175,36,49,185,4,42,174,1,84,207,89,6,180,180,184,50,47,57,163,40,63,47,179,42,181,8,104,33,208,38,168,138,96,36,9,176,106,100,149,122,193,169,37,168,22,129,148,212,2,0,58,117,9,156,198,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAddressSynchronizerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cbe67bdb-4e19-40ad-8bc9-e34c5ecde05d"),
				Name = "GetAddressSynchronizer",
				CreatedInSchemaUId = new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "BaseAddressSynchronizer"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,10,194,64,12,68,207,219,175,8,123,234,66,241,7,170,150,90,212,155,23,241,3,150,54,232,130,205,66,146,69,234,215,187,210,147,208,122,11,147,121,12,51,237,48,48,138,92,39,234,31,28,41,188,145,97,7,237,130,218,52,80,152,238,233,69,78,190,215,200,211,230,140,186,61,120,193,5,247,190,44,140,33,124,65,23,73,148,211,23,104,249,158,70,36,45,109,18,228,252,32,236,53,68,178,21,220,126,4,87,193,42,234,231,172,35,105,208,41,147,243,225,170,127,113,163,23,69,158,157,23,63,98,198,108,54,106,174,97,157,171,11,70,77,76,80,174,116,113,75,115,212,31,54,125,228,50,57,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactAddress_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d56ae4d6-efc0-4cc4-849b-2742e97337a8"));
		}

		#endregion

	}

	#endregion

}

