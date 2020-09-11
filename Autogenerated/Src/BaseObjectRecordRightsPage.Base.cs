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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: BaseObjectRecordRightsPageSchema

	/// <exclude/>
	public class BaseObjectRecordRightsPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TabPanel _gridTabPanel;
		public Terrasoft.UI.WebControls.Controls.TabPanel GridTabPanel {
			get {
				return _gridTabPanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Tab _rightsTab;
		public Terrasoft.UI.WebControls.Controls.Tab RightsTab {
			get {
				return _rightsTab;
			}
		}

		private Terrasoft.UI.WebControls.Controls.PageContainer _grid;
		public Terrasoft.UI.WebControls.Controls.PageContainer Grid {
			get {
				return _grid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _readMenuItem;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem ReadMenuItem {
			get {
				return _readMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _editMenuItem;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem EditMenuItem {
			get {
				return _editMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckMenuItem _deleteMenuItem;
		public Terrasoft.UI.WebControls.Controls.CheckMenuItem DeleteMenuItem {
			get {
				return _deleteMenuItem;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseObjectRecordRightsPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseObjectRecordRightsPageSchema(BaseObjectRecordRightsPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			RealUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			Name = "BaseObjectRecordRightsPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseObjectRecordRightsPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateGridTabPanel());
			GridTabPanel.InsertItem(0, CreateRightsTab());
			RightsTab.InsertItem(0, CreateGrid());
			RightsTab.InsertItem(0, CreateReadMenuItem());
			RightsTab.InsertItem(1, CreateEditMenuItem());
			RightsTab.InsertItem(2, CreateDeleteMenuItem());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseObjectRecordRightsPageEventsProcessSchema() {
			var schema = new BaseObjectRecordRightsPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.PageContainer CreateGrid() {
			_grid = new Terrasoft.UI.WebControls.Controls.PageContainer();
			_grid.UId = new Guid("03971d78-5223-4ef6-81eb-90c638151799");
			_grid.Name = "Grid";
			_grid.CreatedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_grid.ModifiedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_grid.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			_grid.Tag = "";
			_grid.PageSchemaUId = new Guid("08a28020-620d-441e-bc3e-a9b9c8d9e6e6");
			_grid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_grid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_grid.StartNewAlignGroup = false;
			_grid.Edges = "";
			return _grid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateReadMenuItem() {
			_readMenuItem = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_readMenuItem.UId = new Guid("a8dc7d5e-40d8-40e9-9682-1d4d7ae128db");
			_readMenuItem.Name = "ReadMenuItem";
			_readMenuItem.CreatedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_readMenuItem.ModifiedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_readMenuItem.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			_readMenuItem.Group = "RightsGroup";
			_readMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_readMenuItem.Image = new ControlImage {};
			_readMenuItem.Tag = "0";
			return _readMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateEditMenuItem() {
			_editMenuItem = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_editMenuItem.UId = new Guid("b11fd867-bae8-409a-a499-926cd8074a7e");
			_editMenuItem.Name = "EditMenuItem";
			_editMenuItem.CreatedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_editMenuItem.ModifiedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_editMenuItem.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			_editMenuItem.Group = "RightsGroup";
			_editMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_editMenuItem.Image = new ControlImage {};
			_editMenuItem.Tag = "1";
			return _editMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckMenuItem CreateDeleteMenuItem() {
			_deleteMenuItem = new Terrasoft.UI.WebControls.Controls.CheckMenuItem();
			_deleteMenuItem.UId = new Guid("44145641-da85-4450-bc29-98d3c7904d02");
			_deleteMenuItem.Name = "DeleteMenuItem";
			_deleteMenuItem.CreatedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_deleteMenuItem.ModifiedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_deleteMenuItem.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			_deleteMenuItem.Group = "RightsGroup";
			_deleteMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_deleteMenuItem.Image = new ControlImage {};
			_deleteMenuItem.Tag = "2";
			return _deleteMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Tab CreateRightsTab() {
			_rightsTab = new Terrasoft.UI.WebControls.Controls.Tab();
			_rightsTab.UId = new Guid("97c3c97f-9308-4925-8044-da729857ac9a");
			_rightsTab.Name = "RightsTab";
			_rightsTab.CreatedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_rightsTab.ModifiedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_rightsTab.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			_rightsTab.Tag = "";
			_rightsTab.Image = new ControlImage {};
			_rightsTab.ShowMenuItemCaption = true;
			return _rightsTab;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TabPanel CreateGridTabPanel() {
			_gridTabPanel = new Terrasoft.UI.WebControls.Controls.TabPanel();
			_gridTabPanel.UId = new Guid("2c1569b5-dcc2-40a1-bc90-28d3a92cf6fd");
			_gridTabPanel.Name = "GridTabPanel";
			_gridTabPanel.CreatedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_gridTabPanel.ModifiedInSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			_gridTabPanel.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			_gridTabPanel.Tag = "";
			_gridTabPanel.ActiveTabIndex = 0;
			_gridTabPanel.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_gridTabPanel.StartNewAlignGroup = false;
			_gridTabPanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _gridTabPanel;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseObjectRecordRightsPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseObjectRecordRightsPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseObjectRecordRightsPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseObjectRecordRightsPageEventsProcess

	/// <exclude/>
	public class BaseObjectRecordRightsPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.BaseObjectRecordRightsPageSchemaUserControl
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

		public BaseObjectRecordRightsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseObjectRecordRightsPageEventsProcess";
			SchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6");
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
					SchemaElementUId = new Guid("21e0bef4-58bc-4539-b06e-183af4b2f6d9"),
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
					SchemaElementUId = new Guid("67e46877-ef1a-4ac7-bed3-912e41584262"),
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
					SchemaElementUId = new Guid("2f378377-6e4c-4644-9cd3-6d258f5b5a4e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEventSubProcess;
		public ProcessFlowElement PageLoadCompleteEventSubProcess {
			get {
				return _pageLoadCompleteEventSubProcess ?? (_pageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "PageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("2f20b053-43b3-4bea-bc11-f13fc711ca45"),
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
					SchemaElementUId = new Guid("1e08a698-cd21-41ba-89c9-1f9e72f5710f"),
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
					SchemaElementUId = new Guid("44fb0f77-a0df-4fc9-8347-18c254f89aa9"),
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
			FlowElements[InitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitStartMessage };
			FlowElements[InitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTask };
			FlowElements[PageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEventSubProcess };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "InitEventSubProcess":
						break;
					case "InitStartMessage":
						e.Context.QueueTasks.Enqueue("InitScriptTask");
						break;
					case "InitScriptTask":
						break;
					case "PageLoadCompleteEventSubProcess":
						break;
					case "PageLoadCompleteStartMessage":
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
			ActivatedEventElements.Add("InitStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
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
				case "PageLoadCompleteEventSubProcess":
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
			var pageContainer = Page.Grid;
			var entitySchemaUId = new Guid(Page.GetParameterValue("entitySchemaUId").ToString());
			var recordId = new Guid(Page.GetParameterValue("recordId").ToString());
			pageContainer.PageInstance.Process.SetPropertyValue("SysEntitySchemaId", entitySchemaUId);
			pageContainer.PageInstance.Process.SetPropertyValue("ModuleEntitySchemaUId", entitySchemaUId);
			pageContainer.PageInstance.Process.SetPropertyValue("SelectedNodePrimaryColumnValue", recordId);
			
			Page.RightsTab.AjaxEvents.MenuItemClick.Event += (sender, e) => {
				Page.Grid.PageInstance.Process.ThrowEvent(
					Page.Grid.PageInstance.Process.InternalContext, "GridPageRefreshRow");
			};
			
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			Page.ReadMenuItem.Checked = true;
			Page.Grid.PageInstance.Process.ThrowEvent(
				Page.Grid.PageInstance.Process.InternalContext, "GridPageRefreshRow");
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitStartMessage")) {
							context.QueueTasks.Enqueue("InitStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
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

	#region Class: BaseObjectRecordRightsPageEventsProcess

	/// <exclude/>
	public class BaseObjectRecordRightsPageEventsProcess : BaseObjectRecordRightsPageEventsProcess<Terrasoft.WebApp.BaseObjectRecordRightsPageSchemaUserControl>
	{

		public BaseObjectRecordRightsPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseObjectRecordRightsPageSchemaUserControl

	/// <exclude/>
	public partial class BaseObjectRecordRightsPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TabPanel GridTabPanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.TabPanel)PageContainer.FindPageControl("GridTabPanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Tab RightsTab {
			get {
				return (Terrasoft.UI.WebControls.Controls.Tab)PageContainer.FindPageControl("RightsTab", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.PageContainer Grid {
			get {
				return (Terrasoft.UI.WebControls.Controls.PageContainer)PageContainer.FindPageControl("Grid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem ReadMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("ReadMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem EditMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("EditMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckMenuItem DeleteMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckMenuItem)PageContainer.FindPageControl("DeleteMenuItem", true);
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
			var process = (BaseObjectRecordRightsPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseObjectRecordRightsPageEventsProcess(UserConnection);
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
			SchemaName = "BaseObjectRecordRightsPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseObjectRecordRightsPageEventsProcessSchema

	/// <exclude/>
	public class BaseObjectRecordRightsPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BaseObjectRecordRightsPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseObjectRecordRightsPageEventsProcessSchema(BaseObjectRecordRightsPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseObjectRecordRightsPageEventsProcess";
			UId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0");
			CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
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
			ProcessSchemaLaneSet schemaBaseObjectRecordRightsPageLaneSet = CreateBaseObjectRecordRightsPageLaneSetLaneSet();
			LaneSets.Add(schemaBaseObjectRecordRightsPageLaneSet);
			ProcessSchemaLane schemaPageEventsLane = CreatePageEventsLaneLane();
			schemaBaseObjectRecordRightsPageLaneSet.Lanes.Add(schemaPageEventsLane);
			ProcessSchemaEventSubProcess initeventsubprocess = CreateInitEventSubProcessEventSubProcess();
			FlowElements.Add(initeventsubprocess);
			ProcessSchemaEventSubProcess pageloadcompleteeventsubprocess = CreatePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(pageloadcompleteeventsubprocess);
			ProcessSchemaStartMessageEvent initstartmessage = CreateInitStartMessageStartMessageEvent();
			initeventsubprocess.FlowElements.Add(initstartmessage);
			ProcessSchemaScriptTask initscripttask = CreateInitScriptTaskScriptTask();
			initeventsubprocess.FlowElements.Add(initscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			pageloadcompleteeventsubprocess.FlowElements.Add(pageloadcompletescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("07d7e1f9-6a87-44ba-96f0-a6002895a4c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				CurveCenterPosition = new Point(198, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("67e46877-ef1a-4ac7-bed3-912e41584262"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2f378377-6e4c-4644-9cd3-6d258f5b5a4e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("3c058627-2fe8-4c4b-ace1-d4310b40fac2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				CurveCenterPosition = new Point(176, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1e08a698-cd21-41ba-89c9-1f9e72f5710f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44fb0f77-a0df-4fc9-8347-18c254f89aa9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateBaseObjectRecordRightsPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaBaseObjectRecordRightsPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("502371d7-8caf-48fa-ac36-7b8215f90332"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"BaseObjectRecordRightsPageLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1007, 263),
				UseBackgroundMode = false
			};
			return schemaBaseObjectRecordRightsPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreatePageEventsLaneLane() {
			ProcessSchemaLane schemaPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("121585ea-86da-43f6-999c-f4cc38cd393b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("502371d7-8caf-48fa-ac36-7b8215f90332"),
				CreatedInOwnerSchemaUId = new Guid("42ae8f8e-cb0e-45f7-8f82-cf4215fdffa6"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"PageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(978, 263),
				UseBackgroundMode = false
			};
			return schemaPageEventsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("21e0bef4-58bc-4539-b06e-183af4b2f6d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("121585ea-86da-43f6-999c-f4cc38cd393b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"InitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(225, 116),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("67e46877-ef1a-4ac7-bed3-912e41584262"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("21e0bef4-58bc-4539-b06e-183af4b2f6d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"InitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2f378377-6e4c-4644-9cd3-6d258f5b5a4e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("21e0bef4-58bc-4539-b06e-183af4b2f6d9"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"InitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,81,75,195,48,20,133,159,215,95,17,250,212,226,200,31,24,19,100,140,209,135,73,89,167,239,177,57,174,209,54,25,55,183,219,138,248,223,77,59,39,90,4,69,124,76,238,185,223,61,231,38,7,69,98,175,118,88,56,203,202,88,144,152,139,60,156,229,138,140,158,69,135,80,134,101,195,93,81,86,104,212,93,166,131,192,226,40,86,173,209,201,89,9,206,21,169,6,12,186,87,117,139,36,30,181,196,169,220,186,130,201,216,93,146,166,103,42,161,116,164,127,135,187,104,199,156,47,198,101,223,157,89,207,202,150,144,57,185,18,222,203,34,208,200,237,65,220,189,195,138,206,47,63,217,11,212,233,56,226,95,209,107,167,219,26,203,81,248,127,195,23,168,81,50,244,173,211,200,201,52,138,186,133,171,219,198,14,245,48,231,178,167,48,32,26,118,185,49,187,138,253,86,61,200,155,39,117,90,30,130,17,47,215,176,109,198,104,22,181,41,159,229,112,41,174,230,34,241,176,26,20,220,166,98,126,45,94,162,201,199,63,248,222,224,182,34,119,28,218,147,104,242,147,56,179,225,57,173,170,251,208,56,241,84,196,189,182,151,110,240,72,240,213,198,29,227,224,251,53,88,39,112,75,86,48,181,152,189,1,111,166,152,51,160,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreatePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaPageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2f20b053-43b3-4bea-bc11-f13fc711ca45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("121585ea-86da-43f6-999c-f4cc38cd393b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"PageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 133),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(222, 116),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaPageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1e08a698-cd21-41ba-89c9-1f9e72f5710f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2f20b053-43b3-4bea-bc11-f13fc711ca45"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("44fb0f77-a0df-4fc9-8347-18c254f89aa9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2f20b053-43b3-4bea-bc11-f13fc711ca45"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c"),
				CreatedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,206,65,10,194,48,20,132,225,181,133,222,33,116,165,32,185,128,184,42,34,89,20,66,232,5,66,50,26,81,95,224,229,197,246,248,54,120,0,119,255,226,131,25,235,239,208,14,62,78,160,106,4,111,61,38,132,39,162,58,43,225,138,83,223,217,70,174,252,136,186,149,161,34,158,2,180,229,28,80,138,158,19,231,229,242,1,201,190,239,118,127,176,33,1,147,127,141,121,139,85,142,106,104,182,81,135,27,163,36,151,151,225,176,141,50,164,50,253,46,124,1,22,69,208,102,164,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseObjectRecordRightsPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29f35b66-1c99-433d-982c-ed2cbc7934e0"));
		}

		#endregion

	}

	#endregion

}

