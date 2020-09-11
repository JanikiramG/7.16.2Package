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

	#region Class: ActivityTypeSchema

	/// <exclude/>
	public class ActivityTypeSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public ActivityTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityTypeSchema(ActivityTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityTypeSchema(ActivityTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7");
			RealUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7");
			Name = "ActivityType";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateTypeImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTypeImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Image")) {
				UId = new Guid("b4265a4b-144c-40ca-9489-88fd5a46eb29"),
				Name = @"TypeImage",
				CreatedInSchemaUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7"),
				ModifiedInSchemaUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7"),
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityTypeEventsProcessSchema() {
			var schema = new ActivityTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityType_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityType

	/// <summary>
	/// Activity type.
	/// </summary>
	/// <remarks>
	/// Activity type.
	/// </remarks>
	public class ActivityType : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public ActivityType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityType";
		}

		public ActivityType(ActivityType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityType_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("ActivityTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("ActivityTypeInserting", e);
			Saved += (s, e) => ThrowEvent("ActivityTypeSaved", e);
			Saving += (s, e) => ThrowEvent("ActivityTypeSaving", e);
			Validating += (s, e) => ThrowEvent("ActivityTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityType_BaseEventsProcess

	/// <exclude/>
	public partial class ActivityType_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : ActivityType
	{

		public ActivityType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityType_BaseEventsProcess";
			SchemaUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _activityTypeEventSubProcess;
		public ProcessFlowElement ActivityTypeEventSubProcess {
			get {
				return _activityTypeEventSubProcess ?? (_activityTypeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityTypeEventSubProcess",
					SchemaElementUId = new Guid("9fe683cb-ed35-4cf1-b245-2774cac282b7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityTypeSavedStartMessage;
		public ProcessFlowElement ActivityTypeSavedStartMessage {
			get {
				return _activityTypeSavedStartMessage ?? (_activityTypeSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityTypeSavedStartMessage",
					SchemaElementUId = new Guid("9b860427-90b7-4fce-b19a-62f426910cef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityTypeDeletingStartMessage;
		public ProcessFlowElement ActivityTypeDeletingStartMessage {
			get {
				return _activityTypeDeletingStartMessage ?? (_activityTypeDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityTypeDeletingStartMessage",
					SchemaElementUId = new Guid("fe7f1c36-210b-4bd4-a5b2-ebdfa13e54f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityTypeSavedDeletingScriptTask;
		public ProcessScriptTask ActivityTypeSavedDeletingScriptTask {
			get {
				return _activityTypeSavedDeletingScriptTask ?? (_activityTypeSavedDeletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityTypeSavedDeletingScriptTask",
					SchemaElementUId = new Guid("eff0df94-7003-4479-bb66-21f7f04e96e7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityTypeSavedDeletingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ActivityTypeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityTypeEventSubProcess };
			FlowElements[ActivityTypeSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityTypeSavedStartMessage };
			FlowElements[ActivityTypeDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityTypeDeletingStartMessage };
			FlowElements[ActivityTypeSavedDeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityTypeSavedDeletingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ActivityTypeEventSubProcess":
						break;
					case "ActivityTypeSavedStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityTypeSavedDeletingScriptTask");
						break;
					case "ActivityTypeDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityTypeSavedDeletingScriptTask");
						break;
					case "ActivityTypeSavedDeletingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityTypeSavedStartMessage");
			ActivatedEventElements.Add("ActivityTypeDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ActivityTypeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityTypeSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityTypeSavedStartMessage";
					result = ActivityTypeSavedStartMessage.Execute(context);
					break;
				case "ActivityTypeDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityTypeDeletingStartMessage";
					result = ActivityTypeDeletingStartMessage.Execute(context);
					break;
				case "ActivityTypeSavedDeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityTypeSavedDeletingScriptTask";
					result = ActivityTypeSavedDeletingScriptTask.Execute(context, ActivityTypeSavedDeletingScriptTaskExecute);
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

		public virtual bool ActivityTypeSavedDeletingScriptTaskExecute(ProcessExecutingContext context) {
			ClearCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ActivityTypeSaved":
							if (ActivatedEventElements.Contains("ActivityTypeSavedStartMessage")) {
							context.QueueTasks.Enqueue("ActivityTypeSavedStartMessage");
						}
						break;
					case "ActivityTypeDeleting":
							if (ActivatedEventElements.Contains("ActivityTypeDeletingStartMessage")) {
							context.QueueTasks.Enqueue("ActivityTypeDeletingStartMessage");
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

	#region Class: ActivityType_BaseEventsProcess

	/// <exclude/>
	public class ActivityType_BaseEventsProcess : ActivityType_BaseEventsProcess<ActivityType>
	{

		public ActivityType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityType_BaseEventsProcess

	public partial class ActivityType_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ClearCache() {
			ActivityUtils.ClearActivityCache(UserConnection);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityTypeEventsProcessSchema

	/// <exclude/>
	public class ActivityTypeEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityTypeEventsProcessSchema(ActivityTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityType_BaseEventsProcess";
			UId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875");
			CreatedInPackageId = new Guid("f25ac8e1-73cc-488f-8dc8-76a50a94117e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess activitytypeeventsubprocess = CreateActivityTypeEventSubProcessEventSubProcess();
			FlowElements.Add(activitytypeeventsubprocess);
			ProcessSchemaStartMessageEvent activitytypesavedstartmessage = CreateActivityTypeSavedStartMessageStartMessageEvent();
			activitytypeeventsubprocess.FlowElements.Add(activitytypesavedstartmessage);
			ProcessSchemaStartMessageEvent activitytypedeletingstartmessage = CreateActivityTypeDeletingStartMessageStartMessageEvent();
			activitytypeeventsubprocess.FlowElements.Add(activitytypedeletingstartmessage);
			ProcessSchemaScriptTask activitytypesaveddeletingscripttask = CreateActivityTypeSavedDeletingScriptTaskScriptTask();
			activitytypeeventsubprocess.FlowElements.Add(activitytypesaveddeletingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6040b843-5914-40bc-b443-436a847c4680"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				CurveCenterPosition = new Point(194, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b860427-90b7-4fce-b19a-62f426910cef"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eff0df94-7003-4479-bb66-21f7f04e96e7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("4eac208b-8d8e-4020-85c8-edbe726d91ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				CurveCenterPosition = new Point(193, 118),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe7f1c36-210b-4bd4-a5b2-ebdfa13e54f8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eff0df94-7003-4479-bb66-21f7f04e96e7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("fe34d024-a96c-46c7-9bdb-dbd6d48ebbd2"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(604, 207),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e1a49d66-d24f-4c36-8611-e814002cc4c1"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("fe34d024-a96c-46c7-9bdb-dbd6d48ebbd2"),
				CreatedInOwnerSchemaUId = new Guid("75b4d39b-55dc-4bd6-8d10-3f49a58d96c7"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(575, 207),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityTypeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityTypeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9fe683cb-ed35-4cf1-b245-2774cac282b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e1a49d66-d24f-4c36-8611-e814002cc4c1"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				Name = @"ActivityTypeEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 186),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityTypeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityTypeSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9b860427-90b7-4fce-b19a-62f426910cef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9fe683cb-ed35-4cf1-b245-2774cac282b7"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityTypeSaved",
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				Name = @"ActivityTypeSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityTypeDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("fe7f1c36-210b-4bd4-a5b2-ebdfa13e54f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9fe683cb-ed35-4cf1-b245-2774cac282b7"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityTypeDeleting",
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				Name = @"ActivityTypeDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityTypeSavedDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eff0df94-7003-4479-bb66-21f7f04e96e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9fe683cb-ed35-4cf1-b245-2774cac282b7"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				Name = @"ActivityTypeSavedDeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(169, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,114,78,76,206,72,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,179,169,176,3,27,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearCacheMethod());
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

		protected virtual SchemaMethod CreateClearCacheMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("27a3db28-5258-4bc8-888b-6dd9ae1312cb"),
				Name = "ClearCache",
				CreatedInSchemaUId = new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,201,44,203,44,169,12,45,201,204,41,214,115,206,73,77,44,114,132,10,57,39,38,103,164,106,132,22,167,22,57,231,231,229,165,2,69,243,243,52,173,1,118,135,194,14,49,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c6da7a4-47cd-47fd-bb33-72bde5e5c875"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityTypeEventsProcess

	/// <exclude/>
	public class ActivityTypeEventsProcess : ActivityType_BaseEventsProcess
	{

		public ActivityTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

