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
	using System.Text;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: ConditionExpressionEditPageSchema

	/// <exclude/>
	public class ConditionExpressionEditPageSchema : Terrasoft.WebApp.BaseProcessParametersEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayoutTitle;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutTitle {
			get {
				return _controlLayoutTitle;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionTextEdit {
			get {
				return _captionTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _pageContainerFormula;
		public Terrasoft.UI.WebControls.Controls.PageContainer PageContainerFormula {
			get {
				return _pageContainerFormula;
			}
		}

		#endregion

		#region Constructors: Public

		public ConditionExpressionEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ConditionExpressionEditPageSchema(ConditionExpressionEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
		}

		private void UpdateOkButton() {
			OkButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OkButton.Image = new ControlImage {};
			OkButton.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
		}

		private void UpdateBottomControlLayout() {
			BottomControlLayout.Image = new ControlImage {};
			BottomControlLayout.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			RealUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			Name = "ConditionExpressionEditPage";
			ParentSchemaUId = new Guid("eda93b42-6405-4946-9e28-d45fecd6d1d8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateConditionExpressionEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateBottomControlLayout();
			UpdateCancelButton();
			UpdateOkButton();
			UpdateContextHelpButton();
			UpdateTopControlLayout();
			TopLevelControl.MoveItem(0, MainMessagePanel);
			TopLevelControl.MoveItem(1, TopControlLayout);
			TopControlLayout.InsertItem(0, CreateControlLayoutTitle());
			ControlLayoutTitle.InsertItem(0, CreateCaptionTextEdit());
			TopControlLayout.InsertItem(1, CreatePageContainerFormula());
			TopLevelControl.MoveItem(2, BottomControlLayout);
			BottomControlLayout.MoveItem(0, ContextHelpButton);
			BottomControlLayout.MoveItem(1, Spacer1);
			BottomControlLayout.MoveItem(2, OkButton);
			BottomControlLayout.MoveItem(3, CancelButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateConditionExpressionEditPageEventsProcessSchema() {
			var schema = new ConditionExpressionEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionTextEdit() {
			_captionTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionTextEdit.UId = new Guid("6dc4ec6a-2fde-499d-a41a-4e42dcfa4955");
			_captionTextEdit.Name = "CaptionTextEdit";
			_captionTextEdit.CreatedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			_captionTextEdit.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			_captionTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionTextEdit.Tag = "";
			_captionTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionTextEdit.Image = new ControlImage {};
			_captionTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _captionTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayoutTitle() {
			_controlLayoutTitle = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayoutTitle.UId = new Guid("9612b01e-baec-4e8e-9141-43dc260db780");
			_controlLayoutTitle.Name = "ControlLayoutTitle";
			_controlLayoutTitle.CreatedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			_controlLayoutTitle.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			_controlLayoutTitle.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_controlLayoutTitle.Tag = "";
			_controlLayoutTitle.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayoutTitle.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayoutTitle.FitHeightByContent = true;
			_controlLayoutTitle.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayoutTitle.StartNewAlignGroup = false;
			_controlLayoutTitle.Image = new ControlImage {};
			_controlLayoutTitle.Edges = "";
			return _controlLayoutTitle;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreatePageContainerFormula() {
			_pageContainerFormula = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_pageContainerFormula.UId = new Guid("0c922d25-9bd8-4153-8fb6-bdd52e38fad2");
			_pageContainerFormula.Name = "PageContainerFormula";
			_pageContainerFormula.CreatedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			_pageContainerFormula.ModifiedInSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			_pageContainerFormula.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_pageContainerFormula.Tag = "";
			_pageContainerFormula.PageSchemaUId = new Guid("c53bce00-ec06-4c8c-8b0b-c619be916631");
			_pageContainerFormula.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageContainerFormula.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_pageContainerFormula.StartNewAlignGroup = false;
			_pageContainerFormula.Edges = "";
			return _pageContainerFormula;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ConditionExpressionEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ConditionExpressionEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ConditionExpressionEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ConditionExpressionEditPageEventsProcess

	/// <exclude/>
	public class ConditionExpressionEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ConditionExpressionEditPageSchemaUserControl
	{

		public ConditionExpressionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConditionExpressionEditPageEventsProcess";
			SchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66");
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

		public virtual bool IsIgnoredUserTaskSchemas {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessInit;
		public ProcessFlowElement EventSubProcessInit {
			get {
				return _eventSubProcessInit ?? (_eventSubProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInit",
					SchemaElementUId = new Guid("f6e6f9d7-c639-4b75-a014-e5dfc9d364d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _childInitStartMessage;
		public ProcessFlowElement ChildInitStartMessage {
			get {
				return _childInitStartMessage ?? (_childInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInitStartMessage",
					SchemaElementUId = new Guid("9b6aeab4-bcef-4947-a4f6-f7929247821a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent BaseInitIntermediateThrowMessageEvent {
			get {
				return _baseInitIntermediateThrowMessageEvent ?? (_baseInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("0abcfb82-70c8-4942-8c81-408c8714a0ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskInitChild;
		public ProcessScriptTask ScriptTaskInitChild {
			get {
				return _scriptTaskInitChild ?? (_scriptTaskInitChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskInitChild",
					SchemaElementUId = new Guid("b3b744ed-bbeb-4804-94cf-6a57f519fa35"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskInitChildExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessPageLoadComplete;
		public ProcessFlowElement EventSubProcessPageLoadComplete {
			get {
				return _eventSubProcessPageLoadComplete ?? (_eventSubProcessPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessPageLoadComplete",
					SchemaElementUId = new Guid("96d87e58-94b0-415a-ad20-b37e8b1133c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteStartMessage;
		public ProcessFlowElement PageLoadCompleteStartMessage {
			get {
				return _pageLoadCompleteStartMessage ?? (_pageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("d38bf8ab-7c58-49fd-888f-b9cc31aece17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("b3d2c9f6-6ef7-4da1-ab56-5d1fcfe85bff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("a01db97c-12bf-4e28-9ebc-7b429fa3bb26"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2OkButtonClick;
		public ProcessFlowElement EventSubProcess2OkButtonClick {
			get {
				return _eventSubProcess2OkButtonClick ?? (_eventSubProcess2OkButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2OkButtonClick",
					SchemaElementUId = new Guid("10d681c1-b2d7-4bf7-888b-b8d21dc58394"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageOkButtonClick;
		public ProcessFlowElement StartMessageOkButtonClick {
			get {
				return _startMessageOkButtonClick ?? (_startMessageOkButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageOkButtonClick",
					SchemaElementUId = new Guid("1f311f6c-9e2b-4133-9a46-997df984535d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEventOkButtonClick;
		public ProcessThrowMessageEvent IntermediateThrowMessageEventOkButtonClick {
			get {
				return _intermediateThrowMessageEventOkButtonClick ?? (_intermediateThrowMessageEventOkButtonClick = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEventOkButtonClick",
					SchemaElementUId = new Guid("0ebd6493-5d3b-4bd0-9632-18976cd931c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OkButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTaskOkButtonClick;
		public ProcessScriptTask ScriptTaskOkButtonClick {
			get {
				return _scriptTaskOkButtonClick ?? (_scriptTaskOkButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskOkButtonClick",
					SchemaElementUId = new Guid("e6d63d08-cf10-4b49-b66e-2943965bfcdf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskOkButtonClickExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInit };
			FlowElements[ChildInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInitStartMessage };
			FlowElements[BaseInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInitIntermediateThrowMessageEvent };
			FlowElements[ScriptTaskInitChild.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskInitChild };
			FlowElements[EventSubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessPageLoadComplete };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcess2OkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2OkButtonClick };
			FlowElements[StartMessageOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageOkButtonClick };
			FlowElements[IntermediateThrowMessageEventOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEventOkButtonClick };
			FlowElements[ScriptTaskOkButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskOkButtonClick };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessInit":
						break;
					case "ChildInitStartMessage":
						e.Context.QueueTasks.Enqueue("BaseInitIntermediateThrowMessageEvent");
						break;
					case "BaseInitIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("ScriptTaskInitChild");
						break;
					case "ScriptTaskInitChild":
						break;
					case "EventSubProcessPageLoadComplete":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "EventSubProcess2OkButtonClick":
						break;
					case "StartMessageOkButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptTaskOkButtonClick");
						break;
					case "IntermediateThrowMessageEventOkButtonClick":
						break;
					case "ScriptTaskOkButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEventOkButtonClick");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ChildInitStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("StartMessageOkButtonClick");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "ChildInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInitStartMessage";
					result = ChildInitStartMessage.Execute(context);
					break;
				case "BaseInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = BaseInitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "ScriptTaskInitChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskInitChild";
					result = ScriptTaskInitChild.Execute(context, ScriptTaskInitChildExecute);
					break;
				case "EventSubProcessPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteStartMessage";
					result = PageLoadCompleteStartMessage.Execute(context);
					break;
				case "PageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTask";
					result = PageLoadCompleteScriptTask.Execute(context, PageLoadCompleteScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcess2OkButtonClick":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageOkButtonClick";
					result = StartMessageOkButtonClick.Execute(context);
					break;
				case "IntermediateThrowMessageEventOkButtonClick":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OkButtonClick");
					result = IntermediateThrowMessageEventOkButtonClick.Execute(context);
					break;
				case "ScriptTaskOkButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskOkButtonClick";
					result = ScriptTaskOkButtonClick.Execute(context, ScriptTaskOkButtonClickExecute);
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
				case "IsIgnoredUserTaskSchemas":
					IsIgnoredUserTaskSchemas = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTaskInitChildExecute(ProcessExecutingContext context) {
			InitializeContextHelpButton();
			if (Ext.IsAjaxRequest) {
				if (SchemaExplorerCreated) {
					InitializeSchemaExplorerWindow();
				}
			} else {
				var formulaPageProcess = GetFormulaPageProcess();
				formulaPageProcess.EditSchemaUId = EditSchemaUId;
				formulaPageProcess.EditSchemaManagerName = EditSchemaManagerName;
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var conditionalFlow = (ProcessSchemaConditionalFlow)processSchema.GetBaseElementByUId(EditElementUId);
			Page.CaptionTextEdit.Text = conditionalFlow.Caption;
			var formulaPageProcess = GetFormulaPageProcess();
			formulaPageProcess.SetFormulaBody(conditionalFlow.ConditionExpression);
			return true;
		}

		public virtual bool ScriptTaskOkButtonClickExecute(ProcessExecutingContext context) {
			ProcessSchema processSchema = FindDesignedProcessSchema();
			var conditionalFlow = (ProcessSchemaConditionalFlow)processSchema.GetBaseElementByUId(EditElementUId);
			ElementNewCaption = Page.CaptionTextEdit.Text;
			var formulaPageProcess = GetFormulaPageProcess();
			conditionalFlow.Caption.Value = Page.CaptionTextEdit.Text;
			conditionalFlow.ConditionExpression = formulaPageProcess.GetFormulaBody();
			processSchema.SchemaManager.SaveDesignedItemInSessionData(UserConnection, processSchema, processSchema.UId);
			return true;
		}

		public override void InitializeSchemaExplorerWindow() {
			Guid ReadDataUserTaskSchemaId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f");
			bool isNewSchemaExplorer = SchemaExplorer == null;
			var schemaExplorer = SchemaExplorer as SchemaStructureExplorer;
			if (isNewSchemaExplorer) {
				schemaExplorer = new SchemaStructureExplorer(Page.TopControlLayout, "schemaStructure", false, false);
			}
			if (isNewSchemaExplorer) {
				schemaExplorer.ManagerName = EditSchemaManagerName;
			} else {
				schemaExplorer.IncludedDataValueTypes.Clear();
			}
			schemaExplorer.IgnoredUserTaskSchemas.Clear();
			if (IsIgnoredUserTaskSchemas) {
				schemaExplorer.IgnoredUserTaskSchemas.Add(ReadDataUserTaskSchemaId);
			}
			Collection<DataValueType> stringsTypes = UserConnection.DataValueTypeManager.GetDataValueTypesByGroupName("Strings");
			Collection<DataValueType> numbersTypes = UserConnection.DataValueTypeManager.GetDataValueTypesByGroupName("Numbers");
			Collection<DataValueType> datesTypes = UserConnection.DataValueTypeManager.GetDataValueTypesByGroupName("Dates");
			Guid dbObjectNameUId = UserConnection.DataValueTypeManager.GetInstanceByName("DBObjectName").UId;
			foreach(var type in stringsTypes) {
				// TODO CR 139842
				if (type.UId != dbObjectNameUId) {
					schemaExplorer.IncludedDataValueTypes.Add(type.UId, Guid.Empty);
				}
			}
			foreach(var type in numbersTypes) {
				schemaExplorer.IncludedDataValueTypes.Add(type.UId, Guid.Empty);
			}
			foreach(var type in datesTypes) {
				schemaExplorer.IncludedDataValueTypes.Add(type.UId, Guid.Empty);
			}
			schemaExplorer.IncludedDataValueTypes.Add(UserConnection.DataValueTypeManager.GetItemByName("Boolean").UId, Guid.Empty);
			schemaExplorer.IsInputSchemaParameterMode = true;
			SchemaExplorerCreated = true;
			if (!SchemaExplorerRegistered) {
				schemaExplorer.Register();
				SchemaExplorerRegistered = true;
			}
			SchemaExplorer = schemaExplorer;
		}

		public override void MakeCaption() {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.IsNullOrEmpty(Page.CaptionTextEdit.Text) ?
				ElementNewCaption : Page.CaptionTextEdit.Text;
		}

		public override void InitializeContextHelpButton() {
			base.InitializeContextHelpButton();
		}

		public virtual Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl> GetFormulaPageProcess() {
			var formulaPage = Page.PageContainerFormula.PageInstance as Terrasoft.WebApp.FormulaEditPageSchemaUserControl;
			if (formulaPage != null) {
				return (Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>)formulaPage.Process;
			}
			return null;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("ChildInitStartMessage")) {
							context.QueueTasks.Enqueue("ChildInitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("StartMessageOkButtonClick")) {
							context.QueueTasks.Enqueue("StartMessageOkButtonClick");
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
			if (!HasMapping("IsIgnoredUserTaskSchemas") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsIgnoredUserTaskSchemas", IsIgnoredUserTaskSchemas, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ConditionExpressionEditPageEventsProcess

	/// <exclude/>
	public class ConditionExpressionEditPageEventsProcess : ConditionExpressionEditPageEventsProcess<Terrasoft.WebApp.ConditionExpressionEditPageSchemaUserControl>
	{

		public ConditionExpressionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConditionExpressionEditPageSchemaUserControl

	/// <exclude/>
	public partial class ConditionExpressionEditPageSchemaUserControl : Terrasoft.WebApp.BaseProcessParametersEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayoutTitle {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayoutTitle", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer PageContainerFormula {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("PageContainerFormula", true);
			}
		}

		#endregion

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
			var process = (ConditionExpressionEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ConditionExpressionEditPageEventsProcess(UserConnection);
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
			SchemaName = "ConditionExpressionEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ConditionExpressionEditPageEventsProcessSchema

	/// <exclude/>
	public class ConditionExpressionEditPageEventsProcessSchema : Terrasoft.WebApp.BaseProcessParametersEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ConditionExpressionEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ConditionExpressionEditPageEventsProcessSchema(ConditionExpressionEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ConditionExpressionEditPageEventsProcess";
			UId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateIsIgnoredUserTaskSchemasParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e9d0037f-e69d-4c72-a87f-bcfd8920a98a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"IsIgnoredUserTaskSchemas",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsIgnoredUserTaskSchemasParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLaneInit = CreateLaneInitLane();
			schemaLaneSet1.Lanes.Add(schemaLaneInit);
			ProcessSchemaLane schemaLanePageLoadComplete = CreateLanePageLoadCompleteLane();
			schemaLaneSet1.Lanes.Add(schemaLanePageLoadComplete);
			ProcessSchemaLane schemaLaneOkButtonClick = CreateLaneOkButtonClickLane();
			schemaLaneSet1.Lanes.Add(schemaLaneOkButtonClick);
			ProcessSchemaEventSubProcess eventsubprocessinit = CreateEventSubProcessInitEventSubProcess();
			FlowElements.Add(eventsubprocessinit);
			ProcessSchemaEventSubProcess eventsubprocesspageloadcomplete = CreateEventSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(eventsubprocesspageloadcomplete);
			ProcessSchemaEventSubProcess eventsubprocess2okbuttonclick = CreateEventSubProcess2OkButtonClickEventSubProcess();
			FlowElements.Add(eventsubprocess2okbuttonclick);
			ProcessSchemaStartMessageEvent childinitstartmessage = CreateChildInitStartMessageStartMessageEvent();
			eventsubprocessinit.FlowElements.Add(childinitstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent baseinitintermediatethrowmessageevent = CreateBaseInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			eventsubprocessinit.FlowElements.Add(baseinitintermediatethrowmessageevent);
			ProcessSchemaScriptTask scripttaskinitchild = CreateScriptTaskInitChildScriptTask();
			eventsubprocessinit.FlowElements.Add(scripttaskinitchild);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocesspageloadcomplete.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocesspageloadcomplete.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent startmessageokbuttonclick = CreateStartMessageOkButtonClickStartMessageEvent();
			eventsubprocess2okbuttonclick.FlowElements.Add(startmessageokbuttonclick);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageeventokbuttonclick = CreateIntermediateThrowMessageEventOkButtonClickIntermediateThrowMessageEvent();
			eventsubprocess2okbuttonclick.FlowElements.Add(intermediatethrowmessageeventokbuttonclick);
			ProcessSchemaScriptTask scripttaskokbuttonclick = CreateScriptTaskOkButtonClickScriptTask();
			eventsubprocess2okbuttonclick.FlowElements.Add(scripttaskokbuttonclick);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9d9a98ad-9c59-440c-af40-6d796afb0812"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				CurveCenterPosition = new Point(142, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b6aeab4-bcef-4947-a4f6-f7929247821a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0abcfb82-70c8-4942-8c81-408c8714a0ba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("b73ec344-0fae-48c7-ab89-efc03ea7d3af"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				CurveCenterPosition = new Point(222, 79),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0abcfb82-70c8-4942-8c81-408c8714a0ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3b744ed-bbeb-4804-94cf-6a57f519fa35"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("fc811137-5970-4a29-bb41-d57af81c7ec6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				CurveCenterPosition = new Point(162, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d38bf8ab-7c58-49fd-888f-b9cc31aece17"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3d2c9f6-6ef7-4da1-ab56-5d1fcfe85bff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("24d56a77-16a1-48e0-9ef7-283a710fc679"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				CurveCenterPosition = new Point(285, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3d2c9f6-6ef7-4da1-ab56-5d1fcfe85bff"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a01db97c-12bf-4e28-9ebc-7b429fa3bb26"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("f9883459-0835-4020-a357-c354bde59a32"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f311f6c-9e2b-4133-9a46-997df984535d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e6d63d08-cf10-4b49-b66e-2943965bfcdf"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("ef5a348c-2600-40eb-b7eb-6e56795be4b5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6d63d08-cf10-4b49-b66e-2943965bfcdf"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ebd6493-5d3b-4bd0-9632-18976cd931c9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b78e8004-6d3a-4b4d-a86a-d835be615916"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(749, 496),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLaneInitLane() {
			ProcessSchemaLane schemaLaneInit = new ProcessSchemaLane(this) {
				UId = new Guid("43f9dec7-d442-4042-bfb4-54622fd7eed7"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("b78e8004-6d3a-4b4d-a86a-d835be615916"),
				CreatedInOwnerSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"LaneInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 163),
				Size = new Size(720, 165),
				UseBackgroundMode = false
			};
			return schemaLaneInit;
		}

		protected virtual ProcessSchemaLane CreateLanePageLoadCompleteLane() {
			ProcessSchemaLane schemaLanePageLoadComplete = new ProcessSchemaLane(this) {
				UId = new Guid("73159838-cf9d-4403-bff5-53d58dc768df"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("b78e8004-6d3a-4b4d-a86a-d835be615916"),
				CreatedInOwnerSchemaUId = new Guid("754bdafd-b495-4e95-94a6-ce571e4ccd66"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"LanePageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 333),
				Size = new Size(720, 163),
				UseBackgroundMode = false
			};
			return schemaLanePageLoadComplete;
		}

		protected virtual ProcessSchemaLane CreateLaneOkButtonClickLane() {
			ProcessSchemaLane schemaLaneOkButtonClick = new ProcessSchemaLane(this) {
				UId = new Guid("3f229a09-ffa5-48d6-aae5-d1beaf328118"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b78e8004-6d3a-4b4d-a86a-d835be615916"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"LaneOkButtonClick",
				Position = new Point(29, 0),
				Size = new Size(720, 158),
				UseBackgroundMode = false
			};
			return schemaLaneOkButtonClick;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f6e6f9d7-c639-4b75-a014-e5dfc9d364d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("43f9dec7-d442-4042-bfb4-54622fd7eed7"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"EventSubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(263, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9b6aeab4-bcef-4947-a4f6-f7929247821a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6e6f9d7-c639-4b75-a014-e5dfc9d364d6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"ChildInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0abcfb82-70c8-4942-8c81-408c8714a0ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6e6f9d7-c639-4b75-a014-e5dfc9d364d6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"BaseInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(92, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskInitChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b3b744ed-bbeb-4804-94cf-6a57f519fa35"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f6e6f9d7-c639-4b75-a014-e5dfc9d364d6"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"ScriptTaskInitChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(162, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,193,14,193,64,16,134,207,109,210,119,216,35,23,47,208,56,32,69,15,68,136,56,79,244,199,202,118,151,217,89,26,226,221,149,38,162,113,112,156,127,254,239,155,201,173,22,77,70,223,48,114,86,80,201,20,230,52,12,34,206,118,186,105,18,235,157,234,100,149,244,114,63,56,82,181,196,57,192,75,87,221,147,56,122,173,86,219,3,74,202,170,147,113,12,30,49,72,80,52,235,40,255,168,219,173,141,182,133,187,190,237,209,35,137,31,10,198,227,141,92,136,213,206,113,25,12,45,104,143,5,187,45,188,87,125,53,129,140,127,242,198,240,219,239,101,133,150,230,228,58,47,106,186,53,255,101,102,100,235,156,231,84,162,197,126,229,181,163,126,156,33,129,173,18,14,72,159,225,224,69,54,71,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("96d87e58-94b0-415a-ad20-b37e8b1133c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("73159838-cf9d-4403-bff5-53d58dc768df"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"EventSubProcessPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(316, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d38bf8ab-7c58-49fd-888f-b9cc31aece17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96d87e58-94b0-415a-ad20-b37e8b1133c0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b3d2c9f6-6ef7-4da1-ab56-5d1fcfe85bff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96d87e58-94b0-415a-ad20-b37e8b1133c0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,143,193,14,130,48,12,134,239,38,190,195,142,227,178,23,48,94,64,48,222,72,208,7,104,88,197,37,99,35,219,80,120,123,59,3,198,201,173,127,251,245,255,219,218,217,22,189,111,218,7,246,192,134,68,29,89,165,140,60,161,87,157,65,89,255,206,120,118,216,239,158,224,88,107,141,84,65,89,3,186,210,246,69,59,60,1,139,116,158,37,9,226,140,33,7,143,165,198,30,77,200,231,219,69,242,146,248,165,65,50,230,212,208,161,40,96,136,54,87,156,66,36,68,44,40,237,47,127,197,150,235,238,214,245,163,134,104,176,92,69,43,20,90,109,250,159,135,182,184,104,190,112,110,229,204,55,113,171,46,167,193,17,79,85,52,114,24,70,103,88,112,35,30,222,155,109,216,108,98,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("a01db97c-12bf-4e28-9ebc-7b429fa3bb26"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("96d87e58-94b0-415a-ad20-b37e8b1133c0"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2OkButtonClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2OkButtonClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("10d681c1-b2d7-4bf7-888b-b8d21dc58394"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3f229a09-ffa5-48d6-aae5-d1beaf328118"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"EventSubProcess2OkButtonClick",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(307, 137),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2OkButtonClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageOkButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1f311f6c-9e2b-4133-9a46-997df984535d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10d681c1-b2d7-4bf7-888b-b8d21dc58394"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"StartMessageOkButtonClick",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEventOkButtonClickIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("0ebd6493-5d3b-4bd0-9632-18976cd931c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10d681c1-b2d7-4bf7-888b-b8d21dc58394"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"IntermediateThrowMessageEventOkButtonClick",
				Position = new Point(239, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskOkButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e6d63d08-cf10-4b49-b66e-2943965bfcdf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10d681c1-b2d7-4bf7-888b-b8d21dc58394"),
				CreatedInOwnerSchemaUId = new Guid("497d874f-afdb-4603-b94f-2d2239127e0e"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				Name = @"ScriptTaskOkButtonClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(113, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,77,111,131,48,12,189,79,218,127,224,72,165,41,127,160,218,133,22,38,14,157,144,88,119,183,136,215,33,5,7,57,161,31,255,126,78,9,218,82,14,59,37,207,246,243,123,182,27,182,29,58,215,118,223,56,64,54,38,232,53,171,122,210,123,116,253,137,80,55,127,115,249,102,251,252,116,6,206,58,75,186,247,189,37,48,149,177,23,225,228,73,225,46,205,111,18,5,245,134,190,0,135,165,193,1,201,23,183,99,173,243,82,234,99,64,96,208,137,232,29,47,59,24,67,47,81,105,224,132,42,194,15,188,250,192,82,225,19,125,125,89,30,38,3,161,44,250,17,146,200,85,171,248,125,148,135,49,150,206,234,19,204,132,255,200,173,184,11,46,175,35,139,192,108,120,109,72,253,218,41,172,190,221,125,164,235,153,159,3,144,144,88,181,112,198,229,24,181,199,161,166,118,238,190,7,15,249,209,33,139,50,97,23,164,95,210,83,62,64,21,23,203,232,39,166,204,243,132,219,31,5,197,117,141,9,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetFormulaPageProcessMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4159d90-4d80-4bc4-804d-6cc2ca63435e"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a9b659b5-9ae3-4218-9fe8-8047f8e6b589"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6881e55-7df2-4cef-8151-adab44274ad1"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0840abef-9bb9-452e-a8da-ae98b5fb397d"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1b12ba7-35df-4582-a18f-8349f8901d2b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b424ebf7-dbe4-4ba3-91b6-f05370f2faa3"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateInitializeSchemaExplorerWindowMethod() {
			SchemaMethod method = base.CreateInitializeSchemaExplorerWindowMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,149,93,111,218,48,20,134,175,201,175,112,115,149,74,144,14,74,215,86,172,147,198,135,16,210,10,21,208,221,219,241,9,205,102,236,200,118,214,162,137,255,190,227,4,90,66,195,70,37,174,34,217,231,60,239,249,242,201,48,75,56,153,2,229,125,106,233,163,1,61,167,230,215,44,122,130,37,29,113,114,71,36,60,147,33,218,4,126,196,218,87,87,236,115,220,184,190,137,227,70,155,53,161,193,90,237,102,35,106,49,22,125,98,151,215,112,27,251,231,29,143,41,37,72,98,198,240,92,96,6,47,169,80,26,52,194,246,15,16,159,9,209,241,126,83,77,204,127,140,169,217,156,204,172,206,34,155,105,216,94,117,188,36,38,65,133,226,57,249,227,213,222,113,93,70,7,72,193,3,93,64,56,87,105,79,73,171,149,248,78,87,42,179,117,226,155,178,189,95,39,49,21,6,54,31,76,122,253,129,24,194,123,42,81,71,143,233,18,48,158,1,79,108,225,179,115,142,68,2,136,174,240,30,201,72,100,28,242,134,253,160,34,131,249,42,5,19,246,4,80,29,228,161,236,59,44,36,126,121,185,185,59,14,46,242,145,169,182,170,10,255,0,239,27,231,193,161,65,202,195,234,41,33,32,178,137,146,95,74,177,127,37,198,234,68,46,76,158,8,86,196,121,99,7,100,97,28,150,140,55,53,10,135,96,203,5,232,174,134,90,101,169,43,94,224,207,10,160,27,199,195,170,50,91,50,208,39,84,29,23,192,127,171,114,106,225,132,154,125,135,115,138,238,145,18,206,38,236,39,194,220,221,99,254,126,143,84,24,73,99,169,140,160,187,218,96,187,111,32,255,60,68,86,199,139,177,235,52,122,10,220,107,181,232,78,18,89,234,92,62,43,23,23,100,62,233,79,72,111,74,154,151,183,55,237,150,87,115,243,229,236,29,133,156,221,237,7,153,187,29,57,228,110,198,182,168,122,190,151,194,193,50,181,43,204,191,182,198,17,171,10,113,183,205,149,227,252,97,169,106,157,183,198,158,74,229,120,196,177,93,182,176,220,118,184,139,107,26,168,44,154,187,39,189,47,108,70,50,205,54,75,234,129,106,244,183,160,239,21,119,235,11,119,34,110,171,242,210,235,97,117,44,240,215,91,55,1,103,101,147,41,44,18,131,20,224,85,213,218,222,186,245,84,59,228,248,138,95,123,239,254,52,101,94,231,47,41,165,180,240,230,6,0,0 };
			return method;
		}

		protected override SchemaMethod CreateMakeCaptionMethod() {
			SchemaMethod method = base.CreateMakeCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,137,5,37,153,249,121,10,182,10,197,37,69,153,121,233,122,158,197,126,165,57,57,254,69,174,185,5,37,149,26,96,211,160,106,66,82,43,74,92,83,50,75,244,64,12,77,5,123,94,46,78,215,156,212,220,212,188,18,191,212,114,152,57,86,10,56,181,88,3,0,54,151,126,19,156,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = base.CreateInitializeContextHelpButtonMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,204,203,44,201,76,204,201,172,74,117,206,207,43,73,173,40,241,72,205,41,112,42,45,41,201,207,211,208,180,6,0,21,115,174,228,35,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFormulaPageProcessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("61629129-cff3-47cb-996d-680a40bacba6"),
				Name = "GetFormulaPageProcess",
				CreatedInSchemaUId = new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.WebApp.FormulaEditPageEventsProcess<Terrasoft.WebApp.FormulaEditPageSchemaUserControl>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,142,177,10,194,64,12,134,103,239,41,226,214,46,247,2,103,5,145,10,221,10,42,206,177,166,90,184,230,74,114,237,34,190,187,156,118,232,38,46,9,36,63,223,255,77,40,208,6,233,71,143,53,222,9,10,72,203,166,177,15,28,177,99,146,195,247,255,57,86,172,17,185,33,64,133,19,137,160,134,54,218,11,93,119,195,96,231,96,121,235,98,202,30,155,7,245,120,86,146,132,146,224,157,233,90,200,150,117,235,2,120,244,62,135,167,89,9,197,81,24,178,95,216,114,34,142,90,75,104,72,117,243,183,196,54,95,8,216,25,227,204,203,204,253,201,199,189,1,176,44,108,129,23,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConditionExpressionEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e1d1706-36a6-4147-9788-e4e9fcd71492"));
		}

		#endregion

	}

	#endregion

}

