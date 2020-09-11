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

	#region Class: File_Base_TerrasoftSchema

	/// <exclude/>
	public class File_Base_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public File_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public File_Base_TerrasoftSchema(File_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public File_Base_TerrasoftSchema(File_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			RealUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			Name = "File_Base_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8f7c60c3-7d35-4de4-a234-6e18470eb34c")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("6b37344b-b460-44c5-9fd7-a623689bba4c")) == null) {
				Columns.Add(CreateLockedByColumn());
			}
			if (Columns.FindByUId(new Guid("f906243b-8d5c-48f0-8220-89d5c9175806")) == null) {
				Columns.Add(CreateLockedOnColumn());
			}
			if (Columns.FindByUId(new Guid("73c5b07b-3c1a-44fc-953e-f2ce6cbb7420")) == null) {
				Columns.Add(CreateDataColumn());
			}
			if (Columns.FindByUId(new Guid("6255f70e-45c9-4346-8ee0-8d604459e7d8")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("8d8676ce-6974-4157-9a96-841d4499fccb")) == null) {
				Columns.Add(CreateVersionColumn());
			}
			if (Columns.FindByUId(new Guid("5d9d91dd-892d-4652-8da1-e7a53b96ba4a")) == null) {
				Columns.Add(CreateSizeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4a35bb09-6c8c-4de8-8773-4e9e3b3cf3b0"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8f7c60c3-7d35-4de4-a234-6e18470eb34c"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLockedByColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6b37344b-b460-44c5-9fd7-a623689bba4c"),
				Name = @"LockedBy",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLockedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("f906243b-8d5c-48f0-8220-89d5c9175806"),
				Name = @"LockedOn",
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("73c5b07b-3c1a-44fc-953e-f2ce6cbb7420"),
				Name = @"Data",
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6255f70e-45c9-4346-8ee0-8d604459e7d8"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("3c6fc826-bca3-49a7-ae4c-7e9454b386a5"),
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateVersionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("8d8676ce-6974-4157-9a96-841d4499fccb"),
				Name = @"Version",
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSizeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5d9d91dd-892d-4652-8da1-e7a53b96ba4a"),
				Name = @"Size",
				CreatedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				ModifiedInSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFile_Base_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateFile_Base_TerrasoftEventsProcessSchema() {
			var schema = new File_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new File_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new File_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new File_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new File_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("556c5867-60a7-4456-aae1-a57a122bef70"));
		}

		#endregion

	}

	#endregion

	#region Class: File_Base_Terrasoft

	/// <summary>
	/// File.
	/// </summary>
	public class File_Base_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public File_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "File_Base_Terrasoft";
		}

		public File_Base_Terrasoft(File_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid LockedById {
			get {
				return GetTypedColumnValue<Guid>("LockedById");
			}
			set {
				SetColumnValue("LockedById", value);
				_lockedBy = null;
			}
		}

		/// <exclude/>
		public string LockedByName {
			get {
				return GetTypedColumnValue<string>("LockedByName");
			}
			set {
				SetColumnValue("LockedByName", value);
				if (_lockedBy != null) {
					_lockedBy.Name = value;
				}
			}
		}

		private Contact _lockedBy;
		/// <summary>
		/// Locked by.
		/// </summary>
		public Contact LockedBy {
			get {
				return _lockedBy ??
					(_lockedBy = LookupColumnEntities.GetEntity("LockedBy") as Contact);
			}
		}

		/// <summary>
		/// Locked on.
		/// </summary>
		public DateTime LockedOn {
			get {
				return GetTypedColumnValue<DateTime>("LockedOn");
			}
			set {
				SetColumnValue("LockedOn", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private FileType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public FileType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as FileType);
			}
		}

		/// <summary>
		/// Version.
		/// </summary>
		public int Version {
			get {
				return GetTypedColumnValue<int>("Version");
			}
			set {
				SetColumnValue("Version", value);
			}
		}

		/// <summary>
		/// File size.
		/// </summary>
		public int Size {
			get {
				return GetTypedColumnValue<int>("Size");
			}
			set {
				SetColumnValue("Size", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new File_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("File_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("File_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("File_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("File_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("File_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("File_Base_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("File_Base_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("File_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new File_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: File_BaseEventsProcess

	/// <exclude/>
	public partial class File_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : File_Base_Terrasoft
	{

		public File_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "File_BaseEventsProcess";
			SchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _subProcessFileSaving;
		public ProcessFlowElement SubProcessFileSaving {
			get {
				return _subProcessFileSaving ?? (_subProcessFileSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessFileSaving",
					SchemaElementUId = new Guid("c4a1ae26-a39e-43e2-b93d-c5cb941bcc9b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _fileSaving;
		public ProcessFlowElement FileSaving {
			get {
				return _fileSaving ?? (_fileSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "FileSaving",
					SchemaElementUId = new Guid("db0a76ef-5451-47e8-b959-cd2c064f9357"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptFileSaving;
		public ProcessScriptTask ScriptFileSaving {
			get {
				return _scriptFileSaving ?? (_scriptFileSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptFileSaving",
					SchemaElementUId = new Guid("5ba15992-0baa-42d9-8a7d-59869fa5068f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptFileSavingExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess_FileSaved_Base;
		public ProcessFlowElement EventSubProcess_FileSaved_Base {
			get {
				return _eventSubProcess_FileSaved_Base ?? (_eventSubProcess_FileSaved_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess_FileSaved_Base",
					SchemaElementUId = new Guid("2fef8c1d-3142-4adf-a4b6-4b392df860a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage_FileSaved_Base;
		public ProcessFlowElement StartMessage_FileSaved_Base {
			get {
				return _startMessage_FileSaved_Base ?? (_startMessage_FileSaved_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage_FileSaved_Base",
					SchemaElementUId = new Guid("ccdb328d-e3ec-4c15-b0c0-6a9e57fc3689"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_FileSaved_Base;
		public ProcessScriptTask ScriptTask_FileSaved_Base {
			get {
				return _scriptTask_FileSaved_Base ?? (_scriptTask_FileSaved_Base = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_FileSaved_Base",
					SchemaElementUId = new Guid("4b235097-edd5-4001-b093-fba760960c0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_FileSaved_BaseExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess_FileDeleted_Base;
		public ProcessFlowElement EventSubProcess_FileDeleted_Base {
			get {
				return _eventSubProcess_FileDeleted_Base ?? (_eventSubProcess_FileDeleted_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess_FileDeleted_Base",
					SchemaElementUId = new Guid("1f7586d6-f5b2-4137-b2f4-7b0201162878"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage_FileDeleted_Base;
		public ProcessFlowElement StartMessage_FileDeleted_Base {
			get {
				return _startMessage_FileDeleted_Base ?? (_startMessage_FileDeleted_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage_FileDeleted_Base",
					SchemaElementUId = new Guid("0d0cfcdd-3777-4972-8ce9-b546177fc794"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_FileDeleted_Base;
		public ProcessScriptTask ScriptTask_FileDeleted_Base {
			get {
				return _scriptTask_FileDeleted_Base ?? (_scriptTask_FileDeleted_Base = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_FileDeleted_Base",
					SchemaElementUId = new Guid("1413793a-ca7c-43d4-8067-b342ffeb4005"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_FileDeleted_BaseExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess_FileUpdated_Base;
		public ProcessFlowElement EventSubProcess_FileUpdated_Base {
			get {
				return _eventSubProcess_FileUpdated_Base ?? (_eventSubProcess_FileUpdated_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess_FileUpdated_Base",
					SchemaElementUId = new Guid("61e148aa-c479-405e-8567-d2e981eca9a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage_FileUpdated_Base;
		public ProcessFlowElement StartMessage_FileUpdated_Base {
			get {
				return _startMessage_FileUpdated_Base ?? (_startMessage_FileUpdated_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage_FileUpdated_Base",
					SchemaElementUId = new Guid("de5fd116-8a33-473b-8958-d1427e228f45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_FileUpdated_Base;
		public ProcessScriptTask ScriptTask_FileUpdated_Base {
			get {
				return _scriptTask_FileUpdated_Base ?? (_scriptTask_FileUpdated_Base = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_FileUpdated_Base",
					SchemaElementUId = new Guid("46a65bf2-fe91-411a-a013-a1eb643d74c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_FileUpdated_BaseExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessFileSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessFileSaving };
			FlowElements[FileSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { FileSaving };
			FlowElements[ScriptFileSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptFileSaving };
			FlowElements[EventSubProcess_FileSaved_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess_FileSaved_Base };
			FlowElements[StartMessage_FileSaved_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage_FileSaved_Base };
			FlowElements[ScriptTask_FileSaved_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_FileSaved_Base };
			FlowElements[EventSubProcess_FileDeleted_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess_FileDeleted_Base };
			FlowElements[StartMessage_FileDeleted_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage_FileDeleted_Base };
			FlowElements[ScriptTask_FileDeleted_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_FileDeleted_Base };
			FlowElements[EventSubProcess_FileUpdated_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess_FileUpdated_Base };
			FlowElements[StartMessage_FileUpdated_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage_FileUpdated_Base };
			FlowElements[ScriptTask_FileUpdated_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_FileUpdated_Base };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessFileSaving":
						break;
					case "FileSaving":
						e.Context.QueueTasks.Enqueue("ScriptFileSaving");
						break;
					case "ScriptFileSaving":
						break;
					case "EventSubProcess_FileSaved_Base":
						break;
					case "StartMessage_FileSaved_Base":
						e.Context.QueueTasks.Enqueue("ScriptTask_FileSaved_Base");
						break;
					case "ScriptTask_FileSaved_Base":
						break;
					case "EventSubProcess_FileDeleted_Base":
						break;
					case "StartMessage_FileDeleted_Base":
						e.Context.QueueTasks.Enqueue("ScriptTask_FileDeleted_Base");
						break;
					case "ScriptTask_FileDeleted_Base":
						break;
					case "EventSubProcess_FileUpdated_Base":
						break;
					case "StartMessage_FileUpdated_Base":
						e.Context.QueueTasks.Enqueue("ScriptTask_FileUpdated_Base");
						break;
					case "ScriptTask_FileUpdated_Base":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("FileSaving");
			ActivatedEventElements.Add("StartMessage_FileSaved_Base");
			ActivatedEventElements.Add("StartMessage_FileDeleted_Base");
			ActivatedEventElements.Add("StartMessage_FileUpdated_Base");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessFileSaving":
					context.QueueTasks.Dequeue();
					break;
				case "FileSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "FileSaving";
					result = FileSaving.Execute(context);
					break;
				case "ScriptFileSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptFileSaving";
					result = ScriptFileSaving.Execute(context, ScriptFileSavingExecute);
					break;
				case "EventSubProcess_FileSaved_Base":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage_FileSaved_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage_FileSaved_Base";
					result = StartMessage_FileSaved_Base.Execute(context);
					break;
				case "ScriptTask_FileSaved_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_FileSaved_Base";
					result = ScriptTask_FileSaved_Base.Execute(context, ScriptTask_FileSaved_BaseExecute);
					break;
				case "EventSubProcess_FileDeleted_Base":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage_FileDeleted_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage_FileDeleted_Base";
					result = StartMessage_FileDeleted_Base.Execute(context);
					break;
				case "ScriptTask_FileDeleted_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_FileDeleted_Base";
					result = ScriptTask_FileDeleted_Base.Execute(context, ScriptTask_FileDeleted_BaseExecute);
					break;
				case "EventSubProcess_FileUpdated_Base":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage_FileUpdated_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage_FileUpdated_Base";
					result = StartMessage_FileUpdated_Base.Execute(context);
					break;
				case "ScriptTask_FileUpdated_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_FileUpdated_Base";
					result = ScriptTask_FileUpdated_Base.Execute(context, ScriptTask_FileUpdated_BaseExecute);
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

		public virtual bool ScriptFileSavingExecute(ProcessExecutingContext context) {
			OnFileSaving();
			return true;
		}

		public virtual bool ScriptTask_FileSaved_BaseExecute(ProcessExecutingContext context) {
			OnFileSaved();
			return true;
		}

		public virtual bool ScriptTask_FileDeleted_BaseExecute(ProcessExecutingContext context) {
			OnFileDeleted();
			return true;
		}

		public virtual bool ScriptTask_FileUpdated_BaseExecute(ProcessExecutingContext context) {
			OnFileUpdated();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "File_Base_TerrasoftSaving":
							if (ActivatedEventElements.Contains("FileSaving")) {
							context.QueueTasks.Enqueue("FileSaving");
						}
						break;
					case "File_Base_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage_FileSaved_Base")) {
							context.QueueTasks.Enqueue("StartMessage_FileSaved_Base");
						}
						break;
					case "File_Base_TerrasoftDeleted":
							if (ActivatedEventElements.Contains("StartMessage_FileDeleted_Base")) {
							context.QueueTasks.Enqueue("StartMessage_FileDeleted_Base");
						}
						break;
					case "File_Base_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("StartMessage_FileUpdated_Base")) {
							context.QueueTasks.Enqueue("StartMessage_FileUpdated_Base");
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

	#region Class: File_BaseEventsProcess

	/// <exclude/>
	public class File_BaseEventsProcess : File_BaseEventsProcess<File_Base_Terrasoft>
	{

		public File_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: File_BaseEventsProcess

	public partial class File_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnFileSaving() {
			Nullable<int> version = Entity.GetTypedOldColumnValue<int>("Version") as Nullable<int>;
			version = (version == null) ? 1 : version;
			var increaseVersion = false;
			var changedColumnValues = Entity.GetChangedColumnValues();
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (fileType == Terrasoft.WebApp.FileConsts.FileTypeUId) {
				if(changedColumnValues.FirstOrDefault(col => col.Name == "Data") != null) {
					increaseVersion = true;
				}
				var data = Entity.GetColumnValue("Data") as byte[];
				var fileSize = Entity.GetTypedColumnValue<int>("Size");
				if (fileSize == 0 && data != null) {
					Entity.SetColumnValue("Size", data.Length);
				}
			} else {
				var nameOldValue = Entity.GetTypedOldColumnValue<string>("Name");
				var nameNewValue = Entity.GetTypedColumnValue<string>("Name");
				if (nameNewValue != nameOldValue) {
					increaseVersion = true;		
				}
			}
			if (increaseVersion) {
				Entity.SetColumnValue("Version", version + 1);
			} else {
				Entity.SetColumnValue("Version", version);
			}
		}

		public virtual void OnFileSaved() {
		}

		public virtual void OnFileDeleted() {
		}

		public virtual void OnFileUpdated() {
		}

		#endregion

	}

	#endregion

	#region Class: File_Base_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class File_Base_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public File_Base_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public File_Base_TerrasoftEventsProcessSchema(File_Base_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "File_BaseEventsProcess";
			UId = new Guid("46370786-d48d-4d24-916a-dc11d551add9");
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
			ProcessSchemaLaneSet schemaLaneSet392 = CreateLaneSet392LaneSet();
			LaneSets.Add(schemaLaneSet392);
			ProcessSchemaLane schemaLane1190 = CreateLane1190Lane();
			schemaLaneSet392.Lanes.Add(schemaLane1190);
			ProcessSchemaEventSubProcess subprocessfilesaving = CreateSubProcessFileSavingEventSubProcess();
			FlowElements.Add(subprocessfilesaving);
			ProcessSchemaEventSubProcess eventsubprocess_filesaved_base = CreateEventSubProcess_FileSaved_BaseEventSubProcess();
			FlowElements.Add(eventsubprocess_filesaved_base);
			ProcessSchemaEventSubProcess eventsubprocess_filedeleted_base = CreateEventSubProcess_FileDeleted_BaseEventSubProcess();
			FlowElements.Add(eventsubprocess_filedeleted_base);
			ProcessSchemaEventSubProcess eventsubprocess_fileupdated_base = CreateEventSubProcess_FileUpdated_BaseEventSubProcess();
			FlowElements.Add(eventsubprocess_fileupdated_base);
			ProcessSchemaStartMessageEvent filesaving = CreateFileSavingStartMessageEvent();
			subprocessfilesaving.FlowElements.Add(filesaving);
			ProcessSchemaScriptTask scriptfilesaving = CreateScriptFileSavingScriptTask();
			subprocessfilesaving.FlowElements.Add(scriptfilesaving);
			ProcessSchemaStartMessageEvent startmessage_filesaved_base = CreateStartMessage_FileSaved_BaseStartMessageEvent();
			eventsubprocess_filesaved_base.FlowElements.Add(startmessage_filesaved_base);
			ProcessSchemaScriptTask scripttask_filesaved_base = CreateScriptTask_FileSaved_BaseScriptTask();
			eventsubprocess_filesaved_base.FlowElements.Add(scripttask_filesaved_base);
			ProcessSchemaStartMessageEvent startmessage_filedeleted_base = CreateStartMessage_FileDeleted_BaseStartMessageEvent();
			eventsubprocess_filedeleted_base.FlowElements.Add(startmessage_filedeleted_base);
			ProcessSchemaScriptTask scripttask_filedeleted_base = CreateScriptTask_FileDeleted_BaseScriptTask();
			eventsubprocess_filedeleted_base.FlowElements.Add(scripttask_filedeleted_base);
			ProcessSchemaStartMessageEvent startmessage_fileupdated_base = CreateStartMessage_FileUpdated_BaseStartMessageEvent();
			eventsubprocess_fileupdated_base.FlowElements.Add(startmessage_fileupdated_base);
			ProcessSchemaScriptTask scripttask_fileupdated_base = CreateScriptTask_FileUpdated_BaseScriptTask();
			eventsubprocess_fileupdated_base.FlowElements.Add(scripttask_fileupdated_base);
			FlowElements.Add(CreateSequenceFlow6804SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2_085e941f87c54e2aa39bfe2e6f88498eSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_d185b03d4cce4e14a9055f5d3a5d0215SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4_f25dcc5e0d2246fbba614f708e92cfe7SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6804SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6804",
				UId = new Guid("18406668-7604-41ed-8cd3-2a5b69c949a5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CurveCenterPosition = new Point(168, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("db0a76ef-5451-47e8-b959-cd2c064f9357"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ba15992-0baa-42d9-8a7d-59869fa5068f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_085e941f87c54e2aa39bfe2e6f88498eSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_085e941f87c54e2aa39bfe2e6f88498e",
				UId = new Guid("085e941f-87c5-4e2a-a39b-fe2e6f88498e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ccdb328d-e3ec-4c15-b0c0-6a9e57fc3689"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4b235097-edd5-4001-b093-fba760960c0d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_d185b03d4cce4e14a9055f5d3a5d0215SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_d185b03d4cce4e14a9055f5d3a5d0215",
				UId = new Guid("d185b03d-4cce-4e14-a905-5f5d3a5d0215"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0d0cfcdd-3777-4972-8ce9-b546177fc794"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1413793a-ca7c-43d4-8067-b342ffeb4005"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_f25dcc5e0d2246fbba614f708e92cfe7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_f25dcc5e0d2246fbba614f708e92cfe7",
				UId = new Guid("f25dcc5e-0d22-46fb-ba61-4f708e92cfe7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de5fd116-8a33-473b-8958-d1427e228f45"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46a65bf2-fe91-411a-a013-a1eb643d74c7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(415, 240));
			schemaFlow.PolylinePointPositions.Add(new Point(415, 238));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet392LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet392 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("0d3b3bd4-cde8-4f82-8374-c41ae6cf1065"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"LaneSet392",
				Position = new Point(5, 5),
				Size = new Size(1417, 149),
				UseBackgroundMode = false
			};
			return schemaLaneSet392;
		}

		protected virtual ProcessSchemaLane CreateLane1190Lane() {
			ProcessSchemaLane schemaLane1190 = new ProcessSchemaLane(this) {
				UId = new Guid("6a6c05a2-8b0c-4243-9ff0-0b5b5dec18e1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("0d3b3bd4-cde8-4f82-8374-c41ae6cf1065"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"Lane1190",
				Position = new Point(29, 0),
				Size = new Size(1388, 149),
				UseBackgroundMode = false
			};
			return schemaLane1190;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessFileSavingEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessFileSaving = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c4a1ae26-a39e-43e2-b93d-c5cb941bcc9b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a6c05a2-8b0c-4243-9ff0-0b5b5dec18e1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"SubProcessFileSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(225, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessFileSaving;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateFileSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("db0a76ef-5451-47e8-b959-cd2c064f9357"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c4a1ae26-a39e-43e2-b93d-c5cb941bcc9b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FileSaving",
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"FileSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptFileSavingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5ba15992-0baa-42d9-8a7d-59869fa5068f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c4a1ae26-a39e-43e2-b93d-c5cb941bcc9b"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"ScriptFileSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,203,204,73,13,78,44,203,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,22,250,195,155,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess_FileSaved_BaseEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess_FileSaved_Base = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2fef8c1d-3142-4adf-a4b6-4b392df860a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a6c05a2-8b0c-4243-9ff0-0b5b5dec18e1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"EventSubProcess_FileSaved_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(304, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(276, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess_FileSaved_Base;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage_FileSaved_BaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ccdb328d-e3ec-4c15-b0c0-6a9e57fc3689"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fef8c1d-3142-4adf-a4b6-4b392df860a5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FileSaved",
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"StartMessage_FileSaved_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_FileSaved_BaseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4b235097-edd5-4001-b093-fba760960c0d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2fef8c1d-3142-4adf-a4b6-4b392df860a5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"ScriptTask_FileSaved_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(167, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,203,204,73,13,78,44,75,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,192,52,71,88,27,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess_FileDeleted_BaseEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess_FileDeleted_Base = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1f7586d6-f5b2-4137-b2f4-7b0201162878"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a6c05a2-8b0c-4243-9ff0-0b5b5dec18e1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"EventSubProcess_FileDeleted_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(34, 178),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(226, 122),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess_FileDeleted_Base;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage_FileDeleted_BaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0d0cfcdd-3777-4972-8ce9-b546177fc794"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f7586d6-f5b2-4137-b2f4-7b0201162878"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FileDeleted",
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"StartMessage_FileDeleted_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(37, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_FileDeleted_BaseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1413793a-ca7c-43d4-8067-b342ffeb4005"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1f7586d6-f5b2-4137-b2f4-7b0201162878"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"ScriptTask_FileDeleted_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(121, 22),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,203,204,73,117,73,205,73,45,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,237,166,8,91,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess_FileUpdated_BaseEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess_FileUpdated_Base = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("61e148aa-c479-405e-8567-d2e981eca9a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a6c05a2-8b0c-4243-9ff0-0b5b5dec18e1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"EventSubProcess_FileUpdated_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(304, 180),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(276, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess_FileUpdated_Base;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage_FileUpdated_BaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("de5fd116-8a33-473b-8958-d1427e228f45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e148aa-c479-405e-8567-d2e981eca9a1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"FileUpdated",
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"StartMessage_FileUpdated_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 47),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_FileUpdated_BaseScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("46a65bf2-fe91-411a-a013-a1eb643d74c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("61e148aa-c479-405e-8567-d2e981eca9a1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				Name = @"ScriptTask_FileUpdated_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(159, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,203,204,73,13,45,72,73,44,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,219,149,104,72,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateOnFileSavingMethod());
			Methods.Add(CreateOnFileSavedMethod());
			Methods.Add(CreateOnFileDeletedMethod());
			Methods.Add(CreateOnFileUpdatedMethod());
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
				UId = new Guid("8344487b-4f62-45ad-a3a1-e073f07b2ef2"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e33423da-6c95-41fd-bf98-97c4161975e5"),
				Name = "System.Linq",
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

		protected virtual SchemaMethod CreateOnFileSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("39ba4d7f-19f4-4ec8-acf0-c5beb68e14da"),
				Name = "OnFileSaving",
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,65,79,194,48,24,61,143,132,255,240,185,3,217,34,89,228,42,14,99,64,9,137,25,7,16,15,198,67,97,223,160,73,233,72,219,105,208,240,223,109,187,13,54,16,241,176,108,89,223,123,125,239,125,109,148,49,70,230,12,239,40,87,61,248,64,33,105,202,33,132,71,174,168,218,6,67,84,211,237,6,227,49,139,251,41,203,214,124,70,88,150,131,61,119,150,163,93,31,136,132,168,42,212,109,54,14,82,222,254,51,4,174,81,62,220,67,7,110,203,205,12,150,8,160,124,33,144,72,156,237,121,9,97,18,139,213,197,138,240,37,86,61,200,154,201,254,233,186,231,23,220,132,50,52,33,78,83,85,35,13,51,26,235,76,230,255,40,118,13,151,38,224,29,184,33,76,81,8,34,211,68,5,175,56,127,216,108,130,39,189,216,79,185,84,210,126,26,220,203,40,246,225,187,217,112,104,226,253,226,89,227,132,84,99,49,192,132,100,76,121,139,148,65,216,3,253,10,34,178,182,187,184,3,162,136,174,244,170,44,203,168,57,167,237,40,145,153,114,156,157,126,76,202,88,211,234,149,28,246,245,74,81,61,167,249,86,225,219,123,183,96,153,124,19,250,117,161,155,124,220,6,103,139,113,202,102,114,102,8,55,208,106,229,6,234,174,11,201,201,145,25,43,212,182,132,224,25,249,82,173,252,34,201,14,80,207,220,146,141,59,174,59,209,39,207,210,46,158,73,169,4,229,75,237,211,52,153,251,44,53,34,252,60,163,113,65,192,4,173,9,152,124,21,83,127,79,199,113,138,84,249,89,58,66,229,220,51,21,149,87,171,189,191,146,215,208,49,150,42,13,253,151,106,105,63,76,78,249,72,232,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnFileSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d48d411e-e260-4a8f-b49b-e7411b903edd"),
				Name = "OnFileSaved",
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateOnFileDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3b87d6e4-9e59-4708-8f49-4e044afab825"),
				Name = "OnFileDeleted",
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		protected virtual SchemaMethod CreateOnFileUpdatedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6d72dbba-d847-4836-b819-dde2bec48e44"),
				Name = "OnFileUpdated",
				CreatedInSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] {  };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new File_Base_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46370786-d48d-4d24-916a-dc11d551add9"));
		}

		#endregion

	}

	#endregion

}

