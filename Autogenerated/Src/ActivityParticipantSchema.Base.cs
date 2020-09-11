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

	#region Class: ActivityParticipantSchema

	/// <exclude/>
	public class ActivityParticipantSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ActivityParticipantSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityParticipantSchema(ActivityParticipantSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityParticipantSchema(ActivityParticipantSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae");
			RealUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae");
			Name = "ActivityParticipant";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("74669aba-cc69-485d-a68e-956cb30f523a")) == null) {
				Columns.Add(CreateActivityColumn());
			}
			if (Columns.FindByUId(new Guid("80b6623f-f6a9-434b-96e1-c43ba92816ae")) == null) {
				Columns.Add(CreateParticipantColumn());
			}
			if (Columns.FindByUId(new Guid("8dc2dce0-b4d8-4f4e-80a7-b8e5df0c9cc1")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("cf09a744-e539-4bc3-8dde-f63cb772fd58")) == null) {
				Columns.Add(CreateRoleColumn());
			}
			if (Columns.FindByUId(new Guid("ee18b0df-7b71-48c7-b921-ab71a2b276f9")) == null) {
				Columns.Add(CreateReadMarkColumn());
			}
			if (Columns.FindByUId(new Guid("46cf0917-a49e-4e93-8018-14c1846a1c24")) == null) {
				Columns.Add(CreateInviteParticipantColumn());
			}
			if (Columns.FindByUId(new Guid("be4b957d-083d-4660-bf53-83019be16b4e")) == null) {
				Columns.Add(CreateInviteResponseColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("74669aba-cc69-485d-a68e-956cb30f523a"),
				Name = @"Activity",
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				ModifiedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateParticipantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("80b6623f-f6a9-434b-96e1-c43ba92816ae"),
				Name = @"Participant",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				CreatedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				ModifiedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("8dc2dce0-b4d8-4f4e-80a7-b8e5df0c9cc1"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				ModifiedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cf09a744-e539-4bc3-8dde-f63cb772fd58"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("01e72783-64d7-4fac-9d9a-1648eacd51c9"),
				CreatedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				ModifiedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1a8324e8-a6e1-df11-971b-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateReadMarkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ee18b0df-7b71-48c7-b921-ab71a2b276f9"),
				Name = @"ReadMark",
				CreatedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				ModifiedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateInviteParticipantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("46cf0917-a49e-4e93-8018-14c1846a1c24"),
				Name = @"InviteParticipant",
				CreatedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				ModifiedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateInviteResponseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("be4b957d-083d-4660-bf53-83019be16b4e"),
				Name = @"InviteResponse",
				ReferenceSchemaUId = new Guid("55767d4d-fb71-40c3-8140-2bfeb8dff693"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				ModifiedInSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"50e89724-522d-446e-be91-12548b8c834d"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityParticipantEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityParticipantEventsProcessSchema() {
			var schema = new ActivityParticipantEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityParticipant(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityParticipant_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityParticipantSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityParticipantSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipant

	/// <summary>
	/// Activity participant.
	/// </summary>
	public class ActivityParticipant : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ActivityParticipant(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityParticipant";
		}

		public ActivityParticipant(ActivityParticipant source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ActivityId {
			get {
				return GetTypedColumnValue<Guid>("ActivityId");
			}
			set {
				SetColumnValue("ActivityId", value);
				_activity = null;
			}
		}

		/// <exclude/>
		public string ActivityTitle {
			get {
				return GetTypedColumnValue<string>("ActivityTitle");
			}
			set {
				SetColumnValue("ActivityTitle", value);
				if (_activity != null) {
					_activity.Title = value;
				}
			}
		}

		private Activity _activity;
		/// <summary>
		/// Activity.
		/// </summary>
		public Activity Activity {
			get {
				return _activity ??
					(_activity = LookupColumnEntities.GetEntity("Activity") as Activity);
			}
		}

		/// <exclude/>
		public Guid ParticipantId {
			get {
				return GetTypedColumnValue<Guid>("ParticipantId");
			}
			set {
				SetColumnValue("ParticipantId", value);
				_participant = null;
			}
		}

		/// <exclude/>
		public string ParticipantName {
			get {
				return GetTypedColumnValue<string>("ParticipantName");
			}
			set {
				SetColumnValue("ParticipantName", value);
				if (_participant != null) {
					_participant.Name = value;
				}
			}
		}

		private Contact _participant;
		/// <summary>
		/// Participant.
		/// </summary>
		public Contact Participant {
			get {
				return _participant ??
					(_participant = LookupColumnEntities.GetEntity("Participant") as Contact);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <exclude/>
		public Guid RoleId {
			get {
				return GetTypedColumnValue<Guid>("RoleId");
			}
			set {
				SetColumnValue("RoleId", value);
				_role = null;
			}
		}

		/// <exclude/>
		public string RoleName {
			get {
				return GetTypedColumnValue<string>("RoleName");
			}
			set {
				SetColumnValue("RoleName", value);
				if (_role != null) {
					_role.Name = value;
				}
			}
		}

		private ActivityParticipantRole _role;
		/// <summary>
		/// Role.
		/// </summary>
		public ActivityParticipantRole Role {
			get {
				return _role ??
					(_role = LookupColumnEntities.GetEntity("Role") as ActivityParticipantRole);
			}
		}

		/// <summary>
		/// Email opened mark.
		/// </summary>
		public bool ReadMark {
			get {
				return GetTypedColumnValue<bool>("ReadMark");
			}
			set {
				SetColumnValue("ReadMark", value);
			}
		}

		/// <summary>
		/// Send invite to participant.
		/// </summary>
		public bool InviteParticipant {
			get {
				return GetTypedColumnValue<bool>("InviteParticipant");
			}
			set {
				SetColumnValue("InviteParticipant", value);
			}
		}

		/// <exclude/>
		public Guid InviteResponseId {
			get {
				return GetTypedColumnValue<Guid>("InviteResponseId");
			}
			set {
				SetColumnValue("InviteResponseId", value);
				_inviteResponse = null;
			}
		}

		/// <exclude/>
		public string InviteResponseName {
			get {
				return GetTypedColumnValue<string>("InviteResponseName");
			}
			set {
				SetColumnValue("InviteResponseName", value);
				if (_inviteResponse != null) {
					_inviteResponse.Name = value;
				}
			}
		}

		private ParticipantResponse _inviteResponse;
		/// <summary>
		/// Invite response.
		/// </summary>
		public ParticipantResponse InviteResponse {
			get {
				return _inviteResponse ??
					(_inviteResponse = LookupColumnEntities.GetEntity("InviteResponse") as ParticipantResponse);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityParticipant_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityParticipantDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityParticipantDeleting", e);
			Inserted += (s, e) => ThrowEvent("ActivityParticipantInserted", e);
			Inserting += (s, e) => ThrowEvent("ActivityParticipantInserting", e);
			Saved += (s, e) => ThrowEvent("ActivityParticipantSaved", e);
			Saving += (s, e) => ThrowEvent("ActivityParticipantSaving", e);
			Validating += (s, e) => ThrowEvent("ActivityParticipantValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityParticipant(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipant_BaseEventsProcess

	/// <exclude/>
	public partial class ActivityParticipant_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : ActivityParticipant
	{

		public ActivityParticipant_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityParticipant_BaseEventsProcess";
			SchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsUnique {
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
					SchemaElementUId = new Guid("41206455-654f-4020-92ba-15993c2cb63d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityParticipantDeleting;
		public ProcessFlowElement ActivityParticipantDeleting {
			get {
				return _activityParticipantDeleting ?? (_activityParticipantDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityParticipantDeleting",
					SchemaElementUId = new Guid("6415c5e7-8d19-4c9a-a9b5-d8077d566f73"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptActivityParticipantDeleting;
		public ProcessScriptTask ScriptActivityParticipantDeleting {
			get {
				return _scriptActivityParticipantDeleting ?? (_scriptActivityParticipantDeleting = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptActivityParticipantDeleting",
					SchemaElementUId = new Guid("367b83fd-66ef-4b10-8ed5-c9100a5b2867"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptActivityParticipantDeletingExecute,
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
					SchemaElementUId = new Guid("cd3b457b-ec1a-4131-b9bf-bc3965891699"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityParticipantSavedStartMessage1;
		public ProcessFlowElement ActivityParticipantSavedStartMessage1 {
			get {
				return _activityParticipantSavedStartMessage1 ?? (_activityParticipantSavedStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityParticipantSavedStartMessage1",
					SchemaElementUId = new Guid("4227fc1c-1165-42e3-955a-946024866c83"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _activityParticipantSavedIntermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent ActivityParticipantSavedIntermediateThrowMessageEvent1 {
			get {
				return _activityParticipantSavedIntermediateThrowMessageEvent1 ?? (_activityParticipantSavedIntermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ActivityParticipantSavedIntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("845fe4a4-b849-4dd0-a4af-475fd14cf44c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ActivityParticipantSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _activityParticipantSavedScript;
		public ProcessScriptTask ActivityParticipantSavedScript {
			get {
				return _activityParticipantSavedScript ?? (_activityParticipantSavedScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityParticipantSavedScript",
					SchemaElementUId = new Guid("b68f9ef9-4763-43b7-9a77-ba34343eed6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityParticipantSavedScriptExecute,
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
					SchemaElementUId = new Guid("4b878d1c-e104-4b22-8452-971894f77e45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
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
					SchemaElementUId = new Guid("e5e7da00-1777-45ce-8e0f-24fc45c17f4d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityParticipantInserting;
		public ProcessFlowElement ActivityParticipantInserting {
			get {
				return _activityParticipantInserting ?? (_activityParticipantInserting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityParticipantInserting",
					SchemaElementUId = new Guid("92b7c794-e410-4dbf-b026-590e45861403"),
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
					SchemaElementUId = new Guid("458e6b8a-1a46-47af-b4dc-72ad6d48be87"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ActivityParticipantDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantDeleting };
			FlowElements[ScriptActivityParticipantDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptActivityParticipantDeleting };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[ActivityParticipantSavedStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantSavedStartMessage1 };
			FlowElements[ActivityParticipantSavedIntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantSavedIntermediateThrowMessageEvent1 };
			FlowElements[ActivityParticipantSavedScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantSavedScript };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[ActivityParticipantInserting.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantInserting };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ActivityParticipantDeleting":
						e.Context.QueueTasks.Enqueue("ScriptActivityParticipantDeleting");
						break;
					case "ScriptActivityParticipantDeleting":
						break;
					case "EventSubProcess2":
						break;
					case "ActivityParticipantSavedStartMessage1":
						e.Context.QueueTasks.Enqueue("ActivityParticipantSavedIntermediateThrowMessageEvent1");
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "ActivityParticipantSavedIntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ActivityParticipantSavedScript");
						break;
					case "ActivityParticipantSavedScript":
						break;
					case "UpdateRemindings":
						break;
					case "EventSubProcess3":
						break;
					case "ActivityParticipantInserting":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityParticipantDeleting");
			ActivatedEventElements.Add("ActivityParticipantSavedStartMessage1");
			ActivatedEventElements.Add("ActivityParticipantInserting");
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
				case "ActivityParticipantDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityParticipantDeleting";
					result = ActivityParticipantDeleting.Execute(context);
					break;
				case "ScriptActivityParticipantDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptActivityParticipantDeleting";
					result = ScriptActivityParticipantDeleting.Execute(context, ScriptActivityParticipantDeletingExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityParticipantSavedStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityParticipantSavedStartMessage1";
					result = ActivityParticipantSavedStartMessage1.Execute(context);
					break;
				case "ActivityParticipantSavedIntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "ActivityParticipantSaved");
					result = ActivityParticipantSavedIntermediateThrowMessageEvent1.Execute(context);
					break;
				case "ActivityParticipantSavedScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityParticipantSavedScript";
					result = ActivityParticipantSavedScript.Execute(context, ActivityParticipantSavedScriptExecute);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityParticipantInserting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityParticipantInserting";
					result = ActivityParticipantInserting.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
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
				case "IsUnique":
					IsUnique = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptActivityParticipantDeletingExecute(ProcessExecutingContext context) {
			Select select = new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("ActivityCorrespondence")
				.Where("ActivityId").IsEqual(Column.Parameter(Entity.ActivityId)) as Select;
			int activityCorrespondenceCount = select.ExecuteScalar<int>();
			if (activityCorrespondenceCount > 0) {
				var activityId = FindPartisipantActivity();
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					new Update(UserConnection, "ActivityCorrespondence")
						.Set("ActivityId", Column.Const(null))
						.Where("ActivityId").IsEqual(Column.Parameter(activityId))
					.Execute(dbExecutor);
				}
			}
			Update update = new Update(UserConnection, "Activity")
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Where("Id").IsEqual(Column.Parameter(Entity.GetTypedColumnValue<Guid>("ActivityId"))) as Update;
			update.Execute();
			return true;
		}

		public virtual bool ActivityParticipantSavedScriptExecute(ProcessExecutingContext context) {
			var dbSecurityEngine = UserConnection.DBSecurityEngine;
			var sysAdminUnitESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			var primaryColumn = sysAdminUnitESQ.AddColumn(sysAdminUnitESQ.RootSchema.GetPrimaryColumnName()); 
			sysAdminUnitESQ.Filters.Add(sysAdminUnitESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", Entity.ParticipantId));
			var sysAdminUnits = sysAdminUnitESQ.GetEntityCollection(UserConnection);
			if (sysAdminUnits.Count > 0) {
				var adminUnitId = Guid.Empty;
				foreach (var sysAdminUnit in sysAdminUnits) {
					adminUnitId = sysAdminUnit.GetTypedColumnValue<Guid>(primaryColumn.Name);
					var rightLevel = dbSecurityEngine.GetEntitySchemaRecordRightLevel("Activity", Entity.ActivityId);
					if (!rightLevel.HasFlag(SchemaRecordRightLevels.CanRead) &&
						rightLevel.HasFlag(SchemaRecordRightLevels.CanChangeReadRight)) {
						dbSecurityEngine.SetEntitySchemaRecordOperationRightLevel(adminUnitId, "Activity", Entity.ActivityId, EntitySchemaRecordRightOperation.Read, EntitySchemaRecordRightLevel.Allow);
						if (Entity.RoleId.Equals(Guid.Parse("53FC4A92-B0EA-E111-96C4-00165D094C12"))) {
							dbSecurityEngine.SetEntitySchemaRecordOperationRightLevel(adminUnitId, "Activity", Entity.ActivityId, EntitySchemaRecordRightOperation.Edit, EntitySchemaRecordRightLevel.Allow);
						}
					}
				}
			}
			ActualizeInviteActivityParticipant();
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			UpdateRemindingsExecute();
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			if (IsEntityEmail()) {
				return true;
			}
			if (!IsUnique) {
				var activityId = this.Entity.ActivityId;
				var participantId = this.Entity.ParticipantId;
				var delete = new Delete(UserConnection).From("ActivityParticipant").Where("ActivityId")
					.IsEqual(Column.Parameter(activityId)).And("ParticipantId")
					.IsEqual(Column.Parameter(participantId));
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					delete.Execute(dbExecutor);
				}
			}
			SetInviteActivityParticipant();
			Update update = new Update(UserConnection, "Activity")
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Where("Id").IsEqual(Column.Parameter(Entity.GetTypedColumnValue<Guid>("ActivityId"))) as Update;
			update.Execute();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ActivityParticipantDeleting":
							if (ActivatedEventElements.Contains("ActivityParticipantDeleting")) {
							context.QueueTasks.Enqueue("ActivityParticipantDeleting");
						}
						break;
					case "ActivityParticipantSaved":
							if (ActivatedEventElements.Contains("ActivityParticipantSavedStartMessage1")) {
							context.QueueTasks.Enqueue("ActivityParticipantSavedStartMessage1");
						}
						break;
					case "ActivityParticipantInserting":
							if (ActivatedEventElements.Contains("ActivityParticipantInserting")) {
							context.QueueTasks.Enqueue("ActivityParticipantInserting");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsUnique") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsUnique", IsUnique, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipant_BaseEventsProcess

	/// <exclude/>
	public class ActivityParticipant_BaseEventsProcess : ActivityParticipant_BaseEventsProcess<ActivityParticipant>
	{

		public ActivityParticipant_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityParticipant_BaseEventsProcess

	public partial class ActivityParticipant_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual Guid FindPartisipantActivity() {
			var @ParticipantId = Column.Parameter(Entity.ParticipantId);
			return (new Select(UserConnection).Top(1)
					.Column("ActivityId")
				.From("ActivityParticipant")
				.Where("ParticipantId").IsEqual(@ParticipantId)
				.And().Exists(new Select(UserConnection).Column("Id").From("Activity")
								.Where("OwnerId").IsEqual(@ParticipantId).And("Activity", "Id").IsEqual("ActivityParticipant", "ActivityId"))
				.And().Exists(new Select(UserConnection).Column("Id").From("ActivityCorrespondence")
								.Where("ActivityCorrespondence", "ActivityId").IsEqual("ActivityParticipant", "ActivityId")
								.And("SourceActivityId").IsEqual(new Select(UserConnection).Top(1).Column("SourceActivityId").From("ActivityCorrespondence")
																	.Where("ActivityId").IsEqual(Column.Parameter(Entity.ActivityId)))) as Select).ExecuteScalar<Guid>();
		}

		public virtual void SetInviteActivityParticipant() {
		}

		public virtual void ActualizeInviteActivityParticipant() {
		}

		public virtual Select GetActivitySelect() {
			var activityId = Column.Parameter(Entity.ActivityId);
			return new Select(UserConnection).Top(1)
						.Column("OwnerId")
						.Column("OrganizerId")
					.From("Activity")
					.Where("Id").IsEqual(activityId) as Select;
		}

		public virtual bool IsEntityEmail() {
			var select = new Select(UserConnection).Top(1)
					.Column("TypeId")
				.From("Activity").WithHints(new NoLockHint())
				.Where("Id").IsEqual(Column.Parameter(Entity.ActivityId)) as Select;
			var typeId = select.ExecuteScalar<Guid>();
			return typeId.Equals(ActivityConsts.EmailTypeUId);
		}

		public virtual void UpdateRemindingsExecute() {
			if (Entity.ParticipantId == UserConnection.CurrentUser.ContactId) {
				return;
			}
			Guid id = Entity.GetTypedColumnValue<Guid>("ActivityId");
			if (!IsEntityEmail()) {
				ActivityAnniversaryReminding remindingsGenerator = new ActivityAnniversaryReminding(UserConnection, id);
				remindingsGenerator.Options = new [] { ActivityAnniversaryReminding.ParticipantOption };
				remindingsGenerator.GenerateActualRemindings();
			}
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipantEventsProcessSchema

	/// <exclude/>
	public class ActivityParticipantEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityParticipantEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityParticipantEventsProcessSchema(ActivityParticipantEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityParticipant_BaseEventsProcess";
			UId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb");
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

		protected virtual ProcessSchemaParameter CreateIsUniqueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c5c6ae2d-b71d-4636-a7ba-296ab1c9047f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"IsUnique",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsUniqueParameter());
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
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent activityparticipantdeleting = CreateActivityParticipantDeletingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(activityparticipantdeleting);
			ProcessSchemaScriptTask scriptactivityparticipantdeleting = CreateScriptActivityParticipantDeletingScriptTask();
			eventsubprocess1.FlowElements.Add(scriptactivityparticipantdeleting);
			ProcessSchemaStartMessageEvent activityparticipantsavedstartmessage1 = CreateActivityParticipantSavedStartMessage1StartMessageEvent();
			eventsubprocess2.FlowElements.Add(activityparticipantsavedstartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent activityparticipantsavedintermediatethrowmessageevent1 = CreateActivityParticipantSavedIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(activityparticipantsavedintermediatethrowmessageevent1);
			ProcessSchemaScriptTask activityparticipantsavedscript = CreateActivityParticipantSavedScriptScriptTask();
			eventsubprocess2.FlowElements.Add(activityparticipantsavedscript);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			eventsubprocess2.FlowElements.Add(updateremindings);
			ProcessSchemaStartMessageEvent activityparticipantinserting = CreateActivityParticipantInsertingStartMessageEvent();
			eventsubprocess3.FlowElements.Add(activityparticipantinserting);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess3.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("349aa6c8-d109-40a7-8a8f-5c294db80b1f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CurveCenterPosition = new Point(200, 95),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6415c5e7-8d19-4c9a-a9b5-d8077d566f73"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("367b83fd-66ef-4b10-8ed5-c9100a5b2867"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("2a4d279d-2a42-46d5-90b6-89faede1d690"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CurveCenterPosition = new Point(188, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4227fc1c-1165-42e3-955a-946024866c83"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("845fe4a4-b849-4dd0-a4af-475fd14cf44c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d64cf68b-a2c3-488f-839b-cb8d37929538"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CurveCenterPosition = new Point(300, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("845fe4a4-b849-4dd0-a4af-475fd14cf44c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b68f9ef9-4763-43b7-9a77-ba34343eed6a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("9de1dded-7c45-46e0-930d-4c5697c1fa79"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cac33906-5543-41b4-85f2-2780401cd18c"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CurveCenterPosition = new Point(526, 81),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("92b7c794-e410-4dbf-b026-590e45861403"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("458e6b8a-1a46-47af-b4dc-72ad6d48be87"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("65836e05-cbc8-4921-93a4-0e496eb43af3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4227fc1c-1165-42e3-955a-946024866c83"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b878d1c-e104-4b22-8452-971894f77e45"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(116, 185));
			schemaFlow.PolylinePointPositions.Add(new Point(116, 266));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ee64315a-6a6a-435a-b8d4-ea6292b8434e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(785, 354),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a01531ad-9a72-4dac-8bf2-d1e1255640a5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ee64315a-6a6a-435a-b8d4-ea6292b8434e"),
				CreatedInOwnerSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(756, 354),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("41206455-654f-4020-92ba-15993c2cb63d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a01531ad-9a72-4dac-8bf2-d1e1255640a5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 116),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityParticipantDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6415c5e7-8d19-4c9a-a9b5-d8077d566f73"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("41206455-654f-4020-92ba-15993c2cb63d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityParticipantDeleting",
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"ActivityParticipantDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptActivityParticipantDeletingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("367b83fd-66ef-4b10-8ed5-c9100a5b2867"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("41206455-654f-4020-92ba-15993c2cb63d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"ScriptActivityParticipantDeleting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(153, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,93,107,194,48,20,125,174,224,127,8,125,74,64,194,222,231,132,77,171,248,176,15,168,110,207,89,115,221,2,237,77,151,15,157,140,253,247,165,141,90,29,195,109,80,72,219,156,115,239,57,231,222,28,74,40,28,177,241,184,34,8,27,146,183,31,116,105,193,140,53,98,120,87,26,89,191,151,240,177,46,125,133,116,234,177,8,239,30,29,77,231,50,101,237,221,212,232,138,166,215,1,188,86,110,59,214,198,128,173,53,74,192,2,210,22,241,244,10,6,58,72,195,228,115,155,189,121,81,210,88,153,63,8,35,42,112,96,104,134,46,96,120,7,102,140,8,187,211,118,217,239,41,116,68,252,216,172,21,22,172,68,79,60,123,135,194,59,200,11,81,10,51,12,180,17,101,13,127,69,232,57,254,136,92,48,242,17,100,175,133,57,52,154,203,80,119,170,80,6,157,78,89,85,11,116,123,133,109,213,196,91,133,47,132,54,36,249,28,91,107,19,72,167,97,242,12,173,55,48,185,233,126,81,22,219,37,205,4,150,181,20,14,190,77,96,64,206,165,155,36,60,7,119,146,238,128,236,82,13,53,172,163,232,203,146,237,160,255,26,133,56,154,65,67,223,71,74,59,135,173,247,207,126,47,60,81,59,241,241,136,27,245,155,159,184,31,173,254,91,45,213,74,129,188,199,78,127,39,101,18,202,44,84,5,124,233,138,59,189,97,199,123,245,167,125,154,129,91,108,107,144,241,254,81,148,30,134,51,175,228,232,52,140,184,108,81,118,176,22,205,28,124,55,110,13,56,111,144,56,227,27,192,23,64,212,159,42,71,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("cd3b457b-ec1a-4131-b9bf-bc3965891699"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a01531ad-9a72-4dac-8bf2-d1e1255640a5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 130),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(585, 510),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityParticipantSavedStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4227fc1c-1165-42e3-955a-946024866c83"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cd3b457b-ec1a-4131-b9bf-bc3965891699"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityParticipantSaved",
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"ActivityParticipantSavedStartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(30, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateActivityParticipantSavedIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("845fe4a4-b849-4dd0-a4af-475fd14cf44c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cd3b457b-ec1a-4131-b9bf-bc3965891699"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"ActivityParticipantSaved",
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"ActivityParticipantSavedIntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(126, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityParticipantSavedScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b68f9ef9-4763-43b7-9a77-ba34343eed6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cd3b457b-ec1a-4131-b9bf-bc3965891699"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"ActivityParticipantSavedScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(222, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,93,111,218,64,16,124,54,18,255,225,234,135,232,44,129,5,41,137,132,210,70,114,28,147,34,165,109,2,77,251,124,245,109,224,36,251,206,61,159,137,220,42,255,189,123,28,31,198,33,149,242,86,9,252,224,221,153,217,153,93,88,49,77,248,207,57,164,149,22,166,78,228,66,72,32,31,201,67,9,58,86,82,66,106,132,146,225,245,213,97,199,69,183,179,66,96,89,151,17,207,133,124,144,194,36,243,123,196,73,120,34,137,52,216,56,79,151,144,179,251,10,116,77,91,108,205,134,207,76,178,5,232,30,241,231,13,50,63,216,40,20,90,228,76,215,177,202,170,92,34,127,75,49,140,56,119,53,218,174,204,148,50,78,34,188,1,115,215,228,249,194,114,160,65,112,65,186,157,54,106,34,50,3,186,180,188,47,24,99,13,204,128,235,248,33,204,242,142,105,36,178,237,212,189,140,85,94,48,45,74,37,191,213,5,132,201,175,138,101,104,12,157,27,150,26,191,183,73,38,68,160,17,169,40,152,52,83,30,4,71,194,44,143,88,69,23,14,143,38,50,151,100,43,88,203,36,30,201,193,224,101,24,171,74,26,114,73,6,1,249,211,237,120,86,138,109,171,83,142,66,55,149,224,97,146,23,166,70,188,247,168,208,102,186,36,180,61,19,17,242,112,70,199,231,29,146,53,59,236,200,54,137,205,138,190,179,172,130,15,86,237,146,30,236,53,180,11,177,195,123,235,233,180,88,44,205,45,172,32,67,190,246,109,238,99,112,203,157,65,170,52,159,237,32,212,143,48,139,21,214,247,121,111,223,96,216,107,17,155,209,187,189,74,248,137,149,147,140,45,232,113,70,76,144,201,25,48,30,144,147,19,11,247,222,6,141,151,76,46,192,18,172,11,193,38,54,239,133,179,249,49,103,95,11,208,204,46,183,97,177,145,56,158,215,191,252,246,200,43,89,237,104,67,59,216,171,109,206,100,148,101,234,201,69,183,206,110,35,51,83,25,76,185,59,243,146,174,175,8,47,187,4,234,159,189,159,196,163,104,124,218,191,26,36,81,63,25,14,135,253,241,121,60,234,15,6,195,243,179,235,193,120,20,15,79,253,96,151,196,255,18,69,194,133,121,67,20,207,246,105,31,248,197,15,74,97,16,226,55,76,37,42,194,86,185,241,99,167,22,168,193,84,90,18,163,43,251,47,250,23,25,230,30,51,127,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4b878d1c-e104-4b22-8452-971894f77e45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cd3b457b-ec1a-4131-b9bf-bc3965891699"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(105, 109),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,74,205,205,204,75,201,204,75,47,118,173,72,77,46,45,73,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,103,2,161,1,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e5e7da00-1777-45ce-8e0f-24fc45c17f4d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a01531ad-9a72-4dac-8bf2-d1e1255640a5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(796, 75),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(364, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityParticipantInsertingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("92b7c794-e410-4dbf-b026-590e45861403"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e5e7da00-1777-45ce-8e0f-24fc45c17f4d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityParticipantInserting",
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"ActivityParticipantInserting",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("458e6b8a-1a46-47af-b4dc-72ad6d48be87"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e5e7da00-1777-45ce-8e0f-24fc45c17f4d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("cac33906-5543-41b4-85f2-2780401cd18c"),
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(147, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,77,110,194,48,16,133,215,32,113,7,55,43,91,66,190,0,109,37,10,20,101,209,31,169,164,93,187,241,80,44,37,118,112,108,40,170,184,123,39,113,72,72,105,213,85,100,207,155,231,121,223,68,173,9,141,203,133,118,202,29,22,185,80,25,101,140,124,141,134,3,11,206,91,77,156,245,48,25,13,143,163,161,66,229,85,92,38,90,109,61,4,205,78,88,34,82,167,118,216,28,75,114,67,220,70,149,60,152,241,105,91,152,52,210,66,88,167,82,85,8,237,46,212,207,231,181,83,131,132,12,28,160,82,195,158,204,235,3,77,74,176,51,163,53,160,189,209,140,223,91,147,211,232,244,216,153,77,196,248,219,6,44,116,197,88,70,12,157,7,28,3,111,189,200,232,204,100,62,215,213,219,34,71,111,75,187,48,140,241,169,150,52,234,205,245,95,123,47,32,99,85,12,95,42,253,65,104,157,230,125,241,9,169,119,198,98,162,126,12,164,80,122,11,243,187,238,234,180,135,65,128,192,67,47,208,206,165,246,63,214,187,121,1,23,107,28,28,126,225,64,43,93,82,72,129,36,125,248,4,160,225,238,7,208,49,105,113,213,105,57,90,211,232,193,72,181,86,32,159,116,52,38,23,177,231,104,179,82,57,240,196,165,143,102,207,234,190,134,125,5,237,111,96,205,242,151,224,86,135,2,100,168,191,138,204,195,245,210,43,121,219,223,29,18,17,101,51,54,102,10,97,90,48,85,204,243,159,246,27,50,193,141,62,218,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFindPartisipantActivityMethod());
			Methods.Add(CreateSetInviteActivityParticipantMethod());
			Methods.Add(CreateActualizeInviteActivityParticipantMethod());
			Methods.Add(CreateGetActivitySelectMethod());
			Methods.Add(CreateIsEntityEmailMethod());
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

		protected virtual SchemaMethod CreateFindPartisipantActivityMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("25c52964-a356-455b-b676-606176f36972"),
				Name = "FindPartisipantActivity",
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,223,75,195,48,16,126,222,254,138,208,167,4,36,224,243,84,28,165,74,159,20,170,248,28,210,3,3,237,165,94,146,77,255,123,211,186,173,75,233,166,3,239,41,92,190,251,126,36,183,81,196,238,159,21,121,163,77,167,208,151,53,187,101,185,109,66,139,50,182,85,11,30,136,23,232,141,255,146,9,78,172,150,4,62,16,50,142,176,101,21,52,160,61,127,117,64,185,69,140,103,99,81,200,23,219,241,107,177,92,44,228,15,41,207,214,241,102,19,217,202,58,139,125,249,64,182,29,155,71,10,195,237,219,59,16,240,44,17,206,132,44,93,241,17,84,195,83,231,253,192,26,107,46,100,241,105,156,119,231,124,237,221,12,116,169,135,94,184,175,189,248,211,22,129,206,201,14,162,227,248,21,203,18,244,108,184,8,58,126,136,127,178,158,91,34,112,157,197,26,80,195,52,200,9,212,196,202,69,190,119,2,195,3,84,54,144,134,89,170,95,23,228,16,106,134,228,47,17,15,53,205,154,216,56,181,215,35,88,196,98,202,237,204,246,191,1,58,120,168,180,106,20,221,60,6,83,223,113,177,250,6,50,15,85,71,53,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetInviteActivityParticipantMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cd67905d-81f9-45cb-9abc-7acc1916c8bc"),
				Name = "SetInviteActivityParticipant",
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateActualizeInviteActivityParticipantMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d55e2d15-8bba-4570-a254-9d6c728bd4da"),
				Name = "ActualizeInviteActivityParticipant",
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CreatedInPackageId = new Guid("a6558c63-9ae0-4b9f-a2aa-711d80b4faa2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateGetActivitySelectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4b7af4b5-b579-4f47-8417-6e3b9ec30c94"),
				Name = "GetActivitySelect",
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CreatedInPackageId = new Guid("a6558c63-9ae0-4b9f-a2aa-711d80b4faa2"),
				ResultValueTypeName = "Select"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,65,11,130,64,20,132,207,10,254,135,101,79,111,47,11,157,165,67,136,193,158,10,42,58,63,244,81,11,250,182,158,171,82,191,62,35,75,232,54,204,124,204,204,128,162,176,138,126,240,241,225,106,181,86,69,104,250,150,237,30,5,91,138,36,80,114,156,50,187,249,65,38,207,82,161,216,11,43,166,81,29,168,161,42,194,169,35,41,2,243,164,125,96,99,143,225,6,43,147,165,73,146,216,79,39,232,221,200,36,174,214,255,182,92,144,253,115,137,236,86,66,11,250,59,57,155,231,43,9,129,126,67,214,117,229,189,199,6,150,235,70,97,55,127,201,95,128,62,20,149,213,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsEntityEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("aca9c225-323c-426d-9c6c-3a86f87059d2"),
				Name = "IsEntityEmail",
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,143,65,107,195,48,12,133,207,205,175,48,62,201,23,193,206,105,7,163,100,91,96,140,65,91,122,54,137,160,102,142,221,201,114,186,254,251,218,105,123,211,19,79,159,222,155,45,171,68,158,6,81,27,21,232,162,118,139,128,67,34,222,198,16,202,236,98,48,184,143,103,120,49,205,106,133,219,232,243,20,64,239,175,103,234,71,93,118,248,206,113,2,253,86,172,179,147,171,54,120,116,114,250,116,65,18,84,228,119,252,138,195,111,213,96,170,253,120,34,38,208,245,24,251,212,253,101,235,225,78,197,31,203,118,34,33,134,46,72,97,225,19,218,143,198,40,155,30,241,218,102,46,185,101,73,80,114,223,11,96,247,79,67,22,218,13,214,91,94,127,100,55,190,130,105,27,38,201,28,30,110,92,222,37,120,114,75,199,36,9,187,201,58,95,27,29,202,163,246,6,161,131,81,116,21,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateRemindingsExecuteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2cc8d501-53b2-43cd-8c63-6ecea2f59b99"),
				Name = "UpdateRemindingsExecute",
				CreatedInSchemaUId = new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,74,195,64,16,134,207,205,83,140,61,109,64,242,2,53,66,9,37,228,100,41,234,69,60,44,201,40,3,201,36,204,206,86,66,201,187,59,177,169,40,104,97,15,195,240,253,223,254,187,244,6,110,199,74,58,102,123,47,74,53,13,158,181,106,32,207,225,41,160,20,61,51,214,74,61,103,69,20,65,214,121,155,217,90,125,109,92,10,167,100,37,168,81,120,147,76,73,25,169,1,59,57,44,210,18,245,113,28,176,41,250,54,118,252,236,219,136,119,51,116,239,214,91,211,30,141,169,154,117,186,73,200,138,220,84,225,28,219,117,158,90,151,126,201,47,216,150,153,142,40,193,203,120,192,142,184,33,126,7,185,76,161,68,70,241,218,139,221,205,248,1,215,98,238,247,203,110,173,177,53,88,253,33,203,30,134,153,8,139,244,229,21,78,87,205,63,63,241,28,133,233,31,243,50,161,233,162,111,191,13,193,89,149,233,19,238,103,160,153,151,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityParticipantEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd8e3f54-0637-4600-ac7f-27e1bac584fb"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityParticipantEventsProcess

	/// <exclude/>
	public class ActivityParticipantEventsProcess : ActivityParticipant_BaseEventsProcess
	{

		public ActivityParticipantEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

