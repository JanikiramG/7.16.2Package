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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: LeadTypeLookupGridPageSchema

	/// <exclude/>
	public class LeadTypeLookupGridPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public LeadTypeLookupGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public LeadTypeLookupGridPageSchema(LeadTypeLookupGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
			RealUId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
			Name = "LeadTypeLookupGridPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLeadTypeLookupGridPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateLeadTypeLookupGridPageEventsProcessSchema() {
			var schema = new LeadTypeLookupGridPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new LeadTypeLookupGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new LeadTypeLookupGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LeadTypeLookupGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeLookupGridPageEventsProcess

	/// <exclude/>
	public class LeadTypeLookupGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.LeadTypeLookupGridPageSchemaUserControl
	{

		public LeadTypeLookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadTypeLookupGridPageEventsProcess";
			SchemaUId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173");
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

		private ProcessFlowElement _initEventSubProcess;
		public ProcessFlowElement InitEventSubProcess {
			get {
				return _initEventSubProcess ?? (_initEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitEventSubProcess",
					SchemaElementUId = new Guid("744ceb06-c156-41d1-8ac0-86980a396564"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("8670d9f7-cc7b-4e0f-ac72-a11f68a5e88e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskInit;
		public ProcessScriptTask ScriptTaskInit {
			get {
				return _scriptTaskInit ?? (_scriptTaskInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskInit",
					SchemaElementUId = new Guid("52690517-b28f-4ef8-a22a-db82d4eb83b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventBaseInit;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventBaseInit {
			get {
				return _intermediateThrowMessageEventBaseInit ?? (_intermediateThrowMessageEventBaseInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventBaseInit",
					SchemaElementUId = new Guid("76494dbc-4869-4f2d-a1ec-15a6c861ba32"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
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
					SchemaElementUId = new Guid("b66a5878-2408-4398-a4f1-3e702d987b93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("be968025-7c07-4d3f-83fd-71ea97d55c89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("c3def1b2-06f8-44de-9ea3-ddebc68d7f0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTask;
		public ProcessScriptTask PageLoadCompleteScriptTask {
			get {
				return _pageLoadCompleteScriptTask ?? (_pageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("7e8db47f-9516-4e4c-aeb3-b102dd6ca721"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[InitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEventSubProcess };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTaskInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskInit };
			FlowElements[IntermediateThrowMessageEventBaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventBaseInit };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "InitEventSubProcess":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTaskInit");
						break;
					case "ScriptTaskInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventBaseInit");
						break;
					case "IntermediateThrowMessageEventBaseInit":
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage2");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "InitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTaskInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskInit";
					result = ScriptTaskInit.Execute(context, ScriptTaskInitExecute);
					break;
				case "IntermediateThrowMessageEventBaseInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowMessageEventBaseInit.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
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

		public virtual bool ScriptTaskInitExecute(ProcessExecutingContext context) {
			ParentGridPageSchemaId = LeadConsts.LeadTypeGridPage;
			ParentEntitySchemaId = LeadConsts.LeadTypeUId;
			DetailGridPageSchemaId = LeadConsts.ProductInLeadTypeEditPageUId;
			DetailEntitySchemaId = LeadConsts.VwProductInLeadTypeUId;
			DetailAssociationColumnUId = LeadConsts.DetailAssociationColumnUId;
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			EntitySchema productInLeadType = entitySchemaManager.GetInstanceByUId(LeadConsts.ProductInLeadTypeUId);
			Page.DetailTab.Caption = productInLeadType.Caption;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
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

	#region Class: LeadTypeLookupGridPageEventsProcess

	/// <exclude/>
	public class LeadTypeLookupGridPageEventsProcess : LeadTypeLookupGridPageEventsProcess<Terrasoft.WebApp.LeadTypeLookupGridPageSchemaUserControl>
	{

		public LeadTypeLookupGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadTypeLookupGridPageSchemaUserControl

	/// <exclude/>
	public partial class LeadTypeLookupGridPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
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
			var process = (LeadTypeLookupGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new LeadTypeLookupGridPageEventsProcess(UserConnection);
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
			SchemaName = "LeadTypeLookupGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeLookupGridPageEventsProcessSchema

	/// <exclude/>
	public class LeadTypeLookupGridPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public LeadTypeLookupGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LeadTypeLookupGridPageEventsProcessSchema(LeadTypeLookupGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadTypeLookupGridPageEventsProcess";
			UId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
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
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			initeventsubprocess.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttaskinit = CreateScriptTaskInitScriptTask();
			initeventsubprocess.FlowElements.Add(scripttaskinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventbaseinit = CreateIntermediateThrowMessageEventBaseInitIntermediateThrowMessageEvent();
			initeventsubprocess.FlowElements.Add(intermediatethrowmessageeventbaseinit);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(pageloadcompletescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("0490c99f-6af5-4f9f-b2c5-c43328fbcfe6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				CurveCenterPosition = new Point(190, 83),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8670d9f7-cc7b-4e0f-ac72-a11f68a5e88e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("52690517-b28f-4ef8-a22a-db82d4eb83b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1d152a7c-a40f-4057-a265-23bf7fcc2dca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				CurveCenterPosition = new Point(359, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("52690517-b28f-4ef8-a22a-db82d4eb83b4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("76494dbc-4869-4f2d-a1ec-15a6c861ba32"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("646d5680-60ed-4b95-964e-76230d565a4a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				CurveCenterPosition = new Point(195, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("be968025-7c07-4d3f-83fd-71ea97d55c89"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c3def1b2-06f8-44de-9ea3-ddebc68d7f0c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("69e444f2-9352-4ce6-8de1-b2893e3f6b66"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				CurveCenterPosition = new Point(340, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3def1b2-06f8-44de-9ea3-ddebc68d7f0c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e8db47f-9516-4e4c-aeb3-b102dd6ca721"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("40445870-f2b2-448a-84c6-86208869b986"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1566, 408),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("a9d955f0-8665-41a1-be30-1d0ac79fd616"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("40445870-f2b2-448a-84c6-86208869b986"),
				CreatedInOwnerSchemaUId = new Guid("4cdc3d36-5a26-4553-a1e5-385f06837173"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1537, 408),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("744ceb06-c156-41d1-8ac0-86980a396564"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9d955f0-8665-41a1-be30-1d0ac79fd616"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(749, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8670d9f7-cc7b-4e0f-ac72-a11f68a5e88e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("744ceb06-c156-41d1-8ac0-86980a396564"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("52690517-b28f-4ef8-a22a-db82d4eb83b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("744ceb06-c156-41d1-8ac0-86980a396564"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"ScriptTaskInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,141,65,10,194,64,12,69,247,130,119,152,19,120,129,226,66,106,145,1,23,3,90,247,97,18,52,208,102,36,147,65,122,123,91,161,80,20,187,251,139,247,222,15,160,36,118,82,198,0,119,186,196,7,245,224,209,237,221,153,0,235,36,217,242,110,154,215,225,73,51,85,109,55,225,163,53,98,108,195,186,212,122,28,249,35,25,112,183,126,19,52,97,137,230,101,86,27,100,155,240,101,98,237,242,246,250,73,44,213,67,206,41,50,24,39,169,83,87,122,105,191,3,255,185,49,162,100,69,197,153,22,170,222,38,109,176,37,54,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("76494dbc-4869-4f2d-a1ec-15a6c861ba32"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("744ceb06-c156-41d1-8ac0-86980a396564"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"IntermediateThrowMessageEventBaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(344, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b66a5878-2408-4398-a4f1-3e702d987b93"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a9d955f0-8665-41a1-be30-1d0ac79fd616"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(742, 151),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("be968025-7c07-4d3f-83fd-71ea97d55c89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b66a5878-2408-4398-a4f1-3e702d987b93"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("c3def1b2-06f8-44de-9ea3-ddebc68d7f0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b66a5878-2408-4398-a4f1-3e702d987b93"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(169, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7e8db47f-9516-4e4c-aeb3-b102dd6ca721"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b66a5878-2408-4398-a4f1-3e702d987b93"),
				CreatedInOwnerSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae"),
				CreatedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(316, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,65,10,194,80,12,68,247,130,119,8,93,181,155,127,129,226,198,42,82,168,80,176,61,64,252,13,90,208,244,147,159,10,189,189,233,66,80,219,109,102,38,111,230,133,2,196,218,235,116,241,119,122,226,25,25,111,36,176,131,54,146,20,3,51,121,237,7,118,39,210,31,71,154,28,151,177,36,3,140,176,34,228,219,205,247,21,130,12,221,232,181,228,138,176,107,166,64,6,92,169,49,83,75,142,138,236,105,63,181,101,151,206,126,107,21,53,186,250,255,135,233,153,129,106,75,186,3,41,246,143,6,175,174,192,48,15,48,192,2,250,209,44,36,164,163,48,168,140,148,191,1,149,7,3,31,20,1,0,0 }
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
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ea1a6a10-8895-4993-a161-776ee303c7fc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadTypeLookupGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1896423b-0bfe-432d-9299-9e1a9e81b1cb"));
		}

		#endregion

	}

	#endregion

}

