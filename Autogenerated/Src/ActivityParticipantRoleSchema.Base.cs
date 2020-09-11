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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ActivityParticipantRoleSchema

	/// <exclude/>
	public class ActivityParticipantRoleSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public ActivityParticipantRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityParticipantRoleSchema(ActivityParticipantRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityParticipantRoleSchema(ActivityParticipantRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01e72783-64d7-4fac-9d9a-1648eacd51c9");
			RealUId = new Guid("01e72783-64d7-4fac-9d9a-1648eacd51c9");
			Name = "ActivityParticipantRole";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d5a7ef71-6903-49c6-895f-378c283b75c2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityParticipantRoleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityParticipantRoleEventsProcessSchema() {
			var schema = new ActivityParticipantRoleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityParticipantRole(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityParticipantRole_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityParticipantRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityParticipantRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01e72783-64d7-4fac-9d9a-1648eacd51c9"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipantRole

	/// <summary>
	/// Activity participant roles.
	/// </summary>
	public class ActivityParticipantRole : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public ActivityParticipantRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityParticipantRole";
		}

		public ActivityParticipantRole(ActivityParticipantRole source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityParticipantRole_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ActivityParticipantRoleDeleted", e);
			Deleting += (s, e) => ThrowEvent("ActivityParticipantRoleDeleting", e);
			Inserted += (s, e) => ThrowEvent("ActivityParticipantRoleInserted", e);
			Inserting += (s, e) => ThrowEvent("ActivityParticipantRoleInserting", e);
			Saved += (s, e) => ThrowEvent("ActivityParticipantRoleSaved", e);
			Saving += (s, e) => ThrowEvent("ActivityParticipantRoleSaving", e);
			Validating += (s, e) => ThrowEvent("ActivityParticipantRoleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityParticipantRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipantRole_BaseEventsProcess

	/// <exclude/>
	public partial class ActivityParticipantRole_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : ActivityParticipantRole
	{

		public ActivityParticipantRole_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityParticipantRole_BaseEventsProcess";
			SchemaUId = new Guid("01e72783-64d7-4fac-9d9a-1648eacd51c9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("01e72783-64d7-4fac-9d9a-1648eacd51c9");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _activityParticipantRoleSaveProcess;
		public ProcessFlowElement ActivityParticipantRoleSaveProcess {
			get {
				return _activityParticipantRoleSaveProcess ?? (_activityParticipantRoleSaveProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityParticipantRoleSaveProcess",
					SchemaElementUId = new Guid("184fdae1-05ce-46e2-ba70-1f052396e59b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityParticipantRoleSavedStartMessage;
		public ProcessFlowElement ActivityParticipantRoleSavedStartMessage {
			get {
				return _activityParticipantRoleSavedStartMessage ?? (_activityParticipantRoleSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityParticipantRoleSavedStartMessage",
					SchemaElementUId = new Guid("4ded59b0-8609-4308-bfea-050579fe32a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityParticipantRoleSavedDeletedScriptTask;
		public ProcessScriptTask ActivityParticipantRoleSavedDeletedScriptTask {
			get {
				return _activityParticipantRoleSavedDeletedScriptTask ?? (_activityParticipantRoleSavedDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityParticipantRoleSavedDeletedScriptTask",
					SchemaElementUId = new Guid("f47261a0-0e29-4132-9697-abf8e298e847"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityParticipantRoleSavedDeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _activityParticipantRoleDeletingStartMessage;
		public ProcessFlowElement ActivityParticipantRoleDeletingStartMessage {
			get {
				return _activityParticipantRoleDeletingStartMessage ?? (_activityParticipantRoleDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityParticipantRoleDeletingStartMessage",
					SchemaElementUId = new Guid("2013cf05-aab6-4b24-84c4-47dd78b470b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ActivityParticipantRoleSaveProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantRoleSaveProcess };
			FlowElements[ActivityParticipantRoleSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantRoleSavedStartMessage };
			FlowElements[ActivityParticipantRoleSavedDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantRoleSavedDeletedScriptTask };
			FlowElements[ActivityParticipantRoleDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityParticipantRoleDeletingStartMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ActivityParticipantRoleSaveProcess":
						break;
					case "ActivityParticipantRoleSavedStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityParticipantRoleSavedDeletedScriptTask");
						break;
					case "ActivityParticipantRoleSavedDeletedScriptTask":
						break;
					case "ActivityParticipantRoleDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityParticipantRoleSavedDeletedScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityParticipantRoleSavedStartMessage");
			ActivatedEventElements.Add("ActivityParticipantRoleDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ActivityParticipantRoleSaveProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityParticipantRoleSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityParticipantRoleSavedStartMessage";
					result = ActivityParticipantRoleSavedStartMessage.Execute(context);
					break;
				case "ActivityParticipantRoleSavedDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityParticipantRoleSavedDeletedScriptTask";
					result = ActivityParticipantRoleSavedDeletedScriptTask.Execute(context, ActivityParticipantRoleSavedDeletedScriptTaskExecute);
					break;
				case "ActivityParticipantRoleDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityParticipantRoleDeletingStartMessage";
					result = ActivityParticipantRoleDeletingStartMessage.Execute(context);
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

		public virtual bool ActivityParticipantRoleSavedDeletedScriptTaskExecute(ProcessExecutingContext context) {
			ClearCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ActivityParticipantRoleSaved":
							if (ActivatedEventElements.Contains("ActivityParticipantRoleSavedStartMessage")) {
							context.QueueTasks.Enqueue("ActivityParticipantRoleSavedStartMessage");
						}
						break;
					case "ActivityParticipantRoleDeleting":
							if (ActivatedEventElements.Contains("ActivityParticipantRoleDeletingStartMessage")) {
							context.QueueTasks.Enqueue("ActivityParticipantRoleDeletingStartMessage");
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

	#region Class: ActivityParticipantRole_BaseEventsProcess

	/// <exclude/>
	public class ActivityParticipantRole_BaseEventsProcess : ActivityParticipantRole_BaseEventsProcess<ActivityParticipantRole>
	{

		public ActivityParticipantRole_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityParticipantRole_BaseEventsProcess

	public partial class ActivityParticipantRole_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void ClearCache() {
			ActivityUtils.ClearActivityCache(UserConnection);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipantRoleEventsProcessSchema

	/// <exclude/>
	public class ActivityParticipantRoleEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityParticipantRoleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityParticipantRoleEventsProcessSchema(ActivityParticipantRoleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityParticipantRole_BaseEventsProcess";
			UId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8");
			CreatedInPackageId = new Guid("d5a7ef71-6903-49c6-895f-378c283b75c2");
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
			ProcessSchemaEventSubProcess activityparticipantrolesaveprocess = CreateActivityParticipantRoleSaveProcessEventSubProcess();
			FlowElements.Add(activityparticipantrolesaveprocess);
			ProcessSchemaStartMessageEvent activityparticipantrolesavedstartmessage = CreateActivityParticipantRoleSavedStartMessageStartMessageEvent();
			activityparticipantrolesaveprocess.FlowElements.Add(activityparticipantrolesavedstartmessage);
			ProcessSchemaScriptTask activityparticipantrolesaveddeletedscripttask = CreateActivityParticipantRoleSavedDeletedScriptTaskScriptTask();
			activityparticipantrolesaveprocess.FlowElements.Add(activityparticipantrolesaveddeletedscripttask);
			ProcessSchemaStartMessageEvent activityparticipantroledeletingstartmessage = CreateActivityParticipantRoleDeletingStartMessageStartMessageEvent();
			activityparticipantrolesaveprocess.FlowElements.Add(activityparticipantroledeletingstartmessage);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2d8d425d-7214-41fc-a738-cfeb496ef448"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				CurveCenterPosition = new Point(192, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4ded59b0-8609-4308-bfea-050579fe32a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f47261a0-0e29-4132-9697-abf8e298e847"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("c8840667-503e-4961-8bcc-2d57177bef89"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				CurveCenterPosition = new Point(188, 115),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2013cf05-aab6-4b24-84c4-47dd78b470b0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f47261a0-0e29-4132-9697-abf8e298e847"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("7074e9e4-f0fe-4c9a-befe-72f0ca1b03d4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(658, 207),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("89120cd5-d8ec-45a6-a646-391331fbbf06"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("7074e9e4-f0fe-4c9a-befe-72f0ca1b03d4"),
				CreatedInOwnerSchemaUId = new Guid("01e72783-64d7-4fac-9d9a-1648eacd51c9"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(629, 207),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityParticipantRoleSaveProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityParticipantRoleSaveProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("184fdae1-05ce-46e2-ba70-1f052396e59b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("89120cd5-d8ec-45a6-a646-391331fbbf06"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				Name = @"ActivityParticipantRoleSaveProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 179),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityParticipantRoleSaveProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityParticipantRoleSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4ded59b0-8609-4308-bfea-050579fe32a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("184fdae1-05ce-46e2-ba70-1f052396e59b"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityParticipantRoleSaved",
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				Name = @"ActivityParticipantRoleSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 16),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityParticipantRoleSavedDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f47261a0-0e29-4132-9697-abf8e298e847"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("184fdae1-05ce-46e2-ba70-1f052396e59b"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				Name = @"ActivityParticipantRoleSavedDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,114,78,76,206,72,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,179,169,176,3,27,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityParticipantRoleDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2013cf05-aab6-4b24-84c4-47dd78b470b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("184fdae1-05ce-46e2-ba70-1f052396e59b"),
				CreatedInOwnerSchemaUId = new Guid("ac8d0498-3a35-4ee5-ba97-2bf896fcc5e2"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityParticipantRoleDeleting",
				ModifiedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				Name = @"ActivityParticipantRoleDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
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
				UId = new Guid("40807c59-533a-411f-800e-3c4cfec34b97"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
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
				UId = new Guid("f5931d34-671f-483d-b7a6-62f93b355468"),
				Name = "ClearCache",
				CreatedInSchemaUId = new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,201,44,203,44,169,12,45,201,204,41,214,115,206,73,77,44,114,132,10,57,39,38,103,164,106,132,22,167,22,57,231,231,229,165,2,69,243,243,52,173,1,118,135,194,14,49,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityParticipantRoleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5413bd4e-4385-4ea1-b251-fa5151a421f8"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityParticipantRoleEventsProcess

	/// <exclude/>
	public class ActivityParticipantRoleEventsProcess : ActivityParticipantRole_BaseEventsProcess
	{

		public ActivityParticipantRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

