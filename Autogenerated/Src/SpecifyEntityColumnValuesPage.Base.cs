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
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using UIControls = Terrasoft.UI.WebControls.Controls;

	#region Class: SpecifyEntityColumnValuesPageSchema

	/// <exclude/>
	public class SpecifyEntityColumnValuesPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MessagePanel _baseMessagePanel;
		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return _baseMessagePanel;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _mainControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return _mainControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _editButtonsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout EditButtonsControlLayout {
			get {
				return _editButtonsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _addButton;
		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return _addButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _editButton;
		public Terrasoft.UI.WebControls.Controls.Button EditButton {
			get {
				return _editButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _deleteButton;
		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return _deleteButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.TreeGrid _columnValuesTreeGrid;
		public Terrasoft.UI.WebControls.Controls.TreeGrid ColumnValuesTreeGrid {
			get {
				return _columnValuesTreeGrid;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout2;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return _controlLayout2;
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

		public SpecifyEntityColumnValuesPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SpecifyEntityColumnValuesPageSchema(SpecifyEntityColumnValuesPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			RealUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			Name = "SpecifyEntityColumnValuesPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			Width = 460;
			ValidationMessagePanel = "BaseMessagePanel";
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSpecifyEntityColumnValuesPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateBaseMessagePanel());
			Controls.AddAt(1, CreateMainControlLayout());
			MainControlLayout.InsertItem(0, CreateEditButtonsControlLayout());
			EditButtonsControlLayout.InsertItem(0, CreateAddButton());
			EditButtonsControlLayout.InsertItem(1, CreateEditButton());
			EditButtonsControlLayout.InsertItem(2, CreateDeleteButton());
			MainControlLayout.InsertItem(1, CreateColumnValuesTreeGrid());
			Controls.AddAt(2, CreateControlLayout2());
			ControlLayout2.InsertItem(0, CreateSpacer1());
			ControlLayout2.InsertItem(1, CreateOkButton());
			ControlLayout2.InsertItem(2, CreateCancelButton());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSpecifyEntityColumnValuesPageEventsProcessSchema() {
			var schema = new SpecifyEntityColumnValuesPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MessagePanel CreateBaseMessagePanel() {
			_baseMessagePanel = new Terrasoft.UI.WebControls.Controls.MessagePanel();
			_baseMessagePanel.UId = new Guid("7319c9c4-5388-4e02-a034-117b98dabb37");
			_baseMessagePanel.Name = "BaseMessagePanel";
			_baseMessagePanel.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_baseMessagePanel.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_baseMessagePanel.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_baseMessagePanel.Tag = "";
			_baseMessagePanel.ContentLeftOffset = System.Web.UI.WebControls.Unit.Pixel(0);
			_baseMessagePanel.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_baseMessagePanel.Edges = "0 0 1 0";
			return _baseMessagePanel;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateAddButton() {
			_addButton = new Terrasoft.UI.WebControls.Controls.Button();
			_addButton.UId = new Guid("d4a2de05-a12b-4da8-a1ca-ae24b219dc34");
			_addButton.Name = "AddButton";
			_addButton.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_addButton.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_addButton.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_addButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_addButton.Tag = "";
			_addButton.Image = new ControlImage {};
			return _addButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateEditButton() {
			_editButton = new Terrasoft.UI.WebControls.Controls.Button();
			_editButton.UId = new Guid("9dd34b97-59d3-4b53-b392-5b9160351034");
			_editButton.Name = "EditButton";
			_editButton.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_editButton.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_editButton.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_editButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_editButton.Tag = "";
			_editButton.Image = new ControlImage {};
			return _editButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateDeleteButton() {
			_deleteButton = new Terrasoft.UI.WebControls.Controls.Button();
			_deleteButton.UId = new Guid("31e115d8-94c6-45a1-bb2b-9418264ac08e");
			_deleteButton.Name = "DeleteButton";
			_deleteButton.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_deleteButton.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_deleteButton.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_deleteButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_deleteButton.Tag = "";
			_deleteButton.Image = new ControlImage {};
			return _deleteButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateEditButtonsControlLayout() {
			_editButtonsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_editButtonsControlLayout.UId = new Guid("a923bd27-e628-4049-b3e5-37e50dd3ce1b");
			_editButtonsControlLayout.Name = "EditButtonsControlLayout";
			_editButtonsControlLayout.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_editButtonsControlLayout.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_editButtonsControlLayout.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_editButtonsControlLayout.Tag = "";
			_editButtonsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(25);
			_editButtonsControlLayout.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_editButtonsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_editButtonsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_editButtonsControlLayout.StartNewAlignGroup = false;
			_editButtonsControlLayout.Image = new ControlImage {};
			_editButtonsControlLayout.Edges = "";
			return _editButtonsControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TreeGrid CreateColumnValuesTreeGrid() {
			_columnValuesTreeGrid = new Terrasoft.UI.WebControls.Controls.TreeGrid();
			_columnValuesTreeGrid.UId = new Guid("cbf3f18d-abfc-4916-93f8-ee9150a637f3");
			_columnValuesTreeGrid.Name = "ColumnValuesTreeGrid";
			_columnValuesTreeGrid.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_columnValuesTreeGrid.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_columnValuesTreeGrid.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_columnValuesTreeGrid.Tag = "";
			_columnValuesTreeGrid.Edges = "0 1 1 1";
			_columnValuesTreeGrid.IsColumnAutowidth = true;
			_columnValuesTreeGrid.FooterVisible = false;
			_columnValuesTreeGrid.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnValuesTreeGrid.IsSummaryVisible = false;
			_columnValuesTreeGrid.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_columnValuesTreeGrid.HideHeaders = false;
			return _columnValuesTreeGrid;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateMainControlLayout() {
			_mainControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_mainControlLayout.UId = new Guid("3f69aa00-06cf-4ae5-955b-001caaef3f5d");
			_mainControlLayout.Name = "MainControlLayout";
			_mainControlLayout.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_mainControlLayout.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_mainControlLayout.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_mainControlLayout.Tag = "";
			_mainControlLayout.Height = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_mainControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_mainControlLayout.Padding = "5 5 5 5";
			_mainControlLayout.StartNewAlignGroup = false;
			_mainControlLayout.Image = new ControlImage {};
			_mainControlLayout.Edges = "";
			return _mainControlLayout;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateSpacer1() {
			_spacer1 = new Terrasoft.UI.WebControls.Controls.Spacer();
			_spacer1.UId = new Guid("74ca781e-4c6c-4105-a4ec-5a18df0f25be");
			_spacer1.Name = "Spacer1";
			_spacer1.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_spacer1.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_spacer1.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_spacer1.Tag = "";
			_spacer1.Size = System.Web.UI.WebControls.Unit.Percentage(100);
			return _spacer1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOkButton() {
			_okButton = new Terrasoft.UI.WebControls.Controls.Button();
			_okButton.UId = new Guid("74233262-f197-4fcb-b576-cc3227eb0dc5");
			_okButton.Name = "OkButton";
			_okButton.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_okButton.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_okButton.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_okButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_okButton.Tag = "";
			_okButton.Image = new ControlImage {};
			return _okButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateCancelButton() {
			_cancelButton = new Terrasoft.UI.WebControls.Controls.Button();
			_cancelButton.UId = new Guid("423d0d10-e520-400b-82cb-87eaf60c844b");
			_cancelButton.Name = "CancelButton";
			_cancelButton.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_cancelButton.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_cancelButton.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_cancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_cancelButton.Tag = "";
			_cancelButton.Image = new ControlImage {};
			return _cancelButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout2() {
			_controlLayout2 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout2.UId = new Guid("18820974-fc6d-4aa0-90d1-27f02632b35f");
			_controlLayout2.Name = "ControlLayout2";
			_controlLayout2.CreatedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_controlLayout2.ModifiedInSchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			_controlLayout2.CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
			_controlLayout2.Tag = "";
			_controlLayout2.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout2.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout2.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Footer;
			_controlLayout2.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout2.StartNewAlignGroup = false;
			_controlLayout2.Image = new ControlImage {};
			_controlLayout2.Edges = "1 0 0 1";
			return _controlLayout2;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SpecifyEntityColumnValuesPageSchemaUserControl();
		}

		public override object Clone() {
			return new SpecifyEntityColumnValuesPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SpecifyEntityColumnValuesPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SpecifyEntityColumnValuesPageEventsProcess

	/// <exclude/>
	public class SpecifyEntityColumnValuesPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.SpecifyEntityColumnValuesPageSchemaUserControl
	{

		#region Class: OpenColumnEditPageFlowElement

		/// <exclude/>
		public class OpenColumnEditPageFlowElement : OpenPageUserTask
		{

			public OpenColumnEditPageFlowElement(UserConnection userConnection, SpecifyEntityColumnValuesPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenColumnEditPage";
				IsLogging = false;
				SchemaElementUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenColumnPageFlowElement

		/// <exclude/>
		public class OpenColumnPageFlowElement : OpenPageUserTask
		{

			public OpenColumnPageFlowElement(UserConnection userConnection, SpecifyEntityColumnValuesPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenColumnPage";
				IsLogging = false;
				SchemaElementUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b");
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

		public SpecifyEntityColumnValuesPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SpecifyEntityColumnValuesPageEventsProcess";
			SchemaUId = new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f08055cc-a384-4885-8fd0-b6173b0e1d7b");
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

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		public virtual bool IsColumnExplorerCreated {
			get;
			set;
		}

		public virtual Object ColumnExplorer {
			get;
			set;
		}

		public virtual string ColumnValuesContextKey {
			get;
			set;
		}

		public virtual string DecisionalColumnMetaPath {
			get;
			set;
		}

		public virtual string InsertedColumnValueKey {
			get;
			set;
		}

		public virtual Guid EditSchemaUId {
			get;
			set;
		}

		public virtual string EditSchemaManagerName {
			get;
			set;
		}

		public virtual Guid EditElementUId {
			get;
			set;
		}

		private ProcessFlowElement _editButtonClickEventSubProcess;
		public ProcessFlowElement EditButtonClickEventSubProcess {
			get {
				return _editButtonClickEventSubProcess ?? (_editButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EditButtonClickEventSubProcess",
					SchemaElementUId = new Guid("f9faeaf8-d731-48ec-99b4-3810b03e2c6e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _editButtonClickStartMessage;
		public ProcessFlowElement EditButtonClickStartMessage {
			get {
				return _editButtonClickStartMessage ?? (_editButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EditButtonClickStartMessage",
					SchemaElementUId = new Guid("b845b6ad-1b1e-4559-8752-ab93826239df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _editButtonClickScriptTask;
		public ProcessScriptTask EditButtonClickScriptTask {
			get {
				return _editButtonClickScriptTask ?? (_editButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EditButtonClickScriptTask",
					SchemaElementUId = new Guid("54ade1ec-451e-438e-af9e-49545d7597dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EditButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenColumnEditPageFlowElement _openColumnEditPage;
		public OpenColumnEditPageFlowElement OpenColumnEditPage {
			get {
				return _openColumnEditPage ?? (_openColumnEditPage = new OpenColumnEditPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _deleteButtonClickEventSubProcess;
		public ProcessFlowElement DeleteButtonClickEventSubProcess {
			get {
				return _deleteButtonClickEventSubProcess ?? (_deleteButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DeleteButtonClickEventSubProcess",
					SchemaElementUId = new Guid("af8a8724-d7d4-4205-8cbb-ce2e522f9f2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deleteButtonClickStartMessage;
		public ProcessFlowElement DeleteButtonClickStartMessage {
			get {
				return _deleteButtonClickStartMessage ?? (_deleteButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeleteButtonClickStartMessage",
					SchemaElementUId = new Guid("4bf0e6d9-b9a4-4747-a8f0-f45d84e54711"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deleteButtonClickScriptTask;
		public ProcessScriptTask DeleteButtonClickScriptTask {
			get {
				return _deleteButtonClickScriptTask ?? (_deleteButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeleteButtonClickScriptTask",
					SchemaElementUId = new Guid("6e47ffe7-3e4a-4d37-b2ee-7aac66635504"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeleteButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("dca5feeb-8d12-44a7-b8f8-2713a198c203"),
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
					SchemaElementUId = new Guid("06a9b241-44af-4a23-8229-0e328eb54379"),
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
					SchemaElementUId = new Guid("96fb6333-c844-4a30-8ef5-d931cf4c7d6f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OkButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _addButtonClickEventSubProcess;
		public ProcessFlowElement AddButtonClickEventSubProcess {
			get {
				return _addButtonClickEventSubProcess ?? (_addButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AddButtonClickEventSubProcess",
					SchemaElementUId = new Guid("f22246a3-43b4-4174-9f9c-3a1586ec8d03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addButtonClickStartMessage;
		public ProcessFlowElement AddButtonClickStartMessage {
			get {
				return _addButtonClickStartMessage ?? (_addButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddButtonClickStartMessage",
					SchemaElementUId = new Guid("5835265c-5e9a-444e-ae01-f9d154957171"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _addButtonClickScriptTask;
		public ProcessScriptTask AddButtonClickScriptTask {
			get {
				return _addButtonClickScriptTask ?? (_addButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AddButtonClickScriptTask",
					SchemaElementUId = new Guid("a91f377e-75ff-4ec7-9d68-24c2a76f51c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AddButtonClickScriptTaskExecute,
				});
			}
		}

		private OpenColumnPageFlowElement _openColumnPage;
		public OpenColumnPageFlowElement OpenColumnPage {
			get {
				return _openColumnPage ?? (_openColumnPage = new OpenColumnPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _initSpecifyEntityColumnValuesPageEventSubProcess;
		public ProcessFlowElement InitSpecifyEntityColumnValuesPageEventSubProcess {
			get {
				return _initSpecifyEntityColumnValuesPageEventSubProcess ?? (_initSpecifyEntityColumnValuesPageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "InitSpecifyEntityColumnValuesPageEventSubProcess",
					SchemaElementUId = new Guid("e9a1fc9b-4ddb-4c0b-b6b0-19e663ed7c6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initSpecifyEntityColumnValuesPageStartMessage;
		public ProcessFlowElement InitSpecifyEntityColumnValuesPageStartMessage {
			get {
				return _initSpecifyEntityColumnValuesPageStartMessage ?? (_initSpecifyEntityColumnValuesPageStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitSpecifyEntityColumnValuesPageStartMessage",
					SchemaElementUId = new Guid("3342ff8c-35d5-487a-a237-04b1ebf77905"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initSpecifyEntityColumnValuesPageScriptTask;
		public ProcessScriptTask InitSpecifyEntityColumnValuesPageScriptTask {
			get {
				return _initSpecifyEntityColumnValuesPageScriptTask ?? (_initSpecifyEntityColumnValuesPageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitSpecifyEntityColumnValuesPageScriptTask",
					SchemaElementUId = new Guid("390920d5-9251-4b85-8d0c-e1b8f54e7233"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitSpecifyEntityColumnValuesPageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _cancelButtonClickEventSubProcess;
		public ProcessFlowElement CancelButtonClickEventSubProcess {
			get {
				return _cancelButtonClickEventSubProcess ?? (_cancelButtonClickEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CancelButtonClickEventSubProcess",
					SchemaElementUId = new Guid("efcd8a87-b7d4-4580-8b3d-56523168c070"),
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
					SchemaElementUId = new Guid("94bd142b-7bbb-4de4-bfe8-6eec715c3f2f"),
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
					SchemaElementUId = new Guid("36cdfba1-0770-4442-9d8c-df160ed80b7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CancelButtonClickScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _columnValueEditPageClosedEventSubProcess;
		public ProcessFlowElement ColumnValueEditPageClosedEventSubProcess {
			get {
				return _columnValueEditPageClosedEventSubProcess ?? (_columnValueEditPageClosedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ColumnValueEditPageClosedEventSubProcess",
					SchemaElementUId = new Guid("9cb01c70-7508-426d-aea0-7649a5db5115"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnValueEditPageClosedStartMessage;
		public ProcessFlowElement ColumnValueEditPageClosedStartMessage {
			get {
				return _columnValueEditPageClosedStartMessage ?? (_columnValueEditPageClosedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValueEditPageClosedStartMessage",
					SchemaElementUId = new Guid("4896f2e7-7c9a-4df6-8b76-2c293bd1dd59"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _columnValueEditPageClosedScriptTask;
		public ProcessScriptTask ColumnValueEditPageClosedScriptTask {
			get {
				return _columnValueEditPageClosedScriptTask ?? (_columnValueEditPageClosedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ColumnValueEditPageClosedScriptTask",
					SchemaElementUId = new Guid("fbb58fbb-51d8-40c3-9edd-2838427a4257"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ColumnValueEditPageClosedScriptTaskExecute,
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
					SchemaElementUId = new Guid("abadbf60-9671-4286-8853-8215721ff559"),
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
					SchemaElementUId = new Guid("891a1917-d849-4bef-886c-7cfa634ce185"),
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
					SchemaElementUId = new Guid("43c58d43-adc4-47fc-8fbd-451044c27f00"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _columnValuesTreeGridDblClickStartMessage;
		public ProcessFlowElement ColumnValuesTreeGridDblClickStartMessage {
			get {
				return _columnValuesTreeGridDblClickStartMessage ?? (_columnValuesTreeGridDblClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ColumnValuesTreeGridDblClickStartMessage",
					SchemaElementUId = new Guid("8b674369-1f88-45ff-a8e8-d83fa97638b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _columnValuesTreeGridDblClickStartMessage1;
		public ProcessFlowElement ColumnValuesTreeGridDblClickStartMessage1 {
			get {
				return _columnValuesTreeGridDblClickStartMessage1 ?? (_columnValuesTreeGridDblClickStartMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ColumnValuesTreeGridDblClickStartMessage1",
					SchemaElementUId = new Guid("6d19b88d-c8a9-4876-b61f-ac5c37333602"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _editButtonClickIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent EditButtonClickIntermediateThrowMessageEvent {
			get {
				return _editButtonClickIntermediateThrowMessageEvent ?? (_editButtonClickIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "EditButtonClickIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("f166a027-c2f2-412b-bab9-ca14ede82362"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "EditButtonClick",
				});
			}
		}

		private LocalizableString _captionColumnCaption;
		public LocalizableString CaptionColumnCaption {
			get {
				return _captionColumnCaption ?? (_captionColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.CaptionColumnCaption.Value"));
			}
		}

		private LocalizableString _valueColumnCaption;
		public LocalizableString ValueColumnCaption {
			get {
				return _valueColumnCaption ?? (_valueColumnCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ValueColumnCaption.Value"));
			}
		}

		private LocalizableString _schemaLocalizableString3;
		public LocalizableString SchemaLocalizableString3 {
			get {
				return _schemaLocalizableString3 ?? (_schemaLocalizableString3 = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SchemaLocalizableString3.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EditButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickEventSubProcess };
			FlowElements[EditButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickStartMessage };
			FlowElements[EditButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickScriptTask };
			FlowElements[OpenColumnEditPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenColumnEditPage };
			FlowElements[DeleteButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickEventSubProcess };
			FlowElements[DeleteButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickStartMessage };
			FlowElements[DeleteButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeleteButtonClickScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[OkButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickStartMessage };
			FlowElements[OkButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OkButtonClickScriptTask };
			FlowElements[AddButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickEventSubProcess };
			FlowElements[AddButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickStartMessage };
			FlowElements[AddButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddButtonClickScriptTask };
			FlowElements[OpenColumnPage.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenColumnPage };
			FlowElements[InitSpecifyEntityColumnValuesPageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { InitSpecifyEntityColumnValuesPageEventSubProcess };
			FlowElements[InitSpecifyEntityColumnValuesPageStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitSpecifyEntityColumnValuesPageStartMessage };
			FlowElements[InitSpecifyEntityColumnValuesPageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitSpecifyEntityColumnValuesPageScriptTask };
			FlowElements[CancelButtonClickEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickEventSubProcess };
			FlowElements[CancelButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickStartMessage };
			FlowElements[CancelButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CancelButtonClickScriptTask };
			FlowElements[ColumnValueEditPageClosedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedEventSubProcess };
			FlowElements[ColumnValueEditPageClosedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedStartMessage };
			FlowElements[ColumnValueEditPageClosedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValueEditPageClosedScriptTask };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[PageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteStartMessage };
			FlowElements[PageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTask };
			FlowElements[ColumnValuesTreeGridDblClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridDblClickStartMessage };
			FlowElements[ColumnValuesTreeGridDblClickStartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { ColumnValuesTreeGridDblClickStartMessage1 };
			FlowElements[EditButtonClickIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { EditButtonClickIntermediateThrowMessageEvent };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EditButtonClickEventSubProcess":
						break;
					case "EditButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("EditButtonClickScriptTask");
						break;
					case "EditButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenColumnEditPage");
						break;
					case "OpenColumnEditPage":
						break;
					case "DeleteButtonClickEventSubProcess":
						break;
					case "DeleteButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("DeleteButtonClickScriptTask");
						break;
					case "DeleteButtonClickScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "OkButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("OkButtonClickScriptTask");
						break;
					case "OkButtonClickScriptTask":
						break;
					case "AddButtonClickEventSubProcess":
						break;
					case "AddButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("AddButtonClickScriptTask");
						break;
					case "AddButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("OpenColumnPage");
						break;
					case "OpenColumnPage":
						break;
					case "InitSpecifyEntityColumnValuesPageEventSubProcess":
						break;
					case "InitSpecifyEntityColumnValuesPageStartMessage":
						e.Context.QueueTasks.Enqueue("InitSpecifyEntityColumnValuesPageScriptTask");
						break;
					case "InitSpecifyEntityColumnValuesPageScriptTask":
						break;
					case "CancelButtonClickEventSubProcess":
						break;
					case "CancelButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("CancelButtonClickScriptTask");
						break;
					case "CancelButtonClickScriptTask":
						break;
					case "ColumnValueEditPageClosedEventSubProcess":
						break;
					case "ColumnValueEditPageClosedStartMessage":
						e.Context.QueueTasks.Enqueue("ColumnValueEditPageClosedScriptTask");
						break;
					case "ColumnValueEditPageClosedScriptTask":
						break;
					case "EventSubProcess1":
						break;
					case "PageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTask");
						break;
					case "PageLoadCompleteScriptTask":
						break;
					case "ColumnValuesTreeGridDblClickStartMessage":
						break;
					case "ColumnValuesTreeGridDblClickStartMessage1":
						e.Context.QueueTasks.Enqueue("EditButtonClickIntermediateThrowMessageEvent");
						break;
					case "EditButtonClickIntermediateThrowMessageEvent":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EditButtonClickStartMessage");
			ActivatedEventElements.Add("DeleteButtonClickStartMessage");
			ActivatedEventElements.Add("OkButtonClickStartMessage");
			ActivatedEventElements.Add("AddButtonClickStartMessage");
			ActivatedEventElements.Add("InitSpecifyEntityColumnValuesPageStartMessage");
			ActivatedEventElements.Add("CancelButtonClickStartMessage");
			ActivatedEventElements.Add("ColumnValueEditPageClosedStartMessage");
			ActivatedEventElements.Add("PageLoadCompleteStartMessage");
			ActivatedEventElements.Add("ColumnValuesTreeGridDblClickStartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EditButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EditButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditButtonClickStartMessage";
					result = EditButtonClickStartMessage.Execute(context);
					break;
				case "EditButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EditButtonClickScriptTask";
					result = EditButtonClickScriptTask.Execute(context, EditButtonClickScriptTaskExecute);
					break;
				case "OpenColumnEditPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenColumnEditPage";
					result = OpenColumnEditPage.Execute(context);
					break;
				case "DeleteButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DeleteButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickStartMessage";
					result = DeleteButtonClickStartMessage.Execute(context);
					break;
				case "DeleteButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeleteButtonClickScriptTask";
					result = DeleteButtonClickScriptTask.Execute(context, DeleteButtonClickScriptTaskExecute);
					break;
				case "EventSubProcess4":
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
				case "AddButtonClickEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickStartMessage";
					result = AddButtonClickStartMessage.Execute(context);
					break;
				case "AddButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddButtonClickScriptTask";
					result = AddButtonClickScriptTask.Execute(context, AddButtonClickScriptTaskExecute);
					break;
				case "OpenColumnPage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenColumnPage";
					result = OpenColumnPage.Execute(context);
					break;
				case "InitSpecifyEntityColumnValuesPageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InitSpecifyEntityColumnValuesPageStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitSpecifyEntityColumnValuesPageStartMessage";
					result = InitSpecifyEntityColumnValuesPageStartMessage.Execute(context);
					break;
				case "InitSpecifyEntityColumnValuesPageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitSpecifyEntityColumnValuesPageScriptTask";
					result = InitSpecifyEntityColumnValuesPageScriptTask.Execute(context, InitSpecifyEntityColumnValuesPageScriptTaskExecute);
					break;
				case "CancelButtonClickEventSubProcess":
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
				case "ColumnValueEditPageClosedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnValueEditPageClosedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditPageClosedStartMessage";
					result = ColumnValueEditPageClosedStartMessage.Execute(context);
					break;
				case "ColumnValueEditPageClosedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValueEditPageClosedScriptTask";
					result = ColumnValueEditPageClosedScriptTask.Execute(context, ColumnValueEditPageClosedScriptTaskExecute);
					break;
				case "EventSubProcess1":
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
				case "ColumnValuesTreeGridDblClickStartMessage":
					context.QueueTasks.Dequeue();
					break;
				case "ColumnValuesTreeGridDblClickStartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ColumnValuesTreeGridDblClickStartMessage1";
					result = ColumnValuesTreeGridDblClickStartMessage1.Execute(context);
					break;
				case "EditButtonClickIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					result = EditButtonClickIntermediateThrowMessageEvent.Execute(context);
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
				case "EditElementUId":
					EditElementUId = reader.GetValue<System.Guid>();
				break;
				case "EditSchemaManagerName":
					EditSchemaManagerName = reader.GetValue<System.String>();
				break;
				case "EditSchemaUId":
					EditSchemaUId = reader.GetValue<System.Guid>();
				break;
				case "InsertedColumnValueKey":
					InsertedColumnValueKey = reader.GetValue<System.String>();
				break;
				case "DecisionalColumnMetaPath":
					DecisionalColumnMetaPath = reader.GetValue<System.String>();
				break;
				case "ColumnValuesContextKey":
					ColumnValuesContextKey = reader.GetValue<System.String>();
				break;
				case "ColumnExplorer":
					ColumnExplorer = reader.GetSerializableObjectValue();
				break;
				case "IsColumnExplorerCreated":
					IsColumnExplorerCreated = reader.GetValue<System.Boolean>();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool EditButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			TreeGridNode node = null;
			if (Page.ColumnValuesTreeGrid.SelectedNodes.Count != 0) {
				node = Page.ColumnValuesTreeGrid.SelectedNodes[0];
			} else {
				return false;
			}
			
			// Define if column is required
			var requiredColumnIds = GetNotNullColumnIdList();
			var metaPath = node.Values["MetaPath"].ToString();
			
			Guid columnId;
			bool isColumnRequired = Guid.TryParse(metaPath, out columnId) && requiredColumnIds.Contains(columnId);
			
			OpenColumnEditPage.OpenerInstanceId = InstanceUId;
			OpenColumnEditPage.UseCurrentActivePage = true;
			OpenColumnEditPage.CloseMessage = "ColumnValueEditPageClosed";
			OpenColumnEditPage.PageUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			InsertedColumnValueKey = Name + "_" + Guid.NewGuid().ToString();
			OpenColumnEditPage.PageParameters =
				new Dictionary<string, string>() {
						{ "schemaId", EntitySchemaUId.ToString() },
						{ "processSchemaId", EditSchemaUId.ToString() },
						{ "managerName", EditSchemaManagerName },
						{ "contextKey", ColumnValuesContextKey },
						{ "treeGridId", Page.ColumnValuesTreeGrid.ClientID },
						{ "rowId", node.Values["Id"].ToString() },
						{ "metaPath", node.Values["MetaPath"].ToString() },
						{ "canChangeColumn", (!isColumnRequired).ToString().ToLower() },
						{ "insertedRowKey", InsertedColumnValueKey },
						{ "editElementId", EditElementUId.ToString() }
					};
			
			return true;
		}

		public virtual bool DeleteButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			var columnValues = GetColumnValues();
			if (columnValues == null) {
				return true;
			}
			var requiredColumnIds = GetNotNullColumnIdList();
			foreach (var node in Page.ColumnValuesTreeGrid.SelectedNodes) {
				var metaPath = node.Values["MetaPath"].ToString();
				Guid columnId;
				if (Guid.TryParse(metaPath, out columnId) && requiredColumnIds.Contains(columnId)) {
					continue;
				}
				// Remove items from user context
				columnValues.Remove(metaPath);
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			DisplayColumnValues();
			return true;
		}

		public virtual bool OkButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool AddButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			OpenColumnPage.OpenerInstanceId = InstanceUId;
			OpenColumnPage.UseCurrentActivePage = true;
			OpenColumnPage.CloseMessage = "ColumnValueEditPageClosed";
			//// ColumnValueEditPage
			OpenColumnPage.PageUId = new Guid("db94a59d-ccc6-4ba5-8eb0-eb7dfba68488");
			InsertedColumnValueKey = Name + "_" + Guid.NewGuid().ToString();
			OpenColumnPage.PageParameters =
				new Dictionary<string, string>() {
						{ "schemaId", EntitySchemaUId.ToString() },
						{ "processSchemaId", EditSchemaUId.ToString() },
						{ "managerName", EditSchemaManagerName },
						{ "contextKey", ColumnValuesContextKey },
						{ "treeGridId", Page.ColumnValuesTreeGrid.ClientID },
						{ "canChangeColumn", true.ToString().ToLower() },
						{ "insertedRowKey", InsertedColumnValueKey },
						{ "editElementId", EditElementUId.ToString() }
					};
			return true;
		}

		public virtual bool InitSpecifyEntityColumnValuesPageScriptTaskExecute(ProcessExecutingContext context) {
			CreateColumnValuesVds();
			object queryStringValue = Page.Request.QueryString["entitySchemaUId"];
			if (queryStringValue != null) {
				EntitySchemaUId = new Guid(queryStringValue.ToString());
			}
			queryStringValue = Page.Request.QueryString["columnValuesContextKey"];
			if (queryStringValue != null) {
				ColumnValuesContextKey = queryStringValue.ToString();
			}
			queryStringValue = Page.Request.QueryString["insertedColumnValueKey"];
			if (queryStringValue != null) {
				InsertedColumnValueKey = queryStringValue.ToString();
			}
			queryStringValue = Page.Request.QueryString["editElementUId"];
			if (queryStringValue != null) {
				EditElementUId = new Guid(queryStringValue.ToString());
			}
			queryStringValue = Page.Request.QueryString["editSchemaManagerName"];
			if (queryStringValue != null) {
				EditSchemaManagerName = queryStringValue.ToString();
			}
			queryStringValue = Page.Request.QueryString["editSchemaUId"];
			if (queryStringValue != null) {
				EditSchemaUId = new Guid(queryStringValue.ToString());
			}
			return true;
		}

		public virtual bool CancelButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			((Terrasoft.UI.WebControls.Page)Page.AspPage).Close();
			return true;
		}

		public virtual bool ColumnValueEditPageClosedScriptTaskExecute(ProcessExecutingContext context) {
			var insertRowColumnValue = (string)UserConnection.SessionData[InsertedColumnValueKey];
			UserConnection.SessionData.Remove(InsertedColumnValueKey);
			Page.AddScript(insertRowColumnValue);
			return true;
		}

		public virtual bool PageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			DisplayColumnValues();
			InitGridWithNotNullColumns();
			return true;
		}

		public virtual void CreateColumnValuesVds() {
			var vds = new VirtualDataSource() {
				ID = "ColumnValuesVds"
			};
			Page.PageContainer.Controls.Add(vds);
			
			// Set vds Id for calendar tree grid
			Page.ColumnValuesTreeGrid.DataSourceId = vds.ID;
			
			DataSourceStructure vdsStructure = vds.DefStructure;
			
			vdsStructure.PrimaryColumnName = "Id";
			vdsStructure.PrimaryDisplayColumnName = "Name";
			
			var guidDvt = UserConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var maxSizeTextDvt = UserConnection.DataValueTypeManager.GetInstanceByName("MaxSizeText");
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Id",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = guidDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "MetaPath",
				IsVisible = false,
				IsHideable = false,
				IsSortable = false,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Name",
				Caption = CaptionColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
			
			vdsStructure.AddColumn(new DataSourceStructureColumn() {
				Name = "Value",
				Caption = ValueColumnCaption,
				IsVisible = true,
				IsHideable = true,
				IsSortable = true,
				DataValueType = maxSizeTextDvt
			});
		}

		public virtual VirtualDataSource GetColumnValuesVds() {
			return Page.PageContainer.FindControl("ColumnValuesVds") as VirtualDataSource;
		}

		public virtual Dictionary<string, ProcessSchemaParameterValue> GetColumnValues() {
			return UserConnection.SessionData[ColumnValuesContextKey] as Dictionary<string, ProcessSchemaParameterValue>;
		}

		public virtual void DisplayColumnValues() {
			var vds = GetColumnValuesVds();
			vds.Clear();
			
			var columnValues = GetColumnValues();
			if (columnValues == null) {
				return;
			}
			
			foreach (var columnValue in columnValues) {
				Entity row = vds.CreateRow();
				row.SetColumnValue("Id", Guid.NewGuid());
				row.SetColumnValue("MetaPath", columnValue.Key);
				
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
				var column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
				row.SetColumnValue("Name", column.Caption.ToString());
				
				string displayValue = String.IsNullOrEmpty(columnValue.Value.DisplayValue) ?
					columnValue.Value.Value : columnValue.Value.DisplayValue;
				
				row.SetColumnValue("Value", displayValue);
				vds.Add(row);
			}
			
			vds.LoadRows();
		}

		public virtual void InitGridWithNotNullColumns() {
			var columnValues = GetColumnValues();
			
			if (columnValues != null && columnValues.Count > 0) {
				return;
			}
			
			columnValues = new Dictionary<string, ProcessSchemaParameterValue>();
			if (!EntitySchemaUId.Equals(Guid.Empty)) {
				foreach(var columnId in GetNotNullColumnIdList()) {
					var cv = new EntityColumnMappingItem() {
						SchemaUId = EntitySchemaUId,
						ColumnMetaPath = columnId.ToString(),
						Value = new ProcessSchemaParameterValue()
					};
					columnValues[cv.ColumnMetaPath] = cv.Value;
				}
			}
			UserConnection.SessionData[ColumnValuesContextKey] = columnValues;
			DisplayColumnValues();
		}

		public virtual List<Guid> GetNotNullColumnIdList() {
			var result = new List<Guid>();
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			var isActivitySchema = UserConnection.EntitySchemaManager.GetItemByUId(EntitySchemaUId).Name == "Activity";
			foreach(var column in entitySchema.Columns) {
				if (isActivitySchema && entitySchema.PrimaryDisplayColumn.UId == column.UId) {
					continue;
				}
				if (!entitySchema.PrimaryColumn.UId.Equals(column.UId)  && column.IsDBRequirement && !column.HasDefValue) {
					result.Add(column.UId);
				}
			}
			
			return result;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EditButtonClick":
							if (ActivatedEventElements.Contains("EditButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("EditButtonClickStartMessage");
						}
						break;
					case "DeleteButtonClick":
							if (ActivatedEventElements.Contains("DeleteButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("DeleteButtonClickStartMessage");
						}
						break;
					case "OkButtonClick":
							if (ActivatedEventElements.Contains("OkButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("OkButtonClickStartMessage");
						}
						break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("AddButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("AddButtonClickStartMessage");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("InitSpecifyEntityColumnValuesPageStartMessage")) {
							context.QueueTasks.Enqueue("InitSpecifyEntityColumnValuesPageStartMessage");
						}
						break;
					case "CancelButtonClick":
							if (ActivatedEventElements.Contains("CancelButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("CancelButtonClickStartMessage");
						}
						break;
					case "ColumnValueEditPageClosed":
							if (ActivatedEventElements.Contains("ColumnValueEditPageClosedStartMessage")) {
							context.QueueTasks.Enqueue("ColumnValueEditPageClosedStartMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("PageLoadCompleteStartMessage");
						}
						break;
					case "ColumnValuesTreeGridDblClick":
							if (ActivatedEventElements.Contains("ColumnValuesTreeGridDblClickStartMessage1")) {
							context.QueueTasks.Enqueue("ColumnValuesTreeGridDblClickStartMessage1");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("EditElementUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditElementUId", EditElementUId, Guid.Empty);
			}
			if (!HasMapping("EditSchemaManagerName") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaManagerName", EditSchemaManagerName, null);
			}
			if (!HasMapping("EditSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EditSchemaUId", EditSchemaUId, Guid.Empty);
			}
			if (!HasMapping("InsertedColumnValueKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("InsertedColumnValueKey", InsertedColumnValueKey, null);
			}
			if (!HasMapping("DecisionalColumnMetaPath") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DecisionalColumnMetaPath", DecisionalColumnMetaPath, null);
			}
			if (!HasMapping("ColumnValuesContextKey") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("ColumnValuesContextKey", ColumnValuesContextKey, null);
			}
			if (ColumnExplorer != null) {
				if (ColumnExplorer.GetType().IsSerializable ||
					ColumnExplorer.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ColumnExplorer", ColumnExplorer, null);
				}
			}
			if (!HasMapping("IsColumnExplorerCreated") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsColumnExplorerCreated", IsColumnExplorerCreated, false);
			}
			if (!HasMapping("EntitySchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: SpecifyEntityColumnValuesPageEventsProcess

	/// <exclude/>
	public class SpecifyEntityColumnValuesPageEventsProcess : SpecifyEntityColumnValuesPageEventsProcess<Terrasoft.WebApp.SpecifyEntityColumnValuesPageSchemaUserControl>
	{

		public SpecifyEntityColumnValuesPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SpecifyEntityColumnValuesPageSchemaUserControl

	/// <exclude/>
	public partial class SpecifyEntityColumnValuesPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MessagePanel BaseMessagePanel {
			get {
				return (Terrasoft.UI.WebControls.Controls.MessagePanel)PageContainer.FindPageControl("BaseMessagePanel", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout MainControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("MainControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout EditButtonsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("EditButtonsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button AddButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("AddButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button EditButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("EditButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button DeleteButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("DeleteButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.TreeGrid ColumnValuesTreeGrid {
			get {
				return (Terrasoft.UI.WebControls.Controls.TreeGrid)PageContainer.FindPageControl("ColumnValuesTreeGrid", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout2 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout2", true);
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
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
			EditButton.AjaxEvents.Click.Event += EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event += DeleteButtonClick;
			OkButton.AjaxEvents.Click.Event += OkButtonClick;
			CancelButton.AjaxEvents.Click.Event += CancelButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
			EditButton.AjaxEvents.Click.Event -= EditButtonClick;
			DeleteButton.AjaxEvents.Click.Event -= DeleteButtonClick;
			OkButton.AjaxEvents.Click.Event -= OkButtonClick;
			CancelButton.AjaxEvents.Click.Event -= CancelButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SpecifyEntityColumnValuesPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SpecifyEntityColumnValuesPageEventsProcess(UserConnection);
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

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public virtual void EditButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("EditButtonClick");
		}

		public virtual void DeleteButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("DeleteButtonClick");
		}

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
			SchemaName = "SpecifyEntityColumnValuesPage";
		}

		#endregion

	}

	#endregion

	#region Class: SpecifyEntityColumnValuesPageEventsProcessSchema

	/// <exclude/>
	public class SpecifyEntityColumnValuesPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public SpecifyEntityColumnValuesPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SpecifyEntityColumnValuesPageEventsProcessSchema(SpecifyEntityColumnValuesPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SpecifyEntityColumnValuesPageEventsProcess";
			UId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1");
			CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768");
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

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("deeee8e2-632b-45b4-abee-50305e226d44"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsColumnExplorerCreatedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("62a9e29c-4e64-4fc7-93b4-6f4b574cbbf8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"IsColumnExplorerCreated",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnExplorerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7bc3eca0-bc41-4009-96c2-716d2046b0d0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"ColumnExplorer",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateColumnValuesContextKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c33b5338-0ce1-4bc1-9f1c-efd7bfee2b4b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"ColumnValuesContextKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDecisionalColumnMetaPathParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3462dcca-f002-4f07-ba0c-3913c4e369c2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateInsertedColumnValueKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("91d4f3d1-8a74-42ad-be75-b87b404882d0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"InsertedColumnValueKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f2bd021d-6ae6-4197-a9dd-005d66307c52"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EditSchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditSchemaManagerNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dd946c75-7198-4025-a543-3723f5026f4e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EditSchemaManagerName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEditElementUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c515c166-b7da-4f79-a74d-7ec2fdae31bb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EditElementUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateIsColumnExplorerCreatedParameter());
			Parameters.Add(CreateColumnExplorerParameter());
			Parameters.Add(CreateColumnValuesContextKeyParameter());
			Parameters.Add(CreateDecisionalColumnMetaPathParameter());
			Parameters.Add(CreateInsertedColumnValueKeyParameter());
			Parameters.Add(CreateEditSchemaUIdParameter());
			Parameters.Add(CreateEditSchemaManagerNameParameter());
			Parameters.Add(CreateEditElementUIdParameter());
		}

		protected virtual void InitializeOpenColumnEditPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c66a0cac-2065-4705-89aa-9f71db944e9e"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("7d07ec48-9870-4942-9b00-dc62c32f5772"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("57ef2a3f-9d8b-455f-8f37-b42b21ecf1a7"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("5d824b13-8779-4ca3-a6ee-d78f12139e2f"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("3e4a1a2b-d9d3-48ed-ba36-1132ae2034d3"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("1dba0575-f64c-4040-a028-b282fed8b9cc"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("d42e5bf5-da2e-432b-b51f-56015665b4b9"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("ba260934-e24f-438c-b60b-e14a60d3e1cd"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("a89e66c2-ed72-4a53-9465-7d5b11596cbf"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("6fcd2161-d83e-4e81-b4b0-97308c6087c6"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("409becc2-23e8-4d0d-a99f-b6880d78162d"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
				UId = new Guid("1babe34e-c2fa-4f89-9b5b-7c6a457d4e51"),
				ContainerUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeOpenColumnPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("515b517b-8325-4f00-bf51-5885e0cfee32"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("805c4016-2ed6-41f2-ab65-0622e0611d1a"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("04a00a6c-0674-48b9-8b9b-1d2bb9304df7"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("f8875e3b-1e0b-48a6-ae64-60441fccc586"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("dbf14774-11b2-49b6-940e-63134a0186de"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("5b6fd44d-0a99-4c2f-af9b-8af8d01c0c7c"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("053638f6-228b-462d-8419-d290cb9aa635"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("a2887956-5a9e-4087-b215-c6b7f62bd474"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("63bba718-351a-4207-8de1-9cb6457a973f"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("51aa7c7e-6296-442c-b251-52daeaca5dfe"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("3576e8b1-0579-4097-b619-795e49f9db19"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
				UId = new Guid("8edac942-9c4c-4eab-add9-3233662bcf1c"),
				ContainerUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
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
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaSpecifyEntityColumnValueLane1 = CreateSpecifyEntityColumnValueLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaSpecifyEntityColumnValueLane1);
			ProcessSchemaLane schemaSpecifyEntityColumnValuesLane = CreateSpecifyEntityColumnValuesLaneLane();
			schemaLaneSet1.Lanes.Add(schemaSpecifyEntityColumnValuesLane);
			ProcessSchemaEventSubProcess editbuttonclickeventsubprocess = CreateEditButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(editbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess deletebuttonclickeventsubprocess = CreateDeleteButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(deletebuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess addbuttonclickeventsubprocess = CreateAddButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(addbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess initspecifyentitycolumnvaluespageeventsubprocess = CreateInitSpecifyEntityColumnValuesPageEventSubProcessEventSubProcess();
			FlowElements.Add(initspecifyentitycolumnvaluespageeventsubprocess);
			ProcessSchemaEventSubProcess cancelbuttonclickeventsubprocess = CreateCancelButtonClickEventSubProcessEventSubProcess();
			FlowElements.Add(cancelbuttonclickeventsubprocess);
			ProcessSchemaEventSubProcess columnvalueeditpageclosedeventsubprocess = CreateColumnValueEditPageClosedEventSubProcessEventSubProcess();
			FlowElements.Add(columnvalueeditpageclosedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess columnvaluestreegriddblclickstartmessage = CreateColumnValuesTreeGridDblClickStartMessageEventSubProcess();
			FlowElements.Add(columnvaluestreegriddblclickstartmessage);
			ProcessSchemaStartMessageEvent editbuttonclickstartmessage = CreateEditButtonClickStartMessageStartMessageEvent();
			editbuttonclickeventsubprocess.FlowElements.Add(editbuttonclickstartmessage);
			ProcessSchemaScriptTask editbuttonclickscripttask = CreateEditButtonClickScriptTaskScriptTask();
			editbuttonclickeventsubprocess.FlowElements.Add(editbuttonclickscripttask);
			ProcessSchemaUserTask opencolumneditpage = CreateOpenColumnEditPageUserTask();
			editbuttonclickeventsubprocess.FlowElements.Add(opencolumneditpage);
			ProcessSchemaStartMessageEvent deletebuttonclickstartmessage = CreateDeleteButtonClickStartMessageStartMessageEvent();
			deletebuttonclickeventsubprocess.FlowElements.Add(deletebuttonclickstartmessage);
			ProcessSchemaScriptTask deletebuttonclickscripttask = CreateDeleteButtonClickScriptTaskScriptTask();
			deletebuttonclickeventsubprocess.FlowElements.Add(deletebuttonclickscripttask);
			ProcessSchemaStartMessageEvent okbuttonclickstartmessage = CreateOkButtonClickStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(okbuttonclickstartmessage);
			ProcessSchemaScriptTask okbuttonclickscripttask = CreateOkButtonClickScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(okbuttonclickscripttask);
			ProcessSchemaStartMessageEvent addbuttonclickstartmessage = CreateAddButtonClickStartMessageStartMessageEvent();
			addbuttonclickeventsubprocess.FlowElements.Add(addbuttonclickstartmessage);
			ProcessSchemaScriptTask addbuttonclickscripttask = CreateAddButtonClickScriptTaskScriptTask();
			addbuttonclickeventsubprocess.FlowElements.Add(addbuttonclickscripttask);
			ProcessSchemaUserTask opencolumnpage = CreateOpenColumnPageUserTask();
			addbuttonclickeventsubprocess.FlowElements.Add(opencolumnpage);
			ProcessSchemaStartMessageEvent initspecifyentitycolumnvaluespagestartmessage = CreateInitSpecifyEntityColumnValuesPageStartMessageStartMessageEvent();
			initspecifyentitycolumnvaluespageeventsubprocess.FlowElements.Add(initspecifyentitycolumnvaluespagestartmessage);
			ProcessSchemaScriptTask initspecifyentitycolumnvaluespagescripttask = CreateInitSpecifyEntityColumnValuesPageScriptTaskScriptTask();
			initspecifyentitycolumnvaluespageeventsubprocess.FlowElements.Add(initspecifyentitycolumnvaluespagescripttask);
			ProcessSchemaStartMessageEvent cancelbuttonclickstartmessage = CreateCancelButtonClickStartMessageStartMessageEvent();
			cancelbuttonclickeventsubprocess.FlowElements.Add(cancelbuttonclickstartmessage);
			ProcessSchemaScriptTask cancelbuttonclickscripttask = CreateCancelButtonClickScriptTaskScriptTask();
			cancelbuttonclickeventsubprocess.FlowElements.Add(cancelbuttonclickscripttask);
			ProcessSchemaStartMessageEvent columnvalueeditpageclosedstartmessage = CreateColumnValueEditPageClosedStartMessageStartMessageEvent();
			columnvalueeditpageclosedeventsubprocess.FlowElements.Add(columnvalueeditpageclosedstartmessage);
			ProcessSchemaScriptTask columnvalueeditpageclosedscripttask = CreateColumnValueEditPageClosedScriptTaskScriptTask();
			columnvalueeditpageclosedeventsubprocess.FlowElements.Add(columnvalueeditpageclosedscripttask);
			ProcessSchemaStartMessageEvent pageloadcompletestartmessage = CreatePageLoadCompleteStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(pageloadcompletestartmessage);
			ProcessSchemaScriptTask pageloadcompletescripttask = CreatePageLoadCompleteScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(pageloadcompletescripttask);
			ProcessSchemaStartMessageEvent columnvaluestreegriddblclickstartmessage1 = CreateColumnValuesTreeGridDblClickStartMessage1StartMessageEvent();
			columnvaluestreegriddblclickstartmessage.FlowElements.Add(columnvaluestreegriddblclickstartmessage1);
			ProcessSchemaIntermediateThrowMessageEvent editbuttonclickintermediatethrowmessageevent = CreateEditButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			columnvaluestreegriddblclickstartmessage.FlowElements.Add(editbuttonclickintermediatethrowmessageevent);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCaptionColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateValueColumnCaptionLocalizableString());
			LocalizableStrings.Add(CreateSchemaLocalizableString3LocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCaptionColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c791a58d-c168-4bdb-8e71-549ab5bad934"),
				Name = "CaptionColumnCaption",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValueColumnCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f29b8416-93f5-471f-8d2e-614462268c5a"),
				Name = "ValueColumnCaption",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSchemaLocalizableString3LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ec87a0f9-de28-4400-be5e-eac78eeea6ca"),
				Name = "SchemaLocalizableString3",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6294ab62-a285-4931-9fec-5490a4ee29e2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5835265c-5e9a-444e-ae01-f9d154957171"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a91f377e-75ff-4ec7-9d68-24c2a76f51c1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8ea93182-ad48-41f4-84e4-eeaa598fec57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b845b6ad-1b1e-4559-8752-ab93826239df"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("54ade1ec-451e-438e-af9e-49545d7597dd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("17f84f87-4d57-49b1-896d-5d8601bafee8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4bf0e6d9-b9a4-4747-a8f0-f45d84e54711"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6e47ffe7-3e4a-4d37-b2ee-7aac66635504"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("221c4fb0-c91c-422f-bc7a-78afb5308859"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("06a9b241-44af-4a23-8229-0e328eb54379"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96fb6333-c844-4a30-8ef5-d931cf4c7d6f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("3e8a904c-1181-442a-9d03-7103cff16f6c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(170, 408),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3342ff8c-35d5-487a-a237-04b1ebf77905"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("390920d5-9251-4b85-8d0c-e1b8f54e7233"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("06acd764-54f6-41bc-92e1-5cbb2c41baae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94bd142b-7bbb-4de4-bfe8-6eec715c3f2f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36cdfba1-0770-4442-9d8c-df160ed80b7c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("d9a70193-2c4c-401c-8737-c74e07d30798"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(308, 77),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("54ade1ec-451e-438e-af9e-49545d7597dd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("8b4163f9-683b-4950-9fc0-cb61b743f1cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(305, 228),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a91f377e-75ff-4ec7-9d68-24c2a76f51c1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("b4190d55-8b5b-41d5-8d64-67d164940aea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(584, 230),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4896f2e7-7c9a-4df6-8b76-2c293bd1dd59"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fbb58fbb-51d8-40c3-9edd-2838427a4257"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("ae0305e0-e265-4525-a187-6c0a92b25531"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(838, 68),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d19b88d-c8a9-4876-b61f-ac5c37333602"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f166a027-c2f2-412b-bab9-ca14ede82362"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("d81d26e2-5465-42b8-89ed-b676684de2b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CurveCenterPosition = new Point(452, 563),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("891a1917-d849-4bef-886c-7cfa634ce185"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("43c58d43-adc4-47fc-8fbd-451044c27f00"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("32d25c81-8cd8-4564-b2dd-c7fe6b0a2292"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1233, 805),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateSpecifyEntityColumnValueLane1Lane() {
			ProcessSchemaLane schemaSpecifyEntityColumnValueLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b73e5be3-d6f2-4396-821f-cd6c6c291818"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("32d25c81-8cd8-4564-b2dd-c7fe6b0a2292"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"SpecifyEntityColumnValueLane1",
				Position = new Point(29, 616),
				Size = new Size(1204, 189),
				UseBackgroundMode = false
			};
			return schemaSpecifyEntityColumnValueLane1;
		}

		protected virtual ProcessSchemaLane CreateSpecifyEntityColumnValuesLaneLane() {
			ProcessSchemaLane schemaSpecifyEntityColumnValuesLane = new ProcessSchemaLane(this) {
				UId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("32d25c81-8cd8-4564-b2dd-c7fe6b0a2292"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"SpecifyEntityColumnValuesLane",
				Position = new Point(29, 0),
				Size = new Size(1204, 611),
				UseBackgroundMode = false
			};
			return schemaSpecifyEntityColumnValuesLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEditButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEditButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f9faeaf8-d731-48ec-99b4-3810b03e2c6e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EditButtonClickEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(388, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEditButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEditButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b845b6ad-1b1e-4559-8752-ab93826239df"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9faeaf8-d731-48ec-99b4-3810b03e2c6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EditButtonClickStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEditButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("54ade1ec-451e-438e-af9e-49545d7597dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9faeaf8-d731-48ec-99b4-3810b03e2c6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EditButtonClickScriptTask",
				Position = new Point(127, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,93,111,218,48,20,125,38,82,254,131,155,135,42,104,64,251,64,59,170,174,147,166,128,16,90,97,168,192,94,42,52,57,241,165,88,74,236,206,118,202,80,197,127,223,181,147,208,208,129,214,23,39,190,57,231,222,115,191,50,87,0,67,197,217,68,50,32,194,30,119,68,228,105,122,235,123,124,69,194,41,125,130,78,36,211,60,19,63,105,154,131,158,151,248,206,12,82,72,12,56,162,70,72,46,12,57,187,35,151,77,242,234,123,141,210,211,7,233,143,151,75,140,183,35,144,106,112,116,5,38,87,130,172,40,26,236,23,223,243,189,139,11,210,135,21,23,64,80,88,226,124,18,174,137,130,223,57,87,192,124,239,133,170,253,173,136,57,98,26,69,12,193,76,164,153,96,82,149,245,158,107,19,54,111,11,74,6,134,78,169,89,219,196,81,76,167,16,250,24,140,75,123,176,236,204,229,204,40,46,158,28,199,247,134,57,103,165,130,17,67,75,44,101,138,82,10,239,15,165,2,27,24,113,157,185,218,78,169,210,16,86,113,90,68,230,102,79,111,146,243,243,127,85,99,205,132,161,92,232,112,143,115,145,127,60,131,40,64,3,198,141,171,174,53,129,26,9,109,168,72,96,100,227,86,151,133,83,119,132,179,208,16,229,74,129,48,223,18,195,95,192,26,145,103,84,14,199,9,81,42,53,140,65,235,2,24,212,90,90,97,28,132,5,199,249,246,88,56,109,2,54,174,46,97,192,226,155,46,189,186,97,237,36,73,174,219,221,152,94,181,123,16,95,182,33,254,204,86,49,189,238,117,123,189,192,166,141,233,128,50,85,117,92,208,239,176,69,95,19,154,1,249,68,130,95,1,158,174,216,19,216,56,231,205,195,150,157,80,132,125,65,15,6,20,78,137,157,89,148,214,231,88,16,41,168,218,126,209,142,223,34,197,243,107,88,12,118,163,241,74,2,157,172,33,163,35,22,180,200,64,24,110,182,51,103,192,12,107,113,201,174,85,225,159,149,76,176,120,179,26,13,117,252,135,148,81,129,26,149,77,242,128,48,126,179,215,208,9,14,12,252,49,88,24,4,215,55,46,218,127,168,161,77,185,134,78,203,233,37,141,82,142,51,50,234,215,152,74,110,28,233,96,85,208,178,60,145,68,181,68,173,15,44,87,61,29,42,162,53,21,56,86,78,23,210,195,179,247,27,86,111,50,190,222,203,13,168,3,39,188,28,156,7,185,41,234,114,98,146,222,24,128,85,30,164,144,217,172,171,54,149,247,247,125,178,148,157,91,202,242,103,229,182,231,47,150,187,186,115,79,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenColumnEditPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a376fe9c-31a0-420b-a69c-b5e99fdc8916"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f9faeaf8-d731-48ec-99b4-3810b03e2c6e"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"OpenColumnEditPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 37),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenColumnEditPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDeleteButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDeleteButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("af8a8724-d7d4-4205-8cbb-ce2e522f9f2a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"DeleteButtonClickEventSubProcess",
				Position = new Point(442, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(249, 138),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDeleteButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeleteButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4bf0e6d9-b9a4-4747-a8f0-f45d84e54711"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("af8a8724-d7d4-4205-8cbb-ce2e522f9f2a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DeleteButtonClick",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"DeleteButtonClickStartMessage",
				Position = new Point(43, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeleteButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6e47ffe7-3e4a-4d37-b2ee-7aac66635504"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("af8a8724-d7d4-4205-8cbb-ce2e522f9f2a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"DeleteButtonClickScriptTask",
				Position = new Point(141, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,81,193,106,2,49,16,61,239,130,255,48,120,144,93,40,235,7,20,79,10,34,182,139,84,219,139,120,8,155,81,3,187,73,59,153,72,165,244,223,59,49,42,91,60,5,94,222,123,243,230,205,73,17,52,174,13,157,253,80,109,64,15,19,152,35,79,123,72,81,62,15,114,179,135,226,63,109,2,54,180,109,9,63,131,60,35,228,64,22,152,2,10,247,119,144,159,196,149,240,43,24,66,157,188,22,250,106,93,59,174,69,120,67,95,140,231,203,132,189,35,84,205,17,138,168,181,78,35,24,11,43,117,192,170,31,102,67,136,115,50,186,90,99,139,13,163,174,133,233,83,138,40,236,144,213,74,241,81,102,69,143,42,169,182,195,215,43,62,220,85,27,183,102,50,246,112,153,154,205,131,209,215,2,22,58,2,113,211,8,86,27,58,175,20,121,44,110,158,79,224,2,223,185,37,140,70,143,59,74,88,203,202,88,95,220,121,41,92,214,200,135,177,151,130,50,105,40,27,143,225,13,59,119,146,61,25,59,15,123,114,29,4,143,241,28,150,241,155,133,211,111,188,74,236,123,154,50,53,253,46,10,153,105,165,12,227,172,212,226,189,188,51,197,106,219,239,109,154,60,151,120,222,73,53,125,95,177,153,25,255,217,170,243,195,209,251,103,253,3,197,226,28,245,40,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dca5feeb-8d12-44a7-b8f8-2713a198c203"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EventSubProcess4",
				Position = new Point(35, 315),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(211, 124),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOkButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("06a9b241-44af-4a23-8229-0e328eb54379"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dca5feeb-8d12-44a7-b8f8-2713a198c203"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OkButtonClick",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"OkButtonClickStartMessage",
				Position = new Point(29, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOkButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("96fb6333-c844-4a30-8ef5-d931cf4c7d6f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dca5feeb-8d12-44a7-b8f8-2713a198c203"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"OkButtonClickScriptTask",
				Position = new Point(127, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,11,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,157,57,6,49,68,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAddButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAddButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f22246a3-43b4-4174-9f9c-3a1586ec8d03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"AddButtonClickEventSubProcess",
				Position = new Point(35, 154),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(388, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAddButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5835265c-5e9a-444e-ae01-f9d154957171"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f22246a3-43b4-4174-9f9c-3a1586ec8d03"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"AddButtonClickStartMessage",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAddButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a91f377e-75ff-4ec7-9d68-24c2a76f51c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f22246a3-43b4-4174-9f9c-3a1586ec8d03"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"AddButtonClickScriptTask",
				Position = new Point(127, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,77,79,194,64,16,61,67,194,127,216,244,68,35,69,15,128,37,138,137,41,132,52,202,71,4,188,154,109,119,132,77,218,45,217,221,138,132,240,223,157,109,65,22,209,216,195,118,63,222,155,153,247,102,38,107,16,65,150,228,169,152,210,37,52,39,120,4,25,10,165,169,136,33,100,164,71,142,135,69,200,238,106,213,201,57,126,161,32,200,165,4,161,31,99,205,63,192,92,34,71,203,28,46,193,65,146,41,24,129,82,37,200,41,159,94,105,146,195,128,113,109,48,5,132,57,200,189,198,143,252,130,184,136,106,150,69,81,169,128,13,25,230,156,213,29,22,117,91,180,221,101,94,28,199,29,175,21,209,182,231,67,116,227,65,116,203,222,35,218,241,91,190,239,184,152,5,197,129,212,192,172,68,79,176,197,88,99,154,2,185,34,206,155,131,171,9,218,28,195,166,8,238,54,231,217,76,75,46,150,117,247,82,163,89,166,84,34,91,131,84,164,87,171,86,76,89,125,142,246,100,130,202,237,189,42,184,13,82,254,31,234,46,217,33,168,82,217,17,71,197,43,72,105,200,156,6,25,8,205,245,118,86,92,160,58,43,39,217,55,142,248,181,204,98,180,115,102,209,208,165,127,72,41,21,88,163,52,2,207,8,163,211,189,133,142,51,161,225,83,163,41,8,182,92,82,193,247,131,133,214,18,96,40,57,43,106,41,123,110,81,230,135,87,28,4,142,19,19,246,237,60,84,4,43,42,112,2,10,2,210,205,12,89,10,112,251,156,109,64,158,105,225,135,246,189,100,155,178,194,63,250,121,98,0,234,29,36,144,154,252,71,195,14,231,159,142,25,202,30,59,44,65,231,82,148,51,253,5,158,108,18,160,47,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenColumnPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("82dd474c-ee94-46fc-954f-489ae8ad775b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f22246a3-43b4-4174-9f9c-3a1586ec8d03"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"OpenColumnPage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(253, 44),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenColumnPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateInitSpecifyEntityColumnValuesPageEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaInitSpecifyEntityColumnValuesPageEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e9a1fc9b-4ddb-4c0b-b6b0-19e663ed7c6d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b73e5be3-d6f2-4396-821f-cd6c6c291818"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"InitSpecifyEntityColumnValuesPageEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(238, 168),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaInitSpecifyEntityColumnValuesPageEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitSpecifyEntityColumnValuesPageStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3342ff8c-35d5-487a-a237-04b1ebf77905"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9a1fc9b-4ddb-4c0b-b6b0-19e663ed7c6d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"InitSpecifyEntityColumnValuesPageStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 69),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitSpecifyEntityColumnValuesPageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("390920d5-9251-4b85-8d0c-e1b8f54e7233"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9a1fc9b-4ddb-4c0b-b6b0-19e663ed7c6d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"InitSpecifyEntityColumnValuesPageScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(134, 55),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,193,110,194,48,12,134,207,84,234,59,4,78,237,165,47,128,56,85,104,66,19,136,1,227,50,237,16,154,127,44,40,117,181,212,17,171,166,189,251,194,56,80,84,132,200,52,142,145,243,217,159,237,36,183,144,140,188,50,174,164,181,52,14,245,90,213,73,58,140,163,106,179,67,193,226,195,193,54,75,182,154,182,191,113,49,18,115,185,69,182,128,143,212,156,61,157,226,47,3,16,107,110,150,197,59,74,249,60,81,131,87,159,71,191,137,164,147,164,63,18,228,140,73,197,87,28,245,198,231,148,175,64,216,139,7,167,85,7,204,86,213,241,148,164,7,199,239,56,10,242,43,90,125,230,21,49,62,249,17,205,141,154,249,69,216,215,187,34,249,7,71,77,53,44,67,181,202,221,238,56,185,8,255,187,35,148,230,177,65,233,247,29,176,230,51,232,142,91,62,216,29,95,211,84,146,191,101,103,178,68,128,100,135,189,203,252,130,127,73,155,9,155,158,5,59,75,130,173,195,240,7,175,166,181,100,241,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCancelButtonClickEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCancelButtonClickEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("efcd8a87-b7d4-4580-8b3d-56523168c070"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"CancelButtonClickEventSubProcess",
				Position = new Point(281, 317),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(248, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaCancelButtonClickEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCancelButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("94bd142b-7bbb-4de4-bfe8-6eec715c3f2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efcd8a87-b7d4-4580-8b3d-56523168c070"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CancelButtonClick",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"CancelButtonClickStartMessage",
				Position = new Point(43, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCancelButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("36cdfba1-0770-4442-9d8c-df160ed80b7c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efcd8a87-b7d4-4580-8b3d-56523168c070"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"CancelButtonClickScriptTask",
				Position = new Point(141, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,8,73,45,42,74,44,206,79,43,209,11,245,212,11,79,77,114,206,207,43,41,202,207,41,214,11,72,76,79,213,4,17,122,142,197,5,96,142,158,115,78,126,113,170,134,166,53,47,87,81,106,73,105,81,158,66,73,81,105,170,53,0,157,57,6,49,68,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateColumnValueEditPageClosedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaColumnValueEditPageClosedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9cb01c70-7508-426d-aea0-7649a5db5115"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"ColumnValueEditPageClosedEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(442, 156),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(260, 147),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaColumnValueEditPageClosedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValueEditPageClosedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4896f2e7-7c9a-4df6-8b76-2c293bd1dd59"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9cb01c70-7508-426d-aea0-7649a5db5115"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnValueEditPageClosed",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"ColumnValueEditPageClosedStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(43, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateColumnValueEditPageClosedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fbb58fbb-51d8-40c3-9edd-2838427a4257"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9cb01c70-7508-426d-aea0-7649a5db5115"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"ColumnValueEditPageClosedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,204,43,78,45,42,9,202,47,119,206,207,41,205,205,11,75,204,41,77,85,176,85,208,40,46,41,202,204,75,215,12,5,202,58,231,231,229,165,38,151,100,230,231,233,5,167,22,23,3,105,151,196,146,196,104,79,176,206,212,20,36,141,222,169,149,177,214,188,92,184,53,233,5,165,230,230,151,165,106,96,215,171,9,212,27,144,152,158,170,231,152,146,18,156,92,148,89,80,162,129,205,121,32,101,69,169,37,165,69,121,10,37,69,165,169,214,0,208,185,248,233,199,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("abadbf60-9671-4286-8853-8215721ff559"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b73e5be3-d6f2-4396-821f-cd6c6c291818"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(301, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("891a1917-d849-4bef-886c-7cfa634ce185"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("abadbf60-9671-4286-8853-8215721ff559"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"PageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("43c58d43-adc4-47fc-8fbd-451044c27f00"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("abadbf60-9671-4286-8853-8215721ff559"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"PageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,201,44,46,200,73,172,116,206,207,41,205,205,11,75,204,41,77,45,214,208,180,230,229,242,204,203,44,113,47,202,76,9,207,44,201,240,203,47,241,43,205,201,129,168,129,72,23,165,150,148,22,229,41,148,20,149,166,90,3,0,79,112,68,3,67,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateColumnValuesTreeGridDblClickStartMessageEventSubProcess() {
			ProcessSchemaEventSubProcess schemaColumnValuesTreeGridDblClickStartMessage = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8b674369-1f88-45ff-a8e8-d83fa97638b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("97426503-37ad-48c8-8335-cfa8879b80c4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"ColumnValuesTreeGridDblClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 464),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(193, 121),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaColumnValuesTreeGridDblClickStartMessage;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateColumnValuesTreeGridDblClickStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6d19b88d-c8a9-4876-b61f-ac5c37333602"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b674369-1f88-45ff-a8e8-d83fa97638b4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ColumnValuesTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"ColumnValuesTreeGridDblClickStartMessage1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateEditButtonClickIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f166a027-c2f2-412b-bab9-ca14ede82362"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8b674369-1f88-45ff-a8e8-d83fa97638b4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"EditButtonClick",
				ModifiedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				Name = @"EditButtonClickIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(126, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCreateColumnValuesVdsMethod());
			Methods.Add(CreateGetColumnValuesVdsMethod());
			Methods.Add(CreateGetColumnValuesMethod());
			Methods.Add(CreateDisplayColumnValuesMethod());
			Methods.Add(CreateInitGridWithNotNullColumnsMethod());
			Methods.Add(CreateGetNotNullColumnIdListMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f694c636-33c3-4f36-80a7-81fa8aff3cc9"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fdad2abf-793c-47b8-9d5b-1f96bce13c64"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("33b0c46c-7151-4d93-a9f7-56bdda121cdd"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("39daf1d6-d7a1-488c-8ffa-9d8b4a9e023b"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("47e68a52-7f55-4a56-9f47-557c120d3000"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "UIControls",
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768")
			});
		}

		protected virtual SchemaMethod CreateCreateColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("942607e4-1808-46ec-825a-a637fe35fd2a"),
				Name = "CreateColumnValuesVds",
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,77,111,194,48,12,61,175,191,34,234,169,72,83,249,1,136,195,70,37,214,3,19,82,89,239,94,99,88,164,52,69,73,202,96,19,255,125,78,90,209,143,113,3,113,105,147,103,251,61,63,199,7,208,236,192,13,155,51,133,223,44,23,218,214,32,19,176,144,85,181,46,48,154,176,223,224,41,77,40,30,46,42,89,151,42,7,89,163,201,185,9,131,243,44,88,195,14,99,247,89,84,202,130,80,168,99,119,210,149,52,241,11,231,17,81,79,102,65,48,157,178,12,173,23,74,57,219,86,154,21,32,81,113,18,183,26,145,237,180,224,13,87,95,100,67,161,37,69,226,174,31,170,158,59,154,56,77,136,182,195,51,171,235,194,214,26,93,176,187,52,185,9,110,47,16,85,245,51,226,181,22,37,232,83,35,251,14,165,171,9,83,30,206,174,166,37,194,236,37,140,178,221,63,116,188,228,102,87,11,158,28,44,193,31,6,53,141,66,97,97,69,165,188,5,239,106,115,218,227,10,20,121,213,241,18,109,170,140,5,85,224,235,201,209,68,225,146,8,66,26,153,35,43,225,152,137,31,220,224,209,222,196,185,234,120,28,245,208,25,189,82,99,39,114,11,112,101,162,109,212,47,66,111,64,207,180,22,38,23,70,124,74,7,109,65,26,244,216,155,224,8,99,48,171,180,29,129,131,238,9,111,71,23,156,239,211,226,10,45,172,193,126,221,191,209,225,179,220,171,95,191,69,164,182,128,189,123,92,130,218,83,147,220,94,70,102,136,240,159,151,11,214,179,210,98,143,113,226,21,134,86,60,244,80,35,127,10,86,92,39,216,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesVdsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ea1fecb3-c00a-4c75-8379-c5a324342dda"),
				Name = "GetColumnValuesVds",
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "VirtualDataSource"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,199,49,10,128,48,12,5,208,171,148,78,186,244,2,142,21,103,65,232,254,209,32,133,152,64,154,220,95,186,60,120,70,30,38,233,196,75,101,82,85,28,93,200,202,209,229,153,51,229,37,87,229,248,164,129,131,70,123,70,94,19,70,106,221,60,192,59,28,151,134,221,180,253,42,16,51,176,78,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a1eb8d6f-cacd-4c5d-9c6f-25d50fae95c8"),
				Name = "GetColumnValues",
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "Dictionary<string, ProcessSchemaParameterValue>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,29,203,49,10,128,48,12,70,225,171,244,0,226,5,20,23,187,185,8,162,139,56,132,242,163,5,155,66,146,130,222,222,226,244,150,239,9,172,8,187,85,33,99,102,70,176,152,185,93,160,90,235,201,104,31,243,93,18,111,116,23,104,37,134,199,38,188,135,35,117,62,254,156,228,237,213,36,242,217,184,89,114,168,243,18,46,36,154,73,40,193,32,255,61,116,31,0,37,148,5,109,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDisplayColumnValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f029a357-fb86-426f-821f-149fb68dbdbb"),
				Name = "DisplayColumnValues",
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,209,78,195,32,20,125,46,95,65,246,68,19,195,7,184,44,198,213,102,105,116,211,56,183,119,82,238,54,146,22,22,160,91,26,227,191,123,161,81,169,155,190,0,23,206,185,231,220,203,61,9,75,79,210,209,25,93,128,47,76,211,181,122,43,154,14,220,86,58,150,79,9,190,241,162,1,97,67,64,78,136,174,19,208,37,45,192,212,142,178,49,106,70,117,215,52,57,125,39,153,5,223,89,61,37,31,132,236,140,5,81,31,40,251,149,150,42,61,82,137,188,82,123,229,123,106,205,25,69,163,43,36,123,120,53,231,32,153,225,61,95,143,172,176,73,37,39,55,116,209,41,201,87,112,14,59,203,255,130,46,193,139,23,225,15,72,72,148,249,35,244,129,65,178,224,16,162,131,117,125,128,86,160,135,141,3,91,24,173,161,246,202,104,94,38,175,75,161,197,30,44,199,222,84,218,121,161,107,152,247,155,74,178,20,132,113,200,253,83,59,230,76,37,2,123,56,13,78,231,253,151,73,118,197,226,181,162,86,162,133,239,130,120,33,142,209,232,155,89,123,171,244,126,104,6,201,92,140,168,84,238,216,136,126,248,128,25,29,48,188,114,43,252,184,103,91,182,71,223,143,116,135,245,33,97,229,244,142,100,217,37,102,72,121,75,255,103,71,47,215,170,136,27,150,145,26,140,141,195,25,184,151,146,33,39,143,227,20,46,158,140,144,56,18,97,12,63,1,149,144,56,174,218,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitGridWithNotNullColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b289bc45-2909-449d-aec7-63a477b4719c"),
				Name = "InitGridWithNotNullColumns",
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,49,111,194,48,16,133,103,252,43,204,130,28,9,69,221,83,88,2,66,168,45,66,74,233,130,24,172,112,20,75,137,157,218,231,180,81,197,127,239,197,73,17,97,96,177,45,223,119,122,239,157,93,75,203,115,83,248,82,127,200,194,131,227,51,190,2,76,111,110,68,148,48,166,78,92,12,176,241,140,107,95,20,124,50,25,180,199,169,241,26,249,156,63,69,252,151,141,44,160,183,58,97,23,198,238,68,52,124,243,133,202,81,25,45,109,243,236,208,42,253,57,229,91,107,114,112,46,203,207,80,202,173,180,178,4,4,27,186,230,173,145,214,199,120,169,81,97,211,49,187,245,49,94,126,121,89,56,177,242,138,206,101,133,77,20,196,79,198,130,204,207,162,190,70,92,31,185,210,109,190,141,193,13,185,79,251,219,87,229,80,116,77,163,64,215,189,195,78,169,195,222,100,85,145,199,53,66,41,58,116,116,181,64,248,157,169,105,91,239,27,1,41,10,158,9,250,183,17,191,155,44,36,22,81,0,67,192,94,243,193,8,68,68,240,37,161,229,118,154,251,188,142,135,74,135,86,170,142,67,153,232,11,205,127,231,192,166,70,107,8,35,143,51,82,160,125,33,81,238,111,31,155,16,132,31,124,129,230,112,181,219,85,18,182,80,174,42,100,115,247,55,254,0,231,17,165,55,65,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotNullColumnIdListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8dbb5491-14ac-4f9e-8cdc-803cf49c64a4"),
				Name = "GetNotNullColumnIdList",
				CreatedInSchemaUId = new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"),
				CreatedInPackageId = new Guid("53c384bc-84c9-40fb-bbfe-0f8b5f1bc768"),
				ResultValueTypeName = "List<Guid>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,205,78,195,48,16,132,207,241,83,184,61,84,233,197,47,16,130,212,54,85,137,84,16,2,149,251,202,217,80,75,241,166,245,79,80,132,250,238,56,63,64,42,122,226,56,158,157,111,199,178,27,48,220,160,245,149,227,41,39,252,224,123,101,221,221,206,171,226,62,94,38,172,9,54,146,83,174,125,149,71,212,16,134,14,22,205,166,38,66,233,84,77,98,59,113,31,129,224,29,141,216,161,203,201,58,32,137,235,246,144,23,241,116,40,232,17,172,236,42,48,154,127,192,29,234,219,96,241,4,26,121,154,242,249,55,122,158,176,178,54,8,242,24,119,59,101,93,121,77,92,209,213,181,196,166,63,182,75,254,201,34,85,242,248,79,181,197,226,58,240,108,148,6,211,102,202,158,42,104,135,184,8,13,186,221,242,71,245,188,72,214,33,73,30,19,22,93,6,252,236,22,235,23,34,182,103,15,149,141,167,160,174,193,168,115,155,173,95,240,236,149,65,29,64,157,51,27,173,7,176,25,150,111,80,121,28,118,15,111,43,86,69,49,165,245,77,46,140,25,116,222,208,248,1,146,47,47,6,210,26,12,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SpecifyEntityColumnValuesPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("309d586b-8d38-4f74-8dcb-21e6b6586da1"));
		}

		#endregion

	}

	#endregion

}

