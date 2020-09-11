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
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;
	using TSWebControls = Terrasoft.UI.WebControls;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: AnalyticsGridPageSchema

	/// <exclude/>
	public class AnalyticsGridPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _searchElementsLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout searchElementsLayout {
			get {
				return _searchElementsLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _searchTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit searchTextEdit {
			get {
				return _searchTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ToolButton _clearSearchButton;
		public Terrasoft.UI.WebControls.Controls.ToolButton ClearSearchButton {
			get {
				return _clearSearchButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuPanel _analyticsMenu;
		public Terrasoft.UI.WebControls.Controls.MenuPanel AnalyticsMenu {
			get {
				return _analyticsMenu;
			}
		}

		#endregion

		#region Constructors: Public

		public AnalyticsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public AnalyticsGridPageSchema(AnalyticsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			RealUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			Name = "AnalyticsGridPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAnalyticsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreatesearchElementsLayout());
			searchElementsLayout.InsertItem(0, CreatesearchTextEdit());
			searchTextEdit.InsertItem(0, CreateClearSearchButton());
			searchElementsLayout.InsertItem(1, CreateContextHelpButton());
			Controls.AddAt(1, CreateAnalyticsMenu());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateAnalyticsGridPageEventsProcessSchema() {
			var schema = new AnalyticsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ToolButton CreateClearSearchButton() {
			_clearSearchButton = new Terrasoft.UI.WebControls.Controls.ToolButton();
			_clearSearchButton.UId = new Guid("5d53a483-9995-4f8b-a83b-d13221262695");
			_clearSearchButton.Name = "ClearSearchButton";
			_clearSearchButton.CreatedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_clearSearchButton.ModifiedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_clearSearchButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_clearSearchButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_clearSearchButton.Tag = "";
			_clearSearchButton.Image = new ControlImage {};
			_clearSearchButton.Hidden = true;
			return _clearSearchButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreatesearchTextEdit() {
			_searchTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_searchTextEdit.UId = new Guid("40eb0f0d-5af2-4189-9994-8caccfc2a218");
			_searchTextEdit.Name = "searchTextEdit";
			_searchTextEdit.CreatedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_searchTextEdit.ModifiedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_searchTextEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchTextEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_searchTextEdit.Tag = "";
			_searchTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_searchTextEdit.Image = new ControlImage {};
			_searchTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_searchTextEdit.CaptionPosition = Terrasoft.UI.WebControls.CaptionPosition.None;
			_searchTextEdit.AlignedByCaption = false;
			_searchTextEdit.Margins = "0 5 0 0";
			return _searchTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("f3de15de-f687-4580-ae65-69207a2f07a5");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Margins = "0 0 0 0";
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreatesearchElementsLayout() {
			_searchElementsLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_searchElementsLayout.UId = new Guid("6c8e719c-2e56-4fd0-84fa-4dbcb13ca5b1");
			_searchElementsLayout.Name = "searchElementsLayout";
			_searchElementsLayout.CreatedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_searchElementsLayout.ModifiedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_searchElementsLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_searchElementsLayout.Tag = "";
			_searchElementsLayout.Height = System.Web.UI.WebControls.Unit.Pixel(30);
			_searchElementsLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Topbar;
			_searchElementsLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_searchElementsLayout.StartNewAlignGroup = false;
			_searchElementsLayout.Image = new ControlImage {};
			_searchElementsLayout.Edges = "0 0 0 0";
			return _searchElementsLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuPanel CreateAnalyticsMenu() {
			_analyticsMenu = new Terrasoft.UI.WebControls.Controls.MenuPanel();
			_analyticsMenu.UId = new Guid("f8eb950f-e218-44cd-88e5-2d07f8e08860");
			_analyticsMenu.Name = "AnalyticsMenu";
			_analyticsMenu.CreatedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_analyticsMenu.ModifiedInSchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			_analyticsMenu.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_analyticsMenu.Tag = "";
			_analyticsMenu.Edges = "0 0 0 0";
			_analyticsMenu.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_analyticsMenu.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _analyticsMenu;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new AnalyticsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new AnalyticsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AnalyticsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsGridPageEventsProcess

	/// <exclude/>
	public class AnalyticsGridPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.AnalyticsGridPageSchemaUserControl
	{

		#region Class: OpenReportUserTaskFlowElement

		/// <exclude/>
		public class OpenReportUserTaskFlowElement : OpenPageUserTask
		{

			public OpenReportUserTaskFlowElement(UserConnection userConnection, AnalyticsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenReportUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: EditChartOpenPage_UserTaskFlowElement

		/// <exclude/>
		public class EditChartOpenPage_UserTaskFlowElement : OpenPageUserTask
		{

			public EditChartOpenPage_UserTaskFlowElement(UserConnection userConnection, AnalyticsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "EditChartOpenPage_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: DeleteCustomChartQuestion_UserTaskFlowElement

		/// <exclude/>
		public class DeleteCustomChartQuestion_UserTaskFlowElement : QuestionUserTask
		{

			public DeleteCustomChartQuestion_UserTaskFlowElement(UserConnection userConnection, AnalyticsGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DeleteCustomChartQuestion_UserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		private TPage _page;
		public TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public AnalyticsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AnalyticsGridPageEventsProcess";
			SchemaUId = new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b47a5d39-98ed-4dfc-8f4c-b4d5dffa38c3");
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

		public virtual Object SelectedActiveRows {
			get;
			set;
		}

		public virtual string ListenerPageProcessUId {
			get;
			set;
		}

		public virtual string SerializedFilters {
			get;
			set;
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual Object CustomChartIdList {
			get;
			set;
		}

		public virtual bool IsModuleProcessesTuningMode {
			get;
			set;
		}

		public virtual Guid ChartDeleteId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("913f91a1-8c29-4b63-a071-eb3b212082bf"),
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
					SchemaElementUId = new Guid("dd7f4d1c-e10e-480f-b0ce-2ecc19cc3d0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptClearSearchButtonClick;
		public ProcessScriptTask ScriptClearSearchButtonClick {
			get {
				return _scriptClearSearchButtonClick ?? (_scriptClearSearchButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptClearSearchButtonClick",
					SchemaElementUId = new Guid("7788e967-8545-4ec3-91e7-574090dd7cf4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptClearSearchButtonClickExecute,
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
					SchemaElementUId = new Guid("ea8297f3-e095-4eee-b9c7-fccc6fef2870"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "searchTextEditChange",
				});
			}
		}

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("01ec06a6-ff66-4d8c-b1a0-7bd5f7c7a28e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _reSearchMessage;
		public ProcessFlowElement ReSearchMessage {
			get {
				return _reSearchMessage ?? (_reSearchMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ReSearchMessage",
					SchemaElementUId = new Guid("4c6ab385-1208-4d8d-86ba-d8f3b3db7a6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _filterScript;
		public ProcessScriptTask FilterScript {
			get {
				return _filterScript ?? (_filterScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FilterScript",
					SchemaElementUId = new Guid("6843a7a2-96ae-4a8c-833d-09e5bc8987c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = FilterScriptExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessPageLoadComplete;
		public ProcessFlowElement SubProcessPageLoadComplete {
			get {
				return _subProcessPageLoadComplete ?? (_subProcessPageLoadComplete = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPageLoadComplete",
					SchemaElementUId = new Guid("4ab4abc7-c82d-4eb2-be87-5bbec79b281d"),
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
					SchemaElementUId = new Guid("9c54e541-90c9-4e3d-839e-fe947d49a2b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScript;
		public ProcessScriptTask PageLoadCompleteScript {
			get {
				return _pageLoadCompleteScript ?? (_pageLoadCompleteScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScript",
					SchemaElementUId = new Guid("81b1f897-b124-47e2-a368-ee1a7520c832"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptExecute,
				});
			}
		}

		private ProcessFlowElement _switchTuningModeEventSubProcess;
		public ProcessFlowElement SwitchTuningModeEventSubProcess {
			get {
				return _switchTuningModeEventSubProcess ?? (_switchTuningModeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SwitchTuningModeEventSubProcess",
					SchemaElementUId = new Guid("5d1e6cc5-2b8f-4431-b210-c8525d4f802e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startTuningModeChanged;
		public ProcessFlowElement StartTuningModeChanged {
			get {
				return _startTuningModeChanged ?? (_startTuningModeChanged = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartTuningModeChanged",
					SchemaElementUId = new Guid("4907062e-17bc-4d37-84b1-11fbb1dbf2e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _switchTuningMode_ScriptTask;
		public ProcessScriptTask SwitchTuningMode_ScriptTask {
			get {
				return _switchTuningMode_ScriptTask ?? (_switchTuningMode_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SwitchTuningMode_ScriptTask",
					SchemaElementUId = new Guid("eafbc23c-3be5-424c-957a-50ad9d1df3c8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SwitchTuningMode_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessMenuItemClick;
		public ProcessFlowElement EventSubProcessMenuItemClick {
			get {
				return _eventSubProcessMenuItemClick ?? (_eventSubProcessMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessMenuItemClick",
					SchemaElementUId = new Guid("ce550b20-03bf-4448-8e7d-b262f7193c5d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _reportMenuItemClickMessage;
		public ProcessFlowElement ReportMenuItemClickMessage {
			get {
				return _reportMenuItemClickMessage ?? (_reportMenuItemClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ReportMenuItemClickMessage",
					SchemaElementUId = new Guid("e244c58e-e605-450e-8a5b-81f2f4f5f15e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _chartMenuItemClickMessage;
		public ProcessFlowElement ChartMenuItemClickMessage {
			get {
				return _chartMenuItemClickMessage ?? (_chartMenuItemClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChartMenuItemClickMessage",
					SchemaElementUId = new Guid("d630ae70-7d54-4aaf-83d6-973b3fc615b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _reportMenuItemClickScript;
		public ProcessScriptTask ReportMenuItemClickScript {
			get {
				return _reportMenuItemClickScript ?? (_reportMenuItemClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ReportMenuItemClickScript",
					SchemaElementUId = new Guid("554d8f20-270a-4016-90da-255453a59e67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ReportMenuItemClickScriptExecute,
				});
			}
		}

		private ProcessScriptTask _chartMenuItemClickScript;
		public ProcessScriptTask ChartMenuItemClickScript {
			get {
				return _chartMenuItemClickScript ?? (_chartMenuItemClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ChartMenuItemClickScript",
					SchemaElementUId = new Guid("245546fe-4d1e-42af-b7f5-66b85c25b4fe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ChartMenuItemClickScriptExecute,
				});
			}
		}

		private OpenReportUserTaskFlowElement _openReportUserTask;
		public OpenReportUserTaskFlowElement OpenReportUserTask {
			get {
				return _openReportUserTask ?? (_openReportUserTask = new OpenReportUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _createUpdateDeleteChartMenuItemClickEventSubProcess;
		public ProcessFlowElement CreateUpdateDeleteChartMenuItemClickEventSubProcess {
			get {
				return _createUpdateDeleteChartMenuItemClickEventSubProcess ?? (_createUpdateDeleteChartMenuItemClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CreateUpdateDeleteChartMenuItemClickEventSubProcess",
					SchemaElementUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _createNewChartMenuItemClickStartMessage;
		public ProcessFlowElement CreateNewChartMenuItemClickStartMessage {
			get {
				return _createNewChartMenuItemClickStartMessage ?? (_createNewChartMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CreateNewChartMenuItemClickStartMessage",
					SchemaElementUId = new Guid("f2062f5a-8112-4f2c-b8d0-e0235b16f33b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareNewChartOpenPage_ScriptTask;
		public ProcessScriptTask PrepareNewChartOpenPage_ScriptTask {
			get {
				return _prepareNewChartOpenPage_ScriptTask ?? (_prepareNewChartOpenPage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareNewChartOpenPage_ScriptTask",
					SchemaElementUId = new Guid("50faf986-a28d-4f8a-92cf-955a40cb7451"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareNewChartOpenPage_ScriptTaskExecute,
				});
			}
		}

		private EditChartOpenPage_UserTaskFlowElement _editChartOpenPage_UserTask;
		public EditChartOpenPage_UserTaskFlowElement EditChartOpenPage_UserTask {
			get {
				return _editChartOpenPage_UserTask ?? (_editChartOpenPage_UserTask = new EditChartOpenPage_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _chartPropertyEditClosedMessage_IntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent {
			get {
				return _chartPropertyEditClosedMessage_IntermediateCatchMessageEvent ?? (_chartPropertyEditClosedMessage_IntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("805a26e7-8f4c-4f2a-a0fa-ae0be56935ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "ChartPropertyEditClosedMessage",
				});
			}
		}

		private ProcessScriptTask _prepareEditChartOpenPage_ScriptTask;
		public ProcessScriptTask PrepareEditChartOpenPage_ScriptTask {
			get {
				return _prepareEditChartOpenPage_ScriptTask ?? (_prepareEditChartOpenPage_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareEditChartOpenPage_ScriptTask",
					SchemaElementUId = new Guid("fc1058c6-8ed8-4d16-93e5-42587ef5f4db"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareEditChartOpenPage_ScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _editChartMenuItemClickStartMessage;
		public ProcessFlowElement EditChartMenuItemClickStartMessage {
			get {
				return _editChartMenuItemClickStartMessage ?? (_editChartMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditChartMenuItemClickStartMessage",
					SchemaElementUId = new Guid("59ed4915-cbd9-4d99-819c-2bffa228fac1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteChartMenuItemClickStartMessage;
		public ProcessFlowElement DeleteChartMenuItemClickStartMessage {
			get {
				return _deleteChartMenuItemClickStartMessage ?? (_deleteChartMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteChartMenuItemClickStartMessage",
					SchemaElementUId = new Guid("50466cce-6027-4271-9e90-1e7d3bc5b02d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareDeleteCustomChart_ScriptTask;
		public ProcessScriptTask PrepareDeleteCustomChart_ScriptTask {
			get {
				return _prepareDeleteCustomChart_ScriptTask ?? (_prepareDeleteCustomChart_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareDeleteCustomChart_ScriptTask",
					SchemaElementUId = new Guid("4f49c22b-d60d-497e-a173-2214aaa62dcc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareDeleteCustomChart_ScriptTaskExecute,
				});
			}
		}

		private DeleteCustomChartQuestion_UserTaskFlowElement _deleteCustomChartQuestion_UserTask;
		public DeleteCustomChartQuestion_UserTaskFlowElement DeleteCustomChartQuestion_UserTask {
			get {
				return _deleteCustomChartQuestion_UserTask ?? (_deleteCustomChartQuestion_UserTask = new DeleteCustomChartQuestion_UserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _yesDeleteCustomChartMessageIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent YesDeleteCustomChartMessageIntermediateCatchMessageEvent {
			get {
				return _yesDeleteCustomChartMessageIntermediateCatchMessageEvent ?? (_yesDeleteCustomChartMessageIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "YesDeleteCustomChartMessageIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("1ef05a33-d102-4ecf-81ac-49a1a2082d0f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "YesDeleteCustomChartMessage",
				});
			}
		}

		private ProcessScriptTask _deleteCustomChart_ScriptTask;
		public ProcessScriptTask DeleteCustomChart_ScriptTask {
			get {
				return _deleteCustomChart_ScriptTask ?? (_deleteCustomChart_ScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteCustomChart_ScriptTask",
					SchemaElementUId = new Guid("7a6e8347-57f6-47d4-82e3-d3d6e13a3bb5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteCustomChart_ScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _refreshAnalyticsMenuScript;
		public ProcessScriptTask RefreshAnalyticsMenuScript {
			get {
				return _refreshAnalyticsMenuScript ?? (_refreshAnalyticsMenuScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RefreshAnalyticsMenuScript",
					SchemaElementUId = new Guid("fd02529e-93f4-4b46-bcd1-7a02a269ec64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = RefreshAnalyticsMenuScriptExecute,
				});
			}
		}

		private LocalizableString _createNewChartMenuItemCaption;
		public LocalizableString CreateNewChartMenuItemCaption {
			get {
				return _createNewChartMenuItemCaption ?? (_createNewChartMenuItemCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CreateNewChartMenuItemCaption.Value"));
			}
		}

		private LocalizableString _editCaption;
		public LocalizableString EditCaption {
			get {
				return _editCaption ?? (_editCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.EditCaption.Value"));
			}
		}

		private LocalizableString _deleteCaption;
		public LocalizableString DeleteCaption {
			get {
				return _deleteCaption ?? (_deleteCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteCaption.Value"));
			}
		}

		private LocalizableString _deleteChartMessage;
		public LocalizableString DeleteChartMessage {
			get {
				return _deleteChartMessage ?? (_deleteChartMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DeleteChartMessage.Value"));
			}
		}

		private LocalizableString _reportCaption;
		public LocalizableString ReportCaption {
			get {
				return _reportCaption ?? (_reportCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ReportCaption.Value"));
			}
		}

		private LocalizableString _chartCaption;
		public LocalizableString ChartCaption {
			get {
				return _chartCaption ?? (_chartCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ChartCaption.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptClearSearchButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptClearSearchButtonClick };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[ReSearchMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReSearchMessage };
			FlowElements[FilterScript.SchemaElementUId] = new Collection<ProcessFlowElement> { FilterScript };
			FlowElements[SubProcessPageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPageLoadComplete };
			FlowElements[PageLoadComplete.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadComplete };
			FlowElements[PageLoadCompleteScript.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScript };
			FlowElements[SwitchTuningModeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SwitchTuningModeEventSubProcess };
			FlowElements[StartTuningModeChanged.SchemaElementUId] = new Collection<ProcessFlowElement> { StartTuningModeChanged };
			FlowElements[SwitchTuningMode_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SwitchTuningMode_ScriptTask };
			FlowElements[EventSubProcessMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessMenuItemClick };
			FlowElements[ReportMenuItemClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReportMenuItemClickMessage };
			FlowElements[ChartMenuItemClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ChartMenuItemClickMessage };
			FlowElements[ReportMenuItemClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ReportMenuItemClickScript };
			FlowElements[ChartMenuItemClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ChartMenuItemClickScript };
			FlowElements[OpenReportUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenReportUserTask };
			FlowElements[CreateUpdateDeleteChartMenuItemClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateUpdateDeleteChartMenuItemClickEventSubProcess };
			FlowElements[CreateNewChartMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateNewChartMenuItemClickStartMessage };
			FlowElements[PrepareNewChartOpenPage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareNewChartOpenPage_ScriptTask };
			FlowElements[EditChartOpenPage_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EditChartOpenPage_UserTask };
			FlowElements[ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent };
			FlowElements[PrepareEditChartOpenPage_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareEditChartOpenPage_ScriptTask };
			FlowElements[EditChartMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EditChartMenuItemClickStartMessage };
			FlowElements[DeleteChartMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteChartMenuItemClickStartMessage };
			FlowElements[PrepareDeleteCustomChart_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareDeleteCustomChart_ScriptTask };
			FlowElements[DeleteCustomChartQuestion_UserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteCustomChartQuestion_UserTask };
			FlowElements[YesDeleteCustomChartMessageIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { YesDeleteCustomChartMessageIntermediateCatchMessageEvent };
			FlowElements[DeleteCustomChart_ScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteCustomChart_ScriptTask };
			FlowElements[RefreshAnalyticsMenuScript.SchemaElementUId] = new Collection<ProcessFlowElement> { RefreshAnalyticsMenuScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptClearSearchButtonClick");
						break;
					case "ScriptClearSearchButtonClick":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "SubProcess2":
						break;
					case "ReSearchMessage":
						e.Context.QueueTasks.Enqueue("FilterScript");
						break;
					case "FilterScript":
						break;
					case "SubProcessPageLoadComplete":
						break;
					case "PageLoadComplete":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScript");
						break;
					case "PageLoadCompleteScript":
						break;
					case "SwitchTuningModeEventSubProcess":
						break;
					case "StartTuningModeChanged":
						e.Context.QueueTasks.Enqueue("SwitchTuningMode_ScriptTask");
						break;
					case "SwitchTuningMode_ScriptTask":
						break;
					case "EventSubProcessMenuItemClick":
						break;
					case "ReportMenuItemClickMessage":
						e.Context.QueueTasks.Enqueue("ReportMenuItemClickScript");
						break;
					case "ChartMenuItemClickMessage":
						e.Context.QueueTasks.Enqueue("ChartMenuItemClickScript");
						break;
					case "ReportMenuItemClickScript":
						e.Context.QueueTasks.Enqueue("OpenReportUserTask");
						break;
					case "ChartMenuItemClickScript":
						break;
					case "OpenReportUserTask":
						break;
					case "CreateUpdateDeleteChartMenuItemClickEventSubProcess":
						break;
					case "CreateNewChartMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("PrepareNewChartOpenPage_ScriptTask");
						break;
					case "PrepareNewChartOpenPage_ScriptTask":
						e.Context.QueueTasks.Enqueue("EditChartOpenPage_UserTask");
						break;
					case "EditChartOpenPage_UserTask":
						ActivatedEventElements.Add("ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent");
						break;
					case "ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("RefreshAnalyticsMenuScript");
						break;
					case "PrepareEditChartOpenPage_ScriptTask":
						e.Context.QueueTasks.Enqueue("EditChartOpenPage_UserTask");
						break;
					case "EditChartMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("PrepareEditChartOpenPage_ScriptTask");
						break;
					case "DeleteChartMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("PrepareDeleteCustomChart_ScriptTask");
						break;
					case "PrepareDeleteCustomChart_ScriptTask":
						e.Context.QueueTasks.Enqueue("DeleteCustomChartQuestion_UserTask");
						break;
					case "DeleteCustomChartQuestion_UserTask":
						ActivatedEventElements.Add("YesDeleteCustomChartMessageIntermediateCatchMessageEvent");
						break;
					case "YesDeleteCustomChartMessageIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("DeleteCustomChart_ScriptTask");
						break;
					case "DeleteCustomChart_ScriptTask":
						e.Context.QueueTasks.Enqueue("RefreshAnalyticsMenuScript");
						break;
					case "RefreshAnalyticsMenuScript":
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
			ActivatedEventElements.Add("ReSearchMessage");
			ActivatedEventElements.Add("PageLoadComplete");
			ActivatedEventElements.Add("StartTuningModeChanged");
			ActivatedEventElements.Add("ReportMenuItemClickMessage");
			ActivatedEventElements.Add("ChartMenuItemClickMessage");
			ActivatedEventElements.Add("CreateNewChartMenuItemClickStartMessage");
			ActivatedEventElements.Add("EditChartMenuItemClickStartMessage");
			ActivatedEventElements.Add("DeleteChartMenuItemClickStartMessage");
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptClearSearchButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptClearSearchButtonClick";
					result = ScriptClearSearchButtonClick.Execute(context, ScriptClearSearchButtonClickExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ReSearchMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReSearchMessage";
					result = ReSearchMessage.Execute(context);
					break;
				case "FilterScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "FilterScript";
					result = FilterScript.Execute(context, FilterScriptExecute);
					break;
				case "SubProcessPageLoadComplete":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadComplete":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadComplete";
					result = PageLoadComplete.Execute(context);
					break;
				case "PageLoadCompleteScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScript";
					result = PageLoadCompleteScript.Execute(context, PageLoadCompleteScriptExecute);
					break;
				case "SwitchTuningModeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "StartTuningModeChanged":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartTuningModeChanged";
					result = StartTuningModeChanged.Execute(context);
					break;
				case "SwitchTuningMode_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SwitchTuningMode_ScriptTask";
					result = SwitchTuningMode_ScriptTask.Execute(context, SwitchTuningMode_ScriptTaskExecute);
					break;
				case "EventSubProcessMenuItemClick":
					context.QueueTasks.Dequeue();
					break;
				case "ReportMenuItemClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReportMenuItemClickMessage";
					result = ReportMenuItemClickMessage.Execute(context);
					break;
				case "ChartMenuItemClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChartMenuItemClickMessage";
					result = ChartMenuItemClickMessage.Execute(context);
					break;
				case "ReportMenuItemClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReportMenuItemClickScript";
					result = ReportMenuItemClickScript.Execute(context, ReportMenuItemClickScriptExecute);
					break;
				case "ChartMenuItemClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChartMenuItemClickScript";
					result = ChartMenuItemClickScript.Execute(context, ChartMenuItemClickScriptExecute);
					break;
				case "OpenReportUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenReportUserTask";
					result = OpenReportUserTask.Execute(context);
					break;
				case "CreateUpdateDeleteChartMenuItemClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CreateNewChartMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CreateNewChartMenuItemClickStartMessage";
					result = CreateNewChartMenuItemClickStartMessage.Execute(context);
					break;
				case "PrepareNewChartOpenPage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareNewChartOpenPage_ScriptTask";
					result = PrepareNewChartOpenPage_ScriptTask.Execute(context, PrepareNewChartOpenPage_ScriptTaskExecute);
					break;
				case "EditChartOpenPage_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditChartOpenPage_UserTask";
					result = EditChartOpenPage_UserTask.Execute(context);
					break;
				case "ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent";
					result = ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent.Execute(context);
					break;
				case "PrepareEditChartOpenPage_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareEditChartOpenPage_ScriptTask";
					result = PrepareEditChartOpenPage_ScriptTask.Execute(context, PrepareEditChartOpenPage_ScriptTaskExecute);
					break;
				case "EditChartMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditChartMenuItemClickStartMessage";
					result = EditChartMenuItemClickStartMessage.Execute(context);
					break;
				case "DeleteChartMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteChartMenuItemClickStartMessage";
					result = DeleteChartMenuItemClickStartMessage.Execute(context);
					break;
				case "PrepareDeleteCustomChart_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareDeleteCustomChart_ScriptTask";
					result = PrepareDeleteCustomChart_ScriptTask.Execute(context, PrepareDeleteCustomChart_ScriptTaskExecute);
					break;
				case "DeleteCustomChartQuestion_UserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteCustomChartQuestion_UserTask";
					result = DeleteCustomChartQuestion_UserTask.Execute(context);
					break;
				case "YesDeleteCustomChartMessageIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "YesDeleteCustomChartMessageIntermediateCatchMessageEvent";
					result = YesDeleteCustomChartMessageIntermediateCatchMessageEvent.Execute(context);
					break;
				case "DeleteCustomChart_ScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteCustomChart_ScriptTask";
					result = DeleteCustomChart_ScriptTask.Execute(context, DeleteCustomChart_ScriptTaskExecute);
					break;
				case "RefreshAnalyticsMenuScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "RefreshAnalyticsMenuScript";
					result = RefreshAnalyticsMenuScript.Execute(context, RefreshAnalyticsMenuScriptExecute);
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
				case "ChartDeleteId":
					ChartDeleteId = reader.GetValue<System.Guid>();
				break;
				case "IsModuleProcessesTuningMode":
					IsModuleProcessesTuningMode = reader.GetValue<System.Boolean>();
				break;
				case "CustomChartIdList":
					CustomChartIdList = reader.GetSerializableObjectValue();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "SerializedFilters":
					SerializedFilters = reader.GetValue<System.String>();
				break;
				case "ListenerPageProcessUId":
					ListenerPageProcessUId = reader.GetValue<System.String>();
				break;
				case "SelectedActiveRows":
					SelectedActiveRows = reader.GetSerializableObjectValue();
				break;
				case "SysModuleId":
					SysModuleId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptClearSearchButtonClickExecute(ProcessExecutingContext context) {
			Page.searchTextEdit.Text = string.Empty;
			Page.searchTextEdit.Focus();
			return true;
		}

		public virtual bool FilterScriptExecute(ProcessExecutingContext context) {
			var searchText = Page.searchTextEdit.Text;
			if (string.Empty.Equals(searchText)) {
					Page.AddScript(string.Format("{0}.removeFilter();", Page.AnalyticsMenu.ClientID));
			} 
			else {
				string filterFunc = "function(item) {\n";
				filterFunc += "if (item instanceof Ext.menu.Separator) {\n";
				filterFunc += "return false;}";
				filterFunc += string.Concat(string.Format("\tif (item.caption.toLowerCase().search('{0}'.toLowerCase()) != -1)", searchText), "{\n");
					filterFunc += "\t\treturn true;\n";
				filterFunc += "\t\t} else {\n";
				filterFunc += "\t\treturn false;\n";
				filterFunc += "\t}\n";
				filterFunc += "}\n";
				Page.AddScript(string.Format("{0}.setFilter({1});\n", Page.AnalyticsMenu.ClientID, filterFunc));
			}
			return true;
		}

		public virtual bool PageLoadCompleteScriptExecute(ProcessExecutingContext context) {
			Page.ClearSearchButton.Hide();
			Page.ClearSearchButton.Image.Source = Terrasoft.UI.WebControls.ControlImageSource.ResourceManager;
			Page.ClearSearchButton.Image.ResourceManagerName = "Terrasoft.UI.WebControls";
			Page.ClearSearchButton.Image.ResourceItemName = "toolbutton-close.gif";
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysModule");
			//entitySchemaQuery.Cache = UserConnection.SessionCache.WithLocalCaching(
			//	string.Format(TSConfiguration.CacheUtilities.ModuleDataCacheGroup, SysModuleId));
			entitySchemaQuery.Cache = UserConnection.ApplicationCache.WithLocalCaching(
				TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var moduleIdField = entitySchemaQuery.AddColumn("Id");
			var helpContextIdField = entitySchemaQuery.AddColumn("HelpContextId");
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", SysModuleId));
			var sysModuleCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (sysModuleCollection.Count != 0) {
				var pageContainer = (TSWebControls.WebControl)Page.PageContainer;
				TSConfiguration.VideoHelpUtilities.SetWebControlHelpProperties(pageContainer, 
					sysModuleCollection[0].GetTypedColumnValue<string>(helpContextIdField.Name) + "000", UserConnection);
			}
			InitializeContextHelpButton();
			BuildMenu();
			Page.searchTextEdit.AjaxEvents.Change.OnClientEvent = @"(function() {
				var searchTextEdit = " + Page.searchTextEdit.ClientID + @";
				var clearSearchButton = " + Page.ClearSearchButton.ClientID + @";
				if (searchTextEdit.getValue().length == 0) {
					clearSearchButton.hide();
				} else {
					clearSearchButton.show();
				}
			})()
			";
			return true;
		}

		public virtual bool SwitchTuningMode_ScriptTaskExecute(ProcessExecutingContext context) {
			BuildMenu();
			return true;
		}

		public virtual bool ReportMenuItemClickScriptExecute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
				process.ThrowEvent(process.InternalContext, "ReportMenuItemClick");
			}
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			string tag = extraParams["tag"].ToString();
			string[] reportParams = tag.Split('|');
			var reportPreviewPageUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			var pageSchemaManager = Page.Schema.SchemaManagerProvider.GetManager("PageSchemaManager");
			var editPageSchema = pageSchemaManager.GetInstanceByUId(reportPreviewPageUId) as PageSchema;
			OpenReportUserTask.OpenerInstanceId = InstanceUId;
			OpenReportUserTask.PageUId = reportPreviewPageUId;
			var parameters =  
			      new Dictionary<string, string> {
						{"ReportSchemaUId", reportParams[0]},
						{"OptionPageSchemaUId", reportParams[1]},
						{"EntitySchemaUId", EntitySchemaUId.ToString()}
			      };
			OpenReportUserTask.PageParameters = parameters;
			OpenReportUserTask.Width = editPageSchema.Width;
			OpenReportUserTask.Height = editPageSchema.Height;
			OpenReportUserTask.Centered = true;
			OpenReportUserTask.CloseOpenerOnLoad = false;
			return true;
		}

		public virtual bool ChartMenuItemClickScriptExecute(ProcessExecutingContext context) {
			if (!string.IsNullOrEmpty(ListenerPageProcessUId)) {
				var process = UserConnection.IProcessEngine.GetProcessByUId(ListenerPageProcessUId);
				process.ThrowEvent(process.InternalContext, "ChartMenuItemClick");
			}
			return true;
		}

		public virtual bool PrepareNewChartOpenPage_ScriptTaskExecute(ProcessExecutingContext context) {
			var chartEditPage = new Guid("2507A7B3-3DDC-4572-A737-4C015ECD0B2C");
			var chartPropertyEntityId = "8DAD1434-BB20-4AF9-88AD-DB9B09206FAE";
			EditChartOpenPage_UserTask.PageUId = chartEditPage;
			var defValuesId = Guid.NewGuid();
			var defValues = new Dictionary <string, object>();
			defValues.Add("ModuleSchemaId", EntitySchemaUId);
			Page.UserConnection.SessionData[defValuesId.ToString()] = defValues;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", Guid.Empty.ToString()},
						{"entitySchemaUId", chartPropertyEntityId},
						{"defValuesId", defValuesId.ToString()}
			      };
			EditChartOpenPage_UserTask.PageParameters = parameters;
			EditChartOpenPage_UserTask.UseCurrentActivePage = true;
			EditChartOpenPage_UserTask.OpenerInstanceId = InstanceUId;
			EditChartOpenPage_UserTask.CloseMessage = "ChartPropertyEditClosedMessage";
			return true;
		}

		public virtual bool PrepareEditChartOpenPage_ScriptTaskExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			string recordId = extraParams["tag"].ToString();
			var chartEditPage = new Guid("2507A7B3-3DDC-4572-A737-4C015ECD0B2C");
			var chartPropertyEntityId = "8DAD1434-BB20-4AF9-88AD-DB9B09206FAE";
			EditChartOpenPage_UserTask.PageUId = chartEditPage;
			var defValuesId = Guid.NewGuid();
			var defValues = new Dictionary <string, object>();
			defValues.Add("ModuleSchemaId", EntitySchemaUId);
			Page.UserConnection.SessionData[defValuesId.ToString()] = defValues;
			var parameters =  
			      new Dictionary<string, string> {
			            {"recordId", recordId},
						{"entitySchemaUId", chartPropertyEntityId},
						{"defValuesId", defValuesId.ToString()}
			      };
			EditChartOpenPage_UserTask.UseCurrentActivePage = true;
			EditChartOpenPage_UserTask.PageParameters = parameters;
			EditChartOpenPage_UserTask.OpenerInstanceId = InstanceUId;
			EditChartOpenPage_UserTask.CloseMessage = "ChartPropertyEditClosedMessage";
			return true;
		}

		public virtual bool PrepareDeleteCustomChart_ScriptTaskExecute(ProcessExecutingContext context) {
			var extraParams = context.ThrowEventArgs as Dictionary<string, object>;
			ChartDeleteId = new Guid(extraParams["tag"].ToString());
			DeleteCustomChartQuestion_UserTask.Page = Page;
			DeleteCustomChartQuestion_UserTask.MessageText = DeleteChartMessage;
			DeleteCustomChartQuestion_UserTask.Icon = "WARNING";
			DeleteCustomChartQuestion_UserTask.Buttons = "YESNO";
			DeleteCustomChartQuestion_UserTask.ResponseMessages = new Dictionary<string, string> {{"yes", "YesDeleteCustomChartMessage"}, {"no", "NoDeleteCustomChartMessage"}};
			return true;
		}

		public virtual bool DeleteCustomChart_ScriptTaskExecute(ProcessExecutingContext context) {
			var entityChartPropertySchema = UserConnection.EntitySchemaManager.GetInstanceByName("SysModuleAnalyticsChart");
			var entityChartProperty = entityChartPropertySchema.CreateEntity(UserConnection);
			entityChartProperty.FetchFromDB(ChartDeleteId);
			entityChartProperty.Delete(ChartDeleteId);
			ChartDeleteId = Guid.Empty;
			return true;
		}

		public virtual bool RefreshAnalyticsMenuScriptExecute(ProcessExecutingContext context) {
			UserConnection.ApplicationCache.ExpireGroup(Terrasoft.Configuration.CacheUtilities.WorkspaceCacheGroup);
			BuildMenu();
			return true;
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuSeparator CreateMenuSeparator(string MenuSeparatorCaption) {
			var menuSeparator = new Terrasoft.UI.WebControls.Controls.MenuSeparator();
				menuSeparator.UId = Guid.NewGuid();
				menuSeparator.ID = "ActivitySeparator_" + menuSeparator.UId.ToString("N");
				menuSeparator.CreatedByAjax = true;
				menuSeparator.EnableViewState = false;
				menuSeparator.Caption= MenuSeparatorCaption;
				menuSeparator.CaptionColor = Color.FromArgb(0,2,77,156);
				menuSeparator.Image = new ControlImage {};
				menuSeparator.Collapsible = true;
				menuSeparator.Hidden = false;
			return menuSeparator;
		}

		public virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateMenuItem(Terrasoft.Common.LocalizableString MenuItemCaption, string SchemaUId, string OptionPageSchemaUId, string AnalyticsTypeCode) {
			var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			menuItem.UId = Guid.NewGuid();
			menuItem.Caption = MenuItemCaption;
			menuItem.CreatedByAjax = true;
			menuItem.EnableViewState = false;
			menuItem.Image.Source = ControlImageSource.ResourceManager;
			menuItem.Image.ResourceManagerName = "Terrasoft.WebApp";
			string resourceItemName = String.Empty;
			switch (AnalyticsTypeCode) {
				case "Report" : resourceItemName = "reportpreview.png";
					menuItem.ID = "ReportAnalyticsMenuItem_" + SchemaUId.Replace("-","");
					break;
				case "CustomChart" :
				case "Chart" : resourceItemName = "chart.png";
					menuItem.ID = "ChartAnalyticsMenuItem_" + SchemaUId.Replace("-","");
					break;
			}
			menuItem.Image.ResourceItemName = resourceItemName;
			menuItem.CaptionColor = Color.FromArgb(0,2,77,156);
			menuItem.Tag = SchemaUId + "|" + OptionPageSchemaUId + "|" + AnalyticsTypeCode + "|" + MenuItemCaption;
			menuItem.AjaxEvents.Click.ShowLoadMask = true;
			menuItem.AjaxEvents.Click.SignalName = string.Format("{0}MenuItemClick", AnalyticsTypeCode);
			menuItem.AjaxEvents.Click.AjaxEventTargetControlID = Page.AnalyticsMenu.ClientID;
			return menuItem;
		}

		public virtual void InitializeContextHelpButton() {
			if (!GetIsContextHelpButtonHidden() && GetIsContextHelpEnabled()) {
				Page.ContextHelpButton.Hidden = false;
				Page.ContextHelpButton.Image.Source = ControlImageSource.ResourceManager;
				Page.ContextHelpButton.Image.ResourceManagerName = "Terrasoft.WebApp";
				Page.ContextHelpButton.Image.ResourceItemName = "help.png";
				string helpContextId = Page.Schema.HelpContextId;
				if (helpContextId != "") {
					string helpUrl = Terrasoft.Configuration.VideoHelpUtilities.GetHelpUrl(Page.ContextHelpButton, helpContextId, UserConnection);
					Page.ContextHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(null, null, '" + helpUrl + @"')";
				} else {
					Page.ContextHelpButton.AjaxEvents.Click.OnClientEvent = "Terrasoft.HelpContext.showHelp(" + (string.IsNullOrEmpty(helpContextId) ?  "null" : helpContextId) + ",'" + Page.ContextHelpButton.ClientID + "')";
				}
			}
		}

		public virtual bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual bool GetIsContextHelpEnabled() {
			return (bool)SysSettings.GetValue(UserConnection, "EnableContextHelp");
		}

		public virtual List<Tuple<Guid, Guid, string>> GetChartList() {
			/*
			var appCache = UserConnection.ApplicationCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var chartsCollection = Terrasoft.Configuration.CommonUtilities.GetSelectData(
				UserConnection, 
				Terrasoft.Configuration.CommonUtilities.GetModuleAnalyticsChartSelect, 
				appCache, 
				TSConfiguration.CacheUtilities.AnalyticsChartCache);
			string captionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleAnalyticsChart", "Caption");
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as Terrasoft.UI.WebControls.PageSchemaManager;
			chartsCollection.Sort(delegate(Dictionary<string, object> p1, Dictionary<string, object> p2) { 
				return p1[captionColumnName].ToString().CompareTo(p2[captionColumnName].ToString());});
			var result = new List<Tuple<Guid, Guid, string>>();
			foreach (var chart in chartsCollection) {
				Guid sysModuleId = new Guid(chart["sysModuleId"].ToString());
				if (SysModuleId == sysModuleId) {
					string caption = chart[captionColumnName].ToString();
					Guid chartId = new Guid(chart["chartId"].ToString());		
					result.Add(new Tuple<Guid, Guid, string>(chartId, Guid.Empty, caption));
				}
			}
			*/
			var result = new List<Tuple<Guid, Guid, string>>();
			return result;
		}

		public virtual List<Tuple<Guid, Guid, string>> GetReportList() {
			var appCache = UserConnection.ApplicationCache.WithLocalCaching(TSConfiguration.CacheUtilities.WorkspaceCacheGroup);
			var reportsCollection = Terrasoft.Configuration.CommonUtilities.GetSelectData(UserConnection, Terrasoft.Configuration.CommonUtilities.GetModuleAnalyticsReportSelect, appCache, TSConfiguration.CacheUtilities.AnalyticsReportCache);
			string captionColumnName = Terrasoft.Configuration.CommonUtilities.GetLczColumnName(UserConnection, "SysModuleAnalyticsReport", "Caption");
			var reportSchemaManager = UserConnection.GetSchemaManager("ReportSchemaManager") as Terrasoft.Reports.ReportSchemaManager;
			var pageSchemaManager = UserConnection.GetSchemaManager("PageSchemaManager") as Terrasoft.UI.WebControls.PageSchemaManager;
			reportsCollection.Sort(delegate(Dictionary<string, object> p1, Dictionary<string, object> p2) { 
				return p1[captionColumnName].ToString().CompareTo(p2[captionColumnName].ToString());});
			var result = new List<Tuple<Guid, Guid, string>>();
			foreach (var report in reportsCollection) {
				Guid sysModuleId = new Guid(report["sysModuleId"].ToString());
				if (SysModuleId == sysModuleId) {
					string caption = report[captionColumnName].ToString();
					Guid reportSchemaId = new Guid(report["sysSchemaId"].ToString());
					Guid sysOptionsPageSchemaUId = report["sysOptionsPageSchemaUId"] == DBNull.Value ? Guid.Empty : new Guid(report["sysOptionsPageSchemaUId"].ToString());
					if (reportSchemaManager.FindItemByUId(reportSchemaId) != null &&
						(sysOptionsPageSchemaUId == Guid.Empty || pageSchemaManager.FindItemByUId(sysOptionsPageSchemaUId) != null)) {
						result.Add(new Tuple<Guid, Guid, string>(reportSchemaId, sysOptionsPageSchemaUId, caption));
					}
				}
			}
			return result;
		}

		public virtual void BuildMenu() {
			var script = string.Empty;
			var customChartIdList = new List<Guid>();
			if (Ext.IsAjaxRequest) {
				Page.AnalyticsMenu.Menu.RemoveAll();
				Page.AnalyticsMenu.Menu.Clear();
			}
			if (IsModuleProcessesTuningMode) {
				var menuAddNewItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
				menuAddNewItem.CreatedByAjax = true;
				menuAddNewItem.EnableViewState = false;
				menuAddNewItem.Name = "CreateNewChart";
				menuAddNewItem.UId = Guid.NewGuid();
				menuAddNewItem.Tag = "CreateNewChart";
				menuAddNewItem.Image = new ControlImage {};
				menuAddNewItem.Caption = CreateNewChartMenuItemCaption;
				menuAddNewItem.AjaxEvents.Click.SignalName = "CreateNewChartMenuItemClick";
				menuAddNewItem.AjaxEvents.Click.AjaxEventTargetControlID = Page.AnalyticsMenu.ClientID;
				Page.AnalyticsMenu.Menu.Add(menuAddNewItem);
				script = string.Format("window.{0} = {1};\n", menuAddNewItem.ClientID, menuAddNewItem.GenerateControlScript(true, null));
				script += string.Format("{0}.menu.addItem(window.{1});\n", Page.AnalyticsMenu.ClientID, menuAddNewItem.ClientID);
				Page.AddScript(script);
			}
			var codes = new List<string>();
			codes.Add("Chart");
			codes.Add("Report");
			foreach (var code in codes) {
				var elements = GetAnalyticsElements(code);
				if (elements.Count > 0) {
					var separatorCaption = code == "Chart" ? ChartCaption : ReportCaption;
					var separator = CreateMenuSeparator(separatorCaption);
					if (Ext.IsAjaxRequest) {	
						script = string.Format("window.{0} = {1};\n", separator.ClientID, separator.GenerateControlScript(true, null));
						script += string.Format("{0}.menu.addItem(window.{1});\n", Page.AnalyticsMenu.ClientID, separator.ClientID);
						Page.AddScript(script);
					}
					Page.AnalyticsMenu.Menu.Add(separator);
					foreach (var element in elements) {
						var menuItem = CreateMenuItem(element.Item3, element.Item1.ToString(), element.Item2.ToString(), code);
						Page.AnalyticsMenu.Menu.Add(menuItem);
						if (Ext.IsAjaxRequest) {
							script = string.Format("window.{0} = {1};\n", menuItem.ClientID, menuItem.GenerateControlScript(true, null));
							script += string.Format("{0}.menu.addItem(window.{1});\n", Page.AnalyticsMenu.ClientID, menuItem.ClientID);
							Page.AddScript(script);
						}
						if (IsModuleProcessesTuningMode) {			
							script = string.Format("{0}.menu = new Ext.menu.Menu({{id:Ext.id()}});\n", menuItem.ClientID);
							var editMenuItem = new WebControls.MenuItem();		
							editMenuItem.CreatedByAjax = true;
							editMenuItem.EnableViewState = false;
							editMenuItem.UId = Guid.NewGuid();
							editMenuItem.Enabled = code == "Chart";
							editMenuItem.Name = "editProcess_" + element.Item1.ToString("N");
							editMenuItem.Tag = element.Item1.ToString();
							editMenuItem.Caption = EditCaption.Value;
							editMenuItem.Image = new ControlImage {};
							editMenuItem.AjaxEvents.Click.SignalName = string.Format("Edit{0}MenuItemClick", code);
							editMenuItem.AjaxEvents.Click.AjaxEventTargetControlID = Page.AnalyticsMenu.ClientID;
							menuItem.Menu.Add(editMenuItem);
							script += string.Format("window.{0} = {1};\n", editMenuItem.ClientID, editMenuItem.GenerateControlScript(true, null));
							script += string.Format("{0}.menu.addItem(window.{1});\n", menuItem.ClientID, editMenuItem.ClientID);
							var deleteMenuItem = new WebControls.MenuItem();
							deleteMenuItem.CreatedByAjax = true;
							deleteMenuItem.EnableViewState = false;
							deleteMenuItem.UId = Guid.NewGuid();
							deleteMenuItem.Name = "deleteProcess_" + element.Item1.ToString("N");
							deleteMenuItem.Tag = element.Item1.ToString();
							deleteMenuItem.Caption = DeleteCaption.Value;	
							deleteMenuItem.Image = new ControlImage {};
							deleteMenuItem.AjaxEvents.Click.SignalName = string.Format("Delete{0}MenuItemClick", code);
							menuItem.Menu.Add(deleteMenuItem);
							deleteMenuItem.AjaxEvents.Click.AjaxEventTargetControlID = Page.AnalyticsMenu.ClientID;
							script += string.Format("window.{0} = {1};\n", deleteMenuItem.ClientID, deleteMenuItem.GenerateControlScript(true, null));
							script += string.Format("{0}.menu.addItem(window.{1});\n", menuItem.ClientID, deleteMenuItem.ClientID);
							Page.AddScript(script);			
						}
					}
				}
			}
		}

		public virtual List<Tuple<Guid, Guid, string>> GetAnalyticsElements(string code) {
			if (code == "Chart") {
				return GetChartList();
			}
			if (code == "Report") {
				return GetReportList();
			}
			else return null;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ClearSearchButtonClick":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "searchTextEditChange":
							if (ActivatedEventElements.Contains("ReSearchMessage")) {
							context.QueueTasks.Enqueue("ReSearchMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadComplete")) {
							context.QueueTasks.Enqueue("PageLoadComplete");
						}
						break;
					case "TuningModeChanged":
							if (ActivatedEventElements.Contains("StartTuningModeChanged")) {
							context.QueueTasks.Enqueue("StartTuningModeChanged");
						}
						break;
					case "ReportMenuItemClick":
							if (ActivatedEventElements.Contains("ReportMenuItemClickMessage")) {
							context.QueueTasks.Enqueue("ReportMenuItemClickMessage");
						}
						break;
					case "ChartMenuItemClick":
							if (ActivatedEventElements.Contains("ChartMenuItemClickMessage")) {
							context.QueueTasks.Enqueue("ChartMenuItemClickMessage");
						}
						break;
					case "CreateNewChartMenuItemClick":
							if (ActivatedEventElements.Contains("CreateNewChartMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("CreateNewChartMenuItemClickStartMessage");
						}
						break;
					case "ChartPropertyEditClosedMessage":
					if (ActivatedEventElements.Remove("ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent");
					}
					break;
					case "EditChartMenuItemClick":
							if (ActivatedEventElements.Contains("EditChartMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("EditChartMenuItemClickStartMessage");
						}
						break;
					case "DeleteChartMenuItemClick":
							if (ActivatedEventElements.Contains("DeleteChartMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("DeleteChartMenuItemClickStartMessage");
						}
						break;
					case "YesDeleteCustomChartMessage":
					if (ActivatedEventElements.Remove("YesDeleteCustomChartMessageIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("YesDeleteCustomChartMessageIntermediateCatchMessageEvent");
					}
					break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("ChartDeleteId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ChartDeleteId", ChartDeleteId, Guid.Empty);
			}
			if (!HasMapping("IsModuleProcessesTuningMode") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsModuleProcessesTuningMode", IsModuleProcessesTuningMode, false);
			}
			if (CustomChartIdList != null) {
				if (CustomChartIdList.GetType().IsSerializable ||
					CustomChartIdList.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("CustomChartIdList", CustomChartIdList, null);
				}
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("SerializedFilters") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SerializedFilters", SerializedFilters, null);
			}
			if (!HasMapping("ListenerPageProcessUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ListenerPageProcessUId", ListenerPageProcessUId, null);
			}
			if (SelectedActiveRows != null) {
				if (SelectedActiveRows.GetType().IsSerializable ||
					SelectedActiveRows.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("SelectedActiveRows", SelectedActiveRows, null);
				}
			}
			if (!HasMapping("SysModuleId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SysModuleId", SysModuleId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsGridPageEventsProcess

	/// <exclude/>
	public class AnalyticsGridPageEventsProcess : AnalyticsGridPageEventsProcess<Terrasoft.WebApp.AnalyticsGridPageSchemaUserControl>
	{

		public AnalyticsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AnalyticsGridPageSchemaUserControl

	/// <exclude/>
	public partial class AnalyticsGridPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout searchElementsLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("searchElementsLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit searchTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("searchTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ToolButton ClearSearchButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.ToolButton)PageContainer.FindPageControl("ClearSearchButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuPanel AnalyticsMenu {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuPanel)PageContainer.FindPageControl("AnalyticsMenu", true);
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
			searchTextEdit.AjaxEvents.Change.Event += searchTextEditChange;
			ClearSearchButton.AjaxEvents.Click.Event += ClearSearchButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			searchTextEdit.AjaxEvents.Change.Event -= searchTextEditChange;
			ClearSearchButton.AjaxEvents.Click.Event -= ClearSearchButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (AnalyticsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new AnalyticsGridPageEventsProcess(UserConnection);
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

		public virtual void searchTextEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("searchTextEditChange");
		}

		public virtual void ClearSearchButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("ClearSearchButtonClick");
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
			SchemaName = "AnalyticsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: AnalyticsGridPageEventsProcessSchema

	/// <exclude/>
	public class AnalyticsGridPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public AnalyticsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AnalyticsGridPageEventsProcessSchema(AnalyticsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AnalyticsGridPageEventsProcess";
			UId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7");
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
			UId = new Guid("3f23dafc-3464-4e9a-9367-ec093f6dff02"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"SysModuleId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSelectedActiveRowsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8ea44e1d-6c28-4bd5-b92e-c344c84a952e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"SelectedActiveRows",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateListenerPageProcessUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("85b860cc-1760-4c7a-862a-a50acb22f753"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ListenerPageProcessUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSerializedFiltersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1e408c61-0f70-46cd-91be-6083d95a9657"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"SerializedFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f0b0ab37-05c4-48cc-8c32-2b870d7d445e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCustomChartIdListParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c42efffb-d42b-4e19-b066-fcc291895fd7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"CustomChartIdList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsModuleProcessesTuningModeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2b3533c9-c03c-4e38-a49c-a1e47823e7f2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"IsModuleProcessesTuningMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChartDeleteIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7aa1c3df-9727-4069-b91d-2eb445367d85"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ChartDeleteId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSysModuleIdParameter());
			Parameters.Add(CreateSelectedActiveRowsParameter());
			Parameters.Add(CreateListenerPageProcessUIdParameter());
			Parameters.Add(CreateSerializedFiltersParameter());
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateCustomChartIdListParameter());
			Parameters.Add(CreateIsModuleProcessesTuningModeParameter());
			Parameters.Add(CreateChartDeleteIdParameter());
		}

		protected virtual void InitializeOpenReportUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9f025f2d-e52c-4965-b16b-d6f5bfcb6a05"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3cbdd803-8a56-4028-8227-411b533c524a"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9d2502f5-7d3b-405c-973c-2d8ec969e198"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("95311f2c-8b59-49d3-b83e-3221a374f7ab"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("fe32091c-5c95-406f-a610-38835fb0b717"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0effa7e7-9828-4cb0-9297-77e20c352a95"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("97a52e30-0a29-453e-9d91-bba0485a9d82"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("dac179f0-b6ca-457e-8d2e-7b2d70a2ce51"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c09bf3e5-b2f5-4e5a-999a-3ffbfa2ed374"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e8b21ede-4325-42d8-a712-1c67daee53ea"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7d200946-f09c-4aa1-9b90-2ef947919cda"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0004d82b-06bd-4312-995f-6ec44ecc8a1f"),
				ContainerUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeEditChartOpenPage_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("13064a9b-6e89-4e51-a3ca-86a1c0f62a40"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("81cf8263-237d-4bb5-a7c1-0bdb3ad99508"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e1d7e9fd-8191-4e99-95bc-5b40101c85cb"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2ae8cdf5-7f0f-4343-bf76-ec44466804e1"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b16f5a35-696a-47da-82d0-2ce1ac478977"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b51d541b-d54a-48e2-a492-00d274eb6ce2"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("66494b64-76bb-4dff-8414-c1829e4418c0"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("557eef17-8d50-425a-b865-915e16ea7c7a"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7251ae6f-697a-4b12-bcef-d419795e69bd"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("563bc29c-791b-4cca-a501-09bd8494c100"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a6239541-5141-438a-bf78-2193391b4d0d"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2833312b-97e7-4b16-a2dd-9a911dcbdb2a"),
				ContainerUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeDeleteCustomChartQuestion_UserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("bc8f0e21-138b-45a5-bc4f-16c1c4a13d14"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("27c29ab7-aa3f-4712-8dfc-1cf45beba7d0"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("33b3c2a3-84ae-4f1a-9697-27727752b503"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("26218278-5cb4-470f-a464-137de2d4e97a"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("13c7cefc-5ef3-40fd-bca2-b25548d6469e"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("16cda64a-3c0c-4f23-a463-0bbae0250905"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("bed9da02-51fa-4cca-bac3-869b8d680b6d"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("14abcbf7-bd9b-41fd-9d7d-0904b4fec0bc"),
				ContainerUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet68 = CreateLaneSet68LaneSet();
			LaneSets.Add(schemaLaneSet68);
			ProcessSchemaLane schemaLane177 = CreateLane177Lane();
			schemaLaneSet68.Lanes.Add(schemaLane177);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess subprocesspageloadcomplete = CreateSubProcessPageLoadCompleteEventSubProcess();
			FlowElements.Add(subprocesspageloadcomplete);
			ProcessSchemaEventSubProcess switchtuningmodeeventsubprocess = CreateSwitchTuningModeEventSubProcessEventSubProcess();
			FlowElements.Add(switchtuningmodeeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocessmenuitemclick = CreateEventSubProcessMenuItemClickEventSubProcess();
			FlowElements.Add(eventsubprocessmenuitemclick);
			ProcessSchemaEventSubProcess createupdatedeletechartmenuitemclickeventsubprocess = CreateCreateUpdateDeleteChartMenuItemClickEventSubProcessEventSubProcess();
			FlowElements.Add(createupdatedeletechartmenuitemclickeventsubprocess);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scriptclearsearchbuttonclick = CreateScriptClearSearchButtonClickScriptTask();
			eventsubprocess1.FlowElements.Add(scriptclearsearchbuttonclick);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaStartMessageEvent researchmessage = CreateReSearchMessageStartMessageEvent();
			subprocess2.FlowElements.Add(researchmessage);
			ProcessSchemaScriptTask filterscript = CreateFilterScriptScriptTask();
			subprocess2.FlowElements.Add(filterscript);
			ProcessSchemaStartMessageEvent pageloadcomplete = CreatePageLoadCompleteStartMessageEvent();
			subprocesspageloadcomplete.FlowElements.Add(pageloadcomplete);
			ProcessSchemaScriptTask pageloadcompletescript = CreatePageLoadCompleteScriptScriptTask();
			subprocesspageloadcomplete.FlowElements.Add(pageloadcompletescript);
			ProcessSchemaStartMessageEvent starttuningmodechanged = CreateStartTuningModeChangedStartMessageEvent();
			switchtuningmodeeventsubprocess.FlowElements.Add(starttuningmodechanged);
			ProcessSchemaScriptTask switchtuningmode_scripttask = CreateSwitchTuningMode_ScriptTaskScriptTask();
			switchtuningmodeeventsubprocess.FlowElements.Add(switchtuningmode_scripttask);
			ProcessSchemaStartMessageEvent reportmenuitemclickmessage = CreateReportMenuItemClickMessageStartMessageEvent();
			eventsubprocessmenuitemclick.FlowElements.Add(reportmenuitemclickmessage);
			ProcessSchemaStartMessageEvent chartmenuitemclickmessage = CreateChartMenuItemClickMessageStartMessageEvent();
			eventsubprocessmenuitemclick.FlowElements.Add(chartmenuitemclickmessage);
			ProcessSchemaScriptTask reportmenuitemclickscript = CreateReportMenuItemClickScriptScriptTask();
			eventsubprocessmenuitemclick.FlowElements.Add(reportmenuitemclickscript);
			ProcessSchemaScriptTask chartmenuitemclickscript = CreateChartMenuItemClickScriptScriptTask();
			eventsubprocessmenuitemclick.FlowElements.Add(chartmenuitemclickscript);
			ProcessSchemaUserTask openreportusertask = CreateOpenReportUserTaskUserTask();
			eventsubprocessmenuitemclick.FlowElements.Add(openreportusertask);
			ProcessSchemaStartMessageEvent createnewchartmenuitemclickstartmessage = CreateCreateNewChartMenuItemClickStartMessageStartMessageEvent();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(createnewchartmenuitemclickstartmessage);
			ProcessSchemaScriptTask preparenewchartopenpage_scripttask = CreatePrepareNewChartOpenPage_ScriptTaskScriptTask();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(preparenewchartopenpage_scripttask);
			ProcessSchemaUserTask editchartopenpage_usertask = CreateEditChartOpenPage_UserTaskUserTask();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(editchartopenpage_usertask);
			ProcessSchemaIntermediateCatchMessageEvent chartpropertyeditclosedmessage_intermediatecatchmessageevent = CreateChartPropertyEditClosedMessage_IntermediateCatchMessageEventIntermediateCatchMessageEvent();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(chartpropertyeditclosedmessage_intermediatecatchmessageevent);
			ProcessSchemaScriptTask prepareeditchartopenpage_scripttask = CreatePrepareEditChartOpenPage_ScriptTaskScriptTask();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(prepareeditchartopenpage_scripttask);
			ProcessSchemaStartMessageEvent editchartmenuitemclickstartmessage = CreateEditChartMenuItemClickStartMessageStartMessageEvent();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(editchartmenuitemclickstartmessage);
			ProcessSchemaStartMessageEvent deletechartmenuitemclickstartmessage = CreateDeleteChartMenuItemClickStartMessageStartMessageEvent();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(deletechartmenuitemclickstartmessage);
			ProcessSchemaScriptTask preparedeletecustomchart_scripttask = CreatePrepareDeleteCustomChart_ScriptTaskScriptTask();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(preparedeletecustomchart_scripttask);
			ProcessSchemaUserTask deletecustomchartquestion_usertask = CreateDeleteCustomChartQuestion_UserTaskUserTask();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(deletecustomchartquestion_usertask);
			ProcessSchemaIntermediateCatchMessageEvent yesdeletecustomchartmessageintermediatecatchmessageevent = CreateYesDeleteCustomChartMessageIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(yesdeletecustomchartmessageintermediatecatchmessageevent);
			ProcessSchemaScriptTask deletecustomchart_scripttask = CreateDeleteCustomChart_ScriptTaskScriptTask();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(deletecustomchart_scripttask);
			ProcessSchemaScriptTask refreshanalyticsmenuscript = CreateRefreshAnalyticsMenuScriptScriptTask();
			createupdatedeletechartmenuitemclickeventsubprocess.FlowElements.Add(refreshanalyticsmenuscript);
			FlowElements.Add(CreateSequenceFlow556SequenceFlow());
			FlowElements.Add(CreateSequenceFlow558SequenceFlow());
			FlowElements.Add(CreateSequenceFlow559SequenceFlow());
			FlowElements.Add(CreateSequenceFlow560SequenceFlow());
			FlowElements.Add(CreateSequenceFlow561SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCreateNewChartMenuItemCaptionLocalizableString());
			LocalizableStrings.Add(CreateEditCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteCaptionLocalizableString());
			LocalizableStrings.Add(CreateDeleteChartMessageLocalizableString());
			LocalizableStrings.Add(CreateReportCaptionLocalizableString());
			LocalizableStrings.Add(CreateChartCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCreateNewChartMenuItemCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("67bd7ffd-de8e-4705-bdc3-98d2f1b76ff0"),
				Name = "CreateNewChartMenuItemCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cd605566-8de1-40a6-864a-9a6201f71a36"),
				Name = "EditCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5a6af9f7-cf8c-4fd4-bf89-4860ff133b66"),
				Name = "DeleteCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteChartMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fd92027e-7a7e-408d-8e57-fc9a9c91d4b7"),
				Name = "DeleteChartMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateReportCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1f6e4cf0-0459-45d4-afe0-ed3c2f61e3d4"),
				Name = "ReportCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateChartCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f0bc10b7-bc38-4438-aa17-104ca856e39b"),
				Name = "ChartCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow556SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow556",
				UId = new Guid("d461bcf6-e7c7-4436-8f19-cc41716ade74"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(171, 299),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c6ab385-1208-4d8d-86ba-d8f3b3db7a6c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6843a7a2-96ae-4a8c-833d-09e5bc8987c6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow558SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow558",
				UId = new Guid("f77a0596-398d-4e4e-9378-114782942918"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(568, 290),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("554d8f20-270a-4016-90da-255453a59e67"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow559SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow559",
				UId = new Guid("b0465b70-6aab-41f3-9150-d8d5ca475603"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(808, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9c54e541-90c9-4e3d-839e-fe947d49a2b3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("81b1f897-b124-47e2-a368-ee1a7520c832"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow560SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow560",
				UId = new Guid("c88fe9d5-a5a8-408d-b965-001927b41d09"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dd7f4d1c-e10e-480f-b0ce-2ecc19cc3d0c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7788e967-8545-4ec3-91e7-574090dd7cf4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow561SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow561",
				UId = new Guid("4b0ecaec-85d0-4189-954b-cfdba8232e72"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(304, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7788e967-8545-4ec3-91e7-574090dd7cf4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ea8297f3-e095-4eee-b9c7-fccc6fef2870"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c6bb8ab6-9750-4021-bfb4-2f2501ee4310"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(176, 658),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f2062f5a-8112-4f2c-b8d0-e0235b16f33b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("50faf986-a28d-4f8a-92cf-955a40cb7451"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("de445a35-4e51-4d8b-9a49-3e0867fc466e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(278, 662),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("50faf986-a28d-4f8a-92cf-955a40cb7451"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("a7441bec-ec37-4a31-9cbf-711f51ced54c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(174, 836),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("59ed4915-cbd9-4d99-819c-2bffa228fac1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fc1058c6-8ed8-4d16-93e5-42587ef5f4db"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("30730a33-62c7-4a65-a24f-216f0799acc1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(170, 1008),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("50466cce-6027-4271-9e90-1e7d3bc5b02d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f49c22b-d60d-497e-a173-2214aaa62dcc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("6168eb70-d5a4-4b65-8827-90c14ac42ed3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(303, 1184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4f49c22b-d60d-497e-a173-2214aaa62dcc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("68a1d022-d4b0-4d8a-9e54-ef911034d48c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(410, 1182),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ef05a33-d102-4ecf-81ac-49a1a2082d0f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("864833d8-dce8-4193-875d-286c4f37ea0c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(498, 1187),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ef05a33-d102-4ecf-81ac-49a1a2082d0f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7a6e8347-57f6-47d4-82e3-d3d6e13a3bb5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("de5e6a2b-fb4d-4770-9331-e920ee3944f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(178, 631),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4907062e-17bc-4d37-84b1-11fbb1dbf2e9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eafbc23c-3be5-424c-957a-50ad9d1df3c8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("316c221c-7c74-4752-b2c8-c45d88aa6c28"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(481, 732),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d630ae70-7d54-4aaf-83d6-973b3fc615b1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("245546fe-4d1e-42af-b7f5-66b85c25b4fe"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("877b0589-9bb9-45e0-8745-6c678fdefa36"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(472, 617),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e244c58e-e605-450e-8a5b-81f2f4f5f15e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("554d8f20-270a-4016-90da-255453a59e67"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("f795f5a7-9d29-4bf5-b287-d79d163ef3b9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(314, 896),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc1058c6-8ed8-4d16-93e5-42587ef5f4db"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("67b85dbb-d707-4eee-b9f4-e0c9fcc98bce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(485, 812),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("805a26e7-8f4c-4f2a-a0fa-ae0be56935ff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("e7e4a780-0161-4751-adf6-12ed00f4c760"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(634, 1173),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a6e8347-57f6-47d4-82e3-d3d6e13a3bb5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fd02529e-93f4-4b46-bcd1-7a02a269ec64"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("bfbfdace-54e1-4f19-86ce-cdb79dd92d5d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CurveCenterPosition = new Point(612, 992),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("805a26e7-8f4c-4f2a-a0fa-ae0be56935ff"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fd02529e-93f4-4b46-bcd1-7a02a269ec64"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet68LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet68 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("23585c84-fec7-48df-8ae5-58b4f4d3f95f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"LaneSet68",
				Position = new Point(5, 5),
				Size = new Size(1157, 164),
				UseBackgroundMode = false
			};
			return schemaLaneSet68;
		}

		protected virtual ProcessSchemaLane CreateLane177Lane() {
			ProcessSchemaLane schemaLane177 = new ProcessSchemaLane(this) {
				UId = new Guid("175deb81-9a22-4532-9f6b-4c835d2960cf"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("23585c84-fec7-48df-8ae5-58b4f4d3f95f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"Lane177",
				Position = new Point(29, 0),
				Size = new Size(1128, 164),
				UseBackgroundMode = false
			};
			return schemaLane177;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("913f91a1-8c29-4b63-a071-eb3b212082bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("175deb81-9a22-4532-9f6b-4c835d2960cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(348, 143),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dd7f4d1c-e10e-480f-b0ce-2ecc19cc3d0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("913f91a1-8c29-4b63-a071-eb3b212082bf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ClearSearchButtonClick",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"StartMessage1",
				Position = new Point(22, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptClearSearchButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7788e967-8545-4ec3-91e7-574090dd7cf4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("913f91a1-8c29-4b63-a071-eb3b212082bf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ScriptClearSearchButtonClick",
				Position = new Point(141, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,43,78,77,44,74,206,8,73,173,40,113,77,201,44,209,3,49,20,108,21,138,75,138,50,243,210,245,92,115,11,74,42,173,185,2,176,40,116,203,79,46,45,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,98,199,69,179,82,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ea8297f3-e095-4eee-b9c7-fccc6fef2870"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("913f91a1-8c29-4b63-a071-eb3b212082bf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"searchTextEditChange",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("01ec06a6-ff66-4d8c-b1a0-7bd5f7c7a28e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("175deb81-9a22-4532-9f6b-4c835d2960cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"SubProcess2",
				Position = new Point(36, 192),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(254, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateReSearchMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4c6ab385-1208-4d8d-86ba-d8f3b3db7a6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("01ec06a6-ff66-4d8c-b1a0-7bd5f7c7a28e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"searchTextEditChange",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ReSearchMessage",
				Position = new Point(35, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFilterScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6843a7a2-96ae-4a8c-833d-09e5bc8987c6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("01ec06a6-ff66-4d8c-b1a0-7bd5f7c7a28e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"FilterScript",
				Position = new Point(147, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,207,107,194,48,20,62,183,208,255,33,235,197,134,185,48,207,197,131,184,10,131,13,6,238,216,75,136,175,46,208,38,93,242,234,20,233,255,190,196,86,172,155,221,78,9,121,223,203,247,131,111,199,13,177,192,141,248,120,135,61,146,57,121,227,91,96,151,151,108,35,145,249,75,26,133,178,32,137,69,35,213,150,101,85,141,7,150,125,54,188,180,201,5,77,41,57,70,97,16,156,62,89,108,54,107,97,100,141,231,165,149,54,21,199,36,62,62,182,204,64,165,119,176,146,37,130,73,104,26,79,59,226,133,226,229,1,165,176,175,160,26,182,44,37,40,124,126,162,212,177,183,36,10,161,180,112,98,232,126,36,197,105,127,213,40,225,148,199,133,59,81,106,149,72,132,202,41,201,85,236,246,130,1,232,222,161,188,11,15,32,82,89,228,74,128,46,72,182,71,86,121,198,53,212,220,112,212,102,116,221,0,54,70,145,194,25,135,180,189,129,232,205,46,181,18,252,151,245,28,207,244,76,240,218,139,101,168,95,244,23,152,37,183,144,208,62,249,100,226,50,154,92,143,40,185,155,147,135,25,117,81,13,2,159,146,216,11,245,1,5,63,165,230,152,99,47,23,77,3,233,109,67,30,213,146,46,217,113,196,149,237,49,88,123,123,112,126,254,191,21,22,176,175,196,113,214,82,207,243,103,47,166,131,2,116,29,137,194,161,225,111,35,3,56,255,221,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPageLoadCompleteEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPageLoadComplete = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4ab4abc7-c82d-4eb2-be87-5bbec79b281d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("175deb81-9a22-4532-9f6b-4c835d2960cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"SubProcessPageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 380),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(236, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPageLoadComplete;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9c54e541-90c9-4e3d-839e-fe947d49a2b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ab4abc7-c82d-4eb2-be87-5bbec79b281d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"PageLoadComplete",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("81b1f897-b124-47e2-a368-ee1a7520c832"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4ab4abc7-c82d-4eb2-be87-5bbec79b281d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"PageLoadCompleteScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,83,219,48,16,61,135,25,254,131,234,147,61,165,34,119,74,7,8,1,60,83,218,180,14,112,232,244,32,236,77,172,86,150,92,125,0,105,135,255,222,149,236,224,16,155,129,67,38,178,180,251,222,243,219,213,122,198,150,64,39,2,152,206,240,151,151,39,206,90,37,233,5,47,32,78,14,118,119,102,195,231,105,229,247,51,229,116,14,228,144,204,65,107,102,212,194,210,171,148,222,192,237,68,73,171,149,48,180,93,132,240,38,154,126,7,19,22,151,76,226,166,126,141,99,43,252,11,171,60,97,244,18,99,244,86,188,212,66,181,6,179,74,137,219,16,244,33,23,202,0,93,242,133,7,186,99,154,128,180,220,174,178,188,132,138,125,115,160,87,152,32,225,158,76,183,247,227,43,3,26,101,72,200,45,71,186,205,128,86,252,30,137,178,149,185,84,133,19,16,121,119,247,247,123,240,116,194,240,1,73,182,224,50,48,6,255,195,41,189,225,182,252,172,114,38,252,35,151,203,216,67,141,140,213,184,166,103,74,87,204,198,243,12,179,23,124,233,52,11,0,33,243,202,114,193,45,7,67,27,21,167,204,178,112,112,174,149,171,247,200,147,188,180,72,188,192,55,203,59,174,107,193,243,192,244,162,196,209,43,146,110,148,254,109,106,150,67,167,40,105,171,80,181,162,206,56,136,2,217,251,186,142,139,98,162,132,171,100,28,165,69,180,206,43,65,212,190,53,224,193,190,49,249,98,51,35,26,246,224,140,11,11,218,248,180,120,192,33,13,204,66,19,227,93,152,49,141,125,230,19,226,102,115,162,170,154,105,110,148,156,175,106,160,211,63,142,9,108,13,164,235,23,192,191,132,89,239,161,70,209,248,61,248,22,231,96,155,166,235,226,182,154,210,35,242,5,137,7,16,241,170,58,105,201,187,67,50,78,200,63,44,150,103,174,177,107,189,25,140,75,208,200,137,77,181,121,187,187,117,18,238,220,108,51,252,96,160,224,215,56,86,148,119,184,43,122,6,182,131,241,71,51,173,106,208,254,44,126,70,191,71,16,112,52,160,252,199,248,167,127,117,239,101,91,197,107,38,28,124,108,174,195,167,184,223,3,212,95,252,132,188,39,209,120,60,70,211,251,38,61,238,238,164,18,5,50,193,255,66,155,236,197,53,163,36,76,198,19,199,69,113,9,210,117,115,210,132,113,51,199,216,105,193,45,61,254,197,30,166,119,88,39,156,131,37,147,24,240,85,78,4,199,141,176,139,126,30,69,241,194,201,166,82,157,235,207,97,252,128,66,169,67,4,13,88,122,138,199,71,126,94,133,236,124,123,240,109,2,244,167,98,15,35,244,199,115,158,37,216,96,105,156,80,1,114,105,75,114,248,212,38,163,30,31,45,215,31,143,209,35,1,97,224,165,56,83,170,251,54,14,29,79,226,100,119,199,43,208,96,157,150,196,106,7,7,255,1,212,214,192,178,159,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSwitchTuningModeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSwitchTuningModeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5d1e6cc5-2b8f-4431-b210-c8525d4f802e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("175deb81-9a22-4532-9f6b-4c835d2960cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"SwitchTuningModeEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 542),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(263, 155),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSwitchTuningModeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartTuningModeChangedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4907062e-17bc-4d37-84b1-11fbb1dbf2e9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d1e6cc5-2b8f-4431-b210-c8525d4f802e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"TuningModeChanged",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"StartTuningModeChanged",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSwitchTuningMode_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eafbc23c-3be5-424c-957a-50ad9d1df3c8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d1e6cc5-2b8f-4431-b210-c8525d4f802e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"SwitchTuningMode_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,42,205,204,73,241,77,205,43,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,208,97,241,94,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessMenuItemClickEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessMenuItemClick = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ce550b20-03bf-4448-8e7d-b262f7193c5d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("175deb81-9a22-4532-9f6b-4c835d2960cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"EventSubProcessMenuItemClick",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(323, 380),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(490, 253),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessMenuItemClick;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateReportMenuItemClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e244c58e-e605-450e-8a5b-81f2f4f5f15e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce550b20-03bf-4448-8e7d-b262f7193c5d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ReportMenuItemClick",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ReportMenuItemClickMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChartMenuItemClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d630ae70-7d54-4aaf-83d6-973b3fc615b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce550b20-03bf-4448-8e7d-b262f7193c5d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ChartMenuItemClick",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ChartMenuItemClickMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 168),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateReportMenuItemClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("554d8f20-270a-4016-90da-255453a59e67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce550b20-03bf-4448-8e7d-b262f7193c5d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ReportMenuItemClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,147,65,111,218,64,16,133,207,32,241,31,182,190,196,72,96,149,22,21,80,219,72,45,69,169,165,164,160,66,212,3,226,176,181,7,179,141,89,91,187,99,40,74,249,239,157,245,26,108,18,195,5,120,126,243,237,236,155,177,88,51,247,141,70,37,100,228,249,250,71,22,199,83,53,217,166,120,112,239,133,70,144,160,102,60,130,153,74,2,208,250,209,15,219,109,246,220,106,54,118,92,177,212,138,236,51,123,212,160,198,137,148,16,160,72,164,231,23,246,137,140,132,4,239,14,176,16,190,30,136,112,13,252,145,176,5,210,91,108,84,178,159,236,64,162,123,146,124,137,160,36,143,233,28,132,191,216,97,206,79,72,19,133,15,32,51,31,97,59,142,69,240,228,24,202,177,213,52,237,145,73,241,25,87,124,107,90,12,108,89,133,252,69,69,154,113,205,190,137,188,107,174,14,159,108,14,29,150,252,254,67,87,185,37,150,85,24,242,136,24,21,226,210,33,201,89,121,139,100,158,59,220,246,217,188,92,49,149,119,118,62,155,172,222,60,141,5,186,55,255,110,140,209,180,87,120,20,236,4,236,77,20,148,1,121,37,236,217,93,38,66,215,25,4,33,7,62,28,118,3,62,236,117,251,189,81,216,29,241,193,160,27,188,235,13,251,235,247,65,111,244,161,239,156,104,41,1,230,193,6,182,252,129,75,250,173,8,101,160,158,21,189,139,103,20,250,78,132,160,204,100,10,201,117,102,47,9,103,54,132,2,203,167,4,126,117,152,1,249,82,35,151,1,216,25,215,221,174,109,210,46,65,68,159,166,32,237,20,205,6,45,184,126,242,140,4,234,4,203,35,57,253,33,68,125,77,153,94,221,177,231,132,104,26,64,59,100,38,194,90,77,150,127,76,220,53,11,96,191,111,243,85,111,52,158,139,85,179,125,19,210,233,92,140,120,249,118,117,236,20,206,105,106,88,229,45,107,220,189,210,61,145,40,240,80,117,190,80,42,11,118,60,245,124,188,158,194,172,122,201,242,198,245,5,191,68,136,27,179,214,23,243,181,114,125,197,119,16,209,6,95,151,88,189,190,102,12,230,197,5,51,29,84,25,92,49,197,137,6,59,250,169,188,79,184,113,175,121,172,141,93,1,102,74,218,226,255,186,18,94,216,174,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateChartMenuItemClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("245546fe-4d1e-42af-b7f5-66b85c25b4fe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce550b20-03bf-4448-8e7d-b262f7193c5d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ChartMenuItemClickScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 154),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,205,205,10,130,64,20,134,225,117,66,247,48,185,82,136,185,1,105,147,72,12,244,227,34,47,96,176,147,14,141,103,228,204,25,75,162,123,207,200,150,109,95,62,158,207,92,69,178,242,76,6,27,169,252,49,88,123,162,162,235,121,76,246,198,51,32,80,169,27,40,201,213,224,125,165,46,105,42,158,203,104,49,104,18,253,55,138,141,168,60,80,238,16,161,102,227,80,170,121,94,96,99,16,228,14,120,14,219,113,18,254,193,217,196,206,164,60,183,228,238,197,0,200,201,47,41,100,32,212,118,250,97,120,240,90,196,121,171,137,15,128,65,49,116,185,53,245,45,254,32,175,101,68,192,129,80,48,5,200,222,188,144,64,163,225,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenReportUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2f536b14-ac28-40f6-b8cf-96992422b119"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ce550b20-03bf-4448-8e7d-b262f7193c5d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"OpenReportUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(308, 42),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenReportUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCreateUpdateDeleteChartMenuItemClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCreateUpdateDeleteChartMenuItemClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("175deb81-9a22-4532-9f6b-4c835d2960cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"CreateUpdateDeleteChartMenuItemClickEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 723),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(685, 414),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCreateUpdateDeleteChartMenuItemClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCreateNewChartMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f2062f5a-8112-4f2c-b8d0-e0235b16f33b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CreateNewChartMenuItemClick",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"CreateNewChartMenuItemClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareNewChartOpenPage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("50faf986-a28d-4f8a-92cf-955a40cb7451"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"PrepareNewChartOpenPage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,95,79,242,48,20,198,175,33,225,59,52,187,146,132,45,115,12,7,241,79,178,181,211,112,161,146,160,239,141,49,166,239,122,212,41,116,228,172,195,16,194,119,183,237,6,194,27,195,219,155,174,221,115,206,249,61,231,116,201,145,100,239,28,85,42,114,53,225,111,64,46,137,132,47,114,83,229,226,196,9,6,126,20,71,73,223,237,51,70,221,112,16,5,110,28,245,35,55,164,254,233,32,165,204,79,2,234,116,207,59,237,229,54,205,4,139,5,160,90,165,82,229,106,53,22,58,157,51,100,49,59,13,251,161,155,36,129,239,134,241,245,200,29,14,99,230,178,100,148,248,163,192,63,187,142,83,71,39,49,8,212,36,185,95,128,52,44,47,143,37,224,3,47,63,61,115,122,180,217,14,96,155,202,2,94,255,240,89,5,165,85,24,116,239,14,190,172,133,238,191,146,198,31,203,51,149,23,146,227,138,92,148,10,115,249,214,35,197,223,15,200,212,149,141,217,233,189,88,232,70,220,22,162,154,193,52,123,135,57,31,11,167,71,106,127,245,133,6,51,33,6,200,51,196,180,144,18,108,122,111,10,101,169,119,198,21,127,218,163,244,30,138,169,45,122,210,125,214,64,187,63,13,236,130,35,159,131,2,52,180,164,211,38,118,29,98,239,168,235,253,138,172,183,186,122,173,29,132,172,64,97,105,109,75,210,249,66,173,246,42,111,122,157,118,171,213,90,59,112,232,69,235,127,29,229,78,191,103,68,107,127,183,181,217,210,108,254,63,216,201,190,221,31,239,199,3,245,7,173,16,53,123,172,91,178,132,230,237,42,172,224,120,160,185,1,28,203,82,113,153,129,125,49,219,131,54,127,60,150,206,138,18,110,245,76,235,98,14,61,232,147,137,51,2,209,40,204,155,70,80,21,202,26,235,27,45,173,224,213,108,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateEditChartOpenPage_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f89f6539-eb2c-496c-83d8-86074e523400"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"EditChartOpenPage_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(295, 56),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeEditChartOpenPage_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateChartPropertyEditClosedMessage_IntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("805a26e7-8f4c-4f2a-a0fa-ae0be56935ff"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"ChartPropertyEditClosedMessage",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"ChartPropertyEditClosedMessage_IntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(456, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareEditChartOpenPage_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fc1058c6-8ed8-4d16-93e5-42587ef5f4db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"PrepareEditChartOpenPage_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 175),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,91,111,218,48,20,199,159,65,226,59,88,126,106,37,18,165,33,52,160,109,149,114,235,196,67,55,36,104,95,170,106,242,146,51,200,70,109,116,236,192,16,226,187,207,206,133,38,85,197,252,98,251,248,127,142,127,231,178,99,72,224,175,66,54,103,200,94,37,249,66,82,193,149,182,216,203,53,138,125,178,3,174,2,92,73,194,36,137,243,84,229,130,51,60,124,150,10,115,190,26,18,241,243,55,164,234,238,211,160,95,89,8,66,42,48,155,101,58,80,43,236,51,85,108,69,95,236,165,88,148,178,171,107,237,177,211,95,167,107,134,42,201,114,53,103,43,208,62,28,246,228,107,145,103,87,212,29,59,126,224,135,35,107,20,199,145,229,141,125,215,10,252,145,111,121,145,115,51,78,162,216,9,221,136,118,194,204,81,108,1,213,33,225,42,87,135,18,129,78,226,32,190,241,70,158,21,134,174,99,121,193,253,212,154,76,130,216,138,195,105,232,76,93,231,246,62,72,168,14,98,16,34,19,228,251,22,184,97,249,241,40,1,151,76,254,177,205,237,177,140,214,129,173,127,206,224,215,19,219,20,32,75,133,65,183,191,193,190,76,225,250,189,164,206,239,173,140,228,125,29,75,159,179,222,14,50,93,136,7,145,21,27,88,164,107,120,101,179,140,14,73,149,95,101,208,96,198,197,0,217,134,56,18,156,67,25,222,94,128,148,122,143,153,98,207,45,202,86,15,94,52,208,249,165,134,221,154,126,129,2,52,180,100,208,39,229,234,98,159,169,171,253,142,28,27,93,181,142,180,153,2,77,219,28,79,195,65,191,215,235,29,41,116,241,181,228,195,238,157,245,45,118,173,253,56,147,83,3,112,186,220,75,125,136,10,68,51,211,58,153,29,212,83,167,176,128,255,15,193,188,93,154,183,58,93,118,52,22,192,25,151,138,241,20,202,33,105,46,58,249,203,190,209,70,72,120,208,109,172,40,105,212,169,147,241,51,130,172,86,152,49,70,80,5,242,42,159,127,110,7,237,120,218,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditChartMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("59ed4915-cbd9-4d99-819c-2bffa228fac1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EditChartMenuItemClick",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"EditChartMenuItemClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 189),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteChartMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("50466cce-6027-4271-9e90-1e7d3bc5b02d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DeleteChartMenuItemClick",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"DeleteChartMenuItemClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 315),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareDeleteCustomChart_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4f49c22b-d60d-497e-a173-2214aaa62dcc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"PrepareDeleteCustomChart_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 301),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,209,74,195,48,20,134,239,251,20,33,87,27,148,190,64,117,48,183,49,122,97,157,91,69,68,100,196,238,208,85,93,34,231,156,108,142,178,119,247,100,203,133,160,66,175,2,201,255,125,127,248,247,6,21,124,49,154,133,65,179,35,117,173,106,103,89,110,178,106,139,238,48,219,131,229,49,54,164,12,169,105,91,115,235,172,193,227,21,49,182,182,73,149,123,125,131,154,71,121,50,217,26,228,41,124,0,67,177,17,139,133,131,154,251,118,51,248,33,127,214,108,26,253,146,85,110,117,198,7,195,97,158,92,152,137,39,118,187,179,228,222,3,133,154,245,3,1,86,134,222,179,133,105,64,148,225,232,149,191,5,34,201,86,82,45,88,4,66,52,62,244,146,20,178,131,208,250,113,188,44,139,114,174,123,65,55,158,217,217,176,162,126,154,173,202,187,126,212,18,232,83,40,136,223,163,56,223,31,115,95,206,145,234,58,125,4,210,169,212,0,253,106,136,30,125,74,85,167,173,11,177,210,253,159,58,229,9,2,123,180,138,209,67,254,13,84,232,164,163,18,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateDeleteCustomChartQuestion_UserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7181026d-d4e4-4a70-a3bd-ebd5cb78dca3"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"DeleteCustomChartQuestion_UserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 301),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeDeleteCustomChartQuestion_UserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateYesDeleteCustomChartMessageIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("1ef05a33-d102-4ecf-81ac-49a1a2082d0f"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"YesDeleteCustomChartMessage",
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"YesDeleteCustomChartMessageIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 315),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteCustomChart_ScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7a6e8347-57f6-47d4-82e3-d3d6e13a3bb5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"DeleteCustomChart_ScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(449, 301),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,205,10,130,64,20,133,247,65,239,48,184,178,205,188,128,180,40,43,105,97,4,210,3,92,198,67,14,232,157,184,94,133,121,251,76,87,82,109,207,119,254,70,18,3,86,175,49,111,72,244,46,225,5,209,88,185,6,29,153,189,121,244,144,60,48,195,169,15,108,207,179,117,161,37,49,61,33,182,128,94,185,87,98,135,99,188,81,135,52,169,98,95,134,122,104,113,96,106,163,122,215,207,237,201,46,219,110,198,223,139,211,214,223,31,54,23,144,98,25,79,215,151,62,149,63,130,246,2,117,205,69,66,119,58,166,51,57,161,133,226,90,255,11,44,252,219,187,18,166,151,197,224,107,123,238,94,26,39,40,208,65,216,168,12,200,222,174,235,10,5,75,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateRefreshAnalyticsMenuScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fd02529e-93f4-4b46-bcd1-7a02a269ec64"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7e1e032b-4fc8-4aa9-a747-cf8504995cb5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Name = @"RefreshAnalyticsMenuScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(575, 301),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,139,49,14,194,64,12,4,123,36,254,64,25,26,127,32,21,137,16,21,29,17,245,233,178,1,139,211,217,242,217,18,207,135,92,183,179,154,89,26,108,150,90,145,157,165,210,69,181,112,78,251,158,83,126,131,174,95,101,195,205,36,116,120,192,44,53,217,156,254,197,198,175,176,46,82,55,23,231,194,206,104,244,20,251,52,77,25,253,239,233,121,60,30,166,224,178,222,81,99,216,201,224,97,245,228,22,24,127,132,194,162,200,132,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateMenuSeparatorMethod());
			Methods.Add(CreateCreateMenuItemMethod());
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
			Methods.Add(CreateGetChartListMethod());
			Methods.Add(CreateGetReportListMethod());
			Methods.Add(CreateBuildMenuMethod());
			Methods.Add(CreateGetAnalyticsElementsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6cd1550e-52d2-4ebd-9c10-914eb669b246"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("58c031a2-6969-4f07-a3f0-452b1916a29d"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d4170d1d-a410-4fec-9c8f-aadfed780678"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("df444669-aa1f-479c-9107-0f8bc9197e1f"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1af0154-23e8-4680-909c-34697ad4d9ab"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a65f3815-cb54-4b18-a54c-a859578ebd56"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c5029542-b7ab-4f41-bcb0-ed9a6d6110df"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateCreateMenuSeparatorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f63f894f-17ae-4f71-a183-50d2d1600035"),
				Name = "CreateMenuSeparator",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuSeparator"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("67c32d86-fa1d-4f5d-8869-3b434cadd77b"),
				Name = "MenuSeparatorCaption",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,65,75,195,64,16,133,207,246,87,44,57,69,12,75,21,180,135,210,67,140,181,246,96,47,169,122,148,137,59,13,43,155,221,48,153,52,22,241,191,187,214,80,13,219,158,102,120,124,243,134,247,182,64,162,66,219,230,88,3,1,59,18,51,97,177,19,107,36,130,198,109,88,62,45,229,11,22,153,179,76,206,52,242,176,60,254,191,138,207,167,163,179,129,143,191,83,222,107,209,106,37,87,216,253,204,35,208,242,206,51,81,250,198,122,171,121,119,208,95,35,113,33,2,59,185,118,57,147,182,101,28,173,162,208,43,35,4,70,117,187,75,223,225,195,219,50,181,24,64,115,11,133,193,103,141,93,206,158,246,216,6,76,19,114,25,212,172,157,157,137,65,204,94,61,69,103,206,236,11,220,79,121,79,174,74,169,44,226,113,114,149,76,38,201,229,245,205,145,2,42,40,177,239,188,175,246,87,250,252,10,191,56,99,160,110,180,15,112,42,222,131,86,10,237,95,42,66,110,201,14,171,156,126,3,208,225,142,245,244,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateMenuItemMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8b6ec873-3aea-44d2-af50-cd006ff1c0d6"),
				Name = "CreateMenuItem",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Terrasoft.UI.WebControls.Controls.MenuItem"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b0df370f-b78c-4de9-874c-2565cc81793d"),
				Name = "MenuItemCaption",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Terrasoft.Common.LocalizableString",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("66bfb7f8-0a29-4cce-8b5d-e1a3852ef99f"),
				Name = "SchemaUId",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6d23da8b-3006-4e7e-8aa0-d1e9cf0bc574"),
				Name = "OptionPageSchemaUId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ee35e3ca-95af-4068-9f54-1a119c1f4b91"),
				Name = "AnalyticsTypeCode",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,77,111,155,64,16,61,59,82,254,195,106,79,182,74,87,105,165,54,82,173,30,92,226,84,150,234,180,10,110,123,172,198,48,193,212,176,139,134,197,212,74,243,223,59,139,1,135,224,228,210,19,104,222,199,62,102,102,217,1,137,12,117,185,176,152,137,143,66,99,37,86,72,4,133,185,179,234,251,66,253,196,181,111,180,37,147,22,170,123,89,54,130,241,100,122,126,214,170,153,29,177,195,231,50,137,212,13,86,238,217,199,125,200,109,98,52,115,90,125,83,233,145,8,193,98,244,105,63,251,13,127,152,106,169,196,199,248,92,195,58,197,31,9,86,129,101,34,51,238,32,45,122,148,69,6,49,170,192,148,20,58,188,73,93,87,15,69,117,139,69,253,178,4,205,69,26,138,159,16,110,32,115,78,242,216,25,110,203,44,207,37,43,11,75,137,142,5,53,10,103,210,208,131,26,81,243,44,183,123,71,172,18,27,110,196,120,166,33,221,219,36,44,86,251,28,125,19,225,68,220,159,159,141,66,40,80,200,91,204,13,89,41,62,156,50,148,84,163,57,225,142,191,95,229,58,118,1,70,163,99,248,43,199,58,120,116,199,180,205,254,37,197,43,17,132,27,204,128,39,197,159,152,167,16,226,88,190,150,158,148,147,218,104,205,205,223,78,187,48,126,89,88,147,249,27,168,19,29,203,77,225,100,196,208,129,207,70,171,165,255,147,236,225,217,81,61,10,241,52,215,137,37,244,77,106,168,94,14,126,170,107,50,217,140,226,245,248,194,123,235,93,94,122,111,222,189,239,109,238,10,98,55,207,54,33,167,149,127,93,230,175,181,215,55,183,88,3,108,48,230,14,121,97,251,221,210,207,119,168,45,95,182,52,9,183,42,216,152,234,139,129,104,9,197,246,196,109,24,242,147,152,207,109,250,112,88,77,117,109,40,3,59,150,247,23,15,221,209,142,44,189,97,200,201,139,238,93,97,5,20,163,109,111,150,27,173,107,130,234,77,214,105,152,186,184,98,75,66,91,146,238,126,52,211,127,10,186,162,53,118,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2810996b-8dda-4167-8b9e-47ee886807ff"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,146,209,78,194,48,20,134,175,37,225,29,14,187,128,45,44,125,0,141,81,68,226,118,33,24,17,189,46,219,217,168,118,221,210,118,138,49,188,187,237,42,202,80,162,55,222,108,235,233,127,190,254,231,239,88,6,126,239,10,117,172,198,165,208,184,214,17,242,234,162,214,186,20,17,75,83,20,126,0,253,62,236,43,38,130,46,57,166,126,16,192,91,183,115,116,67,115,36,223,0,196,17,224,20,50,202,21,158,28,22,198,133,173,207,203,90,38,104,228,86,32,75,222,84,93,145,220,162,106,62,174,169,48,69,249,43,107,79,63,165,133,5,123,119,40,37,85,101,166,201,3,46,71,85,229,253,25,20,107,44,182,148,149,17,145,74,228,77,183,210,146,137,28,108,237,131,17,167,70,212,64,231,201,10,11,74,162,221,61,219,195,76,234,237,134,158,193,122,46,204,93,226,66,114,195,250,114,109,26,50,150,215,146,106,102,28,222,179,20,75,11,95,104,198,153,102,168,136,185,168,200,245,249,63,143,21,182,157,134,176,80,40,205,82,96,98,153,129,181,119,40,145,209,35,93,79,158,81,104,69,198,156,37,79,100,38,204,219,172,155,98,59,223,157,153,137,90,149,47,118,237,139,154,243,16,220,115,224,193,240,115,198,33,156,123,131,160,201,115,3,104,126,22,151,196,127,249,176,71,251,46,102,18,171,169,241,51,147,147,162,210,175,237,91,9,224,12,192,179,118,61,56,134,189,173,33,120,97,51,195,1,147,206,81,124,105,133,219,209,186,157,205,59,186,121,171,42,113,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("be5082a8-6632-4e7c-b24d-a40b6a86aab9"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("69aec56a-e06f-4020-a7f1-10597b74c3b2"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetChartListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("431e5f8a-8e2f-4dac-b4e5-5adecede7d9c"),
				Name = "GetChartList",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, Guid, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,91,139,218,64,20,126,86,240,63,12,121,26,151,48,75,247,85,87,144,236,34,11,110,41,36,226,195,210,135,179,201,168,211,78,102,134,153,73,75,90,246,191,119,46,166,106,180,130,5,145,228,156,243,93,206,37,247,119,163,225,15,208,8,148,202,160,220,81,244,136,86,134,234,76,10,65,75,203,164,32,115,165,56,43,193,63,135,10,178,102,118,183,148,37,112,255,202,196,22,23,185,43,223,176,109,163,67,21,9,101,43,203,56,179,140,26,178,150,250,187,81,80,210,16,95,104,217,168,241,36,170,150,59,208,214,100,146,243,40,230,212,11,170,53,24,185,177,164,71,42,235,90,138,3,235,130,218,156,122,216,19,88,192,163,225,224,212,118,138,92,232,6,174,87,89,53,156,206,5,240,214,178,210,100,222,88,228,15,76,221,120,34,237,245,126,79,73,66,210,247,107,172,118,195,66,37,168,48,74,201,155,90,124,134,154,222,214,243,178,252,117,128,226,126,207,73,222,154,75,157,36,46,149,69,225,164,155,61,21,150,217,54,119,238,106,120,5,1,91,170,207,151,239,167,124,92,129,147,231,115,88,50,70,96,208,133,196,94,73,185,231,155,117,190,244,65,81,229,48,170,213,11,89,211,119,199,97,181,228,134,156,213,59,241,254,121,145,92,106,139,43,183,214,45,88,138,159,88,136,130,110,167,113,57,41,146,239,223,92,233,12,169,79,41,186,150,126,24,163,223,254,20,52,181,141,22,174,252,237,108,175,95,73,33,243,128,195,99,191,73,5,154,22,18,171,135,235,165,227,201,71,183,33,77,77,195,173,27,150,160,63,209,146,25,59,45,26,197,233,116,209,176,42,69,241,63,58,155,205,176,7,109,164,166,238,220,16,254,251,109,33,38,206,62,50,103,221,57,247,112,100,186,115,121,169,246,50,62,140,3,226,45,57,202,38,167,22,29,158,109,16,206,143,225,143,199,108,81,99,112,122,243,78,34,50,95,29,128,39,143,238,66,241,69,103,251,76,207,213,96,224,161,113,106,100,94,85,216,195,254,57,50,188,39,137,97,242,92,43,219,166,157,213,216,227,199,104,232,126,119,247,255,185,142,253,113,68,220,228,15,117,194,189,141,106,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetReportListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("43697b6d-f860-49c1-80c9-6fbe7369fac1"),
				Name = "GetReportList",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, Guid, string>>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,91,111,218,48,24,125,166,82,255,131,151,135,202,145,34,75,235,227,184,76,20,54,132,68,187,169,129,241,80,245,193,77,12,245,230,196,150,237,116,162,43,255,125,159,29,46,33,1,36,30,18,37,246,249,206,57,223,237,141,106,68,149,26,208,228,149,161,46,154,25,166,7,50,207,89,98,185,204,73,95,41,193,19,234,190,61,130,204,185,125,157,200,132,10,247,203,243,37,158,198,0,95,240,101,161,61,138,120,216,204,114,193,45,103,134,204,165,254,99,20,77,152,63,31,105,89,168,176,125,125,245,6,170,154,41,169,173,25,72,33,74,53,144,159,50,173,169,145,11,75,106,172,50,203,100,190,167,29,49,27,51,23,54,164,150,226,67,211,209,37,44,247,50,45,4,235,231,84,172,44,79,204,163,247,84,82,71,187,186,0,227,249,44,107,241,254,214,165,105,172,134,26,161,132,42,95,65,41,138,44,127,160,25,187,44,211,73,242,190,15,109,36,27,196,43,115,52,139,0,238,6,165,114,112,88,243,24,236,101,244,158,230,116,201,116,179,233,174,184,85,4,14,30,155,97,65,136,168,169,100,81,66,12,57,2,221,104,43,248,190,88,249,103,61,168,174,59,27,147,57,123,1,14,171,165,48,164,129,7,241,198,160,145,24,254,113,10,93,94,82,203,240,144,251,83,170,87,157,178,97,17,146,47,191,1,218,67,234,115,132,206,93,223,134,232,31,186,190,106,105,102,11,157,3,252,169,209,235,103,50,149,177,143,195,161,235,174,162,154,77,37,86,183,231,161,97,123,189,111,154,41,132,133,106,229,236,47,154,112,99,59,211,66,9,214,25,21,60,141,80,249,46,157,245,122,216,5,45,164,102,48,130,8,239,91,142,120,222,92,56,48,15,222,29,1,50,219,33,26,167,27,33,119,140,203,144,167,160,114,29,28,186,4,2,190,64,56,174,198,119,171,116,165,72,235,112,21,64,99,67,125,182,8,142,189,244,87,29,220,147,22,183,215,77,139,187,36,127,120,53,179,31,147,153,103,171,144,28,67,4,207,46,169,225,221,67,33,4,249,69,69,193,208,87,175,78,190,101,202,174,208,151,163,118,142,51,53,172,185,242,29,217,75,242,157,231,233,216,178,236,110,5,113,248,176,0,33,250,4,37,0,55,232,230,198,113,180,240,201,220,186,85,163,31,31,205,53,172,9,157,32,218,41,134,155,134,182,202,177,36,253,52,197,46,251,147,51,89,179,30,157,106,67,180,29,142,77,93,214,240,130,103,237,22,216,111,87,41,216,254,15,229,26,128,124,178,6,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBuildMenuMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7e738c4a-8a77-4301-935f-dfe93f8ea27a"),
				Name = "BuildMenu",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,93,79,219,48,20,125,78,127,133,149,167,84,32,11,182,55,24,76,93,233,80,165,129,16,45,236,101,210,100,106,183,100,203,71,23,59,45,168,202,127,159,63,211,196,113,210,118,26,27,15,165,189,62,190,247,248,250,28,219,43,148,1,58,203,194,37,3,23,128,178,44,76,22,112,20,47,217,235,121,111,197,135,102,57,101,105,60,124,70,25,27,227,47,33,21,168,132,172,129,248,250,225,58,15,241,101,208,63,239,133,115,16,140,94,24,28,211,193,15,244,114,79,126,229,132,178,62,216,244,188,59,180,32,112,144,160,232,149,133,51,122,67,146,28,202,143,123,18,167,43,50,136,34,49,189,21,53,140,8,202,4,162,144,37,198,244,38,197,121,68,238,178,116,70,40,37,116,154,39,156,47,15,18,89,76,16,142,249,188,1,198,183,100,61,102,36,214,108,167,36,203,16,77,231,12,62,140,225,87,242,52,76,19,150,165,17,133,229,23,81,78,76,144,116,234,57,224,48,35,136,17,252,233,85,44,142,103,100,89,78,154,168,81,130,158,34,242,24,146,245,132,113,56,199,205,81,68,29,192,91,20,139,81,95,165,229,81,217,93,191,9,124,24,99,142,19,77,134,60,36,254,187,216,77,209,98,175,108,227,152,55,89,247,67,47,91,133,54,133,99,201,104,201,194,52,225,240,122,94,211,38,61,222,156,40,90,52,90,145,132,241,222,70,225,236,39,156,132,11,190,175,238,53,151,217,4,210,65,185,145,172,12,76,81,182,32,204,44,227,138,167,118,72,136,207,225,208,241,85,135,192,120,177,160,94,84,116,216,246,195,231,52,139,17,11,252,117,152,224,116,13,55,39,5,31,219,156,22,231,223,18,255,24,216,173,211,85,27,3,215,36,33,25,95,189,102,61,145,69,2,33,166,99,144,228,81,212,175,148,62,106,212,230,69,161,72,8,17,198,82,168,134,204,105,209,87,60,58,58,208,74,114,107,62,140,53,33,197,64,122,78,30,0,220,92,180,106,122,197,75,218,94,142,201,30,250,74,117,245,216,61,89,166,42,56,79,249,190,207,158,65,96,50,130,48,81,153,75,223,146,136,196,98,167,133,226,9,43,151,49,210,225,64,160,5,91,113,14,24,44,183,111,158,48,112,9,78,100,26,153,135,146,37,226,93,78,179,173,132,101,193,11,161,62,73,18,124,4,242,139,1,156,1,69,116,171,233,122,162,210,4,162,165,19,19,13,236,66,130,156,215,118,16,122,124,236,64,89,149,249,43,187,184,141,237,37,38,239,205,228,212,36,167,234,181,105,201,243,138,158,215,233,194,50,163,68,215,4,163,183,91,104,198,236,188,218,239,242,192,215,71,253,118,155,228,146,52,24,138,31,239,143,65,245,231,41,156,166,19,217,145,160,95,31,121,87,27,49,170,235,230,110,40,40,100,251,101,120,176,6,76,98,203,200,251,31,39,111,40,129,6,55,93,175,93,2,82,3,222,238,139,156,131,58,123,101,136,235,83,73,244,58,54,251,17,108,54,33,62,19,33,113,91,22,102,37,109,100,165,188,112,88,222,68,58,101,245,137,80,121,25,104,94,213,9,109,143,3,27,214,254,58,176,145,45,183,190,59,33,110,30,111,14,172,185,125,69,80,183,252,187,15,142,218,28,225,223,250,174,138,234,161,209,230,34,199,132,237,9,60,226,97,253,11,62,162,200,217,161,238,247,137,141,238,126,103,88,130,17,229,185,104,234,207,141,170,185,119,228,254,227,103,7,255,43,149,87,158,22,213,90,187,60,234,62,22,234,93,46,29,89,11,255,131,227,193,113,58,57,153,85,188,134,185,124,182,39,116,183,219,228,164,250,132,14,183,89,192,78,191,89,216,118,199,89,64,227,35,21,62,200,73,86,166,125,188,100,47,189,116,211,149,28,168,251,201,115,77,217,105,41,11,127,144,169,20,139,110,91,53,197,95,175,232,94,233,95,245,223,129,214,178,155,94,42,219,26,248,63,246,106,97,215,125,243,234,235,180,80,143,176,162,87,252,6,214,191,191,247,243,15,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetAnalyticsElementsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c8dc84f4-e6f8-4ad7-afc8-abc3e0cc900b"),
				Name = "GetAnalyticsElements",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "List<Tuple<Guid, Guid, string>>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("30a8446e-8612-47d0-aed1-0e07fc65938f"),
				Name = "code",
				CreatedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				ModifiedInSchemaUId = new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,72,206,79,73,85,176,181,85,80,114,206,72,44,42,81,210,84,168,230,229,226,44,74,45,41,45,202,83,112,79,45,1,139,250,100,22,151,104,104,90,243,114,213,242,114,101,34,235,9,74,45,200,199,162,9,34,140,172,43,53,167,56,85,1,170,32,175,52,39,199,26,0,242,143,49,44,123,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AnalyticsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38a8e97d-40fa-4186-9a4d-c49dad8910a7"));
		}

		#endregion

	}

	#endregion

}

