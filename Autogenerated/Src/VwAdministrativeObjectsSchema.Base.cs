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

	#region Class: VwAdministrativeObjectsSchema

	/// <exclude/>
	public class VwAdministrativeObjectsSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public VwAdministrativeObjectsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwAdministrativeObjectsSchema(VwAdministrativeObjectsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwAdministrativeObjectsSchema(VwAdministrativeObjectsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
			RealUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
			Name = "VwAdministrativeObjects";
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
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5d031a2d-53b8-4768-bead-6347cf929ec0"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIsModuleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c7227eee-1b80-4db9-9f3a-cfdaa562ae3d"),
				Name = @"IsModule",
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsLookupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("356fed4d-7b90-41aa-9d61-2cfe1df9e9fc"),
				Name = @"IsLookup",
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAdministratedByRecordsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("278b1727-05db-41b5-a80c-72fc962430ee"),
				Name = @"AdministratedByRecords",
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAdministratedByColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c449bd15-1392-4a02-b1d3-f3852c194ebf"),
				Name = @"AdministratedByColumns",
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAdministratedByOperationsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b12eda60-9b6a-4295-a281-8bd1fd1c2d33"),
				Name = @"AdministratedByOperations",
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysWorkspaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b7a4479c-74c2-4491-bca8-a03c0c093458"),
				Name = @"SysWorkspace",
				ReferenceSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsTrackChangesInDBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b076dce7-a486-4584-a06e-567972ab10c8"),
				Name = @"IsTrackChangesInDB",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsInSSPEntitySchemaAccessListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("117b0843-3caf-41b7-9f04-59ef867d640d"),
				Name = @"IsInSSPEntitySchemaAccessList",
				CreatedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				ModifiedInSchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwAdministrativeObjectsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwAdministrativeObjectsEventsProcessSchema() {
			var schema = new VwAdministrativeObjectsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwAdministrativeObjects(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwAdministrativeObjects_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwAdministrativeObjectsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwAdministrativeObjectsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0"));
		}

		#endregion

	}

	#endregion

	#region Class: VwAdministrativeObjects

	/// <summary>
	/// Objects permissions (view).
	/// </summary>
	public class VwAdministrativeObjects : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public VwAdministrativeObjects(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwAdministrativeObjects";
		}

		public VwAdministrativeObjects(VwAdministrativeObjects source)
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwAdministrativeObjects_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwAdministrativeObjectsDeleted", e);
			Deleting += (s, e) => ThrowEvent("VwAdministrativeObjectsDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwAdministrativeObjectsInserted", e);
			Inserting += (s, e) => ThrowEvent("VwAdministrativeObjectsInserting", e);
			Saved += (s, e) => ThrowEvent("VwAdministrativeObjectsSaved", e);
			Saving += (s, e) => ThrowEvent("VwAdministrativeObjectsSaving", e);
			Updated += (s, e) => ThrowEvent("VwAdministrativeObjectsUpdated", e);
			Updating += (s, e) => ThrowEvent("VwAdministrativeObjectsUpdating", e);
			Validating += (s, e) => ThrowEvent("VwAdministrativeObjectsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwAdministrativeObjects(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwAdministrativeObjects_BaseEventsProcess

	/// <exclude/>
	public partial class VwAdministrativeObjects_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : VwAdministrativeObjects
	{

		public VwAdministrativeObjects_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwAdministrativeObjects_BaseEventsProcess";
			SchemaUId = new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2bdce14f-0018-4090-b168-47ba1f4299b0");
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

		private ProcessFlowElement _startMessageVwAdministrativeObjectsUpdating;
		public ProcessFlowElement StartMessageVwAdministrativeObjectsUpdating {
			get {
				return _startMessageVwAdministrativeObjectsUpdating ?? (_startMessageVwAdministrativeObjectsUpdating = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageVwAdministrativeObjectsUpdating",
					SchemaElementUId = new Guid("e0ea4e6c-4ac6-4c6a-b4b0-8fe10e63cb7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptVwAdministrativeObjectsUpdating;
		public ProcessScriptTask ScriptVwAdministrativeObjectsUpdating {
			get {
				return _scriptVwAdministrativeObjectsUpdating ?? (_scriptVwAdministrativeObjectsUpdating = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptVwAdministrativeObjectsUpdating",
					SchemaElementUId = new Guid("9222f106-5075-4f61-8126-43c14a097ef8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptVwAdministrativeObjectsUpdatingExecute,
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

		private ProcessFlowElement _startMessageVwAdministrativeObjectsUpdated;
		public ProcessFlowElement StartMessageVwAdministrativeObjectsUpdated {
			get {
				return _startMessageVwAdministrativeObjectsUpdated ?? (_startMessageVwAdministrativeObjectsUpdated = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageVwAdministrativeObjectsUpdated",
					SchemaElementUId = new Guid("f33ecdd0-d26b-406a-91e5-bff0c405f1ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptVwAdministrativeObjectsUpdated;
		public ProcessScriptTask ScriptVwAdministrativeObjectsUpdated {
			get {
				return _scriptVwAdministrativeObjectsUpdated ?? (_scriptVwAdministrativeObjectsUpdated = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptVwAdministrativeObjectsUpdated",
					SchemaElementUId = new Guid("2bdc98ab-bf56-48ee-9ec3-e71d569a42eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptVwAdministrativeObjectsUpdatedExecute,
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
			FlowElements[StartMessageVwAdministrativeObjectsUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageVwAdministrativeObjectsUpdating };
			FlowElements[ScriptVwAdministrativeObjectsUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptVwAdministrativeObjectsUpdating };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[StartMessageVwAdministrativeObjectsUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageVwAdministrativeObjectsUpdated };
			FlowElements[ScriptVwAdministrativeObjectsUpdated.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptVwAdministrativeObjectsUpdated };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess1":
						break;
					case "StartMessageVwAdministrativeObjectsUpdating":
						e.Context.QueueTasks.Enqueue("ScriptVwAdministrativeObjectsUpdating");
						break;
					case "ScriptVwAdministrativeObjectsUpdating":
						break;
					case "SubProcess2":
						break;
					case "StartMessageVwAdministrativeObjectsUpdated":
						e.Context.QueueTasks.Enqueue("ScriptVwAdministrativeObjectsUpdated");
						break;
					case "ScriptVwAdministrativeObjectsUpdated":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageVwAdministrativeObjectsUpdating");
			ActivatedEventElements.Add("StartMessageVwAdministrativeObjectsUpdated");
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
				case "StartMessageVwAdministrativeObjectsUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageVwAdministrativeObjectsUpdating";
					result = StartMessageVwAdministrativeObjectsUpdating.Execute(context);
					break;
				case "ScriptVwAdministrativeObjectsUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptVwAdministrativeObjectsUpdating";
					result = ScriptVwAdministrativeObjectsUpdating.Execute(context, ScriptVwAdministrativeObjectsUpdatingExecute);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageVwAdministrativeObjectsUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageVwAdministrativeObjectsUpdated";
					result = StartMessageVwAdministrativeObjectsUpdated.Execute(context);
					break;
				case "ScriptVwAdministrativeObjectsUpdated":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptVwAdministrativeObjectsUpdated";
					result = ScriptVwAdministrativeObjectsUpdated.Execute(context, ScriptVwAdministrativeObjectsUpdatedExecute);
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

		public virtual bool ScriptVwAdministrativeObjectsUpdatingExecute(ProcessExecutingContext context) {
			var eventArgs = (context.ThrowEventArgs as Terrasoft.Core.Entities.EntityBeforeEventArgs);
			var queryCondition = new Terrasoft.Core.DB.QueryCondition();
			queryCondition.ConditionType = Terrasoft.Core.DB.QueryConditionType.Equal;
			queryCondition.LeftExpression = new Terrasoft.Core.DB.QueryColumnExpression("SysWorkspaceId");
			queryCondition.RightExpressions.Add(
				new Terrasoft.Core.DB.QueryColumnExpression(Terrasoft.Core.DB.Column.Parameter(Entity.UserConnection.Workspace.Id)));
			eventArgs.AdditionalCondition = queryCondition;
			return true;
		}

		public virtual bool ScriptVwAdministrativeObjectsUpdatedExecute(ProcessExecutingContext context) {
			var eventArgs = (context.ThrowEventArgs as Terrasoft.Core.Entities.EntityAfterEventArgs);
			var modifiedColumnValues = eventArgs.ModifiedColumnValues;
			Guid sysBaseSchemaUId = eventArgs.PrimaryColumnValue;
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
				var administratedByRecords = modifiedColumnValues.FindByName("AdministratedByRecords");
				if (administratedByRecords != null) {
					sysSchema.Instance.ValidateNames(false);
					bool? NeedAddRightsForRecords = administratedByRecords.Value as bool?;
					bool needAddRightsForRecords = (NeedAddRightsForRecords == null) ? false : (bool)NeedAddRightsForRecords;
					if (needAddRightsForRecords) {
						CreateRightRecordsSchema(sysBaseSchemaUId);
					}
					OperationLogger.Instance.LogAdminEntitySchemaEdit(UserConnection, Entity.Name, EntitySchemaAdministrationType.Records, needAddRightsForRecords);
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
					extraProperties.SetValueByName("AdministratedByRecords", adminByRecords.Value);
					schema.AdministratedByRecords = (bool)adminByRecords.Value;
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
					sysSchemaProperty.FetchFromDB(conditions);
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
					case "VwAdministrativeObjectsUpdating":
							if (ActivatedEventElements.Contains("StartMessageVwAdministrativeObjectsUpdating")) {
							context.QueueTasks.Enqueue("StartMessageVwAdministrativeObjectsUpdating");
						}
						break;
					case "VwAdministrativeObjectsUpdated":
							if (ActivatedEventElements.Contains("StartMessageVwAdministrativeObjectsUpdated")) {
							context.QueueTasks.Enqueue("StartMessageVwAdministrativeObjectsUpdated");
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

	#region Class: VwAdministrativeObjects_BaseEventsProcess

	/// <exclude/>
	public class VwAdministrativeObjects_BaseEventsProcess : VwAdministrativeObjects_BaseEventsProcess<VwAdministrativeObjects>
	{

		public VwAdministrativeObjects_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwAdministrativeObjects_BaseEventsProcess

	public partial class VwAdministrativeObjects_BaseEventsProcess<TEntity>
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
			var schema = schemaManager.FindInstanceByUId(entitySchemaId);
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

	#region Class: VwAdministrativeObjectsEventsProcessSchema

	/// <exclude/>
	public class VwAdministrativeObjectsEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public VwAdministrativeObjectsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwAdministrativeObjectsEventsProcessSchema(VwAdministrativeObjectsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwAdministrativeObjects_BaseEventsProcess";
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
			ProcessSchemaStartMessageEvent startmessagevwadministrativeobjectsupdating = CreateStartMessageVwAdministrativeObjectsUpdatingStartMessageEvent();
			subprocess1.FlowElements.Add(startmessagevwadministrativeobjectsupdating);
			ProcessSchemaScriptTask scriptvwadministrativeobjectsupdating = CreateScriptVwAdministrativeObjectsUpdatingScriptTask();
			subprocess1.FlowElements.Add(scriptvwadministrativeobjectsupdating);
			ProcessSchemaStartMessageEvent startmessagevwadministrativeobjectsupdated = CreateStartMessageVwAdministrativeObjectsUpdatedStartMessageEvent();
			subprocess2.FlowElements.Add(startmessagevwadministrativeobjectsupdated);
			ProcessSchemaScriptTask scriptvwadministrativeobjectsupdated = CreateScriptVwAdministrativeObjectsUpdatedScriptTask();
			subprocess2.FlowElements.Add(scriptvwadministrativeobjectsupdated);
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

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageVwAdministrativeObjectsUpdatingStartMessageEvent() {
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
				Message = @"VwAdministrativeObjectsUpdating",
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"StartMessageVwAdministrativeObjectsUpdating",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptVwAdministrativeObjectsUpdatingScriptTask() {
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
				Name = @"ScriptVwAdministrativeObjectsUpdating",
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

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageVwAdministrativeObjectsUpdatedStartMessageEvent() {
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
				Message = @"VwAdministrativeObjectsUpdated",
				ModifiedInSchemaUId = new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"),
				Name = @"StartMessageVwAdministrativeObjectsUpdated",
				Position = new Point(36, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptVwAdministrativeObjectsUpdatedScriptTask() {
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
				Name = @"ScriptVwAdministrativeObjectsUpdated",
				Position = new Point(169, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,219,110,27,55,16,125,150,1,255,3,237,188,172,0,117,83,164,233,75,156,11,100,93,92,1,245,5,150,220,62,22,244,238,72,98,179,75,10,36,101,71,8,252,239,29,146,123,23,105,57,65,10,228,37,142,151,51,103,14,103,14,135,67,63,80,73,224,1,184,30,202,149,34,31,72,148,8,174,225,139,142,23,107,41,30,39,213,10,85,100,1,82,82,37,150,58,30,9,9,241,132,107,166,25,40,247,159,221,112,169,65,86,246,253,179,227,163,7,132,206,69,202,150,12,210,145,200,182,57,255,139,102,91,48,81,170,136,241,165,199,0,125,47,182,44,37,106,167,206,169,130,121,178,134,156,222,205,210,150,227,141,100,57,149,187,134,95,17,18,44,29,231,116,73,57,93,129,68,199,59,5,114,36,56,135,68,51,193,11,206,45,163,194,29,131,186,207,38,218,190,85,124,1,122,166,33,63,223,33,161,168,203,208,108,155,45,73,84,131,156,124,32,124,155,101,125,242,245,248,168,103,240,105,154,51,206,148,150,84,67,122,94,240,55,57,241,165,42,158,50,142,70,87,52,135,232,116,232,245,60,53,49,123,38,104,0,185,197,160,119,47,68,246,137,240,43,128,116,152,166,183,108,181,214,106,42,100,77,195,143,18,91,62,70,5,22,224,172,132,34,60,8,20,133,131,148,140,62,145,37,205,20,144,119,36,50,96,253,144,135,13,103,182,24,136,86,236,173,231,89,242,150,168,215,123,50,255,92,111,0,119,137,114,248,83,172,76,105,103,92,105,202,19,136,241,119,155,236,166,74,38,41,211,81,91,69,3,226,12,98,83,159,242,23,103,221,168,21,26,46,118,27,136,11,66,131,80,202,44,177,39,191,74,42,166,223,35,148,218,57,168,149,6,190,79,46,221,178,180,232,4,161,94,172,153,22,92,244,92,176,144,112,194,62,65,233,212,38,62,245,212,171,63,143,128,106,78,251,26,106,236,230,25,25,221,66,34,100,250,61,26,42,60,131,2,42,145,219,234,169,218,96,157,25,12,197,82,244,49,81,84,100,171,216,63,11,43,173,102,236,15,248,98,141,213,64,123,2,171,150,94,170,174,194,33,40,173,98,189,212,213,72,2,114,182,171,197,138,75,202,207,163,172,130,214,190,172,202,157,52,53,149,108,149,22,249,179,119,228,24,20,91,113,115,77,206,248,200,154,223,208,228,51,46,237,177,244,166,192,94,195,37,126,51,92,149,6,83,240,230,158,140,151,243,136,253,194,69,32,143,24,253,182,97,176,250,114,59,12,214,184,186,252,96,173,174,119,24,175,221,210,236,160,243,5,215,110,164,192,5,51,135,117,115,53,105,47,159,53,91,194,15,107,5,13,196,31,52,201,52,16,255,159,91,47,212,172,58,233,140,231,160,109,148,3,105,24,116,50,234,58,146,59,202,135,36,233,218,139,207,191,60,112,13,214,254,121,238,27,89,151,169,30,116,170,118,152,117,99,176,107,178,110,249,123,88,7,39,139,111,36,222,40,231,96,95,31,135,233,183,103,140,230,14,186,40,229,38,124,141,109,78,31,192,53,55,72,93,123,155,131,82,232,59,166,154,70,205,227,103,185,132,32,202,254,239,152,98,219,171,218,117,187,63,90,144,37,62,182,104,178,38,81,247,204,239,8,227,221,38,80,36,215,246,105,193,241,94,40,118,204,225,145,204,119,10,41,155,57,52,115,240,10,31,51,28,36,75,226,49,179,31,240,61,245,30,51,198,248,106,64,196,253,191,104,245,177,184,195,190,146,83,83,22,204,125,139,129,189,94,200,211,160,180,153,151,109,12,13,219,141,59,37,246,94,123,42,46,205,200,3,131,247,239,233,31,84,173,79,251,61,243,8,101,220,213,162,87,129,86,251,86,123,95,170,29,182,191,71,225,180,246,246,64,226,41,232,100,61,149,34,31,159,71,117,246,66,214,85,48,251,48,237,236,54,224,227,246,233,201,97,192,222,77,55,93,7,247,181,56,78,56,173,120,86,227,133,152,219,66,70,253,119,196,149,52,158,228,27,189,11,109,6,85,25,85,215,252,43,60,192,39,87,147,197,124,49,188,26,15,111,199,111,254,249,149,188,126,77,22,215,227,107,50,186,189,252,229,237,219,223,126,127,83,156,243,147,139,76,220,211,108,184,217,224,9,198,162,225,211,124,138,243,206,86,2,38,253,118,139,249,207,161,245,218,6,77,113,0,164,13,165,62,10,249,89,109,104,2,231,91,150,165,246,185,222,249,91,67,49,62,168,248,239,142,233,157,102,153,41,176,155,177,186,171,157,113,35,70,146,93,21,116,99,199,246,103,215,177,2,110,79,66,130,47,217,106,235,186,71,205,125,148,81,165,166,52,209,66,238,204,159,11,222,119,54,51,218,115,139,103,142,217,30,218,71,87,19,95,32,71,116,180,166,124,5,169,51,123,5,168,217,229,241,17,242,147,128,21,224,68,75,60,67,255,1,243,14,190,95,227,17,0,0 }
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,193,78,195,48,12,61,175,95,225,113,64,173,132,250,3,213,14,43,12,216,1,14,171,224,30,26,175,141,212,166,147,227,14,42,196,191,147,54,221,200,186,9,56,181,113,158,159,95,158,237,189,32,48,121,137,181,120,18,90,20,72,176,128,23,131,116,219,104,141,57,171,70,199,15,200,153,143,8,175,86,154,21,119,39,193,171,8,132,129,11,23,73,176,63,150,176,220,39,181,226,123,165,229,90,27,22,58,199,180,123,89,203,16,61,134,181,140,146,64,109,33,60,100,47,64,183,85,21,193,103,48,35,228,150,116,18,124,13,128,249,68,242,93,154,97,222,146,101,90,233,66,105,236,223,176,54,190,186,165,172,149,86,134,73,48,202,180,219,96,222,144,52,99,165,104,40,241,23,103,134,252,111,198,27,96,106,49,234,245,246,118,144,42,74,54,217,193,148,127,168,119,116,27,47,239,160,53,9,124,21,183,77,213,214,26,74,133,36,40,47,187,241,124,48,62,126,60,189,112,254,78,209,115,103,52,92,95,79,137,226,13,110,145,208,182,203,149,179,45,139,173,177,245,142,187,208,185,246,71,194,81,73,18,204,70,73,14,104,134,97,72,187,103,81,227,84,80,220,7,163,95,168,220,20,156,217,248,132,44,178,156,212,142,207,7,96,245,97,123,21,250,141,112,85,38,211,229,72,150,3,163,21,83,57,110,16,195,199,88,9,26,223,225,50,104,162,199,54,234,55,129,75,41,125,121,153,216,43,93,56,74,19,142,229,110,78,6,199,18,142,241,56,219,17,10,185,212,50,107,136,67,123,177,109,108,32,47,33,236,167,77,49,214,160,142,162,135,23,166,194,224,3,53,237,206,149,128,194,251,95,184,12,187,207,19,148,237,89,239,179,143,157,123,59,57,179,27,225,161,205,29,110,69,91,241,171,168,90,52,126,150,21,56,251,58,154,235,12,0,249,230,29,46,236,196,207,109,18,248,216,120,245,97,183,133,113,226,85,148,124,3,75,58,155,208,219,4,0,0 };
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
			return new VwAdministrativeObjectsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd478e87-d48f-46dc-a466-99d0690b9476"));
		}

		#endregion

	}

	#endregion


	#region Class: VwAdministrativeObjectsEventsProcess

	/// <exclude/>
	public class VwAdministrativeObjectsEventsProcess : VwAdministrativeObjects_BaseEventsProcess
	{

		public VwAdministrativeObjectsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

