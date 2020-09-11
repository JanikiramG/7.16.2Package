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

	#region Class: StructureExplorerDirectColumnEditPageSchema

	/// <exclude/>
	public class StructureExplorerDirectColumnEditPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainInfoControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainInfoControlLayout {
			get {
				return _mainInfoControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _columnPathEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnPathEdit {
			get {
				return _columnPathEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.EntityDataSource _dataSource;
		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return _dataSource;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _buttonControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonControlLayout {
			get {
				return _buttonControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _contextHelpButton;
		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return _contextHelpButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _spacer1;
		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return _spacer1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _okButton;
		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return _okButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _cancelButton;
		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return _cancelButton;
			}
		}

		#endregion

		#region Constructors: Public

		public StructureExplorerDirectColumnEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public StructureExplorerDirectColumnEditPageSchema(StructureExplorerDirectColumnEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			RealUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			Name = "StructureExplorerDirectColumnEditPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 350;
			Height = 150;
			HelpContextId = "424";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateStructureExplorerDirectColumnEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateMainInfoControlLayout());
			MainInfoControlLayout.InsertItem(0, CreateColumnPathEdit());
			MainInfoControlLayout.InsertItem(1, CreateCaptionEdit());
			Controls.AddAt(1, CreateDataSource());
			UpdateDataSource();
			Controls.AddAt(2, CreateButtonControlLayout());
			ButtonControlLayout.InsertItem(0, CreateContextHelpButton());
			ButtonControlLayout.InsertItem(1, CreateSpacer1());
			ButtonControlLayout.InsertItem(2, CreateOkButton());
			ButtonControlLayout.InsertItem(3, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateStructureExplorerDirectColumnEditPageEventsProcessSchema() {
			var schema = new StructureExplorerDirectColumnEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateColumnPathEdit() {
			_columnPathEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_columnPathEdit.UId = new Guid("8095cb36-76ae-4427-84a8-ed1de9e0c374");
			_columnPathEdit.Name = "ColumnPathEdit";
			_columnPathEdit.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_columnPathEdit.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_columnPathEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_columnPathEdit.Tag = "";
			_columnPathEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_columnPathEdit.Image = new ControlImage {};
			_columnPathEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnPathEdit.Enabled = false;
			return _columnPathEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_captionEdit.UId = new Guid("d2ee54ee-281e-48fd-b4e3-e6b6b7c98811");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_captionEdit.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainInfoControlLayout() {
			_mainInfoControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainInfoControlLayout.UId = new Guid("841dac04-4ba9-401c-95bd-2e611f046820");
			_mainInfoControlLayout.Name = "MainInfoControlLayout";
			_mainInfoControlLayout.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_mainInfoControlLayout.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_mainInfoControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainInfoControlLayout.Tag = "";
			_mainInfoControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_mainInfoControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_mainInfoControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainInfoControlLayout.StartNewAlignGroup = false;
			_mainInfoControlLayout.Image = new ControlImage {};
			_mainInfoControlLayout.Edges = "";
			return _mainInfoControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("a873c56f-6fef-4a66-9cf8-2fa399bac48e");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_mainControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.DefaultMargins = "5 5 5 5";
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.EntityDataSource CreateDataSource() {
			_dataSource = new Terrasoft.UI.WebControls.Controls.EntityDataSource();
			_dataSource.UId = new Guid("feda25e6-f79f-41f1-b42b-94229bc27cd2");
			_dataSource.Name = "DataSource";
			_dataSource.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_dataSource.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_dataSource.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_dataSource.Tag = "";
			_dataSource.EnableServerActiveRow = false;
			_dataSource.SchemaUId = Guid.Empty;
			_dataSource.HierarchicalDepth = 1;
			_dataSource.DefStructure.ID = "c" + _dataSource.DefStructure.UId.ToString("N");
			_dataSource.DefStructure.UId = new Guid("24c40943-7cd7-4909-824d-64e0545feff6");
			_dataSource.DefStructure.Name = "DefStructure";
			_dataSource.DefStructure.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_dataSource.DefStructure.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			return _dataSource;
		}

		protected virtual void UpdateDataSource() {
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateContextHelpButton() {
			_contextHelpButton = new Terrasoft.UI.WebControls.Controls.Button();
			_contextHelpButton.UId = new Guid("bdaa102e-33f0-4cdc-aa9c-1b8cb4c0d74e");
			_contextHelpButton.Name = "ContextHelpButton";
			_contextHelpButton.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_contextHelpButton.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_contextHelpButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_contextHelpButton.Tag = "";
			_contextHelpButton.Image = new ControlImage {};
			_contextHelpButton.Hidden = true;
			return _contextHelpButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("e362bd4b-fb1f-485e-ba5a-19ad84354b4c");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_spacer1.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_spacer1.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("d26441ba-f858-4c39-8283-855f1da9a1c8");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_okButton.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_okButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("b9f6540a-aa07-4a38-89d7-5c2763c09b6f");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_cancelButton.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_cancelButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateButtonControlLayout() {
			_buttonControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_buttonControlLayout.UId = new Guid("e8b11fba-47c6-46c9-b197-496ff9bac869");
			_buttonControlLayout.Name = "ButtonControlLayout";
			_buttonControlLayout.CreatedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_buttonControlLayout.ModifiedInSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			_buttonControlLayout.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_buttonControlLayout.Tag = "";
			_buttonControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_buttonControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_buttonControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_buttonControlLayout.FitHeightByContent = true;
			_buttonControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_buttonControlLayout.StartNewAlignGroup = false;
			_buttonControlLayout.Image = new ControlImage {};
			_buttonControlLayout.Edges = "";
			return _buttonControlLayout;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new StructureExplorerDirectColumnEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new StructureExplorerDirectColumnEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new StructureExplorerDirectColumnEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: StructureExplorerDirectColumnEditPageEventsProcess

	/// <exclude/>
	public class StructureExplorerDirectColumnEditPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.StructureExplorerDirectColumnEditPageSchemaUserControl
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

		public StructureExplorerDirectColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "StructureExplorerDirectColumnEditPageEventsProcess";
			SchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920");
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

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("b9b10247-f4a7-457b-b89b-c716219f264b"),
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
					SchemaElementUId = new Guid("27df6fc3-f218-436d-99f3-1b25f279c37e"),
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
					SchemaElementUId = new Guid("4d59a4e4-9fae-49c1-9b4a-10609c6d25f7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
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
					SchemaElementUId = new Guid("5af32933-a780-4579-9774-5d17b67f6e84"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _okButtonClickStartMessage;
		public ProcessFlowElement OkButtonClickStartMessage {
			get {
				return _okButtonClickStartMessage ?? (_okButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OkButtonClickStartMessage",
					SchemaElementUId = new Guid("da9af31d-8140-4ad2-b6a1-2ab3f5d6d2d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _okButtonClickScriptTask;
		public ProcessScriptTask OkButtonClickScriptTask {
			get {
				return _okButtonClickScriptTask ?? (_okButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OkButtonClickScriptTask",
					SchemaElementUId = new Guid("dd96bcec-70ab-4905-bbc5-ddc663c984dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("e0d7eccd-d33f-4cdb-8882-e689a1b0b5f2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickStartMessage;
		public ProcessFlowElement CancelButtonClickStartMessage {
			get {
				return _cancelButtonClickStartMessage ?? (_cancelButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CancelButtonClickStartMessage",
					SchemaElementUId = new Guid("3b390f7b-e293-4509-adf9-1ca874712144"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _cancelButtonClickScriptTask;
		public ProcessScriptTask CancelButtonClickScriptTask {
			get {
				return _cancelButtonClickScriptTask ?? (_cancelButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CancelButtonClickScriptTask",
					SchemaElementUId = new Guid("49f961c6-5137-413f-b9ed-4469570fe912"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
						break;
					case "OkButtonClickScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
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
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OkButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickStartMessage";
					result = OkButtonClickStartMessage.Execute(context);
					break;
				case "OkButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OkButtonClickScriptTask";
					result = OkButtonClickScriptTask.Execute(context, OkButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "CancelButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickStartMessage";
					result = CancelButtonClickStartMessage.Execute(context);
					break;
				case "CancelButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CancelButtonClickScriptTask";
					result = CancelButtonClickScriptTask.Execute(context, CancelButtonClickScriptTaskExecute);
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

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.SchemaUId = new Guid(Page.Request.QueryString["rootSchemaUId"].ToString());
			if (Page.DataSource.SchemaManager.FindInstanceByUId(Page.DataSource.SchemaUId) == null) {
				Page.DataSource.ManagerName = "SystemEntitySchemaManager";
			}
			EntityDataSourceUtilities.SynchronizeStructure(Page.DataSource);
			Page.DataSource.LoadStructure();
			var conditionsScript = @"var datasourcePrimaryColumnNameId = " + Json.Serialize(Page.DataSource.Schema.PrimaryColumn.UId.ToString()) + @";
				var currentColumnNameId = row.getColumnValue('MetaPath').replace(/\[(.)*\]\./g,'');
				var isOppositeColumn = (row.getColumnValue('MetaPath').indexOf('[') >= 0);
				var isVirtual = isOppositeColumn && (currentColumnNameId == datasourcePrimaryColumnNameId);";
			string script = @"var key = window.name; if (window.opener) { 
				var columnPropertiesEditPageParams = window.opener.window.columnEditPageParams[key];
				var id = columnPropertiesEditPageParams['columnId'];
				var structureExplorer = window.opener[columnPropertiesEditPageParams.structureExplorerId];
				var dataSource = structureExplorer.selectedItemsGrid.dataSource;
				var row = dataSource.findRow(dataSource.getPrimaryColumnName(), id); " +
				conditionsScript +
				//"this." + Page.ColumnPathLabel.ClientID + @".setCaption(row.getColumnValue('MetaPathCaption')); " +
				"this." + Page.ColumnPathEdit.ClientID + @".setValue(row.getColumnValue('MetaPathCaption')); " +
				"this." + Page.CaptionEdit.ClientID + @".setValue(row.getColumnValue('Caption')); "+
			"}";	
			                
			Page.ScriptManager.AddScript(script);
			InitializeContextHelpButton();
			
			Page.CaptionEdit.MaxLength = 250;
			return true;
		}

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			string script = @"var key = window.name; if (window.opener) { 
				var columnPropertiesEditPageParams = window.opener.window.columnEditPageParams[key];
				var id = columnPropertiesEditPageParams['columnId'];
				var structureExplorer = window.opener[columnPropertiesEditPageParams.structureExplorerId];
				var dataSource = structureExplorer.selectedItemsGrid.dataSource;
				var row = dataSource.findRow(dataSource.getPrimaryColumnName(), id);
				row.setColumnValue('Caption','" + System.Web.HttpUtility.JavaScriptStringEncode(Page.CaptionEdit.Text) + @"'); 
				dataSource.fireEvent('rowloaded', dataSource, [row.columns], {});
			}";
			Page.ScriptManager.AddScript(script);
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			(Page.AspPage as Terrasoft.UI.WebControls.Page).Close();
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage");
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

	#region Class: StructureExplorerDirectColumnEditPageEventsProcess

	/// <exclude/>
	public class StructureExplorerDirectColumnEditPageEventsProcess : StructureExplorerDirectColumnEditPageEventsProcess<Terrasoft.WebApp.StructureExplorerDirectColumnEditPageSchemaUserControl>
	{

		public StructureExplorerDirectColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: StructureExplorerDirectColumnEditPageSchemaUserControl

	/// <exclude/>
	public partial class StructureExplorerDirectColumnEditPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainInfoControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainInfoControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit ColumnPathEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ColumnPathEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.EntityDataSource DataSource {
			get {
				return (Terrasoft.UI.WebControls.Controls.EntityDataSource)PageContainer.FindPageControl("DataSource", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ButtonControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ButtonControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ContextHelpButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ContextHelpButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer Spacer1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("Spacer1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OkButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OkButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button CancelButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("CancelButton", true);
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
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (StructureExplorerDirectColumnEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new StructureExplorerDirectColumnEditPageEventsProcess(UserConnection);
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

		public virtual void OkButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("OkButtonClick");
		}

		public virtual void CancelButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("CancelButtonClick");
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
			SchemaName = "StructureExplorerDirectColumnEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: StructureExplorerDirectColumnEditPageEventsProcessSchema

	/// <exclude/>
	public class StructureExplorerDirectColumnEditPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public StructureExplorerDirectColumnEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public StructureExplorerDirectColumnEditPageEventsProcessSchema(StructureExplorerDirectColumnEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "StructureExplorerDirectColumnEditPageEventsProcess";
			UId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(cancelbuttonclickscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e2a6131e-378f-4ead-8484-e031a98c1bbc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				CurveCenterPosition = new Point(197, 458),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("27df6fc3-f218-436d-99f3-1b25f279c37e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4d59a4e4-9fae-49c1-9b4a-10609c6d25f7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("62f99101-cbc1-4a6e-a8a2-f76c22b54e8c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("da9af31d-8140-4ad2-b6a1-2ab3f5d6d2d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dd96bcec-70ab-4905-bbc5-ddc663c984dd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("6f2fde23-0b74-490f-bc96-445012cde3c9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3b390f7b-e293-4509-adf9-1ca874712144"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("49f961c6-5137-413f-b9ed-4469570fe912"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e9795160-93b0-4179-96a2-3c47cdbccdac"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(793, 390),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e8d3cd6c-c575-4fb8-9ebf-8bf2d0e673dc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e9795160-93b0-4179-96a2-3c47cdbccdac"),
				CreatedInOwnerSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(764, 185),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("2345f86f-e2e1-448d-b361-eb4be4cbef5f"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("e9795160-93b0-4179-96a2-3c47cdbccdac"),
				CreatedInOwnerSchemaUId = new Guid("5d2ea6f0-f1ad-43e8-bdb2-5313ddf6a920"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 190),
				Size = new Size(764, 200),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("b9b10247-f4a7-457b-b89b-c716219f264b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2345f86f-e2e1-448d-b361-eb4be4cbef5f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(315, 170),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("27df6fc3-f218-436d-99f3-1b25f279c37e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9b10247-f4a7-457b-b89b-c716219f264b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4d59a4e4-9fae-49c1-9b4a-10609c6d25f7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9b10247-f4a7-457b-b89b-c716219f264b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(182, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,223,111,211,48,16,199,159,155,191,194,202,195,146,176,201,157,144,120,138,138,198,186,49,130,86,86,22,182,151,118,15,38,185,182,22,174,29,108,135,54,160,253,239,92,226,116,93,27,86,132,232,83,122,190,251,220,175,175,61,102,115,160,23,204,178,84,149,58,3,154,102,11,88,178,187,36,39,3,34,97,69,174,74,158,135,227,218,233,22,190,151,96,44,253,92,130,174,82,171,185,156,79,124,173,148,125,10,241,31,232,23,229,78,194,40,138,61,62,35,46,180,195,31,49,137,118,77,223,115,153,39,210,88,38,51,56,175,16,241,130,63,158,68,100,128,21,149,66,68,228,151,215,219,119,107,129,159,216,18,176,112,63,173,140,133,229,165,180,220,86,59,25,253,216,123,244,156,125,27,125,103,185,224,150,131,161,105,37,179,133,86,146,255,4,236,163,204,108,169,97,191,36,108,108,63,251,181,98,249,214,31,29,126,48,77,50,37,115,164,42,105,210,76,243,194,98,93,103,126,125,144,99,160,105,2,199,154,47,153,174,134,74,148,75,89,215,222,140,221,39,199,228,163,81,146,166,160,57,19,88,203,11,83,161,59,241,20,135,244,124,254,72,57,195,118,123,77,45,165,214,32,237,94,34,173,86,116,14,173,245,158,137,18,194,96,4,150,141,153,93,4,17,213,80,8,150,65,216,159,78,66,26,189,154,62,76,105,127,126,18,4,81,11,229,230,166,40,148,225,22,28,1,137,225,95,144,184,110,88,223,204,194,96,18,68,228,237,128,156,110,89,247,92,219,146,9,132,116,184,71,71,36,252,99,7,131,195,179,140,98,236,223,52,243,32,102,119,7,223,160,194,239,21,214,131,5,75,244,142,73,173,214,214,160,10,144,160,81,104,164,29,95,3,29,107,180,235,90,39,151,184,216,122,37,99,166,217,210,108,65,46,142,182,255,92,212,174,239,4,19,63,108,122,174,119,112,24,61,9,220,121,146,7,155,40,179,209,217,229,186,16,74,131,222,79,63,57,140,164,29,64,146,111,216,249,147,194,16,218,241,163,6,4,100,22,242,4,239,150,185,210,60,167,219,128,150,128,251,39,131,103,28,58,195,210,110,213,42,124,102,66,125,116,150,21,70,39,56,143,40,174,197,239,245,58,87,7,109,253,190,111,23,220,208,250,118,52,215,193,5,215,194,186,102,95,65,208,161,224,40,144,228,162,209,61,214,106,135,172,168,25,7,53,217,250,4,209,38,245,139,73,234,41,118,115,56,220,127,101,112,231,255,138,223,193,30,123,254,163,31,247,60,178,247,115,15,149,155,225,230,201,125,151,231,206,16,186,43,129,55,48,145,56,236,230,161,25,42,105,97,109,63,128,40,206,75,107,113,120,120,236,117,234,28,177,245,53,200,185,93,224,174,95,191,57,141,61,13,40,20,73,80,49,16,255,6,142,165,120,150,82,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5af32933-a780-4579-9774-5d17b67f6e84"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e8d3cd6c-c575-4fb8-9ebf-8bf2d0e673dc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"EventSubProcess2",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(244, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("da9af31d-8140-4ad2-b6a1-2ab3f5d6d2d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5af32933-a780-4579-9774-5d17b67f6e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(22, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dd96bcec-70ab-4905-bbc5-ddc663c984dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5af32933-a780-4579-9774-5d17b67f6e84"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"OkButtonClickScriptTask",
				Position = new Point(141, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,203,106,195,48,16,69,215,45,244,31,68,54,182,169,209,15,132,66,130,9,173,11,45,161,73,218,69,200,66,181,38,65,212,150,204,104,156,7,33,255,222,81,156,230,209,64,54,182,53,154,123,116,71,215,158,208,216,133,240,5,154,154,196,147,232,117,150,10,197,15,108,248,123,101,172,118,43,105,85,5,93,97,230,34,62,20,92,13,22,48,17,91,241,112,127,23,218,11,87,54,149,29,34,111,32,25,240,3,109,104,168,22,48,84,168,42,127,34,181,66,121,88,181,170,203,222,41,159,60,235,30,176,70,179,244,54,123,26,181,251,185,142,142,50,79,216,20,212,32,12,214,117,233,16,240,191,129,233,109,166,188,2,228,250,8,215,138,212,200,53,88,0,83,175,26,165,135,18,10,2,157,19,84,254,25,141,150,39,193,31,2,221,138,181,167,186,156,179,185,15,183,138,207,74,11,160,33,154,74,225,38,219,123,125,231,12,226,36,229,43,73,2,134,17,124,20,181,123,159,170,108,32,142,50,85,147,113,54,74,163,142,120,20,163,141,103,11,242,11,190,229,11,81,61,33,83,26,218,200,87,181,84,163,125,214,163,125,240,3,91,56,13,113,24,94,30,0,225,50,228,24,214,148,48,166,215,137,146,110,136,249,194,46,15,188,4,75,113,196,62,74,167,52,232,40,61,27,40,21,83,60,230,235,103,169,216,238,130,235,93,135,31,251,147,90,7,111,202,242,2,101,95,235,182,16,183,127,97,232,109,29,245,125,29,222,66,121,49,6,68,229,221,156,228,36,15,83,101,206,18,186,210,203,208,144,200,172,116,158,47,136,149,8,28,136,21,156,12,116,127,1,88,66,74,89,221,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e0d7eccd-d33f-4cdb-8882-e689a1b0b5f2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e8d3cd6c-c575-4fb8-9ebf-8bf2d0e673dc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"EventSubProcess6",
				Position = new Point(308, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(243, 157),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3b390f7b-e293-4509-adf9-1ca874712144"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0d7eccd-d33f-4cdb-8882-e689a1b0b5f2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(29, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("49f961c6-5137-413f-b9ed-4469570fe912"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e0d7eccd-d33f-4cdb-8882-e689a1b0b5f2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(148, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,8,72,76,79,213,115,44,46,0,209,10,137,197,10,33,169,69,69,137,197,249,105,37,122,161,158,122,225,169,73,206,249,121,37,69,249,57,197,122,32,5,154,122,206,57,249,197,169,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,109,49,24,35,70,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInitializeContextHelpButtonMethod());
			Methods.Add(CreateGetIsContextHelpButtonHiddenMethod());
			Methods.Add(CreateGetIsContextHelpEnabledMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("644210b5-51eb-4b2a-85b2-8c55a660d815"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c91d5db3-3145-49b6-b706-cc4c6a150e36"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected virtual SchemaMethod CreateInitializeContextHelpButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("04917112-d6c1-4533-baa3-fd0cf74f2c11"),
				Name = "InitializeContextHelpButton",
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,142,185,174,194,48,16,69,107,248,138,33,5,36,2,249,7,158,40,216,4,41,88,4,72,212,134,76,32,224,140,35,219,1,36,196,191,63,59,129,2,16,75,101,207,213,185,103,38,137,193,175,13,209,132,186,39,201,224,217,140,80,100,221,220,24,73,163,36,138,144,252,0,234,117,120,38,6,196,215,2,35,63,8,224,82,173,204,248,22,217,75,159,149,2,104,67,204,133,198,191,183,92,152,186,124,33,115,181,65,75,59,64,73,81,164,101,200,230,168,139,207,152,147,13,213,55,213,19,62,225,169,243,122,75,84,138,107,25,27,182,194,117,39,203,188,95,61,161,193,244,46,217,89,136,101,180,253,80,238,236,249,121,112,68,50,154,245,68,178,57,176,41,217,215,206,69,248,120,137,171,221,12,76,239,228,201,205,62,229,66,180,160,225,65,19,222,172,40,125,97,223,18,94,35,176,183,92,255,1,60,248,138,253,201,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0e4d1241-2a21-4d84-b181-aa76d8ec4747"),
				Name = "GetIsContextHelpButtonHidden",
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsContextHelpEnabledMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("50645e4b-2bdb-4742-ad3f-8fc79f117d51"),
				Name = "GetIsContextHelpEnabled",
				CreatedInSchemaUId = new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,208,72,202,207,207,209,12,174,44,14,78,45,41,201,204,75,47,214,115,79,45,9,75,204,41,77,213,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,80,114,205,75,76,202,73,5,10,149,164,86,148,120,164,230,20,40,105,90,3,0,89,24,7,81,71,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new StructureExplorerDirectColumnEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5c096de-3dc5-4450-81f1-bf4ccb1080b4"));
		}

		#endregion

	}

	#endregion

}

