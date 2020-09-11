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

	#region Class: SysModuleEntityGridPageSchema

	/// <exclude/>
	public class SysModuleEntityGridPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public SysModuleEntityGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleEntityGridPageSchema(SysModuleEntityGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
			RealUId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
			Name = "SysModuleEntityGridPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleEntityGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateSysModuleEntityGridPageEventsProcessSchema() {
			var schema = new SysModuleEntityGridPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new SysModuleEntityGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleEntityGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af61d020-a7a7-4e47-a278-c29d26253b89"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleEntityGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityGridPageEventsProcess

	/// <exclude/>
	public class SysModuleEntityGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleEntityGridPageSchemaUserControl
	{

		public SysModuleEntityGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleEntityGridPageEventsProcess";
			SchemaUId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("af61d020-a7a7-4e47-a278-c29d26253b89");
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
					SchemaElementUId = new Guid("7024bc5b-aa0a-4f39-823d-de0b547923c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initStartMessage;
		public ProcessFlowElement InitStartMessage {
			get {
				return _initStartMessage ?? (_initStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitStartMessage",
					SchemaElementUId = new Guid("c867c57c-a44c-47bf-99b9-aa2a530423bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScriptTask;
		public ProcessScriptTask InitScriptTask {
			get {
				return _initScriptTask ?? (_initScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTask",
					SchemaElementUId = new Guid("a9d2e64a-3522-4c2f-b6ac-d4c2b33f1ce1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _initIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent InitIntermediateThrowMessageEvent {
			get {
				return _initIntermediateThrowMessageEvent ?? (_initIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "InitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("e3668b0c-33b1-4027-9092-14878fbeb6c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[InitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { InitIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						e.Context.QueueTasks.Enqueue("InitIntermediateThrowMessageEvent");
						break;
					case "InitIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitStartMessage");
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
				case "InitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitStartMessage";
					result = InitStartMessage.Execute(context);
					break;
				case "InitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTask";
					result = InitScriptTask.Execute(context, InitScriptTaskExecute);
					break;
				case "InitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = InitIntermediateThrowMessageEvent.Execute(context);
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

		public virtual bool InitScriptTaskExecute(ProcessExecutingContext context) {
			ParentGridPageSchemaId = new Guid("7ea7bb60-7abb-40b2-af0e-7b4c5354b436");
			ParentEntitySchemaId = new Guid("9a3fdadf-218b-46d8-a867-5d33a69f125a");
			
			DetailGridPageSchemaId = new Guid("b6f05862-b445-42ea-a935-26bd1a0c8473");
			DetailEntitySchemaId = new Guid("af1d238e-f551-4878-b4c3-d52aa8495adb");
			
			DetailAssociationColumnUId = new Guid("f7b189f1-06c6-4b54-bb04-eaf91625177f");
			IsEntityDetail = true;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
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

	#region Class: SysModuleEntityGridPageEventsProcess

	/// <exclude/>
	public class SysModuleEntityGridPageEventsProcess : SysModuleEntityGridPageEventsProcess<Terrasoft.WebApp.SysModuleEntityGridPageSchemaUserControl>
	{

		public SysModuleEntityGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleEntityGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleEntityGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
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
			var process = (SysModuleEntityGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleEntityGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysModuleEntityGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleEntityGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleEntityGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleEntityGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleEntityGridPageEventsProcessSchema(SysModuleEntityGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleEntityGridPageEventsProcess";
			UId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2");
			CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(initscripttask);
			ProcessSchemaIntermediateThrowMessageEvent initintermediatethrowmessageevent = CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(initintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("65cd8e1f-157c-4032-ac16-cf5f2e41f05a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				CurveCenterPosition = new Point(190, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c867c57c-a44c-47bf-99b9-aa2a530423bc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a9d2e64a-3522-4c2f-b6ac-d4c2b33f1ce1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("bc3d3bb1-5e76-4037-afa2-5d6614b9167f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				CurveCenterPosition = new Point(318, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9d2e64a-3522-4c2f-b6ac-d4c2b33f1ce1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3668b0c-33b1-4027-9092-14878fbeb6c9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cd925d2a-0bdc-4f14-a466-d16ce4aa8e29"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(820, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("84fd0669-cb0d-4223-b4f7-e42967dc5e47"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("cd925d2a-0bdc-4f14-a466-d16ce4aa8e29"),
				CreatedInOwnerSchemaUId = new Guid("af61d020-a7a7-4e47-a278-c29d26253b89"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(791, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7024bc5b-aa0a-4f39-823d-de0b547923c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("84fd0669-cb0d-4223-b4f7-e42967dc5e47"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(63, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c867c57c-a44c-47bf-99b9-aa2a530423bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7024bc5b-aa0a-4f39-823d-de0b547923c9"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a9d2e64a-3522-4c2f-b6ac-d4c2b33f1ce1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7024bc5b-aa0a-4f39-823d-de0b547923c9"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,207,207,74,195,64,16,199,241,123,161,239,80,122,210,195,192,254,153,217,221,32,30,68,165,244,22,16,31,96,38,187,171,129,118,3,201,6,241,237,13,201,73,145,30,231,119,248,240,157,150,199,84,234,105,236,99,203,31,233,173,251,76,87,62,199,195,227,161,164,175,195,105,238,227,221,209,39,246,34,78,129,103,17,64,37,6,56,171,4,94,176,35,75,40,104,221,241,254,97,191,107,87,235,181,212,190,126,255,43,53,108,115,228,152,193,232,176,72,46,6,224,224,60,80,180,150,93,147,181,33,94,165,253,238,37,85,238,47,55,187,196,101,69,193,25,16,68,2,52,137,129,27,75,96,156,68,205,170,11,232,237,170,109,214,141,46,206,58,26,27,18,100,34,13,24,124,88,204,206,66,36,195,28,176,33,142,242,171,235,105,154,134,174,231,218,15,229,121,184,204,215,242,254,71,204,94,116,88,30,2,229,58,7,40,132,32,162,16,18,231,70,59,67,218,251,188,138,231,105,235,218,220,197,168,227,156,150,125,76,117,30,203,118,253,0,210,40,11,250,164,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("e3668b0c-33b1-4027-9092-14878fbeb6c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7024bc5b-aa0a-4f39-823d-de0b547923c9"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8"),
				CreatedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"),
				Name = @"InitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
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
				CreatedInPackageId = new Guid("c5d1282b-7a3f-4441-aec0-d272080d37f8")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleEntityGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d4f03b2-7997-4ed4-ae81-e1616819ccf2"));
		}

		#endregion

	}

	#endregion

}

