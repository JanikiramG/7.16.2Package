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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: VwWorkspaceObjectsSchema

	/// <exclude/>
	public class VwWorkspaceObjectsSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public VwWorkspaceObjectsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwWorkspaceObjectsSchema(VwWorkspaceObjectsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwWorkspaceObjectsSchema(VwWorkspaceObjectsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e");
			RealUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e");
			Name = "VwWorkspaceObjects";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c7227eee-1b80-4db9-9f3a-cfdaa562ae3d")) == null) {
				Columns.Add(CreateIsModuleColumn());
			}
			if (Columns.FindByUId(new Guid("356fed4d-7b90-41aa-9d61-2cfe1df9e9fc")) == null) {
				Columns.Add(CreateIsLookupColumn());
			}
			if (Columns.FindByUId(new Guid("278b1727-05db-41b5-a80c-72fc962430ee")) == null) {
				Columns.Add(CreateAdministratedByRecordsColumn());
			}
			if (Columns.FindByUId(new Guid("c449bd15-1392-4a02-b1d3-f3852c194ebf")) == null) {
				Columns.Add(CreateAdministratedByColumnsColumn());
			}
			if (Columns.FindByUId(new Guid("b12eda60-9b6a-4295-a281-8bd1fd1c2d33")) == null) {
				Columns.Add(CreateAdministratedByOperationsColumn());
			}
			if (Columns.FindByUId(new Guid("b7a4479c-74c2-4491-bca8-a03c0c093458")) == null) {
				Columns.Add(CreateSysWorkspaceColumn());
			}
			if (Columns.FindByUId(new Guid("b076dce7-a486-4584-a06e-567972ab10c8")) == null) {
				Columns.Add(CreateIsTrackChangesInDBColumn());
			}
			if (Columns.FindByUId(new Guid("117b0843-3caf-41b7-9f04-59ef867d640d")) == null) {
				Columns.Add(CreateIsInSSPEntitySchemaAccessListColumn());
			}
			if (Columns.FindByUId(new Guid("50b78acd-9cab-49e3-812a-fd96337814a9")) == null) {
				Columns.Add(CreateUIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5d031a2d-53b8-4768-bead-6347cf929ec0"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsModuleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c7227eee-1b80-4db9-9f3a-cfdaa562ae3d"),
				Name = @"IsModule",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsLookupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("356fed4d-7b90-41aa-9d61-2cfe1df9e9fc"),
				Name = @"IsLookup",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAdministratedByRecordsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("278b1727-05db-41b5-a80c-72fc962430ee"),
				Name = @"AdministratedByRecords",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAdministratedByColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c449bd15-1392-4a02-b1d3-f3852c194ebf"),
				Name = @"AdministratedByColumns",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAdministratedByOperationsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b12eda60-9b6a-4295-a281-8bd1fd1c2d33"),
				Name = @"AdministratedByOperations",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysWorkspaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b7a4479c-74c2-4491-bca8-a03c0c093458"),
				Name = @"SysWorkspace",
				ReferenceSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsTrackChangesInDBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b076dce7-a486-4584-a06e-567972ab10c8"),
				Name = @"IsTrackChangesInDB",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsInSSPEntitySchemaAccessListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("117b0843-3caf-41b7-9f04-59ef867d640d"),
				Name = @"IsInSSPEntitySchemaAccessList",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("50b78acd-9cab-49e3-812a-fd96337814a9"),
				Name = @"UId",
				CreatedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				ModifiedInSchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwWorkspaceObjectsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwWorkspaceObjectsEventsProcessSchema() {
			var schema = new VwWorkspaceObjectsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwWorkspaceObjects(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwWorkspaceObjects_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwWorkspaceObjectsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwWorkspaceObjectsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e"));
		}

		#endregion

	}

	#endregion

	#region Class: VwWorkspaceObjects

	/// <summary>
	/// Workspace objects (view).
	/// </summary>
	public class VwWorkspaceObjects : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public VwWorkspaceObjects(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwWorkspaceObjects";
		}

		public VwWorkspaceObjects(VwWorkspaceObjects source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Section.
		/// </summary>
		public bool IsModule {
			get {
				return GetTypedColumnValue<bool>("IsModule");
			}
			set {
				SetColumnValue("IsModule", value);
			}
		}

		/// <summary>
		/// Lookup.
		/// </summary>
		public bool IsLookup {
			get {
				return GetTypedColumnValue<bool>("IsLookup");
			}
			set {
				SetColumnValue("IsLookup", value);
			}
		}

		/// <summary>
		/// Managed by records.
		/// </summary>
		public bool AdministratedByRecords {
			get {
				return GetTypedColumnValue<bool>("AdministratedByRecords");
			}
			set {
				SetColumnValue("AdministratedByRecords", value);
			}
		}

		/// <summary>
		/// Managed by columns.
		/// </summary>
		public bool AdministratedByColumns {
			get {
				return GetTypedColumnValue<bool>("AdministratedByColumns");
			}
			set {
				SetColumnValue("AdministratedByColumns", value);
			}
		}

		/// <summary>
		/// Managed by operations.
		/// </summary>
		public bool AdministratedByOperations {
			get {
				return GetTypedColumnValue<bool>("AdministratedByOperations");
			}
			set {
				SetColumnValue("AdministratedByOperations", value);
			}
		}

		/// <exclude/>
		public Guid SysWorkspaceId {
			get {
				return GetTypedColumnValue<Guid>("SysWorkspaceId");
			}
			set {
				SetColumnValue("SysWorkspaceId", value);
				_sysWorkspace = null;
			}
		}

		/// <exclude/>
		public string SysWorkspaceName {
			get {
				return GetTypedColumnValue<string>("SysWorkspaceName");
			}
			set {
				SetColumnValue("SysWorkspaceName", value);
				if (_sysWorkspace != null) {
					_sysWorkspace.Name = value;
				}
			}
		}

		private SysWorkspace _sysWorkspace;
		/// <summary>
		/// Workspace.
		/// </summary>
		public SysWorkspace SysWorkspace {
			get {
				return _sysWorkspace ??
					(_sysWorkspace = LookupColumnEntities.GetEntity("SysWorkspace") as SysWorkspace);
			}
		}

		/// <summary>
		/// Update change log.
		/// </summary>
		public bool IsTrackChangesInDB {
			get {
				return GetTypedColumnValue<bool>("IsTrackChangesInDB");
			}
			set {
				SetColumnValue("IsTrackChangesInDB", value);
			}
		}

		/// <summary>
		/// Available for portal users.
		/// </summary>
		public bool IsInSSPEntitySchemaAccessList {
			get {
				return GetTypedColumnValue<bool>("IsInSSPEntitySchemaAccessList");
			}
			set {
				SetColumnValue("IsInSSPEntitySchemaAccessList", value);
			}
		}

		/// <summary>
		/// Column 1.
		/// </summary>
		public Guid UId {
			get {
				return GetTypedColumnValue<Guid>("UId");
			}
			set {
				SetColumnValue("UId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwWorkspaceObjects_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwWorkspaceObjectsDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwWorkspaceObjectsDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwWorkspaceObjectsInserted", e);
			Inserting += (s, e) => ThrowEvent("VwWorkspaceObjectsInserting", e);
			Saved += (s, e) => ThrowEvent("VwWorkspaceObjectsSaved", e);
			Saving += (s, e) => ThrowEvent("VwWorkspaceObjectsSaving", e);
			Updated += (s, e) => ThrowEvent("VwWorkspaceObjectsUpdated", e);
			Updating += (s, e) => ThrowEvent("VwWorkspaceObjectsUpdating", e);
			Validating += (s, e) => ThrowEvent("VwWorkspaceObjectsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwWorkspaceObjects(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwWorkspaceObjects_BaseEventsProcess

	/// <exclude/>
	public partial class VwWorkspaceObjects_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : VwWorkspaceObjects
	{

		public VwWorkspaceObjects_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwWorkspaceObjects_BaseEventsProcess";
			SchemaUId = new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("95a9f7af-bbd7-408a-a5e2-7b24b3f4556e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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
					SchemaElementUId = new Guid("de22ab32-5082-4d48-93ef-9f5ca931c1fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageVwWorkspaceObjectsUpdating;
		public ProcessFlowElement StartMessageVwWorkspaceObjectsUpdating {
			get {
				return _startMessageVwWorkspaceObjectsUpdating ?? (_startMessageVwWorkspaceObjectsUpdating = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageVwWorkspaceObjectsUpdating",
					SchemaElementUId = new Guid("e0ea4e6c-4ac6-4c6a-b4b0-8fe10e63cb7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptVwWorkspaceObjectsUpdating;
		public ProcessScriptTask ScriptVwWorkspaceObjectsUpdating {
			get {
				return _scriptVwWorkspaceObjectsUpdating ?? (_scriptVwWorkspaceObjectsUpdating = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptVwWorkspaceObjectsUpdating",
					SchemaElementUId = new Guid("9222f106-5075-4f61-8126-43c14a097ef8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptVwWorkspaceObjectsUpdatingExecute,
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
					SchemaElementUId = new Guid("2390509d-4343-49bf-8996-06c7ed59f236"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageVwWorkspaceObjectsUpdated;
		public ProcessFlowElement StartMessageVwWorkspaceObjectsUpdated {
			get {
				return _startMessageVwWorkspaceObjectsUpdated ?? (_startMessageVwWorkspaceObjectsUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageVwWorkspaceObjectsUpdated",
					SchemaElementUId = new Guid("f33ecdd0-d26b-406a-91e5-bff0c405f1ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptVwWorkspaceObjectsUpdated;
		public ProcessScriptTask ScriptVwWorkspaceObjectsUpdated {
			get {
				return _scriptVwWorkspaceObjectsUpdated ?? (_scriptVwWorkspaceObjectsUpdated = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptVwWorkspaceObjectsUpdated",
					SchemaElementUId = new Guid("2bdc98ab-bf56-48ee-9ec3-e71d569a42eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptVwWorkspaceObjectsUpdatedExecute,
				});
			}
		}

		private LocalizableString _operationExeptionMessage;
		public LocalizableString OperationExeptionMessage {
			get {
				return _operationExeptionMessage ?? (_operationExeptionMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OperationExeptionMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[StartMessageVwWorkspaceObjectsUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageVwWorkspaceObjectsUpdating };
			FlowElements[ScriptVwWorkspaceObjectsUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptVwWorkspaceObjectsUpdating };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[StartMessageVwWorkspaceObjectsUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageVwWorkspaceObjectsUpdated };
			FlowElements[ScriptVwWorkspaceObjectsUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptVwWorkspaceObjectsUpdated };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess1":
						break;
					case "StartMessageVwWorkspaceObjectsUpdating":
						e.Context.QueueTasks.Enqueue("ScriptVwWorkspaceObjectsUpdating");
						break;
					case "ScriptVwWorkspaceObjectsUpdating":
						break;
					case "SubProcess2":
						break;
					case "StartMessageVwWorkspaceObjectsUpdated":
						e.Context.QueueTasks.Enqueue("ScriptVwWorkspaceObjectsUpdated");
						break;
					case "ScriptVwWorkspaceObjectsUpdated":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageVwWorkspaceObjectsUpdating");
			ActivatedEventElements.Add("StartMessageVwWorkspaceObjectsUpdated");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageVwWorkspaceObjectsUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageVwWorkspaceObjectsUpdating";
					result = StartMessageVwWorkspaceObjectsUpdating.Execute(context);
					break;
				case "ScriptVwWorkspaceObjectsUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptVwWorkspaceObjectsUpdating";
					result = ScriptVwWorkspaceObjectsUpdating.Execute(context, ScriptVwWorkspaceObjectsUpdatingExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageVwWorkspaceObjectsUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageVwWorkspaceObjectsUpdated";
					result = StartMessageVwWorkspaceObjectsUpdated.Execute(context);
					break;
				case "ScriptVwWorkspaceObjectsUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptVwWorkspaceObjectsUpdated";
					result = ScriptVwWorkspaceObjectsUpdated.Execute(context, ScriptVwWorkspaceObjectsUpdatedExecute);
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

		public virtual bool ScriptVwWorkspaceObjectsUpdatingExecute(ProcessExecutingContext context) {
			var eventArgs = (context.ThrowEventArgs as Terrasoft.Core.Entities.EntityBeforeEventArgs);
			var queryCondition = new Terrasoft.Core.DB.QueryCondition();
			queryCondition.ConditionType = Terrasoft.Core.DB.QueryConditionType.Equal;
			queryCondition.LeftExpression = new Terrasoft.Core.DB.QueryColumnExpression("SysWorkspaceId");
			queryCondition.RightExpressions.Add(
				new Terrasoft.Core.DB.QueryColumnExpression(Terrasoft.Core.DB.Column.Parameter(Entity.UserConnection.Workspace.Id)));
			eventArgs.AdditionalCondition = queryCondition;
			return true;
		}

		public virtual bool ScriptVwWorkspaceObjectsUpdatedExecute(ProcessExecutingContext context) {
			var eventArgs = (context.ThrowEventArgs as Terrasoft.Core.Entities.EntityAfterEventArgs);
			var modifiedColumnValues = eventArgs.ModifiedColumnValues;
			Guid sysBaseSchemaId = eventArgs.PrimaryColumnValue;
			Guid sysBaseSchemaUId = WorkspaceUtilities.GetSchemaUIdById(sysBaseSchemaId, UserConnection);
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var sysSchema = entitySchemaManager.GetItemByUId(sysBaseSchemaUId);
			if (sysSchema != null) {
				var administratedByColumns = modifiedColumnValues.FindByName("AdministratedByColumns");
				if (administratedByColumns != null) {
					bool? nNeedAddRightsForColumns = administratedByColumns.Value as bool?;
					bool needAddRightsForColumns = (nNeedAddRightsForColumns == null) ? false : (bool)nNeedAddRightsForColumns;
					if (needAddRightsForColumns) {
						AddRightsForColumns(sysBaseSchemaUId);
					}
					OperationLogger.Instance.LogAdminEntitySchemaEdit(UserConnection, Entity.Name, EntitySchemaAdministrationType.Columns, needAddRightsForColumns);
				}
				var administratedByOperations = modifiedColumnValues.FindByName("AdministratedByOperations");
				if (administratedByOperations != null) {
					bool? NeedAddRightsForOperations = administratedByOperations.Value as bool?;
					bool needAddRightsForOperations = (NeedAddRightsForOperations == null) ? false : (bool)NeedAddRightsForOperations;
					if (needAddRightsForOperations) {
						AddRightsForOperations(sysBaseSchemaUId);
					}
					OperationLogger.Instance.LogAdminEntitySchemaEdit(UserConnection, Entity.Name, EntitySchemaAdministrationType.Operations, needAddRightsForOperations);
				}
				var customSchema = entitySchemaManager.DesignItemInCustomPackage(UserConnection, sysBaseSchemaUId);
				var schema = customSchema.Instance as EntitySchema;
				schema.AdministratedByRecords = sysSchema.Instance.AdministratedByRecords;
				schema.AdministratedByColumns = sysSchema.Instance.AdministratedByColumns;
				schema.AdministratedByOperations = sysSchema.Instance.AdministratedByOperations;
				var extraProperties = customSchema.ExtraProperties;
				var adminByRecords = modifiedColumnValues.FindByName("AdministratedByRecords");
				var adminByColumns = modifiedColumnValues.FindByName("AdministratedByColumns");
				var adminByOperations = modifiedColumnValues.FindByName("AdministratedByOperations");
				if (adminByRecords != null) {
					bool? NeedAddRightsForRecords = adminByRecords.Value as bool?;
					bool needAddRightsForRecords = (NeedAddRightsForRecords == null) ? false : (bool)NeedAddRightsForRecords;
					extraProperties.SetValueByName("AdministratedByRecords", adminByRecords.Value);
					schema.AdministratedByRecords = (bool)adminByRecords.Value;
					schema.ValidateNames(false);
					if (needAddRightsForRecords) {
						CreateRightRecordsSchema(sysBaseSchemaUId);
					}
					OperationLogger.Instance.LogAdminEntitySchemaEdit(UserConnection, Entity.Name, EntitySchemaAdministrationType.Records, needAddRightsForRecords);
				}
				if (adminByColumns != null) {
					extraProperties.SetValueByName("AdministratedByColumns", adminByColumns.Value);
					schema.AdministratedByColumns = (bool)adminByColumns.Value;
				}
				if (adminByOperations != null) {
					extraProperties.SetValueByName("AdministratedByOperations", adminByOperations.Value);
					schema.AdministratedByOperations = (bool)adminByOperations.Value;
				}
				entitySchemaManager.SaveDesignedItemInSessionData(customSchema);
				entitySchemaManager.SaveSchema(schema.UId, Entity.UserConnection);
				foreach (var extraProperty in extraProperties) {
					var conditions = new System.Collections.Generic.Dictionary<string, object> {
						{ "Name", extraProperty.Name },
						{ "SysSchema", customSchema.Id }
					};
					if(extraProperty.Name == "Hash")	continue;
					SysSchemaProperty sysSchemaProperty = new SysSchemaProperty(Entity.UserConnection);
					if (!sysSchemaProperty.FetchFromDB(conditions)) {
						sysSchemaProperty.SetDefColumnValues();
					}
					sysSchemaProperty.SysSchemaId = customSchema.Id;
					sysSchemaProperty.Name = extraProperty.Name;
					sysSchemaProperty.Value = extraProperty.Value != null ? extraProperty.Value.ToString(): string.Empty;
					sysSchemaProperty.Save();
				}
				#if !NETSTANDARD2_0 // TODO CRM-44352
				if (!GlobalAppSettings.FeatureUseRuntimeEntitySchemaMetadata) {
					var workspaceBuilder = Terrasoft.Core.Packages.WorkspaceBuilderUtility.CreateWorkspaceBuilder(UserConnection.AppConnection);
					workspaceBuilder.Build(UserConnection.Workspace);
				}
				var configurationBuilder = ClassFactory.Get<Terrasoft.Core.ConfigurationBuild.IAppConfigurationBuilder>();
				configurationBuilder.BuildChanged();
				#endif
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwWorkspaceObjectsUpdating":
							if (ActivatedEventElements.Contains("StartMessageVwWorkspaceObjectsUpdating")) {
							context.QueueTasks.Enqueue("StartMessageVwWorkspaceObjectsUpdating");
						}
						break;
					case "VwWorkspaceObjectsUpdated":
							if (ActivatedEventElements.Contains("StartMessageVwWorkspaceObjectsUpdated")) {
							context.QueueTasks.Enqueue("StartMessageVwWorkspaceObjectsUpdated");
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

	#region Class: VwWorkspaceObjects_BaseEventsProcess

	/// <exclude/>
	public class VwWorkspaceObjects_BaseEventsProcess : VwWorkspaceObjects_BaseEventsProcess<VwWorkspaceObjects>
	{

		public VwWorkspaceObjects_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwWorkspaceObjects_BaseEventsProcess

	public partial class VwWorkspaceObjects_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void AddRightsForColumns(Guid SysSchemaUId) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var schema = entitySchemaManager.GetInstanceByUId(SysSchemaUId) as EntitySchema;
			
			QueryParameter schemaIdParameter = new QueryParameter("SchemaUId", SysSchemaUId);
			QueryParameter subjectColumnUIdParameter = new QueryParameter("SubjectColumnUId", null);
			QueryParameter idParameter = new QueryParameter("Id", null);
			var defaultAdminUnitId = Guid.Empty;
			var defaultAdminUnitName = string.Empty;
			var adminUnit = GetRootAdminUnitRecordId();
			if (adminUnit != null) {
				defaultAdminUnitId = adminUnit.Item1;
				defaultAdminUnitName = adminUnit.Item2;
			}
			var defaultRightLevelId = new Guid("007F04EE-1FE1-DF11-971B-001D60E938C6");
			var defaultPosition = 0;
			Select conditionSelect = new Select(UserConnection).From("VwSysEntitySchemaColumnRight").
										Column("Id").
									Where("SubjectColumnUId").IsEqual(subjectColumnUIdParameter).
										And("SubjectSchemaUId").IsEqual(schemaIdParameter) as Select;
			Select select = new Select(UserConnection).Top(1).From("SysOneRecord").
								Column(idParameter).As("Id").
								Column(Column.Const(defaultAdminUnitId)).As("SysAdminUnitId").
								Column(Column.Const(defaultRightLevelId)).As("RightLevelId").
								Column(Column.Const(defaultPosition)).As("Position").
								Column(subjectColumnUIdParameter).As("SubjectColumnUId").
								Column(schemaIdParameter).As("SubjectSchemaUId").
							Where().Not().Exists(conditionSelect) as Select;
			InsertSelect insert = new InsertSelect(UserConnection).Into("VwSysEntitySchemaColumnRight").
										Set("Id", "SysAdminUnitId", "RightLevelId", "Position", "SubjectColumnUId", "SubjectSchemaUId").
								FromSelect(select)
			as InsertSelect;
			foreach (var column in schema.Columns) {
				subjectColumnUIdParameter.Value = column.UId;
				idParameter.Value = Guid.NewGuid();
				insert.Execute();
				OperationLogger.Instance.LogEntitySchemaColumnRightEdit(UserConnection, defaultAdminUnitName, schema.UId, column.UId, defaultRightLevelId, defaultPosition);
			}
			return;
		}

		public virtual Tuple<Guid, string> GetRootAdminUnitRecordId() {
			Select select =
				new Select(UserConnection).Top(1)
					.Column("Id")
					.Column("Name")
				.From("SysAdminUnit")
				.Where("SysAdminUnitTypeValue").IsEqual(Column.Parameter(0))
					.And("ConnectionType").IsEqual(Column.Parameter(UserType.General))
					.And("ParentRoleId").IsNull() as Select;
			Tuple<Guid, string> result = null;
			select.ExecuteReader((IDataReader dr) => {
				result = new Tuple<Guid, string>(
					UserConnection.DBTypeConverter.DBValueToGuid(dr["Id"]),
					dr.GetColumnValue<string>("Name"));
			});
			return result;
		}

		public virtual void AddRightsForOperations(Guid schemaUId) {
			QueryParameter schemaIdParameter = new QueryParameter("SchemaUId", schemaUId);
			QueryParameter canReadParameter = new QueryParameter("CanRead", true);
			QueryParameter canAppendParameter = new QueryParameter("CanAppend", true);
			QueryParameter canEditParameter = new QueryParameter("CanEdit", true);
			QueryParameter canDeleteParameter = new QueryParameter("CanDelete", true);
			QueryParameter idParameter = new QueryParameter("Id", Guid.NewGuid());
			var defaultAdminUnitId = Guid.Empty;
			var defaultAdminUnitName = string.Empty;
			var adminUnit = GetRootAdminUnitRecordId();
			if (adminUnit != null) {
				defaultAdminUnitId = adminUnit.Item1;
				defaultAdminUnitName = adminUnit.Item2;
			}
			var defaultPosition = 0;
			Select conditionSelect = new Select(UserConnection).From("SysEntitySchemaOperationRight").
										Column("Id").
									Where("SubjectSchemaUId").IsEqual(schemaIdParameter) as Select;
			Select select = new Select(UserConnection).Top(1).From("SysEntitySchemaOperationRight").
								Column(idParameter).As("Id").
								Column(Column.Const(defaultAdminUnitId)).As("SysAdminUnitId").
								Column(Column.Const(defaultPosition)).As("Position").
								Column(schemaIdParameter).As("SubjectSchemUId").
								Column(canReadParameter).As("CanRead").
								Column(canEditParameter).As("CanEdit").
								Column(canAppendParameter).As("CanAppend").
								Column(canDeleteParameter).As("CanDelete").
							Where().Not().Exists(conditionSelect) as Select;
			InsertSelect insert = new InsertSelect(UserConnection).Into("SysEntitySchemaOperationRight").
										Set("Id", "SysAdminUnitId", "Position", "SubjectSchemaUId", 
										"CanRead", "CanEdit", "CanAppend", "CanDelete").
								FromSelect(select) as InsertSelect;
			insert.Execute();
			return;
		}

		public virtual void CreateRightRecordsSchema(Guid entitySchemaId) {
			var schemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var schemaItem = schemaManager.GetItemFromMetaData(entitySchemaId, UserConnection);
			if (schemaItem == null) {
				return;
			}
			var schema = schemaItem.Instance;
			if (schema == null) {
				return;
			}
			if (!UserConnection.DBSecurityEngine.GetIsEntitySchemaAdministratedByRecords(schema)) {
				UserConnection.DBSecurityEngine.SetEntitySchemaAdministratedByRecords(schema, true);
			}
			var rightsSchema = UserConnection.DBSecurityEngine.GetRecordRightsSchema(schema);
			EntitySchemaColumn hierarchyColumn = schema.HierarchyColumn;
			if (hierarchyColumn != null && hierarchyColumn.ReferenceSchemaUId.IsEmpty()) {
				hierarchyColumn.ReferenceSchema = schema;
				schema.Columns.FindByName(hierarchyColumn.Name).ReferenceSchema = schema;
			}
			if (UserConnection.DBMetaScript.GetIsEntitySchemaExist(rightsSchema.Name)) {
				return;
			}
			DBMetaActionCollection actions = new DBMetaActionCollection(UserConnection);
			UserConnection.DBMetaScript.AddEntitySchemaSavingActions(actions, rightsSchema);
			actions.SpreadAndSort();
			foreach (var item in actions) {
				BaseGroupAction groupAction = item as BaseGroupAction;
				if (groupAction != null) {
					SetGroupActionsDefaultValues(groupAction);
				}
			}
			DBMetaScript dbMetaScript = UserConnection.DBMetaScript;
			dbMetaScript.ExecuteActions(actions);
		}

		public virtual void SetGroupActionsDefaultValues(BaseGroupAction groupAction) {
			foreach (var item in groupAction.Actions) {
				SetColumnValueAction setValueAction = item as SetColumnValueAction;
				if (setValueAction != null) {
					setValueAction.Value = setValueAction.EntitySchemaColumn.DataValueType.DefValue;
				}
				BaseGroupAction _groupAction = item as BaseGroupAction;
				if (_groupAction != null) {
					SetGroupActionsDefaultValues(_groupAction);
				}
			}
		}

		public virtual void SetIsTrackChangesInDB(bool value, EntitySchema schema) {
		}

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion

	#region Class: VwWorkspaceObjectsEventsProcessSchema

	/// <exclude/>
	public class VwWorkspaceObjectsEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public VwWorkspaceObjectsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwWorkspaceObjectsEventsProcessSchema(VwWorkspaceObjectsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwWorkspaceObjects_BaseEventsProcess";
			UId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476");
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
			ProcessSchemaLaneSet schemaLaneSet900 = CreateLaneSet900LaneSet();
			LaneSets.Add(schemaLaneSet900);
			ProcessSchemaLane schemaLane3302 = CreateLane3302Lane();
			schemaLaneSet900.Lanes.Add(schemaLane3302);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaStartMessageEvent startmessagevwworkspaceobjectsupdating = CreateStartMessageVwWorkspaceObjectsUpdatingStartMessageEvent();
			subprocess1.FlowElements.Add(startmessagevwworkspaceobjectsupdating);
			ProcessSchemaScriptTask scriptvwworkspaceobjectsupdating = CreateScriptVwWorkspaceObjectsUpdatingScriptTask();
			subprocess1.FlowElements.Add(scriptvwworkspaceobjectsupdating);
			ProcessSchemaStartMessageEvent startmessagevwworkspaceobjectsupdated = CreateStartMessageVwWorkspaceObjectsUpdatedStartMessageEvent();
			subprocess2.FlowElements.Add(startmessagevwworkspaceobjectsupdated);
			ProcessSchemaScriptTask scriptvwworkspaceobjectsupdated = CreateScriptVwWorkspaceObjectsUpdatedScriptTask();
			subprocess2.FlowElements.Add(scriptvwworkspaceobjectsupdated);
			FlowElements.Add(CreateSequenceFlow19807SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19808SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOperationExeptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOperationExeptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cc38762c-dc69-4e90-a9ab-755d43b45dcd"),
				Name = "OperationExeptionMessage",
				CreatedInPackageId = new Guid("8bf8ae5e-52c9-44c1-a099-364797b55805"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19807SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19807",
				UId = new Guid("f6ccaefe-26fb-4eb2-a24b-192fa7f93c88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CurveCenterPosition = new Point(198, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e0ea4e6c-4ac6-4c6a-b4b0-8fe10e63cb7f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9222f106-5075-4f61-8126-43c14a097ef8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19808SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19808",
				UId = new Guid("6ac0c60a-36ee-41cb-b829-7f173a15fa19"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CurveCenterPosition = new Point(194, 316),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f33ecdd0-d26b-406a-91e5-bff0c405f1ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2bdc98ab-bf56-48ee-9ec3-e71d569a42eb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet900LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet900 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("812bb6bf-ebad-4559-8073-f3678084f840"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"LaneSet900",
				Position = new Point(5, 5),
				Size = new Size(1527, 401),
				UseBackgroundMode = false
			};
			return schemaLaneSet900;
		}

		protected virtual ProcessSchemaLane CreateLane3302Lane() {
			ProcessSchemaLane schemaLane3302 = new ProcessSchemaLane(this) {
				UId = new Guid("a7c0d069-2916-4d20-9457-ceb0ec1d0607"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("812bb6bf-ebad-4559-8073-f3678084f840"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"Lane3302",
				Position = new Point(29, 0),
				Size = new Size(1498, 401),
				UseBackgroundMode = false
			};
			return schemaLane3302;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("de22ab32-5082-4d48-93ef-9f5ca931c1fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a7c0d069-2916-4d20-9457-ceb0ec1d0607"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"SubProcess1",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(301, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageVwWorkspaceObjectsUpdatingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e0ea4e6c-4ac6-4c6a-b4b0-8fe10e63cb7f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de22ab32-5082-4d48-93ef-9f5ca931c1fb"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwWorkspaceObjectsUpdating",
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"StartMessageVwWorkspaceObjectsUpdating",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptVwWorkspaceObjectsUpdatingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9222f106-5075-4f61-8126-43c14a097ef8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de22ab32-5082-4d48-93ef-9f5ca931c1fb"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"ScriptVwWorkspaceObjectsUpdating",
				Position = new Point(176, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,205,110,194,48,12,199,207,67,226,29,34,78,233,197,47,128,118,0,214,3,210,14,251,232,180,115,212,184,80,173,36,197,118,10,125,251,165,84,202,232,152,180,237,102,37,255,143,159,236,206,144,194,14,157,172,104,199,234,94,233,210,59,193,179,64,177,39,127,202,211,143,97,85,32,145,97,95,9,108,60,33,228,78,106,169,145,199,161,95,99,21,95,147,33,91,206,103,93,204,62,6,164,126,227,157,141,90,239,98,129,195,211,247,164,135,53,60,79,100,122,112,79,157,144,166,162,111,49,230,252,150,49,200,32,63,6,211,220,102,61,98,37,249,185,37,100,254,3,84,19,14,238,75,173,23,175,61,191,123,250,224,214,148,184,181,139,31,88,95,234,221,254,170,128,97,101,173,158,207,238,254,83,115,171,27,37,240,100,200,28,80,144,244,184,120,120,99,164,216,237,176,188,148,39,54,216,218,44,27,232,210,125,7,142,11,161,105,174,79,50,165,143,6,66,9,228,148,80,192,229,39,228,212,185,250,33,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2390509d-4343-49bf-8996-06c7ed59f236"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a7c0d069-2916-4d20-9457-ceb0ec1d0607"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"SubProcess2",
				Position = new Point(42, 231),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(301, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageVwWorkspaceObjectsUpdatedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f33ecdd0-d26b-406a-91e5-bff0c405f1ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2390509d-4343-49bf-8996-06c7ed59f236"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwWorkspaceObjectsUpdated",
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"StartMessageVwWorkspaceObjectsUpdated",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptVwWorkspaceObjectsUpdatedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2bdc98ab-bf56-48ee-9ec3-e71d569a42eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2390509d-4343-49bf-8996-06c7ed59f236"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"ScriptVwWorkspaceObjectsUpdated",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,89,111,219,56,16,126,118,128,252,7,198,125,145,1,175,186,232,118,95,154,30,240,153,26,216,28,240,177,125,92,48,210,216,230,86,34,13,146,78,42,20,249,239,203,67,7,37,81,117,178,216,5,250,146,38,228,204,240,155,153,143,223,136,125,192,28,193,3,80,57,226,59,129,62,160,32,98,84,194,55,25,174,247,156,61,206,202,29,44,208,26,56,199,130,109,101,56,97,28,194,25,149,68,18,16,246,151,108,180,149,192,75,251,193,229,249,217,131,10,157,178,152,108,9,196,19,150,28,83,250,39,78,142,160,79,41,79,12,175,61,6,202,247,234,72,98,36,50,49,198,2,86,209,30,82,188,136,107,126,119,156,164,152,103,142,155,215,107,99,220,190,48,254,85,28,112,4,27,73,18,11,250,10,100,105,49,206,22,113,208,56,108,136,54,2,248,132,81,10,145,36,140,22,9,129,73,214,90,93,99,138,119,192,213,1,117,219,188,34,53,163,220,93,157,98,151,117,50,109,43,13,107,33,33,29,103,155,38,36,181,160,49,144,45,10,170,32,23,31,16,61,38,201,0,125,63,63,235,233,248,56,78,9,37,66,114,44,65,229,101,203,163,43,238,107,68,56,39,84,25,221,224,20,130,254,200,235,217,215,103,246,244,161,29,145,107,8,122,247,140,37,159,16,189,1,136,71,113,188,36,187,189,20,115,198,43,24,254,40,161,193,163,57,102,2,92,22,161,16,237,12,20,116,31,82,32,250,132,182,56,17,128,222,161,64,7,27,116,121,152,227,116,138,29,167,229,185,245,60,91,222,22,245,122,79,250,199,237,1,84,150,138,14,127,176,157,110,237,130,10,137,105,4,161,250,219,20,219,101,201,44,38,50,168,179,104,136,172,65,168,251,83,252,97,173,157,94,41,195,117,118,128,48,7,52,236,42,153,1,246,228,103,73,137,244,223,16,165,114,238,228,138,19,223,71,151,102,91,106,112,58,67,61,155,51,181,112,193,143,14,235,34,78,183,79,39,117,42,19,31,123,170,221,159,135,64,21,166,54,135,156,108,92,26,69,71,33,89,250,67,61,155,130,32,59,170,37,109,65,39,198,252,14,71,95,213,86,11,171,183,16,70,50,139,248,238,113,101,49,52,1,220,204,180,151,245,8,27,68,93,66,196,120,172,73,80,234,103,85,82,191,109,119,176,74,136,78,7,115,100,198,31,172,198,208,211,241,234,244,51,67,233,155,218,187,227,76,109,232,225,214,172,213,172,190,125,233,170,128,91,151,151,94,253,220,179,63,104,68,252,143,166,142,19,241,255,81,168,42,247,231,200,82,85,167,186,243,179,133,168,10,208,82,161,114,235,185,18,228,16,180,215,232,126,184,2,105,32,157,232,218,208,155,135,213,159,83,55,200,130,242,249,187,238,106,129,196,202,85,195,16,129,73,104,208,169,152,121,148,66,46,39,28,148,167,217,205,119,44,153,127,30,193,204,97,181,213,178,200,164,144,74,135,111,254,175,166,23,54,176,184,36,195,198,125,59,221,64,231,243,201,109,96,205,223,131,186,115,126,191,16,184,115,17,135,237,155,125,26,126,125,146,187,25,52,163,20,73,248,70,210,10,63,128,29,75,16,219,193,180,2,33,148,239,20,75,28,184,194,105,176,116,133,40,232,104,145,110,244,139,33,103,79,251,225,208,219,170,7,19,142,246,40,104,170,117,134,8,109,202,119,94,92,51,97,25,85,52,205,51,166,240,136,86,153,80,144,245,215,94,98,195,235,151,12,5,78,162,112,74,204,130,122,20,189,87,21,35,116,55,68,236,254,111,101,245,49,191,82,223,81,95,183,69,213,190,134,192,176,29,61,13,11,155,85,49,128,148,97,125,228,198,200,92,179,167,252,14,7,158,48,74,192,250,159,177,216,247,7,61,253,144,36,52,87,132,50,104,153,183,104,173,148,25,214,215,131,238,178,26,146,94,180,34,133,115,144,209,126,206,89,58,29,7,85,9,7,133,182,180,29,20,113,167,176,117,7,74,224,232,138,199,190,88,49,207,203,70,149,46,253,62,182,62,158,218,119,216,219,177,210,116,176,171,249,53,84,99,194,179,27,174,217,202,16,32,24,188,67,150,10,225,44,61,200,172,227,32,205,230,160,84,171,87,170,166,23,55,179,245,106,61,186,153,142,150,211,55,127,253,138,94,191,70,235,219,233,45,154,44,175,127,121,251,246,183,223,223,228,250,112,113,149,176,123,156,140,14,7,85,64,213,108,245,46,159,43,217,62,114,80,205,90,30,85,223,82,168,189,133,65,98,53,16,176,195,240,199,226,105,62,62,146,36,54,143,233,198,255,51,228,31,140,34,252,210,48,181,143,249,44,180,163,162,185,219,208,246,80,129,108,178,167,121,118,104,254,109,58,150,129,235,223,190,140,110,201,238,104,85,167,194,62,73,176,16,115,28,73,198,51,253,152,127,223,72,102,210,114,11,23,22,89,43,218,71,219,19,223,65,22,232,100,143,233,14,98,107,246,10,20,205,183,231,103,10,31,7,213,1,138,36,87,119,239,31,142,67,102,201,223,17,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateAddRightsForColumnsMethod());
			Methods.Add(CreateGetRootAdminUnitRecordIdMethod());
			Methods.Add(CreateAddRightsForOperationsMethod());
			Methods.Add(CreateCreateRightRecordsSchemaMethod());
			Methods.Add(CreateSetGroupActionsDefaultValuesMethod());
			Methods.Add(CreateSetIsTrackChangesInDBMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fc077dd5-943c-4807-854a-ceed26d9df6d"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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
				UId = new Guid("5a76164c-21f0-42f0-a4df-5d478dedd449"),
				Name = "Terrasoft.Core.Packages",
				Alias = "",
				CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0d189a73-29cb-4d45-b5ed-468698cc5863"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("4767b46b-cabd-4943-ac62-3ddefc193e0b")
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
				UId = new Guid("dcb4d2aa-a146-4d91-97fa-c470e1147d06"),
				Name = "Terrasoft.Core",
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

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			return method;
		}

		protected virtual SchemaMethod CreateAddRightsForColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4e83662c-370c-4baf-81c2-c26d069c2741"),
				Name = "AddRightsForColumns",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cc0e2dc1-52dc-4619-ae12-8fe70c2e94a8"),
				Name = "SysSchemaUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,203,110,219,48,16,60,199,128,255,65,245,73,2,108,65,106,139,164,129,145,67,30,114,32,32,77,210,184,78,207,172,180,177,89,72,100,74,82,113,141,162,255,222,37,41,89,79,183,206,193,193,174,102,135,59,156,213,234,141,8,7,152,162,106,183,76,54,144,147,207,132,145,53,8,231,194,89,73,16,215,156,49,72,20,229,204,143,250,160,249,120,244,134,229,210,228,176,98,128,199,191,5,21,51,169,8,75,224,106,183,138,83,119,185,147,22,129,129,231,16,233,52,137,145,113,60,250,82,128,216,61,18,65,114,80,80,209,199,105,157,185,112,24,108,157,54,204,157,236,89,39,83,167,117,200,188,79,89,124,255,129,178,174,121,86,228,108,117,4,117,7,143,39,176,34,203,6,152,233,127,185,90,213,250,250,82,120,33,69,166,46,211,156,178,21,163,42,78,177,242,182,160,169,31,229,175,106,119,0,117,143,124,136,147,74,80,182,110,33,73,5,209,52,160,158,56,175,171,158,32,225,34,69,23,244,225,244,197,113,107,240,187,11,219,149,243,123,60,58,25,236,105,143,245,99,5,121,56,31,192,149,93,181,145,239,17,249,167,165,226,137,174,55,234,14,222,32,51,196,250,154,180,96,119,18,4,103,139,224,99,20,205,194,69,20,206,110,22,97,56,59,63,11,175,102,65,16,222,156,6,209,249,135,79,215,167,147,206,197,61,114,73,245,132,34,81,128,79,150,144,161,85,78,194,89,106,210,101,108,79,177,129,219,30,109,207,95,8,158,187,147,231,45,142,77,115,26,173,223,166,217,137,231,163,92,251,103,211,198,201,58,251,109,3,2,6,38,197,243,99,25,253,44,72,230,30,28,186,6,245,37,75,247,28,245,60,55,56,186,239,130,121,131,172,170,90,187,60,66,242,87,254,234,134,149,114,212,253,192,192,14,71,173,169,212,73,155,157,94,202,182,238,18,99,255,249,120,128,84,110,127,120,60,91,136,199,52,146,71,145,52,39,165,100,105,166,142,226,168,6,164,172,175,194,94,237,63,12,50,221,247,173,237,212,247,204,105,214,53,237,180,117,118,100,60,255,158,43,252,141,126,81,169,164,219,153,219,182,191,184,73,65,168,210,101,106,130,210,229,230,147,158,215,49,83,252,248,241,94,130,42,183,84,215,48,204,180,46,31,227,253,101,106,116,127,75,30,22,127,162,39,175,236,215,206,171,55,30,161,214,166,16,84,252,194,5,144,100,227,184,250,133,79,12,51,10,47,191,9,190,61,74,218,157,117,208,62,255,153,100,133,94,75,182,222,199,103,122,119,209,1,132,89,187,247,176,53,219,200,51,40,211,15,186,3,73,161,192,230,30,94,65,16,173,250,142,175,245,55,174,250,192,249,24,31,184,224,8,77,237,248,50,29,220,233,211,74,27,118,57,109,116,60,29,218,157,211,238,14,244,236,170,21,160,10,193,230,127,1,160,63,22,96,220,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRootAdminUnitRecordIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a439e3ce-5c4d-4161-8005-2e60e3608bbc"),
				Name = "GetRootAdminUnitRecordId",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Tuple<Guid, string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,77,75,3,49,16,61,183,208,255,16,246,148,64,9,122,238,7,212,182,150,189,20,105,183,122,16,15,161,25,116,33,155,172,147,68,45,226,127,119,178,89,169,5,241,146,205,204,190,247,102,222,203,30,12,28,3,243,249,51,27,13,7,22,222,217,190,43,249,193,3,46,157,181,116,175,157,21,178,114,45,191,22,132,25,200,165,51,177,177,188,40,117,113,217,216,170,6,186,150,188,69,215,240,98,127,242,11,221,212,246,96,235,144,251,15,47,128,112,249,163,58,181,112,175,76,36,166,44,253,250,53,42,195,179,160,188,83,72,138,1,144,95,137,60,105,97,53,47,206,107,37,238,127,180,100,34,97,228,6,44,160,50,191,85,8,5,54,236,156,129,228,131,52,182,209,24,46,152,242,125,4,147,209,176,138,173,129,233,38,214,122,204,124,192,218,62,207,25,130,143,134,226,98,150,240,132,201,241,201,245,7,28,99,128,29,40,77,131,121,185,82,65,229,130,105,20,108,54,103,159,52,251,76,166,164,255,80,231,105,191,203,232,229,234,38,89,160,198,27,32,153,162,186,139,171,114,137,201,53,62,166,135,120,18,227,68,213,72,86,67,206,161,67,77,127,132,251,199,17,180,241,87,58,16,66,68,219,187,153,124,3,107,2,55,114,11,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateAddRightsForOperationsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("859ee5c0-4066-47e8-adcb-9be404f25b22"),
				Name = "AddRightsForOperations",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("69471913-2967-4f8e-ac25-c83593caa259"),
				Name = "schemaUId",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,77,111,219,48,12,134,207,45,208,255,224,229,100,1,133,177,238,26,236,16,100,238,224,75,214,38,11,118,214,108,182,81,97,75,158,68,173,11,134,253,247,209,150,252,237,182,110,14,177,37,63,124,69,81,175,120,111,65,159,239,184,230,5,32,232,192,164,39,40,120,146,117,51,159,3,9,207,193,253,0,11,87,135,154,59,38,217,234,218,199,208,59,91,95,93,14,193,32,229,114,15,252,77,185,173,195,72,12,181,133,121,157,77,89,130,92,162,228,192,87,181,226,76,224,2,165,10,123,85,231,11,228,244,186,64,201,129,47,107,137,55,55,86,151,250,171,21,89,180,131,231,234,25,178,74,231,55,215,65,6,15,220,230,184,201,10,33,143,82,96,146,145,70,141,198,69,137,231,23,168,29,41,19,103,80,11,249,56,32,121,131,84,50,128,123,165,186,168,61,164,74,103,9,173,78,176,120,8,194,14,254,64,137,219,60,103,193,223,171,203,139,217,156,90,54,74,16,138,155,245,12,231,179,26,146,159,136,252,55,216,197,157,50,2,133,146,132,126,164,143,7,42,111,138,65,170,100,86,79,251,177,171,164,27,132,71,3,122,171,164,164,119,34,88,116,171,85,65,70,62,155,88,162,192,179,115,244,183,18,52,175,190,239,197,227,9,87,44,162,20,221,111,171,114,91,200,250,28,186,217,31,39,208,64,34,246,231,19,201,118,151,130,69,137,137,127,89,158,135,147,11,197,2,110,124,74,93,226,102,65,190,223,85,25,222,188,51,109,159,116,207,93,44,218,152,225,38,60,227,30,17,173,104,48,156,158,30,115,129,180,110,111,114,145,72,115,84,94,161,25,78,98,167,149,114,43,246,106,123,156,89,114,220,97,92,84,211,80,102,232,193,221,111,233,250,170,207,208,163,174,211,242,190,201,204,68,140,122,66,27,225,91,64,19,225,172,195,162,157,66,250,143,255,8,131,38,28,25,120,232,149,68,146,35,208,59,70,212,3,239,152,254,151,137,111,18,137,234,29,62,63,0,250,102,51,62,108,154,105,15,175,250,58,54,253,117,208,138,244,26,122,175,143,14,154,243,76,73,46,42,111,251,93,152,174,0,253,221,85,77,167,30,82,197,32,181,8,117,31,210,128,86,203,245,127,75,124,101,249,204,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateRightRecordsSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("04ba3223-3dec-4f09-aa3a-4d14c7d82b24"),
				Name = "CreateRightRecordsSchema",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7364aaad-544e-4992-b44c-224e81ac5a92"),
				Name = "entitySchemaId",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,205,110,179,48,16,60,135,167,112,122,168,64,138,252,2,40,135,164,73,219,28,218,67,80,191,187,139,55,96,9,76,180,94,210,70,85,223,253,179,49,161,14,73,127,78,192,122,60,51,30,239,114,16,200,76,94,66,45,158,132,22,5,32,155,179,23,3,120,215,104,13,57,169,70,243,7,160,44,68,196,55,107,77,138,142,103,197,155,132,9,195,174,44,164,209,97,144,216,16,212,150,255,76,207,209,187,250,61,54,245,19,144,88,9,18,49,4,60,27,57,27,57,74,210,72,237,88,28,114,206,153,110,171,42,97,31,209,4,129,90,212,105,244,25,8,15,162,14,205,55,218,144,208,57,132,52,223,80,56,192,116,148,199,106,153,65,222,162,53,184,214,133,210,208,157,192,132,71,95,200,90,105,101,8,5,129,92,30,183,144,55,40,77,175,148,116,18,191,113,102,64,127,102,156,49,194,22,146,211,145,81,21,37,153,236,116,240,63,184,247,116,219,96,223,201,107,26,133,46,238,154,170,173,53,43,21,160,192,188,60,246,223,167,112,249,227,249,130,207,119,140,158,250,160,217,237,237,152,136,111,97,7,8,246,102,188,220,203,70,114,27,108,189,167,99,236,83,251,101,195,224,36,141,38,189,37,15,52,252,94,105,155,219,179,168,97,108,136,187,98,242,3,149,239,130,139,24,93,179,102,57,170,61,93,54,192,250,221,222,85,28,94,132,87,25,117,151,39,89,116,140,214,76,229,185,153,232,30,198,90,208,240,198,174,131,226,139,145,248,201,224,66,202,208,94,38,14,74,23,158,210,196,189,220,236,172,113,44,97,95,231,217,30,65,200,133,150,89,131,20,219,133,93,99,11,121,201,98,215,109,202,205,159,26,76,119,39,92,10,3,15,216,180,123,47,193,138,224,125,238,119,216,159,197,8,101,239,204,229,28,98,167,193,76,78,236,68,4,104,179,130,157,104,43,250,39,170,22,76,184,203,26,156,124,14,225,250,0,152,124,13,62,174,204,196,215,106,26,133,88,190,126,183,211,66,48,202,42,73,255,3,213,22,244,111,56,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetGroupActionsDefaultValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6f105e16-13b3-494e-9323-bbf20c9a8ba1"),
				Name = "SetGroupActionsDefaultValues",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4f17d297-8d63-4111-9e2a-8ecc772926b7"),
				Name = "groupAction",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "BaseGroupAction",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,75,10,194,48,16,93,43,120,135,113,215,110,114,1,233,66,173,120,128,138,91,25,202,212,6,210,164,52,19,161,72,239,110,108,20,147,226,34,36,147,121,223,198,12,132,117,11,217,3,7,144,76,29,72,13,247,193,184,126,95,179,52,90,132,203,230,240,220,172,87,21,241,209,40,215,233,43,42,71,97,5,150,56,30,139,32,131,22,254,161,119,94,69,54,144,45,72,219,2,180,83,42,184,172,210,165,152,223,94,119,241,125,210,44,121,172,234,150,58,12,62,162,68,198,25,114,25,123,18,37,53,243,240,246,156,252,57,160,165,243,175,26,220,162,158,81,236,5,236,155,56,65,167,121,125,209,136,96,189,47,58,21,178,218,132,151,127,162,76,47,244,185,226,128,119,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetIsTrackChangesInDBMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ad07329e-70b7-4ace-a2e3-b1d7e651438d"),
				Name = "SetIsTrackChangesInDB",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("55a97051-52bd-442f-aca8-f510e8b7fcee"),
				Name = "value",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8222ed7f-a577-41d0-b87d-eb15e6b7358d"),
				Name = "schema",
				CreatedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] {  };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwWorkspaceObjectsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"));
		}

		#endregion

	}

	#endregion


	#region Class: VwWorkspaceObjectsEventsProcess

	/// <exclude/>
	public class VwWorkspaceObjectsEventsProcess : VwWorkspaceObjects_BaseEventsProcess
	{

		public VwWorkspaceObjectsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

