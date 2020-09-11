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

	#region Class: ContactCommunication_Base_TerrasoftSchema

	/// <exclude/>
	public class ContactCommunication_Base_TerrasoftSchema : Terrasoft.Configuration.BaseCommunicationSchema
	{

		#region Constructors: Public

		public ContactCommunication_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactCommunication_Base_TerrasoftSchema(ContactCommunication_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactCommunication_Base_TerrasoftSchema(ContactCommunication_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			RealUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			Name = "ContactCommunication_Base_Terrasoft";
			ParentSchemaUId = new Guid("33245659-4fea-425d-b591-9ed4bdeacaf5");
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
			if (Columns.FindByUId(new Guid("c93fe4de-6262-4a06-bd20-df27c2b7982c")) == null) {
				Columns.Add(CreateIsCreatedBySynchronizationColumn());
			}
			if (Columns.FindByUId(new Guid("31c70950-bdc3-4d5d-86fe-0cce719c84dc")) == null) {
				Columns.Add(CreateExternalCommunicationTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			return column;
		}

		protected override EntitySchemaColumn CreateSearchNumberColumn() {
			EntitySchemaColumn column = base.CreateSearchNumberColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("MediumText");
			column.ModifiedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cf226458-c1c0-4d0c-afe5-41664f2d570e"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41"),
				ModifiedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCreatedBySynchronizationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c93fe4de-6262-4a06-bd20-df27c2b7982c"),
				Name = @"IsCreatedBySynchronization",
				CreatedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41"),
				ModifiedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateExternalCommunicationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("31c70950-bdc3-4d5d-86fe-0cce719c84dc"),
				Name = @"ExternalCommunicationType",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41"),
				ModifiedInSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactCommunication_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactCommunication_Base_TerrasoftEventsProcessSchema() {
			var schema = new ContactCommunication_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactCommunication_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactCommunication_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactCommunication_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactCommunication_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_Base_Terrasoft

	/// <summary>
	/// Contact communication option.
	/// </summary>
	public class ContactCommunication_Base_Terrasoft : Terrasoft.Configuration.BaseCommunication
	{

		#region Constructors: Public

		public ContactCommunication_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactCommunication_Base_Terrasoft";
		}

		public ContactCommunication_Base_Terrasoft(ContactCommunication_Base_Terrasoft source)
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

		/// <summary>
		/// Created by synchronization.
		/// </summary>
		public bool IsCreatedBySynchronization {
			get {
				return GetTypedColumnValue<bool>("IsCreatedBySynchronization");
			}
			set {
				SetColumnValue("IsCreatedBySynchronization", value);
			}
		}

		/// <summary>
		/// Communication type in external resource.
		/// </summary>
		public string ExternalCommunicationType {
			get {
				return GetTypedColumnValue<string>("ExternalCommunicationType");
			}
			set {
				SetColumnValue("ExternalCommunicationType", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactCommunication_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactCommunication_Base_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("ContactCommunication_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactCommunication_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactCommunication_Base_TerrasoftSaving", e);
			Updating += (s, e) => ThrowEvent("ContactCommunication_Base_TerrasoftUpdating", e);
			Validating += (s, e) => ThrowEvent("ContactCommunication_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCommunication_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_BaseEventsProcess

	/// <exclude/>
	public partial class ContactCommunication_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCommunication_BaseEventsProcess<TEntity> where TEntity : ContactCommunication_Base_Terrasoft
	{

		public ContactCommunication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactCommunication_BaseEventsProcess";
			SchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
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
					SchemaElementUId = new Guid("e6515633-f307-4575-a468-9506113f07b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactCommunicationSaved;
		public ProcessFlowElement ContactCommunicationSaved {
			get {
				return _contactCommunicationSaved ?? (_contactCommunicationSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactCommunicationSaved",
					SchemaElementUId = new Guid("f886d715-d1fc-4a62-a4a2-6988c192cdaa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactCommunicationSaved;
		public ProcessScriptTask ScriptContactCommunicationSaved {
			get {
				return _scriptContactCommunicationSaved ?? (_scriptContactCommunicationSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactCommunicationSaved",
					SchemaElementUId = new Guid("000ae750-aea5-44b4-8339-81795bd840be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactCommunicationSavedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("f80e73a9-7634-453c-8e30-aa57dbf03366"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactCommunicationDeleted;
		public ProcessFlowElement ContactCommunicationDeleted {
			get {
				return _contactCommunicationDeleted ?? (_contactCommunicationDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactCommunicationDeleted",
					SchemaElementUId = new Guid("616c80f6-9658-4c86-8e5c-fa9d1054268e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactCommunicationDeleted;
		public ProcessScriptTask ScriptContactCommunicationDeleted {
			get {
				return _scriptContactCommunicationDeleted ?? (_scriptContactCommunicationDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactCommunicationDeleted",
					SchemaElementUId = new Guid("b3eb100d-00ab-43bf-8b71-1ba877178682"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactCommunicationDeletedExecute,
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
					SchemaElementUId = new Guid("cde71769-f95b-40c6-a70a-dd0bc670f691"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactCommunicationSavingStartMessage;
		public ProcessFlowElement ContactCommunicationSavingStartMessage {
			get {
				return _contactCommunicationSavingStartMessage ?? (_contactCommunicationSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactCommunicationSavingStartMessage",
					SchemaElementUId = new Guid("61a13bc5-6c00-4ff1-9bcd-e454a44231b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _contactCommunicationSavingScriptTask;
		public ProcessScriptTask ContactCommunicationSavingScriptTask {
			get {
				return _contactCommunicationSavingScriptTask ?? (_contactCommunicationSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ContactCommunicationSavingScriptTask",
					SchemaElementUId = new Guid("b72ffab2-963a-481c-826d-686a7090b4e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ContactCommunicationSavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4846;
		public ProcessFlowElement EventSubProcess4846 {
			get {
				return _eventSubProcess4846 ?? (_eventSubProcess4846 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4846",
					SchemaElementUId = new Guid("2de10518-9086-45b8-8a1a-70282e233518"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactCommunicationUpdating;
		public ProcessFlowElement ContactCommunicationUpdating {
			get {
				return _contactCommunicationUpdating ?? (_contactCommunicationUpdating = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactCommunicationUpdating",
					SchemaElementUId = new Guid("34608bf1-84ea-4f70-b303-c37d183b0ae0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactCommunicationUpdating;
		public ProcessScriptTask ScriptContactCommunicationUpdating {
			get {
				return _scriptContactCommunicationUpdating ?? (_scriptContactCommunicationUpdating = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactCommunicationUpdating",
					SchemaElementUId = new Guid("f01709d4-d644-49e2-b6b1-99bdb8f14240"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactCommunicationUpdatingExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ContactCommunicationSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactCommunicationSaved };
			FlowElements[ScriptContactCommunicationSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactCommunicationSaved };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[ContactCommunicationDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactCommunicationDeleted };
			FlowElements[ScriptContactCommunicationDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactCommunicationDeleted };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ContactCommunicationSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactCommunicationSavingStartMessage };
			FlowElements[ContactCommunicationSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactCommunicationSavingScriptTask };
			FlowElements[EventSubProcess4846.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4846 };
			FlowElements[ContactCommunicationUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactCommunicationUpdating };
			FlowElements[ScriptContactCommunicationUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactCommunicationUpdating };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ContactCommunicationSaved":
						e.Context.QueueTasks.Enqueue("ScriptContactCommunicationSaved");
						break;
					case "ScriptContactCommunicationSaved":
						break;
					case "EventSubProcess3":
						break;
					case "ContactCommunicationDeleted":
						e.Context.QueueTasks.Enqueue("ScriptContactCommunicationDeleted");
						break;
					case "ScriptContactCommunicationDeleted":
						break;
					case "EventSubProcess2":
						break;
					case "ContactCommunicationSavingStartMessage":
						e.Context.QueueTasks.Enqueue("ContactCommunicationSavingScriptTask");
						break;
					case "ContactCommunicationSavingScriptTask":
						break;
					case "EventSubProcess4846":
						break;
					case "ContactCommunicationUpdating":
						e.Context.QueueTasks.Enqueue("ScriptContactCommunicationUpdating");
						break;
					case "ScriptContactCommunicationUpdating":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ContactCommunicationSaved");
			ActivatedEventElements.Add("ContactCommunicationDeleted");
			ActivatedEventElements.Add("ContactCommunicationSavingStartMessage");
			ActivatedEventElements.Add("ContactCommunicationUpdating");
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
				case "ContactCommunicationSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactCommunicationSaved";
					result = ContactCommunicationSaved.Execute(context);
					break;
				case "ScriptContactCommunicationSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactCommunicationSaved";
					result = ScriptContactCommunicationSaved.Execute(context, ScriptContactCommunicationSavedExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "ContactCommunicationDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactCommunicationDeleted";
					result = ContactCommunicationDeleted.Execute(context);
					break;
				case "ScriptContactCommunicationDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactCommunicationDeleted";
					result = ScriptContactCommunicationDeleted.Execute(context, ScriptContactCommunicationDeletedExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ContactCommunicationSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactCommunicationSavingStartMessage";
					result = ContactCommunicationSavingStartMessage.Execute(context);
					break;
				case "ContactCommunicationSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactCommunicationSavingScriptTask";
					result = ContactCommunicationSavingScriptTask.Execute(context, ContactCommunicationSavingScriptTaskExecute);
					break;
				case "EventSubProcess4846":
					context.QueueTasks.Dequeue();
					break;
				case "ContactCommunicationUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactCommunicationUpdating";
					result = ContactCommunicationUpdating.Execute(context);
					break;
				case "ScriptContactCommunicationUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactCommunicationUpdating";
					result = ScriptContactCommunicationUpdating.Execute(context, ScriptContactCommunicationUpdatingExecute);
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

		public virtual bool ScriptContactCommunicationSavedExecute(ProcessExecutingContext context) {
			SetNewContactCommunication();
			RemoveDuplicates();
			return true;
		}

		public virtual bool ScriptContactCommunicationDeletedExecute(ProcessExecutingContext context) {
			OnContactCommunicationDeleted();
			return true;
		}

		public virtual bool ContactCommunicationSavingScriptTaskExecute(ProcessExecutingContext context) {
			OnContactCommunicationSaving();
			return true;
		}

		public virtual bool ScriptContactCommunicationUpdatingExecute(ProcessExecutingContext context) {
			ActualizeExternalCommunicationType();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ContactCommunication_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("ContactCommunicationSaved")) {
							context.QueueTasks.Enqueue("ContactCommunicationSaved");
						}
						break;
					case "ContactCommunication_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("ContactCommunicationDeleted")) {
							context.QueueTasks.Enqueue("ContactCommunicationDeleted");
						}
						break;
					case "ContactCommunication_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("ContactCommunicationSavingStartMessage")) {
							context.QueueTasks.Enqueue("ContactCommunicationSavingStartMessage");
						}
						break;
					case "ContactCommunication_Base_TerrasoftUpdating":
							if (ActivatedEventElements.Contains("ContactCommunicationUpdating")) {
							context.QueueTasks.Enqueue("ContactCommunicationUpdating");
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

	#region Class: ContactCommunication_BaseEventsProcess

	/// <exclude/>
	public class ContactCommunication_BaseEventsProcess : ContactCommunication_BaseEventsProcess<ContactCommunication_Base_Terrasoft>
	{

		public ContactCommunication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactCommunication_BaseEventsProcess

	public partial class ContactCommunication_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void SetNewContactCommunication() {
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			Dictionary<string, string> columnNames = GetColumnNameByCommunicationType(communicationTypeId);
			string typedColumnName = columnNames["TypeColumnName"];
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			UpdateCommunicationParentEntity("Contact", contactId, typedColumnName);
		}

		public virtual void ClearOldContactCommunication() {
			var oldCommunicationTypeId = Entity.GetTypedOldColumnValue<Guid>("CommunicationTypeId");
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			if (!oldCommunicationTypeId.Equals(Guid.Empty) && !oldCommunicationTypeId.Equals(communicationTypeId)) {
				ActualizePrimaryState();
				Entity.SetColumnValue("IsCreatedBySynchronization", true);
				var columnName = string.Empty;
				Dictionary<string, string> columnNames = GetColumnNameByCommunicationType(oldCommunicationTypeId);
				var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
				string typedColumnName = columnNames["TypeColumnName"];
				bool isCanEdit = GetCanEditColumn("Contact", typedColumnName);
				if (isCanEdit && !string.IsNullOrEmpty(typedColumnName)) {
					var update = new Update(UserConnection, "Contact")
					.Set(typedColumnName, Column.Const(string.Empty))
					.Where("Id").IsEqual(Column.Const(contactId));
					update.Execute();
				}
			}
		}

		public virtual void OnContactCommunicationDeleted() {
			Guid contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			string number = Entity.GetTypedColumnValue<string>("Number");
			Guid communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			bool isPrimary = Entity.GetTypedColumnValue<bool>("IsCreatedBySynchronization");
			Dictionary<string, string> columnNames = GetColumnNameByCommunicationType(communicationTypeId);
			var contactSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");
			var contactEntity = contactSchema.CreateEntity(UserConnection);
			string typedColumnName = columnNames["TypeColumnName"];
			string socialColumnName = columnNames["SocialColumnName"];
			bool isCanEdit = GetCanEditColumn("Contact", typedColumnName);
			if (contactEntity.FetchFromDB(contactId) && isPrimary) {
				if (isCanEdit && !string.IsNullOrEmpty(typedColumnName)) {
					string value = contactEntity.GetTypedColumnValue<string>(typedColumnName);
					if (value == number) {
						contactEntity.SetColumnValue(typedColumnName, string.Empty);
						if (!string.IsNullOrEmpty(socialColumnName)) {
							contactEntity.SetColumnValue(socialColumnName, string.Empty);
						}
					}
				}
				contactEntity.SetColumnValue("ModifiedOn", DateTime.UtcNow);
				contactEntity.Save();
			}
		}

		public virtual Dictionary<string, string> GetColumnNameByCommunicationType(Guid communicationType) {
			var values = new Dictionary<string, string>();
			values.Add("TypeColumnName", string.Empty);
			values.Add("SocialColumnName", string.Empty);
			switch (communicationType.ToString()) {
				case CommunicationTypeConsts.LinkedInId:
			 		values["TypeColumnName"] = "LinkedIn";
					values["SocialColumnName"] = "LinkedInId";
					break;
				case CommunicationTypeConsts.TwitterId:
					values["TypeColumnName"] = "Twitter";
					values["SocialColumnName"] = "TwitterId";
					break;
				case CommunicationTypeConsts.FacebookId:
					values["TypeColumnName"] = "Facebook";
					values["SocialColumnName"] = "FacebookId";
					break;
				case CommunicationTypeConsts.EmailId:
					values["TypeColumnName"] = "Email";
					break;
				case CommunicationTypeConsts.SkypeId:
			 		values["TypeColumnName"] = "Skype";
					break;
				case CommunicationTypeConsts.HomePhoneId:
					values["TypeColumnName"] = "HomePhone";
					break;
				case CommunicationTypeConsts.MobilePhoneId:
					values["TypeColumnName"] = "MobilePhone";
					break;
				case CommunicationTypeConsts.WorkPhoneId:
					values["TypeColumnName"] = "Phone";
					break;
			}
			return values;
		}

		public virtual void ActualizeExternalCommunicationType() {
			if (Entity.GetTypedOldColumnValue<Guid>("CommunicationTypeId") != Entity.GetTypedColumnValue<Guid>("CommunicationTypeId")) {
				Entity.SetColumnValue("ExternalCommunicationType", string.Empty);
			}
		}

		public virtual void OnContactCommunicationSaving() {
			IsNew = GetIsNew();
			if (IsNew) {
				ActualizePrimaryState();
				Entity.SetColumnValue("IsCreatedBySynchronization", true);
			} else {
				ClearOldContactCommunication();
			}
		}

		public virtual void ActualizePrimaryState() {
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			
			var update = new Update(UserConnection, "ContactCommunication")
				.Set("IsCreatedBySynchronization", Column.Parameter(false))
			.Where("ContactId").IsEqual(Column.Parameter(contactId))
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
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var number = Entity.GetTypedColumnValue<string>("Number");
			var id = Entity.GetTypedColumnValue<Guid>("Id");
			var del = new Delete(UserConnection).From("ContactCommunication")
				.Where("ContactId").IsEqual(Column.Parameter(contactId)).
				And("CommunicationTypeId").IsEqual(Column.Parameter(communicationTypeId)).
				And("Number").IsEqual(Column.Parameter(number)).
				And("Id").Not().IsEqual(Column.Parameter(id)) as Delete;
			del.Execute();
		}

		public override void SetCommunicationParentEntityColumns(Entity parentEntity) {
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			Dictionary<string, string> columnNames = GetColumnNameByCommunicationType(communicationTypeId);
			string typedColumnName = columnNames["TypeColumnName"];
			string socialColumnName = columnNames["SocialColumnName"];
			var socialColumnValue = Entity.GetTypedColumnValue<string>("SocialMediaId");
			var isPrimary = Entity.GetTypedColumnValue<bool>("IsCreatedBySynchronization");
			if (string.IsNullOrEmpty(typedColumnName) || !isPrimary) {
				return;
			}
			var number = Entity.GetTypedColumnValue<string>("Number");
			parentEntity.SetColumnValue(typedColumnName, number);
			if (!string.IsNullOrEmpty(socialColumnName)) {
				parentEntity.SetColumnValue(socialColumnName, socialColumnValue);
			}
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class ContactCommunication_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseCommunicationEventsProcessSchema
	{

		#region Constructors: Public

		public ContactCommunication_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactCommunication_Base_TerrasoftEventsProcessSchema(ContactCommunication_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactCommunication_BaseEventsProcess";
			UId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e");
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
			UId = new Guid("99377d37-5385-494b-ba98-a8fd87f6069a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"DeletedMain",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNewParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1566d203-d414-4c73-87f0-91ea2430ddc4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
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
			ProcessSchemaLaneSet schemaLaneSet774 = CreateLaneSet774LaneSet();
			LaneSets.Add(schemaLaneSet774);
			ProcessSchemaLane schemaLane2782 = CreateLane2782Lane();
			schemaLaneSet774.Lanes.Add(schemaLane2782);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess4846 = CreateEventSubProcess4846EventSubProcess();
			FlowElements.Add(eventsubprocess4846);
			ProcessSchemaStartMessageEvent contactcommunicationsaved = CreateContactCommunicationSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(contactcommunicationsaved);
			ProcessSchemaScriptTask scriptcontactcommunicationsaved = CreateScriptContactCommunicationSavedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptcontactcommunicationsaved);
			ProcessSchemaStartMessageEvent contactcommunicationdeleted = CreateContactCommunicationDeletedStartMessageEvent();
			eventsubprocess3.FlowElements.Add(contactcommunicationdeleted);
			ProcessSchemaScriptTask scriptcontactcommunicationdeleted = CreateScriptContactCommunicationDeletedScriptTask();
			eventsubprocess3.FlowElements.Add(scriptcontactcommunicationdeleted);
			ProcessSchemaStartMessageEvent contactcommunicationsavingstartmessage = CreateContactCommunicationSavingStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(contactcommunicationsavingstartmessage);
			ProcessSchemaScriptTask contactcommunicationsavingscripttask = CreateContactCommunicationSavingScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(contactcommunicationsavingscripttask);
			ProcessSchemaStartMessageEvent contactcommunicationupdating = CreateContactCommunicationUpdatingStartMessageEvent();
			eventsubprocess4846.FlowElements.Add(contactcommunicationupdating);
			ProcessSchemaScriptTask scriptcontactcommunicationupdating = CreateScriptContactCommunicationUpdatingScriptTask();
			eventsubprocess4846.FlowElements.Add(scriptcontactcommunicationupdating);
			FlowElements.Add(CreateSequenceFlow16367SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow398SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16367SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16367",
				UId = new Guid("16c65beb-61bb-4787-b063-707f3cccb9ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CurveCenterPosition = new Point(182, 218),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("616c80f6-9658-4c86-8e5c-fa9d1054268e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3eb100d-00ab-43bf-8b71-1ba877178682"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0d08c9fe-17a6-42c4-a391-7805a19561de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CurveCenterPosition = new Point(185, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f886d715-d1fc-4a62-a4a2-6988c192cdaa"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("000ae750-aea5-44b4-8339-81795bd840be"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("582f4ab7-be4a-44b5-bf69-efda3ef5e8df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CurveCenterPosition = new Point(192, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("61a13bc5-6c00-4ff1-9bcd-e454a44231b2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b72ffab2-963a-481c-826d-686a7090b4e9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow398SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow398",
				UId = new Guid("332d03b1-a379-48c4-9ce0-ec18b19f6689"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("34608bf1-84ea-4f70-b303-c37d183b0ae0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f01709d4-d644-49e2-b6b1-99bdb8f14240"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet774LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet774 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("aeb3f0e1-fcf5-4f46-8db5-663feb2a833b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"LaneSet774",
				Position = new Point(5, 5),
				Size = new Size(380, 499),
				UseBackgroundMode = false
			};
			return schemaLaneSet774;
		}

		protected virtual ProcessSchemaLane CreateLane2782Lane() {
			ProcessSchemaLane schemaLane2782 = new ProcessSchemaLane(this) {
				UId = new Guid("5d42348f-aaf4-4ede-95fa-f0d1f4a29598"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("aeb3f0e1-fcf5-4f46-8db5-663feb2a833b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"Lane2782",
				Position = new Point(29, 0),
				Size = new Size(351, 499),
				UseBackgroundMode = false
			};
			return schemaLane2782;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e6515633-f307-4575-a468-9506113f07b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d42348f-aaf4-4ede-95fa-f0d1f4a29598"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"EventSubProcess1",
				Position = new Point(43, 170),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactCommunicationSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f886d715-d1fc-4a62-a4a2-6988c192cdaa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6515633-f307-4575-a468-9506113f07b7"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactCommunicationSaved",
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ContactCommunicationSaved",
				Position = new Point(36, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactCommunicationSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("000ae750-aea5-44b4-8339-81795bd840be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6515633-f307-4575-a468-9506113f07b7"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ScriptContactCommunicationSaved",
				Position = new Point(134, 41),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,75,45,119,206,207,43,73,76,46,113,206,207,205,45,205,203,76,78,44,201,204,207,211,208,180,230,229,10,74,205,205,47,75,117,41,45,200,1,137,166,22,131,5,139,82,75,74,139,242,20,74,138,74,83,173,1,41,207,189,191,64,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f80e73a9-7634-453c-8e30-aa57dbf03366"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d42348f-aaf4-4ede-95fa-f0d1f4a29598"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 326),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactCommunicationDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("616c80f6-9658-4c86-8e5c-fa9d1054268e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f80e73a9-7634-453c-8e30-aa57dbf03366"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactCommunicationDeleted",
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ContactCommunicationDeleted",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactCommunicationDeletedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b3eb100d-00ab-43bf-8b71-1ba877178682"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f80e73a9-7634-453c-8e30-aa57dbf03366"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ScriptContactCommunicationDeleted",
				Position = new Point(137, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,206,207,43,73,76,46,113,206,207,205,45,205,203,76,78,44,201,204,207,115,73,205,73,45,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,211,130,52,11,46,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cde71769-f95b-40c6-a70a-dd0bc670f691"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d42348f-aaf4-4ede-95fa-f0d1f4a29598"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactCommunicationSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("61a13bc5-6c00-4ff1-9bcd-e454a44231b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cde71769-f95b-40c6-a70a-dd0bc670f691"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactCommunicationSaving",
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ContactCommunicationSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(37, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateContactCommunicationSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b72ffab2-963a-481c-826d-686a7090b4e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cde71769-f95b-40c6-a70a-dd0bc670f691"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ContactCommunicationSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(135, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,206,207,43,73,76,46,113,206,207,205,45,205,203,76,78,44,201,204,207,11,78,44,203,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,233,218,92,147,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4846EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4846 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2de10518-9086-45b8-8a1a-70282e233518"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d42348f-aaf4-4ede-95fa-f0d1f4a29598"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"EventSubProcess4846",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 503),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(252, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4846;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactCommunicationUpdatingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("34608bf1-84ea-4f70-b303-c37d183b0ae0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2de10518-9086-45b8-8a1a-70282e233518"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactCommunicationUpdating",
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ContactCommunicationUpdating",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(24, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactCommunicationUpdatingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f01709d4-d644-49e2-b6b1-99bdb8f14240"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2de10518-9086-45b8-8a1a-70282e233518"),
				CreatedInOwnerSchemaUId = new Guid("becb3a74-6eee-4c5e-b36e-4159a74e2a8e"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Name = @"ScriptContactCommunicationUpdating",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(141, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,41,77,204,201,172,74,117,173,40,73,45,202,75,204,113,206,207,205,45,205,203,76,78,44,201,204,207,11,169,44,72,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,161,178,207,181,50,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetNewContactCommunicationMethod());
			Methods.Add(CreateClearOldContactCommunicationMethod());
			Methods.Add(CreateOnContactCommunicationDeletedMethod());
			Methods.Add(CreateGetColumnNameByCommunicationTypeMethod());
			Methods.Add(CreateActualizeExternalCommunicationTypeMethod());
			Methods.Add(CreateOnContactCommunicationSavingMethod());
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
				UId = new Guid("fadd6755-df51-4304-ac40-696bb22063b1"),
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

		protected override SchemaMethod CreateSetCommunicationParentEntityColumnsMethod() {
			SchemaMethod method = base.CreateSetCommunicationParentEntityColumnsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,203,106,195,48,20,68,215,13,228,31,20,175,108,48,249,129,166,89,196,13,193,139,186,5,151,110,74,23,138,173,182,23,244,48,122,4,212,38,255,94,73,118,30,216,137,233,74,112,117,231,204,104,180,195,18,85,130,49,195,161,194,26,4,127,181,13,201,107,244,128,214,92,131,182,243,13,209,126,84,103,130,26,198,223,48,53,100,177,49,80,47,227,40,27,234,162,228,126,58,121,132,202,79,176,180,11,165,37,240,175,20,181,231,210,89,121,74,129,25,81,206,194,177,179,211,96,101,7,188,248,74,50,111,208,210,144,62,231,242,0,7,188,192,191,71,126,255,124,27,125,156,133,74,84,128,233,109,101,217,187,15,218,157,107,234,82,24,170,24,239,169,123,117,220,1,159,72,13,184,235,200,211,64,189,72,96,174,166,113,202,86,8,234,24,185,202,36,193,154,212,43,91,90,94,125,75,193,225,39,20,19,128,240,137,226,214,111,158,171,194,80,250,44,215,172,209,54,238,181,148,160,253,30,205,78,214,9,250,157,78,238,36,209,70,114,71,57,180,201,184,97,91,34,255,249,184,34,44,135,16,13,150,132,235,78,84,30,127,55,236,247,115,164,157,201,49,251,236,106,248,254,79,37,109,222,49,159,190,36,29,254,154,247,60,252,1,43,129,108,137,250,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetNewContactCommunicationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f1352329-ae7b-4741-9b8e-140019df9af5"),
				Name = "SetNewContactCommunication",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,49,11,194,48,20,132,247,254,138,144,169,66,241,15,180,118,176,74,113,17,7,117,17,135,71,18,36,96,94,75,250,82,200,191,55,177,210,170,117,112,10,92,238,125,119,215,131,101,162,49,198,161,22,64,186,193,163,111,213,78,178,21,219,34,105,242,203,90,81,148,100,213,220,157,193,51,220,157,42,106,167,101,153,242,106,126,199,23,121,178,209,34,10,96,125,209,145,213,120,203,216,240,150,33,41,66,246,96,84,23,18,2,186,26,133,181,159,225,210,31,197,2,127,128,49,154,90,197,251,192,123,163,95,120,180,79,191,252,154,39,253,115,42,18,8,250,123,224,203,29,103,157,90,9,164,62,74,30,192,42,164,129,51,186,121,54,165,100,223,45,3,231,1,252,2,62,104,114,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClearOldContactCommunicationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ec531158-7fba-49c8-adb4-c13ffd8af17d"),
				Name = "ClearOldContactCommunication",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("467e8661-453f-46e6-ab9a-2749b5699bb7"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,209,78,194,48,20,125,30,95,81,247,64,186,100,217,15,136,36,130,11,225,5,76,16,125,48,62,212,173,74,147,173,195,246,22,29,134,127,247,182,157,108,224,18,121,91,215,115,206,61,247,156,238,152,34,85,145,79,171,178,52,82,100,12,68,37,31,234,45,159,231,228,134,164,18,4,212,201,140,131,253,149,47,45,174,48,165,124,100,133,225,163,153,17,249,152,134,61,212,48,186,30,236,80,56,187,68,245,114,73,241,70,232,85,191,217,36,253,48,172,208,212,10,36,105,185,133,58,34,195,33,249,7,221,227,47,138,200,247,32,184,205,0,1,98,207,239,149,40,153,170,87,192,128,83,180,16,52,230,87,28,58,190,105,56,215,83,197,17,147,79,234,85,45,179,141,170,164,216,59,217,48,38,160,12,183,92,31,137,101,45,88,201,49,9,13,74,200,119,239,23,239,239,68,102,25,56,111,228,111,226,6,49,238,208,52,242,102,191,211,237,143,73,253,103,67,218,191,118,235,65,2,203,224,226,50,26,180,173,32,240,134,8,180,224,102,151,142,195,231,208,106,181,183,225,11,18,95,171,170,32,66,79,153,76,115,1,205,18,254,224,145,199,73,54,177,83,121,59,216,150,223,210,109,183,77,122,115,189,48,69,177,84,46,69,122,206,116,117,186,173,205,54,199,130,112,176,228,159,100,237,14,116,173,185,194,169,146,187,224,99,114,180,16,33,201,150,124,174,23,19,255,157,32,80,3,237,22,24,57,206,211,134,43,251,30,48,45,116,230,222,25,61,161,28,195,143,236,86,129,119,149,164,95,60,51,205,19,59,12,14,63,231,103,188,74,150,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnContactCommunicationDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("927b8703-2710-445d-ae8b-c0dd7d7f4900"),
				Name = "OnContactCommunicationDeleted",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("f2b2bf98-7d51-4b6d-9e0b-dcf9524e962a"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,203,110,194,48,16,69,215,32,241,15,110,22,85,144,80,126,160,165,11,2,68,89,16,42,5,186,169,186,48,142,1,75,177,141,28,135,42,173,248,247,250,145,71,19,82,202,130,8,240,220,115,231,122,38,65,78,18,128,56,147,16,201,48,1,83,176,96,146,200,194,11,176,220,20,39,156,248,60,205,41,123,131,105,142,159,3,85,251,226,58,126,85,237,140,159,70,195,76,10,194,14,128,229,116,135,197,109,189,45,85,132,200,20,27,121,96,253,41,205,25,65,80,18,206,180,236,238,78,174,116,6,186,227,60,5,36,123,21,132,66,81,220,70,233,90,133,10,51,95,96,40,113,50,43,226,130,161,163,224,140,124,25,174,33,206,9,210,223,21,173,76,49,1,101,26,213,188,134,69,144,226,76,57,41,11,191,254,99,86,92,117,232,246,100,213,6,103,40,170,49,196,232,136,41,84,172,109,134,133,186,108,134,141,183,103,67,216,211,21,100,240,128,133,78,20,178,76,66,134,148,153,182,172,199,227,116,168,86,173,168,45,23,207,166,182,135,110,219,240,215,116,101,115,107,218,196,80,234,212,239,142,142,209,156,58,31,141,48,227,136,192,244,111,101,220,57,55,218,114,124,62,100,139,132,200,242,82,237,15,91,217,132,156,116,91,211,77,147,61,112,91,169,189,37,150,232,184,20,156,206,103,110,189,236,99,240,248,216,108,201,24,124,143,134,3,45,109,156,213,249,131,13,226,133,89,148,167,233,90,44,232,73,93,84,215,212,138,7,101,232,179,94,172,230,166,239,120,35,122,66,12,76,47,37,106,90,190,95,165,207,160,77,142,171,157,51,208,46,172,218,84,207,180,110,209,134,221,31,173,59,177,42,219,63,166,93,89,175,235,69,63,245,67,127,110,226,156,21,79,200,158,224,100,205,212,140,231,106,69,55,132,98,111,43,81,196,63,13,173,35,135,103,236,234,255,47,63,61,7,197,211,209,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnNameByCommunicationTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f22957c8-2391-40a6-a8b7-2f02e556afae"),
				Name = "GetColumnNameByCommunicationType",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3"),
				ResultValueTypeName = "Dictionary<string, string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b27ea339-2fce-45f3-ab3b-1336ec5ca66b"),
				Name = "communicationType",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				ModifiedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("5603834c-d982-4f87-a976-a9411eeb30f3")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,209,74,195,48,20,134,175,87,232,59,132,94,181,32,125,0,171,130,212,137,5,21,161,5,47,196,139,52,61,184,208,38,103,36,233,70,17,223,221,174,93,55,87,101,38,87,231,92,124,252,255,119,8,100,67,21,217,208,166,5,77,174,137,132,45,185,227,204,112,148,84,117,87,218,40,46,63,46,200,56,111,194,40,241,189,145,141,111,171,42,12,138,110,13,41,54,173,144,207,84,64,48,129,241,82,172,77,55,135,115,100,156,54,103,113,189,229,134,173,72,200,80,136,86,114,70,119,34,187,146,184,192,124,96,195,40,34,159,190,183,96,84,3,73,231,88,138,82,27,29,63,114,89,67,149,201,172,186,244,61,178,88,140,22,111,115,221,247,254,224,96,98,131,190,254,72,254,114,61,97,179,106,164,75,5,180,78,254,179,41,250,163,12,168,65,230,188,203,158,180,81,57,132,186,152,220,83,6,37,98,109,161,50,161,54,46,199,88,23,153,165,160,188,177,48,25,56,151,224,188,238,119,155,167,31,64,151,228,7,20,240,178,66,9,22,218,7,214,165,224,9,75,222,88,87,252,160,93,74,94,81,213,182,21,127,132,127,249,158,2,211,42,185,255,53,146,111,135,0,244,150,65,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizeExternalCommunicationTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9d932aa4-d2f3-40c1-bd88-fabd60ee4cd8"),
				Name = "ActualizeExternalCommunicationType",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,241,207,73,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,114,206,207,205,45,205,203,76,78,44,201,204,207,3,169,243,76,81,210,84,80,180,85,64,211,77,172,86,77,133,106,46,78,168,222,224,212,18,36,109,26,74,174,21,37,169,69,121,137,57,24,26,149,116,20,138,75,138,50,243,210,245,92,115,11,74,42,53,173,185,106,1,133,44,76,199,193,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnContactCommunicationSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7611e622-d051-412d-a5ba-be7706f793b8"),
				Name = "OnContactCommunicationSaving",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,141,193,10,194,48,16,68,207,237,87,132,158,82,16,127,64,60,104,16,233,165,10,1,239,75,186,226,66,178,129,116,131,164,210,127,183,233,109,6,222,188,25,230,17,191,234,172,238,40,67,141,186,63,181,244,86,122,47,189,250,181,205,197,73,6,79,11,62,19,5,72,197,10,8,86,172,185,177,144,148,163,69,49,209,231,192,47,240,25,117,55,204,38,225,198,76,215,98,11,187,79,138,76,11,8,69,238,14,74,82,198,109,187,42,244,51,86,189,241,8,233,225,39,19,89,192,109,166,16,50,147,219,249,250,178,254,1,143,107,106,6,162,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizePrimaryStateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c55016fb-c347-4f7b-855a-d14be8404d9f"),
				Name = "ActualizePrimaryState",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,221,138,194,48,16,133,175,183,79,17,122,149,128,228,5,186,10,110,41,210,187,5,87,189,30,146,17,3,237,84,147,137,107,125,122,251,163,130,148,93,188,156,225,124,103,206,156,51,120,97,154,186,142,228,12,176,107,232,167,61,98,105,197,92,20,196,142,91,189,66,238,87,54,111,170,88,211,22,170,136,159,171,232,236,66,166,249,148,75,85,150,156,7,75,98,48,252,182,209,93,221,227,3,31,143,22,24,59,152,240,87,108,134,65,110,2,250,78,73,104,250,123,51,241,192,94,98,164,42,249,208,107,100,153,150,33,247,216,113,246,171,93,183,100,14,190,33,119,29,53,51,49,134,208,223,224,161,70,70,47,247,80,5,84,42,209,187,3,122,124,137,164,203,80,156,34,84,114,2,61,191,236,193,37,217,63,42,249,207,96,34,87,74,64,184,191,156,37,99,15,186,184,160,137,93,5,42,187,1,170,73,26,87,176,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsNewMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c805ad35-22a7-4e8b-b1bf-3c44f529f105"),
				Name = "GetIsNew",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,46,41,202,204,75,87,200,207,73,241,43,205,77,74,45,82,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,241,207,73,113,206,207,41,205,205,11,75,204,41,77,181,41,6,107,176,211,80,130,168,87,210,180,230,130,8,41,228,165,150,227,50,131,128,1,69,169,37,165,69,121,10,26,16,41,61,207,98,191,210,156,28,255,34,215,220,130,146,74,13,184,211,52,21,212,212,20,20,225,182,232,185,22,150,38,230,20,35,201,107,90,3,0,215,101,213,54,206,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveDuplicatesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("15103cfc-b6fb-4c1f-9811-bf62f813f01f"),
				Name = "RemoveDuplicates",
				CreatedInSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,193,106,2,49,16,134,207,21,124,135,176,167,228,146,23,176,45,20,187,138,23,241,208,218,115,154,12,53,144,76,52,59,177,245,237,29,87,187,172,136,139,215,97,190,255,159,249,246,38,11,155,98,44,232,173,33,159,240,227,176,133,133,19,47,162,70,242,116,208,115,160,211,200,77,83,40,17,215,38,20,120,158,23,239,94,101,53,189,229,42,53,25,143,246,109,38,146,177,244,112,210,101,187,227,177,196,111,200,195,112,67,217,227,15,227,203,118,185,99,253,99,165,189,54,7,129,17,132,95,241,14,1,8,228,103,3,153,143,66,176,167,223,148,158,229,20,187,51,175,254,174,212,120,244,164,191,54,144,225,234,15,189,104,234,93,49,65,158,155,245,202,100,19,57,58,203,78,141,82,154,217,55,116,119,84,14,69,220,172,247,194,254,117,220,231,207,118,123,72,91,183,76,36,7,32,207,29,194,52,23,69,108,142,173,233,250,15,108,97,97,106,114,4,9,82,41,179,74,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCommunication_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"));
		}

		#endregion

	}

	#endregion

}

