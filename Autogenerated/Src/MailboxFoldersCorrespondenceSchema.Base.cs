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

	#region Class: MailboxFoldersCorrespondence_Base_TerrasoftSchema

	/// <exclude/>
	public class MailboxFoldersCorrespondence_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MailboxFoldersCorrespondence_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailboxFoldersCorrespondence_Base_TerrasoftSchema(MailboxFoldersCorrespondence_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailboxFoldersCorrespondence_Base_TerrasoftSchema(MailboxFoldersCorrespondence_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			RealUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			Name = "MailboxFoldersCorrespondence_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c55e72a2-77b6-411d-a1b9-f1aafe4bc2a2")) == null) {
				Columns.Add(CreateMailboxColumn());
			}
			if (Columns.FindByUId(new Guid("defe22ae-686f-407f-94e4-d331a858fe1a")) == null) {
				Columns.Add(CreateActivityFolderColumn());
			}
			if (Columns.FindByUId(new Guid("80041bc7-5130-4a6e-b202-905cb969bf49")) == null) {
				Columns.Add(CreateFolderPathColumn());
			}
			if (Columns.FindByUId(new Guid("f5c3a03f-c9db-4891-9331-ffe6b5a698b1")) == null) {
				Columns.Add(CreateUIdColumn());
			}
			if (Columns.FindByUId(new Guid("4ad9420a-93a9-483c-b1f9-7405503425f4")) == null) {
				Columns.Add(CreateUIdValidityColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			column.CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			column.CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			column.CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			column.CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			column.CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			column.CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
			return column;
		}

		protected virtual EntitySchemaColumn CreateMailboxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c55e72a2-77b6-411d-a1b9-f1aafe4bc2a2"),
				Name = @"Mailbox",
				ReferenceSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			};
		}

		protected virtual EntitySchemaColumn CreateActivityFolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("defe22ae-686f-407f-94e4-d331a858fe1a"),
				Name = @"ActivityFolder",
				ReferenceSchemaUId = new Guid("31464792-6754-447f-83ae-90a1b468c29f"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			};
		}

		protected virtual EntitySchemaColumn CreateFolderPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("80041bc7-5130-4a6e-b202-905cb969bf49"),
				Name = @"FolderPath",
				CreatedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			};
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f5c3a03f-c9db-4891-9331-ffe6b5a698b1"),
				Name = @"UId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUIdValidityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4ad9420a-93a9-483c-b1f9-7405503425f4"),
				Name = @"UIdValidity",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				ModifiedInSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema() {
			var schema = new MailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MailboxFoldersCorrespondence_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MailboxFoldersCorrespondence_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MailboxFoldersCorrespondence_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailboxFoldersCorrespondence_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"));
		}

		#endregion

	}

	#endregion

	#region Class: MailboxFoldersCorrespondence_Base_Terrasoft

	/// <summary>
	/// Correlation between Activity folders and Mailbox folders.
	/// </summary>
	public class MailboxFoldersCorrespondence_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MailboxFoldersCorrespondence_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailboxFoldersCorrespondence_Base_Terrasoft";
		}

		public MailboxFoldersCorrespondence_Base_Terrasoft(MailboxFoldersCorrespondence_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid MailboxId {
			get {
				return GetTypedColumnValue<Guid>("MailboxId");
			}
			set {
				SetColumnValue("MailboxId", value);
				_mailbox = null;
			}
		}

		/// <exclude/>
		public string MailboxUserName {
			get {
				return GetTypedColumnValue<string>("MailboxUserName");
			}
			set {
				SetColumnValue("MailboxUserName", value);
				if (_mailbox != null) {
					_mailbox.UserName = value;
				}
			}
		}

		private MailboxSyncSettings _mailbox;
		/// <summary>
		/// Mailbox.
		/// </summary>
		public MailboxSyncSettings Mailbox {
			get {
				return _mailbox ??
					(_mailbox = LookupColumnEntities.GetEntity("Mailbox") as MailboxSyncSettings);
			}
		}

		/// <exclude/>
		public Guid ActivityFolderId {
			get {
				return GetTypedColumnValue<Guid>("ActivityFolderId");
			}
			set {
				SetColumnValue("ActivityFolderId", value);
				_activityFolder = null;
			}
		}

		/// <exclude/>
		public string ActivityFolderName {
			get {
				return GetTypedColumnValue<string>("ActivityFolderName");
			}
			set {
				SetColumnValue("ActivityFolderName", value);
				if (_activityFolder != null) {
					_activityFolder.Name = value;
				}
			}
		}

		private ActivityFolder _activityFolder;
		/// <summary>
		/// Activity folder.
		/// </summary>
		public ActivityFolder ActivityFolder {
			get {
				return _activityFolder ??
					(_activityFolder = LookupColumnEntities.GetEntity("ActivityFolder") as ActivityFolder);
			}
		}

		/// <summary>
		/// Path to mailbox folder.
		/// </summary>
		public string FolderPath {
			get {
				return GetTypedColumnValue<string>("FolderPath");
			}
			set {
				SetColumnValue("FolderPath", value);
			}
		}

		/// <summary>
		/// UId of last downloaded letter.
		/// </summary>
		public string UId {
			get {
				return GetTypedColumnValue<string>("UId");
			}
			set {
				SetColumnValue("UId", value);
			}
		}

		/// <summary>
		/// UIdValidity of folder.
		/// </summary>
		public string UIdValidity {
			get {
				return GetTypedColumnValue<string>("UIdValidity");
			}
			set {
				SetColumnValue("UIdValidity", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailboxFoldersCorrespondence_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MailboxFoldersCorrespondence_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("MailboxFoldersCorrespondence_Base_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("MailboxFoldersCorrespondence_Base_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("MailboxFoldersCorrespondence_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailboxFoldersCorrespondence_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailboxFoldersCorrespondence_BaseEventsProcess

	/// <exclude/>
	public partial class MailboxFoldersCorrespondence_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : MailboxFoldersCorrespondence_Base_Terrasoft
	{

		public MailboxFoldersCorrespondence_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailboxFoldersCorrespondence_BaseEventsProcess";
			SchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid ActivityFolderId {
			get;
			set;
		}

		public virtual Guid MailboxId {
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
					SchemaElementUId = new Guid("92c87dd7-5027-4214-9608-da0cb4398eed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailboxFoldersCorrespondenceDeleting;
		public ProcessFlowElement MailboxFoldersCorrespondenceDeleting {
			get {
				return _mailboxFoldersCorrespondenceDeleting ?? (_mailboxFoldersCorrespondenceDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailboxFoldersCorrespondenceDeleting",
					SchemaElementUId = new Guid("09d6f9dc-4bed-47e8-8a24-b8c825288d63"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseEntityDeletingThrow;
		public ProcessThrowMessageEvent BaseEntityDeletingThrow {
			get {
				return _baseEntityDeletingThrow ?? (_baseEntityDeletingThrow = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseEntityDeletingThrow",
					SchemaElementUId = new Guid("e7cae2e6-9b00-4009-980b-1016452b48c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseEntityDeleting",
				});
			}
		}

		private ProcessScriptTask _mailboxFoldersCorrespondenceDeletingScript;
		public ProcessScriptTask MailboxFoldersCorrespondenceDeletingScript {
			get {
				return _mailboxFoldersCorrespondenceDeletingScript ?? (_mailboxFoldersCorrespondenceDeletingScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxFoldersCorrespondenceDeletingScript",
					SchemaElementUId = new Guid("c857f4d7-1fdb-4fe1-888a-7fc9510bff6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxFoldersCorrespondenceDeletingScriptExecute,
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
					SchemaElementUId = new Guid("d819515e-9c4e-4c16-9c79-0419add0d864"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailboxFoldersCorrespondenceDeleted;
		public ProcessFlowElement MailboxFoldersCorrespondenceDeleted {
			get {
				return _mailboxFoldersCorrespondenceDeleted ?? (_mailboxFoldersCorrespondenceDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailboxFoldersCorrespondenceDeleted",
					SchemaElementUId = new Guid("820cc956-3c72-43c0-9652-3e2d07dfc620"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseEntityDeletedThrow;
		public ProcessThrowMessageEvent BaseEntityDeletedThrow {
			get {
				return _baseEntityDeletedThrow ?? (_baseEntityDeletedThrow = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseEntityDeletedThrow",
					SchemaElementUId = new Guid("7b6c02fc-f5e9-48ee-a2ba-da31313b5e6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseEntityDeleted",
				});
			}
		}

		private ProcessScriptTask _mailboxFoldersCorrespondenceDeletedScript;
		public ProcessScriptTask MailboxFoldersCorrespondenceDeletedScript {
			get {
				return _mailboxFoldersCorrespondenceDeletedScript ?? (_mailboxFoldersCorrespondenceDeletedScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailboxFoldersCorrespondenceDeletedScript",
					SchemaElementUId = new Guid("055ab9ec-03b2-49e6-a8c7-21ea47a81f12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailboxFoldersCorrespondenceDeletedScriptExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[MailboxFoldersCorrespondenceDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxFoldersCorrespondenceDeleting };
			FlowElements[BaseEntityDeletingThrow.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityDeletingThrow };
			FlowElements[MailboxFoldersCorrespondenceDeletingScript.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxFoldersCorrespondenceDeletingScript };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[MailboxFoldersCorrespondenceDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxFoldersCorrespondenceDeleted };
			FlowElements[BaseEntityDeletedThrow.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseEntityDeletedThrow };
			FlowElements[MailboxFoldersCorrespondenceDeletedScript.SchemaElementUId] = new Collection<ProcessFlowElement> { MailboxFoldersCorrespondenceDeletedScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "MailboxFoldersCorrespondenceDeleting":
						e.Context.QueueTasks.Enqueue("BaseEntityDeletingThrow");
						break;
					case "BaseEntityDeletingThrow":
						e.Context.QueueTasks.Enqueue("MailboxFoldersCorrespondenceDeletingScript");
						break;
					case "MailboxFoldersCorrespondenceDeletingScript":
						break;
					case "EventSubProcess2":
						break;
					case "MailboxFoldersCorrespondenceDeleted":
						e.Context.QueueTasks.Enqueue("BaseEntityDeletedThrow");
						break;
					case "BaseEntityDeletedThrow":
						e.Context.QueueTasks.Enqueue("MailboxFoldersCorrespondenceDeletedScript");
						break;
					case "MailboxFoldersCorrespondenceDeletedScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MailboxFoldersCorrespondenceDeleting");
			ActivatedEventElements.Add("MailboxFoldersCorrespondenceDeleted");
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
				case "MailboxFoldersCorrespondenceDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxFoldersCorrespondenceDeleting";
					result = MailboxFoldersCorrespondenceDeleting.Execute(context);
					break;
				case "BaseEntityDeletingThrow":
					context.QueueTasks.Dequeue();
					result = BaseEntityDeletingThrow.Execute(context);
					break;
				case "MailboxFoldersCorrespondenceDeletingScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxFoldersCorrespondenceDeletingScript";
					result = MailboxFoldersCorrespondenceDeletingScript.Execute(context, MailboxFoldersCorrespondenceDeletingScriptExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "MailboxFoldersCorrespondenceDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxFoldersCorrespondenceDeleted";
					result = MailboxFoldersCorrespondenceDeleted.Execute(context);
					break;
				case "BaseEntityDeletedThrow":
					context.QueueTasks.Dequeue();
					result = BaseEntityDeletedThrow.Execute(context);
					break;
				case "MailboxFoldersCorrespondenceDeletedScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailboxFoldersCorrespondenceDeletedScript";
					result = MailboxFoldersCorrespondenceDeletedScript.Execute(context, MailboxFoldersCorrespondenceDeletedScriptExecute);
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
				case "MailboxId":
					MailboxId = reader.GetValue<System.Guid>();
				break;
				case "ActivityFolderId":
					ActivityFolderId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool MailboxFoldersCorrespondenceDeletingScriptExecute(ProcessExecutingContext context) {
			MailboxId = Entity.GetTypedColumnValue<Guid>("MailboxId");
			ActivityFolderId = Entity.GetTypedColumnValue<Guid>("ActivityFolderId");
			return true;
		}

		public virtual bool MailboxFoldersCorrespondenceDeletedScriptExecute(ProcessExecutingContext context) {
			var activityFolderSchema = UserConnection.EntitySchemaManager.FindInstanceByName("ActivityFolder");
			var activityFolder = activityFolderSchema.CreateEntity(UserConnection);
			if(activityFolder.FetchFromDB(ActivityFolderId)) {
				activityFolder.Delete();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "MailboxFoldersCorrespondence_Base_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("MailboxFoldersCorrespondenceDeleting")) {
							context.QueueTasks.Enqueue("MailboxFoldersCorrespondenceDeleting");
						}
						break;
					case "MailboxFoldersCorrespondence_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("MailboxFoldersCorrespondenceDeleted")) {
							context.QueueTasks.Enqueue("MailboxFoldersCorrespondenceDeleted");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("MailboxId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("MailboxId", MailboxId, Guid.Empty);
			}
			if (!HasMapping("ActivityFolderId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ActivityFolderId", ActivityFolderId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: MailboxFoldersCorrespondence_BaseEventsProcess

	/// <exclude/>
	public class MailboxFoldersCorrespondence_BaseEventsProcess : MailboxFoldersCorrespondence_BaseEventsProcess<MailboxFoldersCorrespondence_Base_Terrasoft>
	{

		public MailboxFoldersCorrespondence_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailboxFoldersCorrespondence_BaseEventsProcess

	public partial class MailboxFoldersCorrespondence_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: MailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema(MailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailboxFoldersCorrespondence_BaseEventsProcess";
			UId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79");
			CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe");
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

		protected virtual ProcessSchemaParameter CreateActivityFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("60feb251-caa7-496f-9955-438da7395c47"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"ActivityFolderId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMailboxIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9c8c8b5b-c86b-4b77-bab0-6b9c6997fc18"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"MailboxId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateActivityFolderIdParameter());
			Parameters.Add(CreateMailboxIdParameter());
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
			ProcessSchemaStartMessageEvent mailboxfolderscorrespondencedeleting = CreateMailboxFoldersCorrespondenceDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(mailboxfolderscorrespondencedeleting);
			ProcessSchemaIntermediateThrowMessageEvent baseentitydeletingthrow = CreateBaseEntityDeletingThrowIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(baseentitydeletingthrow);
			ProcessSchemaScriptTask mailboxfolderscorrespondencedeletingscript = CreateMailboxFoldersCorrespondenceDeletingScriptScriptTask();
			eventsubprocess1.FlowElements.Add(mailboxfolderscorrespondencedeletingscript);
			ProcessSchemaStartMessageEvent mailboxfolderscorrespondencedeleted = CreateMailboxFoldersCorrespondenceDeletedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(mailboxfolderscorrespondencedeleted);
			ProcessSchemaIntermediateThrowMessageEvent baseentitydeletedthrow = CreateBaseEntityDeletedThrowIntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(baseentitydeletedthrow);
			ProcessSchemaScriptTask mailboxfolderscorrespondencedeletedscript = CreateMailboxFoldersCorrespondenceDeletedScriptScriptTask();
			eventsubprocess2.FlowElements.Add(mailboxfolderscorrespondencedeletedscript);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4576ff32-caed-42d2-ac61-210c6d8f3770"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				CurveCenterPosition = new Point(152, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("09d6f9dc-4bed-47e8-8a24-b8c825288d63"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e7cae2e6-9b00-4009-980b-1016452b48c7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c2836d10-e23c-4764-9010-9b6d84f19932"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				CurveCenterPosition = new Point(248, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e7cae2e6-9b00-4009-980b-1016452b48c7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c857f4d7-1fdb-4fe1-888a-7fc9510bff6e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("77fee0ee-12b4-42db-92e8-5aafa88fa377"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				CurveCenterPosition = new Point(446, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("820cc956-3c72-43c0-9652-3e2d07dfc620"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7b6c02fc-f5e9-48ee-a2ba-da31313b5e6c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("5d4ae464-822d-47f1-b0ec-72f25c2c18e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				CurveCenterPosition = new Point(518, 87),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7b6c02fc-f5e9-48ee-a2ba-da31313b5e6c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("055ab9ec-03b2-49e6-a8c7-21ea47a81f12"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("031793f0-d713-4949-a2a0-783a0ba1aeaf"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(698, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("3b351d67-da8f-4d9b-ab82-eb77639b646a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("031793f0-d713-4949-a2a0-783a0ba1aeaf"),
				CreatedInOwnerSchemaUId = new Guid("ae770c57-1b04-46ac-85cc-2bc38008a9fc"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(669, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("92c87dd7-5027-4214-9608-da0cb4398eed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b351d67-da8f-4d9b-ab82-eb77639b646a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailboxFoldersCorrespondenceDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("09d6f9dc-4bed-47e8-8a24-b8c825288d63"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92c87dd7-5027-4214-9608-da0cb4398eed"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxFoldersCorrespondenceDeleting",
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"MailboxFoldersCorrespondenceDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseEntityDeletingThrowIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e7cae2e6-9b00-4009-980b-1016452b48c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92c87dd7-5027-4214-9608-da0cb4398eed"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseEntityDeleting",
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"BaseEntityDeletingThrow",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxFoldersCorrespondenceDeletingScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c857f4d7-1fdb-4fe1-888a-7fc9510bff6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92c87dd7-5027-4214-9608-da0cb4398eed"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"MailboxFoldersCorrespondenceDeletingScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(190, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,204,204,73,202,175,240,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,242,133,169,86,210,180,230,229,114,76,46,201,44,3,234,112,203,207,73,73,45,34,210,8,116,77,96,147,138,82,75,74,139,242,20,74,138,74,83,173,1,161,151,163,10,146,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d819515e-9c4e-4c16-9c79-0419add0d864"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3b351d67-da8f-4d9b-ab82-eb77639b646a"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(344, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(250, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailboxFoldersCorrespondenceDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("820cc956-3c72-43c0-9652-3e2d07dfc620"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d819515e-9c4e-4c16-9c79-0419add0d864"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailboxFoldersCorrespondenceDeleted",
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"MailboxFoldersCorrespondenceDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(14, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseEntityDeletedThrowIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7b6c02fc-f5e9-48ee-a2ba-da31313b5e6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d819515e-9c4e-4c16-9c79-0419add0d864"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseEntityDeleted",
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"BaseEntityDeletedThrow",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(77, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailboxFoldersCorrespondenceDeletedScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("055ab9ec-03b2-49e6-a8c7-21ea47a81f12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d819515e-9c4e-4c16-9c79-0419add0d864"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe"),
				CreatedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"),
				Name = @"MailboxFoldersCorrespondenceDeletedScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,49,10,131,64,16,69,235,8,222,97,177,90,155,189,128,164,136,154,5,139,164,9,57,192,176,78,226,130,206,194,56,10,18,114,247,40,86,155,164,254,255,191,247,103,96,5,78,252,236,101,177,161,111,145,111,174,195,1,212,81,221,71,228,42,16,225,26,7,50,103,146,181,179,167,23,32,120,34,27,235,169,109,104,20,32,135,229,114,133,1,117,118,138,104,89,94,164,201,252,35,89,241,255,172,166,98,4,193,93,165,227,3,27,200,63,116,60,51,22,197,117,150,195,80,151,58,54,55,109,158,171,87,154,28,190,22,53,246,40,168,55,220,59,77,24,101,98,82,194,19,22,31,9,127,204,168,12,1,0,0 }
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
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("7a646759-5625-40b8-b9b2-a130fe59eabe")
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
			return new MailboxFoldersCorrespondence_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("391bfc39-7f08-4524-9c6d-7be6b707ef79"));
		}

		#endregion

	}

	#endregion

}

