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
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: ReportPreviewPageSchema

	/// <exclude/>
	public class ReportPreviewPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _infoMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel InfoMessagePanel {
			get {
				return _infoMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _optionPageControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout OptionPageControlLayout {
			get {
				return _optionPageControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _reportPreviewControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ReportPreviewControlLayout {
			get {
				return _reportPreviewControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ReportPreview _reportPreview;
		public Terrasoft.UI.WebControls.Controls.ReportPreview ReportPreview {
			get {
				return _reportPreview;
			}
		}

		#endregion

		#region Constructors: Public

		public ReportPreviewPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ReportPreviewPageSchema(ReportPreviewPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			RealUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			Name = "ReportPreviewPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Maximized = true;
			Width = 800;
			Height = 600;
			ValidationMessagePanel = "InfoMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReportPreviewPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateInfoMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateOptionPageControlLayout());
			MainControlLayout.InsertItem(1, CreateReportPreviewControlLayout());
			ReportPreviewControlLayout.InsertItem(0, CreateReportPreview());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateReportPreviewPageEventsProcessSchema() {
			var schema = new ReportPreviewPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateInfoMessagePanel() {
			_infoMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_infoMessagePanel.UId = new Guid("08092f1e-4179-4799-ba86-9d19b1a4a344");
			_infoMessagePanel.Name = "InfoMessagePanel";
			_infoMessagePanel.CreatedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_infoMessagePanel.ModifiedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_infoMessagePanel.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_infoMessagePanel.Tag = "";
			_infoMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_infoMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_infoMessagePanel.Edges = "0 0 1 0";
			return _infoMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateOptionPageControlLayout() {
			_optionPageControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_optionPageControlLayout.UId = new Guid("fda788d8-522c-46d9-ba94-7bb548b74c6c");
			_optionPageControlLayout.Name = "OptionPageControlLayout";
			_optionPageControlLayout.CreatedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_optionPageControlLayout.ModifiedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_optionPageControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_optionPageControlLayout.Tag = "";
			_optionPageControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_optionPageControlLayout.Width = System.Web.UI.WebControls.Unit.Pixel(350);
			_optionPageControlLayout.StartNewAlignGroup = false;
			_optionPageControlLayout.Image = new ControlImage {};
			_optionPageControlLayout.Edges = "";
			_optionPageControlLayout.HasSplitter = true;
			return _optionPageControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ReportPreview CreateReportPreview() {
			_reportPreview = new Terrasoft.UI.WebControls.Controls.ReportPreview();
			_reportPreview.UId = new Guid("e43e5b4b-7809-446a-b924-1d79987b88ea");
			_reportPreview.Name = "ReportPreview";
			_reportPreview.CreatedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_reportPreview.ModifiedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_reportPreview.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_reportPreview.Tag = "";
			_reportPreview.Edges = "";
			_reportPreview.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_reportPreview.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _reportPreview;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateReportPreviewControlLayout() {
			_reportPreviewControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_reportPreviewControlLayout.UId = new Guid("7a48d5a9-a914-4fb5-ad78-e3cb62200df1");
			_reportPreviewControlLayout.Name = "ReportPreviewControlLayout";
			_reportPreviewControlLayout.CreatedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_reportPreviewControlLayout.ModifiedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_reportPreviewControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_reportPreviewControlLayout.Tag = "";
			_reportPreviewControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_reportPreviewControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(75);
			_reportPreviewControlLayout.StartNewAlignGroup = false;
			_reportPreviewControlLayout.Image = new ControlImage {};
			_reportPreviewControlLayout.Edges = "";
			return _reportPreviewControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("05db218b-13c8-4fe2-8565-3a4d39d699ae");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Padding = "";
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.DefaultMargins = "";
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ReportPreviewPageSchemaUserControl();
		}

		public override object Clone() {
			return new ReportPreviewPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ReportPreviewPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ReportPreviewPageEventsProcess

	/// <exclude/>
	public class ReportPreviewPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.ReportPreviewPageSchemaUserControl
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

		public ReportPreviewPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReportPreviewPageEventsProcess";
			SchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964");
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

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("9f1e2cc3-7923-4a8c-9e72-dd286b66ef2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("9440ae3e-cf72-4eee-a567-2d0cd468417a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _startMessageRefreshReportPreviewControl;
		public ProcessFlowElement StartMessageRefreshReportPreviewControl {
			get {
				return _startMessageRefreshReportPreviewControl ?? (_startMessageRefreshReportPreviewControl = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageRefreshReportPreviewControl",
					SchemaElementUId = new Guid("c1a2e3bf-d306-450d-9940-4a4597f25cf0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("83590f8a-dbd6-4c33-8adc-c353c3d4bbd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadStartMessage;
		public ProcessFlowElement PageLoadStartMessage {
			get {
				return _pageLoadStartMessage ?? (_pageLoadStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadStartMessage",
					SchemaElementUId = new Guid("cf776a36-a42d-4976-8141-f9afe4e22754"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setOptionPageScriptTask;
		public ProcessScriptTask SetOptionPageScriptTask {
			get {
				return _setOptionPageScriptTask ?? (_setOptionPageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetOptionPageScriptTask",
					SchemaElementUId = new Guid("cceea06b-7679-493d-8248-8e9fc8ef4aad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetOptionPageScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _reportPreviewSetCaptionScript;
		public ProcessScriptTask ReportPreviewSetCaptionScript {
			get {
				return _reportPreviewSetCaptionScript ?? (_reportPreviewSetCaptionScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ReportPreviewSetCaptionScript",
					SchemaElementUId = new Guid("77b419c8-b47a-40a5-a758-7b932f3d5416"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ReportPreviewSetCaptionScriptExecute,
				});
			}
		}

		private LocalizableString _windowCaption;
		public LocalizableString WindowCaption {
			get {
				return _windowCaption ?? (_windowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.WindowCaption.Value"));
			}
		}

		private LocalizableString _infoMessageHeader;
		public LocalizableString InfoMessageHeader {
			get {
				return _infoMessageHeader ?? (_infoMessageHeader = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InfoMessageHeader.Value"));
			}
		}

		private LocalizableString _pressPreviewButtonMessage;
		public LocalizableString PressPreviewButtonMessage {
			get {
				return _pressPreviewButtonMessage ?? (_pressPreviewButtonMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PressPreviewButtonMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[StartMessageRefreshReportPreviewControl.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageRefreshReportPreviewControl };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[PageLoadStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadStartMessage };
			FlowElements[SetOptionPageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetOptionPageScriptTask };
			FlowElements[ReportPreviewSetCaptionScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ReportPreviewSetCaptionScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SubProcess2":
						break;
					case "ScriptTask1":
						break;
					case "StartMessageRefreshReportPreviewControl":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "SubProcess1":
						break;
					case "PageLoadStartMessage":
						e.Context.QueueTasks.Enqueue("ReportPreviewSetCaptionScript");
						break;
					case "SetOptionPageScriptTask":
						break;
					case "ReportPreviewSetCaptionScript":
						e.Context.QueueTasks.Enqueue("SetOptionPageScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageRefreshReportPreviewControl");
			ActivatedEventElements.Add("PageLoadStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "StartMessageRefreshReportPreviewControl":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageRefreshReportPreviewControl";
					result = StartMessageRefreshReportPreviewControl.Execute(context);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadStartMessage";
					result = PageLoadStartMessage.Execute(context);
					break;
				case "SetOptionPageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetOptionPageScriptTask";
					result = SetOptionPageScriptTask.Execute(context, SetOptionPageScriptTaskExecute);
					break;
				case "ReportPreviewSetCaptionScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReportPreviewSetCaptionScript";
					result = ReportPreviewSetCaptionScript.Execute(context, ReportPreviewSetCaptionScriptExecute);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var reportSchemaUId = Page.GetParameterValue("ReportSchemaUId");
			if(reportSchemaUId != null){
				Page.ReportPreview.SetReportSchemaUId(reportSchemaUId.ToString());
			}
			
			// Hide message to press preview button
			Page.InfoMessagePanel.Remove("PreviewInfoId");
			return true;
		}

		public virtual bool SetOptionPageScriptTaskExecute(ProcessExecutingContext context) {
			bool isParameterPageLoaded = false;
			var OptionPageSchemaUId = Page.GetParameterValue("OptionPageSchemaUId");
			if(OptionPageSchemaUId == null || new Guid(OptionPageSchemaUId.ToString()).IsEmpty()){
				Page.OptionPageControlLayout.Collapsed = true;
				Page.OptionPageControlLayout.HasSplitter = false;
				var reportSchemaUId = Page.GetParameterValue("ReportSchemaUId");
				if(reportSchemaUId != null) {
					Page.ReportPreview.SetReportSchemaUId(reportSchemaUId.ToString());
				}
			} else {
				var helpContextId = Page.GetParameterValue("HelpContextId") as string;
				var _optionPageContainer = new Terrasoft.UI.WebControls.Controls.PageContainer();
					_optionPageContainer.UId = Guid.NewGuid();
					_optionPageContainer.Name = "OptionPageContainer";
					_optionPageContainer.PageSchemaUId = new Guid(OptionPageSchemaUId.ToString());
					_optionPageContainer.Height = Unit.Percentage(100);
					_optionPageContainer.Width = Unit.Percentage(100);
					_optionPageContainer.HelpContextId = helpContextId;
			
				Page.OptionPageControlLayout.InsertItem(0, _optionPageContainer);
				_optionPageContainer.PageInstance.Process.SetPropertyValue("ListenerPageProcessUId", Page.Process.InstanceUId);
				isParameterPageLoaded = true;
			}
			var reportSchema = Page.GetParameterValue("ReportSchemaUId");
			if (reportSchema != null) {
				var reportSchema_OpenMode = UserConnection
					.SessionData[reportSchema.ToString() + "_OpenMode"] as string;
				if (reportSchema_OpenMode != null && reportSchema_OpenMode == "EditPageMode") {
					//Page.OptionPageControlLayout.Collapsed = true;
					//Page.OptionPageControlLayout.HasSplitter = false;
					Page.OptionPageControlLayout.Hide();
					isParameterPageLoaded = false;
				}
			}
			
			// Show message to press preview button
			if (!Ext.IsAjaxRequest && isParameterPageLoaded) {
				Page.InfoMessagePanel.AddMessage("PreviewInfoId", InfoMessageHeader, PressPreviewButtonMessage);
			}
			
			return true;
		}

		public virtual bool ReportPreviewSetCaptionScriptExecute(ProcessExecutingContext context) {
			var reportSchemaUId = Page.GetParameterValue("ReportSchemaUId");
			if(reportSchemaUId != null){
				try{
					Guid reportSchemaUIdGuid = new Guid(reportSchemaUId.ToString());
					var reportSchemaCaption = ((Schema)(UserConnection.GetSchemaManager("ReportSchemaManager") as Terrasoft.Reports.ReportSchemaManager).GetInstanceByUId(reportSchemaUIdGuid)).Caption;
					(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = string.Format(WindowCaption, reportSchemaCaption.ToString());
				}
				catch(Exception ex){
					(Page.AspPage as Terrasoft.UI.WebControls.Page).Caption = ex.Message;
				}
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "RefreshReportPreviewControl":
							if (ActivatedEventElements.Contains("StartMessageRefreshReportPreviewControl")) {
							context.QueueTasks.Enqueue("StartMessageRefreshReportPreviewControl");
						}
						break;
					case "PageLoad":
							if (ActivatedEventElements.Contains("PageLoadStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadStartMessage");
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

	#region Class: ReportPreviewPageEventsProcess

	/// <exclude/>
	public class ReportPreviewPageEventsProcess : ReportPreviewPageEventsProcess<Terrasoft.WebApp.ReportPreviewPageSchemaUserControl>
	{

		public ReportPreviewPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReportPreviewPageSchemaUserControl

	/// <exclude/>
	public partial class ReportPreviewPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel InfoMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("InfoMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout OptionPageControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("OptionPageControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ReportPreviewControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ReportPreviewControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ReportPreview ReportPreview {
			get {
				return (Terrasoft.UI.WebControls.Controls.ReportPreview)PageContainer.FindPageControl("ReportPreview", true);
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
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (ReportPreviewPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ReportPreviewPageEventsProcess(UserConnection);
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
			SchemaName = "ReportPreviewPage";
		}

		#endregion

	}

	#endregion

	#region Class: ReportPreviewPageEventsProcessSchema

	/// <exclude/>
	public class ReportPreviewPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public ReportPreviewPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReportPreviewPageEventsProcessSchema(ReportPreviewPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReportPreviewPageEventsProcess";
			UId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet72 = CreateLaneSet72LaneSet();
			LaneSets.Add(schemaLaneSet72);
			ProcessSchemaLane schemaLane186 = CreateLane186Lane();
			schemaLaneSet72.Lanes.Add(schemaLane186);
			ProcessSchemaLane schemaLane187 = CreateLane187Lane();
			schemaLaneSet72.Lanes.Add(schemaLane187);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			subprocess2.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessagerefreshreportpreviewcontrol = CreateStartMessageRefreshReportPreviewControlStartMessageEvent();
			subprocess2.FlowElements.Add(startmessagerefreshreportpreviewcontrol);
			ProcessSchemaStartMessageEvent pageloadstartmessage = CreatePageLoadStartMessageStartMessageEvent();
			subprocess1.FlowElements.Add(pageloadstartmessage);
			ProcessSchemaScriptTask setoptionpagescripttask = CreateSetOptionPageScriptTaskScriptTask();
			subprocess1.FlowElements.Add(setoptionpagescripttask);
			ProcessSchemaScriptTask reportpreviewsetcaptionscript = CreateReportPreviewSetCaptionScriptScriptTask();
			subprocess1.FlowElements.Add(reportpreviewsetcaptionscript);
			FlowElements.Add(CreateSequenceFlow589SequenceFlow());
			FlowElements.Add(CreateSequenceFlow590SequenceFlow());
			FlowElements.Add(CreateSequenceFlow591SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateWindowCaptionLocalizableString());
			LocalizableStrings.Add(CreateInfoMessageHeaderLocalizableString());
			LocalizableStrings.Add(CreatePressPreviewButtonMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8041af18-0283-4397-9833-460901dbd4e9"),
				Name = "WindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInfoMessageHeaderLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("964f35cc-f028-4cc2-8819-357e314329c6"),
				Name = "InfoMessageHeader",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePressPreviewButtonMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1c646e11-9f01-4933-8c5e-78b174f3a9cc"),
				Name = "PressPreviewButtonMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow589SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow589",
				UId = new Guid("77c54397-7519-4fd9-9723-6bba026606eb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				CurveCenterPosition = new Point(216, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77b419c8-b47a-40a5-a758-7b932f3d5416"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cceea06b-7679-493d-8248-8e9fc8ef4aad"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow590SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow590",
				UId = new Guid("987a00a8-4481-4973-9781-e8383b931f3d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				CurveCenterPosition = new Point(200, 101),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c1a2e3bf-d306-450d-9940-4a4597f25cf0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9440ae3e-cf72-4eee-a567-2d0cd468417a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow591SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow591",
				UId = new Guid("f720e3dd-9d50-4977-b40e-a71ac41fc81e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				CurveCenterPosition = new Point(216, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf776a36-a42d-4976-8141-f9afe4e22754"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77b419c8-b47a-40a5-a758-7b932f3d5416"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet72LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet72 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8e0ae037-f3d1-4281-a7b8-c2b7ff336466"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"LaneSet72",
				Position = new Point(5, 5),
				Size = new Size(1256, 399),
				UseBackgroundMode = false
			};
			return schemaLaneSet72;
		}

		protected virtual ProcessSchemaLane CreateLane186Lane() {
			ProcessSchemaLane schemaLane186 = new ProcessSchemaLane(this) {
				UId = new Guid("5aa0d2e6-74c0-4fe6-a6e5-bbc734d1899b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8e0ae037-f3d1-4281-a7b8-c2b7ff336466"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"Lane186",
				Position = new Point(29, 0),
				Size = new Size(1227, 219),
				UseBackgroundMode = false
			};
			return schemaLane186;
		}

		protected virtual ProcessSchemaLane CreateLane187Lane() {
			ProcessSchemaLane schemaLane187 = new ProcessSchemaLane(this) {
				UId = new Guid("0ff414be-f1bb-4861-b942-cce76665aeac"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("8e0ae037-f3d1-4281-a7b8-c2b7ff336466"),
				CreatedInOwnerSchemaUId = new Guid("7cdaea88-ca81-419d-9a77-c2184f3c1964"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"Lane187",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 224),
				Size = new Size(1227, 175),
				UseBackgroundMode = false
			};
			return schemaLane187;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9f1e2cc3-7923-4a8c-9e72-dd286b66ef2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5aa0d2e6-74c0-4fe6-a6e5-bbc734d1899b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"SubProcess2",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(506, 198),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9440ae3e-cf72-4eee-a567-2d0cd468417a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f1e2cc3-7923-4a8c-9e72-dd286b66ef2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(259, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,49,15,130,48,16,133,103,155,244,63,156,76,176,192,15,32,204,234,96,66,68,221,171,28,216,132,182,228,184,226,96,252,239,82,96,145,229,114,201,189,251,222,123,163,34,32,236,29,113,245,124,161,81,183,83,13,5,148,170,197,244,128,92,42,82,6,25,233,174,58,143,113,116,249,87,70,73,46,133,110,226,45,96,95,128,245,93,151,124,164,216,205,168,229,175,36,28,53,190,211,10,121,3,218,18,210,171,171,152,180,109,227,36,88,124,165,144,34,203,224,168,107,4,131,195,48,49,129,29,244,52,237,97,6,44,60,60,179,179,82,204,142,39,219,184,243,162,44,149,197,110,138,96,220,56,85,88,67,132,251,90,128,144,61,89,96,242,152,255,0,27,94,142,236,15,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageRefreshReportPreviewControlStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c1a2e3bf-d306-450d-9940-4a4597f25cf0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9f1e2cc3-7923-4a8c-9e72-dd286b66ef2f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"RefreshReportPreviewControl",
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"StartMessageRefreshReportPreviewControl",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("83590f8a-dbd6-4c33-8adc-c353c3d4bbd9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0ff414be-f1bb-4861-b942-cce76665aeac"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"SubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(532, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("cf776a36-a42d-4976-8141-f9afe4e22754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83590f8a-dbd6-4c33-8adc-c353c3d4bbd9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoad",
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"PageLoadStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(57, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetOptionPageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("cceea06b-7679-493d-8248-8e9fc8ef4aad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83590f8a-dbd6-4c33-8adc-c353c3d4bbd9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"SetOptionPageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(393, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,77,79,227,48,16,61,23,137,255,96,114,64,169,22,185,221,51,226,192,178,136,86,226,163,162,116,57,172,86,200,52,211,214,171,212,206,218,19,10,90,250,223,119,198,9,144,100,251,65,47,213,68,158,247,60,243,252,102,250,104,109,42,180,31,40,167,230,128,224,6,106,10,151,86,37,144,136,19,49,81,169,135,227,253,189,39,229,196,77,134,218,26,62,30,142,103,48,87,163,62,103,240,183,188,0,124,199,255,80,105,14,113,180,34,59,106,19,147,158,196,43,137,78,132,201,211,84,188,190,10,3,11,113,145,235,100,85,158,188,179,67,116,218,76,227,118,91,246,253,249,60,195,23,10,255,238,239,181,66,33,31,144,51,107,208,217,244,82,189,216,28,229,153,77,83,149,249,208,19,186,156,91,218,12,232,41,63,204,82,141,212,80,69,134,22,235,224,32,179,14,63,163,193,109,61,51,244,223,34,1,154,12,7,69,243,109,193,125,20,117,21,208,129,131,39,13,11,57,4,108,112,53,57,170,194,240,45,203,253,189,165,0,170,58,112,114,217,51,72,51,238,17,158,113,99,209,189,106,94,212,22,202,11,31,152,223,250,127,176,53,205,148,54,65,35,126,182,59,112,78,121,59,65,57,234,203,123,120,44,53,245,242,61,168,161,226,80,106,107,21,161,44,148,101,31,200,107,88,4,63,108,200,190,166,22,40,61,186,249,255,44,90,143,106,122,249,179,206,91,207,216,3,61,157,33,81,141,140,70,57,0,55,6,58,154,66,252,181,219,221,0,187,215,9,206,118,70,245,26,47,90,123,97,130,109,243,120,223,120,112,216,71,152,199,221,163,149,207,26,46,95,43,29,225,81,153,49,200,129,179,99,240,158,109,74,97,70,164,47,165,153,46,181,71,48,197,82,41,179,120,16,142,10,247,189,225,222,136,232,168,24,145,53,219,168,156,220,101,177,143,170,19,176,227,16,234,137,168,13,80,125,2,155,228,15,55,25,152,43,155,176,195,70,36,25,169,96,96,204,154,240,211,80,215,222,83,252,93,161,250,89,133,85,28,35,190,136,232,157,37,250,85,159,169,102,49,31,215,149,85,137,195,195,117,245,144,229,207,19,141,220,123,160,46,87,72,167,179,243,54,220,134,89,179,16,183,108,81,157,64,57,182,219,254,97,194,198,98,207,118,58,98,56,179,11,49,39,89,41,81,160,21,153,163,152,127,121,25,138,199,28,145,165,103,221,14,206,159,201,199,254,244,183,122,190,133,63,57,120,100,177,86,222,85,72,19,202,237,155,137,189,42,232,7,202,64,42,79,147,164,252,142,163,114,231,114,78,112,106,37,185,7,68,228,200,188,92,79,153,247,45,84,83,38,180,143,203,38,28,96,238,76,33,238,63,113,228,179,0,97,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateReportPreviewSetCaptionScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77b419c8-b47a-40a5-a758-7b932f3d5416"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83590f8a-dbd6-4c33-8adc-c353c3d4bbd9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"),
				Name = @"ReportPreviewSetCaptionScript",
				Position = new Point(218, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,81,205,106,195,48,12,62,167,208,119,240,114,178,97,248,5,74,15,91,217,74,14,133,178,54,235,89,115,213,54,144,216,65,86,218,148,177,119,159,157,132,65,66,111,3,27,27,233,243,247,35,95,129,4,97,237,136,119,230,130,21,228,217,81,44,197,22,206,168,215,200,91,32,168,144,145,62,161,108,80,166,31,99,100,170,22,243,89,113,146,83,130,167,165,176,77,89,170,239,249,44,97,186,199,35,89,55,197,113,170,212,213,2,22,111,34,94,167,60,122,239,118,76,133,61,75,21,133,146,228,58,49,187,130,154,11,103,3,133,148,125,69,201,220,35,173,156,181,104,98,43,134,232,59,27,176,33,20,141,51,12,197,84,9,240,98,143,68,224,221,137,117,15,241,250,1,84,69,198,204,122,6,107,240,245,30,92,78,93,199,36,74,233,193,91,231,91,118,243,124,241,117,60,199,82,121,166,15,248,21,12,51,185,210,235,8,248,123,27,114,249,46,191,126,119,84,1,203,67,97,143,238,54,116,159,31,141,98,58,178,159,176,13,176,185,200,183,214,96,207,138,109,247,49,255,112,133,173,222,160,247,161,58,104,132,69,200,13,89,193,212,224,226,23,181,49,175,64,85,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("88a4ddea-69af-4153-99ae-09f28eed7ff6"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReportPreviewPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0fe83b2-33b0-4ce1-955d-17c385575b90"));
		}

		#endregion

	}

	#endregion

}

