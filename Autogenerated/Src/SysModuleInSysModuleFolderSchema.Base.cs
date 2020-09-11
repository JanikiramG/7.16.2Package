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

	#region Class: SysModuleInSysModuleFolderSchema

	/// <exclude/>
	public class SysModuleInSysModuleFolderSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysModuleInSysModuleFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleInSysModuleFolderSchema(SysModuleInSysModuleFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleInSysModuleFolderSchema(SysModuleInSysModuleFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9");
			RealUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9");
			Name = "SysModuleInSysModuleFolder";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("398c17c3-5f0d-4bfd-bace-e54e45b93b1d")) == null) {
				Columns.Add(CreateSysModuleColumn());
			}
			if (Columns.FindByUId(new Guid("04fe38fc-1cef-455a-924f-9274a5091aab")) == null) {
				Columns.Add(CreateSubSysModuleFolderColumn());
			}
			if (Columns.FindByUId(new Guid("08b75e4a-c487-41e7-8c43-0d6f4026d9a1")) == null) {
				Columns.Add(CreateSysModuleFolderColumn());
			}
			if (Columns.FindByUId(new Guid("8b924055-9d6a-4149-9519-ce5f5735a88e")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysModuleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("398c17c3-5f0d-4bfd-bace-e54e45b93b1d"),
				Name = @"SysModule",
				ReferenceSchemaUId = new Guid("2b2ed767-0b4b-4a7b-9de2-d48e14a2c0c5"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				ModifiedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSubSysModuleFolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("04fe38fc-1cef-455a-924f-9274a5091aab"),
				Name = @"SubSysModuleFolder",
				ReferenceSchemaUId = new Guid("88fa8985-5bbd-4975-95b1-51caec10987a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				ModifiedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysModuleFolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("08b75e4a-c487-41e7-8c43-0d6f4026d9a1"),
				Name = @"SysModuleFolder",
				ReferenceSchemaUId = new Guid("88fa8985-5bbd-4975-95b1-51caec10987a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				ModifiedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("8b924055-9d6a-4149-9519-ce5f5735a88e"),
				Name = @"Position",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				ModifiedInSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleInSysModuleFolderEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysModuleInSysModuleFolderEventsProcessSchema() {
			var schema = new SysModuleInSysModuleFolderEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleInSysModuleFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleInSysModuleFolder_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleInSysModuleFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleInSysModuleFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleInSysModuleFolder

	/// <summary>
	/// Section in SysModule folder.
	/// </summary>
	public class SysModuleInSysModuleFolder : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysModuleInSysModuleFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleInSysModuleFolder";
		}

		public SysModuleInSysModuleFolder(SysModuleInSysModuleFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysModuleId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleId");
			}
			set {
				SetColumnValue("SysModuleId", value);
				_sysModule = null;
			}
		}

		/// <exclude/>
		public string SysModuleCaption {
			get {
				return GetTypedColumnValue<string>("SysModuleCaption");
			}
			set {
				SetColumnValue("SysModuleCaption", value);
				if (_sysModule != null) {
					_sysModule.Caption = value;
				}
			}
		}

		private SysModule _sysModule;
		/// <summary>
		/// Section.
		/// </summary>
		public SysModule SysModule {
			get {
				return _sysModule ??
					(_sysModule = LookupColumnEntities.GetEntity("SysModule") as SysModule);
			}
		}

		/// <exclude/>
		public Guid SubSysModuleFolderId {
			get {
				return GetTypedColumnValue<Guid>("SubSysModuleFolderId");
			}
			set {
				SetColumnValue("SubSysModuleFolderId", value);
				_subSysModuleFolder = null;
			}
		}

		/// <exclude/>
		public string SubSysModuleFolderCaption {
			get {
				return GetTypedColumnValue<string>("SubSysModuleFolderCaption");
			}
			set {
				SetColumnValue("SubSysModuleFolderCaption", value);
				if (_subSysModuleFolder != null) {
					_subSysModuleFolder.Caption = value;
				}
			}
		}

		private SysModuleFolder _subSysModuleFolder;
		/// <summary>
		/// Subordinate workplace.
		/// </summary>
		public SysModuleFolder SubSysModuleFolder {
			get {
				return _subSysModuleFolder ??
					(_subSysModuleFolder = LookupColumnEntities.GetEntity("SubSysModuleFolder") as SysModuleFolder);
			}
		}

		/// <exclude/>
		public Guid SysModuleFolderId {
			get {
				return GetTypedColumnValue<Guid>("SysModuleFolderId");
			}
			set {
				SetColumnValue("SysModuleFolderId", value);
				_sysModuleFolder = null;
			}
		}

		/// <exclude/>
		public string SysModuleFolderCaption {
			get {
				return GetTypedColumnValue<string>("SysModuleFolderCaption");
			}
			set {
				SetColumnValue("SysModuleFolderCaption", value);
				if (_sysModuleFolder != null) {
					_sysModuleFolder.Caption = value;
				}
			}
		}

		private SysModuleFolder _sysModuleFolder;
		/// <summary>
		/// Workplace.
		/// </summary>
		public SysModuleFolder SysModuleFolder {
			get {
				return _sysModuleFolder ??
					(_sysModuleFolder = LookupColumnEntities.GetEntity("SysModuleFolder") as SysModuleFolder);
			}
		}

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleInSysModuleFolder_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleInSysModuleFolderDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysModuleInSysModuleFolderDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysModuleInSysModuleFolderInserted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleInSysModuleFolderInserting", e);
			Saved += (s, e) => ThrowEvent("SysModuleInSysModuleFolderSaved", e);
			Saving += (s, e) => ThrowEvent("SysModuleInSysModuleFolderSaving", e);
			Validating += (s, e) => ThrowEvent("SysModuleInSysModuleFolderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleInSysModuleFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleInSysModuleFolder_BaseEventsProcess

	/// <exclude/>
	public partial class SysModuleInSysModuleFolder_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : SysModuleInSysModuleFolder
	{

		public SysModuleInSysModuleFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleInSysModuleFolder_BaseEventsProcess";
			SchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("23960511-3f42-47e5-9f69-1550f0f637e9");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsLastRecord {
			get;
			set;
		}

		private ProcessFlowElement _eventAfterDelete;
		public ProcessFlowElement EventAfterDelete {
			get {
				return _eventAfterDelete ?? (_eventAfterDelete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventAfterDelete",
					SchemaElementUId = new Guid("6a44a6ba-6288-4e9c-91f9-e95e7db61721"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageAfterDelete;
		public ProcessFlowElement StartMessageAfterDelete {
			get {
				return _startMessageAfterDelete ?? (_startMessageAfterDelete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageAfterDelete",
					SchemaElementUId = new Guid("bddf7a50-090b-4993-b488-8033729b3ce1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskCheckLastRecord;
		public ProcessScriptTask ScriptTaskCheckLastRecord {
			get {
				return _scriptTaskCheckLastRecord ?? (_scriptTaskCheckLastRecord = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskCheckLastRecord",
					SchemaElementUId = new Guid("f7760a60-a7c2-4ccc-8457-076e04859034"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskCheckLastRecordExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventAfterDelete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventAfterDelete };
			FlowElements[StartMessageAfterDelete.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageAfterDelete };
			FlowElements[ScriptTaskCheckLastRecord.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskCheckLastRecord };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventAfterDelete":
						break;
					case "StartMessageAfterDelete":
						e.Context.QueueTasks.Enqueue("ScriptTaskCheckLastRecord");
						break;
					case "ScriptTaskCheckLastRecord":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageAfterDelete");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventAfterDelete":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageAfterDelete":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageAfterDelete";
					result = StartMessageAfterDelete.Execute(context);
					break;
				case "ScriptTaskCheckLastRecord":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskCheckLastRecord";
					result = ScriptTaskCheckLastRecord.Execute(context, ScriptTaskCheckLastRecordExecute);
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
				case "IsLastRecord":
					IsLastRecord = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskCheckLastRecordExecute(ProcessExecutingContext context) {
			var recordTableESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModuleInSysModuleFolder");
			recordTableESQ.AddColumn(recordTableESQ.RootSchema.GetPrimaryColumnName());
			recordTableESQ.AddColumn("SysModule");
			recordTableESQ.Filters.Add(recordTableESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "SysModule", Entity.GetTypedColumnValue<string>("SysModuleId")));
			var recordEntity = recordTableESQ.GetEntityCollection(UserConnection);
			if (recordEntity.Count < 1) {
				UserConnection.EntitySchemaManager.GetInstanceByName("SysModule")
					.CreateEntity(UserConnection).Delete(Entity.GetTypedColumnValue<Guid>("SysModuleId"));
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysModuleInSysModuleFolderDeleted":
							if (ActivatedEventElements.Contains("StartMessageAfterDelete")) {
							context.QueueTasks.Enqueue("StartMessageAfterDelete");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsLastRecord") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsLastRecord", IsLastRecord, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleInSysModuleFolder_BaseEventsProcess

	/// <exclude/>
	public class SysModuleInSysModuleFolder_BaseEventsProcess : SysModuleInSysModuleFolder_BaseEventsProcess<SysModuleInSysModuleFolder>
	{

		public SysModuleInSysModuleFolder_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleInSysModuleFolder_BaseEventsProcess

	public partial class SysModuleInSysModuleFolder_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: SysModuleInSysModuleFolderEventsProcessSchema

	/// <exclude/>
	public class SysModuleInSysModuleFolderEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleInSysModuleFolderEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleInSysModuleFolderEventsProcessSchema(SysModuleInSysModuleFolderEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleInSysModuleFolder_BaseEventsProcess";
			UId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		protected virtual ProcessSchemaParameter CreateIsLastRecordParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6238afdc-cc79-4e8c-91e3-09f0aff22d58"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Name = @"IsLastRecord",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsLastRecordParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaObjectEvents = CreateObjectEventsLaneSet();
			LaneSets.Add(schemaObjectEvents);
			ProcessSchemaLane schemaDelete = CreateDeleteLane();
			schemaObjectEvents.Lanes.Add(schemaDelete);
			ProcessSchemaEventSubProcess eventafterdelete = CreateEventAfterDeleteEventSubProcess();
			FlowElements.Add(eventafterdelete);
			ProcessSchemaStartMessageEvent startmessageafterdelete = CreateStartMessageAfterDeleteStartMessageEvent();
			eventafterdelete.FlowElements.Add(startmessageafterdelete);
			ProcessSchemaScriptTask scripttaskchecklastrecord = CreateScriptTaskCheckLastRecordScriptTask();
			eventafterdelete.FlowElements.Add(scripttaskchecklastrecord);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("a8bc7940-4ba1-4b2d-838b-5f46c4414188"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				CurveCenterPosition = new Point(187, 89),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bddf7a50-090b-4993-b488-8033729b3ce1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f7760a60-a7c2-4ccc-8457-076e04859034"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateObjectEventsLaneSet() {
			ProcessSchemaLaneSet schemaObjectEvents = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c2b7bf15-8eaa-4972-9708-042ab4354c7c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Name = @"ObjectEvents",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(827, 177),
				UseBackgroundMode = false
			};
			return schemaObjectEvents;
		}

		protected virtual ProcessSchemaLane CreateDeleteLane() {
			ProcessSchemaLane schemaDelete = new ProcessSchemaLane(this) {
				UId = new Guid("f6b844f6-e2bd-47cc-a883-df1bce6fa6f9"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("c2b7bf15-8eaa-4972-9708-042ab4354c7c"),
				CreatedInOwnerSchemaUId = new Guid("23960511-3f42-47e5-9f69-1550f0f637e9"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Name = @"Delete",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(798, 177),
				UseBackgroundMode = false
			};
			return schemaDelete;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventAfterDeleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventAfterDelete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6a44a6ba-6288-4e9c-91f9-e95e7db61721"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6b844f6-e2bd-47cc-a883-df1bce6fa6f9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Name = @"EventAfterDelete",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(476, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventAfterDelete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageAfterDeleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("bddf7a50-090b-4993-b488-8033729b3ce1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a44a6ba-6288-4e9c-91f9-e95e7db61721"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SysModuleInSysModuleFolderDeleted",
				ModifiedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Name = @"StartMessageAfterDelete",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskCheckLastRecordScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f7760a60-a7c2-4ccc-8457-076e04859034"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a44a6ba-6288-4e9c-91f9-e95e7db61721"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"),
				Name = @"ScriptTaskCheckLastRecord",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,193,78,2,49,16,61,75,194,63,52,123,218,77,200,38,158,65,19,93,129,112,192,128,160,158,199,237,8,77,186,83,156,109,49,27,227,191,219,82,130,235,106,240,214,116,222,188,247,230,189,61,176,96,44,13,203,53,188,104,28,175,150,226,74,16,190,139,49,89,101,155,85,185,197,10,150,14,185,73,31,107,228,194,16,97,105,149,161,188,13,152,3,193,6,121,32,146,85,83,207,141,116,26,103,116,122,78,140,150,200,73,54,236,247,126,74,229,55,82,22,70,187,138,210,206,224,193,24,27,169,243,41,218,5,171,10,184,137,208,123,168,48,205,206,146,125,187,248,75,116,162,180,69,174,3,190,43,91,48,130,197,8,120,86,118,187,0,246,106,1,157,198,207,194,84,59,96,85,27,90,55,59,204,199,111,14,116,251,234,100,112,12,46,216,14,144,163,165,39,208,14,71,181,101,69,155,235,150,191,153,76,178,195,45,251,83,15,113,223,183,208,241,230,9,227,200,51,234,216,65,167,146,192,163,94,69,218,230,201,11,227,200,138,145,184,204,196,71,191,119,241,127,137,65,104,70,181,5,42,241,182,57,164,221,206,211,115,92,28,115,138,203,93,19,249,29,106,31,89,122,38,135,169,83,242,87,10,222,252,103,232,202,58,38,97,217,225,240,11,241,136,44,67,156,2,0,0 }
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleInSysModuleFolderEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d36ff8ad-f724-469f-b5ec-0aa9aeb1c785"));
		}

		#endregion

	}

	#endregion


	#region Class: SysModuleInSysModuleFolderEventsProcess

	/// <exclude/>
	public class SysModuleInSysModuleFolderEventsProcess : SysModuleInSysModuleFolder_BaseEventsProcess
	{

		public SysModuleInSysModuleFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

