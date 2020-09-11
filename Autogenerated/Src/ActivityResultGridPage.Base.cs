namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: ActivityResultGridPageSchema

	/// <exclude/>
	public class ActivityResultGridPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public ActivityResultGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ActivityResultGridPageSchema(ActivityResultGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
			RealUId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
			Name = "ActivityResultGridPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityResultGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateCloseButton();
			UpdateDetailTab();
			UpdateParentTab();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, ParentTabPanel);
			ParentTabPanel.MoveItem(0, ParentTab);
			TopLevelControl.MoveItem(2, DetailTabPanel);
			DetailTabPanel.MoveItem(0, DetailTab);
			TopLevelControl.MoveItem(3, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, Spacer1);
			ButtonsControlLayout.MoveItem(1, CloseButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateActivityResultGridPageEventsProcessSchema() {
			var schema = new ActivityResultGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ActivityResultGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new ActivityResultGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ActivityResultGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityResultGridPageEventsProcess

	/// <exclude/>
	public class ActivityResultGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ActivityResultGridPageSchemaUserControl
	{

		public ActivityResultGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityResultGridPageEventsProcess";
			SchemaUId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + 
				Page.PageContainer.UniqueID;
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("d8cf5e61-27c0-437e-88e9-5593d199674c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _activityResultGridPageInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent ActivityResultGridPageInitIntermediateThrowMessageEvent {
			get {
				return _activityResultGridPageInitIntermediateThrowMessageEvent ?? (_activityResultGridPageInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ActivityResultGridPageInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("5ad7f351-0bd8-4351-bc4d-0d04781863bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _activityResultGridPageInitStartMessage;
		public ProcessFlowElement ActivityResultGridPageInitStartMessage {
			get {
				return _activityResultGridPageInitStartMessage ?? (_activityResultGridPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityResultGridPageInitStartMessage",
					SchemaElementUId = new Guid("88f67fc0-a4f3-4efa-acee-536d01562cda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityResultGridPageInitScriptTask;
		public ProcessScriptTask ActivityResultGridPageInitScriptTask {
			get {
				return _activityResultGridPageInitScriptTask ?? (_activityResultGridPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityResultGridPageInitScriptTask",
					SchemaElementUId = new Guid("a38f10c5-47a3-4a96-b2bd-c5d00087fdb4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityResultGridPageInitScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ActivityResultGridPageInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityResultGridPageInitIntermediateThrowMessageEvent };
			FlowElements[ActivityResultGridPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityResultGridPageInitStartMessage };
			FlowElements[ActivityResultGridPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityResultGridPageInitScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ActivityResultGridPageInitIntermediateThrowMessageEvent":
						break;
					case "ActivityResultGridPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityResultGridPageInitScriptTask");
						break;
					case "ActivityResultGridPageInitScriptTask":
						e.Context.QueueTasks.Enqueue("ActivityResultGridPageInitIntermediateThrowMessageEvent");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityResultGridPageInitStartMessage");
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
				case "ActivityResultGridPageInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ActivityResultGridPageInitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ActivityResultGridPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityResultGridPageInitStartMessage";
					result = ActivityResultGridPageInitStartMessage.Execute(context);
					break;
				case "ActivityResultGridPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityResultGridPageInitScriptTask";
					result = ActivityResultGridPageInitScriptTask.Execute(context, ActivityResultGridPageInitScriptTaskExecute);
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

		public virtual bool ActivityResultGridPageInitScriptTaskExecute(ProcessExecutingContext context) {
			// Set parameters for parent detail compliance
			ParentGridPageSchemaId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			ParentEntitySchemaId = new Guid("329bd06e-f95f-4824-a0fb-85edff2f2948");
			DetailGridPageSchemaId = new Guid("5fdd759b-f4c0-447e-9d4a-ea08a9f918ae");
			DetailEntitySchemaId = new Guid("bd4e2904-dfb9-460a-8fd8-1d5e20405782");
			DetailAssociationColumnUId = new Guid("a9b31a96-5933-4a24-9de8-e6312dbce20b");
			DetailSelectionColumnUId = new Guid("136bcedb-1f6d-4214-8815-551c71f345a8");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ActivityResultGridPageInitStartMessage")) {
							context.QueueTasks.Enqueue("ActivityResultGridPageInitStartMessage");
							ProcessQueue(context);
							return;
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

	#region Class: ActivityResultGridPageEventsProcess

	/// <exclude/>
	public class ActivityResultGridPageEventsProcess : ActivityResultGridPageEventsProcess<Terrasoft.WebApp.ActivityResultGridPageSchemaUserControl>
	{

		public ActivityResultGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityResultGridPageSchemaUserControl

	/// <exclude/>
	public partial class ActivityResultGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ActivityResultGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ActivityResultGridPageEventsProcess(UserConnection);
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
				process.Execute(UserConnection);
				UserConnection.ProcessEngine.SetProcessPropertiesData(process);
			} else {
				process.InternalContext = new ProcessExecutingContext(UserConnection) {
					Process = process
				};
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
			}
		}

		protected override void InitializePageSchemaControls() {
			base.InitializePageSchemaControls();
			if (!PageContainer.IsDesignMode) {
					InitializeEmbeddedProcess();
				}
		}

		#endregion

		#region Methods: Public

		public override void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public override void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public override void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "ActivityResultGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: ActivityResultGridPageEventsProcessSchema

	/// <exclude/>
	public class ActivityResultGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityResultGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityResultGridPageEventsProcessSchema(ActivityResultGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityResultGridPageEventsProcess";
			UId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet404 = CreateLaneSet404LaneSet();
			LaneSets.Add(schemaLaneSet404);
			ProcessSchemaLane schemaLane1208 = CreateLane1208Lane();
			schemaLaneSet404.Lanes.Add(schemaLane1208);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaIntermediateThrowMessageEvent activityresultgridpageinitintermediatethrowmessageevent = CreateActivityResultGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(activityresultgridpageinitintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent activityresultgridpageinitstartmessage = CreateActivityResultGridPageInitStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(activityresultgridpageinitstartmessage);
			ProcessSchemaScriptTask activityresultgridpageinitscripttask = CreateActivityResultGridPageInitScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(activityresultgridpageinitscripttask);
			FlowElements.Add(CreateSequenceFlow6858SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6859SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6858SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6858",
				UId = new Guid("aeea75b5-f6be-4c91-9dc7-14f0c6312b2d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				CurveCenterPosition = new Point(144, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88f67fc0-a4f3-4efa-acee-536d01562cda"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a38f10c5-47a3-4a96-b2bd-c5d00087fdb4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6859SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6859",
				UId = new Guid("f9ab2767-05f3-45f6-86c5-145ad5f8428b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				CurveCenterPosition = new Point(310, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a38f10c5-47a3-4a96-b2bd-c5d00087fdb4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ad7f351-0bd8-4351-bc4d-0d04781863bf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet404LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet404 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4524e969-9805-454e-9904-f398baa211f1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				Name = @"LaneSet404",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(791, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet404;
		}

		protected virtual ProcessSchemaLane CreateLane1208Lane() {
			ProcessSchemaLane schemaLane1208 = new ProcessSchemaLane(this) {
				UId = new Guid("a07f82d8-2dd0-49cd-a652-929410eedf09"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4524e969-9805-454e-9904-f398baa211f1"),
				CreatedInOwnerSchemaUId = new Guid("229cae6b-11e9-4c84-8264-c8359cbbaf47"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				Name = @"Lane1208",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(762, 177),
				UseBackgroundMode = false
			};
			return schemaLane1208;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d8cf5e61-27c0-437e-88e9-5593d199674c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a07f82d8-2dd0-49cd-a652-929410eedf09"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(329, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateActivityResultGridPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("5ad7f351-0bd8-4351-bc4d-0d04781863bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d8cf5e61-27c0-437e-88e9-5593d199674c"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				Name = @"ActivityResultGridPageInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(287, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityResultGridPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("88f67fc0-a4f3-4efa-acee-536d01562cda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d8cf5e61-27c0-437e-88e9-5593d199674c"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				Name = @"ActivityResultGridPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityResultGridPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a38f10c5-47a3-4a96-b2bd-c5d00087fdb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d8cf5e61-27c0-437e-88e9-5593d199674c"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"),
				Name = @"ActivityResultGridPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(133, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,208,193,74,4,49,12,6,224,187,79,81,60,233,33,216,118,210,78,195,226,65,84,22,111,194,226,3,164,77,170,3,187,51,203,108,23,241,237,29,23,97,65,212,99,248,201,199,159,220,220,152,141,54,179,231,153,119,218,116,62,152,58,205,95,163,142,205,136,54,30,182,166,76,187,253,118,224,177,232,197,243,41,88,207,131,60,243,171,110,202,155,238,248,73,204,173,25,245,221,172,143,131,92,93,118,84,157,167,28,33,123,31,0,9,9,40,112,132,228,173,244,169,212,232,9,47,175,87,223,212,227,216,134,246,241,59,180,40,98,163,66,165,80,1,147,71,96,91,51,164,160,82,171,175,139,147,190,160,135,83,203,127,59,133,42,210,7,202,80,177,88,64,236,21,72,144,65,217,38,166,74,46,177,158,169,127,58,101,65,245,100,17,164,102,2,140,150,33,85,73,224,36,168,183,104,67,159,252,25,186,59,28,166,50,112,27,166,241,126,218,30,119,227,203,15,142,41,119,142,41,66,160,174,3,228,229,68,18,77,160,177,115,94,114,89,204,124,230,54,186,213,242,55,230,186,184,108,72,6,87,163,0,122,135,144,146,11,16,130,43,189,171,29,6,62,253,107,214,118,156,71,211,230,163,174,62,1,18,55,145,169,255,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("46b4da2e-0028-4749-9503-d1d38c64a418"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityResultGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b5f34d5-f870-4a9a-8589-e1f7ccbea24e"));
		}

		#endregion

	}

	#endregion

}

