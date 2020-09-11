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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: AnalyticsChartPageSchema

	/// <exclude/>
	public class AnalyticsChartPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainLayout {
			get {
				return _mainLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _topLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout TopLayout {
			get {
				return _topLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _chartEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ChartEdit {
			get {
				return _chartEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _bottomLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomLayout {
			get {
				return _bottomLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _chartPageContainer;
		public Terrasoft.UI.WebControls.Controls.PageContainer ChartPageContainer {
			get {
				return _chartPageContainer;
			}
		}

		#endregion

		#region Constructors: Public

		public AnalyticsChartPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AnalyticsChartPageSchema(AnalyticsChartPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			RealUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			Name = "AnalyticsChartPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			HelpContextId = "42";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAnalyticsChartPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainLayout());
			MainLayout.InsertItem(0, CreateTopLayout());
			TopLayout.InsertItem(0, CreateChartEdit());
			TopLayout.InsertItem(1, CreateContextHelpButton());
			MainLayout.InsertItem(1, CreateBottomLayout());
			BottomLayout.InsertItem(0, CreateChartPageContainer());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAnalyticsChartPageEventsProcessSchema() {
			var schema = new AnalyticsChartPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateChartEdit() {
			_chartEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_chartEdit.UId = new Guid("9565f06b-ef7c-4000-a460-637a333d51fa");
			_chartEdit.Name = "ChartEdit";
			_chartEdit.CreatedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_chartEdit.ModifiedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_chartEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_chartEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_chartEdit.AjaxEvents.Change.ShowLoadMask = true;
			_chartEdit.Tag = "";
			_chartEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_chartEdit.Image = new ControlImage {};
			_chartEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _chartEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("6e0ba519-7726-49f4-80fb-128d38dc2815");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateTopLayout() {
			_topLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_topLayout.UId = new Guid("4037d118-ca6a-4c81-8ef9-1386f2f72223");
			_topLayout.Name = "TopLayout";
			_topLayout.CreatedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_topLayout.ModifiedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_topLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_topLayout.Tag = "";
			_topLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_topLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_topLayout.FitHeightByContent = true;
			_topLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_topLayout.Padding = "5 10 5 5";
			_topLayout.StartNewAlignGroup = false;
			_topLayout.Image = new ControlImage {};
			_topLayout.Edges = "0 0 1 0";
			return _topLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateChartPageContainer() {
			_chartPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_chartPageContainer.UId = new Guid("1e104380-380d-42b3-8190-6eabc25776a1");
			_chartPageContainer.Name = "ChartPageContainer";
			_chartPageContainer.CreatedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_chartPageContainer.ModifiedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_chartPageContainer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_chartPageContainer.Tag = "";
			_chartPageContainer.PageSchemaUId = new Guid("90cdaef8-fcad-486f-ade3-0ad8db15a644");
			_chartPageContainer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_chartPageContainer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_chartPageContainer.StartNewAlignGroup = false;
			_chartPageContainer.Edges = "";
			return _chartPageContainer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateBottomLayout() {
			_bottomLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_bottomLayout.UId = new Guid("b3cf2b42-99a6-47ce-a23f-4df5841d58e0");
			_bottomLayout.Name = "BottomLayout";
			_bottomLayout.CreatedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_bottomLayout.ModifiedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_bottomLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_bottomLayout.Tag = "";
			_bottomLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_bottomLayout.StartNewAlignGroup = false;
			_bottomLayout.Image = new ControlImage {};
			_bottomLayout.Edges = "";
			return _bottomLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainLayout() {
			_mainLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainLayout.UId = new Guid("817e3f21-09d4-4c83-8023-4605fd7f8c74");
			_mainLayout.Name = "MainLayout";
			_mainLayout.CreatedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_mainLayout.ModifiedInSchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			_mainLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainLayout.Tag = "";
			_mainLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainLayout.StartNewAlignGroup = false;
			_mainLayout.Image = new ControlImage {};
			_mainLayout.Edges = "";
			return _mainLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AnalyticsChartPageSchemaUserControl();
		}

		public override object Clone() {
			return new AnalyticsChartPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AnalyticsChartPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsChartPageEventsProcess

	/// <exclude/>
	public class AnalyticsChartPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.AnalyticsChartPageSchemaUserControl
	{

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public AnalyticsChartPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AnalyticsChartPageEventsProcess";
			SchemaUId = new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("48f94c50-8579-410f-ab76-3dc01820e2d3");
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

		public virtual Guid SysModuleId {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual bool NeedChartLoad {
			get;
			set;
		}

		public virtual bool IsContextHelpButtonInitialized {
			get;
			set;
		}

		public virtual Guid ChartPropertyId {
			get;
			set;
		}

		public virtual string SerializedModuleFilters {
			get;
			set;
		}

		public virtual Guid ModuleEntitySchemaId {
			get;
			set;
		}

		private ProcessFlowElement _subProcessChartEditChange;
		public ProcessFlowElement SubProcessChartEditChange {
			get {
				return _subProcessChartEditChange ?? (_subProcessChartEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessChartEditChange",
					SchemaElementUId = new Guid("5c99229a-6332-4530-aac8-475a02e5bdf2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChartEditChange;
		public ProcessFlowElement StartMessageChartEditChange {
			get {
				return _startMessageChartEditChange ?? (_startMessageChartEditChange = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChartEditChange",
					SchemaElementUId = new Guid("4f1a5d3b-9bdf-4755-8b3e-4bde87aa729b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChartEditChange;
		public ProcessScriptTask ScriptChartEditChange {
			get {
				return _scriptChartEditChange ?? (_scriptChartEditChange = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChartEditChange",
					SchemaElementUId = new Guid("217acd4e-7554-4213-b183-465bd58af5eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChartEditChangeExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessInit;
		public ProcessFlowElement SubProcessInit {
			get {
				return _subProcessInit ?? (_subProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessInit",
					SchemaElementUId = new Guid("4bf29751-da14-4aed-836c-9f279f419e52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageInit;
		public ProcessFlowElement StartMessageInit {
			get {
				return _startMessageInit ?? (_startMessageInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageInit",
					SchemaElementUId = new Guid("eebf0d27-a853-4723-b87c-d0430d070eea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptInit;
		public ProcessScriptTask ScriptInit {
			get {
				return _scriptInit ?? (_scriptInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptInit",
					SchemaElementUId = new Guid("5bd26630-8b21-4869-b389-ccec445229d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptInitExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessPageLoad;
		public ProcessFlowElement SubProcessPageLoad {
			get {
				return _subProcessPageLoad ?? (_subProcessPageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPageLoad",
					SchemaElementUId = new Guid("2555738d-88bc-4ac4-9aac-ec840b870bfa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessagePageLoad;
		public ProcessFlowElement StartMessagePageLoad {
			get {
				return _startMessagePageLoad ?? (_startMessagePageLoad = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessagePageLoad",
					SchemaElementUId = new Guid("b27f302c-7ddd-48b6-8ce5-82a4810a5d36"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskPageLoad;
		public ProcessScriptTask ScriptTaskPageLoad {
			get {
				return _scriptTaskPageLoad ?? (_scriptTaskPageLoad = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskPageLoad",
					SchemaElementUId = new Guid("d5804303-4e32-44f2-abfd-41e3e75ca42c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTaskPageLoadExecute,
				});
			}
		}

		private ProcessFlowElement _drawChartEventSubProcess;
		public ProcessFlowElement DrawChartEventSubProcess {
			get {
				return _drawChartEventSubProcess ?? (_drawChartEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DrawChartEventSubProcess",
					SchemaElementUId = new Guid("2e65c347-9158-4e6f-83cf-e99807f34e1e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _drawChartStartMessage;
		public ProcessFlowElement DrawChartStartMessage {
			get {
				return _drawChartStartMessage ?? (_drawChartStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DrawChartStartMessage",
					SchemaElementUId = new Guid("7fd22d1a-8f9e-4964-8194-32b890fc4663"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _drawChartScriptTask;
		public ProcessScriptTask DrawChartScriptTask {
			get {
				return _drawChartScriptTask ?? (_drawChartScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DrawChartScriptTask",
					SchemaElementUId = new Guid("e3f396e9-a39c-4373-a473-2ee65332e111"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DrawChartScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcessChartEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessChartEditChange };
			FlowElements[StartMessageChartEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChartEditChange };
			FlowElements[ScriptChartEditChange.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChartEditChange };
			FlowElements[SubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessInit };
			FlowElements[StartMessageInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageInit };
			FlowElements[ScriptInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptInit };
			FlowElements[SubProcessPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPageLoad };
			FlowElements[StartMessagePageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessagePageLoad };
			FlowElements[ScriptTaskPageLoad.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskPageLoad };
			FlowElements[DrawChartEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DrawChartEventSubProcess };
			FlowElements[DrawChartStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DrawChartStartMessage };
			FlowElements[DrawChartScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DrawChartScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcessChartEditChange":
						break;
					case "StartMessageChartEditChange":
						e.Context.QueueTasks.Enqueue("ScriptChartEditChange");
						break;
					case "ScriptChartEditChange":
						break;
					case "SubProcessInit":
						break;
					case "StartMessageInit":
						e.Context.QueueTasks.Enqueue("ScriptInit");
						break;
					case "ScriptInit":
						break;
					case "SubProcessPageLoad":
						break;
					case "StartMessagePageLoad":
						e.Context.QueueTasks.Enqueue("ScriptTaskPageLoad");
						break;
					case "ScriptTaskPageLoad":
						break;
					case "DrawChartEventSubProcess":
						break;
					case "DrawChartStartMessage":
						e.Context.QueueTasks.Enqueue("DrawChartScriptTask");
						break;
					case "DrawChartScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageChartEditChange");
			ActivatedEventElements.Add("StartMessageInit");
			ActivatedEventElements.Add("StartMessagePageLoad");
			ActivatedEventElements.Add("DrawChartStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcessChartEditChange":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChartEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChartEditChange";
					result = StartMessageChartEditChange.Execute(context);
					break;
				case "ScriptChartEditChange":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChartEditChange";
					result = ScriptChartEditChange.Execute(context, ScriptChartEditChangeExecute);
					break;
				case "SubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageInit";
					result = StartMessageInit.Execute(context);
					break;
				case "ScriptInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptInit";
					result = ScriptInit.Execute(context, ScriptInitExecute);
					break;
				case "SubProcessPageLoad":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessagePageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessagePageLoad";
					result = StartMessagePageLoad.Execute(context);
					break;
				case "ScriptTaskPageLoad":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTaskPageLoad";
					result = ScriptTaskPageLoad.Execute(context, ScriptTaskPageLoadExecute);
					break;
				case "DrawChartEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DrawChartStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DrawChartStartMessage";
					result = DrawChartStartMessage.Execute(context);
					break;
				case "DrawChartScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DrawChartScriptTask";
					result = DrawChartScriptTask.Execute(context, DrawChartScriptTaskExecute);
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
				case "ModuleEntitySchemaId":
					ModuleEntitySchemaId = reader.GetValue<System.Guid>();
				break;
				case "SerializedModuleFilters":
					SerializedModuleFilters = reader.GetValue<System.String>();
				break;
				case "ChartPropertyId":
					ChartPropertyId = reader.GetValue<System.Guid>();
				break;
				case "IsContextHelpButtonInitialized":
					IsContextHelpButtonInitialized = reader.GetValue<System.Boolean>();
				break;
				case "NeedChartLoad":
					NeedChartLoad = reader.GetValue<System.Boolean>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptChartEditChangeExecute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
				process.ThrowEvent(process.InternalContext, "ChartMenuItemClick");
			}
			return true;
		}

		public virtual bool ScriptInitExecute(ProcessExecutingContext context) {
			if (SysModuleId != Guid.Empty) {
				var analyticsList = GetCustomCharts();
				foreach (var analytic in analyticsList) {
					var newItem = new Terrasoft.UI.WebControls.Controls.ListItem(analytic.Value, analytic.Key);
					Page.ChartEdit.Items.Add(newItem);
				}
			}
			if (!IsContextHelpButtonInitialized) {
				InitializeContextHelpButton();
				IsContextHelpButtonInitialized = true;
			}
			return true;
		}

		public virtual bool ScriptTaskPageLoadExecute(ProcessExecutingContext context) {
			if (ChartPropertyId != Guid.Empty) {
				var itemKey = string.Format("{0}|{1}|{2}", new Guid("90CDAEF8-FCAD-486F-ADE3-0AD8DB15A644"), "CustomChart", ChartPropertyId);
				Page.ChartEdit.SuspendAjaxEvents();
				Page.ChartEdit.SelectItem(itemKey);
				Page.ChartEdit.ResumeAjaxEvents();
			}
			if (Page.BottomLayout.Items[0].CreatedByAjax) {
				Page.AddScript(string.Format("{0}.el.mask();", Page.TopLayout.ClientID));
				var chartContainer = Page.BottomLayout.Items[0] as PageContainer;
				chartContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
			}
			return true;
		}

		public virtual bool DrawChartScriptTaskExecute(ProcessExecutingContext context) {
			var process = Page.ChartPageContainer.PageInstance.Process;
			process.SetPropertyValue("ModuleEntitySchemaId", ModuleEntitySchemaId);
			process.SetPropertyValue("ChartPropertyId", ChartPropertyId);
			process.SetPropertyValue("SerializedModuleFilters", SerializedModuleFilters);
			process.ThrowEvent(process.InternalContext, "ProcessChanges");
			return true;
		}

		public virtual void InitializeContextHelpButton() {
			if (!GetIsContextHelpButtonHidden() && GetIsContextHelpEnabled()) {
				Page.ContextHelpButton.Hidden = false;
				Page.ContextHelpButton.Image.Source = ControlImageSource.ResourceManager;
				Page.ContextHelpButton.Image.ResourceManagerName = "Terrasoft.WebApp";
				Page.ContextHelpButton.Image.ResourceItemName = "help.png";
				Page.ContextHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(null, '" + Page.ContextHelpButton.ClientID + "')";
			}
		}

		public virtual bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual bool GetIsContextHelpEnabled() {
			return (bool)SysSettings.GetValue(UserConnection, "EnableContextHelp");
		}

		public virtual List<KeyValuePair<string, string>> GetCustomCharts() {
			string captionColumnName = TSConfiguration.CommonUtilities.GetLczColumnName(
				UserConnection, "SysModuleAnalyticsChart", "Caption");
			var appCache = UserConnection.ApplicationCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var chartsCollection = TSConfiguration.CommonUtilities.GetSelectData(
				UserConnection, TSConfiguration.CommonUtilities.GetModuleAnalyticsChartSelect, appCache, TSConfiguration.CacheUtilities.AnalyticsChartCache);
			var result = new List<KeyValuePair<string, string>>();
			foreach (var chart in chartsCollection) {
				if (SysModuleId == new Guid(chart["sysModuleId"].ToString())) {
					result.Add(new KeyValuePair<string, string> (
						String.Format("{0}|{1}|{2}" , 
							new Guid("90CDAEF8-FCAD-486F-ADE3-0AD8DB15A644"), "CustomChart", new Guid(chart["chartId"].ToString())), 
						chart[captionColumnName].ToString()));
				}
			}
			return result;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ChartEditChange":
							if (ActivatedEventElements.Contains("StartMessageChartEditChange")) {
							context.QueueTasks.Enqueue("StartMessageChartEditChange");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageInit")) {
							context.QueueTasks.Enqueue("StartMessageInit");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("StartMessagePageLoad")) {
							context.QueueTasks.Enqueue("StartMessagePageLoad");
						}
						break;
					case "DrawChart":
							if (ActivatedEventElements.Contains("DrawChartStartMessage")) {
							context.QueueTasks.Enqueue("DrawChartStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ModuleEntitySchemaId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ModuleEntitySchemaId", ModuleEntitySchemaId, Guid.Empty);
			}
			if (!HasMapping("SerializedModuleFilters") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SerializedModuleFilters", SerializedModuleFilters, null);
			}
			if (!HasMapping("ChartPropertyId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ChartPropertyId", ChartPropertyId, Guid.Empty);
			}
			if (!HasMapping("IsContextHelpButtonInitialized") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsContextHelpButtonInitialized", IsContextHelpButtonInitialized, false);
			}
			if (!HasMapping("NeedChartLoad") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedChartLoad", NeedChartLoad, false);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsChartPageEventsProcess

	/// <exclude/>
	public class AnalyticsChartPageEventsProcess : AnalyticsChartPageEventsProcess<Terrasoft.WebApp.AnalyticsChartPageSchemaUserControl>
	{

		public AnalyticsChartPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AnalyticsChartPageSchemaUserControl

	/// <exclude/>
	public partial class AnalyticsChartPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout TopLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("TopLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit ChartEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("ChartEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout BottomLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("BottomLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer ChartPageContainer {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("ChartPageContainer", true);
			}
		}

		private Terrasoft.UI.WebControls.Controls.ScriptManager _scriptManager;
		public Terrasoft.UI.WebControls.Controls.ScriptManager ScriptManager {
			get {
				if (this._scriptManager != null) {
					return this._scriptManager;
				}
				if (!this.DesignMode && this.Page != null) {
					this._scriptManager = ScriptManager.GetCurrent(this.Page);
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
				}
				if (this.Page != null) {
					this._scriptManager = ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManagerProxy") as ScriptManager;
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
					this._scriptManager = (ScriptManager)ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManager");
					if (this.DesignMode && this._scriptManager == null) {
						this._scriptManager = new ScriptManager();
						this.Page.Controls.Add(this._scriptManager);
					}
				}
				if (this._scriptManager == null) {
					throw new InvalidOperationException("The Terrasoft Script Manager Control " +
						"is missing from this Page." +
						Environment.NewLine + Environment.NewLine +
						"Please add the following Script Manager tag inside the <body> or " +
						"<form> of this Page." +
						Environment.NewLine + Environment.NewLine + "Example" +
						Environment.NewLine + Environment.NewLine +
						" <ext:Script Manager runat=\"server\" />");
				}
				return this._scriptManager;
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PageLoadComplete(object sender, EventArgs e) {
			if (!((PageContainer)PageContainer).IsPageLoadCompleted) {
				((PageContainer)PageContainer).IsPageLoadCompleted = true;
				ThrowEvent("PageLoadComplete");
			}
		}

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			ChartEdit.AjaxEvents.Change.Event += ChartEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			ChartEdit.AjaxEvents.Change.Event -= ChartEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AnalyticsChartPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AnalyticsChartPageEventsProcess(UserConnection);
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

		public virtual void ChartEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ChartEditChange");
		}

		public virtual void ThrowClientEvent(string message, params object[] parameters) {
			string key = CopyParameters(parameters);
			ScriptManager.AddScript("if (window.opener) { if (window.key) {window.opener.Terrasoft.AjaxMethods.ThrowClientEvent(window.key, '" + message + "', '" + key + "')}}");
		}

		public virtual void AjaxRefresh() {
			ScriptManager.AddScript("window.Terrasoft.AjaxMethods.ThrowClientEvent(null, null);");
		}

		public virtual void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public virtual void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public virtual void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "AnalyticsChartPage";
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsChartPageEventsProcessSchema

	/// <exclude/>
	public class AnalyticsChartPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public AnalyticsChartPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AnalyticsChartPageEventsProcessSchema(AnalyticsChartPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AnalyticsChartPageEventsProcess";
			UId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateSysModuleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("35d28f04-0887-4ab3-a7bc-0e12cf2e5e44"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6c5a4fa8-7f94-4af4-9a51-a2973bbd9df0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedChartLoadParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fb39b938-a02d-4227-82cf-7308b9c76bf4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"NeedChartLoad",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsContextHelpButtonInitializedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3cfbd9fc-51cc-4495-9fbd-c9a35dc27962"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"IsContextHelpButtonInitialized",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartPropertyIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ef818ebd-74ce-418a-8928-a1d15ef52cdf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"ChartPropertyId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSerializedModuleFiltersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("99c990bc-65e3-46bc-a21f-ec6e1035c6d2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"SerializedModuleFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateModuleEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be3428ef-5db8-4d17-bebd-07055d9e7bfb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"ModuleEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSysModuleIdParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateNeedChartLoadParameter());
			Parameters.Add(CreateIsContextHelpButtonInitializedParameter());
			Parameters.Add(CreateChartPropertyIdParameter());
			Parameters.Add(CreateSerializedModuleFiltersParameter());
			Parameters.Add(CreateModuleEntitySchemaIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet23 = CreateLaneSet23LaneSet();
			LaneSets.Add(schemaLaneSet23);
			ProcessSchemaLane schemaLane72 = CreateLane72Lane();
			schemaLaneSet23.Lanes.Add(schemaLane72);
			ProcessSchemaEventSubProcess subprocesscharteditchange = CreateSubProcessChartEditChangeEventSubProcess();
			FlowElements.Add(subprocesscharteditchange);
			ProcessSchemaEventSubProcess subprocessinit = CreateSubProcessInitEventSubProcess();
			FlowElements.Add(subprocessinit);
			ProcessSchemaEventSubProcess subprocesspageload = CreateSubProcessPageLoadEventSubProcess();
			FlowElements.Add(subprocesspageload);
			ProcessSchemaEventSubProcess drawcharteventsubprocess = CreateDrawChartEventSubProcessEventSubProcess();
			FlowElements.Add(drawcharteventsubprocess);
			ProcessSchemaStartMessageEvent startmessagecharteditchange = CreateStartMessageChartEditChangeStartMessageEvent();
			subprocesscharteditchange.FlowElements.Add(startmessagecharteditchange);
			ProcessSchemaScriptTask scriptcharteditchange = CreateScriptChartEditChangeScriptTask();
			subprocesscharteditchange.FlowElements.Add(scriptcharteditchange);
			ProcessSchemaStartMessageEvent startmessageinit = CreateStartMessageInitStartMessageEvent();
			subprocessinit.FlowElements.Add(startmessageinit);
			ProcessSchemaScriptTask scriptinit = CreateScriptInitScriptTask();
			subprocessinit.FlowElements.Add(scriptinit);
			ProcessSchemaStartMessageEvent startmessagepageload = CreateStartMessagePageLoadStartMessageEvent();
			subprocesspageload.FlowElements.Add(startmessagepageload);
			ProcessSchemaScriptTask scripttaskpageload = CreateScriptTaskPageLoadScriptTask();
			subprocesspageload.FlowElements.Add(scripttaskpageload);
			ProcessSchemaStartMessageEvent drawchartstartmessage = CreateDrawChartStartMessageStartMessageEvent();
			drawcharteventsubprocess.FlowElements.Add(drawchartstartmessage);
			ProcessSchemaScriptTask drawchartscripttask = CreateDrawChartScriptTaskScriptTask();
			drawcharteventsubprocess.FlowElements.Add(drawchartscripttask);
			FlowElements.Add(CreateSequenceFlow243SequenceFlow());
			FlowElements.Add(CreateSequenceFlow244SequenceFlow());
			FlowElements.Add(CreateSequenceFlow245SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow243SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow243",
				UId = new Guid("7b89de8c-03c0-4111-aa6a-b6f975c2487f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CurveCenterPosition = new Point(170, 84),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eebf0d27-a853-4723-b87c-d0430d070eea"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5bd26630-8b21-4869-b389-ccec445229d0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow244SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow244",
				UId = new Guid("82383e00-4bff-4a34-89c5-66a88791ac81"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CurveCenterPosition = new Point(171, 281),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b27f302c-7ddd-48b6-8ce5-82a4810a5d36"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d5804303-4e32-44f2-abfd-41e3e75ca42c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow245SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow245",
				UId = new Guid("f03209dd-cf5a-4ef9-9ba8-40ff6a584faa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f1a5d3b-9bdf-4755-8b3e-4bde87aa729b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("217acd4e-7554-4213-b183-465bd58af5eb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("041c6d99-5e2a-4a49-8cd8-cb70c768f1bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CurveCenterPosition = new Point(182, 443),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7fd22d1a-8f9e-4964-8194-32b890fc4663"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3f396e9-a39c-4373-a473-2ee65332e111"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet23LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet23 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ba0dc95e-b025-46bb-8942-90ed1670a3aa"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"LaneSet23",
				Position = new Point(5, 5),
				Size = new Size(1097, 522),
				UseBackgroundMode = false
			};
			return schemaLaneSet23;
		}

		protected virtual ProcessSchemaLane CreateLane72Lane() {
			ProcessSchemaLane schemaLane72 = new ProcessSchemaLane(this) {
				UId = new Guid("eaa27ec7-b375-4cc1-aae7-71fa90aad7c7"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ba0dc95e-b025-46bb-8942-90ed1670a3aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"Lane72",
				Position = new Point(29, 0),
				Size = new Size(1068, 145),
				UseBackgroundMode = false
			};
			return schemaLane72;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessChartEditChangeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessChartEditChange = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5c99229a-6332-4530-aac8-475a02e5bdf2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaa27ec7-b375-4cc1-aae7-71fa90aad7c7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"SubProcessChartEditChange",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(180, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessChartEditChange;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChartEditChangeStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4f1a5d3b-9bdf-4755-8b3e-4bde87aa729b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c99229a-6332-4530-aac8-475a02e5bdf2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ChartEditChange",
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"StartMessageChartEditChange",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChartEditChangeScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("217acd4e-7554-4213-b183-465bd58af5eb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5c99229a-6332-4530-aac8-475a02e5bdf2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"ScriptChartEditChange",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,205,205,10,130,64,20,134,225,117,66,247,48,185,82,136,185,1,105,147,72,12,244,227,34,47,96,176,147,14,141,103,228,204,25,75,162,123,207,200,150,109,95,62,158,207,92,69,178,242,76,6,27,169,252,49,88,123,162,162,235,121,76,246,198,51,32,80,169,27,40,201,213,224,125,165,46,105,42,158,203,104,49,104,18,253,55,138,141,168,60,80,238,16,161,102,227,80,170,121,94,96,99,16,228,14,120,14,219,113,18,254,193,217,196,206,164,60,183,228,238,197,0,200,201,47,41,100,32,212,118,250,97,120,240,90,196,121,171,137,15,128,65,49,116,185,53,245,45,254,32,175,101,68,192,129,80,48,5,200,222,188,144,64,163,225,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4bf29751-da14-4aed-836c-9f279f419e52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaa27ec7-b375-4cc1-aae7-71fa90aad7c7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"SubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 163),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(241, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("eebf0d27-a853-4723-b87c-d0430d070eea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bf29751-da14-4aed-836c-9f279f419e52"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"StartMessageInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5bd26630-8b21-4869-b389-ccec445229d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4bf29751-da14-4aed-836c-9f279f419e52"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"ScriptInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,221,74,3,49,16,133,175,91,232,59,164,119,41,72,94,160,120,161,75,209,208,10,130,127,215,177,153,181,3,217,164,204,76,212,85,124,119,179,89,173,138,80,200,197,48,156,239,156,147,193,86,233,155,158,175,146,207,1,172,87,243,83,117,145,209,155,85,183,151,126,161,222,103,211,201,179,35,229,162,11,189,224,150,55,200,162,138,6,164,201,44,169,107,118,142,132,245,98,89,132,109,34,112,219,157,210,191,9,133,241,47,61,154,86,215,8,47,86,160,43,126,101,82,183,64,228,56,181,98,238,172,121,128,199,38,69,161,20,216,28,134,1,31,0,253,109,104,238,93,200,112,114,8,48,107,232,107,149,201,181,123,2,83,203,173,60,138,25,40,54,103,222,235,175,204,170,250,152,77,203,195,114,130,185,229,33,5,94,229,18,194,254,60,139,164,104,35,10,186,128,111,224,199,206,63,139,127,218,241,0,199,77,202,55,133,50,44,107,40,129,100,138,227,226,19,162,28,34,79,132,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPageLoadEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPageLoad = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2555738d-88bc-4ac4-9aac-ec840b870bfa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaa27ec7-b375-4cc1-aae7-71fa90aad7c7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"SubProcessPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 163),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(257, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPageLoad;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessagePageLoadStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b27f302c-7ddd-48b6-8ce5-82a4810a5d36"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2555738d-88bc-4ac4-9aac-ec840b870bfa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"StartMessagePageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTaskPageLoadScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d5804303-4e32-44f2-abfd-41e3e75ca42c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2555738d-88bc-4ac4-9aac-ec840b870bfa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"ScriptTaskPageLoad",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(147, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,77,79,194,64,16,134,207,146,240,31,214,158,218,132,110,138,34,193,16,14,165,31,166,145,3,17,241,98,60,108,186,35,174,182,219,102,119,138,54,200,127,119,91,62,18,17,15,61,205,59,239,60,251,84,188,18,59,120,99,10,231,170,40,65,97,157,112,114,57,33,119,149,224,52,202,75,172,29,178,233,118,46,214,76,17,129,144,223,67,77,38,68,163,18,114,69,227,66,229,12,109,107,227,109,191,55,125,243,93,109,173,30,145,240,217,174,219,214,173,23,132,126,20,143,220,56,240,67,119,48,26,198,174,31,70,215,174,231,135,163,112,218,191,241,135,131,129,229,244,136,21,84,26,139,188,197,48,5,39,56,206,216,220,159,179,21,208,118,16,113,129,116,81,233,18,36,247,223,217,87,180,6,137,218,62,155,130,12,82,76,12,182,189,103,63,151,122,0,93,229,112,82,181,237,118,132,49,211,70,167,5,26,186,25,171,139,10,105,211,166,159,189,23,26,40,96,8,124,90,55,155,59,73,109,218,231,124,145,42,81,162,253,215,18,133,140,230,76,127,152,19,230,157,109,252,177,40,247,205,65,38,204,249,36,116,90,200,70,120,218,48,6,133,68,38,36,40,227,253,127,28,194,116,59,61,166,155,142,223,251,180,153,39,82,35,147,41,80,227,55,5,173,141,163,163,234,39,150,85,96,91,51,161,17,76,190,137,239,83,203,132,31,120,15,123,135,162,229,238,7,25,95,10,176,82,146,160,170,96,252,3,143,216,90,24,86,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDrawChartEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDrawChartEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2e65c347-9158-4e6f-83cf-e99807f34e1e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eaa27ec7-b375-4cc1-aae7-71fa90aad7c7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"DrawChartEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 351),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(273, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDrawChartEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDrawChartStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7fd22d1a-8f9e-4964-8194-32b890fc4663"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e65c347-9158-4e6f-83cf-e99807f34e1e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DrawChart",
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"DrawChartStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDrawChartScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e3f396e9-a39c-4373-a473-2ee65332e111"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2e65c347-9158-4e6f-83cf-e99807f34e1e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				Name = @"DrawChartScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,10,130,80,16,69,247,65,255,240,112,101,16,254,128,180,18,3,23,129,96,180,31,244,162,15,94,99,204,27,45,251,250,52,13,34,170,221,204,153,185,119,134,219,147,152,139,180,37,188,55,59,147,83,141,40,105,72,116,170,146,150,149,44,67,162,169,203,216,43,113,137,40,159,215,227,245,106,17,70,5,116,132,23,136,14,39,114,29,194,224,208,86,157,67,202,106,117,40,202,6,103,202,170,96,107,190,225,205,95,163,249,153,133,61,61,62,200,127,121,1,177,228,236,29,213,124,122,111,157,66,252,104,243,99,242,110,119,108,164,189,166,61,88,195,23,202,120,92,98,114,83,52,184,233,214,4,75,26,227,87,92,195,7,147,94,160,157,176,81,233,16,63,0,37,15,144,116,96,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
			Methods.Add(CreateGetCustomChartsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("73fd9877-6780-4b18-bd39-a2971238b21d"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("06d5cead-c204-44aa-9c27-6edf3aa62176"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1095c312-8462-4019-b206-42e3726901f3"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7446b65f-bf2b-44c2-baa8-2c66a658c7c9"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,185,174,194,48,16,69,107,248,138,33,5,36,2,249,7,158,40,216,4,41,88,4,72,212,134,76,32,224,140,35,219,1,36,196,191,63,59,129,2,16,75,101,207,213,185,103,38,137,193,175,13,209,132,186,39,201,224,217,140,80,100,221,220,24,73,163,36,138,144,252,0,234,117,120,38,6,196,215,2,35,63,8,224,82,173,204,248,22,217,75,159,149,2,104,67,204,133,198,191,183,92,152,186,124,33,115,181,65,75,59,64,73,81,164,101,200,230,168,139,207,152,147,13,213,55,213,19,62,225,169,243,122,75,84,138,107,25,27,182,194,117,39,203,188,95,61,161,193,244,46,217,89,136,101,180,253,80,238,236,249,121,112,68,50,154,245,68,178,57,176,41,217,215,206,69,248,120,137,171,221,12,76,239,228,201,205,62,229,66,180,160,225,65,19,222,172,40,125,97,223,18,94,35,176,183,92,255,1,60,248,138,253,201,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cf1b8868-aa63-4f72-a3c5-6f94723d133b"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("daeeca13-bcc8-4eb9-abb8-b77f31447bcd"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCustomChartsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7a0a6cf5-a689-4e3a-bda0-5a625aa5ab55"),
				Name = "GetCustomCharts",
				CreatedInSchemaUId = new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<KeyValuePair<string, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,219,75,235,48,24,127,238,96,255,67,200,83,10,91,153,58,101,226,5,106,235,134,184,115,56,48,47,15,226,67,72,51,23,76,147,146,139,50,231,254,119,115,113,27,59,27,34,180,132,246,251,126,183,47,137,54,138,137,23,64,112,99,152,20,133,228,182,22,127,113,77,193,5,184,155,20,82,76,217,139,85,216,215,178,66,214,181,20,247,134,113,102,24,213,217,136,154,49,249,216,64,80,187,149,220,107,170,28,74,80,226,33,29,0,39,115,253,71,86,150,211,92,96,62,55,140,232,98,134,149,129,174,84,68,77,152,158,181,91,111,88,1,220,52,5,38,51,47,189,77,147,229,77,195,25,9,46,66,71,246,200,204,108,44,9,230,254,211,249,71,59,94,125,219,198,234,163,84,175,186,193,132,134,255,35,37,109,179,82,37,222,142,118,41,120,20,251,93,240,9,245,237,37,54,120,95,234,95,16,236,27,74,36,237,172,7,177,135,104,59,214,54,60,20,87,177,20,213,150,27,23,70,208,119,48,102,218,156,223,210,249,3,230,150,254,195,76,157,235,176,237,29,16,215,203,75,228,113,83,169,168,227,0,104,61,23,192,196,206,128,82,176,112,145,217,20,160,245,222,222,84,224,34,42,141,44,171,80,64,60,65,189,41,195,231,236,78,78,130,22,74,211,200,144,68,139,89,94,85,200,67,127,242,7,252,148,147,36,50,100,67,169,106,108,16,92,244,150,159,139,3,247,30,46,33,232,128,208,146,172,93,192,211,94,81,230,215,195,65,119,88,228,101,183,63,56,25,118,243,242,250,168,219,203,203,65,121,117,112,156,159,244,251,48,245,7,209,106,35,235,213,185,252,63,70,88,118,34,124,203,197,158,157,219,179,221,235,70,155,44,219,45,247,40,106,172,18,223,155,115,246,5,35,219,11,233,124,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AnalyticsChartPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a37aa6eb-f727-4243-8ae8-c6307d31399f"));
		}

		#endregion

	}

	#endregion

}

