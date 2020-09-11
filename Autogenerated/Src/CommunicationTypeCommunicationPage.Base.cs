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

	#region Class: CommunicationTypeCommunicationPageSchema

	/// <exclude/>
	public class CommunicationTypeCommunicationPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public CommunicationTypeCommunicationPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CommunicationTypeCommunicationPageSchema(CommunicationTypeCommunicationPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
			RealUId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
			Name = "CommunicationTypeCommunicationPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCommunicationTypeCommunicationPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateCommunicationTypeCommunicationPageEventsProcessSchema() {
			var schema = new CommunicationTypeCommunicationPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new CommunicationTypeCommunicationPageSchemaUserControl();
		}

		public override object Clone() {
			return new CommunicationTypeCommunicationPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CommunicationTypeCommunicationPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CommunicationTypeCommunicationPageEventsProcess

	/// <exclude/>
	public class CommunicationTypeCommunicationPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CommunicationTypeCommunicationPageSchemaUserControl
	{

		public CommunicationTypeCommunicationPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CommunicationTypeCommunicationPageEventsProcess";
			SchemaUId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e");
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
					SchemaElementUId = new Guid("7af499a6-962c-4883-b248-2f21801e9179"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInit;
		public ProcessFlowElement ChildInit {
			get {
				return _childInit ?? (_childInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInit",
					SchemaElementUId = new Guid("5923eca2-1f04-49d7-80fd-ac60c491b754"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildInit;
		public ProcessScriptTask ScriptChildInit {
			get {
				return _scriptChildInit ?? (_scriptChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildInit",
					SchemaElementUId = new Guid("a35bfb9e-3835-4d6e-af03-c0c728839acd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _throwChildInit;
		public ProcessThrowMessageEvent ThrowChildInit {
			get {
				return _throwChildInit ?? (_throwChildInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ThrowChildInit",
					SchemaElementUId = new Guid("1f4dc978-bdc0-44ba-81be-738dbc5186ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("16d82b83-21f6-4a81-afe5-7aa27fa83fbb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadComplete;
		public ProcessFlowElement PageLoadComplete {
			get {
				return _pageLoadComplete ?? (_pageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadComplete",
					SchemaElementUId = new Guid("2cf0f2ce-add3-4509-add1-ec17ab22d490"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadComplete;
		public ProcessScriptTask ScriptPageLoadComplete {
			get {
				return _scriptPageLoadComplete ?? (_scriptPageLoadComplete = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadComplete",
					SchemaElementUId = new Guid("8433206d-8560-4ddc-8f5c-cc3f8c869135"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteExecute,
				});
			}
		}

		private LocalizableString _captionLS;
		public LocalizableString CaptionLS {
			get {
				return _captionLS ?? (_captionLS = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CaptionLS.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[ThrowChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ThrowChildInit };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[ScriptPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadComplete };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ChildInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						e.Context.QueueTasks.Enqueue("ThrowChildInit");
						break;
					case "ThrowChildInit":
						break;
					case "EventSubProcess2":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadComplete");
						break;
					case "ScriptPageLoadComplete":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildInit");
			ActivatedEventElements.Add("PageLoadComplete");
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
				case "ChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInit";
					result = ChildInit.Execute(context);
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "ThrowChildInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ThrowChildInit.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete";
					result = PageLoadComplete.Execute(context);
					break;
				case "ScriptPageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadComplete";
					result = ScriptPageLoadComplete.Execute(context, ScriptPageLoadCompleteExecute);
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

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			// Set parameters for parent detail compliance
			ParentGridPageSchemaId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			ParentEntitySchemaId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873");
			DetailGridPageSchemaId = new Guid("9b5db097-f356-4c4d-a54b-54e0a2545f8c");
			DetailEntitySchemaId = new Guid("2875aefb-92b6-4b17-9ef6-22fa306f4c3f");
			DetailAssociationColumnUId = new Guid("34b83991-65a0-4978-ac5e-73cd4e167a4a");
			DetailSelectionColumnUId = new Guid("dfa76dad-9bb7-4c53-9a63-e4f6482776b9");
			return true;
		}

		public virtual bool ScriptPageLoadCompleteExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = CaptionLS;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ChildInit")) {
							context.QueueTasks.Enqueue("ChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
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

	#region Class: CommunicationTypeCommunicationPageEventsProcess

	/// <exclude/>
	public class CommunicationTypeCommunicationPageEventsProcess : CommunicationTypeCommunicationPageEventsProcess<Terrasoft.WebApp.CommunicationTypeCommunicationPageSchemaUserControl>
	{

		public CommunicationTypeCommunicationPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CommunicationTypeCommunicationPageSchemaUserControl

	/// <exclude/>
	public partial class CommunicationTypeCommunicationPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
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
			var process = (CommunicationTypeCommunicationPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CommunicationTypeCommunicationPageEventsProcess(UserConnection);
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
			SchemaName = "CommunicationTypeCommunicationPage";
		}

		#endregion

	}

	#endregion

	#region Class: CommunicationTypeCommunicationPageEventsProcessSchema

	/// <exclude/>
	public class CommunicationTypeCommunicationPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public CommunicationTypeCommunicationPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CommunicationTypeCommunicationPageEventsProcessSchema(CommunicationTypeCommunicationPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CommunicationTypeCommunicationPageEventsProcess";
			UId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent childinit = CreateChildInitStartMessageEvent();
			eventsubprocess1.FlowElements.Add(childinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			eventsubprocess1.FlowElements.Add(scriptchildinit);
			ProcessSchemaIntermediateThrowMessageEvent throwchildinit = CreateThrowChildInitIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(throwchildinit);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			eventsubprocess2.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask scriptpageloadcomplete = CreateScriptPageLoadCompleteScriptTask();
			eventsubprocess2.FlowElements.Add(scriptpageloadcomplete);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCaptionLSLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCaptionLSLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("03f08fa1-eb37-43fa-902f-4b302ecd08d5"),
				Name = "CaptionLS",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4ccdfe75-16c9-4ba1-8a8a-5a42c4532c18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				CurveCenterPosition = new Point(174, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5923eca2-1f04-49d7-80fd-ac60c491b754"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a35bfb9e-3835-4d6e-af03-c0c728839acd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0fe3b70c-c30b-4d3a-bd25-150f146d8b3d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				CurveCenterPosition = new Point(282, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a35bfb9e-3835-4d6e-af03-c0c728839acd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1f4dc978-bdc0-44ba-81be-738dbc5186ea"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f93e06cc-37a8-4850-a44b-50ccb925e8a3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				CurveCenterPosition = new Point(460, 90),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2cf0f2ce-add3-4509-add1-ec17ab22d490"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8433206d-8560-4ddc-8f5c-cc3f8c869135"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("a04792a0-2791-4e5a-8099-fcf35ff18d0f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(877, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("66afe0d2-91e1-4af8-a29c-85ee965b13f3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("a04792a0-2791-4e5a-8099-fcf35ff18d0f"),
				CreatedInOwnerSchemaUId = new Guid("238dac47-59a9-4a3f-8ba0-e6d57306312e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(848, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7af499a6-962c-4883-b248-2f21801e9179"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66afe0d2-91e1-4af8-a29c-85ee965b13f3"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(288, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5923eca2-1f04-49d7-80fd-ac60c491b754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7af499a6-962c-4883-b248-2f21801e9179"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a35bfb9e-3835-4d6e-af03-c0c728839acd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7af499a6-962c-4883-b248-2f21801e9179"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(99, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,208,77,74,3,65,16,5,224,189,167,104,178,210,69,145,153,238,234,159,34,184,16,149,224,78,8,30,160,186,187,74,7,146,153,48,233,32,222,222,68,132,128,168,203,162,224,227,189,183,92,154,141,52,179,231,153,119,210,100,62,24,157,230,243,41,99,51,85,26,15,91,83,166,221,126,59,240,88,228,234,249,235,177,158,135,250,204,175,178,41,111,178,227,167,106,110,205,40,239,102,125,28,234,245,194,145,246,150,114,128,108,173,7,36,36,32,207,1,146,237,106,76,69,131,37,92,220,172,190,169,199,177,13,237,227,87,168,38,12,37,163,130,246,169,2,6,18,72,78,21,132,66,175,78,51,167,232,206,208,195,87,202,127,51,81,246,53,119,20,65,157,15,128,5,43,176,199,12,30,165,99,235,209,107,42,23,234,159,76,54,69,207,162,25,200,158,26,98,238,35,144,104,0,107,149,93,23,20,139,211,11,116,119,56,76,101,224,54,76,227,253,180,61,238,198,151,159,91,97,78,142,168,135,224,185,59,109,21,19,112,241,2,209,149,138,210,135,200,200,23,110,35,91,41,127,99,85,57,134,202,21,40,231,120,42,233,29,16,7,7,130,26,48,217,24,67,166,51,54,75,59,206,163,105,243,81,86,159,191,119,201,2,255,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateThrowChildInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("1f4dc978-bdc0-44ba-81be-738dbc5186ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7af499a6-962c-4883-b248-2f21801e9179"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"ThrowChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("16d82b83-21f6-4a81-afe5-7aa27fa83fbb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("66afe0d2-91e1-4af8-a29c-85ee965b13f3"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(193, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2cf0f2ce-add3-4509-add1-ec17ab22d490"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16d82b83-21f6-4a81-afe5-7aa27fa83fbb"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"PageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8433206d-8560-4ddc-8f5c-cc3f8c869135"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("16d82b83-21f6-4a81-afe5-7aa27fa83fbb"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"),
				Name = @"ScriptPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(84, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,137,5,37,153,249,121,10,182,10,80,150,79,176,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,203,14,125,143,82,0,0,0 }
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
			return new CommunicationTypeCommunicationPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b196a14-1398-43d9-a775-0bb9a7910a94"));
		}

		#endregion

	}

	#endregion

}

