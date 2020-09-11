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

	#region Class: DiagramElementSchema

	/// <exclude/>
	[IsVirtual]
	public class DiagramElementSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DiagramElementSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DiagramElementSchema(DiagramElementSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DiagramElementSchema(DiagramElementSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e");
			RealUId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e");
			Name = "DiagramElement";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e7fd766a-3b94-49b8-831c-ca4d3b5a4c66")) == null) {
				Columns.Add(CreateJSONColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateJSONColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e7fd766a-3b94-49b8-831c-ca4d3b5a4c66"),
				Name = @"JSON",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e"),
				ModifiedInSchemaUId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDiagramElementEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDiagramElementEventsProcessSchema() {
			var schema = new DiagramElementEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DiagramElement(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DiagramElement_ProcessLibraryEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DiagramElementSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DiagramElementSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e"));
		}

		#endregion

	}

	#endregion

	#region Class: DiagramElement

	/// <summary>
	/// Diagram element object.
	/// </summary>
	public class DiagramElement : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DiagramElement(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DiagramElement";
		}

		public DiagramElement(DiagramElement source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// JSON.
		/// </summary>
		public string JSON {
			get {
				return GetTypedColumnValue<string>("JSON");
			}
			set {
				SetColumnValue("JSON", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DiagramElement_ProcessLibraryEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DiagramElementDeleted", e);
			Loaded += (s, e) => ThrowEvent("DiagramElementLoaded", e);
			Saving += (s, e) => ThrowEvent("DiagramElementSaving", e);
			Validating += (s, e) => ThrowEvent("DiagramElementValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DiagramElement(this);
		}

		#endregion

	}

	#endregion

	#region Class: DiagramElement_ProcessLibraryEventsProcess

	/// <exclude/>
	public partial class DiagramElement_ProcessLibraryEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_BaseEventsProcess<TEntity> where TEntity : DiagramElement
	{

		public DiagramElement_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DiagramElement_ProcessLibraryEventsProcess";
			SchemaUId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_supportedProperties = () => {{ return "offsetX,offsetY"; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<string> _supportedProperties;
		public virtual string SupportedProperties {
			get {
				return (_supportedProperties ?? (_supportedProperties = () => null)).Invoke();
			}
			set {
				_supportedProperties = () => { return value; };
			}
		}

		private ProcessFlowElement _syncfusionDiagramObjLoadedEventSubProcess;
		public ProcessFlowElement SyncfusionDiagramObjLoadedEventSubProcess {
			get {
				return _syncfusionDiagramObjLoadedEventSubProcess ?? (_syncfusionDiagramObjLoadedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SyncfusionDiagramObjLoadedEventSubProcess",
					SchemaElementUId = new Guid("88b9dd14-9251-43db-b553-b42bd88f543f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _diagramElementLoadedStartMessage;
		public ProcessFlowElement DiagramElementLoadedStartMessage {
			get {
				return _diagramElementLoadedStartMessage ?? (_diagramElementLoadedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DiagramElementLoadedStartMessage",
					SchemaElementUId = new Guid("8489d170-579d-4843-aeed-e253e822b3da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _syncfusionDiagramObjLoadedScriptTask;
		public ProcessScriptTask SyncfusionDiagramObjLoadedScriptTask {
			get {
				return _syncfusionDiagramObjLoadedScriptTask ?? (_syncfusionDiagramObjLoadedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SyncfusionDiagramObjLoadedScriptTask",
					SchemaElementUId = new Guid("9b2fcb73-b86f-48cb-bcc4-ea35acb8b214"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SyncfusionDiagramObjLoadedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SyncfusionDiagramObjLoadedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SyncfusionDiagramObjLoadedEventSubProcess };
			FlowElements[DiagramElementLoadedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DiagramElementLoadedStartMessage };
			FlowElements[SyncfusionDiagramObjLoadedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SyncfusionDiagramObjLoadedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SyncfusionDiagramObjLoadedEventSubProcess":
						break;
					case "DiagramElementLoadedStartMessage":
						e.Context.QueueTasks.Enqueue("SyncfusionDiagramObjLoadedScriptTask");
						break;
					case "SyncfusionDiagramObjLoadedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("DiagramElementLoadedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SyncfusionDiagramObjLoadedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DiagramElementLoadedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DiagramElementLoadedStartMessage";
					result = DiagramElementLoadedStartMessage.Execute(context);
					break;
				case "SyncfusionDiagramObjLoadedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SyncfusionDiagramObjLoadedScriptTask";
					result = SyncfusionDiagramObjLoadedScriptTask.Execute(context, SyncfusionDiagramObjLoadedScriptTaskExecute);
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

		public virtual bool SyncfusionDiagramObjLoadedScriptTaskExecute(ProcessExecutingContext context) {
			return LoadedMethod(context);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "DiagramElementLoaded":
							if (ActivatedEventElements.Contains("DiagramElementLoadedStartMessage")) {
							context.QueueTasks.Enqueue("DiagramElementLoadedStartMessage");
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

	#region Class: DiagramElement_ProcessLibraryEventsProcess

	/// <exclude/>
	public class DiagramElement_ProcessLibraryEventsProcess : DiagramElement_ProcessLibraryEventsProcess<DiagramElement>
	{

		public DiagramElement_ProcessLibraryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DiagramElement_ProcessLibraryEventsProcess

	public partial class DiagramElement_ProcessLibraryEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual bool LoadedMethod(ProcessExecutingContext context) {
			if (!Entity.Schema.Columns.Any(column => column.Name == "JSON")) {
				return true;
			}
			string json = Entity.GetTypedColumnValue<string>("JSON");
			if (!string.IsNullOrEmpty(json)) {
				string[] properties = GetSupportedProperties();
				string extractedProperties = ExtractProperties(json, properties);
				Entity.SetColumnValue("JSON", extractedProperties);
			}
			return true;
		}

		public virtual string ExtractProperties(string json, params string[] properties) {
			JObject sourceObject = JObject.Parse(json);
			JObject newObject = new JObject();
			foreach (string propertyName in properties) {
				JToken value = sourceObject[propertyName];
				if (value == null) {
					continue;
				}
				newObject.Add(propertyName, value);
			}
			return newObject.ToString();
		}

		public virtual string[] GetSupportedProperties() {
			if (string.IsNullOrEmpty(SupportedProperties)) {
				return new string[] { };
			}
			return SupportedProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		}

		#endregion

	}

	#endregion

	#region Class: DiagramElementEventsProcessSchema

	/// <exclude/>
	public class DiagramElementEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DiagramElementEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DiagramElementEventsProcessSchema(DiagramElementEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DiagramElement_ProcessLibraryEventsProcess";
			UId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7");
			CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c");
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

		protected virtual ProcessSchemaParameter CreateSupportedPropertiesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ec29dad5-6924-41ff-8cf5-dcaf425bbe4e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"SupportedProperties",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSupportedPropertiesParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaMainLaneSet = CreateMainLaneSetLaneSet();
			LaneSets.Add(schemaMainLaneSet);
			ProcessSchemaLane schemaMainLane = CreateMainLaneLane();
			schemaMainLaneSet.Lanes.Add(schemaMainLane);
			ProcessSchemaEventSubProcess syncfusiondiagramobjloadedeventsubprocess = CreateSyncfusionDiagramObjLoadedEventSubProcessEventSubProcess();
			FlowElements.Add(syncfusiondiagramobjloadedeventsubprocess);
			ProcessSchemaStartMessageEvent diagramelementloadedstartmessage = CreateDiagramElementLoadedStartMessageStartMessageEvent();
			syncfusiondiagramobjloadedeventsubprocess.FlowElements.Add(diagramelementloadedstartmessage);
			ProcessSchemaScriptTask syncfusiondiagramobjloadedscripttask = CreateSyncfusionDiagramObjLoadedScriptTaskScriptTask();
			syncfusiondiagramobjloadedeventsubprocess.FlowElements.Add(syncfusiondiagramobjloadedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("0561d4e1-1e5f-492b-b6a6-2999ae0e13cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CurveCenterPosition = new Point(376, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8489d170-579d-4843-aeed-e253e822b3da"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b2fcb73-b86f-48cb-bcc4-ea35acb8b214"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMainLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMainLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("db52b9d8-8223-4f1e-993e-8d8268017857"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"MainLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1226, 184),
				UseBackgroundMode = false
			};
			return schemaMainLaneSet;
		}

		protected virtual ProcessSchemaLane CreateMainLaneLane() {
			ProcessSchemaLane schemaMainLane = new ProcessSchemaLane(this) {
				UId = new Guid("9d046742-34a9-4a20-ad88-a3b7278f77ef"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("db52b9d8-8223-4f1e-993e-8d8268017857"),
				CreatedInOwnerSchemaUId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"MainLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1197, 184),
				UseBackgroundMode = false
			};
			return schemaMainLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSyncfusionDiagramObjLoadedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSyncfusionDiagramObjLoadedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("88b9dd14-9251-43db-b553-b42bd88f543f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d046742-34a9-4a20-ad88-a3b7278f77ef"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"SyncfusionDiagramObjLoadedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(203, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSyncfusionDiagramObjLoadedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDiagramElementLoadedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8489d170-579d-4843-aeed-e253e822b3da"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88b9dd14-9251-43db-b553-b42bd88f543f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DiagramElementLoaded",
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"DiagramElementLoadedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSyncfusionDiagramObjLoadedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9b2fcb73-b86f-48cb-bcc4-ea35acb8b214"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88b9dd14-9251-43db-b553-b42bd88f543f"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"SyncfusionDiagramObjLoadedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,240,201,79,76,73,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,6,0,187,108,161,99,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateLoadedMethodMethod());
			Methods.Add(CreateExtractPropertiesMethod());
			Methods.Add(CreateGetSupportedPropertiesMethod());
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
				UId = new Guid("508f7fb7-a5c3-49dd-be14-119dec42069b"),
				Name = "Newtonsoft.Json.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6663ee52-2b09-4be7-94e3-45fb682acae9"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
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

		protected virtual SchemaMethod CreateLoadedMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f1be1fc-071a-4b93-a4fa-4fec690408df"),
				Name = "LoadedMethod",
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b532ddc5-32d9-4016-92a6-9054a3b3ddbf"),
				Name = "context",
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,107,131,64,16,133,207,241,87,76,61,173,32,251,7,172,66,8,33,164,7,45,88,122,41,61,136,78,146,13,186,46,179,179,80,41,253,239,117,187,54,24,200,109,152,153,247,189,199,83,39,16,79,123,205,138,39,89,183,23,28,26,185,27,123,55,104,43,183,122,18,237,223,12,121,1,97,146,101,51,32,228,57,196,47,117,85,198,73,2,223,209,134,144,29,105,96,114,152,69,63,145,101,82,250,12,87,59,206,66,88,216,7,228,183,201,96,23,224,239,77,239,240,57,60,22,98,97,101,145,242,97,194,86,30,109,233,250,190,162,253,96,120,18,30,22,204,194,249,227,19,12,141,6,137,21,218,217,101,198,215,206,152,145,24,187,215,219,65,204,204,69,0,248,197,212,180,119,103,159,46,108,87,18,239,148,174,224,30,241,223,15,242,42,254,18,59,125,68,78,124,15,235,90,126,1,60,65,10,23,103,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateExtractPropertiesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("82bc49d3-722c-483a-a138-f518b36f7158"),
				Name = "ExtractProperties",
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d2ddb03c-462c-441c-bfb3-e3c44a5cc874"),
				Name = "json",
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7e215728-3813-4226-97ae-f9d95566d3b1"),
				Name = "properties",
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string[]",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,143,189,14,194,48,12,132,231,230,41,60,166,18,234,11,84,12,172,29,0,137,110,136,33,164,46,164,20,167,114,18,16,66,125,119,162,254,209,237,108,125,190,59,23,135,107,131,218,131,179,129,53,78,195,22,138,81,101,71,197,14,101,227,44,165,185,152,150,64,248,94,192,168,103,88,70,164,182,140,74,223,65,58,207,134,110,208,177,237,144,253,103,175,158,8,134,230,217,160,75,225,43,146,162,180,15,36,120,169,54,96,52,91,151,56,175,79,47,185,72,76,13,114,2,99,108,104,219,193,33,209,150,188,161,128,145,232,69,178,84,203,118,85,37,215,22,155,49,37,118,236,5,163,15,76,255,63,178,210,158,134,190,241,133,31,235,131,190,96,17,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSupportedPropertiesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("94959676-08a9-4d55-b23d-bc43d472b291"),
				Name = "GetSupportedProperties",
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c"),
				ResultValueTypeName = "string[]"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,206,177,10,194,48,16,198,241,217,64,222,225,182,166,80,242,2,157,59,184,88,105,70,113,16,61,53,144,38,225,114,81,164,228,221,173,209,209,249,207,239,190,179,87,80,137,201,250,155,222,166,93,118,110,164,97,142,252,82,38,199,24,136,241,178,167,16,145,216,98,106,91,88,164,216,16,114,38,15,30,159,240,149,135,35,44,80,122,41,138,20,191,248,71,107,19,157,101,245,97,231,251,137,42,106,186,6,74,7,166,158,169,125,140,108,131,79,122,194,57,60,176,190,50,248,53,175,235,253,27,68,44,165,16,172,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DiagramElementEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"));
		}

		#endregion

	}

	#endregion


	#region Class: DiagramElementEventsProcess

	/// <exclude/>
	public class DiagramElementEventsProcess : DiagramElement_ProcessLibraryEventsProcess
	{

		public DiagramElementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

